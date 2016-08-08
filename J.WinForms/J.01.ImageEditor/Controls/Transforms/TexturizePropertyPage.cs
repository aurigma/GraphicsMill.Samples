using Aurigma.GraphicsMill.Transforms;

namespace Main
{
    public class TexturizePropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
    {
        #region " Windows Form Designer generated code "

        public TexturizePropertyPage()
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
        internal TrackBarText TrackBarTextRowCount;

        internal TrackBarText TrackBarTextColumnCount;
        internal TrackBarText TrackBarTextHorizontalInteresection;
        internal TrackBarText TrackBarTextVerticalInteresection;
        internal System.Windows.Forms.CheckBox CheckBoxSeamless;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TexturizePropertyPage));
            this.TrackBarTextHorizontalInteresection = new Main.TrackBarText();
            this.TrackBarTextColumnCount = new Main.TrackBarText();
            this.TrackBarTextRowCount = new Main.TrackBarText();
            this.TrackBarTextVerticalInteresection = new Main.TrackBarText();
            this.CheckBoxSeamless = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            //
            // TrackBarTextHorizontalInteresection
            //
            this.TrackBarTextHorizontalInteresection.AccessibleDescription = resources.GetString("TrackBarTextHorizontalInteresection.AccessibleDescription");
            this.TrackBarTextHorizontalInteresection.AccessibleName = resources.GetString("TrackBarTextHorizontalInteresection.AccessibleName");
            this.TrackBarTextHorizontalInteresection.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("TrackBarTextHorizontalInteresection.Anchor");
            this.TrackBarTextHorizontalInteresection.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextHorizontalInteresection.AutoScroll"));
            this.TrackBarTextHorizontalInteresection.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("TrackBarTextHorizontalInteresection.AutoScrollMargin");
            this.TrackBarTextHorizontalInteresection.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("TrackBarTextHorizontalInteresection.AutoScrollMinSize");
            this.TrackBarTextHorizontalInteresection.BackgroundImage = (System.Drawing.Image)resources.GetObject("TrackBarTextHorizontalInteresection.BackgroundImage");
            this.TrackBarTextHorizontalInteresection.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("TrackBarTextHorizontalInteresection.Dock");
            this.TrackBarTextHorizontalInteresection.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextHorizontalInteresection.Enabled"));
            this.TrackBarTextHorizontalInteresection.Font = (System.Drawing.Font)resources.GetObject("TrackBarTextHorizontalInteresection.Font");
            this.TrackBarTextHorizontalInteresection.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("TrackBarTextHorizontalInteresection.ImeMode");
            this.TrackBarTextHorizontalInteresection.Location = (System.Drawing.Point)resources.GetObject("TrackBarTextHorizontalInteresection.Location");
            this.TrackBarTextHorizontalInteresection.Maximum = 50;
            this.TrackBarTextHorizontalInteresection.Minimum = 0;
            this.TrackBarTextHorizontalInteresection.Name = "TrackBarTextHorizontalInteresection";
            this.TrackBarTextHorizontalInteresection.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TrackBarTextHorizontalInteresection.RightToLeft");
            this.TrackBarTextHorizontalInteresection.Size = (System.Drawing.Size)resources.GetObject("TrackBarTextHorizontalInteresection.Size");
            this.TrackBarTextHorizontalInteresection.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextHorizontalInteresection.TabIndex"));
            this.TrackBarTextHorizontalInteresection.Text = resources.GetString("TrackBarTextHorizontalInteresection.Text");
            this.TrackBarTextHorizontalInteresection.TickFrequency = 5;
            this.TrackBarTextHorizontalInteresection.Unit = "%";
            this.TrackBarTextHorizontalInteresection.Value = 20;
            this.TrackBarTextHorizontalInteresection.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextHorizontalInteresection.Visible"));
            //
            // TrackBarTextColumnCount
            //
            this.TrackBarTextColumnCount.AccessibleDescription = resources.GetString("TrackBarTextColumnCount.AccessibleDescription");
            this.TrackBarTextColumnCount.AccessibleName = resources.GetString("TrackBarTextColumnCount.AccessibleName");
            this.TrackBarTextColumnCount.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("TrackBarTextColumnCount.Anchor");
            this.TrackBarTextColumnCount.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextColumnCount.AutoScroll"));
            this.TrackBarTextColumnCount.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("TrackBarTextColumnCount.AutoScrollMargin");
            this.TrackBarTextColumnCount.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("TrackBarTextColumnCount.AutoScrollMinSize");
            this.TrackBarTextColumnCount.BackgroundImage = (System.Drawing.Image)resources.GetObject("TrackBarTextColumnCount.BackgroundImage");
            this.TrackBarTextColumnCount.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("TrackBarTextColumnCount.Dock");
            this.TrackBarTextColumnCount.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextColumnCount.Enabled"));
            this.TrackBarTextColumnCount.Font = (System.Drawing.Font)resources.GetObject("TrackBarTextColumnCount.Font");
            this.TrackBarTextColumnCount.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("TrackBarTextColumnCount.ImeMode");
            this.TrackBarTextColumnCount.Location = (System.Drawing.Point)resources.GetObject("TrackBarTextColumnCount.Location");
            this.TrackBarTextColumnCount.Maximum = 10;
            this.TrackBarTextColumnCount.Minimum = 1;
            this.TrackBarTextColumnCount.Name = "TrackBarTextColumnCount";
            this.TrackBarTextColumnCount.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TrackBarTextColumnCount.RightToLeft");
            this.TrackBarTextColumnCount.Size = (System.Drawing.Size)resources.GetObject("TrackBarTextColumnCount.Size");
            this.TrackBarTextColumnCount.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextColumnCount.TabIndex"));
            this.TrackBarTextColumnCount.Text = resources.GetString("TrackBarTextColumnCount.Text");
            this.TrackBarTextColumnCount.TickFrequency = 1;
            this.TrackBarTextColumnCount.Unit = string.Empty;
            this.TrackBarTextColumnCount.Value = 3;
            this.TrackBarTextColumnCount.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextColumnCount.Visible"));
            //
            // TrackBarTextRowCount
            //
            this.TrackBarTextRowCount.AccessibleDescription = resources.GetString("TrackBarTextRowCount.AccessibleDescription");
            this.TrackBarTextRowCount.AccessibleName = resources.GetString("TrackBarTextRowCount.AccessibleName");
            this.TrackBarTextRowCount.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("TrackBarTextRowCount.Anchor");
            this.TrackBarTextRowCount.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextRowCount.AutoScroll"));
            this.TrackBarTextRowCount.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("TrackBarTextRowCount.AutoScrollMargin");
            this.TrackBarTextRowCount.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("TrackBarTextRowCount.AutoScrollMinSize");
            this.TrackBarTextRowCount.BackgroundImage = (System.Drawing.Image)resources.GetObject("TrackBarTextRowCount.BackgroundImage");
            this.TrackBarTextRowCount.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("TrackBarTextRowCount.Dock");
            this.TrackBarTextRowCount.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextRowCount.Enabled"));
            this.TrackBarTextRowCount.Font = (System.Drawing.Font)resources.GetObject("TrackBarTextRowCount.Font");
            this.TrackBarTextRowCount.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("TrackBarTextRowCount.ImeMode");
            this.TrackBarTextRowCount.Location = (System.Drawing.Point)resources.GetObject("TrackBarTextRowCount.Location");
            this.TrackBarTextRowCount.Maximum = 10;
            this.TrackBarTextRowCount.Minimum = 1;
            this.TrackBarTextRowCount.Name = "TrackBarTextRowCount";
            this.TrackBarTextRowCount.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TrackBarTextRowCount.RightToLeft");
            this.TrackBarTextRowCount.Size = (System.Drawing.Size)resources.GetObject("TrackBarTextRowCount.Size");
            this.TrackBarTextRowCount.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextRowCount.TabIndex"));
            this.TrackBarTextRowCount.Text = resources.GetString("TrackBarTextRowCount.Text");
            this.TrackBarTextRowCount.TickFrequency = 1;
            this.TrackBarTextRowCount.Unit = string.Empty;
            this.TrackBarTextRowCount.Value = 3;
            this.TrackBarTextRowCount.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextRowCount.Visible"));
            //
            // TrackBarTextVerticalInteresection
            //
            this.TrackBarTextVerticalInteresection.AccessibleDescription = resources.GetString("TrackBarTextVerticalInteresection.AccessibleDescription");
            this.TrackBarTextVerticalInteresection.AccessibleName = resources.GetString("TrackBarTextVerticalInteresection.AccessibleName");
            this.TrackBarTextVerticalInteresection.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("TrackBarTextVerticalInteresection.Anchor");
            this.TrackBarTextVerticalInteresection.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextVerticalInteresection.AutoScroll"));
            this.TrackBarTextVerticalInteresection.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("TrackBarTextVerticalInteresection.AutoScrollMargin");
            this.TrackBarTextVerticalInteresection.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("TrackBarTextVerticalInteresection.AutoScrollMinSize");
            this.TrackBarTextVerticalInteresection.BackgroundImage = (System.Drawing.Image)resources.GetObject("TrackBarTextVerticalInteresection.BackgroundImage");
            this.TrackBarTextVerticalInteresection.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("TrackBarTextVerticalInteresection.Dock");
            this.TrackBarTextVerticalInteresection.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextVerticalInteresection.Enabled"));
            this.TrackBarTextVerticalInteresection.Font = (System.Drawing.Font)resources.GetObject("TrackBarTextVerticalInteresection.Font");
            this.TrackBarTextVerticalInteresection.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("TrackBarTextVerticalInteresection.ImeMode");
            this.TrackBarTextVerticalInteresection.Location = (System.Drawing.Point)resources.GetObject("TrackBarTextVerticalInteresection.Location");
            this.TrackBarTextVerticalInteresection.Maximum = 50;
            this.TrackBarTextVerticalInteresection.Minimum = 0;
            this.TrackBarTextVerticalInteresection.Name = "TrackBarTextVerticalInteresection";
            this.TrackBarTextVerticalInteresection.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TrackBarTextVerticalInteresection.RightToLeft");
            this.TrackBarTextVerticalInteresection.Size = (System.Drawing.Size)resources.GetObject("TrackBarTextVerticalInteresection.Size");
            this.TrackBarTextVerticalInteresection.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextVerticalInteresection.TabIndex"));
            this.TrackBarTextVerticalInteresection.Text = resources.GetString("TrackBarTextVerticalInteresection.Text");
            this.TrackBarTextVerticalInteresection.TickFrequency = 5;
            this.TrackBarTextVerticalInteresection.Unit = "%";
            this.TrackBarTextVerticalInteresection.Value = 20;
            this.TrackBarTextVerticalInteresection.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextVerticalInteresection.Visible"));
            //
            // CheckBoxSeamless
            //
            this.CheckBoxSeamless.AccessibleDescription = resources.GetString("CheckBoxSeamless.AccessibleDescription");
            this.CheckBoxSeamless.AccessibleName = resources.GetString("CheckBoxSeamless.AccessibleName");
            this.CheckBoxSeamless.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("CheckBoxSeamless.Anchor");
            this.CheckBoxSeamless.Appearance = (System.Windows.Forms.Appearance)resources.GetObject("CheckBoxSeamless.Appearance");
            this.CheckBoxSeamless.BackgroundImage = (System.Drawing.Image)resources.GetObject("CheckBoxSeamless.BackgroundImage");
            this.CheckBoxSeamless.CheckAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxSeamless.CheckAlign");
            this.CheckBoxSeamless.Checked = true;
            this.CheckBoxSeamless.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxSeamless.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("CheckBoxSeamless.Dock");
            this.CheckBoxSeamless.Enabled = System.Convert.ToBoolean(resources.GetObject("CheckBoxSeamless.Enabled"));
            this.CheckBoxSeamless.FlatStyle = (System.Windows.Forms.FlatStyle)resources.GetObject("CheckBoxSeamless.FlatStyle");
            this.CheckBoxSeamless.Font = (System.Drawing.Font)resources.GetObject("CheckBoxSeamless.Font");
            this.CheckBoxSeamless.Image = (System.Drawing.Image)resources.GetObject("CheckBoxSeamless.Image");
            this.CheckBoxSeamless.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxSeamless.ImageAlign");
            this.CheckBoxSeamless.ImageIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxSeamless.ImageIndex"));
            this.CheckBoxSeamless.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("CheckBoxSeamless.ImeMode");
            this.CheckBoxSeamless.Location = (System.Drawing.Point)resources.GetObject("CheckBoxSeamless.Location");
            this.CheckBoxSeamless.Name = "CheckBoxSeamless";
            this.CheckBoxSeamless.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("CheckBoxSeamless.RightToLeft");
            this.CheckBoxSeamless.Size = (System.Drawing.Size)resources.GetObject("CheckBoxSeamless.Size");
            this.CheckBoxSeamless.TabIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxSeamless.TabIndex"));
            this.CheckBoxSeamless.Text = resources.GetString("CheckBoxSeamless.Text");
            this.CheckBoxSeamless.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxSeamless.TextAlign");
            this.CheckBoxSeamless.Visible = System.Convert.ToBoolean(resources.GetObject("CheckBoxSeamless.Visible"));
            //
            // TexturizePropertyPage
            //
            this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
            this.AccessibleName = resources.GetString("$this.AccessibleName");
            this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
            this.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMargin");
            this.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMinSize");
            this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            this.Controls.Add(this.CheckBoxSeamless);
            this.Controls.Add(this.TrackBarTextVerticalInteresection);
            this.Controls.Add(this.TrackBarTextHorizontalInteresection);
            this.Controls.Add(this.TrackBarTextColumnCount);
            this.Controls.Add(this.TrackBarTextRowCount);
            this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
            this.Font = (System.Drawing.Font)resources.GetObject("$this.Font");
            this.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("$this.ImeMode");
            this.Location = (System.Drawing.Point)resources.GetObject("$this.Location");
            this.Name = "TexturizePropertyPage";
            this.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("$this.RightToLeft");
            this.Size = (System.Drawing.Size)resources.GetObject("$this.Size");
            this.ResumeLayout(false);
        }

        #endregion " Windows Form Designer generated code "

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
                FadeType _fadeType;
                if (CheckBoxSeamless.Checked)
                {
                    _fadeType = FadeType.Nonlinear;
                }
                else
                {
                    _fadeType = FadeType.None;
                }

                return new Texturize(TrackBarTextRowCount.Value, TrackBarTextColumnCount.Value, TrackBarTextHorizontalInteresection.Value, TrackBarTextVerticalInteresection.Value, FlipType.Both, _fadeType, InterpolationMode.Medium);
            }
        }

        public string Title
        {
            get
            {
                return "Texturize";
            }
        }
    }
}