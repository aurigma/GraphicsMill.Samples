using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Codecs.Psd;
using Aurigma.GraphicsMill.Transforms;

internal class ValidatePsdExample
{
    private static void Main(string[] args)
    {
        CheckPsdFeatures();
        CheckPsdFeaturesWithOutput();
        CheckPsdFeaturesWithCustomOutput();
    }

    /// <summary>
    /// Checks that PSD files contain only features from a predefined list
    /// </summary>
    private static void CheckPsdFeatures()
    {
        var filenames = new string[] 
        { 
            "Mug.psd", 
            "UnsupportedFeature.psd"
        };

        // A list of features that can be correctly handled by a renderer

        var renderSupportedFeatures = new PsdFeature[] 
        { 
            PsdFeature.LayerTypeRaster, 
            PsdFeature.LayerTypeSmartObject, 
            PsdFeature.BlendModeNormal, 
            PsdFeature.ColorModeRgb, 
            PsdFeature.ChannelSize8bit 
        };

        foreach (var filename in filenames)
        {
            using (var psdReader = new PsdReader("../../../../_Input/" + filename))
            {
                if (psdReader.CheckFeatures(renderSupportedFeatures))
                    Console.WriteLine("File {0} is valid", filename);
                else
                    Console.WriteLine("File {0} is not valid", filename);
            }
        }                
    }

    /// <summary>
    /// Writes a message with a list of unsupported features
    /// </summary>
    private static void CheckPsdFeaturesWithOutput()
    {
        using (var psdReader = new PsdReader("../../../../_Input/UnsupportedFeature.psd"))
        {
            var renderSupportedFeatures = new PsdFeature[] 
            { 
                PsdFeature.LayerTypeRaster, 
                PsdFeature.BlendModeNormal, 
                PsdFeature.ColorModeRgb, 
                PsdFeature.ChannelSize8bit
            };
            
            string output = string.Empty;
            psdReader.CheckFeatures(renderSupportedFeatures, ref output);

            Console.WriteLine(output);
        }
    }

    /// <summary>
    /// Uses custom messages in the output string
    /// </summary>
    private static void CheckPsdFeaturesWithCustomOutput()
    {
        using (var psdReader = new PsdReader("../../../../_Input/UnsupportedFeature.psd"))
        {
            var renderSupportedFeatures = new PsdFeature[] 
            { 
                PsdFeature.LayerTypeRaster, 
                PsdFeature.BlendModeNormal, 
                PsdFeature.ColorModeRgb, 
                PsdFeature.ChannelSize8bit
            };
           
            string output = string.Empty;
            var rm = new System.Resources.ResourceManager("ValidatePsd.Properties.CheckPsdFeatures", System.Reflection.Assembly.GetExecutingAssembly());            
            psdReader.CheckFeatures(renderSupportedFeatures, ref output, rm);

            Console.WriteLine(output);
        }
    }
}
