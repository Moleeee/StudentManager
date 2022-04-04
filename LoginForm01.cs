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
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Crypto.Engines;

namespace WindowsFormsApp1
{
    public partial class LoginForm01 : Form
    {
        public LoginForm01()
        {
            InitializeComponent();
            this.Load += ConnectMySQL;
        }

        List<Admin> admins = new List<Admin>(); //新建一个数据集合，实例化

        public bool closeFlag=true;

        //string acc01 = "2020";
        //string pas01 = "bupt";

        private void Login(TextBox acc,TextBox pas)
        {
            /*if ((acc.Text == acc01) && (pas.Text == pas01))
            {
                //Form form1=new Form1();
                //form1.Show();
                closeFlag = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("账号密码错误");
            }*/

            for(int i = 0; i < admins.Count; i++)
            {
                if ((acc.Text == admins[i].Account) && (pas.Text == admins[i].Password))
                {
                    closeFlag = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码错误");
                }
            }

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login(textBoxAccount,textBoxPassword);
        }

        private void ConnectMySQL(object sender, EventArgs e)
        {
            String connetStr = "server=localhost;" +
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
                string version = conn.ServerVersion;
                Console.WriteLine("已经建立连接"+version);

                //在这里写增删改查语句

                // 创建用于实现MySQL语句的对象

                //string mysqlInsert = "INSERT INTO table1 value(123)";
                // MySqlCommand mySqlCommand = new MySqlCommand(mysqlInsert, conn);

                // 执行MySQL语句进行插入
                //mySqlCommand.ExecuteNonQuery();

                //string sql = "CREATE TABLE " + "WRA1" + "(Type char(20),DIST1 float(16,2),DIST2 float(16,2),DIST3 float(16,2),DIST4 float(16,2))";//表名+字段1,字段2,字段3
                //MySqlCommand cmd = new MySqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("表创建成功！");
                //string Type = "BEEFY TT180-5";
                //string DIST1 = "12351", DIST2 = "12451", DIST3 = "13451", DIST4 = "12351";
                //string ins = "insert into WRA1(Type,DIST1,DIST2,DIST3,DIST4)values('" + Type + "','" + DIST1 + "','" + DIST2 + "','" + DIST3 + "','" + DIST4 + "')";
                //MySqlCommand cmd1 = new MySqlCommand(ins, conn);
                //cmd1.ExecuteNonQuery();
                //MessageBox.Show("插入成功");

                //List<Admin> admins = new List<Admin>(); //新建一个数据集合，实例化
                string query = "select * from WRA1";  //sql查询语句
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
                }

                //dataGridView1.DataSource = admins;

            }
            catch (MySqlException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        
        private void ChangePas()
        {
            for(int i = 0; i < admins.Count; i++)
            {
                if ((textBoxChangeAccount.Text==admins[i].Account)&&(textBoxOldPas.Text == admins[i].Password))
                {
                    Console.WriteLine("1");
                    String connetStr = "server=localhost;" +
                    "port=3307;" +
                    "user=root;" +
                    "password=dyinglight77...; " +
                    "database=Admin;";
                    //连接MySQL
                    MySqlConnection conn = new MySqlConnection(connetStr);
                    try
                    {
                        conn.Open();
                        //更新密码
                        string updatePas = "update wra1 set Password = '" + textBoxNewPas.Text + "' where Account = " + textBoxChangeAccount.Text;
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
                    }
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
