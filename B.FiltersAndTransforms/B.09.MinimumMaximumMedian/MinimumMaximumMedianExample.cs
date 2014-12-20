using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

class MinimumMaximumMedianExample
{
	static void Main(string[] args)
	{
		Minimum();
		MinimumMemoryFriendly();

		Maximum();
		MaximumMemoryFriendly();

		Median();
		MedianMemoryFriendly();
	}


	/// <summary>
	/// Applies minimum filter
	/// </summary>
	private static void Minimum()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Transforms.Minimum(3);

			bitmap.Save("../../../../_Output/Minimum.jpg");
		}
	}


	/// <summary>
	/// Applies minimum filter using memory-friendly Pipeline API
	/// </summary>
	private static void MinimumMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var minimum = new Minimum(3))
		using (var writer = ImageWriter.Create("../../../../_Output/MinimumMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + minimum + writer);
		}
	}


	/// <summary>
	/// Applies maximum filter
	/// </summary>
	private static void Maximum()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Transforms.Maximum(3);

			bitmap.Save("../../../../_Output/Maximum.jpg");
		}
	}


	/// <summary>
	/// Applies maximum filter using memory-friendly Pipeline API
	/// </summary>
	private static void MaximumMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var maximum = new Maximum(3))
		using (var writer = ImageWriter.Create("../../../../_Output/MaximumMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + maximum + writer);
		}
	}


	/// <summary>
	/// Applies median filter
	/// </summary>
	private static void Median()
	{
		using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
		{
			bitmap.Transforms.Median(3);

			bitmap.Save("../../../../_Output/Median.jpg");
		}
	}


	/// <summary>
	/// Applies median filter using memory-friendly Pipeline API
	/// </summary>
	private static void MedianMemoryFriendly()
	{
		using (var reader = ImageReader.Create("../../../../_Input/Chicago.jpg"))
		using (var median = new Median(3))
		using (var writer = ImageWriter.Create("../../../../_Output/MedianMemoryFriendly.jpg"))
		{
			Pipeline.Run(reader + median + writer);
		}
	}
}

