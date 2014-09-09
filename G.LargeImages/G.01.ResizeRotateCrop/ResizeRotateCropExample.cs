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
		Crop1();
		Crop2();
		Brightness();
		CombineImages();
		ConvertColors();
	}

    // BUGBUG
    /*
     * Вроде бы это уже было в B.Filters and Transforms, причем как Bitmap так и Pipeline.
     * Вообще почти везде самплы идут на оба API, а тут бац - отдельно Large Images. Может переименовать в Pipeline API syntax?
     * Ну и, судя по названию, Brightness, CombineImages и convert colors тут быть не должно.
     * 
     * + комментов не хватает
     */
	private static void Resize()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Venice.jpg"))
		using (var resize = new Resize(1048, 0, ResizeInterpolationMode.High))
		using (var writer = ImageWriter.Create("../../../../_Output/PipelineResize.jpg"))
		{
			Pipeline.Run(reader + resize + writer);
		}
	}


	private static void Rotate()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var rotate = new Rotate(5, RgbColor.Yellow, InterpolationMode.High))
		using (var writer = ImageWriter.Create("../../../../_Output/PipelineRotate.jpg"))
		{
			Pipeline.Run(reader + rotate + writer);
		}
	}


	private static void Crop1()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var crop = new Aurigma.GraphicsMill.Transforms.Crop(200, 150, 360, 270))
		using (var writer = ImageWriter.Create("../../../../_Output/PipelineCrop1.jpg"))
		{
			Pipeline.Run(reader + crop + writer);
		}
	}


	private static void Crop2()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		{
			using (var crop = new Crop(50, 50, reader.Width - 100, reader.Height - 100))
			using (var writer = ImageWriter.Create("../../../../_Output/PipelineCrop2.jpg"))
			{
				Pipeline.Run(reader + crop + writer);
			}
		}
	}


	private static void Brightness()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var brightness = new Brightness(0.1f))
		using (var writer = ImageWriter.Create("../../../../_Output/PipelineBrightness.jpg"))
		{
			Pipeline.Run(reader + brightness + writer);
		}
	}


	private static void CombineImages()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Venice.jpg"))
		using (var watermark = ImageReader.Create("../../../../_Input/Stamp.png"))
		using (var combiner = new Combiner())
		using (var writer = ImageWriter.Create("../../../../_Output/PipelineCombineImages.jpg"))
		{
			var overlay = new Aurigma.GraphicsMill.Pipeline();
			overlay.Add(watermark);
			overlay.Add(new ScaleAlpha(0.8f));

			combiner.Mode = Aurigma.GraphicsMill.Transforms.CombineMode.Alpha;
			combiner.TopImage = overlay;
			combiner.X = 10;
			combiner.Y = reader.Height - watermark.Height - 40;
			combiner.AutoDisposeTopImage = true;

			Pipeline.Run(reader + combiner + writer);
		}
	}

	
	private static void ConvertColors()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Venice.jpg"))
		using (var converter = new ColorConverter(PixelFormat.Format32bppCmyk))
		using (var writer = ImageWriter.Create("../../../../_Output/PipelineConvertColors.jpg"))
		{
			converter.ColorManagementEngine = ColorManagementEngine.LittleCms;
			converter.DestinationProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc");
			Aurigma.GraphicsMill.Pipeline.Run(reader + converter + writer);
		}
	}
}

