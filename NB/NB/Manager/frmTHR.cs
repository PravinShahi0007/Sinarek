using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

using MySql.Data;
using MySql.Data.MySqlClient;
using lihatgaji;
using Telerik.Reporting;
using Telerik.Reporting.Processing;
using System.Drawing.Printing;
namespace NB
{
    public partial class frmTHR : Telerik.WinControls.UI.RadForm
    {
        /// <summary>
        /// THR is Paid once in a year
        /// It is calculated according to the date the member started working.
        /// Members who work less than a year will have a 
        /// </summary>
        public frmTHR()
        {
            InitializeComponent();
        }

        private void frmTHR_Load(object sender, EventArgs e)
        {
            FillDataTHR();
            this.tipememberTableAdapter.Fill(this.sinarekDataSet.tipemember);
            this.memberTableAdapter.Fill(this.sinarekDataSet.member);

            //chkBayarOleh.Checked = true;
            //chkBayarRincian.Checked = true;
            //chkBayarTotal.Checked = true;
            
        }

        private void btnCreateTHR_Click(object sender, EventArgs e)
        {
            //if (radGridView1.Rows.Count == 0)
            //{
                using (MySqlConnection oConn = new MySqlConnection())
                {
                    oConn.ConnectionString = ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString;
                    MySqlCommand cmd = new MySqlCommand("pCreateTHR", oConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("PaidDate_", dtpTanggal.Value);
                    cmd.Parameters.AddWithValue("UMP_", decimal.Parse(txtUMP.Value.ToString()));
                    cmd.Parameters.AddWithValue("thrid_", 4);
                    cmd.Parameters.AddWithValue("user_", NBConfig.ValidUserName);
                    oConn.Open();
                    cmd.ExecuteNonQuery();
                    oConn.Close();
                }
            //}
            //else
            //{
            //    //Recalculate THR instead
            //    helper.NotifMessage("THR has been created. Please recalculate to change THR values");
            //}

            FillDataTHR();
        }

        private void FillDataTHR()
        {
            using (MySqlConnection oConn = new MySqlConnection())
            {
                oConn.ConnectionString = ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString;
                MySqlDataAdapter cmd = new MySqlDataAdapter("call pGetDataTHR("+ dtpTahun.Value.Year +")", oConn);
                DataTable dt = new DataTable("Result");
                cmd.Fill(dt);
                radGridView1.DataSource = null;
                BindingSource src = new BindingSource();
                src.DataSource = dt;
                if (rddTipe.SelectedValue != null)
                {
                    src.Filter = "tipememberid = " + rddTipe.SelectedValue.ToString();

                    rptGajiTHR rpt = (rptGajiTHR)reportViewer1.Report;
                    rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                    rpt.ReportParameters["tipepembayaranid"].Value = 4;
                    rpt.ReportParameters["templateid"].Value = rddTipe.SelectedValue;
                    reportViewer1.RefreshReport();
                }
                radGridView1.DataSource = src;
            }
            if (radGridView1.Rows.Count > 0)
            {
                dtpTanggal.Value = DateTime.Parse(radGridView1.Rows[0].Cells["tanggal"].Value.ToString());
                
            }
            else
            {
                dtpTanggal.ResetText();
            }
        }

        private void rddTipe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (radGridView1.Rows.Count > 1 && rddTipe.SelectedValue != null)
            {
                BindingSource src = (BindingSource)radGridView1.DataSource;
                src.Filter = "tipememberid = " + rddTipe.SelectedValue.ToString();

                rptGajiTHR rpt = (rptGajiTHR)reportViewer1.Report;
                rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                rpt.ReportParameters["tipepembayaranid"].Value = 4;
                rpt.ReportParameters["templateid"].Value = (chkBayarOleh.Checked ? -1 : -2);
                reportViewer1.RefreshReport();
            }
        }

        private void radGridView1_RowsChanged(object sender, Telerik.WinControls.UI.GridViewCollectionChangedEventArgs e)
        {
            if (e.Action == Telerik.WinControls.Data.NotifyCollectionChangedAction.Reset || e.Action == Telerik.WinControls.Data.NotifyCollectionChangedAction.Move)
            {
                foreach (GridViewRowInfo row in radGridView1.Rows)
                {
                    row.Cells["noRow"].Value = row.Index + 1;
                }
            }
        }

        private void radGridView1_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            switch(e.Column.Name.ToLower())
            {
                case "thrvalue" :            
                    using (sinarekDataSetTableAdapters.rinciangajiTableAdapter tbl = new sinarekDataSetTableAdapters.rinciangajiTableAdapter())
                    {
                        tbl.UpdateRincianGaji(int.Parse(e.Row.Cells["memberid"].Value.ToString())
                            , 35
                            , 1
                            , decimal.Parse(e.Row.Cells["thrvalue"].Value.ToString())
                            , "THR"
                            , NBConfig.ValidUserName
                            , int.Parse(e.Row.Cells["thrid"].Value.ToString()));
                    }
                    FillDataTHR();
                    break;
                case "bonusvalue":
                    
                    using (sinarekDataSetTableAdapters.rinciangajiTableAdapter tbl = new sinarekDataSetTableAdapters.rinciangajiTableAdapter())
                    {
                        tbl.UpdateRincianGaji(int.Parse(e.Row.Cells["memberid"].Value.ToString())
                            , 36
                            , 1
                            , decimal.Parse(e.Row.Cells["bonusvalue"].Value.ToString())
                            , "Bonus"
                            , NBConfig.ValidUserName
                            , int.Parse(e.Row.Cells["bonusid"].Value.ToString()));
                    }
                    FillDataTHR();
                    break;
                case "calculator":
                    if (e.Row.Cells["calculator"].Value != null)
                    {
                        decimal total = decimal.Parse(e.Row.Cells["calculator"].Value.ToString());
                        decimal thr = decimal.Parse(e.Row.Cells["thrvalue"].Value.ToString());
                        decimal bonus = total - thr;
                        using (sinarekDataSetTableAdapters.rinciangajiTableAdapter tbl = new sinarekDataSetTableAdapters.rinciangajiTableAdapter())
                        {
                            tbl.UpdateRincianGaji(int.Parse(e.Row.Cells["memberid"].Value.ToString())
                                , 36
                                , 1
                                , bonus
                                , "Bonus"
                                , NBConfig.ValidUserName
                                , int.Parse(e.Row.Cells["bonusid"].Value.ToString()));
                        }
                        FillDataTHR();
                    }
                break;
                case "bayaradmin":
            
                using (sinarekDataSetTableAdapters.rinciangajiTableAdapter tbl = new sinarekDataSetTableAdapters.rinciangajiTableAdapter())
                {
                    tbl.UpdateBayarTHR((e.Value.ToString().ToLower() == "1" ? -2 : -1), int.Parse(e.Row.Cells["bonusid"].Value.ToString()));
                    tbl.UpdateBayarTHR((e.Value.ToString().ToLower() == "1" ? -2 : -1), int.Parse(e.Row.Cells["thrid"].Value.ToString()));
                }
                FillDataTHR();
                break;               
            }
            if (rowindex != -1)
            {
                radGridView1.Rows[rowindex].Cells[columnindex].IsSelected = true;
                radGridView1.CurrentRow = radGridView1.Rows[rowindex];
            }
        }

        private void chkBayarOleh_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            rptGajiTHR rpt = (rptGajiTHR)reportViewer1.Report;
            rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
            rpt.ReportParameters["tipepembayaranid"].Value = 4;
            rpt.ReportParameters["templateid"].Value = (chkBayarOleh.Checked ? -2 : -1);
            int tahun = 0;
            if (dtpTahun.Value == null)
            {
                dtpTahun.Value = DateTime.Now;
            }
            tahun = dtpTahun.Value.Year;
            rpt.ReportParameters["tahun"].Value = tahun;
            reportViewer1.RefreshReport();
            //RefreshReportViewer();
        }

        private void chkBayarTotal_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            rptGajiTHRSummary rpt = (rptGajiTHRSummary)reportViewer2.Report;
            rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
            rpt.ReportParameters["tipepembayaranid"].Value = 4;
            rpt.ReportParameters["templateid"].Value = (chkBayarTotal.Checked ? -2 : -1);
            int tahun = 0;
            if (dtpTahun.Value == null)
            {
                dtpTahun.Value = DateTime.Now;
            }
            tahun = dtpTahun.Value.Year;
            rpt.ReportParameters["tahun"].Value = tahun;
            reportViewer2.RefreshReport();
            //RefreshReportViewer();
        }

        private void chkBayarRincian_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            rptGajiTHRTotal rpt = (rptGajiTHRTotal)reportViewer3.Report;
            rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
            rpt.ReportParameters["tipepembayaranid"].Value = 4;
            rpt.ReportParameters["templateid"].Value = (chkBayarRincian.Checked ? -2 : -1);
            int tahun = 0;
            if (dtpTahun.Value == null)
            {
                dtpTahun.Value = DateTime.Now;
            }
            tahun = dtpTahun.Value.Year;
            rpt.ReportParameters["tahun"].Value = tahun;
            reportViewer3.RefreshReport();
            //RefreshReportViewer();
        }

        private void radGridView1_CustomFiltering(object sender, GridViewCustomFilteringEventArgs e)
        {
            
        }

        private void btnPrintSlip_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Print Slip THR. Siap kan kertas di printer."
                              , "Print Slip THR"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Question
                              , MessageBoxDefaultButton.Button2
                              , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Print Slip Gaji                
                rptGajiTHR gj = new rptGajiTHR();
                gj.ReportParameters["templateid"].Value = (chkBayarOleh.Checked ? -2 : -1);
                gj.ReportParameters["tipepembayaranid"].Value = 4;
                gj.ReportParameters["User"].Value = NBConfig.ValidUserName;
                int tahun = 0;
                if (dtpTahun.Value == null)
                {
                    dtpTahun.Value = DateTime.Now;
                }
                tahun = dtpTahun.Value.Year;
                gj.ReportParameters["tahun"].Value = tahun;
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
            }
        }

        private void btnPrintTotal_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Print Total THR. Siap kan kertas di printer."
                              , "Print Total THR"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Question
                              , MessageBoxDefaultButton.Button2
                              , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Print Slip Gaji                
                rptGajiTHRSummary gj = new rptGajiTHRSummary();
                gj.ReportParameters["templateid"].Value = (chkBayarTotal.Checked ? -2 : -1); ;
                gj.ReportParameters["tipepembayaranid"].Value = 4;
                gj.ReportParameters["User"].Value = NBConfig.ValidUserName;
                int tahun = 0;
                if (dtpTahun.Value == null)
                {
                    dtpTahun.Value = DateTime.Now;
                }
                tahun = dtpTahun.Value.Year;
                gj.ReportParameters["tahun"].Value = tahun;
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
            }
        }

        private void btnPrintTotalRincian_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Print Total THR. Siap kan kertas di printer."
                              , "Print Total THR"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Question
                              , MessageBoxDefaultButton.Button2
                              , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Print Slip Gaji                
                rptGajiTHRTotal gj = new rptGajiTHRTotal();
                gj.ReportParameters["templateid"].Value = (chkBayarRincian.Checked ? -2 : -1); ;
                gj.ReportParameters["tipepembayaranid"].Value = 4;
                gj.ReportParameters["User"].Value = NBConfig.ValidUserName;
                int tahun = 0;
                if (dtpTahun.Value == null)
                {
                    dtpTahun.Value = DateTime.Now;
                }
                tahun = dtpTahun.Value.Year;
                gj.ReportParameters["tahun"].Value = tahun;
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
            }
        }

        private void btnPrintNama_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Print Slip THR. Siap kan kertas di printer."
                              , "Print Slip THR"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Question
                              , MessageBoxDefaultButton.Button2
                              , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Print Slip Gaji                
                rptGajiTHRNama gj = new rptGajiTHRNama();
                gj.ReportParameters["templateid"].Value = (chkBayarOleh.Checked ? -2 : -1);
                gj.ReportParameters["tipepembayaranid"].Value = 4;
                gj.ReportParameters["User"].Value = NBConfig.ValidUserName;
                gj.ReportParameters["memberid"].Value = rddMember.SelectedValue;
                int tahun = 0;
                if (dtpTahun.Value == null)
                {
                    dtpTahun.Value = DateTime.Now;
                }
                tahun = dtpTahun.Value.Year;
                gj.ReportParameters["tahun"].Value = tahun;
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
            }
        }

        private void RefreshReportViewer()
        {
            if (dtpTahun.Value == null)
            {
                dtpTahun.Value = DateTime.Now;
            }

            switch (radPageView1.SelectedPage.Name.ToLower())
            {
                case "rpvinput":
                    break;
                case "rpvtotals":
                    //Print Slip Gaji                
                    //rptGajiTHRTotal gj = new rptGajiTHRTotal();
                    rptGajiTHRSummary gj = (rptGajiTHRSummary)reportViewer2.Report;
                    gj.ReportParameters["templateid"].Value = (chkBayarRincian.Checked ? -2 : -1); ;
                    gj.ReportParameters["tipepembayaranid"].Value = 4;
                    gj.ReportParameters["User"].Value = NBConfig.ValidUserName;
                    int tahun = 0;
                    tahun = dtpTahun.Value.Year;
                    gj.ReportParameters["tahun"].Value = tahun;
                    reportViewer2.RefreshReport();
                    break;
                case "rpvrincian":
                    //Print Slip Gaji                
                    rptGajiTHRTotal gj2 = (rptGajiTHRTotal)reportViewer3.Report;
                    gj2.ReportParameters["templateid"].Value = (chkBayarOleh.Checked ? -2 : -1);
                    gj2.ReportParameters["tipepembayaranid"].Value = 4;
                    gj2.ReportParameters["User"].Value = NBConfig.ValidUserName;
                    tahun = 0;
                    tahun = dtpTahun.Value.Year;
                    gj2.ReportParameters["tahun"].Value = tahun;
                    reportViewer3.RefreshReport();
                    break;
                case "rpvpreview":
                    //Print Slip Gaji                
                    rptGajiTHR gj3 = (rptGajiTHR)reportViewer1.Report; ;
                    gj3.ReportParameters["templateid"].Value = (chkBayarOleh.Checked ? -2 : -1);
                    gj3.ReportParameters["tipepembayaranid"].Value = 4;
                    gj3.ReportParameters["User"].Value = NBConfig.ValidUserName;
                    //gj3.ReportParameters["memberid"].Value = rddMember.SelectedValue;
                    tahun = 0;
                    tahun = dtpTahun.Value.Year;
                    gj3.ReportParameters["tahun"].Value = tahun;
                    reportViewer1.RefreshReport();
                    break;
            }
        }
        
        private void dtpTahun_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTahun.Value != null)
            {
                FillDataTHR();
                RefreshReportViewer();
            }
        }

        private void radGridView1_FilterChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (e.Action == Telerik.WinControls.Data.NotifyCollectionChangedAction.Reset || e.Action == Telerik.WinControls.Data.NotifyCollectionChangedAction.Move)
            {
                foreach (GridViewRowInfo row in radGridView1.Rows)
                {
                    row.Cells["noRow"].Value = row.Index + 1;
                }
            }
        }

        private void radGridView1_SortChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (e.Action == Telerik.WinControls.Data.NotifyCollectionChangedAction.Reset || e.Action == Telerik.WinControls.Data.NotifyCollectionChangedAction.Move)
            {
                foreach (GridViewRowInfo row in radGridView1.Rows)
                {
                    row.Cells["noRow"].Value = row.Index + 1;
                }
            }
        }

        private void radPageView1_PageIndexChanged(object sender, RadPageViewIndexChangedEventArgs e)
        {

        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            RefreshReportViewer();
        }
    }
}
