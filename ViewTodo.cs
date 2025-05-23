using Npgsql;
using System.Data;
using WinformNPGSQL.Controller;
using WinformNPGSQL.Model.Todo;

namespace WinformNPGSQL
{
	public partial class ViewTodo : Form
	{
		//TodoController _todoController = new TodoController();
		//List<Todo> listTodo;
		//string InputTodo;
		//int SelectedCellId;
		public ViewTodo()
		{
			//listTodo = _todoController.GetAllTodos();
			InitializeComponent();
			//gridTodo.DataSource = listTodo;
			//gridTodo.Columns["id"].Visible = true;

		}

		private void boxTodo_TextChanged(object sender, EventArgs e)
		{
			//InputTodo = boxTodo.Text;
		}

		private void buttonSimpan_Click(object sender, EventArgs e)
		{
			//if (string.IsNullOrEmpty(InputTodo))
			//{
			//	MessageBox.Show("Teks tidak boleh kosong");
			//	return;
			//}
			//if (SelectedCellId > 0)
			//{
			//	_todoController.UpdateTodo(SelectedCellId, InputTodo);
			//	MessageBox.Show("Berhasil Update");
			//	SelectedCellId = -1;
			//	boxTodo.Clear();
			//	gridTodo.DataSource = _todoController.GetAllTodos();

			//}
			//else
			//{
			//	_todoController.AddTodo(InputTodo);
			//	MessageBox.Show("Berhasil Simpan");
			//	boxTodo.Clear();
			//	gridTodo.DataSource = _todoController.GetAllTodos();
			//}
		}

		private void gridTodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < gridTodo.RowCount - 1)
			//{
			//	SelectedCellId = (int)gridTodo.Rows[e.RowIndex].Cells["id"].Value;
			//	var cellValue = gridTodo.Rows[e.RowIndex].Cells["teks"].Value;
			//	boxTodo.Text = cellValue?.ToString();
			//	label1.Text = "" + SelectedCellId.ToString();

			//}
		}

		private void buttonHapus_Click(object sender, EventArgs e)
		{
			//_todoController.DeleteTodo(SelectedCellId);
			//SelectedCellId = -1;
			//gridTodo.DataSource = _todoController.GetAllTodos();
			//boxTodo.Clear();
			//label1.Text = "" + SelectedCellId.ToString();

		}

		private void button1_Click(object sender, EventArgs e)
		{
		//	SelectedCellId = -1;
		//	label1.Text = "" + SelectedCellId.ToString();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}



//public class DatabaseHandler
//{
//	NpgsqlConnection conn;

//	public DatabaseHandler()
//	{
//		conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=pbo");
//		conn.Open();
//	}

//	public DataTable GetTodo()
//	{
//		DataTable dt = new DataTable();
//		using (var cmd = new NpgsqlCommand("SELECT id, teks FROM todo ORDER BY id", conn))
//		using (var reader = cmd.ExecuteReader())
//		{
//			dt.Load(reader);
//		}
//		return dt;
//	}

//	public void AddTodo(string teks)
//	{
//		using (var cmd = new NpgsqlCommand("INSERT INTO todo(teks) VALUES(@teks)", conn))
//		{
//			cmd.Parameters.AddWithValue("@teks", teks);
//			cmd.ExecuteNonQuery();
//		}
//	}

//	public void UpdateTodo(int id, string newText)
//	{
//		using (var cmd = new NpgsqlCommand("UPDATE todo SET teks = @teks WHERE id = @id", conn))
//		{
//			cmd.Parameters.AddWithValue("@id", id);
//			cmd.Parameters.AddWithValue("@teks", newText);
//			cmd.ExecuteNonQuery();
//		}
//	}


//	public void DeleteTodo(int id)
//	{
//		using (var cmd = new NpgsqlCommand("DELETE FROM todo WHERE id = @id", conn))
//		{
//			cmd.Parameters.AddWithValue("@id", id);
//			cmd.ExecuteNonQuery();
//		}
//	}


//	~DatabaseHandler()
//	{
//		conn.Close();
//	}

//}

