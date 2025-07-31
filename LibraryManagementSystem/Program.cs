using DTO_Models;
using GUI_UI;

namespace LibraryManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new UserManagementForm());

            //var loginForm = new LoginForm();
            //if (loginForm.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new MainForm());
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }
    }
}