using System;
using System.Windows.Forms;

namespace inventory
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Db.EnsureUsersTable();
            Application.Run(new SignInForm());
        }
    }
}
