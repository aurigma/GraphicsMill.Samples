using System;
using System.IO;
using System.Web.UI;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

namespace AjaxControls
{
    public partial class PhotoCropDemo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !IsCallback)
            {
                BitmapViewer1.SourceImageFilename = Server.MapPath(@"~/Venice.jpg");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!BitmapViewer1.HasContent || RectangleRubberband1.IsEmpty)
                return;

            var sourceFilePath = BitmapViewer1.SourceImageFilename;
            var rect = RectangleRubberband1.Rectangle;

            var outputFolder = Server.MapPath("~/Result");
            if (!Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder);

            var fileName = string.Format("{0}[{1},{2},{3},{4}]{5}",
                Path.GetFileNameWithoutExtension(sourceFilePath),
                rect.Left, rect.Top, rect.Width, rect.Height,
                Path.GetExtension(sourceFilePath));

            var filePath = Path.Combine(outputFolder, fileName);
            if (!File.Exists(filePath))
            {
                using (var reader = ImageReader.Create(sourceFilePath))
                using (var crop = new Crop(rect))
                using (var writer = ImageWriter.Create(filePath))
                {
                    Pipeline.Run(reader + crop + writer);
                }
            }

            BitmapViewer1.SourceImageFilename = filePath;
            RectangleRubberband1.Erase();
        }
    }
}