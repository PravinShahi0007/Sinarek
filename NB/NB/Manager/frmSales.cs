using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using lihatgaji;
using Telerik.Reporting;
using Telerik.Reporting.Processing;
using System.Drawing.Printing;
namespace NB
{
    public partial class frmSales : Telerik.WinControls.UI.RadForm
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
           
                this.gajibulananTableAdapter.Fill(this.sinarekDataSet.gajibulanan);
                this.salesTableAdapter.Fill(this.sinarekDataSet.sales);
                rddBulanan.SelectedValue = NBConfig.IGBID;
                DataRowView row = (DataRowView)rddBulanan.SelectedItem.DataBoundItem;
                lblCurrent.Text = "Current Month : " + DateTime.Parse(row.Row["startdate"].ToString()).ToString("MMM yyyy");
            
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            this.salesTableAdapter.Update(this.sinarekDataSet.sales);
            this.salesTableAdapter.Fill(this.sinarekDataSet.sales);
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            if (cell.CommandButton.Text.ToLower().Contains("report"))
            {
                DataRowView row = (DataRowView)rddBulanan.SelectedItem.DataBoundItem;
                DataRowView rowSales = (DataRowView)cell.RowInfo.DataBoundItem;
                frmSalesPerformanceReview frm = new frmSalesPerformanceReview(rowSales.Row,row.Row);
                frm.ShowDialog(this);

                this.salescomissionTableAdapter.FillByGBID(this.sinarekDataSet.salescomission
                , int.Parse(rddBulanan.SelectedValue.ToString()));

            }

        }

        private void rddBulanan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddBulanan.SelectedValue != null)
            {
                try
                {
                    this.salescomissionTableAdapter.FillByGBID(this.sinarekDataSet.salescomission
                        , int.Parse(rddBulanan.SelectedValue.ToString()));
                    rptGajiKomisi1.ReportParameters["GBID"].Value = rddBulanan.SelectedValue;
                }
                catch (Exception ex)
                {
                    helper.ErrorMessage(ex.Message + " " + ex.StackTrace);
                }

            }
        }

        private void radGridView1_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Reset)
            {
                foreach (GridViewRowInfo row in radGridView1.Rows)
                {
                    row.Cells["norow"].Value = row.Index + 1;
                }
            }
        }

        private void btnPrintSlip_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Print Slip Gaji. Siap kan kertas di printer."
                              , "Print Slip Gaji"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Question
                              , MessageBoxDefaultButton.Button2
                              , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Print Slip Gaji                
                rptGajiKomisi gj = new rptGajiKomisi();
                gj.ReportParameters["GBID"].Value = rddBulanan.SelectedValue;
                gj.ReportParameters["User"].Value = NBConfig.ValidUserName;
                IReportDocument report1 = (IReportDocument)gj;
                ////set parameters when necessary

                //// PrinterSettings 
                PrinterSettings printerSettings = new PrinterSettings();
                //// Adjust the printer settings if necessary...

                InstanceReportSource reportSource = new InstanceReportSource();
                reportSource.ReportDocument = report1;
                // Print the report using the printer settings.
                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(reportSource, printerSettings);

                ////process printed
                //if (!NBConfig.GetGBIDPrintedOther())
                //{
                //    using (sinarekDataSetTableAdapters.gajibulananTableAdapter gb = new sinarekDataSetTableAdapters.gajibulananTableAdapter())
                //    {
                //        gb.UpdatePrintedOther(NBConfig.ValidUserName, NBConfig.IGBID);
                //    }
                //    SetPrintedForms();
                //    helper.NotifMessage("Data Gaji telah terkunci dan tidak dapat di ubah lagi.");
                //}
            }
        }
    }
}
