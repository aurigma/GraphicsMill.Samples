using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Codecs.Psd;
using Aurigma.GraphicsMill.Templates;
using Aurigma.GraphicsMill.Transforms;

internal class Create3DPreviewExample
{
    private static void Main(string[] args)
    {
        RenderMugPreview();
    }

    /// <summary>
    /// Creates 3D Preview of a customized mug using Adobe Photoshop's SmartObject
    /// http://www.graphicsmill.com/blog/2015/11/25/Creation-3D-preview-of-personalized-products
    /// </summary>
    private static void RenderMugPreview()
    {
        var psdProcessor = new PsdProcessor();

        psdProcessor.FrameCallback = (processor, frame) =>
        {
            if (frame.Type != FrameType.SmartObject || frame.Name != "Design")
            {
                return processor.ProcessFrame(frame);
            }

            var smartFrame = (PsdSmartFrame)frame;

            return smartFrame.ToGraphicsContainer(
                ImageReader.Create(@"../../../../_Input/Copenhagen_RGB.jpg"),
                ResizeMode.ImageFill);
        };

        psdProcessor.Render(@"../../../../_Input/Mug.psd", @"../../../../_Output/RenderMugPreview.png");
    }
}