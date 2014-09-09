using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class RGBToCMYKExample
{
	static void Main(string[] args)
	{
		RgbToCmykNoColorManagement();
		RgbToCmykNoColorManagementMemoryFriendly();

		RgbToCmykWithColorManagement();
		RgbToCmykWithColorManagementMemoryFriendly();

		PreviewRgbToCmykOnScreen();
		PreviewRgbToCmykOnScreenMemoryFriendly();
	}


	/// <summary>
	/// Converts color space from RGB to CMYK without color management
	/// </summary>
	private static void RgbToCmykNoColorManagement()
	{
        // BUGBUG
        /*
         * Кому нужна конвертация без ColorManagement'а? Вот прям, чтобы это специально было сделано?
         * Если есть профиль, то CC, если нет, то скорее подсунут какой-нибудь неправильный дефолтовый
         * и получат более-менее вменяемый результат.
         * 
         * Исходя из того, что у нас есть сампл на это дело, можно подумать, 
         * что это нормальный use case, хотя это не так.
         * 
         */

		using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_RGB.jpg"))
		{
			bitmap.ColorManagement.Convert(PixelFormat.Format32bppCmyk);

			bitmap.Save("../../../../_Output/RgbToCmykNoColorManagement.jpg");
		}
	}

	/// <summary>
	/// Converts color space from RGB to CMYK without color management using memory-friendly Pipeline API
	/// </summary>
	private static void RgbToCmykNoColorManagementMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_RGB.jpg"))
		using (var converter = new ColorConverter())
		using (var writer = ImageWriter.Create("../../../../_Output/RgbToCmykNoColorManagementMemoryFriendly.jpg"))
		{
			converter.DestinationPixelFormat = PixelFormat.Format32bppCmyk;

			Pipeline.Run(reader + converter + writer);
		}
	}


	/// <summary>
	/// Converts color space from RGB to CMYK with color management
	/// </summary>
	private static void RgbToCmykWithColorManagement()
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

			bitmap.Save("../../../../_Output/RgbToCmykWithColorManagement.jpg");
		}
	}


	/// <summary>
	/// Converts color space from RGB to CMYK with color management using memory-friendly Pipeline API
	/// </summary>
	private static void RgbToCmykWithColorManagementMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_RGB.jpg"))
		using (var converter = new ColorConverter())
		using (var writer = ImageWriter.Create("../../../../_Output/RgbToCmykWithColorManagementMemoryFriendly.jpg"))
		{
			converter.DestinationPixelFormat = PixelFormat.Format32bppCmyk;
			converter.DefaultSourceProfile = ColorProfile.FromSrgb();
			converter.DestinationProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc");
			converter.TransformationIntent = ColorTransformationIntent.Perceptual;

			Pipeline.Run(reader + converter + writer);
		}
	}


	/// <summary>
	/// Generates an RGB preview of CMYK color conversion
	/// </summary>
	private static void PreviewRgbToCmykOnScreen()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_RGB.jpg"))
		{
			if (bitmap.ColorProfile == null)
			{
				bitmap.ColorProfile = ColorProfile.FromSrgb();
			}

			bitmap.ColorManagement.TargetDeviceProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc");
			bitmap.ColorManagement.DestinationProfile = ColorProfile.FromScreen();

			bitmap.ColorManagement.Convert(PixelFormat.Format24bppRgb);

			bitmap.Save("../../../../_Output/PreviewRgbToCmykOnScreen.jpg");
		}
	}


	/// <summary>
	/// Generates an RGB preview of CMYK color conversion using memory-friendly Pipeline API
	/// </summary>
	private static void PreviewRgbToCmykOnScreenMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_RGB.jpg"))
		using (var converter = new ColorConverter())
		using (var writer = ImageWriter.Create("../../../../_Output/PreviewRgbToCmykOnScreenMemoryFriendly.jpg"))
		{
			converter.DestinationPixelFormat = PixelFormat.Format24bppRgb;
			converter.DefaultSourceProfile = ColorProfile.FromSrgb();
			converter.TargetDeviceProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc");
			converter.DestinationProfile = ColorProfile.FromScreen();
			converter.TransformationIntent = ColorTransformationIntent.Perceptual;

			Pipeline.Run(reader + converter + writer);
		}
	}

}

