using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Aurigma.GraphicsMill.Transforms;

namespace Main
{
    public class CurvesPropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
    {
        #region " Windows Form Designer generated code "

        public CurvesPropertyPage()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call
            _lut.SetPoint(0, 0);
            _lut.SetPoint(100, 100);
            _lut.InterpolationMode = LutInterpolationMode.Linear;
        }

        // UserControl overrides dispose to clean up the component list.
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

        // Required by the Windows Form Designer
        private System.ComponentModel.Container components = null;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        internal System.Windows.Forms.PictureBox PictureBox1;

        public System.Windows.Forms.ComboBox ComboBoxChannel;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBoxOutput;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.TextBox TextBoxInput;
        internal System.Windows.Forms.PictureBox PictureBoxHorizontalGradient;
        internal System.Windows.Forms.PictureBox PictureBoxVerticalGradient;
        internal System.Windows.Forms.Button ButtonSmooth;
        internal System.Windows.Forms.RadioButton RadioButtonCurve;
        internal System.Windows.Forms.RadioButton RadioButtonPen;
        public System.Windows.Forms.Label LabelChannel;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CurvesPropertyPage));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(PictureBox1_Paint);
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(PictureBox1_MouseDown);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(PictureBox1_MouseMove);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(PictureBox1_MouseUp);
            this.PictureBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(PictureBox1_KeyDown);
            this.ComboBoxChannel = new System.Windows.Forms.ComboBox();
            this.LabelChannel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.TextBoxOutput = new System.Windows.Forms.TextBox();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PictureBoxHorizontalGradient = new System.Windows.Forms.PictureBox();
            this.PictureBoxHorizontalGradient.Paint += new System.Windows.Forms.PaintEventHandler(PictureBoxHorizontalGradient_Paint);
            this.PictureBoxHorizontalGradient.MouseDown += new System.Windows.Forms.MouseEventHandler(PictureBoxHorizontalGradient_MouseDown);
            this.PictureBoxVerticalGradient = new System.Windows.Forms.PictureBox();
            this.PictureBoxVerticalGradient.Paint += new System.Windows.Forms.PaintEventHandler(PictureBoxVerticalGradient_Paint);
            this.ButtonSmooth = new System.Windows.Forms.Button();
            this.ButtonSmooth.Click += new System.EventHandler(ButtonSmooth_Click);
            this.RadioButtonCurve = new System.Windows.Forms.RadioButton();
            this.RadioButtonCurve.CheckedChanged += new System.EventHandler(RadioButtonCurve_CheckedChanged);
            this.RadioButtonPen = new System.Windows.Forms.RadioButton();
            this.RadioButtonPen.CheckedChanged += new System.EventHandler(RadioButtonPen_CheckedChanged);
            this.SuspendLayout();
            //
            // PictureBox1
            //
            this.PictureBox1.AccessibleDescription = resources.GetString("PictureBox1.AccessibleDescription");
            this.PictureBox1.AccessibleName = resources.GetString("PictureBox1.AccessibleName");
            this.PictureBox1.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("PictureBox1.Anchor");
            this.PictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("PictureBox1.BackgroundImage");
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox1.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("PictureBox1.Dock");
            this.PictureBox1.Enabled = System.Convert.ToBoolean(resources.GetObject("PictureBox1.Enabled"));
            this.PictureBox1.Font = (System.Drawing.Font)resources.GetObject("PictureBox1.Font");
            this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
            this.PictureBox1.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("PictureBox1.ImeMode");
            this.PictureBox1.Location = (System.Drawing.Point)resources.GetObject("PictureBox1.Location");
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("PictureBox1.RightToLeft");
            this.PictureBox1.Size = (System.Drawing.Size)resources.GetObject("PictureBox1.Size");
            this.PictureBox1.SizeMode = (System.Windows.Forms.PictureBoxSizeMode)resources.GetObject("PictureBox1.SizeMode");
            this.PictureBox1.TabIndex = System.Convert.ToInt32(resources.GetObject("PictureBox1.TabIndex"));
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Text = resources.GetString("PictureBox1.Text");
            this.PictureBox1.Visible = System.Convert.ToBoolean(resources.GetObject("PictureBox1.Visible"));
            //
            // ComboBoxChannel
            //
            this.ComboBoxChannel.AccessibleDescription = resources.GetString("ComboBoxChannel.AccessibleDescription");
            this.ComboBoxChannel.AccessibleName = resources.GetString("ComboBoxChannel.AccessibleName");
            this.ComboBoxChannel.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("ComboBoxChannel.Anchor");
            this.ComboBoxChannel.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBoxChannel.BackgroundImage = (System.Drawing.Image)resources.GetObject("ComboBoxChannel.BackgroundImage");
            this.ComboBoxChannel.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("ComboBoxChannel.Dock");
            this.ComboBoxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxChannel.Enabled = System.Convert.ToBoolean(resources.GetObject("ComboBoxChannel.Enabled"));
            this.ComboBoxChannel.Font = (System.Drawing.Font)resources.GetObject("ComboBoxChannel.Font");
            this.ComboBoxChannel.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("ComboBoxChannel.ImeMode");
            this.ComboBoxChannel.IntegralHeight = System.Convert.ToBoolean(resources.GetObject("ComboBoxChannel.IntegralHeight"));
            this.ComboBoxChannel.ItemHeight = System.Convert.ToInt32(resources.GetObject("ComboBoxChannel.ItemHeight"));
            this.ComboBoxChannel.Items.AddRange(new object[] { resources.GetString("ComboBoxChannel.Items"), resources.GetString("ComboBoxChannel.Items1"), resources.GetString("ComboBoxChannel.Items2"), resources.GetString("ComboBoxChannel.Items3") });
            this.ComboBoxChannel.Location = (System.Drawing.Point)resources.GetObject("ComboBoxChannel.Location");
            this.ComboBoxChannel.MaxDropDownItems = System.Convert.ToInt32(resources.GetObject("ComboBoxChannel.MaxDropDownItems"));
            this.ComboBoxChannel.MaxLength = System.Convert.ToInt32(resources.GetObject("ComboBoxChannel.MaxLength"));
            this.ComboBoxChannel.Name = "ComboBoxChannel";
            this.ComboBoxChannel.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("ComboBoxChannel.RightToLeft");
            this.ComboBoxChannel.Size = (System.Drawing.Size)resources.GetObject("ComboBoxChannel.Size");
            this.ComboBoxChannel.TabIndex = System.Convert.ToInt32(resources.GetObject("ComboBoxChannel.TabIndex"));
            this.ComboBoxChannel.Text = resources.GetString("ComboBoxChannel.Text");
            this.ComboBoxChannel.Visible = System.Convert.ToBoolean(resources.GetObject("ComboBoxChannel.Visible"));
            //
            // LabelChannel
            //
            this.LabelChannel.AccessibleDescription = resources.GetString("LabelChannel.AccessibleDescription");
            this.LabelChannel.AccessibleName = resources.GetString("LabelChannel.AccessibleName");
            this.LabelChannel.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("LabelChannel.Anchor");
            this.LabelChannel.AutoSize = System.Convert.ToBoolean(resources.GetObject("LabelChannel.AutoSize"));
            this.LabelChannel.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("LabelChannel.Dock");
            this.LabelChannel.Enabled = System.Convert.ToBoolean(resources.GetObject("LabelChannel.Enabled"));
            this.LabelChannel.Font = (System.Drawing.Font)resources.GetObject("LabelChannel.Font");
            this.LabelChannel.Image = (System.Drawing.Image)resources.GetObject("LabelChannel.Image");
            this.LabelChannel.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("LabelChannel.ImageAlign");
            this.LabelChannel.ImageIndex = System.Convert.ToInt32(resources.GetObject("LabelChannel.ImageIndex"));
            this.LabelChannel.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("LabelChannel.ImeMode");
            this.LabelChannel.Location = (System.Drawing.Point)resources.GetObject("LabelChannel.Location");
            this.LabelChannel.Name = "LabelChannel";
            this.LabelChannel.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("LabelChannel.RightToLeft");
            this.LabelChannel.Size = (System.Drawing.Size)resources.GetObject("LabelChannel.Size");
            this.LabelChannel.TabIndex = System.Convert.ToInt32(resources.GetObject("LabelChannel.TabIndex"));
            this.LabelChannel.Text = resources.GetString("LabelChannel.Text");
            this.LabelChannel.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("LabelChannel.TextAlign");
            this.LabelChannel.Visible = System.Convert.ToBoolean(resources.GetObject("LabelChannel.Visible"));
            //
            // Label2
            //
            this.Label2.AccessibleDescription = resources.GetString("Label2.AccessibleDescription");
            this.Label2.AccessibleName = resources.GetString("Label2.AccessibleName");
            this.Label2.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("Label2.Anchor");
            this.Label2.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label2.AutoSize"));
            this.Label2.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("Label2.Dock");
            this.Label2.Enabled = System.Convert.ToBoolean(resources.GetObject("Label2.Enabled"));
            this.Label2.Font = (System.Drawing.Font)resources.GetObject("Label2.Font");
            this.Label2.Image = (System.Drawing.Image)resources.GetObject("Label2.Image");
            this.Label2.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("Label2.ImageAlign");
            this.Label2.ImageIndex = System.Convert.ToInt32(resources.GetObject("Label2.ImageIndex"));
            this.Label2.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("Label2.ImeMode");
            this.Label2.Location = (System.Drawing.Point)resources.GetObject("Label2.Location");
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("Label2.RightToLeft");
            this.Label2.Size = (System.Drawing.Size)resources.GetObject("Label2.Size");
            this.Label2.TabIndex = System.Convert.ToInt32(resources.GetObject("Label2.TabIndex"));
            this.Label2.Text = resources.GetString("Label2.Text");
            this.Label2.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("Label2.TextAlign");
            this.Label2.Visible = System.Convert.ToBoolean(resources.GetObject("Label2.Visible"));
            //
            // Label3
            //
            this.Label3.AccessibleDescription = resources.GetString("Label3.AccessibleDescription");
            this.Label3.AccessibleName = resources.GetString("Label3.AccessibleName");
            this.Label3.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("Label3.Anchor");
            this.Label3.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label3.AutoSize"));
            this.Label3.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("Label3.Dock");
            this.Label3.Enabled = System.Convert.ToBoolean(resources.GetObject("Label3.Enabled"));
            this.Label3.Font = (System.Drawing.Font)resources.GetObject("Label3.Font");
            this.Label3.Image = (System.Drawing.Image)resources.GetObject("Label3.Image");
            this.Label3.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("Label3.ImageAlign");
            this.Label3.ImageIndex = System.Convert.ToInt32(resources.GetObject("Label3.ImageIndex"));
            this.Label3.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("Label3.ImeMode");
            this.Label3.Location = (System.Drawing.Point)resources.GetObject("Label3.Location");
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("Label3.RightToLeft");
            this.Label3.Size = (System.Drawing.Size)resources.GetObject("Label3.Size");
            this.Label3.TabIndex = System.Convert.ToInt32(resources.GetObject("Label3.TabIndex"));
            this.Label3.Text = resources.GetString("Label3.Text");
            this.Label3.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("Label3.TextAlign");
            this.Label3.Visible = System.Convert.ToBoolean(resources.GetObject("Label3.Visible"));
            //
            // TextBoxInput
            //
            this.TextBoxInput.AccessibleDescription = resources.GetString("TextBoxInput.AccessibleDescription");
            this.TextBoxInput.AccessibleName = resources.GetString("TextBoxInput.AccessibleName");
            this.TextBoxInput.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("TextBoxInput.Anchor");
            this.TextBoxInput.AutoSize = System.Convert.ToBoolean(resources.GetObject("TextBoxInput.AutoSize"));
            this.TextBoxInput.BackgroundImage = (System.Drawing.Image)resources.GetObject("TextBoxInput.BackgroundImage");
            this.TextBoxInput.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("TextBoxInput.Dock");
            this.TextBoxInput.Enabled = System.Convert.ToBoolean(resources.GetObject("TextBoxInput.Enabled"));
            this.TextBoxInput.Font = (System.Drawing.Font)resources.GetObject("TextBoxInput.Font");
            this.TextBoxInput.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("TextBoxInput.ImeMode");
            this.TextBoxInput.Location = (System.Drawing.Point)resources.GetObject("TextBoxInput.Location");
            this.TextBoxInput.MaxLength = System.Convert.ToInt32(resources.GetObject("TextBoxInput.MaxLength"));
            this.TextBoxInput.Multiline = System.Convert.ToBoolean(resources.GetObject("TextBoxInput.Multiline"));
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.PasswordChar = System.Convert.ToChar(resources.GetObject("TextBoxInput.PasswordChar"));
            this.TextBoxInput.ReadOnly = true;
            this.TextBoxInput.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TextBoxInput.RightToLeft");
            this.TextBoxInput.ScrollBars = (System.Windows.Forms.ScrollBars)resources.GetObject("TextBoxInput.ScrollBars");
            this.TextBoxInput.Size = (System.Drawing.Size)resources.GetObject("TextBoxInput.Size");
            this.TextBoxInput.TabIndex = System.Convert.ToInt32(resources.GetObject("TextBoxInput.TabIndex"));
            this.TextBoxInput.Text = resources.GetString("TextBoxInput.Text");
            this.TextBoxInput.TextAlign = (System.Windows.Forms.HorizontalAlignment)resources.GetObject("TextBoxInput.TextAlign");
            this.TextBoxInput.Visible = System.Convert.ToBoolean(resources.GetObject("TextBoxInput.Visible"));
            this.TextBoxInput.WordWrap = System.Convert.ToBoolean(resources.GetObject("TextBoxInput.WordWrap"));
            //
            // TextBoxOutput
            //
            this.TextBoxOutput.AccessibleDescription = resources.GetString("TextBoxOutput.AccessibleDescription");
            this.TextBoxOutput.AccessibleName = resources.GetString("TextBoxOutput.AccessibleName");
            this.TextBoxOutput.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("TextBoxOutput.Anchor");
            this.TextBoxOutput.AutoSize = System.Convert.ToBoolean(resources.GetObject("TextBoxOutput.AutoSize"));
            this.TextBoxOutput.BackgroundImage = (System.Drawing.Image)resources.GetObject("TextBoxOutput.BackgroundImage");
            this.TextBoxOutput.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("TextBoxOutput.Dock");
            this.TextBoxOutput.Enabled = System.Convert.ToBoolean(resources.GetObject("TextBoxOutput.Enabled"));
            this.TextBoxOutput.Font = (System.Drawing.Font)resources.GetObject("TextBoxOutput.Font");
            this.TextBoxOutput.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("TextBoxOutput.ImeMode");
            this.TextBoxOutput.Location = (System.Drawing.Point)resources.GetObject("TextBoxOutput.Location");
            this.TextBoxOutput.MaxLength = System.Convert.ToInt32(resources.GetObject("TextBoxOutput.MaxLength"));
            this.TextBoxOutput.Multiline = System.Convert.ToBoolean(resources.GetObject("TextBoxOutput.Multiline"));
            this.TextBoxOutput.Name = "TextBoxOutput";
            this.TextBoxOutput.PasswordChar = System.Convert.ToChar(resources.GetObject("TextBoxOutput.PasswordChar"));
            this.TextBoxOutput.ReadOnly = true;
            this.TextBoxOutput.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TextBoxOutput.RightToLeft");
            this.TextBoxOutput.ScrollBars = (System.Windows.Forms.ScrollBars)resources.GetObject("TextBoxOutput.ScrollBars");
            this.TextBoxOutput.Size = (System.Drawing.Size)resources.GetObject("TextBoxOutput.Size");
            this.TextBoxOutput.TabIndex = System.Convert.ToInt32(resources.GetObject("TextBoxOutput.TabIndex"));
            this.TextBoxOutput.Text = resources.GetString("TextBoxOutput.Text");
            this.TextBoxOutput.TextAlign = (System.Windows.Forms.HorizontalAlignment)resources.GetObject("TextBoxOutput.TextAlign");
            this.TextBoxOutput.Visible = System.Convert.ToBoolean(resources.GetObject("TextBoxOutput.Visible"));
            this.TextBoxOutput.WordWrap = System.Convert.ToBoolean(resources.GetObject("TextBoxOutput.WordWrap"));
            //
            // ImageList1
            //
            this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImageList1.ImageSize = (System.Drawing.Size)resources.GetObject("ImageList1.ImageSize");
            this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            //
            // PictureBoxHorizontalGradient
            //
            this.PictureBoxHorizontalGradient.AccessibleDescription = resources.GetString("PictureBoxHorizontalGradient.AccessibleDescription");
            this.PictureBoxHorizontalGradient.AccessibleName = resources.GetString("PictureBoxHorizontalGradient.AccessibleName");
            this.PictureBoxHorizontalGradient.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("PictureBoxHorizontalGradient.Anchor");
            this.PictureBoxHorizontalGradient.BackgroundImage = (System.Drawing.Image)resources.GetObject("PictureBoxHorizontalGradient.BackgroundImage");
            this.PictureBoxHorizontalGradient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxHorizontalGradient.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("PictureBoxHorizontalGradient.Dock");
            this.PictureBoxHorizontalGradient.Enabled = System.Convert.ToBoolean(resources.GetObject("PictureBoxHorizontalGradient.Enabled"));
            this.PictureBoxHorizontalGradient.Font = (System.Drawing.Font)resources.GetObject("PictureBoxHorizontalGradient.Font");
            this.PictureBoxHorizontalGradient.Image = (System.Drawing.Image)resources.GetObject("PictureBoxHorizontalGradient.Image");
            this.PictureBoxHorizontalGradient.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("PictureBoxHorizontalGradient.ImeMode");
            this.PictureBoxHorizontalGradient.Location = (System.Drawing.Point)resources.GetObject("PictureBoxHorizontalGradient.Location");
            this.PictureBoxHorizontalGradient.Name = "PictureBoxHorizontalGradient";
            this.PictureBoxHorizontalGradient.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("PictureBoxHorizontalGradient.RightToLeft");
            this.PictureBoxHorizontalGradient.Size = (System.Drawing.Size)resources.GetObject("PictureBoxHorizontalGradient.Size");
            this.PictureBoxHorizontalGradient.SizeMode = (System.Windows.Forms.PictureBoxSizeMode)resources.GetObject("PictureBoxHorizontalGradient.SizeMode");
            this.PictureBoxHorizontalGradient.TabIndex = System.Convert.ToInt32(resources.GetObject("PictureBoxHorizontalGradient.TabIndex"));
            this.PictureBoxHorizontalGradient.TabStop = false;
            this.PictureBoxHorizontalGradient.Text = resources.GetString("PictureBoxHorizontalGradient.Text");
            this.PictureBoxHorizontalGradient.Visible = System.Convert.ToBoolean(resources.GetObject("PictureBoxHorizontalGradient.Visible"));
            //
            // PictureBoxVerticalGradient
            //
            this.PictureBoxVerticalGradient.AccessibleDescription = resources.GetString("PictureBoxVerticalGradient.AccessibleDescription");
            this.PictureBoxVerticalGradient.AccessibleName = resources.GetString("PictureBoxVerticalGradient.AccessibleName");
            this.PictureBoxVerticalGradient.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("PictureBoxVerticalGradient.Anchor");
            this.PictureBoxVerticalGradient.BackgroundImage = (System.Drawing.Image)resources.GetObject("PictureBoxVerticalGradient.BackgroundImage");
            this.PictureBoxVerticalGradient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxVerticalGradient.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("PictureBoxVerticalGradient.Dock");
            this.PictureBoxVerticalGradient.Enabled = System.Convert.ToBoolean(resources.GetObject("PictureBoxVerticalGradient.Enabled"));
            this.PictureBoxVerticalGradient.Font = (System.Drawing.Font)resources.GetObject("PictureBoxVerticalGradient.Font");
            this.PictureBoxVerticalGradient.Image = (System.Drawing.Image)resources.GetObject("PictureBoxVerticalGradient.Image");
            this.PictureBoxVerticalGradient.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("PictureBoxVerticalGradient.ImeMode");
            this.PictureBoxVerticalGradient.Location = (System.Drawing.Point)resources.GetObject("PictureBoxVerticalGradient.Location");
            this.PictureBoxVerticalGradient.Name = "PictureBoxVerticalGradient";
            this.PictureBoxVerticalGradient.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("PictureBoxVerticalGradient.RightToLeft");
            this.PictureBoxVerticalGradient.Size = (System.Drawing.Size)resources.GetObject("PictureBoxVerticalGradient.Size");
            this.PictureBoxVerticalGradient.SizeMode = (System.Windows.Forms.PictureBoxSizeMode)resources.GetObject("PictureBoxVerticalGradient.SizeMode");
            this.PictureBoxVerticalGradient.TabIndex = System.Convert.ToInt32(resources.GetObject("PictureBoxVerticalGradient.TabIndex"));
            this.PictureBoxVerticalGradient.TabStop = false;
            this.PictureBoxVerticalGradient.Text = resources.GetString("PictureBoxVerticalGradient.Text");
            this.PictureBoxVerticalGradient.Visible = System.Convert.ToBoolean(resources.GetObject("PictureBoxVerticalGradient.Visible"));
            //
            // ButtonSmooth
            //
            this.ButtonSmooth.AccessibleDescription = resources.GetString("ButtonSmooth.AccessibleDescription");
            this.ButtonSmooth.AccessibleName = resources.GetString("ButtonSmooth.AccessibleName");
            this.ButtonSmooth.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("ButtonSmooth.Anchor");
            this.ButtonSmooth.BackgroundImage = (System.Drawing.Image)resources.GetObject("ButtonSmooth.BackgroundImage");
            this.ButtonSmooth.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("ButtonSmooth.Dock");
            this.ButtonSmooth.Enabled = System.Convert.ToBoolean(resources.GetObject("ButtonSmooth.Enabled"));
            this.ButtonSmooth.FlatStyle = (System.Windows.Forms.FlatStyle)resources.GetObject("ButtonSmooth.FlatStyle");
            this.ButtonSmooth.Font = (System.Drawing.Font)resources.GetObject("ButtonSmooth.Font");
            this.ButtonSmooth.Image = (System.Drawing.Image)resources.GetObject("ButtonSmooth.Image");
            this.ButtonSmooth.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("ButtonSmooth.ImageAlign");
            this.ButtonSmooth.ImageIndex = System.Convert.ToInt32(resources.GetObject("ButtonSmooth.ImageIndex"));
            this.ButtonSmooth.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("ButtonSmooth.ImeMode");
            this.ButtonSmooth.Location = (System.Drawing.Point)resources.GetObject("ButtonSmooth.Location");
            this.ButtonSmooth.Name = "ButtonSmooth";
            this.ButtonSmooth.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("ButtonSmooth.RightToLeft");
            this.ButtonSmooth.Size = (System.Drawing.Size)resources.GetObject("ButtonSmooth.Size");
            this.ButtonSmooth.TabIndex = System.Convert.ToInt32(resources.GetObject("ButtonSmooth.TabIndex"));
            this.ButtonSmooth.Text = resources.GetString("ButtonSmooth.Text");
            this.ButtonSmooth.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("ButtonSmooth.TextAlign");
            this.ButtonSmooth.Visible = System.Convert.ToBoolean(resources.GetObject("ButtonSmooth.Visible"));
            //
            // RadioButtonCurve
            //
            this.RadioButtonCurve.AccessibleDescription = resources.GetString("RadioButtonCurve.AccessibleDescription");
            this.RadioButtonCurve.AccessibleName = resources.GetString("RadioButtonCurve.AccessibleName");
            this.RadioButtonCurve.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("RadioButtonCurve.Anchor");
            this.RadioButtonCurve.Appearance = (System.Windows.Forms.Appearance)resources.GetObject("RadioButtonCurve.Appearance");
            this.RadioButtonCurve.BackgroundImage = (System.Drawing.Image)resources.GetObject("RadioButtonCurve.BackgroundImage");
            this.RadioButtonCurve.CheckAlign = (System.Drawing.ContentAlignment)resources.GetObject("RadioButtonCurve.CheckAlign");
            this.RadioButtonCurve.Checked = true;
            this.RadioButtonCurve.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("RadioButtonCurve.Dock");
            this.RadioButtonCurve.Enabled = System.Convert.ToBoolean(resources.GetObject("RadioButtonCurve.Enabled"));
            this.RadioButtonCurve.FlatStyle = (System.Windows.Forms.FlatStyle)resources.GetObject("RadioButtonCurve.FlatStyle");
            this.RadioButtonCurve.Font = (System.Drawing.Font)resources.GetObject("RadioButtonCurve.Font");
            this.RadioButtonCurve.Image = (System.Drawing.Image)resources.GetObject("RadioButtonCurve.Image");
            this.RadioButtonCurve.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("RadioButtonCurve.ImageAlign");
            this.RadioButtonCurve.ImageIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonCurve.ImageIndex"));
            this.RadioButtonCurve.ImageList = this.ImageList1;
            this.RadioButtonCurve.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("RadioButtonCurve.ImeMode");
            this.RadioButtonCurve.Location = (System.Drawing.Point)resources.GetObject("RadioButtonCurve.Location");
            this.RadioButtonCurve.Name = "RadioButtonCurve";
            this.RadioButtonCurve.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("RadioButtonCurve.RightToLeft");
            this.RadioButtonCurve.Size = (System.Drawing.Size)resources.GetObject("RadioButtonCurve.Size");
            this.RadioButtonCurve.TabIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonCurve.TabIndex"));
            this.RadioButtonCurve.TabStop = true;
            this.RadioButtonCurve.Text = resources.GetString("RadioButtonCurve.Text");
            this.RadioButtonCurve.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("RadioButtonCurve.TextAlign");
            this.RadioButtonCurve.Visible = System.Convert.ToBoolean(resources.GetObject("RadioButtonCurve.Visible"));
            //
            // RadioButtonPen
            //
            this.RadioButtonPen.AccessibleDescription = resources.GetString("RadioButtonPen.AccessibleDescription");
            this.RadioButtonPen.AccessibleName = resources.GetString("RadioButtonPen.AccessibleName");
            this.RadioButtonPen.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("RadioButtonPen.Anchor");
            this.RadioButtonPen.Appearance = (System.Windows.Forms.Appearance)resources.GetObject("RadioButtonPen.Appearance");
            this.RadioButtonPen.BackgroundImage = (System.Drawing.Image)resources.GetObject("RadioButtonPen.BackgroundImage");
            this.RadioButtonPen.CheckAlign = (System.Drawing.ContentAlignment)resources.GetObject("RadioButtonPen.CheckAlign");
            this.RadioButtonPen.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("RadioButtonPen.Dock");
            this.RadioButtonPen.Enabled = System.Convert.ToBoolean(resources.GetObject("RadioButtonPen.Enabled"));
            this.RadioButtonPen.FlatStyle = (System.Windows.Forms.FlatStyle)resources.GetObject("RadioButtonPen.FlatStyle");
            this.RadioButtonPen.Font = (System.Drawing.Font)resources.GetObject("RadioButtonPen.Font");
            this.RadioButtonPen.Image = (System.Drawing.Image)resources.GetObject("RadioButtonPen.Image");
            this.RadioButtonPen.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("RadioButtonPen.ImageAlign");
            this.RadioButtonPen.ImageIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonPen.ImageIndex"));
            this.RadioButtonPen.ImageList = this.ImageList1;
            this.RadioButtonPen.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("RadioButtonPen.ImeMode");
            this.RadioButtonPen.Location = (System.Drawing.Point)resources.GetObject("RadioButtonPen.Location");
            this.RadioButtonPen.Name = "RadioButtonPen";
            this.RadioButtonPen.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("RadioButtonPen.RightToLeft");
            this.RadioButtonPen.Size = (System.Drawing.Size)resources.GetObject("RadioButtonPen.Size");
            this.RadioButtonPen.TabIndex = System.Convert.ToInt32(resources.GetObject("RadioButtonPen.TabIndex"));
            this.RadioButtonPen.Text = resources.GetString("RadioButtonPen.Text");
            this.RadioButtonPen.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("RadioButtonPen.TextAlign");
            this.RadioButtonPen.Visible = System.Convert.ToBoolean(resources.GetObject("RadioButtonPen.Visible"));
            //
            // CurvesPropertyPage
            //
            this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
            this.AccessibleName = resources.GetString("$this.AccessibleName");
            this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
            this.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMargin");
            this.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMinSize");
            this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            this.Controls.Add(this.RadioButtonPen);
            this.Controls.Add(this.RadioButtonCurve);
            this.Controls.Add(this.ButtonSmooth);
            this.Controls.Add(this.PictureBoxVerticalGradient);
            this.Controls.Add(this.PictureBoxHorizontalGradient);
            this.Controls.Add(this.TextBoxOutput);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ComboBoxChannel);
            this.Controls.Add(this.LabelChannel);
            this.Controls.Add(this.PictureBox1);
            this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
            this.Font = (System.Drawing.Font)resources.GetObject("$this.Font");
            this.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("$this.ImeMode");
            this.Location = (System.Drawing.Point)resources.GetObject("$this.Location");
            this.Name = "CurvesPropertyPage";
            this.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("$this.RightToLeft");
            this.Size = (System.Drawing.Size)resources.GetObject("$this.Size");
            this.ResumeLayout(false);
        }

        #endregion " Windows Form Designer generated code "

        private Aurigma.GraphicsMill.Bitmap _bitmap;

        private PointF[] _points = new PointF[] { new PointF(0, 0), new PointF(1, 1) };
        private Lut _lut = new Lut() { InterpolationMode = LutInterpolationMode.Cubic };

        private int _pointIndex = -1;

        private bool _inverted;

        private int _prevX = -1;
        private int _prevY = -1;

        private const float mouseTolerance = 0.02F;

        private int _smoothRadius = -1;

        private enum MouseMode
        {
            None,
            AddPoint,
            MovePoint,
            MovingPoint,
            DrawLut
        }

        private MouseMode _mouseMode = MouseMode.None;

        private enum EditMode
        {
            Curve,
            Pen
        }

        private EditMode _editMode = EditMode.Curve;

        public Aurigma.GraphicsMill.Bitmap Bitmap
        {
            get
            {
                return _bitmap;
            }
            set
            {
                _bitmap = value;
                UpdateComboBoxChannel();
            }
        }

        public IBitmapTransform Transform
        {
            get
            {
                return new LutTransform(_lut);
            }
        }

        public string Title
        {
            get
            {
                return "Curves";
            }
        }

        private void UpdateComboBoxChannel()
        {
            // TODO: We need to implement per channel effect applying
            ComboBoxChannel.Enabled = false;
            LabelChannel.Enabled = ComboBoxChannel.Enabled;
            ComboBoxChannel.SelectedIndex = 0;
        }

        private int TranslateX(int value)
        {
            if (_inverted)
            {
                return 255 - value;
            }
            else
            {
                return value;
            }
        }

        private int TranslateY(int value)
        {
            if (_inverted)
            {
                return value;
            }
            else
            {
                return 255 - value;
            }
        }

        private void PictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.Clear(System.Drawing.Color.WhiteSmoke);

            // Grid
            System.Drawing.Pen gp = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0xFF, 0x33, 0x33, 0x33), 1);
            gp.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            e.Graphics.DrawLine(gp, 0, 63, 255, 63);
            e.Graphics.DrawLine(gp, 0, 127, 255, 127);
            e.Graphics.DrawLine(gp, 0, 191, 255, 191);
            e.Graphics.DrawLine(gp, 63, 0, 63, 255);
            e.Graphics.DrawLine(gp, 127, 0, 127, 255);
            e.Graphics.DrawLine(gp, 191, 0, 191, 255);

            System.Drawing.Pen bp = new System.Drawing.Pen(System.Drawing.Color.Black, 1);

            System.Drawing.SolidBrush bb = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            int[] lutValues = _lut.GetInterpolatedValues();

            for (int i = 0; i <= 255; i++)
            {
                e.Graphics.FillRectangle(bb, TranslateX(i), TranslateY(lutValues[i]), 1, 1);
            }

            if (_editMode == EditMode.Curve)
            {
                // Points
                for (int i = 0; i <= _points.Length - 1; i++)
                {
                    int x = TranslateX(Convert.ToInt32(_points[i].X * 255));
                    int y = TranslateY(Convert.ToInt32(_points[i].Y * 255));
                    if (i == _pointIndex)
                    {
                        e.Graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), new Rectangle(x - 3, y - 3, 6, 6));
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(bp, new Rectangle(x - 3, y - 3, 5, 5));
                    }
                }
            }
        }

        private void PictureBoxHorizontalGradient_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            int X;
            switch (ComboBoxChannel.Text)
            {
                case "Red":

                    for (int I = 0; I <= 255; I++)
                    {
                        X = TranslateX(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(X, 0, 0));
                        e.Graphics.DrawLine(p, I, 0, I, 11);
                    }
                    break;

                case "Green":

                    for (int I = 0; I <= 255; I++)
                    {
                        X = TranslateX(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0, X, 0));
                        e.Graphics.DrawLine(p, I, 0, I, 11);
                    }
                    break;

                case "Blue":

                    for (int I = 0; I <= 255; I++)
                    {
                        X = TranslateX(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0, 0, X));
                        e.Graphics.DrawLine(p, I, 0, I, 11);
                    }
                    break;

                case "Cyan":

                    for (int I = 0; I <= 255; I++)
                    {
                        X = TranslateX(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0, X, X));
                        e.Graphics.DrawLine(p, I, 0, I, 11);
                    }
                    break;

                case "Magenta":

                    for (int I = 0; I <= 255; I++)
                    {
                        X = TranslateX(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(X, 0, X));
                        e.Graphics.DrawLine(p, I, 0, I, 11);
                    }
                    break;

                case "Yellow":

                    for (int I = 0; I <= 255; I++)
                    {
                        X = TranslateX(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(X, X, 0));
                        e.Graphics.DrawLine(p, I, 0, I, 11);
                    }
                    break;

                default:

                    for (int I = 0; I <= 255; I++)
                    {
                        X = TranslateX(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(X, X, X));
                        e.Graphics.DrawLine(p, I, 0, I, 11);
                    }
                    break;
            }

            // Draw control box
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            System.Drawing.SolidBrush wb = new System.Drawing.SolidBrush(System.Drawing.Color.White);

            e.Graphics.FillRectangle(wb, new Rectangle(117, 0, 21, 12));

            System.Drawing.Pen bp = new System.Drawing.Pen(System.Drawing.Color.Black);
            e.Graphics.DrawLine(bp, 117, 0, 117, 11);
            e.Graphics.DrawLine(bp, 127, 0, 127, 11);
            e.Graphics.DrawLine(bp, 137, 0, 137, 11);

            System.Drawing.SolidBrush bb = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            if (_inverted)
            {
                e.Graphics.FillPolygon(bb, new Point[] { new Point(124, 1), new Point(124, 11), new Point(119, 6) });
                e.Graphics.DrawPolygon(bp, new Point[] { new Point(130, 2), new Point(130, 10), new Point(134, 6) });
            }
            else
            {
                e.Graphics.DrawPolygon(bp, new Point[] { new Point(124, 2), new Point(124, 10), new Point(120, 6) });
                e.Graphics.FillPolygon(bb, new Point[] { new Point(130, 1), new Point(130, 11), new Point(135, 6) });
            }
        }

        private void PictureBoxVerticalGradient_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            int Y;
            switch (ComboBoxChannel.Text)
            {
                case "Red":

                    for (int I = 0; I <= 255; I++)
                    {
                        Y = TranslateY(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(Y, 0, 0));
                        e.Graphics.DrawLine(p, 0, I, 11, I);
                    }
                    break;

                case "Green":

                    for (int I = 0; I <= 255; I++)
                    {
                        Y = TranslateY(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0, Y, 0));
                        e.Graphics.DrawLine(p, 0, I, 11, I);
                    }
                    break;

                case "Blue":

                    for (int I = 0; I <= 255; I++)
                    {
                        Y = TranslateY(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0, 0, Y));
                        e.Graphics.DrawLine(p, 0, I, 11, I);
                    }
                    break;

                case "Cyan":

                    for (int I = 0; I <= 255; I++)
                    {
                        Y = TranslateY(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0, Y, Y));
                        e.Graphics.DrawLine(p, 0, I, 11, I);
                    }
                    break;

                case "Magenta":

                    for (int I = 0; I <= 255; I++)
                    {
                        Y = TranslateY(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(Y, 0, Y));
                        e.Graphics.DrawLine(p, 0, I, 11, I);
                    }
                    break;

                case "Yellow":

                    for (int I = 0; I <= 255; I++)
                    {
                        Y = TranslateY(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(Y, Y, 0));
                        e.Graphics.DrawLine(p, 0, I, 11, I);
                    }
                    break;

                default:

                    for (int I = 0; I <= 255; I++)
                    {
                        Y = TranslateY(I);
                        System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.FromArgb(Y, Y, Y));
                        e.Graphics.DrawLine(p, 0, I, 11, I);
                    }
                    break;
            }
        }

        private void PictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            PictureBox1.Focus();

            if (_editMode == EditMode.Curve)
            {
                _pointIndex = GetPointAt(e.X, e.Y);

                if (_pointIndex == -1)
                {
                    _mouseMode = MouseMode.MovingPoint;

                    PictureBox1.Cursor = Cursors.SizeAll;
                    PictureBox1.Refresh();

                    // Add new point
                    float x = Convert.ToSingle(TranslateX(e.X)) / 255.0F;
                    float y = Convert.ToSingle(TranslateY(e.Y)) / 255.0F;

                    for (int i = 0; i <= _points.Length - 2; i++)
                    {
                        if ((x > _points[i].X) && (x < _points[i + 1].X))
                        {
                            _pointIndex = i + 1;
                            break;
                        }
                    }

                    if (_pointIndex != -1)
                    {
                        // Increase length on 1 element
                        // ReDim Preserve points(points.Length)
                        PointF[] newPoints;
                        newPoints = new PointF[_points.Length + 1];
                        _points.CopyTo(newPoints, 0);
                        _points = newPoints;

                        // Shift all elements
                        for (int i = 1; i <= _points.Length - _pointIndex; i++)
                        {
                            _points[_points.Length - i] = _points[_points.Length - i - 1];
                        }

                        _points[_pointIndex] = new PointF(x, y);

                        BuildLut();

                        _mouseMode = MouseMode.MovingPoint;

                        PictureBox1.Cursor = Cursors.SizeAll;

                        PictureBox1.Refresh();
                    }
                }
                else
                {
                    // Seleted existed point
                    _mouseMode = MouseMode.MovingPoint;
                    PictureBox1.Refresh();
                }
            }
            else // EditMode.Pen()
            {
                _mouseMode = MouseMode.DrawLut;
                int x = TranslateX(e.X);
                int y = TranslateY(e.Y);

                _prevX = x;
                _prevY = y;

                _lut.InterpolationMode = LutInterpolationMode.Linear;
                _lut.SetPoint(x, y);

                _smoothRadius = -1;

                PictureBox1.Refresh();
            }
        }

        private void PictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Globalization.NumberFormatInfo numberFormat = new System.Globalization.NumberFormatInfo();
            TextBoxInput.Text = Convert.ToString(Math.Max(0, Math.Min(100, Math.Round(Convert.ToSingle(e.X) / 255.0F * 100.0F))), numberFormat) + "%";
            TextBoxOutput.Text = Convert.ToString(Math.Max(0, Math.Min(100, Math.Round((255.0F - Convert.ToSingle(e.Y)) / 255.0F * 100.0F))), numberFormat) + "%";

            // BUGBUG
            if (_editMode == EditMode.Curve)
            {
                if (_mouseMode == MouseMode.MovingPoint)
                {
                    float maxValue = Math.Max(0, Convert.ToSingle(TranslateX(e.X)) / 255.0F);
                    float X = Convert.ToSingle(Math.Min(1, maxValue));

                    maxValue = Math.Max(0, Convert.ToSingle(TranslateY(e.Y)) / 255.0F);
                    float Y = Convert.ToSingle(Math.Min(1, maxValue));

                    if (_pointIndex == 0)
                    {
                        _points[0].Y = Y;
                    }
                    else if (_pointIndex == _points.Length - 1)
                    {
                        _points[_points.Length - 1].Y = Y;
                    }
                    else if ((X > _points[_pointIndex - 1].X) && (X < _points[_pointIndex + 1].X))
                    {
                        _points[_pointIndex].X = X;
                        _points[_pointIndex].Y = Y;
                    }
                    else
                    {
                        // Delete point
                        // Shift all elements
                        for (int i = _pointIndex; i <= _points.Length - 2; i++)
                        {
                            _points[i] = _points[i + 1];
                        }

                        // Decrease length on 1 element
                        // ReDim Preserve points(points.Length - 2)
                        PointF[] newPoints;
                        newPoints = new PointF[_points.Length - 2 + 1];
                        System.Array.Copy(_points, 0, newPoints, 0, newPoints.Length);
                        _points = newPoints;

                        _pointIndex = -1;

                        _mouseMode = MouseMode.None;
                    }

                    // Rebuild LUT
                    BuildLut();

                    PictureBox1.Refresh();
                }
                else
                {
                    if (GetPointAt(e.X, e.Y) != -1)
                    {
                        PictureBox1.Cursor = Cursors.SizeAll;
                    }
                    else
                    {
                        PictureBox1.Cursor = Cursors.Cross;
                    }
                }
            }
            else // EditMode.Pen()
            {
                PictureBox1.Cursor = Cursors.Cross;

                if (_mouseMode == MouseMode.DrawLut)
                {
                    int x = Math.Max(0, Math.Min(255, TranslateX(e.X)));
                    int y = Math.Max(0, Math.Min(255, TranslateY(e.Y)));

                    // _lut[x] = y;
                    _lut.SetPoint(x, y);

                    if (Math.Abs(x - _prevX) > 1)
                    {
                        // Make interpolation for points
                        int minX;
                        int minY;
                        int maxX;
                        int maxY;
                        if (x < _prevX)
                        {
                            minX = x;
                            minY = y;
                            maxX = _prevX;
                            maxY = _prevY;
                        }
                        else // X > prevX
                        {
                            maxX = x;
                            maxY = y;
                            minX = _prevX;
                            minY = _prevY;
                        }

                        for (int i = minX + 1; i <= maxX - 1; i++)
                        {
                            _lut.SetPoint(i, Convert.ToInt32(Math.Round(Convert.ToSingle(i - minX) / Convert.ToSingle(maxX - minX) * Convert.ToSingle(maxY - minY) + Convert.ToSingle(minY))));
                        }
                    }

                    _prevX = x;
                    _prevY = y;

                    PictureBox1.Refresh();
                }
            }
        }

        private void PictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _mouseMode = MouseMode.None;
        }

        private void PictureBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Delete) && (_pointIndex != -1) && (_mouseMode != MouseMode.MovingPoint))
            {
                // Shift all elements
                for (int i = _pointIndex; i <= _points.Length - 2; i++)
                {
                    _points[i] = _points[i + 1];
                }

                // Decrease length on 1 element
                // ReDim Preserve points(points.Length - 2)
                PointF[] newPoints;
                newPoints = new PointF[_points.Length - 2 + 1];
                System.Array.Copy(_points, 0, newPoints, 0, newPoints.Length);
                _points = newPoints;

                // Rebuild LUT
                // _lut.BuildFromSpline(points, false);
                BuildLut();

                PictureBox1.Refresh();
            }
        }

        private int GetPointAt(int controlX, int controlY)
        {
            float x = Convert.ToSingle(TranslateX(controlX)) / 255.0F;
            float y = Convert.ToSingle(TranslateY(controlY)) / 255.0F;

            for (int i = 0; i <= _points.Length - 1; i++)
            {
                if (Math.Abs(_points[i].X - x) < mouseTolerance && Math.Abs(_points[i].Y - y) < mouseTolerance)
                {
                    return i;
                }
            }

            return -1;
        }

        private void PictureBoxHorizontalGradient_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _inverted = !_inverted;
            PictureBoxHorizontalGradient.Refresh();
            PictureBoxVerticalGradient.Refresh();
            PictureBox1.Refresh();
        }

        private void RadioButtonCurve_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (_editMode != EditMode.Curve)
            {
                _editMode = EditMode.Curve;
                ButtonSmooth.Enabled = false;

                SetPointsFromLut();

                PictureBox1.Refresh();
            }
        }

        private void RadioButtonPen_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (_editMode != EditMode.Pen)
            {
                _editMode = EditMode.Pen;
                ButtonSmooth.Enabled = true;
                _smoothRadius = -1;
                PictureBox1.Refresh();
            }
        }

        private void ButtonSmooth_Click(System.Object sender, System.EventArgs e)
        {
            _smoothRadius += Convert.ToInt32(Math.Round(_smoothRadius * 1.25));
            _smoothRadius = Math.Min(70, Math.Max(20, _smoothRadius));
            SmoothLut(_smoothRadius);
            PictureBox1.Refresh();
        }

        private void SmoothLut(long smoothRadius)
        {
            float[] conv;
            conv = new float[Convert.ToInt32(smoothRadius * 2) + 1];

            // Fill convolution slide with Gaussian kernel
            float sigma = Convert.ToInt32(smoothRadius / 3.0F);
            float convSum = 0;
            for (int i = 0; i <= Convert.ToInt32(smoothRadius * 2); i++)
            {
                conv[i] = Convert.ToSingle(1.0F / (2.0F * Math.PI * sigma * sigma) * Math.Exp(-((i - smoothRadius) * (i - smoothRadius)) / (2.0F * sigma * sigma)));
                convSum += conv[i];
            }

            int[] lutValues = _lut.GetInterpolatedValues();

            // Solve problem with edge artifact
            // BUGBUG
            float minK = Convert.ToSingle(lutValues[Convert.ToInt32(smoothRadius)] - lutValues[0]) / smoothRadius;
            float maxK = Convert.ToSingle(lutValues[255] - lutValues[Convert.ToInt32(255 - smoothRadius)]) / smoothRadius;

            float sum;
            for (int i = 0; i <= 255; i++)
            {
                sum = 0;
                for (int J = 0; J <= Convert.ToInt32(smoothRadius * 2); J++)
                {
                    int x = Convert.ToInt32(i + J - smoothRadius);
                    // Solve problem with edge artifact
                    if (x < 0)
                    {
                        sum += conv[J] * (lutValues[0] + x * minK);
                    }
                    else if (x > 255)
                    {
                        sum += conv[J] * (lutValues[255] + (x - 255) * maxK);
                    }
                    else
                    {
                        sum += conv[J] * lutValues[x];
                    }
                }
                lutValues[i] = Convert.ToInt32(Math.Min(Math.Max(Math.Round(sum / convSum), 0), 255));
            }

            _lut = new Lut();
            for (int i = 0; i < lutValues.Length; i++)
            {
                _lut.SetPoint(i, lutValues[i]);
            }

            _lut.InterpolationMode = LutInterpolationMode.Linear;
        }

        private void SetPointsFromLut()
        {
            // Find points using least-squares method

            // First of all smooth LUT for removing noise
            // BUGBUG
            SmoothLut(30);

            int[] lutValues = _lut.GetInterpolatedValues();

            ArrayList newPoints = new ArrayList();
            // Add first point
            newPoints.Add(new PointF(0, Convert.ToSingle(lutValues[0]) / 255.0F));

            // Add 7 points
            for (int i = 31; i <= 223; i += 32)
            {
                newPoints.Add(new PointF(Convert.ToSingle(i) / 255.0F, Convert.ToSingle(lutValues[i]) / 255.0F));
            }

            // Add last point
            newPoints.Add(new PointF(1.0F, Convert.ToSingle(lutValues[255]) / 255.0F));

            _points = new PointF[newPoints.Count - 1 + 1];

            // Copy elements
            for (int i = 0; i <= _points.Length - 1; i++)
            {
                _points[i] = (PointF)newPoints[i];
            }

            // _lut.BuildFromSpline(points, false);
            BuildLut();
        }

        private void BuildLut()
        {
            float coef = _bitmap.PixelFormat.IsExtended ? 0xFFFF : 0xFF;

            _lut = new Lut();
            _lut.InterpolationMode = LutInterpolationMode.Cubic;

            foreach (var point in _points)
            {
                _lut.SetPoint((int)(point.X * coef), (int)(point.Y * coef));
            }
        }
    }
}