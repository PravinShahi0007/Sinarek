using System;
using System.Collections;
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
    public partial class frmLihatLP : Telerik.WinControls.UI.RadForm
    {
        #region "Private Variables"
        private bool add_;
        private bool edit_;
        private bool delete_;
        #endregion

        public frmLihatLP()
        {
            InitializeComponent();
            //PopulateInstalledPrintersCombo();
        }

        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            helper.GetPermissions(frmName, (this.Tag != null ? this.Tag.ToString() : ""), out add_, out edit_, out delete_);

            radGroupBox1.Visible = (add_||edit_ || delete_);

            btnNew.Visible = (add_);
            btnEdit.Enabled = (add_);
            btnPrint.Enabled = (add_);
            btnPrintSales.Enabled = (add_);
        }

        private void frmLihatSJ_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            this.pelTableAdapter.Fill(this.sinarekDataSet.pel);
            this.logpelTableAdapter.Fill(this.sinarekDataSet.logpel);
            this.logotherTableAdapter.Fill(this.sinarekDataSet.logother);
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.productbaseTableAdapter.Fill(this.sinarekDataSet.productbase);

            dtpTanggal.Value = DateTime.Now;
            this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen,dtpTanggal.Value,"Penjualan");

        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggal.Value,"Penjualan");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblLogID.Text))
            {
                EditLaporan();
            }
            else
            {
                helper.NotifMessage("Silahkan pilih laporan untuk diedit!");
            }
        }

        private void PopulateInstalledPrintersCombo()
        {
            // Add list of installed printers found to the combo box.
            // The pkInstalledPrinters string will be used to provide the display string.
            //String pkInstalledPrinters;
            //for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            //{
            //    pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
            //    PrinterSettings set = new PrinterSettings();
            //    set.PrinterName = pkInstalledPrinters;
                
            //    rddPrinter.Items.Add(pkInstalledPrinters);
            //}
           
            try
            {
                ManagementObjectSearcher searcher = 
                    new ManagementObjectSearcher("root\\CIMV2", 
                    "SELECT * FROM Win32_Printer WHERE DriverName like 'EPSON%'"); 

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    rddPrinter.Items.Add(queryObj["Name"].ToString());
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }
        
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            string iLappenID = radGridView1.SelectedRows[0].Cells["lappenID"].Value.ToString();
            //Print
            DialogResult res = RadMessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , RadMessageIcon.Question
                , MessageBoxDefaultButton.Button2);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                PrinterSettings printerSettings;
                ReportProcessor reportProcessor;

                rptLaporanPenj rpt = new rptLaporanPenj();
                rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                rpt.ReportParameters["lappenid"].Value = iLappenID;

                IReportDocument iRpt = (IReportDocument)rpt;

                iRpt.DocumentName = radGridView1.SelectedRows[0].Cells["NOSJ"].Value.ToString() + " "
                                + radGridView1.SelectedRows[0].Cells["SalesName"].Value.ToString();
                //// PrinterSettings 
                printerSettings = new PrinterSettings();
                try
                {
                    reportProcessor = new ReportProcessor();
                    InstanceReportSource reportSource = new InstanceReportSource();
                    reportSource.ReportDocument = iRpt;

                    reportProcessor.PrintReport(reportSource, printerSettings);
                    using (sinarekDataSetTableAdapters.lappenTableAdapter tbl = new sinarekDataSetTableAdapters.lappenTableAdapter())
                    {
                        tbl.UpdateLapPenj(NBConfig.ValidUserName
                                            , radGridView1.SelectedRows[0].Cells["statusID"].Value
                                            , 1, int.Parse(iLappenID));
                    }
                    helper.PrintLog(this.GetType().Name, rpt.Name, "Print:" + iLappenID);
                    this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggal.Value,"Penjualan");

                }
                catch (Exception ex)
                {
                    helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                    helper.ErrorMessage(ex.Message);
                }
            }
        }

        private void radGridView1_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (!(e.CurrentRow is GridViewGroupRowInfo))
            {
                //if (e.CurrentRow.HasChildViews)
                //{
                if (e.CurrentRow.Cells["NoSJ"] != null)
                {
                    lblSelection.Text = "Laporan : " + e.CurrentRow.Cells["NoSJ"].Value.ToString();
                    lblLogID.Text = e.CurrentRow.Cells["LogID"].Value.ToString();
                    lblSales.Text = e.CurrentRow.Cells["SalesShort"].Value.ToString();
                }
                //}
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmInputLP frm = new frmInputLP();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(this);
            this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggal.Value, "Penjualan");

        }
        #region "Methods"
        public void GetPermissions(out bool add, out bool edit, out bool delete)
        {
            add = add_;
            edit = edit_;
            delete = delete_;
        }

        private void EditLaporan()
        {
            GridViewRowInfo row = radGridView1.SelectedRows[0];
            sinarekDataSet.vlogproductDataTable sjData = new sinarekDataSet.vlogproductDataTable();
            using (sinarekDataSetTableAdapters.vlogproductTableAdapter tbl = new sinarekDataSetTableAdapters.vlogproductTableAdapter())
            {
                try
                {
                    tbl.FillBySJ(sjData,row.Cells["nosj"].Value.ToString());
                    DataRow row_ = sjData.Rows[0];
                    frmInputPenjualan frm = new frmInputPenjualan(row_,
                                                    row.Cells["lappenid"].Value.ToString(),
                                                    DateTime.Parse(row.Cells["enddate"].Value.ToString()),
                                                    DateTime.Parse(row.Cells["tanggalsj"].Value.ToString()),
                                                    DateTime.Parse(row.Cells["tanggal"].Value.ToString()));
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    helper.ErrorMessage("Error mengedit laporan.!" + ex.StackTrace + ex.Message);
                    helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                }
            }
        }
        #endregion

        private void btnPrintSales_Click(object sender, EventArgs e)
        {
            //Print
            DialogResult res = RadMessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , RadMessageIcon.Question
                , MessageBoxDefaultButton.Button2);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                PrinterSettings printerSettings;
                ReportProcessor reportProcessor;

                rptLaporanPenjSales rpt = new rptLaporanPenjSales();
                rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                rpt.ReportParameters["salesname"].Value = lblSales.Text;
                rpt.ReportParameters["tanggal"].Value = dtpTanggal.Value;

                IReportDocument iRpt = (IReportDocument)rpt;
                
                //iRpt.DocumentName = radGridView1.SelectedRows[0].Cells["NOSJ"].Value.ToString() + " "
                //                    + radGridView1.SelectedRows[0].Cells["SalesName"].Value.ToString();
                //// PrinterSettings 
                printerSettings = new PrinterSettings();
                try
                {
                    InstanceReportSource reportSource = new InstanceReportSource();
                    reportSource.ReportDocument = iRpt;
                    reportProcessor = new ReportProcessor();
                    reportProcessor.PrintReport(reportSource, printerSettings);
                    //SavedToPDF(iRpt, @"C:\Users\VINA\Documents\Laporan Penjualan");
                    using (sinarekDataSetTableAdapters.lappenTableAdapter tbl = new sinarekDataSetTableAdapters.lappenTableAdapter())
                    {
                        tbl.UpdatePrintedSales(NBConfig.ValidUserName
                                            , 1
                                            , dtpTanggal.Value
                                            , lblSales.Text);
                    }
                    helper.PrintLog(this.GetType().Name, rpt.Name, "PrintSales:" + lblSales.Text + "," + dtpTanggal.Value.ToString("dd MMM yy"));
                    this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggal.Value,"Penjualan");

                }
                catch (Exception ex)
                {
                    helper.ErrorMessage(ex.Message);
                }
            }
        }

        private void btnLihatSales_Click(object sender, EventArgs e)
        {
            frmPreviewSales frm = new frmPreviewSales(lblSales.Text, dtpTanggal.Value);
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.FormElement.TitleBar.TitlePrimitive.Font = new System.Drawing.Font("Lucida Bright", 12, FontStyle.Bold);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

    }
}
