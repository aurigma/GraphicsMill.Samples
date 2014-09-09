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

    /// <summary>
    /// Draws different art texts
    /// </summary>
	private static void RenderArtText()
	{
		using (var bitmap = new Bitmap(600, 400, PixelFormat.Format24bppRgb, new RgbColor(0xff, 0xff, 0xff, 0xff)))
        using (var graphics = bitmap.GetAdvancedGraphics())
		{			
			var font = graphics.CreateFont("Arial", 48);
			var brush = new SolidBrush(new RgbColor(0x41, 0x41, 0x41));

            var texts = new Text[]
            {
                new BridgeText("Bridge Text", font, brush)
                {
                    Center = new System.Drawing.PointF(150f, 50f),
                    Bend = 0.2f
                },
                new BulgeText("Bulge Text", font, brush)
                {
                    Center = new System.Drawing.PointF(150f, 150f),
                    Bend = 0.2f
                },
                new PinchText("Pinch Text", font, brush)
                {
                    Center = new System.Drawing.PointF(150f, 250f),
                    Bend = 0.2f
                },
                new RoofText("Roof Text", font, brush)
                {
                    Center = new System.Drawing.PointF(150f, 350f), 
                    Bend = 0.2f
                },
                new ValleyText("Valley Text", font)
                {
                    Brush = new SolidBrush(RgbColor.Yellow),
				    Pen = new Pen(RgbColor.Red, 2f),
                    Center = new System.Drawing.PointF(450f, 50f), 
                    Bend = 0.2f
                },
                new WedgeText("Wedge Text", font, brush)
                {
                    Center = new System.Drawing.PointF(450f, 150f),
                    LeftScale = 2.0f, 
                    RightScale = 0.7f, 
                    Tilt = -0.3f,
                    Effect = new Shadow(new RgbColor(80, 80, 80), 5, 4, 4)
                },
                new RoundText("Round Text", font, brush)
                {
                    Center = new System.Drawing.PointF(450f, 300f), 
                    Bend = 1,
                    Effect = new Glow(new RgbColor(0x66, 0xaf, 0xe9), 5)
                }
            };

            foreach (var text in texts)
            {
                graphics.DrawText(text);
            }
            			
			bitmap.Save("../../../../_Output/ArtText.png");
		}
	}
}

