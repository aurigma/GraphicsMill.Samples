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
	public class HistogramDialog : System.Windows.Forms.Form
	{
		
		#region " Windows Form Designer generated code "
		
		public HistogramDialog()
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
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label LabelMean;
		public System.Windows.Forms.Label LabelMedian;
		public System.Windows.Forms.Label LabelPixels;
		public System.Windows.Forms.PictureBox PictureBoxHistogram;
		public System.Windows.Forms.PictureBox PictureBoxGradient;
		public System.Windows.Forms.ComboBox ComboBoxChannel;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label LabelStandardDeviation;
		public System.Windows.Forms.Label LabelLevel;
		public System.Windows.Forms.Label LabelCount;
		public System.Windows.Forms.Label LabelPercentile;
		
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(HistogramDialog));
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.LabelMean = new System.Windows.Forms.Label();
			this.LabelStandardDeviation = new System.Windows.Forms.Label();
			this.LabelMedian = new System.Windows.Forms.Label();
			this.LabelPixels = new System.Windows.Forms.Label();
			this.PictureBoxHistogram = new System.Windows.Forms.PictureBox();
			this.PictureBoxHistogram.Paint += new System.Windows.Forms.PaintEventHandler(PictureBoxHistogram_Paint);
			this.PictureBoxHistogram.MouseMove += new System.Windows.Forms.MouseEventHandler(PictureBoxHistogram_MouseMove);
			this.PictureBoxGradient = new System.Windows.Forms.PictureBox();
			this.PictureBoxGradient.Paint += new System.Windows.Forms.PaintEventHandler(PictureBoxGradient_Paint);
			this.ComboBoxChannel = new System.Windows.Forms.ComboBox();
			this.ComboBoxChannel.SelectedIndexChanged += new System.EventHandler(ComboBoxChannel_SelectedIndexChanged);
			this.Label1 = new System.Windows.Forms.Label();
			this.LabelLevel = new System.Windows.Forms.Label();
			this.LabelCount = new System.Windows.Forms.Label();
			this.LabelPercentile = new System.Windows.Forms.Label();
			this.SuspendLayout();
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
			//Label3
			//
			this.Label3.AccessibleDescription = resources.GetString("Label3.AccessibleDescription");
			this.Label3.AccessibleName = resources.GetString("Label3.AccessibleName");
			this.Label3.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("Label3.Anchor");
			this.Label3.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label3.AutoSize"));
			this.Label3.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("Label3.Dock");
			this.Label3.Enabled = System.Convert.ToBoolean(resources.GetObject("Label3.Enabled"));
			this.Label3.Font = (System.Drawing.Font) resources.GetObject("Label3.Font");
			this.Label3.Image = (System.Drawing.Image) resources.GetObject("Label3.Image");
			this.Label3.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label3.ImageAlign");
			this.Label3.ImageIndex = System.Convert.ToInt32(resources.GetObject("Label3.ImageIndex"));
			this.Label3.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("Label3.ImeMode");
			this.Label3.Location = (System.Drawing.Point) resources.GetObject("Label3.Location");
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("Label3.RightToLeft");
			this.Label3.Size = (System.Drawing.Size) resources.GetObject("Label3.Size");
			this.Label3.TabIndex = System.Convert.ToInt32(resources.GetObject("Label3.TabIndex"));
			this.Label3.Text = resources.GetString("Label3.Text");
			this.Label3.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label3.TextAlign");
			this.Label3.Visible = System.Convert.ToBoolean(resources.GetObject("Label3.Visible"));
			//
			//Label4
			//
			this.Label4.AccessibleDescription = resources.GetString("Label4.AccessibleDescription");
			this.Label4.AccessibleName = resources.GetString("Label4.AccessibleName");
			this.Label4.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("Label4.Anchor");
			this.Label4.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label4.AutoSize"));
			this.Label4.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("Label4.Dock");
			this.Label4.Enabled = System.Convert.ToBoolean(resources.GetObject("Label4.Enabled"));
			this.Label4.Font = (System.Drawing.Font) resources.GetObject("Label4.Font");
			this.Label4.Image = (System.Drawing.Image) resources.GetObject("Label4.Image");
			this.Label4.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label4.ImageAlign");
			this.Label4.ImageIndex = System.Convert.ToInt32(resources.GetObject("Label4.ImageIndex"));
			this.Label4.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("Label4.ImeMode");
			this.Label4.Location = (System.Drawing.Point) resources.GetObject("Label4.Location");
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("Label4.RightToLeft");
			this.Label4.Size = (System.Drawing.Size) resources.GetObject("Label4.Size");
			this.Label4.TabIndex = System.Convert.ToInt32(resources.GetObject("Label4.TabIndex"));
			this.Label4.Text = resources.GetString("Label4.Text");
			this.Label4.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label4.TextAlign");
			this.Label4.Visible = System.Convert.ToBoolean(resources.GetObject("Label4.Visible"));
			//
			//Label5
			//
			this.Label5.AccessibleDescription = resources.GetString("Label5.AccessibleDescription");
			this.Label5.AccessibleName = resources.GetString("Label5.AccessibleName");
			this.Label5.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("Label5.Anchor");
			this.Label5.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label5.AutoSize"));
			this.Label5.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("Label5.Dock");
			this.Label5.Enabled = System.Convert.ToBoolean(resources.GetObject("Label5.Enabled"));
			this.Label5.Font = (System.Drawing.Font) resources.GetObject("Label5.Font");
			this.Label5.Image = (System.Drawing.Image) resources.GetObject("Label5.Image");
			this.Label5.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label5.ImageAlign");
			this.Label5.ImageIndex = System.Convert.ToInt32(resources.GetObject("Label5.ImageIndex"));
			this.Label5.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("Label5.ImeMode");
			this.Label5.Location = (System.Drawing.Point) resources.GetObject("Label5.Location");
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("Label5.RightToLeft");
			this.Label5.Size = (System.Drawing.Size) resources.GetObject("Label5.Size");
			this.Label5.TabIndex = System.Convert.ToInt32(resources.GetObject("Label5.TabIndex"));
			this.Label5.Text = resources.GetString("Label5.Text");
			this.Label5.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label5.TextAlign");
			this.Label5.Visible = System.Convert.ToBoolean(resources.GetObject("Label5.Visible"));
			//
			//Label6
			//
			this.Label6.AccessibleDescription = resources.GetString("Label6.AccessibleDescription");
			this.Label6.AccessibleName = resources.GetString("Label6.AccessibleName");
			this.Label6.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("Label6.Anchor");
			this.Label6.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label6.AutoSize"));
			this.Label6.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("Label6.Dock");
			this.Label6.Enabled = System.Convert.ToBoolean(resources.GetObject("Label6.Enabled"));
			this.Label6.Font = (System.Drawing.Font) resources.GetObject("Label6.Font");
			this.Label6.Image = (System.Drawing.Image) resources.GetObject("Label6.Image");
			this.Label6.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label6.ImageAlign");
			this.Label6.ImageIndex = System.Convert.ToInt32(resources.GetObject("Label6.ImageIndex"));
			this.Label6.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("Label6.ImeMode");
			this.Label6.Location = (System.Drawing.Point) resources.GetObject("Label6.Location");
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("Label6.RightToLeft");
			this.Label6.Size = (System.Drawing.Size) resources.GetObject("Label6.Size");
			this.Label6.TabIndex = System.Convert.ToInt32(resources.GetObject("Label6.TabIndex"));
			this.Label6.Text = resources.GetString("Label6.Text");
			this.Label6.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label6.TextAlign");
			this.Label6.Visible = System.Convert.ToBoolean(resources.GetObject("Label6.Visible"));
			//
			//Label7
			//
			this.Label7.AccessibleDescription = resources.GetString("Label7.AccessibleDescription");
			this.Label7.AccessibleName = resources.GetString("Label7.AccessibleName");
			this.Label7.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("Label7.Anchor");
			this.Label7.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label7.AutoSize"));
			this.Label7.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("Label7.Dock");
			this.Label7.Enabled = System.Convert.ToBoolean(resources.GetObject("Label7.Enabled"));
			this.Label7.Font = (System.Drawing.Font) resources.GetObject("Label7.Font");
			this.Label7.Image = (System.Drawing.Image) resources.GetObject("Label7.Image");
			this.Label7.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label7.ImageAlign");
			this.Label7.ImageIndex = System.Convert.ToInt32(resources.GetObject("Label7.ImageIndex"));
			this.Label7.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("Label7.ImeMode");
			this.Label7.Location = (System.Drawing.Point) resources.GetObject("Label7.Location");
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("Label7.RightToLeft");
			this.Label7.Size = (System.Drawing.Size) resources.GetObject("Label7.Size");
			this.Label7.TabIndex = System.Convert.ToInt32(resources.GetObject("Label7.TabIndex"));
			this.Label7.Text = resources.GetString("Label7.Text");
			this.Label7.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label7.TextAlign");
			this.Label7.Visible = System.Convert.ToBoolean(resources.GetObject("Label7.Visible"));
			//
			//Label8
			//
			this.Label8.AccessibleDescription = resources.GetString("Label8.AccessibleDescription");
			this.Label8.AccessibleName = resources.GetString("Label8.AccessibleName");
			this.Label8.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("Label8.Anchor");
			this.Label8.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label8.AutoSize"));
			this.Label8.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("Label8.Dock");
			this.Label8.Enabled = System.Convert.ToBoolean(resources.GetObject("Label8.Enabled"));
			this.Label8.Font = (System.Drawing.Font) resources.GetObject("Label8.Font");
			this.Label8.Image = (System.Drawing.Image) resources.GetObject("Label8.Image");
			this.Label8.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label8.ImageAlign");
			this.Label8.ImageIndex = System.Convert.ToInt32(resources.GetObject("Label8.ImageIndex"));
			this.Label8.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("Label8.ImeMode");
			this.Label8.Location = (System.Drawing.Point) resources.GetObject("Label8.Location");
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("Label8.RightToLeft");
			this.Label8.Size = (System.Drawing.Size) resources.GetObject("Label8.Size");
			this.Label8.TabIndex = System.Convert.ToInt32(resources.GetObject("Label8.TabIndex"));
			this.Label8.Text = resources.GetString("Label8.Text");
			this.Label8.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label8.TextAlign");
			this.Label8.Visible = System.Convert.ToBoolean(resources.GetObject("Label8.Visible"));
			//
			//LabelMean
			//
			this.LabelMean.AccessibleDescription = resources.GetString("LabelMean.AccessibleDescription");
			this.LabelMean.AccessibleName = resources.GetString("LabelMean.AccessibleName");
			this.LabelMean.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("LabelMean.Anchor");
			this.LabelMean.AutoSize = System.Convert.ToBoolean(resources.GetObject("LabelMean.AutoSize"));
			this.LabelMean.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("LabelMean.Dock");
			this.LabelMean.Enabled = System.Convert.ToBoolean(resources.GetObject("LabelMean.Enabled"));
			this.LabelMean.Font = (System.Drawing.Font) resources.GetObject("LabelMean.Font");
			this.LabelMean.Image = (System.Drawing.Image) resources.GetObject("LabelMean.Image");
			this.LabelMean.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelMean.ImageAlign");
			this.LabelMean.ImageIndex = System.Convert.ToInt32(resources.GetObject("LabelMean.ImageIndex"));
			this.LabelMean.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("LabelMean.ImeMode");
			this.LabelMean.Location = (System.Drawing.Point) resources.GetObject("LabelMean.Location");
			this.LabelMean.Name = "LabelMean";
			this.LabelMean.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("LabelMean.RightToLeft");
			this.LabelMean.Size = (System.Drawing.Size) resources.GetObject("LabelMean.Size");
			this.LabelMean.TabIndex = System.Convert.ToInt32(resources.GetObject("LabelMean.TabIndex"));
			this.LabelMean.Text = resources.GetString("LabelMean.Text");
			this.LabelMean.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelMean.TextAlign");
			this.LabelMean.Visible = System.Convert.ToBoolean(resources.GetObject("LabelMean.Visible"));
			//
			//LabelStandardDeviation
			//
			this.LabelStandardDeviation.AccessibleDescription = resources.GetString("LabelStandardDeviation.AccessibleDescription");
			this.LabelStandardDeviation.AccessibleName = resources.GetString("LabelStandardDeviation.AccessibleName");
			this.LabelStandardDeviation.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("LabelStandardDeviation.Anchor");
			this.LabelStandardDeviation.AutoSize = System.Convert.ToBoolean(resources.GetObject("LabelStandardDeviation.AutoSize"));
			this.LabelStandardDeviation.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("LabelStandardDeviation.Dock");
			this.LabelStandardDeviation.Enabled = System.Convert.ToBoolean(resources.GetObject("LabelStandardDeviation.Enabled"));
			this.LabelStandardDeviation.Font = (System.Drawing.Font) resources.GetObject("LabelStandardDeviation.Font");
			this.LabelStandardDeviation.Image = (System.Drawing.Image) resources.GetObject("LabelStandardDeviation.Image");
			this.LabelStandardDeviation.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelStandardDeviation.ImageAlign");
			this.LabelStandardDeviation.ImageIndex = System.Convert.ToInt32(resources.GetObject("LabelStandardDeviation.ImageIndex"));
			this.LabelStandardDeviation.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("LabelStandardDeviation.ImeMode");
			this.LabelStandardDeviation.Location = (System.Drawing.Point) resources.GetObject("LabelStandardDeviation.Location");
			this.LabelStandardDeviation.Name = "LabelStandardDeviation";
			this.LabelStandardDeviation.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("LabelStandardDeviation.RightToLeft");
			this.LabelStandardDeviation.Size = (System.Drawing.Size) resources.GetObject("LabelStandardDeviation.Size");
			this.LabelStandardDeviation.TabIndex = System.Convert.ToInt32(resources.GetObject("LabelStandardDeviation.TabIndex"));
			this.LabelStandardDeviation.Text = resources.GetString("LabelStandardDeviation.Text");
			this.LabelStandardDeviation.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelStandardDeviation.TextAlign");
			this.LabelStandardDeviation.Visible = System.Convert.ToBoolean(resources.GetObject("LabelStandardDeviation.Visible"));
			//
			//LabelMedian
			//
			this.LabelMedian.AccessibleDescription = resources.GetString("LabelMedian.AccessibleDescription");
			this.LabelMedian.AccessibleName = resources.GetString("LabelMedian.AccessibleName");
			this.LabelMedian.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("LabelMedian.Anchor");
			this.LabelMedian.AutoSize = System.Convert.ToBoolean(resources.GetObject("LabelMedian.AutoSize"));
			this.LabelMedian.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("LabelMedian.Dock");
			this.LabelMedian.Enabled = System.Convert.ToBoolean(resources.GetObject("LabelMedian.Enabled"));
			this.LabelMedian.Font = (System.Drawing.Font) resources.GetObject("LabelMedian.Font");
			this.LabelMedian.Image = (System.Drawing.Image) resources.GetObject("LabelMedian.Image");
			this.LabelMedian.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelMedian.ImageAlign");
			this.LabelMedian.ImageIndex = System.Convert.ToInt32(resources.GetObject("LabelMedian.ImageIndex"));
			this.LabelMedian.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("LabelMedian.ImeMode");
			this.LabelMedian.Location = (System.Drawing.Point) resources.GetObject("LabelMedian.Location");
			this.LabelMedian.Name = "LabelMedian";
			this.LabelMedian.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("LabelMedian.RightToLeft");
			this.LabelMedian.Size = (System.Drawing.Size) resources.GetObject("LabelMedian.Size");
			this.LabelMedian.TabIndex = System.Convert.ToInt32(resources.GetObject("LabelMedian.TabIndex"));
			this.LabelMedian.Text = resources.GetString("LabelMedian.Text");
			this.LabelMedian.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelMedian.TextAlign");
			this.LabelMedian.Visible = System.Convert.ToBoolean(resources.GetObject("LabelMedian.Visible"));
			//
			//LabelPixels
			//
			this.LabelPixels.AccessibleDescription = resources.GetString("LabelPixels.AccessibleDescription");
			this.LabelPixels.AccessibleName = resources.GetString("LabelPixels.AccessibleName");
			this.LabelPixels.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("LabelPixels.Anchor");
			this.LabelPixels.AutoSize = System.Convert.ToBoolean(resources.GetObject("LabelPixels.AutoSize"));
			this.LabelPixels.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("LabelPixels.Dock");
			this.LabelPixels.Enabled = System.Convert.ToBoolean(resources.GetObject("LabelPixels.Enabled"));
			this.LabelPixels.Font = (System.Drawing.Font) resources.GetObject("LabelPixels.Font");
			this.LabelPixels.Image = (System.Drawing.Image) resources.GetObject("LabelPixels.Image");
			this.LabelPixels.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelPixels.ImageAlign");
			this.LabelPixels.ImageIndex = System.Convert.ToInt32(resources.GetObject("LabelPixels.ImageIndex"));
			this.LabelPixels.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("LabelPixels.ImeMode");
			this.LabelPixels.Location = (System.Drawing.Point) resources.GetObject("LabelPixels.Location");
			this.LabelPixels.Name = "LabelPixels";
			this.LabelPixels.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("LabelPixels.RightToLeft");
			this.LabelPixels.Size = (System.Drawing.Size) resources.GetObject("LabelPixels.Size");
			this.LabelPixels.TabIndex = System.Convert.ToInt32(resources.GetObject("LabelPixels.TabIndex"));
			this.LabelPixels.Text = resources.GetString("LabelPixels.Text");
			this.LabelPixels.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelPixels.TextAlign");
			this.LabelPixels.Visible = System.Convert.ToBoolean(resources.GetObject("LabelPixels.Visible"));
			//
			//PictureBoxHistogram
			//
			this.PictureBoxHistogram.AccessibleDescription = resources.GetString("PictureBoxHistogram.AccessibleDescription");
			this.PictureBoxHistogram.AccessibleName = resources.GetString("PictureBoxHistogram.AccessibleName");
			this.PictureBoxHistogram.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("PictureBoxHistogram.Anchor");
			this.PictureBoxHistogram.BackgroundImage = (System.Drawing.Image) resources.GetObject("PictureBoxHistogram.BackgroundImage");
			this.PictureBoxHistogram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PictureBoxHistogram.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("PictureBoxHistogram.Dock");
			this.PictureBoxHistogram.Enabled = System.Convert.ToBoolean(resources.GetObject("PictureBoxHistogram.Enabled"));
			this.PictureBoxHistogram.Font = (System.Drawing.Font) resources.GetObject("PictureBoxHistogram.Font");
			this.PictureBoxHistogram.Image = (System.Drawing.Image) resources.GetObject("PictureBoxHistogram.Image");
			this.PictureBoxHistogram.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("PictureBoxHistogram.ImeMode");
			this.PictureBoxHistogram.Location = (System.Drawing.Point) resources.GetObject("PictureBoxHistogram.Location");
			this.PictureBoxHistogram.Name = "PictureBoxHistogram";
			this.PictureBoxHistogram.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("PictureBoxHistogram.RightToLeft");
			this.PictureBoxHistogram.Size = (System.Drawing.Size) resources.GetObject("PictureBoxHistogram.Size");
			this.PictureBoxHistogram.SizeMode = (System.Windows.Forms.PictureBoxSizeMode) resources.GetObject("PictureBoxHistogram.SizeMode");
			this.PictureBoxHistogram.TabIndex = System.Convert.ToInt32(resources.GetObject("PictureBoxHistogram.TabIndex"));
			this.PictureBoxHistogram.TabStop = false;
			this.PictureBoxHistogram.Text = resources.GetString("PictureBoxHistogram.Text");
			this.PictureBoxHistogram.Visible = System.Convert.ToBoolean(resources.GetObject("PictureBoxHistogram.Visible"));
			//
			//PictureBoxGradient
			//
			this.PictureBoxGradient.AccessibleDescription = resources.GetString("PictureBoxGradient.AccessibleDescription");
			this.PictureBoxGradient.AccessibleName = resources.GetString("PictureBoxGradient.AccessibleName");
			this.PictureBoxGradient.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("PictureBoxGradient.Anchor");
			this.PictureBoxGradient.BackgroundImage = (System.Drawing.Image) resources.GetObject("PictureBoxGradient.BackgroundImage");
			this.PictureBoxGradient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PictureBoxGradient.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("PictureBoxGradient.Dock");
			this.PictureBoxGradient.Enabled = System.Convert.ToBoolean(resources.GetObject("PictureBoxGradient.Enabled"));
			this.PictureBoxGradient.Font = (System.Drawing.Font) resources.GetObject("PictureBoxGradient.Font");
			this.PictureBoxGradient.Image = (System.Drawing.Image) resources.GetObject("PictureBoxGradient.Image");
			this.PictureBoxGradient.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("PictureBoxGradient.ImeMode");
			this.PictureBoxGradient.Location = (System.Drawing.Point) resources.GetObject("PictureBoxGradient.Location");
			this.PictureBoxGradient.Name = "PictureBoxGradient";
			this.PictureBoxGradient.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("PictureBoxGradient.RightToLeft");
			this.PictureBoxGradient.Size = (System.Drawing.Size) resources.GetObject("PictureBoxGradient.Size");
			this.PictureBoxGradient.SizeMode = (System.Windows.Forms.PictureBoxSizeMode) resources.GetObject("PictureBoxGradient.SizeMode");
			this.PictureBoxGradient.TabIndex = System.Convert.ToInt32(resources.GetObject("PictureBoxGradient.TabIndex"));
			this.PictureBoxGradient.TabStop = false;
			this.PictureBoxGradient.Text = resources.GetString("PictureBoxGradient.Text");
			this.PictureBoxGradient.Visible = System.Convert.ToBoolean(resources.GetObject("PictureBoxGradient.Visible"));
			//
			//ComboBoxChannel
			//
			this.ComboBoxChannel.AccessibleDescription = resources.GetString("ComboBoxChannel.AccessibleDescription");
			this.ComboBoxChannel.AccessibleName = resources.GetString("ComboBoxChannel.AccessibleName");
			this.ComboBoxChannel.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("ComboBoxChannel.Anchor");
			this.ComboBoxChannel.BackColor = System.Drawing.SystemColors.Window;
			this.ComboBoxChannel.BackgroundImage = (System.Drawing.Image) resources.GetObject("ComboBoxChannel.BackgroundImage");
			this.ComboBoxChannel.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("ComboBoxChannel.Dock");
			this.ComboBoxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxChannel.Enabled = System.Convert.ToBoolean(resources.GetObject("ComboBoxChannel.Enabled"));
			this.ComboBoxChannel.Font = (System.Drawing.Font) resources.GetObject("ComboBoxChannel.Font");
			this.ComboBoxChannel.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("ComboBoxChannel.ImeMode");
			this.ComboBoxChannel.IntegralHeight = System.Convert.ToBoolean(resources.GetObject("ComboBoxChannel.IntegralHeight"));
			this.ComboBoxChannel.ItemHeight = System.Convert.ToInt32(resources.GetObject("ComboBoxChannel.ItemHeight"));
			this.ComboBoxChannel.Items.AddRange(new object[] { resources.GetString("ComboBoxChannel.Items"), resources.GetString("ComboBoxChannel.Items1"), resources.GetString("ComboBoxChannel.Items2"), resources.GetString("ComboBoxChannel.Items3") });
			this.ComboBoxChannel.Location = (System.Drawing.Point) resources.GetObject("ComboBoxChannel.Location");
			this.ComboBoxChannel.MaxDropDownItems = System.Convert.ToInt32(resources.GetObject("ComboBoxChannel.MaxDropDownItems"));
			this.ComboBoxChannel.MaxLength = System.Convert.ToInt32(resources.GetObject("ComboBoxChannel.MaxLength"));
			this.ComboBoxChannel.Name = "ComboBoxChannel";
			this.ComboBoxChannel.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("ComboBoxChannel.RightToLeft");
			this.ComboBoxChannel.Size = (System.Drawing.Size) resources.GetObject("ComboBoxChannel.Size");
			this.ComboBoxChannel.TabIndex = System.Convert.ToInt32(resources.GetObject("ComboBoxChannel.TabIndex"));
			this.ComboBoxChannel.Text = resources.GetString("ComboBoxChannel.Text");
			this.ComboBoxChannel.Visible = System.Convert.ToBoolean(resources.GetObject("ComboBoxChannel.Visible"));
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
			//LabelLevel
			//
			this.LabelLevel.AccessibleDescription = resources.GetString("LabelLevel.AccessibleDescription");
			this.LabelLevel.AccessibleName = resources.GetString("LabelLevel.AccessibleName");
			this.LabelLevel.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("LabelLevel.Anchor");
			this.LabelLevel.AutoSize = System.Convert.ToBoolean(resources.GetObject("LabelLevel.AutoSize"));
			this.LabelLevel.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("LabelLevel.Dock");
			this.LabelLevel.Enabled = System.Convert.ToBoolean(resources.GetObject("LabelLevel.Enabled"));
			this.LabelLevel.Font = (System.Drawing.Font) resources.GetObject("LabelLevel.Font");
			this.LabelLevel.Image = (System.Drawing.Image) resources.GetObject("LabelLevel.Image");
			this.LabelLevel.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelLevel.ImageAlign");
			this.LabelLevel.ImageIndex = System.Convert.ToInt32(resources.GetObject("LabelLevel.ImageIndex"));
			this.LabelLevel.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("LabelLevel.ImeMode");
			this.LabelLevel.Location = (System.Drawing.Point) resources.GetObject("LabelLevel.Location");
			this.LabelLevel.Name = "LabelLevel";
			this.LabelLevel.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("LabelLevel.RightToLeft");
			this.LabelLevel.Size = (System.Drawing.Size) resources.GetObject("LabelLevel.Size");
			this.LabelLevel.TabIndex = System.Convert.ToInt32(resources.GetObject("LabelLevel.TabIndex"));
			this.LabelLevel.Text = resources.GetString("LabelLevel.Text");
			this.LabelLevel.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelLevel.TextAlign");
			this.LabelLevel.Visible = System.Convert.ToBoolean(resources.GetObject("LabelLevel.Visible"));
			//
			//LabelCount
			//
			this.LabelCount.AccessibleDescription = resources.GetString("LabelCount.AccessibleDescription");
			this.LabelCount.AccessibleName = resources.GetString("LabelCount.AccessibleName");
			this.LabelCount.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("LabelCount.Anchor");
			this.LabelCount.AutoSize = System.Convert.ToBoolean(resources.GetObject("LabelCount.AutoSize"));
			this.LabelCount.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("LabelCount.Dock");
			this.LabelCount.Enabled = System.Convert.ToBoolean(resources.GetObject("LabelCount.Enabled"));
			this.LabelCount.Font = (System.Drawing.Font) resources.GetObject("LabelCount.Font");
			this.LabelCount.Image = (System.Drawing.Image) resources.GetObject("LabelCount.Image");
			this.LabelCount.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelCount.ImageAlign");
			this.LabelCount.ImageIndex = System.Convert.ToInt32(resources.GetObject("LabelCount.ImageIndex"));
			this.LabelCount.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("LabelCount.ImeMode");
			this.LabelCount.Location = (System.Drawing.Point) resources.GetObject("LabelCount.Location");
			this.LabelCount.Name = "LabelCount";
			this.LabelCount.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("LabelCount.RightToLeft");
			this.LabelCount.Size = (System.Drawing.Size) resources.GetObject("LabelCount.Size");
			this.LabelCount.TabIndex = System.Convert.ToInt32(resources.GetObject("LabelCount.TabIndex"));
			this.LabelCount.Text = resources.GetString("LabelCount.Text");
			this.LabelCount.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelCount.TextAlign");
			this.LabelCount.Visible = System.Convert.ToBoolean(resources.GetObject("LabelCount.Visible"));
			//
			//LabelPercentile
			//
			this.LabelPercentile.AccessibleDescription = resources.GetString("LabelPercentile.AccessibleDescription");
			this.LabelPercentile.AccessibleName = resources.GetString("LabelPercentile.AccessibleName");
			this.LabelPercentile.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("LabelPercentile.Anchor");
			this.LabelPercentile.AutoSize = System.Convert.ToBoolean(resources.GetObject("LabelPercentile.AutoSize"));
			this.LabelPercentile.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("LabelPercentile.Dock");
			this.LabelPercentile.Enabled = System.Convert.ToBoolean(resources.GetObject("LabelPercentile.Enabled"));
			this.LabelPercentile.Font = (System.Drawing.Font) resources.GetObject("LabelPercentile.Font");
			this.LabelPercentile.Image = (System.Drawing.Image) resources.GetObject("LabelPercentile.Image");
			this.LabelPercentile.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelPercentile.ImageAlign");
			this.LabelPercentile.ImageIndex = System.Convert.ToInt32(resources.GetObject("LabelPercentile.ImageIndex"));
			this.LabelPercentile.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("LabelPercentile.ImeMode");
			this.LabelPercentile.Location = (System.Drawing.Point) resources.GetObject("LabelPercentile.Location");
			this.LabelPercentile.Name = "LabelPercentile";
			this.LabelPercentile.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("LabelPercentile.RightToLeft");
			this.LabelPercentile.Size = (System.Drawing.Size) resources.GetObject("LabelPercentile.Size");
			this.LabelPercentile.TabIndex = System.Convert.ToInt32(resources.GetObject("LabelPercentile.TabIndex"));
			this.LabelPercentile.Text = resources.GetString("LabelPercentile.Text");
			this.LabelPercentile.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelPercentile.TextAlign");
			this.LabelPercentile.Visible = System.Convert.ToBoolean(resources.GetObject("LabelPercentile.Visible"));
			//
			//HistogramDialog
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = (System.Drawing.Size) resources.GetObject("$this.AutoScaleBaseSize");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.ClientSize = (System.Drawing.Size) resources.GetObject("$this.ClientSize");
			this.Controls.Add(this.LabelLevel);
			this.Controls.Add(this.LabelCount);
			this.Controls.Add(this.LabelPercentile);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.LabelMean);
			this.Controls.Add(this.LabelStandardDeviation);
			this.Controls.Add(this.LabelMedian);
			this.Controls.Add(this.LabelPixels);
			this.Controls.Add(this.PictureBoxHistogram);
			this.Controls.Add(this.PictureBoxGradient);
			this.Controls.Add(this.ComboBoxChannel);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = (System.Drawing.Icon) resources.GetObject("$this.Icon");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.MaximumSize = (System.Drawing.Size) resources.GetObject("$this.MaximumSize");
			this.MinimumSize = (System.Drawing.Size) resources.GetObject("$this.MinimumSize");
			this.Name = "HistogramDialog";
			this.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("$this.RightToLeft");
			this.StartPosition = (System.Windows.Forms.FormStartPosition) resources.GetObject("$this.StartPosition");
			this.Text = resources.GetString("$this.Text");
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private Aurigma.GraphicsMill.Bitmap _bitmap;
		private Histogram _histogram;
		private System.Drawing.Color histColor;
		
		public Aurigma.GraphicsMill.Bitmap Bitmap
		{
			get
			{
				return _bitmap;
			}
			set
			{
				_bitmap = value;

				UpdateHistogram();
			}
		}

		private void UpdateHistogram()
		{
			ShowChannels();
			RefreshHistogram();
			PictureBoxHistogram.Refresh();
			PictureBoxGradient.Refresh();
			System.Globalization.NumberFormatInfo numberFormat = new System.Globalization.NumberFormatInfo();
			LabelMean.Text = _histogram.Mean.ToString(numberFormat);
			LabelStandardDeviation.Text = _histogram.StandardDeviation.ToString(numberFormat);
			LabelMedian.Text = _histogram.Median.ToString(numberFormat);
			LabelPixels.Text = Convert.ToString(Bitmap.Width * Bitmap.Height, numberFormat);
		}
		
		private void ShowChannels()
		{
			if ((_bitmap != null) &&(! _bitmap.IsEmpty))
			{
				ComboBoxChannel.Items.Clear();
				if (_bitmap.PixelFormat.IsRgb)
				{
					ComboBoxChannel.Items.AddRange(new string[] { "All", "Red", "Green", "Blue", "Luminosity" });
				}
				else if (_bitmap.PixelFormat.IsCmyk)
				{
					ComboBoxChannel.Items.AddRange(new string[] { "All", "Cyan", "Magenta", "Yellow", "Black" });
				}
				else if (_bitmap.PixelFormat.IsGrayscale)
				{
					ComboBoxChannel.Items.AddRange(new string[] {"All"});
				}
				ComboBoxChannel.SelectedIndex = 0;
				ComboBoxChannel.Enabled = ! _bitmap.PixelFormat.IsGrayscale;
			}
		}
		
		private void RefreshHistogram()
		{
			if (_bitmap != null && ! _bitmap.IsEmpty)
			{
                switch (ComboBoxChannel.Text)
                {
                    case "Red":
                        _histogram = _bitmap.Statistics.GetSumHistogram(Channel.Red);
                        histColor = System.Drawing.Color.Red;
                        break;

                    case "Green":
                        _histogram = _bitmap.Statistics.GetSumHistogram(Channel.Green);
                        histColor = System.Drawing.Color.Green;
                        break;

                    case "Blue":
                        _histogram = _bitmap.Statistics.GetSumHistogram(Channel.Blue);
                        histColor = System.Drawing.Color.Blue;
                        break;

                    case "Cyan":
                        _histogram = _bitmap.Statistics.GetSumHistogram(Channel.Cyan);
                        histColor = System.Drawing.Color.Cyan;
                        break;

                    case "Magenta":
                        _histogram = _bitmap.Statistics.GetSumHistogram(Channel.Magenta);
                        histColor = System.Drawing.Color.Magenta;
                        break;

                    case "Yellow":
                        _histogram = _bitmap.Statistics.GetSumHistogram(Channel.Yellow);
                        histColor = System.Drawing.Color.Yellow;
                        break;

                    case "Black":
                        _histogram = _bitmap.Statistics.GetSumHistogram(Channel.Black);
                        histColor = System.Drawing.Color.Black;
                        break;

                    case "All":
                        _histogram = _bitmap.Statistics.GetSumHistogram();
                        histColor = System.Drawing.Color.Black;
                        break;
                }
			}
		}
		
		private void ComboBoxChannel_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			PictureBoxGradient.Refresh();
			RefreshHistogram();
			PictureBoxHistogram.Refresh();
		}
		
		private void PictureBoxHistogram_Paint(System.Object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Utils.DrawHistogram(_histogram, e.Graphics, PictureBoxHistogram.Height, histColor, _bitmap.PixelFormat.IsCmyk);
		}
		
		private void PictureBoxGradient_Paint(System.Object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Utils.DrawGradient(e.Graphics, ComboBoxChannel.Text);
		}
		
		// Handle also mouse out event here.
		private void PictureBoxHistogram_MouseMove(System.Object eventSender, System.Windows.Forms.MouseEventArgs eventArgs)
		{
			int x = eventArgs.X;
			int y = eventArgs.Y;
			bool mouseOver;
			//Ensure whether Bitmap is not empty
			if (!(_bitmap == null) &&(! _bitmap.IsEmpty))
			{
				//Check if the mouse is over
				mouseOver = (0 <= x) &&(x <= 255) &&(0 <= y) &&(y <= PictureBoxHistogram.Height);
				if (mouseOver)
				{
					NativeMethods.SetCapture(PictureBoxHistogram.Handle.ToInt32());
					System.Globalization.NumberFormatInfo numberFormat = new System.Globalization.NumberFormatInfo();
					LabelLevel.Text = x.ToString(numberFormat);
					LabelCount.Text = Convert.ToString(_histogram[x], numberFormat);
					int sum = 0;
					for (int i = 0; i <= x; i++)
					{
						sum += _histogram[i];
					}
					int totalSum = sum;
					for (int i = x + 1; i <= 255; i++)
					{
						totalSum += _histogram[i];
					}
					LabelPercentile.Text = Convert.ToString(Math.Round(Convert.ToSingle(sum) / Convert.ToSingle(totalSum) * 100.0F, 2), numberFormat);
				}
				else
				{
					NativeMethods.ReleaseCapture();
					LabelLevel.Text = string.Empty;
					LabelCount.Text = string.Empty;
					LabelPercentile.Text = string.Empty;
				}
			}
		}
		
	}
}
