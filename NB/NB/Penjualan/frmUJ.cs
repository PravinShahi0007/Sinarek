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
    public partial class frmUJ : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool edit_;
        private bool delete_;

        public frmUJ()
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
            dtpTanggalKas.Value = DateTime.Now;
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            helper.GetPermissions(frmName, this.Tag.ToString(), out add_, out edit_, out delete_);

            btnEdit.Enabled = (add_ || edit_ || delete_);
            btnPrint.Enabled = (add_ || edit_ || delete_);
            radGridView2.Columns["cmdBatal"].IsVisible = delete_;
            btnPrintUJ.Enabled = (delete_);
            btnBatalLUJ.Enabled = delete_;
            btnBatalKas.Enabled = delete_;
        }

        private void dtpAmbilTanggal_ValueChanged(object sender, EventArgs e)
        {
            this.vujTableAdapter.FillByTanggal(this.sinarekDataSet.vuj,dtpAmbilTanggal.Value);
        }

        private void dtpTanggalLaporan_ValueChanged(object sender, EventArgs e)
        {
            this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen,dtpTanggalLaporan.Value,"UJ");
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
                    InstanceReportSource reportSource = new InstanceReportSource();
                    reportSource.ReportDocument = iRpt;

                    reportProcessor = new ReportProcessor();

                    reportProcessor.PrintReport(reportSource, printerSettings);
                    using (sinarekDataSetTableAdapters.lappenTableAdapter tbl = new sinarekDataSetTableAdapters.lappenTableAdapter())
                    {
                        tbl.UpdateLapPenj(NBConfig.ValidUserName
                                            , 1
                                            , 1, int.Parse(iLappenID));
                    }
                    helper.PrintLog(this.GetType().Name, rpt.Name, "Print:" + iLappenID);
                    this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggalLaporan.Value,"UJ");

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
        private void EditLaporanUB(RadGridView oGrid,string lappenid, string NOSJ, bool printed)
        {
            DataRowView row = (DataRowView)oGrid.SelectedRows[0].DataBoundItem;
            frmInputUB frm = new frmInputUB(row.Row
                                            , lappenid
                                            , printed);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(this);
               
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
                            InstanceReportSource reportSource = new InstanceReportSource();
                            reportSource.ReportDocument = iRpt;

                            reportProcessor = new ReportProcessor();

                            reportProcessor.PrintReport(reportSource, printerSettings);
                            using (sinarekDataSetTableAdapters.uangjalanTableAdapter tbl = new sinarekDataSetTableAdapters.uangjalanTableAdapter())
                            {
                                tbl.UpdatePrinted(1
                                    , NBConfig.ValidUserName
                                    , int.Parse(UJID));
                            }
                            helper.PrintLog(this.GetType().Name, rpt.Name, "Print:" + UJID);
                            this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggalLaporan.Value,"UJ");
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
            string question = string.Empty;

            if (cell.RowInfo.Cells["NOSJ"].Value.ToString() == "KAS")
            {
                question = "Yakin " + cell.RowInfo.Cells["sopirname"].Value.ToString() 
                                                    + " sudah kembali dari belanja ?";
            }
            else
            {
                question = "Yakin mobil " + cell.RowInfo.Cells["mobilname"].Value.ToString() + " oleh sopir "
                                                    + cell.RowInfo.Cells["sopirname"].Value.ToString()
                                                    + " sudah kembali dari "
                                                    + cell.RowInfo.Cells["tujuan"].Value.ToString();
            }
            switch (cell.CommandButton.TextElement.Text)
            {
                case "Input Laporan":
                //Print
                DialogResult res = RadMessageBox.Show(question, "SMS - Verification"
                    , MessageBoxButtons.OKCancel
                    , RadMessageIcon.Question
                    , MessageBoxDefaultButton.Button2);
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    //Create Laporan
                    using (sinarekDataSetTableAdapters.lappenTableAdapter tbl = new sinarekDataSetTableAdapters.lappenTableAdapter())
                    {
                        try
                        {
                            if (cell.RowInfo.Cells["NOSJ"].Value.ToString() != "KAS")
                            {
                                lappenjid = tbl.pInsertLapPenj(int.Parse(cell.RowInfo.Cells["LogID"].Value.ToString())
                                                    , DateTime.Now
                                                    , DateTime.Now
                                                    , NBConfig.ValidUserName
                                                    , "UJ").ToString();
                                EditLaporan(lappenjid
                                        , cell.RowInfo.Cells["NOSJ"].Value.ToString()
                                        , false);
                            }
                            else
                            {
                                lappenjid = tbl.pInsertLapPenj(int.Parse(cell.RowInfo.Cells["ujid"].Value.ToString())
                                                                , DateTime.Now
                                                                , DateTime.Now
                                                                , NBConfig.ValidUserName
                                                                , "UB").ToString();
                                EditLaporanUB(radGridView2,lappenjid
                                        , cell.RowInfo.Cells["NOSJ"].Value.ToString()
                                        , false);
                            }
                            
                            this.uangjalanTableAdapter.FillByNoLap(this.sinarekDataSet.uangjalan);
                            this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggalLaporan.Value,"UJ");
                            sinarekDataSet.vlappenDataTable dt = new sinarekDataSet.vlappenDataTable();
                            this.vlappenTableAdapter.FillByTanggal(dt, dtpTanggalKas.Value, "UB");
                            radGridView4.DataSource = dt;
                        }
                        catch (Exception ex)
                        {
                            helper.NotifMessage("Laporan UJ untuk " + cell.RowInfo.Cells["NOSJ"].Value.ToString() + " sudah terinput.");
                            helper.SysLog(this.GetType().Name, this.Text, "Create Laporan UJ :" + ex.Message);
                            //lappenjid = tbl.GetLapPenID(int.Parse(cell.RowInfo.Cells["LogID"].Value.ToString()), "UJ").ToString();
                        }
                    }
                }
                break;
                case "Batal":
                DialogResult res2 = RadMessageBox.Show("Yakin uang jalan mobil "+ cell.RowInfo.Cells["mobilname"].Value.ToString() +" oleh sopir " 
                                                    + cell.RowInfo.Cells["sopirname"].Value.ToString() 
                                                    +" tujuan ke "
                                                    + cell.RowInfo.Cells["tujuan"].Value.ToString()+ " akan dibatalkan ?", "SMS - Verification"
                    , MessageBoxButtons.OKCancel
                    , RadMessageIcon.Question
                    , MessageBoxDefaultButton.Button2);
                if (res2 == System.Windows.Forms.DialogResult.OK)
                {
                    this.uangjalanTableAdapter.UpdateStatus(3, NBConfig.ValidUserName
                                , int.Parse(cell.RowInfo.Cells["ujid"].Value.ToString()));
                    this.uangjalanTableAdapter.FillByNoLap(this.sinarekDataSet.uangjalan);
                    this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggalLaporan.Value,"UJ");
                }
                break;

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
                    InstanceReportSource reportSource = new InstanceReportSource();
                    reportSource.ReportDocument = iRpt;
                    reportProcessor = new ReportProcessor();

                    reportProcessor.PrintReport(reportSource, printerSettings);
                    using (sinarekDataSetTableAdapters.uangjalanTableAdapter tbl = new sinarekDataSetTableAdapters.uangjalanTableAdapter())
                    {
                        tbl.UpdatePrinted(1
                            , NBConfig.ValidUserName
                            , int.Parse(iUJID));
                    }
                    helper.PrintLog(this.GetType().Name, rpt.Name, "Print:" + iUJID);
                    this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggalLaporan.Value,"UJ");
                }
                catch (Exception ex)
                {
                    helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                    helper.ErrorMessage(ex.Message);
                }
            }
        }

        private void btnBatalLUJ_Click(object sender, EventArgs e)
        {
            if (radGridView3.SelectedRows.Count == 1)
            {
                string iUJID = radGridView3.SelectedRows[0].Cells["lappenid"].Value.ToString();
                vlappenTableAdapter.DeleteLaporan(int.Parse(iUJID), "UJ");
                //Delete laporan
                helper.SysLog(this.GetType().Name, this.Text, "Delete: LappenID" + iUJID);

                this.uangjalanTableAdapter.FillByNoLap(this.sinarekDataSet.uangjalan);
                this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggalLaporan.Value,"UJ");
            }
        }

        private void btnBelanja_Click(object sender, EventArgs e)
        {
            frmInputAmbil frm = new frmInputAmbil();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(this);

            this.uangjalanTableAdapter.FillByNoLap(this.sinarekDataSet.uangjalan);
            this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggalLaporan.Value, "UJ");
        }

        private void dtpTanggalKas_ValueChanged(object sender, EventArgs e)
        {
            sinarekDataSet.vlappenDataTable dt = new sinarekDataSet.vlappenDataTable();
            this.vlappenTableAdapter.FillByTanggal(dt, dtpTanggalKas.Value, "UB");
            radGridView4.DataSource = dt;
        }

        private void btnEditKas_Click(object sender, EventArgs e)
        {
            GridViewRowInfo row = radGridView4.SelectedRows[0];
            EditLaporanUB(radGridView4,row.Cells["lappenid"].Value.ToString()
                        , row.Cells["nosj"].Value.ToString()
                        , bool.Parse(row.Cells["printed"].Value.ToString()));
        }

        private void btnPrintKas_Click(object sender, EventArgs e)
        {
            string iLappenID = radGridView4.SelectedRows[0].Cells["lappenID"].Value.ToString();
            //Print
            DialogResult res = RadMessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , RadMessageIcon.Question
                , MessageBoxDefaultButton.Button2);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                PrinterSettings printerSettings;
                ReportProcessor reportProcessor;

                rptLaporanUB rpt = new rptLaporanUB();
                rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                rpt.ReportParameters["lappenid"].Value = iLappenID;
                rpt.ReportParameters["logid"].Value = radGridView4.SelectedRows[0].Cells["LogID"].Value.ToString();

                IReportDocument iRpt = (IReportDocument)rpt;

                iRpt.DocumentName = radGridView4.SelectedRows[0].Cells["NOSJ"].Value.ToString() + " "
                                    + radGridView4.SelectedRows[0].Cells["SopirName"].Value.ToString();
                //// PrinterSettings 
                printerSettings = new PrinterSettings();
                try
                {
                    InstanceReportSource reportSource = new InstanceReportSource();
                    reportSource.ReportDocument = iRpt;
                    reportProcessor = new ReportProcessor();

                    reportProcessor.PrintReport(reportSource, printerSettings);
                    using (sinarekDataSetTableAdapters.lappenTableAdapter tbl = new sinarekDataSetTableAdapters.lappenTableAdapter())
                    {
                        tbl.UpdateLapPenj(NBConfig.ValidUserName
                                            , 1
                                            , 1, int.Parse(iLappenID));
                    }
                    helper.PrintLog(this.GetType().Name, rpt.Name, "Print:" + iLappenID);
                    this.vlappenTableAdapter.FillByTanggal(this.sinarekDataSet.vlappen, dtpTanggalLaporan.Value, "UJ");

                }
                catch (Exception ex)
                {
                    helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                    //helper.ErrorMessage(ex.Message);
                }
            }
        }

        private void radGridView3_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            //don't allow edit when already printed
            if (!(e.CurrentRow is GridViewGroupRowInfo))
            {
                if (e.CurrentRow.Cells["printed"].Value.ToString().ToLower() == "false")
                {
                    btnPrint.Enabled = true;
                }
                else
                {
                    btnPrint.Enabled = delete_;
                }
            }


        }

        private void radGridView4_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            //don't allow edit when already printed
            if (!(e.CurrentRow is GridViewGroupRowInfo))
            {
                if (e.CurrentRow.Cells["printed"].Value.ToString().ToLower() == "false")
                {
                    btnPrintKas.Enabled = true;
                }
                else
                {
                    btnPrintKas.Enabled = delete_;
                }
            }
        }

        private void btnBatalKas_Click(object sender, EventArgs e)
        {

        }


    }
}
