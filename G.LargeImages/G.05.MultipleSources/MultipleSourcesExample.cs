using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

internal class MultipleSourcesExample
{
    private static void Main(string[] args)
    {
        SplitChannels();
        CombineChannels();
        SplitAndCombineChannels();
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

    /// <summary>
    /// Splits and combines images channels
    /// </summary>
    private static void SplitAndCombineChannels()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
        using (var channelSplitter = new RgbChannelSplitter())
        using (var brightnessR = new Brightness(0.1f))
        using (var brightnessG = new Brightness(-0.05f))
        using (var brightnessB = new Brightness(0.2f))
        using (var channelCombiner = new RgbChannelCombiner())
        using (var writer = ImageWriter.Create("../../../../_Output/SplitAndCombineChannels.png"))
        {
            reader.Receivers.Add(channelSplitter);

            channelCombiner.R = channelSplitter.R + brightnessR;
            channelCombiner.G = channelSplitter.G + brightnessG;
            channelCombiner.B = channelSplitter.B + brightnessB;

            Pipeline.Run(channelCombiner + writer);
        }
    }
}