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

        CreateBusinessCard();
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

    /// <summary>
    /// Creates business card in PDF format
    /// </summary>
    private static void CreateBusinessCard()
    {
        using (var writer = new PdfWriter("../../../../_Output/CreateBusinessCard.pdf"))
        {
            int width = 353;
            int height = 200;

            writer.AddPage(width, height, RgbColor.White);
        
            using (var graphics = writer.GetGraphics())
            {

                var blueBrush = new SolidBrush(RgbColor.DeepSkyBlue);

                //Draw circle
                graphics.DrawEllipse(new Pen(RgbColor.DeepSkyBlue, 2f), 15, 20, 30, 30);


                //Draw text
                var font = graphics.CreateFont("Arial", 18f);
                var text = new PlainText("Front side", font, new SolidBrush(RgbColor.Gray),
                    90, 40f, TextAlignment.Center);
                graphics.DrawText(text);

                font = graphics.CreateFont("Arial", 16f);
                text = new PlainText("<span style=\"color:DeepSkyBlue;font-size:16pt\">John Doe\n</span><span style=\"color:gray;font-size:16pt\">General Manager</span>", font, blueBrush, 340, 100f, TextAlignment.Right);

                graphics.DrawText(text);

                graphics.FillRectangle(blueBrush, 0, height - 50, width, 50);

                font = graphics.CreateFont("Arial", 12f);
                text = new PlainText(@"123.4567.890
info@website.com", font, new SolidBrush(RgbColor.White), 15, 170, TextAlignment.Left);

                graphics.DrawText(text);

                text = new PlainText(@"335 Cloverfield Blvd
Charlington, NY 10123", font, new SolidBrush(RgbColor.White), 200, 170, TextAlignment.Left);

                graphics.DrawText(text);

                writer.AddPage(width, height, RgbColor.DeepSkyBlue);

                graphics.DrawEllipse(new Pen(RgbColor.White, 3f), 45, 72, 55, 55);

                font = graphics.CreateFont("Arial", 36);

                text = new PlainText("Back side", font, new SolidBrush(RgbColor.White), 120, 115f, TextAlignment.Left);
                graphics.DrawText(text);
            }
        }
    }
}

