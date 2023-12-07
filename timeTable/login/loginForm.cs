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
        private void Button1_click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "123" && password == "123")
            {
                ShowTimetableForm();
            }
            else
            {
                MessageBox.Show("로그인 실패. 아이디와 비밀번호를 확인하세요.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowTimetableForm()
        {
            Form1 timetableForm = new Form1();

            timetableForm.Show();

            this.Hide();
        }

    }
}
