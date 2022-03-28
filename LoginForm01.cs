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
    public partial class LoginForm01 : Form
    {
        public LoginForm01()
        {
            InitializeComponent();
        }

        public bool closeFlag=true;

        string acc01 = "2020";
        string pas01 = "bupt";

        private void Login(TextBox acc,TextBox pas)
        {
            if ((acc.Text == acc01) && (pas.Text == pas01))
            {
                //Form form1=new Form1();
                //form1.Show();
                closeFlag = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("账号密码错误");
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login(textBoxAccount,textBoxPassword);
        }
    }
}
