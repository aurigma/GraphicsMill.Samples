using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace OnlineDemo
{
	public class DownloadFile : IHttpHandler
	{

		public void ProcessRequest(HttpContext context)
		{
			Guid id;

			if (!String.IsNullOrEmpty(context.Request.QueryString["id"]) && Guid.TryParse(context.Request.QueryString["id"], out id))
			{
				var filePath = context.Server.MapPath("~/App_Data/Temp/" + id.ToString());

				if (File.Exists(filePath) && File.Exists(filePath + ".txt"))
				{
					context.Response.ContentType = System.IO.File.ReadAllText(filePath + ".txt");

					string fileExt = null;

					switch (context.Response.ContentType)
					{ 
						case "application/pdf":
							fileExt = "pdf";
							break;
						case "application/postscript":
							fileExt = "eps";
							break;
					}

					if (fileExt != null)
					{
						var fileName = String.Format("{0:X8}.{1}",  id.ToString().GetHashCode(), fileExt);
						context.Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName);
					}

					context.Response.TransmitFile(filePath);
					return;
				}
			}

			context.Response.ContentType = "text/plain";
			context.Response.Write("File not found");
		}

		public bool IsReusable
		{
			get
			{
				return false;
			}
		}
	}
}