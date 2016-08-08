using System;
using Aurigma.GraphicsMill.Transforms;

namespace Aurigma.GraphicsMill
{
    public static class ColorExtension
    {
        public static T To<T>(this Color color, ColorProfile destinationProfile = null, ColorManagementEngine engine = ColorManagementEngine.LittleCms, ColorProfile targetDeviceProfile = null,
            ColorTransformationIntent transformationIntent = ColorTransformationIntent.Perceptual) where T : Color, new()
        {
            return ColorExtension.ConvertColor<T>(color, destinationProfile, engine, targetDeviceProfile, transformationIntent);
        }

        public static T To<T>(this Color color, string destinationProfile = null, ColorManagementEngine engine = ColorManagementEngine.LittleCms, ColorProfile targetDeviceProfile = null,
            ColorTransformationIntent transformationIntent = ColorTransformationIntent.Perceptual) where T : Color, new()
        {
            return To<T>(color, new ColorProfile(destinationProfile), engine, targetDeviceProfile, transformationIntent);
        }

        public static T To<T>(this Color color) where T : Color, new()
        {
            return To<T>(color, (ColorProfile)null);
        }

        internal static T ConvertColor<T>(Color color, ColorProfile destinationProfile, ColorManagementEngine engine = ColorManagementEngine.LittleCms, ColorProfile targetDeviceProfile = null,
            ColorTransformationIntent transformationIntent = ColorTransformationIntent.Perceptual) where T : Color, new()
        {
            if (destinationProfile == null)
            {
                Type colorType = typeof(T);
                if (colorType != typeof(LabColor) && colorType != typeof(Lab16Color))
                {
                    throw new ArgumentException("Destination profile should be specified for converting to non-absolute color space (LabColor or Lab16Color)",
                        "destinationProfile");
                }
            }

            using (var cc = new Aurigma.GraphicsMill.Transforms.ColorConverter())
            {
                cc.DestinationProfile = destinationProfile;
                cc.TargetDeviceProfile = targetDeviceProfile;
                cc.ColorManagementEngine = engine;
                cc.TransformationIntent = transformationIntent;

                T tempColor = new T();

                cc.DestinationPixelFormat = tempColor.PixelFormat;

                return (T)cc.ConvertColor(color, color.Profile);
            }
        }

        internal static T ConvertColor<T>(Color color, string destinationProfile, ColorManagementEngine engine = ColorManagementEngine.LittleCms, ColorProfile targetDeviceProfile = null,
            ColorTransformationIntent transformationIntent = ColorTransformationIntent.Perceptual) where T : Color, new()
        {
            return ConvertColor<T>(color, new ColorProfile(destinationProfile), engine, targetDeviceProfile, transformationIntent);
        }
    }
}