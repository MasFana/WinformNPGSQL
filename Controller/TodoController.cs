using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using WinformNPGSQL.Database;
using WinformNPGSQL.Model;
namespace WinformNPGSQL.Controller
{
	public class TodoController
	{

		public List<Todo> GetAllTodos()
		{
			try
			{
				List<Todo> todos = new List<Todo>();
				DataTable dt = DB.ExecuteQuery("SELECT * FROM todo");
				foreach (DataRow row in dt.Rows)
				{
					Todo todo = new(Convert.ToInt32(row["id"]), row["teks"].ToString());
					todos.Add(todo);
				}
				return todos;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Database error: {ex.Message}");
				return new List<Todo>();
			}
		}

		public void AddTodo(string todoText)
		{
			DB.ExecuteNonQuery("INSERT INTO todo(teks) VALUES(@teks)", new NpgsqlParameter("@teks", todoText));
		}

		public void UpdateTodo(int id, string todoText)
		{
			DB.ExecuteNonQuery("UPDATE todo SET teks = @teks WHERE id = @id", new NpgsqlParameter("@teks", todoText), new NpgsqlParameter("@id", id));
		}

		public void DeleteTodo(int id)
		{
			DB.ExecuteNonQuery("DELETE FROM todo WHERE id = @id", new NpgsqlParameter("@id", id));
		}
	}
}

