using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace LAB_5_OAIP
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }
        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            using (UserContainer db = new UserContainer())
            {
                foreach (var i in db.Users)
                {
                    Console.WriteLine("user.login: " + i.Login);
                    Console.WriteLine("user.paasword: " + i.Password);
                    Console.WriteLine("LTextBox.Text (введеный логин): " + LTextBox.Text);
                    Console.WriteLine("etHashString(PTextBox.Text) (введеный пароль): " + GetHashString(PTextBox.Text));
                    if (i.Login == LTextBox.Text && i.Password == GetHashString(PTextBox.Text))
                    {
                        this.Hide();
                        WelcomeForm welcomeForm = new WelcomeForm();
                        welcomeForm.ShowDialog();
                        this.Close();
                        return;
                    }
                }
                if (MessageBox.Show("Опа, повався:D. Ты не зарегестрирован!", "ВХОД ПРЕРВАН!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
            }
        }

        private void linkLabelRegist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Hide();
                RegisterForm1 registerForm = new RegisterForm1();
                registerForm.ShowDialog();
                this.Close();
            }
            
        }

        private void linkLabelPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Hide();
                ResetPasswordForm resetPassword = new ResetPasswordForm();
                resetPassword.ShowDialog();
                this.Close();
            }
        }

        private void PTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (LogcheckBox1.Checked == false)
            {
                PTextBox.PasswordChar = '\0';
            }
            else
            {
                PTextBox.PasswordChar = '*';
            }
        }
    }
}
