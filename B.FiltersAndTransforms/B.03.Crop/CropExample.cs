using System.Drawing;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;
using Bitmap = Aurigma.GraphicsMill.Bitmap;

internal class CropExample
{
    private static void Main(string[] args)
    {
        Crop();
        CropMemoryFriendly();
        CropCenterMemoryFriendly();
    }

    /// <summary>
    /// Crops image
    /// </summary>
    private static void Crop()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            bitmap.Transforms.Crop(230, 170, 320, 240);
            bitmap.Save("../../../../_Output/Crop.jpg");
        }
    }

    /// <summary>
    /// Crops image using memory-friendly Pipeline API
    /// </summary>
    private static void CropMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
        using (var crop = new Crop(230, 170, 320, 240))
        using (var writer = ImageWriter.Create("../../../../_Output/CropMemoryFriendly.jpg"))
        {
            Pipeline.Run(reader + crop + writer);
        }
    }

    /// <summary>
    /// Crops image center using memory-friendly Pipeline API
    /// </summary>
    private static void CropCenterMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
        using (var crop = new Crop())
        using (var writer = ImageWriter.Create("../../../../_Output/CropCenterMemoryFriendly.jpg"))
        {
            crop.OnInit += (sender, e) =>
            {
                float cropScale = 0.75f;

                var cropRectangle = new System.Drawing.RectangleF(
                    e.ImageParams.Width - ((e.ImageParams.Width * cropScale) / 2),
                    e.ImageParams.Height - ((e.ImageParams.Height * cropScale) / 2),
                    e.ImageParams.Width * cropScale,
                    e.ImageParams.Height * cropScale);

                (sender as Crop).Rectangle = Rectangle.Round(cropRectangle);
            };

            Pipeline.Run(reader + crop + writer);
        }
    }
}