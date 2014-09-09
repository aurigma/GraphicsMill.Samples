using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class CombineImagesExamples
{
	static void Main(string[] args)
	{
		DrawImage();
		CombineImages();
		CombineImagesMemoryFriendly();
	}


	/// <summary>
	/// Draws image
	/// </summary>
	private static void DrawImage()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Venice.jpg"))
		using (var watermark = new Bitmap("../../../../_Input/Stamp.png"))
        using (var graphics = bitmap.GetAdvancedGraphics())
		{
		    graphics.DrawImage(watermark, 10, bitmap.Height - watermark.Height - 40);

			bitmap.Save("../../../../_Output/DrawImage.jpg");
		}
	}


	/// <summary>
	/// Combines images
	/// </summary>
	private static void CombineImages()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Venice.jpg"))
		using (var watermark = new Bitmap("../../../../_Input/Stamp.png"))
		{
			bitmap.Draw(watermark, 10, bitmap.Height - watermark.Height - 40, CombineMode.AlphaOverlay);

			bitmap.Save("../../../../_Output/CombineImages.jpg");
		}
	}


	/// <summary>
	/// Combines images using memory-friendly Pipeline API
	/// </summary>
	private static void CombineImagesMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Venice.jpg"))
		using (var watermark = ImageReader.Create("../../../../_Input/Stamp.png"))
		using (var combiner = new Combiner())
		using (var writer = ImageWriter.Create("../../../../_Output/CombineImagesMemoryFriendly.jpg"))
		{
			reader.Receivers.Add(combiner);

			combiner.Mode = CombineMode.AlphaOverlay;
			combiner.TopImage = watermark;
			combiner.X = 10;
			combiner.Y = reader.Height - watermark.Height - 40;
			
			combiner.Receivers.Add(writer);

			Pipeline.Run(reader);
		}
	}

    // BUGBUG
    /*
     * Combine images вроде как больше к трансформам относится. На graphics'е мы тоже можем рисовать картинки, 
     * но без combine mode, так как есть векторые форматы, к которым это неприменимо.
     * 
     * Предлагаю в трансформы.
     */
}

