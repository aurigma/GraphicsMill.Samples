using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class TIFFFormatExample
{
	static void Main(string[] args)
	{
		WriteTiff();
		WriteTiffMemoryFriendly();
		WriteMultiframeTiff();
		WriteMultiframeTiffMemoryFriendly();
		ReadTiff();
		ReadTiffMemoryFriendly();
		ReadMultiframeTiff();
		ReadMultiframeTiffMemoryFriendly();
	}


	/// <summary>
	/// Reads image in JPEG format and saves to TIFF format
	/// </summary>
	private static void WriteTiff()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Transforms.Flip(FlipType.Vertical);

            var tiffSettings = new TiffSettings()
            {
                Compression = CompressionType.Jpeg,
                Quality = 85
            };

			bitmap.Save("../../../../_Output/WriteTiff.tif", tiffSettings);
		}
	}


	/// <summary>
	/// Reads image in JPEG format and saves to TIFF format using memory-friendly Pipeline API
	/// </summary>
	private static void WriteTiffMemoryFriendly()
	{
		using (var reader = new JpegReader("../../../../_Input/Chicago.jpg"))
		using (var flip = new Flip(FlipType.Vertical))
		using (var writer = new TiffWriter("../../../../_Output/WriteTiffMemoryFriendly.tif"))
		{
			writer.Compression = CompressionType.Jpeg;
			writer.Quality = 85;

			Pipeline.Run(reader + flip + writer);
		}
	}


	/// <summary>
	/// Writes multiframe image in TIFF format
	/// </summary>
	private static void WriteMultiframeTiff()
	{
		using (var writer = new TiffWriter("../../../../_Output/WriteMultiframeTiff.tif"))
		{
			using (var frame1 = new Bitmap("../../../../_Input/Chicago.jpg"))
			{
				//You can specify the compression of each frame separately
				writer.Compression = CompressionType.Jpeg;
				writer.Quality = 85;

				Pipeline.Run(frame1 + writer);
			}

			using (var frame2 = new Bitmap("../../../../_Input/Copenhagen_RGB.jpg"))
			{
				writer.Compression = CompressionType.Lzw;

				Pipeline.Run(frame2 + writer);
			}
		}
	}


	/// <summary>
	/// Writes multiframe image in TIFF format using memory-friendly Pipeline API
	/// </summary>
	private static void WriteMultiframeTiffMemoryFriendly()
	{
		using (var writer = new TiffWriter("../../../../_Output/WriteMultiframeTiffMemoryFriendly.tif"))
		{
			using (var reader1 = new JpegReader("../../../../_Input/Chicago.jpg"))
			{
				Pipeline.Run(reader1 + writer);
			}

			using (var reader2 = new JpegReader("../../../../_Input/Copenhagen_RGB.jpg"))
			{
				Pipeline.Run(reader2 + writer);
			}
		}
	}


	/// <summary>
	/// Reads first frame of image in TIFF format
	/// </summary>
	private static void ReadTiff()
	{
		using (var bitmap = new Bitmap("../../../../_Output/WriteMultiframeTiff.tif"))
		{
			bitmap.Save("../../../../_Output/ReadTiff.jpg");
		}
	}


	/// <summary>
	/// Reads first frame of image in TIFF format using memory-friendly Pipeline API
	/// </summary>
	private static void ReadTiffMemoryFriendly()
	{
		using (var reader = new TiffReader("../../../../_Output/WriteMultiframeTiffMemoryFriendly.tif"))
		using (var writer = new JpegWriter("../../../../_Output/ReadTiffMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + writer);
		}
	}


	/// <summary>
	/// Reads multiframe image in TIFF format
	/// </summary>
	private static void ReadMultiframeTiff()
	{
		using (var reader = new TiffReader("../../../../_Output/WriteMultiframeTiff.tif"))
		{
			for (int i = 0; i < reader.Frames.Count; i++)
			{
				using (var bitmap = reader.Frames[i].GetBitmap())
				{
					bitmap.Save("../../../../_Output/ReadMultiframeTiff_" + i + ".jpg");
				}
			}
		}
	}


	/// <summary>
	/// Reads multiframe image in TIFF format using memory-friendly Pipeline API
	/// </summary>
	private static void ReadMultiframeTiffMemoryFriendly()
	{
		using (var reader = new TiffReader("../../../../_Output/WriteMultiframeTiff.tif"))
		{
			for (int i = 0; i < reader.Frames.Count; i++)
			{
				using (var writer = new JpegWriter("../../../../_Output/ReadMultiframeTiffMemoryFriendly_" + i + ".jpg"))
				{
					Pipeline.Run(reader.Frames[i] + writer);
				}
			}
		}
	}
}

