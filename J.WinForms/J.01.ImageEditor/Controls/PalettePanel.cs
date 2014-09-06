using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.WinControls;


namespace Main
{
	public class PalettePanel : System.Windows.Forms.UserControl, IBitmapPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public PalettePanel()
		{
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Add any initialization after the InitializeComponent() call
			
		}
		
		//UserControl overrides dispose to clean up the component list.
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
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		public System.Windows.Forms.PictureBox Picture2;
		public System.Windows.Forms.TextBox TextColor;
		public System.Windows.Forms.PictureBox Picture1;
		public System.Windows.Forms.Label Label1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PalettePanel));
			this.Picture2 = new System.Windows.Forms.PictureBox();
			this.Picture2.Paint += new System.Windows.Forms.PaintEventHandler(Picture2_Paint);
			this.TextColor = new System.Windows.Forms.TextBox();
			this.Picture1 = new System.Windows.Forms.PictureBox();
			this.Picture1.MouseMove += new System.Windows.Forms.MouseEventHandler(Picture1_MouseMove);
			this.Picture1.Paint += new System.Windows.Forms.PaintEventHandler(Picture1_Paint);
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Picture2
			//
			this.Picture2.AccessibleDescription = resources.GetString("Picture2.AccessibleDescription");
			this.Picture2.AccessibleName = resources.GetString("Picture2.AccessibleName");
			this.Picture2.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("Picture2.Anchor");
			this.Picture2.BackgroundImage = (System.Drawing.Image) resources.GetObject("Picture2.BackgroundImage");
			this.Picture2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Picture2.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("Picture2.Dock");
			this.Picture2.Enabled = System.Convert.ToBoolean(resources.GetObject("Picture2.Enabled"));
			this.Picture2.Font = (System.Drawing.Font) resources.GetObject("Picture2.Font");
			this.Picture2.Image = (System.Drawing.Image) resources.GetObject("Picture2.Image");
			this.Picture2.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("Picture2.ImeMode");
			this.Picture2.Location = (System.Drawing.Point) resources.GetObject("Picture2.Location");
			this.Picture2.Name = "Picture2";
			this.Picture2.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("Picture2.RightToLeft");
			this.Picture2.Size = (System.Drawing.Size) resources.GetObject("Picture2.Size");
			this.Picture2.SizeMode = (System.Windows.Forms.PictureBoxSizeMode) resources.GetObject("Picture2.SizeMode");
			this.Picture2.TabIndex = System.Convert.ToInt32(resources.GetObject("Picture2.TabIndex"));
			this.Picture2.TabStop = false;
			this.Picture2.Text = resources.GetString("Picture2.Text");
			this.Picture2.Visible = System.Convert.ToBoolean(resources.GetObject("Picture2.Visible"));
			//
			//TextColor
			//
			this.TextColor.AcceptsReturn = true;
			this.TextColor.AccessibleDescription = resources.GetString("TextColor.AccessibleDescription");
			this.TextColor.AccessibleName = resources.GetString("TextColor.AccessibleName");
			this.TextColor.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TextColor.Anchor");
			this.TextColor.AutoSize = System.Convert.ToBoolean(resources.GetObject("TextColor.AutoSize"));
			this.TextColor.BackgroundImage = (System.Drawing.Image) resources.GetObject("TextColor.BackgroundImage");
			this.TextColor.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TextColor.Dock");
			this.TextColor.Enabled = System.Convert.ToBoolean(resources.GetObject("TextColor.Enabled"));
			this.TextColor.Font = (System.Drawing.Font) resources.GetObject("TextColor.Font");
			this.TextColor.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TextColor.ImeMode");
			this.TextColor.Location = (System.Drawing.Point) resources.GetObject("TextColor.Location");
			this.TextColor.MaxLength = System.Convert.ToInt32(resources.GetObject("TextColor.MaxLength"));
			this.TextColor.Multiline = System.Convert.ToBoolean(resources.GetObject("TextColor.Multiline"));
			this.TextColor.Name = "TextColor";
			this.TextColor.PasswordChar = System.Convert.ToChar(resources.GetObject("TextColor.PasswordChar"));
			this.TextColor.ReadOnly = true;
			this.TextColor.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TextColor.RightToLeft");
			this.TextColor.ScrollBars = (System.Windows.Forms.ScrollBars) resources.GetObject("TextColor.ScrollBars");
			this.TextColor.Size = (System.Drawing.Size) resources.GetObject("TextColor.Size");
			this.TextColor.TabIndex = System.Convert.ToInt32(resources.GetObject("TextColor.TabIndex"));
			this.TextColor.Text = resources.GetString("TextColor.Text");
			this.TextColor.TextAlign = (System.Windows.Forms.HorizontalAlignment) resources.GetObject("TextColor.TextAlign");
			this.TextColor.Visible = System.Convert.ToBoolean(resources.GetObject("TextColor.Visible"));
			this.TextColor.WordWrap = System.Convert.ToBoolean(resources.GetObject("TextColor.WordWrap"));
			//
			//Picture1
			//
			this.Picture1.AccessibleDescription = resources.GetString("Picture1.AccessibleDescription");
			this.Picture1.AccessibleName = resources.GetString("Picture1.AccessibleName");
			this.Picture1.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("Picture1.Anchor");
			this.Picture1.BackgroundImage = (System.Drawing.Image) resources.GetObject("Picture1.BackgroundImage");
			this.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Picture1.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("Picture1.Dock");
			this.Picture1.Enabled = System.Convert.ToBoolean(resources.GetObject("Picture1.Enabled"));
			this.Picture1.Font = (System.Drawing.Font) resources.GetObject("Picture1.Font");
			this.Picture1.Image = (System.Drawing.Image) resources.GetObject("Picture1.Image");
			this.Picture1.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("Picture1.ImeMode");
			this.Picture1.Location = (System.Drawing.Point) resources.GetObject("Picture1.Location");
			this.Picture1.Name = "Picture1";
			this.Picture1.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("Picture1.RightToLeft");
			this.Picture1.Size = (System.Drawing.Size) resources.GetObject("Picture1.Size");
			this.Picture1.SizeMode = (System.Windows.Forms.PictureBoxSizeMode) resources.GetObject("Picture1.SizeMode");
			this.Picture1.TabIndex = System.Convert.ToInt32(resources.GetObject("Picture1.TabIndex"));
			this.Picture1.TabStop = false;
			this.Picture1.Text = resources.GetString("Picture1.Text");
			this.Picture1.Visible = System.Convert.ToBoolean(resources.GetObject("Picture1.Visible"));
			//
			//Label1
			//
			this.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription");
			this.Label1.AccessibleName = resources.GetString("Label1.AccessibleName");
			this.Label1.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("Label1.Anchor");
			this.Label1.AutoSize = System.Convert.ToBoolean(resources.GetObject("Label1.AutoSize"));
			this.Label1.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("Label1.Dock");
			this.Label1.Enabled = System.Convert.ToBoolean(resources.GetObject("Label1.Enabled"));
			this.Label1.Font = (System.Drawing.Font) resources.GetObject("Label1.Font");
			this.Label1.Image = (System.Drawing.Image) resources.GetObject("Label1.Image");
			this.Label1.ImageAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label1.ImageAlign");
			this.Label1.ImageIndex = System.Convert.ToInt32(resources.GetObject("Label1.ImageIndex"));
			this.Label1.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("Label1.ImeMode");
			this.Label1.Location = (System.Drawing.Point) resources.GetObject("Label1.Location");
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("Label1.RightToLeft");
			this.Label1.Size = (System.Drawing.Size) resources.GetObject("Label1.Size");
			this.Label1.TabIndex = System.Convert.ToInt32(resources.GetObject("Label1.TabIndex"));
			this.Label1.Text = resources.GetString("Label1.Text");
			this.Label1.TextAlign = (System.Drawing.ContentAlignment) resources.GetObject("Label1.TextAlign");
			this.Label1.Visible = System.Convert.ToBoolean(resources.GetObject("Label1.Visible"));
			//
			//PalettePanel
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.Picture2);
			this.Controls.Add(this.TextColor);
			this.Controls.Add(this.Picture1);
			this.Controls.Add(this.Label1);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "PalettePanel";
			this.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("$this.RightToLeft");
			this.Size = (System.Drawing.Size) resources.GetObject("$this.Size");
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private Aurigma.GraphicsMill.Bitmap _bitmap;
		private int currentPalleteIndex = - 1;
		
		public Aurigma.GraphicsMill.Bitmap Bitmap
		{
			get
			{
				return _bitmap;
			}
			set
			{
				_bitmap = value;
				currentPalleteIndex = - 1;
				TextColor.Text = string.Empty;
				Picture1.Refresh();
				Picture2.Refresh();
				
				if (_bitmap != null)
				{
					//_bitmap.Changed += new Aurigma.GraphicsMill.BitmapChangedEventHandler(_bitmap_Changed);
				}
			}
		}
		
		public string Title
		{
			get
			{
				return "Color Palette";
			}
		}
		
// 		private void _bitmap_Changed(System.Object eventSender, BitmapChangedEventArgs eventArgs)
// 		{
// 			Picture1.Refresh();
// 		}
		
		// Show item color
		// Handle also mouse out event here.
		private void Picture1_MouseMove(System.Object eventSender, System.Windows.Forms.MouseEventArgs eventArgs)
		{
			int x = eventArgs.X;
			int y = eventArgs.Y;
			bool mouseOver;
			//Ensure whether Bitmap is not empty
			if (_bitmap != null&& ! _bitmap.IsEmpty)
			{
				//See if the mouse is over
				mouseOver = (0 <= x) &&(x <= Picture1.Width) &&(0 <= y) &&(y <= Picture1.Height);
				
				currentPalleteIndex = (y / 17) * 16 + x / 17;
				
				if (mouseOver &&(currentPalleteIndex < _bitmap.Palette.Count))
				{
					//TextColor.Text = "#" & Hex(_bitmap.Palette(currentPalleteIndex).ToInt32)
					
					TextColor.Text = "#" + _bitmap.Palette[currentPalleteIndex].ToInt32().ToString("X");
					
					Picture2.Refresh();
					NativeMethods.SetCapture(Picture1.Handle.ToInt32());
				}
				else
				{
					//Show rect with cross lines
					currentPalleteIndex = - 1;
					Picture2.Refresh();
					TextColor.Text = string.Empty;
					NativeMethods.ReleaseCapture();
					return;
				}
			}
		}
		
		private void Picture1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			int i;
			
			//Draw background
			System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, 221, 221, 221));
			e.Graphics.FillRectangle(brush, 0, 0, 273, 273);
			
			//Draw grid
			System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(255, 102, 102, 102));
			for (i = 16; i <= 264; i += 17)
			{
				e.Graphics.DrawLine(pen, 0, i, 271, i);
				e.Graphics.DrawLine(pen, i, 0, i, 271);
			}
			
			int row;
			int column;
			int palleteIndex;
			int missingEntryIndex = 0;
			
			//Ensure whether Bitmap is not empty
			if (!(_bitmap == null))
			{
				if ((! _bitmap.IsEmpty) &&(_bitmap.Palette != null))
				{
					//Show Pallete
					for (palleteIndex = 0; palleteIndex <= _bitmap.Palette.Count - 1; palleteIndex++)
					{
						column = palleteIndex % 16;
						row = palleteIndex / 16;
						System.Drawing.SolidBrush b = new System.Drawing.SolidBrush(_bitmap.Palette[palleteIndex].ToGdiPlusColor());
						e.Graphics.FillRectangle(b, column * 17, row * 17, 16, 16);
					}
					missingEntryIndex = _bitmap.Palette.Count;
				}
			}
			
			//Show missing palette entries
			for (palleteIndex = missingEntryIndex; palleteIndex <= 255; palleteIndex++)
			{
				column = palleteIndex % 16;
				row = palleteIndex / 16;
				e.Graphics.DrawLine(pen, column * 17, row * 17, column * 17 + 16, row * 17 + 16);
				e.Graphics.DrawLine(pen, column * 17 + 16, row * 17, column * 17, row * 17 + 16);
			}
		}
		
		private void Picture2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if (currentPalleteIndex != - 1)
			{
				if ((! _bitmap.IsEmpty) &&(_bitmap.Palette != null))
				{
					System.Drawing.SolidBrush b = new System.Drawing.SolidBrush(_bitmap.Palette[currentPalleteIndex].ToGdiPlusColor());
					e.Graphics.FillRectangle(b, 0, 0, 19, 19);
				}
			}
			else
			{
				System.Drawing.SolidBrush b = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, 221, 221, 221));
				e.Graphics.FillRectangle(b, 0, 0, 19, 19);
				
				System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(255, 102, 102, 102));
				e.Graphics.DrawLine(pen, 0, 0, 16, 16);
				e.Graphics.DrawLine(pen, 16, 0, 0, 16);
			}
		}
	}
}
