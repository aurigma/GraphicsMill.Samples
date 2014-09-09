using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class ResizeRotateCropExample
{
	static void Main(string[] args)
	{
		Resize();
		Rotate();
		Crop();
	}


	/// <summary>
	/// Resizes image using memory-friendly Pipeline API
	/// </summary>
	private static void Resize()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Venice.jpg"))
		using (var resize = new Resize(1048, 0, ResizeInterpolationMode.High))
		using (var writer = ImageWriter.Create("../../../../_Output/PipelineResize.jpg"))
		{
			Pipeline.Run(reader + resize + writer);
		}
	}


	/// <summary>
	/// Rotates image using memory-friendly Pipeline API
	/// </summary>
	private static void Rotate()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var rotate = new Rotate(5, RgbColor.Yellow, InterpolationMode.High))
		using (var writer = ImageWriter.Create("../../../../_Output/PipelineRotate.jpg"))
		{
			Pipeline.Run(reader + rotate + writer);
		}
	}


	/// <summary>
	/// Crops image using memory-friendly Pipeline API
	/// </summary>
	private static void Crop()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var crop = new Crop(200, 150, 360, 270))
		using (var writer = ImageWriter.Create("../../../../_Output/PipelineCrop1.jpg"))
		{
			Pipeline.Run(reader + crop + writer);
		}
	}
}

