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
            InitializeComponent();
            this.Load += Form1_Load;
            
        }

        public void saveInfo()
        {
            StreamWriter sw=new StreamWriter("D:/studentInfo.txt");
            LinkedListNode<Student> prev = linkListStudent.First;
            //sw.WriteLine("123456");
            while (prev != null)
            {
                sw.WriteLine(prev.Value.no + "\r\n" + prev.Value.name + "\r\n" + prev.Value.deg);
                prev = prev.Next;
            }
            sw.Close();
            
        }

        public void readInfo()
        {
            StreamReader sr = new StreamReader("D:/studentInfo.txt");
            //Console.WriteLine(sr.ReadToEnd());
            string line;
            string[] array=new string[102];
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

            for (int n = 0; array[n] != null; n = n + 3)
            {
                p=new Student(true, array[n], array[n + 1], array[n + 2]);
                linkListStudent.AddLast(p);
                addRecord(true, linkListStudent.Last);
            }


            /*while (line != null)
            {
                p = new Student(true, sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
                Console.WriteLine("test"+p.deg);
            }
            //Console.WriteLine(sr.Read());*/

            sr.Close();
        }

        private void setPanelUnvisible()
        {
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void addStudent()
        {
            p = new Student(textBox1,textBox2,textBox3);
            linkListStudent.AddLast(p);
            addRecord(true,linkListStudent.Last);
        }

        private void display()
        {
            LinkedListNode<Student> linkNodeStudent = linkListStudent.First;
            if (Student.sumNum == 0)
            {
                Console.WriteLine("当前无学生");
            }
            else
            {
                Console.WriteLine("当前学生总数为:"+Student.sumNum);
                linkNodeStudent.Value.showInfo();
                while (linkNodeStudent.Next != null)
                {

                    linkNodeStudent = linkNodeStudent.Next;
                    linkNodeStudent.Value.showInfo();
                }
            }
            
        }
        
        private void delStudent(TextBox delNo)
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

        private float getAverage()
        {
            float average =(Student.sumNum==0) ? 0 : (Student.sumDeg/Student.sumNum) ;
            return (average);
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

        private void addRecord(bool isAdd,LinkedListNode<Student> node)//为操作添加历史记录
        {
            if (isAdd)
            {
                /*this.listBox1.Items.Add("添加了学号为"+this.textBox1.Text+
                    "  姓名为"+this.textBox2.Text+"的学生");*/
                this.listBox1.Items.Add(labelDate.Text+"添加了学号为" + node.Value.no +
                    ",姓名为" + node.Value.name + "的学生");
            }
            else
            {
                this.listBox1.Items.Add(labelDate.Text+"删除了学号为" + node.Value.no +
                    ",姓名为" + node.Value.name + "的学生");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setPanelUnvisible();
            this.panel1.Visible = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addStudent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display();
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '-' || e.KeyChar == '\b' || float.TryParse(((TextBox)sender).Text + e.KeyChar.ToString(), out float f)))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setPanelUnvisible();
            //panel2.Visible = false;
            panel3.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            delStudent(textBox4);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("学生的平均分数:" + getAverage());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            saveInfo();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            readInfo();
        }
    }
    public class Student
    {
        public string no;
        public string name;
        public float deg;

        public static int sumNum=0;
        public static float sumDeg=0;
        
        
        public Student(TextBox a, TextBox b, TextBox c) 
        {
            try
            {
                no = a.Text;
                name = b.Text;
                deg = float.Parse(c.Text);

                sumNum++;
                sumDeg += deg;
                Console.WriteLine("添加成功");
                a.Text = null;
                b.Text = null;
                c.Text = null;
            }
            catch
            {
                Console.WriteLine("failed");
            }
        }
        
        public Student(bool l,String a,String b,String c)
        {
            no = a;
            name = b;
            deg = float.Parse(c);

            sumNum++;
            sumDeg += deg;
            Console.WriteLine("success");
        }

        public void showInfo()
        {
            Console.WriteLine(no +"  "+ name+"  " + deg);
        }
    }
}
