using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using lihatgaji;
using Telerik.Reporting;
using Telerik.Reporting.Processing;
using System.Drawing.Printing;

namespace NB
{
    public partial class frmGajiSatpam : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool edit_;
        private bool delete_;

        public frmGajiSatpam()
        {
            InitializeComponent();


            rptGajiOther rpt = new rptGajiOther();
            reportViewer1.Report = rpt;
            rpt.ReportParameters["TipeMember"].Visible = false;
            rpt.ReportParameters["TipeMember"].Value = "satpam";
            rpt.ReportParameters["GBID"].Value = NBConfig.IGBID;
            rpt.ReportParameters["MemberID"].Value = -1;
            rpt.ReportParameters["User"].Value = NBConfig.ValidUserName;
        }

        private void InitializeButton()
        {
            string frmName = this.GetType().Name;
            add_ = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "add");
            edit_ = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "edit");
            delete_ = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "delete");

            radGroupBox1.Enabled = add_;
            btnPrintSlip.Enabled = add_;
            btnPrintTotal.Enabled = add_;
        }

        private void frmGajiSatpam_Load(object sender, EventArgs e)
        {
            InitializeButton();

            reportViewer1.RefreshReport();
            reportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            reportViewer1.ZoomPercent = 75;
        }

        private void AddDetail(int TipeID_,decimal value_,string Title)
        {
            frmAddGajiDetailSatpam frm = new frmAddGajiDetailSatpam(TipeID_
                , " Input " + Title
                , value_);
            frm.ShowDialog(this);

            //refresh report
            reportViewer1.RefreshReport();
        }

        private void btnPrintTotal_Click(object sender, EventArgs e)
        {
            DialogResult res = RadMessageBox.Show("Print Total Gaji Satpam. Siap kan kertas di printer."
                              , "Print Total Gaji Satpam"
                              , MessageBoxButtons.OKCancel
                              , RadMessageIcon.Question
                              , MessageBoxDefaultButton.Button2);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Print Slip Gaji                
                rptGajiOtherSummary ab = new rptGajiOtherSummary();
                ab.ReportParameters[0].Value = "satpam";
                ab.ReportParameters[1].Value = NBConfig.IGBID;
                ab.ReportParameters["User"].Value = NBConfig.ValidUserName;

                IReportDocument report1 = (IReportDocument)ab;
                ////set parameters when necessary

                //// PrinterSettings 
                PrinterSettings printerSettings = new PrinterSettings();
                //// Adjust the printer settings if necessary...

                // Print the report using the printer settings.
                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(report1, printerSettings);

                helper.PrintLog(this.Text, ab.Name, "Satpam ; GBID = " + NBConfig.IGBID.ToString());
            }
        }

        private void btnPrintSlip_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Print Slip Gaji Satpam. Siap kan kertas di printer."
                              , "Print Slip Gaji Satpam"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Question
                              , MessageBoxDefaultButton.Button2
                              , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Print Slip Gaji                
                rptGajiOther ab = new rptGajiOther();
                ab.ReportParameters[0].Value = "satpam";
                ab.ReportParameters[1].Value = NBConfig.IGBID;
                ab.ReportParameters[2].Value = -1;
                ab.ReportParameters["User"].Value = NBConfig.ValidUserName;
                IReportDocument report1 = (IReportDocument)ab;
                ////set parameters when necessary

                //// PrinterSettings 
                PrinterSettings printerSettings = new PrinterSettings();
                //// Adjust the printer settings if necessary...

                // Print the report using the printer settings.
                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(report1, printerSettings);

                helper.PrintLog(this.Text, ab.Name, "Satpam ; GBID = " + NBConfig.IGBID.ToString());
            }
        }

        private void btnAngsuran_Click(object sender, EventArgs e)
        {
            AddDetail(int.Parse(btnAngsuran.Tag.ToString()), 0, "Angsuran Pinjaman");
        }

        private void btnTambahan_Click(object sender, EventArgs e)
        {
            AddDetail(int.Parse(btnTambahan.Tag.ToString()), 0, "Tambahan");
        }

        private void btnPanjar_Click(object sender, EventArgs e)
        {
            AddDetail(int.Parse(btnPanjar.Tag.ToString()), 0, "Panjar");
        }

        private void btnInputLembur_Click(object sender, EventArgs e)
        {
            AddDetail(int.Parse(btnInputLembur.Tag.ToString()), 10380, "Lembur");
        }

        private void btnPotongan_Click(object sender, EventArgs e)
        {
            AddDetail(int.Parse(btnPotongan.Tag.ToString()), 10380, "Potongan");
        }

    }
}
