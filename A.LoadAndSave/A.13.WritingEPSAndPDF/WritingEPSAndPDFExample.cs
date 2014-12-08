using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.AdvancedDrawing;


class WritingEPSAndPDFExample
{
	static void Main(string[] args)
	{
		WriteBitmapToPdf();
		WriteBitmapToPdfMemoryFriendly();
		WriteBitmapToEps();
		WriteBitmapToEpsMemoryFriendly();

		WriteRasterAndVectorGraphicsToPdf();
		WriteRasterAndVectorGraphicsToEps();
	}


	/// <summary>
	/// Saves bitmap to PDF format
	/// </summary>
	private static void WriteBitmapToPdf()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Save("../../../../_Output/WritePdf.pdf");
		}
	}


	/// <summary>
	/// Saved bitmap to PDF format using memory-friendly Pipeline API
	/// </summary>
	private static void WriteBitmapToPdfMemoryFriendly()
	{
		using (var reader = new JpegReader("../../../../_Input/Chicago.jpg"))
		using (var writer = new PdfWriter("../../../../_Output/WritePdfMemoryFriendly.pdf"))
		{
			Pipeline.Run(reader + writer);
		}
	}


	/// <summary>
	/// Saves bitmap to EPS format
	/// </summary>
	private static void WriteBitmapToEps()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Save("../../../../_Output/WriteEps.eps");
		}
	}


	/// <summary>
	/// Saved bitmap to EPS format using memory-friendly Pipeline API
	/// </summary>
	private static void WriteBitmapToEpsMemoryFriendly()
	{
		using (var reader = new JpegReader("../../../../_Input/Chicago.jpg"))
		using (var writer = new EpsWriter("../../../../_Output/WriteEpsMemoryFriendly.eps"))
		{
			Pipeline.Run(reader + writer);
		}
	}


	/// <summary>
	/// Saves raster and vector graphics to PDF format
	/// </summary>
	private static void WriteRasterAndVectorGraphicsToPdf()
	{
		using (var writer = new PdfWriter("../../../../_Output/WriteRasterAndVectorGraphicsToPdf.pdf"))
		{
			writer.AddPage(800, 650, RgbColor.White);

			using (var graphics = writer.GetGraphics())
			{
				//Draw bitmap
				using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
				{
					graphics.DrawImage(bitmap, 100f, 100f);
				}

				//Draw rectangle
				graphics.DrawRectangle(new Pen(RgbColor.Gray, 4f), 50f, 50f, 700f, 550f);

				//Draw text
				var font = graphics.CreateFont("Arial", 56f);
				var text = new PlainText("Confidential", font, new SolidBrush(RgbColor.OrangeRed),
					400f, 340f, TextAlignment.Center);
				graphics.DrawText(text);
			}
		}
	}


	/// <summary>
	/// Saves raster and vector graphics to EPS format
	/// </summary>
	private static void WriteRasterAndVectorGraphicsToEps()
	{
		using (var writer = new EpsWriter("../../../../_Output/WriteRasterAndVectorGraphicsToPdf.eps", 800, 650))
		using (var graphics = writer.GetGraphics())
		{
			//Draw bitmap
			using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
			{
				graphics.DrawImage(bitmap, 100f, 100f);
			}

			//Draw rectangle
			graphics.DrawRectangle(new Pen(RgbColor.Gray, 4f), 50f, 50f, 700f, 550f);

			//Draw text
			var font = graphics.CreateFont("Arial", 56f);
			var text = new PlainText("Confidential", font, new SolidBrush(RgbColor.OrangeRed),
				400f, 340f, TextAlignment.Center);
			graphics.DrawText(text);
		}

	}
}

