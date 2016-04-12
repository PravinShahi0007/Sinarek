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
    public partial class sfrmManageUser : Telerik.WinControls.UI.ShapedForm
    {
        public sfrmManageUser()
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
            //set the initial view of form
            grpPermission.Enabled = false;
            grpReset.Enabled = false;
            grpIndividual.Enabled = false;
        }

        private void rddStaff_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddStaff.SelectedValue != null)
            {
                this.fingermachDataSet.pSelectMenuAuth.Clear();
                this.pSelectMenuAuthTableAdapter.Fill(this.fingermachDataSet.pSelectMenuAuth, int.Parse(rddStaff.SelectedValue.ToString()));
                radGridView1.Refresh();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void RefreshMenuGrid()
        {
            this.fingermachDataSet.pSelectMenuAuth.Clear();
            this.pSelectMenuAuthTableAdapter.Fill(this.fingermachDataSet.pSelectMenuAuth, int.Parse(rddStaff.SelectedValue.ToString()));
            //foreach (GridViewRowInfo row in radGridView1.Rows)
            //{
            //    if (row.HasChildRows())
            //    {
            //        row.IsExpanded = true;
            //    }
            //}
        }
        private void UpdateInsertPermission(GridViewRowInfo row)
        {
            if (row != null)
            {
                try
                {
                    int selectedIndex = -1;
                    selectedIndex = row.Index;
                    int add, edit, view, delete;
                    int authid, userid, authuserid;

                    add = (string.IsNullOrEmpty(row.Cells["add"].Value.ToString()) ? 0 : int.Parse(row.Cells["add"].Value.ToString()));
                    edit = (string.IsNullOrEmpty(row.Cells["edit"].Value.ToString()) ? 0 : int.Parse(row.Cells["edit"].Value.ToString()));
                    view = (string.IsNullOrEmpty(row.Cells["view"].Value.ToString()) ? 0 : int.Parse(row.Cells["view"].Value.ToString()));
                    delete = (string.IsNullOrEmpty(row.Cells["delete"].Value.ToString()) ? 0 : int.Parse(row.Cells["delete"].Value.ToString()));
                    authid = int.Parse(row.Cells["authid"].Value.ToString());
                    userid = int.Parse(rddStaff.SelectedValue.ToString());
                    authuserid = (string.IsNullOrEmpty(row.Cells["authuserid"].Value.ToString()) ? 0 : int.Parse(row.Cells["authuserid"].Value.ToString()));
                    //Check if it is an update or an insert

                    using (fingermachDataSetTableAdapters.authuserTableAdapter tbl = new fingermachDataSetTableAdapters.authuserTableAdapter())
                    {
                        if (authuserid == 0)
                        {
                            tbl.pInsertPermission(authid, userid, add, edit, view, delete);
                        }
                        else
                        {
                            tbl.pUpdatePermission(authuserid, authid, userid, add, edit, view, delete);
                        }
                    }

                    radGridView1.Rows[selectedIndex].IsSelected = true;
                    radGridView1.CurrentRow = radGridView1.Rows[selectedIndex];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            UpdateInsertPermission(e.Row);
            RefreshMenuGrid();                       
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (btnChange.Tag.ToString() == "start")
            {
                btnChange.Tag = "end";
                btnChange.Text = "End &Change";
                radGridView1.AllowEditRow = true;
                radGridView2.AllowEditRow = true;
                radGridView1.ReadOnly = false;
                radGridView2.ReadOnly = false;
                rddStaff.Enabled = false;

                grpPermission.Enabled = true;
                grpReset.Enabled = true;
                grpIndividual.Enabled = true;


            }
            else
            {
                btnChange.Tag = "start";
                btnChange.Text = "&Change Permission";
                radGridView1.AllowEditRow = false;
                radGridView2.AllowEditRow = false;
                radGridView1.ReadOnly = true;
                radGridView2.ReadOnly = true;
                rddStaff.Enabled = true;

                grpPermission.Enabled = false;
                grpReset.Enabled = false;
                grpIndividual.Enabled = false;
            }
        }

        private void radGridView1_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            
            pSelectMenuAuthBindingSource1.Filter = "parentid =  " + e.CurrentRow.Cells["authid"].Value.ToString();
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            string command;
            int selectedIndex = -1;
            int add, edit, view, delete;
            int authid, userid, authuserid;
            GridViewRowInfo row = radGridView1.CurrentRow;
            selectedIndex = row.Index;
            add = 0;
            edit = 0;
            view = 0;
            delete = 0;
            authid = int.Parse(row.Cells["authid"].Value.ToString());
            userid = int.Parse(rddStaff.SelectedValue.ToString());
            authuserid = (string.IsNullOrEmpty(row.Cells["authuserid"].Value.ToString()) ? 0 : int.Parse(row.Cells["authuserid"].Value.ToString()));

            GridCommandCellElement cell = (GridCommandCellElement)sender;
            command = cell.CommandButton.Text;
            //GridViewCommandColumn col = (GridViewCommandColumn)sender;
            switch (command.ToLower())
            {
                case "allow":
                    add = 1;
                    edit = 1;
                    view = 1;
                    delete = 1;
                    break;
                case "deny":
                    add = 0;
                    edit = 0;
                    view = 0;
                    delete = 0;
                    break;
                case "dup":
                    add = (string.IsNullOrEmpty(row.Cells["add"].Value.ToString()) ? 0 : int.Parse(row.Cells["add"].Value.ToString()));
                    edit = (string.IsNullOrEmpty(row.Cells["edit"].Value.ToString()) ? 0 : int.Parse(row.Cells["edit"].Value.ToString()));
                    view = (string.IsNullOrEmpty(row.Cells["view"].Value.ToString()) ? 0 : int.Parse(row.Cells["view"].Value.ToString()));
                    delete = (string.IsNullOrEmpty(row.Cells["delete"].Value.ToString()) ? 0 : int.Parse(row.Cells["delete"].Value.ToString()));
                    break;
            }
            try
            {
                //Check if it is an update or an insert
                using (fingermachDataSetTableAdapters.authuserTableAdapter tbl = new fingermachDataSetTableAdapters.authuserTableAdapter())
                {
                    if (authuserid == 0)
                    {
                        tbl.pInsertPermission(authid, userid, add, edit, view, delete);
                    }
                    else
                    {
                        tbl.pUpdatePermission(authuserid, authid, userid, add, edit, view, delete);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            RefreshMenuGrid();
            radGridView1.Rows[selectedIndex].IsSelected = true;
            radGridView1.CurrentRow = radGridView1.Rows[selectedIndex];
        }

        private void radGridView2_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            UpdateInsertPermission(e.Row);
            RefreshMenuGrid();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtUser.Text)) && (!string.IsNullOrEmpty(txtPwd.Text)))
            {
                staffTableAdapter.InsertUser(txtPwd.Value.ToString(), txtUser.Text.ToUpper(), 0);
                RadMessageBox.Show("User has been created.");
                txtUser.ResetText();
                txtPwd.ResetText();
                this.staffTableAdapter.Fill(this.fingermachDataSet.staff);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtReset.Text))
            {
                DialogResult res = RadMessageBox.Show("Yakin akan  mengubah password user yg terpilih?", "SMS - Verification", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    using (fingermachDataSetTableAdapters.staffTableAdapter tbl = new fingermachDataSetTableAdapters.staffTableAdapter())
                    {
                        tbl.UpdatePassword(txtReset.Text, int.Parse(rddStaff.SelectedValue.ToString()));
                    }
                    RadMessageBox.Show("Password has been changed successfully");
                    txtReset.ResetText();
                }
                else
                {
                    //do nothing
                }
            }
            else
            {
                RadMessageBox.Show("New password is empty! Password has not been changed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult s = RadMessageBox.Show("Are you sure you want to delete "+ rddStaff.SelectedText + "?","Confirmation",MessageBoxButtons.YesNo);

            if (s == System.Windows.Forms.DialogResult.Yes)
            {
                using (fingermachDataSetTableAdapters.staffTableAdapter tbl = new fingermachDataSetTableAdapters.staffTableAdapter())
                {
                    tbl.DeleteUser(int.Parse(rddStaff.SelectedValue.ToString()));
                }
                RadMessageBox.Show("User has been deleted");
                btnChange.Tag = "start";
                btnChange.Text = "&Change Permission";
                radGridView1.AllowEditRow = false;
                radGridView2.AllowEditRow = false;
                radGridView1.ReadOnly = true;
                radGridView2.ReadOnly = true;
                rddStaff.Enabled = true;

                grpPermission.Enabled = false;
                grpReset.Enabled = false;
                grpIndividual.Enabled = false;
            }
            this.staffTableAdapter.Fill(this.fingermachDataSet.staff);

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            using (fingermachDataSetTableAdapters.QueriesTableAdapter tbl = new fingermachDataSetTableAdapters.QueriesTableAdapter())
            {
                tbl.pCopyPermissionByUser(int.Parse(rddStaff.SelectedValue.ToString()), int.Parse(rddCopyFrom.SelectedValue.ToString()));
            }
            RadMessageBox.Show("Permission has been copied");
            RefreshMenuGrid();
        }


    }
}
