using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.AdvancedDrawing.Art;
using Aurigma.GraphicsMill.Codecs;

class PDFAndEPSOutputExample
{
	static void Main(string[] args)
	{
		GenerateRgbPdf();
		GenerateCmykEps();
	}


	public static void GenerateRgbPdf()
	{
		var dpi = 300f;

		using (var pdfWriter = new PdfWriter("../../../../_Output/PDFAndEPSOutput.pdf"))
		{
			//Front side 3.5"×2.5" size
			pdfWriter.AddPage(UnitConverter.ConvertUnitsToPixels(dpi, 3.5f, Unit.Inch),
				UnitConverter.ConvertUnitsToPixels(dpi, 2.0f, Unit.Inch), dpi, dpi);

			using (var graphics = pdfWriter.GetGraphics())
			{
				//Pen 1pt width
				var pen = new Pen(RgbColor.Red, UnitConverter.ConvertUnitsToPixels(dpi, 1.0f, Unit.Point));

				//Rectangle
				graphics.DrawRectangle(pen, UnitConverter.ConvertUnitsToPixels(dpi, 0.125f, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 0.125f, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 3.5f - 0.125f * 2, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 2 - 0.125f * 2, Unit.Inch));

				//Image
				using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
				{
					graphics.DrawImage(bitmap, new System.Drawing.RectangleF(
						UnitConverter.ConvertUnitsToPixels(dpi, 0.25f, Unit.Inch),
						UnitConverter.ConvertUnitsToPixels(dpi, 0.75f, Unit.Inch),
						UnitConverter.ConvertUnitsToPixels(dpi, 0.25f + 0.5f * (float)bitmap.Height / (float)bitmap.Width, Unit.Inch),
						UnitConverter.ConvertUnitsToPixels(dpi, 1.25f, Unit.Inch)));
				}

				//Text
				var font = graphics.CreateFont("Arial", 32f);
				var text = new PlainText("Front Side", font, new SolidBrush(RgbColor.Navy));
				text.Alignment = TextAlignment.Left;
				text.Position = new System.Drawing.PointF(UnitConverter.ConvertUnitsToPixels(dpi, 1.125f, Unit.Inch)
					, UnitConverter.ConvertUnitsToPixels(dpi, 1.125f, Unit.Inch));
				graphics.DrawText(text);
			}

			//Back side	3.5"×2.5" size
			pdfWriter.AddPage(UnitConverter.ConvertUnitsToPixels(dpi, 3.5f, Unit.Inch),
				UnitConverter.ConvertUnitsToPixels(dpi, 2.0f, Unit.Inch), dpi, dpi);

			using (var graphics = pdfWriter.GetGraphics())
			{
				//Pen 0.5pt width
				var pen = new Pen(RgbColor.Blue, UnitConverter.ConvertUnitsToPixels(dpi, 0.5f, Unit.Point));

				graphics.DrawRectangle(pen, UnitConverter.ConvertUnitsToPixels(dpi, 0.125f, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 0.125f, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 3.5f - 0.125f * 2, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 2 - 0.125f * 2, Unit.Inch));

				//Artistic (bridge) text
				var font = graphics.CreateFont("Times New Roman", "Italic", 24f);
				var bridgeText = new BridgeText("Back Side", font, new SolidBrush(RgbColor.Green));
				bridgeText.Bend = 0.2f;
				bridgeText.Center = new System.Drawing.PointF(UnitConverter.ConvertUnitsToPixels(dpi, 3.5f / 2, Unit.Inch)
					, UnitConverter.ConvertUnitsToPixels(dpi, 1f, Unit.Inch));
				graphics.DrawText(bridgeText);
			}
		}	
	}


	public static void GenerateCmykEps()
	{
		var dpi = 300f;

		using (var epsWriter = new EpsWriter("../../../../_Output/PDFAndEPSOutput.eps", UnitConverter.ConvertUnitsToPixels(dpi, 3.5f, Unit.Inch),
				UnitConverter.ConvertUnitsToPixels(dpi, 2.0f, Unit.Inch)
				, dpi, dpi))
		{
			using (var graphics = epsWriter.GetGraphics())
			{
				//Pen 1pt width
				var pen = new Pen(new CmykColor(0, 255, 255, 0), UnitConverter.ConvertUnitsToPixels(dpi, 1.0f, Unit.Point));

				//Rectangle
				graphics.DrawRectangle(pen, UnitConverter.ConvertUnitsToPixels(dpi, 0.125f, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 0.125f, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 3.5f - 0.125f * 2, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 2 - 0.125f * 2, Unit.Inch));

				//Image
				using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
				{
					graphics.DrawImage(bitmap, new System.Drawing.RectangleF(
						UnitConverter.ConvertUnitsToPixels(dpi, 0.25f, Unit.Inch),
						UnitConverter.ConvertUnitsToPixels(dpi, 0.75f, Unit.Inch),
						UnitConverter.ConvertUnitsToPixels(dpi, 0.25f + 0.5f * (float)bitmap.Height / (float)bitmap.Width, Unit.Inch),
						UnitConverter.ConvertUnitsToPixels(dpi, 1.25f, Unit.Inch)));
				}

				//Text
				var font = graphics.CreateFont("Arial", 32f);
				var text = new PlainText("Front Side", font, new SolidBrush(RgbColor.Navy));
				text.Alignment = TextAlignment.Left;
				text.Position = new System.Drawing.PointF(UnitConverter.ConvertUnitsToPixels(dpi, 1.125f, Unit.Inch)
					, UnitConverter.ConvertUnitsToPixels(dpi, 1.125f, Unit.Inch));
				graphics.DrawText(text);
			}

		}
	}
}

