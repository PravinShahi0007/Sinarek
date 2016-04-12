using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Telerik.WinControls;

namespace Manager
{
    public partial class frmLogin : Telerik.WinControls.UI.RadForm
    {
        public frmLogin()
        {
            InitializeComponent();            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            object retPass = new object();
            //validate username and password
            string passToValidate = string.Empty;
            string userName = string.Empty;
            userName = lognameRadMaskedEditBox.Text.ToUpper();

            //Hardcoded password for admin
            if (userName == "ADMIN")
            {
                if (txtPassword.Text.ToLower() == "adm1n")
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    //record the time users authenticated
                    this.Close();
                    return;
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                    MessageBox.Show("Wrong username/password!");
                    lognameRadMaskedEditBox.Focus();
                    lognameRadMaskedEditBox.SelectAll();
                }
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                MessageBox.Show("Wrong username/password!");
                lognameRadMaskedEditBox.Focus();
                lognameRadMaskedEditBox.SelectAll();
            }
           
        }

        static string GetMD5Hash( string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            Close();            
        }

        private void lognameRadMaskedEditBox_Enter(object sender, EventArgs e)
        {
            lognameRadMaskedEditBox.SelectAll();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin.PerformClick();
            }
        }
        
    }
}
