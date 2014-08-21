using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using Aurigma.GraphicsMill;


namespace Main
{
	public class PaletteDialog : System.Windows.Forms.Form
	{
		
		#region " Windows Form Designer generated code "
		
		public PaletteDialog()
		{
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Add any initialization after the InitializeComponent() call
			
		}
		
		//Form overrides dispose to clean up the component list.
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
		internal Main.PalettePanel paletteControlPalette;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PaletteDialog));
			this.paletteControlPalette = new Main.PalettePanel();
			this.SuspendLayout();
			//
			//paletteControlPalette
			//
			this.paletteControlPalette.AccessibleDescription = resources.GetString("paletteControlPalette.AccessibleDescription");
			this.paletteControlPalette.AccessibleName = resources.GetString("paletteControlPalette.AccessibleName");
			this.paletteControlPalette.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("paletteControlPalette.Anchor");
			this.paletteControlPalette.AutoScroll = System.Convert.ToBoolean(resources.GetObject("paletteControlPalette.AutoScroll"));
			this.paletteControlPalette.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("paletteControlPalette.AutoScrollMargin");
			this.paletteControlPalette.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("paletteControlPalette.AutoScrollMinSize");
			this.paletteControlPalette.BackgroundImage = (System.Drawing.Image) resources.GetObject("paletteControlPalette.BackgroundImage");
			this.paletteControlPalette.Bitmap = null;
			this.paletteControlPalette.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("paletteControlPalette.Dock");
			this.paletteControlPalette.Enabled = System.Convert.ToBoolean(resources.GetObject("paletteControlPalette.Enabled"));
			this.paletteControlPalette.Font = (System.Drawing.Font) resources.GetObject("paletteControlPalette.Font");
			this.paletteControlPalette.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("paletteControlPalette.ImeMode");
			this.paletteControlPalette.Location = (System.Drawing.Point) resources.GetObject("paletteControlPalette.Location");
			this.paletteControlPalette.Name = "paletteControlPalette";
			this.paletteControlPalette.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("paletteControlPalette.RightToLeft");
			this.paletteControlPalette.Size = (System.Drawing.Size) resources.GetObject("paletteControlPalette.Size");
			this.paletteControlPalette.TabIndex = System.Convert.ToInt32(resources.GetObject("paletteControlPalette.TabIndex"));
			this.paletteControlPalette.Visible = System.Convert.ToBoolean(resources.GetObject("paletteControlPalette.Visible"));
			//
			//PaletteDialog
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = (System.Drawing.Size) resources.GetObject("$this.AutoScaleBaseSize");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.ClientSize = (System.Drawing.Size) resources.GetObject("$this.ClientSize");
			this.Controls.Add(this.paletteControlPalette);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = (System.Drawing.Icon) resources.GetObject("$this.Icon");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.MaximumSize = (System.Drawing.Size) resources.GetObject("$this.MaximumSize");
			this.MinimumSize = (System.Drawing.Size) resources.GetObject("$this.MinimumSize");
			this.Name = "PaletteDialog";
			this.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("$this.RightToLeft");
			this.StartPosition = (System.Windows.Forms.FormStartPosition) resources.GetObject("$this.StartPosition");
			this.Text = resources.GetString("$this.Text");
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		public IBitmapPropertyPage BitmapConnector
		{
			get
			{
				return paletteControlPalette;
			}
		}
	}
	
}
