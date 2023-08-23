using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

internal class ColorAdjustmentExample
{
    private static void Main(string[] args)
    {
        ChannelBalance();
        ChannelBalanceMemoryFriendly();

        AdjustHsl();
        AdjustHslMemoryFriendly();

        Desaturate();
        DesaturateMemoryFriendly();

        AdjustColorsUsingLab();
    }

    /// <summary>
    /// Modifies channel balance
    /// </summary>
    private static void ChannelBalance()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            // Pixel format specifies the order of channels
            // Example: Format24bppRgb - [Blue]|[Green]|[Red]
            // http://www.graphicsmill.com/docs/gm/accessing-pixel-data.htm#PixelsInMemory
            bitmap.ColorAdjustment.ChannelBalance(new float[] { 0.0f, 0.0f, 0.3f }, new float[] { 1f, 1f, 1f });

            bitmap.Save("../../../../_Output/ChannelBalance.jpg");
        }
    }

    /// <summary>
    /// Modifies channel balance using memory-friendly Pipeline API
    /// </summary>
    private static void ChannelBalanceMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
        using (var channelBalance = new ChannelBalance()
        {
            // Pixel format specifies the order of channels
            // Example: Format24bppRgb - [Blue]|[Green]|[Red]
            // http://www.graphicsmill.com/docs/gm/accessing-pixel-data.htm#PixelsInMemory
            Addends = new float[] { 0.0f, 0.0f, 0.3f },
        })
        using (var writer = ImageWriter.Create("../../../../_Output/ChannelBalanceMemoryFriendly.jpg"))
        {
            Pipeline.Run(reader + channelBalance + writer);
        }
    }

    /// <summary>
    /// Adjusts HSL (Hue-Saturation-Lightness) balance
    /// </summary>
    private static void AdjustHsl()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            bitmap.ColorAdjustment.AdjustHsl(0.2f, -0.1f, 0.1f);

            bitmap.Save("../../../../_Output/AdjustHsl.jpg");
        }
    }

    /// <summary>
    /// Adjusts HSL (Hue-Saturation-Lightness) balance using memory-friendly Pipeline API
    /// </summary>
    private static void AdjustHslMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
        using (var adjustHsl = new AdjustHsl(0.2f, -0.1f, 0.1f))
        using (var writer = ImageWriter.Create("../../../../_Output/AdjustHslMemoryFriendly.jpg"))
        {
            Pipeline.Run(reader + adjustHsl + writer);
        }
    }

    /// <summary>
    /// Desaturates image
    /// </summary>
    private static void Desaturate()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            bitmap.ColorAdjustment.Desaturate();

            bitmap.Save("../../../../_Output/Desaturate.jpg");
        }
    }

    /// <summary>
    /// Desaturates image using memory-friendly Pipeline API
    /// </summary>
    private static void DesaturateMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
        using (var desaturate = new Desaturate())
        using (var writer = ImageWriter.Create("../../../../_Output/DesaturateMemoryFriendly.jpg"))
        {
            Pipeline.Run(reader + desaturate + writer);
        }
    }

    /// <summary>
    /// Adjusts hue modifying [a] component of Lab color space
    /// </summary>
    private static void AdjustColorsUsingLab()
    {
        // L - lightness
        // a - green/red
        // b - blue/yellow

        using (var lChannel = new Bitmap())
        using (var aChannel = new Bitmap())
        using (var bChannel = new Bitmap())
        {
            using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
            using (var labConverter = new ColorConverter(PixelFormat.Format24bppLab))
            using (var splitter = new LabChannelSplitter())
            {
                splitter.L = lChannel;
                splitter.A = aChannel;
                splitter.B = bChannel;

                Pipeline.Run(reader + labConverter + splitter);
            }

            // Increase yellow
            bChannel.ColorAdjustment.ChannelBalance(new float[] { 0.1f }, new float[] { 1f });

            using (var combiner = new LabChannelCombiner())
            using (var rgbConverter = new ColorConverter(PixelFormat.Format24bppRgb))
            using (var writer = ImageWriter.Create("../../../../_Output/AdjustColorsUsingLab.jpg"))
            {
                combiner.L = lChannel;
                combiner.A = aChannel;
                combiner.B = bChannel;

                rgbConverter.DestinationProfile = ColorProfile.FromSrgb();

                Pipeline.Run(combiner + rgbConverter + writer);
            }
        }
    }
}