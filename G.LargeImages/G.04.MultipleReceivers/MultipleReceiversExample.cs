using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class MultipleReceiversExample
{
	static void Main(string[] args)
	{
		MultipleReceivers();
	}


	private static void MultipleReceivers()
	{
		//reader --->  resizeBig    --->  writerBig
		//       \-->  resizeSmall  --->  writerSmall
		using (var reader = ImageReader.Create("../../../../_Input/Venice.jpg"))
		using (var resizeBig = new Resize(640, 0, ResizeInterpolationMode.High))
		using (var writerBig = ImageWriter.Create("../../../../_Output/MultipleReceivers_Big.jpg"))
		using (var resizeSmall = new Resize(128, 0, ResizeInterpolationMode.High))
		using (var writerSmall = ImageWriter.Create("../../../../_Output/MultipleReceivers_Small.jpg"))
		{
			reader.Receivers.Add(resizeBig);
			resizeBig.Receivers.Add(writerBig);

			reader.Receivers.Add(resizeSmall);
			resizeSmall.Receivers.Add(writerSmall);

			Aurigma.GraphicsMill.Pipeline.Run(reader);
		}
	}
}

