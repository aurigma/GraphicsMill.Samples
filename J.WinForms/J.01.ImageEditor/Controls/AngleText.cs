using System;

namespace Main
{
    public class AngleText : System.Windows.Forms.UserControl
    {
        #region " Windows Form Designer generated code "

        public AngleText()
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
        internal System.Windows.Forms.NumericUpDown NumericUpDown1;

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AngleText));
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown1.ValueChanged += new System.EventHandler(NumericUpDown1_ValueChanged);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(Panel1_Paint);
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(Panel1_MouseDown);
            this.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(Panel1_MouseMove);
            this.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(Panel1_MouseUp);
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).BeginInit();
            this.SuspendLayout();
            //
            // NumericUpDown1
            //
            this.NumericUpDown1.AccessibleDescription = resources.GetString("NumericUpDown1.AccessibleDescription");
            this.NumericUpDown1.AccessibleName = resources.GetString("NumericUpDown1.AccessibleName");
            this.NumericUpDown1.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("NumericUpDown1.Anchor");
            this.NumericUpDown1.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("NumericUpDown1.Dock");
            this.NumericUpDown1.Enabled = System.Convert.ToBoolean(resources.GetObject("NumericUpDown1.Enabled"));
            this.NumericUpDown1.Font = (System.Drawing.Font)resources.GetObject("NumericUpDown1.Font");
            this.NumericUpDown1.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("NumericUpDown1.ImeMode");
            this.NumericUpDown1.Location = (System.Drawing.Point)resources.GetObject("NumericUpDown1.Location");
            this.NumericUpDown1.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            this.NumericUpDown1.Minimum = new decimal(new int[] { 360, 0, 0, - 2147483648 });
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("NumericUpDown1.RightToLeft");
            this.NumericUpDown1.Size = (System.Drawing.Size)resources.GetObject("NumericUpDown1.Size");
            this.NumericUpDown1.TabIndex = System.Convert.ToInt32(resources.GetObject("NumericUpDown1.TabIndex"));
            this.NumericUpDown1.TextAlign = (System.Windows.Forms.HorizontalAlignment)resources.GetObject("NumericUpDown1.TextAlign");
            this.NumericUpDown1.ThousandsSeparator = System.Convert.ToBoolean(resources.GetObject("NumericUpDown1.ThousandsSeparator"));
            this.NumericUpDown1.UpDownAlign = (System.Windows.Forms.LeftRightAlignment)resources.GetObject("NumericUpDown1.UpDownAlign");
            this.NumericUpDown1.Visible = System.Convert.ToBoolean(resources.GetObject("NumericUpDown1.Visible"));
            //
            // Panel1
            //
            this.Panel1.AccessibleDescription = resources.GetString("Panel1.AccessibleDescription");
            this.Panel1.AccessibleName = resources.GetString("Panel1.AccessibleName");
            this.Panel1.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("Panel1.Anchor");
            this.Panel1.AutoScroll = System.Convert.ToBoolean(resources.GetObject("Panel1.AutoScroll"));
            this.Panel1.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("Panel1.AutoScrollMargin");
            this.Panel1.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("Panel1.AutoScrollMinSize");
            this.Panel1.BackgroundImage = (System.Drawing.Image)resources.GetObject("Panel1.BackgroundImage");
            this.Panel1.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("Panel1.Dock");
            this.Panel1.Enabled = System.Convert.ToBoolean(resources.GetObject("Panel1.Enabled"));
            this.Panel1.Font = (System.Drawing.Font)resources.GetObject("Panel1.Font");
            this.Panel1.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("Panel1.ImeMode");
            this.Panel1.Location = (System.Drawing.Point)resources.GetObject("Panel1.Location");
            this.Panel1.Name = "Panel1";
            this.Panel1.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("Panel1.RightToLeft");
            this.Panel1.Size = (System.Drawing.Size)resources.GetObject("Panel1.Size");
            this.Panel1.TabIndex = System.Convert.ToInt32(resources.GetObject("Panel1.TabIndex"));
            this.Panel1.TabStop = true;
            this.Panel1.Text = resources.GetString("Panel1.Text");
            this.Panel1.Visible = System.Convert.ToBoolean(resources.GetObject("Panel1.Visible"));
            //
            // Label1
            //
            this.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription");
            this.Label1.AccessibleName = resources.GetString("Label1.AccessibleName");
            this.Label1.Anchor = (System.Windows.Forms.AnchorStyles)resources.GetObject("Label1.Anchor");
            this.Label1.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label1.AutoSize"));
            this.Label1.Dock = (System.Windows.Forms.DockStyle)resources.GetObject("Label1.Dock");
            this.Label1.Enabled = System.Convert.ToBoolean(resources.GetObject("Label1.Enabled"));
            this.Label1.Font = (System.Drawing.Font)resources.GetObject("Label1.Font");
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
            // AngleText
            //
            this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
            this.AccessibleName = resources.GetString("$this.AccessibleName");
            this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
            this.AutoScrollMargin = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMargin");
            this.AutoScrollMinSize = (System.Drawing.Size)resources.GetObject("$this.AutoScrollMinSize");
            this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.NumericUpDown1);
            this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
            this.Font = (System.Drawing.Font)resources.GetObject("$this.Font");
            this.ImeMode = (System.Windows.Forms.ImeMode)resources.GetObject("$this.ImeMode");
            this.Location = (System.Drawing.Point)resources.GetObject("$this.Location");
            this.Name = "AngleText";
            this.RightToLeft = (System.Windows.Forms.RightToLeft)resources.GetObject("$this.RightToLeft");
            this.Size = (System.Drawing.Size)resources.GetObject("$this.Size");
            ((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).EndInit();
            this.ResumeLayout(false);
        }

        #endregion " Windows Form Designer generated code "

        private bool blnMouseDown;

        private delegate void ValueChangedEventHandler(object sender, System.EventArgs e);

        private ValueChangedEventHandler ValueChangedEvent;

        private event ValueChangedEventHandler ValueChanged
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

        public int Value
        {
            get
            {
                return Convert.ToInt32(NumericUpDown1.Value);
            }
            set
            {
                NumericUpDown1.Value = value;
                if (ValueChangedEvent != null)
                    ValueChangedEvent(this, new System.EventArgs());
            }
        }

        private void Panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.Black, 2), 1, 1, 36, 36);
            e.Graphics.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.Black, 1), 18, 18, 3, 3);

            float x = Convert.ToSingle(System.Math.Cos(Convert.ToSingle(NumericUpDown1.Value) / 180.0F * System.Math.PI) * 18 + 19);
            float y = Convert.ToSingle(System.Math.Sin(Convert.ToSingle(NumericUpDown1.Value) / 180.0F * System.Math.PI) * 18 + 19);

            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black, 1), 19, 19, x, y);
        }

        private void NumericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            if (ValueChangedEvent != null)
                ValueChangedEvent(this, new System.EventArgs());
            Panel1.Refresh();
        }

        private void Panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            blnMouseDown = true;
            Panel1_MouseMove(Panel1, e);
        }

        private void Panel1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int intAngle;
            if (blnMouseDown)
            {
                if (e.X - 19 == 0)
                {
                    if (e.Y - 19 >= 0)
                    {
                        intAngle = 90;
                    }
                    else
                    {
                        intAngle = 270;
                    }
                }
                else if (e.X - 19 > 0)
                {
                    intAngle = Convert.ToInt32((System.Math.Atan(Convert.ToSingle(e.Y - 19) / Convert.ToSingle(e.X - 19)) / Math.PI) * 180.0F);
                    if (intAngle < 0)
                    {
                        intAngle = 360 + intAngle;
                    }
                }
                else
                {
                    intAngle = Convert.ToInt32((1.0F + System.Math.Atan(Convert.ToSingle(e.Y - 19) / Convert.ToSingle(e.X - 19)) / Math.PI) * 180.0F);
                }

                NumericUpDown1.Value = Convert.ToDecimal(intAngle % 360);
                Panel1.Refresh();

                if (ValueChangedEvent != null)
                    ValueChangedEvent(this, new System.EventArgs());
            }
        }

        private void Panel1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            blnMouseDown = false;
        }
    }
}