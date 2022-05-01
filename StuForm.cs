using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sql_SAccount;

namespace WindowsFormsApp1
{
    public partial class StuForm : Form
    {

        List<SAccount> list_saccount = new List<SAccount>(); //新建一个数据集合，实例化

        static public string nowSno = "";

        #region 连接MySQL
        static string port = "port=3306;";
        static string database = "database=Admin01;";
        static string connectStr = "server=localhost;" +
                port +
                "user=root;" +
                "password=root; " +
                database;

        //连接MySQL
        MySqlConnection conn = new MySqlConnection(connectStr);
        #endregion

        public StuForm()
        {
            InitializeComponent();
            this.Load += OpenMySQL;     //窗体载入时打开数据库连接
            //this.Load += InisAccountList;
            this.FormClosed += CloseMySQL;//窗体关闭后关闭数据库连接
        }
        
        private void CheckDeg()
        {
            string no = nowSno;
            //Stu stu = students.Find(t => t.Sno == no);
            string check = "select * from stuinfo where Sno=" + no;
            MySqlCommand cmd = new MySqlCommand(check, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("成绩:" + dr.GetString("Sdeg"));
            }
            else
            {
                MessageBox.Show("该学号不存在", "错误",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Error);
            }
            dr.Close();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            CheckDeg();
        }

        private void OpenMySQL(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                string version = conn.ServerVersion;
                Console.WriteLine("连接数据库，版本:" + version);
            }
            catch (Exception)
            {
                MessageBox.Show("连接失败");
            }
        }

        private void CloseMySQL(object sender, EventArgs e)
        {
            conn.Close();
        }

        private void buttonSelectLesson_Click(object sender, EventArgs e)
        {
            panelSL.Visible = true;
        }

        private void buttonSLConfirm_Click(object sender, EventArgs e)
        {

        }

        private void buttonSLBack_Click(object sender, EventArgs e)
        {
            panelSL.Visible = false;
        }



        /*private void InisAccountList(object sender, EventArgs e)
        {
            string query = "select * from sAccount";  //sql查询语句
            MySqlCommand cmd = new MySqlCommand(query, conn);    //将查询语句放进该数据库容器中
            MySqlDataReader dataReader = cmd.ExecuteReader();   //创建一个实例保存查询出来的结构
            list_saccount.Clear();
            if (dataReader.HasRows) //判断有没有读取到数据，实际是判断有没有读取到行数据，可以不写
            {
                while (dataReader.Read())
                {
                    //在数据集合加入数据，
                    list_saccount.Add(
                    //添加数据库数据到list
                    new SAccount()
                    {
                        Account = dataReader["Account"].ToString(),
                        Password = dataReader["Password"].ToString(),
                    });
                }
                //dataReader.Close();
            }
            dataReader.Close();
        }*/
    }
}
