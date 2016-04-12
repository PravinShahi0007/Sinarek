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
    public partial class frmAbsenStaff : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool edit_;
        private bool delete_;

        public frmAbsenStaff()
        {
            InitializeComponent();                        
        }

        private void frmAbsenStaff_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            SetDefaults();

            this.gajibulananTableAdapter.Fill(this.fingermachDataSet.gajibulanan);
            this.staffTableAdapter.Fill(this.fingermachDataSet.staff);
            this.tipehadirTableAdapter.Fill(this.sinarekDataSet.tipehadir);
            rddGBID.SelectedValue = NBConfig.IGBID;
        }

        private void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {
            absenbulananBindingSource.Filter = "tanggal = '" + radCalendar1.SelectedDate.ToString("yyyy-MM-dd") +"'";
        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int iTipeHadir = int.Parse(e.Row.Cells["tipehadirid"].Value.ToString());
            int iAbsenId = int.Parse(e.Row.Cells["ABId"].Value.ToString());
            absenbulananTableAdapter.UpdateAbsenBulanan(iTipeHadir, NBConfig.ValidUserName, e.Row.Cells["keterangan"].Value.ToString(), iAbsenId);
            int rowIndex = e.RowIndex;

            this.fingermachDataSet.absenbulanan.Clear();
            this.fingermachDataSet.vsummaryabsenbulanan.Clear();
            this.vsummaryabsenbulananTableAdapter.Fill(this.fingermachDataSet.vsummaryabsenbulanan, "staff", NBConfig.IGBID);
            this.absenbulananTableAdapter.FillByGBID(this.fingermachDataSet.absenbulanan, NBConfig.IGBID, "staff");
            absenbulananBindingSource.Filter = "tanggal = '" + radCalendar1.SelectedDate.ToString("yyyy-MM-dd") + "'";
            radGridView1.Refresh();
            radGridView2.Refresh();
        }

        private void radGridView2_SelectionChanged(object sender, EventArgs e)
        {
            string keterangan1 = radGridView2.SelectedRows[0].Cells["ketcuti"].Value.ToString();
            string keterangan2 = radGridView2.SelectedRows[0].Cells["ketijin"].Value.ToString();
            string keterangan3 = radGridView2.SelectedRows[0].Cells["ketsakit"].Value.ToString();
            string keterangan4 = radGridView2.SelectedRows[0].Cells["ketalpa"].Value.ToString();
            string keterangan5 = radGridView2.SelectedRows[0].Cells["ketcutitahunan"].Value.ToString();
            string ket = string.Empty;
            string[] list = { (string.IsNullOrEmpty(keterangan4)?null:keterangan4)
                                ,(string.IsNullOrEmpty(keterangan1)?null:keterangan1)
                                ,(string.IsNullOrEmpty(keterangan2)?null:keterangan2)
                                ,(string.IsNullOrEmpty(keterangan3)?null:keterangan3)
                                ,(string.IsNullOrEmpty(keterangan5)?null:keterangan5)};
            ket = string.Join("/", list);
            char[] chr = { '/' };
            list = ket.Split(chr, StringSplitOptions.RemoveEmptyEntries);
            txtInfo.Lines = list;
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Print Absen Staff. Siap kan kertas di printer."
                              , "Print Absen Staff"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Question
                              , MessageBoxDefaultButton.Button2
                              , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Print Slip Gaji                
                rptAbsenOther ab = new rptAbsenOther();
                ab.ReportParameters[0].Value = "staff";
                ab.ReportParameters[1].Value = rddGBID.SelectedValue;
                IReportDocument report1 = (IReportDocument)ab;
                ////set parameters when necessary

                //// PrinterSettings 
                PrinterSettings printerSettings = new PrinterSettings();
                //// Adjust the printer settings if necessary...

                // Print the report using the printer settings.
                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(report1, printerSettings);

                helper.PrintLog(this.GetType().Name, ab.Name, "GBID:" + rddGBID.SelectedValue.ToString());
            }
        }

        private void rddGBID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddGBID.SelectedValue != null)
            {
                this.absenbulananTableAdapter.FillByGBID(this.fingermachDataSet.absenbulanan, int.Parse(rddGBID.SelectedValue.ToString()), "staff");
                this.vsummaryabsenbulananTableAdapter.Fill(this.fingermachDataSet.vsummaryabsenbulanan, "staff", int.Parse(rddGBID.SelectedValue.ToString()));
                int month = DateTime.Parse(rddGBID.SelectedText).Month;
                int year = DateTime.Parse(rddGBID.SelectedText).Year;

                DateTime mindate = DateTime.Parse(month.ToString() + "/01/" + year.ToString());
                DateTime maxdate = mindate.AddMonths(1).AddDays(-1);

                //Set calendar for current month only
                radCalendar1.RangeMinDate = mindate;
                radCalendar1.RangeMaxDate = maxdate;
                radCalendar1.SelectedDate = mindate.Date;
                radCalendar1.FocusedDate = mindate.Date;
            }
        }
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            helper.GetPermissions(frmName, this.Tag.ToString(), out add_, out edit_, out delete_);
        }

        private void SetDefaults()
        {
            rddGBID.Enabled = delete_;
        }
    }
}
