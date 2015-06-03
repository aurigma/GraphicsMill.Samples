using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class LoadingAndSavingImagesExample
{
	static void Main(string[] args)
	{
		LoadSaveFile();
		LoadSaveFileMemoryFriendly();

		LoadSaveFileWithOptions();
		LoadSaveFileWithOptionsMemoryFriendly();
		LoadSaveFileAltSyntaxMemoryFriendly();

		LoadSaveStream();
		LoadSaveStreamMemoryFriendly();

		SaveMultiframeImage();
		LoadMultiframeImage();

        ReadImageMetadata();
	}


	/// <summary>
	/// Loads and saves image to file
	/// </summary>
	private static void LoadSaveFile()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Save("../../../../_Output/LoadSaveFile.jpg");
		}
	}


	/// <summary>
	/// Loads and saves image to file using memory-friendly Pipeline API
	/// </summary>
	private static void LoadSaveFileMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var writer = ImageWriter.Create("../../../../_Output/LoadSaveFileMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + writer);
		}
	}


	/// <summary>
	/// Loads and saves image to file with specified encoder options
	/// </summary>
	private static void LoadSaveFileWithOptions()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			// Set value of JPEG quality to 85
			bitmap.Save("../../../../_Output/LoadSaveFileWithOptions.jpg", new JpegSettings(85));
		}
	}


	/// <summary>
	/// Loads and saves image to file with specified encoder options using memory-friendly Pipeline API
	/// </summary>
	private static void LoadSaveFileWithOptionsMemoryFriendly()
	{
		using (var reader = new JpegReader("../../../../_Input/Chicago.jpg"))
		// Set value of JPEG quality to 85
		using (var writer = new JpegWriter("../../../../_Output/LoadSaveFileWithOptionsMemoryFriendly.jpg", 85))
		{
			Pipeline.Run(reader + writer);
		}
	}


	/// <summary>
	/// Loads and saves image to file with specified encoder options using alternative syntax and memory-friendly Pipeline API
	/// </summary>
	private static void LoadSaveFileAltSyntaxMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		// Set value of JPEG quality to 85
		using (var writer = ImageWriter.Create("../../../../_Output/LoadSaveFileAltSyntaxMemoryFriendly.jpg", new JpegSettings(85)))
		{
			Pipeline.Run(reader + writer);
		}
	}


	/// <summary>
	/// Loads and saves image to stream
	/// </summary>
	private static void LoadSaveStream()
	{
		using (var readStream = System.IO.File.OpenRead("../../../../_Input/Chicago.jpg"))
		using (var writerStream = System.IO.File.OpenWrite("../../../../_Output/LoadSaveStream.jpg"))
		using (var bitmap = new Bitmap(readStream))
		{
			bitmap.Save(writerStream, new JpegSettings(85));
		}
	}


	/// <summary>
	/// Loads and saves image to stream using memory-friendly Pipeline API
	/// </summary>
	private static void LoadSaveStreamMemoryFriendly()
	{
		using (var readStream = System.IO.File.OpenRead("../../../../_Input/Chicago.jpg"))
		using (var jpegReader = new JpegReader(readStream))
		using (var writerStream = System.IO.File.OpenWrite("../../../../_Output/LoadSaveStreamMemoryFriendly.jpg"))
		using (var jpegWriter = new JpegWriter(writerStream, 85))
		{
			Pipeline.Run(jpegReader + jpegWriter);
		}
	}


	/// <summary>
	/// Saves multiframe (multipage) image
	/// </summary>
	private static void SaveMultiframeImage()
	{
		using (var writer = new TiffWriter("../../../../_Output/SaveMultiframe.tif"))
		{
			using (var frame1 = new Bitmap("../../../../_Input/Chicago.jpg"))
			{
				Pipeline.Run(frame1 + writer);
			}

			using (var frame2 = new Bitmap("../../../../_Input/Copenhagen_RGB.jpg"))
			{
				Pipeline.Run(frame2 + writer);
			}
		}
	}


	/// <summary>
	/// Loads multiframe image
	/// </summary>
	private static void LoadMultiframeImage()
	{
		using (var reader = new TiffReader("../../../../_Output/SaveMultiframe.tif"))
		{
			for (int i = 0; i < reader.Frames.Count; i++)
			{
				using (var bitmap = reader.Frames[i].GetBitmap())
				{
					bitmap.Save("../../../../_Output/LoadMultiframe_" + i + ".jpg");
				}
			}
		}
	}


    /// <summary>
    /// Reads image metadata without loading bitmap data
    /// </summary>
    private static void ReadImageMetadata()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
        {
            Console.WriteLine("Width: {0}", reader.Width);
            Console.WriteLine("Height: {0}", reader.Height);
            Console.WriteLine("Pixel format: {0}", reader.PixelFormat);

            if (reader.Exif != null)
                Console.WriteLine("EXIF tag count: {0}", reader.Exif.Count);

            if (reader.Iptc != null)
                Console.WriteLine("IPTC tag count: {0}", reader.Iptc.Count);
        }
    }
}

