using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class BezierExample
{
    static void Main(string[] args)
    {
        Bezier();
        BezierMemoryFriendly();
    }


    static System.Drawing.PointF[] ControlPoints = new []
    {
        new System.Drawing.PointF(0.0f, 0.0f),
        new System.Drawing.PointF(200.0f, 164.760284f),
        new System.Drawing.PointF(400.0f, -164.760284f),
        new System.Drawing.PointF(600.0f, 0.0f),
        new System.Drawing.PointF(0.0f, 150.0f),
        new System.Drawing.PointF(200.0f, 314.760284f),
        new System.Drawing.PointF(400.0f, -14.7602825f),
        new System.Drawing.PointF(600.0f, 150.0f),
        new System.Drawing.PointF(0.0f, 300.0f),
        new System.Drawing.PointF(200.0f, 464.760284f),
        new System.Drawing.PointF(400.0f, 135.239716f),
        new System.Drawing.PointF(600.0f, 300.0f),
        new System.Drawing.PointF(0.0f, 450.0f),
        new System.Drawing.PointF(200.0f, 614.760254f),
        new System.Drawing.PointF(400.0f, 285.239716f),
        new System.Drawing.PointF(600.0f, 450.0f)
    };


    /// <summary>
    /// Warps image
    /// </summary>
    private static void Bezier()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            bitmap.Transforms.ApplyBezier(ControlPoints, RgbColor.Transparent, InterpolationMode.High);
            bitmap.Save("../../../../_Output/Bezier.jpg");
        }
    }


    /// <summary>
    /// Warps image using memory-friendly Pipeline API
    /// </summary>
    private static void BezierMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
        using (var bezier = new BezierTransform(ControlPoints, RgbColor.Transparent, InterpolationMode.High))
        using (var writer = ImageWriter.Create("../../../../_Output/BezierMemoryFriendly.jpg"))
        {
            Pipeline.Run(reader + bezier + writer);
        }
    }
}

