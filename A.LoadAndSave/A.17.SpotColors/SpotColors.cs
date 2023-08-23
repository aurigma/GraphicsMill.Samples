using System.Linq;

using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Codecs;

internal class SpotColors
{
    // Ink has a name as well as an alternative color
    private static Ink ink = new Ink("PANTONE Red 032 C", new RgbColor(243, 40, 55));

    // Spot color is specified with a tint of the ink
    private static SpotColor spotColor = new SpotColor(ink, 255);

    private static void Main(string[] args)
    {
        DrawOnPdfWithSpotColor();

        SaveSpotImageToPdf();

        DrawSpotOnCmyk();

        ReplaceProcessColor();
    }

    /// <summary>
    /// Fills a rectangle with a PANTONE color
    /// </summary>
    private static void DrawOnPdfWithSpotColor()
    {
        using (var pdfWriter = new PdfWriter(@"../../../../_Output/VectorSpot.pdf"))
        using (var gr = pdfWriter.GetGraphics())
        {
            pdfWriter.AddPage(500, 500, 72, 72);

            gr.FillRectangle(new SolidBrush(spotColor), 10, 10, 400, 400);

            pdfWriter.Close();
        }
    }

    /// <summary>
    /// Saves an image with a spot color to PDF
    /// </summary>
    private static void SaveSpotImageToPdf()
    {
        using (var spotImage = new Bitmap(300, 300, PixelFormat.Format8bppSpot, RgbColor.White))
        {
            spotImage.Ink = ink;

            using (var gr = spotImage.GetAdvancedGraphics())
            {
                var brush = new RadialGradientBrush();
                brush.ColorStops = new ColorStop[]
                {
                    new ColorStop() { Color = RgbColor.White, Position = 0.0f },
                    new ColorStop() { Color = RgbColor.Black, Position = 1.0f },
                };
                brush.StartPoint = new System.Drawing.PointF(gr.Width / 2, gr.Height / 2);
                brush.EndPoint = brush.StartPoint;

                brush.StartRadius = 0;
                brush.EndRadius = 300;

                gr.FillRectangle(brush, 0, 0, gr.Width, gr.Height);
            }

            using (var pdfWriter = new PdfWriter(@"../../../../_Output/SpotImage.pdf"))
            {
                Pipeline.Run(spotImage + pdfWriter);

                pdfWriter.Close();
            }
        }
    }

    /// <summary>
    /// Draws a text and an image on the spot channel, using the existing CMYK image as a background
    /// </summary>
    private static void DrawSpotOnCmyk()
    {
        using (var bgImageReader = ImageReader.Create(@"../../../../_Input/Copenhagen_CMYK.jpg"))
        using (var pdfWriter = new PdfWriter(@"../../../../_Output/SpotWithProcessColors.pdf"))
        {
            Pipeline.Run(bgImageReader + pdfWriter);

            using (var gr = pdfWriter.GetGraphics())
            using (var spotImage = new Bitmap(@"../../../../_Input/Sheep.gif"))
            {
                var text = new PlainText("Spot color text", gr.CreateFont("Arial", 150))
                {
                    Position = new System.Drawing.PointF(gr.Width / 2, gr.Height / 2),
                    Alignment = TextAlignment.Center,
                    Brush = new SolidBrush(spotColor),
                };

                gr.DrawText(text);

                // After these operations, the loaded image reflects a spot color
                spotImage.ColorManagement.Convert(PixelFormat.Format16bppAspot);
                spotImage.Ink = ink;

                spotImage.Transforms.Resize(400, 400, Aurigma.GraphicsMill.Transforms.ResizeInterpolationMode.Linear, Aurigma.GraphicsMill.Transforms.ResizeMode.Fit);

                gr.DrawImage(spotImage, gr.Width - spotImage.Width, gr.Height - (spotImage.Height / 3));
            }

            pdfWriter.Close();
        }
    }

    /// <summary>
    /// Converts the specified process color into a spot color saving graphics container to the PDF format
    /// </summary>
    private static void ReplaceProcessColor()
    {
        using (var reader = new PdfReader(@"../../../../_Input/Seal.pdf"))
        using (var gc = reader.Frames[0].GetContent())
        using (var writer = new PdfWriter(@"../../../../_Output/Process2SpotColor.pdf"))
        using (var gr = writer.GetGraphics())
        {
            writer.AddPage(gc.Width, gc.Height, gc.DpiX, gc.DpiY);

            gc.ReplaceProcessColors(spotColor);

            gr.DrawContainer(gc, 0, 0);
        }
    }
}

public static class Extensions
{
    public static bool IsBlack(this Color color)
    {
        var grayColor = (GrayscaleColor)color.Convert(PixelFormat.Format8bppGrayscale);

        return grayColor.L < 20;
    }

    public static void ReplaceProcessColors(this GraphicsContainer container, SpotColor spotColor)
    {
        foreach (var item in container.Items.OfType<ShapeItem>())
        {
            if (item.Brush != null && item.Brush is SolidBrush && (item.Brush as SolidBrush).Color.IsBlack())
            {
                item.Brush = new SolidBrush(spotColor);
            }
        }

        foreach (var item in container.Items.OfType<ContainerItem>())
        {
            item.GraphicsContainer.ReplaceProcessColors(spotColor);
        }
    }
}