using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Codecs;

internal class WritingEPSAndPDFExample
{
    private static void Main(string[] args)
    {
        WriteBitmapToPdf();
        WriteBitmapToPdfMemoryFriendly();
        WriteBitmapToEps();
        WriteBitmapToEpsMemoryFriendly();

        WriteRasterAndVectorGraphicsToPdf();
        WriteRasterAndVectorGraphicsToEps();

        CreateBusinessCard();
    }

    /// <summary>
    /// Saves bitmap to PDF format
    /// </summary>
    private static void WriteBitmapToPdf()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            bitmap.Save("../../../../_Output/WritePdf.pdf");
        }
    }

    /// <summary>
    /// Saved bitmap to PDF format using memory-friendly Pipeline API
    /// </summary>
    private static void WriteBitmapToPdfMemoryFriendly()
    {
        using (var reader = new JpegReader("../../../../_Input/Chicago.jpg"))
        using (var writer = new PdfWriter("../../../../_Output/WritePdfMemoryFriendly.pdf"))
        {
            Pipeline.Run(reader + writer);
        }
    }

    /// <summary>
    /// Saves bitmap to EPS format
    /// </summary>
    private static void WriteBitmapToEps()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            bitmap.Save("../../../../_Output/WriteEps.eps");
        }
    }

    /// <summary>
    /// Saved bitmap to EPS format using memory-friendly Pipeline API
    /// </summary>
    private static void WriteBitmapToEpsMemoryFriendly()
    {
        using (var reader = new JpegReader("../../../../_Input/Chicago.jpg"))
        using (var writer = new EpsWriter("../../../../_Output/WriteEpsMemoryFriendly.eps"))
        {
            Pipeline.Run(reader + writer);
        }
    }

    /// <summary>
    /// Saves raster and vector graphics to PDF format
    /// </summary>
    private static void WriteRasterAndVectorGraphicsToPdf()
    {
        using (var writer = new PdfWriter("../../../../_Output/WriteRasterAndVectorGraphicsToPdf.pdf"))
        {
            // Reduce output file size
            writer.Compression = CompressionType.Jpeg;
            writer.Quality = 80;

            writer.AddPage(800, 650, RgbColor.White);

            using (var graphics = writer.GetGraphics())
            {
                // Draw bitmap
                using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
                {
                    graphics.DrawImage(bitmap, 100f, 100f);
                }

                // Draw rectangle
                graphics.DrawRectangle(new Pen(RgbColor.Gray, 4f), 50f, 50f, 700f, 550f);

                // Draw text
                var font = graphics.CreateFont("Arial", 56f);
                var text = new PlainText("Confidential", font, new SolidBrush(RgbColor.OrangeRed),
                    400f, 340f, TextAlignment.Center);
                graphics.DrawText(text);
            }
        }
    }

    /// <summary>
    /// Saves raster and vector graphics to EPS format
    /// </summary>
    private static void WriteRasterAndVectorGraphicsToEps()
    {
        using (var writer = new EpsWriter("../../../../_Output/WriteRasterAndVectorGraphicsToPdf.eps", 800, 650))
        using (var graphics = writer.GetGraphics())
        {
            // Draw bitmap
            using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
            {
                graphics.DrawImage(bitmap, 100f, 100f);
            }

            // Draw rectangle
            graphics.DrawRectangle(new Pen(RgbColor.Gray, 4f), 50f, 50f, 700f, 550f);

            // Draw text
            var font = graphics.CreateFont("Arial", 56f);
            var text = new PlainText("Confidential", font, new SolidBrush(RgbColor.OrangeRed),
                400f, 340f, TextAlignment.Center);
            graphics.DrawText(text);
        }
    }

    /// <summary>
    /// Creates business card in PDF format
    /// </summary>
    private static void CreateBusinessCard()
    {
        using (var writer = new PdfWriter("../../../../_Output/CreateBusinessCard.pdf"))
        {
            int width = 350;
            int height = 200;

            using (var graphics = writer.GetGraphics())
            {
                // Front side
                writer.AddPage(width, height, RgbColor.White);

                var blueBrush = new SolidBrush(RgbColor.DeepSkyBlue);

                // Draw circle
                graphics.DrawEllipse(new Pen(RgbColor.DeepSkyBlue, 2f), 15f, 20f, 30f, 30f);

                // Draw text
                var font = graphics.CreateFont("Arial", 18f);
                var text = new PlainText("Front side", font, new SolidBrush(RgbColor.Gray),
                    95f, 41f, TextAlignment.Center);
                graphics.DrawText(text);

                font = graphics.CreateFont("Arial", 16f);
                text = new PlainText(@"John Doe
<span style=""color:gray;font-size:16pt"">General Manager</span>", font, blueBrush, 335f, 100f, TextAlignment.Right);

                graphics.DrawText(text);

                graphics.FillRectangle(blueBrush, 0, height - 50, width, 50);

                font = graphics.CreateFont("Arial", 12f);
                text = new PlainText(@"123.456.7890
info@website.com", font, new SolidBrush(RgbColor.White), 15f, 170f, TextAlignment.Left);

                graphics.DrawText(text);

                text = new PlainText(@"335 Cloverfield Blvd
Charlington, NY 10123", font, new SolidBrush(RgbColor.White), 200f, 170f, TextAlignment.Left);

                graphics.DrawText(text);

                // Back side
                writer.AddPage(width, height, RgbColor.DeepSkyBlue);

                graphics.DrawEllipse(new Pen(RgbColor.White, 3f), 65f, 72f, 55f, 55f);

                font = graphics.CreateFont("Arial", 36);

                text = new PlainText("Back side", font, new SolidBrush(RgbColor.White), 140f, 112f, TextAlignment.Left);
                graphics.DrawText(text);
            }
        }
    }
}