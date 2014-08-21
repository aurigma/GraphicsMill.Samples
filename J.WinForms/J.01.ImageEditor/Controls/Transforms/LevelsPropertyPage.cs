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
	public class LevelsPropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
	{

        public class LevelsChannelTransform : Aurigma.GraphicsMill.Transforms.IBitmapTransform
        {
            private Levels _levels;
            private Channel? _channel = null;

            public LevelsChannelTransform(Levels levels, Channel channel)
            {
                _levels = levels;
                _channel = channel;
            }

            public LevelsChannelTransform(Levels levels)
            {
                _levels = levels;
            }


            public Aurigma.GraphicsMill.Bitmap Apply(Aurigma.GraphicsMill.Bitmap bitmap)
            {
                if (_channel.HasValue)
                {
                    var result = new Aurigma.GraphicsMill.Bitmap(bitmap);

                    using (var channel = result.Channels[_channel.Value])
                    using (var adjustedChannel = _levels.Apply(channel))
                    {
                        result.Channels[_channel.Value] = adjustedChannel;

                        return result;
                    }
                }
                else
                {
                    return _levels.Apply(bitmap);
                }
            }
        }		
		
		#region " Windows Form Designer generated code "
		
		public LevelsPropertyPage()
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
		public System.Windows.Forms.ComboBox ComboBoxChannel;
		internal System.Windows.Forms.ImageList ImageList1;
		public System.Windows.Forms.Label LabelChannel;
		public System.Windows.Forms.PictureBox PictureBoxHistogram;
		public System.Windows.Forms.PictureBox PictureBoxGradient;
		internal System.Windows.Forms.TextBox TextBoxShadows;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TextBoxMidtones;
		internal System.Windows.Forms.TextBox TextBoxHighlights;
		internal System.Windows.Forms.Label Label2;
		public System.Windows.Forms.PictureBox PictureBoxInputTrackers;
		public System.Windows.Forms.PictureBox PictureBoxOutputTrackers;
		internal System.Windows.Forms.TextBox TextBoxMaximumLevel;
		internal System.Windows.Forms.TextBox TextBoxMinimumLevel;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(LevelsPropertyPage));
			this.ComboBoxChannel = new System.Windows.Forms.ComboBox();
			this.ComboBoxChannel.SelectedIndexChanged += new System.EventHandler(ComboBoxChannel_SelectedIndexChanged);
			this.LabelChannel = new System.Windows.Forms.Label();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.PictureBoxHistogram = new System.Windows.Forms.PictureBox();
			this.PictureBoxHistogram.Paint += new System.Windows.Forms.PaintEventHandler(PictureBoxHistogram_Paint);
			this.PictureBoxGradient = new System.Windows.Forms.PictureBox();
			this.PictureBoxGradient.Paint += new System.Windows.Forms.PaintEventHandler(PictureBoxGradient_Paint);
			this.TextBoxShadows = new System.Windows.Forms.TextBox();
			this.TextBoxShadows.TextChanged += new System.EventHandler(TextBoxShadows_TextChanged);
			this.TextBoxShadows.Leave += new System.EventHandler(TextBoxShadows_Leave);
			this.Label1 = new System.Windows.Forms.Label();
			this.TextBoxMidtones = new System.Windows.Forms.TextBox();
			this.TextBoxMidtones.TextChanged += new System.EventHandler(TextBoxMidtones_TextChanged);
			this.TextBoxMidtones.Leave += new System.EventHandler(TextBoxMidtones_Leave);
			this.TextBoxHighlights = new System.Windows.Forms.TextBox();
			this.TextBoxHighlights.TextChanged += new System.EventHandler(TextBoxHighlights_TextChanged);
			this.TextBoxHighlights.Leave += new System.EventHandler(TextBoxHighlights_Leave);
			this.TextBoxMaximumLevel = new System.Windows.Forms.TextBox();
			this.TextBoxMaximumLevel.TextChanged += new System.EventHandler(TextBoxMaximumLevel_TextChanged);
			this.TextBoxMaximumLevel.Leave += new System.EventHandler(TextBoxMaximumLevel_Leave);
			this.Label2 = new System.Windows.Forms.Label();
			this.TextBoxMinimumLevel = new System.Windows.Forms.TextBox();
			this.TextBoxMinimumLevel.TextChanged += new System.EventHandler(TextBoxMinimumLevel_TextChanged);
			this.TextBoxMinimumLevel.Leave += new System.EventHandler(TextBoxMinimumLevel_Leave);
			this.PictureBoxInputTrackers = new System.Windows.Forms.PictureBox();
			this.PictureBoxInputTrackers.Paint += new System.Windows.Forms.PaintEventHandler(PictureBoxInputTrackers_Paint);
			this.PictureBoxInputTrackers.MouseDown += new System.Windows.Forms.MouseEventHandler(PictureBoxInputTrackers_MouseDown);
			this.PictureBoxInputTrackers.MouseMove += new System.Windows.Forms.MouseEventHandler(PictureBoxInputTrackers_MouseMove);
			this.PictureBoxInputTrackers.MouseUp += new System.Windows.Forms.MouseEventHandler(PictureBoxInputTrackers_MouseUp);
			this.PictureBoxOutputTrackers = new System.Windows.Forms.PictureBox();
			this.PictureBoxOutputTrackers.Paint += new System.Windows.Forms.PaintEventHandler(PictureBoxOutputTrackers_Paint);
			this.PictureBoxOutputTrackers.MouseDown += new System.Windows.Forms.MouseEventHandler(PictureBoxOutputTrackers_MouseDown);
			this.PictureBoxOutputTrackers.MouseMove += new System.Windows.Forms.MouseEventHandler(PictureBoxOutputTrackers_MouseMove);
			this.PictureBoxOutputTrackers.MouseUp += new System.Windows.Forms.MouseEventHandler(PictureBoxOutputTrackers_MouseUp);
			this.SuspendLayout();
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
			//LabelChannel
			//
			this.LabelChannel.AccessibleDescription = resources.GetString("LabelChannel.AccessibleDescription");
			this.LabelChannel.AccessibleName = resources.GetString("LabelChannel.AccessibleName");
			this.LabelChannel.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("LabelChannel.Anchor");
			this.LabelChannel.AutoSize = System.Convert.ToBoolean(resources.GetObject("LabelChannel.AutoSize"));
			this.LabelChannel.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("LabelChannel.Dock");
			this.LabelChannel.Enabled = System.Convert.ToBoolean(resources.GetObject("LabelChannel.Enabled"));
			this.LabelChannel.Font = (System.Drawing.Font) resources.GetObject("LabelChannel.Font");
			this.LabelChannel.Image = (System.Drawing.Image) resources.GetObject("LabelChannel.Image");
			this.LabelChannel.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelChannel.ImageAlign");
			this.LabelChannel.ImageIndex = System.Convert.ToInt32(resources.GetObject("LabelChannel.ImageIndex"));
			this.LabelChannel.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("LabelChannel.ImeMode");
			this.LabelChannel.Location = (System.Drawing.Point) resources.GetObject("LabelChannel.Location");
			this.LabelChannel.Name = "LabelChannel";
			this.LabelChannel.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("LabelChannel.RightToLeft");
			this.LabelChannel.Size = (System.Drawing.Size) resources.GetObject("LabelChannel.Size");
			this.LabelChannel.TabIndex = System.Convert.ToInt32(resources.GetObject("LabelChannel.TabIndex"));
			this.LabelChannel.Text = resources.GetString("LabelChannel.Text");
			this.LabelChannel.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("LabelChannel.TextAlign");
			this.LabelChannel.Visible = System.Convert.ToBoolean(resources.GetObject("LabelChannel.Visible"));
			//
			//ImageList1
			//
			this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ImageList1.ImageSize = (System.Drawing.Size) resources.GetObject("ImageList1.ImageSize");
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) resources.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
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
			//TextBoxShadows
			//
			this.TextBoxShadows.AccessibleDescription = resources.GetString("TextBoxShadows.AccessibleDescription");
			this.TextBoxShadows.AccessibleName = resources.GetString("TextBoxShadows.AccessibleName");
			this.TextBoxShadows.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TextBoxShadows.Anchor");
			this.TextBoxShadows.AutoSize = System.Convert.ToBoolean(resources.GetObject("TextBoxShadows.AutoSize"));
			this.TextBoxShadows.BackgroundImage = (System.Drawing.Image) resources.GetObject("TextBoxShadows.BackgroundImage");
			this.TextBoxShadows.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TextBoxShadows.Dock");
			this.TextBoxShadows.Enabled = System.Convert.ToBoolean(resources.GetObject("TextBoxShadows.Enabled"));
			this.TextBoxShadows.Font = (System.Drawing.Font) resources.GetObject("TextBoxShadows.Font");
			this.TextBoxShadows.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TextBoxShadows.ImeMode");
			this.TextBoxShadows.Location = (System.Drawing.Point) resources.GetObject("TextBoxShadows.Location");
			this.TextBoxShadows.MaxLength = System.Convert.ToInt32(resources.GetObject("TextBoxShadows.MaxLength"));
			this.TextBoxShadows.Multiline = System.Convert.ToBoolean(resources.GetObject("TextBoxShadows.Multiline"));
			this.TextBoxShadows.Name = "TextBoxShadows";
			this.TextBoxShadows.PasswordChar = System.Convert.ToChar(resources.GetObject("TextBoxShadows.PasswordChar"));
			this.TextBoxShadows.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TextBoxShadows.RightToLeft");
			this.TextBoxShadows.ScrollBars = (System.Windows.Forms.ScrollBars) resources.GetObject("TextBoxShadows.ScrollBars");
			this.TextBoxShadows.Size = (System.Drawing.Size) resources.GetObject("TextBoxShadows.Size");
			this.TextBoxShadows.TabIndex = System.Convert.ToInt32(resources.GetObject("TextBoxShadows.TabIndex"));
			this.TextBoxShadows.Text = resources.GetString("TextBoxShadows.Text");
			this.TextBoxShadows.TextAlign = (System.Windows.Forms.HorizontalAlignment) resources.GetObject("TextBoxShadows.TextAlign");
			this.TextBoxShadows.Visible = System.Convert.ToBoolean(resources.GetObject("TextBoxShadows.Visible"));
			this.TextBoxShadows.WordWrap = System.Convert.ToBoolean(resources.GetObject("TextBoxShadows.WordWrap"));
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
			//TextBoxMidtones
			//
			this.TextBoxMidtones.AccessibleDescription = resources.GetString("TextBoxMidtones.AccessibleDescription");
			this.TextBoxMidtones.AccessibleName = resources.GetString("TextBoxMidtones.AccessibleName");
			this.TextBoxMidtones.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TextBoxMidtones.Anchor");
			this.TextBoxMidtones.AutoSize = System.Convert.ToBoolean(resources.GetObject("TextBoxMidtones.AutoSize"));
			this.TextBoxMidtones.BackgroundImage = (System.Drawing.Image) resources.GetObject("TextBoxMidtones.BackgroundImage");
			this.TextBoxMidtones.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TextBoxMidtones.Dock");
			this.TextBoxMidtones.Enabled = System.Convert.ToBoolean(resources.GetObject("TextBoxMidtones.Enabled"));
			this.TextBoxMidtones.Font = (System.Drawing.Font) resources.GetObject("TextBoxMidtones.Font");
			this.TextBoxMidtones.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TextBoxMidtones.ImeMode");
			this.TextBoxMidtones.Location = (System.Drawing.Point) resources.GetObject("TextBoxMidtones.Location");
			this.TextBoxMidtones.MaxLength = System.Convert.ToInt32(resources.GetObject("TextBoxMidtones.MaxLength"));
			this.TextBoxMidtones.Multiline = System.Convert.ToBoolean(resources.GetObject("TextBoxMidtones.Multiline"));
			this.TextBoxMidtones.Name = "TextBoxMidtones";
			this.TextBoxMidtones.PasswordChar = System.Convert.ToChar(resources.GetObject("TextBoxMidtones.PasswordChar"));
			this.TextBoxMidtones.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TextBoxMidtones.RightToLeft");
			this.TextBoxMidtones.ScrollBars = (System.Windows.Forms.ScrollBars) resources.GetObject("TextBoxMidtones.ScrollBars");
			this.TextBoxMidtones.Size = (System.Drawing.Size) resources.GetObject("TextBoxMidtones.Size");
			this.TextBoxMidtones.TabIndex = System.Convert.ToInt32(resources.GetObject("TextBoxMidtones.TabIndex"));
			this.TextBoxMidtones.Text = resources.GetString("TextBoxMidtones.Text");
			this.TextBoxMidtones.TextAlign = (System.Windows.Forms.HorizontalAlignment) resources.GetObject("TextBoxMidtones.TextAlign");
			this.TextBoxMidtones.Visible = System.Convert.ToBoolean(resources.GetObject("TextBoxMidtones.Visible"));
			this.TextBoxMidtones.WordWrap = System.Convert.ToBoolean(resources.GetObject("TextBoxMidtones.WordWrap"));
			//
			//TextBoxHighlights
			//
			this.TextBoxHighlights.AccessibleDescription = resources.GetString("TextBoxHighlights.AccessibleDescription");
			this.TextBoxHighlights.AccessibleName = resources.GetString("TextBoxHighlights.AccessibleName");
			this.TextBoxHighlights.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TextBoxHighlights.Anchor");
			this.TextBoxHighlights.AutoSize = System.Convert.ToBoolean(resources.GetObject("TextBoxHighlights.AutoSize"));
			this.TextBoxHighlights.BackgroundImage = (System.Drawing.Image) resources.GetObject("TextBoxHighlights.BackgroundImage");
			this.TextBoxHighlights.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TextBoxHighlights.Dock");
			this.TextBoxHighlights.Enabled = System.Convert.ToBoolean(resources.GetObject("TextBoxHighlights.Enabled"));
			this.TextBoxHighlights.Font = (System.Drawing.Font) resources.GetObject("TextBoxHighlights.Font");
			this.TextBoxHighlights.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TextBoxHighlights.ImeMode");
			this.TextBoxHighlights.Location = (System.Drawing.Point) resources.GetObject("TextBoxHighlights.Location");
			this.TextBoxHighlights.MaxLength = System.Convert.ToInt32(resources.GetObject("TextBoxHighlights.MaxLength"));
			this.TextBoxHighlights.Multiline = System.Convert.ToBoolean(resources.GetObject("TextBoxHighlights.Multiline"));
			this.TextBoxHighlights.Name = "TextBoxHighlights";
			this.TextBoxHighlights.PasswordChar = System.Convert.ToChar(resources.GetObject("TextBoxHighlights.PasswordChar"));
			this.TextBoxHighlights.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TextBoxHighlights.RightToLeft");
			this.TextBoxHighlights.ScrollBars = (System.Windows.Forms.ScrollBars) resources.GetObject("TextBoxHighlights.ScrollBars");
			this.TextBoxHighlights.Size = (System.Drawing.Size) resources.GetObject("TextBoxHighlights.Size");
			this.TextBoxHighlights.TabIndex = System.Convert.ToInt32(resources.GetObject("TextBoxHighlights.TabIndex"));
			this.TextBoxHighlights.Text = resources.GetString("TextBoxHighlights.Text");
			this.TextBoxHighlights.TextAlign = (System.Windows.Forms.HorizontalAlignment) resources.GetObject("TextBoxHighlights.TextAlign");
			this.TextBoxHighlights.Visible = System.Convert.ToBoolean(resources.GetObject("TextBoxHighlights.Visible"));
			this.TextBoxHighlights.WordWrap = System.Convert.ToBoolean(resources.GetObject("TextBoxHighlights.WordWrap"));
			//
			//TextBoxMaximumLevel
			//
			this.TextBoxMaximumLevel.AccessibleDescription = resources.GetString("TextBoxMaximumLevel.AccessibleDescription");
			this.TextBoxMaximumLevel.AccessibleName = resources.GetString("TextBoxMaximumLevel.AccessibleName");
			this.TextBoxMaximumLevel.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TextBoxMaximumLevel.Anchor");
			this.TextBoxMaximumLevel.AutoSize = System.Convert.ToBoolean(resources.GetObject("TextBoxMaximumLevel.AutoSize"));
			this.TextBoxMaximumLevel.BackgroundImage = (System.Drawing.Image) resources.GetObject("TextBoxMaximumLevel.BackgroundImage");
			this.TextBoxMaximumLevel.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TextBoxMaximumLevel.Dock");
			this.TextBoxMaximumLevel.Enabled = System.Convert.ToBoolean(resources.GetObject("TextBoxMaximumLevel.Enabled"));
			this.TextBoxMaximumLevel.Font = (System.Drawing.Font) resources.GetObject("TextBoxMaximumLevel.Font");
			this.TextBoxMaximumLevel.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TextBoxMaximumLevel.ImeMode");
			this.TextBoxMaximumLevel.Location = (System.Drawing.Point) resources.GetObject("TextBoxMaximumLevel.Location");
			this.TextBoxMaximumLevel.MaxLength = System.Convert.ToInt32(resources.GetObject("TextBoxMaximumLevel.MaxLength"));
			this.TextBoxMaximumLevel.Multiline = System.Convert.ToBoolean(resources.GetObject("TextBoxMaximumLevel.Multiline"));
			this.TextBoxMaximumLevel.Name = "TextBoxMaximumLevel";
			this.TextBoxMaximumLevel.PasswordChar = System.Convert.ToChar(resources.GetObject("TextBoxMaximumLevel.PasswordChar"));
			this.TextBoxMaximumLevel.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TextBoxMaximumLevel.RightToLeft");
			this.TextBoxMaximumLevel.ScrollBars = (System.Windows.Forms.ScrollBars) resources.GetObject("TextBoxMaximumLevel.ScrollBars");
			this.TextBoxMaximumLevel.Size = (System.Drawing.Size) resources.GetObject("TextBoxMaximumLevel.Size");
			this.TextBoxMaximumLevel.TabIndex = System.Convert.ToInt32(resources.GetObject("TextBoxMaximumLevel.TabIndex"));
			this.TextBoxMaximumLevel.Text = resources.GetString("TextBoxMaximumLevel.Text");
			this.TextBoxMaximumLevel.TextAlign = (System.Windows.Forms.HorizontalAlignment) resources.GetObject("TextBoxMaximumLevel.TextAlign");
			this.TextBoxMaximumLevel.Visible = System.Convert.ToBoolean(resources.GetObject("TextBoxMaximumLevel.Visible"));
			this.TextBoxMaximumLevel.WordWrap = System.Convert.ToBoolean(resources.GetObject("TextBoxMaximumLevel.WordWrap"));
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
			//TextBoxMinimumLevel
			//
			this.TextBoxMinimumLevel.AccessibleDescription = resources.GetString("TextBoxMinimumLevel.AccessibleDescription");
			this.TextBoxMinimumLevel.AccessibleName = resources.GetString("TextBoxMinimumLevel.AccessibleName");
			this.TextBoxMinimumLevel.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TextBoxMinimumLevel.Anchor");
			this.TextBoxMinimumLevel.AutoSize = System.Convert.ToBoolean(resources.GetObject("TextBoxMinimumLevel.AutoSize"));
			this.TextBoxMinimumLevel.BackgroundImage = (System.Drawing.Image) resources.GetObject("TextBoxMinimumLevel.BackgroundImage");
			this.TextBoxMinimumLevel.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TextBoxMinimumLevel.Dock");
			this.TextBoxMinimumLevel.Enabled = System.Convert.ToBoolean(resources.GetObject("TextBoxMinimumLevel.Enabled"));
			this.TextBoxMinimumLevel.Font = (System.Drawing.Font) resources.GetObject("TextBoxMinimumLevel.Font");
			this.TextBoxMinimumLevel.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TextBoxMinimumLevel.ImeMode");
			this.TextBoxMinimumLevel.Location = (System.Drawing.Point) resources.GetObject("TextBoxMinimumLevel.Location");
			this.TextBoxMinimumLevel.MaxLength = System.Convert.ToInt32(resources.GetObject("TextBoxMinimumLevel.MaxLength"));
			this.TextBoxMinimumLevel.Multiline = System.Convert.ToBoolean(resources.GetObject("TextBoxMinimumLevel.Multiline"));
			this.TextBoxMinimumLevel.Name = "TextBoxMinimumLevel";
			this.TextBoxMinimumLevel.PasswordChar = System.Convert.ToChar(resources.GetObject("TextBoxMinimumLevel.PasswordChar"));
			this.TextBoxMinimumLevel.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TextBoxMinimumLevel.RightToLeft");
			this.TextBoxMinimumLevel.ScrollBars = (System.Windows.Forms.ScrollBars) resources.GetObject("TextBoxMinimumLevel.ScrollBars");
			this.TextBoxMinimumLevel.Size = (System.Drawing.Size) resources.GetObject("TextBoxMinimumLevel.Size");
			this.TextBoxMinimumLevel.TabIndex = System.Convert.ToInt32(resources.GetObject("TextBoxMinimumLevel.TabIndex"));
			this.TextBoxMinimumLevel.Text = resources.GetString("TextBoxMinimumLevel.Text");
			this.TextBoxMinimumLevel.TextAlign = (System.Windows.Forms.HorizontalAlignment) resources.GetObject("TextBoxMinimumLevel.TextAlign");
			this.TextBoxMinimumLevel.Visible = System.Convert.ToBoolean(resources.GetObject("TextBoxMinimumLevel.Visible"));
			this.TextBoxMinimumLevel.WordWrap = System.Convert.ToBoolean(resources.GetObject("TextBoxMinimumLevel.WordWrap"));
			//
			//PictureBoxInputTrackers
			//
			this.PictureBoxInputTrackers.AccessibleDescription = resources.GetString("PictureBoxInputTrackers.AccessibleDescription");
			this.PictureBoxInputTrackers.AccessibleName = resources.GetString("PictureBoxInputTrackers.AccessibleName");
			this.PictureBoxInputTrackers.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("PictureBoxInputTrackers.Anchor");
			this.PictureBoxInputTrackers.BackgroundImage = (System.Drawing.Image) resources.GetObject("PictureBoxInputTrackers.BackgroundImage");
			this.PictureBoxInputTrackers.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("PictureBoxInputTrackers.Dock");
			this.PictureBoxInputTrackers.Enabled = System.Convert.ToBoolean(resources.GetObject("PictureBoxInputTrackers.Enabled"));
			this.PictureBoxInputTrackers.Font = (System.Drawing.Font) resources.GetObject("PictureBoxInputTrackers.Font");
			this.PictureBoxInputTrackers.Image = (System.Drawing.Image) resources.GetObject("PictureBoxInputTrackers.Image");
			this.PictureBoxInputTrackers.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("PictureBoxInputTrackers.ImeMode");
			this.PictureBoxInputTrackers.Location = (System.Drawing.Point) resources.GetObject("PictureBoxInputTrackers.Location");
			this.PictureBoxInputTrackers.Name = "PictureBoxInputTrackers";
			this.PictureBoxInputTrackers.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("PictureBoxInputTrackers.RightToLeft");
			this.PictureBoxInputTrackers.Size = (System.Drawing.Size) resources.GetObject("PictureBoxInputTrackers.Size");
			this.PictureBoxInputTrackers.SizeMode = (System.Windows.Forms.PictureBoxSizeMode) resources.GetObject("PictureBoxInputTrackers.SizeMode");
			this.PictureBoxInputTrackers.TabIndex = System.Convert.ToInt32(resources.GetObject("PictureBoxInputTrackers.TabIndex"));
			this.PictureBoxInputTrackers.TabStop = false;
			this.PictureBoxInputTrackers.Text = resources.GetString("PictureBoxInputTrackers.Text");
			this.PictureBoxInputTrackers.Visible = System.Convert.ToBoolean(resources.GetObject("PictureBoxInputTrackers.Visible"));
			//
			//PictureBoxOutputTrackers
			//
			this.PictureBoxOutputTrackers.AccessibleDescription = resources.GetString("PictureBoxOutputTrackers.AccessibleDescription");
			this.PictureBoxOutputTrackers.AccessibleName = resources.GetString("PictureBoxOutputTrackers.AccessibleName");
			this.PictureBoxOutputTrackers.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("PictureBoxOutputTrackers.Anchor");
			this.PictureBoxOutputTrackers.BackgroundImage = (System.Drawing.Image) resources.GetObject("PictureBoxOutputTrackers.BackgroundImage");
			this.PictureBoxOutputTrackers.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("PictureBoxOutputTrackers.Dock");
			this.PictureBoxOutputTrackers.Enabled = System.Convert.ToBoolean(resources.GetObject("PictureBoxOutputTrackers.Enabled"));
			this.PictureBoxOutputTrackers.Font = (System.Drawing.Font) resources.GetObject("PictureBoxOutputTrackers.Font");
			this.PictureBoxOutputTrackers.Image = (System.Drawing.Image) resources.GetObject("PictureBoxOutputTrackers.Image");
			this.PictureBoxOutputTrackers.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("PictureBoxOutputTrackers.ImeMode");
			this.PictureBoxOutputTrackers.Location = (System.Drawing.Point) resources.GetObject("PictureBoxOutputTrackers.Location");
			this.PictureBoxOutputTrackers.Name = "PictureBoxOutputTrackers";
			this.PictureBoxOutputTrackers.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("PictureBoxOutputTrackers.RightToLeft");
			this.PictureBoxOutputTrackers.Size = (System.Drawing.Size) resources.GetObject("PictureBoxOutputTrackers.Size");
			this.PictureBoxOutputTrackers.SizeMode = (System.Windows.Forms.PictureBoxSizeMode) resources.GetObject("PictureBoxOutputTrackers.SizeMode");
			this.PictureBoxOutputTrackers.TabIndex = System.Convert.ToInt32(resources.GetObject("PictureBoxOutputTrackers.TabIndex"));
			this.PictureBoxOutputTrackers.TabStop = false;
			this.PictureBoxOutputTrackers.Text = resources.GetString("PictureBoxOutputTrackers.Text");
			this.PictureBoxOutputTrackers.Visible = System.Convert.ToBoolean(resources.GetObject("PictureBoxOutputTrackers.Visible"));
			//
			//LevelsPropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.PictureBoxOutputTrackers);
			this.Controls.Add(this.PictureBoxInputTrackers);
			this.Controls.Add(this.TextBoxMaximumLevel);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.TextBoxMinimumLevel);
			this.Controls.Add(this.TextBoxHighlights);
			this.Controls.Add(this.TextBoxMidtones);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TextBoxShadows);
			this.Controls.Add(this.PictureBoxHistogram);
			this.Controls.Add(this.PictureBoxGradient);
			this.Controls.Add(this.ComboBoxChannel);
			this.Controls.Add(this.LabelChannel);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "LevelsPropertyPage";
			this.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("$this.RightToLeft");
			this.Size = (System.Drawing.Size) resources.GetObject("$this.Size");
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private Aurigma.GraphicsMill.Bitmap _bitmap;
		private Histogram _histogram;
		private System.Drawing.Color histColor;
		
		private int shadowsValue;
		private float midtonesValue = 1.0F;
		private int highlightsValue = 255;
		private int minimumLevel;
		private int maximumLevel = 255;
		
		private enum TrackerType
		{
			None = 0,
			Minimum,
			Middle,
			Maximum
		}
		
		private TrackerType inputTracker = TrackerType.None;
		private TrackerType outputTracker = TrackerType.None;
		
		private const int sliderWidth = 7;
		private const int epsilon = 3;
		
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
		
		public IBitmapTransform Transform
		{
			get
			{

                Levels levels = new Levels();
                
                levels.Auto = false;
                levels.MinimumLevel = Convert.ToSingle(minimumLevel) / 255.0F;
                levels.MaximumLevel = Convert.ToSingle(maximumLevel) / 255.0F;
                levels.Shadows = Convert.ToSingle(shadowsValue) / 255.0F;
                levels.Midtones = midtonesValue;
                levels.Highlights = Convert.ToSingle(highlightsValue) / 255.0F;

                try
                {
                    Channel channel = (Channel)Enum.Parse(typeof(Channel), ComboBoxChannel.Text);
                    return new LevelsChannelTransform(levels, channel);
                }
                catch (System.ArgumentException)
                {
                    return new LevelsChannelTransform(levels);
                }
            }
		}

		public string Title
		{
			get
			{
				return "Levels";
			}
		}
		
		private void ShowChannels()
		{
			if ((_bitmap != null) &&(! _bitmap.IsEmpty))
			{
				ComboBoxChannel.Items.Clear();
				if (_bitmap.PixelFormat.IsRgb)
				{
					ComboBoxChannel.Items.AddRange(new string[] { "All", "Red", "Green", "Blue" });
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

		private void UpdateHistogram()
		{
			ShowChannels();
			RefreshHistogram();
			PictureBoxHistogram.Refresh();
			PictureBoxGradient.Refresh();
		}
		
		private void RefreshHistogram()
		{
			if (_bitmap != null && !_bitmap.IsEmpty)
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
		
		private static void DrawTracker(Graphics _graphics, TrackerType _type, int position)
		{
			System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Black, 1);
			
            _graphics.DrawLine(pen, sliderWidth + position, 1, position, sliderWidth + 1);
			_graphics.DrawLine(pen, sliderWidth + position, 1, sliderWidth + sliderWidth + position, sliderWidth + 1);
			_graphics.DrawLine(pen, position, sliderWidth + 1, sliderWidth + sliderWidth + position, sliderWidth + 1);

			if (_type == TrackerType.Middle)
			{
				for (int i = 0; i <= sliderWidth * 2; i += 2)
				{
					_graphics.DrawLine(pen, sliderWidth + position + i / 2, 1 + i / 2, position + i, sliderWidth + 1);
				}
			}
			else if (_type == TrackerType.Minimum)
			{
				for (int i = 1; i <= sliderWidth; i++)
				{
					_graphics.DrawLine(pen, sliderWidth + position - i, 1 + i, sliderWidth + position + i, 1 + i);
				}
			}
		}
		
		//Input trackers
		private void PictureBoxInputTrackers_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawTracker(e.Graphics, TrackerType.Minimum, shadowsValue);
			int midtonesPosition = Convert.ToInt32(Math.Round(shadowsValue +(highlightsValue - shadowsValue) / 2 *(1 - Math.Log10(midtonesValue))));
			DrawTracker(e.Graphics, TrackerType.Middle, midtonesPosition);
			DrawTracker(e.Graphics, TrackerType.Maximum, highlightsValue);
		}
		
		private void PictureBoxInputTrackers_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int x = e.X - 7;
			if (Math.Abs(x - shadowsValue) <= epsilon)
			{
				inputTracker = TrackerType.Minimum;
			}
			else if (Math.Abs(x - highlightsValue) <= epsilon)
			{
				inputTracker = TrackerType.Maximum;
			}
			else
			{
				int midtonesPosition = Convert.ToInt32(Math.Round(shadowsValue +(highlightsValue - shadowsValue) / 2 *(1 - Math.Log10(midtonesValue))));
				if (Math.Abs(x - midtonesPosition) <= epsilon)
				{
					inputTracker = TrackerType.Middle;
				}
			}
			
		}
		
		private void PictureBoxInputTrackers_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (inputTracker != TrackerType.None)
			{
				int x = e.X - 7;
				if (inputTracker == TrackerType.Minimum)
				{
					shadowsValue = Math.Min(Math.Max(x, 0), highlightsValue - 2);
					TextBoxShadows.Text = shadowsValue.ToString(new System.Globalization.NumberFormatInfo());
				}
				else if (inputTracker == TrackerType.Middle)
				{
					double power = System.Convert.ToDouble(shadowsValue - x) / System.Convert.ToDouble(highlightsValue - shadowsValue) * 2.0 + 1.0;
					double maxValue = Math.Max(Math.Round(Math.Pow(10F, power), 2), 0.1F);
					midtonesValue = Convert.ToSingle(Math.Min(maxValue, 10));
					TextBoxMidtones.Text = midtonesValue.ToString(new System.Globalization.NumberFormatInfo());
				}
				else if (inputTracker == TrackerType.Maximum)
				{
					highlightsValue = Math.Max(Math.Min(x, 255), shadowsValue + 2);
					TextBoxHighlights.Text = highlightsValue.ToString(new System.Globalization.NumberFormatInfo());
				}
				PictureBoxInputTrackers.Refresh();
			}
		}
		
		private void PictureBoxInputTrackers_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			inputTracker = TrackerType.None;
		}
		
		private void TextBoxShadows_TextChanged(object sender, System.EventArgs e)
		{
			if (TextBoxShadows.Focused)
			{
				try
				{
					shadowsValue = Math.Min(Math.Max(int.Parse(TextBoxShadows.Text, new System.Globalization.NumberFormatInfo()), 0), highlightsValue - 2);
					PictureBoxInputTrackers.Refresh();
				}
				catch (FormatException)
				{
				}
			}
		}
		
		private void TextBoxShadows_Leave(object sender, System.EventArgs e)
		{
			TextBoxShadows.Text = shadowsValue.ToString(new System.Globalization.NumberFormatInfo());
		}
		
		private void TextBoxMidtones_TextChanged(object sender, System.EventArgs e)
		{
			if (TextBoxMidtones.Focused)
			{
				try
				{
					midtonesValue = Convert.ToSingle(Math.Round(Math.Min(Math.Max(float.Parse(TextBoxMidtones.Text, new System.Globalization.NumberFormatInfo()), 0.1F), 10.0F), 2));
					PictureBoxInputTrackers.Refresh();
				}
				catch (FormatException)
				{
				}
			}
		}
		
		private void TextBoxMidtones_Leave(object sender, System.EventArgs e)
		{
			TextBoxMidtones.Text = midtonesValue.ToString(new System.Globalization.NumberFormatInfo());
		}
		
		private void TextBoxHighlights_TextChanged(object sender, System.EventArgs e)
		{
			if (TextBoxHighlights.Focused)
			{
				try
				{
					highlightsValue = Math.Max(Math.Min(int.Parse(TextBoxHighlights.Text, new System.Globalization.NumberFormatInfo()), 255), shadowsValue + 2);
					PictureBoxInputTrackers.Refresh();
				}
				catch (FormatException)
				{
				}
			}
		}
		
		private void TextBoxHighlights_Leave(object sender, System.EventArgs e)
		{
			TextBoxHighlights.Text = highlightsValue.ToString(new System.Globalization.NumberFormatInfo());
		}
		
		//Output trackes
		private void PictureBoxOutputTrackers_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawTracker(e.Graphics, TrackerType.Minimum, minimumLevel);
			DrawTracker(e.Graphics, TrackerType.Maximum, maximumLevel);
		}
		
		private void PictureBoxOutputTrackers_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int x = e.X - 7;
			if (Math.Abs(x - minimumLevel) <= epsilon)
			{
				outputTracker = TrackerType.Minimum;
			}
			else if (Math.Abs(x - maximumLevel) <= epsilon)
			{
				outputTracker = TrackerType.Maximum;
			}
		}
		
		private void PictureBoxOutputTrackers_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (outputTracker != TrackerType.None)
			{
				int x = e.X - 7;
				if (outputTracker == TrackerType.Minimum)
				{
					minimumLevel = Math.Min(Math.Max(x, 0), maximumLevel - 2);
					TextBoxMinimumLevel.Text = minimumLevel.ToString(new System.Globalization.NumberFormatInfo());
				}
				else if (outputTracker == TrackerType.Maximum)
				{
					maximumLevel = Math.Max(Math.Min(x, 255), minimumLevel + 2);
					TextBoxMaximumLevel.Text = maximumLevel.ToString(new System.Globalization.NumberFormatInfo());
				}
				PictureBoxOutputTrackers.Refresh();
			}
		}
		
		private void PictureBoxOutputTrackers_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			outputTracker = TrackerType.None;
		}
		
		private void TextBoxMinimumLevel_TextChanged(object sender, System.EventArgs e)
		{
			if (TextBoxMinimumLevel.Focused)
			{
				try
				{
					minimumLevel = Math.Min(Math.Max(int.Parse(TextBoxMinimumLevel.Text, new System.Globalization.NumberFormatInfo()), 0), maximumLevel - 2);
					PictureBoxOutputTrackers.Refresh();
				}
				catch (FormatException)
				{
				}
			}
		}
		
		private void TextBoxMinimumLevel_Leave(object sender, System.EventArgs e)
		{
			TextBoxMinimumLevel.Text = minimumLevel.ToString(new System.Globalization.NumberFormatInfo());
		}
		
		private void TextBoxMaximumLevel_TextChanged(object sender, System.EventArgs e)
		{
			if (TextBoxMaximumLevel.Focused)
			{
				try
				{
					maximumLevel = Math.Max(Math.Min(int.Parse(TextBoxMaximumLevel.Text, new System.Globalization.NumberFormatInfo()), 255), minimumLevel + 2);
					PictureBoxOutputTrackers.Refresh();
				}
				catch (FormatException)
				{
				}
			}
		}
		
		private void TextBoxMaximumLevel_Leave(object sender, System.EventArgs e)
		{
			TextBoxMaximumLevel.Text = maximumLevel.ToString(new System.Globalization.NumberFormatInfo());
		}
	}
	
}
