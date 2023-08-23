using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.AdvancedDrawing.Art;
using Aurigma.GraphicsMill.Codecs;

internal class PDFAndEPSOutputExample
{
    private static void Main(string[] args)
    {
        GenerateRgbPdf();
        GenerateCmykEps();
    }

    /// <summary>
    /// Generates PDF file with two pages.
    /// </summary>
    private static void GenerateRgbPdf()
    {
        var dpi = 300f;

        var unitFactory = new UnitFactory(dpi);

        using (var pdfWriter = new PdfWriter("../../../../_Output/PDFAndEPSOutput.pdf"))
        using (var graphics = pdfWriter.GetGraphics())
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            bitmap.DpiX = dpi;
            bitmap.DpiY = dpi;

            // Front side 3.5"×2.5" size
            pdfWriter.AddPage(unitFactory.Inch(3.5f), unitFactory.Inch(2.0f), dpi, dpi);

            {
                // Rectangle
                var pen = new Pen(RgbColor.Red, unitFactory.Point(1));

                graphics.DrawRectangle(
                    pen,
                    unitFactory.Inch(0.125f),
                    unitFactory.Inch(0.125f),
                    unitFactory.Inch(3.5f - (0.125f * 2)),
                    unitFactory.Inch(2 - (0.125f * 2)));

                // Image
                graphics.DrawImage(
                    bitmap,
                    new System.Drawing.RectangleF(
                    unitFactory.Inch(0.25f),
                    unitFactory.Inch(0.75f),
                    unitFactory.Inch(0.25f + (0.5f * (float)bitmap.Height / (float)bitmap.Width)),
                    unitFactory.Inch(1.25f)));

                // Text
                var font = graphics.CreateFont("Arial", 32f);
                var text = new PlainText("Front Side", font, new SolidBrush(RgbColor.Navy))
                {
                    Alignment = TextAlignment.Left,
                    Position = new System.Drawing.PointF(unitFactory.Inch(1.125f), unitFactory.Inch(1.125f)),
                };

                graphics.DrawText(text);
            }

            // Back side    3.5"×2.5" size
            pdfWriter.AddPage(unitFactory.Inch(3.5f), unitFactory.Inch(2.0f), dpi, dpi);

            {
                // Pen 0.5pt width
                var pen = new Pen(RgbColor.Blue, unitFactory.Point(0.5f));

                graphics.DrawRectangle(
                    pen,
                    unitFactory.Inch(0.125f),
                    unitFactory.Inch(0.125f),
                    unitFactory.Inch(3.5f - (0.125f * 2)),
                    unitFactory.Inch(2 - (0.125f * 2)));

                // Artistic (bridge) text
                var font = graphics.CreateFont("Times New Roman", "Italic", 24f);
                var bridgeText = new BridgeText("Back Side", font, new SolidBrush(RgbColor.Green))
                {
                    Bend = 0.2f,
                    Center = new System.Drawing.PointF(unitFactory.Inch(3.5f / 2), unitFactory.Inch(1f)),
                };
                graphics.DrawText(bridgeText);
            }
        }
    }

    /// <summary>
    /// Generates CMYK EPS
    /// </summary>
    public static void GenerateCmykEps()
    {
        var dpi = 300f;

        var unitFactory = new UnitFactory(dpi);

        using (var epsWriter = new EpsWriter("../../../../_Output/PDFAndEPSOutput.eps", unitFactory.Inch(3.5f), unitFactory.Inch(2.0f), dpi, dpi))
        using (var graphics = epsWriter.GetGraphics())
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            // Pen 1pt width
            var pen = new Pen(new CmykColor(0, 255, 255, 0), unitFactory.Point(1.0f));

            // Rectangle
            graphics.DrawRectangle(
                pen,
                unitFactory.Inch(0.125f),
                unitFactory.Inch(0.125f),
                unitFactory.Inch(3.5f - (0.125f * 2)),
                unitFactory.Inch(2 - (0.125f * 2)));

            // Image
            graphics.DrawImage(
                bitmap,
                new System.Drawing.RectangleF(
                    unitFactory.Inch(0.25f),
                    unitFactory.Inch(0.75f),
                    unitFactory.Inch(0.25f + (0.5f * (float)bitmap.Height / (float)bitmap.Width)),
                    unitFactory.Inch(1.25f)));

            // Text
            var font = graphics.CreateFont("Arial", 32f);
            var text = new PlainText("Front Side", font, new SolidBrush(RgbColor.Navy))
            {
                Alignment = TextAlignment.Left,
                Position = new System.Drawing.PointF(unitFactory.Inch(1.125f), unitFactory.Inch(1.125f)),
            };
            graphics.DrawText(text);
        }
    }
}