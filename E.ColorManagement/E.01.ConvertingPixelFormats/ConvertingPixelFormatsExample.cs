using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class ConvertingPixelFormatsExample
{
	static void Main(string[] args)
	{
		ConvertRgbToCmyk();
		ConvertRgbToCmykMemoryFriendly();

		ConvertCmykToRgb();
		ConvertCmykToRgbMemoryFriendly();

		AddAlphaChannel();
		AddAlphaChannelMemoryFriendly();

		ConvertToIndexed();
		ConvertToIndexedMemoryFriendly();

		ConvertToBlackAndWhite();
		ConvertToBlackAndWhiteMemoryFriendly();

		ConvertToExtended();
		ConvertToExtendedMemoryFriendly();
	}


	/// <summary>
	/// Converts color space from RGB to CMYK with color management
	/// </summary>
	private static void ConvertRgbToCmyk()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_RGB.jpg"))
		{
			if (bitmap.ColorProfile == null)
			{
				bitmap.ColorProfile = ColorProfile.FromSrgb();
			}

			bitmap.ColorManagement.DestinationProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc");
			bitmap.ColorManagement.TransformationIntent = ColorTransformationIntent.Perceptual;

			bitmap.ColorManagement.Convert(PixelFormat.Format32bppCmyk);

			bitmap.Save("../../../../_Output/PF_ConvertRgbToCmyk.jpg");
		}
	}


	/// <summary>
	/// Converts color space from RGB to CMYK with color management using memory-friendly Pipeline API
	/// </summary>
	private static void ConvertRgbToCmykMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_RGB.jpg"))
		using (var converter = new ColorConverter())
		using (var writer = ImageWriter.Create("../../../../_Output/PF_ConvertRgbToCmyk_MemoryFriendly.jpg"))
		{
			converter.DestinationPixelFormat = PixelFormat.Format32bppCmyk;
			converter.DefaultSourceProfile = ColorProfile.FromSrgb();
			converter.DestinationProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc");
			converter.TransformationIntent = ColorTransformationIntent.Perceptual;

			Pipeline.Run(reader + converter + writer);
		}
	}


	/// <summary>
	/// Converts color space from CMYK to RGB with color management
	/// </summary>
	private static void ConvertCmykToRgb()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_CMYK_NoColorProfile.jpg"))
		{
			//Assign some default color profile
			if (bitmap.ColorProfile == null)
			{
				bitmap.ColorProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc");
			}

			bitmap.ColorManagement.DestinationProfile = ColorProfile.FromSrgb();

			bitmap.ColorManagement.Convert(PixelFormat.Format24bppRgb);

			bitmap.Save("../../../../_Output/PF_ConvertCmykToRgb.jpg");
		}
	}


	/// <summary>
	/// Converts color space from CMYK to RGB with color management
	/// </summary>
	private static void ConvertCmykToRgbMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_CMYK.jpg"))
		using (var convertor = new ColorConverter(PixelFormat.Format24bppRgb))
		using (var writer = ImageWriter.Create("../../../../_Output/PF_ConvertCmykToRgbMemoryFriendly.jpg"))
		{
			convertor.DefaultSourceProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc");
			convertor.DestinationProfile = ColorProfile.FromSrgb();

			Pipeline.Run(reader + convertor + writer);
		}
	}


	/// <summary>
	/// Adds alpha channel
	/// </summary>
	private static void AddAlphaChannel()
	{
		using (var bitmap = new Bitmap("../../../../_Input/GreenScreen.jpg"))
		{
			//Use PixelFormat.Format40bppAcmyk for CMYK images
			bitmap.ColorManagement.Convert(PixelFormat.Format32bppArgb);

			//Remove background just to demonstrate alpha channel
			bitmap.Transforms.RemoveGreenScreen();

			bitmap.Save("../../../../_Output/PF_AddAlphaChannel.png");
		}
	}


	/// <summary>
	/// Adds alpha channel using memory-friendly Pipeline API
	/// </summary>
	private static void AddAlphaChannelMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/GreenScreen.jpg"))
		//Use PixelFormat.Format40bppAcmyk for CMYK images
		using (var converter = new ColorConverter(PixelFormat.Format32bppArgb))
		//Remove background just to demonstrate alpha channel
		using (var greenScreenRemoval = new GreenScreenRemoval())
		using (var writer = ImageWriter.Create("../../../../_Output/PF_AddAlphaChannelMemoryFriendly.png"))
		{
			Pipeline.Run(reader + converter + greenScreenRemoval + writer);
		}
	}


	/// <summary>
	/// Converts to indexed pixel format (optimized for Web)
	/// </summary>
	private static void ConvertToIndexed()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_RGB.jpg"))
		{
			bitmap.ColorManagement.Dithering = DitheringType.FloydSteinberg;
			bitmap.ColorManagement.Palette = ColorPalette.Create(bitmap, 64);
			bitmap.ColorManagement.Convert(PixelFormat.Format8bppIndexed);

			bitmap.Save("../../../../_Output/PF_ConvertToIndexed.png");
		}
	}


	/// <summary>
	/// Converts to indexed pixel format (optimized for Web)
	/// </summary>
	private static void ConvertToIndexedMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_RGB.jpg"))
		using (var converter = new ColorConverter(PixelFormat.Format8bppIndexed))
		using (var writer = ImageWriter.Create("../../../../_Output/PF_ConvertToIndexedMemoryFriendly.png"))
		{
			converter.Dithering = DitheringType.FloydSteinberg;

			Pipeline.Run(reader + converter + writer);
		}
	}

	/// <summary>
	/// Converts to black & white pixel format using memory-friendly Pipeline API
	/// </summary>
	private static void ConvertToBlackAndWhite()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_RGB.jpg"))
		{
			bitmap.ColorManagement.Convert(PixelFormat.Format1bppIndexed);

			bitmap.Save("../../../../_Output/PF_ConvertToBlackAndWhite.png");
		}
	}


	/// <summary>
	/// Converts to black & white pixel format using memory-friendly Pipeline API
	/// </summary>
	private static void ConvertToBlackAndWhiteMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_RGB.jpg"))
		using (var converter = new ColorConverter(PixelFormat.Format1bppIndexed))
		using (var writer = ImageWriter.Create("../../../../_Output/PF_ConvertToBlackAndWhiteMemoryFriendly.png"))
		{
			Pipeline.Run(reader + converter + writer);
		}
	}


	/// <summary>
	/// Converts to 16-bit precssion per channel
	/// </summary>
	private static void ConvertToExtended()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_RGB.jpg"))
		{
			bitmap.ColorManagement.Convert(PixelFormat.Format48bppRgb);

			bitmap.Save("../../../../_Output/PF_ConvertToExtended.png");
		}
	}


	/// <summary>
	/// Converts to 16-bit precssion per channel using memory-friendly Pipeline API
	/// </summary>
	private static void ConvertToExtendedMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_RGB.jpg"))
		using (var converter = new ColorConverter(PixelFormat.Format48bppRgb))
		using (var writer = ImageWriter.Create("../../../../_Output/PF_ConvertToExtendedMemoryFriendly.png"))
		{
			Pipeline.Run(reader + converter + writer);
		}
	}
}
