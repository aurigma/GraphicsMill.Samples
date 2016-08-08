using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

internal class CMYKGrayscaleToRGBExample
{
    private static void Main(string[] args)
    {
        CmykToRgbNoColorManagement();
        CmykToRgbNoColorManagementMemoryFriendly();

        CmykToRgbWithColorManagement();
        CmykToRgbWithColorManagementMemoryFriendly();

        CmykNoProfileToRgbNoColorManagement();
        CmykNoProfileToRgbNoColorManagementMemoryFriendly();

        CmykNoProfileToRgbWithColorManagement();
        CmykNoProfileToRgbWithColorManagementMemoryFriendly();

        GrayscaleToRgbNoColorManagement();
        GrayscaleToRgbNoColorManagementMemoryFriendly();

        ConvertTo24bppRgb("../../../../_Input/Stamp.png", "../../../../_Output/ConvertTo24bppRgb_FromRGBWithAlpha.jpg");
        ConvertTo24bppRgbMemoryFriendly("../../../../_Input/Stamp.png", "../../../../_Output/ConvertTo24bppRgb_FromRGBWithAlpha_MemoryFriendly.jpg");

        ConvertTo24bppRgb("../../../../_Input/Copenhagen_Grayscale.jpg", "../../../../_Output/ConvertTo24bppRgb_FromGrayscale.jpg");
        ConvertTo24bppRgbMemoryFriendly("../../../../_Input/Copenhagen_Grayscale.jpg", "../../../../_Output/ConvertTo24bppRgb_FromGrayscale_MemoryFriendly.jpg");

        ConvertTo24bppRgb("../../../../_Input/Copenhagen_CMYK.jpg", "../../../../_Output/ConvertTo24bppRgb_FromCMYK.jpg");
        ConvertTo24bppRgbMemoryFriendly("../../../../_Input/Copenhagen_CMYK.jpg", "../../../../_Output/ConvertTo24bppRgb_FromCMYK_MemoryFriendly.jpg");
    }

    /// <summary>
    /// Converts color space from CMYK to RGB without color management
    /// </summary>
    private static void CmykToRgbNoColorManagement()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_CMYK.jpg"))
        {
            bitmap.ColorManagement.Convert(PixelFormat.Format24bppRgb);

            bitmap.Save("../../../../_Output/CmykToRgbNoColorManagement.jpg");
        }
    }

    /// <summary>
    /// Converts color space from CMYK to RGB without color management using memory-friendly Pipeline API
    /// </summary>
    private static void CmykToRgbNoColorManagementMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_CMYK.jpg"))
        using (var converter = new ColorConverter(PixelFormat.Format24bppRgb))
        using (var writer = ImageWriter.Create("../../../../_Output/CmykToRgbNoColorManagementMemoryFriendly.jpg"))
        {
            Pipeline.Run(reader + converter + writer);
        }
    }

    /// <summary>
    /// Converts color space from CMYK to RGB with color management
    /// </summary>
    private static void CmykToRgbWithColorManagement()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_CMYK.jpg"))
        {
            bitmap.ColorManagement.DestinationProfile = ColorProfile.FromSrgb();

            bitmap.ColorManagement.Convert(PixelFormat.Format24bppRgb);

            bitmap.Save("../../../../_Output/CmykToRgbWithColorManagement.jpg");
        }
    }

    /// <summary>
    /// Converts color space from CMYK to RGB with color management using memory-friendly Pipeline API
    /// </summary>
    private static void CmykToRgbWithColorManagementMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_CMYK.jpg"))
        using (var converter = new ColorConverter(PixelFormat.Format24bppRgb))
        using (var writer = ImageWriter.Create("../../../../_Output/CmykToRgbWithColorManagementMemoryFriendly.jpg"))
        {
            converter.DestinationProfile = ColorProfile.FromSrgb();

            Pipeline.Run(reader + converter + writer);
        }
    }

    /// <summary>
    /// Converts color space from CMYK (no assigned color profile) to RGB without color management
    /// </summary>
    private static void CmykNoProfileToRgbNoColorManagement()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_CMYK_NoColorProfile.jpg"))
        {
            bitmap.ColorManagement.Convert(PixelFormat.Format24bppRgb);

            bitmap.Save("../../../../_Output/CmykNoProfileToRgbNoColorManagement.jpg");
        }
    }

    /// <summary>
    /// Converts color space from CMYK (no assigned color profile) to RGB without color management
    /// using memory-friendly Pipeline API
    /// </summary>
    private static void CmykNoProfileToRgbNoColorManagementMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_CMYK.jpg"))
        using (var converter = new ColorConverter(PixelFormat.Format24bppRgb))
        using (var writer = ImageWriter.Create("../../../../_Output/CmykNoProfileToRgbNoColorManagementMemoryFriendly.jpg"))
        {
            Pipeline.Run(reader + converter + writer);
        }
    }

    /// <summary>
    /// Converts color space from CMYK (no assigned color profile) to RGB with color management
    /// </summary>
    private static void CmykNoProfileToRgbWithColorManagement()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_CMYK_NoColorProfile.jpg"))
        {
            // Assign some default color profile
            if (bitmap.ColorProfile == null)
            {
                bitmap.ColorProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc");
            }

            bitmap.ColorManagement.DestinationProfile = ColorProfile.FromSrgb();

            bitmap.ColorManagement.Convert(PixelFormat.Format24bppRgb);

            bitmap.Save("../../../../_Output/CmykNoProfileToRgbWithColorManagement.jpg");
        }
    }

    /// <summary>
    /// Converts color space from CMYK (no assigned color profile) to RGB with color management
    /// using memory-friendly Pipeline API
    /// </summary>
    private static void CmykNoProfileToRgbWithColorManagementMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_CMYK.jpg"))
        using (var converter = new ColorConverter(PixelFormat.Format24bppRgb))
        using (var writer = ImageWriter.Create("../../../../_Output/CmykNoProfileToRgbWithColorManagementMemoryFriendly.jpg"))
        {
            converter.DefaultSourceProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc");
            converter.DestinationProfile = ColorProfile.FromSrgb();

            Pipeline.Run(reader + converter + writer);
        }
    }

    /// <summary>
    /// Converts color space from grayscale to RGB without color management
    /// </summary>
    private static void GrayscaleToRgbNoColorManagement()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_Grayscale.jpg"))
        {
            bitmap.ColorManagement.Convert(PixelFormat.Format24bppRgb);

            bitmap.Save("../../../../_Output/GrayscaleToRgbNoColorManagement.jpg");
        }
    }

    /// <summary>
    /// Converts color space from grayscale to RGB without color management using memory-friendly Pipeline API
    /// </summary>
    private static void GrayscaleToRgbNoColorManagementMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_Grayscale.jpg"))
        using (var converter = new ColorConverter(PixelFormat.Format24bppRgb))
        using (var writer = ImageWriter.Create("../../../../_Output/GrayscaleToRgbNoColorManagementMemoryFriendly.jpg"))
        {
            Pipeline.Run(reader + converter + writer);
        }
    }

    /// <summary>
    /// Converts pixel format to Format24bppRgb (RGB, 8-bit per channel, no alpha channel)
    /// </summary>
    private static void ConvertTo24bppRgb(string inputPath, string outputPath)
    {
        using (var bitmap = new Bitmap(inputPath))
        {
            if (bitmap.PixelFormat.IsRgb && bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                bitmap.ColorManagement.BackgroundColor = RgbColor.White;

                // Assign some default color profile
                if (bitmap.ColorProfile == null)
                {
                    bitmap.ColorProfile = ColorProfile.FromSrgb();
                }

                bitmap.ColorManagement.DestinationProfile = ColorProfile.FromSrgb();

                bitmap.ColorManagement.Convert(PixelFormat.Format24bppRgb);
            }

            if (bitmap.PixelFormat.IsGrayscale)
            {
                bitmap.ColorManagement.BackgroundColor = new GrayscaleColor(255);

                // Assign some default color profile
                if (bitmap.ColorProfile == null)
                {
                    bitmap.ColorProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOnewspaper26v4_gr.icc");
                }

                bitmap.ColorManagement.DestinationProfile = ColorProfile.FromSrgb();

                bitmap.ColorManagement.Convert(PixelFormat.Format24bppRgb);
            }

            if (bitmap.PixelFormat.IsCmyk)
            {
                bitmap.ColorManagement.BackgroundColor = new CmykColor(0, 0, 0, 0, 255);

                // Assign some default color profile
                if (bitmap.ColorProfile == null)
                {
                    bitmap.ColorProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc");
                }

                bitmap.ColorManagement.DestinationProfile = ColorProfile.FromSrgb();

                bitmap.ColorManagement.Convert(PixelFormat.Format24bppRgb);
            }

            bitmap.Save(outputPath);
        }
    }

    /// <summary>
    /// Converts pixel format to Format24bppRgb (RGB, 8-bit per channel, no alpha channel) using memory-friendly Pipeline API
    /// </summary>
    private static void ConvertTo24bppRgbMemoryFriendly(string inputPath, string outputPath)
    {
        using (var reader = ImageReader.Create(inputPath))
        using (var converter = new ColorConverter(PixelFormat.Format24bppRgb))
        using (var writer = ImageWriter.Create(outputPath))
        {
            if (reader.PixelFormat.IsRgb && reader.PixelFormat != PixelFormat.Format24bppRgb)
            {
                converter.BackgroundColor = RgbColor.White;

                // Assign some default color profile
                converter.DefaultSourceProfile = ColorProfile.FromSrgb();
                converter.DestinationProfile = ColorProfile.FromSrgb();

                Pipeline.Run(reader + converter + writer);

                return;
            }

            if (reader.PixelFormat.IsGrayscale)
            {
                converter.BackgroundColor = new GrayscaleColor(255);

                // Assign some default color profile
                converter.DefaultSourceProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOnewspaper26v4_gr.icc");
                converter.DestinationProfile = ColorProfile.FromSrgb();

                Pipeline.Run(reader + converter + writer);

                return;
            }

            if (reader.PixelFormat.IsCmyk)
            {
                converter.BackgroundColor = new CmykColor(0, 0, 0, 0, 255);

                // Assign some default color profile
                converter.DefaultSourceProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc");
                converter.DestinationProfile = ColorProfile.FromSrgb();

                Pipeline.Run(reader + converter + writer);

                return;
            }

            // Or just copy file from inputPath to outputPath
            Pipeline.Run(reader + writer);
        }
    }
}