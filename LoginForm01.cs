using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Microsoft.Win32.SafeHandles;
using Sql_Read_Show_;
using Sql_SAccount;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Crypto.Engines;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace WindowsFormsApp1
{
    public partial class LoginForm01 : Form
    {
        public LoginForm01()
        {
            InitializeComponent();
            this.Load += CreateMysqlDB; //创建名为Admin的数据库
            this.Load += CreatTable_tAccount;    //创建存储管理员初始账户的表
            this.Load += CreatTable_sAccount;    //创建存储学生初始账户的表
            this.Load += InisAccountList;       //初始化学生账户的
            this.Load += ConnectMySQL;  //连接数据库，获取初始账户信息
        }
        static string port = "port=3306;";
        static string database = "database=Admin01;";

        List<Admin> admins = new List<Admin>(); //新建一个存储管理员账户的数据集合，实例化

        List<SAccount> list_saccount = new List<SAccount>(); //新建一个数据集合，实例化

        public string isTeacher="unknown";//登录身份

        /*管理员初始账户:2020
                初始密码:bupt
        */

        private void Login(TextBox acc, TextBox pas,ComboBox identity)
        {
            if (identity.Text == "")
            {
                MessageBox.Show("请选择登录身份");
            }
            else if (identity.Text == "管理员")
            {
                bool AccPasMatch = false;
                for (int i = 0; i < admins.Count; i++)
                {
                    if ((acc.Text == admins[i].Account) && (pas.Text == admins[i].Password))
                    {
                        isTeacher = "yes";
                        AccPasMatch = true;
                        this.Close();
                    }
                }
                if (AccPasMatch == false) MessageBox.Show("密码错误");
            }
            else if (identity.Text == "学生")
            {
                bool AccPasMatch = false;
                for (int i = 0; i < list_saccount.Count; i++)
                {
                    if ((acc.Text == list_saccount[i].sAccount) && (pas.Text == list_saccount[i].sPassword))
                    {
                        isTeacher = "no";
                        StuForm.nowSno = acc.Text;
                        AccPasMatch = true;
                        this.Close();
                    }
                }
                if (AccPasMatch == false) MessageBox.Show("密码错误");
            }

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login(textBoxAccount, textBoxPassword,comboBoxIsTeacher);
        }

        private void ConnectMySQL(object sender, EventArgs e)
        {
            String connetStr = "server=localhost;" +
                port+
                "user=root;" +
                "password=root; " +
                database;
            //连接MySQL
            MySqlConnection conn = new MySqlConnection(connetStr);

            //异常检测
            try
            {
                conn.Open();
                string version = conn.ServerVersion;
                Console.WriteLine("已经建立连接" + version);

                #region 注释
                //创建数据库
                /*string cdb = "create database AAA;";
                MySqlCommand createdb = new MySqlCommand(cdb, conn);
                createdb.ExecuteNonQuery();
                Console.WriteLine("创建数据库成功");*/

                //在这里写增删改查语句

                // 创建用于实现MySQL语句的对象

                //string mysqlInsert = "INSERT INTO table1 value(123)";
                // MySqlCommand mySqlCommand = new MySqlCommand(mysqlInsert, conn);

                // 执行MySQL语句进行插入
                //mySqlCommand.ExecuteNonQuery();

                //string sql = "CREATE TABLE " + "teinfo" + "(Type char(20),DIST1 float(16,2),DIST2 float(16,2),DIST3 float(16,2),DIST4 float(16,2))";//表名+字段1,字段2,字段3
                //MySqlCommand cmd = new MySqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("表创建成功！");
                //string Type = "BEEFY TT180-5";
                //string DIST1 = "12351", DIST2 = "12451", DIST3 = "13451", DIST4 = "12351";
                //string ins = "insert into teinfo(Type,DIST1,DIST2,DIST3,DIST4)values('" + Type + "','" + DIST1 + "','" + DIST2 + "','" + DIST3 + "','" + DIST4 + "')";
                //MySqlCommand cmd1 = new MySqlCommand(ins, conn);
                //cmd1.ExecuteNonQuery();
                //MessageBox.Show("插入成功");
                #endregion

                //List<Admin> admins = new List<Admin>(); //新建一个数据集合，实例化
                string query = "select * from teinfo";  //sql查询语句
                MySqlCommand cmd = new MySqlCommand(query, conn);    //将查询语句放进该数据库容器中
                MySqlDataReader dataReader = cmd.ExecuteReader();   //创建一个实例保存查询出来的结构                              
                if (dataReader.HasRows) //判断有没有读取到数据，实际是判断有没有读取到行数据，可以不写
                {
                    while (dataReader.Read())
                    {
                        //在数据集合加入数据，
                        admins.Add(
                        //添加数据库数据到list
                        new Admin()
                        {
                            Account = dataReader["Account"].ToString(),
                            Password = dataReader["Password"].ToString(),

                        });
                    }
                    dataReader.Close();

                }
                dataReader.Close();
                //Console.WriteLine(dataReader.IsClosed);
                //dataGridView1.DataSource = admins;

            }
            catch
            {

                Console.WriteLine("error");
            }
            finally
            {
                conn.Close();
                //Console.WriteLine("conn close");

            }
            //Console.WriteLine(conn.State);
            conn.Close();

        }

        private void ChangePas()
        {
            for (int i = 0; i < admins.Count; i++)
            {
                if ((textBoxChangeAccount.Text == admins[i].Account) && (textBoxOldPas.Text == admins[i].Password))
                {
                    Console.WriteLine("1");
                    String connetStr = "server=localhost;" +
                    port +
                    "user=root;" +
                    "password=root; " +
                    database;
                    //连接MySQL
                    MySqlConnection conn = new MySqlConnection(connetStr);
                    try
                    {
                        conn.Open();
                        //更新密码
                        string updatePas = "update teinfo set Password = '" + textBoxNewPas.Text + "' where Account = " + textBoxChangeAccount.Text;
                        MySqlCommand cmd = new MySqlCommand(updatePas, conn);
                        cmd.ExecuteNonQuery();
                        admins[i].Password = textBoxNewPas.Text;
                        Console.WriteLine("change success");
                    }
                    catch
                    {
                        MessageBox.Show("failed");
                    }
                    finally
                    {
                        conn.Close();
                        Console.WriteLine("close conn");
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("密码错误");
                }
            }
        }

        private void linkLabelChangePas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panelChangePas.Visible = true;
        }

        private void BtnChangeConfirm_Click(object sender, EventArgs e)
        {
            ChangePas();
        }

        private void BtnBackToLog_Click(object sender, EventArgs e)
        {
            this.panelChangePas.Visible = false;
        }

        private void LoginForm01_Load(object sender, EventArgs e)
        {

        }

        private void textBoxChangeAccount_TextChanged(object sender, EventArgs e)
        {

        }

        public static void CreateMysqlDB(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Data Source=localhost;" +
                                                        port +
                                                        "UserId=root;" +
                                                        " PWD=root");
            MySqlCommand cmd = new MySqlCommand("CREATE DATABASE Admin01;", conn);

            conn.Open();

            //防止第二次启动时再次新建数据库
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("建立数据库成功");

            }
            catch (Exception)
            {
                conn.Close();
                Console.WriteLine("建立数据库失败，已存在了");
                //throw;
            }
            //防止第二次启动时再次新建数据库
            finally
            {

            }
        }

        public void CreatTable_tAccount(object sender, EventArgs e)
        {
            MySqlConnection conn_1 = new MySqlConnection("Data Source=localhost;" +
                                                        port +
                                                        "user=root;" +
                                                        " password=root;" +
                                                        database);
            try
            {
                conn_1.Open();
                //建表
                string createTable = "create table teinfo(Account varchar(10) NOT NULL,Password varchar(20))";
                MySqlCommand cmd1 = new MySqlCommand(createTable, conn_1);
                cmd1.ExecuteNonQuery();
                Console.WriteLine("建表成功");

                //在表中写入初始密码
                string iniAccount = "2020";
                string iniPassword = "bupt";
                string iniInfo= "insert into teinfo(Account,Password)" +
                            "values('" + iniAccount + "','" + iniPassword + "')";
                MySqlCommand cmd2 = new MySqlCommand(iniInfo, conn_1);
                cmd2.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("表已存在");
                //throw;
            }
            finally
            {
                conn_1.Close();
            }

        }

        private void CreatTable_sAccount(object sender, EventArgs e)
        {
            MySqlConnection conn_1 = new MySqlConnection("Data Source=localhost;" +
                                                        port +
                                                        "user=root;" +
                                                        " password=root;" +
                                                        database);
            try
            {
                conn_1.Open();
                //建表
                string createTable = "create table sAccount(Account varchar(10) NOT NULL,Password varchar(20))";
                MySqlCommand cmd1 = new MySqlCommand(createTable, conn_1);
                cmd1.ExecuteNonQuery();
                Console.WriteLine("建表成功");

                //在表中写入初始密码
                /*string iniAccount = "2020";
                string iniPassword = "bupt";
                string iniInfo = "insert into teinfo(Account,Password)" +
                            "values('" + iniAccount + "','" + iniPassword + "')";
                MySqlCommand cmd2 = new MySqlCommand(iniInfo, conn_1);
                cmd2.ExecuteNonQuery();*/

            }
            catch
            {
                Console.WriteLine("表已存在");
                //throw;
            }
            finally
            {
                conn_1.Close();
            }
        }

        private void InisAccountList(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Data Source=localhost;" +
                                                        port +
                                                        "user=root;" +
                                                        " password=root;" +
                                                        database);
            conn.Open();
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
                        sAccount = dataReader["Account"].ToString(),
                        sPassword = dataReader["Password"].ToString(),
                    });
                }
                //dataReader.Close();
            }
            dataReader.Close();
            conn.Close();
        }
    }
}
namespace Sql_Read_Show_
 {
     public partial class Admin
     {
        public string Account { get; set; }
        public string Password { get; set; }

        }
    }
namespace Sql_SAccount
{
    public partial class SAccount
    {
        public string sAccount { get; set; }
        public string sPassword { get; set; }
    }
}
