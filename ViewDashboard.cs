using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformNPGSQL.Controller;
using WinformNPGSQL.Database;

namespace WinformNPGSQL
{
	public partial class ViewDashboard : Form
	{
		NavigationController navigationController = new NavigationController();
		public ViewDashboard()
		{
			InitializeComponent();
			navigationController.NavigateTodo(this);
		}


		private void buttonPicture_Click(object sender, EventArgs e)
		{
			navigationController.NavigateViewFoto(this);
		}

		private void buttonTodo_Click(object sender, EventArgs e)
		{
			navigationController.NavigateTodo(this);

		}

		~ViewDashboard()
		{
			DB.Close();
		}
	}
}
