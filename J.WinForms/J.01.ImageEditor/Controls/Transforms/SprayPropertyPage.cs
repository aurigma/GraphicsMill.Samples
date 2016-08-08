using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Transforms;

namespace Main
{
    public class SprayPropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
    {
        #region " Windows Form Designer generated code "

        public SprayPropertyPage()
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
        internal System.Windows.Forms.CheckBox CheckBoxFrame;

        internal TrackBarText TrackBarTextAmount;
        internal System.Windows.Forms.CheckBox CheckBoxFade;
        internal TrackBarText TrackBarTextFrameWidth;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SprayPropertyPage));
            this.CheckBoxFrame = new System.Windows.Forms.CheckBox();
            this.CheckBoxFrame.CheckedChanged += new System.EventHandler(CheckBoxFrame_CheckedChanged);
            this.TrackBarTextAmount = new Main.TrackBarText();
            this.CheckBoxFade = new System.Windows.Forms.CheckBox();
            this.TrackBarTextFrameWidth = new Main.TrackBarText();
            this.SuspendLayout();
            //
            // CheckBoxFrame
            //
            this.CheckBoxFrame.AccessibleDescription = resources.GetString("CheckBoxFrame.AccessibleDescription");
            this.CheckBoxFrame.AccessibleName = resources.GetString("CheckBoxFrame.AccessibleName");
            this.CheckBoxFrame.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("CheckBoxFrame.Anchor");
            this.CheckBoxFrame.Appearance = (System.Windows.Forms.Appearance)resources.GetObject("CheckBoxFrame.Appearance");
            this.CheckBoxFrame.BackgroundImage = (System.Drawing.Image)resources.GetObject("CheckBoxFrame.BackgroundImage");
            this.CheckBoxFrame.CheckAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxFrame.CheckAlign");
            this.CheckBoxFrame.Checked = true;
            this.CheckBoxFrame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxFrame.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("CheckBoxFrame.Dock");
            this.CheckBoxFrame.Enabled = System.Convert.ToBoolean(resources.GetObject("CheckBoxFrame.Enabled"));
            this.CheckBoxFrame.FlatStyle = (System.Windows.Forms.FlatStyle)resources.GetObject("CheckBoxFrame.FlatStyle");
            this.CheckBoxFrame.Font = (System.Drawing.Font)resources.GetObject("CheckBoxFrame.Font");
            this.CheckBoxFrame.Image = (System.Drawing.Image)resources.GetObject("CheckBoxFrame.Image");
            this.CheckBoxFrame.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxFrame.ImageAlign");
            this.CheckBoxFrame.ImageIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxFrame.ImageIndex"));
            this.CheckBoxFrame.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("CheckBoxFrame.ImeMode");
            this.CheckBoxFrame.Location = (System.Drawing.Point)resources.GetObject("CheckBoxFrame.Location");
            this.CheckBoxFrame.Name = "CheckBoxFrame";
            this.CheckBoxFrame.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("CheckBoxFrame.RightToLeft");
            this.CheckBoxFrame.Size = (System.Drawing.Size)resources.GetObject("CheckBoxFrame.Size");
            this.CheckBoxFrame.TabIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxFrame.TabIndex"));
            this.CheckBoxFrame.Text = resources.GetString("CheckBoxFrame.Text");
            this.CheckBoxFrame.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxFrame.TextAlign");
            this.CheckBoxFrame.Visible = System.Convert.ToBoolean(resources.GetObject("CheckBoxFrame.Visible"));
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
            this.TrackBarTextAmount.Maximum = 200;
            this.TrackBarTextAmount.Minimum = 1;
            this.TrackBarTextAmount.Name = "TrackBarTextAmount";
            this.TrackBarTextAmount.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TrackBarTextAmount.RightToLeft");
            this.TrackBarTextAmount.Size = (System.Drawing.Size)resources.GetObject("TrackBarTextAmount.Size");
            this.TrackBarTextAmount.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextAmount.TabIndex"));
            this.TrackBarTextAmount.Text = resources.GetString("TrackBarTextAmount.Text");
            this.TrackBarTextAmount.TickFrequency = 10;
            this.TrackBarTextAmount.Unit = "pixels";
            this.TrackBarTextAmount.Value = 50;
            this.TrackBarTextAmount.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextAmount.Visible"));
            //
            // CheckBoxFade
            //
            this.CheckBoxFade.AccessibleDescription = resources.GetString("CheckBoxFade.AccessibleDescription");
            this.CheckBoxFade.AccessibleName = resources.GetString("CheckBoxFade.AccessibleName");
            this.CheckBoxFade.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("CheckBoxFade.Anchor");
            this.CheckBoxFade.Appearance = (System.Windows.Forms.Appearance)resources.GetObject("CheckBoxFade.Appearance");
            this.CheckBoxFade.BackgroundImage = (System.Drawing.Image)resources.GetObject("CheckBoxFade.BackgroundImage");
            this.CheckBoxFade.CheckAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxFade.CheckAlign");
            this.CheckBoxFade.Checked = true;
            this.CheckBoxFade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxFade.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("CheckBoxFade.Dock");
            this.CheckBoxFade.Enabled = System.Convert.ToBoolean(resources.GetObject("CheckBoxFade.Enabled"));
            this.CheckBoxFade.FlatStyle = (System.Windows.Forms.FlatStyle)resources.GetObject("CheckBoxFade.FlatStyle");
            this.CheckBoxFade.Font = (System.Drawing.Font)resources.GetObject("CheckBoxFade.Font");
            this.CheckBoxFade.Image = (System.Drawing.Image)resources.GetObject("CheckBoxFade.Image");
            this.CheckBoxFade.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxFade.ImageAlign");
            this.CheckBoxFade.ImageIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxFade.ImageIndex"));
            this.CheckBoxFade.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("CheckBoxFade.ImeMode");
            this.CheckBoxFade.Location = (System.Drawing.Point)resources.GetObject("CheckBoxFade.Location");
            this.CheckBoxFade.Name = "CheckBoxFade";
            this.CheckBoxFade.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("CheckBoxFade.RightToLeft");
            this.CheckBoxFade.Size = (System.Drawing.Size)resources.GetObject("CheckBoxFade.Size");
            this.CheckBoxFade.TabIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxFade.TabIndex"));
            this.CheckBoxFade.Text = resources.GetString("CheckBoxFade.Text");
            this.CheckBoxFade.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxFade.TextAlign");
            this.CheckBoxFade.Visible = System.Convert.ToBoolean(resources.GetObject("CheckBoxFade.Visible"));
            //
            // TrackBarTextFrameWidth
            //
            this.TrackBarTextFrameWidth.AccessibleDescription = resources.GetString("TrackBarTextFrameWidth.AccessibleDescription");
            this.TrackBarTextFrameWidth.AccessibleName = resources.GetString("TrackBarTextFrameWidth.AccessibleName");
            this.TrackBarTextFrameWidth.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("TrackBarTextFrameWidth.Anchor");
            this.TrackBarTextFrameWidth.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextFrameWidth.AutoScroll"));
            this.TrackBarTextFrameWidth.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("TrackBarTextFrameWidth.AutoScrollMargin");
            this.TrackBarTextFrameWidth.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("TrackBarTextFrameWidth.AutoScrollMinSize");
            this.TrackBarTextFrameWidth.BackgroundImage = (System.Drawing.Image)resources.GetObject("TrackBarTextFrameWidth.BackgroundImage");
            this.TrackBarTextFrameWidth.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("TrackBarTextFrameWidth.Dock");
            this.TrackBarTextFrameWidth.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextFrameWidth.Enabled"));
            this.TrackBarTextFrameWidth.Font = (System.Drawing.Font)resources.GetObject("TrackBarTextFrameWidth.Font");
            this.TrackBarTextFrameWidth.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("TrackBarTextFrameWidth.ImeMode");
            this.TrackBarTextFrameWidth.Location = (System.Drawing.Point)resources.GetObject("TrackBarTextFrameWidth.Location");
            this.TrackBarTextFrameWidth.Maximum = 100;
            this.TrackBarTextFrameWidth.Minimum = 1;
            this.TrackBarTextFrameWidth.Name = "TrackBarTextFrameWidth";
            this.TrackBarTextFrameWidth.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TrackBarTextFrameWidth.RightToLeft");
            this.TrackBarTextFrameWidth.Size = (System.Drawing.Size)resources.GetObject("TrackBarTextFrameWidth.Size");
            this.TrackBarTextFrameWidth.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextFrameWidth.TabIndex"));
            this.TrackBarTextFrameWidth.Text = resources.GetString("TrackBarTextFrameWidth.Text");
            this.TrackBarTextFrameWidth.TickFrequency = 5;
            this.TrackBarTextFrameWidth.Unit = "pixels";
            this.TrackBarTextFrameWidth.Value = 50;
            this.TrackBarTextFrameWidth.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextFrameWidth.Visible"));
            //
            // SprayPropertyPage
            //
            this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
            this.AccessibleName = resources.GetString("$this.AccessibleName");
            this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
            this.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMargin");
            this.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMinSize");
            this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            this.Controls.Add(this.CheckBoxFade);
            this.Controls.Add(this.TrackBarTextFrameWidth);
            this.Controls.Add(this.CheckBoxFrame);
            this.Controls.Add(this.TrackBarTextAmount);
            this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
            this.Font = (System.Drawing.Font)resources.GetObject("$this.Font");
            this.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("$this.ImeMode");
            this.Location = (System.Drawing.Point)resources.GetObject("$this.Location");
            this.Name = "SprayPropertyPage";
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
                FadeType fade;

                if (CheckBoxFade.Checked)
                {
                    fade = FadeType.Linear;
                }
                else
                {
                    fade = FadeType.None;
                }

                if (CheckBoxFrame.Checked)
                {
                    return new Spray { Amount = TrackBarTextAmount.Value, FrameWidth = TrackBarTextFrameWidth.Value, Type = fade, Seed = 0, BackgroundColor = RgbColor.Gray };
                }
                else
                {
                    return new Spray { Amount = TrackBarTextAmount.Value, FrameWidth = 0, Type = fade, Seed = 0, BackgroundColor = RgbColor.Gray };
                }
            }
        }

        public string Title
        {
            get
            {
                return "Spray";
            }
        }

        private void CheckBoxFrame_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            TrackBarTextFrameWidth.Enabled = CheckBoxFrame.Checked;
            CheckBoxFade.Enabled = CheckBoxFrame.Checked;
        }
    }
}