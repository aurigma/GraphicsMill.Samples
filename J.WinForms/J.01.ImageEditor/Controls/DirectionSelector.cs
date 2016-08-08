using System;

namespace Main
{
    public enum Direction
    {
        Up = 0,
        UpLeft = 1,
        Left = 2,
        DownLeft = 3,
        Down = 4,
        DownRight = 5,
        Right = 6,
        UpRight = 7
    };

    public class DirectionSelector : System.Windows.Forms.UserControl
    {
        #region " Windows Form Designer generated code "

        public DirectionSelector()
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
        internal System.Windows.Forms.PictureBox PictureBox1;

        internal System.Windows.Forms.RadioButton RadioButtonUpLeft;
        internal System.Windows.Forms.RadioButton RadioButtonLeft;
        internal System.Windows.Forms.RadioButton RadioButtonDownLeft;
        internal System.Windows.Forms.RadioButton RadioButtonUp;
        internal System.Windows.Forms.RadioButton RadioButtonUpRight;
        internal System.Windows.Forms.RadioButton RadioButtonRight;
        internal System.Windows.Forms.RadioButton RadioButtonDownRight;
        internal System.Windows.Forms.RadioButton RadioButtonDown;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.RadioButtonUpLeft = new System.Windows.Forms.RadioButton();
            this.RadioButtonUpLeft.CheckedChanged += new System.EventHandler(RadioButton_CheckedChanged);
            this.RadioButtonLeft = new System.Windows.Forms.RadioButton();
            this.RadioButtonLeft.CheckedChanged += new System.EventHandler(RadioButton_CheckedChanged);
            this.RadioButtonDownLeft = new System.Windows.Forms.RadioButton();
            this.RadioButtonDownLeft.CheckedChanged += new System.EventHandler(RadioButton_CheckedChanged);
            this.RadioButtonUp = new System.Windows.Forms.RadioButton();
            this.RadioButtonUp.CheckedChanged += new System.EventHandler(RadioButton_CheckedChanged);
            this.RadioButtonUpRight = new System.Windows.Forms.RadioButton();
            this.RadioButtonUpRight.CheckedChanged += new System.EventHandler(RadioButton_CheckedChanged);
            this.RadioButtonRight = new System.Windows.Forms.RadioButton();
            this.RadioButtonRight.CheckedChanged += new System.EventHandler(RadioButton_CheckedChanged);
            this.RadioButtonDownRight = new System.Windows.Forms.RadioButton();
            this.RadioButtonDownRight.CheckedChanged += new System.EventHandler(RadioButton_CheckedChanged);
            this.RadioButtonDown = new System.Windows.Forms.RadioButton();
            this.RadioButtonDown.CheckedChanged += new System.EventHandler(RadioButton_CheckedChanged);
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(PictureBox1_Paint);
            this.SuspendLayout();
            //
            // RadioButtonUpLeft
            //
            this.RadioButtonUpLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioButtonUpLeft.Location = new System.Drawing.Point(8, 0);
            this.RadioButtonUpLeft.Name = "RadioButtonUpLeft";
            this.RadioButtonUpLeft.Size = new System.Drawing.Size(16, 24);
            this.RadioButtonUpLeft.TabIndex = 0;
            //
            // RadioButtonLeft
            //
            this.RadioButtonLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioButtonLeft.Location = new System.Drawing.Point(8, 32);
            this.RadioButtonLeft.Name = "RadioButtonLeft";
            this.RadioButtonLeft.Size = new System.Drawing.Size(16, 24);
            this.RadioButtonLeft.TabIndex = 1;
            //
            // RadioButtonDownLeft
            //
            this.RadioButtonDownLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioButtonDownLeft.Location = new System.Drawing.Point(8, 64);
            this.RadioButtonDownLeft.Name = "RadioButtonDownLeft";
            this.RadioButtonDownLeft.Size = new System.Drawing.Size(16, 24);
            this.RadioButtonDownLeft.TabIndex = 2;
            //
            // RadioButtonUp
            //
            this.RadioButtonUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioButtonUp.Location = new System.Drawing.Point(40, 0);
            this.RadioButtonUp.Name = "RadioButtonUp";
            this.RadioButtonUp.Size = new System.Drawing.Size(16, 24);
            this.RadioButtonUp.TabIndex = 3;
            //
            // RadioButtonUpRight
            //
            this.RadioButtonUpRight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioButtonUpRight.Location = new System.Drawing.Point(72, 0);
            this.RadioButtonUpRight.Name = "RadioButtonUpRight";
            this.RadioButtonUpRight.Size = new System.Drawing.Size(16, 24);
            this.RadioButtonUpRight.TabIndex = 4;
            //
            // RadioButtonRight
            //
            this.RadioButtonRight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioButtonRight.Location = new System.Drawing.Point(72, 32);
            this.RadioButtonRight.Name = "RadioButtonRight";
            this.RadioButtonRight.Size = new System.Drawing.Size(16, 24);
            this.RadioButtonRight.TabIndex = 5;
            //
            // RadioButtonDownRight
            //
            this.RadioButtonDownRight.Checked = true;
            this.RadioButtonDownRight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioButtonDownRight.Location = new System.Drawing.Point(72, 64);
            this.RadioButtonDownRight.Name = "RadioButtonDownRight";
            this.RadioButtonDownRight.Size = new System.Drawing.Size(16, 24);
            this.RadioButtonDownRight.TabIndex = 6;
            this.RadioButtonDownRight.TabStop = true;
            //
            // RadioButtonDown
            //
            this.RadioButtonDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioButtonDown.Location = new System.Drawing.Point(40, 64);
            this.RadioButtonDown.Name = "RadioButtonDown";
            this.RadioButtonDown.Size = new System.Drawing.Size(16, 24);
            this.RadioButtonDown.TabIndex = 7;
            //
            // PictureBox1
            //
            this.PictureBox1.Location = new System.Drawing.Point(31, 27);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(32, 32);
            this.PictureBox1.TabIndex = 8;
            this.PictureBox1.TabStop = false;
            //
            // DirectionSelector
            //
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.RadioButtonDown);
            this.Controls.Add(this.RadioButtonDownRight);
            this.Controls.Add(this.RadioButtonRight);
            this.Controls.Add(this.RadioButtonUpRight);
            this.Controls.Add(this.RadioButtonUp);
            this.Controls.Add(this.RadioButtonDownLeft);
            this.Controls.Add(this.RadioButtonLeft);
            this.Controls.Add(this.RadioButtonUpLeft);
            this.Name = "DirectionSelector";
            this.Size = new System.Drawing.Size(96, 88);
            this.ResumeLayout(false);
        }

        #endregion " Windows Form Designer generated code "

        public Direction Direction
        {
            get
            {
                if (RadioButtonUpLeft.Checked)
                {
                    return Direction.UpLeft;
                }
                else if (RadioButtonLeft.Checked)
                {
                    return Direction.Left;
                }
                else if (RadioButtonDownLeft.Checked)
                {
                    return Direction.DownLeft;
                }
                else if (RadioButtonDown.Checked)
                {
                    return Direction.Down;
                }
                else if (RadioButtonRight.Checked)
                {
                    return Direction.Right;
                }
                else if (RadioButtonUpRight.Checked)
                {
                    return Direction.UpRight;
                }
                else if (RadioButtonUp.Checked)
                {
                    return Direction.Up;
                }
                else
                {
                    return Direction.DownRight;
                }
            }
            set
            {
                switch (value)
                {
                    case Direction.UpLeft:

                        RadioButtonUpLeft.Checked = true;
                        break;

                    case Direction.Left:

                        RadioButtonLeft.Checked = true;
                        break;

                    case Direction.DownLeft:

                        RadioButtonDownLeft.Checked = true;
                        break;

                    case Direction.Down:

                        RadioButtonDown.Checked = true;
                        break;

                    case Direction.Right:

                        RadioButtonRight.Checked = true;
                        break;

                    case Direction.UpRight:

                        RadioButtonUpRight.Checked = true;
                        break;

                    case Direction.Up:

                        RadioButtonUp.Checked = true;
                        break;

                    default:

                        RadioButtonDownRight.Checked = true;
                        break;
                }
            }
        }

        private void PictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            int directionX;
            int directionY;

            switch (this.Direction)
            {
                case Direction.UpLeft:

                    directionX = -1;
                    directionY = -1;
                    break;

                case Direction.Left:

                    directionX = -1;
                    directionY = 0;
                    break;

                case Direction.DownLeft:

                    directionX = -1;
                    directionY = 1;
                    break;

                case Direction.Down:

                    directionX = 0;
                    directionY = 1;
                    break;

                case Direction.Right:

                    directionX = 1;
                    directionY = 0;
                    break;

                case Direction.UpRight:

                    directionX = 1;
                    directionY = -1;
                    break;

                case Direction.Up:

                    directionX = 0;
                    directionY = -1;
                    break;

                default: // Direction.DownRight

                    directionX = 1;
                    directionY = 1;
                    break;
            }

            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Black, 3);
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Flat, System.Drawing.Drawing2D.LineCap.ArrowAnchor, System.Drawing.Drawing2D.DashCap.Flat);

            int center = Convert.ToInt32(PictureBox1.Width / 2);
            int radius = center - 1;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(pen, center, center, center + radius * directionX, center + radius * directionY);
        }

        private void RadioButton_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            PictureBox1.Refresh();
        }
    }
}