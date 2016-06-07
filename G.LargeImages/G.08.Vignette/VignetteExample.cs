using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

class VignetteExample
{
    static void Main(string[] args)
    {
        CreateVignette("../../../../_Input/Venice.jpg", RgbColor.White, "../../../../_Output/VeniceVignette.jpg");
    }

    /// <summary>
    /// Creates a vignette with a specified color
    /// </summary>
    private static void CreateVignette(string srcPath, Color color, string dstPath)
    {
        const float borderScale = 0.05f;
        const float blurRadiusScale = borderScale / 2.0f;

        using (var reader = ImageReader.Create(srcPath))
        using (var gc = new GraphicsContainer(reader.Width, reader.Height, reader.DpiX, reader.DpiY))
        using (var gr = gc.GetGraphics())
        {
            int offset = (int)(reader.Width * borderScale);

            gr.FillEllipse(new SolidBrush(RgbColor.White), offset, offset, gc.Width - 2 * offset, gc.Height - 2 * offset);

            // One pipeline for generating an alpha channel

            var alphaPipeline = new Pipeline();
            alphaPipeline.Add(new ImageGenerator(gc, PixelFormat.Format8bppGrayscale, RgbColor.Black));
            alphaPipeline.Add(new Blur(reader.Width * blurRadiusScale));

            // And another one for getting a final content

            var pipeline = new Pipeline();
            pipeline.Add(reader);
            pipeline.Add(new ScaleAlpha(alphaPipeline));
            pipeline.Add(new RemoveAlpha(color));
            pipeline.Add(ImageWriter.Create(dstPath));

            try
            {
                pipeline.Run();
            }
            finally
            {
                pipeline.DisposeAllElements();
                alphaPipeline.DisposeAllElements();
            }
        }
    }
}

