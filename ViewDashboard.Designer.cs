namespace WinformNPGSQL
{
	partial class ViewDashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDashboard));
			pictureBox1 = new PictureBox();
			flowLayoutPanel1 = new FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			resources.ApplyResources(pictureBox1, "pictureBox1");
			pictureBox1.Name = "pictureBox1";
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BackColor = SystemColors.Highlight;
			flowLayoutPanel1.Controls.Add(pictureBox1);
			resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			// 
			// ViewDashboard
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(flowLayoutPanel1);
			IsMdiContainer = true;
			Name = "ViewDashboard";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			flowLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}