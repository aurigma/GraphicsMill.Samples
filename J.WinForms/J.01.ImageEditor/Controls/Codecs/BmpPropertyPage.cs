using Aurigma.GraphicsMill.Codecs;

namespace Main
{
    public class BmpPropertyPage : System.Windows.Forms.UserControl, IEncoderPropertyPage
    {
        #region " Windows Form Designer generated code "

        public BmpPropertyPage()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call
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
        internal System.Windows.Forms.CheckBox CheckBoxCompressed;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BmpPropertyPage));
            this.CheckBoxCompressed = new System.Windows.Forms.CheckBox();
            this.CheckBoxCompressed.CheckedChanged += new System.EventHandler(CheckBoxCompressed_CheckedChanged);
            this.SuspendLayout();
            //
            // CheckBoxCompressed
            //
            this.CheckBoxCompressed.AccessibleDescription = resources.GetString("CheckBoxCompressed.AccessibleDescription");
            this.CheckBoxCompressed.AccessibleName = resources.GetString("CheckBoxCompressed.AccessibleName");
            this.CheckBoxCompressed.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("CheckBoxCompressed.Anchor");
            this.CheckBoxCompressed.Appearance = (System.Windows.Forms.Appearance)resources.GetObject("CheckBoxCompressed.Appearance");
            this.CheckBoxCompressed.BackgroundImage = (System.Drawing.Image)resources.GetObject("CheckBoxCompressed.BackgroundImage");
            this.CheckBoxCompressed.CheckAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxCompressed.CheckAlign");
            this.CheckBoxCompressed.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("CheckBoxCompressed.Dock");
            this.CheckBoxCompressed.Enabled = System.Convert.ToBoolean(resources.GetObject("CheckBoxCompressed.Enabled"));
            this.CheckBoxCompressed.FlatStyle = (System.Windows.Forms.FlatStyle)resources.GetObject("CheckBoxCompressed.FlatStyle");
            this.CheckBoxCompressed.Font = (System.Drawing.Font)resources.GetObject("CheckBoxCompressed.Font");
            this.CheckBoxCompressed.Image = (System.Drawing.Image)resources.GetObject("CheckBoxCompressed.Image");
            this.CheckBoxCompressed.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxCompressed.ImageAlign");
            this.CheckBoxCompressed.ImageIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxCompressed.ImageIndex"));
            this.CheckBoxCompressed.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("CheckBoxCompressed.ImeMode");
            this.CheckBoxCompressed.Location = (System.Drawing.Point)resources.GetObject("CheckBoxCompressed.Location");
            this.CheckBoxCompressed.Name = "CheckBoxCompressed";
            this.CheckBoxCompressed.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("CheckBoxCompressed.RightToLeft");
            this.CheckBoxCompressed.Size = (System.Drawing.Size)resources.GetObject("CheckBoxCompressed.Size");
            this.CheckBoxCompressed.TabIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxCompressed.TabIndex"));
            this.CheckBoxCompressed.Text = resources.GetString("CheckBoxCompressed.Text");
            this.CheckBoxCompressed.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxCompressed.TextAlign");
            this.CheckBoxCompressed.Visible = System.Convert.ToBoolean(resources.GetObject("CheckBoxCompressed.Visible"));
            //
            // BmpPropertyPage
            //
            this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
            this.AccessibleName = resources.GetString("$this.AccessibleName");
            this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
            this.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMargin");
            this.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMinSize");
            this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            this.Controls.Add(this.CheckBoxCompressed);
            this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
            this.Font = (System.Drawing.Font)resources.GetObject("$this.Font");
            this.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("$this.ImeMode");
            this.Location = (System.Drawing.Point)resources.GetObject("$this.Location");
            this.Name = "BmpPropertyPage";
            this.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("$this.RightToLeft");
            this.Size = (System.Drawing.Size)resources.GetObject("$this.Size");
            this.ResumeLayout(false);
        }

        #endregion " Windows Form Designer generated code "

        private Aurigma.GraphicsMill.Bitmap _bitmap;
        private BmpSettings _encoderOptions;

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
                _encoderOptions = (BmpSettings)value;
                CheckBoxCompressed.Checked = _encoderOptions.Compression != CompressionType.None;
            }
        }

        public string Title
        {
            get
            {
                return "BMP File Format";
            }
        }

        private void CheckBoxCompressed_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (!(_encoderOptions == null))
            {
                if (CheckBoxCompressed.Checked)
                {
                    _encoderOptions.Compression = CompressionType.Rle;
                }
                else
                {
                    _encoderOptions.Compression = CompressionType.None;
                }
            }
        }
    }
}