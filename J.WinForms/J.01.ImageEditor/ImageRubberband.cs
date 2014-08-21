using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;


namespace Main
{
	public class ImageRubberband : Aurigma.GraphicsMill.WinControls.RectangleRubberband
	{
		
		
		private Aurigma.GraphicsMill.Bitmap _image;
		
		public ImageRubberband(Aurigma.GraphicsMill.Bitmap image)
		{
			if (image == null)
			{
				throw (new ArgumentNullException("image"));
			}
			
			_image = image;
			this.GripSize = 8;
			this.MaskStyle = Aurigma.GraphicsMill.WinControls.MaskStyle.None;
			this.ResizeMode = Aurigma.GraphicsMill.WinControls.ResizeMode.Proportional;
			this.Ratio = System.Convert.ToDouble(_image.Width) / System.Convert.ToDouble(_image.Height);
			this.Erasable = false;
		}
		
		protected override void OnViewerDoubleBufferPaint(System.Windows.Forms.PaintEventArgs e)
		{
			if (! this.IsEmpty)
			{
                _image.DrawOn(e.Graphics, this.Viewer.WorkspaceToControl((RectangleF)this.Rectangle, Aurigma.GraphicsMill.Unit.Pixel), Aurigma.GraphicsMill.Transforms.CombineMode.Copy, 1.0F, Aurigma.GraphicsMill.Transforms.ResizeInterpolationMode.Medium);
			}
			
			base.OnViewerDoubleBufferPaint(e);
		}
		
	}
	
}
