using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.AdvancedDrawing.Art;
using Aurigma.GraphicsMill.AdvancedDrawing.Effects;
using Aurigma.GraphicsMill.Codecs;


class PlainAndBoundedTextExample
{
	static void Main(string[] args)
	{
		DrawPlainAndBoundedText();
        DrawMultilinePlainText();
	}

    /// <summary>
    /// Draws plain and bounded texts with different parameters.
    /// </summary>
	private static void DrawPlainAndBoundedText() 
	{
		using (var bitmap = new Bitmap(400, 250, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
        using (var graphics = bitmap.GetAdvancedGraphics())
		{
			var brush = new SolidBrush(new RgbColor(0x41, 0x41, 0x41));
            var dummyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras elementum quam ac nisi varius gravida. Mauris ornare, dolor et scelerisque volutpat, enim urna commodo odio, consequat fermentum sem arcu sit amet nisl. Aliquam tincidunt id neque in gravida. Mauris mollis est vulputate suscipit facilisis.";
            var boundedTextRect = new System.Drawing.RectangleF(200f, 20f, 180f, 150f);

            var texts = new Text[]
            {
                new PlainText("Horizontal", graphics.CreateFont("Times New Roman", 22f), brush)
                {
                    Position = new System.Drawing.PointF(50f, 38f)
                },
                new PlainText("Vertical", graphics.CreateFont("Arial", 24f), brush)
                {
                    Vertical = true,
                    Position = new System.Drawing.PointF(20f, 10f),
                    Effect = new Glow(new RgbColor(0x66, 0xaf, 0xe9), 5)
                },
                new BoundedText(dummyText, graphics.CreateFont("Verdana", 14f), brush)
			    {
				    Alignment = TextAlignment.Center,
				    Rectangle = boundedTextRect
			    }
            };

			foreach (var text in texts)
			{
				graphics.DrawText(text);
			}

			graphics.DrawRectangle(new Pen(new RgbColor(0x4e, 0xb5, 0xe6)), boundedTextRect);

			bitmap.Save("../../../../_Output/PlainAndBoundedText.png");
		}
	}


    /// <summary>
    /// Draws multiline plain text.
    /// </summary>
    private static void DrawMultilinePlainText()
    {
        using (var bitmap = new Bitmap(600, 250, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
        using (var graphics = bitmap.GetAdvancedGraphics())
        {
            var brush = new SolidBrush(new RgbColor(0x41, 0x41, 0x41));
            var dummyText = @"Lorem ipsum dolor sit amet,
consectetur adipiscing elit. Cras
elementum quam ac nisi varius gravida.
Mauris ornare, dolor et scelerisque volutpat, enim
urna commodo odio,
consequat fermentum sem arcu sit amet nisl.
Aliquam tincidunt id neque
in gravida. Mauris mollis est
vulputate suscipit facilisis.";

            var text = new PlainText(dummyText, graphics.CreateFont("Verdana", 20f), brush)
            {
                Position = new System.Drawing.PointF(10f, 30f)
            };

            graphics.DrawText(text);

            bitmap.Save("../../../../_Output/DrawMultilinePlainText.png");
        }
    }
}
