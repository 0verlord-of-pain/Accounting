using System;
using System.Windows.Forms;

namespace Accounting
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var a = SqliteDataAccess.GetUsers();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartMenu());
        }
    }
}