using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.AdvancedDrawing.Art;
using Aurigma.GraphicsMill.AdvancedDrawing.Effects;

namespace OnlineDemo.Controllers
{
	public class FontAndTextController : ApiController
	{
		#region Plain and bounded text

		public class PlainAndBoundedTextParams
		{
			public string HorizontalText { get; set; }
			public string VerticalText { get; set; }
			public string BoundedText { get; set; }
		}


		[HttpPost]
		public HttpResponseMessage RenderPlainAndBoundedText([FromBody] PlainAndBoundedTextParams p)
		{
			//Filter params
			p.HorizontalText = Utility.FilterTextString(p.HorizontalText);
			p.VerticalText = Utility.FilterTextString(p.VerticalText);
			p.BoundedText = Utility.FilterTextString(p.BoundedText);


			HttpResponseMessage response;

			using (var bitmap = new Bitmap(600, 250, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
			{
				using (var graphics = bitmap.GetAdvancedGraphics())
				{
					var brush = new SolidBrush(new RgbColor(0x41, 0x41, 0x41));

					using (var plainHorizontalText = new PlainText(p.HorizontalText, graphics.CreateFont("Times New Roman", 22f), brush))
					{
						plainHorizontalText.Position = new System.Drawing.PointF(50f, 38f);
						graphics.DrawText(plainHorizontalText);
					}


					using (var plainVerticalText = new PlainText(p.VerticalText, graphics.CreateFont("Arial", 24f), brush))
					{
						plainVerticalText.Vertical = true;
						plainVerticalText.Position = new System.Drawing.PointF(20f, 10f);
						plainVerticalText.Effect = new Glow(new RgbColor(0x66, 0xaf, 0xe9), 5);
						graphics.DrawText(plainVerticalText);
					}


					var rect = new System.Drawing.RectangleF(300f, 20f, 280f, 200f);

					using (var boundedText = new BoundedText(p.BoundedText, graphics.CreateFont("Verdana", 14f), brush))
					{
						boundedText.Alignment = TextAlignment.Center;
						boundedText.Rectangle = rect;
						graphics.DrawText(boundedText);
					}

					graphics.DrawRectangle(new Pen(new RgbColor(0x4e, 0xb5, 0xe6)), rect);
				}


				using (var ms = new MemoryStream())
				{
					bitmap.Save(ms, new PngSettings());

					response = Utility.Base64ResponseFromBinaryStream(ms);
					response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/png");
				}
			}

			return response;
		}


		#endregion


		#region Font loading and text measuring

		public class FontLoadingAndTextMeasuringParams
		{
			public string StringToMeasure { get; set; }
			public string PlainText { get; set; }
			public string RoundText { get; set; }
		}


		[HttpPost]
		public dynamic GetFontLoadingAndTextMeasuring([FromBody] FontLoadingAndTextMeasuringParams p)
		{
			//Filter params
			p.StringToMeasure = Utility.FilterTextString(p.StringToMeasure);
			p.PlainText = Utility.FilterTextString(p.PlainText);
			p.RoundText = Utility.FilterTextString(p.RoundText);


			using (var bitmap = new Bitmap(600, 250, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
			{
				var sb = new System.Text.StringBuilder();


				using (var graphics = bitmap.GetAdvancedGraphics())
				{
					var fontSize = 60f;

					//We can load system-wide fonts without using of custom font registry
					//var font = graphics.CreateFont("Arial", fontSize);

					//Load custom font
					var fontRegistry = new CustomFontRegistry();
					fontRegistry.Add(System.Web.HttpContext.Current.Server.MapPath("~/Input/Fonts/Lobster.ttf"));

					graphics.FontRegistry = fontRegistry;

					var font = graphics.CreateFont("lobster", fontSize);

					StringMeasure stringMeasure = font.MeasureString(p.StringToMeasure);

					//Font metrics
					sb.AppendFormat("Font and string (\"{0}\")\n", p.StringToMeasure);
					sb.AppendFormat("  DPI (X,Y): {0},{1}\n", bitmap.DpiX, bitmap.DpiY);
					sb.AppendFormat("  Size:      {0}pt\n", fontSize);
					sb.AppendFormat("  Width:     {0}\n", stringMeasure.Width);
					sb.AppendFormat("  Height:    {0}\n", stringMeasure.Height);
					sb.AppendFormat("  Ascender:  {0}\n", stringMeasure.Ascender);
					sb.AppendFormat("  Descender: {0}\n\n", stringMeasure.Descender);


					//Plain text metrics
					using (var plainText = new PlainText(p.PlainText, font))
					{
						var plainBlackBox = plainText.GetBlackBox();
						plainText.Position = new System.Drawing.PointF(5, plainBlackBox.Height + 10);

						//We need to update black box after changing center
						plainBlackBox = plainText.GetBlackBox();

						sb.AppendFormat("Plain text metrics (\"{0}\")\n", plainText.String);
						sb.AppendFormat("  Position\n");
						sb.AppendFormat("    X:       {0}\n", plainText.Position.X);
						sb.AppendFormat("    Y:       {0}\n", plainText.Position.Y);
						sb.AppendFormat("  Black box\n");
						sb.AppendFormat("    X:       {0}\n", plainBlackBox.X);
						sb.AppendFormat("    Y:       {0}\n", plainBlackBox.Y);
						sb.AppendFormat("    Width:   {0}\n", plainBlackBox.Width);
						sb.AppendFormat("    Height:  {0}\n\n", plainBlackBox.Height);

						//Draw plain text, its black box, ascender, descender and position point
						graphics.DrawText(plainText);
						graphics.DrawRectangle(new Pen(RgbColor.Gray, 1f), plainBlackBox);

						stringMeasure = font.MeasureString(p.PlainText);
						graphics.DrawLine(new Pen(RgbColor.Blue, 1f), plainBlackBox.X, plainText.Position.Y - stringMeasure.Ascender,
							plainBlackBox.X + plainBlackBox.Width, plainText.Position.Y - stringMeasure.Ascender);
						graphics.DrawLine(new Pen(RgbColor.Green, 1f), plainBlackBox.X, plainText.Position.Y - stringMeasure.Descender,
							plainBlackBox.X + plainBlackBox.Width, plainText.Position.Y - stringMeasure.Descender);
						graphics.DrawLine(new Pen(RgbColor.IndianRed, 1f), plainBlackBox.X, plainText.Position.Y,
							plainBlackBox.X + plainBlackBox.Width, plainText.Position.Y);
						graphics.FillEllipse(new SolidBrush(RgbColor.Red), plainText.Position.X - 3, plainText.Position.Y - 3, 6, 6);
					}


					//Round text metrics
					using (var roundText = new RoundText(p.RoundText, font, new System.Drawing.PointF(50, 50)))
					{
						roundText.Bend = 0.9f;

						var roundBlackBox = roundText.GetBlackBox();
						roundText.Center = new System.Drawing.PointF(graphics.Width - roundBlackBox.Width / 2 - 15,
							graphics.Height - roundBlackBox.Height / 2 - 10);

						//We need to update black box after changing center
						roundBlackBox = roundText.GetBlackBox();

						sb.AppendFormat("Round text metrics (\"{0}\")\n", roundText.String);
						sb.AppendFormat("  Center\n");
						sb.AppendFormat("    X:       {0}\n", roundText.Center.X);
						sb.AppendFormat("    Y:       {0}\n", roundText.Center.Y);
						sb.AppendFormat("  Black box\n");
						sb.AppendFormat("    X:       {0}\n", roundBlackBox.X);
						sb.AppendFormat("    Y:       {0}\n", roundBlackBox.Y);
						sb.AppendFormat("    Width:   {0}\n", roundBlackBox.Width);
						sb.AppendFormat("    Height:  {0}\n", roundBlackBox.Height);


						//Draw round text, its black box and center point
						graphics.DrawText(roundText);
						graphics.DrawRectangle(new Pen(RgbColor.Gray, 1f), roundBlackBox);
						graphics.FillEllipse(new SolidBrush(RgbColor.Red), roundText.Center.X - 3, roundText.Center.Y - 3, 6, 6);
					}
				}


				using (var ms = new MemoryStream())
				{
					bitmap.Save(ms, new PngSettings());

					ms.Position = 0;

					return new
					{
						Info = sb.ToString(),
						Image = Convert.ToBase64String(ms.ToArray())
					};
				}
			}
		}

		#endregion


		#region Art text

		public enum ArtTextType
		{
			Bridge,
			Bulge,
			Pinch,
			Roof,
			Round,
			Valley,
			Wedge
		}


		public enum TextEffectType
		{
			None,
			Glow,
			Shadow
		}


		public class ArtTextParams
		{
			public string FontName { get; set; }
			public string Text { get; set; }
			public ArtTextType Type { get; set; }
			public TextEffectType Effect { get; set; }
			public float Bend { get; set; }
		}

		[HttpPost]
		public HttpResponseMessage RenderArtText([FromBody] ArtTextParams p)
		{
			//Filter params
			p.FontName = Utility.FilterTextString(p.FontName);
			p.Text = Utility.FilterTextString(p.Text);
			p.Bend = Math.Min(Math.Max(p.Bend, 0f), 1f);


			HttpResponseMessage response;

			using (var bitmap = new Bitmap(600, 250, PixelFormat.Format24bppRgb, new RgbColor(0xff, 0xff, 0xff, 0xff)))
			{
				using (var graphics = bitmap.GetAdvancedGraphics())
				{
					var font = graphics.CreateFont(p.FontName, 48);
					var brush = new SolidBrush(new RgbColor(0x41, 0x41, 0x41));
					var center = new System.Drawing.PointF((float)(bitmap.Width * 0.5f), (float)(bitmap.Height) * 0.5f);

					ArtText artText = null;

					try
					{
						switch (p.Type)
						{
							case ArtTextType.Bridge:
								artText = new BridgeText(p.Text, font, brush, center, p.Bend);
								break;
							case ArtTextType.Bulge:
								artText = new BulgeText(p.Text, font, brush, center, p.Bend);
								break;
							case ArtTextType.Pinch:
								artText = new PinchText(p.Text, font, brush, center, p.Bend);
								break;
							case ArtTextType.Roof:
								artText = new RoofText(p.Text, font, brush, center, p.Bend);
								break;
							case ArtTextType.Round:
								artText = new RoundText(p.Text, font, brush, center, p.Bend);
								break;
							case ArtTextType.Valley:
								artText = new ValleyText(p.Text, font, brush, center, p.Bend);
								break;
							case ArtTextType.Wedge:
								//The distortion is defined using 3 parameters (without the parameter Bend)
								float leftScale = 1.0f * (p.Bend + 0.1f);
								float rightScale = 1.0f / (p.Bend + 0.1f);
								float tilt = -0.2f;

								artText = new WedgeText(p.Text, font, brush, center, leftScale, rightScale, tilt);
								break;
						}

						switch (p.Effect)
						{
							case TextEffectType.Glow:
								artText.Effect = new Glow(new RgbColor(0x66, 0xaf, 0xe9), 5);
								break;
							case TextEffectType.Shadow:
								artText.Effect = new Shadow(new RgbColor(80, 80, 80), 5, 4, 4);
								break;
						}

						graphics.DrawText(artText);
					}
					finally
					{
						if (artText != null)
						{
							artText.Dispose();
						}
					}
				}


				using (var ms = new MemoryStream())
				{
					bitmap.Save(ms, new PngSettings());

					response = Utility.Base64ResponseFromBinaryStream(ms);
					response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/png");
				}
			}

			return response;
		}

		#endregion


		#region Double path text

		public class DoublePathTextParams
		{
			public Point[] TopPath { get; set; }
			public Point[] BottomPath { get; set; }
			public string FontName { get; set; }
			public int FontSize { get; set; }
			public string Text { get; set; }
		}


		[HttpPost]
		public HttpResponseMessage RenderDoublePathText([FromBody] DoublePathTextParams p)
		{
			//Filter params
			if (p.TopPath == null || p.TopPath.Length != 4 || p.BottomPath == null || p.BottomPath.Length != 4)
			{
				throw new ArgumentException();
			}

			p.FontName = Utility.FilterTextString(p.FontName);
			p.FontSize = Math.Min(Math.Max(p.FontSize, 8), 72);
			p.Text = Utility.FilterTextString(p.Text);


			HttpResponseMessage response;

			using (var bitmap = new Bitmap(600, 250, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
			{
				using (var graphics = bitmap.GetAdvancedGraphics())
				using (var doublePathText = new DoublePathText(p.Text, graphics.CreateFont(p.FontName, p.FontSize)))
				{
					doublePathText.Brush = new SolidBrush(new RgbColor(0x41, 0x41, 0x41));
					doublePathText.Alignment = TextAlignment.Center;

					doublePathText.TopPath.MoveTo(p.TopPath[0].X, p.TopPath[0].Y);
					doublePathText.TopPath.CurveTo(p.TopPath[1].X, p.TopPath[1].Y
						, p.TopPath[2].X, p.TopPath[2].Y
						, p.TopPath[3].X, p.TopPath[3].Y);

					doublePathText.BottomPath.MoveTo(p.BottomPath[0].X, p.BottomPath[0].Y);
					doublePathText.BottomPath.CurveTo(p.BottomPath[1].X, p.BottomPath[1].Y
						, p.BottomPath[2].X, p.BottomPath[2].Y
						, p.BottomPath[3].X, p.BottomPath[3].Y);

					graphics.DrawText(doublePathText);
				}

				using (var ms = new MemoryStream())
				{
					bitmap.Save(ms, new PngSettings());

					response = Utility.Base64ResponseFromBinaryStream(ms);
					response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/png");
				}
			}

			return response;
		}

		#endregion


		#region Watermark

		public enum WatermarkType
		{
			RotatedText,
			GridAndText
		}


		public class WatermarkParams
		{
			public WatermarkType Type { get; set; }
			public string Text1 { get; set; }
			public string Text2 { get; set; }			
		}


		[HttpPost]
		public HttpResponseMessage RenderWatermark([FromBody] WatermarkParams p)
		{
			//Filter params
			p.Text1 = Utility.FilterTextString(p.Text1);
			p.Text2 = Utility.FilterTextString(p.Text2);


			HttpResponseMessage response;

			using (var bitmap = new Bitmap(System.Web.HttpContext.Current.Server.MapPath("~/Input/Chicago.jpg")))
			{
				switch (p.Type)
				{
					case WatermarkType.RotatedText:
						AddRotatedTextWatermark(bitmap, p.Text1);
						break;
					case WatermarkType.GridAndText:
						AddGridAndTextWatermark(bitmap, p.Text1, p.Text2);
						break;
				}

				using (var ms = new MemoryStream())
				{
					bitmap.Save(ms, new JpegSettings());

					response = Utility.Base64ResponseFromBinaryStream(ms);
					response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
				}
			}

			return response;
		}


		public void AddRotatedTextWatermark(Bitmap bitmap, string watermark)
		{
			//Modular
			int baseSize = 100;

			using (var graphics = bitmap.GetAdvancedGraphics())
			{
				var matrix = (new System.Drawing.Drawing2D.Matrix());
				matrix.Translate(bitmap.Width / 2, bitmap.Height / 2);
				matrix.Rotate(-35f);

				graphics.Transform = matrix;

				//Render text
				var font = graphics.CreateFont("Arial", baseSize / 5);
				using (var text = new PlainText(watermark, font, new SolidBrush(new RgbColor(255, 255, 255, 80))))
				{
					var blackBox = text.GetBlackBox();

					int baseSizeX = (int)(blackBox.Width + baseSize / 2);
					int baseOffsetX = baseSizeX / 3;

					int halfDiagonal = (int)(Math.Sqrt(Math.Pow(bitmap.Width, 2) + Math.Pow(bitmap.Height, 2)) / 2) + baseSize;

					int offsetX = 0;

					for (int y = -halfDiagonal; y < halfDiagonal; y += baseSize)
					{
						for (int x = -halfDiagonal - offsetX; x <= halfDiagonal; x += baseSizeX)
						{
							text.Position = new System.Drawing.PointF(x, y);
							graphics.DrawText(text);
						}

						offsetX = (offsetX + baseOffsetX) % baseSizeX;
					}
				}
			}		
		}


		public void AddGridAndTextWatermark(Bitmap bitmap, string mainWatermark, string subWatermark)
		{
			//Modular
			int baseSize = 40;

			using (var graphics = bitmap.GetAdvancedGraphics())
			{
				//Render grid
				var pen = new Pen(new RgbColor(255, 255, 255, 40), 1f);

				int diagonal = (int)Math.Sqrt(Math.Pow(bitmap.Width, 2) + Math.Pow(bitmap.Height, 2));

				for (int i = baseSize; i < diagonal; i += baseSize)
				{
					graphics.DrawEllipse(pen, -i, bitmap.Height - i, i * 2, i * 2);

					graphics.DrawEllipse(pen, bitmap.Width - i, bitmap.Height - i, i * 2, i * 2);
				}

				//Render text
				var brush = new SolidBrush(new RgbColor(255, 255, 255, 80));

				var mainFont = graphics.CreateFont("Arial", baseSize / 2);
				var subFont = graphics.CreateFont("Arial", baseSize / 5);

				using(var mainText = new PlainText(mainWatermark, mainFont, brush))
				using(var subText = new PlainText(subWatermark, subFont, brush))
				{
					var mainBlackBox = mainText.GetBlackBox();
					var subBlackBox = subText.GetBlackBox();

					int spacing = baseSize / 10;

					//We manually align text using font metrics
					int totalHeight = (int)(mainBlackBox.Height + spacing + subBlackBox.Height);

					int mainOffsetY = (int)(mainBlackBox.Height - totalHeight / 2);
					int mainOffsetX = (int)(-mainBlackBox.Width / 2);

					int subOffsetY = totalHeight / 2;
					int subOffsetX = (int)(mainOffsetX + mainBlackBox.Width - subBlackBox.Width);

					int baseSizeX = (int)(Math.Max(baseSize * 2, mainBlackBox.Width));
					int baseSizeY = baseSize * 2;

					var c = 0;

					for (int y = bitmap.Height / 2 - (bitmap.Height / 2 / baseSizeY + 1) * baseSizeY; y < bitmap.Height + baseSizeY; y += baseSizeY)
					{
						for (int x = bitmap.Width / 2 - (bitmap.Width / 2 / baseSizeX + 1) * baseSizeX; x < bitmap.Width + baseSizeX; x += baseSizeX)
						{
							c++;

							//Render with chessboard style
							if (c % 2 > 0)
							{
								continue;
							}

							mainText.Position = new System.Drawing.PointF(x + mainOffsetX, y + mainOffsetY);
							graphics.DrawText(mainText);

							subText.Position = new System.Drawing.PointF(x + subOffsetX, y + subOffsetY);
							graphics.DrawText(subText);
						}
					}
				}
			}
		}

		#endregion


		#region PDF and EPS output

		public class PDFAndEPSOutputParams
		{
			public string FrontText { get; set; }
			public string BackText { get; set; }
		}


		[HttpPost]
		public dynamic GetPDFAndEPSOutput([FromBody] PDFAndEPSOutputParams p)
		{
			//Filter params
			p.FrontText = Utility.FilterTextString(p.FrontText);
			p.BackText = Utility.FilterTextString(p.BackText);


			var dpi = 300f;

			//PDF
			var pdfFileId = Guid.NewGuid();
			var pdfFilePath = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Temp/" + pdfFileId.ToString());

			using (var pdfWriter = new PdfWriter(pdfFilePath))
			{
				//Front side 3.5"×2.5" size
				pdfWriter.AddPage(UnitConverter.ConvertUnitsToPixels(dpi, 3.5f, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 2.0f, Unit.Inch), dpi, dpi);

				using (var graphics = pdfWriter.GetGraphics())
				{
					DrawBusinessCardFrontSide(graphics, dpi, RgbColor.Red, p.FrontText, RgbColor.Navy);
				}

				//Back side	3.5"×2.5" size
				pdfWriter.AddPage(UnitConverter.ConvertUnitsToPixels(dpi, 3.5f, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 2.0f, Unit.Inch), dpi, dpi);

				using (var graphics = pdfWriter.GetGraphics())
				{
					DrawBusinessCardBackSide(graphics, dpi, RgbColor.Blue, p.BackText, RgbColor.Green);
				}
			}

			System.IO.File.WriteAllText(pdfFilePath + ".txt", "application/pdf");


			//EPS
			var epsFileId = Guid.NewGuid();
			var epsFilePath = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Temp/" + epsFileId.ToString());
			
			using (var epsWriter = new EpsWriter(epsFilePath, UnitConverter.ConvertUnitsToPixels(dpi, 3.5f, Unit.Inch), 
				UnitConverter.ConvertUnitsToPixels(dpi, 2.0f, Unit.Inch), dpi, dpi))
			{
				using (var graphics = epsWriter.GetGraphics())
				{
					DrawBusinessCardFrontSide(graphics, dpi, new CmykColor(0, 255, 255, 0), p.FrontText, new CmykColor(127, 127, 0, 127));
				}
			}

			System.IO.File.WriteAllText(epsFilePath + ".txt", "application/postscript");


			//Preview
			var previewDpi = 72f;

			using (var bitmap = new Bitmap(600, 180, PixelFormat.Format24bppRgb, RgbColor.White))
			{
				bitmap.DpiX = previewDpi;
				bitmap.DpiY = previewDpi;

				var cardWidth = UnitConverter.ConvertUnitsToPixels(previewDpi, 3.5f, Unit.Inch);
				var cardHeight = UnitConverter.ConvertUnitsToPixels(previewDpi, 2.0f, Unit.Inch);
				var offsetX = (bitmap.Width / 2 - cardWidth) / 2;
				var offsetY = (bitmap.Height - cardHeight) / 2;

				using (var graphics = bitmap.GetAdvancedGraphics())
				{
					var pen = new Pen(RgbColor.Gray, 1.0f);

					var transform = new System.Drawing.Drawing2D.Matrix();
					transform.Translate(offsetX, offsetY);

					graphics.Transform = transform;					

					DrawBusinessCardFrontSide(graphics, previewDpi, RgbColor.Red, p.FrontText, RgbColor.Navy);
					graphics.DrawRectangle(pen, 0, 0, cardWidth, cardHeight);

					transform = new System.Drawing.Drawing2D.Matrix();
					transform.Translate(offsetX + bitmap.Width / 2, offsetY);

					graphics.Transform = transform;

					DrawBusinessCardBackSide(graphics, previewDpi, RgbColor.Blue, p.BackText, RgbColor.Green);
					graphics.DrawRectangle(pen, 0, 0, cardWidth, cardHeight);
				}

				using (var ms = new MemoryStream())
				{
					bitmap.Save(ms, new PngSettings());

					ms.Position = 0;

					return new
					{
						PdfFileId = pdfFileId,
						EpsFileId = epsFileId,
						Preview = Convert.ToBase64String(ms.ToArray())
					};	
				}
			}
		}


		public static void DrawBusinessCardFrontSide(Graphics graphics, float dpi, Color rectangleColor, string textString, Color textColor)
		{
			//Pen 1pt width
			var pen = new Pen(new CmykColor(0, 255, 255, 0), UnitConverter.ConvertUnitsToPixels(dpi, 1.0f, Unit.Point));

			//Rectangle
			graphics.DrawRectangle(pen, UnitConverter.ConvertUnitsToPixels(dpi, 0.125f, Unit.Inch),
				UnitConverter.ConvertUnitsToPixels(dpi, 0.125f, Unit.Inch),
				UnitConverter.ConvertUnitsToPixels(dpi, 3.5f - 0.125f * 2, Unit.Inch),
				UnitConverter.ConvertUnitsToPixels(dpi, 2 - 0.125f * 2, Unit.Inch));

			//Image
			using (var bitmap = new Bitmap(System.Web.HttpContext.Current.Server.MapPath("~/Input/Chicago.jpg")))
			{
				graphics.DrawImage(bitmap, new System.Drawing.RectangleF(
					UnitConverter.ConvertUnitsToPixels(dpi, 0.25f, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 0.75f, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 0.25f + 0.5f * (float)bitmap.Height / (float)bitmap.Width, Unit.Inch),
					UnitConverter.ConvertUnitsToPixels(dpi, 1.25f, Unit.Inch)));
			}

			//Text
			var font = graphics.CreateFont("Arial", 32f);
			var text = new PlainText(textString, font, new SolidBrush(textColor));
			text.Alignment = TextAlignment.Left;
			text.Position = new System.Drawing.PointF(UnitConverter.ConvertUnitsToPixels(dpi, 1.125f, Unit.Inch)
				, UnitConverter.ConvertUnitsToPixels(dpi, 1.125f, Unit.Inch));
			graphics.DrawText(text);
		}


		public static void DrawBusinessCardBackSide(Graphics graphics, float dpi, Color ellipseColor, string textString, Color textColor)
		{
			//Pen 0.5pt width
			var pen = new Pen(ellipseColor, UnitConverter.ConvertUnitsToPixels(dpi, 1f, Unit.Point));

			graphics.DrawEllipse(pen, UnitConverter.ConvertUnitsToPixels(dpi, 0.125f, Unit.Inch),
				UnitConverter.ConvertUnitsToPixels(dpi, 0.125f, Unit.Inch),
				UnitConverter.ConvertUnitsToPixels(dpi, 3.5f - 0.125f * 2, Unit.Inch),
				UnitConverter.ConvertUnitsToPixels(dpi, 2 - 0.125f * 2, Unit.Inch));

			//Artistic (bridge) text
			var font = graphics.CreateFont("Times New Roman", "Italic", 24f);
			var bridgeText = new BridgeText(textString, font, new SolidBrush(textColor));
			bridgeText.Bend = 0.2f;
			bridgeText.Center = new System.Drawing.PointF(UnitConverter.ConvertUnitsToPixels(dpi, 3.5f / 2, Unit.Inch)
				, UnitConverter.ConvertUnitsToPixels(dpi, 1f, Unit.Inch));
			graphics.DrawText(bridgeText);		
		}

		#endregion
	}
}
