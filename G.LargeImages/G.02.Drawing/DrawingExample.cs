using System;


class DrawingExample
{
	static void Main(string[] args)
	{
		DrawUsingAdvancedGraphics();
		DrawUsingGdiPlusGraphics();
	}


	private static void DrawUsingAdvancedGraphics()
	{
		using (var reader = Aurigma.GraphicsMill.Codecs.ImageReader.Create("../../../../_Input/Venice.jpg"))
		using (var drawer = new Aurigma.GraphicsMill.Drawing.AdvancedGraphicsDrawer())
		using (var writer = Aurigma.GraphicsMill.Codecs.ImageWriter.Create("../../../../_Output/DrawUsingAdvancedGraphics.jpg"))
		{
			drawer.Draw += delegate(object sender, Aurigma.GraphicsMill.Drawing.AdvancedGraphicsDrawEventArgs e)
			{
				var pen = new Aurigma.GraphicsMill.AdvancedDrawing.Pen(System.Drawing.Color.GreenYellow, 30);

				e.Graphics.DrawRectangle(pen, new System.Drawing.Rectangle(15, 15, e.Width - 30, e.Height - 30));
			};

			Aurigma.GraphicsMill.Pipeline.Run(reader + drawer + writer);
		}
	}


	private static void DrawUsingGdiPlusGraphics()
	{
		using (var generator = new Aurigma.GraphicsMill.ImageGenerator(640, 480, Aurigma.GraphicsMill.PixelFormat.Format24bppRgb, 
			Aurigma.GraphicsMill.RgbColor.White))
		using (var drawer = new Aurigma.GraphicsMill.Drawing.GdiPlusGraphicsDrawer())
		using (var writer = Aurigma.GraphicsMill.Codecs.ImageWriter.Create("../../../../_Output/DrawUsingGdiPlusGraphics.jpg"))
		{
			drawer.Draw += delegate(object sender, Aurigma.GraphicsMill.Drawing.GdiPlusGraphicsDrawEventArgs e)
			{
				var pen = new System.Drawing.Pen(System.Drawing.Color.Blue, 20);
				pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

				e.Graphics.DrawRectangle(pen, new System.Drawing.Rectangle(20, 20, e.Width - 40, e.Height - 40));
			};

			Aurigma.GraphicsMill.Pipeline.Run(generator + drawer + writer);
		}
	}
}

