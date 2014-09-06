using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

class GreenScreenRemovalExample
{
	static void Main(string[] args)
	{
		RemoveGreenScreen();
		RemoveGreenScreenMemoryFriendly();
	}


	/// <summary>
	/// Removes green screen using standard approach
	/// </summary>
	private static void RemoveGreenScreen()
	{
		using (var bitmap = new Bitmap("../../../../_Input/GreenScreen.jpg"))
		{
			bitmap.Transforms.RemoveGreenScreen();

			bitmap.Save("../../../../_Output/RemoveGreenScreen.png");
		}
	}


	/// <summary>
	/// Removes green screen using memory-friendly Pipeline API
	/// </summary>
	private static void RemoveGreenScreenMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/GreenScreen.jpg"))
		using (var greenScreenRemoval = new GreenScreenRemoval())
		using (var writer = new PngWriter("../../../../_Output/RemoveGreenScreenMemoryFriendly.png"))
		{
			Pipeline.Run(reader + greenScreenRemoval + writer);
		}
	}
}
