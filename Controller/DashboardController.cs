using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformNPGSQL.Controller
{
	public class DashboardController
	{
		Form? formTerbuka;

		public void NavigateTodo(Form form)
		{
			if(formTerbuka != null)
			{
				formTerbuka.Close();
				formTerbuka = null;
			}
			formTerbuka = new ViewTodo();

			formTerbuka.MdiParent = form;
			formTerbuka.Dock = DockStyle.Fill;
			form.Text = "Todo";
			formTerbuka.Show();
		}

		public void NavigateViewFoto(Form form)
		{
			if (formTerbuka != null)
			{
				formTerbuka.Close();
				formTerbuka = null;
			}
			formTerbuka = new ViewFoto();

			formTerbuka.MdiParent = form;
			formTerbuka.Dock = DockStyle.Fill;
			form.Text = "View Foto";
			formTerbuka.Show();
		}
	}
}
