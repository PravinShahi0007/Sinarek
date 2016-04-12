using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Manager
{
    public partial class sfrmManageNewUser : Telerik.WinControls.UI.ShapedForm
    {
        public sfrmManageNewUser()
        {
            InitializeComponent();
        }

        private void sfrmManageUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fingermachDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.fingermachDataSet.staff);
            // TODO: This line of code loads data into the 'fingermachDataSet.auth' table. You can move, or remove it, as needed.
            this.authTableAdapter.Fill(this.fingermachDataSet.auth);

            //RefreshMenuGrid();
        }

        private void rddStaff_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddStaff.SelectedValue != null)
            {
                this.fingermachDataSet.pSelectMenuAuth.Clear();
                this.pSelectMenuAuthTableAdapter.Fill(this.fingermachDataSet.pSelectMenuAuth, int.Parse(rddStaff.SelectedValue.ToString()));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
             
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtUser.Text)) && (!string.IsNullOrEmpty(txtPwd.Text)))
            {
                staffTableAdapter.InsertUser(txtPwd.Value.ToString(), txtUser.Text.ToUpper(), 0);
                int id = int.Parse(staffTableAdapter.GetLatest().ToString());

                //create permission based on selected user
                authuserTableAdapter.InsertPermissionByUser(id.ToString(), int.Parse(rddStaff.SelectedValue.ToString()));
                RadMessageBox.Show("User has been created.");
                txtUser.ResetText();
                txtPwd.ResetText();
                this.staffTableAdapter.Fill(this.fingermachDataSet.staff);
            }
        }


    }
}
