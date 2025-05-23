using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformNPGSQL.Model
{
	public class Todo
	{
		public int id { get; set; }
		public string teks { get; set; }

		public Todo(int id, string teks)
		{
			this.id = id;
			this.teks = teks;
		}
	}

}
