using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Transforms;


namespace Main
{
	public class RotatePropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public RotatePropertyPage()
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
		internal AngleText AngleText1;
		internal System.Windows.Forms.Label Label1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(RotatePropertyPage));
			this.AngleText1 = new Main.AngleText();
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//AngleText1
			//
			this.AngleText1.AccessibleDescription = resources.GetString("AngleText1.AccessibleDescription");
			this.AngleText1.AccessibleName = resources.GetString("AngleText1.AccessibleName");
			this.AngleText1.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("AngleText1.Anchor");
			this.AngleText1.AutoScroll = System.Convert.ToBoolean(resources.GetObject("AngleText1.AutoScroll"));
			this.AngleText1.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("AngleText1.AutoScrollMargin");
			this.AngleText1.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("AngleText1.AutoScrollMinSize");
			this.AngleText1.BackgroundImage = (System.Drawing.Image) resources.GetObject("AngleText1.BackgroundImage");
			this.AngleText1.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("AngleText1.Dock");
			this.AngleText1.Enabled = System.Convert.ToBoolean(resources.GetObject("AngleText1.Enabled"));
			this.AngleText1.Font = (System.Drawing.Font) resources.GetObject("AngleText1.Font");
			this.AngleText1.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("AngleText1.ImeMode");
			this.AngleText1.Location = (System.Drawing.Point) resources.GetObject("AngleText1.Location");
			this.AngleText1.Name = "AngleText1";
			this.AngleText1.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("AngleText1.RightToLeft");
			this.AngleText1.Size = (System.Drawing.Size) resources.GetObject("AngleText1.Size");
			this.AngleText1.TabIndex = System.Convert.ToInt32(resources.GetObject("AngleText1.TabIndex"));
			this.AngleText1.Value = 0;
			this.AngleText1.Visible = System.Convert.ToBoolean(resources.GetObject("AngleText1.Visible"));
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
			//RotatePropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.AngleText1);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "RotatePropertyPage";
			this.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("$this.RightToLeft");
			this.Size = (System.Drawing.Size) resources.GetObject("$this.Size");
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private Aurigma.GraphicsMill.Bitmap _bitmap;
		
		public Aurigma.GraphicsMill.Bitmap Bitmap
		{
			get
			{
				return _bitmap;
			}
			set
			{
				_bitmap = value;
			}
		}
		
		public IBitmapTransform Transform
		{
			get
			{
				return new Rotate(AngleText1.Value);
			}
		}
		
		public string Title
		{
			get
			{
				return "Rotate";
			}
		}
	}
	
}
