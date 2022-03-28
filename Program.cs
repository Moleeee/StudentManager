using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Application.Run(new Form1());
            //Application.Run(new LoginForm01());
            LoginForm01 loginform =new LoginForm01();
            loginform.ShowDialog();
            if (loginform.closeFlag == false)
            {
                Application.Run(new Form1());
            }
        }
    }
}
