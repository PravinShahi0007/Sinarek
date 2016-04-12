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

using System.IO;

namespace NB
{
    public partial class frmGajiBulanan : Telerik.WinControls.UI.RadForm
    {
        string gajiCurrentFilter = "";
        private bool add_ =false
            , edit_ = false
            , delete_ = false;
        public frmGajiBulanan()
        {
            InitializeComponent();

            #region "Gaji"
            //Add Default test if gaji has been paid
            this.radGridView1.Text = "Gaji minggu ini sudah di bayar"; 
            //Add Total info         
            this.radGridView1.GroupDescriptors[0].Aggregates.Add("sum(unit*unitvalue)");
            this.radGridView1.GroupDescriptors[0].Format = "Nama : {1} - {2:Rp #,###.00}";
            this.radGridView2.GroupDescriptors[0].Aggregates.Add("sum(unit*unitvalue)");
            this.radGridView2.GroupDescriptors[0].Aggregates.Add("count(rinciangajiid)");
            this.radGridView2.GroupDescriptors[0].Format = "{1} ({3}) - {2:Rp #,###.00}";

            //Set Event for Gaji Radio Button
            radRadioButtonNama.Click +=new EventHandler(rbFilterGaji_Click);
            radRadioButtonTipe.Click += new EventHandler(rbFilterGaji_Click);
            radRadioButtonNama.ToggleStateChanged +=new StateChangedEventHandler(rbFilterGaji_ToggleStateChanged);
            radRadioButtonTipe.ToggleStateChanged += new StateChangedEventHandler(rbFilterGaji_ToggleStateChanged);
            #endregion
        }

        private void initializeButtons()
        {
            string formName = this.GetType().Name;
            string MenuName = this.Tag.ToString();

            helper.GetPermissions(formName, MenuName, out add_, out edit_, out delete_);
            
        }

        private void SetDefault()
        {
            rddGajiMingguan.Enabled = delete_;
            radGridView1.Columns["cmdDel"].IsVisible = delete_;
            radGridView1.ReadOnly = !delete_;
            radGroupBox4.Enabled = delete_;
            processGaji.Enabled = delete_;
            btnDataAbsen.Enabled = delete_;
            if (!delete_)
            {
                tiperinciangajiBindingSource1.Filter = "systemonly = 0";                
            }
            else
            {
                
                tiperinciangajiBindingSource1.Filter = "";
            }
        }
        private void frmGaji_Load(object sender, EventArgs e)
        {
            initializeButtons();
            SetDefault();
            try
            {
                this.gajibulananTableAdapter.Fill(this.sinarekDataSet.gajibulanan);
                this.memberTableAdapter.Fill(this.sinarekDataSet.member);
                this.tiperinciangajiTableAdapter.Fill(this.sinarekDataSet.tiperinciangaji);
                rddGajiMingguan.SelectedValue = NBConfig.IGBID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " : " + ex.StackTrace);
            }
            //Always check if gaji has been printed
            if (NBConfig.GetGMIDPrinted())
            {
                SetPrintedForms();
            }
            
            //Setting for GAJI
            radRadioButtonNama.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            ddlNama2.ResetText();
            ddlTipe2.ResetText();
            //radGridView1.BestFitColumns();
            tipeRincianddl.SelectedValue = 12;          
        }
        private void SetPrintedForms()
        {
            //Set Input according to permission        
            btnBonus.Enabled = delete_;
                     
        }

        #region "GAJI"

        private void btnClear2_Click(object sender, EventArgs e)
        {
            ddlNama2.ResetText();
            ddlTipe2.ResetText();
            radRadioButtonNama.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            ddlNama2.Focus();
        }
        private void ddlNama2_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (ddlNama2.SelectedValue != null)
            {
               //vrinciangajiBindingSource.Filter = gajiCurrentFilter + " and memberid =" + ddlNama2.SelectedValue.ToString();
                gajiCurrentFilter = "gid = " + rddGajiMingguan.SelectedValue.ToString() + " and memberid =" + ddlNama2.SelectedValue.ToString();
            }
            else
            {
                //vrinciangajiBindingSource.Filter = gajiCurrentFilter;
                gajiCurrentFilter = "gid = " + rddGajiMingguan.SelectedValue.ToString() ;
            }
            vrinciangajiBindingSource3.Filter = gajiCurrentFilter;
        }
        private void ddlTipe2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ddlTipe2.SelectedValue != null)
            {
                gajiCurrentFilter = "gid = " + rddGajiMingguan.SelectedValue.ToString()  + " and tipeid =" + ddlTipe2.SelectedValue.ToString();
                //vrinciangajiBindingSource.Filter = gajiCurrentFilter + " and tipeid =" + ddlTipe2.SelectedValue.ToString();
            }
            else
            {
                gajiCurrentFilter = "gid = " + rddGajiMingguan.SelectedValue.ToString() ;
            }
            vrinciangajiBindingSource3.Filter = gajiCurrentFilter;
        }
        private void rbFilterGaji_Click(object sender, EventArgs e)
        {
            RadRadioButton rb = (RadRadioButton)sender;
            setGajiRadioButton(rb);
        }
        private void rbFilterGaji_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            RadRadioButton rb = (RadRadioButton)sender;
            setGajiRadioButton(rb);
        }
        private void setGajiRadioButton(RadRadioButton rb)
        {
            switch (rb.Text.Replace("&", "").ToLower())
            {
                case "nama":
                    ddlTipe2.Enabled = false;
                    ddlNama2.Enabled = true;
                    ddlNama2.Focus();
                    break;
                case "tipe":
                    ddlNama2.Enabled = false;
                    ddlTipe2.Enabled = true;
                    ddlTipe2.Focus();
                    break;
            }

        }        
        private void btnBonus_Click(object sender, EventArgs e)
        {
            //Always check if gaji total has been printed or not
            if (!NBConfig.GetGBIDPrintedOther())
            {
                if (delete_ || rddGajiMingguan.SelectedValue.ToString() == NBConfig.IGBID.ToString())
                {
                    frmAddGajiDetail frm = new frmAddGajiDetail(int.Parse(tipeRincianddl.SelectedValue.ToString())
                        , int.Parse(rddGajiMingguan.SelectedValue.ToString())
                        , 1
                        , tipeRincianddl.Text
                        , decimal.Parse(tipeRincianddl.Tag.ToString()));
                    frm.ShowDialog(this);

                    //refresh grid
                    this.vrinciangajiTableAdapter.FillByBulan(this.sinarekDataSet.vrinciangaji,int.Parse(rddGajiMingguan.SelectedValue.ToString()),1);
                }

            }
            else
            {
                SetPrintedForms();
                MessageBox.Show("Gaji Minggu ini telah di print maka input sudah tidak diperbolehkan"
                                 +"./nJika ada kesalahan harap dilaporkan.");
            }
        }
        
        #endregion

        #region "Print"

        private void btnDataAbsen_Click(object sender, EventArgs e)
        {
            ////On Printing Surat Jalan Make sure after printing surat jalan has been updated too 
            ////printed so the next time surat jalan is printing COPY is appended to the title.
            DialogResult res = MessageBox.Show("Print Data Absen. Siap kan kertas di printer."
                              , "Print Data Absen"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Question
                              , MessageBoxDefaultButton.Button2
                              , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Print Slip Gaji                
                rptKehadiran gj = new rptKehadiran();
                gj.ReportParameters[0].Value = NBConfig.IGMID;
                gj.ReportParameters["User"].Value = NBConfig.ValidUserName;
                IReportDocument report1 = (IReportDocument)gj;
                ////set parameters when necessary

                //// PrinterSettings 
                PrinterSettings printerSettings = new PrinterSettings();
                //// Adjust the printer settings if necessary...

                // Print the report using the printer settings.
                InstanceReportSource reportSource = new InstanceReportSource();
                reportSource.ReportDocument = report1;

                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(reportSource, printerSettings);
            }
        }
        
        private void btnRincian_Click(object sender, EventArgs e)
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
                rptGajiOther gj = new rptGajiOther();
                gj.ReportParameters["GBID"].Value = NBConfig.IGBID;
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
                
                //process printed
                if (!NBConfig.GetGBIDPrintedOther())
                {
                    using (sinarekDataSetTableAdapters.gajibulananTableAdapter gb = new sinarekDataSetTableAdapters.gajibulananTableAdapter())
                    {
                        gb.UpdatePrintedOther(NBConfig.ValidUserName,NBConfig.IGBID);
                    }
                    SetPrintedForms();
                    helper.NotifMessage("Data Gaji telah terkunci dan tidak dapat di ubah lagi.");
                }
            }
        }
        private void btnSummary_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Print Laporan Total Gaji. Siap kan kertas di printer."
                             , "Print Laporan Total Gaji"
                             , MessageBoxButtons.OKCancel
                             , MessageBoxIcon.Question
                             , MessageBoxDefaultButton.Button2
                             , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Print Summary Gaji
                rptGajiSummaryOther gj = new rptGajiSummaryOther();                
                gj.ReportParameters["GBID"].Value = rddGajiMingguan.SelectedValue;
                gj.ReportParameters["user"].Value = NBConfig.ValidUserName;
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

                //process printed
                if (!NBConfig.GetGBIDPrintedOther())
                {
                    using (sinarekDataSetTableAdapters.gajibulananTableAdapter gb = new sinarekDataSetTableAdapters.gajibulananTableAdapter())
                    {
                        gb.UpdatePrintedOther(NBConfig.ValidUserName, NBConfig.IGBID);
                    }
                    SetPrintedForms();
                    helper.NotifMessage("Data Gaji telah terkunci dan tidak dapat di ubah lagi.");
                }
            }
        }
        private void btnTotalRincian_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Print Laporan Rincian Total Gaji. Siap kan kertas di printer."
                             , "Print Laporan Rincian Total Gaji"
                             , MessageBoxButtons.OKCancel
                             , MessageBoxIcon.Question
                             , MessageBoxDefaultButton.Button2
                             , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Print Rincian Summary Gaji
                rptGajiTotalOther gj = new rptGajiTotalOther();
                gj.ReportParameters["GBID"].Value = rddGajiMingguan.SelectedValue;
                gj.ReportParameters["user"].Value = NBConfig.ValidUserName;
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

                //process printed
                if (!NBConfig.GetGBIDPrintedOther())
                {
                    using (sinarekDataSetTableAdapters.gajibulananTableAdapter gb = new sinarekDataSetTableAdapters.gajibulananTableAdapter())
                    {
                        gb.UpdatePrintedOther(NBConfig.ValidUserName, NBConfig.IGBID);
                    }
                    SetPrintedForms();
                    helper.NotifMessage("Data Gaji telah terkunci dan tidak dapat di ubah lagi.");
                }
            }
        }
        private void btPrintPages_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtFrom.Value.ToString()) > 0)
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
                    rptGajiOther gj = new rptGajiOther();
                    gj.ReportParameters["GBID"].Value = rddGajiMingguan.SelectedValue;
                    gj.ReportParameters["User"].Value = NBConfig.ValidUserName;
                    IReportDocument report1 = (IReportDocument)gj;
                    ////set parameters when necessary

                    //// PrinterSettings 
                    PrinterSettings printerSettings = new PrinterSettings();
                    printerSettings.DefaultPageSettings.PaperSize = new PaperSize("Mini Letter", 850, 550);
                    printerSettings.DefaultPageSettings.Margins.Top = 17;
                    printerSettings.DefaultPageSettings.Margins.Bottom = 17;
                    printerSettings.DefaultPageSettings.Margins.Left = 12;
                    printerSettings.DefaultPageSettings.Margins.Right = 12;

                    //// Adjust the printer settings if necessary...
                    printerSettings.PrintRange = PrintRange.SomePages;                     
                    printerSettings.FromPage = int.Parse(txtFrom.Value.ToString());
                    printerSettings.ToPage = int.Parse(txtTo.Value.ToString());

                    InstanceReportSource reportSource = new InstanceReportSource();
                    reportSource.ReportDocument = report1;
                    // Print the report using the printer settings.
                    ReportProcessor reportProcessor = new ReportProcessor();

                    reportProcessor.PrintReport(reportSource, printerSettings);

                    //process printed
                    if (!NBConfig.GetGBIDPrintedOther())
                    {
                        using (sinarekDataSetTableAdapters.gajibulananTableAdapter gb = new sinarekDataSetTableAdapters.gajibulananTableAdapter())
                        {
                            gb.UpdatePrintedOther(NBConfig.ValidUserName, NBConfig.IGBID);
                        }
                        SetPrintedForms();
                        helper.NotifMessage("Data Gaji telah terkunci dan tidak dapat di ubah lagi.");
                    }
                    
                }
            }
            else
            {
                //Silahkan pilih halaman untuk di print
                MessageBox.Show("Pilih halaman untuk di print!");
            }
        }
        private void txtFrom_ValueChanged(object sender, EventArgs e)
        {
            txtTo.Value = txtFrom.Value;
        }
        private void btnPrintNama_Click(object sender, EventArgs e)
        {
            if (rddMember.SelectedValue != null)
            {
                DialogResult res = MessageBox.Show("Print Slip Gaji Untuk " + rddMember.Text + ". Siap kan kertas di printer."
                      , "Print Slip Gaji Per Nama"
                      , MessageBoxButtons.OKCancel
                      , MessageBoxIcon.Question
                      , MessageBoxDefaultButton.Button2
                      , MessageBoxOptions.DefaultDesktopOnly);

                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    //Print Slip Gaji                
                    rptGajiMingguanNama gj = new rptGajiMingguanNama();
                    gj.ReportParameters["GMID"].Value = rddGajiMingguan.SelectedValue;
                    gj.ReportParameters["User"].Value = NBConfig.ValidUserName;
                    gj.ReportParameters["memberid"].Value = rddMember.SelectedValue;
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

                    //process printed
                    if (!NBConfig.GetGBIDPrintedOther())
                    {
                        using (sinarekDataSetTableAdapters.gajibulananTableAdapter gb = new sinarekDataSetTableAdapters.gajibulananTableAdapter())
                        {
                            gb.UpdatePrintedOther(NBConfig.ValidUserName, NBConfig.IGBID);
                        }
                        SetPrintedForms();
                        helper.NotifMessage("Data Gaji telah terkunci dan tidak dapat di ubah lagi.");
                    }
                }
            }

        }

        #endregion

        private void rddGajiMingguan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddGajiMingguan.SelectedValue != null)
            {
                vrinciangajiBindingSource3.Filter = "gid = " + rddGajiMingguan.SelectedValue.ToString() ;
                if (ddlTipe2.SelectedValue != null)
                {
                    vrinciangajiBindingSource3.Filter += " and tipeid =" + ddlTipe2.SelectedValue.ToString();
                }
                if (ddlNama2.SelectedValue != null)
                {
                    vrinciangajiBindingSource3.Filter += " and memberid =" + ddlNama2.SelectedValue.ToString();
                }
                this.vrinciangajiTableAdapter.FillByBulan(this.sinarekDataSet.vrinciangaji,int.Parse(rddGajiMingguan.SelectedValue.ToString()),1);

                rptGajiOther1.ReportParameters["GBID"].Value = rddGajiMingguan.SelectedValue;
                rptGajiOther1.ReportParameters["User"].Value = NBConfig.ValidUserName;
            }
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            if (cell.CommandButton.Text.ToLower() == "del")
            {
                this.rinciangajiTableAdapter.DeleteRincianGaji(int.Parse(cell.RowInfo.Cells["rinciangajiid"].Value.ToString()));
                this.vrinciangajiTableAdapter.FillByBulan(this.sinarekDataSet.vrinciangaji, int.Parse(rddGajiMingguan.SelectedValue.ToString()),2);
            }

        }

        private void btnGajiTemplate_Click(object sender, EventArgs e)
        {
            this.rinciangajiTableAdapter.pCreateDataGajiTemplateBulanan(int.Parse(rddGajiMingguan.SelectedValue.ToString())
                , 1, NBConfig.ValidUserName);
            this.vrinciangajiTableAdapter.FillByBulan(this.sinarekDataSet.vrinciangaji, int.Parse(rddGajiMingguan.SelectedValue.ToString()), 1);
            helper.SysLog(this.Tag.ToString(), "btnGajiTemplate_Click", "Process Gaji");
            helper.NotifMessage("Data Gaji Telah di perbaharui");
        }

        private void btnPinjaman_Click(object sender, EventArgs e)
        {
            //using (sinarekDataSetTableAdapters.pinjamanTableAdapter tbl = new sinarekDataSetTableAdapters.pinjamanTableAdapter())
            //{
            //    tbl.pProcessPinjaman(NBConfig.IGMID, NBConfig.ValidUserName);
            //}
            //this.vrinciangajiTableAdapter.FillByBulan(this.sinarekDataSet.vrinciangaji, int.Parse(rddGajiMingguan.SelectedValue.ToString()), 2);
            //helper.SysLog(this.Tag.ToString(), "btnPinjaman_Click", "Process Pinjaman:" + NBConfig.IGMID);
            //helper.NotifMessage("Data Pinjaman Telah di perbaharui");
        }


        

    }
}
