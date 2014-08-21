using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;
using System.Runtime.InteropServices;


namespace Main
{
	public interface IBitmapPropertyPage
	{
		Aurigma.GraphicsMill.Bitmap Bitmap{
			get;
			set;
		}
		string Title{
			get;
		}
	}
	
	public interface ITransformPropertyPage : IBitmapPropertyPage
	{
		IBitmapTransform Transform{
			get;
		}
	}
	
	public interface IEncoderPropertyPage : IBitmapPropertyPage
	{
		WriterSettings EncoderOptions{
			get;
			set;
		}
	}
	
	internal class Utils
	{
		
		private Utils()
		{
			
		}
		
		public static void DrawHistogram(Histogram _histogram, Graphics _graphics, int _height, System.Drawing.Color _color, bool inverted)
		{
			
			if (_histogram != null)
			{
				int maxValue = 0;
				for (int i = 0; i <= 255; i++)
				{
					if (maxValue < _histogram[i])
					{
						maxValue = _histogram[i];
					}
				}
				
				float k = Convert.ToSingle(_height) / Convert.ToSingle(maxValue);
				
				_graphics.Clear(System.Drawing.Color.White);
				
				Pen p = new Pen(_color);
				if (! inverted)
				{
					for (int i = 0; i <= 255; i++)
					{
						int y = Convert.ToInt32(_height - _histogram[i] * k - 5);
						_graphics.DrawLine(p, i, _height, i, y);
					}
				}
				else
				{
					for (int i = 0; i <= 255; i++)
					{
						int y = Convert.ToInt32(_height - _histogram[i] * k - 5);
						_graphics.DrawLine(p, 255 - i, _height, 255 - i, y);
					}
				}
			}
			
			
		}
		
		public static void DrawGradient(Graphics _graphics, string channel)
		{
			switch (channel)
			{
				case "Red":
					
					for (int i = 0; i <= 255; i++)
					{
						System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(i, 0, 0));
						_graphics.DrawLine(p, i, 0, i, 20);
					}
					break;
				case "Green":
					
					for (int i = 0; i <= 255; i++)
					{
						System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0, i, 0));
						_graphics.DrawLine(p, i, 0, i, 20);
					}
					break;
				case "Blue":
					
					for (int i = 0; i <= 255; i++)
					{
						System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0, 0, i));
						_graphics.DrawLine(p, i, 0, i, 20);
					}
					break;
				case "Cyan":
					
					for (int i = 0; i <= 255; i++)
					{
						System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(i, 255, 255));
						_graphics.DrawLine(p, i, 0, i, 20);
					}
					break;
				case "Magenta":
					
					for (int i = 0; i <= 255; i++)
					{
						System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(255, i, 255));
						_graphics.DrawLine(p, i, 0, i, 20);
					}
					break;
				case "Yellow":
					
					for (int i = 0; i <= 255; i++)
					{
						System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(255, 255, i));
						_graphics.DrawLine(p, i, 0, i, 20);
					}
					break;
				default:
					
					for (int i = 0; i <= 255; i++)
					{
						System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(i, i, i));
						_graphics.DrawLine(p, i, 0, i, 20);
					}
					break;
			}
		}
		
		//This function is defined expclicity for easy C# porting only
		public static bool IsNumeric(string value)
		{
			try
			{
				int.Parse(value);
			}
			catch
			{
				return false;
			}
			return true;
		}
	}
	
	[System.Security.SuppressUnmanagedCodeSecurity()]internal class NativeMethods
	{
		
		private NativeMethods()
		{
		}
		
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int SetCapture(int hwnd);
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int ReleaseCapture();
	}
	
	
	
}
