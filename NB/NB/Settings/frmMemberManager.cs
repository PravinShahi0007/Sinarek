using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
namespace NB
{
    public partial class frmMemberManager : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool delete_;
        private bool edit_;

        public frmMemberManager()
        {
            InitializeComponent();
        }

        private void frmMemberManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.sinarekDataSet.gender);
            this.shiftTableAdapter.Fill(this.sinarekDataSet.shift);
            this.tipememberTableAdapter.Fill(this.sinarekDataSet.tipemember);
            this.memberTableAdapter.Fill(this.sinarekDataSet.member);
        }

        private void SetPermissionLevel()
        {
            helper.GetPermissions(this.GetType().Name, this.Tag.ToString(), out add_, out edit_, out delete_);

            radGroupBox1.Enabled = delete_;
            radGridView1.Columns["cmdView"].IsVisible = delete_;
            radGridView1.Columns["cmdDelete"].IsVisible = delete_;
        }
        private void lstTipeMember_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstTipeMember.SelectedValue != null)
            {
                memberBindingSource.Filter = "tipememberid = " + lstTipeMember.SelectedValue.ToString();
            }
        }

        private void btnAddTipe_Click(object sender, EventArgs e)
        {
            this.sinarekDataSet.tipemember.AddtipememberRow(rddTipeMember.Text);
            tipememberTableAdapter.Update(this.sinarekDataSet.tipemember);
            this.tipememberTableAdapter.Fill(this.sinarekDataSet.tipemember);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            memberTableAdapter.Update(this.sinarekDataSet.member);
            this.memberTableAdapter.Fill(this.sinarekDataSet.member);

            helper.NotifMessage("Member Changes Has Been Saved");
        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
           
        }

        private void radGridView1_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            e.Row.Cells["modifiedby"].Value = NBConfig.ValidUserName;
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            switch(cell.CommandButton.TextElement.Text.ToLower())
            {
                case "view":
                    frmViewMember frm = new frmViewMember(radGridView1.CurrentRow.Cells["MemberID"].Value.ToString());
                    frm.ShowDialog(this);
                    this.memberTableAdapter.Fill(this.sinarekDataSet.member);
                    break;
                case "delete":
                    string Nama = radGridView1.CurrentRow.Cells["Name"].Value.ToString();
                    DialogResult res = RadMessageBox.Show("<html>Member dengan nama " + Nama
                                                            + " akan dihapus.<br />Silahkan pilih [No] untuk membatalkan.</html>", "SMS - Verification"
                                                            , MessageBoxButtons.YesNo, RadMessageIcon.Question);
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.sinarekDataSet.member.Rows.Find(radGridView1.CurrentRow.Cells["memberid"].Value).Delete();
                        memberTableAdapter.Update(this.sinarekDataSet.member);
                        this.memberTableAdapter.Fill(this.sinarekDataSet.member);

                        helper.NotifMessage("Member dengan nama " + Nama + " Sudah Terhapus.");
                    }
                    break;
                case "register":
                    string userNama = radGridView1.CurrentRow.Cells["Name"].Value.ToString();
                    string NoAbsen = radGridView1.CurrentRow.Cells["fingerid"].Value.ToString();
                    try
                    {
                        //register username against their absen id
                        cFingerAbsen.RegisterUserName("196.10.0.200", 4370, 421288, 1, NoAbsen, userNama);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            memberTableAdapter.Insert(int.Parse(rddTipeMember.SelectedValue.ToString()), 1, dtpMasukKerja.Value
                                       , null, txtNama.Text, rddGender.SelectedValue.ToString(), "", "", "", 0, 0, 0, 0, 0, "", 1
                                       , DateTime.Now, NBConfig.ValidUserName, DateTime.Now
                                       , NBConfig.ValidUserName);
            this.memberTableAdapter.Fill(this.sinarekDataSet.member);

            helper.NotifMessage("New Member Has Been Added");
        }

    }
}
