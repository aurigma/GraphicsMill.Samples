using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.Codecs.Psd;
using Aurigma.GraphicsMill.AdvancedDrawing;


class ParagraphsAndListsExample
{
	static void Main(string[] args)
	{
		DrawParagraphs();
		DrawLists();
	}


	/// <summary>
	/// Draws formatted text with several paragraphs
	/// </summary>
	private static void DrawParagraphs()
	{
		using (var bitmap = new Bitmap(600, 400, PixelFormat.Format24bppRgb, RgbColor.White))
		using (var graphics = bitmap.GetAdvancedGraphics())
		{
			var dummyText = @"<p style='first-line-indent:30pt;space-before:50pt;space-after:20pt;'>" +
				@"Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
				@"sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut " +
				@"enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi " +
				@"ut aliquip ex ea commodo consequat." +
				@"</p>" +

				@"<p style='first-line-indent:50pt;space-before:15pt;space-after:5pt;'>" +
				@"Duis aute irure dolor in reprehenderit " +
				@"in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
				@"</p>" +

				@"<p style='first-line-indent:20pt;space-before:20pt;'>" +			
				@"Excepteur " +
				@"sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt " + 
				@"mollit anim id est laborum." + 
				@"</p>";

			var boundedText = new BoundedText(dummyText, graphics.CreateFont("Verdana", 18f),
				new SolidBrush(RgbColor.Black))
			{
				Rectangle = new System.Drawing.RectangleF(20f, 20f, 560f, 360f)
			};

			graphics.DrawText(boundedText);

			graphics.DrawRectangle(new Pen(RgbColor.Red), boundedText.Rectangle);

			bitmap.Save("../../../../_Output/DrawParagraphs.png");
		}
	}


	/// <summary>
	/// Draws formatted text with ordered and unordered lists
	/// </summary>
	private static void DrawLists()
	{
		using (var bitmap = new Bitmap(600, 600, PixelFormat.Format24bppRgb, RgbColor.White))
		using (var graphics = bitmap.GetAdvancedGraphics())
		{
			//Ordered list (number)
			{
				var dummyText = 
					@"<ol>" + //<ol style='type:numbers;'>
						@"<li>First</li>" +
						@"<li>Second</li>" +
						@"<li>Third</li>" +
						@"<li>Fourth</li>" +
					@"</ol>";

				var boundedText = new BoundedText(dummyText, graphics.CreateFont("Verdana", 18f),
					new SolidBrush(RgbColor.Black))
				{
					Rectangle = new System.Drawing.RectangleF(20f, 20f, 160f, 160f)
				};

				graphics.DrawText(boundedText);

				graphics.DrawRectangle(new Pen(RgbColor.Red), boundedText.Rectangle);
			}


			//Ordered list (lowercase letters)
			{
				var dummyText = 
					@"<ol style='type:lowerLetter;'>" +
						@"<li>First</li>" +
						@"<li>Second</li>" +
						@"<li>Third</li>" +
						@"<li>Fourth</li>" +
					@"</ol>";

				var boundedText = new BoundedText(dummyText, graphics.CreateFont("Verdana", 18f),
					new SolidBrush(RgbColor.Black))
				{
					Rectangle = new System.Drawing.RectangleF(220f, 20f, 160f, 160f)
				};

				graphics.DrawText(boundedText);

				graphics.DrawRectangle(new Pen(RgbColor.Red), boundedText.Rectangle);
			}


			//Ordered list (uppercase letter)
			{
				var dummyText = 
					@"<ol style='type:upperLetter;'>" +
						@"<li>First</li>" +
						@"<li>Second</li>" +
						@"<li>Third</li>" +
						@"<li>Fourth</li>" +
					@"</ol>";

				var boundedText = new BoundedText(dummyText, graphics.CreateFont("Verdana", 18f),
					new SolidBrush(RgbColor.Black))
				{
					Rectangle = new System.Drawing.RectangleF(420f, 20f, 160f, 160f)
				};

				graphics.DrawText(boundedText);

				graphics.DrawRectangle(new Pen(RgbColor.Red), boundedText.Rectangle);
			}


			//Ordered list (lowercase roman numerals)
			{
				var dummyText = 
					@"<ol style='type:lowerRoman;'>" +
						@"<li>First</li>" +
						@"<li>Second</li>" +
						@"<li>Third</li>" +
						@"<li>Fourth</li>" +
					@"</ol>";

				var boundedText = new BoundedText(dummyText, graphics.CreateFont("Verdana", 18f),
					new SolidBrush(RgbColor.Black))
				{
					Rectangle = new System.Drawing.RectangleF(20f, 220f, 160f, 160f)
				};

				graphics.DrawText(boundedText);

				graphics.DrawRectangle(new Pen(RgbColor.Red), boundedText.Rectangle);
			}


			//Ordered list (uppercase roman numerals)
			{
				var dummyText = 
					@"<ol style='type:upperRoman;'>" +
						@"<li>First</li>" +
						@"<li>Second</li>" +
						@"<li>Third</li>" +
						@"<li>Fourth</li>" +
					@"</ol>";

				var boundedText = new BoundedText(dummyText, graphics.CreateFont("Verdana", 18f),
					new SolidBrush(RgbColor.Black))
				{
					Rectangle = new System.Drawing.RectangleF(220f, 220f, 160f, 160f)
				};

				graphics.DrawText(boundedText);

				graphics.DrawRectangle(new Pen(RgbColor.Red), boundedText.Rectangle);
			}


			//Ordered list (start from 10)
			{
				var dummyText = 
					@"<ol style='start:10;'>" +
						@"<li>Tenth</li>" +
						@"<li>Eleventh</li>" +
						@"<li>Twelfth</li>" +
						@"<li>Thirteenth</li>" +
					@"</ol>";

				var boundedText = new BoundedText(dummyText, graphics.CreateFont("Verdana", 18f),
					new SolidBrush(RgbColor.Black))
				{
					Rectangle = new System.Drawing.RectangleF(420f, 220f, 160f, 160f)
				};

				graphics.DrawText(boundedText);

				graphics.DrawRectangle(new Pen(RgbColor.Red), boundedText.Rectangle);
			}


			//Unordered list (circle)
			{
				var dummyText = 
					@"<ul style='type: #9675;'>" +
						@"<li>First</li>" +
						@"<li>Second</li>" +
						@"<li>Third</li>" +
						@"<li>Fourth</li>" +
					@"</ul>";

				var boundedText = new BoundedText(dummyText, graphics.CreateFont("Verdana", 18f),
					new SolidBrush(RgbColor.Black))
				{
					Rectangle = new System.Drawing.RectangleF(20f, 420f, 160f, 160f)
				};

				graphics.DrawText(boundedText);

				graphics.DrawRectangle(new Pen(RgbColor.Red), boundedText.Rectangle);
			}


			//Unordered list (square)
			{
				var dummyText = 
					@"<ul style='type: #9632;'>" +
						@"<li>First</li>" +
						@"<li>Second</li>" +
						@"<li>Third</li>" +
						@"<li>Fourth</li>" +
					@"</ul>";

				var boundedText = new BoundedText(dummyText, graphics.CreateFont("Verdana", 18f),
					new SolidBrush(RgbColor.Black))
				{
					Rectangle = new System.Drawing.RectangleF(220f, 420f, 160f, 160f)
				};

				graphics.DrawText(boundedText);

				graphics.DrawRectangle(new Pen(RgbColor.Red), boundedText.Rectangle);
			}

			//Nested lists
			{
				var dummyText = 
					@"<ol>" + 
						@"<li>First" +
							@"<ul style='type: #9679;'>" +
								@"<li>First</li>" +
								@"<li>Second</li>" +
								@"<li>Third</li>" +
								@"<li>Fourth</li>" +
							@"</ul>" +
						@"</li>" +
						@"<li>Second</li>" +
						@"<li>Third</li>" +
					@"</ol>";

				var boundedText = new BoundedText(dummyText, graphics.CreateFont("Verdana", 18f),
					new SolidBrush(RgbColor.Black))
				{
					Rectangle = new System.Drawing.RectangleF(420f, 420f, 160f, 160f)
				};

				graphics.DrawText(boundedText);

				graphics.DrawRectangle(new Pen(RgbColor.Red), boundedText.Rectangle);
			}


			bitmap.Save("../../../../_Output/DrawLists.png");
		}
	}
}
