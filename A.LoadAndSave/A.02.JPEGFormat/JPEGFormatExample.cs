using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class JPEGFormatExample
{
	static void Main(string[] args)
	{
		ReadWriteJpeg();
		ReadWriteJpegMemoryFriendly();

		RemoveAlphaAndWriteJpeg();
		RemoveAlphaAndWriteJpegMemoryFriendly();
	}



	/// <summary>
	/// Reads and writes image in JPEG format
	/// </summary>
	private static void ReadWriteJpeg()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Transforms.Flip(FlipType.Vertical);

			var jpegSettings = new JpegSettings();
			jpegSettings.Quality = 90;
			jpegSettings.UseSubsampling = false;
			jpegSettings.IsProgressive = true;

			bitmap.Save("../../../../_Output/ReadWriteJpeg.jpg", jpegSettings);

			//The simplified syntax
			//bitmap.Save("../../../../_Output/ReadWriteJpeg.jpg", new JpegSettings(90, false, true));
		}

	}


	/// <summary>
	/// Reads and writes image in JPEG format using memory-friendly Pipeline API
	/// </summary>
	private static void ReadWriteJpegMemoryFriendly()
	{
		using (var reader = new JpegReader("../../../../_Input/Chicago.jpg"))
		using (var flip = new Flip(FlipType.Vertical))
		using (var writer = new JpegWriter("../../../../_Output/ReadWriteJpegMemoryFriendly.jpg"))
		{
			writer.Quality = 90;
			writer.UseSubsampling = false;
			writer.IsProgressive = true;
			Pipeline.Run(reader + flip + writer);
		}
	}


	/// <summary>
	/// Removes alpha channel and saves to JPEG format
	/// </summary>
	private static void RemoveAlphaAndWriteJpeg()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Stamp.png"))
		{
			if (bitmap.HasAlpha)
			{
				bitmap.Channels.RemoveAlpha(RgbColor.White);
			}

			bitmap.Save("../../../../_Output/RemoveAlphaAndWriteJpeg.jpg");
		}
	}


	/// <summary>
	/// Removes alpha channel and saves to JPEG format using memory-friendly Pipeline API
	/// </summary>
	private static void RemoveAlphaAndWriteJpegMemoryFriendly()
	{
		using (var reader = new PngReader(@"Images\watermark.png"))
		using (var removeAlpha = new RemoveAlpha(Aurigma.GraphicsMill.RgbColor.White))
		using (var writer = new JpegWriter("../../../../_Output/RemoveAlphaAndWriteJpegMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + removeAlpha + writer);
		}
	}
}

