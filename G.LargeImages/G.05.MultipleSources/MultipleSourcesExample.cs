using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class MultipleSourcesExample
{
	static void Main(string[] args)
	{
		SplitChannels();
		CombineChannels();
	}

	/// <summary>
	/// Combines image channels into multiple receivers
	/// </summary>	
	private static void SplitChannels()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var splitter = new Aurigma.GraphicsMill.RgbChannelSplitter())
		using (var brighntessR = new Brightness(0.1f))
		using (var writerR = new PngWriter("../../../../_Output/Chicago_R.png"))
		using (var brightnessG = new Brightness(0.2f))
		using (var writerG = new PngWriter("../../../../_Output/Chicago_G.png"))
		using (var brightnessB = new Brightness(-0.1f))
		using (var writerB = new PngWriter("../../../../_Output/Chicago_B.png"))
		{
			splitter.R = brighntessR;
			brighntessR.Receivers.Add(writerR);
			
			splitter.G = brightnessG;
			brightnessG.Receivers.Add(writerG);

			splitter.B = brightnessB;
			brightnessB.Receivers.Add(writerB);

			Pipeline.Run(reader + splitter);
		}
	}


	/// <summary>
	/// Combines image channels from multiple sources
	/// </summary>
	private static void CombineChannels()
	{
		using (var writer = ImageWriter.Create("../../../../_Output/PipelineCombineChannels.jpg"))
		using (var combiner = new Aurigma.GraphicsMill.RgbChannelCombiner())
		using (var readerR = new PngReader("../../../../_Output/Chicago_R.png"))
		using (var readerG = new PngReader("../../../../_Output/Chicago_G.png"))
		using (var readerB = new PngReader("../../../../_Output/Chicago_B.png"))
		{
			combiner.R = readerR;
			combiner.G = readerG;
			combiner.B = readerB;
			Pipeline.Run(combiner + writer);
		}
	}
}