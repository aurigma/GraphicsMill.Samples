using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;

internal class DoublePathTextExample
{
    private static void Main(string[] args)
    {
        DrawDoublePathText();
    }

    /// <summary>
    /// Draws DoublePathText
    /// </summary>
    private static void DrawDoublePathText()
    {
        using (var bitmap = new Bitmap(400, 250, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
        using (var graphics = bitmap.GetAdvancedGraphics())
        {
            var doublePathText = new DoublePathText("Double Path Text", graphics.CreateFont("Arial", 36))
            {
                Brush = new SolidBrush(new RgbColor(0x41, 0x41, 0x41)),
                ParagraphStyle = new ParagraphStyle() { Alignment = TextAlignment.Center },
            };

            doublePathText.TopPath.MoveTo(26, 71);
            doublePathText.TopPath.CurveTo(128, 162, 186, 21, 367, 64);

            doublePathText.BottomPath.MoveTo(26, 152);
            doublePathText.BottomPath.CurveTo(121, 177, 183, 68, 368, 157);

            graphics.DrawText(doublePathText);

            bitmap.Save("../../../../_Output/DoublePathText.png");
        }
    }
}