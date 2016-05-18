using System;
using System.IO;
using System.Collections.Generic;

using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

class SmartImageOptimizationExample
{
    static void Main(string[] args)
    {
        const int maxAllowedSize = 1024 * 1024;   // 1 MB

        const string srcPath = "../../../../_Input/Venice.jpg";

        CallFitDimensionsToFileSize(srcPath, new JpegSettings(85, true, true), 
            maxAllowedSize, "../../../../_Output/Venice_optimal_size.jpg");

        CallFitDimensionsToFileSize(srcPath, new TiffSettings(CompressionType.Lzw), 
            maxAllowedSize, "../../../../_Output/Venice_optimal_size.tif");

        CallFitDimensionsToFileSize(srcPath, new PngSettings(false), 
            maxAllowedSize, "../../../../_Output/Venice_optimal_size.png");

        CallFitDimensionsToFileSize(srcPath, new EpsSettings(CompressionType.Jpeg, 85), 
            maxAllowedSize, "../../../../_Output/Venice_optimal_size.eps");

        CallFitDimensionsToFileSize(srcPath, new TgaSettings(CompressionType.Rle, true), 
            maxAllowedSize, "../../../../_Output/Venice_optimal_size.tga");

        CallFitJpegQualityToFileSize(srcPath, maxAllowedSize, "../../../../_Output/Venice_optimal_quality.jpg");
    }

    /// <summary>
    /// Calls FitDimensionsToFileSize method and writes result info to console
    /// </summary>
    private static void CallFitDimensionsToFileSize(string srcPath, WriterSettings settings, long maxAllowedSize, string dstPath)
    {
        Console.WriteLine("Fit image dimensions to {0}", FormatFileSize(maxAllowedSize));

        using (var reader = ImageReader.Create(srcPath))
        {
            Console.WriteLine("Source: \n  - Dimensions: {0} x {1}\n  - Format: {2}",
                reader.Width, reader.Height, reader.FileFormat);
        }

        FitDimensionsToFileSize(srcPath, settings, maxAllowedSize, dstPath);

        Console.WriteLine("Destination:\n  - Format: {0}\n  - File size: {1}", 
            settings.Format, FormatFileSize(new FileInfo(dstPath).Length));
        
        var unsupportedFormats = new List<FileFormat>{ FileFormat.Eps, FileFormat.Pdf };

        if (!unsupportedFormats.Contains(settings.Format))
        {
            using (var reader = ImageReader.Create(dstPath))
                Console.WriteLine("  - Dimensions: {0} x {1}", reader.Width, reader.Height);
        }

        Console.WriteLine();
    }

    /// <summary>
    /// Calls FitJpegQualityToFileSize method and writes result info to console
    /// </summary>
    private static void CallFitJpegQualityToFileSize(string srcPath, long maxAllowedSize, string dstPath)
    {
        Console.WriteLine("Fit jpeg quality to {0}", FormatFileSize(maxAllowedSize));

        using (var reader = ImageReader.Create(srcPath))
            Console.WriteLine("Source:\n  - Dimensions {0} x {1}\n  - Format: {2}", reader.Width, reader.Height, reader.FileFormat);

        FitJpegQualityToFileSize(srcPath, maxAllowedSize, dstPath);

        Console.WriteLine("Destination:\n  - File size: {0}", FormatFileSize(new FileInfo(dstPath).Length));

        using (var reader = ImageReader.Create(dstPath))
            Console.WriteLine("  - Dimensions: {0} x {1}", reader.Width, reader.Height);
        
        Console.WriteLine();
    }

    /// <summary>
    /// A wrapper for FitDimensionsToFileSize method with path arguments
    /// </summary>
    public static void FitDimensionsToFileSize(string srcPath, WriterSettings settings, long maxAllowedSize, string dstPath)
    {
        using (var srcStream = new FileStream(srcPath, FileMode.Open, FileAccess.Read))
        using (var dstStream = new FileStream(dstPath, FileMode.Create, FileAccess.Write))
        {
            FitDimensionsToFileSize(srcStream, settings, maxAllowedSize, dstStream);
        }
    }
    
    /// <summary>
    /// Incrementally applies a resize transform to fit encoded image into maxAllowedSize limit
    /// </summary>
    public static void FitDimensionsToFileSize(Stream srcStream, WriterSettings settings, long maxAllowedSize, Stream dstStream)
    {
        float scale = 1.0f;
        const float minScale = 0.98f;

        var ms = ResizeImageToMemoryStream(srcStream, scale, settings);

        try
        {
            while (ms.Length > maxAllowedSize)
            {
                scale *= (float)(Math.Min(Math.Sqrt((float)maxAllowedSize / (float)ms.Length), minScale));

                ms.Dispose();
                ms = ResizeImageToMemoryStream(srcStream, scale, settings);
            }

            ms.WriteTo(dstStream);
        }
        finally
        {
            ms.Dispose();
        } 
    }

    /// <summary>
    /// A wrapper for FitJpegQualityToFileSize method with path arguments
    /// </summary>
    public static void FitJpegQualityToFileSize(string srcPath, long maxAllowedSize, string dstPath)
    {
        using (var srcStream = new FileStream(srcPath, FileMode.Open, FileAccess.Read))
        using (var dstStream = new FileStream(dstPath, FileMode.Create, FileAccess.Write))
        {
            FitJpegQualityToFileSize(srcStream, maxAllowedSize, dstStream);
        }
    }

    /// <summary>
    /// Tries to encode an image with different JPEG qualities and calls 
    /// FitDimensionsToFileSize if reducing the quality is not enough
    /// </summary>
    public static void FitJpegQualityToFileSize(Stream srcStream, long maxAllowedSize, Stream dstStream)
    {
        const int minQuality = 50;
        const int maxQuality = 90;

        const int step = 10;

        for (int quality = maxQuality; quality >= minQuality; quality -= step)
        {
            using (var ms = ResizeImageToMemoryStream(srcStream, 1.0f, new JpegSettings(quality)))
            {
                if (ms.Length < maxAllowedSize)
                {
                    ms.WriteTo(dstStream);
                    return;
                }
            }
        }

        FitDimensionsToFileSize(srcStream, new JpegSettings(minQuality), maxAllowedSize, dstStream);
    }

    /// <summary>
    /// Resizes an image and gets a result as a memory stream
    /// </summary>
    private static MemoryStream ResizeImageToMemoryStream(Stream stream, float scale, WriterSettings settings)
    {
        var ms = new MemoryStream();

        using (var reader = ImageReader.Create(stream))
        using (var writer = ImageWriter.Create(ms, settings))
        using (var resize = new Resize((int)(reader.Width * scale), (int)(reader.Height * scale)))
        {
            Pipeline.Run(reader + resize + writer);
            writer.Close();
        }

        return ms;
    }

    /// <summary>
    /// Formats file size string
    /// </summary>
    private static string FormatFileSize(long fileSize)
    {
        return string.Format("{0:0.##} KB", fileSize / 1024);
    }
}
