using System;

namespace Main
{
    public class TrackBarText : System.Windows.Forms.UserControl
    {
        #region " Windows Form Designer generated code "

        public TrackBarText()
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
        internal System.Windows.Forms.TextBox TextBox1;

        internal System.Windows.Forms.TrackBar TrackBar1;
        internal System.Windows.Forms.Label LabelText;
        internal System.Windows.Forms.Label LabelUnit;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TrackBarText));
            this.LabelText = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox1.TextChanged += new System.EventHandler(TextBox1_TextChanged);
            this.TrackBar1 = new System.Windows.Forms.TrackBar();
            this.TrackBar1.ValueChanged += new System.EventHandler(TrackBar1_ValueChanged);
            this.LabelUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)this.TrackBar1).BeginInit();
            this.SuspendLayout();
            //
            // LabelText
            //
            this.LabelText.AccessibleDescription = resources.GetString("LabelText.AccessibleDescription");
            this.LabelText.AccessibleName = resources.GetString("LabelText.AccessibleName");
            this.LabelText.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("LabelText.Anchor");
            this.LabelText.AutoSize = System.Convert.ToBoolean(resources.GetObject("LabelText.AutoSize"));
            this.LabelText.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("LabelText.Dock");
            this.LabelText.Enabled = System.Convert.ToBoolean(resources.GetObject("LabelText.Enabled"));
            this.LabelText.Font = (System.Drawing.Font)resources.GetObject("LabelText.Font");
            this.LabelText.Image = (System.Drawing.Image)resources.GetObject("LabelText.Image");
            this.LabelText.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("LabelText.ImageAlign");
            this.LabelText.ImageIndex = System.Convert.ToInt32(resources.GetObject("LabelText.ImageIndex"));
            this.LabelText.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("LabelText.ImeMode");
            this.LabelText.Location = (System.Drawing.Point)resources.GetObject("LabelText.Location");
            this.LabelText.Name = "LabelText";
            this.LabelText.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("LabelText.RightToLeft");
            this.LabelText.Size = (System.Drawing.Size)resources.GetObject("LabelText.Size");
            this.LabelText.TabIndex = System.Convert.ToInt32(resources.GetObject("LabelText.TabIndex"));
            this.LabelText.Text = resources.GetString("LabelText.Text");
            this.LabelText.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("LabelText.TextAlign");
            this.LabelText.Visible = System.Convert.ToBoolean(resources.GetObject("LabelText.Visible"));
            //
            // TextBox1
            //
            this.TextBox1.AccessibleDescription = resources.GetString("TextBox1.AccessibleDescription");
            this.TextBox1.AccessibleName = resources.GetString("TextBox1.AccessibleName");
            this.TextBox1.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("TextBox1.Anchor");
            this.TextBox1.AutoSize = System.Convert.ToBoolean(resources.GetObject("TextBox1.AutoSize"));
            this.TextBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("TextBox1.BackgroundImage");
            this.TextBox1.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("TextBox1.Dock");
            this.TextBox1.Enabled = System.Convert.ToBoolean(resources.GetObject("TextBox1.Enabled"));
            this.TextBox1.Font = (System.Drawing.Font)resources.GetObject("TextBox1.Font");
            this.TextBox1.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("TextBox1.ImeMode");
            this.TextBox1.Location = (System.Drawing.Point)resources.GetObject("TextBox1.Location");
            this.TextBox1.MaxLength = System.Convert.ToInt32(resources.GetObject("TextBox1.MaxLength"));
            this.TextBox1.Multiline = System.Convert.ToBoolean(resources.GetObject("TextBox1.Multiline"));
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = System.Convert.ToChar(resources.GetObject("TextBox1.PasswordChar"));
            this.TextBox1.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TextBox1.RightToLeft");
            this.TextBox1.ScrollBars = (System.Windows.Forms.ScrollBars)resources.GetObject("TextBox1.ScrollBars");
            this.TextBox1.Size = (System.Drawing.Size)resources.GetObject("TextBox1.Size");
            this.TextBox1.TabIndex = System.Convert.ToInt32(resources.GetObject("TextBox1.TabIndex"));
            this.TextBox1.Text = resources.GetString("TextBox1.Text");
            this.TextBox1.TextAlign = (System.Windows.Forms.HorizontalAlignment)resources.GetObject("TextBox1.TextAlign");
            this.TextBox1.Visible = System.Convert.ToBoolean(resources.GetObject("TextBox1.Visible"));
            this.TextBox1.WordWrap = System.Convert.ToBoolean(resources.GetObject("TextBox1.WordWrap"));
            //
            // TrackBar1
            //
            this.TrackBar1.AccessibleDescription = resources.GetString("TrackBar1.AccessibleDescription");
            this.TrackBar1.AccessibleName = resources.GetString("TrackBar1.AccessibleName");
            this.TrackBar1.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("TrackBar1.Anchor");
            this.TrackBar1.BackgroundImage = (System.Drawing.Image)resources.GetObject("TrackBar1.BackgroundImage");
            this.TrackBar1.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("TrackBar1.Dock");
            this.TrackBar1.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBar1.Enabled"));
            this.TrackBar1.Font = (System.Drawing.Font)resources.GetObject("TrackBar1.Font");
            this.TrackBar1.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("TrackBar1.ImeMode");
            this.TrackBar1.Location = (System.Drawing.Point)resources.GetObject("TrackBar1.Location");
            this.TrackBar1.Maximum = 100;
            this.TrackBar1.Minimum = -100;
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Orientation = (System.Windows.Forms.Orientation)resources.GetObject("TrackBar1.Orientation");
            this.TrackBar1.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("TrackBar1.RightToLeft");
            this.TrackBar1.Size = (System.Drawing.Size)resources.GetObject("TrackBar1.Size");
            this.TrackBar1.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBar1.TabIndex"));
            this.TrackBar1.Text = resources.GetString("TrackBar1.Text");
            this.TrackBar1.TickFrequency = 10;
            this.TrackBar1.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBar1.Visible"));
            //
            // LabelUnit
            //
            this.LabelUnit.AccessibleDescription = resources.GetString("LabelUnit.AccessibleDescription");
            this.LabelUnit.AccessibleName = resources.GetString("LabelUnit.AccessibleName");
            this.LabelUnit.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("LabelUnit.Anchor");
            this.LabelUnit.AutoSize = System.Convert.ToBoolean(resources.GetObject("LabelUnit.AutoSize"));
            this.LabelUnit.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("LabelUnit.Dock");
            this.LabelUnit.Enabled = System.Convert.ToBoolean(resources.GetObject("LabelUnit.Enabled"));
            this.LabelUnit.Font = (System.Drawing.Font)resources.GetObject("LabelUnit.Font");
            this.LabelUnit.Image = (System.Drawing.Image)resources.GetObject("LabelUnit.Image");
            this.LabelUnit.ImageAlign = (System.Drawing.ContentAlignment)resources.GetObject("LabelUnit.ImageAlign");
            this.LabelUnit.ImageIndex = System.Convert.ToInt32(resources.GetObject("LabelUnit.ImageIndex"));
            this.LabelUnit.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("LabelUnit.ImeMode");
            this.LabelUnit.Location = (System.Drawing.Point)resources.GetObject("LabelUnit.Location");
            this.LabelUnit.Name = "LabelUnit";
            this.LabelUnit.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("LabelUnit.RightToLeft");
            this.LabelUnit.Size = (System.Drawing.Size)resources.GetObject("LabelUnit.Size");
            this.LabelUnit.TabIndex = System.Convert.ToInt32(resources.GetObject("LabelUnit.TabIndex"));
            this.LabelUnit.Text = resources.GetString("LabelUnit.Text");
            this.LabelUnit.TextAlign = (System.Drawing.ContentAlignment)resources.GetObject("LabelUnit.TextAlign");
            this.LabelUnit.Visible = System.Convert.ToBoolean(resources.GetObject("LabelUnit.Visible"));
            //
            // TrackBarText
            //
            this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
            this.AccessibleName = resources.GetString("$this.AccessibleName");
            this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
            this.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMargin");
            this.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMinSize");
            this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            this.Controls.Add(this.LabelUnit);
            this.Controls.Add(this.TrackBar1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.LabelText);
            this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
            this.Font = (System.Drawing.Font)resources.GetObject("$this.Font");
            this.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("$this.ImeMode");
            this.Location = (System.Drawing.Point)resources.GetObject("$this.Location");
            this.Name = "TrackBarText";
            this.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("$this.RightToLeft");
            this.Size = (System.Drawing.Size)resources.GetObject("$this.Size");
            ((System.ComponentModel.ISupportInitialize)this.TrackBar1).EndInit();
            this.ResumeLayout(false);
        }

        #endregion " Windows Form Designer generated code "

        public delegate void ValueChangedEventHandler(object sender, System.EventArgs e);

        private ValueChangedEventHandler ValueChangedEvent;

        public event ValueChangedEventHandler ValueChanged
        {
            add
            {
                ValueChangedEvent = (ValueChangedEventHandler)System.Delegate.Combine(ValueChangedEvent, value);
            }
            remove
            {
                ValueChangedEvent = (ValueChangedEventHandler)System.Delegate.Remove(ValueChangedEvent, value);
            }
        }

        public int Maximum
        {
            get
            {
                return TrackBar1.Maximum;
            }
            set
            {
                TrackBar1.Maximum = value;
            }
        }

        public int Minimum
        {
            get
            {
                return TrackBar1.Minimum;
            }
            set
            {
                TrackBar1.Minimum = value;
            }
        }

        public int TickFrequency
        {
            get
            {
                return TrackBar1.TickFrequency;
            }
            set
            {
                TrackBar1.TickFrequency = value;
            }
        }

        public int Value
        {
            get
            {
                return TrackBar1.Value;
            }
            set
            {
                TrackBar1.Value = value;
                TextBox1.Text = Value.ToString(new System.Globalization.NumberFormatInfo());
                if (ValueChangedEvent != null)
                    ValueChangedEvent(this, new System.EventArgs());
            }
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return LabelText.Text;
            }
            set
            {
                LabelText.Text = value;
            }
        }

        public string Unit
        {
            get
            {
                return LabelUnit.Text;
            }
            set
            {
                LabelUnit.Text = value;
                if (value == string.Empty)
                {
                    TextBox1.Left = this.Width - 45;
                }
                else
                {
                    TextBox1.Left = this.Width - 83;
                }
            }
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public new bool Enabled
        {
            get
            {
                return TextBox1.Enabled;
            }
            set
            {
                TextBox1.Enabled = value;
                LabelText.Enabled = value;
                LabelUnit.Enabled = value;
                TrackBar1.Enabled = value;
            }
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override bool Focused
        {
            get
            {
                return TextBox1.Focused || TrackBar1.Focused;
            }
        }

        // Sync values and validate
        private void TrackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            if (ValueChangedEvent != null)
                ValueChangedEvent(this, new System.EventArgs());
            if (TrackBar1.Focused)
            {
                TextBox1.Text = TrackBar1.Value.ToString(new System.Globalization.NumberFormatInfo());
            }
        }

        private void TextBox1_TextChanged(object sender, System.EventArgs e)
        {
            System.Globalization.NumberFormatInfo numberFormat = new System.Globalization.NumberFormatInfo();
            if (Utils.IsNumeric(TextBox1.Text))
            {
                int lngValue = 0;
                try
                {
                    lngValue = int.Parse(TextBox1.Text, numberFormat);
                }
                catch (FormatException)
                {
                }

                if (lngValue < TrackBar1.Minimum)
                {
                    TextBox1.Text = TrackBar1.Minimum.ToString(numberFormat);
                    TrackBar1.Value = TrackBar1.Minimum;
                }
                else if (lngValue > TrackBar1.Maximum)
                {
                    TextBox1.Text = TrackBar1.Maximum.ToString(numberFormat);
                    TrackBar1.Value = TrackBar1.Maximum;
                }
                else
                {
                    TrackBar1.Value = lngValue;
                }
            }
            else if ((TextBox1.Text == string.Empty) || (TextBox1.Text == "-"))
            {
                TrackBar1.Value = Math.Max(0, TrackBar1.Minimum);
            }
            else
            {
                TextBox1.Text = TrackBar1.Value.ToString(numberFormat);
            }
        }
    }
}