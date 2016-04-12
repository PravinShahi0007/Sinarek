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
using Telerik.Reporting;
using Telerik.Reporting.Processing;

namespace NB
{
    public partial class frmUJKTR : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool edit_;
        private bool delete_;

        public frmUJKTR()
        {
            InitializeComponent();
        }

        private void frmUJ_Load(object sender, EventArgs e)
        {
            add_ = false;
            edit_ = false;
            delete_ = false;
            dtpAmbilTanggal.Value = DateTime.Now;
            dtpTanggalLaporan.Value = DateTime.Now;
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            add_ = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "add");
            edit_ = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "edit");
            delete_ = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "delete");

            btnEdit.Enabled = (add_ || edit_ || delete_);
            btnPrint.Enabled = (add_ || edit_ || delete_);
            btnBatalUJ.Enabled = (delete_);
            btnPrintUJ.Enabled = (delete_);
        }
        private void dtpAmbilTanggal_ValueChanged(object sender, EventArgs e)
        {
            this.vujTableAdapter.FillByTanggal(this.sinarekDataSet.vuj,dtpAmbilTanggal.Value);
        }

        private void dtpTanggalLaporan_ValueChanged(object sender, EventArgs e)
        {
            this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen,dtpTanggalLaporan.Value);
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (radPageView1.SelectedPage == radPagePaid)
            {
                this.uangjalanTableAdapter.FillByNoLap(this.sinarekDataSet.uangjalan);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string iLappenID = radGridView3.SelectedRows[0].Cells["lappenID"].Value.ToString();
            //Print
            DialogResult res = RadMessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , RadMessageIcon.Question
                , MessageBoxDefaultButton.Button2);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                PrinterSettings printerSettings;
                ReportProcessor reportProcessor;

                rptLaporanUJ rpt = new rptLaporanUJ();
                rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                rpt.ReportParameters["lappenid"].Value = iLappenID;
                rpt.ReportParameters["logid"].Value = radGridView3.SelectedRows[0].Cells["logID"].Value.ToString();

                IReportDocument iRpt = (IReportDocument)rpt;
                iRpt.DocumentName = radGridView3.SelectedRows[0].Cells["NOSJ"].Value.ToString() + " "
                                    + radGridView3.SelectedRows[0].Cells["SalesName"].Value.ToString();
                //// PrinterSettings 
                printerSettings = new PrinterSettings();
                try
                {
                    reportProcessor = new ReportProcessor();

                    reportProcessor.PrintReport(iRpt, printerSettings);
                    using (sinarekDataSetTableAdapters.lappenTableAdapter tbl = new sinarekDataSetTableAdapters.lappenTableAdapter())
                    {
                        tbl.UpdateLapPenj(NBConfig.ValidUserName
                                            , 1
                                            , 1, int.Parse(iLappenID));
                    }
                    helper.PrintLog(this.GetType().Name, rpt.Name, "Print:" + iLappenID);
                    this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggalLaporan.Value);

                }
                catch (Exception ex)
                {
                    helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                    //helper.ErrorMessage(ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GridViewRowInfo row = radGridView3.SelectedRows[0];
            EditLaporan(row.Cells["lappenid"].Value.ToString()
                        , row.Cells["nosj"].Value.ToString()
                        , bool.Parse(row.Cells["printed"].Value.ToString()));
        }

        private void EditLaporan(string lappenid,string NOSJ,bool printed)
        {
            sinarekDataSet.vlogproductDataTable sjData = new sinarekDataSet.vlogproductDataTable();
            using (sinarekDataSetTableAdapters.vlogproductTableAdapter tbl = new sinarekDataSetTableAdapters.vlogproductTableAdapter())
            {
                try
                {
                    tbl.FillBySJ(sjData,NOSJ);
                    DataRow row_ = sjData.Rows[0];
                    frmInputUJ frm = new frmInputUJ(row_
                                                    , lappenid
                                                    , printed);
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    helper.ErrorMessage("Error mengedit laporan.!");
                    helper.SysLog(this.GetType().Name, this.Text, "Error : " + ex.Message);
                }
            }
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            string UJID;
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            if (cell.CommandButton.TextElement.Text == "Ambil")
            {
                if (bool.Parse(cell.RowInfo.Cells["printed"].Value.ToString()))
                {
                    //Create UJ
                    using (sinarekDataSetTableAdapters.uangjalanTableAdapter tbl = new sinarekDataSetTableAdapters.uangjalanTableAdapter())
                    {
                        UJID = tbl.pInsertUangJalan(int.Parse(cell.RowInfo.Cells["LogID"].Value.ToString())
                            , cell.RowInfo.Cells["TUJUAN"].Value.ToString()
                            , cell.RowInfo.Cells["NOSJ"].Value.ToString()
                            , cell.RowInfo.Cells["SOPIRNAME"].Value.ToString()
                            , cell.RowInfo.Cells["MOBILNAME"].Value.ToString()
                            , cell.RowInfo.Cells["KERNETNAME"].Value.ToString()
                            , -1
                            , decimal.Parse(cell.RowInfo.Cells["UangJalan"].Value.ToString())
                            , 0, NBConfig.ValidUserName).ToString();
                    }

                    //Print Uang Jalan
                    //Print
                    DialogResult res = RadMessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                        , MessageBoxButtons.OKCancel
                        , RadMessageIcon.Question
                        , MessageBoxDefaultButton.Button2);
                    if (res == System.Windows.Forms.DialogResult.OK)
                    {
                        PrinterSettings printerSettings;
                        ReportProcessor reportProcessor;

                        rptUJ rpt = new rptUJ();
                        rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                        rpt.ReportParameters["UJID"].Value = UJID;

                        IReportDocument iRpt = (IReportDocument)rpt;
                        iRpt.DocumentName = "UJ_" + cell.RowInfo.Cells["NOSJ"].Value.ToString() + " "
                                            + cell.RowInfo.Cells["SOPIRNAME"].Value.ToString();
                        //// PrinterSettings 
                        printerSettings = new PrinterSettings();
                        try
                        {
                            reportProcessor = new ReportProcessor();

                            reportProcessor.PrintReport(iRpt, printerSettings);
                            using (sinarekDataSetTableAdapters.uangjalanTableAdapter tbl = new sinarekDataSetTableAdapters.uangjalanTableAdapter())
                            {
                                tbl.UpdatePrinted(1
                                    , NBConfig.ValidUserName
                                    , int.Parse(UJID));
                            }
                            helper.PrintLog(this.GetType().Name, rpt.Name, "Print:" + UJID);
                            this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggalLaporan.Value);
                        }
                        catch (Exception ex)
                        {
                            helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                            helper.ErrorMessage(ex.Message);
                        }
                    }
                    this.uangjalanTableAdapter.FillByNoLap(this.sinarekDataSet.uangjalan);
                    this.vujTableAdapter.FillByTanggal(this.sinarekDataSet.vuj, dtpAmbilTanggal.Value);
                }
                else
                {
                    helper.NotifMessage("Surat Jalan Belum Di Print. Uang Jalan tidak dapat di ambil.");
                }
            }
        }

        private void radGridView2_CommandCellClick(object sender, EventArgs e)
        {
            string lappenjid;
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            if (cell.CommandButton.TextElement.Text == "Input Laporan")
            {
                //Create Laporan
                using (sinarekDataSetTableAdapters.lappenTableAdapter tbl = new sinarekDataSetTableAdapters.lappenTableAdapter())
                {
                    try
                    {
                        lappenjid = tbl.pInsertLapPenj(int.Parse(cell.RowInfo.Cells["LogID"].Value.ToString())
                                            , DateTime.Now
                                            , DateTime.Now
                                            , NBConfig.ValidUserName
                                            , "UJ").ToString();
                        EditLaporan(lappenjid
                                    ,cell.RowInfo.Cells["NOSJ"].Value.ToString()
                                    ,false);
                        this.uangjalanTableAdapter.FillByNoLap(this.sinarekDataSet.uangjalan);
                        this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggalLaporan.Value);
                    }
                    catch (Exception ex)
                    {
                        helper.NotifMessage("Laporan UJ untuk " + cell.RowInfo.Cells["NOSJ"].Value.ToString() + " sudah terinput.");
                        helper.SysLog(this.GetType().Name, this.Text, "Create Laporan UJ :" + ex.Message);
                        lappenjid = tbl.GetLapPenID(int.Parse(cell.RowInfo.Cells["LogID"].Value.ToString())
                                            , "UJ").ToString();
                    }
                }
            }
        }

        private void btnPrintUJ_Click(object sender, EventArgs e)
        {
            string iUJID = radGridView2.SelectedRows[0].Cells["UJID"].Value.ToString();
            //Print
            DialogResult res = RadMessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , RadMessageIcon.Question
                , MessageBoxDefaultButton.Button2);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                PrinterSettings printerSettings;
                ReportProcessor reportProcessor;

                rptUJ rpt = new rptUJ();
                rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                rpt.ReportParameters["UJid"].Value = iUJID;

                IReportDocument iRpt = (IReportDocument)rpt;
                iRpt.DocumentName = "UJ_" + radGridView2.SelectedRows[0].Cells["NOSJ"].Value.ToString() + " "
                                    + radGridView2.SelectedRows[0].Cells["SOPIRName"].Value.ToString();
                //// PrinterSettings 
                printerSettings = new PrinterSettings();
                try
                {
                    reportProcessor = new ReportProcessor();

                    reportProcessor.PrintReport(iRpt, printerSettings);
                    using (sinarekDataSetTableAdapters.uangjalanTableAdapter tbl = new sinarekDataSetTableAdapters.uangjalanTableAdapter())
                    {
                        tbl.UpdatePrinted(1
                            , NBConfig.ValidUserName
                            , int.Parse(radGridView2.SelectedRows[0].Cells["logid"].Value.ToString()));
                    }
                    helper.PrintLog(this.GetType().Name, rpt.Name, "Print:" + iUJID);
                    this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggalLaporan.Value);
                }
                catch (Exception ex)
                {
                    helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                    helper.ErrorMessage(ex.Message);
                }
            }
        }

    }
}
