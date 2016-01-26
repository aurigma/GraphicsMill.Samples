using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.Codecs.Psd;
using Aurigma.GraphicsMill.AdvancedDrawing;


class PngNeuQuantExample
{
	static void Main(string[] args)
	{
		SaveToPng("../../../../_Input/Chicago.jpg");

		Console.WriteLine("");
		
		SaveToPng("../../../../_Input/Stamp.png");
	}


	/// <summary>
	/// Saves image to PNG format using different bitness, color quantization and dithering algoritms.
	/// </summary>
	private static void SaveToPng(string sourceFileName)
	{
		//Source file information
		long sourceFileSize = new System.IO.FileInfo(sourceFileName).Length;

		Console.WriteLine("Source file:");
		Console.WriteLine("  {0}", sourceFileName);
		Console.WriteLine("  {0:f2} KB", sourceFileSize / 1024f);

		var baseName = System.IO.Path.GetFileNameWithoutExtension(sourceFileName);


		//Convert to 24-bit PNG 
		{
			var png24bitFileName = "../../../../_Output/" + baseName + "_24bit.png";

			//Save to PNG
			using (var bitmap = new Bitmap(sourceFileName))
			{
				bitmap.Save(png24bitFileName, new PngSettings(true));
			}

			long png24bitFileSize = new System.IO.FileInfo(png24bitFileName).Length;

			Console.WriteLine("PNG 24-bit:");
			Console.WriteLine("  {0}", png24bitFileName);
			Console.WriteLine("  {0:f2} KB ({1:f2}%)", (float)png24bitFileSize / 1024f
				, (float)png24bitFileSize / (float)sourceFileSize * 100f);
		}


		//Convert to 8-bit PNG using the Octree color quantization and Floyd–Steinberg dithering algorithms
		{
			var png8bitFileName = "../../../../_Output/" + baseName + "_8bit.png";

			//Save to PNG
			using (var bitmap = new Bitmap(sourceFileName))
			{
				bitmap.ColorManagement.Convert(PixelFormat.Format8bppIndexed);

				bitmap.Save(png8bitFileName, new PngSettings(true));
			}

			long png8bitFileSize = new System.IO.FileInfo(png8bitFileName).Length;

			Console.WriteLine("PNG 8-bit (Octree, Floyd–Steinberg, no alpha transparency):");
			Console.WriteLine("  {0}", png8bitFileName);
			Console.WriteLine("  {0:f2} KB ({1:f2}%)", (float)png8bitFileSize / 1024f
				, (float)png8bitFileSize / (float)sourceFileSize * 100f);
		}


		//Convert to 8-bit PNG using the Neuquant color quantization algorithm
		{
			var png8bitNeuQuantFileName = "../../../../_Output/" + baseName + "_8bit_NeuQuant.png";

			//Save to PNG
			using (var bitmap = new Bitmap(sourceFileName))
			{
				bitmap.ColorManagement.Palette = new ColorPalette(ColorPaletteType.NeuQuant);
				bitmap.ColorManagement.Convert(PixelFormat.Format8bppIndexed);

				bitmap.Save(png8bitNeuQuantFileName, new PngSettings(true));
			}

			long png8bitNeuQuantFileSize = new System.IO.FileInfo(png8bitNeuQuantFileName).Length;

			Console.WriteLine("PNG 8-bit (NeuQaunt, with alpha transparency):");
			Console.WriteLine("  {0}", png8bitNeuQuantFileName);
			Console.WriteLine("  {0:f2} KB ({1:f2}%)", (float)png8bitNeuQuantFileSize / 1024f
				, (float)png8bitNeuQuantFileSize / (float)sourceFileSize * 100f);
		}
	}
}
