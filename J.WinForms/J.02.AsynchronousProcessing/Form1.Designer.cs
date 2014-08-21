namespace AsynchronousProcessing
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.bitmapViewer1 = new Aurigma.GraphicsMill.WinControls.BitmapViewer();
			this.rbAsynchronous = new System.Windows.Forms.RadioButton();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.rbSynchronous = new System.Windows.Forms.RadioButton();
			this.trackBarHue = new System.Windows.Forms.TrackBar();
			this.labelHue = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
			this.SuspendLayout();
			// 
			// bitmapViewer1
			// 
			this.bitmapViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bitmapViewer1.BackColor = System.Drawing.Color.White;
			this.bitmapViewer1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
			this.bitmapViewer1.Location = new System.Drawing.Point(12, 60);
			this.bitmapViewer1.Name = "bitmapViewer1";
			this.bitmapViewer1.ScrollingPosition = new System.Drawing.Point(0, 0);
			this.bitmapViewer1.Size = new System.Drawing.Size(629, 370);
			this.bitmapViewer1.TabIndex = 0;
			this.bitmapViewer1.UndoRedoMaxStepCount = 4;
			this.bitmapViewer1.ZoomMode = Aurigma.GraphicsMill.WinControls.ZoomMode.BestFit;
			// 
			// rbAsynchronous
			// 
			this.rbAsynchronous.AutoSize = true;
			this.rbAsynchronous.Checked = true;
			this.rbAsynchronous.Location = new System.Drawing.Point(144, 20);
			this.rbAsynchronous.Name = "rbAsynchronous";
			this.rbAsynchronous.Size = new System.Drawing.Size(92, 17);
			this.rbAsynchronous.TabIndex = 1;
			this.rbAsynchronous.TabStop = true;
			this.rbAsynchronous.Text = "Asynchronous";
			this.rbAsynchronous.UseVisualStyleBackColor = true;
			// 
			// buttonOpen
			// 
			this.buttonOpen.Location = new System.Drawing.Point(13, 17);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(108, 23);
			this.buttonOpen.TabIndex = 2;
			this.buttonOpen.Text = "Open";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// rbSynchronous
			// 
			this.rbSynchronous.AutoSize = true;
			this.rbSynchronous.Location = new System.Drawing.Point(254, 20);
			this.rbSynchronous.Name = "rbSynchronous";
			this.rbSynchronous.Size = new System.Drawing.Size(87, 17);
			this.rbSynchronous.TabIndex = 3;
			this.rbSynchronous.Text = "Synchronous";
			this.rbSynchronous.UseVisualStyleBackColor = true;
			// 
			// trackBarHue
			// 
			this.trackBarHue.Location = new System.Drawing.Point(425, 9);
			this.trackBarHue.Maximum = 100;
			this.trackBarHue.Minimum = -100;
			this.trackBarHue.Name = "trackBarHue";
			this.trackBarHue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.trackBarHue.Size = new System.Drawing.Size(216, 45);
			this.trackBarHue.TabIndex = 4;
			this.trackBarHue.TickFrequency = 10;
			this.trackBarHue.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarHue.Scroll += new System.EventHandler(this.trackBarHue_Scroll);
			// 
			// labelHue
			// 
			this.labelHue.AutoSize = true;
			this.labelHue.Location = new System.Drawing.Point(364, 22);
			this.labelHue.Name = "labelHue";
			this.labelHue.Size = new System.Drawing.Size(56, 13);
			this.labelHue.TabIndex = 5;
			this.labelHue.Text = "Hue";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 442);
			this.Controls.Add(this.labelHue);
			this.Controls.Add(this.trackBarHue);
			this.Controls.Add(this.rbSynchronous);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.rbAsynchronous);
			this.Controls.Add(this.bitmapViewer1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Aurigma.GraphicsMill.WinControls.BitmapViewer bitmapViewer1;
		private System.Windows.Forms.RadioButton rbAsynchronous;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.RadioButton rbSynchronous;
		private System.Windows.Forms.TrackBar trackBarHue;
		private System.Windows.Forms.Label labelHue;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;

	}
}

