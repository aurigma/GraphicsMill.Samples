using Aurigma.GraphicsMill.Transforms;

namespace Main
{
    public class SharpenPropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
    {
        #region " Windows Form Designer generated code "

        public SharpenPropertyPage()
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
        internal TrackBarText TrackBarTextStrength;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SharpenPropertyPage));
            this.TrackBarTextStrength = new Main.TrackBarText();
            this.SuspendLayout();
            //
            // TrackBarTextStrength
            //
            this.TrackBarTextStrength.AccessibleDescription = resources.GetString("TrackBarTextStrength.AccessibleDescription");
            this.TrackBarTextStrength.AccessibleName = resources.GetString("TrackBarTextStrength.AccessibleName");
            this.TrackBarTextStrength.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("TrackBarTextStrength.Anchor");
            this.TrackBarTextStrength.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextStrength.AutoScroll"));
            this.TrackBarTextStrength.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("TrackBarTextStrength.AutoScrollMargin");
            this.TrackBarTextStrength.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("TrackBarTextStrength.AutoScrollMinSize");
            this.TrackBarTextStrength.BackgroundImage = (System.Drawing.Image)resources.GetObject("TrackBarTextStrength.BackgroundImage");
            this.TrackBarTextStrength.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("TrackBarTextStrength.Dock");
            this.TrackBarTextStrength.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextStrength.Enabled"));
            this.TrackBarTextStrength.Font = (System.Drawing.Font)resources.GetObject("TrackBarTextStrength.Font");
            this.TrackBarTextStrength.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("TrackBarTextStrength.ImeMode");
            this.TrackBarTextStrength.Location = (System.Drawing.Point)resources.GetObject("TrackBarTextStrength.Location");
            this.TrackBarTextStrength.Maximum = 100;
            this.TrackBarTextStrength.Minimum = 1;
            this.TrackBarTextStrength.Name = "TrackBarTextStrength";
            this.TrackBarTextStrength.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TrackBarTextStrength.RightToLeft");
            this.TrackBarTextStrength.Size = (System.Drawing.Size)resources.GetObject("TrackBarTextStrength.Size");
            this.TrackBarTextStrength.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextStrength.TabIndex"));
            this.TrackBarTextStrength.Text = resources.GetString("TrackBarTextStrength.Text");
            this.TrackBarTextStrength.TickFrequency = 5;
            this.TrackBarTextStrength.Unit = "%";
            this.TrackBarTextStrength.Value = 40;
            this.TrackBarTextStrength.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextStrength.Visible"));
            //
            // SharpenPropertyPage
            //
            this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
            this.AccessibleName = resources.GetString("$this.AccessibleName");
            this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
            this.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMargin");
            this.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMinSize");
            this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            this.Controls.Add(this.TrackBarTextStrength);
            this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
            this.Font = (System.Drawing.Font)resources.GetObject("$this.Font");
            this.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("$this.ImeMode");
            this.Location = (System.Drawing.Point)resources.GetObject("$this.Location");
            this.Name = "SharpenPropertyPage";
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
                return new Sharpen(TrackBarTextStrength.Value);
            }
        }

        public string Title
        {
            get
            {
                return "Sharpen";
            }
        }
    }
}