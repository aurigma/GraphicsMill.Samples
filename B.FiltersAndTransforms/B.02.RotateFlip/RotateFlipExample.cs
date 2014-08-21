using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class RotateExample
{
	static void Main(string[] args)
	{
		Rotate();
		RotateMemoryFriendly();

		RotateArbitrary();
		RotateArbitraryMemoryFriendly();

		Flip();
		FlipMemoryFriendly();
	}


	/// <summary>
	/// Rotates image on 90, 180, 270 degrees
	/// </summary>
	private static void Rotate()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Transforms.Rotate(90);
			bitmap.Save("../../../../_Output/Rotate.jpg");
		}
	}


	/// <summary>
	/// Rotates image on 90, 180, 270 degrees image using memory-friendly Pipeline API
	/// </summary>
	private static void RotateMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var rotate = new Rotate(90))
		using (var writer = ImageWriter.Create("../../../../_Output/RotateMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + rotate + writer);
		}
	}


	/// <summary>
	/// Rotates image on arbitrary angle
	/// </summary>
	private static void RotateArbitrary()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Transforms.Rotate(15, RgbColor.Yellow, InterpolationMode.High);
			bitmap.Save("../../../../_Output/RotateArbitrary.jpg");
		}
	}


	/// <summary>
	/// Rotates image on arbitrary angle using memory-friendly Pipeline API
	/// </summary>
	private static void RotateArbitraryMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var rotate = new Rotate(15, RgbColor.Yellow, InterpolationMode.High))
		using (var writer = ImageWriter.Create("../../../../_Output/RotateArbitraryMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + rotate + writer);
		}
	}


	/// <summary>
	/// Flips image
	/// </summary>
	private static void Flip()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Transforms.Flip(FlipType.Vertical);
			bitmap.Save("../../../../_Output/Flip.jpg");
		}
	}


	/// <summary>
	/// Flips image using memory-friendly Pipeline API
	/// </summary>
	private static void FlipMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var flip = new Flip(FlipType.Vertical))
		using (var writer = ImageWriter.Create("../../../../_Output/FlipMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + flip + writer);
		}
	}
}

