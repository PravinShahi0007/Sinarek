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
    public partial class frmRes : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool edit_;
        private bool delete_;

        public frmRes()
        {
            InitializeComponent();
        }

        private void frmRes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.gajibulanan' table. You can move, or remove it, as needed.
            this.gajibulananTableAdapter.Fill(this.sinarekDataSet.gajibulanan);
            this.sopirTableAdapter.Fill(this.sinarekDataSet.sopir);

            rddGBID.SelectedValue = NBConfig.IGBID;
            RefreshReport();
            InitializeButtons();

        }

        private void rddSopir_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddSopir.SelectedValue != null && rddGBID.SelectedValue != null)
            {
                vlogproductresTableAdapter.FillBySopir(this.sinarekDataSet.vlogproductres
                    , int.Parse(rddSopir.SelectedValue.ToString())
                    , int.Parse(rddGBID.SelectedValue.ToString()));
                RefreshReport();
            }
        }

        private void rddGBID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddSopir.SelectedValue != null && rddGBID.SelectedValue != null)
            {
                vlogproductresTableAdapter.FillBySopir(this.sinarekDataSet.vlogproductres
                    , int.Parse(rddSopir.SelectedValue.ToString())
                    , int.Parse(rddGBID.SelectedValue.ToString()));
                RefreshReport();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult res = RadMessageBox.Show("Print Laporan Res Bulanan. Siap kan kertas di printer."
                              , "Print Laporan Res Bulanan"
                              , MessageBoxButtons.OKCancel
                              , RadMessageIcon.Question
                              , MessageBoxDefaultButton.Button2);

            if (res == System.Windows.Forms.DialogResult.OK)
            {               
                rptResBulanan rpt = new rptResBulanan();
                rpt.ReportParameters["GBID"].Value = rddGBID.SelectedValue;
                rpt.ReportParameters["User"].Value = NBConfig.ValidUserName;
                rpt.PageSettings.PaperKind = PaperKind.A4;
                IReportDocument report1 = (IReportDocument)rpt;
                ////set parameters when necessary

                //// PrinterSettings 
                PrinterSettings printerSettings = new PrinterSettings();
                //// Adjust the printer settings if necessary...

                // Print the report using the printer settings.
                InstanceReportSource reportSource = new InstanceReportSource();
                reportSource.ReportDocument = rpt;

                // Print the report using the printer settings.
                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(reportSource, printerSettings);

                helper.PrintLog(this.Text, rpt.Name, "GBID: " + NBConfig.IGBID);
            }
        }

        private void btnPrintLaporan_Click(object sender, EventArgs e)
        {
            DialogResult res = RadMessageBox.Show("Print Laporan Res Bulanan. Siap kan kertas di printer."
                              , "Print Laporan Res Bulanan"
                              , MessageBoxButtons.OKCancel
                              , RadMessageIcon.Question
                              , MessageBoxDefaultButton.Button2);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                rptResBulananSummary rpt = new rptResBulananSummary();
                rpt.ReportParameters["GBID"].Value = rddGBID.SelectedValue;
                rpt.ReportParameters["User"].Value = NBConfig.ValidUserName;
                IReportDocument report1 = (IReportDocument)rpt;
                ////set parameters when necessary

                //// PrinterSettings 
                PrinterSettings printerSettings = new PrinterSettings();
                //// Adjust the printer settings if necessary...

                InstanceReportSource reportSource = new InstanceReportSource();
                reportSource.ReportDocument = report1;

                // Print the report using the printer settings.
                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(reportSource, printerSettings);

                helper.PrintLog(this.Text, rpt.Name, "GBID: " + NBConfig.IGBID);
            }
        }

        private void RefreshReport()
        {
            rptResSopir rpt = (rptResSopir)reportViewer1.Report;
            rpt.ReportParameters["SopirID"].Value = rddSopir.SelectedValue;
            rpt.ReportParameters["GBID"].Value = rddGBID.SelectedValue;
            rpt.ReportParameters["User"].Value = NBConfig.ValidUserName;
            reportViewer1.RefreshReport();
        }

        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            helper.GetPermissions(frmName, this.Tag.ToString(), out add_, out edit_, out delete_);
            add_ = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "add");
            edit_ = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "edit");
            delete_ = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "delete");

            rddGBID.Enabled = edit_ || delete_;
            btnPrint.Enabled = delete_;
            btnPrintLaporan.Enabled = delete_;
    
        }
    }
}
