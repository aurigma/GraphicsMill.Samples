using System.Windows.Forms;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;

namespace Main
{
    public class TiffPropertyPage : System.Windows.Forms.UserControl, IEncoderPropertyPage
    {
        #region " Windows Form Designer generated code "

        public TiffPropertyPage()
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
        internal System.Windows.Forms.GroupBox GroupBox1;

        internal TrackBarText TrackBarTextQuality;
        internal System.Windows.Forms.RadioButton RadioButtonNone;
        internal System.Windows.Forms.RadioButton RadioButtonCCITTGroup3;
        internal System.Windows.Forms.RadioButton RadioButtonCCITTRLE;
        internal System.Windows.Forms.RadioButton RadioButtonCCITTGroup4;
        internal System.Windows.Forms.RadioButton RadioButtonJPEG;
        internal System.Windows.Forms.RadioButton RadioButtonLZW;
        internal System.Windows.Forms.RadioButton RadioButtonRLE;
        private CheckBox CheckBoxAlphaPremultiplied;
        internal System.Windows.Forms.RadioButton RadioButtonZIP;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiffPropertyPage));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonJPEG = new System.Windows.Forms.RadioButton();
            this.RadioButtonLZW = new System.Windows.Forms.RadioButton();
            this.RadioButtonRLE = new System.Windows.Forms.RadioButton();
            this.RadioButtonZIP = new System.Windows.Forms.RadioButton();
            this.RadioButtonCCITTRLE = new System.Windows.Forms.RadioButton();
            this.RadioButtonCCITTGroup4 = new System.Windows.Forms.RadioButton();
            this.RadioButtonCCITTGroup3 = new System.Windows.Forms.RadioButton();
            this.RadioButtonNone = new System.Windows.Forms.RadioButton();
            this.TrackBarTextQuality = new Main.TrackBarText();
            this.CheckBoxAlphaPremultiplied = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            //
            // GroupBox1
            //
            this.GroupBox1.Controls.Add(this.RadioButtonJPEG);
            this.GroupBox1.Controls.Add(this.RadioButtonLZW);
            this.GroupBox1.Controls.Add(this.RadioButtonRLE);
            this.GroupBox1.Controls.Add(this.RadioButtonZIP);
            this.GroupBox1.Controls.Add(this.RadioButtonCCITTRLE);
            this.GroupBox1.Controls.Add(this.RadioButtonCCITTGroup4);
            this.GroupBox1.Controls.Add(this.RadioButtonCCITTGroup3);
            this.GroupBox1.Controls.Add(this.RadioButtonNone);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.GroupBox1, "GroupBox1");
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.TabStop = false;
            //
            // RadioButtonJPEG
            //
            resources.ApplyResources(this.RadioButtonJPEG, "RadioButtonJPEG");
            this.RadioButtonJPEG.Name = "RadioButtonJPEG";
            this.RadioButtonJPEG.CheckedChanged += new System.EventHandler(this.CompressionTypeChanged);
            //
            // RadioButtonLZW
            //
            resources.ApplyResources(this.RadioButtonLZW, "RadioButtonLZW");
            this.RadioButtonLZW.Name = "RadioButtonLZW";
            this.RadioButtonLZW.CheckedChanged += new System.EventHandler(this.CompressionTypeChanged);
            //
            // RadioButtonRLE
            //
            resources.ApplyResources(this.RadioButtonRLE, "RadioButtonRLE");
            this.RadioButtonRLE.Name = "RadioButtonRLE";
            this.RadioButtonRLE.CheckedChanged += new System.EventHandler(this.CompressionTypeChanged);
            //
            // RadioButtonZIP
            //
            resources.ApplyResources(this.RadioButtonZIP, "RadioButtonZIP");
            this.RadioButtonZIP.Name = "RadioButtonZIP";
            this.RadioButtonZIP.CheckedChanged += new System.EventHandler(this.CompressionTypeChanged);
            //
            // RadioButtonCCITTRLE
            //
            resources.ApplyResources(this.RadioButtonCCITTRLE, "RadioButtonCCITTRLE");
            this.RadioButtonCCITTRLE.Name = "RadioButtonCCITTRLE";
            this.RadioButtonCCITTRLE.CheckedChanged += new System.EventHandler(this.CompressionTypeChanged);
            //
            // RadioButtonCCITTGroup4
            //
            resources.ApplyResources(this.RadioButtonCCITTGroup4, "RadioButtonCCITTGroup4");
            this.RadioButtonCCITTGroup4.Name = "RadioButtonCCITTGroup4";
            this.RadioButtonCCITTGroup4.CheckedChanged += new System.EventHandler(this.CompressionTypeChanged);
            //
            // RadioButtonCCITTGroup3
            //
            resources.ApplyResources(this.RadioButtonCCITTGroup3, "RadioButtonCCITTGroup3");
            this.RadioButtonCCITTGroup3.Name = "RadioButtonCCITTGroup3";
            this.RadioButtonCCITTGroup3.CheckedChanged += new System.EventHandler(this.CompressionTypeChanged);
            //
            // RadioButtonNone
            //
            this.RadioButtonNone.Checked = true;
            resources.ApplyResources(this.RadioButtonNone, "RadioButtonNone");
            this.RadioButtonNone.Name = "RadioButtonNone";
            this.RadioButtonNone.TabStop = true;
            this.RadioButtonNone.CheckedChanged += new System.EventHandler(this.CompressionTypeChanged);
            //
            // TrackBarTextQuality
            //
            resources.ApplyResources(this.TrackBarTextQuality, "TrackBarTextQuality");
            this.TrackBarTextQuality.Maximum = 100;
            this.TrackBarTextQuality.Minimum = 0;
            this.TrackBarTextQuality.Name = "TrackBarTextQuality";
            this.TrackBarTextQuality.TickFrequency = 5;
            this.TrackBarTextQuality.Unit = "%";
            this.TrackBarTextQuality.Value = 60;
            this.TrackBarTextQuality.ValueChanged += new Main.TrackBarText.ValueChangedEventHandler(this.TrackBarTextQuality_ValueChanged);
            //
            // CheckBoxAlphaPremultiplied
            //
            resources.ApplyResources(this.CheckBoxAlphaPremultiplied, "CheckBoxAlphaPremultiplied");
            this.CheckBoxAlphaPremultiplied.Name = "CheckBoxAlphaPremultiplied";
            this.CheckBoxAlphaPremultiplied.UseVisualStyleBackColor = true;
            this.CheckBoxAlphaPremultiplied.CheckStateChanged += new System.EventHandler(this.CompressionTypeChanged);
            //
            // TiffPropertyPage
            //
            this.Controls.Add(this.CheckBoxAlphaPremultiplied);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TrackBarTextQuality);
            this.Name = "TiffPropertyPage";
            resources.ApplyResources(this, "$this");
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion " Windows Form Designer generated code "

        private Aurigma.GraphicsMill.Bitmap _bitmap;
        private TiffSettings _encoderOptions;

        public Aurigma.GraphicsMill.Bitmap Bitmap
        {
            get
            {
                return _bitmap;
            }
            set
            {
                _bitmap = value;
                bool ccittEnabled = _bitmap.PixelFormat == PixelFormat.Format1bppIndexed;
                RadioButtonCCITTGroup3.Enabled = ccittEnabled;
                RadioButtonCCITTGroup4.Enabled = ccittEnabled;
                RadioButtonCCITTRLE.Enabled = ccittEnabled;
                RadioButtonJPEG.Enabled = !_bitmap.PixelFormat.IsIndexed && !_bitmap.PixelFormat.IsExtended;
                CheckBoxAlphaPremultiplied.Enabled = (_bitmap.PixelFormat == PixelFormat.Format16bppAgrayscale) || (_bitmap.PixelFormat == PixelFormat.Format32bppAgrayscale) ||
                     (_bitmap.PixelFormat == PixelFormat.Format32bppArgb) || (_bitmap.PixelFormat == PixelFormat.Format64bppArgb) ||
                     (_bitmap.PixelFormat == PixelFormat.Format40bppAcmyk) || (_bitmap.PixelFormat == PixelFormat.Format80bppAcmyk);
            }
        }

        public WriterSettings EncoderOptions
        {
            get
            {
                return _encoderOptions;
            }
            set
            {
                _encoderOptions = (TiffSettings)value;
                switch (_encoderOptions.Compression)
                {
                    case CompressionType.Ccitt3:

                        RadioButtonCCITTGroup3.Checked = true;
                        break;

                    case CompressionType.Ccitt4:

                        RadioButtonCCITTGroup4.Checked = true;
                        break;

                    case CompressionType.CcittRle:

                        RadioButtonCCITTRLE.Checked = true;
                        break;

                    case CompressionType.Zip:

                        RadioButtonZIP.Checked = true;
                        break;

                    case CompressionType.Rle:

                        RadioButtonRLE.Checked = true;
                        break;

                    case CompressionType.Lzw:

                        RadioButtonLZW.Checked = true;
                        break;

                    case CompressionType.Jpeg:

                        RadioButtonJPEG.Checked = true;
                        break;

                    default:

                        RadioButtonNone.Checked = true;
                        break;
                }
                CheckBoxAlphaPremultiplied.Checked = _encoderOptions.IsAlphaPremultiplied;
                TrackBarTextQuality.Value = _encoderOptions.Quality;
            }
        }

        public string Title
        {
            get
            {
                return "TIFF File Format";
            }
        }

        // Private Sub _bitmap_Changed(ByVal eventSender As System.Object, ByVal eventArgs As BitmapChangedEventArgs) Handles _bitmap.Changed
        //    'TODO: to be implemented
        // End Sub

        private void CompressionTypeChanged(System.Object sender, System.EventArgs e)
        {
            if (!(_encoderOptions == null))
            {
                if (RadioButtonCCITTGroup3.Checked)
                {
                    _encoderOptions.Compression = CompressionType.Ccitt3;
                }
                else if (RadioButtonCCITTGroup4.Checked)
                {
                    _encoderOptions.Compression = CompressionType.Ccitt4;
                }
                else if (RadioButtonCCITTRLE.Checked)
                {
                    _encoderOptions.Compression = CompressionType.CcittRle;
                }
                else if (RadioButtonZIP.Checked)
                {
                    _encoderOptions.Compression = CompressionType.Zip;
                }
                else if (RadioButtonRLE.Checked)
                {
                    _encoderOptions.Compression = CompressionType.Rle;
                }
                else if (RadioButtonLZW.Checked)
                {
                    _encoderOptions.Compression = CompressionType.Lzw;
                }
                else if (RadioButtonJPEG.Checked)
                {
                    _encoderOptions.Compression = CompressionType.Jpeg;
                }
                else
                {
                    _encoderOptions.Compression = CompressionType.None;
                }
                _encoderOptions.IsAlphaPremultiplied = CheckBoxAlphaPremultiplied.Checked;
                TrackBarTextQuality.Enabled = RadioButtonJPEG.Checked;
            }
        }

        private void TrackBarTextQuality_ValueChanged(object sender, System.EventArgs e)
        {
            if (!(_encoderOptions == null))
            {
                _encoderOptions.Quality = TrackBarTextQuality.Value;
            }
        }
    }
}