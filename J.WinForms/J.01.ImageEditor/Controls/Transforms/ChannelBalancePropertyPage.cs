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
	public class ChannelBalancePropertyPage : System.Windows.Forms.UserControl, ITransformPropertyPage
	{
		
		
		#region " Windows Form Designer generated code "
		
		public ChannelBalancePropertyPage()
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
		internal TrackBarText TrackBarTextCyanRed;
		internal TrackBarText TrackBarTextMagentaGreen;
		internal TrackBarText TrackBarTextYellowBlue;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ChannelBalancePropertyPage));
			this.TrackBarTextMagentaGreen = new Main.TrackBarText();
			this.TrackBarTextCyanRed = new Main.TrackBarText();
			this.TrackBarTextYellowBlue = new Main.TrackBarText();
			this.SuspendLayout();
			//
			//TrackBarTextMagentaGreen
			//
			this.TrackBarTextMagentaGreen.AccessibleDescription = resources.GetString("TrackBarTextMagentaGreen.AccessibleDescription");
			this.TrackBarTextMagentaGreen.AccessibleName = resources.GetString("TrackBarTextMagentaGreen.AccessibleName");
			this.TrackBarTextMagentaGreen.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextMagentaGreen.Anchor");
			this.TrackBarTextMagentaGreen.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextMagentaGreen.AutoScroll"));
			this.TrackBarTextMagentaGreen.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextMagentaGreen.AutoScrollMargin");
			this.TrackBarTextMagentaGreen.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextMagentaGreen.AutoScrollMinSize");
			this.TrackBarTextMagentaGreen.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextMagentaGreen.BackgroundImage");
			this.TrackBarTextMagentaGreen.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextMagentaGreen.Dock");
			this.TrackBarTextMagentaGreen.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextMagentaGreen.Enabled"));
			this.TrackBarTextMagentaGreen.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextMagentaGreen.Font");
			this.TrackBarTextMagentaGreen.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextMagentaGreen.ImeMode");
			this.TrackBarTextMagentaGreen.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextMagentaGreen.Location");
			this.TrackBarTextMagentaGreen.Maximum = 100;
			this.TrackBarTextMagentaGreen.Minimum = - 100;
			this.TrackBarTextMagentaGreen.Name = "TrackBarTextMagentaGreen";
			this.TrackBarTextMagentaGreen.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextMagentaGreen.RightToLeft");
			this.TrackBarTextMagentaGreen.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextMagentaGreen.Size");
			this.TrackBarTextMagentaGreen.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextMagentaGreen.TabIndex"));
			this.TrackBarTextMagentaGreen.Text = resources.GetString("TrackBarTextMagentaGreen.Text");
			this.TrackBarTextMagentaGreen.TickFrequency = 10;
			this.TrackBarTextMagentaGreen.Unit = "";
			this.TrackBarTextMagentaGreen.Value = 0;
			this.TrackBarTextMagentaGreen.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextMagentaGreen.Visible"));
			//
			//TrackBarTextCyanRed
			//
			this.TrackBarTextCyanRed.AccessibleDescription = resources.GetString("TrackBarTextCyanRed.AccessibleDescription");
			this.TrackBarTextCyanRed.AccessibleName = resources.GetString("TrackBarTextCyanRed.AccessibleName");
			this.TrackBarTextCyanRed.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextCyanRed.Anchor");
			this.TrackBarTextCyanRed.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextCyanRed.AutoScroll"));
			this.TrackBarTextCyanRed.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextCyanRed.AutoScrollMargin");
			this.TrackBarTextCyanRed.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextCyanRed.AutoScrollMinSize");
			this.TrackBarTextCyanRed.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextCyanRed.BackgroundImage");
			this.TrackBarTextCyanRed.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextCyanRed.Dock");
			this.TrackBarTextCyanRed.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextCyanRed.Enabled"));
			this.TrackBarTextCyanRed.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextCyanRed.Font");
			this.TrackBarTextCyanRed.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextCyanRed.ImeMode");
			this.TrackBarTextCyanRed.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextCyanRed.Location");
			this.TrackBarTextCyanRed.Maximum = 100;
			this.TrackBarTextCyanRed.Minimum = - 100;
			this.TrackBarTextCyanRed.Name = "TrackBarTextCyanRed";
			this.TrackBarTextCyanRed.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextCyanRed.RightToLeft");
			this.TrackBarTextCyanRed.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextCyanRed.Size");
			this.TrackBarTextCyanRed.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextCyanRed.TabIndex"));
			this.TrackBarTextCyanRed.Text = resources.GetString("TrackBarTextCyanRed.Text");
			this.TrackBarTextCyanRed.TickFrequency = 10;
			this.TrackBarTextCyanRed.Unit = "";
			this.TrackBarTextCyanRed.Value = 0;
			this.TrackBarTextCyanRed.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextCyanRed.Visible"));
			//
			//TrackBarTextYellowBlue
			//
			this.TrackBarTextYellowBlue.AccessibleDescription = resources.GetString("TrackBarTextYellowBlue.AccessibleDescription");
			this.TrackBarTextYellowBlue.AccessibleName = resources.GetString("TrackBarTextYellowBlue.AccessibleName");
			this.TrackBarTextYellowBlue.Anchor = (System.Windows.Forms.AnchorStyles) resources.GetObject("TrackBarTextYellowBlue.Anchor");
			this.TrackBarTextYellowBlue.AutoScroll = System.Convert.ToBoolean(resources.GetObject("TrackBarTextYellowBlue.AutoScroll"));
			this.TrackBarTextYellowBlue.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("TrackBarTextYellowBlue.AutoScrollMargin");
			this.TrackBarTextYellowBlue.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("TrackBarTextYellowBlue.AutoScrollMinSize");
			this.TrackBarTextYellowBlue.BackgroundImage = (System.Drawing.Image) resources.GetObject("TrackBarTextYellowBlue.BackgroundImage");
			this.TrackBarTextYellowBlue.Dock = (System.Windows.Forms.DockStyle) resources.GetObject("TrackBarTextYellowBlue.Dock");
			this.TrackBarTextYellowBlue.Enabled = System.Convert.ToBoolean(resources.GetObject("TrackBarTextYellowBlue.Enabled"));
			this.TrackBarTextYellowBlue.Font = (System.Drawing.Font) resources.GetObject("TrackBarTextYellowBlue.Font");
			this.TrackBarTextYellowBlue.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("TrackBarTextYellowBlue.ImeMode");
			this.TrackBarTextYellowBlue.Location = (System.Drawing.Point) resources.GetObject("TrackBarTextYellowBlue.Location");
			this.TrackBarTextYellowBlue.Maximum = 100;
			this.TrackBarTextYellowBlue.Minimum = - 100;
			this.TrackBarTextYellowBlue.Name = "TrackBarTextYellowBlue";
			this.TrackBarTextYellowBlue.RightToLeft = (System.Windows.Forms.RightToLeft) resources.GetObject("TrackBarTextYellowBlue.RightToLeft");
			this.TrackBarTextYellowBlue.Size = (System.Drawing.Size) resources.GetObject("TrackBarTextYellowBlue.Size");
			this.TrackBarTextYellowBlue.TabIndex = System.Convert.ToInt32(resources.GetObject("TrackBarTextYellowBlue.TabIndex"));
			this.TrackBarTextYellowBlue.Text = resources.GetString("TrackBarTextYellowBlue.Text");
			this.TrackBarTextYellowBlue.TickFrequency = 10;
			this.TrackBarTextYellowBlue.Unit = "";
			this.TrackBarTextYellowBlue.Value = 0;
			this.TrackBarTextYellowBlue.Visible = System.Convert.ToBoolean(resources.GetObject("TrackBarTextYellowBlue.Visible"));
			//
			//ChannelBalancePropertyPage
			//
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = System.Convert.ToBoolean(resources.GetObject("$this.AutoScroll"));
			this.AutoScrollMargin = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMargin");
			this.AutoScrollMinSize = (System.Drawing.Size) resources.GetObject("$this.AutoScrollMinSize");
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("$this.BackgroundImage");
			this.Controls.Add(this.TrackBarTextYellowBlue);
			this.Controls.Add(this.TrackBarTextMagentaGreen);
			this.Controls.Add(this.TrackBarTextCyanRed);
			this.Enabled = System.Convert.ToBoolean(resources.GetObject("$this.Enabled"));
			this.Font = (System.Drawing.Font) resources.GetObject("$this.Font");
			this.ImeMode = (System.Windows.Forms.ImeMode) resources.GetObject("$this.ImeMode");
			this.Location = (System.Drawing.Point) resources.GetObject("$this.Location");
			this.Name = "ChannelBalancePropertyPage";
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
				if (_bitmap.PixelFormat.IsRgb)
				{
					float[] levels = new float[3];
					levels[0] = Convert.ToSingle(TrackBarTextYellowBlue.Value) / 100.0F;
					levels[1] = Convert.ToSingle(TrackBarTextMagentaGreen.Value) / 100.0F;
					levels[2] = Convert.ToSingle(TrackBarTextCyanRed.Value) / 100.0F;
					return new ChannelBalance(){ Addends = levels };
				}
				else if (_bitmap.PixelFormat.IsCmyk)
				{
					float[] levels = new float[4];
					levels[0] = 0;
					levels[1] = Convert.ToSingle(- TrackBarTextYellowBlue.Value) / 100.0F;
					levels[2] = Convert.ToSingle(- TrackBarTextMagentaGreen.Value) / 100.0F;
					levels[3] = Convert.ToSingle(- TrackBarTextCyanRed.Value) / 100.0F;
                    return new ChannelBalance() { Addends = levels };
				}
				else
				{
					throw (new Aurigma.GraphicsMill.UnsupportedPixelFormatException());
				}
			}
		}
		
		public string Title
		{
			get
			{
				return "Channel Balance";
			}
		}
	}
	
}
