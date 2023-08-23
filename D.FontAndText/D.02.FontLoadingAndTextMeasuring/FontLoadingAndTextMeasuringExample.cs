﻿using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.AdvancedDrawing.Art;

internal class FontLoadingAndTextMeasuringExample
{
    private static void Main(string[] args)
    {
        ShowCustomFontMetrics();

        LoadFontAndMeasureText();

        DrawTextWithFontFallback();
    }

    /// <summary>
    /// Adds font to FontRegistry from file and shows its metrics
    /// </summary>
    private static void ShowCustomFontMetrics()
    {
        using (var fontRegistry = new CustomFontRegistry())
        {
            var fontSize = 30f;
            var dpi = 150f;

            // Load custom OpenType font
            var postscriptName = fontRegistry.Add(@"../../../../_Input/Fonts/Amburegul.otf");

            var font = fontRegistry.CreateFont(postscriptName, fontSize, dpi, dpi);

            // Font metrics
            Console.WriteLine("Font: {0} {1}", font.Family, font.Style);
            Console.WriteLine("  DPI (X,Y):             {0},{0}", dpi);
            Console.WriteLine("  Size:                  {0}pt", fontSize);
            Console.WriteLine("  Ascender:              {0}px", font.Metrics.Ascender);
            Console.WriteLine("  Descender:             {0}px", font.Metrics.Descender);
            Console.WriteLine("  Height:                {0}px", font.Metrics.Height);
            Console.WriteLine("  Underline position:    {0}px", font.Metrics.UnderlinePosition);
            Console.WriteLine("  Underline thickness:   {0}px", font.Metrics.UnderlineThickness);
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Adds font to FontRegistry from file and shows its metrics
    /// </summary>
    private static void LoadFontAndMeasureText()
    {
        using (var bitmap = new Bitmap(600, 250, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
        using (var graphics = bitmap.GetAdvancedGraphics())
        using (var fontRegistry = new CustomFontRegistry())
        {
            var fontSize = 60f;

            // Load custom TrueType font
            fontRegistry.Add(@"../../../../_Input/Fonts/Lobster.ttf");

            graphics.FontRegistry = fontRegistry;

            var font = graphics.CreateFont("lobster", fontSize);

            // Plain text metrics
            var plainText = new PlainText("plain text", font);
            plainText.Position = new System.Drawing.PointF(5, plainText.GetBlackBox(fontRegistry, bitmap.DpiX, bitmap.DpiY).Height + 10);

            ShowTextPosition(plainText.String, plainText.Position, plainText.GetBlackBox(fontRegistry, bitmap.DpiX, bitmap.DpiY));

            DrawPlainTextWithMarkup(plainText, graphics);

            // Round text metrics
            var roundText = new RoundText("Art round text", font, new System.Drawing.PointF(50, 50))
            {
                Bend = 0.9f,
            };

            roundText.Center = new System.Drawing.PointF(
                graphics.Width - (roundText.GetBlackBox(fontRegistry, bitmap.DpiX, bitmap.DpiY).Width / 2) - 15,
                graphics.Height - (roundText.GetBlackBox(fontRegistry, bitmap.DpiX, bitmap.DpiY).Height / 2) - 10);

            ShowTextPosition(roundText.String, roundText.Center, roundText.GetBlackBox(fontRegistry, bitmap.DpiX, bitmap.DpiY));

            DrawArtTextWithMarkup(roundText, graphics);

            bitmap.Save("../../../../_Output/FontLoadingAndTextMeasuring.png");
        }
    }

    /// <summary>
    /// Writes to console information about text placement
    /// </summary>
    private static void ShowTextPosition(string str, System.Drawing.PointF pos, System.Drawing.RectangleF blackBox)
    {
        Console.WriteLine("Text metrics (\"{0}\")", str);
        Console.WriteLine("  Position");
        Console.WriteLine("    X:       {0}", pos.X);
        Console.WriteLine("    Y:       {0}", pos.Y);
        Console.WriteLine("  Black box");
        Console.WriteLine("    X:       {0}", blackBox.X);
        Console.WriteLine("    Y:       {0}", blackBox.Y);
        Console.WriteLine("    Width:   {0}", blackBox.Width);
        Console.WriteLine("    Height:  {0}", blackBox.Height);
        Console.WriteLine();
    }

    /// <summary>
    /// Draws PlainText with ascender and descender lines
    /// </summary>
    private static void DrawPlainTextWithMarkup(PlainText text, Graphics graphics)
    {
        // Draw plain text, its black box, ascender, descender and position point
        graphics.DrawText(text);

        var bbox = text.GetBlackBox(graphics.FontRegistry, graphics.DpiX, graphics.DpiY);

        graphics.DrawRectangle(new Pen(RgbColor.Gray, 1f), bbox);

        var font = graphics.CreateFont(text.CharStyle.PostScriptName, text.CharStyle.Size);                

        var stringMeasure = font.MeasureString("plain text");

        graphics.DrawLine(
            new Pen(RgbColor.Blue, 1f),
            bbox.X,
            text.Position.Y - stringMeasure.Ascender,
            bbox.X + bbox.Width,
            text.Position.Y - stringMeasure.Ascender);

        graphics.DrawLine(
            new Pen(RgbColor.Green, 1f),
            bbox.X,
            text.Position.Y - stringMeasure.Descender,
            bbox.X + bbox.Width,
            text.Position.Y - stringMeasure.Descender);

        graphics.DrawLine(
            new Pen(RgbColor.IndianRed, 1f),
            bbox.X,
            text.Position.Y,
            bbox.X + bbox.Width,
            text.Position.Y);

        graphics.FillEllipse(new SolidBrush(RgbColor.Red), text.Position.X - 3, text.Position.Y - 3, 6, 6);
    }

    /// <summary>
    /// Draws art text with center point and black box
    /// </summary>
    private static void DrawArtTextWithMarkup(ArtText text, Graphics graphics)
    {
        // Draw round text, its black box and center point
        graphics.DrawText(text);

        graphics.DrawRectangle(new Pen(RgbColor.Gray, 1f), text.GetBlackBox(graphics.FontRegistry, graphics.DpiX, graphics.DpiY));

        graphics.FillEllipse(new SolidBrush(RgbColor.Red), text.Center.X - 3, text.Center.Y - 3, 6, 6);
    }

    /// <summary>
    /// Draws multilanguage text with font fallback support
    /// </summary>
    private static void DrawTextWithFontFallback()
    {
        using (var bitmap = new Bitmap(400, 200, PixelFormat.Format24bppRgb, RgbColor.White))
        using (var graphics = bitmap.GetAdvancedGraphics())
        {
            var fontRegistry = new CustomFontRegistry();
            fontRegistry.Add("../../../../_Input/Fonts/Lobster.ttf");
            fontRegistry.Add("../../../../_Input/Fonts/ARIALUNI.TTF");

            fontRegistry.FallbackFonts.Add("Arial Unicode MS");

            graphics.FontRegistry = fontRegistry;

            var dummyText = "Lorem ipsum dolor sit amet, ex mel latine pertinax. 載自大制節規信兵著旋避漂。";

            var boundedText = new BoundedText(dummyText, graphics.CreateFont("Lobster", 32f), new SolidBrush(RgbColor.Black))
            {
                Rectangle = new System.Drawing.RectangleF(20f, 20f, 360f, 360f),
            };

            graphics.DrawText(boundedText);

            bitmap.Save("../../../../_Output/DrawTextWithFontFallback.png");
        }
    }
}