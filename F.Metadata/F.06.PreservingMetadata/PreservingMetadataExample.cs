using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

class PreservingMetadataExample
{
	static void Main(string[] args)
	{
		ResizeAndPreserveMetadata();
	}


	private static void ResizeAndPreserveMetadata()
	{
		using (var jpegReader = new JpegReader("../../../../_Input/Chicago.jpg"))
		using (var resizer = new Resize(jpegReader.Width / 2, 0))
		using (var jpegWriter = new JpegWriter("../../../../_Output/ResizeAndPreserveMetadata.jpg"))
		{
			// Read EXIF
			var exif = jpegReader.Exif;
			// Check if loaded image contains EXIF metadata
			if (exif == null)
			{
				exif = new ExifDictionary();
			}
			exif[ExifDictionary.Software] = "Aurigma Graphics Mill";

			// Read IPTC
			var iptc = jpegReader.Iptc;
			// Check if loaded image contains IPTC metadata
			if (iptc == null)
			{
				iptc = new IptcDictionary();
			}
			iptc[IptcDictionary.Keyword] = "mountain";

			// Read Adobe resource blocks
			var adobeResources = jpegReader.AdobeResources;
			// Check if loaded image contains Adobe image resource blocks
			if (adobeResources == null)
			{
				adobeResources = new AdobeResourceDictionary();
			}
			// Create new adobe image resource block containing copyright metadata
			var arBlock = new AdobeResourceBlock("Copyright", new byte[] { 1 });
			// Set this block to the item with 0x040A ID (copyright flag)
			adobeResources[0x040A] = arBlock;

			// Read XMP
			var xmp = new XmpData();
			//Check if loaded image contains XMP metadata
			if (jpegReader.Xmp != null)
			{
				xmp.Load(jpegReader.Xmp);
			}
			// Create a node containing dc:contributor metadata
			var node = new XmpValueNode(XmpNodeType.SimpleProperty, "John Doe", XmpTagNames.DCContributor);
			xmp.AddNode(node);

			// Write metadata
			jpegWriter.Exif = exif;
			jpegWriter.Iptc = iptc;
			jpegWriter.AdobeResources = adobeResources;
			jpegWriter.Xmp = xmp.Save();

			Pipeline.Run(jpegReader + resizer + jpegWriter);
		}
	}
}
