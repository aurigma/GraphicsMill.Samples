using System;
using System.Web.UI;

namespace AjaxControls
{
    public partial class BitmapViewerDemo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !IsCallback)
            {
                BitmapViewer1.SourceImageFilename = Server.MapPath(@"~/Venice.jpg");
            }
        }
    }
}