namespace WinformNPGSQL
{
    partial class ViewTodo
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
			buttonReset = new Button();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)gridTodo).BeginInit();
			SuspendLayout();
			// 
			// gridTodo
			// 
			gridTodo.AllowUserToOrderColumns = true;
			gridTodo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			gridTodo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			gridTodo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridTodo.Location = new Point(8, 7);
			gridTodo.Margin = new Padding(2);
			gridTodo.Name = "gridTodo";
			gridTodo.RowHeadersWidth = 62;
			gridTodo.Size = new Size(546, 281);
			gridTodo.TabIndex = 0;
			gridTodo.CellClick += gridTodo_CellContentClick;
			gridTodo.CellContentClick += gridTodo_CellContentClick;
			// 
			// boxTodo
			// 
			boxTodo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			boxTodo.Location = new Point(8, 292);
			boxTodo.Margin = new Padding(2);
			boxTodo.Multiline = true;
			boxTodo.Name = "boxTodo";
			boxTodo.Size = new Size(458, 77);
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
			buttonSimpan.Location = new Point(278, 371);
			buttonSimpan.Margin = new Padding(2);
			buttonSimpan.Name = "buttonSimpan";
			buttonSimpan.Size = new Size(276, 53);
			buttonSimpan.TabIndex = 3;
			buttonSimpan.Text = "SIMPAN";
			buttonSimpan.UseVisualStyleBackColor = false;
			buttonSimpan.Click += buttonSimpan_Click;
			// 
			// buttonHapus
			// 
			buttonHapus.BackColor = Color.Red;
			buttonHapus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			buttonHapus.Location = new Point(8, 371);
			buttonHapus.Margin = new Padding(2);
			buttonHapus.Name = "buttonHapus";
			buttonHapus.Size = new Size(265, 53);
			buttonHapus.TabIndex = 4;
			buttonHapus.Text = "HAPUS";
			buttonHapus.UseVisualStyleBackColor = false;
			buttonHapus.Click += buttonHapus_Click;
			// 
			// buttonReset
			// 
			buttonReset.Location = new Point(479, 320);
			buttonReset.Name = "buttonReset";
			buttonReset.Size = new Size(72, 27);
			buttonReset.TabIndex = 5;
			buttonReset.Text = "Reset ID";
			buttonReset.UseVisualStyleBackColor = true;
			buttonReset.Click += buttonReset_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(500, 296);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(17, 15);
			label1.TabIndex = 6;
			label1.Text = "id";
			// 
			// ViewTodo
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(563, 431);
			Controls.Add(label1);
			Controls.Add(buttonReset);
			Controls.Add(buttonHapus);
			Controls.Add(buttonSimpan);
			Controls.Add(boxTodo);
			Controls.Add(gridTodo);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(2);
			Name = "ViewTodo";
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
		private Button buttonReset;
		private Label label1;
	}
}
