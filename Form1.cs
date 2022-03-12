using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        LinkedList<Student> linkListStudent = new LinkedList<Student>();
        Student p = null;
        

        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void setPanelUnvisible()
        {
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void addStudent()
        {
            p = new Student(textBox1,textBox2,textBox3);
            linkListStudent.AddLast(p);

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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setPanelUnvisible();
            panel2.Visible = true;
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
            //setPanelUnvisible();
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
            }
            catch
            {
                Console.WriteLine("failed");
            }
        }
        
        public void showInfo()
        {
            Console.WriteLine(no +"  "+ name+"  " + deg);
        }
    }
}
