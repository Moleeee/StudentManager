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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        LinkedList<Student> linkListStudent = new LinkedList<Student>();
        Student p = null;
        

        
        public Form1()
        {
            InitializeComponent();      //初始化窗体
            this.Load += Form1_Load;    //
            this.Load += readInfo;      //窗体载入时读取文件
            this.FormClosed += saveInfo;//窗体关闭后写入文件
        }

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

        private float getAverage()  //获取所有学生的平均分
        {
            float average =(Student.sumNum==0) ? 0 : (Student.sumDeg/Student.sumNum) ;
            string.Format("{0:F}", average);
            return average;
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

        private void buttonAddSinfo_Click(object sender, EventArgs e)
        {
            setPanelUnvisible();
            this.panelAddSinfo.Visible = true;
        }

        private void buttonAddConfirm_Click(object sender, EventArgs e)
        {
            addStudent();
        }

        private void buttonAllSinfo_Click(object sender, EventArgs e)
        {
            display();
            
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
            delStudent(textBoxDel);
        }
        
        private void buttonGetSAverage_Click(object sender, EventArgs e)
        {
            listBoxShow.Items.Clear();
            //Console.WriteLine("学生的平均分数:" + getAverage());
            listBoxShow.Items.Add("学生的平均分数:" + string.Format("{0:F}", getAverage()));
        }

        private void buttonSearchSinfo_Click(object sender, EventArgs e)
        {
            setPanelUnvisible();
            panelSearchSinfo.Visible = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchNo(textSearch);
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
