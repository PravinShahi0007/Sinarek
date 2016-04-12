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
    public partial class frmStockManagement : Telerik.WinControls.UI.RadForm
    {
        string tipe_;
        public frmStockManagement()
            : this("Produksi")
        {

        }
        public frmStockManagement(string sTipe)
        {
            InitializeComponent();
            //initiliazeButtons();
            tipe_ = sTipe;
            this.Text = "Stock Awal " + sTipe + " - "
                        + DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void frmLihatTotal_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            // TODO: This line of code loads data into the 'sinarekDataSet.producttotal' table. You can move, or remove it, as needed.
            this.producttotalTableAdapter.Fill(this.sinarekDataSet.producttotal);
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

                //rddNama.FindItemExact(NBConfig.ValidUserName, false).Selected = true;
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
            // TODO: This line of code loads data into the 'sinarekDataSet.producttotal' table. You can move, or remove it, as needed.
            this.producttotalTableAdapter.Fill(this.sinarekDataSet.producttotal);
            //this.producttotaluserTableAdapter.FillByTipe(this.sinarekDataSet.producttotaluser
            //                                        ,int.Parse(rddTipe.SelectedValue.ToString())
            //                                        ,DateTime.Now
            //                                        ,rddNama.Text);
            this.Text = "Stock " + rddTipe.Text + " - "
                        + dtpTanggal.Value.ToString("dd-MMM-yyyy");

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            //frmAddStockTotal frm = new frmAddStockTotal(int.Parse(rddTipe.SelectedValue.ToString())
            //    ,dtpTanggal.Value,rddNama.Text);
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.ShowDialog(this);
            // TODO: This line of code loads data into the 'sinarekDataSet.producttotal' table. You can move, or remove it, as needed.
            this.producttotalTableAdapter.Fill(this.sinarekDataSet.producttotal);
            //this.producttotalTableAdapter.FillByTipe(this.sinarekDataSet.producttotaluser
            //                                        , int.Parse(rddTipe.SelectedValue.ToString())
            //                                        , dtpTanggal.Value
            //                                        , rddNama.Text);
        }

        private void radGridView1_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            //Remove data from database
            //using (sinarekDataSetTableAdapters.producttotaluserTableAdapter tbl = new sinarekDataSetTableAdapters.producttotaluserTableAdapter())
            //{
            //    try
            //    {
            //        tbl.DeleteProductTotalUser(int.Parse(e.Rows[0].Cells["totalid"].Value.ToString()));
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Ada masalah dengan penghapusan sisa barang.", "SMS - Error Notification");
            //        e.Cancel = true;
            //    }
            //}
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

        #region "Methods"
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            bool add = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "add");
            bool edit = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "edit");
            bool delete = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "delete");

            btnPrint.Enabled = delete;
            btnPrint.Visible = delete;
            rddTipe.Enabled = delete;
            dtpTanggal.Enabled = delete;
            //rddNama.Enabled = delete;
        }
        private void ResetFields()
        {

        }
        #endregion

        private void rddNama_SelectedValueChanged(object sender, EventArgs e)
        {
            //if(rddTipe.SelectedValue != null)
            //{           
            //    this.producttotaluserTableAdapter.FillByTipe(this.sinarekDataSet.producttotaluser
            //                                            , int.Parse(rddTipe.SelectedValue.ToString())
            //                                            , dtpTanggal.Value
            //                                            , rddNama.Text);            
            //}
            
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            if (rddTipe.SelectedValue != null)
            {
                producttotalBindingSource.Filter = "tanggal = '" + dtpTanggal.Value.ToString("dd-MMM-yyyy") + "'"; 

                //this.producttotaluserTableAdapter.FillByTipe(this.sinarekDataSet.producttotaluser
                //                                        , int.Parse(rddTipe.SelectedValue.ToString())
                //                                        , dtpTanggal.Value
                //                                        , rddNama.Text);
                this.Text = "Laporan Stock " + rddTipe.Text + " - "
                        + dtpTanggal.Value.ToString("dd-MMM-yyyy");
            }
        }
    }
}
