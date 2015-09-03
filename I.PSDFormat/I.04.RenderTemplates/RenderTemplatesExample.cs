using System;
using System.Linq;
using System.Text.RegularExpressions;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Codecs.Psd;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Templates;

class RenderTemplatesExample
{
	static void Main(string[] args)
	{
        MergeLayers();
        UpdateText();
        UpdateTextColor();

        InvertBackground();
        ReplaceBackground();

        MergeSeal();
        UpdateTextAndShapeColor();
	}


    /// <summary>
    /// Merges PSD image to TIFF file
    /// </summary>	
    private static void MergeLayers()
	{
        var psdProcessor = new PsdProcessor();

        psdProcessor.Render(@"../../../../_Input/BusinessCard.psd", @"../../../../_Output/MergeLayers.tif");
	}


    /// <summary>
    /// Updates text layer of PSD image and saves to PDF file
    /// </summary>	
    private static void UpdateText()
    {
        var psdProcessor = new PsdProcessor();

        psdProcessor.StringCallback = (processor, textFrame) =>
        {
            var textString = textFrame.GetFormattedText();

            if (textFrame.Name == "Name")
                textString = "Type your name";

            return textString;
        };

        psdProcessor.Render(@"../../../../_Input/BusinessCard.psd", @"../../../../_Output/UpdateText.pdf");
    }


    /// <summary>
    /// Updates text color of PSD image and saves to PDF file
    /// </summary>	
    private static void UpdateTextColor()
    {
        var psdProcessor = new PsdProcessor();

        psdProcessor.TextCallback = (processor, textFrame, textString) =>
        {
            var text = processor.ProcessText(textFrame);
            text.String = textString;

            if (textFrame.Name == "Name")
                text.Brush = new SolidBrush(RgbColor.Red);

            return text;
        };

        psdProcessor.Render(@"../../../../_Input/BusinessCard.psd", @"../../../../_Output/UpdateTextColor.pdf");
    }


    /// <summary>
    /// Inverts background layer of PSD image and saves to PDF file
    /// </summary>	
    private static void InvertBackground()
    {
        var psdProcessor = new PsdProcessor();

        psdProcessor.FrameCallback = (processor, frame) =>
        {
            if (frame.Type != FrameType.Raster)
                return processor.ProcessFrame(frame);

            using (var invert = new Invert())
            {
                //We don't know size of template, but we know maximum size of frame
                var graphicsContainer = new GraphicsContainer(frame.X + frame.Width, frame.Y + frame.Height, frame.DpiX, frame.DpiY);

                using (var graphics = graphicsContainer.GetGraphics())
                {
                    graphics.DrawImage(frame + invert, frame.X, frame.Y);
                }

                return graphicsContainer;
            }
        };

        psdProcessor.Render(@"../../../../_Input/BusinessCard.psd", @"../../../../_Output/InvertBackground.pdf");
    }


    /// <summary>
    /// Replaces background image of PSD image and saves to PDF file
    /// </summary>	
    private static void ReplaceBackground()
    {
        PsdProcessor psdProcessor = new PsdProcessor();

        psdProcessor.FrameCallback = (processor, frame) =>
        {
            if (frame.Type != FrameType.Raster)
                return processor.ProcessFrame(frame);

            using (var background = ImageReader.Create(@"../../../../_Input/Venice.jpg"))
            using (var resize = new Resize(frame.Width, frame.Height, ResizeInterpolationMode.High, ResizeMode.ImageFill))
            using (var changeResolution = new ResolutionModifier(frame.DpiX, frame.DpiY))
            {
                background.CloseOnDispose = false;

                //We don't know size of template, but we know maximum size of frame
                var graphicsContainer = new GraphicsContainer(frame.X + frame.Width, frame.Y + frame.Height, frame.DpiX, frame.DpiY);

                using (var graphics = graphicsContainer.GetGraphics())
                {
                    graphics.DrawImage(background + resize + changeResolution, frame.X, frame.Y);
                }

                return graphicsContainer;
            }
        };

        psdProcessor.Render(@"../../../../_Input/BusinessCard.psd", @"../../../../_Output/ReplaceBackground.pdf");
    }


    /// <summary>
    ///  Merges PSD image with vector shape layers to PDF file
    /// </summary>	
    private static void MergeSeal()
    {
        var psdProcessor = new PsdProcessor();

        psdProcessor.Render(@"../../../../_Input/Seal.psd", @"../../../../_Output/MergeSeal.pdf");
    }


    /// <summary>
    /// Updates text and shape color of PSD image and saves to PDF file
    /// </summary>	
    private static void UpdateTextAndShapeColor()
    {
        var psdProcessor = new PsdProcessor();

        psdProcessor.TextCallback = (processor, textFrame, textString) =>
        {
            var text = processor.ProcessText(textFrame);
            text.String = textString;

            text.Brush = new SolidBrush(RgbColor.DarkRed);

            return text;
        };

        psdProcessor.FrameCallback = (processor, frame) =>
        {
            if (frame.Type != FrameType.Shape)
                return processor.ProcessFrame(frame);

            var shapeFrame = (PsdShapeFrame)frame;

            var graphicsContainer = new GraphicsContainer(frame.X + frame.Width, frame.Y + frame.Height, frame.DpiX, frame.DpiY);

            using (var graphics = graphicsContainer.GetGraphics())
            {
                graphics.FillPath(new SolidBrush(RgbColor.DarkGreen), shapeFrame.VectorMask);
            }

            return graphicsContainer;
        };

        psdProcessor.Render(@"../../../../_Input/Seal.psd", @"../../../../_Output/UpdateTextAndShapeColor.pdf");
    }
}