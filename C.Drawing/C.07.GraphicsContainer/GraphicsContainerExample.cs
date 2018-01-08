using System;

using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Codecs;

namespace GraphicsContainerSample
{
    public class GraphicsContainerExamples
    {
        public static void Main(string[] args)
        {
            SaveGraphicsContainerToJpeg("../../../../_Input/GraphicsContainer.pdf", "../../../../_Output/GraphicsContainer.jpg");

            RecolorRedStrokes("../../../../_Input/GraphicsContainer.pdf", "../../../../_Output/GraphicsContainer_RecolorRedStrokes.pdf");

            EnumContentItems("../../../../_Input/GraphicsContainer.pdf");
        }

        /// <summary>
        /// Gets content from the specified PDF file and saves it as JPEG format
        /// </summary>
        private static void SaveGraphicsContainerToJpeg(string pdfPath, string jpegPath)
        {
            using (var reader = new PdfReader(pdfPath))
            using (var gc = reader.Frames[0].GetContent())
            using (var writer = new JpegWriter(jpegPath))
            using (var ig = new ImageGenerator(gc, PixelFormat.Format24bppRgb, RgbColor.White))
            {
                Pipeline.Run(ig + writer);
            }
        }

        /// <summary>
        /// Demonstrates how to edit shape stroke color with DrawPath event
        /// </summary>
        private static void RecolorRedStrokes(string inPdf, string outPdf)
        {
            using (var reader = new PdfReader(inPdf))
            using (var gc = reader.Frames[0].GetContent())
            using (var updatedContainer = new GraphicsContainer(gc.Width, gc.Height, gc.DpiX, gc.DpiY))
            using (var gr = updatedContainer.GetGraphics())
            {
                updatedContainer.DrawPath += (sender, e) =>
                {
                    if (e.Pen != null && e.Pen.Color.IsRed())
                    {
                        // This sample works fine without all these complex manipulations 
                        // with transforms and clipping paths, but in general case, 
                        // we need to handle it correctly. 

                        var oldTransform = gr.Transform;

                        foreach (var cp in e.ClippingPaths)
                            gr.ClippingPaths.Add(cp);

                        gr.Transform = e.Transform;
                        gr.FillingRule = e.FillingRule;
                        gr.BlendMode = e.BlendMode;

                        if (e.Brush != null)
                            gr.FillPath(e.Brush, e.Path);

                        if (e.Pen != null)
                            gr.DrawPath(new Pen(RgbColor.DarkMagenta, e.Pen.Width), e.Path);

                        gr.Transform = oldTransform;
                        gr.ClippingPaths.Clear();

                        // We don't want to add this path to the container
                        e.Cancel = true;
                    }
                };

                gr.DrawContainer(gc, 0, 0);

                updatedContainer.SaveToPdf(outPdf);
            }
        }

        private static void EnumContentItems(string inPdf)
        {
            using (var reader = new PdfReader(inPdf))
            using (var gc = reader.Frames[0].GetContent())
            using (var callbackContainer = new GraphicsContainer(gc.Width, gc.Height, gc.DpiX, gc.DpiY))
            using (var gr = callbackContainer.GetGraphics())
            {
                callbackContainer.DrawPath += (sender, e) =>
                {
                    if (e.Pen != null)
                        Console.WriteLine(string.Format("Stroke: {0}", e.Pen.Color.ToString()));

                    if (e.Brush != null)
                        Console.WriteLine(string.Format("Fill: {0}", e.Brush.ToString()));

                    e.Cancel = true;
                };

                callbackContainer.DrawImage += (sender, e) =>
                {
                    Console.WriteLine(string.Format("Bitmap: {0} x {1}", e.Bitmap.Width, e.Bitmap.Height));

                    e.Cancel = true;
                };

                gr.DrawContainer(gc, 0, 0);
            }
        }
    }

    public static class Extensions
    {
        public static void SaveToPdf(this GraphicsContainer container, string pdfPath)
        {
            using (var writer = new PdfWriter(pdfPath))
            using (var gr = writer.GetGraphics())
            {
                writer.AddPage(container.Width, container.Height, container.DpiX, container.DpiY);
                gr.DrawContainer(container, 0, 0);
            }
        }

        public static bool IsRed(this Color color)
        {
            RgbColor rgbColor = (RgbColor)color.Convert(PixelFormat.Format24bppRgb);

            return rgbColor.R > (rgbColor.G + rgbColor.B);
        }
    }
}
