using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class ThumbnailFromEXIFExample
{
	static void Main(string[] args)
	{
		GetExifThumbnail();
	}


	private static void GetExifThumbnail()
	{
		using (var jpegReader = new JpegReader("../../../../_Input/Copenhagen_RGB.jpg"))
		using (var thumbnail = (Bitmap)jpegReader.Exif[ExifDictionary.Thumbnail])
		using (var jpegWriter = new JpegWriter("../../../../_Output/GetExifThumbnail.jpg"))
		{
			Pipeline.Run(thumbnail + jpegWriter);
		}
	}
}


