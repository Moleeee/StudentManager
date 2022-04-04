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
            //Application.Run(new Form1());
            //Application.Run(new LoginForm01());
            LoginForm01 loginform = new LoginForm01();
            loginform.ShowDialog();
            
            if (loginform.closeFlag == false)
            {
                Application.Run(new Form1());
            }

            /*String connetStr = "server=127.0.0.1;" +
                "port=3307;" +
                "user=root;" +
                "password=dyinglight77...; " +
                "database=Admin;";
            //连接MySQL
            MySqlConnection conn = new MySqlConnection(connetStr);

            //异常检测
            try
            {
                conn.Open();
                Console.WriteLine("已经建立连接");

                //在这里写增删改查语句
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }*/
        }

    }
}
