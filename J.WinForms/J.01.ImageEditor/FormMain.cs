using System;
using System.Drawing;
using System.Windows.Forms;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Transforms;
using Aurigma.GraphicsMill.WinControls;

namespace Main
{
    public class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            try
            {
                var bitmap = new Aurigma.GraphicsMill.Bitmap();
            }
            catch (Aurigma.GraphicsMill.Licensing.LicenseException)
            {
                System.Windows.Forms.MessageBox.Show("License key is not registered or entered evaluation key has expired. Please register a valid license key.", "Aurigma Graphics Mill", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(1);
            }

            Application.EnableVisualStyles();

            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Add progress bar
            const int margin = 3;
            _progressBarMain = new System.Windows.Forms.ProgressBar();
            _progressBarMain.Height = statusBarMain.Height - margin * 2;
            _progressBarMain.Width = StatusBarPanelProgress.Width - margin * 2;
            _progressBarMain.Top = margin;
            _progressBarMain.Left = StatusBarPanelState.Width + margin;
            _progressBarMain.Minimum = 0;
            _progressBarMain.Maximum = 100;
            _progressBarMain.Visible = false;
            _progressBarMain.Style = ProgressBarStyle.Marquee;
            statusBarMain.Controls.Add(_progressBarMain);

            // Add zoom combo box
            zoomToolStripComboBox.Items.AddRange(new string[] { "Best Fit", "Fit to Width", "Fit to Height", "10%", "25%", "50%", "75%", "100%", "150%", "200%", "400%", "600%", "800%", "1000%" });
            zoomToolStripComboBox.SelectedIndex = 0;
            zoomToolStripComboBox.Enabled = false;

            SetMenuAndToolbar(false);
            bitmapViewerMainView.MouseWheel += new System.Windows.Forms.MouseEventHandler(bitmapViewerMainView_MouseWheel);
            bitmapViewerMainView.ContentChanged += new EventHandler(bitmapViewerMainView_ContentChanged);

            bitmapViewerMainView.UndoRedoMaxStepCount = 5;
        }

        [STAThread()]
        public static void Main()
        {
            Application.Run(new FormMain());
        }

        #region " Windows Form Designer generated code "

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

        private System.ComponentModel.IContainer components;

        // Required by the Windows Form Designer

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        internal System.Windows.Forms.OpenFileDialog openFileDialog;

        internal System.Windows.Forms.StatusBarPanel StatusBarPanelState;
        internal System.Windows.Forms.StatusBarPanel StatusBarPanelProgress;
        internal System.Windows.Forms.StatusBarPanel StatusBarPanelPosition;
        internal System.Windows.Forms.SaveFileDialog saveFileDialog;
        internal Aurigma.GraphicsMill.WinControls.PanNavigator panNavigatorExample;
        internal Aurigma.GraphicsMill.WinControls.ZoomRectangleNavigator zoomRectangleNavigatorExample;
        internal Aurigma.GraphicsMill.WinControls.ZoomInNavigator zoomInNavigatorExample;
        internal Aurigma.GraphicsMill.WinControls.ZoomOutNavigator zoomOutNavigatorExample;
        internal Aurigma.GraphicsMill.WinControls.BitmapViewer bitmapViewerMainView;
        internal System.Windows.Forms.ImageList imageListToolbarIcons;
        internal System.Windows.Forms.StatusBar statusBarMain;
        internal Aurigma.GraphicsMill.WinControls.RectangleRubberband rectangleRubberbandExample;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ImageToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TransformsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem ImageInfoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RedoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ModeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem Bitmap1BitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem IndexedColorToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem GrayscaleColorToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RgbColorToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CmykColorToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
        internal System.Windows.Forms.ToolStripMenuItem Bit8ColorDepthToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem Bit16ColorDepthToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        internal System.Windows.Forms.ToolStripMenuItem AdjustToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.ToolStripMenuItem CropToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ResizeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RotateToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FlipToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
        internal System.Windows.Forms.ToolStripMenuItem HistogramToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PaletteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
        internal System.Windows.Forms.ToolStripMenuItem AlphaChannelToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AutoBrightnessToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AutoContrastToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BrightnessContrastToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AutoLevelsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LevelsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ChannelBalanceToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CurvesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator10;
        internal System.Windows.Forms.ToolStripMenuItem HueSaturationLightnessToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EqualizeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem Rotate90ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem Rotate180ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem Rotate270ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RotateArbitraryToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FlipHorizontalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FlipVerticalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AddNoiseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BlurToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EdgeDetectToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EdgeDetectGlowToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EdgeDetectLaplaceHVToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EdgeDetectLaplaceOmniToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EdgeDetectPatternToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EdgeDetectPrewittToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EdgeDetectSharpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EdgeDetectSharpMoreToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EdgeDetectTraceContourToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EmbossToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MaximumFilterToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MedianFilterToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MinimumFilterToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MosaicToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SolarizeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ShadowToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SharpenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SprayToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TexturizeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem UnsharpMaskToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton openToolStripButton;
        internal System.Windows.Forms.ToolStripButton saveToolStripButton;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator11;
        internal System.Windows.Forms.ToolStripButton undoToolStripButton;
        internal System.Windows.Forms.ToolStripButton redoToolStripButton;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator12;
        internal System.Windows.Forms.ToolStripButton pointerToolStripButton;
        internal System.Windows.Forms.ToolStripButton selectionToolStripButton;
        internal System.Windows.Forms.ToolStripButton panToolStripButton;
        internal System.Windows.Forms.ToolStripButton zoomInToolStripButton;
        internal System.Windows.Forms.ToolStripButton zoomOutToolStripButton;
        internal System.Windows.Forms.ToolStripButton zoomRectToolStripButton;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator13;
        internal System.Windows.Forms.ToolStripButton printToolStripButton;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStripContainer ToolStripContainer1;
        internal System.Windows.Forms.ToolStripComboBox zoomToolStripComboBox;

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusBarMain = new System.Windows.Forms.StatusBar();
            this.StatusBarPanelState = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanelProgress = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanelPosition = new System.Windows.Forms.StatusBarPanel();
            this.imageListToolbarIcons = new System.Windows.Forms.ImageList(this.components);
            this.bitmapViewerMainView = new Aurigma.GraphicsMill.WinControls.BitmapViewer();
            this.zoomRectangleNavigatorExample = new Aurigma.GraphicsMill.WinControls.ZoomRectangleNavigator();
            this.rectangleRubberbandExample = new Aurigma.GraphicsMill.WinControls.RectangleRubberband();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panNavigatorExample = new Aurigma.GraphicsMill.WinControls.PanNavigator();
            this.zoomInNavigatorExample = new Aurigma.GraphicsMill.WinControls.ZoomInNavigator();
            this.zoomOutNavigatorExample = new Aurigma.GraphicsMill.WinControls.ZoomOutNavigator();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ImageInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bitmap1BitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IndexedColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrayscaleColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RgbColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmykColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.Bit8ColorDepthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bit16ColorDepthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.AlphaChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.AdjustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoBrightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrightnessContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoLevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChannelBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.HueSaturationLightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EqualizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.CropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RotateArbitraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlipHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlipVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.HistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransformsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdgeDetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdgeDetectGlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdgeDetectLaplaceHVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdgeDetectLaplaceOmniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdgeDetectPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdgeDetectPrewittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdgeDetectSharpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdgeDetectSharpMoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdgeDetectTraceContourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmbossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaximumFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MedianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinimumFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MosaicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SolarizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShadowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SprayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TexturizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnsharpMaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.redoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.pointerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.selectionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomRectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.zoomToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanelState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanelProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanelPosition)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.ToolStripContainer1.ContentPanel.SuspendLayout();
            this.ToolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.ToolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            //
            // openFileDialog
            //
            this.openFileDialog.InitialDirectory = "..\\Sample Files";
            //
            // statusBarMain
            //
            this.statusBarMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusBarMain.Location = new System.Drawing.Point(0, 415);
            this.statusBarMain.Name = "statusBarMain";
            this.statusBarMain.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.StatusBarPanelState,
            this.StatusBarPanelProgress,
            this.StatusBarPanelPosition});
            this.statusBarMain.ShowPanels = true;
            this.statusBarMain.Size = new System.Drawing.Size(810, 24);
            this.statusBarMain.TabIndex = 0;
            this.statusBarMain.Text = "StatusBar1";
            //
            // StatusBarPanelState
            //
            this.StatusBarPanelState.Name = "StatusBarPanelState";
            this.StatusBarPanelState.Text = "Ready";
            this.StatusBarPanelState.Width = 80;
            //
            // StatusBarPanelProgress
            //
            this.StatusBarPanelProgress.Name = "StatusBarPanelProgress";
            this.StatusBarPanelProgress.Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw;
            this.StatusBarPanelProgress.Width = 200;
            //
            // StatusBarPanelPosition
            //
            this.StatusBarPanelPosition.Name = "StatusBarPanelPosition";
            this.StatusBarPanelPosition.Text = "(0,0)";
            this.StatusBarPanelPosition.Width = 80;
            //
            // imageListToolbarIcons
            //
            this.imageListToolbarIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListToolbarIcons.ImageStream")));
            this.imageListToolbarIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListToolbarIcons.Images.SetKeyName(0, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(1, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(2, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(3, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(4, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(5, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(6, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(7, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(8, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(9, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(10, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(11, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(12, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(13, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(14, string.Empty);
            this.imageListToolbarIcons.Images.SetKeyName(15, string.Empty);
            //
            // bitmapViewerMainView
            //
            this.bitmapViewerMainView.BackColor = System.Drawing.Color.White;
            this.bitmapViewerMainView.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.bitmapViewerMainView.Cursor = System.Windows.Forms.Cursors.Default;
            this.bitmapViewerMainView.DefaultCursor = System.Windows.Forms.Cursors.Default;
            this.bitmapViewerMainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bitmapViewerMainView.HorizontalLargeChange = 5;
            this.bitmapViewerMainView.HorizontalSmallChange = 1;
            this.bitmapViewerMainView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bitmapViewerMainView.Location = new System.Drawing.Point(0, 0);
            this.bitmapViewerMainView.MinZoom = 0.05F;
            this.bitmapViewerMainView.Name = "bitmapViewerMainView";
            this.bitmapViewerMainView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bitmapViewerMainView.ScrollingPosition = new System.Drawing.Point(0, 0);
            this.bitmapViewerMainView.Size = new System.Drawing.Size(810, 415);
            this.bitmapViewerMainView.TabIndex = 0;
            this.bitmapViewerMainView.UndoRedoMaxStepCount = 4;
            this.bitmapViewerMainView.VerticalLargeChange = 5;
            this.bitmapViewerMainView.VerticalSmallChange = 1;
            this.bitmapViewerMainView.WorkspaceBorderColor = System.Drawing.Color.DimGray;
            this.bitmapViewerMainView.ZoomMode = Aurigma.GraphicsMill.WinControls.ZoomMode.None;
            this.bitmapViewerMainView.ZoomQuality = Aurigma.GraphicsMill.WinControls.ZoomQuality.Medium;
            this.bitmapViewerMainView.Zoomed += new System.EventHandler(this.bitmapViewerMainView_Zoomed);
            this.bitmapViewerMainView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bitmapViewMainView_MouseMove);
            //
            // zoomRectangleNavigatorExample
            //
            this.zoomRectangleNavigatorExample.OutlineColor1 = System.Drawing.Color.Red;
            this.zoomRectangleNavigatorExample.OutlineColor2 = System.Drawing.Color.Red;
            //
            // rectangleRubberbandExample
            //
            this.rectangleRubberbandExample.GripColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.rectangleRubberbandExample.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.rectangleRubberbandExample.MaskOpacity = 127;
            this.rectangleRubberbandExample.OutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(154)))), ((int)(((byte)(222)))));
            this.rectangleRubberbandExample.OutlineColor2 = System.Drawing.Color.White;
            this.rectangleRubberbandExample.Rectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.rectangleRubberbandExample.RectangleChanged += new Aurigma.GraphicsMill.WinControls.RectangleEventHandler(this.rectangleRubberbandExample_Selected);
            //
            // MenuStrip1
            //
            this.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ImageToolStripMenuItem,
            this.TransformsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(810, 24);
            this.MenuStrip1.TabIndex = 3;
            this.MenuStrip1.Text = "MenuStrip1";
            //
            // FileToolStripMenuItem
            //
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.ToolStripSeparator1,
            this.ImageInfoToolStripMenuItem,
            this.ToolStripSeparator2,
            this.PrintToolStripMenuItem,
            this.ToolStripSeparator3,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            //
            // OpenToolStripMenuItem
            //
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.OpenToolStripMenuItem.Text = "&Open...";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.MenuItemOpen_Click);
            //
            // SaveToolStripMenuItem
            //
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.SaveToolStripMenuItem.Text = "&Save...";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.MenuItemSave_Click);
            //
            // ToolStripSeparator1
            //
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            //
            // ImageInfoToolStripMenuItem
            //
            this.ImageInfoToolStripMenuItem.Name = "ImageInfoToolStripMenuItem";
            this.ImageInfoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ImageInfoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ImageInfoToolStripMenuItem.Text = "&Image Info...";
            this.ImageInfoToolStripMenuItem.Click += new System.EventHandler(this.MenuItemImageInfo_Click);
            //
            // ToolStripSeparator2
            //
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            //
            // PrintToolStripMenuItem
            //
            this.PrintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolStripMenuItem.Image")));
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.PrintToolStripMenuItem.Text = "&Print...";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.MenuItemPrint_Click);
            //
            // ToolStripSeparator3
            //
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            //
            // ExitToolStripMenuItem
            //
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.MenuItemExit_Click);
            //
            // EditToolStripMenuItem
            //
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem,
            this.ToolStripSeparator4,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "&Edit";
            //
            // UndoToolStripMenuItem
            //
            this.UndoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UndoToolStripMenuItem.Image")));
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.UndoToolStripMenuItem.Text = "&Undo";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.MenuItemUndo_Click);
            //
            // RedoToolStripMenuItem
            //
            this.RedoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RedoToolStripMenuItem.Image")));
            this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            this.RedoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.RedoToolStripMenuItem.Text = "&Redo";
            this.RedoToolStripMenuItem.Click += new System.EventHandler(this.MenuItemRedo_Click);
            //
            // ToolStripSeparator4
            //
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            this.ToolStripSeparator4.Visible = false;
            //
            // CutToolStripMenuItem
            //
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.CutToolStripMenuItem.Text = "Cu&t";
            this.CutToolStripMenuItem.Visible = false;
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.MenuItemCut_Click);
            //
            // CopyToolStripMenuItem
            //
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.CopyToolStripMenuItem.Text = "&Copy";
            this.CopyToolStripMenuItem.Visible = false;
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.MenuItemCopy_Click);
            //
            // PasteToolStripMenuItem
            //
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.PasteToolStripMenuItem.Text = "&Paste";
            this.PasteToolStripMenuItem.Visible = false;
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.MenuItemPaste_Click);
            //
            // ImageToolStripMenuItem
            //
            this.ImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModeToolStripMenuItem,
            this.ToolStripSeparator5,
            this.AdjustToolStripMenuItem,
            this.ToolStripSeparator6,
            this.CropToolStripMenuItem,
            this.ResizeToolStripMenuItem,
            this.RotateToolStripMenuItem,
            this.FlipToolStripMenuItem,
            this.ToolStripSeparator7,
            this.HistogramToolStripMenuItem,
            this.PaletteToolStripMenuItem});
            this.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem";
            this.ImageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ImageToolStripMenuItem.Text = "&Image";
            //
            // ModeToolStripMenuItem
            //
            this.ModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bitmap1BitToolStripMenuItem,
            this.IndexedColorToolStripMenuItem,
            this.GrayscaleColorToolStripMenuItem,
            this.RgbColorToolStripMenuItem,
            this.CmykColorToolStripMenuItem,
            this.ToolStripSeparator8,
            this.Bit8ColorDepthToolStripMenuItem,
            this.Bit16ColorDepthToolStripMenuItem,
            this.ToolStripSeparator9,
            this.AlphaChannelToolStripMenuItem});
            this.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem";
            this.ModeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ModeToolStripMenuItem.Text = "&Mode";
            //
            // Bitmap1BitToolStripMenuItem
            //
            this.Bitmap1BitToolStripMenuItem.Name = "Bitmap1BitToolStripMenuItem";
            this.Bitmap1BitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.Bitmap1BitToolStripMenuItem.Text = "&Bitmap (1 Bit)";
            this.Bitmap1BitToolStripMenuItem.Click += new System.EventHandler(this.MenuItemBitmap_Click);
            //
            // IndexedColorToolStripMenuItem
            //
            this.IndexedColorToolStripMenuItem.Name = "IndexedColorToolStripMenuItem";
            this.IndexedColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.IndexedColorToolStripMenuItem.Text = "&Indexed Color";
            this.IndexedColorToolStripMenuItem.Click += new System.EventHandler(this.MenuItemIndexed_Click);
            //
            // GrayscaleColorToolStripMenuItem
            //
            this.GrayscaleColorToolStripMenuItem.Name = "GrayscaleColorToolStripMenuItem";
            this.GrayscaleColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.GrayscaleColorToolStripMenuItem.Text = "&Grayscale Color";
            this.GrayscaleColorToolStripMenuItem.Click += new System.EventHandler(this.MenuItemGrayscale_Click);
            //
            // RgbColorToolStripMenuItem
            //
            this.RgbColorToolStripMenuItem.Name = "RgbColorToolStripMenuItem";
            this.RgbColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.RgbColorToolStripMenuItem.Text = "&RGB Color";
            this.RgbColorToolStripMenuItem.Click += new System.EventHandler(this.MenuRGB_Click);
            //
            // CmykColorToolStripMenuItem
            //
            this.CmykColorToolStripMenuItem.Name = "CmykColorToolStripMenuItem";
            this.CmykColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.CmykColorToolStripMenuItem.Text = "&CMYK Color";
            this.CmykColorToolStripMenuItem.Click += new System.EventHandler(this.MenuItemCMYK_Click);
            //
            // ToolStripSeparator8
            //
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(167, 6);
            //
            // Bit8ColorDepthToolStripMenuItem
            //
            this.Bit8ColorDepthToolStripMenuItem.Name = "Bit8ColorDepthToolStripMenuItem";
            this.Bit8ColorDepthToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.Bit8ColorDepthToolStripMenuItem.Text = "8 Bit Color &Depth";
            this.Bit8ColorDepthToolStripMenuItem.Click += new System.EventHandler(this.MenuItem8Bit_Click);
            //
            // Bit16ColorDepthToolStripMenuItem
            //
            this.Bit16ColorDepthToolStripMenuItem.Name = "Bit16ColorDepthToolStripMenuItem";
            this.Bit16ColorDepthToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.Bit16ColorDepthToolStripMenuItem.Text = "16 Bit Color D&epth";
            this.Bit16ColorDepthToolStripMenuItem.Click += new System.EventHandler(this.MenuItem16bit_Click);
            //
            // ToolStripSeparator9
            //
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(167, 6);
            //
            // AlphaChannelToolStripMenuItem
            //
            this.AlphaChannelToolStripMenuItem.Name = "AlphaChannelToolStripMenuItem";
            this.AlphaChannelToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.AlphaChannelToolStripMenuItem.Text = "&Alpha Channel";
            this.AlphaChannelToolStripMenuItem.Click += new System.EventHandler(this.MenuItemAlphaChannel_Click);
            //
            // ToolStripSeparator5
            //
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(136, 6);
            //
            // AdjustToolStripMenuItem
            //
            this.AdjustToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoBrightnessToolStripMenuItem,
            this.AutoContrastToolStripMenuItem,
            this.BrightnessContrastToolStripMenuItem,
            this.AutoLevelsToolStripMenuItem,
            this.LevelsToolStripMenuItem,
            this.ChannelBalanceToolStripMenuItem,
            this.CurvesToolStripMenuItem,
            this.ToolStripSeparator10,
            this.HueSaturationLightnessToolStripMenuItem,
            this.EqualizeToolStripMenuItem});
            this.AdjustToolStripMenuItem.Name = "AdjustToolStripMenuItem";
            this.AdjustToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.AdjustToolStripMenuItem.Text = "&Adjust";
            //
            // AutoBrightnessToolStripMenuItem
            //
            this.AutoBrightnessToolStripMenuItem.Name = "AutoBrightnessToolStripMenuItem";
            this.AutoBrightnessToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.AutoBrightnessToolStripMenuItem.Text = "Auto &Brightness";
            this.AutoBrightnessToolStripMenuItem.Click += new System.EventHandler(this.MenuItemAutoBrightness_Click);
            //
            // AutoContrastToolStripMenuItem
            //
            this.AutoContrastToolStripMenuItem.Name = "AutoContrastToolStripMenuItem";
            this.AutoContrastToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.AutoContrastToolStripMenuItem.Text = "Auto &Contrast";
            this.AutoContrastToolStripMenuItem.Click += new System.EventHandler(this.MenuAutoContrast_Click);
            //
            // BrightnessContrastToolStripMenuItem
            //
            this.BrightnessContrastToolStripMenuItem.Name = "BrightnessContrastToolStripMenuItem";
            this.BrightnessContrastToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.BrightnessContrastToolStripMenuItem.Text = "Brightne&ss-Contrast...";
            this.BrightnessContrastToolStripMenuItem.Click += new System.EventHandler(this.MenuItemBrightnessContrast_Click);
            //
            // AutoLevelsToolStripMenuItem
            //
            this.AutoLevelsToolStripMenuItem.Name = "AutoLevelsToolStripMenuItem";
            this.AutoLevelsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.AutoLevelsToolStripMenuItem.Text = "&Auto Levels";
            this.AutoLevelsToolStripMenuItem.Click += new System.EventHandler(this.MenuAutoLevels_Click);
            //
            // LevelsToolStripMenuItem
            //
            this.LevelsToolStripMenuItem.Name = "LevelsToolStripMenuItem";
            this.LevelsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.LevelsToolStripMenuItem.Text = "&Levels...";
            this.LevelsToolStripMenuItem.Click += new System.EventHandler(this.MenuLevels_Click);
            //
            // ChannelBalanceToolStripMenuItem
            //
            this.ChannelBalanceToolStripMenuItem.Name = "ChannelBalanceToolStripMenuItem";
            this.ChannelBalanceToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.ChannelBalanceToolStripMenuItem.Text = "Cha&nnel Balance...";
            this.ChannelBalanceToolStripMenuItem.Click += new System.EventHandler(this.MenuItemChannelBalance_Click);
            //
            // CurvesToolStripMenuItem
            //
            this.CurvesToolStripMenuItem.Name = "CurvesToolStripMenuItem";
            this.CurvesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.CurvesToolStripMenuItem.Text = "C&urves...";
            this.CurvesToolStripMenuItem.Click += new System.EventHandler(this.MenuItemCurves_Click);
            //
            // ToolStripSeparator10
            //
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new System.Drawing.Size(216, 6);
            //
            // HueSaturationLightnessToolStripMenuItem
            //
            this.HueSaturationLightnessToolStripMenuItem.Name = "HueSaturationLightnessToolStripMenuItem";
            this.HueSaturationLightnessToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.HueSaturationLightnessToolStripMenuItem.Text = "&Hue-Saturation-Lightness...";
            this.HueSaturationLightnessToolStripMenuItem.Click += new System.EventHandler(this.MenuAdjustHsl_Click);
            //
            // EqualizeToolStripMenuItem
            //
            this.EqualizeToolStripMenuItem.Name = "EqualizeToolStripMenuItem";
            this.EqualizeToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.EqualizeToolStripMenuItem.Text = "&Equalize";
            this.EqualizeToolStripMenuItem.Click += new System.EventHandler(this.MenuItemEqualize_Click);
            //
            // ToolStripSeparator6
            //
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(136, 6);
            //
            // CropToolStripMenuItem
            //
            this.CropToolStripMenuItem.Name = "CropToolStripMenuItem";
            this.CropToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.CropToolStripMenuItem.Text = "&Crop";
            this.CropToolStripMenuItem.Click += new System.EventHandler(this.MenuItemCrop_Click);
            //
            // ResizeToolStripMenuItem
            //
            this.ResizeToolStripMenuItem.Name = "ResizeToolStripMenuItem";
            this.ResizeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ResizeToolStripMenuItem.Text = "Re&size";
            this.ResizeToolStripMenuItem.Click += new System.EventHandler(this.MenuItemResize_Click);
            //
            // RotateToolStripMenuItem
            //
            this.RotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rotate90ToolStripMenuItem,
            this.Rotate180ToolStripMenuItem,
            this.Rotate270ToolStripMenuItem,
            this.RotateArbitraryToolStripMenuItem});
            this.RotateToolStripMenuItem.Name = "RotateToolStripMenuItem";
            this.RotateToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.RotateToolStripMenuItem.Text = "&Rotate";
            //
            // Rotate90ToolStripMenuItem
            //
            this.Rotate90ToolStripMenuItem.Name = "Rotate90ToolStripMenuItem";
            this.Rotate90ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.Rotate90ToolStripMenuItem.Text = "&Rotate 90°";
            this.Rotate90ToolStripMenuItem.Click += new System.EventHandler(this.MenuItemRotate90_Click);
            //
            // Rotate180ToolStripMenuItem
            //
            this.Rotate180ToolStripMenuItem.Name = "Rotate180ToolStripMenuItem";
            this.Rotate180ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.Rotate180ToolStripMenuItem.Text = "R&otate 180°";
            this.Rotate180ToolStripMenuItem.Click += new System.EventHandler(this.MenuItemRotate180_Click);
            //
            // Rotate270ToolStripMenuItem
            //
            this.Rotate270ToolStripMenuItem.Name = "Rotate270ToolStripMenuItem";
            this.Rotate270ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.Rotate270ToolStripMenuItem.Text = "Ro&tate 270°";
            this.Rotate270ToolStripMenuItem.Click += new System.EventHandler(this.MenuItemRotate270_Click);
            //
            // RotateArbitraryToolStripMenuItem
            //
            this.RotateArbitraryToolStripMenuItem.Name = "RotateArbitraryToolStripMenuItem";
            this.RotateArbitraryToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.RotateArbitraryToolStripMenuItem.Text = "Rotate &Arbitrary...";
            this.RotateArbitraryToolStripMenuItem.Click += new System.EventHandler(this.MenuItemRotateArbitary_Click);
            //
            // FlipToolStripMenuItem
            //
            this.FlipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FlipHorizontalToolStripMenuItem,
            this.FlipVerticalToolStripMenuItem});
            this.FlipToolStripMenuItem.Name = "FlipToolStripMenuItem";
            this.FlipToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.FlipToolStripMenuItem.Text = "&Flip";
            //
            // FlipHorizontalToolStripMenuItem
            //
            this.FlipHorizontalToolStripMenuItem.Name = "FlipHorizontalToolStripMenuItem";
            this.FlipHorizontalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.FlipHorizontalToolStripMenuItem.Text = "Flip &Horizontal";
            this.FlipHorizontalToolStripMenuItem.Click += new System.EventHandler(this.MenuItemFlipHorizontal_Click);
            //
            // FlipVerticalToolStripMenuItem
            //
            this.FlipVerticalToolStripMenuItem.Name = "FlipVerticalToolStripMenuItem";
            this.FlipVerticalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.FlipVerticalToolStripMenuItem.Text = "Flip &Vertical";
            this.FlipVerticalToolStripMenuItem.Click += new System.EventHandler(this.MenuItemFlipVertical_Click);
            //
            // ToolStripSeparator7
            //
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(136, 6);
            //
            // HistogramToolStripMenuItem
            //
            this.HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem";
            this.HistogramToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.HistogramToolStripMenuItem.Text = "&Histogram...";
            this.HistogramToolStripMenuItem.Click += new System.EventHandler(this.MenuItemHistogram_Click);
            //
            // PaletteToolStripMenuItem
            //
            this.PaletteToolStripMenuItem.Name = "PaletteToolStripMenuItem";
            this.PaletteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.PaletteToolStripMenuItem.Text = "&Palette...";
            this.PaletteToolStripMenuItem.Click += new System.EventHandler(this.MenuItemPalette_Click);
            //
            // TransformsToolStripMenuItem
            //
            this.TransformsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoiseToolStripMenuItem,
            this.BlurToolStripMenuItem,
            this.EdgeDetectToolStripMenuItem,
            this.EmbossToolStripMenuItem,
            this.MaximumFilterToolStripMenuItem,
            this.MedianFilterToolStripMenuItem,
            this.MinimumFilterToolStripMenuItem,
            this.MosaicToolStripMenuItem,
            this.SolarizeToolStripMenuItem,
            this.ShadowToolStripMenuItem,
            this.SharpenToolStripMenuItem,
            this.SprayToolStripMenuItem,
            this.TexturizeToolStripMenuItem,
            this.UnsharpMaskToolStripMenuItem});
            this.TransformsToolStripMenuItem.Name = "TransformsToolStripMenuItem";
            this.TransformsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.TransformsToolStripMenuItem.Text = "&Transforms";
            //
            // AddNoiseToolStripMenuItem
            //
            this.AddNoiseToolStripMenuItem.Name = "AddNoiseToolStripMenuItem";
            this.AddNoiseToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.AddNoiseToolStripMenuItem.Text = "&Add Noise...";
            this.AddNoiseToolStripMenuItem.Click += new System.EventHandler(this.MenuItemAddNoise_Click);
            //
            // BlurToolStripMenuItem
            //
            this.BlurToolStripMenuItem.Name = "BlurToolStripMenuItem";
            this.BlurToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.BlurToolStripMenuItem.Text = "&Blur...";
            this.BlurToolStripMenuItem.Click += new System.EventHandler(this.MenuItemBlur_Click);
            //
            // EdgeDetectToolStripMenuItem
            //
            this.EdgeDetectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EdgeDetectGlowToolStripMenuItem,
            this.EdgeDetectLaplaceHVToolStripMenuItem,
            this.EdgeDetectLaplaceOmniToolStripMenuItem,
            this.EdgeDetectPatternToolStripMenuItem,
            this.EdgeDetectPrewittToolStripMenuItem,
            this.EdgeDetectSharpToolStripMenuItem,
            this.EdgeDetectSharpMoreToolStripMenuItem,
            this.EdgeDetectTraceContourToolStripMenuItem});
            this.EdgeDetectToolStripMenuItem.Name = "EdgeDetectToolStripMenuItem";
            this.EdgeDetectToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.EdgeDetectToolStripMenuItem.Text = "Ed&ge Detect";
            //
            // EdgeDetectGlowToolStripMenuItem
            //
            this.EdgeDetectGlowToolStripMenuItem.Name = "EdgeDetectGlowToolStripMenuItem";
            this.EdgeDetectGlowToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.EdgeDetectGlowToolStripMenuItem.Text = "Edge Detect &Glow";
            this.EdgeDetectGlowToolStripMenuItem.Click += new System.EventHandler(this.MenuItemEdgeDetectGlow_Click);
            //
            // EdgeDetectLaplaceHVToolStripMenuItem
            //
            this.EdgeDetectLaplaceHVToolStripMenuItem.Name = "EdgeDetectLaplaceHVToolStripMenuItem";
            this.EdgeDetectLaplaceHVToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.EdgeDetectLaplaceHVToolStripMenuItem.Text = "Edge Detect Laplace &HV";
            this.EdgeDetectLaplaceHVToolStripMenuItem.Click += new System.EventHandler(this.MenuItemEdgeDetectLaplaceHV_Click);
            //
            // EdgeDetectLaplaceOmniToolStripMenuItem
            //
            this.EdgeDetectLaplaceOmniToolStripMenuItem.Name = "EdgeDetectLaplaceOmniToolStripMenuItem";
            this.EdgeDetectLaplaceOmniToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.EdgeDetectLaplaceOmniToolStripMenuItem.Text = "Edge Detect Laplace &Omni";
            this.EdgeDetectLaplaceOmniToolStripMenuItem.Click += new System.EventHandler(this.MenuItemEdgeDetectLaplaceOmni_Click);
            //
            // EdgeDetectPatternToolStripMenuItem
            //
            this.EdgeDetectPatternToolStripMenuItem.Name = "EdgeDetectPatternToolStripMenuItem";
            this.EdgeDetectPatternToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.EdgeDetectPatternToolStripMenuItem.Text = "Edge Detect &Pattern";
            this.EdgeDetectPatternToolStripMenuItem.Click += new System.EventHandler(this.MenuItemEdgeDetectPattern_Click);
            //
            // EdgeDetectPrewittToolStripMenuItem
            //
            this.EdgeDetectPrewittToolStripMenuItem.Name = "EdgeDetectPrewittToolStripMenuItem";
            this.EdgeDetectPrewittToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.EdgeDetectPrewittToolStripMenuItem.Text = "Edge Detect Pre&witt";
            this.EdgeDetectPrewittToolStripMenuItem.Click += new System.EventHandler(this.MenuItemEdgeDetectPrewitt_Click);
            //
            // EdgeDetectSharpToolStripMenuItem
            //
            this.EdgeDetectSharpToolStripMenuItem.Name = "EdgeDetectSharpToolStripMenuItem";
            this.EdgeDetectSharpToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.EdgeDetectSharpToolStripMenuItem.Text = "Edge Detect &Sharp";
            this.EdgeDetectSharpToolStripMenuItem.Click += new System.EventHandler(this.MenuItemEdgeDetectSharp_Click);
            //
            // EdgeDetectSharpMoreToolStripMenuItem
            //
            this.EdgeDetectSharpMoreToolStripMenuItem.Name = "EdgeDetectSharpMoreToolStripMenuItem";
            this.EdgeDetectSharpMoreToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.EdgeDetectSharpMoreToolStripMenuItem.Text = "Edge Detect Sharp &More";
            this.EdgeDetectSharpMoreToolStripMenuItem.Click += new System.EventHandler(this.MenuItemEdgeDetectSharpMore_Click);
            //
            // EdgeDetectTraceContourToolStripMenuItem
            //
            this.EdgeDetectTraceContourToolStripMenuItem.Name = "EdgeDetectTraceContourToolStripMenuItem";
            this.EdgeDetectTraceContourToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.EdgeDetectTraceContourToolStripMenuItem.Text = "Edge Detect &Trace Contour";
            this.EdgeDetectTraceContourToolStripMenuItem.Click += new System.EventHandler(this.MenuItemEdgeDetectTraceContour_Click);
            //
            // EmbossToolStripMenuItem
            //
            this.EmbossToolStripMenuItem.Name = "EmbossToolStripMenuItem";
            this.EmbossToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.EmbossToolStripMenuItem.Text = "&Emboss...";
            this.EmbossToolStripMenuItem.Click += new System.EventHandler(this.MenuItemEmboss_Click);
            //
            // MaximumFilterToolStripMenuItem
            //
            this.MaximumFilterToolStripMenuItem.Name = "MaximumFilterToolStripMenuItem";
            this.MaximumFilterToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.MaximumFilterToolStripMenuItem.Text = "Ma&ximum Filter...";
            this.MaximumFilterToolStripMenuItem.Click += new System.EventHandler(this.MenuItemMaximumFilter_Click);
            //
            // MedianFilterToolStripMenuItem
            //
            this.MedianFilterToolStripMenuItem.Name = "MedianFilterToolStripMenuItem";
            this.MedianFilterToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.MedianFilterToolStripMenuItem.Text = "Median &Filter...";
            this.MedianFilterToolStripMenuItem.Click += new System.EventHandler(this.MenuItemMedianFilter_Click);
            //
            // MinimumFilterToolStripMenuItem
            //
            this.MinimumFilterToolStripMenuItem.Name = "MinimumFilterToolStripMenuItem";
            this.MinimumFilterToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.MinimumFilterToolStripMenuItem.Text = "Minim&um Filter...";
            this.MinimumFilterToolStripMenuItem.Click += new System.EventHandler(this.MenuItemMinimumFilter_Click);
            //
            // MosaicToolStripMenuItem
            //
            this.MosaicToolStripMenuItem.Name = "MosaicToolStripMenuItem";
            this.MosaicToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.MosaicToolStripMenuItem.Text = "&Mosaic...";
            this.MosaicToolStripMenuItem.Click += new System.EventHandler(this.MenuItemMosaic_Click);
            //
            // SolarizeToolStripMenuItem
            //
            this.SolarizeToolStripMenuItem.Name = "SolarizeToolStripMenuItem";
            this.SolarizeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.SolarizeToolStripMenuItem.Text = "Sola&rize";
            this.SolarizeToolStripMenuItem.Click += new System.EventHandler(this.MenuItemSolarize_Click);
            //
            // ShadowToolStripMenuItem
            //
            this.ShadowToolStripMenuItem.Name = "ShadowToolStripMenuItem";
            this.ShadowToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ShadowToolStripMenuItem.Text = "&Shadow...";
            this.ShadowToolStripMenuItem.Click += new System.EventHandler(this.MenuItemShadow_Click);
            //
            // SharpenToolStripMenuItem
            //
            this.SharpenToolStripMenuItem.Name = "SharpenToolStripMenuItem";
            this.SharpenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.SharpenToolStripMenuItem.Text = "S&harpen...";
            this.SharpenToolStripMenuItem.Click += new System.EventHandler(this.MenuItemSharpen_Click);
            //
            // SprayToolStripMenuItem
            //
            this.SprayToolStripMenuItem.Name = "SprayToolStripMenuItem";
            this.SprayToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.SprayToolStripMenuItem.Text = "Spra&y...";
            this.SprayToolStripMenuItem.Click += new System.EventHandler(this.MenuItemSpray_Click);
            //
            // TexturizeToolStripMenuItem
            //
            this.TexturizeToolStripMenuItem.Name = "TexturizeToolStripMenuItem";
            this.TexturizeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.TexturizeToolStripMenuItem.Text = "&Texturize...";
            this.TexturizeToolStripMenuItem.Click += new System.EventHandler(this.MenuItemTexturize_Click);
            //
            // UnsharpMaskToolStripMenuItem
            //
            this.UnsharpMaskToolStripMenuItem.Name = "UnsharpMaskToolStripMenuItem";
            this.UnsharpMaskToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.UnsharpMaskToolStripMenuItem.Text = "Unsharp &Mask...";
            this.UnsharpMaskToolStripMenuItem.Click += new System.EventHandler(this.MenuItemUnsharpMask_Click);
            //
            // HelpToolStripMenuItem
            //
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            //
            // AboutToolStripMenuItem
            //
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.AboutToolStripMenuItem.Text = "&About...";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.MenuItemAbout_Click);
            //
            // ToolStrip1
            //
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.ToolStripSeparator11,
            this.undoToolStripButton,
            this.redoToolStripButton,
            this.ToolStripSeparator12,
            this.pointerToolStripButton,
            this.selectionToolStripButton,
            this.panToolStripButton,
            this.zoomInToolStripButton,
            this.zoomOutToolStripButton,
            this.zoomRectToolStripButton,
            this.ToolStripSeparator13,
            this.printToolStripButton,
            this.ToolStripLabel1,
            this.zoomToolStripComboBox});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(810, 25);
            this.ToolStrip1.Stretch = true;
            this.ToolStrip1.TabIndex = 4;
            this.ToolStrip1.Text = "ToolStrip1";
            //
            // openToolStripButton
            //
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "ToolStripButton2";
            this.openToolStripButton.ToolTipText = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            //
            // saveToolStripButton
            //
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Enabled = false;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "ToolStripButton3";
            this.saveToolStripButton.ToolTipText = "Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            //
            // ToolStripSeparator11
            //
            this.ToolStripSeparator11.Name = "ToolStripSeparator11";
            this.ToolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            //
            // undoToolStripButton
            //
            this.undoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoToolStripButton.Enabled = false;
            this.undoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripButton.Image")));
            this.undoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoToolStripButton.Name = "undoToolStripButton";
            this.undoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.undoToolStripButton.Text = "ToolStripButton4";
            this.undoToolStripButton.ToolTipText = "Undo";
            this.undoToolStripButton.Click += new System.EventHandler(this.undoToolStripButton_Click);
            //
            // redoToolStripButton
            //
            this.redoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoToolStripButton.Enabled = false;
            this.redoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripButton.Image")));
            this.redoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoToolStripButton.Name = "redoToolStripButton";
            this.redoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.redoToolStripButton.Text = "ToolStripButton5";
            this.redoToolStripButton.ToolTipText = "Redo";
            this.redoToolStripButton.Click += new System.EventHandler(this.redoToolStripButton_Click);
            //
            // ToolStripSeparator12
            //
            this.ToolStripSeparator12.Name = "ToolStripSeparator12";
            this.ToolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            //
            // pointerToolStripButton
            //
            this.pointerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pointerToolStripButton.Enabled = false;
            this.pointerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pointerToolStripButton.Image")));
            this.pointerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pointerToolStripButton.Name = "pointerToolStripButton";
            this.pointerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pointerToolStripButton.Text = "ToolStripButton6";
            this.pointerToolStripButton.ToolTipText = "Pointer";
            this.pointerToolStripButton.Click += new System.EventHandler(this.pointerToolStripButton_Click);
            //
            // selectionToolStripButton
            //
            this.selectionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectionToolStripButton.Enabled = false;
            this.selectionToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("selectionToolStripButton.Image")));
            this.selectionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectionToolStripButton.Name = "selectionToolStripButton";
            this.selectionToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.selectionToolStripButton.Text = "ToolStripButton7";
            this.selectionToolStripButton.ToolTipText = "Select";
            this.selectionToolStripButton.Click += new System.EventHandler(this.selectionToolStripButton_Click);
            //
            // panToolStripButton
            //
            this.panToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.panToolStripButton.Enabled = false;
            this.panToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("panToolStripButton.Image")));
            this.panToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.panToolStripButton.Name = "panToolStripButton";
            this.panToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.panToolStripButton.Text = "ToolStripButton8";
            this.panToolStripButton.ToolTipText = "Pan";
            this.panToolStripButton.Click += new System.EventHandler(this.panToolStripButton_Click);
            //
            // zoomInToolStripButton
            //
            this.zoomInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInToolStripButton.Enabled = false;
            this.zoomInToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInToolStripButton.Image")));
            this.zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInToolStripButton.Name = "zoomInToolStripButton";
            this.zoomInToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomInToolStripButton.Text = "ToolStripButton9";
            this.zoomInToolStripButton.ToolTipText = "Zoom in";
            this.zoomInToolStripButton.Click += new System.EventHandler(this.zoomInToolStripButton_Click);
            //
            // zoomOutToolStripButton
            //
            this.zoomOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutToolStripButton.Enabled = false;
            this.zoomOutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutToolStripButton.Image")));
            this.zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutToolStripButton.Name = "zoomOutToolStripButton";
            this.zoomOutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomOutToolStripButton.Text = "ToolStripButton10";
            this.zoomOutToolStripButton.ToolTipText = "Zoom out";
            this.zoomOutToolStripButton.Click += new System.EventHandler(this.zoomOutToolStripButton_Click);
            //
            // zoomRectToolStripButton
            //
            this.zoomRectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomRectToolStripButton.Enabled = false;
            this.zoomRectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomRectToolStripButton.Image")));
            this.zoomRectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomRectToolStripButton.Name = "zoomRectToolStripButton";
            this.zoomRectToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomRectToolStripButton.Text = "ToolStripButton11";
            this.zoomRectToolStripButton.ToolTipText = "Zoom selection";
            this.zoomRectToolStripButton.Click += new System.EventHandler(this.zoomRectToolStripButton_Click);
            //
            // ToolStripSeparator13
            //
            this.ToolStripSeparator13.Name = "ToolStripSeparator13";
            this.ToolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            //
            // printToolStripButton
            //
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Enabled = false;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "ToolStripButton12";
            this.printToolStripButton.ToolTipText = "Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            //
            // ToolStripLabel1
            //
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(28, 22);
            this.ToolStripLabel1.Text = "       ";
            //
            // zoomToolStripComboBox
            //
            this.zoomToolStripComboBox.Name = "zoomToolStripComboBox";
            this.zoomToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.zoomToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBoxZoom_SelectedIndexChanged);
            this.zoomToolStripComboBox.LostFocus += new System.EventHandler(this.comboBoxZoom_LostFocus);
            this.zoomToolStripComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxZoom_KeyPress);
            this.zoomToolStripComboBox.TextChanged += new System.EventHandler(this.comboBoxZoom_TextChanged);
            //
            // ToolStripContainer1
            //
            //
            // ToolStripContainer1.ContentPanel
            //
            this.ToolStripContainer1.ContentPanel.AutoScroll = true;
            this.ToolStripContainer1.ContentPanel.Controls.Add(this.bitmapViewerMainView);
            this.ToolStripContainer1.ContentPanel.Controls.Add(this.statusBarMain);
            this.ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(810, 439);
            this.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.ToolStripContainer1.Name = "ToolStripContainer1";
            this.ToolStripContainer1.Size = new System.Drawing.Size(810, 488);
            this.ToolStripContainer1.TabIndex = 5;
            this.ToolStripContainer1.Text = "ToolStripContainer1";
            //
            // ToolStripContainer1.TopToolStripPanel
            //
            this.ToolStripContainer1.TopToolStripPanel.Controls.Add(this.MenuStrip1);
            this.ToolStripContainer1.TopToolStripPanel.Controls.Add(this.ToolStrip1);
            //
            // FormMain
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(810, 488);
            this.Controls.Add(this.ToolStripContainer1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "FormMain";
            this.Text = "Aurigma Graphics Mill for .NET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanelState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanelProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanelPosition)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ToolStripContainer1.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer1.TopToolStripPanel.PerformLayout();
            this.ToolStripContainer1.ResumeLayout(false);
            this.ToolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion " Windows Form Designer generated code "

        #region "Local variable declaration"

        private System.Windows.Forms.ProgressBar _progressBarMain;

        #endregion "Local variable declaration"

        #region "Misc"

        // Apply transforms which don't require dialog with properties
        private void ApplyTransform(IBitmapTransform transform)
        {
            var res = transform.Apply(bitmapViewerMainView.Bitmap);
            bitmapViewerMainView.Bitmap = res;
        }

        // Apply transforms which require dialog with properties
        private void ApplyTransform(System.Windows.Forms.UserControl propertyPage)
        {
            IBitmapTransform transform = TransformDialog.ApplyTransform(bitmapViewerMainView.Bitmap, propertyPage);

            _progressBarMain.Visible = true;
            statusBarMain.Panels[0].Text = "Working...";
            Enabled = false;

            var callBack = new System.Threading.WaitCallback((state) =>
            {
                IBitmapTransform bitmapTransform = (IBitmapTransform)state;

                try
                {
                    if (!(bitmapTransform == null))
                    {
                        ApplyTransform(bitmapTransform);
                    }
                }
                finally
                {
                    _progressBarMain.Visible = false;
                    statusBarMain.Panels[0].Text = "Ready";
                    Enabled = true;
                }
            });

            System.Threading.ThreadPool.QueueUserWorkItem(callBack, transform);
        }

        // Handles mouse move and shows mouse coordinates
        private void bitmapViewMainView_MouseMove(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (bitmapViewerMainView.Bitmap != null)
            {
                PointF bitmapPointF = bitmapViewerMainView.ControlToWorkspace(new Point(e.X, e.Y), Aurigma.GraphicsMill.Unit.Pixel);

                Point bitmapPoint = new Point((int)bitmapPointF.X, (int)bitmapPointF.Y);

                if ((bitmapPoint.X >= 0 && bitmapPoint.Y >= 0) && (bitmapPoint.X < bitmapViewerMainView.Bitmap.Width && bitmapPoint.Y < bitmapViewerMainView.Bitmap.Height))
                {
                    statusBarMain.Panels[2].Text = "(" + bitmapPoint.X.ToString() + "," + bitmapPoint.Y.ToString() + ")";
                    return;
                }
            }

            statusBarMain.Panels[2].Text = string.Empty;
        }

        #endregion "Misc"

        #region "Handling Bitmap And Responsible Events"

        private void bitmapViewerMainView_ContentChanged(object sender, EventArgs e)
        {
            UndoToolStripMenuItem.Enabled = bitmapViewerMainView.CanUndo;
            undoToolStripButton.Enabled = UndoToolStripMenuItem.Enabled;
            RedoToolStripMenuItem.Enabled = bitmapViewerMainView.CanRedo;
            redoToolStripButton.Enabled = RedoToolStripMenuItem.Enabled;
            ImageInfoToolStripMenuItem.Enabled = !bitmapViewerMainView.Bitmap.IsEmpty;
            SetMenuAndToolbar(!bitmapViewerMainView.Bitmap.IsEmpty);
            ShowPixelFormat();
        }

        private void rectangleRubberbandExample_Selected(System.Object sender, Aurigma.GraphicsMill.WinControls.RectangleEventArgs pEventArgs)
        {
            CropToolStripMenuItem.Enabled = (rectangleRubberbandExample.Rectangle.Width > 0) && (rectangleRubberbandExample.Rectangle.Height > 0);
        }

        #endregion "Handling Bitmap And Responsible Events"

        #region "Toolbar Events"

        private void openToolStripButton_Click(System.Object sender, System.EventArgs e)
        {
            MenuItemOpen_Click(OpenToolStripMenuItem, new System.EventArgs());
        }

        private void saveToolStripButton_Click(System.Object sender, System.EventArgs e)
        {
            MenuItemSave_Click(SaveToolStripMenuItem, new System.EventArgs());
        }

        private void undoToolStripButton_Click(System.Object sender, System.EventArgs e)
        {
            MenuItemUndo_Click(UndoToolStripMenuItem, new System.EventArgs());
        }

        private void redoToolStripButton_Click(System.Object sender, System.EventArgs e)
        {
            MenuItemRedo_Click(RedoToolStripMenuItem, new System.EventArgs());
        }

        private void pointerToolStripButton_Click(System.Object sender, System.EventArgs e)
        {
            bitmapViewerMainView.Rubberband = null;
            bitmapViewerMainView.Navigator = null;
            UnpushToolBarButtons();
            pointerToolStripButton.Checked = true;
            CropToolStripMenuItem.Enabled = false;
        }

        private void selectionToolStripButton_Click(System.Object sender, System.EventArgs e)
        {
            bitmapViewerMainView.Rubberband = rectangleRubberbandExample;
            bitmapViewerMainView.Navigator = null;
            UnpushToolBarButtons();
            selectionToolStripButton.Checked = true;

            CropToolStripMenuItem.Enabled = (rectangleRubberbandExample.Rectangle.Width > 0) && (rectangleRubberbandExample.Rectangle.Height > 0);
        }

        private void panToolStripButton_Click(System.Object sender, System.EventArgs e)
        {
            bitmapViewerMainView.Navigator = panNavigatorExample;
            bitmapViewerMainView.Rubberband = null;
            UnpushToolBarButtons();
            panToolStripButton.Checked = true;

            CropToolStripMenuItem.Enabled = false;
        }

        private void zoomInToolStripButton_Click(System.Object sender, System.EventArgs e)
        {
            bitmapViewerMainView.ZoomMode = ZoomMode.None;
            bitmapViewerMainView.Navigator = zoomInNavigatorExample;
            bitmapViewerMainView.Rubberband = null;
            UnpushToolBarButtons();
            zoomInToolStripButton.Checked = true;

            CropToolStripMenuItem.Enabled = false;
        }

        private void zoomOutToolStripButton_Click(System.Object sender, System.EventArgs e)
        {
            bitmapViewerMainView.ZoomMode = ZoomMode.None;
            bitmapViewerMainView.Navigator = zoomOutNavigatorExample;
            bitmapViewerMainView.Rubberband = null;
            UnpushToolBarButtons();
            zoomOutToolStripButton.Checked = true;

            CropToolStripMenuItem.Enabled = false;
        }

        private void zoomRectToolStripButton_Click(System.Object sender, System.EventArgs e)
        {
            bitmapViewerMainView.ZoomMode = ZoomMode.None;
            bitmapViewerMainView.Navigator = zoomRectangleNavigatorExample;
            bitmapViewerMainView.Rubberband = null;
            UnpushToolBarButtons();
            zoomRectToolStripButton.Checked = true;

            CropToolStripMenuItem.Enabled = false;
        }

        private void printToolStripButton_Click(System.Object sender, System.EventArgs e)
        {
            MenuItemPrint_Click(this, System.EventArgs.Empty);
        }

        private void UnpushToolBarButtons()
        {
            pointerToolStripButton.Checked = false;
            selectionToolStripButton.Checked = false;
            panToolStripButton.Checked = false;
            zoomInToolStripButton.Checked = false;
            zoomOutToolStripButton.Checked = false;
            zoomRectToolStripButton.Checked = false;
        }

        private bool isExceptionOccured = false;
        private bool isTextChanged = false;

        private void ParseComboBoxZoomText()
        {
            isTextChanged = false;
            if ((zoomToolStripComboBox.Text == "Best Fit") || (zoomToolStripComboBox.Text == "Fit to Width") || (zoomToolStripComboBox.Text == "Fit to Height"))
            {
                if (zoomToolStripComboBox.Text == "Best Fit")
                {
                    bitmapViewerMainView.ZoomMode = ZoomMode.BestFit;
                }
                else if (zoomToolStripComboBox.Text == "Fit to Width")
                {
                    bitmapViewerMainView.ZoomMode = ZoomMode.FitToWidth;
                }
                else if (zoomToolStripComboBox.Text == "Fit to Height")
                {
                    bitmapViewerMainView.ZoomMode = ZoomMode.FitToHeight;
                }
                return;
            }

            float zoom;
            string strZoom = zoomToolStripComboBox.Text.Trim(null);

            // Zoom can contain % in the end of text

            if (strZoom.Length == 0)
            {
                return;
            }
            System.Globalization.NumberFormatInfo numberFormat = new System.Globalization.NumberFormatInfo();
            if (strZoom[strZoom.Length - 1] == '%')
            {
                zoom = Convert.ToSingle(float.Parse(strZoom.Substring(0, strZoom.Length - 1), numberFormat) / 100.0F);
            }
            else
            {
                zoom = Convert.ToSingle(float.Parse(strZoom, numberFormat) / 100.0F);
            }

            if ((zoom < bitmapViewerMainView.MinZoom) || (zoom > bitmapViewerMainView.MaxZoom))
            {
                throw new System.FormatException(string.Empty);
            }

            bitmapViewerMainView.ZoomMode = ZoomMode.None;
            bitmapViewerMainView.Zoom = zoom;
        }

        private void comboBoxZoom_KeyPress(System.Object sender, KeyPressEventArgs e)
        {
            if ((!isExceptionOccured) && (e.KeyChar == Convert.ToChar(13)))
            {
                try
                {
                    ParseComboBoxZoomText();
                    isExceptionOccured = false;
                }
                catch (FormatException)
                {
                    isExceptionOccured = true;
                    MessageBox.Show(this, "Zoom value must be an integer number form 5 to 1600.", "Incorrect zoom value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    zoomToolStripComboBox.Focus();
                    isExceptionOccured = false;
                }
            }
        }

        private void comboBoxZoom_LostFocus(System.Object sender, System.EventArgs e)
        {
            if ((!isExceptionOccured) && isTextChanged)
            {
                try
                {
                    ParseComboBoxZoomText();
                    isExceptionOccured = false;
                }
                catch (FormatException)
                {
                    isExceptionOccured = true;
                    MessageBox.Show(this, "Zoom value must be an integer number form 5 to 1600.", "Incorrect zoom value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    zoomToolStripComboBox.Focus();
                    isExceptionOccured = false;
                }
            }
        }

        private void comboBoxZoom_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (!isExceptionOccured)
            {
                try
                {
                    ParseComboBoxZoomText();
                    isExceptionOccured = false;
                }
                catch (FormatException)
                {
                    isExceptionOccured = true;
                    MessageBox.Show(this, "Zoom value must be an integer number form 5 to 1600.", "Incorrect zoom value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    zoomToolStripComboBox.Focus();
                    isExceptionOccured = false;
                }
            }
        }

        private void comboBoxZoom_TextChanged(System.Object sender, System.EventArgs e)
        {
            isTextChanged = true;
        }

        private void bitmapViewerMainView_Zoomed(object sender, System.EventArgs e)
        {
            if (bitmapViewerMainView.ZoomMode != ZoomMode.None)
                return;
            string zoom = Convert.ToString(System.Math.Round(bitmapViewerMainView.Zoom * 100.0F), new System.Globalization.NumberFormatInfo()) + "%";
            if (!zoomToolStripComboBox.Focused)
            {
                zoomToolStripComboBox.Text = zoom;
            }
        }

        private void bitmapViewerMainView_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (bitmapViewerMainView.ZoomMode != ZoomMode.None)
                bitmapViewerMainView.ZoomMode = ZoomMode.None;
        }

        #endregion "Toolbar Events"

        #region "Menu Routines"

        private void ShowPixelFormat()
        {
            // Uncheck all modes

            Bitmap1BitToolStripMenuItem.Checked = false;
            IndexedColorToolStripMenuItem.Checked = false;
            GrayscaleColorToolStripMenuItem.Checked = false;
            RgbColorToolStripMenuItem.Checked = false;
            CmykColorToolStripMenuItem.Checked = false;

            // Check current pixel format and mark appropriate mode

            if (bitmapViewerMainView.Bitmap.PixelFormat == PixelFormat.Format1bppIndexed)
            {
                Bitmap1BitToolStripMenuItem.Checked = true;
            }
            else if ((bitmapViewerMainView.Bitmap.PixelFormat == PixelFormat.Format4bppIndexed) || (bitmapViewerMainView.Bitmap.PixelFormat == PixelFormat.Format8bppIndexed))
            {
                IndexedColorToolStripMenuItem.Checked = true;
            }
            else if (bitmapViewerMainView.Bitmap.PixelFormat.IsGrayscale)
            {
                GrayscaleColorToolStripMenuItem.Checked = true;
            }
            else if (bitmapViewerMainView.Bitmap.PixelFormat.IsRgb)
            {
                RgbColorToolStripMenuItem.Checked = true;
            }
            else if (bitmapViewerMainView.Bitmap.PixelFormat.IsCmyk)
            {
                CmykColorToolStripMenuItem.Checked = true;
            }

            // Check if there is alpha channel available

            AlphaChannelToolStripMenuItem.Checked = bitmapViewerMainView.Bitmap.HasAlpha;

            // Check whether image is 8 or 16 bit per channel

            Bit16ColorDepthToolStripMenuItem.Checked = bitmapViewerMainView.Bitmap.PixelFormat.IsExtended;
            Bit8ColorDepthToolStripMenuItem.Checked = !Bit16ColorDepthToolStripMenuItem.Checked;

            // Enable palette dialog for indexed images

            PaletteToolStripMenuItem.Enabled = bitmapViewerMainView.Bitmap.PixelFormat.IsIndexed;
            HistogramToolStripMenuItem.Enabled = bitmapViewerMainView.Bitmap.PixelFormat != PixelFormat.Format1bppIndexed;

            // Check for each effect if this pixel format is supported. If not, disable this effect

            Crop _crop = new Crop();
            CropToolStripMenuItem.Enabled = _crop.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _crop.Dispose();

            Resize _resize = new Resize();
            ResizeToolStripMenuItem.Enabled = _resize.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _resize.Dispose();

            Rotate _rotateAndFlip = new Rotate();
            Rotate90ToolStripMenuItem.Enabled = _rotateAndFlip.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            Rotate180ToolStripMenuItem.Enabled = _rotateAndFlip.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            Rotate270ToolStripMenuItem.Enabled = _rotateAndFlip.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            FlipHorizontalToolStripMenuItem.Enabled = _rotateAndFlip.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            FlipVerticalToolStripMenuItem.Enabled = _rotateAndFlip.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _rotateAndFlip.Dispose();

            Rotate _rotate = new Rotate();
            RotateArbitraryToolStripMenuItem.Enabled = _rotate.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _rotate.Dispose();

            BrightnessContrast _brightnessContrast = new BrightnessContrast();
            AutoBrightnessToolStripMenuItem.Enabled = _brightnessContrast.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            AutoContrastToolStripMenuItem.Enabled = _brightnessContrast.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            BrightnessContrastToolStripMenuItem.Enabled = _brightnessContrast.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _brightnessContrast.Dispose();

            Levels _levels = new Levels();
            LevelsToolStripMenuItem.Enabled = _levels.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            AutoLevelsToolStripMenuItem.Enabled = LevelsToolStripMenuItem.Enabled;
            _levels.Dispose();

            Levels _applyLut = new Levels();
            CurvesToolStripMenuItem.Enabled = _applyLut.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _applyLut.Dispose();

            ChannelBalance _channelBalance = new ChannelBalance();
            ChannelBalanceToolStripMenuItem.Enabled = _channelBalance.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _channelBalance.Dispose();

            HistogramEqualize _histogramEqualize = new HistogramEqualize();
            EqualizeToolStripMenuItem.Enabled = _histogramEqualize.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _histogramEqualize.Dispose();

            AdjustHsl _adjustHsl = new AdjustHsl();
            HueSaturationLightnessToolStripMenuItem.Enabled = _adjustHsl.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _adjustHsl.Dispose();

            AddNoise _addNoise = new AddNoise();
            AddNoiseToolStripMenuItem.Enabled = _addNoise.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _addNoise.Dispose();

            Blur _blur = new Blur();
            BlurToolStripMenuItem.Enabled = _blur.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _blur.Dispose();

            EdgeDetect _edgeDetect = new EdgeDetect();
            EdgeDetectGlowToolStripMenuItem.Enabled = _edgeDetect.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            EdgeDetectLaplaceHVToolStripMenuItem.Enabled = _edgeDetect.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            EdgeDetectLaplaceOmniToolStripMenuItem.Enabled = _edgeDetect.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            EdgeDetectPatternToolStripMenuItem.Enabled = _edgeDetect.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            EdgeDetectPrewittToolStripMenuItem.Enabled = _edgeDetect.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            EdgeDetectSharpToolStripMenuItem.Enabled = _edgeDetect.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            EdgeDetectSharpMoreToolStripMenuItem.Enabled = _edgeDetect.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            EdgeDetectTraceContourToolStripMenuItem.Enabled = _edgeDetect.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _edgeDetect.Dispose();

            Emboss _emboss = new Emboss();
            EmbossToolStripMenuItem.Enabled = _emboss.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _emboss.Dispose();

            Maximum _maximumFilter = new Maximum();
            MaximumFilterToolStripMenuItem.Enabled = _maximumFilter.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _maximumFilter.Dispose();

            Median _medianFilter = new Median();
            MedianFilterToolStripMenuItem.Enabled = _medianFilter.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _medianFilter.Dispose();

            Minimum _minimumFilter = new Minimum();
            MinimumFilterToolStripMenuItem.Enabled = _minimumFilter.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _minimumFilter.Dispose();

            Sharpen _sharpen = new Sharpen();
            SharpenToolStripMenuItem.Enabled = _sharpen.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _sharpen.Dispose();

            UnsharpMask _unsharpMask = new UnsharpMask();
            UnsharpMaskToolStripMenuItem.Enabled = _unsharpMask.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _unsharpMask.Dispose();

            Mosaic _mosaic = new Mosaic();
            MosaicToolStripMenuItem.Enabled = _mosaic.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _mosaic.Dispose();

            Shadow _shadow = new Shadow();
            ShadowToolStripMenuItem.Enabled = _shadow.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _shadow.Dispose();

            Solarize _solarize = new Solarize();
            SolarizeToolStripMenuItem.Enabled = _solarize.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _solarize.Dispose();

            Spray _spray = new Spray();
            SprayToolStripMenuItem.Enabled = _spray.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _spray.Dispose();

            Texturize _texturize = new Texturize();
            TexturizeToolStripMenuItem.Enabled = _texturize.IsPixelFormatSupported(bitmapViewerMainView.Bitmap.PixelFormat);
            _texturize.Dispose();
        }

        private void SetMenuAndToolbar(bool value)
        {
            // Enable zoom combobox

            zoomToolStripComboBox.Enabled = value;

            // Enable toolbar items

            saveToolStripButton.Enabled = value;
            zoomInToolStripButton.Enabled = value;
            zoomOutToolStripButton.Enabled = value;
            zoomRectToolStripButton.Enabled = value;
            panToolStripButton.Enabled = value;
            selectionToolStripButton.Enabled = value;
            pointerToolStripButton.Enabled = value;
            printToolStripButton.Enabled = value;

            // Enable menu items

            SaveToolStripMenuItem.Enabled = value;
            ImageInfoToolStripMenuItem.Enabled = value;
            EditToolStripMenuItem.Enabled = value;
            ImageToolStripMenuItem.Enabled = value;
            AdjustToolStripMenuItem.Enabled = value;
            TransformsToolStripMenuItem.Enabled = value;
            PrintToolStripMenuItem.Enabled = value;
        }

        #endregion "Menu Routines"

        #region "File Menu"

        private void MenuItemNew_Click(System.Object sender, System.EventArgs e)
        {
            NewImage dialog = new NewImage();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bitmapViewerMainView.Bitmap = new Aurigma.GraphicsMill.Bitmap(dialog.ImageWidth, dialog.ImageHeight, dialog.PixelFormat, RgbColor.White);

                // Enable menu and toolbars

                SetMenuAndToolbar(true);

                // Show PixelFormat and support of Alpha channel in menu

                ShowPixelFormat();
            }
            dialog.Close();
        }

        private void MenuItemOpen_Click(System.Object sender, System.EventArgs e)
        {
            // openFileDialog.Filter = FormatManager.FilterStringForLoad;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (System.IO.Path.GetExtension(openFileDialog.FileName).ToLower() == ".psd")
                    {
                        using (Aurigma.GraphicsMill.Codecs.Psd.PsdReader reader = new Aurigma.GraphicsMill.Codecs.Psd.PsdReader(openFileDialog.FileName))
                        {
                            if (reader.MergedImageFrame != null)
                                bitmapViewerMainView.Bitmap = reader.MergedImageFrame.GetBitmap();
                            else
                                bitmapViewerMainView.Bitmap = reader.MergeLayers();
                        }
                    }
                    else
                        bitmapViewerMainView.Bitmap = new Aurigma.GraphicsMill.Bitmap(openFileDialog.FileName);
                }
                catch (System.Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Error arrised during loading following file:" + Environment.NewLine + openFileDialog.FileName);
                    return;
                }

                // Enable menu and toolbars

                SetMenuAndToolbar(true);

                UnpushToolBarButtons();
                bitmapViewerMainView.Navigator = null;
                bitmapViewerMainView.Rubberband = null;
                pointerToolStripButton.Checked = true;

                // Show PixelFormat and support of Alpha channel in menu

                ShowPixelFormat();

                CropToolStripMenuItem.Enabled = false;
            }
        }

        private void MenuItemSave_Click(System.Object sender, System.EventArgs e)
        {
            saveFileDialog.Filter = GetSaveFileDialogString();
            saveFileDialog.FileName = string.Empty;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    bitmapViewerMainView.Bitmap.Save(saveFileDialog.FileName);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Error arrised during saving following file:" + Environment.NewLine + openFileDialog.FileName);
                    return;
                }
            }
        }

        private void MenuItemImageInfo_Click(System.Object sender, System.EventArgs e)
        {
            ImageInfoDialog dialog = new ImageInfoDialog();
            dialog.Bitmap = bitmapViewerMainView.Bitmap;
            dialog.ShowDialog();
        }

        private void MenuItemExit_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void MenuItemPrint_Click(System.Object sender, System.EventArgs e)
        {
            PrintImageDialog printDialog = new PrintImageDialog(this.bitmapViewerMainView.Bitmap);
            printDialog.ShowDialog(this);
        }

        #endregion "File Menu"

        #region "Edit Menu"

        // Edit -> Undo

        private void MenuItemUndo_Click(System.Object sender, System.EventArgs e)
        {
            bitmapViewerMainView.Undo();
        }

        // Edit -> Redo

        private void MenuItemRedo_Click(System.Object sender, System.EventArgs e)
        {
            bitmapViewerMainView.Redo();
        }

        // Edit -> Cut

        private void MenuItemCut_Click(System.Object sender, System.EventArgs e)
        {
            // TODO: Cut isn't implemented

            // MessageBox.Show("This feature is not implemented in preliminary version.")
        }

        // Edit -> Copy

        private void MenuItemCopy_Click(System.Object sender, System.EventArgs e)
        {
            // TODO: Copy isn't implemented

            // MessageBox.Show("This feature is not implemented in preliminary version.")
        }

        // Edit -> Paste

        private void MenuItemPaste_Click(System.Object sender, System.EventArgs e)
        {
            // TODO: Paste isn't implemented

            // MessageBox.Show("This feature is not implemented in preliminary version.")
        }

        #endregion "Edit Menu"

        #region "Image -> Mode Menu"

        // Image -> Mode -> Bitmap

        // Convert image to 1 bpp image

        private void MenuItemBitmap_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            if (bitmapViewerMainView.Bitmap.PixelFormat != PixelFormat.Format1bppIndexed)
            {
                PixelFormatConverterPropertyPage propertyPage = new PixelFormatConverterPropertyPage();
                propertyPage.DestinationPixelFormat = PixelFormat.Format1bppIndexed;
                ApplyTransform(propertyPage);
                ShowPixelFormat();
            }
        }

        // Image -> Mode -> Grayscale

        // Convert image to grayscale

        private void MenuItemGrayscale_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            if (!bitmapViewerMainView.Bitmap.PixelFormat.IsGrayscale)
            {
                PixelFormat pf;
                if (bitmapViewerMainView.Bitmap.PixelFormat.IsExtended)
                {
                    if (bitmapViewerMainView.Bitmap.HasAlpha)
                    {
                        pf = PixelFormat.Format32bppAgrayscale;
                    }
                    else
                    {
                        pf = PixelFormat.Format16bppGrayscale;
                    }
                }
                else
                {
                    if (bitmapViewerMainView.Bitmap.HasAlpha)
                    {
                        pf = PixelFormat.Format16bppAgrayscale;
                    }
                    else
                    {
                        pf = PixelFormat.Format8bppGrayscale;
                    }
                }
                var converter = new Aurigma.GraphicsMill.Transforms.ColorConverter();
                converter.DestinationPixelFormat = pf;
                ApplyTransform(converter);
                ShowPixelFormat();
            }
        }

        // Image -> Mode -> Indexed

        // Convert image to indexed image

        private void MenuItemIndexed_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            if (bitmapViewerMainView.Bitmap.PixelFormat == PixelFormat.Format1bppIndexed)
            {
                Aurigma.GraphicsMill.Transforms.ColorConverter converter = new Aurigma.GraphicsMill.Transforms.ColorConverter();
                converter.DestinationPixelFormat = PixelFormat.Format8bppIndexed;
                converter.Palette = new ColorPalette(ColorPaletteType.Bicolor);
                converter.Dithering = DitheringType.None;
                ApplyTransform(converter);
                ShowPixelFormat();
            }
            else if ((bitmapViewerMainView.Bitmap.PixelFormat != PixelFormat.Format8bppIndexed) && (bitmapViewerMainView.Bitmap.PixelFormat != PixelFormat.Format4bppIndexed))
            {
                PixelFormatConverterPropertyPage propertyPage = new PixelFormatConverterPropertyPage();
                propertyPage.DestinationPixelFormat = PixelFormat.Format8bppIndexed;
                ApplyTransform(propertyPage);
                ShowPixelFormat();
            }
        }

        // Image -> Mode -> RGB

        // Convert image to RGB colorspace

        private void MenuRGB_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            if (!bitmapViewerMainView.Bitmap.PixelFormat.IsRgb)
            {
                PixelFormat pf;
                if (bitmapViewerMainView.Bitmap.PixelFormat.IsExtended)
                {
                    if (bitmapViewerMainView.Bitmap.HasAlpha)
                    {
                        pf = PixelFormat.Format64bppArgb;
                    }
                    else
                    {
                        pf = PixelFormat.Format48bppRgb;
                    }
                }
                else
                {
                    if (bitmapViewerMainView.Bitmap.HasAlpha)
                    {
                        pf = PixelFormat.Format32bppArgb;
                    }
                    else
                    {
                        pf = PixelFormat.Format24bppRgb;
                    }
                }
                Aurigma.GraphicsMill.Transforms.ColorConverter converter = new Aurigma.GraphicsMill.Transforms.ColorConverter();
                converter.DestinationPixelFormat = pf;
                ApplyTransform(converter);
                ShowPixelFormat();
            }
            else if (bitmapViewerMainView.Bitmap.PixelFormat.IsIndexed)
            {
                bitmapViewerMainView.Bitmap.ColorManagement.Convert(ColorSpace.Rgb, false, false);
                ShowPixelFormat();
            }
        }

        // Image -> Mode -> CMYK

        // Convert image to CMYK colorspace

        private void MenuItemCMYK_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            if (!bitmapViewerMainView.Bitmap.PixelFormat.IsCmyk)
            {
                PixelFormat pf;
                if (bitmapViewerMainView.Bitmap.PixelFormat.IsExtended)
                {
                    if (bitmapViewerMainView.Bitmap.HasAlpha)
                    {
                        pf = PixelFormat.Format80bppAcmyk;
                    }
                    else
                    {
                        pf = PixelFormat.Format64bppCmyk;
                    }
                }
                else
                {
                    if (bitmapViewerMainView.Bitmap.HasAlpha)
                    {
                        pf = PixelFormat.Format40bppAcmyk;
                    }
                    else
                    {
                        pf = PixelFormat.Format32bppCmyk;
                    }
                }
                Aurigma.GraphicsMill.Transforms.ColorConverter converter = new Aurigma.GraphicsMill.Transforms.ColorConverter();
                converter.DestinationPixelFormat = pf;
                ApplyTransform(converter);
                ShowPixelFormat();
            }
        }

        // Image -> Mode -> Alpha Channel

        // Add or remove alpha channel to image

        private void MenuItemAlphaChannel_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            if (!bitmapViewerMainView.Bitmap.HasAlpha)
            {
                if (bitmapViewerMainView.Bitmap.PixelFormat.IsIndexed)
                {
                    Aurigma.GraphicsMill.Transforms.ColorConverter converter = new Aurigma.GraphicsMill.Transforms.ColorConverter();
                    converter.DestinationPixelFormat = PixelFormat.Format32bppArgb;
                    ApplyTransform(converter);
                }
                else
                {
                    bitmapViewerMainView.Bitmap.Channels.SetAlpha(1);
                }
            }
            else
            {
                if (bitmapViewerMainView.Bitmap.PixelFormat.IsIndexed)
                {
                    Aurigma.GraphicsMill.Transforms.ColorConverter converter = new Aurigma.GraphicsMill.Transforms.ColorConverter();
                    converter.DestinationPixelFormat = PixelFormat.Format24bppRgb;
                    ApplyTransform(converter);
                }
                else
                {
                    bitmapViewerMainView.Bitmap.Channels.RemoveAlpha(new Aurigma.GraphicsMill.RgbColor(255, 255, 255));
                }
            }
            ShowPixelFormat();
        }

        // Image -> Mode -> 8 bit

        private void MenuItem8Bit_Click(System.Object sender, System.EventArgs eventArgs)
        {
            if (bitmapViewerMainView.Bitmap.PixelFormat.IsExtended)
            {
                bitmapViewerMainView.Bitmap.ColorManagement.Convert(bitmapViewerMainView.Bitmap.PixelFormat.ColorSpace, bitmapViewerMainView.Bitmap.HasAlpha, false);
                ShowPixelFormat();
            }
        }

        // Image -> Mode -> 16 bit

        private void MenuItem16bit_Click(System.Object sender, System.EventArgs eventArgs)
        {
            if (!bitmapViewerMainView.Bitmap.PixelFormat.IsExtended)
            {
                bitmapViewerMainView.Bitmap.ColorManagement.Convert(bitmapViewerMainView.Bitmap.PixelFormat.ColorSpace, bitmapViewerMainView.Bitmap.HasAlpha, true);
                ShowPixelFormat();
            }
        }

        #endregion "Image -> Mode Menu"

        #region "Image->Adjust Menu"

        // Brightness
        private void MenuItemBrightnessContrast_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            ApplyTransform(new BrightnessContrastPropertyPage());
        }

        // Auto Brightness
        private void MenuItemAutoBrightness_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            Brightness brightness = new Brightness();
            brightness.Auto = true;
            ApplyTransform(brightness);
        }

        // Auto Contrast
        private void MenuAutoContrast_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            Brightness contrast = new Brightness();
            contrast.Auto = true;
            ApplyTransform(contrast);
        }

        // Adjust HSL
        private void MenuAdjustHsl_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            ApplyTransform(new AdjustHslPropertyPage());
        }

        // Levels
        private void MenuLevels_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            ApplyTransform(new LevelsPropertyPage());
        }

        // Curves
        private void MenuItemCurves_Click(System.Object sender, System.EventArgs e)
        {
            ApplyTransform(new CurvesPropertyPage());
        }

        // Channel Balance

        private void MenuItemChannelBalance_Click(System.Object sender, System.EventArgs e)
        {
            ApplyTransform(new ChannelBalancePropertyPage());
        }

        // Auto Levels
        private void MenuAutoLevels_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            Levels levels = new Levels();
            levels.Auto = true;
            ApplyTransform(levels);
        }

        // Equalize
        private void MenuItemEqualize_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new HistogramEqualize());
        }

        #endregion "Image->Adjust Menu"

        #region "Image Menu"

        // Image -> Crop

        private void MenuItemCrop_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            if ((rectangleRubberbandExample.Rectangle.Width > 0) && (rectangleRubberbandExample.Rectangle.Height > 0))
            {
                Rectangle cropRectangle = rectangleRubberbandExample.Rectangle;

                rectangleRubberbandExample.Rectangle = new Rectangle(0, 0, rectangleRubberbandExample.Rectangle.Width, rectangleRubberbandExample.Rectangle.Height);

                ApplyTransform(new Crop(cropRectangle));
            }
        }

        // Image -> Resize

        private void MenuItemResize_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            ApplyTransform(new ResizePropertyPage());
        }

        // Image -> Rotate -> Rotate 90

        private void MenuItemRotate90_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            ApplyTransform(new Rotate(90));
        }

        // Image -> Rotate -> Rotate 180

        private void MenuItemRotate180_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            ApplyTransform(new Rotate(180));
        }

        // Image -> Rotate -> Rotate 270

        private void MenuItemRotate270_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            ApplyTransform(new Rotate(270));
        }

        // Image -> Rotate -> Arbitary...

        private void MenuItemRotateArbitary_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            ApplyTransform(new RotatePropertyPage());
        }

        // Image -> Flip -> Horizontal

        private void MenuItemFlipHorizontal_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            ApplyTransform(new Flip(FlipType.Horizontal));
        }

        // Image -> Flip -> Vertical

        private void MenuItemFlipVertical_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            ApplyTransform(new Flip(FlipType.Vertical));
        }

        // Image -> Histogram

        private void MenuItemHistogram_Click(System.Object sender, System.EventArgs eventArgs)
        {
            HistogramDialog MyHistogramDialog = new HistogramDialog();
            MyHistogramDialog.Bitmap = bitmapViewerMainView.Bitmap;
            MyHistogramDialog.ShowDialog();
            MyHistogramDialog.Close();
        }

        // Image -> Palette

        private void MenuItemPalette_Click(System.Object sender, System.EventArgs eventArgs)
        {
            PaletteDialog MyPaletteDialog = new PaletteDialog();
            MyPaletteDialog.BitmapConnector.Bitmap = bitmapViewerMainView.Bitmap;
            MyPaletteDialog.ShowDialog();
            MyPaletteDialog.Close();
        }

        #endregion "Image Menu"

        #region "Transforms Menu"

        // Transforms -> Add Noise...

        private void MenuItemAddNoise_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new AddNoisePropertyPage());
        }

        // Transforms -> Blur...

        private void MenuItemBlur_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new BlurPropertyPage());
        }

        // Transforms -> Edge Detect -> Glow

        private void MenuItemEdgeDetectGlow_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new EdgeDetect(EdgeDetectMode.Glow));
        }

        // Transforms -> Edge Detect -> Laplace HV

        private void MenuItemEdgeDetectLaplaceHV_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new EdgeDetect(EdgeDetectMode.LaplaceHV));
        }

        // Transforms -> Edge Detect -> Laplace Omni

        private void MenuItemEdgeDetectLaplaceOmni_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new EdgeDetect(EdgeDetectMode.LaplaceOmni));
        }

        // Transforms -> Edge Detect -> Pattern

        private void MenuItemEdgeDetectPattern_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new EdgeDetect(EdgeDetectMode.Pattern));
        }

        // Transforms -> Edge Detect -> Prewitt

        private void MenuItemEdgeDetectPrewitt_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new EdgeDetect(EdgeDetectMode.Prewitt));
        }

        // Transforms -> Edge Detect -> Sharp

        private void MenuItemEdgeDetectSharp_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new EdgeDetect(EdgeDetectMode.Sharp));
        }

        // Transforms -> Edge Detect -> Sharp More

        private void MenuItemEdgeDetectSharpMore_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new EdgeDetect(EdgeDetectMode.SharpMore));
        }

        // Transforms -> Edge Detect -> Trace Contour

        private void MenuItemEdgeDetectTraceContour_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new EdgeDetect(EdgeDetectMode.TraceContour));
        }

        // Transforms -> Emboss...

        private void MenuItemEmboss_Click(System.Object sender, System.EventArgs e)
        {
            ApplyTransform(new EmbossPropertyPage());
        }

        // Transforms -> Maximum Filter...

        private void MenuItemMaximumFilter_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new MaximumFilterPropertyPage());
        }

        // Transforms -> Median Filter...

        private void MenuItemMedianFilter_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new MedianFilterPropertyPage());
        }

        // Transforms -> Minimum Filter...

        private void MenuItemMinimumFilter_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new MinimumFilterPropertyPage());
        }

        // Transforms -> Mosaic...

        private void MenuItemMosaic_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new MosaicPropertyPage());
        }

        // Transforms -> Solarize

        private void MenuItemSolarize_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new Solarize());
        }

        // Transforms -> Spray...

        private void MenuItemSpray_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new SprayPropertyPage());
        }

        // Transforms -> Shadow...

        private void MenuItemShadow_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new ShadowPropertyPage());
        }

        // Transforms -> Sharpen...

        private void MenuItemSharpen_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new SharpenPropertyPage());
        }

        // Transforms -> Texturize...

        private void MenuItemTexturize_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new TexturizePropertyPage());
        }

        // Transforms -> Unsharp Mask...

        private void MenuItemUnsharpMask_Click(System.Object sender, System.EventArgs eventArgs)
        {
            ApplyTransform(new UnsharpMaskPropertyPage());
        }

        #endregion "Transforms Menu"

        #region "About Menu"

        // Help -> About...

        private void MenuItemAbout_Click(System.Object sender, System.EventArgs e)
        {
            AboutForm dialog = new AboutForm();
            dialog.ShowDialog();
        }

        #endregion "About Menu"

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private string GetSaveFileDialogString()
        {
            return
                    "JPEG (Joint Photographic Experts Group) (*.jpg;*.jpeg;*.jpe)|*.jpg;*.jpeg;*.jpe|" +
                    "BMP (Windows Bitmap) (*.bmp;*.dib)|*.bmp;*.dib|" +
                    "PNG (Portable Network Graphics) (*.png)|*.png|" +
                    "TIFF (Tagged Image File Format) (*.tif;*.tiff)|*.tif;*.tiff|" +
                    "GIF (Graphics Interchange Format) (*.gif)|*.gif|" +
                    "PDF (Portable Document Format) (*.pdf)|*.pdf";
        }
    }
}