﻿using System;
using System.Linq;
using System.Text.RegularExpressions;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Codecs.Psd;
using Aurigma.GraphicsMill.AdvancedDrawing;

class CurvedTextExample
{
	static void Main(string[] args)
	{
		MergeLayersRaster();
		MergeLayersPDF();
	}


	private static void MergeLayersRaster()
	{
		using (var psdReader = new PsdReader("../../../../_Input/Seal.psd"))
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

				bitmap.Save("../../../../_Output/CurvedText.png");
			}
		}
	}


	private static void MergeLayersPDF()
	{
		using (var psdReader = new PsdReader("../../../../_Input/Seal.psd"))
		{
			//The same approach can be used for EPS
			using (var pdfWriter = new PdfWriter("../../../../_Output/CurvedText.pdf"))
			{
				pdfWriter.AddPage(psdReader.Width, psdReader.Height, psdReader.DpiX, psdReader.DpiY, RgbColor.White);

				using (var graphics = pdfWriter.GetGraphics())
				{
					MergeLayers(psdReader, graphics, GetLayerText);
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

                if (textFrame.Path != null)
                {
                    text = new PathText(textFrame.Text, font)
                    {
                        Path = textFrame.Path
                    };
                }
				else if (textFrame.TextBox.Width == 0 || textFrame.TextBox.Height == 0)
				{
					text = new PlainText(layerText, font)
					{
                        Position = new System.Drawing.PointF(textFrame.OriginalTextBox.Left, textFrame.OriginalTextBox.Top)
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

                text.Tracking = textFrame.Tracking;
                text.Transform = textFrame.Transform;

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