using System;
using System.Windows.Forms;
using Aurigma.GraphicsMill;

namespace Main
{
    public class NewImage : System.Windows.Forms.Form
    {
        #region " Windows Form Designer generated code "

        public NewImage()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call
            comboBoxMode.SelectedIndex = 0;
            comboBoxColorDepth.SelectedIndex = 1;
        }

        // Form overrides dispose to clean up the component list.
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
        internal System.Windows.Forms.TextBox textBoxHeight;

        internal System.Windows.Forms.ComboBox comboBoxResolution;
        internal System.Windows.Forms.ComboBox comboBoxMode;
        internal System.Windows.Forms.TextBox textBoxWidth;
        internal System.Windows.Forms.ComboBox comboBoxColorDepth;
        internal System.Windows.Forms.CheckBox checkBoxAlpha;
        internal System.Windows.Forms.Button buttonCancel;
        internal System.Windows.Forms.Button buttonAccept;
        internal System.Windows.Forms.Label labelWidth;
        internal System.Windows.Forms.Label labelHeight;
        internal System.Windows.Forms.Label labelResolution;
        internal System.Windows.Forms.Label labelMode;
        internal System.Windows.Forms.Label labelBitsPerChannel;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NewImage));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCancel.Click += new System.EventHandler(buttonCancel_Click);
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonAccept.Click += new System.EventHandler(buttonAccept_Click);
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelResolution = new System.Windows.Forms.Label();
            this.comboBoxResolution = new System.Windows.Forms.ComboBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(comboBoxMode_SelectedIndexChanged);
            this.labelBitsPerChannel = new System.Windows.Forms.Label();
            this.comboBoxColorDepth = new System.Windows.Forms.ComboBox();
            this.checkBoxAlpha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            //
            // buttonCancel
            //
            this.buttonCancel.AccessibleDescription = resources.GetString("buttonCancel.AccessibleDescription");
            this.buttonCancel.AccessibleName = resources.GetString("buttonCancel.AccessibleName");
            this.buttonCancel.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("buttonCancel.Anchor");
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonCancel.BackgroundImage");
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("buttonCancel.Dock");
            this.buttonCancel.Enabled = System.Convert.ToBoolean(resources.GetObject("buttonCancel.Enabled"));
            this.buttonCancel.FlatStyle = (System.Windows.Forms.FlatStyle)resources.GetObject("buttonCancel.FlatStyle");
            this.buttonCancel.Font = (System.Drawing.Font)resources.GetObject("buttonCancel.Font");
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancel.Image = (System.Drawing.Image)resources.GetObject("buttonCancel.Image");
            this.buttonCancel.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("buttonCancel.ImageAlign");
            this.buttonCancel.ImageIndex = System.Convert.ToInt32(resources.GetObject("buttonCancel.ImageIndex"));
            this.buttonCancel.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("buttonCancel.ImeMode");
            this.buttonCancel.Location = (System.Drawing.Point)resources.GetObject("buttonCancel.Location");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("buttonCancel.RightToLeft");
            this.buttonCancel.Size = (System.Drawing.Size)resources.GetObject("buttonCancel.Size");
            this.buttonCancel.TabIndex = System.Convert.ToInt32(resources.GetObject("buttonCancel.TabIndex"));
            this.buttonCancel.Text = resources.GetString("buttonCancel.Text");
            this.buttonCancel.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("buttonCancel.TextAlign");
            this.buttonCancel.Visible = System.Convert.ToBoolean(resources.GetObject("buttonCancel.Visible"));
            //
            // buttonAccept
            //
            this.buttonAccept.AccessibleDescription = resources.GetString("buttonAccept.AccessibleDescription");
            this.buttonAccept.AccessibleName = resources.GetString("buttonAccept.AccessibleName");
            this.buttonAccept.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("buttonAccept.Anchor");
            this.buttonAccept.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAccept.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonAccept.BackgroundImage");
            this.buttonAccept.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAccept.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("buttonAccept.Dock");
            this.buttonAccept.Enabled = System.Convert.ToBoolean(resources.GetObject("buttonAccept.Enabled"));
            this.buttonAccept.FlatStyle = (System.Windows.Forms.FlatStyle)resources.GetObject("buttonAccept.FlatStyle");
            this.buttonAccept.Font = (System.Drawing.Font)resources.GetObject("buttonAccept.Font");
            this.buttonAccept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAccept.Image = (System.Drawing.Image)resources.GetObject("buttonAccept.Image");
            this.buttonAccept.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("buttonAccept.ImageAlign");
            this.buttonAccept.ImageIndex = System.Convert.ToInt32(resources.GetObject("buttonAccept.ImageIndex"));
            this.buttonAccept.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("buttonAccept.ImeMode");
            this.buttonAccept.Location = (System.Drawing.Point)resources.GetObject("buttonAccept.Location");
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("buttonAccept.RightToLeft");
            this.buttonAccept.Size = (System.Drawing.Size)resources.GetObject("buttonAccept.Size");
            this.buttonAccept.TabIndex = System.Convert.ToInt32(resources.GetObject("buttonAccept.TabIndex"));
            this.buttonAccept.Text = resources.GetString("buttonAccept.Text");
            this.buttonAccept.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("buttonAccept.TextAlign");
            this.buttonAccept.Visible = System.Convert.ToBoolean(resources.GetObject("buttonAccept.Visible"));
            //
            // textBoxWidth
            //
            this.textBoxWidth.AccessibleDescription = resources.GetString("textBoxWidth.AccessibleDescription");
            this.textBoxWidth.AccessibleName = resources.GetString("textBoxWidth.AccessibleName");
            this.textBoxWidth.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("textBoxWidth.Anchor");
            this.textBoxWidth.AutoSize = System.Convert.ToBoolean(resources.GetObject("textBoxWidth.AutoSize"));
            this.textBoxWidth.BackgroundImage = (System.Drawing.Image)resources.GetObject("textBoxWidth.BackgroundImage");
            this.textBoxWidth.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("textBoxWidth.Dock");
            this.textBoxWidth.Enabled = System.Convert.ToBoolean(resources.GetObject("textBoxWidth.Enabled"));
            this.textBoxWidth.Font = (System.Drawing.Font)resources.GetObject("textBoxWidth.Font");
            this.textBoxWidth.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("textBoxWidth.ImeMode");
            this.textBoxWidth.Location = (System.Drawing.Point)resources.GetObject("textBoxWidth.Location");
            this.textBoxWidth.MaxLength = System.Convert.ToInt32(resources.GetObject("textBoxWidth.MaxLength"));
            this.textBoxWidth.Multiline = System.Convert.ToBoolean(resources.GetObject("textBoxWidth.Multiline"));
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.PasswordChar = System.Convert.ToChar(resources.GetObject("textBoxWidth.PasswordChar"));
            this.textBoxWidth.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("textBoxWidth.RightToLeft");
            this.textBoxWidth.ScrollBars = (System.Windows.Forms.ScrollBars)resources.GetObject("textBoxWidth.ScrollBars");
            this.textBoxWidth.Size = (System.Drawing.Size)resources.GetObject("textBoxWidth.Size");
            this.textBoxWidth.TabIndex = System.Convert.ToInt32(resources.GetObject("textBoxWidth.TabIndex"));
            this.textBoxWidth.Text = resources.GetString("textBoxWidth.Text");
            this.textBoxWidth.TextAlign = (System.Windows.Forms.HorizontalAlignment)resources.GetObject("textBoxWidth.TextAlign");
            this.textBoxWidth.Visible = System.Convert.ToBoolean(resources.GetObject("textBoxWidth.Visible"));
            this.textBoxWidth.WordWrap = System.Convert.ToBoolean(resources.GetObject("textBoxWidth.WordWrap"));
            //
            // labelWidth
            //
            this.labelWidth.AccessibleDescription = resources.GetString("labelWidth.AccessibleDescription");
            this.labelWidth.AccessibleName = resources.GetString("labelWidth.AccessibleName");
            this.labelWidth.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("labelWidth.Anchor");
            this.labelWidth.AutoSize = System.Convert.ToBoolean(resources.GetObject("labelWidth.AutoSize"));
            this.labelWidth.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("labelWidth.Dock");
            this.labelWidth.Enabled = System.Convert.ToBoolean(resources.GetObject("labelWidth.Enabled"));
            this.labelWidth.Font = (System.Drawing.Font)resources.GetObject("labelWidth.Font");
            this.labelWidth.Image = (System.Drawing.Image)resources.GetObject("labelWidth.Image");
            this.labelWidth.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("labelWidth.ImageAlign");
            this.labelWidth.ImageIndex = System.Convert.ToInt32(resources.GetObject("labelWidth.ImageIndex"));
            this.labelWidth.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("labelWidth.ImeMode");
            this.labelWidth.Location = (System.Drawing.Point)resources.GetObject("labelWidth.Location");
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("labelWidth.RightToLeft");
            this.labelWidth.Size = (System.Drawing.Size)resources.GetObject("labelWidth.Size");
            this.labelWidth.TabIndex = System.Convert.ToInt32(resources.GetObject("labelWidth.TabIndex"));
            this.labelWidth.Text = resources.GetString("labelWidth.Text");
            this.labelWidth.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("labelWidth.TextAlign");
            this.labelWidth.Visible = System.Convert.ToBoolean(resources.GetObject("labelWidth.Visible"));
            //
            // labelHeight
            //
            this.labelHeight.AccessibleDescription = resources.GetString("labelHeight.AccessibleDescription");
            this.labelHeight.AccessibleName = resources.GetString("labelHeight.AccessibleName");
            this.labelHeight.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("labelHeight.Anchor");
            this.labelHeight.AutoSize = System.Convert.ToBoolean(resources.GetObject("labelHeight.AutoSize"));
            this.labelHeight.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("labelHeight.Dock");
            this.labelHeight.Enabled = System.Convert.ToBoolean(resources.GetObject("labelHeight.Enabled"));
            this.labelHeight.Font = (System.Drawing.Font)resources.GetObject("labelHeight.Font");
            this.labelHeight.Image = (System.Drawing.Image)resources.GetObject("labelHeight.Image");
            this.labelHeight.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("labelHeight.ImageAlign");
            this.labelHeight.ImageIndex = System.Convert.ToInt32(resources.GetObject("labelHeight.ImageIndex"));
            this.labelHeight.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("labelHeight.ImeMode");
            this.labelHeight.Location = (System.Drawing.Point)resources.GetObject("labelHeight.Location");
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("labelHeight.RightToLeft");
            this.labelHeight.Size = (System.Drawing.Size)resources.GetObject("labelHeight.Size");
            this.labelHeight.TabIndex = System.Convert.ToInt32(resources.GetObject("labelHeight.TabIndex"));
            this.labelHeight.Text = resources.GetString("labelHeight.Text");
            this.labelHeight.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("labelHeight.TextAlign");
            this.labelHeight.Visible = System.Convert.ToBoolean(resources.GetObject("labelHeight.Visible"));
            //
            // textBoxHeight
            //
            this.textBoxHeight.AccessibleDescription = resources.GetString("textBoxHeight.AccessibleDescription");
            this.textBoxHeight.AccessibleName = resources.GetString("textBoxHeight.AccessibleName");
            this.textBoxHeight.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("textBoxHeight.Anchor");
            this.textBoxHeight.AutoSize = System.Convert.ToBoolean(resources.GetObject("textBoxHeight.AutoSize"));
            this.textBoxHeight.BackgroundImage = (System.Drawing.Image)resources.GetObject("textBoxHeight.BackgroundImage");
            this.textBoxHeight.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("textBoxHeight.Dock");
            this.textBoxHeight.Enabled = System.Convert.ToBoolean(resources.GetObject("textBoxHeight.Enabled"));
            this.textBoxHeight.Font = (System.Drawing.Font)resources.GetObject("textBoxHeight.Font");
            this.textBoxHeight.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("textBoxHeight.ImeMode");
            this.textBoxHeight.Location = (System.Drawing.Point)resources.GetObject("textBoxHeight.Location");
            this.textBoxHeight.MaxLength = System.Convert.ToInt32(resources.GetObject("textBoxHeight.MaxLength"));
            this.textBoxHeight.Multiline = System.Convert.ToBoolean(resources.GetObject("textBoxHeight.Multiline"));
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.PasswordChar = System.Convert.ToChar(resources.GetObject("textBoxHeight.PasswordChar"));
            this.textBoxHeight.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("textBoxHeight.RightToLeft");
            this.textBoxHeight.ScrollBars = (System.Windows.Forms.ScrollBars)resources.GetObject("textBoxHeight.ScrollBars");
            this.textBoxHeight.Size = (System.Drawing.Size)resources.GetObject("textBoxHeight.Size");
            this.textBoxHeight.TabIndex = System.Convert.ToInt32(resources.GetObject("textBoxHeight.TabIndex"));
            this.textBoxHeight.Text = resources.GetString("textBoxHeight.Text");
            this.textBoxHeight.TextAlign = (System.Windows.Forms.HorizontalAlignment)resources.GetObject("textBoxHeight.TextAlign");
            this.textBoxHeight.Visible = System.Convert.ToBoolean(resources.GetObject("textBoxHeight.Visible"));
            this.textBoxHeight.WordWrap = System.Convert.ToBoolean(resources.GetObject("textBoxHeight.WordWrap"));
            //
            // labelResolution
            //
            this.labelResolution.AccessibleDescription = resources.GetString("labelResolution.AccessibleDescription");
            this.labelResolution.AccessibleName = resources.GetString("labelResolution.AccessibleName");
            this.labelResolution.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("labelResolution.Anchor");
            this.labelResolution.AutoSize = System.Convert.ToBoolean(resources.GetObject("labelResolution.AutoSize"));
            this.labelResolution.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("labelResolution.Dock");
            this.labelResolution.Enabled = System.Convert.ToBoolean(resources.GetObject("labelResolution.Enabled"));
            this.labelResolution.Font = (System.Drawing.Font)resources.GetObject("labelResolution.Font");
            this.labelResolution.Image = (System.Drawing.Image)resources.GetObject("labelResolution.Image");
            this.labelResolution.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("labelResolution.ImageAlign");
            this.labelResolution.ImageIndex = System.Convert.ToInt32(resources.GetObject("labelResolution.ImageIndex"));
            this.labelResolution.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("labelResolution.ImeMode");
            this.labelResolution.Location = (System.Drawing.Point)resources.GetObject("labelResolution.Location");
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("labelResolution.RightToLeft");
            this.labelResolution.Size = (System.Drawing.Size)resources.GetObject("labelResolution.Size");
            this.labelResolution.TabIndex = System.Convert.ToInt32(resources.GetObject("labelResolution.TabIndex"));
            this.labelResolution.Text = resources.GetString("labelResolution.Text");
            this.labelResolution.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("labelResolution.TextAlign");
            this.labelResolution.Visible = System.Convert.ToBoolean(resources.GetObject("labelResolution.Visible"));
            //
            // comboBoxResolution
            //
            this.comboBoxResolution.AccessibleDescription = resources.GetString("comboBoxResolution.AccessibleDescription");
            this.comboBoxResolution.AccessibleName = resources.GetString("comboBoxResolution.AccessibleName");
            this.comboBoxResolution.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("comboBoxResolution.Anchor");
            this.comboBoxResolution.BackgroundImage = (System.Drawing.Image)resources.GetObject("comboBoxResolution.BackgroundImage");
            this.comboBoxResolution.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("comboBoxResolution.Dock");
            this.comboBoxResolution.Enabled = System.Convert.ToBoolean(resources.GetObject("comboBoxResolution.Enabled"));
            this.comboBoxResolution.Font = (System.Drawing.Font)resources.GetObject("comboBoxResolution.Font");
            this.comboBoxResolution.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("comboBoxResolution.ImeMode");
            this.comboBoxResolution.IntegralHeight = System.Convert.ToBoolean(resources.GetObject("comboBoxResolution.IntegralHeight"));
            this.comboBoxResolution.ItemHeight = System.Convert.ToInt32(resources.GetObject("comboBoxResolution.ItemHeight"));
            this.comboBoxResolution.Items.AddRange(new object[] { resources.GetString("comboBoxResolution.Items"), resources.GetString("comboBoxResolution.Items1"), resources.GetString("comboBoxResolution.Items2"), resources.GetString("comboBoxResolution.Items3"), resources.GetString("comboBoxResolution.Items4") });
            this.comboBoxResolution.Location = (System.Drawing.Point)resources.GetObject("comboBoxResolution.Location");
            this.comboBoxResolution.MaxDropDownItems = System.Convert.ToInt32(resources.GetObject("comboBoxResolution.MaxDropDownItems"));
            this.comboBoxResolution.MaxLength = System.Convert.ToInt32(resources.GetObject("comboBoxResolution.MaxLength"));
            this.comboBoxResolution.Name = "comboBoxResolution";
            this.comboBoxResolution.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("comboBoxResolution.RightToLeft");
            this.comboBoxResolution.Size = (System.Drawing.Size)resources.GetObject("comboBoxResolution.Size");
            this.comboBoxResolution.TabIndex = System.Convert.ToInt32(resources.GetObject("comboBoxResolution.TabIndex"));
            this.comboBoxResolution.Text = resources.GetString("comboBoxResolution.Text");
            this.comboBoxResolution.Visible = System.Convert.ToBoolean(resources.GetObject("comboBoxResolution.Visible"));
            //
            // labelMode
            //
            this.labelMode.AccessibleDescription = resources.GetString("labelMode.AccessibleDescription");
            this.labelMode.AccessibleName = resources.GetString("labelMode.AccessibleName");
            this.labelMode.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("labelMode.Anchor");
            this.labelMode.AutoSize = System.Convert.ToBoolean(resources.GetObject("labelMode.AutoSize"));
            this.labelMode.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("labelMode.Dock");
            this.labelMode.Enabled = System.Convert.ToBoolean(resources.GetObject("labelMode.Enabled"));
            this.labelMode.Font = (System.Drawing.Font)resources.GetObject("labelMode.Font");
            this.labelMode.Image = (System.Drawing.Image)resources.GetObject("labelMode.Image");
            this.labelMode.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("labelMode.ImageAlign");
            this.labelMode.ImageIndex = System.Convert.ToInt32(resources.GetObject("labelMode.ImageIndex"));
            this.labelMode.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("labelMode.ImeMode");
            this.labelMode.Location = (System.Drawing.Point)resources.GetObject("labelMode.Location");
            this.labelMode.Name = "labelMode";
            this.labelMode.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("labelMode.RightToLeft");
            this.labelMode.Size = (System.Drawing.Size)resources.GetObject("labelMode.Size");
            this.labelMode.TabIndex = System.Convert.ToInt32(resources.GetObject("labelMode.TabIndex"));
            this.labelMode.Text = resources.GetString("labelMode.Text");
            this.labelMode.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("labelMode.TextAlign");
            this.labelMode.Visible = System.Convert.ToBoolean(resources.GetObject("labelMode.Visible"));
            //
            // comboBoxMode
            //
            this.comboBoxMode.AccessibleDescription = resources.GetString("comboBoxMode.AccessibleDescription");
            this.comboBoxMode.AccessibleName = resources.GetString("comboBoxMode.AccessibleName");
            this.comboBoxMode.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("comboBoxMode.Anchor");
            this.comboBoxMode.BackgroundImage = (System.Drawing.Image)resources.GetObject("comboBoxMode.BackgroundImage");
            this.comboBoxMode.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("comboBoxMode.Dock");
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.Enabled = System.Convert.ToBoolean(resources.GetObject("comboBoxMode.Enabled"));
            this.comboBoxMode.Font = (System.Drawing.Font)resources.GetObject("comboBoxMode.Font");
            this.comboBoxMode.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("comboBoxMode.ImeMode");
            this.comboBoxMode.IntegralHeight = System.Convert.ToBoolean(resources.GetObject("comboBoxMode.IntegralHeight"));
            this.comboBoxMode.ItemHeight = System.Convert.ToInt32(resources.GetObject("comboBoxMode.ItemHeight"));
            this.comboBoxMode.Items.AddRange(new object[] { resources.GetString("comboBoxMode.Items"), resources.GetString("comboBoxMode.Items1"), resources.GetString("comboBoxMode.Items2"), resources.GetString("comboBoxMode.Items3"), resources.GetString("comboBoxMode.Items4") });
            this.comboBoxMode.Location = (System.Drawing.Point)resources.GetObject("comboBoxMode.Location");
            this.comboBoxMode.MaxDropDownItems = System.Convert.ToInt32(resources.GetObject("comboBoxMode.MaxDropDownItems"));
            this.comboBoxMode.MaxLength = System.Convert.ToInt32(resources.GetObject("comboBoxMode.MaxLength"));
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("comboBoxMode.RightToLeft");
            this.comboBoxMode.Size = (System.Drawing.Size)resources.GetObject("comboBoxMode.Size");
            this.comboBoxMode.TabIndex = System.Convert.ToInt32(resources.GetObject("comboBoxMode.TabIndex"));
            this.comboBoxMode.Text = resources.GetString("comboBoxMode.Text");
            this.comboBoxMode.Visible = System.Convert.ToBoolean(resources.GetObject("comboBoxMode.Visible"));
            //
            // labelBitsPerChannel
            //
            this.labelBitsPerChannel.AccessibleDescription = resources.GetString("labelBitsPerChannel.AccessibleDescription");
            this.labelBitsPerChannel.AccessibleName = resources.GetString("labelBitsPerChannel.AccessibleName");
            this.labelBitsPerChannel.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("labelBitsPerChannel.Anchor");
            this.labelBitsPerChannel.AutoSize = System.Convert.ToBoolean(resources.GetObject("labelBitsPerChannel.AutoSize"));
            this.labelBitsPerChannel.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("labelBitsPerChannel.Dock");
            this.labelBitsPerChannel.Enabled = System.Convert.ToBoolean(resources.GetObject("labelBitsPerChannel.Enabled"));
            this.labelBitsPerChannel.Font = (System.Drawing.Font)resources.GetObject("labelBitsPerChannel.Font");
            this.labelBitsPerChannel.Image = (System.Drawing.Image)resources.GetObject("labelBitsPerChannel.Image");
            this.labelBitsPerChannel.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("labelBitsPerChannel.ImageAlign");
            this.labelBitsPerChannel.ImageIndex = System.Convert.ToInt32(resources.GetObject("labelBitsPerChannel.ImageIndex"));
            this.labelBitsPerChannel.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("labelBitsPerChannel.ImeMode");
            this.labelBitsPerChannel.Location = (System.Drawing.Point)resources.GetObject("labelBitsPerChannel.Location");
            this.labelBitsPerChannel.Name = "labelBitsPerChannel";
            this.labelBitsPerChannel.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("labelBitsPerChannel.RightToLeft");
            this.labelBitsPerChannel.Size = (System.Drawing.Size)resources.GetObject("labelBitsPerChannel.Size");
            this.labelBitsPerChannel.TabIndex = System.Convert.ToInt32(resources.GetObject("labelBitsPerChannel.TabIndex"));
            this.labelBitsPerChannel.Text = resources.GetString("labelBitsPerChannel.Text");
            this.labelBitsPerChannel.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("labelBitsPerChannel.TextAlign");
            this.labelBitsPerChannel.Visible = System.Convert.ToBoolean(resources.GetObject("labelBitsPerChannel.Visible"));
            //
            // comboBoxColorDepth
            //
            this.comboBoxColorDepth.AccessibleDescription = resources.GetString("comboBoxColorDepth.AccessibleDescription");
            this.comboBoxColorDepth.AccessibleName = resources.GetString("comboBoxColorDepth.AccessibleName");
            this.comboBoxColorDepth.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("comboBoxColorDepth.Anchor");
            this.comboBoxColorDepth.BackgroundImage = (System.Drawing.Image)resources.GetObject("comboBoxColorDepth.BackgroundImage");
            this.comboBoxColorDepth.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("comboBoxColorDepth.Dock");
            this.comboBoxColorDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColorDepth.Enabled = System.Convert.ToBoolean(resources.GetObject("comboBoxColorDepth.Enabled"));
            this.comboBoxColorDepth.Font = (System.Drawing.Font)resources.GetObject("comboBoxColorDepth.Font");
            this.comboBoxColorDepth.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("comboBoxColorDepth.ImeMode");
            this.comboBoxColorDepth.IntegralHeight = System.Convert.ToBoolean(resources.GetObject("comboBoxColorDepth.IntegralHeight"));
            this.comboBoxColorDepth.ItemHeight = System.Convert.ToInt32(resources.GetObject("comboBoxColorDepth.ItemHeight"));
            this.comboBoxColorDepth.Items.AddRange(new object[] { resources.GetString("comboBoxColorDepth.Items"), resources.GetString("comboBoxColorDepth.Items1") });
            this.comboBoxColorDepth.Location = (System.Drawing.Point)resources.GetObject("comboBoxColorDepth.Location");
            this.comboBoxColorDepth.MaxDropDownItems = System.Convert.ToInt32(resources.GetObject("comboBoxColorDepth.MaxDropDownItems"));
            this.comboBoxColorDepth.MaxLength = System.Convert.ToInt32(resources.GetObject("comboBoxColorDepth.MaxLength"));
            this.comboBoxColorDepth.Name = "comboBoxColorDepth";
            this.comboBoxColorDepth.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("comboBoxColorDepth.RightToLeft");
            this.comboBoxColorDepth.Size = (System.Drawing.Size)resources.GetObject("comboBoxColorDepth.Size");
            this.comboBoxColorDepth.TabIndex = System.Convert.ToInt32(resources.GetObject("comboBoxColorDepth.TabIndex"));
            this.comboBoxColorDepth.Text = resources.GetString("comboBoxColorDepth.Text");
            this.comboBoxColorDepth.Visible = System.Convert.ToBoolean(resources.GetObject("comboBoxColorDepth.Visible"));
            //
            // checkBoxAlpha
            //
            this.checkBoxAlpha.AccessibleDescription = resources.GetString("checkBoxAlpha.AccessibleDescription");
            this.checkBoxAlpha.AccessibleName = resources.GetString("checkBoxAlpha.AccessibleName");
            this.checkBoxAlpha.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("checkBoxAlpha.Anchor");
            this.checkBoxAlpha.Appearance = (System.Windows.Forms.Appearance)resources.GetObject("checkBoxAlpha.Appearance");
            this.checkBoxAlpha.BackgroundImage = (System.Drawing.Image)resources.GetObject("checkBoxAlpha.BackgroundImage");
            this.checkBoxAlpha.CheckAlign = (System.Drawing.ContentAlignment)resources.GetObject("checkBoxAlpha.CheckAlign");
            this.checkBoxAlpha.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("checkBoxAlpha.Dock");
            this.checkBoxAlpha.Enabled = System.Convert.ToBoolean(resources.GetObject("checkBoxAlpha.Enabled"));
            this.checkBoxAlpha.FlatStyle = (System.Windows.Forms.FlatStyle)resources.GetObject("checkBoxAlpha.FlatStyle");
            this.checkBoxAlpha.Font = (System.Drawing.Font)resources.GetObject("checkBoxAlpha.Font");
            this.checkBoxAlpha.Image = (System.Drawing.Image)resources.GetObject("checkBoxAlpha.Image");
            this.checkBoxAlpha.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("checkBoxAlpha.ImageAlign");
            this.checkBoxAlpha.ImageIndex = System.Convert.ToInt32(resources.GetObject("checkBoxAlpha.ImageIndex"));
            this.checkBoxAlpha.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("checkBoxAlpha.ImeMode");
            this.checkBoxAlpha.Location = (System.Drawing.Point)resources.GetObject("checkBoxAlpha.Location");
            this.checkBoxAlpha.Name = "checkBoxAlpha";
            this.checkBoxAlpha.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("checkBoxAlpha.RightToLeft");
            this.checkBoxAlpha.Size = (System.Drawing.Size)resources.GetObject("checkBoxAlpha.Size");
            this.checkBoxAlpha.TabIndex = System.Convert.ToInt32(resources.GetObject("checkBoxAlpha.TabIndex"));
            this.checkBoxAlpha.Text = resources.GetString("checkBoxAlpha.Text");
            this.checkBoxAlpha.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("checkBoxAlpha.TextAlign");
            this.checkBoxAlpha.Visible = System.Convert.ToBoolean(resources.GetObject("checkBoxAlpha.Visible"));
            //
            // NewImage
            //
            this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
            this.AccessibleName = resources.GetString("$this.AccessibleName");
            this.AutoScaleBaseSize = (System.Drawing.Size)resources.GetObject("$this.AutoScaleBaseSize");
            this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
            this.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMargin");
            this.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMinSize");
            this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            this.ClientSize = (System.Drawing.Size)resources.GetObject("$this.ClientSize");
            this.Controls.Add(this.checkBoxAlpha);
            this.Controls.Add(this.comboBoxColorDepth);
            this.Controls.Add(this.labelBitsPerChannel);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.comboBoxResolution);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
            this.Font = (System.Drawing.Font)resources.GetObject("$this.Font");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("$this.ImeMode");
            this.Location = (System.Drawing.Point)resources.GetObject("$this.Location");
            this.MaximizeBox = false;
            this.MaximumSize = (System.Drawing.Size)resources.GetObject("$this.MaximumSize");
            this.MinimizeBox = false;
            this.MinimumSize = (System.Drawing.Size)resources.GetObject("$this.MinimumSize");
            this.Name = "NewImage";
            this.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("$this.RightToLeft");
            this.StartPosition = (System.Windows.Forms.FormStartPosition)resources.GetObject("$this.StartPosition");
            this.Text = resources.GetString("$this.Text");
            this.ResumeLayout(false);
        }

        #endregion " Windows Form Designer generated code "

        public int ImageWidth
        {
            get
            {
                try
                {
                    return int.Parse(textBoxWidth.Text, new System.Globalization.NumberFormatInfo());
                }
                catch (FormatException)
                {
                    return 0;
                }
            }
        }

        public int ImageHeight
        {
            get
            {
                try
                {
                    return int.Parse(textBoxHeight.Text, new System.Globalization.NumberFormatInfo());
                }
                catch (FormatException)
                {
                    return 0;
                }
            }
        }

        public int ImageResolution
        {
            get
            {
                try
                {
                    return Convert.ToInt32(comboBoxResolution.Text, new System.Globalization.NumberFormatInfo());
                }
                catch (FormatException)
                {
                    return 72;
                }
            }
        }

        public PixelFormat PixelFormat
        {
            get
            {
                bool extended = comboBoxColorDepth.SelectedIndex == 1;
                if (comboBoxMode.SelectedIndex == 1)
                {
                    // "Grayscale"
                    if (extended)
                    {
                        if (checkBoxAlpha.Checked)
                        {
                            return PixelFormat.Format32bppAgrayscale;
                        }
                        else
                        {
                            return PixelFormat.Format16bppGrayscale;
                        }
                    }
                    else
                    {
                        if (checkBoxAlpha.Checked)
                        {
                            return PixelFormat.Format16bppAgrayscale;
                        }
                        else
                        {
                            return PixelFormat.Format8bppGrayscale;
                        }
                    }
                }
                else if (comboBoxMode.SelectedIndex == 2)
                {
                    // "CMYK"
                    if (extended)
                    {
                        if (checkBoxAlpha.Checked)
                        {
                            return PixelFormat.Format80bppAcmyk;
                        }
                        else
                        {
                            return PixelFormat.Format64bppCmyk;
                        }
                    }
                    else
                    {
                        if (checkBoxAlpha.Checked)
                        {
                            return PixelFormat.Format40bppAcmyk;
                        }
                        else
                        {
                            return PixelFormat.Format32bppCmyk;
                        }
                    }
                }
                else if (comboBoxMode.SelectedIndex == 3)
                {
                    // "Indexed (WebSafe Palette)"
                    return PixelFormat.Format8bppIndexed;
                }
                else if (comboBoxMode.SelectedIndex == 4)
                {
                    // "Bitmap (1 bit)"
                    return PixelFormat.Format1bppIndexed;
                }
                else
                {
                    // 5 "RGB"
                    if (extended)
                    {
                        if (checkBoxAlpha.Checked)
                        {
                            return PixelFormat.Format64bppArgb;
                        }
                        else
                        {
                            return PixelFormat.Format48bppRgb;
                        }
                    }
                    else
                    {
                        if (checkBoxAlpha.Checked)
                        {
                            return PixelFormat.Format32bppArgb;
                        }
                        else
                        {
                            return PixelFormat.Format24bppRgb;
                        }
                    }
                }
            }
        }

        private static bool ValidateSize(TextBox textBoxSize, string name)
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NewImage));
            try
            {
                int width = int.Parse(textBoxSize.Text, new System.Globalization.NumberFormatInfo());
                if (width < 1)
                {
                    MessageBox.Show(name + " is less than minimum", "Image properties error");
                    textBoxSize.Focus();
                    return false;
                }
                if (width > 30000)
                {
                    MessageBox.Show(name + " is more than maximum", "Image properties error");
                    textBoxSize.Focus();
                    return false;
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show(name + " field has incorrect format", "Image properties error");
                textBoxSize.Focus();
                return false;
            }

            return true;
        }

        private void buttonAccept_Click(System.Object sender, System.EventArgs e)
        {
            if (ValidateSize(textBoxWidth, "Width") && ValidateSize(textBoxHeight, "Height"))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void buttonCancel_Click(System.Object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void comboBoxMode_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (comboBoxMode.SelectedIndex <= 2) // RGB Grayscale CMYK
            {
                comboBoxColorDepth.Enabled = true;
                checkBoxAlpha.Enabled = true;
            }
            else // Indexed (WebSafe Palette) Bitmap (1 bit)
            {
                comboBoxColorDepth.Enabled = false;
                checkBoxAlpha.Enabled = false;
            }
        }
    }
}