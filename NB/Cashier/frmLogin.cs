using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Reflection;

using Telerik.WinControls;
using Telerik.WinControls.UI;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Cashier
{
    public partial class frmLogin : Telerik.WinControls.UI.RadForm
    {
        public frmLogin()
        {
            InitializeComponent();
            ThemeResolutionService.ApplicationThemeName = NBConfig.THEMENAME;
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fingermachDataSet);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.staffTableAdapter.Fill(this.fingermachDataSet.staff);
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
                    NBConfig.BLoggedIn = true;
                    NBConfig.LoginTime = DateTime.Now;
                    NBConfig.ValidUserName = userName;
                    NBConfig.RetrieveGMID();
                    NBConfig.RetrieveGBID();
                    NBConfig.ValidUserID = -1;
                    ////record the time users authenticated
                    //this.Close();
                    //return;
                    frmMain frm = new frmMain();
                    frm.MaximizeBox = false;
                    frm.WindowState = FormWindowState.Maximized;
                    this.Close();
                    frm.Show();
                }
            }
            try
            {
                passToValidate = staffTableAdapter.RetrievePassword(lognameRadMaskedEditBox.Text.ToUpper()).ToString();
                if (passToValidate == GetMD5Hash(txtPassword.Text))
                {
                    NBConfig.ValidUserID = int.Parse(staffTableAdapter.RetrieveUserID(userName).ToString());
                    NBConfig.BLoggedIn = true;
                    NBConfig.LoginTime = DateTime.Now;
                    NBConfig.ValidUserName = userName;
                    NBConfig.RetrieveGMID();
                    NBConfig.RetrieveGBID();
                    //Also get the ID of the current week's date
                    //record the time users authenticated               
                    helper.SysLog(this.GetType().Name, NBConfig.ValidUserName, "Login");
                    //this.Close();
                    //return;
                }
                else
                {
                    MessageBox.Show("Wrong username/password!","SMS - Error Notification");
                    lognameRadMaskedEditBox.Focus();
                    lognameRadMaskedEditBox.SelectAll();
                }
            }
            catch (MySqlException mex)
            {
                helper.ErrorMessage("Tidak ada koneksi ke Database. Segera hubungi administrator." + mex.StackTrace);
            }
            catch (Exception ex)
            {
                helper.ErrorMessage("Ada masalah untuk login ke system. Segera hubungi administrator.");
                lognameRadMaskedEditBox.Focus();
                lognameRadMaskedEditBox.SelectAll();
                //MessageBox.Show(ex.Message);
            }
            this.Close();
            
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
            Application.Exit();
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
