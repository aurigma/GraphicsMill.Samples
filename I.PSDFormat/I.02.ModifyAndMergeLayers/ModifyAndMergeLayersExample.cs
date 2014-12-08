using System;
using System.Linq;
using System.Text.RegularExpressions;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Codecs.Psd;
using Aurigma.GraphicsMill.AdvancedDrawing;
using System.Collections.Generic;


class ModifyAndMergeLayersExample
{
	static void Main(string[] args)
	{
		MergeLayersRaster();
		MergeLayersPDF();
		ModifyAndMergeLayers();
	}


	private static void MergeLayersRaster()
	{
		using (var psdReader = new PsdReader("../../../../_Input/BusinessCard.psd"))
		{
			using (var bitmap = new Bitmap(psdReader.Width, psdReader.Height, psdReader.PixelFormat, RgbColor.White)
			{
				DpiX = psdReader.DpiX,
				DpiY = psdReader.DpiY
			})
			{
				using (var graphics = bitmap.GetAdvancedGraphics())
				{
					MergeLayers(psdReader, graphics, GetLayerText);
				}

				bitmap.Save("../../../../_Output/ModifyAndMergeLayers.png");
			}
		}
	}


	private static void MergeLayersPDF()
	{
		using (var psdReader = new PsdReader("../../../../_Input/BusinessCard.psd"))
		{
			//The same approach can be used for EPS
			using (var pdfWriter = new PdfWriter("../../../../_Output/ModifyAndMergeLayers.pdf"))
			{
				pdfWriter.AddPage(psdReader.Width, psdReader.Height, psdReader.DpiX, psdReader.DpiY, RgbColor.White);

				using (var graphics = pdfWriter.GetGraphics())
				{
					MergeLayers(psdReader, graphics, GetLayerText);
				}
			}
		}
	}


	private static void ModifyAndMergeLayers()
	{
		var persons = new List<Dictionary<string, string>>() { 
			new Dictionary<string, string> {
				{ "Name", "Isaac Kerr" },
				{ "Address", "4112 East Bogard Road\nMontgomery, OH 44070" },
				{ "Phone", "202-555-0179" },
				{ "Email", "isaac.kerr@email.com" }
			},
			new Dictionary<string, string> {
				{ "Name", "Frank Manning" },
				{ "Address", "1719 Dog Hill Lane\nPayson, UT 84601" },
				{ "Phone", "801-555-0118" },
				{ "Email", "frank.manning@email.com" }
			},
			new Dictionary<string, string> {
				{ "Name", "Leah Bell" },
				{ "Address", "3243 Jerry Dove Drive\nRidgeland, MS 29410" },
				{ "Phone", "601-555-0112" },
				{ "Email", "leah.bell@email.com" }
			}
		};


		for (var i = 0; i < persons.Count; i++)
		{
			using (var psdReader = new PsdReader("../../../../_Input/BusinessCard.psd"))
			{
				using (var bitmap = new Bitmap(psdReader.Width, psdReader.Height, psdReader.PixelFormat, RgbColor.White)
				{
					DpiX = psdReader.DpiX,
					DpiY = psdReader.DpiY
				})
				{
					using (var graphics = bitmap.GetAdvancedGraphics())
					{
						MergeLayers(psdReader, graphics, 
							(PsdTextFrame textFrame) =>
							{
								return persons[i][textFrame.Name];
							});
					}

					bitmap.Save("../../../../_Output/ModifyAndMergeLayers_" + i+ ".png");
				}
			}
		}
	}


	private static void MergeLayers(PsdReader psdReader, Graphics graphics, Func<PsdTextFrame, string> getLayerText)
	{
		//Merge layers
		for (int i = 0; i < psdReader.Frames.Count; i++)
		{
			var frame = psdReader.Frames[i];

			if (frame.Type == FrameType.Text)
			{
				var textFrame = (PsdTextFrame)frame;

				var layerText = getLayerText(textFrame);

				Text text;

				var font = graphics.CreateFont(textFrame.FontName, textFrame.FontSize);

				if (textFrame.TextBox.Width == 0 || textFrame.TextBox.Height == 0)
				{
					text = new PlainText(layerText, font)
					{
						Position = new System.Drawing.PointF(textFrame.TextBox.Left, textFrame.TextBox.Top)
					};
				}
				else
				{
					text = new BoundedText(layerText, font)
					{
						Rectangle = textFrame.TextBox
					};
				}

				text.Alignment = JustificationToTextAlignment(textFrame.Justification);
				text.Brush = new SolidBrush(textFrame.Color);

				graphics.DrawText(text);
			}
			else if (frame.Type == FrameType.Raster)
			{
				using (var frameBitmap = frame.GetBitmap())
				{
					graphics.DrawImage(frameBitmap, frame.X, frame.Y);
				}
			}
		}
	}


	private static string GetLayerText(PsdTextFrame textFrame)
	{
		//Fix line break
		return textFrame.Text.Replace("\r\n", "\n").Replace("\r", "\n");
	}


	private static TextAlignment JustificationToTextAlignment(TextJustification justification)
	{
		switch (justification)
		{
			case TextJustification.Right:
				return TextAlignment.Center;
			case TextJustification.Center:
				return TextAlignment.Center;
			default:
				return TextAlignment.Left;
		}
	}
}

