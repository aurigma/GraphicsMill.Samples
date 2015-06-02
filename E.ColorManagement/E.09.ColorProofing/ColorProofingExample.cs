using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class ColorProofingExample
{
    static void Main(string[] args)
    {
        ColorProofing();
    }

    /// <summary>
    /// Color proofing - (CMYK to RGB using destination (screen) and target device profile)
    /// </summary>
    private static void ColorProofing()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_CMYK.jpg"))
        using (var converter = new ColorConverter())
        using (var writer = ImageWriter.Create("../../../../_Output/ColorProofing.jpg"))
        {
            // LittleCMS is a default color management engine, so no need to specify it
            // converter.ColorManagementEngine = ColorManagementEngine.LittleCms;
            converter.DestinationProfile = ColorProfile.FromSrgb();
            converter.TargetDeviceProfile = new ColorProfile(@"../../../../_Input/ColorProfiles/ISOnewspaper26v4_gr.icc");

            Pipeline.Run(reader + converter + writer);
        }
    }
}

