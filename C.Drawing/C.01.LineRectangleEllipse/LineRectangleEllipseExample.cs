using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;


class LineRectangleEllipseExample
{
	static void Main(string[] args)
	{
		DrawOnRgbImage();
		DrawOnCmykImage();
		DrawOnGrayscaleImage();
		DrawOnExtendedRgbImage();
	}


	/// <summary>
	/// Draws geometric primitives on RGB image
	/// </summary>
	private static void DrawOnRgbImage()
	{
		using (var bitmap = new Bitmap(640, 480, PixelFormat.Format24bppRgb, RgbColor.White))
        using (var graphics = bitmap.GetAdvancedGraphics())
		{
			var redPen = new Pen(RgbColor.Red, 5f);
			graphics.DrawRectangle(redPen, 20, 20, bitmap.Width - 40, bitmap.Height - 40);

			var blueBrush = new SolidBrush(new RgbColor(0, 0, 255));
			graphics.FillRectangle(blueBrush, 60, 60, bitmap.Width - 120, bitmap.Height - 120);

			var blackPen = new Pen(RgbColor.Black, 2f);
			graphics.DrawLine(blackPen, 80, 80, bitmap.Width - 80, bitmap.Height - 80);

			bitmap.Save("../../../../_Output/DrawOnRgbImage.tif");
		}
	}


	/// <summary>
	/// Draws geometric primitives on CMYK image
	/// </summary>
	private static void DrawOnCmykImage()
	{
		using (var bitmap = new Bitmap(640, 480, PixelFormat.Format32bppCmyk, new CmykColor(0, 0, 0, 0)))
        using (var graphics = bitmap.GetAdvancedGraphics())
		{			
			var greenPen = new Pen(new CmykColor(230, 23, 204, 40), 7f);

			graphics.DrawEllipses(greenPen, new System.Drawing.RectangleF[] {									
					new System.Drawing.RectangleF(20, 20, bitmap.Width - 40, bitmap.Height - 40),
					new System.Drawing.RectangleF(80, 80, bitmap.Width - 160, bitmap.Height - 160)
				});

			var redPen = new Pen(new CmykColor(20, 230, 197, 32, 127), 20f);

			graphics.DrawBezier(redPen, new System.Drawing.PointF(0, 0), new System.Drawing.PointF(100, 480),
				new System.Drawing.PointF(540, 0), new System.Drawing.PointF(640, 480));

			bitmap.Save("../../../../_Output/DrawOnCmykImage.tif");
		}
	}

	/// <summary>
	/// Draws geometric primitives on grayscale image
	/// </summary>
	private static void DrawOnGrayscaleImage()
	{
		using (var bitmap = new Bitmap(640, 480, PixelFormat.Format8bppGrayscale, new GrayscaleColor(255)))
        using (var graphics = bitmap.GetAdvancedGraphics())
		{			
			var pen = new Pen(new GrayscaleColor(180), 10f);

			graphics.DrawPolygon(pen, new System.Drawing.PointF[] {
				new System.Drawing.PointF(210f, 445f),
				new System.Drawing.PointF(307f, 456f),
				new System.Drawing.PointF(549f, 208f),
				new System.Drawing.PointF(509f, 118f),
				new System.Drawing.PointF(173f, 30f),
				new System.Drawing.PointF(114f, 114f)
			});

			bitmap.Save("../../../../_Output/DrawOnGrayscaleImage.tif");
		}
	}


	/// <summary>
	/// Draws geometric primitives on RGB image with extended precision per channel
	/// </summary>
	private static void DrawOnExtendedRgbImage()
	{
		using (var bitmap = new Bitmap(640, 480, PixelFormat.Format64bppArgb, new Rgb16Color(65535, 65535, 65535, 65535)))
        using (var graphics = bitmap.GetAdvancedGraphics())
		{
			var redPen = new SolidBrush(new Rgb16Color(65535, 0, 0));

			graphics.FillPolygon(redPen, new System.Drawing.PointF[] {
				new System.Drawing.PointF(320f, 40f),
				new System.Drawing.PointF(40f, 460f),
				new System.Drawing.PointF(600f, 420f)
			});

			bitmap.Save("../../../../_Output/DrawOnExtendedRgbImage.tif");
		}
	}
}

