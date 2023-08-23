using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;

internal class FormattedTextExample
{
    private static void Main(string[] args)
    {
        DrawColoredText();
        DrawSubSupText();
    }

    /// <summary>
    /// Draws multicolor text.
    /// </summary>
    private static void DrawColoredText()
    {
        using (var bitmap = new Bitmap(600, 400, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
        using (var graphics = bitmap.GetAdvancedGraphics())
        {
            var brush = new SolidBrush(RgbColor.Black);

            var dummyText = @"Lorem ipsum dolor sit <span style='color:red;'>amet</span>, consectetur adipiscing elit. " +
                @"<span style='bold:true;underline:true;color:rgb(0,0,255)'>Cras</span> elementum quam ac nisi varius gravida. Mauris ornare, " +
                @"<span style='font-name:Times New Roman;font-size:60pt;pen-color:green;pen-width:1px;color:yellow;'>dolor</span> et scelerisque " +
                @"volutpat, <span style='italic:true;color:gray;'>enim urna commodo odio, <span style='color:green;'>consequat</span> fermentum sem arcu</span> sit amet nisl. " +
                @"Aliquam tincidunt id neque in gravida. Mauris mollis est vulputate suscipit facilisis.";

            var boundedText = new BoundedText(dummyText, graphics.CreateFont("Verdana", 26f), brush)
            {
                Rectangle = new System.Drawing.RectangleF(20f, 20f, 560f, 360f),
            };

            graphics.DrawText(boundedText);

            bitmap.Save("../../../../_Output/DrawColoredText.png");
        }
    }

    /// <summary>
    /// Draws subscript and superscript text.
    /// </summary>
    private static void DrawSubSupText()
    {
        using (var bitmap = new Bitmap(200, 200, PixelFormat.Format24bppRgb, RgbColor.White))
        using (var gr = bitmap.GetAdvancedGraphics())
        {
            var text = new PlainText("X<span style='sup:true;sup-position:0.333;sup-size:0.583'>2</span>\nX<span style='sub:true;sub-position:0.333;sub-size:0.583'>2</span>", gr.CreateFont("Verdana", 50))
            {
                Position = new System.Drawing.PointF(30, 80),
            };

            gr.DrawText(text);

            bitmap.Save("../../../../_Output/DrawSubSupText.png");
        }
    }
}