using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace LAB_5_OAIP
{
    public partial class ResetPasswordForm : Form
    {
        public int code = 0;
        public static string mail;
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void RandomCode()
        {
            Random random = new Random();
            code = random.Next(1000, 9999);
        }
        private void Codebutton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (code == Convert.ToInt32(CodetextBox.Text))
                {
                    this.Hide();
                    NewPasswordForm newPasswordForm = new NewPasswordForm();
                    newPasswordForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный код!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Неверный код!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Codebutton_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("aleshka.karnaukh@mail.ru", "Алексей Карнаух");
            MailAddress to = new MailAddress(EMtextBox.Text);
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Восстановление пароля";
            using (UserContainer db = new UserContainer())
            {
                foreach (User user in db.Users)
                {
                    if (EMtextBox.Text == user.Email)
                    {
                        RandomCode();
                        message.Body = "Код для восстановления пароля: " + code;
                    }
                }
            }
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential("aleshka.karnaukh@mail.ru", "karnauh.alex");
            smtp.EnableSsl = true;
            smtp.Send(message);
            mail = EMtextBox.Text;
        }
    }
}
