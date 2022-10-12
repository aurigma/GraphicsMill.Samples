using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;

internal class TextAutofitExample
{
    private static void Main(string[] args)
    {
        FitTextToArea();
    }

    /// <summary>
    /// Demonstrates how to fit the largest possible text inside PathBoundedText area.
    /// </summary>
    private static void FitTextToArea()
    {
        using (var bitmap = new Bitmap(400, 400, PixelFormat.Format24bppRgb, RgbColor.White))
        using (var graphics = bitmap.GetAdvancedGraphics())
        {
            var text = new Text();

            text.String = "Since 2001, Aurigma have helped software developers add imaging functionality to their applications in a variety of industries. Our image processing Software Development Kit for .NET, Graphics Mill, is a truly powerful product we are proud to have developed."; ;
            text.CharStyle.PostScriptName = "Verdana";

            var shapeTextFrame = new ShapeTextFrame();

            shapeTextFrame.Shape = new Path();
            shapeTextFrame.Shape.DrawEllipse(0, 0, graphics.Width, graphics.Height);

            shapeTextFrame.CopyfittingMode = CopyfittingMode.Fill;

            text.Frames.Add(shapeTextFrame);
                        
            graphics.DrawPath(new Pen(RgbColor.Blue), shapeTextFrame.Shape);
            graphics.DrawText(text);

            bitmap.Save("../../../../_Output/FitTextToArea.png");
        }
    }
}