using System;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill;


class DrawingExample
{
	static void Main(string[] args)
	{
		DrawUsingAdvancedGraphics();
		DrawUsingGdiPlusGraphics();
	}

    /// <summary>
	/// Draws inside pipeline with AdvancedDrawing
	/// </summary>	
	private static void DrawUsingAdvancedGraphics()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Venice.jpg"))
		using (var drawer = new Aurigma.GraphicsMill.Drawing.AdvancedGraphicsDrawer())
		using (var writer = ImageWriter.Create("../../../../_Output/DrawUsingAdvancedGraphics.jpg"))
		{
			drawer.Draw += (sender, e) =>
			{
				var pen = new Pen(System.Drawing.Color.GreenYellow, 30);

				e.Graphics.DrawRectangle(pen, new System.Drawing.RectangleF(15, 15, e.Width - 30, e.Height - 30));
			};

			Aurigma.GraphicsMill.Pipeline.Run(reader + drawer + writer);
		}
	}


    /// <summary>
    /// Draws inside pipeline with GdiPlus
    /// </summary>	
	private static void DrawUsingGdiPlusGraphics()
	{
		using (var generator = new ImageGenerator(640, 480, PixelFormat.Format24bppRgb, RgbColor.White))
		using (var drawer = new Aurigma.GraphicsMill.Drawing.GdiPlusGraphicsDrawer())
		using (var writer = ImageWriter.Create("../../../../_Output/DrawUsingGdiPlusGraphics.jpg"))
		{
			drawer.Draw += (sender, e) =>
			{
				var pen = new System.Drawing.Pen(System.Drawing.Color.Blue, 20);
				pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

				e.Graphics.DrawRectangle(pen, new System.Drawing.Rectangle(20, 20, e.Width - 40, e.Height - 40));
			};

			Aurigma.GraphicsMill.Pipeline.Run(generator + drawer + writer);
		}
	}
}

