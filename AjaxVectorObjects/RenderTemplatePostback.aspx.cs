using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.AjaxControls;
using Aurigma.GraphicsMill.AjaxControls.VectorObjects;
using Aurigma.GraphicsMill.AjaxControls.VectorObjects.Math;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Codecs.Psd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxVectorObjects
{
    public partial class RenderTemplatePostback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !IsCallback)
            {
                CanvasViewer1.ZoomMode = ZoomMode.BestFit;

                using (var reader = new PsdReader(Server.MapPath("~/BusinessCard.psd")))
                {
                    var converter = new PsdSvgConverter();
                    converter.ParsePsd(reader, canvas: CanvasViewer1.Canvas);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var filePath = "~/Result/result.pdf";

            using (var writer = ImageWriter.Create(Server.MapPath(filePath)))
                CanvasViewer1.Canvas.RenderWorkspace(writer, 300, ColorSpace.Rgb);

			Link1.Visible = true;
            Link1.Text = filePath;
            Link1.NavigateUrl = filePath;
        }

    }
}