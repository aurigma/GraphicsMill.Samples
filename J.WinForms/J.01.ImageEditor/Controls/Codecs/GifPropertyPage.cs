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
	public class GifPropertyPage : System.Windows.Forms.UserControl, IEncoderPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public GifPropertyPage()
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
		internal System.Windows.Forms.CheckBox CheckBoxInterlaced;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GifPropertyPage));
			this.CheckBoxInterlaced = new System.Windows.Forms.CheckBox();
			this.CheckBoxInterlaced.CheckedChanged += new System.EventHandler(CheckBoxInterlaced_CheckedChanged);
			this.SuspendLayout();
			//
			//CheckBoxInterlaced
			//
			this.CheckBoxInterlaced.AccessibleDescription = resources.GetString("CheckBoxInterlaced.AccessibleDescription");
			this.CheckBoxInterlaced.AccessibleName = resources.GetString("CheckBoxInterlaced.AccessibleName");
			this.CheckBoxInterlaced.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("CheckBoxInterlaced.Anchor");
			this.CheckBoxInterlaced.Appearance = (System.Windows.Forms.Appearance) resources.GetObject("CheckBoxInterlaced.Appearance");
			this.CheckBoxInterlaced.BackgroundImage = (System.Drawing.Image) resources.GetObject("CheckBoxInterlaced.BackgroundImage");
			this.CheckBoxInterlaced.CheckAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxInterlaced.CheckAlign");
			this.CheckBoxInterlaced.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("CheckBoxInterlaced.Dock");
			this.CheckBoxInterlaced.Enabled = System.Convert.ToBoolean(resources.GetObject("CheckBoxInterlaced.Enabled"));
			this.CheckBoxInterlaced.FlatStyle = (System.Windows.Forms.FlatStyle) resources.GetObject("CheckBoxInterlaced.FlatStyle");
			this.CheckBoxInterlaced.Font = (System.Drawing.Font) resources.GetObject("CheckBoxInterlaced.Font");
			this.CheckBoxInterlaced.Image = (System.Drawing.Image) resources.GetObject("CheckBoxInterlaced.Image");
			this.CheckBoxInterlaced.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxInterlaced.ImageAlign");
			this.CheckBoxInterlaced.ImageIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxInterlaced.ImageIndex"));
			this.CheckBoxInterlaced.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("CheckBoxInterlaced.ImeMode");
			this.CheckBoxInterlaced.Location = (System.Drawing.Point) resources.GetObject("CheckBoxInterlaced.Location");
			this.CheckBoxInterlaced.Name = "CheckBoxInterlaced";
			this.CheckBoxInterlaced.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("CheckBoxInterlaced.RightToLeft");
			this.CheckBoxInterlaced.Size = (System.Drawing.Size) resources.GetObject("CheckBoxInterlaced.Size");
			this.CheckBoxInterlaced.TabIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxInterlaced.TabIndex"));
			this.CheckBoxInterlaced.Text = resources.GetString("CheckBoxInterlaced.Text");
			this.CheckBoxInterlaced.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxInterlaced.TextAlign");
			this.CheckBoxInterlaced.Visible = System.Convert.ToBoolean(resources.GetObject("CheckBoxInterlaced.Visible"));
			//
			//GifPropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.CheckBoxInterlaced);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "GifPropertyPage";
			this.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("$this.RightToLeft");
			this.Size = (System.Drawing.Size) resources.GetObject("$this.Size");
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private Aurigma.GraphicsMill.Bitmap _bitmap;
		private GifSettings _encoderOptions;
		
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
				_encoderOptions = (GifSettings) value;
                // BUGBUG
				//CheckBoxInterlaced.Checked = _encoderOptions.IsOptimized
			}
		}
		
		public string Title
		{
			get
			{
				return "GIF File Format";
			}
		}
		
		//Private Sub _bitmap_Changed(ByVal eventSender As System.Object, ByVal eventArgs As BitmapChangedEventArgs) Handles _bitmap.Changed
		//	'TODO: to be implemented
		//End Sub
		
		private void CheckBoxInterlaced_CheckedChanged(System.Object sender, System.EventArgs e)
		{
            // BUGBUG
			//_encoderOptions.IsInterlaced = CheckBoxInterlaced.Checked;
		}
	}
}
