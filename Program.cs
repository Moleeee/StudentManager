using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*LoginForm01 loginform = new LoginForm01();
            loginform.ShowDialog();
            if (loginform.closeFlag == false)
            {
                Application.Run(new Form1());
            }*/

            Application.Run(new Form1());
        }

    }
}
