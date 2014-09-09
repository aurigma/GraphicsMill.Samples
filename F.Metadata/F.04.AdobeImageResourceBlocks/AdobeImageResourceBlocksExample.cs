using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class AdobeImageResourceBlocksExample
{
	static void Main(string[] args)
	{
		WriteAdobeResourceBlock(@"../../../../_Input/Chicago.jpg", @"../../../../_Output/Chicago_AdobeResourceBlock.jpg");
		WriteAdobeResourceBlock(@"../../../../_Input/Venice.jpg", @"../../../../_Output/Venice_AdobeResourceBlock.jpg");
	}

    /// <summary>
    /// Write copyright XMP block
    /// </summary>
	private static void WriteAdobeResourceBlock(string inputPath, string outputPath)
	{
		using (var reader = new JpegReader(inputPath))
        using (var writer = new JpegWriter(outputPath))
		{
			var adobeResources = reader.AdobeResources;
			if (adobeResources == null)
			{
				adobeResources = new AdobeResourceDictionary();
			}

			// Create new adobe image resource block with the required metadata
			var arBlock = new AdobeResourceBlock("Copyright", new byte[] { 1 });
			// Set this block to the item with 0x040A ID (copyright flag)
			adobeResources[0x040A] = arBlock;
			// Remove a block with 0x0409 (thumbnail data)
			adobeResources.Remove(0x0409);

			writer.AdobeResources = adobeResources;
			Pipeline.Run(reader + writer);
		}
	}
}
