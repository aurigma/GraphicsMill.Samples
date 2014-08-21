using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Codecs;


class MatrixTransformExample
{
	static void Main(string[] args)
	{
		TransformCoordinates();
	}


	private static void TransformCoordinates()
	{
		using (var bitmap = new Bitmap(600, 300, PixelFormat.Format24bppRgb, RgbColor.White))
		{
			using (var graphics = bitmap.GetAdvancedGraphics())
			{
				//Move cordinate system
				var matrix1 = new System.Drawing.Drawing2D.Matrix();
				matrix1.Translate(bitmap.Width / 2, bitmap.Height / 2);

				graphics.Transform = matrix1;

				DrawEllipseAndText(graphics, 30);

				//Move, shear and rotate cordinate system
				var matrix2 = new System.Drawing.Drawing2D.Matrix();
				matrix2.Translate(bitmap.Width / 2, bitmap.Height / 2);
				matrix2.Shear(0.5f, 0.1f);
				matrix2.Rotate(30f);

				graphics.Transform = matrix2;

				DrawEllipseAndText(graphics, 255);
			}

			bitmap.Save("../../../../_Output/TransformCoordinates.png");
		}
	}


	private static void DrawEllipseAndText(Graphics graphics, byte alpha)
	{
		graphics.DrawEllipse(new Pen(new RgbColor(0x01, 0x97, 0xfd, alpha), 20f), -280, -135, 560, 270);
		
		var text = new PlainText("Graphics Mill", graphics.CreateFont("Arial", "Bold", 80f));
		text.Alignment = TextAlignment.Center;
		text.Position = new System.Drawing.PointF(0f, text.GetBlackBox().Height / 2);
		text.Brush = new SolidBrush(new RgbColor(0xd4, 0x00, 0x00, alpha));
		
		graphics.DrawText(text);
	}
}

