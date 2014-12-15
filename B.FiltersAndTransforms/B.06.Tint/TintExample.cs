using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class TintExample
{
	static void Main(string[] args)
	{
		TintUsingAlpha(RgbColor.Green);
		TintUsingAlphaMemoryFriendly(RgbColor.OrangeRed);
		
		//Sepia
		TintUsingLab(new RgbColor(250, 178, 79));
	}


	/// <summary>
	/// Tints using alpha channel
	/// </summary>
	private static void TintUsingAlpha(RgbColor color)
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			using (var result = new Aurigma.GraphicsMill.Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format24bppRgb, color))
			{
				bitmap.ColorManagement.Convert(PixelFormat.Format8bppGrayscale);
				bitmap.Transforms.Invert();

				result.Channels.SetAlpha(bitmap);
				result.Channels.RemoveAlpha(RgbColor.White);

				result.Save("../../../../_Output/TintUsingAlpha_" + color.ToString() + ".jpg");
			}
		}
	}


	/// <summary>
	/// Tints using alpha channel and memory-friendly Pipeline API
	/// </summary>
	private static void TintUsingAlphaMemoryFriendly(RgbColor color)
	{
		// reader  --->  converter  ---> invert  -----\
		//                            generator  --->  setAlpha  --->  removeAlpha  --->  writer
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var converter = new ColorConverter(PixelFormat.Format8bppGrayscale))
		using (var invert = new Invert())
		using (var generator = new ImageGenerator(reader.Width, reader.Height, PixelFormat.Format24bppRgb, color))
		using (var setAlpha = new SetAlpha())
		using (var removeAlpha = new RemoveAlpha(RgbColor.White))
		using (var writer = ImageWriter.Create("../../../../_Output/TintUsingAlphaMemoryFriendly_" + color.ToString() + ".jpg"))
		{
			setAlpha.AlphaSource = reader + converter + invert;

			Pipeline.Run(generator + setAlpha + removeAlpha + writer);
		}
	}


	/// <summary>
	/// Tints using Lab color space
	/// </summary>
	private static void TintUsingLab(RgbColor color)
	{		
		//You can hardcode a = 20, b = 60 for sepia effect
		var labColor = RgbToLabColor(color);
		var a = labColor.A; 
		var b = labColor.B;

		using (var lChannel = new Bitmap())
		{
			//Convert to Lab color space and get lightness channel
			using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
			using (var labConverter = new ColorConverter(PixelFormat.Format24bppLab))
			using (var splitter = new LabChannelSplitter())
			{
				splitter.L = lChannel;

				Pipeline.Run(reader + labConverter + splitter);
			}

			//Create a and b channels, combine with lightness channel and convert to RGB color space
			using (var combiner = new LabChannelCombiner())
			using (var aChannel = new Bitmap(lChannel.Width, lChannel.Height, PixelFormat.Format8bppGrayscale,
				new GrayscaleColor((byte)(a + 127))))
			using (var bChannel = new Bitmap(lChannel.Width, lChannel.Height, PixelFormat.Format8bppGrayscale, 
				new GrayscaleColor((byte)(b + 127))))
			using (var rgbConverter = new ColorConverter(PixelFormat.Format24bppRgb))
			using (var writer = ImageWriter.Create("../../../../_Output/TintUsingLab_" + color.ToString() + ".jpg"))
			{
				combiner.L = lChannel;
				combiner.A = aChannel;
				combiner.B = bChannel;

				rgbConverter.DestinationProfile = ColorProfile.FromSrgb();

				Pipeline.Run(combiner + rgbConverter + writer);
			}
		}
	}


	private static LabColor RgbToLabColor(RgbColor color)
	{
		using (var bitmap = new Aurigma.GraphicsMill.Bitmap(1, 1, PixelFormat.Format24bppRgb, color))
		{
			bitmap.ColorProfile = ColorProfile.FromSrgb();

			bitmap.ColorManagement.Convert(PixelFormat.Format24bppLab);

			return (LabColor)bitmap.GetPixel(0, 0);
		}
	}
}