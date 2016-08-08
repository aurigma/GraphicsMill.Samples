using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;

internal class RAWFormatExample
{
    private static string rawImagePath = "../../../../_Input/PowerStation.arw";

    private static void Main(string[] args)
    {
        if (!System.IO.File.Exists(rawImagePath))
        {
            Console.WriteLine("The image in RAW format doesn't exists at the location \"{0}\"", rawImagePath);
            Console.WriteLine("You can download the test file here:");
            Console.WriteLine("http://www.aurigma.com/Download/GraphicsMill/Misc/TestRawImage.zip");

            return;
        }

        ReadRaw();
        ReadRawMemoryFriendly();
    }

    /// <summary>
    /// Reads RAW image
    /// </summary>
    private static void ReadRaw()
    {
        using (var bitmap = new Bitmap(rawImagePath))
        {
            bitmap.Save("../../../../_Output/ReadRaw.jpg");
        }
    }

    /// <summary>
    /// Reads RAW image using memory-friendly Pipeline API
    /// </summary>
    private static void ReadRawMemoryFriendly()
    {
        using (var reader = new RawReader(rawImagePath))
        using (var writer = new PngWriter("../../../../_Output/ReadRawMemoryFriendly.jpg"))
        {
            Pipeline.Run(reader + writer);
        }
    }
}