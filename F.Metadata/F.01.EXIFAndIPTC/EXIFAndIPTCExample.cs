using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class EXIFAndIPTCExample
{
	static void Main(string[] args)
	{
		ReadExifIptc();
		WriteExifIptc();
		WriteExifIptcMemoryFriendly();
	}


	/// <summary>
	/// Reads EXIF and IPTC metadata
	/// </summary>
	private static void ReadExifIptc()
	{
		using (var jpegReader = new JpegReader("../../../../_Input/Venice.jpg"))
		{
			//Read metadata
			var exif = jpegReader.Exif;
			var iptc = jpegReader.Iptc;

			//Show EXIF tags
			if (exif != null)
			{
				Console.WriteLine("EXIF");
				Console.WriteLine("---------------");
				foreach (object key in exif.Keys)
				{
					Console.WriteLine("{0}: {1}, {2}", exif.GetKeyDescription(key),
						exif[key], exif.GetItemString(key));
				}
			}

			//Show IPTC tags
			if (iptc != null)
			{
				Console.WriteLine("IPTC");
				Console.WriteLine("---------------");
				foreach (long key in iptc.Keys)
				{
					Console.WriteLine("{0}: {1}, {2}", iptc.GetKeyDescription(key),
						iptc[key], iptc.GetItemString(key));
				}
			}
		}
	}


	/// <summary>
	/// Writes EXIF and IPTC metadata
	/// </summary>
	private static void WriteExifIptc()
	{
		using (var bitmap = new Aurigma.GraphicsMill.Bitmap("../../../../_Input/Chicago.jpg"))
		{
			var settings = new Aurigma.GraphicsMill.Codecs.JpegSettings(70);

			var exif = new Aurigma.GraphicsMill.Codecs.ExifDictionary();
			exif[Aurigma.GraphicsMill.Codecs.ExifDictionary.Software] = "Aurigma Graphics Mill";
			settings.Exif = exif;

			var iptc = new Aurigma.GraphicsMill.Codecs.IptcDictionary();
			iptc[Aurigma.GraphicsMill.Codecs.IptcDictionary.Keyword] = "mountain";
			iptc[Aurigma.GraphicsMill.Codecs.IptcDictionary.City] = "Olympia";
			settings.Iptc = iptc;

			bitmap.Save("../../../../_Output/WriteExifIptc.jpg", settings);
		}

	}


	/// <summary>
	/// Writes EXIF and IPTC metadata using memory-friendly Pipeline API
	/// </summary>
	private static void WriteExifIptcMemoryFriendly()
	{
		using (var jpegReader = new JpegReader("../../../../_Input/Chicago.jpg"))
		using (var jpegWriter = new JpegWriter("../../../../_Output/WriteExifIptcMemoryFriendly.jpg", 70))
		{
			var exif = new Aurigma.GraphicsMill.Codecs.ExifDictionary();
			exif[Aurigma.GraphicsMill.Codecs.ExifDictionary.Software] = "Aurigma Graphics Mill";
			jpegWriter.Exif = exif;

			var iptc = new Aurigma.GraphicsMill.Codecs.IptcDictionary();
			iptc[Aurigma.GraphicsMill.Codecs.IptcDictionary.Keyword] = "mountain";
			iptc[Aurigma.GraphicsMill.Codecs.IptcDictionary.City] = "Olympia";
			jpegWriter.Iptc = iptc;

			Aurigma.GraphicsMill.Pipeline.Run(jpegReader + jpegWriter);
		}

	}




}

