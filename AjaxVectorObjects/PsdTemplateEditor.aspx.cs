using System;
using System.Web.UI;
using Aurigma.GraphicsMill.AjaxControls;
using Aurigma.GraphicsMill.AjaxControls.VectorObjects;
using Aurigma.GraphicsMill.Codecs.Psd;

namespace AjaxVectorObjects
{
    public partial class PsdTemplateEditor : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !IsCallback)
            {
                CanvasViewer1.ZoomMode = ZoomMode.BestFit;

                using (var reader = new PsdReader(Server.MapPath("~/BusinessCard.psd")))
                {
                    PsdSvgConverter.ParsePsd(reader, canvas: CanvasViewer1.Canvas);
                }
                
            }
        }
    }
}