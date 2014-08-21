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
	public class BlurPropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public BlurPropertyPage()
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
		internal TrackBarText TrackBarTextRadius;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton RadioButtonFast;
		internal System.Windows.Forms.RadioButton RadioButtonGaussian;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BlurPropertyPage));
			this.TrackBarTextRadius = new Main.TrackBarText();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.RadioButtonFast = new System.Windows.Forms.RadioButton();
			this.RadioButtonGaussian = new System.Windows.Forms.RadioButton();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//TrackBarTextRadius
			//
			this.TrackBarTextRadius.AccessibleDescription = resources.GetString("TrackBarTextRadius.AccessibleDescription");
			this.TrackBarTextRadius.AccessibleName = resources.GetString("TrackBarTextRadius.AccessibleName");
			this.TrackBarTextRadius.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextRadius.Anchor");
			this.TrackBarTextRadius.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextRadius.AutoScroll"));
			this.TrackBarTextRadius.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextRadius.AutoScrollMargin");
			this.TrackBarTextRadius.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextRadius.AutoScrollMinSize");
			this.TrackBarTextRadius.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextRadius.BackgroundImage");
			this.TrackBarTextRadius.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextRadius.Dock");
			this.TrackBarTextRadius.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextRadius.Enabled"));
			this.TrackBarTextRadius.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextRadius.Font");
			this.TrackBarTextRadius.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextRadius.ImeMode");
			this.TrackBarTextRadius.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextRadius.Location");
			this.TrackBarTextRadius.Maximum = 100;
			this.TrackBarTextRadius.Minimum = 1;
			this.TrackBarTextRadius.Name = "TrackBarTextRadius";
			this.TrackBarTextRadius.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextRadius.RightToLeft");
			this.TrackBarTextRadius.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextRadius.Size");
			this.TrackBarTextRadius.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextRadius.TabIndex"));
			this.TrackBarTextRadius.Text = resources.GetString("TrackBarTextRadius.Text");
			this.TrackBarTextRadius.TickFrequency = 5;
			this.TrackBarTextRadius.Unit = "pixels";
			this.TrackBarTextRadius.Value = 5;
			this.TrackBarTextRadius.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextRadius.Visible"));
			//
			//GroupBox1
			//
			this.GroupBox1.AccessibleDescription = resources.GetString("GroupBox1.AccessibleDescription");
			this.GroupBox1.AccessibleName = resources.GetString("GroupBox1.AccessibleName");
			this.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("GroupBox1.Anchor");
			this.GroupBox1.BackgroundImage = (System.Drawing.Image) resources.GetObject("GroupBox1.BackgroundImage");
			this.GroupBox1.Controls.Add(this.RadioButtonFast);
			this.GroupBox1.Controls.Add(this.RadioButtonGaussian);
			this.GroupBox1.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("GroupBox1.Dock");
			this.GroupBox1.Enabled = System.Convert.ToBoolean(resources.GetObject("GroupBox1.Enabled"));
			this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.GroupBox1.Font = (System.Drawing.Font) resources.GetObject("GroupBox1.Font");
			this.GroupBox1.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("GroupBox1.ImeMode");
			this.GroupBox1.Location = (System.Drawing.Point) resources.GetObject("GroupBox1.Location");
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("GroupBox1.RightToLeft");
			this.GroupBox1.Size = (System.Drawing.Size) resources.GetObject("GroupBox1.Size");
			this.GroupBox1.TabIndex = System.Convert.ToInt32(resources.GetObject("GroupBox1.TabIndex"));
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = resources.GetString("GroupBox1.Text");
			this.GroupBox1.Visible = System.Convert.ToBoolean(resources.GetObject("GroupBox1.Visible"));
			//
			//RadioButtonFast
			//
			this.RadioButtonFast.AccessibleDescription = resources.GetString("RadioButtonFast.AccessibleDescription");
			this.RadioButtonFast.AccessibleName = resources.GetString("RadioButtonFast.AccessibleName");
			this.RadioButtonFast.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("RadioButtonFast.Anchor");
			this.RadioButtonFast.Appearance = (System.Windows.Forms.Appearance) resources.GetObject("RadioButtonFast.Appearance");
			this.RadioButtonFast.BackgroundImage = (System.Drawing.Image) resources.GetObject("RadioButtonFast.BackgroundImage");
			this.RadioButtonFast.CheckAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonFast.CheckAlign");
			this.RadioButtonFast.Checked = true;
			this.RadioButtonFast.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("RadioButtonFast.Dock");
			this.RadioButtonFast.Enabled = System.Convert.ToBoolean(resources.GetObject("RadioButtonFast.Enabled"));
			this.RadioButtonFast.FlatStyle = (System.Windows.Forms.FlatStyle) resources.GetObject("RadioButtonFast.FlatStyle");
			this.RadioButtonFast.Font = (System.Drawing.Font) resources.GetObject("RadioButtonFast.Font");
			this.RadioButtonFast.Image = (System.Drawing.Image) resources.GetObject("RadioButtonFast.Image");
			this.RadioButtonFast.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonFast.ImageAlign");
			this.RadioButtonFast.ImageIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonFast.ImageIndex"));
			this.RadioButtonFast.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("RadioButtonFast.ImeMode");
			this.RadioButtonFast.Location = (System.Drawing.Point) resources.GetObject("RadioButtonFast.Location");
			this.RadioButtonFast.Name = "RadioButtonFast";
			this.RadioButtonFast.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("RadioButtonFast.RightToLeft");
			this.RadioButtonFast.Size = (System.Drawing.Size) resources.GetObject("RadioButtonFast.Size");
			this.RadioButtonFast.TabIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonFast.TabIndex"));
			this.RadioButtonFast.TabStop = true;
			this.RadioButtonFast.Text = resources.GetString("RadioButtonFast.Text");
			this.RadioButtonFast.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonFast.TextAlign");
			this.RadioButtonFast.Visible = System.Convert.ToBoolean(resources.GetObject("RadioButtonFast.Visible"));
			//
			//RadioButtonGaussian
			//
			this.RadioButtonGaussian.AccessibleDescription = resources.GetString("RadioButtonGaussian.AccessibleDescription");
			this.RadioButtonGaussian.AccessibleName = resources.GetString("RadioButtonGaussian.AccessibleName");
			this.RadioButtonGaussian.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("RadioButtonGaussian.Anchor");
			this.RadioButtonGaussian.Appearance = (System.Windows.Forms.Appearance) resources.GetObject("RadioButtonGaussian.Appearance");
			this.RadioButtonGaussian.BackgroundImage = (System.Drawing.Image) resources.GetObject("RadioButtonGaussian.BackgroundImage");
			this.RadioButtonGaussian.CheckAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonGaussian.CheckAlign");
			this.RadioButtonGaussian.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("RadioButtonGaussian.Dock");
			this.RadioButtonGaussian.Enabled = System.Convert.ToBoolean(resources.GetObject("RadioButtonGaussian.Enabled"));
			this.RadioButtonGaussian.FlatStyle = (System.Windows.Forms.FlatStyle) resources.GetObject("RadioButtonGaussian.FlatStyle");
			this.RadioButtonGaussian.Font = (System.Drawing.Font) resources.GetObject("RadioButtonGaussian.Font");
			this.RadioButtonGaussian.Image = (System.Drawing.Image) resources.GetObject("RadioButtonGaussian.Image");
			this.RadioButtonGaussian.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonGaussian.ImageAlign");
			this.RadioButtonGaussian.ImageIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonGaussian.ImageIndex"));
			this.RadioButtonGaussian.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("RadioButtonGaussian.ImeMode");
			this.RadioButtonGaussian.Location = (System.Drawing.Point) resources.GetObject("RadioButtonGaussian.Location");
			this.RadioButtonGaussian.Name = "RadioButtonGaussian";
			this.RadioButtonGaussian.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("RadioButtonGaussian.RightToLeft");
			this.RadioButtonGaussian.Size = (System.Drawing.Size) resources.GetObject("RadioButtonGaussian.Size");
			this.RadioButtonGaussian.TabIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonGaussian.TabIndex"));
			this.RadioButtonGaussian.Text = resources.GetString("RadioButtonGaussian.Text");
			this.RadioButtonGaussian.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonGaussian.TextAlign");
			this.RadioButtonGaussian.Visible = System.Convert.ToBoolean(resources.GetObject("RadioButtonGaussian.Visible"));
			//
			//BlurPropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.TrackBarTextRadius);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "BlurPropertyPage";
			this.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("$this.RightToLeft");
			this.Size = (System.Drawing.Size) resources.GetObject("$this.Size");
			this.GroupBox1.ResumeLayout(false);
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
				return new Blur((float)TrackBarTextRadius.Value);
			}
		}
		
		public string Title
		{
			get
			{
				return "Blur";
			}
		}
	}
}
