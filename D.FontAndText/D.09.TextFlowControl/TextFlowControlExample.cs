using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;

internal class TextFlowControlExample
{
    private static void Main(string[] args)
    {
        DrawTextWrappedAroundPath();
        DrawPathBoundedText();
    }

    /// <summary>
    /// Draws text wrapped around path
    /// </summary>
    private static void DrawTextWrappedAroundPath()
    {
        using (var bitmap = new Bitmap(400, 400, PixelFormat.Format24bppRgb, RgbColor.White))
        using (var graphics = bitmap.GetAdvancedGraphics())
        {
            var dummyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do " +
                "eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim " +
                "veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo " +
                "consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum " +
                "dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, " +
                "sunt in culpa qui officia deserunt mollit anim id est laborum.";

            var boundedText = new BoundedText(dummyText, graphics.CreateFont("Verdana", 18f), new SolidBrush(RgbColor.Black))
            {
                Rectangle = new System.Drawing.RectangleF(20f, 20f, 360f, 360f),
            };

            // Adding paths which you need to wrap with the text
            var wrappingPath = new Path();
            wrappingPath.DrawEllipse(200, 80, 200, 200);
            boundedText.WrappingPaths.Add(wrappingPath);

            graphics.DrawText(boundedText);

            // Drawing frames around text blocks (for demonstration purposes)
            graphics.FillPath(new SolidBrush(RgbColor.LightGreen), wrappingPath);
            graphics.DrawRectangle(new Pen(RgbColor.Red), boundedText.Rectangle);

            bitmap.Save("../../../../_Output/DrawTextWrappedAroundPath.png");
        }
    }

    /// <summary>
    /// Draw text which flows from one area to another
    /// </summary>
    private static void DrawPathBoundedText()
    {
        using (var bitmap = new Bitmap(600, 300, PixelFormat.Format24bppRgb, RgbColor.White))
        using (var graphics = bitmap.GetAdvancedGraphics())
        {
            var dummyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do " +
                "eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim " +
                "veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo " +
                "consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum " +
                "dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, " +
                "sunt in culpa qui officia deserunt mollit anim id est laborum.";

            var boundingPath = new Path();

            var pathBoundedText = new PathBoundedText(dummyText, graphics.CreateFont("Verdana", 18f), new SolidBrush(RgbColor.Black));

            // Adding text areas. When the first text area runs out of space,
            // text will automatically flow to the next one.
            var boundingPath1 = new Path();
            boundingPath1.DrawRectangle(20, 20, 260, 260);
            pathBoundedText.BoundingPaths.Add(boundingPath1);

            var boundingPath2 = new Path();
            boundingPath2.DrawRectangle(320, 20, 260, 260);
            pathBoundedText.BoundingPaths.Add(boundingPath2);

            // Adding paths which you need to wrap with the text
            var wrappingPath = new Path();
            wrappingPath.DrawEllipse(200, 100, 200, 100);
            pathBoundedText.WrappingPaths.Add(wrappingPath);

            graphics.DrawText(pathBoundedText);

            // Drawing frames around text blocks (for demonstration purposes)
            graphics.FillPath(new SolidBrush(RgbColor.LightGreen), wrappingPath);

            var pen = new Pen(RgbColor.Red);
            graphics.DrawPath(pen, boundingPath1);
            graphics.DrawPath(pen, boundingPath2);

            graphics.DrawLine(new Pen(RgbColor.Blue, 2f), 280f, 280f, 320f, 20f);

            bitmap.Save("../../../../_Output/DrawPathBoundedText.png");
        }
    }
}