using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

internal class ColorProfileExample
{
    private static void Main(string[] args)
    {
        ShowColorProfileInfo(ColorProfile.FromSrgb());
        ShowColorProfileInfo(new ColorProfile("../../../../_Input/ColorProfiles/ISOcoated_v2_eci.icc"));
        ShowColorProfileInfo(new ColorProfile("../../../../_Input/ColorProfiles/ISOnewspaper26v4_gr.icc"));

        GetEmbeddedProfile();
        GetEmbeddedProfileMemoryFriendly();

        SetEmbeddedProfile();

        RetainEmbeddedProfile();
        RetainEmbeddedProfileMemoryFriendly();
    }

    /// <summary>
    /// Shows information about color profile
    /// </summary>
    private static void ShowColorProfileInfo(ColorProfile colorProfile)
    {
        Console.WriteLine("\n## Color Profile Information #\n");
        Console.WriteLine("Model:         {0}", colorProfile.Model);
        Console.WriteLine("Description:   {0}", colorProfile.Description);
        Console.WriteLine("Manufacturer:  {0}", colorProfile.Manufacturer);
        Console.WriteLine("Copyright:     {0}", colorProfile.Copyright);
        Console.WriteLine("Device class:  {0}", colorProfile.DeviceClass);
        Console.WriteLine("Color space:   {0}", colorProfile.ColorSpace);
    }

    /// <summary>
    /// Gets and display information about embedded profile
    /// </summary>
    private static void GetEmbeddedProfile()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_CMYK.jpg"))
        {
            // Display the description of the embedded profile
            Console.WriteLine("ICC Profile description:" + bitmap.ColorProfile.Description);
        }
    }

    /// <summary>
    /// Gets and display information about embedded profile using memory-friendly Pipeline API
    /// </summary>
    private static void GetEmbeddedProfileMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_CMYK.jpg"))
        {
            // Bitmap isn't loaded to memory
            Console.WriteLine("ICC Profile description:" + reader.ColorProfile.Description);
        }
    }

    /// <summary>
    /// Sets embedded profile
    /// </summary>
    private static void SetEmbeddedProfile()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            bitmap.ColorProfile = ColorProfile.FromSrgb();

            bitmap.Save("../../../../_Output/SetEmbeddedProfile.jpg");
        }
    }

    /// <summary>
    /// Resizes and preserves embedded profile on saving
    /// </summary>
    private static void RetainEmbeddedProfile()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_CMYK.jpg"))
        {
            // bitmap.ColorProfile is automatically retained after modification of bitmap
            bitmap.Transforms.Resize(640, 0, ResizeInterpolationMode.High);

            bitmap.Save("../../../../_Output/RetainEmbeddedProfile.jpg");
        }
    }

    /// <summary>
    /// Resizes and preserves embedded profile on saving
    /// </summary>
    private static void RetainEmbeddedProfileMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_CMYK.jpg"))
        using (var resize = new Resize(640, 0, ResizeInterpolationMode.High))
        using (var writer = ImageWriter.Create("../../../../_Output/RetainEmbeddedProfileMemoryFriendly.jpg"))
        {
            // Color profile is automatically retained from reading to writing
            Pipeline.Run(reader + resize + writer);
        }
    }
}