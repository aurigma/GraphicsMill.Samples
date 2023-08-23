using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Matrix = System.Drawing.Drawing2D.Matrix;
using PointF = System.Drawing.PointF;
using RectangleF = System.Drawing.RectangleF;

internal class WatermarkExample
{
    private static void Main(string[] args)
    {
        DrawRotatedTextWatermark();
        DrawMultilineWatermark();
    }

    /// <summary>
    /// Simple rotated text watermark
    /// </summary>
    private static void DrawRotatedTextWatermark()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Venice.jpg"))
        using (var gr = bitmap.GetAdvancedGraphics())
        using (var textPath = new Path())
        {
            var watermarkColor = new RgbColor(255, 255, 255, 45);

            var fontSize = UnitConverter.ConvertPixelsToUnits(bitmap.DpiY, bitmap.Height, Unit.Point) / 100.0f;

            var plainText = new PlainText("Graphics Mill", gr.CreateFont("Arial", fontSize));

            textPath.DrawText(plainText, gr.FontRegistry, gr.DpiX, gr.DpiY);

            var rect = new RectangleF(0, 0, bitmap.Width, bitmap.Height);

            var transform = new Matrix();
            transform.RotateAt(-35, new PointF(rect.Left + (rect.Width / 2), rect.Top + (rect.Height / 2)));

            float offset = plainText.GetBlackBox(gr.FontRegistry, gr.DpiX, gr.DpiY).Width / 2;

            using (var tiledTextPath = TilePathText(textPath, GetInvertedRect(rect, transform), offset))
            {
                tiledTextPath.ApplyTransform(transform);
                gr.FillPath(new SolidBrush(watermarkColor), tiledTextPath);
            }

            bitmap.Save("../../../../_Output/VeniceRotatedWatermark.jpg");
        }
    }

    /// <summary>
    /// Multiline text with different settings and additional grids
    /// </summary>
    private static void DrawMultilineWatermark()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Venice.jpg"))
        using (var gr = bitmap.GetAdvancedGraphics())
        using (var textPath = new Path())
        {
            var watermarkColor = new RgbColor(255, 255, 255, 45);

            var fontSize = UnitConverter.ConvertPixelsToUnits(bitmap.DpiY, bitmap.Height, Unit.Point) / 40.0f;

            var watermarkText = string.Format("<span>Graphics Mill</span><br/><span style=\"font-size:{0}pt\">© {1} Aurigma, Inc.</span>", (int)(fontSize / 2), DateTime.Now.Year);

            var text = new PlainText(watermarkText, gr.CreateFont("Arial", fontSize));
            text.Alignment = TextAlignment.Right;
            text.CharStyle.Leading = 1;

            textPath.DrawText(text, gr.FontRegistry, gr.DpiX, gr.DpiY);

            var rect = new RectangleF(0, 0, bitmap.Width, bitmap.Height);

            float offset = text.GetBlackBox(gr.FontRegistry, gr.DpiX, gr.DpiY).Width / 2;

            using (var tiledTextPath = TilePathText(textPath, rect, offset))
            {
                gr.FillPath(new SolidBrush(watermarkColor), tiledTextPath);

                for (float i = offset; i < bitmap.Width; i += offset / 2)
                {
                    gr.DrawEllipse(new Pen(watermarkColor, 3), -i, rect.Height - i, i * 2, i * 2);
                    gr.DrawEllipse(new Pen(watermarkColor, 3), rect.Width - i, rect.Height - i, i * 2, i * 2);
                }
            }

            bitmap.Save("../../../../_Output/VeniceMultilineWatermark.jpg");
        }
    }

    /// <summary>
    /// Gets rectangle required for a visible content
    /// </summary>
    static private RectangleF GetInvertedRect(RectangleF rect, Matrix transform)
    {
        var t = (System.Drawing.Drawing2D.Matrix)transform.Clone();

        t.Invert();

        using (var path = new Path())
        {
            path.DrawRectangle(rect);
            path.ApplyTransform(t);

            return path.GetBounds();
        }
    }

    /// <summary>
    /// Tiles path text inside a rectangle
    /// </summary>
    static private Path TilePathText(Path pathText, RectangleF rect, float offset)
    {
        var textBounds = pathText.GetBounds();
        pathText.ApplyTransform(CreateTranslateMatrix(rect.X - textBounds.Left, rect.Y - textBounds.Top));

        var tiledText = new Path();

        using (var firstLine = new Path())
        {
            while (rect.Contains(pathText.GetBounds()))
            {
                firstLine.DrawPath(pathText);
                pathText.ApplyTransform(CreateTranslateMatrix(textBounds.Width + offset, 0));
            }

            float lineOffset = textBounds.Width / 2;

            if (firstLine.Points.Count == 0)
            {
                return tiledText;
            }

            while (rect.Bottom > firstLine.GetBounds().Bottom)
            {
                tiledText.DrawPath(firstLine);
                firstLine.ApplyTransform(CreateTranslateMatrix(lineOffset, textBounds.Height + offset));
                lineOffset *= -1;
            }

            return tiledText;
        }
    }

    /// <summary>
    /// Creates translate matrix
    /// </summary>
    static private Matrix CreateTranslateMatrix(float dx, float dy)
    {
        var translate = new Matrix();

        translate.Translate(dx, dy);

        return translate;
    }
}