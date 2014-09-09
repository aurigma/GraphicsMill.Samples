using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class DrawImageExamples
{
	static void Main(string[] args)
	{
		DrawImage();
	}


	/// <summary>
	/// Draws image
	/// </summary>
	private static void DrawImage()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Venice.jpg"))
		using (var watermark = new Bitmap("../../../../_Input/Stamp.png"))
        using (var graphics = bitmap.GetAdvancedGraphics())
		{
		    graphics.DrawImage(watermark, 10, bitmap.Height - watermark.Height - 40);

			bitmap.Save("../../../../_Output/DrawImage.jpg");
		}
	}
}

