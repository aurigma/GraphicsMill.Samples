using System;
using System.Collections.Generic;
using System.IO;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;


class SplitImageIntoTilesExample
{
	private struct ZoomLevel
	{
		public int ImageWidth;
		public int ImageHeight;
		public int GridWidth;
		public int GridHeight;
	}


	static void Main(string[] args)
	{
		SplitImageIntoTiles(256);
	}


	static void SplitImageIntoTiles(int tileSize)
	{
		var outputPath = "../../../../_Output/SplitImagesintoTiles/";

		if (!Directory.Exists(outputPath))
		{
			Directory.CreateDirectory(outputPath);
		}

		// Store reference to all pipeline elements for further correct object disposing
		var pipelineElements = new List<PipelineElement>();

		try
		{
			var reader = ImageReader.Create("../../../../_Input/Venice.jpg");
			pipelineElements.Add(reader);

			var d = 1f;

			var zoomLevels = new List<ZoomLevel>();

			ZoomLevel zoomLevel;

			do
			{
				zoomLevel.ImageWidth = (int)((float)reader.Width / d);
				zoomLevel.ImageHeight = (int)((float)reader.Height / d);
				zoomLevel.GridWidth = (zoomLevel.ImageWidth + tileSize - 1) / tileSize;
				zoomLevel.GridHeight = (zoomLevel.ImageHeight + tileSize - 1) / tileSize;

				zoomLevels.Add(zoomLevel);

				d *= 2;

			} while (zoomLevel.ImageWidth > tileSize || zoomLevel.ImageHeight > tileSize);

			zoomLevels.Reverse();


			for (int zoom = 0; zoom < zoomLevels.Count; zoom++)
			{
				PipelineElement resize;

				if (zoom == zoomLevels.Count)
				{
					resize = reader;
				}
				else
				{
					resize = new Resize(zoomLevels[zoom].ImageWidth, zoomLevels[zoom].ImageHeight, ResizeInterpolationMode.Lanczos3);
					pipelineElements.Add(resize);
					reader.Receivers.Add(resize);
				}


				for (int tileX = 0; tileX < zoomLevels[zoom].GridWidth; tileX++)
				{
					for (int tileY = 0; tileY < zoomLevels[zoom].GridHeight; tileY++)
					{
						int x = tileX * tileSize;
						int y = tileY * tileSize;
						int width = Math.Min((tileX + 1) * tileSize, zoomLevels[zoom].ImageWidth) - x;
						int height = Math.Min((tileY + 1) * tileSize, zoomLevels[zoom].ImageHeight) - y;

						var crop = new Crop(x, y, width, height);
						pipelineElements.Add(crop);
						resize.Receivers.Add(crop);

						var outputFilePath = String.Format(outputPath + "{0}-{1}-{2}.jpg", zoom, tileX, tileY);

						var p = Path.GetDirectoryName(outputFilePath);

						var writer = new JpegWriter(outputFilePath);

						pipelineElements.Add(writer);
						crop.Receivers.Add(writer);
					}
				}
			}

			Pipeline.Run(reader);
		}
		finally
		{
			for (var i = 0; i < pipelineElements.Count; i++)
			{
				pipelineElements[i].Dispose();
			}
		}
	}
}
