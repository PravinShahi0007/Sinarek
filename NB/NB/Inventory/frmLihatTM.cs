using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using Telerik.Reporting;
using Telerik.Reporting.Processing;

namespace NB
{
    public partial class frmLihatTM : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool edit_;
        private bool delete_;

        public frmLihatTM():this("Completed")
        {
        }

        public frmLihatTM(string Status)
        {
            InitializeComponent();
            add_ = false;
            edit_ = false;
            delete_ = false;
            switch (Status.ToLower())
            {
                case "completed":
                    vlogproductBindingSource.Filter = "category = 1 and statusid = 4";
                    break;
                case "batal":
                    vlogproductBindingSource.Filter = "category = 1 and statusid = 3";
                    this.Text += " " + Status;
                    break;
            }
        }
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            add_ = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "add");
            edit_ = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "edit");
            delete_ = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "delete");

            radGroupBox1.Visible = (add_||edit_ || delete_);

            btnBatal.Enabled = (edit_ ||delete_);
            btnEdit.Enabled = delete_;
            btnPrint.Enabled = add_;
        }
        
        private void Form_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.SetConditions();
            rbtnTanggal.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTanggal.Value != null)
            {
                this.vlogproductdetailTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproductdetail, dtpTanggal.Value);
                this.vlogproductTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproduct, dtpTanggal.Value);

            }
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
                    helper.NotifMessage("Transaksi Sudah di Print!");
                    return;
                }
            }

            //Print
            DialogResult res = MessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                PrinterSettings printerSettings;
                ReportProcessor reportProcessor;

                rptTM rpt = new rptTM();
                rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                rpt.ReportParameters["logid"].Value = lblLogID.Text;
                //rpt.ReportParameters["custtypetoid"].Value = custtypetoid;

                IReportDocument iRpt = (IReportDocument)rpt;
                //// PrinterSettings 
                printerSettings = new PrinterSettings();
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SMS - Error Notofication");
                }
            }
        }

        private void radGridView1_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (!(e.CurrentRow is GridViewGroupRowInfo))
            {
                if (e.CurrentRow.HasChildRows())
                {
                    lblSelection.Text = "No. Trans : " + e.CurrentRow.Cells["NoSJ"].Value.ToString();
                    lblLogID.Text = e.CurrentRow.Cells["LogID"].Value.ToString();                    
                }
            }
        }

        private void SetConditions()
        {           
            //Pecah
            ConditionalFormattingObject c2 = new ConditionalFormattingObject("Light Sea Green, applied to entire row", ConditionTypes.Equal, "2", "", true);
            c2.RowBackColor = Color.LightSeaGreen;
            gridViewTemplate1.Columns["status"].ConditionalFormattingObjectList.Add(c2);
            //Rusak
            ConditionalFormattingObject c3 = new ConditionalFormattingObject("Light Still Blue, applied to entire row", ConditionTypes.Equal, "3", "", true);
            c3.RowBackColor = Color.LightSteelBlue;
            gridViewTemplate1.Columns["status"].ConditionalFormattingObjectList.Add(c3);
            //Sumbing
            ConditionalFormattingObject c4 = new ConditionalFormattingObject("Corn Flower Blue, applied to entire row", ConditionTypes.Equal, "4", "", true);
            c4.RowBackColor = Color.CornflowerBlue;
            gridViewTemplate1.Columns["status"].ConditionalFormattingObjectList.Add(c4); 
            //Expire
            ConditionalFormattingObject c5 = new ConditionalFormattingObject("Purple, applied to entire row", ConditionTypes.Equal, "5", "", true);
            c5.RowBackColor = Color.Purple;
            gridViewTemplate1.Columns["status"].ConditionalFormattingObjectList.Add(c5);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bool bAllowed = false;
            if (dtpTanggal.Value == DateTime.Now)
            {
                bAllowed = true;
            }
            else
            {
                bAllowed = delete_;

            }

            if (bAllowed)
            {
                if (!string.IsNullOrEmpty(lblLogID.Text))
                {
                    DialogResult res = MessageBox.Show(lblSelection.Text + " akan dibatal.\nPilih [Ok] untuk batal Transaksi.", "SMS - Verification"
                    , MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                    if (res == System.Windows.Forms.DialogResult.OK)
                    {
                        using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
                        {
                            tbl.UpdateStatus(3, NBConfig.ValidUserName, long.Parse(lblLogID.Text));
                        }
                        this.vlogproductTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproduct, dtpTanggal.Value);
                    }
                }
                else
                {
                    helper.NotifMessage("Silahkan pilih Surat Jalan untuk di batalkan!");
                }
            }            
        }

        private void rbtn_Changed(object sender, StateChangedEventArgs args)
        {
            RadRadioButton btn = (RadRadioButton)sender;
            if (btn.IsChecked)
            {
                switch (btn.Text.Replace(":","").Trim().ToLower())
                {
                    case "tanggal":
                        dtpTanggal.Enabled = true;
                        dtpTanggal.Value = DateTime.Now;
                        txtNoSJ.Enabled = false;
                        btnFind.Enabled = false;
                        txtNoSJ.ResetText();
                        dtpTanggal.Focus();
                        break;
                    case "no trans":
                        dtpTanggal.Enabled = false;
                        dtpTanggal.ResetText();
                        txtNoSJ.Enabled = true;
                        btnFind.Enabled = true;
                        txtNoSJ.ResetText();
                        this.vlogproductdetailTableAdapter.FillByID(this.sinarekDataSet.vlogproductdetail, txtNoSJ.Text);
                        this.vlogproductTableAdapter.FillBySJ(this.sinarekDataSet.vlogproduct, txtNoSJ.Text);
                        txtNoSJ.Focus();                        
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Only allow editing for custtypetoid 1 to 6
            if (radGridView1.SelectedRows[0].Cells["NoSJ"] != null)
            {
                string tipeTransaksi = radGridView1.SelectedRows[0].Cells["CustTypeName"].Value.ToString();
                switch (tipeTransaksi)
                {
                    case "Sales":

                        break;
                    case "Sisa":
                        break;
                    case "Supplier":
                        break;
                }
                //int typeid = int.Parse(radGridView1.SelectedRows[0].Cells["TransTypeID"].Value.ToString());
                //if (typeid >= 1 && typeid <= 6)
                //{
                //    //Log Editing
                //    helper.SysLog(this.GetType().Name, this.Text, "Edit :" + lblLogID.Text);

                //    string noSJ = radGridView1.SelectedRows[0].Cells["NoSJ"].Value.ToString();
                //    DataRowView data = (DataRowView)radGridView1.SelectedRows[0].DataBoundItem;
                //    frmEditSJ frm = new frmEditSJ(data.Row);
                //    frm.ShowDialog(this);

                //    this.vlogproductTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproduct, dtpTanggal.Value);
                //    this.vlogproductdetailTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproductdetail, dtpTanggal.Value);

                //}
                //else
                //{
                //    helper.NotifMessage("Transaksi tidak dapat di ubah");
                //}
            }
        }


    }
}
