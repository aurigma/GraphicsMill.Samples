using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

internal class ThumbnailFromEXIFExample
{
    private static void Main(string[] args)
    {
        GetExifThumbnail("../../../../_Input/Venice.jpg", "../../../../_Output/GetExifThumbnail.jpg");

        GetThumbnail("../../../../_Input/Venice.jpg", "../../../../_Output/Venice_Thumb.jpg", 100);
        GetThumbnail("../../../../_Input/Copenhagen_RGB.jpg", "../../../../_Output/Copenhagen_RGB_Thumb.jpg", 100);
        GetThumbnail("../../../../_Input/Copenhagen_CMYK.jpg", "../../../../_Output/Copenhagen_CMYK_Thumb.jpg", 100);
        GetThumbnail("../../../../_Input/Stamp.png", "../../../../_Output/Stamp_Thumb.jpg", 100);
    }

    /// <summary>
    /// Gets thumbnail of image from its EXIF metadata
    /// </summary>
    private static void GetExifThumbnail(string inputPath, string outputPath)
    {
        using (var jpegReader = new JpegReader(inputPath))
        using (var thumbnail = (Bitmap)jpegReader.Exif[ExifDictionary.Thumbnail])
        using (var jpegWriter = new JpegWriter(outputPath))
        {
            Pipeline.Run(thumbnail + jpegWriter);
        }
    }

    /// <summary>
    /// Gets thumbnail of image using different approaches (EXIF, JPEG scale, resize)
    /// </summary>
    private static void GetThumbnail(string inputPath, string outputPath, int thumbnailSize)
    {
        using (var reader = ImageReader.Create(inputPath))
        using (var converter = new ColorConverter(PixelFormat.Format24bppRgb))
        using (var resize = new Resize(thumbnailSize, thumbnailSize, ResizeInterpolationMode.High, ResizeMode.Fit))
        using (var jpegWriter = new JpegWriter(outputPath, 85))
        {
            if (reader.Width <= thumbnailSize && reader.Height <= thumbnailSize)
            {
                if (reader.PixelFormat == PixelFormat.Format24bppRgb)
                {
                    Pipeline.Run(reader + jpegWriter);
                }
                else
                {
                    Pipeline.Run(reader + converter + jpegWriter);
                }

                return;
            }

            var jpegReader = reader as JpegReader;

            if (jpegReader != null)
            {
                if (jpegReader.Exif.Contains(ExifDictionary.Thumbnail))
                {
                    using (var thumbnail = (Bitmap)jpegReader.Exif[ExifDictionary.Thumbnail])
                    {
                        if (thumbnail.Width > thumbnailSize || thumbnail.Height > thumbnailSize)
                        {
                            if (thumbnail.PixelFormat == PixelFormat.Format24bppRgb)
                            {
                                Pipeline.Run(thumbnail + resize + jpegWriter);
                            }
                            else
                            {
                                Pipeline.Run(thumbnail + resize + converter + jpegWriter);
                            }

                            return;
                        }
                    }
                }

                var size = Math.Max(jpegReader.Width, jpegReader.Height);

                const float k = 1.5f;

                if (size / 8 >= thumbnailSize * k)
                {
                    jpegReader.Scale = JpegScale.x8;
                }
                else if (size / 4 >= thumbnailSize * k)
                {
                    jpegReader.Scale = JpegScale.x4;
                }
                else if (size / 2 >= thumbnailSize * k)
                {
                    jpegReader.Scale = JpegScale.x2;
                }
            }

            if (reader.PixelFormat == PixelFormat.Format24bppRgb)
            {
                Pipeline.Run(reader + resize + jpegWriter);
            }
            else
            {
                Pipeline.Run(reader + resize + converter + jpegWriter);
            }
        }
    }
}