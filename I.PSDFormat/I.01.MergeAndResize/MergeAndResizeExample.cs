﻿using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Codecs.Psd;
using Aurigma.GraphicsMill.Transforms;

internal class MergeAndResizeExample
{
    private static void Main(string[] args)
    {
        MergeAndResize();
        MergeAndMultipleResize();
    }

    /// <summary>
    /// Merges PSD layers
    /// </summary>
    private static void MergeAndResize()
    {
        using (var psdReader = new PsdReader("../../../../_Input/BusinessCard.psd"))
        using (var resize = new Resize(400, 0, ResizeInterpolationMode.High))
        using (var writer = ImageWriter.Create("../../../../_Output/BusinessCard_Resize.png"))
        {
            resize.Receivers.Add(writer);
            psdReader.MergeLayers(resize);
        }
    }

    /// <summary>
    /// Writes merged PSD layers to different sizes
    /// </summary>
    private static void MergeAndMultipleResize()
    {
        using (var psdReader = new PsdReader("../../../../_Input/BusinessCard.psd"))
        
        // This transform does nothing with image. We use it just to pass data to resize1 and resize2 transforms
        using (var repeater = new ImageTransmitter())
        using (var resize1 = new Resize(150, 0, ResizeInterpolationMode.High))
        using (var writer1 = ImageWriter.Create("../../../../_Output/BusinessCard_MultipleResize1.png"))
        using (var resize2 = new Resize(400, 0, ResizeInterpolationMode.High))
        using (var writer2 = ImageWriter.Create("../../../../_Output/BusinessCard_MultipleResize2.png"))
        {
            repeater.Receivers.Add(resize1);
            resize1.Receivers.Add(writer1);

            repeater.Receivers.Add(resize2);
            resize2.Receivers.Add(writer2);

            psdReader.MergeLayers(repeater);
        }
    }
}