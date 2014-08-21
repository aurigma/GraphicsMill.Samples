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
	public class MosaicPropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public MosaicPropertyPage()
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
		internal TrackBarText TrackBarTextWidth;
		internal TrackBarText TrackBarTextHeight;
		internal System.Windows.Forms.CheckBox CheckBoxProportional;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MosaicPropertyPage));
			this.TrackBarTextWidth = new Main.TrackBarText();
			this.TrackBarTextWidth.ValueChanged += new Main.TrackBarText.ValueChangedEventHandler(this.TrackBarTextWidth_ValueChanged);
			this.TrackBarTextHeight = new Main.TrackBarText();
			this.TrackBarTextHeight.ValueChanged += new Main.TrackBarText.ValueChangedEventHandler(this.TrackBarTextHeight_ValueChanged);
			this.CheckBoxProportional = new System.Windows.Forms.CheckBox();
			this.CheckBoxProportional.CheckedChanged += new System.EventHandler(CheckBoxProportional_CheckedChanged);
			this.SuspendLayout();
			//
			//TrackBarTextWidth
			//
			this.TrackBarTextWidth.AccessibleDescription = resources.GetString("TrackBarTextWidth.AccessibleDescription");
			this.TrackBarTextWidth.AccessibleName = resources.GetString("TrackBarTextWidth.AccessibleName");
			this.TrackBarTextWidth.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextWidth.Anchor");
			this.TrackBarTextWidth.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextWidth.AutoScroll"));
			this.TrackBarTextWidth.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextWidth.AutoScrollMargin");
			this.TrackBarTextWidth.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextWidth.AutoScrollMinSize");
			this.TrackBarTextWidth.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextWidth.BackgroundImage");
			this.TrackBarTextWidth.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextWidth.Dock");
			this.TrackBarTextWidth.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextWidth.Enabled"));
			this.TrackBarTextWidth.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextWidth.Font");
			this.TrackBarTextWidth.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextWidth.ImeMode");
			this.TrackBarTextWidth.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextWidth.Location");
			this.TrackBarTextWidth.Maximum = 200;
			this.TrackBarTextWidth.Minimum = 2;
			this.TrackBarTextWidth.Name = "TrackBarTextWidth";
			this.TrackBarTextWidth.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextWidth.RightToLeft");
			this.TrackBarTextWidth.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextWidth.Size");
			this.TrackBarTextWidth.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextWidth.TabIndex"));
			this.TrackBarTextWidth.Text = resources.GetString("TrackBarTextWidth.Text");
			this.TrackBarTextWidth.TickFrequency = 10;
			this.TrackBarTextWidth.Unit = "pixels";
			this.TrackBarTextWidth.Value = 5;
			this.TrackBarTextWidth.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextWidth.Visible"));
			//
			//TrackBarTextHeight
			//
			this.TrackBarTextHeight.AccessibleDescription = resources.GetString("TrackBarTextHeight.AccessibleDescription");
			this.TrackBarTextHeight.AccessibleName = resources.GetString("TrackBarTextHeight.AccessibleName");
			this.TrackBarTextHeight.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextHeight.Anchor");
			this.TrackBarTextHeight.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextHeight.AutoScroll"));
			this.TrackBarTextHeight.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextHeight.AutoScrollMargin");
			this.TrackBarTextHeight.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextHeight.AutoScrollMinSize");
			this.TrackBarTextHeight.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextHeight.BackgroundImage");
			this.TrackBarTextHeight.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextHeight.Dock");
			this.TrackBarTextHeight.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextHeight.Enabled"));
			this.TrackBarTextHeight.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextHeight.Font");
			this.TrackBarTextHeight.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextHeight.ImeMode");
			this.TrackBarTextHeight.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextHeight.Location");
			this.TrackBarTextHeight.Maximum = 200;
			this.TrackBarTextHeight.Minimum = 2;
			this.TrackBarTextHeight.Name = "TrackBarTextHeight";
			this.TrackBarTextHeight.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextHeight.RightToLeft");
			this.TrackBarTextHeight.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextHeight.Size");
			this.TrackBarTextHeight.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextHeight.TabIndex"));
			this.TrackBarTextHeight.Text = resources.GetString("TrackBarTextHeight.Text");
			this.TrackBarTextHeight.TickFrequency = 10;
			this.TrackBarTextHeight.Unit = "pixels";
			this.TrackBarTextHeight.Value = 5;
			this.TrackBarTextHeight.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextHeight.Visible"));
			//
			//CheckBoxProportional
			//
			this.CheckBoxProportional.AccessibleDescription = resources.GetString("CheckBoxProportional.AccessibleDescription");
			this.CheckBoxProportional.AccessibleName = resources.GetString("CheckBoxProportional.AccessibleName");
			this.CheckBoxProportional.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("CheckBoxProportional.Anchor");
			this.CheckBoxProportional.Appearance = (System.Windows.Forms.Appearance) resources.GetObject("CheckBoxProportional.Appearance");
			this.CheckBoxProportional.BackgroundImage = (System.Drawing.Image) resources.GetObject("CheckBoxProportional.BackgroundImage");
			this.CheckBoxProportional.CheckAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxProportional.CheckAlign");
			this.CheckBoxProportional.Checked = true;
			this.CheckBoxProportional.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxProportional.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("CheckBoxProportional.Dock");
			this.CheckBoxProportional.Enabled = System.Convert.ToBoolean(resources.GetObject("CheckBoxProportional.Enabled"));
			this.CheckBoxProportional.FlatStyle = (System.Windows.Forms.FlatStyle) resources.GetObject("CheckBoxProportional.FlatStyle");
			this.CheckBoxProportional.Font = (System.Drawing.Font) resources.GetObject("CheckBoxProportional.Font");
			this.CheckBoxProportional.Image = (System.Drawing.Image) resources.GetObject("CheckBoxProportional.Image");
			this.CheckBoxProportional.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxProportional.ImageAlign");
			this.CheckBoxProportional.ImageIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxProportional.ImageIndex"));
			this.CheckBoxProportional.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("CheckBoxProportional.ImeMode");
			this.CheckBoxProportional.Location = (System.Drawing.Point) resources.GetObject("CheckBoxProportional.Location");
			this.CheckBoxProportional.Name = "CheckBoxProportional";
			this.CheckBoxProportional.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("CheckBoxProportional.RightToLeft");
			this.CheckBoxProportional.Size = (System.Drawing.Size) resources.GetObject("CheckBoxProportional.Size");
			this.CheckBoxProportional.TabIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxProportional.TabIndex"));
			this.CheckBoxProportional.Text = resources.GetString("CheckBoxProportional.Text");
			this.CheckBoxProportional.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxProportional.TextAlign");
			this.CheckBoxProportional.Visible = System.Convert.ToBoolean(resources.GetObject("CheckBoxProportional.Visible"));
			//
			//MosaicPropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.CheckBoxProportional);
			this.Controls.Add(this.TrackBarTextHeight);
			this.Controls.Add(this.TrackBarTextWidth);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "MosaicPropertyPage";
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
				return new Mosaic(TrackBarTextWidth.Value, TrackBarTextHeight.Value);
			}
		}
		
		public string Title
		{
			get
			{
				return "Mosaic";
			}
		}
		
		private void TrackBarTextWidth_ValueChanged(object sender, System.EventArgs e)
		{
			if (CheckBoxProportional.Checked && TrackBarTextWidth.Focused)
			{
				TrackBarTextHeight.Value = TrackBarTextWidth.Value;
			}
		}
		
		private void TrackBarTextHeight_ValueChanged(object sender, System.EventArgs e)
		{
			if (CheckBoxProportional.Checked && TrackBarTextHeight.Focused)
			{
				TrackBarTextWidth.Value = TrackBarTextHeight.Value;
			}
		}
		
		private void CheckBoxProportional_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (CheckBoxProportional.Checked)
			{
				TrackBarTextHeight.Value = TrackBarTextWidth.Value;
			}
		}
		
	}
}
