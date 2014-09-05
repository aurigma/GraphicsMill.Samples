using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


namespace LosslessJPEGTransformsExample
{
	class Program
	{
		static void Main(string[] args)
		{
			RotateJpegLosslessly();
			FlipJpegLosslessly();
			CropJpegLosslessly();
			RecompressJpegPartially();
			UpdateJpegMetadataLosslessly();
		}


		/// <summary>
		/// Rotates JPEG image losslessly
		/// </summary>
		private static void RotateJpegLosslessly()
		{
			using (var losslessJpeg = new LosslessJpeg("../../../../_Input/Chicago.jpg"))
			{
				losslessJpeg.WriteRotated("../../../../_Output/RotateJpegLosslessly.jpg", 
					System.Drawing.RotateFlipType.Rotate90FlipNone);
			}
		}


		/// <summary>
		/// Flips JPEG image losslessly
		/// </summary>
		private static void FlipJpegLosslessly()
		{
			using (var losslessJpeg = new LosslessJpeg("../../../../_Input/Chicago.jpg"))
			{
				losslessJpeg.WriteRotated("../../../../_Output/FlipJpegLosslessly.jpg", 
					System.Drawing.RotateFlipType.RotateNoneFlipX);
			}
		}


		/// <summary>
		/// Crops JPEG image losslessly
		/// </summary>
		private static void CropJpegLosslessly()
		{
			using (var losslessJpeg = new LosslessJpeg("../../../../_Input/Chicago.jpg"))
			{
				losslessJpeg.WriteCropped("../../../../_Output/CropJpegLosslessly.jpg", 
					new System.Drawing.Rectangle(64, 40, 157, 117));
			}
		}


		/// <summary>
		/// Applies mosaic effect on region of image with partial JPEG recompression
		/// </summary>
		private static void RecompressJpegPartially()
		{
			var rect = new System.Drawing.Rectangle(264, 192, 264, 184);

			using (var patchBitmap = new Bitmap())
			{
				//Apply crop and mosaic transfroms
				using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
				using (var crop = new Crop(rect))
				using (var mosaic = new Mosaic(10, 10))
				{
					Aurigma.GraphicsMill.Pipeline.Run(reader + crop + mosaic + patchBitmap);
				}

				//Patch JPEG
				using (var losslessJpeg = new LosslessJpeg("../../../../_Input/Chicago.jpg"))
				{
					rect = losslessJpeg.AlignToMCUSize(rect, JpegAlignToSampleSizeMode.Patch);
					losslessJpeg.WritePatched("../../../../_Output/ResompressJpegPartially.jpg", rect.Location, patchBitmap);
				}
			}
		}


		/// <summary>
		/// Updates metdata of JPEG image without recompression
		/// </summary>
		private static void UpdateJpegMetadataLosslessly()
		{
			using (var losslessJpeg = new LosslessJpeg("../../../../_Input/Chicago.jpg"))
			{
				// IPTC
				if (losslessJpeg.Iptc == null)
				{
					losslessJpeg.Iptc = new IptcDictionary();
				}
				losslessJpeg.Iptc[IptcDictionary.Caption] = "Mountain";

				// EXIF
				if (losslessJpeg.Exif == null)
				{
					losslessJpeg.Exif = new ExifDictionary();
				}
				losslessJpeg.Exif[ExifDictionary.Software] = "Aurigma Graphics Mill";

				// XMP
				var xmp = new XmpData();
				if (losslessJpeg.Xmp != null)
				{
					xmp.Load(losslessJpeg.Xmp);
				}
				var node = new XmpValueNode(XmpNodeType.SimpleProperty, "John Doe", XmpTagNames.DCContributor);
				xmp.AddNode(node);
				losslessJpeg.Xmp = xmp.Save();

				// Adobe image resource blocks
				if (losslessJpeg.AdobeResources == null)
				{
					losslessJpeg.AdobeResources = new AdobeResourceDictionary();
				}

				var arBlock = new AdobeResourceBlock("Copyright", new byte[] { 1 });
				losslessJpeg.AdobeResources[0x040A] = arBlock;

				losslessJpeg.Write("../../../../_Output/UpdateJpegMetadataLosslessly.jpg");
			}
		}
	}
}
