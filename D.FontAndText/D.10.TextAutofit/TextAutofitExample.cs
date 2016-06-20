using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;

class TextAutofitExample
{
    static void Main(string[] args)
    {
        FitTextToArea();
    }

    /// <summary>
    /// Draws a text on a temporary path and returns its subpath count.
    /// </summary>
    static int GetTextElementCount(Text text)
    {
        using (var path = new Path())
        {
            path.DrawText(text);

            var subpaths = path.Split();

            foreach (var sp in subpaths)
                sp.Dispose();

            return subpaths.Length;
        }
    }

    /// <summary>
    /// Creates a text object.
    /// </summary>
    static PathBoundedText CreateText(float fontSize, Graphics graphics)
    {
        var str = "Since 2001, Aurigma have helped software developers add imaging functionality to their applications in a variety of industries. Our image processing Software Development Kit for .NET, Graphics Mill, is a truly powerful product we are proud to have developed.";

        var text = new PathBoundedText(str, graphics.CreateFont("Verdana", fontSize));

        var bounds = new Path();
        bounds.DrawEllipse(0, 0, graphics.Width, graphics.Height);

        text.BoundingPaths.Add(bounds);

        return text;
    }

    /// <summary>
    /// Demonstrates how to fit the largest possible text inside PathBoundedText area.
    /// </summary>
    static void FitTextToArea()
    {
        using (var bitmap = new Bitmap(400, 400, PixelFormat.Format24bppRgb, RgbColor.White))
        using (var graphics = bitmap.GetAdvancedGraphics())
        {
            float fontSize = 1;

            // Assume that we can place all text in an area with initial font size.
            int initialElementCount = GetTextElementCount(CreateText(fontSize, graphics));

            // Increase font size until text element count is the same. It means no shrinking occurs.
            while (GetTextElementCount(CreateText(fontSize + 1, graphics)) == initialElementCount)
                fontSize += 1;

            var largestText = CreateText(fontSize, graphics);

            graphics.DrawPath(new Pen(RgbColor.Blue), largestText.BoundingPaths[0]);
            graphics.DrawText(largestText);

            bitmap.Save("../../../../_Output/FitTextToArea.png");
        }
    }
}

