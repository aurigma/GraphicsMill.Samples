using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

internal class AnimatedGIFExample
{
    private static void Main(string[] args)
    {
        // http://www.graphicsmill.com/docs/gm/loading-and-saving-animated-gifs.htm

        WriteAnimatedGif();
        ReadAnimatedGif();
        ResizeAnimatedGif();
    }

    /// <summary>
    /// Writes simple animated image in GIF format
    /// </summary>
    private static void WriteAnimatedGif()
    {
        using (var writer = new GifWriter("../../../../_Output/WriteAnimatedGif.gif"))
        {
            writer.Width = 400;
            writer.Height = 100;
            writer.FrameOptions.Delay = 25;

            for (int i = 0; i < 400; i += 25)
            {
                var bitmap = new Bitmap(400, 100, PixelFormat.Format24bppRgb, RgbColor.Yellow);

                using (var graphics = bitmap.GetAdvancedGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(RgbColor.Green), new System.Drawing.RectangleF(i, 0, 100, 100));
                }

                bitmap.ColorManagement.Convert(PixelFormat.Format8bppIndexed);

                Pipeline.Run(bitmap + writer);
            }
        }
    }

    /// <summary>
    /// Reads frames of animated image in GIF format
    /// </summary>
    private static void ReadAnimatedGif()
    {
        using (var reader = new GifReader("../../../../_Output/WriteAnimatedGif.gif"))
        {
            for (int i = 0; i < reader.Frames.Count; i++)
            {
                using (var bitmap = reader.Frames[i].GetBitmap())
                {
                    bitmap.Save("../../../../_Output/ReadAnimatedGif_" + i + ".gif");
                }
            }
        }
    }

    /// <summary>
    /// Resizes animated image in GIF format
    /// </summary>
    private static void ResizeAnimatedGif()
    {
        const int width = 200;
        const int height = 50;

        using (var reader = new GifReader("../../../../_Output/WriteAnimatedGif.gif"))
        {
            var kX = (float)width / (float)reader.Width;
            var kY = (float)height / (float)reader.Height;

            using (var writer = new GifWriter("../../../../_Output/ResizeAnimatedGif.gif"))
            {
                // Copy general properties of the source file
                writer.BackgroundIndex = reader.BackgroundEntryIndex;
                writer.Palette = reader.Palette;
                writer.PlaybackCount = reader.PlaybackCount;

                for (int i = 0; i < reader.Frames.Count; i++)
                {
                    // Read a frame
                    using (var frame = (GifFrame)reader.Frames[i])
                    using (var bitmap = frame.GetBitmap())
                    {
                        // Preserve the original palette
                        ColorPalette palette = bitmap.Palette;
                        // Preserve the original pixel format
                        PixelFormat pixelFormat = bitmap.PixelFormat;

                        // Convert the bitmap to a non-indexed format
                        bitmap.ColorManagement.Convert(Aurigma.GraphicsMill.ColorSpace.Rgb, true, false);

                        // Resize the bitmap in a low quality mode to prevent noise
                        var newWidth = Math.Max(1, (int)((float)bitmap.Width * kX));
                        var newHeight = Math.Max(1, (int)((float)bitmap.Height * kY));
                        bitmap.Transforms.Resize(newWidth, newHeight, ResizeInterpolationMode.Low);

                        // Return to the indexed format
                        bitmap.ColorManagement.Palette = palette;
                        bitmap.ColorManagement.Convert(pixelFormat);

                        // Copy frame settings
                        writer.FrameOptions.Left = (ushort)((float)frame.Left * kX);
                        writer.FrameOptions.Top = (ushort)((float)frame.Top * kY);
                        writer.FrameOptions.Delay = frame.Delay;
                        writer.FrameOptions.DisposalMethod = frame.DisposalMethod;

                        // Add the frame
                        Pipeline.Run(bitmap + writer);
                    }
                }
            }
        }

        // BUGBUG
        /*
         * Should we move it to the A.08 GIF Format project?
         */
    }
}