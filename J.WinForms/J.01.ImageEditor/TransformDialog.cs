using Aurigma.GraphicsMill.Transforms;

namespace Main
{
    public class TransformDialog : System.Windows.Forms.Form
    {
        #region " Windows Form Designer generated code "

        public TransformDialog()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call
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
        private System.Windows.Forms.Button buttonCancel;

        private System.Windows.Forms.Button buttonOK;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TransformDialog));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
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
            // buttonOK
            //
            this.buttonOK.AccessibleDescription = resources.GetString("buttonOK.AccessibleDescription");
            this.buttonOK.AccessibleName = resources.GetString("buttonOK.AccessibleName");
            this.buttonOK.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("buttonOK.Anchor");
            this.buttonOK.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOK.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonOK.BackgroundImage");
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("buttonOK.Dock");
            this.buttonOK.Enabled = System.Convert.ToBoolean(resources.GetObject("buttonOK.Enabled"));
            this.buttonOK.FlatStyle = (System.Windows.Forms.FlatStyle)resources.GetObject("buttonOK.FlatStyle");
            this.buttonOK.Font = (System.Drawing.Font)resources.GetObject("buttonOK.Font");
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOK.Image = (System.Drawing.Image)resources.GetObject("buttonOK.Image");
            this.buttonOK.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("buttonOK.ImageAlign");
            this.buttonOK.ImageIndex = System.Convert.ToInt32(resources.GetObject("buttonOK.ImageIndex"));
            this.buttonOK.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("buttonOK.ImeMode");
            this.buttonOK.Location = (System.Drawing.Point)resources.GetObject("buttonOK.Location");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("buttonOK.RightToLeft");
            this.buttonOK.Size = (System.Drawing.Size)resources.GetObject("buttonOK.Size");
            this.buttonOK.TabIndex = System.Convert.ToInt32(resources.GetObject("buttonOK.TabIndex"));
            this.buttonOK.Text = resources.GetString("buttonOK.Text");
            this.buttonOK.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("buttonOK.TextAlign");
            this.buttonOK.Visible = System.Convert.ToBoolean(resources.GetObject("buttonOK.Visible"));
            //
            // TransformDialog
            //
            this.AcceptButton = this.buttonOK;
            this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
            this.AccessibleName = resources.GetString("$this.AccessibleName");
            this.AutoScaleBaseSize = (System.Drawing.Size)resources.GetObject("$this.AutoScaleBaseSize");
            this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
            this.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMargin");
            this.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMinSize");
            this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            this.CancelButton = this.buttonCancel;
            this.ClientSize = (System.Drawing.Size)resources.GetObject("$this.ClientSize");
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
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
            this.Name = "TransformDialog";
            this.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("$this.RightToLeft");
            this.StartPosition = (System.Windows.Forms.FormStartPosition)resources.GetObject("$this.StartPosition");
            this.Text = resources.GetString("$this.Text");
            this.ResumeLayout(false);
        }

        #endregion " Windows Form Designer generated code "

        public static IBitmapTransform ApplyTransform(Aurigma.GraphicsMill.Bitmap bitmap, System.Windows.Forms.UserControl propertyPage)
        {
            ITransformPropertyPage tpp = (ITransformPropertyPage)propertyPage;

            tpp.Bitmap = bitmap;

            TransformDialog dialog = new TransformDialog();

            dialog.SuspendLayout();
            dialog.ClientSize = new System.Drawing.Size(propertyPage.Width + 118, propertyPage.Height + 16);
            propertyPage.Location = new System.Drawing.Point(8, 8);
            propertyPage.TabIndex = 0;
            dialog.Controls.Add(propertyPage);

            dialog.buttonOK.Left = propertyPage.Width + 24;
            dialog.buttonCancel.Left = propertyPage.Width + 24;
            dialog.ResumeLayout(false);

            dialog.Text = tpp.Title;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return tpp.Transform;
            }
            else
            {
                return null;
            }
        }
    }
}