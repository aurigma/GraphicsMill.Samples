using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace OnlineDemo.Controllers
{
	public class Point
	{
		public int X { get; set; }
		public int Y { get; set; }
	}


	public static class Utility
	{
		public static HttpResponseMessage Base64ResponseFromBinaryStream(MemoryStream binaryStream)
		{
			HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

			binaryStream.Position = 0;
			var bytes = Convert.ToBase64String(binaryStream.ToArray());

			var base64Stream = new MemoryStream();

			var base64Writer = new StreamWriter(base64Stream);

			base64Writer.Write(bytes);
			base64Writer.Flush();
			base64Stream.Position = 0;

			response.Content = new StreamContent(base64Stream);

			return response;
		}


		private const int MaxTextStringLength = 2000;


		public static string FilterTextString(string str)
		{
			if (str == null)
			{
				return "";
			}
			else if (str.Length > MaxTextStringLength)
			{
				return str.Substring(0, MaxTextStringLength);
			}
			else 
			{
				return str;
			}
		}
	}

}