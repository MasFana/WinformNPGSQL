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
			flowLayoutPanel1 = new FlowLayoutPanel();
			buttonPicture = new Button();
			buttonTodo = new Button();
			pictureBox1 = new PictureBox();
			flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BackColor = SystemColors.ControlText;
			flowLayoutPanel1.Controls.Add(pictureBox1);
			flowLayoutPanel1.Controls.Add(buttonPicture);
			flowLayoutPanel1.Controls.Add(buttonTodo);
			resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			// 
			// buttonPicture
			// 
			resources.ApplyResources(buttonPicture, "buttonPicture");
			buttonPicture.Name = "buttonPicture";
			buttonPicture.UseVisualStyleBackColor = true;
			buttonPicture.Click += buttonPicture_Click;
			// 
			// buttonTodo
			// 
			resources.ApplyResources(buttonTodo, "buttonTodo");
			buttonTodo.Name = "buttonTodo";
			buttonTodo.UseVisualStyleBackColor = true;
			buttonTodo.Click += buttonTodo_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.Frieren___Sousou_no_Frieren;
			resources.ApplyResources(pictureBox1, "pictureBox1");
			pictureBox1.Name = "pictureBox1";
			pictureBox1.TabStop = false;
			// 
			// ViewDashboard
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(flowLayoutPanel1);
			IsMdiContainer = true;
			Name = "ViewDashboard";
			flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private FlowLayoutPanel flowLayoutPanel1;
		private Button buttonPicture;
		private Button buttonTodo;
		private PictureBox pictureBox1;
	}
}