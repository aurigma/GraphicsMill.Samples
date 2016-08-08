using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

internal class PNGFormatExample
{
    private static void Main(string[] args)
    {
        WritePng();
        WritePngMemoryFriendly();

        ReadConvertAndWritePng();
        ReadConvertAndWritePngMemoryFriendly();

        // See the "A.15. PNG NeuQuant" project for a sample which converts a bitmap to
        // 8-bit PNG with alpha transparency support
    }

    /// <summary>
    /// Reads image in JPEG format and saves to PNG format
    /// </summary>
    private static void WritePng()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            bitmap.Transforms.Flip(FlipType.Vertical);
            bitmap.Save("../../../../_Output/WritePng.png");
        }
    }

    /// <summary>
    /// Reads image in JPEG format and saves to PNG format using memory-friendly Pipeline API
    /// </summary>
    private static void WritePngMemoryFriendly()
    {
        using (var reader = new JpegReader("../../../../_Input/Chicago.jpg"))
        using (var flip = new Flip(FlipType.Vertical))
        using (var writer = new PngWriter("../../../../_Output/WritePngMemoryFriendly.png"))
        {
            Pipeline.Run(reader + flip + writer);
        }
    }

    /// <summary>
    /// Reads image in PNG format, converts to palette-based pixel format and saves to interlaced PNG format
    /// </summary>
    private static void ReadConvertAndWritePng()
    {
        using (var bitmap = new Bitmap("../../../../_Output/WritePng.png"))
        {
            bitmap.ColorManagement.Convert(PixelFormat.Format8bppIndexed);
            bitmap.Save("../../../../_Output/ReadConvertAndWritePng.png", new PngSettings(true));
        }
    }

    /// <summary>
    /// Reads image in PNG format, converts to palette-based pixel format and saves to interlaced PNG format
    /// using memory-friendly Pipeline API
    /// </summary>
    private static void ReadConvertAndWritePngMemoryFriendly()
    {
        using (var reader = new PngReader("../../../../_Output/WritePng.png"))
        using (var colorConverter = new ColorConverter(PixelFormat.Format8bppIndexed))
        using (var writer = new PngWriter("../../../../_Output/ReadConvertAndWritePngMemoryFriendly.png"))
        {
            writer.IsInterlaced = true;

            Pipeline.Run(reader + colorConverter + writer);
        }
    }
}