using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

internal class JPEGFormatExample
{
    private static void Main(string[] args)
    {
        ReadAndWriteJpeg();
        ReadAndWriteJpegMemoryFriendly();

        ResizeWhileReadingJpeg();
        ResizeWhileReadingJpegMemoryFriendly();

        ConvertAndWriteJpeg();
        ConvertAndWriteJpegMemoryFriendly();
    }

    /// <summary>
    /// Reads and writes image in JPEG format
    /// </summary>
    private static void ReadAndWriteJpeg()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            bitmap.Transforms.Flip(FlipType.Vertical);

            var jpegSettings = new JpegSettings()
            {
                Quality = 90,
                UseSubsampling = false,
                IsProgressive = true
            };

            bitmap.Save("../../../../_Output/ReadWriteJpeg.jpg", jpegSettings);
        }
    }

    /// <summary>
    /// Reads and writes image in JPEG format using memory-friendly Pipeline API
    /// </summary>
    private static void ReadAndWriteJpegMemoryFriendly()
    {
        using (var reader = new JpegReader("../../../../_Input/Chicago.jpg"))
        using (var flip = new Flip(FlipType.Vertical))
        using (var writer = new JpegWriter("../../../../_Output/ReadWriteJpegMemoryFriendly.jpg"))
        {
            writer.Quality = 90;
            writer.UseSubsampling = false;
            writer.IsProgressive = true;

            Pipeline.Run(reader + flip + writer);
        }
    }

    /// <summary>
    /// Resizes while reading of JPEG image
    /// </summary>
    private static void ResizeWhileReadingJpeg()
    {
        using (var reader = new JpegReader("../../../../_Input/Chicago.jpg"))
        {
            reader.Scale = JpegScale.x2;

            using (var bitmap = reader.Frames[0].GetBitmap())
            {
                bitmap.Save("../../../../_Output/ResizeWhileReadingJpeg.jpg");
            }
        }
    }

    /// <summary>
    /// Resizes while reading of JPEG image using memory-friendly Pipeline API
    /// </summary>
    private static void ResizeWhileReadingJpegMemoryFriendly()
    {
        using (var reader = new JpegReader("../../../../_Input/Chicago.jpg"))
        using (var writer = new JpegWriter("../../../../_Output/ResizeWhileReadingJpegMemoryFriendly.jpg"))
        {
            reader.Scale = JpegScale.x2;

            Pipeline.Run(reader + writer);
        }
    }

    /// <summary>
    /// Converts to PixelFormat.Format24bppRgb to and saves to JPEG format
    /// </summary>
    private static void ConvertAndWriteJpeg()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Stamp.png"))
        {
            // JPEG format supports PixelFormat.Format32bppCmyk and PixelFormat.Format8bppGrayscale
            // for CMYK and grayscale images accordingly
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                bitmap.ColorManagement.Convert(PixelFormat.Format24bppRgb);
            }

            bitmap.Save("../../../../_Output/ConvertAndWriteJpeg.jpg");
        }
    }

    /// <summary>
    /// Converts to PixelFormat.Format24bppRgb to and saves to JPEG format using memory-friendly Pipeline API
    /// </summary>
    private static void ConvertAndWriteJpegMemoryFriendly()
    {
        using (var reader = new PngReader("../../../../_Input/Stamp.png"))
        using (var colorConverter = new ColorConverter(PixelFormat.Format24bppRgb))
        using (var writer = new JpegWriter("../../../../_Output/ConvertAndWriteJpegMemoryFriendly.jpg"))
        {
            // JPEG format supports PixelFormat.Format32bppCmyk and PixelFormat.Format8bppGrayscale
            // for CMYK and grayscale images accordingly
            if (reader.PixelFormat == PixelFormat.Format24bppRgb)
            {
                Pipeline.Run(reader + writer);
            }
            else
            {
                Pipeline.Run(reader + colorConverter + writer);
            }
        }
    }
}