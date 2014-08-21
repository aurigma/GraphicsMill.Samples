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
	public class PixelFormatConverterPropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public PixelFormatConverterPropertyPage()
		{
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Add any initialization after the InitializeComponent() call
			ComboBoxPaletteType.SelectedIndex = 0;
			ComboBoxDitheringType.SelectedIndex = 1;
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
		public System.Windows.Forms.Label LabelPaletteType;
		public System.Windows.Forms.Label LabelDitheringType;
		internal TrackBarText TrackBarTextIntensity;
		internal TrackBarText TrackBarTextColors;
		public System.Windows.Forms.ComboBox ComboBoxPaletteType;
		public System.Windows.Forms.ComboBox ComboBoxDitheringType;
		public System.Windows.Forms.CheckBox CheckBoxDithering;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PixelFormatConverterPropertyPage));
			this.TrackBarTextIntensity = new Main.TrackBarText();
			this.TrackBarTextColors = new Main.TrackBarText();
			this.ComboBoxPaletteType = new System.Windows.Forms.ComboBox();
			this.ComboBoxPaletteType.SelectedIndexChanged += new System.EventHandler(ComboBoxPaletteType_SelectedIndexChanged);
			this.ComboBoxDitheringType = new System.Windows.Forms.ComboBox();
			this.CheckBoxDithering = new System.Windows.Forms.CheckBox();
			this.CheckBoxDithering.CheckedChanged += new System.EventHandler(CheckBoxDithering_CheckedChanged);
			this.LabelPaletteType = new System.Windows.Forms.Label();
			this.LabelDitheringType = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//TrackBarTextIntensity
			//
			this.TrackBarTextIntensity.AccessibleDescription = resources.GetString("TrackBarTextIntensity.AccessibleDescription");
			this.TrackBarTextIntensity.AccessibleName = resources.GetString("TrackBarTextIntensity.AccessibleName");
			this.TrackBarTextIntensity.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextIntensity.Anchor");
			this.TrackBarTextIntensity.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextIntensity.AutoScroll"));
			this.TrackBarTextIntensity.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextIntensity.AutoScrollMargin");
			this.TrackBarTextIntensity.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextIntensity.AutoScrollMinSize");
			this.TrackBarTextIntensity.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextIntensity.BackgroundImage");
			this.TrackBarTextIntensity.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextIntensity.Dock");
			this.TrackBarTextIntensity.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextIntensity.Enabled"));
			this.TrackBarTextIntensity.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextIntensity.Font");
			this.TrackBarTextIntensity.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextIntensity.ImeMode");
			this.TrackBarTextIntensity.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextIntensity.Location");
			this.TrackBarTextIntensity.Maximum = 100;
			this.TrackBarTextIntensity.Minimum = 0;
			this.TrackBarTextIntensity.Name = "TrackBarTextIntensity";
			this.TrackBarTextIntensity.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextIntensity.RightToLeft");
			this.TrackBarTextIntensity.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextIntensity.Size");
			this.TrackBarTextIntensity.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextIntensity.TabIndex"));
			this.TrackBarTextIntensity.Text = resources.GetString("TrackBarTextIntensity.Text");
			this.TrackBarTextIntensity.TickFrequency = 10;
			this.TrackBarTextIntensity.Unit = "%";
			this.TrackBarTextIntensity.Value = 100;
			this.TrackBarTextIntensity.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextIntensity.Visible"));
			//
			//TrackBarTextColors
			//
			this.TrackBarTextColors.AccessibleDescription = resources.GetString("TrackBarTextColors.AccessibleDescription");
			this.TrackBarTextColors.AccessibleName = resources.GetString("TrackBarTextColors.AccessibleName");
			this.TrackBarTextColors.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextColors.Anchor");
			this.TrackBarTextColors.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextColors.AutoScroll"));
			this.TrackBarTextColors.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextColors.AutoScrollMargin");
			this.TrackBarTextColors.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextColors.AutoScrollMinSize");
			this.TrackBarTextColors.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextColors.BackgroundImage");
			this.TrackBarTextColors.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextColors.Dock");
			this.TrackBarTextColors.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextColors.Enabled"));
			this.TrackBarTextColors.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextColors.Font");
			this.TrackBarTextColors.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextColors.ImeMode");
			this.TrackBarTextColors.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextColors.Location");
			this.TrackBarTextColors.Maximum = 256;
			this.TrackBarTextColors.Minimum = 2;
			this.TrackBarTextColors.Name = "TrackBarTextColors";
			this.TrackBarTextColors.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextColors.RightToLeft");
			this.TrackBarTextColors.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextColors.Size");
			this.TrackBarTextColors.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextColors.TabIndex"));
			this.TrackBarTextColors.Text = resources.GetString("TrackBarTextColors.Text");
			this.TrackBarTextColors.TickFrequency = 10;
			this.TrackBarTextColors.Unit = "";
			this.TrackBarTextColors.Value = 256;
			this.TrackBarTextColors.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextColors.Visible"));
			//
			//ComboBoxPaletteType
			//
			this.ComboBoxPaletteType.AccessibleDescription = resources.GetString("ComboBoxPaletteType.AccessibleDescription");
			this.ComboBoxPaletteType.AccessibleName = resources.GetString("ComboBoxPaletteType.AccessibleName");
			this.ComboBoxPaletteType.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("ComboBoxPaletteType.Anchor");
			this.ComboBoxPaletteType.BackColor = System.Drawing.SystemColors.Window;
			this.ComboBoxPaletteType.BackgroundImage = (System.Drawing.Image) resources.GetObject("ComboBoxPaletteType.BackgroundImage");
			this.ComboBoxPaletteType.Cursor = System.Windows.Forms.Cursors.Default;
			this.ComboBoxPaletteType.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("ComboBoxPaletteType.Dock");
			this.ComboBoxPaletteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxPaletteType.Enabled = System.Convert.ToBoolean(resources.GetObject("ComboBoxPaletteType.Enabled"));
			this.ComboBoxPaletteType.Font = (System.Drawing.Font) resources.GetObject("ComboBoxPaletteType.Font");
			this.ComboBoxPaletteType.ForeColor = System.Drawing.SystemColors.WindowText;
			this.ComboBoxPaletteType.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("ComboBoxPaletteType.ImeMode");
			this.ComboBoxPaletteType.IntegralHeight = System.Convert.ToBoolean(resources.GetObject("ComboBoxPaletteType.IntegralHeight"));
			this.ComboBoxPaletteType.ItemHeight = System.Convert.ToInt32(resources.GetObject("ComboBoxPaletteType.ItemHeight"));
			this.ComboBoxPaletteType.Items.AddRange(new object[] { resources.GetString("ComboBoxPaletteType.Items"), resources.GetString("ComboBoxPaletteType.Items1"), resources.GetString("ComboBoxPaletteType.Items2"), resources.GetString("ComboBoxPaletteType.Items3") });
			this.ComboBoxPaletteType.Location = (System.Drawing.Point) resources.GetObject("ComboBoxPaletteType.Location");
			this.ComboBoxPaletteType.MaxDropDownItems = System.Convert.ToInt32(resources.GetObject("ComboBoxPaletteType.MaxDropDownItems"));
			this.ComboBoxPaletteType.MaxLength = System.Convert.ToInt32(resources.GetObject("ComboBoxPaletteType.MaxLength"));
			this.ComboBoxPaletteType.Name = "ComboBoxPaletteType";
			this.ComboBoxPaletteType.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("ComboBoxPaletteType.RightToLeft");
			this.ComboBoxPaletteType.Size = (System.Drawing.Size) resources.GetObject("ComboBoxPaletteType.Size");
			this.ComboBoxPaletteType.TabIndex = System.Convert.ToInt32(resources.GetObject("ComboBoxPaletteType.TabIndex"));
			this.ComboBoxPaletteType.Text = resources.GetString("ComboBoxPaletteType.Text");
			this.ComboBoxPaletteType.Visible = System.Convert.ToBoolean(resources.GetObject("ComboBoxPaletteType.Visible"));
			//
			//ComboBoxDitheringType
			//
			this.ComboBoxDitheringType.AccessibleDescription = resources.GetString("ComboBoxDitheringType.AccessibleDescription");
			this.ComboBoxDitheringType.AccessibleName = resources.GetString("ComboBoxDitheringType.AccessibleName");
			this.ComboBoxDitheringType.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("ComboBoxDitheringType.Anchor");
			this.ComboBoxDitheringType.BackColor = System.Drawing.SystemColors.Window;
			this.ComboBoxDitheringType.BackgroundImage = (System.Drawing.Image) resources.GetObject("ComboBoxDitheringType.BackgroundImage");
			this.ComboBoxDitheringType.Cursor = System.Windows.Forms.Cursors.Default;
			this.ComboBoxDitheringType.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("ComboBoxDitheringType.Dock");
			this.ComboBoxDitheringType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxDitheringType.Enabled = System.Convert.ToBoolean(resources.GetObject("ComboBoxDitheringType.Enabled"));
			this.ComboBoxDitheringType.Font = (System.Drawing.Font) resources.GetObject("ComboBoxDitheringType.Font");
			this.ComboBoxDitheringType.ForeColor = System.Drawing.SystemColors.WindowText;
			this.ComboBoxDitheringType.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("ComboBoxDitheringType.ImeMode");
			this.ComboBoxDitheringType.IntegralHeight = System.Convert.ToBoolean(resources.GetObject("ComboBoxDitheringType.IntegralHeight"));
			this.ComboBoxDitheringType.ItemHeight = System.Convert.ToInt32(resources.GetObject("ComboBoxDitheringType.ItemHeight"));
			this.ComboBoxDitheringType.Items.AddRange(new object[] { resources.GetString("ComboBoxDitheringType.Items"), resources.GetString("ComboBoxDitheringType.Items1"), resources.GetString("ComboBoxDitheringType.Items2"), resources.GetString("ComboBoxDitheringType.Items3"), resources.GetString("ComboBoxDitheringType.Items4"), resources.GetString("ComboBoxDitheringType.Items5"), resources.GetString("ComboBoxDitheringType.Items6"), resources.GetString("ComboBoxDitheringType.Items7"), resources.GetString("ComboBoxDitheringType.Items8"), resources.GetString
			("ComboBoxDitheringType.Items9"), resources.GetString("ComboBoxDitheringType.Items10"), resources.GetString("ComboBoxDitheringType.Items11"), resources.GetString("ComboBoxDitheringType.Items12"), resources.GetString("ComboBoxDitheringType.Items13"), resources.GetString("ComboBoxDitheringType.Items14") }
			);
			this.ComboBoxDitheringType.Location = (System.Drawing.Point) resources.GetObject("ComboBoxDitheringType.Location");
			this.ComboBoxDitheringType.MaxDropDownItems = System.Convert.ToInt32(resources.GetObject("ComboBoxDitheringType.MaxDropDownItems"));
			this.ComboBoxDitheringType.MaxLength = System.Convert.ToInt32(resources.GetObject("ComboBoxDitheringType.MaxLength"));
			this.ComboBoxDitheringType.Name = "ComboBoxDitheringType";
			this.ComboBoxDitheringType.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("ComboBoxDitheringType.RightToLeft");
			this.ComboBoxDitheringType.Size = (System.Drawing.Size) resources.GetObject("ComboBoxDitheringType.Size");
			this.ComboBoxDitheringType.TabIndex = System.Convert.ToInt32(resources.GetObject("ComboBoxDitheringType.TabIndex"));
			this.ComboBoxDitheringType.Text = resources.GetString("ComboBoxDitheringType.Text");
			this.ComboBoxDitheringType.Visible = System.Convert.ToBoolean(resources.GetObject("ComboBoxDitheringType.Visible"));
			//
			//CheckBoxDithering
			//
			this.CheckBoxDithering.AccessibleDescription = resources.GetString("CheckBoxDithering.AccessibleDescription");
			this.CheckBoxDithering.AccessibleName = resources.GetString("CheckBoxDithering.AccessibleName");
			this.CheckBoxDithering.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("CheckBoxDithering.Anchor");
			this.CheckBoxDithering.Appearance = (System.Windows.Forms.Appearance) resources.GetObject("CheckBoxDithering.Appearance");
			this.CheckBoxDithering.BackColor = System.Drawing.SystemColors.Control;
			this.CheckBoxDithering.BackgroundImage = (System.Drawing.Image) resources.GetObject("CheckBoxDithering.BackgroundImage");
			this.CheckBoxDithering.CheckAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxDithering.CheckAlign");
			this.CheckBoxDithering.Checked = true;
			this.CheckBoxDithering.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBoxDithering.Cursor = System.Windows.Forms.Cursors.Default;
			this.CheckBoxDithering.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("CheckBoxDithering.Dock");
			this.CheckBoxDithering.Enabled = System.Convert.ToBoolean(resources.GetObject("CheckBoxDithering.Enabled"));
			this.CheckBoxDithering.FlatStyle = (System.Windows.Forms.FlatStyle) resources.GetObject("CheckBoxDithering.FlatStyle");
			this.CheckBoxDithering.Font = (System.Drawing.Font) resources.GetObject("CheckBoxDithering.Font");
			this.CheckBoxDithering.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CheckBoxDithering.Image = (System.Drawing.Image) resources.GetObject("CheckBoxDithering.Image");
			this.CheckBoxDithering.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxDithering.ImageAlign");
			this.CheckBoxDithering.ImageIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxDithering.ImageIndex"));
			this.CheckBoxDithering.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("CheckBoxDithering.ImeMode");
			this.CheckBoxDithering.Location = (System.Drawing.Point) resources.GetObject("CheckBoxDithering.Location");
			this.CheckBoxDithering.Name = "CheckBoxDithering";
			this.CheckBoxDithering.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("CheckBoxDithering.RightToLeft");
			this.CheckBoxDithering.Size = (System.Drawing.Size) resources.GetObject("CheckBoxDithering.Size");
			this.CheckBoxDithering.TabIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxDithering.TabIndex"));
			this.CheckBoxDithering.Text = resources.GetString("CheckBoxDithering.Text");
			this.CheckBoxDithering.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("CheckBoxDithering.TextAlign");
			this.CheckBoxDithering.Visible = System.Convert.ToBoolean(resources.GetObject("CheckBoxDithering.Visible"));
			//
			//LabelPaletteType
			//
			this.LabelPaletteType.AccessibleDescription = resources.GetString("LabelPaletteType.AccessibleDescription");
			this.LabelPaletteType.AccessibleName = resources.GetString("LabelPaletteType.AccessibleName");
			this.LabelPaletteType.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("LabelPaletteType.Anchor");
			this.LabelPaletteType.AutoSize = System.Convert.ToBoolean(resources.GetObject("LabelPaletteType.AutoSize"));
			this.LabelPaletteType.BackColor = System.Drawing.SystemColors.Control;
			this.LabelPaletteType.Cursor = System.Windows.Forms.Cursors.Default;
			this.LabelPaletteType.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("LabelPaletteType.Dock");
			this.LabelPaletteType.Enabled = System.Convert.ToBoolean(resources.GetObject("LabelPaletteType.Enabled"));
			this.LabelPaletteType.Font = (System.Drawing.Font) resources.GetObject("LabelPaletteType.Font");
			this.LabelPaletteType.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LabelPaletteType.Image = (System.Drawing.Image) resources.GetObject("LabelPaletteType.Image");
			this.LabelPaletteType.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelPaletteType.ImageAlign");
			this.LabelPaletteType.ImageIndex = System.Convert.ToInt32(resources.GetObject("LabelPaletteType.ImageIndex"));
			this.LabelPaletteType.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("LabelPaletteType.ImeMode");
			this.LabelPaletteType.Location = (System.Drawing.Point) resources.GetObject("LabelPaletteType.Location");
			this.LabelPaletteType.Name = "LabelPaletteType";
			this.LabelPaletteType.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("LabelPaletteType.RightToLeft");
			this.LabelPaletteType.Size = (System.Drawing.Size) resources.GetObject("LabelPaletteType.Size");
			this.LabelPaletteType.TabIndex = System.Convert.ToInt32(resources.GetObject("LabelPaletteType.TabIndex"));
			this.LabelPaletteType.Text = resources.GetString("LabelPaletteType.Text");
			this.LabelPaletteType.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelPaletteType.TextAlign");
			this.LabelPaletteType.Visible = System.Convert.ToBoolean(resources.GetObject("LabelPaletteType.Visible"));
			//
			//LabelDitheringType
			//
			this.LabelDitheringType.AccessibleDescription = resources.GetString("LabelDitheringType.AccessibleDescription");
			this.LabelDitheringType.AccessibleName = resources.GetString("LabelDitheringType.AccessibleName");
			this.LabelDitheringType.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("LabelDitheringType.Anchor");
			this.LabelDitheringType.AutoSize = System.Convert.ToBoolean(resources.GetObject("LabelDitheringType.AutoSize"));
			this.LabelDitheringType.BackColor = System.Drawing.SystemColors.Control;
			this.LabelDitheringType.Cursor = System.Windows.Forms.Cursors.Default;
			this.LabelDitheringType.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("LabelDitheringType.Dock");
			this.LabelDitheringType.Enabled = System.Convert.ToBoolean(resources.GetObject("LabelDitheringType.Enabled"));
			this.LabelDitheringType.Font = (System.Drawing.Font) resources.GetObject("LabelDitheringType.Font");
			this.LabelDitheringType.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LabelDitheringType.Image = (System.Drawing.Image) resources.GetObject("LabelDitheringType.Image");
			this.LabelDitheringType.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelDitheringType.ImageAlign");
			this.LabelDitheringType.ImageIndex = System.Convert.ToInt32(resources.GetObject("LabelDitheringType.ImageIndex"));
			this.LabelDitheringType.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("LabelDitheringType.ImeMode");
			this.LabelDitheringType.Location = (System.Drawing.Point) resources.GetObject("LabelDitheringType.Location");
			this.LabelDitheringType.Name = "LabelDitheringType";
			this.LabelDitheringType.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("LabelDitheringType.RightToLeft");
			this.LabelDitheringType.Size = (System.Drawing.Size) resources.GetObject("LabelDitheringType.Size");
			this.LabelDitheringType.TabIndex = System.Convert.ToInt32(resources.GetObject("LabelDitheringType.TabIndex"));
			this.LabelDitheringType.Text = resources.GetString("LabelDitheringType.Text");
			this.LabelDitheringType.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelDitheringType.TextAlign");
			this.LabelDitheringType.Visible = System.Convert.ToBoolean(resources.GetObject("LabelDitheringType.Visible"));
			//
			//PixelFormatConverterPropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.TrackBarTextIntensity);
			this.Controls.Add(this.TrackBarTextColors);
			this.Controls.Add(this.ComboBoxPaletteType);
			this.Controls.Add(this.ComboBoxDitheringType);
			this.Controls.Add(this.CheckBoxDithering);
			this.Controls.Add(this.LabelPaletteType);
			this.Controls.Add(this.LabelDitheringType);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "PixelFormatConverterPropertyPage";
			this.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("$this.RightToLeft");
			this.Size = (System.Drawing.Size) resources.GetObject("$this.Size");
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private Aurigma.GraphicsMill.Bitmap _bitmap;
		private PixelFormat _destinationPixelFormat = PixelFormat.Format8bppIndexed;
		
		public PixelFormat DestinationPixelFormat
		{
			get
			{
				return _destinationPixelFormat;
			}
			set
			{
				_destinationPixelFormat = value;
				if (_destinationPixelFormat == PixelFormat.Format1bppIndexed)
				{
					LabelPaletteType.Enabled = false;
					ComboBoxPaletteType.Enabled = false;
					TrackBarTextColors.Enabled = false;
					TrackBarTextColors.Value = 2;
				}
				else if (_destinationPixelFormat == PixelFormat.Format8bppIndexed)
				{
					LabelPaletteType.Enabled = true;
					ComboBoxPaletteType.Enabled = true;
					TrackBarTextColors.Enabled = true;
					TrackBarTextColors.Value = 256;
					ComboBoxPaletteType.SelectedIndex = 0;
				}
				else
				{
					System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PixelFormatConverterPropertyPage));
					throw (new ArgumentException(resources.GetString("IncorrectPixelFormat"), "Value"));
				}
			}
		}
		
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
		
		public string Title
		{
			get
			{
				return "Image Mode Conversion";
			}
		}
		
		public IBitmapTransform Transform
		{
			get
			{
				DitheringType dithering;
				if (CheckBoxDithering.Checked)
				{
					switch (ComboBoxDitheringType.SelectedIndex)
					{
						case 0: //Original
							
							dithering = DitheringType.Original;
							break;
						case 1: //Floyd Steinberg
							
							dithering = DitheringType.FloydSteinberg;
							break;
						case 2: //Fan
							
							dithering = DitheringType.Fan;
							break;
						case 3: //Jarvis
							
							dithering = DitheringType.Jarvis;
							break;
						case 4: //Stucki
							
							dithering = DitheringType.Stucki;
							break;
						case 5: //Sierra
							
							dithering = DitheringType.Sierra;
							break;
						case 6: //Stephenson
							
							dithering = DitheringType.Stephenson;
							break;
						case 7: //Noise
							
							dithering = DitheringType.Noise;
							break;
						case 8: //Burkes
							
							dithering = DitheringType.Burkes;
							break;
						case 9: //Ordered Spiral 2
							
							dithering = DitheringType.OrderedSpiral2;
							break;
						case 10: //Ordered Spiral 3
							
							dithering = DitheringType.OrderedSpiral3;
							break;
						case 11: //Ordered Spiral 4
							
							dithering = DitheringType.OrderedSpiral4;
							break;
						case 12: //Ordered Bayer 2
							
							dithering = DitheringType.OrderedBayer2;
							break;
						case 13: //Ordered Bayer 3
							
							dithering = DitheringType.OrderedBayer3;
							break;
						case 14: //Ordered Bayer 4
							
							dithering = DitheringType.OrderedBayer4;
							break;
						default:
							
							dithering = DitheringType.None;
							break;
					}
				}
				else
				{
					dithering = DitheringType.None;
				}
				
				var converter = new Aurigma.GraphicsMill.Transforms.ColorConverter();

				if (_destinationPixelFormat == PixelFormat.Format1bppIndexed)
				{
					converter.DestinationPixelFormat = _destinationPixelFormat;
					converter.Palette = new ColorPalette(ColorPaletteType.Bicolor);
					converter.Dithering = dithering;
					converter.DitheringIntensity = Convert.ToSingle(TrackBarTextIntensity.Value) / 100.0F;
				}
				else //_destinationPixelFormat = PixelFormat.Format1bppIndexed
				{					
                    ColorPalette palette = null;

					switch (ComboBoxPaletteType.SelectedIndex)
					{
                        case 0:
                            palette = ColorPalette.Create(this._bitmap, TrackBarTextColors.Value);
                            break;

						case 1: //Web Safe

                            palette = new ColorPalette(ColorPaletteType.WebSafe);
							break;
						case 2: //Windows

                            palette = new ColorPalette(ColorPaletteType.Windows);
							break;
						case 3: //Macintosh

                            palette = new ColorPalette(ColorPaletteType.Mac);
							break;
					}
					converter.DestinationPixelFormat = _destinationPixelFormat;
                    converter.Palette = palette;
					converter.Dithering = dithering;
					converter.DitheringIntensity = Convert.ToSingle(TrackBarTextIntensity.Value) / 100.0F;
				}
				
				return converter;
			}
		}
		
		private void CheckBoxDithering_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			LabelDitheringType.Enabled = CheckBoxDithering.Checked;
			ComboBoxDitheringType.Enabled = CheckBoxDithering.Checked;
			TrackBarTextIntensity.Enabled = CheckBoxDithering.Checked;
		}
		
		private void ComboBoxPaletteType_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (ComboBoxPaletteType.SelectedIndex == 1)
			{
				TrackBarTextColors.Value = Math.Min(TrackBarTextColors.Value, 216);
				TrackBarTextColors.Maximum = 216;
			}
			else
			{
				TrackBarTextColors.Maximum = 256;
			}
		}
	}
}
