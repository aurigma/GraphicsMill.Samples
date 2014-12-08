using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Transforms;

namespace Aurigma.GraphicsMill
{
	public static class ColorExtension
	{
		public static ColorWithProfile<T> WithProfile<T>(this T color, string colorProfile) where T : Color, new()
		{
			return WithProfile<T>(color, new ColorProfile(colorProfile));
		}


		public static ColorWithProfile<T> WithProfile<T>(this T color, ColorProfile colorProfile) where T : Color, new()
		{
			return new ColorWithProfile<T>
			{
				ColorProfile = colorProfile,
				Color = color
			};
		}

		//LabColor is in absolute color space and doesn't requre assigned color profile
		public static ColorWithProfile<T> To<T>(this LabColor color, ColorProfile destinationProfile, ColorManagementEngine engine = ColorManagementEngine.LittleCms, ColorProfile targetDeviceProfile = null,
			ColorTransformationIntent transformationIntent = ColorTransformationIntent.Perceptual) where T : Color, new()
		{
			return new ColorWithProfile<T>
			{
				ColorProfile = destinationProfile,
				Color = ColorExtension.ConvertColor<T>(color, null, destinationProfile, engine, targetDeviceProfile, transformationIntent)
			};
		}


		public static ColorWithProfile<T> To<T>(this LabColor color, string destinationProfile, ColorManagementEngine engine = ColorManagementEngine.LittleCms, ColorProfile targetDeviceProfile = null,
			ColorTransformationIntent transformationIntent = ColorTransformationIntent.Perceptual) where T : Color, new()
		{
			return To<T>(color, new ColorProfile(destinationProfile), engine, targetDeviceProfile, transformationIntent);
		}


		//Lab16Color is in absolute color space and doesn't requre assigned color profile
		public static ColorWithProfile<T> To<T>(this Lab16Color color, ColorProfile destinationProfile, ColorManagementEngine engine = ColorManagementEngine.LittleCms, ColorProfile targetDeviceProfile = null,
			ColorTransformationIntent transformationIntent = ColorTransformationIntent.Perceptual) where T : Color, new()
		{
			return new ColorWithProfile<T>
			{
				ColorProfile = destinationProfile,
				Color = ColorExtension.ConvertColor<T>(color, null, destinationProfile, engine, targetDeviceProfile, transformationIntent)
			};
		}


		public static ColorWithProfile<T> To<T>(this Lab16Color color, string destinationProfile, ColorManagementEngine engine = ColorManagementEngine.LittleCms, ColorProfile targetDeviceProfile = null,
			ColorTransformationIntent transformationIntent = ColorTransformationIntent.Perceptual) where T : Color, new()
		{
			return To<T>(color, new ColorProfile(destinationProfile), engine, targetDeviceProfile, transformationIntent);
		}


		internal static T ConvertColor<T>(Color color, ColorProfile sourceProfile, ColorProfile destinationProfile, ColorManagementEngine engine = ColorManagementEngine.LittleCms, ColorProfile targetDeviceProfile = null,
			ColorTransformationIntent transformationIntent = ColorTransformationIntent.Perceptual) where T : Color, new()
		{
			using (var bitmap = new Aurigma.GraphicsMill.Bitmap(1, 1, color.PixelFormat, color))
			{
				bitmap.ColorProfile = sourceProfile;

				bitmap.ColorManagement.DestinationProfile = destinationProfile;
				bitmap.ColorManagement.TargetDeviceProfile = targetDeviceProfile;
				bitmap.ColorManagement.ColorManagementEngine = engine;
				bitmap.ColorManagement.TransformationIntent = transformationIntent;

				T tempColor = new T();
				bitmap.ColorManagement.Convert(tempColor.PixelFormat);


				return (T)bitmap.GetPixel(0, 0);
			}
		}
	}


	public class ColorWithProfile<T> where T : Color
	{
		public T Color { get; set; }

		public ColorProfile ColorProfile { get; set; }


		public ColorWithProfile<N> To<N>(ColorProfile destinationProfile = null, ColorManagementEngine engine = ColorManagementEngine.LittleCms, ColorProfile targetDeviceProfile = null,
			ColorTransformationIntent transformationIntent = ColorTransformationIntent.Perceptual) where N : Color, new()
		{
			if (destinationProfile == null)
			{
				Type colorType = typeof(N);
				if (colorType != typeof(LabColor) && colorType != typeof(LabColor))
				{
					throw new ArgumentException("Destination profile should be specified for converting to non-absolute color space (LabColor or Lab16Color)",
						"destinationProfile");
				}
			}

			return new ColorWithProfile<N>
			{
				ColorProfile = destinationProfile,
				Color = ColorExtension.ConvertColor<N>(this.Color, this.ColorProfile, destinationProfile, engine, targetDeviceProfile, transformationIntent)
			};
		}


		public ColorWithProfile<N> To<N>(string destinationProfile = null, ColorManagementEngine engine = ColorManagementEngine.LittleCms, ColorProfile targetDeviceProfile = null,
			ColorTransformationIntent transformationIntent = ColorTransformationIntent.Perceptual) where N : Color, new()
		{
			if (destinationProfile == null)
			{
				Type colorType = typeof(N);
				if(colorType != typeof(LabColor) && colorType != typeof(LabColor))
				{
					throw new ArgumentException("Destination profile should be specified for converting to non-absolute color space (LabColor or Lab16Color)", 
						"destinationProfile");
				}
			}

			return To<N>(new ColorProfile(destinationProfile), engine, targetDeviceProfile, transformationIntent);
		}


		public ColorWithProfile<N> To<N>() where N : Color, new()
		{
			return To<N>((ColorProfile)null);
		}
	}
}