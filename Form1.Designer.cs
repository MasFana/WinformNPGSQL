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
			((System.ComponentModel.ISupportInitialize)gridTodo).BeginInit();
			SuspendLayout();
			// 
			// gridTodo
			// 
			gridTodo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			gridTodo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			gridTodo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridTodo.Location = new Point(12, 12);
			gridTodo.Name = "gridTodo";
			gridTodo.RowHeadersWidth = 62;
			gridTodo.Size = new Size(780, 469);
			gridTodo.TabIndex = 0;
			// 
			// boxTodo
			// 
			boxTodo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			boxTodo.Location = new Point(12, 487);
			boxTodo.Multiline = true;
			boxTodo.Name = "boxTodo";
			boxTodo.Size = new Size(780, 125);
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
			buttonSimpan.Location = new Point(12, 618);
			buttonSimpan.Name = "buttonSimpan";
			buttonSimpan.Size = new Size(780, 88);
			buttonSimpan.TabIndex = 3;
			buttonSimpan.Text = "SIMPAN";
			buttonSimpan.UseVisualStyleBackColor = false;
			buttonSimpan.Click += buttonSimpan_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(804, 718);
			Controls.Add(buttonSimpan);
			Controls.Add(boxTodo);
			Controls.Add(gridTodo);
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
	}
}
