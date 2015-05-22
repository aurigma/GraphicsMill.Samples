using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using Aurigma.GraphicsMill.AjaxControls.VectorObjects;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Codecs.Psd;

namespace AjaxVectorObjects
{
    public class SampleController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage UploadTemplate()
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
                                
                                PsdSvgConverter.ParsePsd(reader, canvas: canvas);

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

        [HttpPost]
        public HttpResponseMessage UploadImage()
        {
            var context = HttpContext.Current;

            var message = "Request is empty";
            var success = false;

            if (context.Request.Files.Count > 0)
            {
                var file = context.Request.Files["image"];
                if (file != null)
                {
                    try
                    {
                        var storage = Aurigma.GraphicsMill.AjaxControls.VectorObjects.Configuration.FileStorage;
                        var imageStream = file.InputStream;
                        var extension = Common.GetImageExtension(imageStream).Substring(1);
                        var fileStorageId = storage.AddFile(extension, imageStream);

                        message = fileStorageId;
                        success = true;
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