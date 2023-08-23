using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.AdvancedDrawing.Effects;

internal class PlainAndBoundedTextExample
{
    private static void Main(string[] args)
    {
        DrawPlainAndBoundedText();
        DrawMultilinePlainText();
        PlainTextWithGradientColor();
        PlainTextWithRoundedDoubleOutline();
    }

    /// <summary>
    /// Draws plain and bounded texts with different parameters.
    /// </summary>
    private static void DrawPlainAndBoundedText()
    {
        using (var bitmap = new Bitmap(400, 250, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
        using (var graphics = bitmap.GetAdvancedGraphics())
        {
            var brush = new SolidBrush(new RgbColor(0x41, 0x41, 0x41));
            var dummyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras elementum quam ac nisi varius gravida. Mauris ornare, dolor et scelerisque volutpat, enim urna commodo odio, consequat fermentum sem arcu sit amet nisl. Aliquam tincidunt id neque in gravida. Mauris mollis est vulputate suscipit facilisis.";
            var boundedTextRect = new System.Drawing.RectangleF(200f, 20f, 180f, 150f);

            var texts = new Text[]
            {
                new PlainText("Horizontal", graphics.CreateFont("Times New Roman", 22f), brush)
                {
                    Position = new System.Drawing.PointF(50f, 38f),
                },
                new PlainText("Vertical", graphics.CreateFont("Arial", 24f), brush)
                {
                    Vertical = true,
                    Position = new System.Drawing.PointF(20f, 10f),
                    Effect = new Glow(new RgbColor(0x66, 0xaf, 0xe9), 5),
                },
                new BoundedText(dummyText, graphics.CreateFont("Verdana", 14f), brush)
                {
                    ParagraphStyle = new ParagraphStyle
                    {
                        Alignment = TextAlignment.Center,
                    },
                    Rectangle = boundedTextRect,
                },
            };

            foreach (var text in texts)
            {
                graphics.DrawText(text);
            }

            graphics.DrawRectangle(new Pen(new RgbColor(0x4e, 0xb5, 0xe6)), boundedTextRect);

            bitmap.Save("../../../../_Output/PlainAndBoundedText.png");
        }
    }

    /// <summary>
    /// Draws multiline plain text.
    /// </summary>
    private static void DrawMultilinePlainText()
    {
        using (var bitmap = new Bitmap(600, 250, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
        using (var graphics = bitmap.GetAdvancedGraphics())
        {
            var brush = new SolidBrush(new RgbColor(0x41, 0x41, 0x41));
            var dummyText = @"Lorem ipsum dolor sit amet,
consectetur adipiscing elit. Cras
elementum quam ac nisi varius gravida.
Mauris ornare, dolor et scelerisque volutpat, enim
urna commodo odio,
consequat fermentum sem arcu sit amet nisl.
Aliquam tincidunt id neque
in gravida. Mauris mollis est
vulputate suscipit facilisis.";

            var text = new PlainText(dummyText, graphics.CreateFont("Verdana", 20f), brush)
            {
                Position = new System.Drawing.PointF(10f, 30f),
            };

            graphics.DrawText(text);

            bitmap.Save("../../../../_Output/DrawMultilinePlainText.png");
        }
    }

    /// <summary>
    /// Draws plain text with gradient fill.
    /// </summary>
    private static void PlainTextWithGradientColor()
    {
        using (var bitmap = new Bitmap(600, 250, PixelFormat.Format24bppRgb, new RgbColor(255, 255, 255, 255)))
        using (var graphics = bitmap.GetAdvancedGraphics())
        {
            var gradientBrush = new LinearGradientBrush()
            {
                BackgroundColor = RgbColor.Green,
                StartPoint = new System.Drawing.PointF(0, 0),
                EndPoint = new System.Drawing.PointF(600, 400),
                ColorStops = new ColorStop[]
                {
                    new ColorStop() { Color = RgbColor.Aqua, Position = 0.0f },
                    new ColorStop() { Color = RgbColor.Black, Position = 0.66f },
                    new ColorStop() { Color = RgbColor.Violet, Position = 1 },
                },
            };

            var dummyText = "GRADIENT";

            var text = new PlainText(dummyText, graphics.CreateFont("Verdana", 110f))
            {
                Position = new System.Drawing.PointF(10f, 230f),
                Brush = gradientBrush,
            };

            graphics.DrawText(text);

            bitmap.Save("../../../../_Output/PlainTextWithGradientBrush.png");
        }
    }

    /// <summary>
    /// Draws text with sharp corners using double outline with a round line join.
    /// </summary>
    private static void PlainTextWithRoundedDoubleOutline()
    {
        var bgColor = new RgbColor(23, 42, 88);
        var fillColor = new RgbColor(254, 190, 16);

        using (var bitmap = new Bitmap(600, 250, PixelFormat.Format24bppRgb, bgColor))
        using (var fr = new CustomFontRegistry())
        using (var gr = bitmap.GetAdvancedGraphics())
        {
            var psName = fr.Add("../../../../_Input/Fonts/Jost/Jost-Regular.ttf");

            gr.FontRegistry = fr;

            var text = new PlainText("WOW", gr.CreateFont(psName, 190))
            {
                Position = new System.Drawing.PointF(10, 220),
            };

            text.Brush = null;
            text.Pen = new Pen(RgbColor.White, 15);
            text.Pen.LineJoin = Aurigma.GraphicsMill.AdvancedDrawing.LineJoin.Round;

            gr.DrawText(text);

            text.Brush = new SolidBrush(fillColor);
            text.Pen = new Pen(bgColor, 5);
            text.Pen.LineJoin = Aurigma.GraphicsMill.AdvancedDrawing.LineJoin.Round;

            gr.DrawText(text);

            bitmap.Save("../../../../_Output/PlainTextWithRoundedOutline.png");
        }
    }
}