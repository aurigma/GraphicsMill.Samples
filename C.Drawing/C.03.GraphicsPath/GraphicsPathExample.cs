using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;

internal class GraphicsPathExample
{
    private static void Main(string[] args)
    {
        DrawPath();
    }

    /// <summary>
    /// Draws path on Graphics
    /// </summary>
    private static void DrawPath()
    {
        using (var bitmap = new Bitmap(640, 480, PixelFormat.Format24bppRgb, RgbColor.White))
        using (var graphics = bitmap.GetAdvancedGraphics())
        {
            var path = CreatePath(graphics);

            graphics.DrawPath(new Pen(RgbColor.Red, 2f), path);

            // Translate coordinates and rotate
            var matrix = new System.Drawing.Drawing2D.Matrix();
            matrix.Translate(bitmap.Width / 3, bitmap.Height / 3);
            matrix.Rotate(30);
            graphics.Transform = matrix;

            graphics.DrawPath(new Pen(RgbColor.Green, 2f), path);

            bitmap.Save("../../../../_Output/DrawPath.tif");
        }
    }

    private static Path CreatePath(Graphics graphics)
    {
        var path = new Path();

        var font = graphics.CreateFont("Arial", "Bold", 40f);

        var text = new PlainText("GraphicsMill", font)
        {
            Alignment = TextAlignment.Center,
        };

        var blackBox = text.GetBlackBox(graphics.FontRegistry, graphics.DpiX, graphics.DpiY);
        text.Position = new System.Drawing.PointF(blackBox.Width, blackBox.Height * 2.3f);

        path.DrawEllipse(0, 0, blackBox.Width * 2, blackBox.Height * 4);
        path.DrawText(text, graphics.FontRegistry, graphics.DpiX, graphics.DpiY);

        return path;
    }
}