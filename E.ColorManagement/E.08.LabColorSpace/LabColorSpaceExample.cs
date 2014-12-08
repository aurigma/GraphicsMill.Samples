using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class LabColorSpaceExample
{
	static void Main(string[] args)
	{
		AdjustLightnessLab();
		AdjustLightnessRgb();
	}


	private static float brightnessAmount = 0.3f;


	/// <summary>
	/// Adjusts brightness modifying lightness channel of Lab color space 
	/// </summary>
	private static void AdjustLightnessLab()
	{
		using (var lChannel = new Bitmap())
		using (var aChannel = new Bitmap())
		using (var bChannel = new Bitmap())
		{
			using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
			using (var labConverter = new ColorConverter(PixelFormat.Format24bppLab))
			using (var splitter = new LabChannelSplitter())
			{
				splitter.L = lChannel;
				splitter.A = aChannel;
				splitter.B = bChannel;

				Pipeline.Run(reader + labConverter + splitter);
			}

			lChannel.ColorAdjustment.Brightness(brightnessAmount);

			using (var combiner = new LabChannelCombiner())
			using (var rgbConverter = new ColorConverter(PixelFormat.Format24bppRgb))
			using (var writer = ImageWriter.Create("../../../../_Output/AdjustLightnessLab.jpg"))
			{
				combiner.L = lChannel;
				combiner.A = aChannel;
				combiner.B = bChannel;

				rgbConverter.DestinationProfile = ColorProfile.FromSrgb();

				Pipeline.Run(combiner + rgbConverter + writer);
			}
		}
	}


	/// <summary>
	/// Adjusts brightness modifying all channels of RGB color space 
	/// </summary>
	private static void AdjustLightnessRgb()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var brightness = new Brightness(brightnessAmount))
		using (var writer = ImageWriter.Create("../../../../_Output/AdjustLightnessRgb.jpg"))
		{
			Pipeline.Run(reader + brightness + writer);
		}
	}
}
