using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class CropExample
{
	static void Main(string[] args)
	{
		Crop();
		CropMemoryFriendly();
	}


	/// <summary>
	/// Crops image
	/// </summary>
	private static void Crop()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Transforms.Crop(230, 170, 320, 240);
			bitmap.Save("../../../../_Output/Crop.jpg");
		}
	}


	/// <summary>
	/// Crops image using memory-friendly Pipeline API
	/// </summary>
	private static void CropMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var crop = new Crop(230, 170, 320, 240))
		using (var writer = ImageWriter.Create("../../../../_Output/CropMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + crop + writer);
		}
	}
}

