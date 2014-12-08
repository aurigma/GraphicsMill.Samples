using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

class AutototateExample
{
	static void Main(string[] args)
	{
		Autorotate("../../../../_Input/Gondola.jpg", "../../../../_Output/Autorotate.jpg");
	}


	/// <summary>
	/// Automatically rotates image based on EXIF orientation metadata
	/// </summary>
	public static bool Autorotate(string pathIn, string pathOut)
	{
		uint orientation;

		using (var reader = ImageReader.Create(pathIn))
		{
			var exif = reader.Exif;

			if (exif == null || !exif.Contains(ExifDictionary.Orientation))
			{
				return false;
			}

			orientation = (uint)(exif[ExifDictionary.Orientation]);

			//  1        2       3      4         5            6           7          8

			//######  ######      ##  ##      ##########  ##                  ##  ##########
			//##          ##      ##  ##      ##  ##      ##  ##          ##  ##      ##  ##
			//####      ####    ####  ####    ##          ##########  ##########          ##
			//##          ##      ##  ##
			//##          ##  ######  ######					

			if (orientation == 1)
			{
				return false;
			}

			using (var writer = ImageWriter.Create(pathOut))
			{
				if (!(reader is JpegReader) || !(writer is JpegWriter))
				{
					RotateWithRecompression(reader, writer, orientation);

					return true;
				}
			}
		}

		RotateJpegWithRecompression(pathIn, pathOut, orientation);

		return true;
	}


	private static void RotateWithRecompression(ImageReader reader, ImageWriter writer, uint orientation)
	{
		using (var rotate = new Aurigma.GraphicsMill.Transforms.Rotate())
		using (var flip = new Aurigma.GraphicsMill.Transforms.Flip())
		{
			flip.Type = Aurigma.GraphicsMill.Transforms.FlipType.None;

			switch (orientation)
			{
				case 2:
					flip.Type = Aurigma.GraphicsMill.Transforms.FlipType.Vertical;
					break;
				case 3:
					rotate.Angle = 180f;
					break;
				case 4:
					flip.Type = Aurigma.GraphicsMill.Transforms.FlipType.Vertical;
					rotate.Angle = 180f;
					break;
				case 5:
					flip.Type = Aurigma.GraphicsMill.Transforms.FlipType.Horizontal;
					rotate.Angle = 270f;
					break;
				case 6:
					rotate.Angle = 90f;
					break;
				case 7:
					flip.Type = Aurigma.GraphicsMill.Transforms.FlipType.Horizontal;
					rotate.Angle = 90f;
					break;
				case 8:
					rotate.Angle = 270;
					break;
			}


			var jpegWriter = writer as JpegWriter;

			if (jpegWriter != null)
			{
				jpegWriter.Quality = 85;
			}


			var metadataWriter = writer as IMetadataWriter;

			if (metadataWriter != null)
			{
				metadataWriter.Exif = reader.Exif ?? new ExifDictionary();
				metadataWriter.Exif[ExifDictionary.Orientation] = 1;

				metadataWriter.Iptc = reader.Iptc;
				metadataWriter.AdobeResources = reader.AdobeResources;
				metadataWriter.Xmp = reader.Xmp;
			}


			if (flip.Type == Aurigma.GraphicsMill.Transforms.FlipType.None)
			{
				Aurigma.GraphicsMill.Pipeline.Run(reader + rotate + writer);
			}
			else if (rotate.Angle == 0)
			{
				Aurigma.GraphicsMill.Pipeline.Run(reader + flip + writer);
			}
			else
			{
				Aurigma.GraphicsMill.Pipeline.Run(reader + rotate + flip + writer);
			}
		}
	}


	private static void RotateJpegWithRecompression(string pathIn, string pathOut, uint orientation)
	{
		using (var losslessJpeg = new LosslessJpeg(pathIn))
		{
			System.Drawing.RotateFlipType flipType;

			switch (orientation)
			{
				case 2:
					flipType = System.Drawing.RotateFlipType.RotateNoneFlipX;
					break;
				case 3:
					flipType = System.Drawing.RotateFlipType.Rotate180FlipNone;
					break;
				case 4:
					flipType = System.Drawing.RotateFlipType.Rotate180FlipX;
					break;
				case 5:
					flipType = System.Drawing.RotateFlipType.Rotate90FlipX;
					break;
				case 6:
					flipType = System.Drawing.RotateFlipType.Rotate90FlipNone;
					break;
				case 7:
					flipType = System.Drawing.RotateFlipType.Rotate270FlipX;
					break;
				case 8:
					flipType = System.Drawing.RotateFlipType.Rotate270FlipNone;
					break;
				default:
					flipType = System.Drawing.RotateFlipType.RotateNoneFlipNone;
					break;
			}

			losslessJpeg.Exif[ExifDictionary.Orientation] = 1;

			losslessJpeg.WriteRotated(pathOut, flipType);
		}
	}
}