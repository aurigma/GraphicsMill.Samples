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
	public class AddNoisePropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public AddNoisePropertyPage()
		{
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
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
		internal TrackBarText TrackBarTextAmount;
		internal System.Windows.Forms.CheckBox CheckBoxGray;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton RadioButtonUniform;
		internal System.Windows.Forms.RadioButton RadioButtonGaussian;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AddNoisePropertyPage));
			this.TrackBarTextAmount = new Main.TrackBarText();
			this.CheckBoxGray = new System.Windows.Forms.CheckBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.RadioButtonGaussian = new System.Windows.Forms.RadioButton();
			this.RadioButtonUniform = new System.Windows.Forms.RadioButton();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//TrackBarTextAmount
			//
			this.TrackBarTextAmount.AccessibleDescription = resources.GetString("TrackBarTextAmount.AccessibleDescription");
			this.TrackBarTextAmount.AccessibleName = resources.GetString("TrackBarTextAmount.AccessibleName");
			this.TrackBarTextAmount.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextAmount.Anchor");
			this.TrackBarTextAmount.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextAmount.AutoScroll"));
			this.TrackBarTextAmount.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextAmount.AutoScrollMargin");
			this.TrackBarTextAmount.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextAmount.AutoScrollMinSize");
			this.TrackBarTextAmount.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextAmount.BackgroundImage");
			this.TrackBarTextAmount.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextAmount.Dock");
			this.TrackBarTextAmount.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextAmount.Enabled"));
			this.TrackBarTextAmount.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextAmount.Font");
			this.TrackBarTextAmount.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextAmount.ImeMode");
			this.TrackBarTextAmount.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextAmount.Location");
			this.TrackBarTextAmount.Maximum = 100;
			this.TrackBarTextAmount.Minimum = 1;
			this.TrackBarTextAmount.Name = "TrackBarTextAmount";
			this.TrackBarTextAmount.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextAmount.RightToLeft");
			this.TrackBarTextAmount.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextAmount.Size");
			this.TrackBarTextAmount.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextAmount.TabIndex"));
			this.TrackBarTextAmount.Text = resources.GetString("TrackBarTextAmount.Text");
			this.TrackBarTextAmount.TickFrequency = 5;
			this.TrackBarTextAmount.Unit = "%";
			this.TrackBarTextAmount.Value = 20;
			this.TrackBarTextAmount.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextAmount.Visible"));
			//
			//CheckBoxGray
			//
			this.CheckBoxGray.AccessibleDescription = resources.GetString("CheckBoxGray.AccessibleDescription");
			this.CheckBoxGray.AccessibleName = resources.GetString("CheckBoxGray.AccessibleName");
			this.CheckBoxGray.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("CheckBoxGray.Anchor");
			this.CheckBoxGray.Appearance = (System.Windows.Forms.Appearance) resources.GetObject("CheckBoxGray.Appearance");
			this.CheckBoxGray.BackgroundImage = (System.Drawing.Image) resources.GetObject("CheckBoxGray.BackgroundImage");
			this.CheckBoxGray.CheckAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxGray.CheckAlign");
			this.CheckBoxGray.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("CheckBoxGray.Dock");
			this.CheckBoxGray.Enabled = System.Convert.ToBoolean(resources.GetObject("CheckBoxGray.Enabled"));
			this.CheckBoxGray.FlatStyle = (System.Windows.Forms.FlatStyle) resources.GetObject("CheckBoxGray.FlatStyle");
			this.CheckBoxGray.Font = (System.Drawing.Font) resources.GetObject("CheckBoxGray.Font");
			this.CheckBoxGray.Image = (System.Drawing.Image) resources.GetObject("CheckBoxGray.Image");
			this.CheckBoxGray.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxGray.ImageAlign");
			this.CheckBoxGray.ImageIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxGray.ImageIndex"));
			this.CheckBoxGray.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("CheckBoxGray.ImeMode");
			this.CheckBoxGray.Location = (System.Drawing.Point) resources.GetObject("CheckBoxGray.Location");
			this.CheckBoxGray.Name = "CheckBoxGray";
			this.CheckBoxGray.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("CheckBoxGray.RightToLeft");
			this.CheckBoxGray.Size = (System.Drawing.Size) resources.GetObject("CheckBoxGray.Size");
			this.CheckBoxGray.TabIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxGray.TabIndex"));
			this.CheckBoxGray.Text = resources.GetString("CheckBoxGray.Text");
			this.CheckBoxGray.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxGray.TextAlign");
			this.CheckBoxGray.Visible = System.Convert.ToBoolean(resources.GetObject("CheckBoxGray.Visible"));
			//
			//GroupBox1
			//
			this.GroupBox1.AccessibleDescription = resources.GetString("GroupBox1.AccessibleDescription");
			this.GroupBox1.AccessibleName = resources.GetString("GroupBox1.AccessibleName");
			this.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("GroupBox1.Anchor");
			this.GroupBox1.BackgroundImage = (System.Drawing.Image) resources.GetObject("GroupBox1.BackgroundImage");
			this.GroupBox1.Controls.Add(this.RadioButtonGaussian);
			this.GroupBox1.Controls.Add(this.RadioButtonUniform);
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
			//RadioButtonGaussian
			//
			this.RadioButtonGaussian.AccessibleDescription = resources.GetString("RadioButtonGaussian.AccessibleDescription");
			this.RadioButtonGaussian.AccessibleName = resources.GetString("RadioButtonGaussian.AccessibleName");
			this.RadioButtonGaussian.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("RadioButtonGaussian.Anchor");
			this.RadioButtonGaussian.Appearance = (System.Windows.Forms.Appearance) resources.GetObject("RadioButtonGaussian.Appearance");
			this.RadioButtonGaussian.BackgroundImage = (System.Drawing.Image) resources.GetObject("RadioButtonGaussian.BackgroundImage");
			this.RadioButtonGaussian.CheckAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonGaussian.CheckAlign");
			this.RadioButtonGaussian.Checked = true;
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
			this.RadioButtonGaussian.TabStop = true;
			this.RadioButtonGaussian.Text = resources.GetString("RadioButtonGaussian.Text");
			this.RadioButtonGaussian.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonGaussian.TextAlign");
			this.RadioButtonGaussian.Visible = System.Convert.ToBoolean(resources.GetObject("RadioButtonGaussian.Visible"));
			//
			//RadioButtonUniform
			//
			this.RadioButtonUniform.AccessibleDescription = resources.GetString("RadioButtonUniform.AccessibleDescription");
			this.RadioButtonUniform.AccessibleName = resources.GetString("RadioButtonUniform.AccessibleName");
			this.RadioButtonUniform.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("RadioButtonUniform.Anchor");
			this.RadioButtonUniform.Appearance = (System.Windows.Forms.Appearance) resources.GetObject("RadioButtonUniform.Appearance");
			this.RadioButtonUniform.BackgroundImage = (System.Drawing.Image) resources.GetObject("RadioButtonUniform.BackgroundImage");
			this.RadioButtonUniform.CheckAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonUniform.CheckAlign");
			this.RadioButtonUniform.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("RadioButtonUniform.Dock");
			this.RadioButtonUniform.Enabled = System.Convert.ToBoolean(resources.GetObject("RadioButtonUniform.Enabled"));
			this.RadioButtonUniform.FlatStyle = (System.Windows.Forms.FlatStyle) resources.GetObject("RadioButtonUniform.FlatStyle");
			this.RadioButtonUniform.Font = (System.Drawing.Font) resources.GetObject("RadioButtonUniform.Font");
			this.RadioButtonUniform.Image = (System.Drawing.Image) resources.GetObject("RadioButtonUniform.Image");
			this.RadioButtonUniform.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonUniform.ImageAlign");
			this.RadioButtonUniform.ImageIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonUniform.ImageIndex"));
			this.RadioButtonUniform.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("RadioButtonUniform.ImeMode");
			this.RadioButtonUniform.Location = (System.Drawing.Point) resources.GetObject("RadioButtonUniform.Location");
			this.RadioButtonUniform.Name = "RadioButtonUniform";
			this.RadioButtonUniform.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("RadioButtonUniform.RightToLeft");
			this.RadioButtonUniform.Size = (System.Drawing.Size) resources.GetObject("RadioButtonUniform.Size");
			this.RadioButtonUniform.TabIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonUniform.TabIndex"));
			this.RadioButtonUniform.Text = resources.GetString("RadioButtonUniform.Text");
			this.RadioButtonUniform.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("RadioButtonUniform.TextAlign");
			this.RadioButtonUniform.Visible = System.Convert.ToBoolean(resources.GetObject("RadioButtonUniform.Visible"));
			//
			//AddNoisePropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.CheckBoxGray);
			this.Controls.Add(this.TrackBarTextAmount);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "AddNoisePropertyPage";
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
				DistributionKind _type;
				if (RadioButtonUniform.Checked)
				{
					_type = DistributionKind.Uniform;
				}
				else
				{
					_type = DistributionKind.Gaussian;
				}
				return new AddNoise(Convert.ToSingle(TrackBarTextAmount.Value) / 100.0F, _type, CheckBoxGray.Checked, 0);
			}
		}
		
		public string Title
		{
			get
			{
				return "Add Noise";
			}
		}
	}
}
