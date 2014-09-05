using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.AdvancedDrawing;


class AnimatedGIFExample
{
	static void Main(string[] args)
	{
		//http://www.graphicsmill.com/docs/gm/loading-and-saving-animated-gifs.htm

		WriteAnimatedGif();
		ReadAnimatedGif();
		ResizesAnimatedGif();
	}


	/// <summary>
	/// Writes simple animated image in GIF format
	/// </summary>
	private static void WriteAnimatedGif()
	{
		using (var writer = new GifWriter("../../../../_Output/WriteAnimatedGif.gif"))
		{
			writer.Width = 400;
			writer.Height = 100;
			writer.FrameOptions.Delay = 25;

			for (int i = 0; i < 400; i+=25)
			{
				var bitmap = new Bitmap(400, 100, PixelFormat.Format24bppRgb, RgbColor.Yellow);

				using (var graphics = bitmap.GetAdvancedGraphics())
				{
					graphics.FillEllipse(new SolidBrush(RgbColor.Green), new System.Drawing.RectangleF(i, 0, 100, 100));
				}

				bitmap.ColorManagement.Convert(PixelFormat.Format8bppIndexed);

				Pipeline.Run(bitmap + writer);
			}
		}	
	}


	/// <summary>
	/// Reads frames of animated image in GIF format
	/// </summary>
	private static void ReadAnimatedGif()
	{
		using (var reader = new GifReader("../../../../_Output/WriteAnimatedGif.gif"))
		{
			for (int i = 0; i < reader.Frames.Count; i++)
			{
				using (var bitmap = reader.Frames[i].GetBitmap())
				{
					bitmap.Save("../../../../_Output/ReadAnimatedGif_" + i + ".gif");
				}
			}
		}
	}


	/// <summary>
	/// Resizes animated image in GIF format
	/// </summary>
	private static void ResizesAnimatedGif()
	{
		using (var reader = new GifReader("../../../../_Output/WriteAnimatedGif.gif"))
		using (var writer = new GifWriter("../../../../_Output/ResizesAnimatedGif.gif"))
		{
			//Copy general properties of the source file
			writer.BackgroundIndex = reader.BackgroundEntryIndex;
			writer.Palette = reader.Palette;
			writer.PlaybackCount = reader.PlaybackCount;

			for (int i = 0; i < reader.Frames.Count; i++)
			{
				//Read a frame
				using (var frame = (GifFrame)reader.Frames[i])
				using (var bitmap = frame.GetBitmap())
				{
					//Preserve the original palette
					ColorPalette palette = bitmap.Palette;
					//Preserve the original pixel format
					PixelFormat pixelFormat = bitmap.PixelFormat;

					//Convert the bitmap to a non-indexed format
					bitmap.ColorManagement.Convert(Aurigma.GraphicsMill.ColorSpace.Rgb, true, false);

					//Resize the bitmap in a high quality mode
					bitmap.Transforms.Resize(frame.Width / 2, frame.Height / 2,
						Aurigma.GraphicsMill.Transforms.ResizeInterpolationMode.High);

					//Return to the indexed format
					bitmap.Palette = palette;
					bitmap.ColorManagement.Convert(pixelFormat);

					//Copy frame delay
					writer.FrameOptions.Delay = frame.Delay;

					//Add the frame
					Pipeline.Run(bitmap + writer);
				}
			}
		}
	}
}
