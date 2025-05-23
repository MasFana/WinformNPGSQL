using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformNPGSQL.Model.Todo
{
	public class Todo 
	{
		public int id;
		public string teks;

		public Todo(int id, string teks)
		{
			this.id = id;
			this.teks = teks;
		}
	}
	
}
