using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;

internal class FormattedTextExample
{
    private static void Main(string[] args)
    {
        DrawFormattedText();
    }

    private static void DrawFormattedText()
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
                Rectangle = new System.Drawing.RectangleF(20f, 20f, 560f, 360f)
            };

            graphics.DrawText(boundedText);

            bitmap.Save("../../../../_Output/DrawFormattedText.png");
        }
    }
}