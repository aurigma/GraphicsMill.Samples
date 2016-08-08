using System;
using System.Windows.Forms;
using Aurigma.GraphicsMill.Transforms;

namespace Main
{
    public class ResizePropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
    {
        #region " Windows Form Designer generated code "

        public ResizePropertyPage()
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
        public System.Windows.Forms.Label Label1;

        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.CheckBox CheckBoxConstrainProportions;
        public System.Windows.Forms.TextBox textBoxWidth;
        public System.Windows.Forms.TextBox textBoxHeight;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ResizePropertyPage));
            this.CheckBoxConstrainProportions = new System.Windows.Forms.CheckBox();
            this.CheckBoxConstrainProportions.CheckedChanged += new System.EventHandler(CheckBoxConstrainProportions_CheckedChanged);
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxWidth.TextChanged += new System.EventHandler(TextBoxWidth_TextChanged);
            this.textBoxWidth.Leave += new System.EventHandler(textBoxWidth_Leave);
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxHeight.TextChanged += new System.EventHandler(textBoxHeight_TextChanged);
            this.textBoxHeight.Leave += new System.EventHandler(TextBoxHeight_Leave);
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // CheckBoxConstrainProportions
            //
            this.CheckBoxConstrainProportions.AccessibleDescription = resources.GetString("CheckBoxConstrainProportions.AccessibleDescription");
            this.CheckBoxConstrainProportions.AccessibleName = resources.GetString("CheckBoxConstrainProportions.AccessibleName");
            this.CheckBoxConstrainProportions.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("CheckBoxConstrainProportions.Anchor");
            this.CheckBoxConstrainProportions.Appearance = (System.Windows.Forms.Appearance)resources.GetObject("CheckBoxConstrainProportions.Appearance");
            this.CheckBoxConstrainProportions.BackColor = System.Drawing.SystemColors.Control;
            this.CheckBoxConstrainProportions.BackgroundImage = (System.Drawing.Image)resources.GetObject("CheckBoxConstrainProportions.BackgroundImage");
            this.CheckBoxConstrainProportions.CheckAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxConstrainProportions.CheckAlign");
            this.CheckBoxConstrainProportions.Checked = true;
            this.CheckBoxConstrainProportions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxConstrainProportions.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckBoxConstrainProportions.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("CheckBoxConstrainProportions.Dock");
            this.CheckBoxConstrainProportions.Enabled = System.Convert.ToBoolean(resources.GetObject("CheckBoxConstrainProportions.Enabled"));
            this.CheckBoxConstrainProportions.FlatStyle = (System.Windows.Forms.FlatStyle)resources.GetObject("CheckBoxConstrainProportions.FlatStyle");
            this.CheckBoxConstrainProportions.Font = (System.Drawing.Font)resources.GetObject("CheckBoxConstrainProportions.Font");
            this.CheckBoxConstrainProportions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckBoxConstrainProportions.Image = (System.Drawing.Image)resources.GetObject("CheckBoxConstrainProportions.Image");
            this.CheckBoxConstrainProportions.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxConstrainProportions.ImageAlign");
            this.CheckBoxConstrainProportions.ImageIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxConstrainProportions.ImageIndex"));
            this.CheckBoxConstrainProportions.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("CheckBoxConstrainProportions.ImeMode");
            this.CheckBoxConstrainProportions.Location = (System.Drawing.Point)resources.GetObject("CheckBoxConstrainProportions.Location");
            this.CheckBoxConstrainProportions.Name = "CheckBoxConstrainProportions";
            this.CheckBoxConstrainProportions.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("CheckBoxConstrainProportions.RightToLeft");
            this.CheckBoxConstrainProportions.Size = (System.Drawing.Size)resources.GetObject("CheckBoxConstrainProportions.Size");
            this.CheckBoxConstrainProportions.TabIndex = System.Convert.ToInt32(resources.GetObject("CheckBoxConstrainProportions.TabIndex"));
            this.CheckBoxConstrainProportions.Text = resources.GetString("CheckBoxConstrainProportions.Text");
            this.CheckBoxConstrainProportions.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("CheckBoxConstrainProportions.TextAlign");
            this.CheckBoxConstrainProportions.Visible = System.Convert.ToBoolean(resources.GetObject("CheckBoxConstrainProportions.Visible"));
            //
            // textBoxWidth
            //
            this.textBoxWidth.AcceptsReturn = true;
            this.textBoxWidth.AccessibleDescription = resources.GetString("textBoxWidth.AccessibleDescription");
            this.textBoxWidth.AccessibleName = resources.GetString("textBoxWidth.AccessibleName");
            this.textBoxWidth.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("textBoxWidth.Anchor");
            this.textBoxWidth.AutoSize = System.Convert.ToBoolean(resources.GetObject("textBoxWidth.AutoSize"));
            this.textBoxWidth.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxWidth.BackgroundImage = (System.Drawing.Image)resources.GetObject("textBoxWidth.BackgroundImage");
            this.textBoxWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxWidth.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("textBoxWidth.Dock");
            this.textBoxWidth.Enabled = System.Convert.ToBoolean(resources.GetObject("textBoxWidth.Enabled"));
            this.textBoxWidth.Font = (System.Drawing.Font)resources.GetObject("textBoxWidth.Font");
            this.textBoxWidth.ForeColor = System.Drawing.SystemColors.WindowText;
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
            // textBoxHeight
            //
            this.textBoxHeight.AcceptsReturn = true;
            this.textBoxHeight.AccessibleDescription = resources.GetString("textBoxHeight.AccessibleDescription");
            this.textBoxHeight.AccessibleName = resources.GetString("textBoxHeight.AccessibleName");
            this.textBoxHeight.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("textBoxHeight.Anchor");
            this.textBoxHeight.AutoSize = System.Convert.ToBoolean(resources.GetObject("textBoxHeight.AutoSize"));
            this.textBoxHeight.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxHeight.BackgroundImage = (System.Drawing.Image)resources.GetObject("textBoxHeight.BackgroundImage");
            this.textBoxHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxHeight.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("textBoxHeight.Dock");
            this.textBoxHeight.Enabled = System.Convert.ToBoolean(resources.GetObject("textBoxHeight.Enabled"));
            this.textBoxHeight.Font = (System.Drawing.Font)resources.GetObject("textBoxHeight.Font");
            this.textBoxHeight.ForeColor = System.Drawing.SystemColors.WindowText;
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
            // Label1
            //
            this.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription");
            this.Label1.AccessibleName = resources.GetString("Label1.AccessibleName");
            this.Label1.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("Label1.Anchor");
            this.Label1.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label1.AutoSize"));
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("Label1.Dock");
            this.Label1.Enabled = System.Convert.ToBoolean(resources.GetObject("Label1.Enabled"));
            this.Label1.Font = (System.Drawing.Font)resources.GetObject("Label1.Font");
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Image = (System.Drawing.Image)resources.GetObject("Label1.Image");
            this.Label1.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("Label1.ImageAlign");
            this.Label1.ImageIndex = System.Convert.ToInt32(resources.GetObject("Label1.ImageIndex"));
            this.Label1.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("Label1.ImeMode");
            this.Label1.Location = (System.Drawing.Point)resources.GetObject("Label1.Location");
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("Label1.RightToLeft");
            this.Label1.Size = (System.Drawing.Size)resources.GetObject("Label1.Size");
            this.Label1.TabIndex = System.Convert.ToInt32(resources.GetObject("Label1.TabIndex"));
            this.Label1.Text = resources.GetString("Label1.Text");
            this.Label1.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("Label1.TextAlign");
            this.Label1.Visible = System.Convert.ToBoolean(resources.GetObject("Label1.Visible"));
            //
            // Label2
            //
            this.Label2.AccessibleDescription = resources.GetString("Label2.AccessibleDescription");
            this.Label2.AccessibleName = resources.GetString("Label2.AccessibleName");
            this.Label2.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("Label2.Anchor");
            this.Label2.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label2.AutoSize"));
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("Label2.Dock");
            this.Label2.Enabled = System.Convert.ToBoolean(resources.GetObject("Label2.Enabled"));
            this.Label2.Font = (System.Drawing.Font)resources.GetObject("Label2.Font");
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
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
            // ResizePropertyPage
            //
            this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
            this.AccessibleName = resources.GetString("$this.AccessibleName");
            this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
            this.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMargin");
            this.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMinSize");
            this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            this.Controls.Add(this.CheckBoxConstrainProportions);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.Label2);
            this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
            this.Font = (System.Drawing.Font)resources.GetObject("$this.Font");
            this.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("$this.ImeMode");
            this.Location = (System.Drawing.Point)resources.GetObject("$this.Location");
            this.Name = "ResizePropertyPage";
            this.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("$this.RightToLeft");
            this.Size = (System.Drawing.Size)resources.GetObject("$this.Size");
            this.ResumeLayout(false);
        }

        #endregion " Windows Form Designer generated code "

        private Aurigma.GraphicsMill.Bitmap _bitmap;
        private int newWidth;
        private int newHeight;

        public Aurigma.GraphicsMill.Bitmap Bitmap
        {
            get
            {
                return _bitmap;
            }
            set
            {
                _bitmap = value;
                System.Globalization.NumberFormatInfo numberFormat = new System.Globalization.NumberFormatInfo();
                newWidth = _bitmap.Width;
                textBoxWidth.Text = newWidth.ToString(numberFormat);
                newHeight = _bitmap.Height;
                textBoxHeight.Text = newHeight.ToString(numberFormat);
            }
        }

        public IBitmapTransform Transform
        {
            get
            {
                try
                {
                    System.Globalization.NumberFormatInfo numberFormat = new System.Globalization.NumberFormatInfo();
                    newWidth = int.Parse(textBoxWidth.Text, numberFormat);
                    newHeight = int.Parse(textBoxHeight.Text, numberFormat);
                    if ((newWidth <= 0) || (newWidth > 10000) || (newHeight <= 0) || (newHeight > 10000))
                    {
                        throw new FormatException();
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Width ad height must be integers numbers form 1 to 10000.", "Size values error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                return new Resize(newWidth, newHeight, ResizeInterpolationMode.Medium);
            }
        }

        public string Title
        {
            get
            {
                return "Resize";
            }
        }

        private void TextBoxWidth_TextChanged(System.Object sender, System.EventArgs e)
        {
            if (!(_bitmap == null) && textBoxWidth.Focused)
            {
                System.Globalization.NumberFormatInfo numberFormat = new System.Globalization.NumberFormatInfo();
                int oldWidth = newWidth;
                try
                {
                    newWidth = int.Parse(textBoxWidth.Text, numberFormat);
                    if (CheckBoxConstrainProportions.Checked)
                    {
                        newHeight = Convert.ToInt32(Math.Round(Convert.ToSingle(newWidth) / Convert.ToSingle(_bitmap.Width) * Convert.ToSingle(_bitmap.Height)));
                        textBoxHeight.Text = newHeight.ToString(numberFormat);
                    }
                }
                catch (System.Exception)
                {
                }
            }
        }

        private void textBoxWidth_Leave(System.Object sender, System.EventArgs e)
        {
            textBoxWidth.Text = newWidth.ToString(new System.Globalization.NumberFormatInfo());
        }

        private void textBoxHeight_TextChanged(System.Object sender, System.EventArgs e)
        {
            if (!(_bitmap == null) && textBoxHeight.Focused)
            {
                System.Globalization.NumberFormatInfo numberFormat = new System.Globalization.NumberFormatInfo();
                int oldHeight = newHeight;
                try
                {
                    newHeight = int.Parse(textBoxHeight.Text, numberFormat);
                    if (CheckBoxConstrainProportions.Checked)
                    {
                        newWidth = Convert.ToInt32(Math.Round(Convert.ToSingle(newHeight) / Convert.ToSingle(_bitmap.Height) * Convert.ToSingle(_bitmap.Width)));
                        textBoxWidth.Text = newWidth.ToString(numberFormat);
                    }
                }
                catch (System.Exception)
                {
                }
            }
        }

        private void TextBoxHeight_Leave(System.Object sender, System.EventArgs e)
        {
            textBoxHeight.Text = newHeight.ToString(new System.Globalization.NumberFormatInfo());
        }

        private void CheckBoxConstrainProportions_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (CheckBoxConstrainProportions.Checked && !(_bitmap == null))
            {
                newHeight = Convert.ToInt32(Math.Round(Convert.ToSingle(newWidth) * Convert.ToSingle(_bitmap.Width) / Convert.ToSingle(_bitmap.Height)));
                textBoxHeight.Text = newHeight.ToString(new System.Globalization.NumberFormatInfo());
            }
        }
    }
}