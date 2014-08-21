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
		RenderSimpleAndBoundedText();
	}


	private static void RenderSimpleAndBoundedText() 
	{
		using (var bitmap = new Bitmap(400, 250, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
		{
			using (var graphics = bitmap.GetAdvancedGraphics())
			{

				var brush = new SolidBrush(new RgbColor(0x41, 0x41, 0x41));

				using (var plainHorizontalText = new PlainText("Horizontal", graphics.CreateFont("Times New Roman", 22f), brush))
				{
					plainHorizontalText.Position = new System.Drawing.PointF(50f, 38f);
					graphics.DrawText(plainHorizontalText);
				}


				using (var plainVerticalText = new PlainText("Vertical", graphics.CreateFont("Arial", 24f), brush))
				{
					plainVerticalText.Vertical = true;
					plainVerticalText.Position = new System.Drawing.PointF(20f, 10f);
					plainVerticalText.Effect = new Glow(new RgbColor(0x66, 0xaf, 0xe9), 5);
					graphics.DrawText(plainVerticalText);
				}


				var rect = new System.Drawing.RectangleF(200f, 20f, 180f, 150f);
				
				using (var boundedText = new BoundedText(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras elementum quam ac nisi varius gravida. Mauris ornare, dolor et scelerisque volutpat, enim urna commodo odio, consequat fermentum sem arcu sit amet nisl. Aliquam tincidunt id neque in gravida. Mauris mollis est vulputate suscipit facilisis.",
					graphics.CreateFont("Verdana", 14f), brush))
				{
					boundedText.Alignment = TextAlignment.Center;
					boundedText.Rectangle = rect;
					graphics.DrawText(boundedText);
				}

				graphics.DrawRectangle(new Pen(new RgbColor(0x4e, 0xb5, 0xe6)), rect);
			}

			bitmap.Save("../../../../_Output/PlainAndBoundedText.png");
		}
	}
}
