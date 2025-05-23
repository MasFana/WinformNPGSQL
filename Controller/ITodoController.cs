using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformNPGSQL.Model;

namespace WinformNPGSQL.Controller
{
	internal interface ITodoController
	{
		List<Todo> GetAllTodos();
		void AddTodo(string todoText);
		void UpdateTodo(int id, string todoText);
		void DeleteTodo(int id);
	}
}
