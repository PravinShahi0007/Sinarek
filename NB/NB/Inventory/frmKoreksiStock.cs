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
    public partial class frmKoreksiStock : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool edit_;
        private bool delete_;
        string tipe_;
        public frmKoreksiStock()
            : this("Produksi")
        {

        }
        public frmKoreksiStock(string sTipe)
        {
            InitializeComponent();
            //initiliazeButtons();
            tipe_ = sTipe;
            this.Text = "Stock Awal " + sTipe + " - "
                        + DateTime.Now.ToString("dd-MMM-yyyy");
        }
        #region "Control Events"
        private void frmLihatTotal_Load(object sender, EventArgs e)
        {
            //Call a function to create stock awal for the current day
            InitializeButtons();
            //this.producttotalTableAdapter.Fill(this.sinarekDataSet.producttotal);
            this.staffTableAdapter.Fill(this.fingermachDataSet.staff);
            this.tipeprodTableAdapter.Fill(this.sinarekDataSet.tipeprod);
            try
            {
                // TODO: This line of code loads data into the 'sinarekDataSet.vproductbase' table. You can move, or remove it, as needed.
                this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
                // TODO: This line of code loads data into the 'sinarekDataSet.producttotaluser' table. You can move, or remove it, as needed.
                dtpTanggal.Value = DateTime.Now;
                rddTipe.FindItemExact(tipe_, false).Selected = true;

            }
            catch (Exception ex)
            {
                helper.ErrorMessage("Ada masalah dengan lihat total. Silahkan coba lagi.!");
                helper.SysLog(this.GetType().Name, this.Text, "Error:" + ex.Message + " : " + ex.StackTrace);
                this.Close();
            }
        }
        private void rddTipe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dtpTanggal.Value != null && rddTipe.SelectedValue != null)
            {
                // TODO: This line of code loads data into the 'sinarekDataSet.producttotal' table. You can move, or remove it, as needed.
                this.producttotalTableAdapter.FillByTanggalTipe(this.sinarekDataSet.producttotal, dtpTanggal.Value
                                                            , "AWAL"
                                                            , int.Parse(rddTipe.SelectedValue.ToString()));
                this.Text = "Stock Awal " + rddTipe.Text + " - "
                            + dtpTanggal.Value.ToString("dd-MMM-yyyy");
            }

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ////On Printing Surat Jalan Make sure after printing surat jalan has been updated too 
            ////printed so the next time surat jalan is printing COPY is appended to the title.
            DialogResult res = MessageBox.Show("Print Laporan Stock. Siap kan kertas di printer."
                              , "Print Laporan Stock"
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ada masalah untuk print laporan stock. Segera hubungi administrator", "SMS - Error Notification");
                }
            }
        }
        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTanggal.Value != null && rddTipe.SelectedValue != null)
            {
                // TODO: This line of code loads data into the 'sinarekDataSet.producttotal' table. You can move, or remove it, as needed.
                this.producttotalTableAdapter.FillByTanggalTipe(this.sinarekDataSet.producttotal, dtpTanggal.Value
                                                            , "AWAL"
                                                            , int.Parse(rddTipe.SelectedValue.ToString()));
                this.Text = "Stock Awal " + rddTipe.Text + " - "
                            + dtpTanggal.Value.ToString("dd-MMM-yyyy");
            }
        }
        #endregion
        #region "Methods"
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            add_ = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "add");
            edit_ = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "edit");
            delete_ = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "delete");
            
            btnPrint.Enabled = delete_;
            btnPrint.Visible = delete_;
            rddTipe.Enabled = delete_;
            dtpTanggal.Enabled = delete_;
        }
        
        #endregion

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Column.Name.ToLower() == "keterangan" || e.Column.Name.ToLower() == "adjustedval")
            {
                producttotalTableAdapter.UpdateValue(decimal.Parse(e.Row.Cells["adjustedval"].Value.ToString())
                                                    , e.Row.Cells["keterangan"].Value.ToString()
                                                    , NBConfig.ValidUserName
                                                    , int.Parse(e.Row.Cells["totalid"].Value.ToString()));
                this.producttotalTableAdapter.FillByTanggalTipe(this.sinarekDataSet.producttotal, dtpTanggal.Value
                                                        , "AWAL"
                                                        , int.Parse(rddTipe.SelectedValue.ToString()));

            }
        }

    }
}
