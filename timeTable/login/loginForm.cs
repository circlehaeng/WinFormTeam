using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "아이디를 입력해 주세요.") txtUsername.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") txtUsername.Text = "아이디를 입력해 주세요.";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "비밀번호를 입력해 주세요.")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "비밀번호를 입력해 주세요.";
                txtPassword.PasswordChar = '\0';
            }
        }

    }
}
