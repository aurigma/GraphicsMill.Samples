using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;

internal class ClippingPathExample
{
    private static void Main(string[] args)
    {
        DrawWithClippingPaths();
    }

    /// <summary>
    /// Draws on Graphics with clipping paths
    /// </summary>
    private static void DrawWithClippingPaths()
    {
        using (var background = new Bitmap(600, 450, PixelFormat.Format24bppRgb, RgbColor.White))
        using (var graphics = background.GetAdvancedGraphics())
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            var path = new Path();
            path.DrawEllipse(0f, 0f, background.Width, background.Height);

            graphics.ClippingPaths.Add(path);
            graphics.DrawImage(bitmap, 0f, 0f);

            graphics.DrawLine(new Pen(new RgbColor(255, 255, 0, 127), 20),
                0f, 0f, background.Width, background.Height);

            background.Save("../../../../_Output/RestrictDrawingRegion.png");
        }
    }
}