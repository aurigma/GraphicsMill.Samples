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
            using (var writer = new PdfWriter(outPdf))
            using (var gr = writer.GetGraphics())
            {
                writer.AddPage(gc.Width, gc.Height, gc.DpiX, gc.DpiY);

                gr.BeforeDrawPath += (sender, e) =>
                {
                    if (e.Pen != null)
                        e.Pen = new Pen(RgbColor.DarkMagenta, e.Pen.Width);
                };

                gr.DrawContainer(gc, 0, 0);
            }
        }

        /// <summary>
        /// Enumerates the elements of graphics container
        /// </summary>
        private static void EnumContentItems(string inPdf)
        {
            using (var reader = new PdfReader(inPdf))
            using (var gc = reader.Frames[0].GetContent())
            using (var callbackContainer = new GraphicsContainer(gc.Width, gc.Height, gc.DpiX, gc.DpiY))
            using (var gr = callbackContainer.GetGraphics())
            {
                gr.BeforeDrawPath += (sender, e) =>
                {
                    if (e.Pen != null)
                        Console.WriteLine(string.Format("Stroke: {0}", e.Pen.Color.ToString()));

                    if (e.Brush != null)
                        Console.WriteLine(string.Format("Fill: {0}", e.Brush.ToString()));

                    e.Cancel = true;
                };

                gr.BeforeDrawImage += (sender, e) =>
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
        public static bool IsRed(this Color color)
        {
            var rgbColor = (RgbColor)color.Convert(PixelFormat.Format24bppRgb);

            return rgbColor.R > (rgbColor.G + rgbColor.B);
        }
    }
}
