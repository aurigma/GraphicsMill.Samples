﻿using System.Collections.Generic;

using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

internal class TIFFExtraChannelsExample
{
    private static void Main(string[] args)
    {
        /*
          http://www.graphicsmill.com/docs/gm/working-with-tiff-extra-channels.htm
        */

        PrepareExampleImages();

        WriteExtraChannel();
        ReadExtraChannel();
        WriteExtraChannelWithName();
    }

    /// <summary>
    /// Creates business card 3.5"x2.0" size with extra channel
    /// </summary>
    private static void WriteExtraChannel()
    {
        using (var reader = new TiffReader("../../../../_Output/BusinessCard_Base.tif"))
        using (var writer = new TiffWriter("../../../../_Output/BusinessCard.tif"))
        {
            // Load bitmap for the extra channel.
            // Note: image for extra channel must be grayscale and have the same dimensions and DPI as the source one.
            using (var extraBitmap = new Bitmap("../../../../_Output/BusinessCard_Extra.tif"))
            {
                // Create extra channel options based on extraBitmap.
                var extraChannel = new TiffExtraChannelEntry(extraBitmap, TiffChannelType.Alpha);

                writer.ExtraChannels.Add(extraChannel);
                Pipeline.Run(reader + writer);
            }
        }
    }

    /// <summary>
    /// Save extra channel's name to TIFF
    /// </summary>
    private static void WriteExtraChannelWithName()
    {
        string channelName = "MyChannelName";

        using (var reader = new TiffReader("../../../../_Output/BusinessCard_Base.tif"))
        using (var writer = new TiffWriter("../../../../_Output/BusinessCardExtraChannelWithName.tif"))
        using (var extraChannel = new Bitmap(reader.Width, reader.Height, PixelFormat.Format8bppGrayscale))
        {
            writer.ExtraChannels.Add(new TiffExtraChannelEntry(extraChannel, TiffChannelType.Color));

            var ar = new AdobeResourceDictionary();

            // https://www.adobe.com/devnet-apps/photoshop/fileformatashtml/
            const int unicodeAlphaNames = 0x0415;

            ar[unicodeAlphaNames] = ChannelNameToResource(channelName);
            writer.AdobeResources = ar;
            Pipeline.Run(reader + writer);
        }
    }

    private static AdobeResourceBlock ChannelNameToResource(string name)
    {
        var arr = new List<byte>();

        arr.AddRange(new byte[] { 0, 0 });
        arr.AddRange(new byte[] { 0, (byte)(name.Length + 1) });

        foreach (var ch in name)
        {
            arr.AddRange(new byte[] { 0, (byte)ch });
        }

        arr.AddRange(new byte[] { 0, 0 });

        return new AdobeResourceBlock(string.Empty, arr.ToArray());
    }

    /// <summary>
    /// Reads and saves extra channel
    /// </summary>
    private static void ReadExtraChannel()
    {
        using (var reader = new TiffReader("../../../../_Output/BusinessCard.tif"))
        {
            var bitmap = reader.Frames[0].ExtraChannels[0].GetBitmap();

            bitmap.Save("../../../../_Output/BusinessCard_ReadExtra.tif");
        }
    }

    /// <summary>
    /// Prepares example images for demonstration purposes only
    /// </summary>
    private static void PrepareExampleImages()
    {
        const float dpi = 150;

        using (var bitmap = new Bitmap("../../../../_Input/Copenhagen_CMYK.jpg"))
        {
            bitmap.Transforms.Resize((int)(3.5f * dpi), (int)(2.0f * dpi), ResizeInterpolationMode.High, ResizeMode.ImageFill);
            bitmap.DpiX = dpi;
            bitmap.DpiY = dpi;

            bitmap.Save("../../../../_Output/BusinessCard_Base.tif");

            // Create bitmap of extra channel (size and resolution of source and extra channel image should match)
            using (var extraBitmap = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format8bppGrayscale, new GrayscaleColor(0)))
            {
                extraBitmap.DpiX = dpi;
                extraBitmap.DpiY = dpi;

                using (var graphics = extraBitmap.GetAdvancedGraphics())
                {
                    var brush = new SolidBrush(new GrayscaleColor(255));

                    using (var plainText = new PlainText("Welcome!", graphics.CreateFont("Arial", "Bold", 40f), brush))
                    {
                        plainText.Position = new System.Drawing.PointF(extraBitmap.Width / 2, extraBitmap.Height / 2);
                        plainText.Alignment = TextAlignment.Center;
                        graphics.DrawText(plainText);
                    }
                }

                extraBitmap.Save("../../../../_Output/BusinessCard_Extra.tif");
            }
        }
    }
}