using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.AdvancedDrawing.Art;
using Aurigma.GraphicsMill.AdvancedDrawing.Effects;
using Aurigma.GraphicsMill.Codecs;


class ArtTextExample
{
	static void Main(string[] args)
	
	{
		RenderArtText();
	}


	private static void RenderArtText()
	{
		using (var bitmap = new Bitmap(600, 400, PixelFormat.Format24bppRgb, new RgbColor(0xff, 0xff, 0xff, 0xff)))
		{
			using (var graphics = bitmap.GetAdvancedGraphics())
			{
				var font = graphics.CreateFont("Arial", 48);
				var brush = new SolidBrush(new RgbColor(0x41, 0x41, 0x41));

				using (var bridgeText = new BridgeText("Bridge Text", font, brush, new System.Drawing.PointF(150f, 50f), 0.2f))
				{
					graphics.DrawText(bridgeText);
				}
				
				using (var bulgeText = new BulgeText("Bulge Text", font, brush, new System.Drawing.PointF(150f, 150f), 0.2f))
				{
					graphics.DrawText(bulgeText);
				}

				using (var pinchText = new PinchText("Pinch Text", font, brush, new System.Drawing.PointF(150f, 250f), 0.2f))
				{
					graphics.DrawText(pinchText);
				}

				using (var roofText = new RoofText("Roof Text", font, brush, new System.Drawing.PointF(150f, 350f), 0.2f))
				{
					graphics.DrawText(roofText);
				}				 

				using (var valleyText = new ValleyText("Valley Text", font, new System.Drawing.PointF(450f, 50f), 0.2f))
				{
					valleyText.Brush = new SolidBrush(RgbColor.Yellow);
					valleyText.Pen = new Pen(RgbColor.Red, 2f);
					graphics.DrawText(valleyText);
				}

				using (var wedgeText = new WedgeText("Wedge Text", font, brush, new System.Drawing.PointF(450f, 150f), 2.0f, 0.7f, -0.3f))
				{
					wedgeText.Effect = new Shadow(new RgbColor(80, 80, 80), 5, 4, 4);

					graphics.DrawText(wedgeText);
				}

				using (var roundText = new RoundText("Round Text", font, brush, new System.Drawing.PointF(450f, 300f), 1f))
				{
					roundText.Effect = new Glow(new RgbColor(0x66, 0xaf, 0xe9), 5);

					graphics.DrawText(roundText);
				}
			}

			bitmap.Save("../../../../Output/ArtText.png");
		}
	}
}

