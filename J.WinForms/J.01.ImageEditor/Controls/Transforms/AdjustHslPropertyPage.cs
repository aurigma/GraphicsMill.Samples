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
	public class AdjustHslPropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public AdjustHslPropertyPage()
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
		internal TrackBarText TrackBarTextHue;
		internal TrackBarText TrackBarTextSaturation;
		internal TrackBarText TrackBarTextLightness;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.PictureBox PictureBoxBefore;
		internal System.Windows.Forms.PictureBox PictureBoxAfter;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AdjustHslPropertyPage));
			this.TrackBarTextHue = new Main.TrackBarText();
			this.TrackBarTextHue.ValueChanged += new Main.TrackBarText.ValueChangedEventHandler(this.TrackBarTextHue_ValueChanged);
			this.TrackBarTextSaturation = new Main.TrackBarText();
			this.TrackBarTextSaturation.ValueChanged += new Main.TrackBarText.ValueChangedEventHandler(this.TrackBarTextSaturation_ValueChanged);
			this.TrackBarTextLightness = new Main.TrackBarText();
			this.TrackBarTextLightness.ValueChanged += new Main.TrackBarText.ValueChangedEventHandler(this.TrackBarTextLightness_ValueChanged);
			this.Label1 = new System.Windows.Forms.Label();
			this.PictureBoxBefore = new System.Windows.Forms.PictureBox();
			this.PictureBoxBefore.Paint += new System.Windows.Forms.PaintEventHandler(PictureBoxBefore_Paint);
			this.PictureBoxAfter = new System.Windows.Forms.PictureBox();
			this.PictureBoxAfter.Paint += new System.Windows.Forms.PaintEventHandler(PictureBoxAfter_Paint);
			this.Label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//TrackBarTextHue
			//
			this.TrackBarTextHue.AccessibleDescription = resources.GetString("TrackBarTextHue.AccessibleDescription");
			this.TrackBarTextHue.AccessibleName = resources.GetString("TrackBarTextHue.AccessibleName");
			this.TrackBarTextHue.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextHue.Anchor");
			this.TrackBarTextHue.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextHue.AutoScroll"));
			this.TrackBarTextHue.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextHue.AutoScrollMargin");
			this.TrackBarTextHue.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextHue.AutoScrollMinSize");
			this.TrackBarTextHue.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextHue.BackgroundImage");
			this.TrackBarTextHue.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextHue.Dock");
			this.TrackBarTextHue.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextHue.Enabled"));
			this.TrackBarTextHue.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextHue.Font");
			this.TrackBarTextHue.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextHue.ImeMode");
			this.TrackBarTextHue.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextHue.Location");
			this.TrackBarTextHue.Maximum = 180;
			this.TrackBarTextHue.Minimum = - 180;
			this.TrackBarTextHue.Name = "TrackBarTextHue";
			this.TrackBarTextHue.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextHue.RightToLeft");
			this.TrackBarTextHue.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextHue.Size");
			this.TrackBarTextHue.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextHue.TabIndex"));
			this.TrackBarTextHue.Text = resources.GetString("TrackBarTextHue.Text");
			this.TrackBarTextHue.TickFrequency = 18;
			this.TrackBarTextHue.Unit = "";
			this.TrackBarTextHue.Value = 0;
			this.TrackBarTextHue.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextHue.Visible"));
			//
			//TrackBarTextSaturation
			//
			this.TrackBarTextSaturation.AccessibleDescription = resources.GetString("TrackBarTextSaturation.AccessibleDescription");
			this.TrackBarTextSaturation.AccessibleName = resources.GetString("TrackBarTextSaturation.AccessibleName");
			this.TrackBarTextSaturation.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextSaturation.Anchor");
			this.TrackBarTextSaturation.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextSaturation.AutoScroll"));
			this.TrackBarTextSaturation.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextSaturation.AutoScrollMargin");
			this.TrackBarTextSaturation.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextSaturation.AutoScrollMinSize");
			this.TrackBarTextSaturation.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextSaturation.BackgroundImage");
			this.TrackBarTextSaturation.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextSaturation.Dock");
			this.TrackBarTextSaturation.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextSaturation.Enabled"));
			this.TrackBarTextSaturation.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextSaturation.Font");
			this.TrackBarTextSaturation.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextSaturation.ImeMode");
			this.TrackBarTextSaturation.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextSaturation.Location");
			this.TrackBarTextSaturation.Maximum = 100;
			this.TrackBarTextSaturation.Minimum = - 100;
			this.TrackBarTextSaturation.Name = "TrackBarTextSaturation";
			this.TrackBarTextSaturation.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextSaturation.RightToLeft");
			this.TrackBarTextSaturation.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextSaturation.Size");
			this.TrackBarTextSaturation.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextSaturation.TabIndex"));
			this.TrackBarTextSaturation.Text = resources.GetString("TrackBarTextSaturation.Text");
			this.TrackBarTextSaturation.TickFrequency = 10;
			this.TrackBarTextSaturation.Unit = "";
			this.TrackBarTextSaturation.Value = 0;
			this.TrackBarTextSaturation.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextSaturation.Visible"));
			//
			//TrackBarTextLightness
			//
			this.TrackBarTextLightness.AccessibleDescription = resources.GetString("TrackBarTextLightness.AccessibleDescription");
			this.TrackBarTextLightness.AccessibleName = resources.GetString("TrackBarTextLightness.AccessibleName");
			this.TrackBarTextLightness.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextLightness.Anchor");
			this.TrackBarTextLightness.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextLightness.AutoScroll"));
			this.TrackBarTextLightness.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextLightness.AutoScrollMargin");
			this.TrackBarTextLightness.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextLightness.AutoScrollMinSize");
			this.TrackBarTextLightness.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextLightness.BackgroundImage");
			this.TrackBarTextLightness.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextLightness.Dock");
			this.TrackBarTextLightness.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextLightness.Enabled"));
			this.TrackBarTextLightness.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextLightness.Font");
			this.TrackBarTextLightness.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextLightness.ImeMode");
			this.TrackBarTextLightness.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextLightness.Location");
			this.TrackBarTextLightness.Maximum = 100;
			this.TrackBarTextLightness.Minimum = - 100;
			this.TrackBarTextLightness.Name = "TrackBarTextLightness";
			this.TrackBarTextLightness.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextLightness.RightToLeft");
			this.TrackBarTextLightness.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextLightness.Size");
			this.TrackBarTextLightness.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextLightness.TabIndex"));
			this.TrackBarTextLightness.Text = resources.GetString("TrackBarTextLightness.Text");
			this.TrackBarTextLightness.TickFrequency = 10;
			this.TrackBarTextLightness.Unit = "";
			this.TrackBarTextLightness.Value = 0;
			this.TrackBarTextLightness.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextLightness.Visible"));
			//
			//Label1
			//
			this.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription");
			this.Label1.AccessibleName = resources.GetString("Label1.AccessibleName");
			this.Label1.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("Label1.Anchor");
			this.Label1.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label1.AutoSize"));
			this.Label1.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("Label1.Dock");
			this.Label1.Enabled = System.Convert.ToBoolean(resources.GetObject("Label1.Enabled"));
			this.Label1.Font = (System.Drawing.Font) resources.GetObject("Label1.Font");
			this.Label1.Image = (System.Drawing.Image) resources.GetObject("Label1.Image");
			this.Label1.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label1.ImageAlign");
			this.Label1.ImageIndex = System.Convert.ToInt32(resources.GetObject("Label1.ImageIndex"));
			this.Label1.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("Label1.ImeMode");
			this.Label1.Location = (System.Drawing.Point) resources.GetObject("Label1.Location");
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("Label1.RightToLeft");
			this.Label1.Size = (System.Drawing.Size) resources.GetObject("Label1.Size");
			this.Label1.TabIndex = System.Convert.ToInt32(resources.GetObject("Label1.TabIndex"));
			this.Label1.Text = resources.GetString("Label1.Text");
			this.Label1.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label1.TextAlign");
			this.Label1.Visible = System.Convert.ToBoolean(resources.GetObject("Label1.Visible"));
			//
			//PictureBoxBefore
			//
			this.PictureBoxBefore.AccessibleDescription = resources.GetString("PictureBoxBefore.AccessibleDescription");
			this.PictureBoxBefore.AccessibleName = resources.GetString("PictureBoxBefore.AccessibleName");
			this.PictureBoxBefore.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("PictureBoxBefore.Anchor");
			this.PictureBoxBefore.BackgroundImage = (System.Drawing.Image) resources.GetObject("PictureBoxBefore.BackgroundImage");
			this.PictureBoxBefore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PictureBoxBefore.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("PictureBoxBefore.Dock");
			this.PictureBoxBefore.Enabled = System.Convert.ToBoolean(resources.GetObject("PictureBoxBefore.Enabled"));
			this.PictureBoxBefore.Font = (System.Drawing.Font) resources.GetObject("PictureBoxBefore.Font");
			this.PictureBoxBefore.Image = (System.Drawing.Image) resources.GetObject("PictureBoxBefore.Image");
			this.PictureBoxBefore.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("PictureBoxBefore.ImeMode");
			this.PictureBoxBefore.Location = (System.Drawing.Point) resources.GetObject("PictureBoxBefore.Location");
			this.PictureBoxBefore.Name = "PictureBoxBefore";
			this.PictureBoxBefore.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("PictureBoxBefore.RightToLeft");
			this.PictureBoxBefore.Size = (System.Drawing.Size) resources.GetObject("PictureBoxBefore.Size");
			this.PictureBoxBefore.SizeMode = (System.Windows.Forms.PictureBoxSizeMode) resources.GetObject("PictureBoxBefore.SizeMode");
			this.PictureBoxBefore.TabIndex = System.Convert.ToInt32(resources.GetObject("PictureBoxBefore.TabIndex"));
			this.PictureBoxBefore.TabStop = false;
			this.PictureBoxBefore.Text = resources.GetString("PictureBoxBefore.Text");
			this.PictureBoxBefore.Visible = System.Convert.ToBoolean(resources.GetObject("PictureBoxBefore.Visible"));
			//
			//PictureBoxAfter
			//
			this.PictureBoxAfter.AccessibleDescription = resources.GetString("PictureBoxAfter.AccessibleDescription");
			this.PictureBoxAfter.AccessibleName = resources.GetString("PictureBoxAfter.AccessibleName");
			this.PictureBoxAfter.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("PictureBoxAfter.Anchor");
			this.PictureBoxAfter.BackgroundImage = (System.Drawing.Image) resources.GetObject("PictureBoxAfter.BackgroundImage");
			this.PictureBoxAfter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PictureBoxAfter.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("PictureBoxAfter.Dock");
			this.PictureBoxAfter.Enabled = System.Convert.ToBoolean(resources.GetObject("PictureBoxAfter.Enabled"));
			this.PictureBoxAfter.Font = (System.Drawing.Font) resources.GetObject("PictureBoxAfter.Font");
			this.PictureBoxAfter.Image = (System.Drawing.Image) resources.GetObject("PictureBoxAfter.Image");
			this.PictureBoxAfter.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("PictureBoxAfter.ImeMode");
			this.PictureBoxAfter.Location = (System.Drawing.Point) resources.GetObject("PictureBoxAfter.Location");
			this.PictureBoxAfter.Name = "PictureBoxAfter";
			this.PictureBoxAfter.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("PictureBoxAfter.RightToLeft");
			this.PictureBoxAfter.Size = (System.Drawing.Size) resources.GetObject("PictureBoxAfter.Size");
			this.PictureBoxAfter.SizeMode = (System.Windows.Forms.PictureBoxSizeMode) resources.GetObject("PictureBoxAfter.SizeMode");
			this.PictureBoxAfter.TabIndex = System.Convert.ToInt32(resources.GetObject("PictureBoxAfter.TabIndex"));
			this.PictureBoxAfter.TabStop = false;
			this.PictureBoxAfter.Text = resources.GetString("PictureBoxAfter.Text");
			this.PictureBoxAfter.Visible = System.Convert.ToBoolean(resources.GetObject("PictureBoxAfter.Visible"));
			//
			//Label2
			//
			this.Label2.AccessibleDescription = resources.GetString("Label2.AccessibleDescription");
			this.Label2.AccessibleName = resources.GetString("Label2.AccessibleName");
			this.Label2.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("Label2.Anchor");
			this.Label2.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label2.AutoSize"));
			this.Label2.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("Label2.Dock");
			this.Label2.Enabled = System.Convert.ToBoolean(resources.GetObject("Label2.Enabled"));
			this.Label2.Font = (System.Drawing.Font) resources.GetObject("Label2.Font");
			this.Label2.Image = (System.Drawing.Image) resources.GetObject("Label2.Image");
			this.Label2.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label2.ImageAlign");
			this.Label2.ImageIndex = System.Convert.ToInt32(resources.GetObject("Label2.ImageIndex"));
			this.Label2.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("Label2.ImeMode");
			this.Label2.Location = (System.Drawing.Point) resources.GetObject("Label2.Location");
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("Label2.RightToLeft");
			this.Label2.Size = (System.Drawing.Size) resources.GetObject("Label2.Size");
			this.Label2.TabIndex = System.Convert.ToInt32(resources.GetObject("Label2.TabIndex"));
			this.Label2.Text = resources.GetString("Label2.Text");
			this.Label2.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label2.TextAlign");
			this.Label2.Visible = System.Convert.ToBoolean(resources.GetObject("Label2.Visible"));
			//
			//AdjustHslPropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.PictureBoxAfter);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.PictureBoxBefore);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TrackBarTextLightness);
			this.Controls.Add(this.TrackBarTextSaturation);
			this.Controls.Add(this.TrackBarTextHue);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "AdjustHslPropertyPage";
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
				return new AdjustHsl(Convert.ToSingle(TrackBarTextHue.Value) / 180.0F, Convert.ToSingle(TrackBarTextSaturation.Value) / 100.0F, Convert.ToSingle(TrackBarTextLightness.Value) / 100.0F);
			}
		}
		
		public string Title
		{
			get
			{
				return "Hue-Saturation-Lightness";
			}
		}
		
		private void ShowGradient(System.Drawing.Graphics g, int StartHue, float Saturation, float Lightness)
		{
			for (int i = 0; i <= PictureBoxBefore.Width - 1; i++)
			{
                RgbColor c = Aurigma.GraphicsMill.RgbColor.FromHsl(Convert.ToInt32(System.Math.Round(Convert.ToSingle(StartHue) + Convert.ToSingle(i) / Convert.ToSingle(PictureBoxBefore.Width) * 360 + 360) % 360), Saturation, Lightness);
                
				System.Drawing.Pen p = new System.Drawing.Pen(c.ToGdiPlusColor());
				g.DrawLine(p, i, 0, i, PictureBoxBefore.Height - 1);
			}
		}
		
		private void PictureBoxBefore_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			ShowGradient(e.Graphics, 0, 0.5F, 0.5F);
		}
		
		private void PictureBoxAfter_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			ShowGradient(e.Graphics, 0, 0.5F, 0.5F);
			ShowGradient(e.Graphics, TrackBarTextHue.Value, Convert.ToSingle(TrackBarTextSaturation.Value) / 200.0F + 0.5F, Convert.ToSingle(TrackBarTextLightness.Value) / 200.0F + 0.5F);
		}
		
		private void TrackBarTextHue_ValueChanged(object sender, System.EventArgs e)
		{
			PictureBoxAfter.Refresh();
		}
		
		private void TrackBarTextSaturation_ValueChanged(object sender, System.EventArgs e)
		{
			PictureBoxAfter.Refresh();
		}
		
		private void TrackBarTextLightness_ValueChanged(object sender, System.EventArgs e)
		{
			PictureBoxAfter.Refresh();
		}
	}
	
}
