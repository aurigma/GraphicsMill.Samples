using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.Codecs.Psd;
using Aurigma.GraphicsMill.AdvancedDrawing;


class TgaFormatExample
{
	static void Main(string[] args)
	{
  		WriteTga();
		ReadConvertAndWriteTga();
        ConvertClippingPathToTga();

	}


    /// <summary>
    /// Reads image in JPEG format and saves to TARGA 24 format
    /// </summary>
	private static void WriteTga()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Transforms.Flip(FlipType.Vertical);
			bitmap.Save("../../../../_Output/WriteTga.tga");
		}
	}


    /// <summary>
    /// Reads image in TARGA 24 format and saves to TARGA 16 format with RLE compression
    /// </summary>
	private static void ReadConvertAndWriteTga()
	{
        using (var reader = new TgaReader("../../../../_Output/WriteTga.tga"))
        using (var writer = new TgaWriter("../../../../_Output/ReadConvertAndWriteTga.tga"))
        {
            writer.Compression = CompressionType.Rle;
            writer.ReducedPrecision = true;

            Pipeline.Run(reader + writer);
        }
	}


    /// <summary>
    /// Reads image in JPEG format, converts clipping path to alpha channel and saves to TARGA 32 format
    /// </summary>
    public static void ConvertClippingPathToTga()
    {
        using (var reader = ImageReader.Create(@"../../../../_Input/Apple.jpg"))
        using (var alpha = new Bitmap(reader.Width, reader.Height, PixelFormat.Format8bppGrayscale, RgbColor.Black))
        using (var writer = ImageWriter.Create("../../../../_Output/ConvertClippingPathToTga.tga"))
        {
            using (var graphics = alpha.GetAdvancedGraphics())
            {
                
                var path = reader.ClippingPaths[0];
                using (var graphicsPath = Path.Create(path, alpha.Width, alpha.Height))
                {
                    graphics.FillPath(new SolidBrush(RgbColor.White), graphicsPath);
                }
            }

            using (var setAlpha = new Aurigma.GraphicsMill.Transforms.SetAlpha(alpha))
            {
                Pipeline.Run(reader + setAlpha + writer);
            }
        }
    }
}

