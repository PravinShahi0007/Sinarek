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
    public partial class frmGaji : Telerik.WinControls.UI.RadForm
    {
        string gajiCurrentFilter = "gmid = " + NBConfig.IGMID;
        public frmGaji()
        {
            InitializeComponent();

            #region "Gaji"
            //Add Default test if gaji has been paid
            this.radGridView1.Text = "Gaji minggu ini sudah di bayar"; 
            //Add Total info         
            this.radGridView1.GroupDescriptors[0].Aggregates.Add("sum(unit*unitvalue)");
            this.radGridView1.GroupDescriptors[0].Format = "{0} : {1} - {2:Rp #,###.00}";
            radGridView1.AutoExpandGroups = true;       

                        
            //Set Event for Gaji Radio Button
            radRadioButtonNama.Click +=new EventHandler(rbFilterGaji_Click);
            radRadioButtonTipe.Click += new EventHandler(rbFilterGaji_Click);
            radRadioButtonNama.ToggleStateChanged +=new StateChangedEventHandler(rbFilterGaji_ToggleStateChanged);
            radRadioButtonTipe.ToggleStateChanged += new StateChangedEventHandler(rbFilterGaji_ToggleStateChanged);
            #endregion

            #region "Kas Bon"
            //Add Total info         
            this.radGridView4.GroupDescriptors[0].Aggregates.Add("sum(unit*unitvalue)");
            this.radGridView4.GroupDescriptors[0].Format = @"Total {1} - {2:Rp #,##0_);RP (#,##0);_(@_)}";
            radGridView4.AutoExpandGroups = true;
            #endregion
         
        }

        private void frmGaji_Load(object sender, EventArgs e)
        {
            #region "Print"
            string frmName = this.GetType().Name;
            bool delete = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "delete");

            btnPindah.Enabled = delete;
            btnPindah.Visible = delete;


            #endregion
            this.tiperinciangajiTableAdapter.Fill(this.sinarekDataSet.tiperinciangaji);
            this.buruhTableAdapter.Fill(this.sinarekDataSet.buruh);
            this.gajidetailtempTableAdapter.FillByGMID(this.sinarekDataSet.gajidetailtemp,NBConfig.IGMID);         
            this.vgajidetailabsenTableAdapter.FillByGMID(this.sinarekDataSet.vgajidetailabsen,NBConfig.IGMID);
            //Always check if gaji has been printed
            if (NBConfig.GetGMIDPrinted())
            {
                SetPrintedForms();
            }
            
                        
            //Setting for INPUTRES
            vgajidetailabsenbindingSource2.Filter = INPUTRESFILTER;
            //Setting for GAJI
            vgajidetailabsenBindingSource.Filter = gajiCurrentFilter;
            radRadioButtonNama.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            ddlNama2.ResetText();
            ddlTipe2.ResetText();
            radGridView1.BestFitColumns();
            tipeRincianddl.SelectedValue = 12;          

            //Make sure borongan is only loaded once
            long lResult = 0;
            if (!long.TryParse(gajidetailtempTableAdapter.CheckBorongan().ToString(), out lResult))
            {
                btnBorongan.Text = "Borongan Sudah Di Process";
                btnBorongan.Enabled = false;
            }    
        }

        private void SetPrintedForms()
        {
            bool bAdd = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), "frmGaji", "add");
            bool bEdit = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), "frmGaji", "edit");
            bool bDelete = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), "frmGaji", "delete");

            //Set Input according to permission        
            btnBonus.Enabled = bDelete;
            btnKasBon.Enabled = bDelete;
            radGridView3.AllowEditRow = bDelete;             
            
        }

        #region "GAJI"

        private void btnClear2_Click(object sender, EventArgs e)
        {
            this.sinarekDataSet.vgajidetailabsen.Clear();
            vgajidetailabsenTableAdapter.FillByGMID(this.sinarekDataSet.vgajidetailabsen, NBConfig.IGMID);
            vgajidetailabsenBindingSource.Filter = gajiCurrentFilter;
            ddlNama2.ResetText();
            ddlTipe2.ResetText();
            radRadioButtonNama.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            ddlNama2.Focus();
        }
        private void ddlNama2_SelectedValueChanged(object sender, EventArgs e)
        {            
            this.sinarekDataSet.vgajidetailabsen.Clear();
            vgajidetailabsenTableAdapter.FillByGMID(this.sinarekDataSet.vgajidetailabsen, NBConfig.IGMID);
            if (ddlNama2.SelectedValue != null)
            {
                vgajidetailabsenBindingSource.Filter = gajiCurrentFilter + " and buruhid =" + ddlNama2.SelectedValue.ToString();
            }
            else
            {
                vgajidetailabsenBindingSource.Filter = gajiCurrentFilter;          
            }
            
        }
        private void ddlTipe2_SelectedValueChanged(object sender, EventArgs e)
        {
            this.sinarekDataSet.vgajidetailabsen.Clear();
            vgajidetailabsenTableAdapter.FillByGMID(this.sinarekDataSet.vgajidetailabsen, NBConfig.IGMID);
            if (ddlTipe2.SelectedValue != null)
            {
                vgajidetailabsenBindingSource.Filter = gajiCurrentFilter + " and tipeid =" + ddlTipe2.SelectedValue.ToString();
            }
            else
            {
                vgajidetailabsenBindingSource.Filter = gajiCurrentFilter;
            }            
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
                //frmAddGajiDetail frm = new frmAddGajiDetail(int.Parse(tipeRincianddl.SelectedValue.ToString())
                //    , tipeRincianddl.Text
                //    , decimal.Parse(tipeRincianddl.Tag.ToString()));
                //frm.ShowDialog(this);

                //refresh grid
                this.sinarekDataSet.vgajidetailabsen.Clear();
                vgajidetailabsenTableAdapter.FillByGMID(this.sinarekDataSet.vgajidetailabsen,NBConfig.IGMID);
                vgajidetailabsenBindingSource.Filter = gajiCurrentFilter;
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
                //frmAddGajiDetail frm = new frmAddGajiDetail(12
                //    , "Kas Bon"
                //    , 50000);
                //frm.ShowDialog(this);

                //refresh grid
                this.sinarekDataSet.vgajidetailabsen.Clear();
                vgajidetailabsenTableAdapter.FillByGMID(this.sinarekDataSet.vgajidetailabsen, NBConfig.IGMID);
                //vgajidetailabsenBindingSource3.Filter = gajiCurrentFilter;
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
                rptKasBon gj = new rptKasBon();
                gj.ReportParameters[0].Value = NBConfig.IGMID;
                gj.ReportParameters["user"].Value = NBConfig.ValidUserName;
                IReportDocument report1 = (IReportDocument)gj;
                ////set parameters when necessary

                //// PrinterSettings 
                PrinterSettings printerSettings = new PrinterSettings();
                //// Adjust the printer settings if necessary...

                // Print the report using the printer settings.
                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(report1, printerSettings);
            }
        }

        #endregion

        #region "INPUT RES"
        string INPUTRESFILTER = "(sopir = 1 or kernet = 1) and (tipeid > 12 and tipeid < 17) and gmid = " + NBConfig.IGMID;

        private void btnClear3_Click(object sender, EventArgs e)
        {
            this.sinarekDataSet.vgajidetailabsen.Clear();
            vgajidetailabsenTableAdapter.FillByGMID(this.sinarekDataSet.vgajidetailabsen, NBConfig.IGMID);
            vgajidetailabsenbindingSource2.Filter = INPUTRESFILTER;
            ddlNama3.ResetText();
        }
        private void ddlNama3_SelectedValueChanged(object sender, EventArgs e)
        {
            this.sinarekDataSet.vgajidetailabsen.Clear();
            vgajidetailabsenTableAdapter.FillByGMID(this.sinarekDataSet.vgajidetailabsen, NBConfig.IGMID);
            if (ddlNama3.Text != "")
            {
                vgajidetailabsenbindingSource2.Filter = INPUTRESFILTER + " and buruhid =" + ddlNama3.SelectedValue.ToString();
            }
            else
            {
                vgajidetailabsenbindingSource2.Filter = INPUTRESFILTER;
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
            //update nilai res / uang makan sopir dan kernet
            gajidetailtempTableAdapter.UpdateRes(decimal.Parse(e.Row.Cells["unit"].Value.ToString())
                , e.Row.Cells["keterangan"].Value.ToString()
                , NBConfig.ValidUserName
                , int.Parse(e.Row.Cells["gajidetailtempid"].Value.ToString()));
        }
        #endregion        

        #region "Print"
        /// <summary>
        /// This Method is called if NBConfig.PrintedOnce is false
        /// </summary>
        private void MoveGaji(string sQPart)
        {
            //TODO:
            //when moving always move the current gaji
            //always make sure that it is giving out gaji day if not do not print
            //a setting table is needed to keep these values
            DialogResult res = MessageBox.Show(sQPart + "/nData gaji sudah tidak dapat diganti lagi."
                                + "/nHarap dipastikan bahwa gaji rincian gaji buruh tidak ada lagi kesalahan."
                                + "/nSilahkan lihat history untuk melihat rincian gaji"
                              , "Print Data Absen"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Question
                              , MessageBoxDefaultButton.Button2
                              , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
            }
 
        }

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
                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(report1, printerSettings);
            }
        }
        private void btnBorongan_Click(object sender, EventArgs e)
        {
            DialogResult res = RadMessageBox.Show("Data Hasil Borongan akan diprocess. Pilih [Cancel] untuk membatalkan process."
                              , "Process Borongan"
                              , MessageBoxButtons.OKCancel
                              , RadMessageIcon.Question
                              , MessageBoxDefaultButton.Button2);
            
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //process borongan
                using (sinarekDataSetTableAdapters.boronganTableAdapter borongan = new sinarekDataSetTableAdapters.boronganTableAdapter())
                {
                    borongan.pCreateDataBoronganGaji(NBConfig.IGMID, NBConfig.ValidUserName);
                }
                MessageBox.Show("Data Borongan sudah terprocess.");

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
                rptGaji gj = new rptGaji();
                gj.ReportParameters[0].Value = NBConfig.IGMID;
                gj.ReportParameters["User"].Value = NBConfig.ValidUserName;
                IReportDocument report1 = (IReportDocument)gj;
                ////set parameters when necessary

                //// PrinterSettings 
                PrinterSettings printerSettings = new PrinterSettings();
                //// Adjust the printer settings if necessary...
                
                // Print the report using the printer settings.
                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(report1, printerSettings);
                
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

                // Print the report using the printer settings.
                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(report1, printerSettings);

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

                // Print the report using the printer settings.
                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(report1, printerSettings);

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
        private void btnPindah_Click(object sender, EventArgs e)
        {
            string Question = string.Empty;
            int iGMID = NBConfig.IGMID;
            DialogResult prevRes = MessageBox.Show("Hapus Gaji Minggu Lalu?"
                              , "Process Gaji Mingguan"
                              , MessageBoxButtons.YesNo
                              , MessageBoxIcon.Question
                              , MessageBoxDefaultButton.Button2
                              , MessageBoxOptions.DefaultDesktopOnly);
            if (prevRes == System.Windows.Forms.DialogResult.Yes)
            {
                Question = "Gaji Minggu Lalu akan dipindahkan dan di hapus!";
                iGMID = iGMID - 1; 
            }
            else
            {
                Question = "Gaji akan dipindahkan dan di hapus. Pastikan gaji sudah terbayar!";
            }
            DialogResult res = MessageBox.Show(Question
                              , "Process Gaji Mingguan"
                              , MessageBoxButtons.OKCancel
                              , MessageBoxIcon.Question
                              , MessageBoxDefaultButton.Button2
                              , MessageBoxOptions.DefaultDesktopOnly);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                using (sinarekDataSetTableAdapters.gajidetailTableAdapter gdAdap = new sinarekDataSetTableAdapters.gajidetailTableAdapter())
                {
                    try
                    {
                        gdAdap.pMovePaidGaji(iGMID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Gaji Sudah di pindahkan dan terhapus.\n Data pinjaman sudah terupdate.");
                    }
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
                    rptGaji gj = new rptGaji();
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
                    
                    // Print the report using the printer settings.
                    ReportProcessor reportProcessor = new ReportProcessor();

                    reportProcessor.PrintReport(report1, printerSettings);

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

        

    }
}
