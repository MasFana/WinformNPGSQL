using Npgsql;
using System.Data;

namespace WinformNPGSQL
{
	public partial class Form1 : Form
	{
		string InputTodo;
		DatabaseHandler db = new DatabaseHandler();
		public Form1()
		{
			InitializeComponent();
			gridTodo.DataSource = db.GetTodo();
		}

		private void boxTodo_TextChanged(object sender, EventArgs e)
		{
			InputTodo = boxTodo.Text;
		}

		private void buttonSimpan_Click(object sender, EventArgs e)
		{
			db.AddTodo(InputTodo);
			MessageBox.Show("Berhasil Simpan");
			boxTodo.Clear();
			gridTodo.DataSource = db.GetTodo();
		}
	}
}


public class DatabaseHandler
{
	NpgsqlConnection conn;

	public DatabaseHandler()
	{
		conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=pbo");
		conn.Open();
	}

	public DataTable GetTodo()
	{
		DataTable dt = new DataTable();
		using (var cmd = new NpgsqlCommand("SELECT id, teks FROM todo ORDER BY id", conn))
		using (var reader = cmd.ExecuteReader())
		{
			dt.Load(reader);
		}
		return dt;
	}

	public void AddTodo(string teks)
	{
		using (var cmd = new NpgsqlCommand("INSERT INTO todo(teks) VALUES(@teks)", conn))
		{
			cmd.Parameters.AddWithValue("@teks", teks);
			cmd.ExecuteNonQuery();
		}
	}

	public void UpdateTodo(int id, string newText)
	{
		using (var cmd = new NpgsqlCommand("UPDATE todo SET teks = @teks WHERE id = @id", conn))
		{
			cmd.Parameters.AddWithValue("@id", id);
			cmd.Parameters.AddWithValue("@teks", newText);
			cmd.ExecuteNonQuery();
		}
	}


	public void DeleteTodo(int id)
	{
		using (var cmd = new NpgsqlCommand("DELETE FROM todo WHERE id = @id", conn))
		{
			cmd.Parameters.AddWithValue("@id", id);
			cmd.ExecuteNonQuery();
		}
	}


	~DatabaseHandler()
	{
		conn.Close();
	}

}
