using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.Reporting;
using Telerik.Reporting.Processing;
using lihatinventory;

namespace NB
{
    public partial class frmLihatTotal : Telerik.WinControls.UI.RadForm
    {
        string tipe_;
        public frmLihatTotal()
            : this("Produksi")
        {

        }
        public frmLihatTotal(string sTipe)
        {
            InitializeComponent();
            //initiliazeButtons();
            tipe_ = sTipe;
            this.Text = "Laporan Stock " + sTipe + " - "
                        + DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void frmLihatTotal_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            // TODO: This line of code loads data into the 'fingermachDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.fingermachDataSet.staff);
            // TODO: This line of code loads data into the 'sinarekDataSet.tipeprod' table. You can move, or remove it, as needed.
            this.tipeprodTableAdapter.Fill(this.sinarekDataSet.tipeprod);
            try
            {
                // TODO: This line of code loads data into the 'sinarekDataSet.vproductbase' table. You can move, or remove it, as needed.
                this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
                // TODO: This line of code loads data into the 'sinarekDataSet.producttotaluser' table. You can move, or remove it, as needed.
                this.producttotaluserTableAdapter.Fill(this.sinarekDataSet.producttotaluser);
                dtpTanggal.Value = DateTime.Now;

                rddNama.FindItemExact(NBConfig.ValidUserName, false).Selected = true;
                rddTipe.FindItemExact(tipe_, false).Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ada masalah dengan lihat total. Silahkan coba lagi.!", "SMS - Error Notification");
                this.Close();
            }
        }

        private void rddTipe_SelectedValueChanged(object sender, EventArgs e)
        {
            this.producttotaluserTableAdapter.FillByTipe(this.sinarekDataSet.producttotaluser
                                                    ,int.Parse(rddTipe.SelectedValue.ToString())
                                                    ,DateTime.Now
                                                    ,rddNama.Text);
            this.Text = "Laporan Stock " + rddTipe.Text + " - "
                        + dtpTanggal.Value.ToString("dd-MMM-yyyy");

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            frmAddProductTotal frm = new frmAddProductTotal(int.Parse(rddTipe.SelectedValue.ToString())
                ,dtpTanggal.Value,rddNama.Text);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(this);

            this.producttotaluserTableAdapter.FillByTipe(this.sinarekDataSet.producttotaluser
                                                    , int.Parse(rddTipe.SelectedValue.ToString())
                                                    , dtpTanggal.Value
                                                    , rddNama.Text);
        }

        private void radGridView1_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            //Remove data from database
            using (sinarekDataSetTableAdapters.producttotaluserTableAdapter tbl = new sinarekDataSetTableAdapters.producttotaluserTableAdapter())
            {
                try
                {
                    tbl.DeleteProductTotalUser(int.Parse(e.Rows[0].Cells["totalid"].Value.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ada masalah dengan penghapusan sisa barang.", "SMS - Error Notification");
                    e.Cancel = true;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Print Laporan Perhitungan Stock. Siap kan kertas di printer."
                              , "Print Laporan Perhitungan Stock"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Question
                              , MessageBoxDefaultButton.Button2
                              , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {                
                rptSisaBarang gj = new rptSisaBarang();
                gj.ReportParameters["tanggal"].Value = dtpTanggal.Value;
                gj.ReportParameters["tipeid"].Value = rddTipe.SelectedValue;
                gj.ReportParameters["User"].Value = NBConfig.ValidUserName;
                IReportDocument report1 = (IReportDocument)gj;
                ////set parameters when necessary

                //// PrinterSettings 
                PrinterSettings printerSettings = new PrinterSettings();
                //// Adjust the printer settings if necessary...
                try
                {
                    InstanceReportSource reportSource = new InstanceReportSource();
                    reportSource.ReportDocument = report1;

                    // Print the report using the printer settings.
                    ReportProcessor reportProcessor = new ReportProcessor();
                    reportProcessor.PrintReport(reportSource, printerSettings);

                    //print log
                    helper.PrintLog(this.Text, gj.Name, "tanggal:" + dtpTanggal.Value.ToString() +
                                                        ",tipeid:" + rddTipe.SelectedValue.ToString());

                    //Process Stock Data Akhir
                    //TODO: For Tipe 1 keep data for BSJ & BJ 
                    //TODO: For the rest only keep record with stock with parentid = -1

                }
                catch (Exception ex)
                {
                    helper.ErrorMessage("Ada masalah untuk print laporan stock. Segera hubungi administrator");
                    helper.SysLog(this.GetType().Name, this.Text, "ERROR : " + ex.Message + " : " + ex.StackTrace);
                }
            }
        }

        #region "Methods"
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            bool add = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "add");
            bool edit = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "edit");
            bool delete = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "delete");

            btnPrint.Enabled = edit;
            btnPrint.Visible = edit;
            btnPrintBJ.Enabled = edit;
            btnPrintBSJ.Enabled = edit;
            btnPrintBJ.Visible = edit;
            btnPrintBSJ.Visible = edit;

            rddTipe.Enabled = delete;
            dtpTanggal.Enabled = delete;
            rddNama.Enabled = delete;
        }
        private void ResetFields()
        {

        }
        #endregion

        private void rddNama_SelectedValueChanged(object sender, EventArgs e)
        {
            if(rddTipe.SelectedValue != null)
            {           
                this.producttotaluserTableAdapter.FillByTipe(this.sinarekDataSet.producttotaluser
                                                        , int.Parse(rddTipe.SelectedValue.ToString())
                                                        , dtpTanggal.Value
                                                        , rddNama.Text);            
            }
            
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            if (rddTipe.SelectedValue != null)
            {
                this.producttotaluserTableAdapter.FillByTipe(this.sinarekDataSet.producttotaluser
                                                        , int.Parse(rddTipe.SelectedValue.ToString())
                                                        , dtpTanggal.Value
                                                        , rddNama.Text);
                this.Text = "Laporan Stock " + rddTipe.Text + " - "
                        + dtpTanggal.Value.ToString("dd-MMM-yyyy");
            }
        }

        private void btnPrintBJ_Click(object sender, EventArgs e)
        {
            DialogResult res = RadMessageBox.Show(@"Laporan Barang Jadi. Laporan Bisa Dilihat Di Z:\Inventory\Report\"
                              , "Print Laporan Stock"
                              , MessageBoxButtons.OKCancel
                              , RadMessageIcon.Question
                              , MessageBoxDefaultButton.Button2);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Create stock akhir before printing
                helper.SysLog(this.GetType().Name, this.Text, "Creating Stock AKhir");
                using (sinarekDataSetTableAdapters.productbaseTableAdapter tbl = new sinarekDataSetTableAdapters.productbaseTableAdapter())
                {
                    tbl.pCreateStockAkhir(dtpTanggal.Value, int.Parse(rddTipe.SelectedValue.ToString()), NBConfig.ValidUserName);
                }

                rptTotalBarangNEW rpt = new rptTotalBarangNEW();
                rpt.ReportParameters["tanggal"].Value = dtpTanggal.Value;
                rpt.ReportParameters["User"].Value = NBConfig.ValidUserName;

                IReportDocument iRpt = (IReportDocument)rpt;

                iRpt.DocumentName = "Barang_Jadi_" + DateTime.Now.ToString("yyyyMMddhhmm");
                ////set parameters when necessary
                //Laporan di simpan ke folder
                helper.SavedToEXCEL(iRpt, @"d:\Inventory\Report\");
                helper.PrintLog(this.Text , rpt.Name + "_FileEXCEL", "tanggal:" + dtpTanggal.Value.ToString());

                ////// PrinterSettings 
                //PrinterSettings printerSettings = new PrinterSettings();
                ////// Adjust the printer settings if necessary...
                //try
                //{
                //    // Print the report using the printer settings.
                //    ReportProcessor reportProcessor = new ReportProcessor();
                //    reportProcessor.PrintReport(report1, printerSettings);

                //    //print log
                //    helper.PrintLog(this.Text, rpt.Name, "tanggal:" + dtpTanggal.Value.ToString());

                //}
                //catch (Exception ex)
                //{
                //    helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                //    helper.ErrorMessage("Ada masalah untuk print laporan barang jadi. Segera hubungi administrator");
                //}

                
            }
        }

        private void btnPrintBSJ_Click(object sender, EventArgs e)
        {
            DialogResult res = RadMessageBox.Show(@"Laporan Barang Setengah Jadi. Laporan Bisa Dilihat Di Z:\Inventory\Report\."
                              , "Print Laporan Stock"
                              , MessageBoxButtons.OKCancel
                              , RadMessageIcon.Question
                              , MessageBoxDefaultButton.Button2);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Create stock akhir before printing
                helper.SysLog(this.GetType().Name, this.Text, "Creating Stock AKhir");
                using (sinarekDataSetTableAdapters.productbaseTableAdapter tbl = new sinarekDataSetTableAdapters.productbaseTableAdapter())
                {
                    tbl.pCreateStockAkhir(dtpTanggal.Value, int.Parse(rddTipe.SelectedValue.ToString()), NBConfig.ValidUserName);
                }

                rptTotalBarangSJNEW rpt = new rptTotalBarangSJNEW();
                rpt.ReportParameters["tanggal"].Value = dtpTanggal.Value;
                rpt.ReportParameters["User"].Value = NBConfig.ValidUserName;
                IReportDocument iRpt = (IReportDocument)rpt;

                iRpt.DocumentName = "Barang_Setengah_Jadi_" + DateTime.Now.ToString("yyyyMMddhhmm");
                ////set parameters when necessary
                //Laporan di simpan ke folder
                helper.SavedToEXCEL(iRpt, @"d:\Inventory\Report\");
                helper.PrintLog(this.Text, rpt.Name + "_FileEXCEL", "tanggal:" + dtpTanggal.Value.ToString());

                ////// PrinterSettings 
                //PrinterSettings printerSettings = new PrinterSettings();
                ////// Adjust the printer settings if necessary...
                //try
                //{
                //    // Print the report using the printer settings.
                //    ReportProcessor reportProcessor = new ReportProcessor();
                //    reportProcessor.PrintReport(report1, printerSettings);

                //    //print log
                //    helper.PrintLog(this.Text, rpt.Name, "tanggal:" + dtpTanggal.Value.ToString());

                //}
                //catch (Exception ex)
                //{
                //    helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                //    helper.ErrorMessage("Ada masalah untuk print laporan barang setengah jadi. Segera hubungi administrator");
                //}

                
            }
        }
    }
}
