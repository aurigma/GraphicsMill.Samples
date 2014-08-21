using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.AdvancedDrawing.Art;
using Aurigma.GraphicsMill.Codecs;


class WatermarkExample
{
	static void Main(string[] args)
	{
		RenderRotatedTextWatermark();
		RenderGridAndTextWatermark();
	}


	/// <summary>
	/// Simple rotated text watermark
	/// </summary>
	private static void RenderRotatedTextWatermark()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Venice.jpg"))
		{
			//Modular
			int baseSize = 100;  //Math.Min(bitmap.Width, bitmap.Height) / 10;

			var watermark = "Graphics Mill";

			using (var graphics = bitmap.GetAdvancedGraphics())
			{
				var matrix = (new System.Drawing.Drawing2D.Matrix());
				matrix.Translate(bitmap.Width / 2, bitmap.Height / 2);
				matrix.Rotate(-35f);

				graphics.Transform = matrix;

				//Render text
				var font = graphics.CreateFont("Arial", baseSize / 5);

				using (var text = new PlainText(watermark, font, new SolidBrush(new RgbColor(255, 255, 255, 45))))
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

			bitmap.Save("../../../../_Output/RotatedTextWatermark.jpg");
		}
	}


	/// <summary>
	/// Watermark with grid and horizontal text
	/// </summary>
	private static void RenderGridAndTextWatermark()
	{
		//Modular
		int baseSize = 100; //Math.Min(bitmap.Width, bitmap.Height) / 10;

		using (var bitmap = new Bitmap("../../../../_Input/Venice.jpg"))
		{
			var mainWatermark = "Graphics Mill";
			var subWatermark = "© 2014 Aurigma, Inc.";

			using (var graphics = bitmap.GetAdvancedGraphics())
			{
				//Render grid
				var pen = new Pen(new RgbColor(255, 255, 255, 31), 5f);

				int diagonal = (int)Math.Sqrt(Math.Pow(bitmap.Width, 2) + Math.Pow(bitmap.Height, 2));

				for (int i = baseSize; i < diagonal; i += baseSize)
				{
					graphics.DrawEllipse(pen, -i, bitmap.Height - i, i * 2, i * 2);

					graphics.DrawEllipse(pen, bitmap.Width - i, bitmap.Height - i, i * 2, i * 2);
				}

				//Render text
				var brush = new SolidBrush(new RgbColor(255, 255, 255, 45));

				var mainFont = graphics.CreateFont("Arial", baseSize / 2);
				var subFont = graphics.CreateFont("Arial", baseSize / 5);

				using (var mainText = new PlainText(mainWatermark, mainFont, brush))
				using (var subText = new PlainText(subWatermark, subFont, brush))
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

			bitmap.Save("../../../../_Output/GridAndTextWatermark.jpg");
		}
	}
}
