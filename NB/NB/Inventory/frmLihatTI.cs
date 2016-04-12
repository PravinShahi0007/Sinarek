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
    public partial class frmLihatTI : Telerik.WinControls.UI.RadForm
    {
        public frmLihatTI()
        {
            InitializeComponent();

            InitializeButtons();
        }

        public frmLihatTI(string Status)
            : this()
        {
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
            bool add = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "add");
            bool edit = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "edit");
            bool delete = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "delete");

            radGroupBox1.Visible = (add||edit || delete);

            btnBatal.Enabled = (edit|delete);
            btnEdit.Enabled = delete;
            btnPrint.Enabled = add;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            //this.vlogproductTableAdapter.Fill(this.sinarekDataSet.vlogproduct);
            //this.logdetailTableAdapter.Fill(this.sinarekDataSet.logother);
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.productbaseTableAdapter.Fill(this.sinarekDataSet.productbase);
            this.logdetailTableAdapter.Fill(this.sinarekDataSet.logdetail);
            this.vlogproductTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproduct, DateTime.Now);

            this.SetConditions();
            dtpTanggal.Value = DateTime.Now;
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            this.vlogproductTableAdapter.FillByTanggal(this.sinarekDataSet.vlogproduct, dtpTanggal.Value);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //string noSJ = radGridView1.SelectedRows[0].Cells["NoSJ"].Value.ToString();
            //frmInputTM frm = new frmInputTM(noSJ, false);
            //frm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Print Selected Transaction
            //string custtypetoid = radGridView1.SelectedRows[0].Cells["custtypetoid"].Value.ToString();
            string iLogID = radGridView1.SelectedRows[0].Cells["LogID"].Value.ToString();
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
                    reportProcessor = new ReportProcessor();
                    reportProcessor.PrintReport(iRpt, printerSettings);

                    using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
                    {
                        tbl.UpdatePrinted(NBConfig.ValidUserName, long.Parse(lblLogID.Text));
                    }
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
}
