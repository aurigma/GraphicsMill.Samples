using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class BrightnessContrastExample
{
	static void Main(string[] args)
	{
		Brightness();
		BrightnessMemoryFriendly();

		Contrast();
		ContrastMemoryFriendly();

		BrightnessContrast();
		BrightnessContrastMemoryFriendly();

		AutoBrightness();
		AutoBrightnessMemoryFriendly();

		AutoContrast();
		AutoContrastMemoryFriendly();
	}


	/// <summary>
	/// Adjusts brightness
	/// </summary>
	private static void Brightness()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.ColorAdjustment.Brightness(0.1f);

			bitmap.Save("../../../../_Output/Brightness.jpg");
		}
	}


	/// <summary>
	/// Adjusts brightness using memory-friendly Pipeline API
	/// </summary>
	private static void BrightnessMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var brightness = new Brightness(0.1f))
		using (var writer = ImageWriter.Create("../../../../_Output/BrightnessMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + brightness + writer);
		}
	}


	/// <summary>
	/// Adjusts contrast
	/// </summary>
	private static void Contrast()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.ColorAdjustment.Contrast(0.1f);

			bitmap.Save("../../../../_Output/Contrast.jpg");
		}
	}


	/// <summary>
	/// Adjusts contrast using memory-friendly Pipeline API
	/// </summary>
	private static void ContrastMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var contrast = new Contrast(0.2f))
		using (var writer = ImageWriter.Create("../../../../_Output/ContrastMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + contrast + writer);
		}
	}


	/// <summary>
	/// Adjusts brightness/contrast
	/// </summary>
	private static void BrightnessContrast()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.ColorAdjustment.BrightnessContrast(0.1f, 0.2f);

			bitmap.Save("../../../../_Output/BrightnessContrast.jpg");
		}
	}


	/// <summary>
	/// Adjusts contrast using memory-friendly Pipeline API
	/// </summary>
	private static void BrightnessContrastMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var brightnessContrast = new BrightnessContrast(0.1f, 0.2f))
		using (var writer = ImageWriter.Create("../../../../_Output/BrightnessContrastMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + brightnessContrast + writer);
		}
	}



	/// <summary>
	/// Adjusts brightness automatically
	/// </summary>
	private static void AutoBrightness()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.ColorAdjustment.AutoBrightness();

			bitmap.Save("../../../../_Output/AutoBrightness.jpg");
		}
	}


	/// <summary>
	/// Adjusts brightness automatically using memory-friendly Pipeline API
	/// </summary>
	private static void AutoBrightnessMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var brightness = new Brightness() { Auto = true })
		using (var writer = ImageWriter.Create("../../../../_Output/AutoBrightnessMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + brightness + writer);
		}
	}


	/// <summary>
	/// Adjusts contract automatically
	/// </summary>
	private static void AutoContrast()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.ColorAdjustment.AutoContrast();

			bitmap.Save("../../../../_Output/AutoContrast.jpg");
		}
	}


	/// <summary>
	/// Adjusts contrast automatically using memory-friendly Pipeline API
	/// </summary>
	private static void AutoContrastMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var contrast = new Contrast() { Auto = true })
		using (var writer = ImageWriter.Create("../../../../_Output/AutoContrastMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + contrast + writer);
		}
	}
}

