using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class ResizeExample
{
	static void Main(string[] args)
	{
		Resize();
		ResizeMemoryFriendly();
		ResizeToBitmapMemoryFriendly();

        ResizeSharp();
        ResizeSharpMemoryFriendly();

		//See also F.Metadata --> F.02. Thumbnail from EXIF
	}


	/// <summary>
	/// Resizes image
	/// </summary>
	private static void Resize()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Transforms.Resize(320, 0, ResizeInterpolationMode.High);
			bitmap.Save("../../../../_Output/Resize.jpg");
		}
	}


	/// <summary>
	/// Resizes image using memory-friendly Pipeline API
	/// </summary>
	private static void ResizeMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var resize = new Resize(320, 0, ResizeInterpolationMode.High))
		using (var writer = ImageWriter.Create("../../../../_Output/ResizeMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + resize + writer);
		}
	}


	/// <summary>
	/// Resizes image to bitmap using memory-friendly Pipeline API
	/// </summary>
	private static void ResizeToBitmapMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var resize = new Resize(320, 0, ResizeInterpolationMode.High))
		using (var bitmap = new Bitmap())
		{
			Pipeline.Run(reader + resize + bitmap);

			bitmap.Save("../../../../_Output/ResizeToBitmapMemoryFriendly.jpg");
		}
	}


    /// <summary>
    /// Resizes image and maintains original sharpness (like Bicubic Sharper mode in Photoshop)
    /// </summary>
    private static void ResizeSharp()
    {
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            bitmap.Transforms.Resize(320, 0, ResizeInterpolationMode.High);
            bitmap.Transforms.UnsharpMask(0.35f, 1, 0);
            bitmap.Save("../../../../_Output/ResizeSharp.jpg");
        }
    }


    /// <summary>
    /// Resizes image and maintains original sharpness using memory-friendly Pipeline API (like Bicubic Sharper mode in Photoshop)
    /// </summary>
    private static void ResizeSharpMemoryFriendly()
    {
        using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
        using (var resize = new Resize(320, 0, ResizeInterpolationMode.High))
        using (var unsharpMask = new UnsharpMask(0.35f, 1, 0))
        using (var writer = ImageWriter.Create("../../../../_Output/ResizeSharpMemoryFriendly.jpg"))
        {
            Pipeline.Run(reader + resize + unsharpMask + writer);
        }
    }
}

