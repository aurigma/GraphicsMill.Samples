using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Codecs;


class GraphicsPathExample
{
	static void Main(string[] args)
	{
		DrawGraphicsPath();
	}


	private static void DrawGraphicsPath()
	{
		using (var bitmap = new Bitmap(640, 480, PixelFormat.Format24bppRgb, RgbColor.White))
		{
			using (var graphics = bitmap.GetAdvancedGraphics())
			{
				var path = new Path();

				var font = graphics.CreateFont("Arial", "Bold", 40f);
				var text = new PlainText("GraphicsMill", font);
				text.Alignment = TextAlignment.Center;
				var blackBox = text.GetBlackBox();
				text.Position = new System.Drawing.PointF(blackBox.Width, blackBox.Height * 2.3f);

				path.DrawEllipse(0, 0, blackBox.Width * 2, blackBox.Height * 4);
				path.DrawText(text);


				graphics.DrawPath(new Pen(RgbColor.Red, 2f), path);

				//Translate coordinates to center and rotate
				var matrix = new System.Drawing.Drawing2D.Matrix();
				matrix.Translate(bitmap.Width / 2 - blackBox.Width, bitmap.Height / 2 - blackBox.Height * 2);
				matrix.RotateAt(10, new System.Drawing.PointF(blackBox.Width, blackBox.Height * 2));

				graphics.Transform = matrix;

				graphics.DrawPath(new Pen(RgbColor.Green, 2f), path);	
			}

			bitmap.Save("../../../../_Output/DrawPath.tif");
		}
	}
}

