using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Transforms;


namespace Main
{
	public class BrightnessContrastPropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public BrightnessContrastPropertyPage()
		{
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Add any initialization after the InitializeComponent() call
			
		}
		
		//UserControl overrides dispose to clean up the component list.
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
		internal TrackBarText TrackBarTextBrightness;
		internal TrackBarText TrackBarTextContrast;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BrightnessContrastPropertyPage));
			this.TrackBarTextBrightness = new Main.TrackBarText();
			this.TrackBarTextContrast = new Main.TrackBarText();
			this.SuspendLayout();
			//
			//TrackBarTextBrightness
			//
			this.TrackBarTextBrightness.AccessibleDescription = resources.GetString("TrackBarTextBrightness.AccessibleDescription");
			this.TrackBarTextBrightness.AccessibleName = resources.GetString("TrackBarTextBrightness.AccessibleName");
			this.TrackBarTextBrightness.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextBrightness.Anchor");
			this.TrackBarTextBrightness.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextBrightness.AutoScroll"));
			this.TrackBarTextBrightness.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextBrightness.AutoScrollMargin");
			this.TrackBarTextBrightness.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextBrightness.AutoScrollMinSize");
			this.TrackBarTextBrightness.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextBrightness.BackgroundImage");
			this.TrackBarTextBrightness.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextBrightness.Dock");
			this.TrackBarTextBrightness.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextBrightness.Enabled"));
			this.TrackBarTextBrightness.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextBrightness.Font");
			this.TrackBarTextBrightness.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextBrightness.ImeMode");
			this.TrackBarTextBrightness.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextBrightness.Location");
			this.TrackBarTextBrightness.Maximum = 100;
			this.TrackBarTextBrightness.Minimum = - 100;
			this.TrackBarTextBrightness.Name = "TrackBarTextBrightness";
			this.TrackBarTextBrightness.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextBrightness.RightToLeft");
			this.TrackBarTextBrightness.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextBrightness.Size");
			this.TrackBarTextBrightness.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextBrightness.TabIndex"));
			this.TrackBarTextBrightness.Text = resources.GetString("TrackBarTextBrightness.Text");
			this.TrackBarTextBrightness.TickFrequency = 10;
			this.TrackBarTextBrightness.Unit = "";
			this.TrackBarTextBrightness.Value = 0;
			this.TrackBarTextBrightness.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextBrightness.Visible"));
			//
			//TrackBarTextContrast
			//
			this.TrackBarTextContrast.AccessibleDescription = resources.GetString("TrackBarTextContrast.AccessibleDescription");
			this.TrackBarTextContrast.AccessibleName = resources.GetString("TrackBarTextContrast.AccessibleName");
			this.TrackBarTextContrast.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextContrast.Anchor");
			this.TrackBarTextContrast.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextContrast.AutoScroll"));
			this.TrackBarTextContrast.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextContrast.AutoScrollMargin");
			this.TrackBarTextContrast.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextContrast.AutoScrollMinSize");
			this.TrackBarTextContrast.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextContrast.BackgroundImage");
			this.TrackBarTextContrast.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextContrast.Dock");
			this.TrackBarTextContrast.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextContrast.Enabled"));
			this.TrackBarTextContrast.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextContrast.Font");
			this.TrackBarTextContrast.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextContrast.ImeMode");
			this.TrackBarTextContrast.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextContrast.Location");
			this.TrackBarTextContrast.Maximum = 100;
			this.TrackBarTextContrast.Minimum = - 100;
			this.TrackBarTextContrast.Name = "TrackBarTextContrast";
			this.TrackBarTextContrast.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextContrast.RightToLeft");
			this.TrackBarTextContrast.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextContrast.Size");
			this.TrackBarTextContrast.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextContrast.TabIndex"));
			this.TrackBarTextContrast.Text = resources.GetString("TrackBarTextContrast.Text");
			this.TrackBarTextContrast.TickFrequency = 10;
			this.TrackBarTextContrast.Unit = "";
			this.TrackBarTextContrast.Value = 0;
			this.TrackBarTextContrast.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextContrast.Visible"));
			//
			//BrightnessContrastPropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.TrackBarTextContrast);
			this.Controls.Add(this.TrackBarTextBrightness);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "BrightnessContrastPropertyPage";
			this.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("$this.RightToLeft");
			this.Size = (System.Drawing.Size) resources.GetObject("$this.Size");
			this.ResumeLayout(false);
			
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
			}
		}
		
		public IBitmapTransform Transform
		{
			get
			{
				return new BrightnessContrast(Convert.ToSingle(TrackBarTextBrightness.Value) / 100.0F, Convert.ToSingle(TrackBarTextContrast.Value) / 100.0F);
			}
		}
		
		public string Title
		{
			get
			{
				return "Brightness-Contrast";
			}
		}
	}
	
}
