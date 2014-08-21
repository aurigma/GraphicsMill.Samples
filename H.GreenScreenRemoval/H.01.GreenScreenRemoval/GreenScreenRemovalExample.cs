using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

namespace GreenScreenRemovalExample
{
	class Program
	{
		static void Main(string[] args)
		{
			RemoveGreenScreen();
			RemoveGreenScreenUsingPipeline();
		}


		/// <summary>
		/// Remove green screen using standard approach
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
		/// Remove green screen using memory-friendly pipeline approach
		/// </summary>
		private static void RemoveGreenScreenUsingPipeline()
		{
			using (var reader = Aurigma.GraphicsMill.Codecs.ImageReader.Create("../../../../_Input/GreenScreen.jpg"))
			using (var greenScreenRemoval = new GreenScreenRemoval())
			using (var writer = new PngWriter("../../../../_Output/RemoveGreenScreenUsingPipeline.png"))
			{
				Pipeline.Run(reader + greenScreenRemoval + writer);
			}
		}
	}
}
