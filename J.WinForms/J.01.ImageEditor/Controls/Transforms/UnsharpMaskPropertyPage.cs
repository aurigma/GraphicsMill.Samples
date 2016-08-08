using System;
using Aurigma.GraphicsMill.Transforms;

namespace Main
{
    public class UnsharpMaskPropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
    {
        #region " Windows Form Designer generated code "

        public UnsharpMaskPropertyPage()
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
        internal TrackBarText TrackBarTextAmount;

        internal TrackBarText TrackBarTextRadius;
        internal TrackBarText TrackBarTextThreshold;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(UnsharpMaskPropertyPage));
            this.TrackBarTextAmount = new Main.TrackBarText();
            this.TrackBarTextRadius = new Main.TrackBarText();
            this.TrackBarTextThreshold = new Main.TrackBarText();
            this.SuspendLayout();
            //
            // TrackBarTextAmount
            //
            this.TrackBarTextAmount.AccessibleDescription = resources.GetString("TrackBarTextAmount.AccessibleDescription");
            this.TrackBarTextAmount.AccessibleName = resources.GetString("TrackBarTextAmount.AccessibleName");
            this.TrackBarTextAmount.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("TrackBarTextAmount.Anchor");
            this.TrackBarTextAmount.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextAmount.AutoScroll"));
            this.TrackBarTextAmount.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("TrackBarTextAmount.AutoScrollMargin");
            this.TrackBarTextAmount.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("TrackBarTextAmount.AutoScrollMinSize");
            this.TrackBarTextAmount.BackgroundImage = (System.Drawing.Image)resources.GetObject("TrackBarTextAmount.BackgroundImage");
            this.TrackBarTextAmount.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("TrackBarTextAmount.Dock");
            this.TrackBarTextAmount.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextAmount.Enabled"));
            this.TrackBarTextAmount.Font = (System.Drawing.Font)resources.GetObject("TrackBarTextAmount.Font");
            this.TrackBarTextAmount.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("TrackBarTextAmount.ImeMode");
            this.TrackBarTextAmount.Location = (System.Drawing.Point)resources.GetObject("TrackBarTextAmount.Location");
            this.TrackBarTextAmount.Maximum = 500;
            this.TrackBarTextAmount.Minimum = 1;
            this.TrackBarTextAmount.Name = "TrackBarTextAmount";
            this.TrackBarTextAmount.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TrackBarTextAmount.RightToLeft");
            this.TrackBarTextAmount.Size = (System.Drawing.Size)resources.GetObject("TrackBarTextAmount.Size");
            this.TrackBarTextAmount.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextAmount.TabIndex"));
            this.TrackBarTextAmount.Text = resources.GetString("TrackBarTextAmount.Text");
            this.TrackBarTextAmount.TickFrequency = 50;
            this.TrackBarTextAmount.Unit = "%";
            this.TrackBarTextAmount.Value = 50;
            this.TrackBarTextAmount.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextAmount.Visible"));
            //
            // TrackBarTextRadius
            //
            this.TrackBarTextRadius.AccessibleDescription = resources.GetString("TrackBarTextRadius.AccessibleDescription");
            this.TrackBarTextRadius.AccessibleName = resources.GetString("TrackBarTextRadius.AccessibleName");
            this.TrackBarTextRadius.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("TrackBarTextRadius.Anchor");
            this.TrackBarTextRadius.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextRadius.AutoScroll"));
            this.TrackBarTextRadius.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("TrackBarTextRadius.AutoScrollMargin");
            this.TrackBarTextRadius.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("TrackBarTextRadius.AutoScrollMinSize");
            this.TrackBarTextRadius.BackgroundImage = (System.Drawing.Image)resources.GetObject("TrackBarTextRadius.BackgroundImage");
            this.TrackBarTextRadius.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("TrackBarTextRadius.Dock");
            this.TrackBarTextRadius.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextRadius.Enabled"));
            this.TrackBarTextRadius.Font = (System.Drawing.Font)resources.GetObject("TrackBarTextRadius.Font");
            this.TrackBarTextRadius.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("TrackBarTextRadius.ImeMode");
            this.TrackBarTextRadius.Location = (System.Drawing.Point)resources.GetObject("TrackBarTextRadius.Location");
            this.TrackBarTextRadius.Maximum = 250;
            this.TrackBarTextRadius.Minimum = 1;
            this.TrackBarTextRadius.Name = "TrackBarTextRadius";
            this.TrackBarTextRadius.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TrackBarTextRadius.RightToLeft");
            this.TrackBarTextRadius.Size = (System.Drawing.Size)resources.GetObject("TrackBarTextRadius.Size");
            this.TrackBarTextRadius.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextRadius.TabIndex"));
            this.TrackBarTextRadius.Text = resources.GetString("TrackBarTextRadius.Text");
            this.TrackBarTextRadius.TickFrequency = 25;
            this.TrackBarTextRadius.Unit = "pixels";
            this.TrackBarTextRadius.Value = 1;
            this.TrackBarTextRadius.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextRadius.Visible"));
            //
            // TrackBarTextThreshold
            //
            this.TrackBarTextThreshold.AccessibleDescription = resources.GetString("TrackBarTextThreshold.AccessibleDescription");
            this.TrackBarTextThreshold.AccessibleName = resources.GetString("TrackBarTextThreshold.AccessibleName");
            this.TrackBarTextThreshold.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("TrackBarTextThreshold.Anchor");
            this.TrackBarTextThreshold.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextThreshold.AutoScroll"));
            this.TrackBarTextThreshold.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("TrackBarTextThreshold.AutoScrollMargin");
            this.TrackBarTextThreshold.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("TrackBarTextThreshold.AutoScrollMinSize");
            this.TrackBarTextThreshold.BackgroundImage = (System.Drawing.Image)resources.GetObject("TrackBarTextThreshold.BackgroundImage");
            this.TrackBarTextThreshold.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("TrackBarTextThreshold.Dock");
            this.TrackBarTextThreshold.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextThreshold.Enabled"));
            this.TrackBarTextThreshold.Font = (System.Drawing.Font)resources.GetObject("TrackBarTextThreshold.Font");
            this.TrackBarTextThreshold.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("TrackBarTextThreshold.ImeMode");
            this.TrackBarTextThreshold.Location = (System.Drawing.Point)resources.GetObject("TrackBarTextThreshold.Location");
            this.TrackBarTextThreshold.Maximum = 255;
            this.TrackBarTextThreshold.Minimum = 0;
            this.TrackBarTextThreshold.Name = "TrackBarTextThreshold";
            this.TrackBarTextThreshold.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TrackBarTextThreshold.RightToLeft");
            this.TrackBarTextThreshold.Size = (System.Drawing.Size)resources.GetObject("TrackBarTextThreshold.Size");
            this.TrackBarTextThreshold.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextThreshold.TabIndex"));
            this.TrackBarTextThreshold.Text = resources.GetString("TrackBarTextThreshold.Text");
            this.TrackBarTextThreshold.TickFrequency = 16;
            this.TrackBarTextThreshold.Unit = "levels";
            this.TrackBarTextThreshold.Value = 0;
            this.TrackBarTextThreshold.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextThreshold.Visible"));
            //
            // UnsharpMaskPropertyPage
            //
            this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
            this.AccessibleName = resources.GetString("$this.AccessibleName");
            this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
            this.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMargin");
            this.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMinSize");
            this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            this.Controls.Add(this.TrackBarTextThreshold);
            this.Controls.Add(this.TrackBarTextRadius);
            this.Controls.Add(this.TrackBarTextAmount);
            this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
            this.Font = (System.Drawing.Font)resources.GetObject("$this.Font");
            this.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("$this.ImeMode");
            this.Location = (System.Drawing.Point)resources.GetObject("$this.Location");
            this.Name = "UnsharpMaskPropertyPage";
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
                return new UnsharpMask(Convert.ToSingle(TrackBarTextAmount.Value) / 100.0F, TrackBarTextRadius.Value, Convert.ToSingle(TrackBarTextThreshold.Value) / 255.0F);
            }
        }

        public string Title
        {
            get
            {
                return "Unsharp Mask";
            }
        }
    }
}