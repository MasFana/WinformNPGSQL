namespace WinformNPGSQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			gridTodo = new DataGridView();
			boxTodo = new TextBox();
			contextMenuStrip1 = new ContextMenuStrip(components);
			buttonSimpan = new Button();
			buttonHapus = new Button();
			button1 = new Button();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)gridTodo).BeginInit();
			SuspendLayout();
			// 
			// gridTodo
			// 
			gridTodo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			gridTodo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			gridTodo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridTodo.Location = new Point(11, 12);
			gridTodo.Name = "gridTodo";
			gridTodo.RowHeadersWidth = 62;
			gridTodo.Size = new Size(780, 468);
			gridTodo.TabIndex = 0;
			gridTodo.CellClick += gridTodo_CellContentClick;
			gridTodo.CellContentClick += gridTodo_CellContentClick;
			// 
			// boxTodo
			// 
			boxTodo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			boxTodo.Location = new Point(11, 487);
			boxTodo.Multiline = true;
			boxTodo.Name = "boxTodo";
			boxTodo.Size = new Size(653, 126);
			boxTodo.TabIndex = 1;
			boxTodo.TextChanged += boxTodo_TextChanged;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(24, 24);
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// buttonSimpan
			// 
			buttonSimpan.BackColor = Color.LightGreen;
			buttonSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			buttonSimpan.Location = new Point(397, 618);
			buttonSimpan.Name = "buttonSimpan";
			buttonSimpan.Size = new Size(394, 88);
			buttonSimpan.TabIndex = 3;
			buttonSimpan.Text = "SIMPAN";
			buttonSimpan.UseVisualStyleBackColor = false;
			buttonSimpan.Click += buttonSimpan_Click;
			// 
			// buttonHapus
			// 
			buttonHapus.BackColor = Color.Red;
			buttonHapus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			buttonHapus.Location = new Point(11, 618);
			buttonHapus.Name = "buttonHapus";
			buttonHapus.Size = new Size(379, 88);
			buttonHapus.TabIndex = 4;
			buttonHapus.Text = "HAPUS";
			buttonHapus.UseVisualStyleBackColor = false;
			buttonHapus.Click += buttonHapus_Click;
			// 
			// button1
			// 
			button1.Location = new Point(684, 533);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(103, 45);
			button1.TabIndex = 5;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(714, 494);
			label1.Name = "label1";
			label1.Size = new Size(27, 25);
			label1.TabIndex = 6;
			label1.Text = "id";
			label1.Click += label1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(804, 718);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(buttonHapus);
			Controls.Add(buttonSimpan);
			Controls.Add(boxTodo);
			Controls.Add(gridTodo);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form1";
			Text = "TODO ASIK";
			((System.ComponentModel.ISupportInitialize)gridTodo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView gridTodo;
		private TextBox boxTodo;
		private ContextMenuStrip contextMenuStrip1;
		private Button buttonSimpan;
		private Button buttonHapus;
		private Button button1;
		private Label label1;
	}
}
