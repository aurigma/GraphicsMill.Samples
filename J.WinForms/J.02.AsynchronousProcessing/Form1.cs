using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousProcessing
{
	public partial class Form1 : Form
	{
		private Aurigma.GraphicsMill.Bitmap bitmap = null;

		Task<Aurigma.GraphicsMill.Bitmap> HueTask = null;
		private object lockObject = new Object();
		private bool needToUpdateHue = false;
	

		public Form1()
		{
			InitializeComponent();
		}


		private void buttonOpen_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				if (bitmap != null)
				{
					bitmap.Dispose();
				}

				bitmap = new Aurigma.GraphicsMill.Bitmap(openFileDialog1.FileName);

				if (bitmapViewer1.Bitmap != null)
				{
					var b = bitmapViewer1.Bitmap;
					b.Dispose();
				};

				bitmapViewer1.Bitmap = new Aurigma.GraphicsMill.Bitmap(bitmap);

				trackBarHue.Enabled = true;
			}
		}


		private void trackBarHue_Scroll(object sender, EventArgs e)
		{
			if (rbSynchronous.Checked)
			{
				HueSync();
			}
			else
			{
				HueAsync();
			}
		}


		private void HueSync()
		{
			float amount = (float)trackBarHue.Value / 100;

			var procBitmap = new Aurigma.GraphicsMill.Bitmap(bitmap);

			procBitmap.ColorAdjustment.AdjustHsl(amount, 0, 0);

			if (bitmapViewer1.Bitmap != null)
			{
				var b = bitmapViewer1.Bitmap;
				bitmapViewer1.Bitmap = null;
				b.Dispose();
			};

			bitmapViewer1.Bitmap = procBitmap;		
		}


		private void HueAsync()
		{
			if (bitmap == null)
			{
				return;
			}

			lock (lockObject)
			{
				//Don't create an additional task before the previous one is completed
				if (HueTask != null && !HueTask.IsCompleted)
				{
					needToUpdateHue = true;
					return;
				}
			}

			UpdateHueAsync();
		}


		private void UpdateHueAsync()
		{
			float amount = (float)trackBarHue.Value / 100;

			HueTask = Task.Factory.StartNew<Aurigma.GraphicsMill.Bitmap>(() =>
			{
				var procBitmap = new Aurigma.GraphicsMill.Bitmap(bitmap);

				procBitmap.ColorAdjustment.AdjustHsl(amount, 0, 0);

				return procBitmap;
			});

			HueTask.ContinueWith((result) =>
			{
				if (bitmapViewer1.Bitmap != null)
				{
					var b = bitmapViewer1.Bitmap;
					bitmapViewer1.Bitmap = result.Result;
					b.Dispose();
				}
				else
				{
					bitmapViewer1.Bitmap = result.Result;
				}

				//Check whether we need to run another task
				lock (lockObject)
				{
					if (!needToUpdateHue)
					{
						return;
					}

					needToUpdateHue = false;
				}

				UpdateHueAsync();
			}, TaskScheduler.FromCurrentSynchronizationContext());		
		}
	}
}
