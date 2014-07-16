using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace OnlineDemo
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

			//Remove old temp files
			var tempPath = System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/Temp/");

			if (System.IO.Directory.Exists(tempPath))
			{
				var tempDir = new System.IO.DirectoryInfo(tempPath);
				tempDir.GetFiles().Where(f => (DateTime.Now - f.CreationTime).TotalMinutes > 60).ToList().ForEach(f => f.Delete());
			}
        }
    }
}
