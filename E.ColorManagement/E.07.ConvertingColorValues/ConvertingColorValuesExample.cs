﻿using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Transforms;

internal class ConvertingColorValuesExample
{
    private static void Main(string[] args)
    {
        RgbToCmykWithColorManagement();
        CmykToRgbWithColorManagement();
        RgbToLabWithColorManagement();
        LabToCmykWithColorManagement();

        Console.WriteLine();

        RgbToCmykWithoutColorManagement();
        CmykToRgbWithoutColorManagement();
        RgbToLabWithoutColorManagement();
    }

    private static void RgbToCmykWithColorManagement()
    {
        RgbColor rgbColor = new RgbColor(253, 202, 12)
        {
            Profile = ColorProfile.FromSrgb(),
        };

        CmykColor cmykColor = rgbColor.To<CmykColor>("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc", transformationIntent: ColorTransformationIntent.Perceptual);

        Console.WriteLine("With color management: {0} to {1}", rgbColor, cmykColor);
    }

    private static void CmykToRgbWithColorManagement()
    {
        CmykColor cmykColor = new CmykColor(20, 42, 211, 40)
        {
            Profile = new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc"),
        };

        RgbColor rgbColor = cmykColor.To<RgbColor>(ColorProfile.FromSrgb());

        Console.WriteLine("With color management: {0} to {1}", cmykColor, rgbColor);
    }

    private static void RgbToLabWithColorManagement()
    {
        RgbColor rgbColor = new RgbColor(223, 210, 30)
        {
            Profile = ColorProfile.FromSrgb(),
        };

        LabColor labColor = rgbColor.To<LabColor>();

        Console.WriteLine("With color management: {0} to {1}", rgbColor, labColor);
    }

    private static void LabToCmykWithColorManagement()
    {
        LabColor labColor = new LabColor(179, -20, 29, 255);

        CmykColor cmykColor = labColor.To<CmykColor>("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc");

        Console.WriteLine("With color management: {0} to {1}", labColor, cmykColor);
    }

    private static void RgbToCmykWithoutColorManagement()
    {
        RgbColor rgbColor = new RgbColor(253, 202, 12);
        CmykColor cmykColor = new CmykColor(rgbColor);

        Console.WriteLine("Without color management: {0} to {1}", rgbColor, cmykColor);
    }

    private static void CmykToRgbWithoutColorManagement()
    {
        CmykColor cmykColor = new CmykColor(20, 42, 211, 40);
        RgbColor rgbColor = new RgbColor(cmykColor);

        Console.WriteLine("Without color management: {0} to {1}", cmykColor, rgbColor);
    }

    private static void RgbToLabWithoutColorManagement()
    {
        RgbColor rgbColor = new RgbColor(223, 210, 30);
        LabColor labColor = new LabColor(rgbColor);

        Console.WriteLine("Without color management: {0} to {1}", rgbColor, labColor);
    }    
}