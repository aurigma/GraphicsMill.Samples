using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Codecs;


class ClippingPathExample
{
	static void Main(string[] args)
	{
		RestrictDrawingRegion();
	}


	private static void RestrictDrawingRegion()
	{
		using (var background = new Bitmap(600, 450, PixelFormat.Format24bppRgb, RgbColor.White))
		{
			using (var graphics = background.GetAdvancedGraphics())
			{
				var path = new Path();	
				path.DrawEllipse(0f, 0f, background.Width, background.Height);

				graphics.ClippingPaths.Add(path);


				using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
				{
					graphics.DrawImage(bitmap, 0f, 0f);
				}

				//graphics.DrawLine(new Pen(new RgbColor(255, 255, 0, 127), 20f),
				//	0f, 0f, background.Width, background.Height);
			}

			background.Save("../../../../_Output/RestrictDrawingRegion.png");				
		}
	}
}

