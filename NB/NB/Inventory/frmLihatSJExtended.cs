using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Management;

using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using Telerik.Reporting;
using Telerik.Reporting.Processing;

namespace NB
{
    public partial class frmLihatSJExtended : Telerik.WinControls.UI.RadForm
    {
        private string statusName_ = string.Empty;
        private bool add_;
        private bool edit_;
        private bool delete_;
        public frmLihatSJExtended()
            : this("Completed")
        {

        }
        public frmLihatSJExtended(string statusName)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(statusName))
            {
                statusName_ = statusName;
            }
            else
            {
                statusName_ = "Completed";
            }
            add_ = false;
            edit_ = false;
            delete_ = false;
        }

        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            helper.GetPermissions(frmName, this.Tag.ToString(), out add_, out edit_, out delete_);

            radGroupBox1.Visible = (add_||edit_ || delete_);
            btnBatal.Enabled = (delete_);
            btnEdit.Enabled = (edit_ || delete_);

            if (statusName_.ToLower() == "batal")
            {
                btnBatal.Visible = false;
                btnEdit.Visible = false;
            }

            radGridView1.ReadOnly = delete_;
            radGridView1.AllowEditRow = delete_;
            radGridView1.MasterTemplate.ReadOnly = true;
            gridViewTemplate1.AllowEditRow = delete_;
            gridViewTemplate1.ReadOnly = (!delete_);

            btnPrint.Enabled = (add_);

        }

        private void frmLihatSJ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.kota' table. You can move, or remove it, as needed.
            this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
            InitializeButtons();
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
             if (statusName_.ToLower() == "batal")
            {
                vlogproductBindingSource.Filter = "category = 0 and statusid = 3";
                this.Text += " " + statusName_;
            }
            else
            {
                vlogproductBindingSource.Filter = "category = 0 and statusid = 4";
            }
            rbtnTanggal.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
       }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTanggal.Value != null)
            {
                this.vlogproductTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproduct, dtpTanggal.Value);
                this.vlogproductdetailTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproductdetail, dtpTanggal.Value);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Only allow editing for custtypetoid 1 to 6
            if (radGridView1.SelectedRows[0].Cells["NoSJ"] != null)
            {
                int typeid = int.Parse(radGridView1.SelectedRows[0].Cells["TransTypeID"].Value.ToString());
                if (typeid >= 1 && typeid <= 6)
                {
                    //Log Editing
                    helper.SysLog(this.GetType().Name, this.Text, "Edit :" + lblLogID.Text);

                    string noSJ = radGridView1.SelectedRows[0].Cells["NoSJ"].Value.ToString();
                    DataRowView data = (DataRowView)radGridView1.SelectedRows[0].DataBoundItem;
                    frmEditSJ frm = new frmEditSJ(data.Row);
                    frm.ShowDialog(this);

                    this.vlogproductTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproduct, dtpTanggal.Value);
                    this.vlogproductdetailTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproductdetail, dtpTanggal.Value);

                }
                else
                {
                    helper.NotifMessage("Surat Jalan tidak dapat di ubah");
                }
            }
        }

        public void GetPermissions(out bool add, out bool edit, out bool delete)
        {
            add = add_;
            edit = edit_;
            delete = delete_;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //check printed
            bool printed = false;
            //if printed
            //Print Selected Transaction
            //string custtypetoid = radGridView1.SelectedRows[0].Cells["custtypetoid"].Value.ToString();
            string iLogID = radGridView1.SelectedRows[0].Cells["LogID"].Value.ToString();
            //Print
            using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
            {
                printed = (bool)tbl.CheckPrinted(long.Parse(iLogID));
            }
            string frmName = this.GetType().Name;
            bool edit = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "delete");
            if (!edit)
            {
                if (printed)
                {
                    helper.NotifMessage("Surat Jalan Sudah di Print");
                    return;
                }
            }

            DialogResult res = MessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                PrinterSettings printerSettings;
                ReportProcessor reportProcessor;

                rptSJ rpt = new rptSJ();
                rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                rpt.ReportParameters["logid"].Value = lblLogID.Text;
                //rpt.ReportParameters["custtypetoid"].Value = custtypetoid;

                IReportDocument iRpt = (IReportDocument)rpt;
                //// PrinterSettings 
                printerSettings = new PrinterSettings();
                //printerSettings.PrinterName = rddPrinter.Text;
                //// Adjust the printer settings if necessary...

                // Print the report using the printer settings.
                try
                {
                    InstanceReportSource reportSource = new InstanceReportSource();
                    reportSource.ReportDocument = iRpt;

                    reportProcessor = new ReportProcessor();
                    reportProcessor.PrintReport(reportSource, printerSettings);
                    using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
                    {
                        tbl.UpdatePrinted(NBConfig.ValidUserName, long.Parse(lblLogID.Text));
                    }
                    helper.PrintLog(this.GetType().Name, rpt.Name, this.Text + ":LogID-" + iLogID);
                    this.vlogproductTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproduct, dtpTanggal.Value);
                }
                catch (Exception ex)
                {
                    helper.ErrorMessage(ex.Message);
                }
            }
        }

        private void radGridView1_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {

            if (!(e.CurrentRow is GridViewGroupRowInfo))
            {
                if (e.CurrentRow.HasChildRows())
                {
                    lblSelection.Text = "Surat Jalan yang Terpilih : " + e.CurrentRow.Cells["NoSJ"].Value.ToString();
                    lblLogID.Text = e.CurrentRow.Cells["LogID"].Value.ToString();

                    //decide to allow user delete edit or batal sj
                    if (DateTime.Parse(e.CurrentRow.Cells["created"].Value.ToString()).Date == DateTime.Now.Date)
                    {
                        if (bool.Parse(e.CurrentRow.Cells["Printed"].Value.ToString()))
                        {
                            btnBatal.Enabled = delete_;
                            btnEdit.Enabled = delete_;
                            btnPrint.Enabled = delete_;
                        }
                        else
                        {
                            btnEdit.Enabled = (add_ || edit_ || delete_);
                            btnBatal.Enabled = (add_ || edit_ || delete_);
                            btnPrint.Enabled = (add_ || edit_ || delete_);
                        }
                    }
                    else
                    {
                        btnEdit.Enabled = (edit_ || delete_);
                        btnBatal.Enabled = delete_;
                        if (bool.Parse(e.CurrentRow.Cells["Printed"].Value.ToString()))
                        {
                            btnPrint.Enabled = delete_;
                        }
                        else
                        {
                            btnPrint.Enabled = add_ || edit_ ||delete_;
                        }
                    }
                }
            }
            else
            {
                btnBatal.Enabled = false;
                btnEdit.Enabled = false;
                btnPrint.Enabled = false;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblLogID.Text))
            {
                 DialogResult res = MessageBox.Show(lblSelection.Text + " akan dibatal.\nPilih [Ok] untuk batal SJ.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question);
                 if (res == System.Windows.Forms.DialogResult.OK)
                 {
                     using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
                     {
                         tbl.UpdateStatus(3, NBConfig.ValidUserName, long.Parse(lblLogID.Text));
                     }
                 }
                 this.vlogproductTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproduct, dtpTanggal.Value);
                 this.vlogproductdetailTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproductdetail, dtpTanggal.Value);
            }
            else
            {
                helper.NotifMessage("Silahkan pilih Surat Jalan untuk di batalkan!");
            }
        }

        private void rbtn_Changed(object sender, StateChangedEventArgs args)
        {           
            RadRadioButton btn = (RadRadioButton)sender;
            if (btn.IsChecked)
            {
                switch (btn.Text.Replace(":", "").Trim().ToLower())
                {
                    case "tanggal":
                        dtpTanggal.Enabled = true;
                        dtpTanggal.Value = DateTime.Now;
                        txtNoSJ.Enabled = false;
                        btnFind.Enabled = false;
                        txtNoSJ.ResetText();
                        break;
                    case "no sj":
                        dtpTanggal.Enabled = false;
                        dtpTanggal.ResetText();
                        txtNoSJ.Enabled = true;
                        btnFind.Enabled = true;
                        txtNoSJ.ResetText();
                        txtNoSJ.Focus();
                        this.vlogproductdetailTableAdapter.FillByID(this.sinarekDataSet.vlogproductdetail, txtNoSJ.Text);
                        this.vlogproductTableAdapter.FillBySJ(this.sinarekDataSet.vlogproduct, txtNoSJ.Text);
                        break;
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtNoSJ.Text != "________")
            {
                //Search for record
                this.vlogproductdetailTableAdapter.FillByID(this.sinarekDataSet.vlogproductdetail, txtNoSJ.Text);
                this.vlogproductTableAdapter.FillBySJ(this.sinarekDataSet.vlogproduct, txtNoSJ.Text);
            }
            else
            {
                helper.NotifMessage("Silahkan input No Trans untuk di cari");
            }
        }
        

    }
}
