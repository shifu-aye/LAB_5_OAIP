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
    public partial class RegisterForm1 : Form
    {
        public RegisterForm1()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            using (var db = new UserContainer())
            {
                User user = new User()
                {
                    Login = LogTextBox.Text,
                    Password = GetHashString(PasswordTextBox.Text),
                    Email = EMailTextBox.Text,
                    Role = comboBoxRole.Text
                };
                db.Users.Add(user);
                db.SaveChanges();
                if (MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    this.Hide();
                    LogForm logForm = new LogForm();
                    logForm.ShowDialog();
                    this.Close();
                }
            }
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

        private void RegcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RegcheckBox.Checked == false)
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }
    }
}
