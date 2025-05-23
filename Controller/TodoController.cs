using Npgsql;
using WinformNPGSQL.Model.Todo;
using System;
using System.Collections.Generic;
using System.Data;
namespace WinformNPGSQL.Controller
{
	public class TodoController
	{

		public List<Todo> GetAllTodos()
		{

			List<Todo> todos = new List<Todo>();
			DataTable dt = db.Database.ExecuteQuery("SELECT * FROM todo");
			foreach (DataRow row in dt.Rows)
			{
				Todo todo = new(Convert.ToInt32(row["id"]), row["teks"].ToString() ?? string.Empty);
				todos.Add(todo);
			}
			return todos;
		}

		public void AddTodo(string todoText)
		{
			db.Database.ExecuteNonQuery("INSERT INTO todo(teks) VALUES(@teks)", new NpgsqlParameter("@teks", todoText));
		}

		public void UpdateTodo(int id, string todoText)
		{
			db.Database.ExecuteNonQuery("UPDATE todo SET teks = @teks WHERE id = @id", new NpgsqlParameter("@teks", todoText), new NpgsqlParameter("@id", id));
		}

		public void DeleteTodo(int id)
		{
			db.Database.ExecuteNonQuery("DELETE FROM todo WHERE id = @id", new NpgsqlParameter("@id", id));
		}
	}
}

