using System;
using System.Drawing;
using System.Windows.Forms;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.WinControls;

namespace Main
{
    public class PrintImageDialog : System.Windows.Forms.Form
    {
        #region " Windows Form Designer generated code "

        public PrintImageDialog(Aurigma.GraphicsMill.Bitmap printImage)
        {
            if (printImage == null)
            {
                throw new ArgumentNullException("printImage");
            }

            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call
            _originalImage = printImage;
            UpdatePreview();
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
        internal System.Windows.Forms.Button ButtonPrint;

        internal System.Windows.Forms.Button ButtonPageSetup;
        internal System.Windows.Forms.Button ButtonCancel;
        internal System.Windows.Forms.TextBox TextBoxPositionX;
        internal System.Windows.Forms.TextBox TextBoxPositionY;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxWidth;
        internal System.Windows.Forms.TextBox TextBoxHeight;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal Aurigma.GraphicsMill.WinControls.BitmapViewer BitmapViewer1;
        internal System.Windows.Forms.PageSetupDialog PageSetupDialog1;
        internal Aurigma.GraphicsMill.WinControls.ImagePrintDocument _printDocument;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.ButtonPageSetup = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.TextBoxPositionX = new System.Windows.Forms.TextBox();
            this.TextBoxPositionY = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxWidth = new System.Windows.Forms.TextBox();
            this.TextBoxHeight = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.BitmapViewer1 = new Aurigma.GraphicsMill.WinControls.BitmapViewer();
            this.PageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this._printDocument = new Aurigma.GraphicsMill.WinControls.ImagePrintDocument();
            this.SuspendLayout();
            //
            // ButtonPrint
            //
            this.ButtonPrint.Location = new System.Drawing.Point(512, 16);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(88, 24);
            this.ButtonPrint.TabIndex = 0;
            this.ButtonPrint.Text = "Print";
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            //
            // ButtonPageSetup
            //
            this.ButtonPageSetup.Location = new System.Drawing.Point(512, 48);
            this.ButtonPageSetup.Name = "ButtonPageSetup";
            this.ButtonPageSetup.Size = new System.Drawing.Size(88, 24);
            this.ButtonPageSetup.TabIndex = 1;
            this.ButtonPageSetup.Text = "Page Setup...";
            this.ButtonPageSetup.Click += new System.EventHandler(this.ButtonPageSetup_Click);
            //
            // ButtonCancel
            //
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(512, 80);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(88, 24);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            //
            // TextBoxPositionX
            //
            this.TextBoxPositionX.Location = new System.Drawing.Point(328, 22);
            this.TextBoxPositionX.MaxLength = 4;
            this.TextBoxPositionX.Name = "TextBoxPositionX";
            this.TextBoxPositionX.Size = new System.Drawing.Size(40, 20);
            this.TextBoxPositionX.TabIndex = 4;
            this.TextBoxPositionX.Text = "0";
            this.TextBoxPositionX.Validated += new System.EventHandler(this.TextBox_TextChanged);
            //
            // TextBoxPositionY
            //
            this.TextBoxPositionY.Location = new System.Drawing.Point(328, 44);
            this.TextBoxPositionY.MaxLength = 4;
            this.TextBoxPositionY.Name = "TextBoxPositionY";
            this.TextBoxPositionY.Size = new System.Drawing.Size(40, 20);
            this.TextBoxPositionY.TabIndex = 5;
            this.TextBoxPositionY.Text = "0";
            this.TextBoxPositionY.Validated += new System.EventHandler(this.TextBox_TextChanged);
            //
            // Label1
            //
            this.Label1.Location = new System.Drawing.Point(264, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Position X:";
            //
            // Label2
            //
            this.Label2.Location = new System.Drawing.Point(264, 47);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Position Y:";
            //
            // TextBoxWidth
            //
            this.TextBoxWidth.Location = new System.Drawing.Point(448, 22);
            this.TextBoxWidth.MaxLength = 4;
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.Size = new System.Drawing.Size(40, 20);
            this.TextBoxWidth.TabIndex = 8;
            this.TextBoxWidth.Text = "0";
            this.TextBoxWidth.Validated += new System.EventHandler(this.TextBox_TextChanged);
            //
            // TextBoxHeight
            //
            this.TextBoxHeight.Location = new System.Drawing.Point(448, 44);
            this.TextBoxHeight.MaxLength = 4;
            this.TextBoxHeight.Name = "TextBoxHeight";
            this.TextBoxHeight.Size = new System.Drawing.Size(40, 20);
            this.TextBoxHeight.TabIndex = 9;
            this.TextBoxHeight.Text = "0";
            this.TextBoxHeight.Validated += new System.EventHandler(this.TextBox_TextChanged);
            //
            // Label3
            //
            this.Label3.Location = new System.Drawing.Point(400, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 16);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Width:";
            //
            // Label4
            //
            this.Label4.Location = new System.Drawing.Point(400, 47);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 16);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Height:";
            //
            // BitmapViewer1
            //
            this.BitmapViewer1.AlphaEnabled = false;
            this.BitmapViewer1.BackColor = System.Drawing.Color.Silver;
            this.BitmapViewer1.Location = new System.Drawing.Point(8, 8);
            this.BitmapViewer1.MaxZoom = 1F;
            this.BitmapViewer1.MinZoom = 1F;
            this.BitmapViewer1.Name = "BitmapViewer1";
            this.BitmapViewer1.ScrollingPosition = new System.Drawing.Point(0, 0);
            this.BitmapViewer1.Size = new System.Drawing.Size(248, 312);
            this.BitmapViewer1.TabIndex = 13;
            this.BitmapViewer1.Text = "BitmapViewer1";
            this.BitmapViewer1.WorkspaceBorderColor = System.Drawing.Color.Black;
            this.BitmapViewer1.WorkspaceBorderWidth = 1;
            this.BitmapViewer1.ZoomMode = Aurigma.GraphicsMill.WinControls.ZoomMode.None;
            //
            // PageSetupDialog1
            //
            this.PageSetupDialog1.Document = this._printDocument;
            //
            // _printDocument
            //
            this._printDocument.PlacementMode = Aurigma.GraphicsMill.WinControls.PlacementMode.Manual;
            this._printDocument.PrintOptions.FooterFont = new System.Drawing.Font("Arial", 10F);
            this._printDocument.PrintOptions.HeaderFont = new System.Drawing.Font("Arial", 10F);
            this._printDocument.PrintOptions.ImageAutoRotate = false;
            this._printDocument.PrintOptions.PlaceholderSize = new System.Drawing.Size(0, 0);
            this._printDocument.Source = null;
            //
            // PrintImageDialog
            //
            this.AcceptButton = this.ButtonPrint;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(608, 333);
            this.Controls.Add(this.BitmapViewer1);
            this.Controls.Add(this.TextBoxHeight);
            this.Controls.Add(this.TextBoxWidth);
            this.Controls.Add(this.TextBoxPositionY);
            this.Controls.Add(this.TextBoxPositionX);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonPageSetup);
            this.Controls.Add(this.ButtonPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrintImageDialog";
            this.Text = "PrintImageDialog";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion " Windows Form Designer generated code "

        #region "Variables Declaration"

        private Aurigma.GraphicsMill.Bitmap _originalImage;
        private float _previewScaleX;
        private float _previewScaleY;
        private int _printerResolutionX;
        private int _printerResolutionY;
        private bool _updateIsInProgress;
        private bool _proportionCorrecting;
        private string _lastX;
        private string _lastY;
        private string _lastWidth;
        private string _lastHeight;

        #endregion "Variables Declaration"

        #region "Printing"

        private void UpdatePreview()
        {
            // Paper bitmap initializing
            int width;
            int height;
            width = 0;
            height = 0;
            CalculatePaperImageDimensions(ref width, ref height);
            System.Drawing.Size fittedSize = FitDimensions(width, height, BitmapViewer1.Width - 20, BitmapViewer1.Height - 20);

            if (BitmapViewer1.Bitmap != null)
            {
                BitmapViewer1.Bitmap.Dispose();
            }

            BitmapViewer1.Bitmap = new Aurigma.GraphicsMill.Bitmap(fittedSize.Width, fittedSize.Height, PixelFormat.Format24bppRgb, RgbColor.White);

            // Scale coefficients
            _previewScaleX = Convert.ToSingle(width) / Convert.ToSingle(fittedSize.Width);
            _previewScaleY = Convert.ToSingle(height) / Convert.ToSingle(fittedSize.Height);

            // Image rubberband initializing
            Aurigma.GraphicsMill.Bitmap previewImage = new Aurigma.GraphicsMill.Bitmap();
            Resize resizeTransform = new Resize();
            resizeTransform.Width = fittedSize.Width;
            resizeTransform.Height = fittedSize.Height;
            resizeTransform.ResizeMode = Aurigma.GraphicsMill.Transforms.ResizeMode.Fit;
            previewImage = resizeTransform.Apply(_originalImage);
            ImageRubberband rubberband = new ImageRubberband(previewImage);
            BitmapViewer1.Rubberband = rubberband;
            rubberband.RectangleChanged += new Aurigma.GraphicsMill.WinControls.RectangleEventHandler(this.RubberbandRectangleChanged);

            // Setting image size
            int imageActualWidth;
            int imageActualHeight;
            imageActualWidth = Convert.ToInt32(Convert.ToSingle(_originalImage.Width) / Convert.ToSingle(_originalImage.DpiX) * Convert.ToSingle(_printerResolutionX));
            imageActualHeight = Convert.ToInt32(Convert.ToSingle(_originalImage.Height) / Convert.ToSingle(_originalImage.DpiY) * Convert.ToSingle(_printerResolutionY));

            int previewImageWidth;
            int previewImageHeight;
            previewImageWidth = Convert.ToInt32(Convert.ToSingle(imageActualWidth) / Convert.ToSingle(_previewScaleX));
            previewImageHeight = Convert.ToInt32(Convert.ToSingle(imageActualHeight) / Convert.ToSingle(_previewScaleY));

            System.Drawing.Size tmp = FitDimensions(previewImageWidth, previewImageHeight, fittedSize.Width, fittedSize.Height);
            previewImageWidth = tmp.Width;
            previewImageHeight = tmp.Height;
            rubberband.Rectangle = new System.Drawing.Rectangle((fittedSize.Width - previewImageWidth) / 2, (fittedSize.Height - previewImageHeight) / 2, previewImageWidth, previewImageHeight);

            // Initializing coordinates & size editboxes
            UpdateSizeAndPositionFromPreview();
        }

        private void CalculatePaperImageDimensions(ref int width, ref int height)
        {
            RetrievePrinterResolution();

            width = Convert.ToInt32(_printDocument.PrinterSettings.DefaultPageSettings.Bounds.Width * _printerResolutionX / 100.0F);
            height = Convert.ToInt32(_printDocument.PrinterSettings.DefaultPageSettings.Bounds.Height * _printerResolutionY / 100.0F);
        }

        private void RetrievePrinterResolution()
        {
            _printerResolutionX = _printDocument.DefaultPageSettings.PrinterResolution.X;
            _printerResolutionY = _printDocument.DefaultPageSettings.PrinterResolution.Y;
            if ((_printerResolutionX == 0) || (_printerResolutionY == 0))
            {
                if ((_printerResolutionX == 0) && (_printerResolutionY == 0))
                {
                    throw new ApplicationException("Cannot retrieve printer resolution");
                }
                else
                {
                    _printerResolutionX = Math.Max(_printerResolutionX, _printerResolutionY);
                    _printerResolutionY = Math.Max(_printerResolutionX, _printerResolutionY);
                }
            }
        }

        private System.Drawing.Size FitDimensions(int width, int height, int boundWidth, int boundHeight)
        {
            if ((width == 0) || (height == 0) || (boundWidth == 0) || (boundHeight == 0))
            {
                throw new ArgumentOutOfRangeException("All parameters should be above zero.");
            }

            if ((width <= boundWidth) && (height <= boundHeight))
            {
                return new System.Drawing.Size(width, height);
            }

            System.Drawing.Size result = new System.Drawing.Size();
            float boundAspect = Convert.ToSingle(boundWidth) / Convert.ToSingle(boundHeight);
            float aspect = Convert.ToSingle(width) / Convert.ToSingle(height);

            if (aspect >= boundAspect)
            {
                result.Width = boundWidth;
                result.Height = Convert.ToInt32(Convert.ToSingle(boundWidth) / aspect);
            }
            else
            {
                result.Height = boundHeight;
                result.Width = Convert.ToInt32(Convert.ToSingle(boundHeight) * aspect);
            }

            return result;
        }

        private void CenterRubberband()
        {
            ImageRubberband rubberband = (ImageRubberband)BitmapViewer1.Rubberband;
            System.Drawing.Rectangle prevRect = rubberband.Rectangle;

            int x;
            int y;
            x = (BitmapViewer1.Bitmap.Width - prevRect.Width) / 2;
            y = (BitmapViewer1.Bitmap.Height - prevRect.Height) / 2;

            rubberband.Rectangle = new System.Drawing.Rectangle(x, y, prevRect.Width, prevRect.Height);
        }

        private void UpdateSizeAndPositionFromPreview()
        {
            if (_updateIsInProgress)
            {
                return;
            }

            _updateIsInProgress = true;

            try
            {
                ImageRubberband rubberband = (ImageRubberband)BitmapViewer1.Rubberband;

                int realWidth;
                int realHeight;
                int realX;
                int realY;
                realWidth = ConvertToInchH(Convert.ToSingle(rubberband.Rectangle.Width) * _previewScaleX, _printerResolutionX);
                realHeight = ConvertToInchH(Convert.ToSingle(rubberband.Rectangle.Height) * _previewScaleY, _printerResolutionY);
                realX = ConvertToInchH(Convert.ToSingle(rubberband.Rectangle.X) * _previewScaleX, _printerResolutionX);
                realY = ConvertToInchH(Convert.ToSingle(rubberband.Rectangle.Y) * _previewScaleY, _printerResolutionY);

                _lastX = TextBoxPositionX.Text = realX.ToString();
                _lastY = TextBoxPositionY.Text = realY.ToString();
                _lastWidth = TextBoxWidth.Text = realWidth.ToString();
                _lastHeight = TextBoxHeight.Text = realHeight.ToString();
            }
            finally
            {
                _updateIsInProgress = false;
            }
        }

        private void TextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (TextBoxPositionX.Text == _lastX && TextBoxPositionY.Text == _lastY &&
                    TextBoxWidth.Text == _lastWidth && TextBoxHeight.Text == _lastHeight)
                return;
            try
            {
                ImageRubberband rubberband = (ImageRubberband)BitmapViewer1.Rubberband;

                int width;
                int height;
                int x;
                int y;

                x = ConvertToPixels(System.Convert.ToSingle(TextBoxPositionX.Text) / _previewScaleX, _printerResolutionX);
                y = ConvertToPixels(System.Convert.ToSingle(TextBoxPositionY.Text) / _previewScaleY, _printerResolutionY);
                width = ConvertToPixels(System.Convert.ToSingle(TextBoxWidth.Text) / _previewScaleX, _printerResolutionX);
                height = ConvertToPixels(System.Convert.ToSingle(TextBoxHeight.Text) / _previewScaleY, _printerResolutionY);
                if ((TextBox)sender == TextBoxWidth)
                    height = (width * _originalImage.Height) / _originalImage.Width;
                if ((TextBox)sender == TextBoxHeight)
                    width = (height * _originalImage.Width) / _originalImage.Height;

                if (x > BitmapViewer1.Bitmap.Width)
                    x = BitmapViewer1.Bitmap.Width - width;
                if (x < 0)
                    x = 0;
                if (y > BitmapViewer1.Bitmap.Height)
                    y = BitmapViewer1.Bitmap.Height - height;
                if (y < 0)
                    y = 0;
                if (x + width > BitmapViewer1.Bitmap.Width)
                    width = BitmapViewer1.Bitmap.Width - x;
                if (y + height > BitmapViewer1.Bitmap.Height)
                    height = BitmapViewer1.Bitmap.Height - y;
                rubberband.Rectangle = new Rectangle(x, y, width, height);
            }
            catch
            {
                TextBoxPositionX.Text = _lastX;
                TextBoxPositionY.Text = _lastY;
                TextBoxWidth.Text = _lastWidth;
                TextBoxHeight.Text = _lastHeight;
            }
        }

        private void UpdatePreviewFromSizeAndPosition(bool dimensionsChanged, bool widthChanged)
        {
            ImageRubberband rubberband = (ImageRubberband)BitmapViewer1.Rubberband;
            if ((rubberband == null) || _updateIsInProgress)
            {
                return;
            }

            _updateIsInProgress = true;
            try
            {
                System.Drawing.Rectangle prevRect = rubberband.Rectangle;

                int newWidth = 0;
                int newHeight = 0;
                int newX = 0;
                int newY = 0;

                try
                {
                    if (dimensionsChanged)
                    {
                        newWidth = int.Parse(TextBoxWidth.Text);
                        newHeight = int.Parse(TextBoxHeight.Text);
                    }
                    else
                    {
                        newX = int.Parse(TextBoxPositionX.Text);
                        newY = int.Parse(TextBoxPositionY.Text);
                    }
                }
                catch
                {
                    newX = 0;
                    newY = 0;
                    newWidth = 10;
                    newHeight = 10;
                }

                if (dimensionsChanged)
                {
                    newWidth = Convert.ToInt32(Convert.ToSingle(ConvertToPixels(newWidth, _printerResolutionX)) / _previewScaleX);
                    newHeight = Convert.ToInt32(Convert.ToSingle(ConvertToPixels(newHeight, _printerResolutionY)) / _previewScaleY);

                    if (widthChanged)
                    {
                        newHeight = Convert.ToInt32(Convert.ToSingle(newWidth) * Convert.ToSingle(prevRect.Height) / Convert.ToSingle(prevRect.Width));
                    }
                    else
                    {
                        newWidth = Convert.ToInt32(Convert.ToSingle(newHeight) * Convert.ToSingle(prevRect.Width) / Convert.ToSingle(prevRect.Height));
                    }
                    System.Drawing.Size fittedSize = FitDimensions(newWidth, newHeight, BitmapViewer1.Bitmap.Width - prevRect.X, BitmapViewer1.Bitmap.Height - prevRect.Y);
                    rubberband.Rectangle = new System.Drawing.Rectangle(prevRect.X, prevRect.Y, fittedSize.Width, fittedSize.Height);

                    TextBoxWidth.Text = ConvertToInchH(Convert.ToSingle(fittedSize.Width) * _previewScaleX, _printerResolutionX).ToString();
                    TextBoxHeight.Text = ConvertToInchH(Convert.ToSingle(fittedSize.Height * _previewScaleY), _printerResolutionY).ToString();
                }
                else
                {
                    newX = Convert.ToInt32(Convert.ToSingle(ConvertToPixels(newX, _printerResolutionX)) / _previewScaleX);
                    newY = Convert.ToInt32(Convert.ToSingle(ConvertToPixels(newY, _printerResolutionY)) / _previewScaleY);

                    newX = Math.Min(newX, BitmapViewer1.Bitmap.Width - prevRect.Width);
                    newY = Math.Min(newY, BitmapViewer1.Bitmap.Height - prevRect.Height);
                    rubberband.Rectangle = new System.Drawing.Rectangle(newX, newY, prevRect.Width, prevRect.Height);

                    TextBoxPositionX.Text = ConvertToInchH(Convert.ToSingle(newX) * _previewScaleX, _printerResolutionX).ToString();
                    TextBoxPositionY.Text = ConvertToInchH(Convert.ToSingle(newY) * _previewScaleY, _printerResolutionY).ToString();
                }
            }
            finally
            {
                _updateIsInProgress = false;
            }
        }

        private int ConvertToInchH(float pixelVal, int dpi)
        {
            if (dpi == 0)
            {
                throw new ArgumentException("dpi");
            }

            return Convert.ToInt32(pixelVal / Convert.ToSingle(dpi) * 100.0F);
        }

        private int ConvertToPixels(float hundInchVal, int dpi)
        {
            if (dpi == 0)
            {
                throw new ArgumentException("dpi");
            }

            return Convert.ToInt32(hundInchVal * Convert.ToSingle(dpi) / 100.0F);
        }

        private void RubberbandRectangleChanged(object sender, Aurigma.GraphicsMill.WinControls.RectangleEventArgs e)
        {
            if (_proportionCorrecting)
            {
                return;
            }

            _proportionCorrecting = true;

            try
            {
                _proportionCorrecting = true;
                ImageRubberband rubberband = (ImageRubberband)BitmapViewer1.Rubberband;
                Rectangle rect = rubberband.Rectangle;
                rect.Height = (rect.Width * _originalImage.Height) / _originalImage.Width;
                if (rect.Height < 5)
                {
                    rect.Height = 5;
                    rect.Width = (rect.Height * _originalImage.Width) / _originalImage.Height;
                }
                int spade = rect.Y + rect.Height - BitmapViewer1.Bitmap.Height;
                if (spade > 0)
                {
                    rect.Y -= spade;
                }
                spade = rect.X + rect.Width - BitmapViewer1.Bitmap.Width;
                if (spade > 0)
                {
                    rect.X -= spade;
                }
                rubberband.Rectangle = rect;
                UpdateSizeAndPositionFromPreview();
            }
            finally
            {
                _proportionCorrecting = false;
            }
        }

        private void PrintImage()
        {
            int x;
            int y;
            int width;
            int height;
            x = int.Parse(TextBoxPositionX.Text);
            y = int.Parse(TextBoxPositionY.Text);
            width = int.Parse(TextBoxWidth.Text);
            height = int.Parse(TextBoxHeight.Text);

            PrintPlaceholder placeholder = new PrintPlaceholder();
            placeholder.Image = _originalImage;
            placeholder.Location = new System.Drawing.Point(x, y);
            placeholder.Size = new System.Drawing.Size(width, height);

            _printDocument.Source = placeholder;

            _printDocument.DefaultPageSettings.Margins.Left = 0;
            _printDocument.DefaultPageSettings.Margins.Right = 0;
            _printDocument.DefaultPageSettings.Margins.Top = 0;
            _printDocument.DefaultPageSettings.Margins.Bottom = 0;

            _printDocument.Print();
        }

        #endregion "Printing"

        #region "GUI Events Handlers"

        private void ButtonCancel_Click(System.Object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void ButtonPageSetup_Click(System.Object sender, System.EventArgs e)
        {
            PageSetupDialog1.ShowDialog(this);
            UpdatePreview();
        }

        private void ButtonCenterImage_Click(System.Object sender, System.EventArgs e)
        {
            CenterRubberband();
        }

        private void ButtonPrint_Click(System.Object sender, System.EventArgs e)
        {
            PrintImage();
        }

        #endregion "GUI Events Handlers"
    }
}