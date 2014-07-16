using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.AdvancedDrawing.Art;
using Aurigma.GraphicsMill.Codecs;


class DoublePathTextExample
{
	static void Main(string[] args)
	{
		RenderDoublePathText();
	}


	private static void RenderDoublePathText()
	{
		using (var bitmap = new Bitmap(400, 250, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
		{
			using (var graphics = bitmap.GetAdvancedGraphics())
			using (var doublePathText = new DoublePathText("Double Path Text", graphics.CreateFont("Arial", 36)))
			{
				doublePathText.Brush = new SolidBrush(new RgbColor(0x41, 0x41, 0x41));
				doublePathText.Alignment = TextAlignment.Center;

				doublePathText.TopPath.MoveTo(26, 71);
				doublePathText.TopPath.CurveTo(128, 162, 186, 21, 367, 64);

				doublePathText.BottomPath.MoveTo(26, 152);
				doublePathText.BottomPath.CurveTo(121, 177, 183, 68, 368, 157);

				graphics.DrawText(doublePathText);
			}

			bitmap.Save("../../../../Output/DoublePathText.png");
		}
	}
}
