using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using Aurigma.GraphicsMill;


namespace Main
{
	public class ImageInfoDialog : System.Windows.Forms.Form
	{
		
		#region " Windows Form Designer generated code "
		
		public ImageInfoDialog()
		{
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Add any initialization after the InitializeComponent() call
			
		}
		
		//Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		public System.Windows.Forms.Label Label12;
		public System.Windows.Forms.Label LabelHorizontalResolution;
		public System.Windows.Forms.Label LabelVerticalResolution;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label LabelMemoryUsed;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label LabelColorSpace;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label LabelHeight;
		public System.Windows.Forms.Label LabelWidth;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label LabelColorDepth;
		public System.Windows.Forms.Label LabelAlphaChannel;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageInfoDialog));
			this.Label12 = new System.Windows.Forms.Label();
			this.LabelHorizontalResolution = new System.Windows.Forms.Label();
			this.LabelVerticalResolution = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.LabelMemoryUsed = new System.Windows.Forms.Label();
			this.LabelColorDepth = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.LabelColorSpace = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.LabelHeight = new System.Windows.Forms.Label();
			this.LabelWidth = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.LabelAlphaChannel = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Label12
			//
			resources.ApplyResources(this.Label12, "Label12");
			this.Label12.Name = "Label12";
			//
			//LabelHorizontalResolution
			//
			resources.ApplyResources(this.LabelHorizontalResolution, "LabelHorizontalResolution");
			this.LabelHorizontalResolution.Name = "LabelHorizontalResolution";
			//
			//LabelVerticalResolution
			//
			resources.ApplyResources(this.LabelVerticalResolution, "LabelVerticalResolution");
			this.LabelVerticalResolution.Name = "LabelVerticalResolution";
			//
			//Label3
			//
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.Name = "Label3";
			//
			//Label5
			//
			resources.ApplyResources(this.Label5, "Label5");
			this.Label5.Name = "Label5";
			//
			//LabelMemoryUsed
			//
			resources.ApplyResources(this.LabelMemoryUsed, "LabelMemoryUsed");
			this.LabelMemoryUsed.Name = "LabelMemoryUsed";
			//
			//LabelColorDepth
			//
			resources.ApplyResources(this.LabelColorDepth, "LabelColorDepth");
			this.LabelColorDepth.Name = "LabelColorDepth";
			//
			//Label2
			//
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.Name = "Label2";
			//
			//Label6
			//
			resources.ApplyResources(this.Label6, "Label6");
			this.Label6.Name = "Label6";
			//
			//LabelColorSpace
			//
			resources.ApplyResources(this.LabelColorSpace, "LabelColorSpace");
			this.LabelColorSpace.Name = "LabelColorSpace";
			//
			//Label4
			//
			resources.ApplyResources(this.Label4, "Label4");
			this.Label4.Name = "Label4";
			//
			//LabelHeight
			//
			resources.ApplyResources(this.LabelHeight, "LabelHeight");
			this.LabelHeight.Name = "LabelHeight";
			//
			//LabelWidth
			//
			resources.ApplyResources(this.LabelWidth, "LabelWidth");
			this.LabelWidth.Name = "LabelWidth";
			//
			//Label1
			//
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.Name = "Label1";
			//
			//LabelAlphaChannel
			//
			resources.ApplyResources(this.LabelAlphaChannel, "LabelAlphaChannel");
			this.LabelAlphaChannel.Name = "LabelAlphaChannel";
			//
			//Label8
			//
			resources.ApplyResources(this.Label8, "Label8");
			this.Label8.Name = "Label8";
			//
			//ImageInfoDialog
			//
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.LabelAlphaChannel);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label12);
			this.Controls.Add(this.LabelHorizontalResolution);
			this.Controls.Add(this.LabelVerticalResolution);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.LabelMemoryUsed);
			this.Controls.Add(this.LabelColorDepth);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.LabelColorSpace);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.LabelHeight);
			this.Controls.Add(this.LabelWidth);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ImageInfoDialog";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		#endregion
		
		private Aurigma.GraphicsMill.Bitmap _bitmap;
		
		public Aurigma.GraphicsMill.Bitmap Bitmap
		{
			get
			{
				return _bitmap;
			}
			set
			{
				_bitmap = value;
				//_bitmap.Changed += new Aurigma.GraphicsMill.BitmapChangedEventHandler(_bitmap_Changed);
				ShowImageInfo();
			}
		}
		
// 		private void _bitmap_Changed(object sender, BitmapChangedEventArgs e)
// 		{
// 			ShowImageInfo();
// 		}
		
		private void ShowImageInfo()
		{
			System.Globalization.NumberFormatInfo numberFormat = new System.Globalization.NumberFormatInfo();
			
			LabelWidth.Text = _bitmap.Width.ToString(numberFormat);
			LabelHeight.Text = _bitmap.Height.ToString(numberFormat);
			
			LabelHorizontalResolution.Text = _bitmap.DpiX.ToString(numberFormat) + " dpi";
			LabelVerticalResolution.Text = _bitmap.DpiY.ToString(numberFormat) + " dpi";
			
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ImageInfoDialog));
			
			if (_bitmap.PixelFormat.IsRgb)
			{
				LabelColorSpace.Text = resources.GetString("RgbText");
			}
			else if (_bitmap.PixelFormat.IsCmyk)
			{
				LabelColorSpace.Text = resources.GetString("CmykText");
			}
			else if (_bitmap.PixelFormat.IsGrayscale)
			{
				LabelColorSpace.Text = resources.GetString("GrayscaleText");
			}
			else
			{
				LabelColorSpace.Text = string.Empty;
			}
			
			if (_bitmap.HasAlpha)
			{
				LabelAlphaChannel.Text = resources.GetString("YesText");
			}
			else
			{
				LabelAlphaChannel.Text = resources.GetString("NoText");
			}
			
			if (_bitmap.PixelFormat.IsExtended)
			{
				LabelColorDepth.Text = resources.GetString("16bitText");
			}
			else
			{
				LabelColorDepth.Text = resources.GetString("8bitText");
			}
			
			//LabelMemoryUsed.Text = Convert.ToString(_bitmap.MemoryUsed, numberFormat);
		}
		
	}
	
}
