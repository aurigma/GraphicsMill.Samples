using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.AdvancedDrawing.Art;
using Aurigma.GraphicsMill.Codecs;


class FontLoadingAndTextMeasuringExample
{
	static void Main(string[] args)
	{
		LoadFontAndMeasureText();
	}


	public static void LoadFontAndMeasureText()
	{
		using (var bitmap = new Bitmap(600, 250, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
		{
			using (var graphics = bitmap.GetAdvancedGraphics())
			{
				var fontSize = 60f;

				//We can load system-wide fonts without using of custom font registry
				//var font = graphics.CreateFont("Arial", 60f);

				//Load custom font
				var fontRegistry = new CustomFontRegistry();
				fontRegistry.Add(@"../../../../Input/Fonts/Lobster.ttf");

				graphics.FontRegistry = fontRegistry;

				var font = graphics.CreateFont("lobster", fontSize);

				var s = "Some string to measure";

				StringMeasure stringMeasure = font.MeasureString(s);

				//Font metrics
				Console.WriteLine("Font and string (\"{0}\")", s);
				Console.WriteLine("  DPI (X,Y): {0},{1}", bitmap.DpiX, bitmap.DpiY);
				Console.WriteLine("  Size:      {0}pt", fontSize);
				Console.WriteLine("  Width:     {0}", stringMeasure.Width);
				Console.WriteLine("  Height:    {0}", stringMeasure.Height);
				Console.WriteLine("  Ascender:  {0}", stringMeasure.Ascender);
				Console.WriteLine("  Descender: {0}", stringMeasure.Descender);
				Console.WriteLine();


				//Plain text metrics
				using (var plainText = new PlainText("plain text", font))
				{
					var plainBlackBox = plainText.GetBlackBox();
					plainText.Position = new System.Drawing.PointF(5, plainBlackBox.Height + 10);

					//We need to update black box after changing center
					plainBlackBox = plainText.GetBlackBox();				

					Console.WriteLine("Plain text metrics (\"{0}\")", plainText.String);
					Console.WriteLine("  Position");
					Console.WriteLine("    X:       {0}", plainText.Position.X);
					Console.WriteLine("    Y:       {0}", plainText.Position.Y);
					Console.WriteLine("  Black box");
					Console.WriteLine("    X:       {0}", plainBlackBox.X);
					Console.WriteLine("    Y:       {0}", plainBlackBox.Y);
					Console.WriteLine("    Width:   {0}", plainBlackBox.Width);
					Console.WriteLine("    Height:  {0}", plainBlackBox.Height);
					Console.WriteLine();

					//Draw plain text, its black box, ascender, descender and position point
					graphics.DrawText(plainText);

					graphics.DrawRectangle(new Pen(RgbColor.Gray, 1f), plainBlackBox);

					stringMeasure = font.MeasureString("plain text");
					graphics.DrawLine(new Pen(RgbColor.Blue, 1f), plainBlackBox.X, plainText.Position.Y - stringMeasure.Ascender,
						plainBlackBox.X + plainBlackBox.Width, plainText.Position.Y - stringMeasure.Ascender);					
					graphics.DrawLine(new Pen(RgbColor.Green, 1f), plainBlackBox.X, plainText.Position.Y - stringMeasure.Descender,
						plainBlackBox.X + plainBlackBox.Width, plainText.Position.Y - stringMeasure.Descender);					
					graphics.DrawLine(new Pen(RgbColor.IndianRed, 1f), plainBlackBox.X, plainText.Position.Y,
						plainBlackBox.X + plainBlackBox.Width, plainText.Position.Y);
					graphics.FillEllipse(new SolidBrush(RgbColor.Red), plainText.Position.X - 3, plainText.Position.Y - 3, 6, 6);
				}

				//Round text metrics
				using (var roundText = new RoundText("Art round text", font, new System.Drawing.PointF(50, 50)))
				{
					roundText.Bend = 0.9f;

					var roundBlackBox = roundText.GetBlackBox();
					roundText.Center = new System.Drawing.PointF(graphics.Width - roundBlackBox.Width / 2 - 15,
						graphics.Height - roundBlackBox.Height / 2 - 10);

					//We need to update black box after changing center
					roundBlackBox = roundText.GetBlackBox();

					Console.WriteLine("Round text metrics (\"{0}\")", roundText.String);
					Console.WriteLine("  Center");
					Console.WriteLine("    X:       {0}", roundText.Center.X);
					Console.WriteLine("    Y:       {0}", roundText.Center.Y);
					Console.WriteLine("  Black box");
					Console.WriteLine("    X:       {0}", roundBlackBox.X);
					Console.WriteLine("    Y:       {0}", roundBlackBox.Y);
					Console.WriteLine("    Width:   {0}", roundBlackBox.Width);
					Console.WriteLine("    Height:  {0}", roundBlackBox.Height);


					//Draw round text, its black box and center point
					graphics.DrawText(roundText);
					graphics.DrawRectangle(new Pen(RgbColor.Gray, 1f), roundBlackBox);
					graphics.FillEllipse(new SolidBrush(RgbColor.Red), roundText.Center.X - 3, roundText.Center.Y - 3, 6, 6);
				}
			}

			bitmap.Save("../../../../Output/FontLoadingAndTextMeasuring.png");
		}
	}
}

