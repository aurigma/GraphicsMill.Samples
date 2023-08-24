using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Aurigma.GraphicsMill;

public static class Extensions
{
    /// <summary>
    /// An extension to convert Graphics Mill Bitmap to WPF BitmapSource
    /// </summary>
    public static BitmapSource ToBitmapSource(this Bitmap bitmap)
    {
        return BitmapFrame.Create(
            bitmap.Width,
            bitmap.Height,
            bitmap.DpiX,
            bitmap.DpiY,
            ConvertFormat(bitmap.PixelFormat),
            null,
            bitmap.Scan0,
            bitmap.Stride * bitmap.Height,
            bitmap.Stride);
    }

    /// <summary>
    /// An extension to convert WPF BitmapFrame to Graphics Mill Bitmap
    /// </summary>
    public static Bitmap ToAurigmaBitmap(this BitmapFrame bitmapFrame)
    {
        var bitmap = new Bitmap(bitmapFrame.PixelWidth, bitmapFrame.PixelHeight, ConvertFormat(bitmapFrame.Format));

        bitmap.DpiX = (float)bitmapFrame.DpiX;
        bitmap.DpiY = (float)bitmapFrame.DpiY;

        bitmapFrame.CopyPixels(new System.Windows.Int32Rect(0, 0, bitmapFrame.PixelWidth, bitmapFrame.PixelHeight), bitmap.Scan0, bitmap.Stride * bitmap.Height, bitmap.Stride);

        return bitmap;
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

public class WPFInteroperabilityExample
{
    static void Main(string[] args)
    {
        ConvertToWPF();
        ConvertFromWPF();
    }

    /// <summary>
    /// Converts Graphics Mill Bitmap to WPF BitmapSource
    /// </summary>
    private static void ConvertToWPF()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            var bitmapSource = bitmap.ToBitmapSource();

            var encoder = new TiffBitmapEncoder();
            encoder.Compression = TiffCompressOption.Zip;
            encoder.Frames.Add(BitmapFrame.Create(bitmapSource));

            using (var fs = new FileStream("../../../../_Output/ChicagoSavedWithWPF.tif", FileMode.Create, FileAccess.ReadWrite, FileShare.Write))
            {
                encoder.Save(fs);
            }
        }
    }

    /// <summary>
    /// Converts WPF BitmapFrame to GraphicsMill Bitmap
    /// </summary>
    private static void ConvertFromWPF()
    {
        using (var fs = new FileStream(@"../../../../_Input/Chicago.jpg", FileMode.Open, FileAccess.Read, FileShare.Read))
        {
            /*
             There are not too many formats that can be converted with direct pixel copying.
             According to Microsoft documentation, with BitmapCreateOptions.None the PixelFormat
             of the image is chosen by the system depending on what the system determines will yield the best performance.
            */
            var bitmapFrame = BitmapFrame.Create(fs, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);

            using (var bitmap = bitmapFrame.ToAurigmaBitmap())
            {
                bitmap.Save(@"../../../../_Output/ChicagoSavedGotFromWPF.tif");
            }
        }
    }
}