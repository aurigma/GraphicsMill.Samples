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
	public class CylindrizePropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public CylindrizePropertyPage()
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
		internal TrackBarText TrackBarTextSlopeAngle;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CylindrizePropertyPage));
			this.TrackBarTextSlopeAngle = new Main.TrackBarText();
			this.SuspendLayout();
			//
			//TrackBarTextSlopeAngle
			//
			this.TrackBarTextSlopeAngle.AccessibleDescription = resources.GetString("TrackBarTextSlopeAngle.AccessibleDescription");
			this.TrackBarTextSlopeAngle.AccessibleName = resources.GetString("TrackBarTextSlopeAngle.AccessibleName");
			this.TrackBarTextSlopeAngle.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextSlopeAngle.Anchor");
			this.TrackBarTextSlopeAngle.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextSlopeAngle.AutoScroll"));
			this.TrackBarTextSlopeAngle.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextSlopeAngle.AutoScrollMargin");
			this.TrackBarTextSlopeAngle.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextSlopeAngle.AutoScrollMinSize");
			this.TrackBarTextSlopeAngle.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextSlopeAngle.BackgroundImage");
			this.TrackBarTextSlopeAngle.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextSlopeAngle.Dock");
			this.TrackBarTextSlopeAngle.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextSlopeAngle.Enabled"));
			this.TrackBarTextSlopeAngle.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextSlopeAngle.Font");
			this.TrackBarTextSlopeAngle.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextSlopeAngle.ImeMode");
			this.TrackBarTextSlopeAngle.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextSlopeAngle.Location");
			this.TrackBarTextSlopeAngle.Maximum = 80;
			this.TrackBarTextSlopeAngle.Minimum = 1;
			this.TrackBarTextSlopeAngle.Name = "TrackBarTextSlopeAngle";
			this.TrackBarTextSlopeAngle.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextSlopeAngle.RightToLeft");
			this.TrackBarTextSlopeAngle.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextSlopeAngle.Size");
			this.TrackBarTextSlopeAngle.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextSlopeAngle.TabIndex"));
			this.TrackBarTextSlopeAngle.Text = resources.GetString("TrackBarTextSlopeAngle.Text");
			this.TrackBarTextSlopeAngle.TickFrequency = 5;
			this.TrackBarTextSlopeAngle.Unit = "";
			this.TrackBarTextSlopeAngle.Value = 30;
			this.TrackBarTextSlopeAngle.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextSlopeAngle.Visible"));
			//
			//CylindrizePropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.TrackBarTextSlopeAngle);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "CylindrizePropertyPage";
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
                throw new Aurigma.GraphicsMill.UnexpectedException();
				//return new Cylindrize(TrackBarTextSlopeAngle.Value);
			}
		}
		
		public string Title
		{
			get
			{
				return "Cylindrize";
			}
		}
	}
	
}
