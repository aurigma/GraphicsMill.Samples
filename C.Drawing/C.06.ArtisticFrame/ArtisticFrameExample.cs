using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;

internal class ArtisticFrameExample
{
    private static void Main(string[] args)
    {
        DrawArtisticFrame();
    }

    /// <summary>
    /// Draws artistic frame
    /// </summary>
    private static void DrawArtisticFrame()
    {
        int padding = 200;

        using (var source = new Bitmap("../../../../_Input/Copenhagen_Rgb.jpg"))
        {
            int width = source.Width + (padding * 2);
            int height = source.Height + (padding * 2);

            var mattPath = "../../../../_Input/Matt.png";
            var framePath = "../../../../_Input/Frame.png";

            using (var result = new Bitmap(width, height, PixelFormat.Format24bppRgb))
            using (var graphics = result.GetAdvancedGraphics())
            {
                // Draw matt
                using (var matt = new Bitmap(mattPath))
                {
                    matt.DpiX = graphics.DpiX;
                    matt.DpiY = graphics.DpiY;
                    using (var mattRepeated = RepeatBitmap(matt, result.Width, result.Height))
                    {
                        // Draw centered
                        graphics.DrawImage(mattRepeated, 0, 0);
                    }

                    // Draw frame
                    using (var frame = new Bitmap(framePath))
                    {
                        frame.DpiX = graphics.DpiX;
                        frame.DpiY = graphics.DpiY;
                        using (var frameRepeated = RepeatBitmap(frame, frame.Width, Math.Max(result.Height, result.Width)))
                        {
                            // Right border
                            graphics.DrawImage(frameRepeated, 0, 0);

                            // Left border
                            frameRepeated.Transforms.Rotate(180f);
                            graphics.DrawImage(frameRepeated, result.Width - frameRepeated.Width, 0);

                            // Top border
                            frameRepeated.Transforms.Rotate(270f);

                            var clippingPathTop = new Path();
                            clippingPathTop.MoveTo(0f, 0f);
                            clippingPathTop.LineTo((float)result.Width / 2f, (float)result.Width / 2f);
                            clippingPathTop.LineTo(result.Width, 0);
                            clippingPathTop.Close();

                            graphics.ClippingPaths.Add(clippingPathTop);

                            graphics.DrawImage(frameRepeated, 0, 0);

                            graphics.ClippingPaths.Clear();

                            // Bottom border
                            frameRepeated.Transforms.Rotate(180f);

                            var clippingPathBottom = new Path();
                            clippingPathBottom.MoveTo(0f, result.Height);
                            clippingPathBottom.LineTo((float)result.Width / 2f, (float)result.Height - ((float)result.Width / 2f));
                            clippingPathBottom.LineTo(result.Width, result.Height);
                            clippingPathBottom.Close();

                            graphics.ClippingPaths.Add(clippingPathBottom);

                            graphics.DrawImage(frameRepeated, 0, result.Height - frameRepeated.Height);

                            graphics.ClippingPaths.Clear();

                            // Draw image in the center
                            var rect1 = new System.Drawing.RectangleF(
                                (result.Width - source.Width) / 2,
                                (result.Height - source.Height) / 2,
                                source.Width,
                                source.Height);

                            graphics.DrawImage(source, rect1);

                            var pen = new Pen(RgbColor.LightGray, 4f);

                            graphics.DrawRectangle(pen, rect1);

                            float offset = 8f;

                            var rect2 = new System.Drawing.RectangleF(
                                rect1.X - offset,
                                rect1.Y - offset,
                                rect1.Width + (offset * 2),
                                rect1.Height + (offset * 2));

                            graphics.DrawRectangle(pen, rect2);
                        }
                    }
                }

                result.Save("../../../../_Output/DrawArtisticFrame.png");
            }
        }
    }

    private static Bitmap RepeatBitmap(Bitmap bitmap, int minWidth, int minHeight)
    {
        int tileXCount = ((minWidth - 1) / bitmap.Width) + 1;
        int tileYCount = ((minHeight - 1) / bitmap.Height) + 1;

        var repeated = new Bitmap(tileXCount * bitmap.Width, tileYCount * bitmap.Height, PixelFormat.Format24bppRgb);

        using (var graphics = repeated.GetAdvancedGraphics())
        {
            for (var i = 0; i < tileXCount; i++)
            {
                for (var j = 0; j < tileYCount; j++)
                {
                    graphics.DrawImage(bitmap, bitmap.Width * i, bitmap.Height * j);
                }
            }
        }

        return repeated;
    }
}