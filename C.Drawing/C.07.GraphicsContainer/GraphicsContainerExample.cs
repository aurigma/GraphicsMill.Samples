using System;
using System.Linq;

using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.Codecs;

namespace GraphicsContainerSample
{
    public static class Extensions
    {
        public static bool IsRed(this Color color)
        {
            var rgbColor = (RgbColor)color.Convert(PixelFormat.Format24bppRgb);

            return rgbColor.R > (rgbColor.G + rgbColor.B);
        }

        public static void PrintContent(this GraphicsContainer container)
        {
            foreach (var shapeItem in container.Items.OfType<ShapeItem>())
            {
                Console.WriteLine("Shape:");

                if (shapeItem.Brush != null)
                    Console.WriteLine($"  {shapeItem.Brush.ToString()}");

                if (shapeItem.Pen != null)
                    Console.WriteLine($"  {shapeItem.Pen.ToString()}");
            }

            foreach (var imageItem in container.Items.OfType<ImageItem>())
            {
                Console.WriteLine($"Image: {imageItem.Bitmap.Width} x ${imageItem.Bitmap.Height}");
            }

            foreach (var textItem in container.Items.OfType<TextItem>())
            {
                Console.WriteLine($"Text: {textItem.Text.String}");
            }

            foreach (var containerItem in container.Items.OfType<ContainerItem>())
            {
                containerItem.GraphicsContainer.PrintContent();
            }
        }
    }
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
        /// Demonstrates how to edit shape stroke color
        /// </summary>
        private static void RecolorRedStrokes(string inPdf, string outPdf)
        {
            using (var reader = new PdfReader(inPdf))
            using (var gc = reader.Frames[0].GetContent())
            using (var writer = new PdfWriter(outPdf))
            using (var gr = writer.GetGraphics())
            {
                writer.AddPage(gc.Width, gc.Height, gc.DpiX, gc.DpiY);

                foreach (var shapeItem in gc.Items.OfType<ShapeItem>())
                {
                    if (shapeItem.Pen != null)
                    {
                        shapeItem.Pen = new Pen(RgbColor.DarkMagenta, shapeItem.Pen.Width);
                    }
                }

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
            {
                gc.PrintContent();                
            }
        }
    }    
}
