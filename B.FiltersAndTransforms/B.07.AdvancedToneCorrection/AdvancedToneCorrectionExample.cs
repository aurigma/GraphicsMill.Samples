using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class AdvancedToneCorrectionExample
{
	static void Main(string[] args)
	{
		Levels();
		LevelsMemoryFriendly();

		ApplyLut();
		ApplyLutMemoryFriendly();

		AdjustLevelsUsingLab();
	}


	/// <summary>
	/// Applies levels correction
	/// </summary>
	private static void Levels()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.ColorAdjustment.Levels(0.03F, 0.9F, 0.05F, 1.5F, 0.7F, HistogramMode.Sum);

			bitmap.Save("../../../../_Output/Levels.jpg");
		}
	}


	/// <summary>
	/// Applies levels correction using memory-friendly Pipeline API
	/// </summary>
	private static void LevelsMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var levels = new Levels() { 
			Auto = false,
			MinimumLevel = 0.03f,
			MaximumLevel = 0.9f,
			Shadows = 0.05f,
			Midtones = 1.5f,
			Highlights = 0.7f,
			HistogramMode = HistogramMode.Sum
		})
		using (var writer = ImageWriter.Create("../../../../_Output/LevelsMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + levels + writer);
		}
	}


	/// <summary>
	/// Applies LUT (look-up table) correction
	/// </summary>
	private static void ApplyLut()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		using (var lut = new Lut())
		{
			lut.SetPoint(50, 70);
			lut.SetPoint(100, 150);
			lut.InterpolationMode = LutInterpolationMode.Cubic;

			bitmap.ColorAdjustment.ApplyLut(lut);

			bitmap.Save("../../../../_Output/ApplyLut.jpg");
		}
	}


	/// <summary>
	/// Applies LUT (look-up table) correction using memory-friendly Pipeline API
	/// </summary>
	private static void ApplyLutMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var lutTransform = new LutTransform())
		using (var lut = new Lut())
		using (var writer = ImageWriter.Create("../../../../_Output/ApplyLutMemoryFriendly.jpg"))
		{
			lut.SetPoint(50, 70);
			lut.SetPoint(100, 150);
			lut.InterpolationMode = LutInterpolationMode.Cubic;

			lutTransform.Lut = lut;

			Pipeline.Run(reader + lutTransform + writer);
		}
	}


	/// <summary>
	/// Corrects tone modifying lightness component of Lab color space 
	/// </summary>
	private static void AdjustLevelsUsingLab()
	{
		//L - lightness
		//a - green/red
		//b - blue/yellow

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

			lChannel.ColorAdjustment.Levels(0.03F, 0.9F, 0.05F, 1.5F, 0.7F, HistogramMode.Sum);

			using (var combiner = new LabChannelCombiner())
			using (var rgbConverter = new ColorConverter(PixelFormat.Format24bppRgb))
			using (var writer = ImageWriter.Create("../../../../_Output/AdjustLevelsUsingLab.jpg"))
			{
				combiner.L = lChannel;
				combiner.A = aChannel;
				combiner.B = bChannel;

				rgbConverter.DestinationProfile = ColorProfile.FromSrgb();

				Pipeline.Run(combiner + rgbConverter + writer);
			}
		}
	}
}

