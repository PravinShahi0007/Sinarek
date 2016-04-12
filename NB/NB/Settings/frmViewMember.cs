using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;
namespace NB
{
    public partial class frmViewMember : Telerik.WinControls.UI.RadForm
    {
        private string memberid_;
        private bool bFirst_ = true;
        public frmViewMember(string MemberID)
        {
            InitializeComponent();
            memberid_ = MemberID;
        }
        
        private void frmViewMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.sinarekDataSet.gender);
            this.formulaTableAdapter.Fill(this.sinarekDataSet1.formula);
            this.tipepembayaranTableAdapter.Fill(this.sinarekDataSet1.tipepembayaran);
            this.tiperinciangajiTableAdapter.Fill(this.sinarekDataSet.tiperinciangaji);
            this.formulaTableAdapter.Fill(this.sinarekDataSet.formula);
            this.tipepembayaranTableAdapter.Fill(this.sinarekDataSet.tipepembayaran);
            this.tipepembayaranTableAdapter.Fill(this.sinarekDataSet.tipepembayaran);
            this.gajitemplateallTableAdapter.FillByMember(this.sinarekDataSet.gajitemplateall,int.Parse(memberid_));
            this.shiftTableAdapter.Fill(this.sinarekDataSet.shift);
            this.tipememberTableAdapter.Fill(this.sinarekDataSet.tipemember);
            this.memberTableAdapter.FillByID(this.sinarekDataSet.member,int.Parse(memberid_));
            LoadItem();
            if (bFirst_)
            {
                bFirst_ = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bFirst_ = true;
            SaveItem();
            this.memberTableAdapter.FillByID(this.sinarekDataSet.member, int.Parse(memberid_));
            helper.NotifMessage("Member Changes Has Been Saved.");
            LoadItem();
            bFirst_ = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveItem()
        {
            this.memberTableAdapter.UpdateMemberData(int.Parse(rddTipeMember.SelectedValue.ToString())
                , int.Parse(rddShift.SelectedValue.ToString())
                , dtpMasuk.Value
                , dtpKeluar.NullableValue
                , txtName.Text,rddGender.SelectedValue.ToString(), txtKTP.Text, txtAddress.Text, txtTLP.Text
                , (chkSopir.Checked ? 1 : 0), (chkKernet.Checked ? 1 : 0), (chkSales.Checked ? 1 : 0), (chkManager.Checked ? 1 : 0)
                , short.Parse(txtfingerid.Text), txtKeterangan.Text, (chkActive.Checked ? 1 : 0)
                , NBConfig.ValidUserName, int.Parse(memberid_));
            this.memberTableAdapter.FillByID(this.sinarekDataSet.member, int.Parse(memberid_));

        }

        private void LoadItem()
        {
            DateTime dt;
            DataRow row = this.sinarekDataSet.member.Rows[0];
            this.Text = "View Member " + row["name"].ToString();
            //load data for gaji template list
            sinarekDataSet.memberDataTable tbl = new NB.sinarekDataSet.memberDataTable();
            this.memberTableAdapter.Fill(tbl);

            rddName.DataSource = tbl.Select("TipeMemberID = " + row["tipememberid"].ToString() + " and MEmberID <> " + memberid_
                            + " and active = 1");


            rddTipeMember.SelectedValue = row["tipememberid"];
            rddShift.SelectedValue = row["shiftid"];
            rddGender.SelectedValue = row["gender"];
            dtpMasuk.Value = DateTime.Parse(row["masukkerja"].ToString());
            dtpCreated.Value = DateTime.Parse(row["created"].ToString());
            dtpModified.Value = DateTime.Parse(row["modified"].ToString());
            DateTime.TryParse(row["keluarkerja"].ToString(),out dt);
            dtpKeluar.NullableValue = dt;
            txtName.Value = row["name"];
            txtKTP.Value = row["KTP"];
            txtTLP.Value = row["contact"];
            txtAddress.Value = row["address"];
            txtfingerid.Value = row["fingerid"];
            txtKeterangan.Value = row["keterangan"];
            txtCreatedBy.Value = row["createdby"];
            txtModifiedBy.Value = row["modifiedby"];

            chkActive.ToggleState = (row["active"].ToString().Equals("True") ? ToggleState.On : ToggleState.Off);
            chkSopir.ToggleState = (row["sopir"].ToString().Equals("True") ? ToggleState.On : ToggleState.Off);
            chkKernet.ToggleState = (row["kernet"].ToString().Equals("True") ? ToggleState.On : ToggleState.Off);
            chkManager.ToggleState = (row["manager"].ToString().Equals("True") ? ToggleState.On : ToggleState.Off);
            chkSales.ToggleState = (row["sales"].ToString().Equals("True") ? ToggleState.On : ToggleState.Off);

        }

        private void chkActive_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                dtpKeluar.ResetText();
            }
        }

        private void chkActive_ToggleStateChanging(object sender, StateChangingEventArgs args)
        {
            if (args.NewValue == ToggleState.On && args.OldValue == ToggleState.Off & (!bFirst_))
            {
                DialogResult res = RadMessageBox.Show("<html>Mengaktifkan kembali pegawai menghapus tanggal keluar pegawai tersebut.<br /> Pilih [Cancel] untuk membatalkan.</html>"
                    , "SMS - Verification", MessageBoxButtons.OKCancel, RadMessageIcon.Question);
                if(res == System.Windows.Forms.DialogResult.Cancel)
                {
                    args.Cancel = true;            
                }
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.gajitemplateallTableAdapter.Insert(int.Parse(memberid_), int.Parse(rddTipeGaji.SelectedValue.ToString())
                    , decimal.Parse(txtUnit.Value.ToString()), decimal.Parse(txtValue.Value.ToString())
                    , short.Parse(rddFormula.SelectedValue.ToString()), short.Parse(rddTipePembayaran.SelectedValue.ToString()),1
                    , DateTime.Now);
                this.memberTableAdapter.UpdateModified(NBConfig.ValidUserName, int.Parse(memberid_));
                rddTipeGaji.ResetText();
                rddTipePembayaran.ResetText();
                rddFormula.ResetText();
                txtUnit.ResetText();
                txtValue.ResetText();
                rddTipeGaji.Focus();
                this.gajitemplateallTableAdapter.FillByMember(this.sinarekDataSet.gajitemplateall, int.Parse(memberid_));
            }
            catch (Exception ex)
            {
                helper.SysLog(this.GetType().Name, this.Text, ex.Message + ";Stack Trace :" + ex.StackTrace);
                helper.NotifMessage("Error menambah gaji template. Silahkan hubungi administrator");
            }
        }

        private void btnCopyFrom_Click(object sender, EventArgs e)
        {
            //Copy Gaji Template from other members selected from the dropdownlist
            DialogResult res = RadMessageBox.Show("This action will remove current template and replace it with selected members template.", "SMS - Verification"
                                                    , MessageBoxButtons.OKCancel, RadMessageIcon.Question);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                this.gajitemplateallTableAdapter.InsertGajiFrom(memberid_, int.Parse(rddName.SelectedValue.ToString()));
                helper.NotifMessage("Template has been updated");
                this.memberTableAdapter.UpdateModified(NBConfig.ValidUserName, int.Parse(memberid_));
                this.gajitemplateallTableAdapter.FillByMember(this.sinarekDataSet.gajitemplateall, int.Parse(memberid_));
            }
        }

        private void radGridView1_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            if (e.Row != null)
            {
                this.gajitemplateallTableAdapter.UpdateTemplate(decimal.Parse(e.Row.Cells["unit"].Value.ToString()), decimal.Parse(e.Row.Cells["Value"].Value.ToString())
                    , short.Parse(e.Row.Cells["CalculationID"].Value.ToString()), short.Parse(e.Row.Cells["TipePembayaranID"].Value.ToString())
                    , e.Row.Cells["active"].Value
                    , int.Parse(e.Row.Cells["TemplateID"].Value.ToString()));
                this.gajitemplateallTableAdapter.FillByMember(this.sinarekDataSet.gajitemplateall, int.Parse(memberid_));
            }
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            if (cell.CommandButton.Text.ToLower() == "delete")
            {
                this.gajitemplateallTableAdapter.DeleteTemplate(int.Parse(cell.RowInfo.Cells["templateid"].Value.ToString()));
                this.gajitemplateallTableAdapter.FillByMember(this.sinarekDataSet.gajitemplateall, int.Parse(memberid_));
            }
        }
    }
}
