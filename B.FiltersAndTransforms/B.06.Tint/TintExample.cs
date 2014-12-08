using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class TintExample
{
	static void Main(string[] args)
	{
		Tint(RgbColor.SaddleBrown);
		Tint(RgbColor.SeaGreen);
		TintMemoryFriendly(RgbColor.OrangeRed);
	}


	/// <summary>
	/// Tints
	/// </summary>
	private static void Tint(RgbColor color)
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			using (var result = new Aurigma.GraphicsMill.Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format24bppRgb, color))
			{
				bitmap.ColorManagement.Convert(PixelFormat.Format8bppGrayscale);
				bitmap.Transforms.Invert();

				result.Channels.SetAlpha(bitmap);
				result.Channels.RemoveAlpha(RgbColor.White);

				result.Save("../../../../_Output/Tint_" + color.ToString() + ".jpg");
			}
		}
	}


	/// <summary>
	/// Tints using memory-friendly Pipeline API
	/// </summary>
	private static void TintMemoryFriendly(RgbColor color)
	{
		// reader  --->  converter  ---> invert  -----\
		//                            generator  --->  setAlpha  --->  removeAlpha  --->  writer
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var converter = new ColorConverter(PixelFormat.Format8bppGrayscale))
		using (var invert = new Invert())
		using (var generator = new ImageGenerator(reader.Width, reader.Height, PixelFormat.Format24bppRgb, color))
		using (var setAlpha = new SetAlpha())
		using (var removeAlpha = new RemoveAlpha(RgbColor.White))
		using (var writer = ImageWriter.Create("../../../../_Output/TintMemoryFriendly_" + color.ToString() + ".jpg"))
		{
			setAlpha.AlphaSource = reader + converter + invert;

			Pipeline.Run(generator + setAlpha + removeAlpha + writer);
		}
	}
}

