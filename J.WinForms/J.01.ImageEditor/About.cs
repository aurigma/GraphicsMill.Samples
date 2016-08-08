namespace Main
{
    public class AboutForm : System.Windows.Forms.Form
    {
        #region " Windows Form Designer generated code "

        public AboutForm()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call
            var version = typeof(Aurigma.GraphicsMill.Bitmap).Assembly.GetName().Version;
            groupBoxInformation.Text = string.Format("Aurigma Graphics Mill {0}.{1}", version.Major, version.Minor);
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
        internal System.Windows.Forms.Button buttonOK;

        internal System.Windows.Forms.GroupBox groupBoxInformation;
        internal System.Windows.Forms.Label labelCopyright;
        internal System.Windows.Forms.Label labelSupport;
        internal System.Windows.Forms.LinkLabel linkLabelAurigmaLink;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelSupport = new System.Windows.Forms.Label();
            this.linkLabelAurigmaLink = new System.Windows.Forms.LinkLabel();
            this.groupBoxInformation.SuspendLayout();
            this.SuspendLayout();
            //
            // buttonOK
            //
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            //
            // groupBoxInformation
            //
            this.groupBoxInformation.Controls.Add(this.labelCopyright);
            this.groupBoxInformation.Controls.Add(this.labelSupport);
            this.groupBoxInformation.Controls.Add(this.linkLabelAurigmaLink);
            this.groupBoxInformation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.groupBoxInformation, "groupBoxInformation");
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.TabStop = false;
            //
            // labelCopyright
            //
            resources.ApplyResources(this.labelCopyright, "labelCopyright");
            this.labelCopyright.Name = "labelCopyright";
            //
            // labelSupport
            //
            resources.ApplyResources(this.labelSupport, "labelSupport");
            this.labelSupport.Name = "labelSupport";
            //
            // linkLabelAurigmaLink
            //
            resources.ApplyResources(this.linkLabelAurigmaLink, "linkLabelAurigmaLink");
            this.linkLabelAurigmaLink.Name = "linkLabelAurigmaLink";
            this.linkLabelAurigmaLink.TabStop = true;
            this.linkLabelAurigmaLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAurigmaLink_LinkClicked);
            //
            // AboutForm
            //
            this.AcceptButton = this.buttonOK;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion " Windows Form Designer generated code "

        private void buttonOK_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        public void VisitLink()
        {
            linkLabelAurigmaLink.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.aurigma.com/support/");
        }

        private void linkLabelAurigmaLink_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (System.Exception)
            {
            }
        }
    }
}