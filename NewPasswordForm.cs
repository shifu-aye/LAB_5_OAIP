using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Security.Cryptography;

namespace LAB_5_OAIP
{
    public partial class NewPasswordForm : Form
    {
        public NewPasswordForm()
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

        private void Donebutton_Click(object sender, EventArgs e)
        {
            using (UserContainer db = new UserContainer())
            {
                
                foreach (User user in db.Users)
                {
                    if (user.Email == ResetPasswordForm.mail)
                    {
                        user.Password = GetHashString(NewPasswordtextBox.Text);
                    }
                }
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
    }
}
