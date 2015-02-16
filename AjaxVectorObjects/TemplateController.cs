using Aurigma.GraphicsMill.AjaxControls.VectorObjects;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Codecs.Psd;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace AjaxVectorObjects
{
    public class TemplateController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Upload()
        {
            var context = HttpContext.Current;

            var message = "Request is empty";
            var success = false;

            if (context.Request.Files.Count > 0)
            {
                var file = context.Request.Files["template"];
                if (file != null)
                {
                    try
                    {
                        var path = Path.Combine(context.Server.MapPath("~/Upload"), file.FileName);
                        file.SaveAs(path);

                        if (ImageReader.RecognizeFormat(path) == FileFormat.Psd)
                        {
                            using (var reader = new PsdReader(path))
                            {
                                var canvas = new Canvas();

                                if (!string.IsNullOrWhiteSpace(context.Request.Form["canvas"])) 
                                    canvas.Data = context.Request.Form["canvas"];
                                
                                new PsdSvgConverter().ParsePsd(reader, canvas: canvas);

                                message = canvas.Data;
                                success = true;
                            }
                        }
                        else
                        {
                            message = "Uploaded file is not PSD.";
                        }
                    }
                    catch (Exception e)
                    {
                       message = e.Message;
                    }
                }
            }

            var response = new HttpResponseMessage(success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
            response.Content = new StringContent(message);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}