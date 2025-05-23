using WinformNPGSQL.Controller;
using WinformNPGSQL.Model.Todo;

namespace WinformNPGSQL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			//// To customize application configuration such as set high DPI settings or default font,
			//// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new ViewDashboard());

			//TodoController _todoController = new TodoController();
			//List<Todo> listTodo;
			//string InputTodo;
			//int SelectedCellId;

			//listTodo = _todoController.GetAllTodos();
			//Console.WriteLine(listTodo);


		}
    }
}