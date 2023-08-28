using System.IO;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;

public class Program
{
    public static void Main(string[] args)
    {
        ReadImageWithWPF();
        WriteImageWithWPF();

        CodecRegistrySample();
    }

    /// <summary>
    /// Demonstrates passing an image to a pipeline with the custom image reader.
    /// </summary>
    private static void ReadImageWithWPF()
    {
        // You may need to have HEVC Video Extensions installed.
        using (var fs = new FileStream("../../../../_Input/flower.jpg", FileMode.Open, FileAccess.Read))
        using (var reader = new CustomImageReader(new WPFImageReader(fs)))
        using (var writer = new TiffWriter("../../../../_Output/ReadWithWPF.tif"))
        {
            Pipeline.Run(reader + writer);
        }
    }

    /// <summary>
    /// Demonstrates writing an image from a pipeline with the custom image writer.
    /// </summary>
    private static void WriteImageWithWPF()
    {
        using (var reader = ImageReader.Create("../../../../_Input/flower.jpg"))
        using (var fs = new FileStream("../../../../_Output/WroteByWPF.tif", FileMode.Create, FileAccess.Write))
        using (var writer = new CustomImageWriter(new WPFImageWriter(fs)))
        {
            Pipeline.Run(reader + writer);
        }
    }

    /// <summary>
    /// Shows how to use CodecRegistry class.
    /// </summary>
    private static void CodecRegistrySample()
    {
        /*
        This is a list of formats CodecRegistry will try to use to detect the type of image from the stream. 
        The first one to try is JPEG, if it fails - PNG, and so on. The first successful attempt will be used.
        Here, the last one is a WIC-based codec. May be helpful to read unsupported formats, like HEIC, AVIF etc.

        Also, there are specific cases related to the same file signature. For example, some RAW formats are
        actually TIFFs, and it takes much longer to validate RAW than TIFF. In some scenarios, you decide that faster 
        reading of regular TIFF is more important, or you don't expect the RAW format at all, and you just put 
        TIFF format higher on the priority list.
        */
        var formatList = new[]
        {
            FileFormat.Jpeg,
            FileFormat.Png,
            FileFormat.Gif,
            FileFormat.Bmp,
            FileFormat.Raw,
            FileFormat.Tiff,
            FileFormat.Custom,
        };

        var codecRegistry = new CodecRegistry(formatList);

        codecRegistry.CustomReaderCreate = (Stream stream) =>
        {
            // Somehow, after stream analysis we may decide that WPFImageReader is good to go.
            return new CustomImageReader(new WPFImageReader(stream));
        };

        // You may need to have HEVC Video Extensions installed.
        using (var fs = new FileStream("../../../../_Input/IMG_4212.HEIC", FileMode.Open, FileAccess.Read))
        using (var reader = codecRegistry.CreateReader(fs))
        using (var writer = new TiffWriter("../../../../_Output/CodecRegistry.tiff"))
        {
            // TIFF format is good for such samples, because it supports the most number of formats.
            writer.Compression = CompressionType.Zip;
            Pipeline.Run(reader + writer);
        }
    }
}