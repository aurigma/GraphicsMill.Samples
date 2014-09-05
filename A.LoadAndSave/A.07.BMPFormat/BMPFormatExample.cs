using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class BMPFormatExample
{
	static void Main(string[] args)
	{
		WriteBmp();
		WriteBmpMemoryFriendly();

		ReadConvertAndWriteBmp();
		ReadConvertAndWriteBmpMemoryFriendly();
	}


	/// <summary>
	/// Reads image in JPEG format and saves to BMP format
	/// </summary>
	private static void WriteBmp()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Transforms.Flip(FlipType.Vertical);
			bitmap.Save("../../../../_Output/WriteBmp.bmp");
		}
	}


	/// <summary>
	/// Reads image in JPEG format and saves to BMP format using memory-friendly Pipeline API
	/// </summary>
	private static void WriteBmpMemoryFriendly()
	{
		using (var reader = new JpegReader("../../../../_Input/Chicago.jpg"))
		using (var flip = new Flip(FlipType.Vertical))
		using (var writer = new BmpWriter("../../../../_Output/WriteBmpMemoryFriendly.bmp"))
		{
			Pipeline.Run(reader + flip + writer);
		}
	}


	/// <summary>
	/// Reads image in BMP format, converts to palette-based pixel format and saves to BMP format with RLE compression
	/// </summary>
	private static void ReadConvertAndWriteBmp()
	{
		using (var bitmap = new Bitmap("../../../../_Output/WriteBmp.bmp"))
		{
			bitmap.ColorManagement.Convert(PixelFormat.Format8bppIndexed);
			bitmap.Save("../../../../_Output/ReadConvertAndWriteBmp.bmp", new BmpSettings(CompressionType.Rle));		
		}
	}


	/// <summary>
	/// Reads image in BMP format, converts to palette-based pixel format and saves to BMP format with RLE compression
	/// using memory-friendly Pipeline API
	/// </summary>
	private static void ReadConvertAndWriteBmpMemoryFriendly()
	{
		using (var reader = new BmpReader("../../../../_Output/WriteBmpMemoryFriendly.bmp"))
		using (var colorConverter = new ColorConverter(PixelFormat.Format8bppIndexed))
		using (var writer = new BmpWriter("../../../../_Output/ReadConvertAndWriteBmpMemoryFriendly.bmp"))
		{
			writer.Compression = CompressionType.Rle;

			Pipeline.Run(reader + colorConverter + writer);
		}	
	}
}

