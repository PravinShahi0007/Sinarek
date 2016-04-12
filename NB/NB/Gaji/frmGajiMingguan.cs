﻿using System;
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
    public partial class frmGajiMingguan : Telerik.WinControls.UI.RadForm
    {
        string gajiCurrentFilter = "";
        private bool add_ =false
            , edit_ = false
            , delete_ = false;
        public frmGajiMingguan()
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

            #region "Kas Bon"
            //Add Total info         
            this.radGridView4.GroupDescriptors[0].Aggregates.Add("sum(unit*unitvalue)");
            this.radGridView4.GroupDescriptors[0].Format = @"Total {1} - {2:Rp #,##0.00}";
            radGridView4.AutoExpandGroups = true;
            #endregion
         
        }

        private void initializeButtons()
        {
            string formName = this.GetType().Name;
            string MenuName = this.Tag.ToString();

            helper.GetPermissions(formName, MenuName, out add_, out edit_, out delete_);

            rddGajiMingguan.Enabled = delete_;
            radGridView1.Columns["cmdDel"].IsVisible = delete_;
            radGridView1.ReadOnly = !delete_;
            radGroupBox4.Enabled = delete_;
        }

        private void SetDefault()
        {
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
                this.gajimingguanTableAdapter.Fill(this.sinarekDataSet.gajimingguan);
                this.memberTableAdapter.Fill(this.sinarekDataSet.member);
                this.tiperinciangajiTableAdapter.Fill(this.sinarekDataSet.tiperinciangaji);
                rddGajiMingguan.SelectedValue = NBConfig.IGMID;
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
            btnKasBon.Enabled = delete_;
            radGridView3.AllowEditRow = delete_;
                     
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
            if (!NBConfig.GetGMIDPrinted())
            {
                if (delete_ || rddGajiMingguan.SelectedValue.ToString() == NBConfig.IGMID.ToString())
                {
                    frmAddGajiDetail frm = new frmAddGajiDetail(int.Parse(tipeRincianddl.SelectedValue.ToString())
                        , int.Parse(rddGajiMingguan.SelectedValue.ToString())
                        , 2
                        , tipeRincianddl.Text
                        , decimal.Parse(tipeRincianddl.Tag.ToString()));
                    frm.ShowDialog(this);

                    //refresh grid
                    this.vrinciangajiTableAdapter.FillByGID(this.sinarekDataSet.vrinciangaji,int.Parse(rddGajiMingguan.SelectedValue.ToString()),2);
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

        #region "Kas Bon"
        private void btnKasBon_Click(object sender, EventArgs e)
        {
            if (!NBConfig.GetGMIDPrinted())
            {
                //Hardcoded to input only kasbon
                frmAddGajiDetail frm = new frmAddGajiDetail(12
                    , int.Parse(rddGajiMingguan.SelectedValue.ToString())
                    , 2
                    , "Kas Bon"
                    , 50000);
                frm.ShowDialog(this);

                //refresh grid
                this.rinciangajiTableAdapter.FillByTipeGID(this.sinarekDataSet.rinciangaji, 2, int.Parse(rddGajiMingguan.SelectedValue.ToString()));
            }
            else
            {
                SetPrintedForms();
                MessageBox.Show("Gaji Minggu ini telah di print maka input sudah tidak diperbolehkan"
                                 + "./nJika ada kesalahan harap dilaporkan.");
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Siap kan kertas di printer"
                             , "Print Laporan Rincian Kas Bon"
                             , MessageBoxButtons.OKCancel
                             , MessageBoxIcon.Question
                             , MessageBoxDefaultButton.Button2
                             , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Print Rincian Summary Gaji
                rptKasBonNew gj = new rptKasBonNew();
                gj.ReportParameters[0].Value = rddGajiMingguan.SelectedValue;
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
            }
        }

        #endregion

        #region "INPUT RES"
        string INPUTRESFILTER = "(tipeid > 12 and tipeid < 17) ";

        private void btnClear3_Click(object sender, EventArgs e)
        {
            ddlNama3.ResetText();
        }
        private void ddlNama3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ddlNama3.Text != "")
            {
                vrinciangajiBindingSource2.Filter = INPUTRESFILTER + " and memberid =" + ddlNama3.SelectedValue.ToString();
            }
            else
            {
                vrinciangajiBindingSource2.Filter = INPUTRESFILTER;
            }
        }
        private void radGridView3_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (NBConfig.GetGMIDPrinted())
            {
                e.Cancel = true;
                MessageBox.Show("Gaji telah di print maka perubahan data gaji sudah tidak diperbolehkan.");
            }
        }
        private void radGridView3_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            if (e.Row != null)
            {
                //update nilai res / uang makan sopir dan kernet
                this.rinciangajiTableAdapter.UpdateRincianGaji(int.Parse(e.Row.Cells["memberid"].Value.ToString())
                    , int.Parse(e.Row.Cells["tipeid"].Value.ToString())
                    , decimal.Parse(e.Row.Cells["unit"].Value.ToString())
                    , decimal.Parse(e.Row.Cells["unitvalue"].Value.ToString())
                    , e.Row.Cells["keterangan"].Value.ToString()
                    , NBConfig.ValidUserName, int.Parse(e.Row.Cells["rinciangajiid"].Value.ToString()));
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
                InstanceReportSource reportSource = new InstanceReportSource();
                reportSource.ReportDocument = report1;
                // Print the report using the printer settings.
                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(reportSource, printerSettings);
            }
        }
        private void btnBorongan_Click(object sender, EventArgs e)
        {
            DialogResult res = RadMessageBox.Show("Data Hasil Borongan untuk minggu yang terpiliah akan diprocess. Pilih [Cancel] untuk membatalkan process."
                              , "Process Borongan"
                              , MessageBoxButtons.OKCancel
                              , RadMessageIcon.Question
                              , MessageBoxDefaultButton.Button2);
            
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //process borongan
                using (sinarekDataSetTableAdapters.boronganTableAdapter borongan = new sinarekDataSetTableAdapters.boronganTableAdapter())
                {
                    borongan.pCreateDataBoronganGaji(int.Parse(rddGajiMingguan.SelectedValue.ToString()), NBConfig.ValidUserName);
                }
                MessageBox.Show("Data Borongan sudah terprocess.");
                this.vrinciangajiTableAdapter.FillByGID(this.sinarekDataSet.vrinciangaji, int.Parse(rddGajiMingguan.SelectedValue.ToString()), 2);
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
                rptGajiMingguan gj = new rptGajiMingguan();
                gj.ReportParameters[0].Value = NBConfig.IGMID;
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
                if (!NBConfig.GetGMIDPrinted())
                {
                    using (sinarekDataSetTableAdapters.gajimingguanTableAdapter gm = new sinarekDataSetTableAdapters.gajimingguanTableAdapter())
                    {
                        gm.UpdatePrinted(NBConfig.ValidUserName, NBConfig.IGMID);
                    }
                    SetPrintedForms();
                    MessageBox.Show("Data Gaji telah terkunci dan tidak dapat di ubah lagi.");
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
                rptGajiSummary gj = new rptGajiSummary();                
                gj.ReportParameters[0].Value = NBConfig.IGMID;
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
                if (!NBConfig.GetGMIDPrinted())
                {
                    using (sinarekDataSetTableAdapters.gajimingguanTableAdapter gm = new sinarekDataSetTableAdapters.gajimingguanTableAdapter())
                    {
                        gm.UpdatePrinted(NBConfig.ValidUserName, NBConfig.IGMID);
                    }
                    SetPrintedForms();
                    MessageBox.Show("Data Gaji telah terkunci dan tidak dapat di ubah lagi.");
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
                rptGajiTotal gj = new rptGajiTotal();
                gj.ReportParameters[0].Value = NBConfig.IGMID;
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
                if (!NBConfig.GetGMIDPrinted())
                {
                    using (sinarekDataSetTableAdapters.gajimingguanTableAdapter gm = new sinarekDataSetTableAdapters.gajimingguanTableAdapter())
                    {
                        gm.UpdatePrinted(NBConfig.ValidUserName, NBConfig.IGMID);
                    }
                    SetPrintedForms();
                    MessageBox.Show("Data Gaji telah terkunci dan tidak dapat di ubah lagi.");
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
                    rptGajiMingguan gj = new rptGajiMingguan();
                    gj.ReportParameters[0].Value = NBConfig.IGMID;
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
                    if (!NBConfig.GetGMIDPrinted())
                    {
                        using (sinarekDataSetTableAdapters.gajimingguanTableAdapter gm = new sinarekDataSetTableAdapters.gajimingguanTableAdapter())
                        {
                            gm.UpdatePrinted(NBConfig.ValidUserName, NBConfig.IGMID);
                        }
                        SetPrintedForms();
                        MessageBox.Show("Data Gaji telah terkunci dan tidak dapat di ubah lagi.");
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
                this.vrinciangajiTableAdapter.FillByGID(this.sinarekDataSet.vrinciangaji,int.Parse(rddGajiMingguan.SelectedValue.ToString()),2);

                rptGajiMingguan1.ReportParameters["GMID"].Value = rddGajiMingguan.SelectedValue;
                rptGajiMingguan1.ReportParameters["User"].Value = NBConfig.ValidUserName;
            }
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            if (cell.CommandButton.Text.ToLower() == "del")
            {
                this.rinciangajiTableAdapter.DeleteRincianGaji(int.Parse(cell.RowInfo.Cells["rinciangajiid"].Value.ToString()));
                this.vrinciangajiTableAdapter.FillByGID(this.sinarekDataSet.vrinciangaji, int.Parse(rddGajiMingguan.SelectedValue.ToString()),2);
            }

        }

        private void btnGajiTemplate_Click(object sender, EventArgs e)
        {
            this.rinciangajiTableAdapter.pCreateDataGajiTemplate(int.Parse(rddGajiMingguan.SelectedValue.ToString())
                , 2, NBConfig.ValidUserName);
            this.vrinciangajiTableAdapter.FillByGID(this.sinarekDataSet.vrinciangaji, int.Parse(rddGajiMingguan.SelectedValue.ToString()), 2);
            helper.SysLog(this.Tag.ToString(), "btnGajiTemplate_Click", "Process Gaji");
            helper.NotifMessage("Data Gaji Telah di perbaharui");
        }

        private void btnProcessRes_Click(object sender, EventArgs e)
        {
            if (radGridView3.Rows.Count == 0)
            {
                this.rinciangajiTableAdapter.pCreateDataGajiTanpaAbsen(int.Parse(rddGajiMingguan.SelectedValue.ToString())
                    , 2, NBConfig.ValidUserName);
                this.vrinciangajiTableAdapter.FillByGID(this.sinarekDataSet.vrinciangaji, int.Parse(rddGajiMingguan.SelectedValue.ToString()), 2);
                helper.SysLog(this.Tag.ToString(), "btnProcessRes_Click", "Process Res");
                helper.NotifMessage("Data Res Telah di perbaharui");
            }
            else
            {
                helper.NotifMessage("Data Res Telah di process. Tidak dapat diprocess lagi.");
            }
        }

        private void btnPinjaman_Click(object sender, EventArgs e)
        {
            using (sinarekDataSetTableAdapters.pinjamanTableAdapter tbl = new sinarekDataSetTableAdapters.pinjamanTableAdapter())
            {
                tbl.pProcessPinjaman(NBConfig.IGMID, NBConfig.ValidUserName);
            }
            this.vrinciangajiTableAdapter.FillByGID(this.sinarekDataSet.vrinciangaji, int.Parse(rddGajiMingguan.SelectedValue.ToString()), 2);
            helper.SysLog(this.Tag.ToString(), "btnPinjaman_Click", "Process Pinjaman:" + NBConfig.IGMID);
            helper.NotifMessage("Data Pinjaman Telah di perbaharui");
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
                    if (!NBConfig.GetGMIDPrinted())
                    {
                        using (sinarekDataSetTableAdapters.gajimingguanTableAdapter gm = new sinarekDataSetTableAdapters.gajimingguanTableAdapter())
                        {
                            gm.UpdatePrinted(NBConfig.ValidUserName, NBConfig.IGMID);
                        }
                        SetPrintedForms();
                        MessageBox.Show("Data Gaji telah terkunci dan tidak dapat di ubah lagi.");
                    }
                }
            }

        }

        

    }
}
