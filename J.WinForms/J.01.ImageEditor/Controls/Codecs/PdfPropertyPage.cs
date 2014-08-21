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
	public class PdfPropertyPage : System.Windows.Forms.UserControl, IEncoderPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public PdfPropertyPage()
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
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton RadioButtonJpeg;
		internal System.Windows.Forms.RadioButton RadioButtonZip;
		internal TrackBarText TrackBarTextQuality;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PdfPropertyPage));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.RadioButtonJpeg = new System.Windows.Forms.RadioButton();
			this.RadioButtonJpeg.CheckedChanged += new System.EventHandler(CompressionTypeChanged);
			this.RadioButtonZip = new System.Windows.Forms.RadioButton();
			this.RadioButtonZip.CheckedChanged += new System.EventHandler(CompressionTypeChanged);
			this.TrackBarTextQuality = new Main.TrackBarText();
			this.TrackBarTextQuality.ValueChanged += new Main.TrackBarText.ValueChangedEventHandler(this.TrackBarTextQuality_ValueChanged);
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.AccessibleDescription = resources.GetString("GroupBox1.AccessibleDescription");
			this.GroupBox1.AccessibleName = resources.GetString("GroupBox1.AccessibleName");
			this.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("GroupBox1.Anchor");
			this.GroupBox1.BackgroundImage = (System.Drawing.Image) resources.GetObject("GroupBox1.BackgroundImage");
			this.GroupBox1.Controls.Add(this.RadioButtonJpeg);
			this.GroupBox1.Controls.Add(this.RadioButtonZip);
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
			//RadioButtonJpeg
			//
			this.RadioButtonJpeg.AccessibleDescription = resources.GetString("RadioButtonJpeg.AccessibleDescription");
			this.RadioButtonJpeg.AccessibleName = resources.GetString("RadioButtonJpeg.AccessibleName");
			this.RadioButtonJpeg.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("RadioButtonJpeg.Anchor");
			this.RadioButtonJpeg.Appearance = (System.Windows.Forms.Appearance) resources.GetObject("RadioButtonJpeg.Appearance");
			this.RadioButtonJpeg.BackgroundImage = (System.Drawing.Image) resources.GetObject("RadioButtonJpeg.BackgroundImage");
			this.RadioButtonJpeg.CheckAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonJpeg.CheckAlign");
			this.RadioButtonJpeg.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("RadioButtonJpeg.Dock");
			this.RadioButtonJpeg.Enabled = System.Convert.ToBoolean(resources.GetObject("RadioButtonJpeg.Enabled"));
			this.RadioButtonJpeg.FlatStyle = (System.Windows.Forms.FlatStyle) resources.GetObject("RadioButtonJpeg.FlatStyle");
			this.RadioButtonJpeg.Font = (System.Drawing.Font) resources.GetObject("RadioButtonJpeg.Font");
			this.RadioButtonJpeg.Image = (System.Drawing.Image) resources.GetObject("RadioButtonJpeg.Image");
			this.RadioButtonJpeg.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonJpeg.ImageAlign");
			this.RadioButtonJpeg.ImageIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonJpeg.ImageIndex"));
			this.RadioButtonJpeg.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("RadioButtonJpeg.ImeMode");
			this.RadioButtonJpeg.Location = (System.Drawing.Point) resources.GetObject("RadioButtonJpeg.Location");
			this.RadioButtonJpeg.Name = "RadioButtonJpeg";
			this.RadioButtonJpeg.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("RadioButtonJpeg.RightToLeft");
			this.RadioButtonJpeg.Size = (System.Drawing.Size) resources.GetObject("RadioButtonJpeg.Size");
			this.RadioButtonJpeg.TabIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonJpeg.TabIndex"));
			this.RadioButtonJpeg.Text = resources.GetString("RadioButtonJpeg.Text");
			this.RadioButtonJpeg.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonJpeg.TextAlign");
			this.RadioButtonJpeg.Visible = System.Convert.ToBoolean(resources.GetObject("RadioButtonJpeg.Visible"));
			//
			//RadioButtonZip
			//
			this.RadioButtonZip.AccessibleDescription = resources.GetString("RadioButtonZip.AccessibleDescription");
			this.RadioButtonZip.AccessibleName = resources.GetString("RadioButtonZip.AccessibleName");
			this.RadioButtonZip.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("RadioButtonZip.Anchor");
			this.RadioButtonZip.Appearance = (System.Windows.Forms.Appearance) resources.GetObject("RadioButtonZip.Appearance");
			this.RadioButtonZip.BackgroundImage = (System.Drawing.Image) resources.GetObject("RadioButtonZip.BackgroundImage");
			this.RadioButtonZip.CheckAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonZip.CheckAlign");
			this.RadioButtonZip.Checked = true;
			this.RadioButtonZip.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("RadioButtonZip.Dock");
			this.RadioButtonZip.Enabled = System.Convert.ToBoolean(resources.GetObject("RadioButtonZip.Enabled"));
			this.RadioButtonZip.FlatStyle = (System.Windows.Forms.FlatStyle) resources.GetObject("RadioButtonZip.FlatStyle");
			this.RadioButtonZip.Font = (System.Drawing.Font) resources.GetObject("RadioButtonZip.Font");
			this.RadioButtonZip.Image = (System.Drawing.Image) resources.GetObject("RadioButtonZip.Image");
			this.RadioButtonZip.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonZip.ImageAlign");
			this.RadioButtonZip.ImageIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonZip.ImageIndex"));
			this.RadioButtonZip.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("RadioButtonZip.ImeMode");
			this.RadioButtonZip.Location = (System.Drawing.Point) resources.GetObject("RadioButtonZip.Location");
			this.RadioButtonZip.Name = "RadioButtonZip";
			this.RadioButtonZip.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("RadioButtonZip.RightToLeft");
			this.RadioButtonZip.Size = (System.Drawing.Size) resources.GetObject("RadioButtonZip.Size");
			this.RadioButtonZip.TabIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonZip.TabIndex"));
			this.RadioButtonZip.TabStop = true;
			this.RadioButtonZip.Text = resources.GetString("RadioButtonZip.Text");
			this.RadioButtonZip.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonZip.TextAlign");
			this.RadioButtonZip.Visible = System.Convert.ToBoolean(resources.GetObject("RadioButtonZip.Visible"));
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
			//PdfPropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.TrackBarTextQuality);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "PdfPropertyPage";
			this.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("$this.RightToLeft");
			this.Size = (System.Drawing.Size) resources.GetObject("$this.Size");
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private Aurigma.GraphicsMill.Bitmap _bitmap;
		private PdfSettings _encoderOptions;
		
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
				_encoderOptions = (PdfSettings) value;
				if (_encoderOptions.Compression == CompressionType.Jpeg)
				{
					RadioButtonJpeg.Checked = true;
				}
				else
				{
					RadioButtonZip.Checked = true;
				}
				TrackBarTextQuality.Value = _encoderOptions.Quality;
			}
		}
		
		public string Title
		{
			get
			{
				return "PDF File Format";
			}
		}
		
		//Private Sub _bitmap_Changed(ByVal eventSender As System.Object, ByVal eventArgs As BitmapChangedEventArgs) Handles _bitmap.Changed
		//	'TODO: to be implemented
		//End Sub
		
		private void CompressionTypeChanged(System.Object sender, System.EventArgs e)
		{
			if (!(_encoderOptions == null))
			{
				if (RadioButtonJpeg.Checked)
				{
					_encoderOptions.Compression = CompressionType.Jpeg;
				}
				else
				{
					_encoderOptions.Compression = CompressionType.Zip;
				}
				TrackBarTextQuality.Enabled = RadioButtonJpeg.Checked;
			}
		}
		
		private void TrackBarTextQuality_ValueChanged(object sender, System.EventArgs e)
		{
			if (!(_encoderOptions == null))
			{
				_encoderOptions.Quality = TrackBarTextQuality.Value;
			}
		}
	}
	
}
