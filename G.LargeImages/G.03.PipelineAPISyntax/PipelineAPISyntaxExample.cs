using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

internal class PipelineAPISyntaxExample
{
    private static void Main(string[] args)
    {
        ResizeBasicSyntax();
        ResizePipelineSyntax();
        ResizeSimpleSyntax();
    }

    private static void ResizeBasicSyntax()
    {
        // reader --->  resize  --->  writer
        using (var reader = ImageReader.Create("../../../../_Input/Venice.jpg"))
        using (var resize = new Resize(320, 0, ResizeInterpolationMode.High))
        using (var writer = ImageWriter.Create("../../../../_Output/PipelineBasics1.jpg"))
        {
            // Reader element sends data to resize element
            reader.Receivers.Add(resize);

            // Resize element sends data to writer element
            resize.Receivers.Add(writer);

            // Pass first element
            Pipeline.Run(reader);
        }
    }

    private static void ResizePipelineSyntax()
    {
        // reader --->  resize  --->  writer
        using (var reader = ImageReader.Create("../../../../_Input/Venice.jpg"))
        using (var resize = new Resize(320, 0, ResizeInterpolationMode.High))
        using (var writer = ImageWriter.Create("../../../../_Output/PipelineBasics2.jpg"))
        {
            // We use Pipeline class to chain (specify Receivers) reader, resize, and writer elements
            var pipeline = new Pipeline();
            pipeline.Add(reader);
            pipeline.Add(resize);
            pipeline.Add(writer);

            pipeline.Run();
        }
    }

    private static void ResizeSimpleSyntax()
    {
        // reader --->  resize  --->  writer
        using (var reader = ImageReader.Create("../../../../_Input/Venice.jpg"))
        using (var resize = new Resize(320, 0, ResizeInterpolationMode.High))
        using (var writer = ImageWriter.Create("../../../../_Output/PipelineBasics3.jpg"))
        {
            // We use plus operator to create a Pipeline collection and chain reader, resize, and writer elements
            (reader + resize + writer).Run();

            // You can use the alternative syntax for better readability
            // Pipeline.Run(reader + resize + writer);
        }
    }
}