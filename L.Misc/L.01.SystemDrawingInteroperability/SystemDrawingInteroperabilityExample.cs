internal class SystemDrawingInteroperabilityExample
{
    private static void Main(string[] args)
    {
        SimpleConversion();
        PreserveColorProfileAndMetadata();
        ProcessNonRgb();
    }

    /// <summary>
    /// Converts Aurigma.GraphicsMill.Bitmap to System.Drawing.Bitmap and vice versa
    /// </summary>
    private static void SimpleConversion()
    {
        // Imagine that you have a legacy application which works with System.Drawing.Bitmap,
        // and you want to integrate it with Graphics Mill.
        using (var gmBitmap1 = new Aurigma.GraphicsMill.Bitmap("../../../../_Input/Copenhagen_RGB.jpg"))
        // To convert Aurigma's bitmap to System.Drawing.Bitmap, just cast it
        using (var sdBitmap = (System.Drawing.Bitmap)gmBitmap1)
        {
            // Here we modify System.Drawing.Bitmap
            ApplyWatermark(sdBitmap);

            // If all you need is to copy pixels, just cast your System.Drawing.Bitmap
            // to Aurigma.GraphicsMill.Bitmap.
            using (var gmBitmap2 = (Aurigma.GraphicsMill.Bitmap)sdBitmap)
            {
                gmBitmap2.Save("../../../../_Output/SimpleConversion.jpg");
            }
        }
    }

    /// <summary>
    /// Converts Aurigma.GraphicsMill.Bitmap to System.Drawing.Bitmap and vice versa preserving metadata
    /// </summary>
    private static void PreserveColorProfileAndMetadata()
    {
        // Imagine that you have a legacy application which works with System.Drawing.Bitmap,
        // and you want to integrate it with Graphics Mill, and you want to preserve metadata and color profile
        using (var reader = new Aurigma.GraphicsMill.Codecs.JpegReader("../../../../_Input/Copenhagen_RGB.jpg"))
        using (var gmBitmap1 = reader.Frames[0].GetBitmap())
        // To convert Aurigma's bitmap to System.Drawing.Bitmap, just cast it
        using (var sdBitmap = (System.Drawing.Bitmap)gmBitmap1)
        {
            // Here we modify System.Drawing.Bitmap
            ApplyWatermark(sdBitmap);

            // To copy pixels, just cast your System.Drawing.Bitmap to Aurigma.GraphicsMill.Bitmap.
            using (var gmBitmap2 = (Aurigma.GraphicsMill.Bitmap)sdBitmap)
            {
                // Copy color profile
                gmBitmap2.ColorProfile = gmBitmap1.ColorProfile;

                using (var writer = new Aurigma.GraphicsMill.Codecs.JpegWriter("../../../../_Output/PreserveColorProfileAndMetadata.jpg"))
                {
                    // Copy metadata
                    writer.Exif = reader.Exif;
                    writer.Iptc = reader.Iptc;
                    writer.Xmp = reader.Xmp;
                    writer.AdobeResources = reader.AdobeResources;

                    Aurigma.GraphicsMill.Pipeline.Run(gmBitmap2 + writer);
                }
            }
        }
    }

    /// <summary>
    /// Loads non-RGB image with Aurigma.GraphicsMill.Bitmap, pass it to System.Drawing.Bitmap and
    /// convert it back to Aurigma.GraphicsMill.Bitmap.
    /// </summary>
    private static void ProcessNonRgb()
    {
        // Imagine that you have a legacy application which works with System.Drawing.Bitmap,
        // and you need to work with non-RGB images. You should convert it to RGB with Graphics Mill, cast it
        // to System.Drawing.Bitmap and convert back.
        using (var reader = new Aurigma.GraphicsMill.Codecs.JpegReader("../../../../_Input/Copenhagen_CMYK.jpg"))
        using (var gmBitmap1 = reader.Frames[0].GetBitmap())
        {
            Aurigma.GraphicsMill.Bitmap rgbGmBitmap = null;

            try
            {
                // Convert a non-RGB image to the RGB color space with the sRGB color profile
                if (!gmBitmap1.PixelFormat.IsRgb)
                {
                    rgbGmBitmap = new Aurigma.GraphicsMill.Bitmap(gmBitmap1);
                    rgbGmBitmap.ColorManagement.DestinationProfile = Aurigma.GraphicsMill.ColorProfile.FromSrgb();
                    rgbGmBitmap.ColorManagement.Convert(Aurigma.GraphicsMill.PixelFormat.Format24bppRgb);
                }

                using (var sdBitmap = (System.Drawing.Bitmap)(gmBitmap1.PixelFormat.IsRgb ? gmBitmap1 : rgbGmBitmap))
                {
                    // Here we modify System.Drawing.Bitmap
                    ApplyWatermark(sdBitmap);

                    using (var gmBitmap2 = (Aurigma.GraphicsMill.Bitmap)sdBitmap)
                    {
                        // Convert an RGB image to the source color space (CMYK, grayscale, or Lab)
                        if (!gmBitmap1.PixelFormat.IsRgb)
                        {
                            gmBitmap2.ColorProfile = Aurigma.GraphicsMill.ColorProfile.FromSrgb();
                            gmBitmap2.ColorManagement.DestinationProfile = gmBitmap1.ColorProfile;
                            gmBitmap2.ColorManagement.Convert(gmBitmap1.PixelFormat);
                        }

                        // Copy color profile
                        gmBitmap2.ColorProfile = gmBitmap1.ColorProfile;

                        using (var writer = new Aurigma.GraphicsMill.Codecs.JpegWriter("../../../../_Output/ProcessNonRgb.jpg"))
                        {
                            // Copy metadata
                            writer.Exif = reader.Exif;
                            writer.Iptc = reader.Iptc;
                            writer.Xmp = reader.Xmp;
                            writer.AdobeResources = reader.AdobeResources;

                            Aurigma.GraphicsMill.Pipeline.Run(gmBitmap2 + writer);
                        }
                    }
                }
            }
            finally
            {
                if (rgbGmBitmap != null)
                {
                    rgbGmBitmap.Dispose();
                }
            }
        }
    }

    private static void ApplyWatermark(System.Drawing.Bitmap sdBitmap)
    {
        using (var graphics = System.Drawing.Graphics.FromImage(sdBitmap))
        {
            var font = new System.Drawing.Font("Arial", 72);
            var brush = System.Drawing.Brushes.LightGreen;

            graphics.DrawString("Graphics Mill", font, brush, new System.Drawing.PointF(50, 50));
        }
    }
}