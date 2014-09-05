using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.AdvancedDrawing;


class ClippingPathExample
{
	static void Main(string[] args)
	{
		CopyClippingPath();
		CopyClippingPathMemoryFriendly();
		CropImageAndPreserveClippingPath();
		ResizeImageAndClippingPath();
		ResizeImageAndClippingPathMemoryFriendly();
		ConvertClippingPathToMask();

		VisualizeClippingPath(@"../../../../_Output/CopyClippingPath.jpg", @"../../../../_Output/CopyClippingPath_Visualized.jpg");
		VisualizeClippingPath(@"../../../../_Output/CopyClippingPathMemoryFriendly.jpg", @"../../../../_Output/CopyClippingPathMemoryFriendly_Visualized.jpg");
		VisualizeClippingPath(@"../../../../_Output/CropImageAndPreserveClippingPath.jpg", @"../../../../_Output/CropImageAndPreserveClippingPath_Visualized.jpg");
		VisualizeClippingPath(@"../../../../_Output/ResizeImageAndClippingPath.jpg", @"../../../../_Output/ResizeImageAndClippingPath_Visualized.jpg");
		VisualizeClippingPath(@"../../../../_Output/ResizeImageAndClippingPathMemoryFriendly.jpg", @"../../../../_Output/ResizeImageAndClippingPathMemoryFriendly_Visualized.jpg");
	}


	/// <summary>
	/// Copies all Adobe resources including clipping path
	/// </summary>
	private static void CopyClippingPath()
	{
		using (var reader = new JpegReader(@"../../../../_Input/Apple.jpg"))
		using (var bitmap = reader.Frames[0].GetBitmap())
		{
			var jpegSettings = new JpegSettings();
			jpegSettings.AdobeResources = reader.AdobeResources;

			bitmap.Save(@"../../../../_Output/CopyClippingPath.jpg", jpegSettings);
		}	
	}


	/// <summary>
	/// Copies clipping path using memory-friendly Pipeline API
	/// </summary>
	private static void CopyClippingPathMemoryFriendly()
	{
		using (var reader = new JpegReader(@"../../../../_Input/Apple.jpg"))
		using (var writer = new JpegWriter(@"../../../../_Output/CopyClippingPathMemoryFriendly.jpg"))
		{
			if (reader.AdobeResources != null)
			{
				var adobeResources = new AdobeResourceDictionary();

				const int firstPathId = 2000;
				const int lastPathId = 2998;

				for (int i = firstPathId; i <= lastPathId; i++)
				{
					if (reader.AdobeResources.Contains(i))
					{
						adobeResources[i] = reader.AdobeResources[i];
					}

				}
				writer.AdobeResources = adobeResources;
			}
			Pipeline.Run(reader + writer);
		}
	}


	/// <summary>
	/// Crops image and preserves clipping path
	/// </summary>
	private static void CropImageAndPreserveClippingPath()
	{
		using (var reader = new JpegReader(@"../../../../_Input/Apple.jpg"))
		using (var writer = new JpegWriter(@"../../../../_Output/CropImageAndPreserveClippingPath.jpg"))
		using (var crop = new Crop(reader.Width / 6, 0, reader.Width / 2, reader.Height / 2))
		{
			writer.AdobeResources = reader.AdobeResources;

			Pipeline.Run(reader + crop + writer);
		}
	}


	/// <summary>
	/// Resizes image and clipping path
	/// </summary>
	private static void ResizeImageAndClippingPath()
	{
		using (var reader = new JpegReader(@"../../../../_Input/Apple.jpg"))
		using (var bitmap = reader.Frames[0].GetBitmap())
		{
			var jpegSettings = new Aurigma.GraphicsMill.Codecs.JpegSettings();
			jpegSettings.AdobeResources = reader.AdobeResources;

			bitmap.Transforms.Resize(reader.Width / 2, reader.Height / 2);

			bitmap.Save(@"../../../../_Output/ResizeImageAndClippingPath.jpg", jpegSettings);
		}
	}


	/// <summary>
	/// Resizes image and clipping path using memory-friendly Pipeline API
	/// </summary>
	private static void ResizeImageAndClippingPathMemoryFriendly()
	{
		using (var reader = new JpegReader(@"../../../../_Input/Apple.jpg"))
		using (var writer = new JpegWriter(@"../../../../_Output/ResizeImageAndClippingPathMemoryFriendly.jpg"))
		using (var resize = new Resize(reader.Width / 2, reader.Height / 2))
		{
			writer.AdobeResources = reader.AdobeResources;

			Pipeline.Run(reader + resize + writer);
		}

	}


	/// <summary>
	/// Converts clipping path to alpha channel mask
	/// </summary>
	private static void ConvertClippingPathToMask()
	{
		using (var reader = new JpegReader(@"../../../../_Input/Apple.jpg"))
		using (var bitmap = reader.Frames[0].GetBitmap())
		using (var maskBitmap = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format8bppGrayscale, new GrayscaleColor(0)))
		using (var graphics = maskBitmap.GetAdvancedGraphics())
		{
			var graphicsPath = reader.ClippingPaths[0].CreateGraphicsPath(reader.Width, reader.Height);

			graphics.FillPath(new SolidBrush(new GrayscaleColor(255)), Path.Create(graphicsPath));

			bitmap.Channels.SetAlpha(maskBitmap);

			bitmap.Save(@"../../../../_Output/ConvertClippingPathToMask.png");
		}
	}


	/// <summary>
	/// Visualizes clipping path for demonstration purposes
	/// </summary>
	private static void VisualizeClippingPath(string inputPath, string outputPath)
	{
		using (var reader = new JpegReader(inputPath))
		using (var bitmap = reader.Frames[0].GetBitmap())
		using (var graphics = bitmap.GetAdvancedGraphics())
		{
			var graphicsPath = reader.ClippingPaths[0].CreateGraphicsPath(reader.Width, reader.Height);

			graphics.DrawPath(new Pen(new RgbColor(0, 0, 255, 127), 4f), Path.Create(graphicsPath));

			bitmap.Save(outputPath);
		}
	}

}

