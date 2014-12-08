using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class ExtractTIFFPreviewFromEPSExample
{
	static void Main(string[] args)
	{
		ReadTiffPreviewFromEpsMemoryFriendly();
	}	


	/// <summary>
	/// Reads TIFF preview from EPS and saves to PNG using memory-friendly Pipeline API
	/// </summary>
	private static void ReadTiffPreviewFromEpsMemoryFriendly()
	{
		using (var reader = new EpsReader("../../../../_Input/Seal.eps"))
		using (var writer = new PngWriter("../../../../_Output/ReadTiffPreviewFromEpsMemoryFriendly.png"))
		{
			Pipeline.Run(reader + writer);
		}
	}
}

