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
using WinformNPGSQL.db;

namespace WinformNPGSQL
{
	public partial class ViewDashboard : Form
	{
		DashboardController dashboardController = new DashboardController();
		public ViewDashboard()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			dashboardController.NavigateTodo(this);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dashboardController.NavigateViewFoto(this);
		}

		~ViewDashboard()
		{
			Database.Close();
		}
	}
}
