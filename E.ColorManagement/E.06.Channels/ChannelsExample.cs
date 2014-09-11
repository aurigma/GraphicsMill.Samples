using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.AdvancedDrawing;


class ChannelsExample
{
	static void Main(string[] args)
	{
		SplitChannels();
		CombineChannels();
		AddAlphaChannel();
		AddAlphaChannelMemoryFriendly();
		RemoveAlphaChannel();
		RemoveAlphaChannelMemoryFriendly();
		SwapChannels();
		SwapChannelsMemoryFriendly();
		Transparentize();
		TransparentizeMemoryFriendly();
	}

	/// <summary>
	/// Splits image channels into multiple receivers
	/// </summary>	
	private static void SplitChannels()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Copenhagen_CMYK.jpg"))
		using (var splitter = new CmykChannelSplitter())
		using (var writerC = new TiffWriter("../../../../_Output/Copenhagen_C.tif"))
		using (var writerM = new TiffWriter("../../../../_Output/Copenhagen_M.tif"))
		using (var writerY = new TiffWriter("../../../../_Output/Copenhagen_Y.tif"))
		using (var writerK = new TiffWriter("../../../../_Output/Copenhagen_K.tif"))
		{
			splitter.C = writerC;
			splitter.M = writerM;
			splitter.Y = writerY;
			splitter.K = writerK;

			Pipeline.Run(reader + splitter);
		}
	}


	/// <summary>
	/// Combines image channels from multiple sources
	/// </summary>
	private static void CombineChannels()
	{
		using (var writer = ImageWriter.Create("../../../../_Output/Copenhagen_CMYK_Combined.jpg"))
		using (var combiner = new CmykChannelCombiner())
		using (var readerC = new TiffReader("../../../../_Output/Copenhagen_C.tif"))
		using (var readerM = new TiffReader("../../../../_Output/Copenhagen_M.tif"))
		using (var readerY = new TiffReader("../../../../_Output/Copenhagen_Y.tif"))
		using (var readerK = new TiffReader("../../../../_Output/Copenhagen_K.tif"))
		{
			combiner.C = readerC;
			combiner.M = readerM;
			combiner.Y = readerY;
			combiner.K = readerK;

			Pipeline.Run(combiner + writer);
		}
	}


	/// <summary>
	/// Adds alpha channel
	/// </summary>
	private static void AddAlphaChannel()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		using (var alpha = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format8bppGrayscale , new GrayscaleColor(0)))
        using (var graphics = alpha.GetAdvancedGraphics())
		{
			graphics.FillEllipse(new SolidBrush(new GrayscaleColor(255)), 
				0, 0, bitmap.Width, bitmap.Height);

			bitmap.Channels.SetAlpha(alpha);

			bitmap.Save("../../../../_Output/AddAlphaChannel.png");
		}
	}


	/// <summary>
	/// Adds alpha channel using memory-friendly Pipeline API
	/// </summary>
	private static void AddAlphaChannelMemoryFriendly()
	{
		// reader --------------->  setAlpha  --->  writer
		// alpha  --->  drawer  ---/
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var alpha = new ImageGenerator(reader.Width, reader.Height, PixelFormat.Format8bppGrayscale, new GrayscaleColor(0)))
		using (var drawer = new Drawer())
		using (var setAlpha = new SetAlpha())
		using (var writer = ImageWriter.Create("../../../../_Output/AddAlphaChannelMemoryFriendly.png"))
		{
			drawer.Draw += (sender, e) =>
			{
				e.Graphics.FillEllipse(new SolidBrush(new GrayscaleColor(255)),
					0, 0, reader.Width, reader.Height); 
			};

			setAlpha.AlphaSource = alpha + drawer;

			Pipeline.Run(reader + setAlpha + writer);
		}
	}


	/// <summary>
	/// Removes alpha channel
	/// </summary>
	private static void RemoveAlphaChannel()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Stamp.png"))
		{
			bitmap.Channels.RemoveAlpha();

			bitmap.Save("../../../../_Output/RemoveAlphaChannel.png");
		}
	}


	/// <summary>
	/// Removes alpha channel using memory-friendly Pipeline API
	/// </summary>
	private static void RemoveAlphaChannelMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Stamp.png"))
		using (var removeAlpha = new RemoveAlpha())
		using (var writer = ImageWriter.Create("../../../../_Output/RemoveAlphaChannelMemoryFriendly.png"))
		{
			Pipeline.Run(reader + removeAlpha + writer);
		}
	}


	/// <summary>
	/// Swaps channels
	/// </summary>
	private static void SwapChannels()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			// http://www.graphicsmill.com/docs/gm/accessing-pixel-data.htm
			// Format24bppRgb - [Blue] = 0|[Green] = 1|[Red] = 2
			// Swap blue (0) and green (1) channels
			bitmap.Channels.SwapChannels(new int[] { 1, 0, 2 });

			bitmap.Save("../../../../_Output/SwapChannels.jpg");
		}
	}


	/// <summary>
	/// Swaps channels
	/// </summary>
	private static void SwapChannelsMemoryFriendly()
	{
		//                         /-- (R) ------- (R)--\
		//                        /                      \
		// reader --->  splitter  ---- (G) --\ /-- (B)----  combiner  ---> writer
		//                        \           X          /
		//                         \-- (B) --/ \-- (G)--/ 
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var splitter = new RgbChannelSplitter())
		using (var combiner = new RgbChannelCombiner())
		using (var writer = ImageWriter.Create("../../../../_Output/SwapChannelsMemoryFriendly.jpg"))
		{
			reader.Receivers.Add(splitter);

			combiner.R = splitter.R;
			combiner.G = splitter.B;
			combiner.B = splitter.G;

			combiner.Receivers.Add(writer);

			Pipeline.Run(combiner);
		}
	}


	/// <summary>
	///  Sets alpha values of pixels with a given color to transparent
	/// </summary>
	private static void Transparentize()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Channels.SetAlpha(1f);
			bitmap.Channels.Transparentize(new RgbColor(0x8a, 0xb9, 0xed), 0.1f);

			bitmap.Save("../../../../_Output/Transparentize.png");
		}
	}


	/// <summary>
	///  Sets alpha values of pixels with a given color to transparent using memory-friendly Pipeline API
	/// </summary>
	private static void TransparentizeMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var transparentize = new Transparentize())
		using (var writer = ImageWriter.Create("../../../../_Output/TransparentizeMemoryFriendly.png"))
		{
			transparentize.BackgroundColor = new RgbColor(0x8a, 0xb9, 0xed);
			transparentize.Threshold = 0.1f;

			Pipeline.Run(reader + transparentize + writer);
		}
	}
}

