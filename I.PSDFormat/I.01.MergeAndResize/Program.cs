using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Codecs.Psd;


namespace MergeAndResize
{
	class Program
	{
		static void Main(string[] args)
		{
			MergeAndResize();
		}


		private static void MergeAndResize()
		{
			using (var psdReader = new PsdReader("../../../../_Input/BusinessCard.psd"))
			//This transform does nothing with image. We use it just to pass data to resize1 and resize2 transforms
			using (var repeater = new ChannelTransmitter())
			using (var resize1 = new Resize(150, 0, ResizeInterpolationMode.High))
			using (var writer1 = ImageWriter.Create("../../../../_Output/BusinessCard_Resize1.png"))
			using (var resize2 = new Resize(400, 0, ResizeInterpolationMode.High))
			using (var writer2 = ImageWriter.Create("../../../../_Output/BusinessCard_Resize2.png"))
			{
				repeater.Receivers.Add(resize1);
				repeater.Receivers.Add(resize2);

				resize1.Receivers.Add(writer1);
				resize2.Receivers.Add(writer2);

				psdReader.MergeLayers(repeater);
			}	
		}
	}
}
