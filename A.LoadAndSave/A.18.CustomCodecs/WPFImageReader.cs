using System.Collections.Generic;
using System.Windows.Media.Imaging;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;

/// <summary>
/// Implementation of IImageReader interface with WPF.
/// Short and simple, no support for ColorProfile, IndexedFormat, no checking for arguments.
/// </summary>
public sealed class WPFImageReader : IImageReader, IImageParams
{
    private BitmapSource bitmapSource;

    public WPFImageReader(System.IO.Stream stream)
    {
        this.bitmapSource = BitmapFrame.Create(stream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);
    }

    public Aurigma.GraphicsMill.Ink Ink
    {
        get
        {
            return null;
        }
    }

    public ColorPalette Palette
    {
        get
        {
            return null;
        }
    }

    public ColorProfile ColorProfile
    {
        get
        {
            return null;
        }
    }

    public float DpiX
    {
        get
        {
            return (float)this.bitmapSource.DpiX;
        }
    }

    public float DpiY
    {
        get
        {
            return (float)this.bitmapSource.DpiY;
        }
    }

    public PixelFormat PixelFormat
    {
        get
        {
            return ConvertFormat(this.bitmapSource.Format);
        }
    }

    public int Height
    {
        get
        {
            return this.bitmapSource.PixelHeight;
        }
    }

    public int Width
    {
        get
        {
            return this.bitmapSource.PixelWidth;
        }
    }

    public ImageParams GetImageParams()
    {
        return ImageParams.Create(this);
    }

    public Bitmap GetStripe(int stripeY, int stripeHeight)
    {
        // In production, it makes sense to consider more sophisticated logic 
        // for disposing stripe bitmaps. The possible approach is to dispose 
        // the previous stripe with generating the next one.
        var stripe = new Bitmap(this.Width, stripeHeight, this.PixelFormat);

        stripe.DpiX = this.DpiX;
        stripe.DpiY = this.DpiY;

        this.bitmapSource.CopyPixels(new System.Windows.Int32Rect(0, stripeY, stripe.Width, stripe.Height), stripe.Scan0, stripe.Stride * stripe.Height, stripe.Stride);

        return stripe;
    }

    /// <summary>
    /// Converts WPF pixel format to corresponding one for Graphics Mill.
    /// </summary>
    private static PixelFormat ConvertFormat(System.Windows.Media.PixelFormat format)
    {
        var dict = new Dictionary<System.Windows.Media.PixelFormat, Aurigma.GraphicsMill.PixelFormat>
        {
            { System.Windows.Media.PixelFormats.Bgr24, Aurigma.GraphicsMill.PixelFormat.Format24bppRgb },
            { System.Windows.Media.PixelFormats.Bgr32, Aurigma.GraphicsMill.PixelFormat.Format32bppRgb },
            { System.Windows.Media.PixelFormats.Bgra32, Aurigma.GraphicsMill.PixelFormat.Format32bppArgb },
            { System.Windows.Media.PixelFormats.Gray8, Aurigma.GraphicsMill.PixelFormat.Format8bppGrayscale },
            { System.Windows.Media.PixelFormats.Gray16, Aurigma.GraphicsMill.PixelFormat.Format16bppGrayscale },
        };

        if (!dict.ContainsKey(format))
        {
            throw new Aurigma.GraphicsMill.UnsupportedPixelFormatException();
        }

        return dict[format];
    }
}