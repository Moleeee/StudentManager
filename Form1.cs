﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using Sql_Student;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static string port = "port=3306;";
        static string database = "database=Admin01;";

        List<Stu> students = new List<Stu>(); //新建一个数据集合，实例化
        
        public Form1()
        {
            InitializeComponent();      //初始化窗体
            this.Load += Form1_Load;
            this.Load += OpenMySQL;     //窗体载入时打开数据库连接
            this.Load += CreateTableStuInfo;
            this.Load += IniStuList;
            this.FormClosed += CloseMySQL;//窗体关闭后关闭数据库连接
        }

        #region 连接MySQL
        static string connectStr = "server=localhost;" +
                port +
                "user=root;" +
                "password=root; " +
                database;
        //连接MySQL
        MySqlConnection conn = new MySqlConnection(connectStr);
        #endregion

        private void setPanelUnvisible()    //隐藏面板，用于不同面板切换
        {
            panelAddSinfo.Visible = false;
            panelSearchSinfo.Visible = false;
            panelDelSinfo.Visible = false;
        }

        private void addStudent_1()
        {
            string Sno = textBoxSno.Text, Sname = textBoxSname.Text,
                    Sdeg = textBoxSdeg.Text, Ssex = comboBoxSsex.Text,
                    Sgrade = comboBoxSgrade.Text;
            string ins = "insert into stuinfo(Sno,Sname,Sdeg,Ssex,Sgrade)" +
                            "values('" + Sno + "','" + Sname + "','" + Sdeg + "','" + Ssex + "','" + Sgrade + "')";
            try 
            {
                
                MySqlCommand cmd1 = new MySqlCommand(ins, conn);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("插入成功");
                students.Add(
                    new Stu() { 
                        Sno=textBoxSno.Text,
                        Sname=textBoxSname.Text,
                        Sdeg=float.Parse(textBoxSdeg.Text),
                        Ssex=comboBoxSsex.Text,
                        Sgrade=comboBoxSgrade.Text,
                                });
                //students.Sort();
                addRecord_1(true, students);
                
                dataGridViewShow.DataSource = null;
                dataGridViewShow.DataSource = students;
                
            }
            catch
            {
                Console.WriteLine("添加出现错误");
                throw;
            }

            try
            {

            }
            catch
            {

            }
        }

        private void display_1()
        {
            string query = "select * from stuinfo";  //sql查询语句
            MySqlCommand cmd = new MySqlCommand(query, conn);    //将查询语句放进该数据库容器中
            MySqlDataReader dataReader = cmd.ExecuteReader();   //创建一个实例保存查询出来的结构
            try
            {
                students.Clear();
                if (dataReader.HasRows) //判断有没有读取到数据，实际是判断有没有读取到行数据，可以不写
                {
                    while (dataReader.Read())
                    {
                        //在数据集合加入数据，
                        students.Add(
                        //添加数据库数据到list
                        new Stu()
                        {
                            Sno = dataReader["Sno"].ToString(),
                            Sname = dataReader["Sname"].ToString(),
                            Sdeg = float.Parse(dataReader["Sdeg"].ToString()),
                            Ssex = dataReader["Ssex"].ToString(),
                            Sgrade = dataReader["Sgrade"].ToString(),
                        });
                    }
                    dataReader.Close();

                }
                dataReader.Close();
                dataGridViewShow.DataSource = null;
                dataGridViewShow.DataSource = students;
                dataGridViewShow.RowHeadersVisible = false;
                dataGridViewShow.Columns[0].Width = 62;
                dataGridViewShow.Columns[1].Width = 85;
                dataGridViewShow.Columns[2].Width = 85;
                dataGridViewShow.Columns[3].Width = 85;
                dataGridViewShow.Columns[4].Width = 85;
            }
            catch
            {
                MessageBox.Show("有错误");
            }
            finally
            {
                dataReader.Close();
            }

            if (students.Count == 0)
            {
                MessageBox.Show("数据库中无学生");
            }
        }
                
        private void delStudent_1()
        {
            string delNo = textBoxDel.Text;
            if (students.Exists(t => t.Sno == delNo))
            {
                string del = "delete from stuinfo where sno =" + delNo;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(del, conn);
                    cmd.ExecuteNonQuery();
                    addRecord_1(false, students);
                    students.RemoveAll((stu) => stu.Sno == delNo);
                    dataGridViewShow.DataSource = null;
                    dataGridViewShow.DataSource = students;
                    MessageBox.Show("删除成功");
                }
                catch
                {
                    Console.WriteLine("无此学号");
                }
            }
            else
            {
                MessageBox.Show("该学号不存在", "错误",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private float getAverage_1()
        {
            float ave = students.Average(t => t.Sdeg);
            return ave;
        }

        private void searchNo_1(TextBox tb)
        {
            if (tb.Text == "")
            {
                MessageBox.Show("请输入学号","错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string no = tb.Text;
                //Stu stu = students.Find(t => t.Sno == no);
                string search = "select * from stuinfo where Sno=" + no;
                MySqlCommand cmd = new MySqlCommand(search, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("学号:" + no + "\t" +
                                    "姓名:" + dr.GetString("Sname") + "\t" +
                                    "成绩:" + dr.GetString("Sdeg") + "\t" +
                                    "性别:" + dr.GetString("Ssex") + "\t" +
                                    "年级:" + dr.GetString("Sgrade"));
                }
                else
                {
                    MessageBox.Show("该学号不存在", "错误",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Error);
                }
                dr.Close();
            }
        }

        public void addRecord_1(bool isAdd, List<Stu> stu)
        {
            Stu last = stu.Last();
            string addHis;
            if (isAdd)
            {
                addHis = "添加了学号：" + last.Sno + ",姓名：" + last.Sname +
                        ",成绩：" + last.Sdeg + ",性别：" + last.Ssex +
                        ",年级：" + last.Sgrade + "的学生";
            }
            else
            {
                addHis = "删除了学号：" + last.Sno + ",姓名：" + last.Sname +
                        ",成绩：" + last.Sdeg + ",性别：" + last.Ssex +
                        ",年级：" + last.Sgrade + "的学生";
            }
            listBoxHistory.Items.Add(addHis);
        }


        #region 显示系统时间
        private void Form1_Load(object sender, EventArgs e) //首先在主窗体添加定时事件
        {
            this.timer1.Interval = 1000;//设置定时器触发间隔
            this.timer1.Start();    //启动定时器
            labelDate.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)    //接着在定时器触发事件中添加获取时间和显示时间函数
        {
            DateTime time = DateTime.Now;       //获取当前时间
            //labelDate.Font = new Font("宋体", 12);  //设置label1显示字体
            this.labelDate.Text = time.ToString(); //显示当前时间
        }

        #endregion

        #region 调用函数

        private void buttonAddSinfo_Click(object sender, EventArgs e)
        {
            setPanelUnvisible();
            this.panelAddSinfo.Visible = true;
        }

        private void buttonAddConfirm_Click(object sender, EventArgs e)
        {
            //addStudent();

            addStudent_1();

            //CreateTableStuInfo();


            /*try
            {
                //string sql = "CREATE TABLE " + "test" + "(Type char(20) NOT NULL,UNIQUE(Type))";
                string Type = "1";
                string ins = "insert into test(Type)values('" + Type + "')";
                MySqlCommand cmd = new MySqlCommand(ins, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch
            {
                MessageBox.Show("fail");
            }*/
        }

        private void buttonAllSinfo_Click(object sender, EventArgs e)
        {
            //display();
            display_1();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)   //限制输入为纯数字
        {
            if (!(e.KeyChar == '-' || e.KeyChar == '\b' || float.TryParse(((TextBox)sender).Text + e.KeyChar.ToString(), out float f)))
            {
                e.Handled = true;
            }
        }

        private void buttonDelSinfo_Click(object sender, EventArgs e)
        {
            setPanelUnvisible();
            //panel2.Visible = false;
            panelDelSinfo.Visible = true;
        }

        private void buttonDelConfirm_Click(object sender, EventArgs e)
        {
            //delStudent(textBoxDel);
            delStudent_1();
        }

        private void buttonGetSAverage_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("数据库中无学生");
            }
            else
            {
                int count = students.Count;
                MessageBox.Show("学生总数:" + count + "\t" + "平均分:" + string.Format("{0:F}", getAverage_1()));

            }
        }

        private void buttonSearchSinfo_Click(object sender, EventArgs e)
        {
            setPanelUnvisible();
            panelSearchSinfo.Visible = true;
        }

        private void buttonSearchConfirm_Click(object sender, EventArgs e)
        {
            //searchNo(textBoxSearch);
            searchNo_1(textBoxSearch);
        }

        #endregion

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

        private void CreateTableStuInfo(object sender, EventArgs e)
        {
            string ino = "12";
            string iname = "名字";
            string ideg = "44";
            string isex = "女";
            string igrade = "大二";
            string cretbl = "CREATE TABLE " + "StuInfo" + "(Sno int NOT NULL,Sname varchar(10)," +
                                                           "Sdeg float(16,2),Ssex char(1),Sgrade char(2)," +
                                                           "UNIQUE(Sno))";
            string initial = "insert into stuinfo(Sno,Sname,Sdeg,Ssex,Sgrade)" +
                            "values('" + ino + "','" + iname + "','" + ideg + "','" + isex + "','" + igrade + "')";
            try
            {
                MySqlCommand cmd = new MySqlCommand(cretbl, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (Exception)
            {
                Console.WriteLine("stuinfo已存在");
                //throw;
            }
        }

        private void IniStuList(object sender, EventArgs e)
        {
            string query = "select * from stuinfo";  //sql查询语句
            MySqlCommand cmd = new MySqlCommand(query, conn);    //将查询语句放进该数据库容器中
            MySqlDataReader dataReader = cmd.ExecuteReader();   //创建一个实例保存查询出来的结构
            students.Clear();
            if (dataReader.HasRows) //判断有没有读取到数据，实际是判断有没有读取到行数据，可以不写
            {
                while (dataReader.Read())
                {
                    //在数据集合加入数据，
                    students.Add(
                    //添加数据库数据到list
                    new Stu()
                    {
                        Sno = dataReader["Sno"].ToString(),
                        Sname = dataReader["Sname"].ToString(),
                        Sdeg = float.Parse(dataReader["Sdeg"].ToString()),
                        Ssex = dataReader["Ssex"].ToString(),
                        Sgrade = dataReader["Sgrade"].ToString(),
                    });
                }
                //dataReader.Close();
            }
            dataReader.Close();
        }

    }
}
namespace Sql_Student
{
    public partial class Stu
    {
        public string Sno { get; set; }
        public string Sname { get; set; }
        public float Sdeg { get; set; }
        public string Ssex { get; set; }
        public string Sgrade { get; set; }
    }
}
