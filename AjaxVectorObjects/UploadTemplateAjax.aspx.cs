using Aurigma.GraphicsMill.AdvancedDrawing;
using Aurigma.GraphicsMill.AjaxControls;
using Aurigma.GraphicsMill.AjaxControls.VectorObjects;
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
    public partial class UploadTemplateAjax : System.Web.UI.Page
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
    }
}