using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;


namespace Main
{
	public class JpegPropertyPage : System.Windows.Forms.UserControl, IEncoderPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public JpegPropertyPage()
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
		internal System.Windows.Forms.CheckBox CheckBoxIsProgressive;
		internal TrackBarText TrackBarTextQuality;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(JpegPropertyPage));
			this.TrackBarTextQuality = new Main.TrackBarText();
			this.TrackBarTextQuality.ValueChanged += new Main.TrackBarText.ValueChangedEventHandler(this.TrackBarTextQuality_ValueChanged);
			this.CheckBoxIsProgressive = new System.Windows.Forms.CheckBox();
			this.CheckBoxIsProgressive.CheckedChanged += new System.EventHandler(CheckBoxIsProgressive_CheckedChanged);
			this.SuspendLayout();
			//
			//TrackBarTextQuality
			//
			this.TrackBarTextQuality.AccessibleDescription = resources.GetString("TrackBarTextQuality.AccessibleDescription");
			this.TrackBarTextQuality.AccessibleName = resources.GetString("TrackBarTextQuality.AccessibleName");
			this.TrackBarTextQuality.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextQuality.Anchor");
			this.TrackBarTextQuality.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextQuality.AutoScroll"));
			this.TrackBarTextQuality.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextQuality.AutoScrollMargin");
			this.TrackBarTextQuality.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextQuality.AutoScrollMinSize");
			this.TrackBarTextQuality.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextQuality.BackgroundImage");
			this.TrackBarTextQuality.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextQuality.Dock");
			this.TrackBarTextQuality.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextQuality.Enabled"));
			this.TrackBarTextQuality.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextQuality.Font");
			this.TrackBarTextQuality.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextQuality.ImeMode");
			this.TrackBarTextQuality.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextQuality.Location");
			this.TrackBarTextQuality.Maximum = 100;
			this.TrackBarTextQuality.Minimum = 0;
			this.TrackBarTextQuality.Name = "TrackBarTextQuality";
			this.TrackBarTextQuality.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextQuality.RightToLeft");
			this.TrackBarTextQuality.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextQuality.Size");
			this.TrackBarTextQuality.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextQuality.TabIndex"));
			this.TrackBarTextQuality.Text = resources.GetString("TrackBarTextQuality.Text");
			this.TrackBarTextQuality.TickFrequency = 5;
			this.TrackBarTextQuality.Unit = "%";
			this.TrackBarTextQuality.Value = 60;
			this.TrackBarTextQuality.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextQuality.Visible"));
			//
			//CheckBoxIsProgressive
			//
			this.CheckBoxIsProgressive.AccessibleDescription = resources.GetString("CheckBoxIsProgressive.AccessibleDescription");
			this.CheckBoxIsProgressive.AccessibleName = resources.GetString("CheckBoxIsProgressive.AccessibleName");
			this.CheckBoxIsProgressive.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("CheckBoxIsProgressive.Anchor");
			this.CheckBoxIsProgressive.Appearance = (System.Windows.Forms.Appearance) resources.GetObject("CheckBoxIsProgressive.Appearance");
			this.CheckBoxIsProgressive.BackgroundImage = (System.Drawing.Image) resources.GetObject("CheckBoxIsProgressive.BackgroundImage");
			this.CheckBoxIsProgressive.CheckAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxIsProgressive.CheckAlign");
			this.CheckBoxIsProgressive.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("CheckBoxIsProgressive.Dock");
			this.CheckBoxIsProgressive.Enabled = System.Convert.ToBoolean(resources.GetObject("CheckBoxIsProgressive.Enabled"));
			this.CheckBoxIsProgressive.FlatStyle = (System.Windows.Forms.FlatStyle) resources.GetObject("CheckBoxIsProgressive.FlatStyle");
			this.CheckBoxIsProgressive.Font = (System.Drawing.Font) resources.GetObject("CheckBoxIsProgressive.Font");
			this.CheckBoxIsProgressive.Image = (System.Drawing.Image) resources.GetObject("CheckBoxIsProgressive.Image");
			this.CheckBoxIsProgressive.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxIsProgressive.ImageAlign");
			this.CheckBoxIsProgressive.ImageIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxIsProgressive.ImageIndex"));
			this.CheckBoxIsProgressive.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("CheckBoxIsProgressive.ImeMode");
			this.CheckBoxIsProgressive.Location = (System.Drawing.Point) resources.GetObject("CheckBoxIsProgressive.Location");
			this.CheckBoxIsProgressive.Name = "CheckBoxIsProgressive";
			this.CheckBoxIsProgressive.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("CheckBoxIsProgressive.RightToLeft");
			this.CheckBoxIsProgressive.Size = (System.Drawing.Size) resources.GetObject("CheckBoxIsProgressive.Size");
			this.CheckBoxIsProgressive.TabIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxIsProgressive.TabIndex"));
			this.CheckBoxIsProgressive.Text = resources.GetString("CheckBoxIsProgressive.Text");
			this.CheckBoxIsProgressive.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxIsProgressive.TextAlign");
			this.CheckBoxIsProgressive.Visible = System.Convert.ToBoolean(resources.GetObject("CheckBoxIsProgressive.Visible"));
			//
			//JpegPropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.CheckBoxIsProgressive);
			this.Controls.Add(this.TrackBarTextQuality);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "JpegPropertyPage";
			this.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("$this.RightToLeft");
			this.Size = (System.Drawing.Size) resources.GetObject("$this.Size");
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private Aurigma.GraphicsMill.Bitmap _bitmap;
		private JpegSettings _encoderOptions;
		
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
		
		public WriterSettings EncoderOptions
		{
			get
			{
				return _encoderOptions;
			}
			set
			{
				_encoderOptions = (JpegSettings) value;
				TrackBarTextQuality.Value = _encoderOptions.Quality;
				CheckBoxIsProgressive.Checked = _encoderOptions.IsProgressive;
			}
		}
		
		public string Title
		{
			get
			{
				return "JPEG File Format";
			}
		}
		
		//Private Sub _bitmap_Changed(ByVal eventSender As System.Object, ByVal eventArgs As BitmapChangedEventArgs) Handles _bitmap.Changed
		//	'TODO: to be implemented
		//End Sub
		
		private void TrackBarTextQuality_ValueChanged(object sender, System.EventArgs e)
		{
			if (!(_encoderOptions == null))
			{
				_encoderOptions.Quality = TrackBarTextQuality.Value;
			}
		}
		
		private void CheckBoxIsProgressive_CheckedChanged(object sender, System.EventArgs e)
		{
			if (!(_encoderOptions == null))
			{
				_encoderOptions.IsProgressive = CheckBoxIsProgressive.Checked;
			}
		}
	}
	
}
