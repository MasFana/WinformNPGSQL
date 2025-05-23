using Npgsql;
using System.ComponentModel;
using System.Data;
using WinformNPGSQL.Controller;
using WinformNPGSQL.Model;

namespace WinformNPGSQL
{
	public partial class ViewTodo : Form
	{
		TodoController _todoController = new TodoController();
		
		string InputTodo;
		int SelectedCellId;

		public void RefreshTodo()
		{
			gridTodo.DataSource = _todoController.GetAllTodos();
			if (gridTodo.Columns["id"] != null)
			{
				gridTodo.Columns["id"].Visible = false;
			}
		}
		public ViewTodo()
		{
			InitializeComponent();
			RefreshTodo();

		}

		private void boxTodo_TextChanged(object sender, EventArgs e)
		{
			InputTodo = boxTodo.Text;
		}

		private void buttonSimpan_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(InputTodo))
			{
				MessageBox.Show("Teks tidak boleh kosong");
				return;
			}
			if (SelectedCellId > 0)
			{
				_todoController.UpdateTodo(SelectedCellId, InputTodo);
				MessageBox.Show("Berhasil Update");
				SelectedCellId = -1;
				boxTodo.Clear();
				RefreshTodo();
			}
			else
			{
				_todoController.AddTodo(InputTodo);
				MessageBox.Show("Berhasil Simpan");
				boxTodo.Clear();
				RefreshTodo();
			}
		}

		private void gridTodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < gridTodo.RowCount)
			{
				SelectedCellId = (int)gridTodo.Rows[e.RowIndex].Cells["id"].Value;
				var cellValue = gridTodo.Rows[e.RowIndex].Cells["teks"].Value;
				boxTodo.Text = cellValue?.ToString();
				label1.Text = "" + SelectedCellId.ToString();


			}
		}

		private void buttonHapus_Click(object sender, EventArgs e)
		{
			_todoController.DeleteTodo(SelectedCellId);
			SelectedCellId = -1;
			boxTodo.Clear();
			label1.Text = "" + SelectedCellId.ToString();
			RefreshTodo();

		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			SelectedCellId = -1;
			label1.Text = "" + SelectedCellId.ToString();
		}

	}
}


