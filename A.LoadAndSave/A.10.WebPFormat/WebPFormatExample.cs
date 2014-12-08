using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.AdvancedDrawing;


class WebPFormatExample
{
	static void Main(string[] args)
	{
		WriteWebP();
		WriteWebPMemoryFriendly();

		WriteAnimatedWebP();
	}


	/// <summary>
	/// Reads image in JPEG format and saves to WebP format
	/// </summary>
	private static void WriteWebP()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			var webPSettings = new WebPSettings(100);

			bitmap.Save("../../../../_Output/WriteWebP.webp", webPSettings);
		}
	}


	/// <summary>
	/// Reads image in JPEG format and saves to WebP format using memory-friendly Pipeline API
	/// </summary>
	private static void WriteWebPMemoryFriendly()
	{
		using (var reader = new JpegReader("../../../../_Input/Chicago.jpg"))
		using (var writer = new WebPWriter("../../../../_Output/WriteWebPMemoryFriendly.webp"))
		{
			Pipeline.Run(reader + writer);
		}
	}


	/// <summary>
	/// Writes simple animated image in WebP format
	/// </summary>
	private static void WriteAnimatedWebP()
	{
		using (var writer = new WebPWriter("../../../../_Output/WriteAnimatedWebP.webp"))
		{
			writer.FrameOptions.Delay = 250;

			for (int i = 0; i < 400; i += 25)
			{
				var bitmap = new Bitmap(400, 100, PixelFormat.Format24bppRgb, RgbColor.Yellow);

				using (var graphics = bitmap.GetAdvancedGraphics())
				{
					graphics.FillEllipse(new SolidBrush(RgbColor.Green), new System.Drawing.RectangleF(i, 0, 100, 100));
				}

				Pipeline.Run(bitmap + writer);
			}
		}
	}
}

