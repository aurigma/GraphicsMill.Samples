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
	public class EmbossPropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public EmbossPropertyPage()
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
		internal System.Windows.Forms.Label Label1;
		internal AngleText AngleText1;
		internal TrackBarText TrackBarTextAmount;
		internal TrackBarText TrackBarTextHeight;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EmbossPropertyPage));
			this.Label1 = new System.Windows.Forms.Label();
			this.AngleText1 = new Main.AngleText();
			this.TrackBarTextAmount = new Main.TrackBarText();
			this.TrackBarTextHeight = new Main.TrackBarText();
			this.SuspendLayout();
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
			this.AngleText1.Value = 45;
			this.AngleText1.Visible = System.Convert.ToBoolean(resources.GetObject("AngleText1.Visible"));
			//
			//TrackBarTextAmount
			//
			this.TrackBarTextAmount.AccessibleDescription = resources.GetString("TrackBarTextAmount.AccessibleDescription");
			this.TrackBarTextAmount.AccessibleName = resources.GetString("TrackBarTextAmount.AccessibleName");
			this.TrackBarTextAmount.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextAmount.Anchor");
			this.TrackBarTextAmount.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextAmount.AutoScroll"));
			this.TrackBarTextAmount.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextAmount.AutoScrollMargin");
			this.TrackBarTextAmount.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextAmount.AutoScrollMinSize");
			this.TrackBarTextAmount.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextAmount.BackgroundImage");
			this.TrackBarTextAmount.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextAmount.Dock");
			this.TrackBarTextAmount.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextAmount.Enabled"));
			this.TrackBarTextAmount.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextAmount.Font");
			this.TrackBarTextAmount.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextAmount.ImeMode");
			this.TrackBarTextAmount.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextAmount.Location");
			this.TrackBarTextAmount.Maximum = 100;
			this.TrackBarTextAmount.Minimum = 1;
			this.TrackBarTextAmount.Name = "TrackBarTextAmount";
			this.TrackBarTextAmount.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextAmount.RightToLeft");
			this.TrackBarTextAmount.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextAmount.Size");
			this.TrackBarTextAmount.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextAmount.TabIndex"));
			this.TrackBarTextAmount.Text = resources.GetString("TrackBarTextAmount.Text");
			this.TrackBarTextAmount.TickFrequency = 5;
			this.TrackBarTextAmount.Unit = "%";
			this.TrackBarTextAmount.Value = 100;
			this.TrackBarTextAmount.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextAmount.Visible"));
			//
			//TrackBarTextHeight
			//
			this.TrackBarTextHeight.AccessibleDescription = resources.GetString("TrackBarTextHeight.AccessibleDescription");
			this.TrackBarTextHeight.AccessibleName = resources.GetString("TrackBarTextHeight.AccessibleName");
			this.TrackBarTextHeight.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextHeight.Anchor");
			this.TrackBarTextHeight.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextHeight.AutoScroll"));
			this.TrackBarTextHeight.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextHeight.AutoScrollMargin");
			this.TrackBarTextHeight.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextHeight.AutoScrollMinSize");
			this.TrackBarTextHeight.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextHeight.BackgroundImage");
			this.TrackBarTextHeight.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextHeight.Dock");
			this.TrackBarTextHeight.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextHeight.Enabled"));
			this.TrackBarTextHeight.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextHeight.Font");
			this.TrackBarTextHeight.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextHeight.ImeMode");
			this.TrackBarTextHeight.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextHeight.Location");
			this.TrackBarTextHeight.Maximum = 100;
			this.TrackBarTextHeight.Minimum = 1;
			this.TrackBarTextHeight.Name = "TrackBarTextHeight";
			this.TrackBarTextHeight.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextHeight.RightToLeft");
			this.TrackBarTextHeight.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextHeight.Size");
			this.TrackBarTextHeight.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextHeight.TabIndex"));
			this.TrackBarTextHeight.Text = resources.GetString("TrackBarTextHeight.Text");
			this.TrackBarTextHeight.TickFrequency = 5;
			this.TrackBarTextHeight.Unit = "pixels";
			this.TrackBarTextHeight.Value = 3;
			this.TrackBarTextHeight.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextHeight.Visible"));
			//
			//EmbossPropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.AngleText1);
			this.Controls.Add(this.TrackBarTextAmount);
			this.Controls.Add(this.TrackBarTextHeight);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "EmbossPropertyPage";
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
				return new Emboss(AngleText1.Value, TrackBarTextHeight.Value, TrackBarTextAmount.Value);
			}
		}
		
		public string Title
		{
			get
			{
				return "Emboss";
			}
		}
	}
	
}
