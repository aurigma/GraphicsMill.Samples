using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

internal class DeviceLinkProfileExample
{
    private static void Main(string[] args)
    {
        CmykToCmykUsingDeviceLinkProfile();
    }

    /// <summary>
    /// Converts one CMYK color space to another CMYK one using device link color profile
    /// </summary>
    private static void CmykToCmykUsingDeviceLinkProfile()
    {
        // Source image with the "ISO Coated v2" color profile
        using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_CMYK.jpg"))
        using (var converter = new ColorConverter(PixelFormat.Format32bppCmyk))
        using (var writer = ImageWriter.Create("../../../../_Output/DeviceLinkProfile.jpg"))
        {
            converter.ColorManagementEngine = ColorManagementEngine.LittleCms;

            // Device link profile is used for color conversion
            converter.DeviceLinkProfile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_to_PSOcoated_v3_DeviceLink.icc");

            // Destination profile is just embedded into the result image. It is not used for color conversion.
            converter.DestinationProfile = new ColorProfile("../../../../_Input/ColorProfiles/PSOcoated_v3.icc");

            Pipeline.Run(reader + converter + writer);
        }
    }
}