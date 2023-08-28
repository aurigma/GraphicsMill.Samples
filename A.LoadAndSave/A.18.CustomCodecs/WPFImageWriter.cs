using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media.Imaging;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;

/// <summary>
/// Implementation of IImageWriter interface with WPF.
/// Short and simple, no support for ColorProfile, IndexedFormat, no checking for arguments.
/// </summary>
public sealed class WPFImageWriter : IImageWriter
{
    private readonly Stream stream;
    private WriteableBitmap writeableBitmap;
    private int offset = 0;

    public WPFImageWriter(Stream stream)
    {
        this.stream = stream;
    }

    public void Init(ImageParams imageParams)
    {
        this.writeableBitmap = new WriteableBitmap(
            imageParams.Width,
            imageParams.Height,
            (double)imageParams.DpiX,
            (double)imageParams.DpiY,
            ConvertFormat(imageParams.PixelFormat),
            null);
    }

    public void WriteStripe(Bitmap stripe)
    {
        try
        {
            this.writeableBitmap.Lock();

            IntPtr backBufferLine = this.writeableBitmap.BackBuffer + (this.writeableBitmap.BackBufferStride * this.offset);

            IntPtr stripeLine = stripe.Scan0;

            unsafe
            {
                for (int i = 0; i < stripe.Height; i++)
                {
                    Buffer.MemoryCopy(stripeLine.ToPointer(), backBufferLine.ToPointer(), this.writeableBitmap.BackBufferStride, stripe.Stride);
                    backBufferLine += this.writeableBitmap.BackBufferStride;
                    stripeLine += stripe.Stride;
                }
            }
        }
        finally
        {
            this.writeableBitmap.Unlock();
        }

        this.offset += stripe.Height;

        if (this.offset == this.writeableBitmap.PixelHeight)
        {
            var encoder = new TiffBitmapEncoder();

            encoder.Compression = TiffCompressOption.Zip;
            encoder.Frames.Add(BitmapFrame.Create(this.writeableBitmap));

            encoder.Save(this.stream);
        }
    }

    /// <summary>
    /// Converts Graphics Mill pixel format to corresponding one for WPF.
    /// </summary>
    private static System.Windows.Media.PixelFormat ConvertFormat(Aurigma.GraphicsMill.PixelFormat format)
    {
        var dict = new Dictionary<Aurigma.GraphicsMill.PixelFormat, System.Windows.Media.PixelFormat>
        {
            { Aurigma.GraphicsMill.PixelFormat.Format24bppRgb, System.Windows.Media.PixelFormats.Bgr24 },
            { Aurigma.GraphicsMill.PixelFormat.Format32bppRgb, System.Windows.Media.PixelFormats.Bgr32 },
            { Aurigma.GraphicsMill.PixelFormat.Format32bppArgb, System.Windows.Media.PixelFormats.Bgra32 },
            { Aurigma.GraphicsMill.PixelFormat.Format8bppGrayscale, System.Windows.Media.PixelFormats.Gray8 },
            { Aurigma.GraphicsMill.PixelFormat.Format16bppGrayscale, System.Windows.Media.PixelFormats.Gray16 },
        };

        if (!dict.ContainsKey(format))
        {
            throw new Aurigma.GraphicsMill.UnsupportedPixelFormatException();
        }

        return dict[format];
    }
}