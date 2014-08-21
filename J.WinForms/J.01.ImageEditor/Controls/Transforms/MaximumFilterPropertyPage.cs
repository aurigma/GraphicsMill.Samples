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
	public class MaximumFilterPropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public MaximumFilterPropertyPage()
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
		internal TrackBarText TrackBarTextRadius;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MaximumFilterPropertyPage));
			this.TrackBarTextRadius = new Main.TrackBarText();
			this.SuspendLayout();
			//
			//TrackBarTextRadius
			//
			this.TrackBarTextRadius.AccessibleDescription = resources.GetString("TrackBarTextRadius.AccessibleDescription");
			this.TrackBarTextRadius.AccessibleName = resources.GetString("TrackBarTextRadius.AccessibleName");
			this.TrackBarTextRadius.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextRadius.Anchor");
			this.TrackBarTextRadius.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextRadius.AutoScroll"));
			this.TrackBarTextRadius.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextRadius.AutoScrollMargin");
			this.TrackBarTextRadius.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextRadius.AutoScrollMinSize");
			this.TrackBarTextRadius.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextRadius.BackgroundImage");
			this.TrackBarTextRadius.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextRadius.Dock");
			this.TrackBarTextRadius.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextRadius.Enabled"));
			this.TrackBarTextRadius.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextRadius.Font");
			this.TrackBarTextRadius.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextRadius.ImeMode");
			this.TrackBarTextRadius.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextRadius.Location");
			this.TrackBarTextRadius.Maximum = 50;
			this.TrackBarTextRadius.Minimum = 1;
			this.TrackBarTextRadius.Name = "TrackBarTextRadius";
			this.TrackBarTextRadius.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextRadius.RightToLeft");
			this.TrackBarTextRadius.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextRadius.Size");
			this.TrackBarTextRadius.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextRadius.TabIndex"));
			this.TrackBarTextRadius.Text = resources.GetString("TrackBarTextRadius.Text");
			this.TrackBarTextRadius.TickFrequency = 5;
			this.TrackBarTextRadius.Unit = "pixels";
			this.TrackBarTextRadius.Value = 5;
			this.TrackBarTextRadius.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextRadius.Visible"));
			//
			//MaximumFilterPropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.TrackBarTextRadius);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "MaximumFilterPropertyPage";
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
				return new Maximum(TrackBarTextRadius.Value);
			}
		}
		
		public string Title
		{
			get
			{
				return "Maximum Filter";
			}
		}
	}
	
}
