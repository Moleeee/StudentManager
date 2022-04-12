using System;
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


        LinkedList<Student> linkListStudent = new LinkedList<Student>();
        Student p = null;

        List<Stu> students = new List<Stu>(); //新建一个数据集合，实例化
        
        public Form1()
        {
            InitializeComponent();      //初始化窗体
            //this.Load += readInfo;      //窗体载入时读取文件
            this.Load += Form1_Load;
            this.Load += OpenMySQL;     //窗体载入时打开数据库连接
            this.Load += IniStuList;
            //this.FormClosed += saveInfo;//窗体关闭后写入文件
            this.FormClosed += CloseMySQL;//窗体关闭后关闭数据库连接
        }

        #region 连接MySQL
        static string connectStr = "server=localhost;" +
                "port=3307;" +
                "user=root;" +
                "password=dyinglight77...; " +
                "database=Admin;";
        //连接MySQL
        MySqlConnection conn = new MySqlConnection(connectStr);
        #endregion

        public void saveInfo(object sender, EventArgs e)    //在文件中写入学生信息
        {
            StreamWriter sw=new StreamWriter("D:/studentInfo.txt");
            LinkedListNode<Student> prev = linkListStudent.First;
            //sw.WriteLine("123456");
            while (prev != null)
            {
                sw.WriteLine(prev.Value.no + "\r\n" + prev.Value.name + "\r\n" + prev.Value.deg
                            + "\r\n" + prev.Value.sex + "\r\n" + prev.Value.grade);
                prev = prev.Next;
            }
            sw.Close();
            
        }

        public void readInfo(object sender, EventArgs e)    //从文件中读取学生信息
        {
            StreamReader sr = new StreamReader("D:/studentInfo.txt");
            //Console.WriteLine(sr.ReadToEnd());
            string line;
            string[] array=new string[200];
            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                
                Console.WriteLine(line);
                array[i] = line;
                i++;
            }

            int j = 0;
            while (array[j] != null)
            {
                Console.WriteLine("array"+array[j]);
                j++;
            }

            for (int n = 0; array[n] != null; n = n + 5)
            {
                p=new Student(true, array[n], array[n + 1], array[n + 2],array[n+3],array[n+4]);
                linkListStudent.AddLast(p);
                //addRecord(true, linkListStudent.Last);
            }
            listBoxHistory.Items.Add("文件读取成功");

            /*while (line != null)
            {
                p = new Student(true, sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
                Console.WriteLine("test"+p.deg);
            }
            //Console.WriteLine(sr.Read());*/

            sr.Close();
        }

        private void setPanelUnvisible()    //隐藏面板，用于不同面板切换
        {
            panelAddSinfo.Visible = false;
            panelSearchSinfo.Visible = false;
            panelDelSinfo.Visible = false;
        }

        private bool isNoDifferent(TextBox no)  //判断学号是否重复
        {
            LinkedListNode<Student> prev = linkListStudent.First;
            int sameNum = 0;
            while (prev != null)
            {
                if (prev.Value.no == no.Text)
                {
                    sameNum++;
                    break;
                }
                prev = prev.Next;
            }
            return (sameNum == 0) ? true : false;
        }

        private void addStudent()   //添加学生
        {
            LinkedListNode<Student> prev = linkListStudent.First;
            if (isNoDifferent(textBoxSno))
            {
                p = new Student(textBoxSno,textBoxSname,textBoxSdeg,comboBoxSsex,comboBoxSgrade);
                linkListStudent.AddLast(p);
                addRecord(true,linkListStudent.Last);
            }
            else
            {
                Console.WriteLine("学号重复，添加失败");
            }
            
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
                Console.WriteLine("学号重复");
            }
        }

        private void display()   //显示所有学生信息
        {
            LinkedListNode<Student> linkNodeStudent = linkListStudent.First;
            if (Student.sumNum == 0)
            {
                //Console.WriteLine("当前无学生");
                listBoxShow.Items.Clear();
                listBoxShow.Items.Add("当前无学生");
            }
            else
            {
                //Console.WriteLine("当前学生总数为:"+Student.sumNum);
                listBoxShow.Items.Clear();
                listBoxShow.Items.Add("当前学生总数为:" + Student.sumNum);
                listBoxShow.Items.Add("no"+"\t"+"name"+"\t"+"deg"+"\t"+"sex"+" \t"+"grade");
                //linkNodeStudent.Value.showInfo();
                while (linkNodeStudent!= null)
                {
                    var value = linkNodeStudent.Value;
                    linkNodeStudent.Value.showInfo();
                    listBoxShow.Items.Add(value.no+ "\t" + value.name+ "\t" + value.deg + "\t"
                                        + value.sex + "\t" + value.grade); 
                    linkNodeStudent = linkNodeStudent.Next;
                    
                }
            }
            
        }

        private void display_1()
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
                        Sno= dataReader["Sno"].ToString(),
                        Sname=dataReader["Sname"].ToString(),
                        Sdeg = float.Parse(dataReader["Sdeg"].ToString()),
                        Ssex=dataReader["Ssex"].ToString(),
                        Sgrade=dataReader["Sgrade"].ToString(),
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
        
        private void delStudent(TextBox delNo)  //删除指定学号的学生
        {
            LinkedListNode<Student> linkNodeStudent = linkListStudent.First;

            if (Student.sumNum == 0)
            {
                Console.WriteLine("当前无学生");
            }
            else
            {
                while (linkNodeStudent != null)
                {
                    if (linkNodeStudent.Value.no == delNo.Text)
                    {
                        Student.sumDeg -= linkNodeStudent.Value.deg;
                        Student.sumNum--;
                        
                        addRecord(false,linkNodeStudent);
                        linkListStudent.Remove(linkNodeStudent);
                        Console.WriteLine("删除成功");
                    }

                    linkNodeStudent = linkNodeStudent.Next;
                }
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

        private float getAverage()  //获取所有学生的平均分
        {
            float average =(Student.sumNum==0) ? 0 : (Student.sumDeg/Student.sumNum) ;
            string.Format("{0:F}", average);
            return average;
        }

        private float getAverage_1()
        {
            float ave = students.Average(t => t.Sdeg);
            return ave;
        }

        private void searchNo(TextBox textBox)
        {
            if (Student.sumNum == 0)
            {
                listBoxShow.Items.Add("当前无学生");
            }
            else
            {
                LinkedListNode<Student> prev = linkListStudent.First;
                while (prev != null)
                {
                    if (textBox.Text == prev.Value.no)
                    {
                        var value = prev.Value;
                        listBoxHistory.Items.Add("查找学号为"+textBox.Text+"的学生");
                        listBoxShow.Items.Clear();
                        listBoxShow.Items.Add("查找结果如下：");
                        listBoxShow.Items.Add("no:" + value.no +"\t"+ "name:" + value.name +"\t"+ "deg:" + value.deg +"\t"+
                                        "sex:" + value.sex + "\t"+"grade:" + value.grade);
                    }
                    prev = prev.Next;
                }
            }
        }

        private void searchNo_1(TextBox tb)
        {
            string no = tb.Text;
            //Stu stu = students.Find(t => t.Sno == no);
            string search = "select * from stuinfo where Sno=" + no;
            MySqlCommand cmd = new MySqlCommand(search, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("学号:"+no+ "\t" +
                                "姓名:" +dr.GetString("Sname")+ "\t" +
                                "成绩:" +dr.GetString("Sdeg")+ "\t" +
                                "性别:" +dr.GetString("Ssex")+ "\t" +
                                "年级:" +dr.GetString("Sgrade"));
            }
            else
            {
                MessageBox.Show("该学号不存在", "错误",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Error);
            }
            dr.Close();
        }

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

        public void addRecord(bool isAdd,LinkedListNode<Student> node)//为操作添加历史记录
        {
            if (isAdd)
            {
                /*this.listBox1.Items.Add("添加了学号为"+this.textBox1.Text+
                    "  姓名为"+this.textBox2.Text+"的学生");*/
                this.listBoxHistory.Items.Add(labelDate.Text+"添加了学号为" + node.Value.no +
                    ",姓名为" + node.Value.name + "的学生");
                
            }
            else
            {
                this.listBoxHistory.Items.Add(labelDate.Text+"删除了学号为" + node.Value.no +
                    ",姓名为" + node.Value.name + "的学生");
            }
        }

        public void addRecord_1(bool isAdd,List<Stu> stu)
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
                addHis= "删除了学号：" + last.Sno + ",姓名：" + last.Sname +
                        ",成绩：" + last.Sdeg + ",性别：" + last.Ssex +
                        ",年级：" + last.Sgrade + "的学生";
            }
            listBoxHistory.Items.Add(addHis);
        }

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
            /*listBoxShow.Items.Clear();
            //Console.WriteLine("学生的平均分数:" + getAverage());
            listBoxShow.Items.Add("学生的平均分数:" + string.Format("{0:F}", getAverage()));*/
            int count = students.Count;
            MessageBox.Show("学生总数:"+count+"\t"+"平均分:"+string.Format("{0:F}",getAverage_1()));
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

        private void CreateTableStuInfo()
        {
            string cretbl = "CREATE TABLE " + "StuInfo" + "(Sno int NOT NULL,Sname varchar(10)," +
                                                           "Sdeg float(16,2),Ssex char(1),Sgrade char(2)," +
                                                           "UNIQUE(Sno))";
            try
            {
                MySqlCommand cmd = new MySqlCommand(cretbl, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (Exception)
            {
                MessageBox.Show("failed");
                //throw;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“adminDataSet.stuinfo”中。您可以根据需要移动或删除它。
            this.stuinfoTableAdapter.Fill(this.adminDataSet.stuinfo);

        }

        private void SetDataSource()
        {
            dataGridViewShow.DataSource = stuinfoBindingSource.DataSource;
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
                dataReader.Close();

            }
        }

    }
    public class Student
    {
        public string no;
        public string name;
        public float deg;
        public string sex;
        public string grade;

        public static int sumNum=0;
        public static float sumDeg=0;
        
        
        public Student(TextBox a, TextBox b, TextBox c,ComboBox d,ComboBox e)   //构造函数1
        {
            try
            {
                no = a.Text;
                name = b.Text;
                deg = float.Parse(c.Text);
                sex = d.Text;
                grade = e.Text;

                sumNum++;
                sumDeg += deg;
                
                Console.WriteLine("添加成功");
                a.Text = null;
                b.Text = null;
                c.Text = null;
                d.Text = null;
                e.Text = null;
            }
            catch
            {
                Console.WriteLine("failed");
            }
        }
        
        public Student(bool l,String a,String b,String c,String d,String e)     //构造函数2
        {
            no = a;
            name = b;
            deg = float.Parse(c);
            sex = d;
            grade = e;

            sumNum++;
            sumDeg += deg;
            Console.WriteLine("success");
        }

        public void showInfo()  //展示学生信息
        {
            Console.WriteLine(no +"  "+ name+"  " + deg+" "+ sex +" " + grade);
            
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
