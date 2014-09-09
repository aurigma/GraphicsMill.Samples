using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class ColorManagementEnginesExample
{
	static void Main(string[] args)
	{
		Console.WriteLine("Convert colors using LittleCMS ");
		ConvertColorsLittleCms();
		ConvertColorsLittleCmsMemoryFriendly();

		Console.WriteLine("Convert colors using Adobe Color Management Module (CMM)");
		ConvertColorsAdobeCmm();
		ConvertColorsAdobeCmmMemoryFriendly();
	}


	/// <summary>
	/// Converts colors using LittleCMS
	/// </summary>
	private static void ConvertColorsLittleCms()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_CMYK.jpg"))
		{
			// LittleCMS is a default color management engine, so no need to specify it
			// bitmap.ColorManagement.ColorManagementEngine = ColorManagementEngine.LittleCms;
			bitmap.ColorManagement.DestinationProfile = ColorProfile.FromSrgb();
			bitmap.ColorManagement.Convert(PixelFormat.Format24bppRgb);
			bitmap.Save("../../../../_Output/ConvertColorsLittleCms.jpg");
		}
	}


	/// <summary>
	/// Converts colors using LittleCMS and memory-friendly Pipeline API
	/// </summary>
	private static void ConvertColorsLittleCmsMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_CMYK.jpg"))
		using (var converter = new ColorConverter())
		using (var writer = ImageWriter.Create("../../../../_Output/ConvertColorsLittleCmsMemoryFriendly.jpg"))
		{
			// LittleCMS is a default color management engine, so no need to specify it
			// converter.ColorManagementEngine = ColorManagementEngine.LittleCms;
			converter.DestinationProfile = ColorProfile.FromSrgb();

			Pipeline.Run(reader + converter + writer);
		}
	}


	/// <summary>
	/// Converts colors using Adobe Color Management Module (CMM)
	/// </summary>
	private static void ConvertColorsAdobeCmm()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_CMYK.jpg"))
		{
			bitmap.ColorManagement.ColorManagementEngine = ColorManagementEngine.AdobeCmm;
			bitmap.ColorManagement.DestinationProfile = ColorProfile.FromSrgb();

			try
			{
				bitmap.ColorManagement.Convert(PixelFormat.Format24bppRgb);
			}
			catch (CMAdobeModuleLoadException e)
			{
				Console.WriteLine("Can't load Adobe Color Management Module (CMM).\n" + e.Message);
				Console.WriteLine("http://www.adobe.com/support/downloads/detail.jsp?ftpID=3618");
				return;
			}

			bitmap.Save("../../../../_Output/ConvertColorsAdobeCmm.jpg");
		}
	}


	/// <summary>
	/// Converts colors using Adobe Color Management Module (CMM) and memory-friendly Pipeline API
	/// </summary>
	private static void ConvertColorsAdobeCmmMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_CMYK.jpg"))
		using (var converter = new ColorConverter())
		using (var writer = ImageWriter.Create("../../../../_Output/ConvertColorsAdobeCmmMemoryFriendly.jpg"))
		{
			converter.ColorManagementEngine = ColorManagementEngine.AdobeCmm;
			converter.DestinationProfile = ColorProfile.FromSrgb();

			try
			{
				Pipeline.Run(reader + converter + writer);
			}
			catch (CMAdobeModuleLoadException e)
			{
				Console.WriteLine("Can't load Adobe Color Management Module (CMM).\n" + e.Message);
				Console.WriteLine("http://www.adobe.com/support/downloads/detail.jsp?ftpID=3618");
			}			
		}
	}
}

