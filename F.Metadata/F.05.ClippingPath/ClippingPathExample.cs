using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.AdvancedDrawing;


class ClippingPathExample
{
    //2000-2997 Clipping path information 
    //http://www.adobe.com/devnet-apps/photoshop/fileformatashtml/ 
    const int FirstPathId = 2000;
    const int LastPathId = 2997;


	static void Main(string[] args)
	{
		CopyClippingPath();
		CopyClippingPathMemoryFriendly();
		CropImageAndPreserveClippingPath();
		ResizeImageAndClippingPath();
		ResizeImageAndClippingPathMemoryFriendly();
		ConvertClippingPathToMask();
		ModifyClippingPathExplicitlyMemoryFriendly();
		ModifyClippingPathExplicitly();

		VisualizeClippingPath("../../../../_Output/CopyClippingPath.jpg", "../../../../_Output/CopyClippingPath_Visualized.jpg");
		VisualizeClippingPath("../../../../_Output/CopyClippingPathMemoryFriendly.jpg", "../../../../_Output/CopyClippingPathMemoryFriendly_Visualized.jpg");
		VisualizeClippingPath("../../../../_Output/CropImageAndPreserveClippingPath.jpg", "../../../../_Output/CropImageAndPreserveClippingPath_Visualized.jpg");
		VisualizeClippingPath("../../../../_Output/ResizeImageAndClippingPath.jpg", "../../../../_Output/ResizeImageAndClippingPath_Visualized.jpg");
		VisualizeClippingPath("../../../../_Output/ResizeImageAndClippingPathMemoryFriendly.jpg", "../../../../_Output/ResizeImageAndClippingPathMemoryFriendly_Visualized.jpg");
		VisualizeClippingPath("../../../../_Output/ModifyClippingPathExplicitlyMemoryFriendly.jpg", "../../../../_Output/ModifyClippingPathExplicitlyMemoryFriendly_Visualized.jpg");
		VisualizeClippingPath("../../../../_Output/ModifyClippingPathExplicitly.jpg", "../../../../_Output/ModifyClippingPathExplicitly_Visualized.jpg");
	}


	/// <summary>
	/// Copies all Adobe resources including clipping path
	/// </summary>
	private static void CopyClippingPath()
	{
		using (var reader = new JpegReader("../../../../_Input/Apple.jpg"))
		using (var bitmap = reader.Frames[0].GetBitmap())
		{
			var jpegSettings = new JpegSettings();
			jpegSettings.AdobeResources = reader.AdobeResources;

			bitmap.Save("../../../../_Output/CopyClippingPath.jpg", jpegSettings);
		}	
	}


	/// <summary>
	/// Copies clipping path using memory-friendly Pipeline API
	/// </summary>
	private static void CopyClippingPathMemoryFriendly()
	{
		using (var reader = new JpegReader("../../../../_Input/Apple.jpg"))
		using (var writer = new JpegWriter("../../../../_Output/CopyClippingPathMemoryFriendly.jpg"))
		{
			if (reader.AdobeResources != null)
			{
				var adobeResources = new AdobeResourceDictionary();

				for (int i = FirstPathId; i <= LastPathId; i++)
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
		using (var reader = new JpegReader("../../../../_Input/Apple.jpg"))
		using (var writer = new JpegWriter("../../../../_Output/CropImageAndPreserveClippingPath.jpg"))
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
		using (var reader = new JpegReader("../../../../_Input/Apple.jpg"))
		using (var bitmap = reader.Frames[0].GetBitmap())
		{
			var jpegSettings = new Aurigma.GraphicsMill.Codecs.JpegSettings();
			jpegSettings.AdobeResources = reader.AdobeResources;

			bitmap.Transforms.Resize(reader.Width / 2, reader.Height / 2);

			bitmap.Save("../../../../_Output/ResizeImageAndClippingPath.jpg", jpegSettings);
		}
	}


	/// <summary>
	/// Resizes image and clipping path using memory-friendly Pipeline API
	/// </summary>
	private static void ResizeImageAndClippingPathMemoryFriendly()
	{
		using (var reader = new JpegReader("../../../../_Input/Apple.jpg"))
		using (var writer = new JpegWriter("../../../../_Output/ResizeImageAndClippingPathMemoryFriendly.jpg"))
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
		using (var reader = new JpegReader("../../../../_Input/Apple.jpg"))
		using (var bitmap = reader.Frames[0].GetBitmap())
		using (var maskBitmap = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format8bppGrayscale, new GrayscaleColor(0)))
		using (var graphics = maskBitmap.GetAdvancedGraphics())
		{
			var graphicsPath = reader.ClippingPaths[0].CreateGraphicsPath(reader.Width, reader.Height);

			graphics.FillPath(new SolidBrush(new GrayscaleColor(255)), Path.Create(graphicsPath));

			bitmap.Channels.SetAlpha(maskBitmap);

			bitmap.Save("../../../../_Output/ConvertClippingPathToMask.png");
		}
	}


	/// <summary>
	/// Modifies clipping path explicitly using memory-friendly Pipeline API
	/// </summary>
	private static void ModifyClippingPathExplicitlyMemoryFriendly()
	{
		int width = 1000;
		int height = 1000;

		using (var reader = new JpegReader("../../../../_Input/Apple.jpg"))
		using (var generator = new ImageGenerator(width, height, reader.PixelFormat, RgbColor.White))
		using (var combiner = new Combiner(CombineMode.Copy))
		using (var writer = new JpegWriter("../../../../_Output/ModifyClippingPathExplicitlyMemoryFriendly.jpg"))
		{
			combiner.TopImage = reader;
			combiner.X = (width - reader.Width) / 2;
			combiner.Y = (height - reader.Height) / 2;

			//The clipping path has relatives coordinates (0.0f ... 1.f0). So we need to transform it.
			var transform = new System.Drawing.Drawing2D.Matrix();
			transform.Scale((float)reader.Width / (float)width, (float)reader.Height / (float)height);
			transform.Translate((float)combiner.X / (float)reader.Width, (float)combiner.Y / (float)reader.Height);

			var adobeResources = reader.AdobeResources;

			//Remove clipping paths
			foreach (long key in adobeResources.Keys)
			{
				if (key >= FirstPathId && key <= LastPathId)
				{
					adobeResources.Remove(key);
				}
			}

			//Transform and save clipping paths
			for (var i = 0; i < reader.ClippingPaths.Count; i++)
			{
				var clippingPath = reader.ClippingPaths[i];
				clippingPath.ApplyTransform(transform);

                adobeResources.Add(FirstPathId + i, new AdobeResourceBlock(clippingPath.Name, clippingPath.Data));
			}

			writer.AdobeResources = adobeResources;

			Pipeline.Run(generator + combiner + writer);
		}
	}


	/// <summary>
	/// Modifies clipping path explicitly
	/// </summary>
	private static void ModifyClippingPathExplicitly()
	{
		using (var reader = new JpegReader("../../../../_Input/Apple.jpg"))
		using (var bitmap = reader.Frames[0].GetBitmap())
		{
			var crop = new Crop(20, 20, bitmap.Width - 40, bitmap.Height - 40);

			var cropped = crop.Apply(bitmap);

			var clippingPath = reader.ClippingPaths[0];
			
			clippingPath.ApplyTransform(crop.GetPathTransformMatrix(bitmap.Width, bitmap.Height).ToGdiPlusMatrix());

			var adobeResources = new AdobeResourceDictionary();
			adobeResources.Add(FirstPathId, new AdobeResourceBlock("Apple", clippingPath.Data));

			var jpegSettings = new JpegSettings();
			jpegSettings.AdobeResources = adobeResources;

			cropped.Save("../../../../_Output/ModifyClippingPathExplicitly.jpg", jpegSettings);
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

