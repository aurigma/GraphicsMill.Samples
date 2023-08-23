using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

internal class GIFFormatExample
{
    private static void Main(string[] args)
    {
        WriteGif("../../../../_Input/Chicago.jpg", "../../../../_Output/WriteGif1.gif");
        WriteGifMemoryFriendly("../../../../_Input/Chicago.jpg", "../../../../_Output/WriteGifMemoryFriendly1.gif");

        // Image with transparency
        WriteGif("../../../../_Input/Stamp.png", "../../../../_Output/WriteGif2.gif");
        WriteGifMemoryFriendly("../../../../_Input/Stamp.png", "../../../../_Output/WriteGifMemoryFriendly2.gif");
    }

    /// <summary>
    /// Reads image in JPEG format, converts to palette-based pixel format, and saves to GIF format
    /// </summary>
    private static void WriteGif(string inputPath, string outputPath)
    {
        using (var bitmap = new Bitmap(inputPath))
        {
            // Image is automatically converted to the appropriate pixel format on saving, so we can omit the next line
            // bitmap.ColorManagement.Convert(PixelFormat.Format8bppIndexed);
            bitmap.Save(outputPath);
        }
    }

    /// <summary>
    /// Reads image in JPEG format, converts to palette-based pixel format, and saves to GIF format
    /// using memory-friendly Pipeline API
    /// </summary>
    private static void WriteGifMemoryFriendly(string inputPath, string outputPath)
    {
        using (var reader = ImageReader.Create(inputPath))
        using (var colorConverter = new ColorConverter(PixelFormat.Format8bppIndexed))
        using (var writer = new GifWriter(outputPath))
        {
            Pipeline.Run(reader + colorConverter + writer);
        }
    }
}