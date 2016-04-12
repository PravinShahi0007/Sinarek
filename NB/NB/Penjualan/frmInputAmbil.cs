using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Reporting;
using Telerik.Reporting.Processing;


namespace NB
{
    public partial class frmInputAmbil : Telerik.WinControls.UI.RadForm
    {
        public frmInputAmbil()
        {
            InitializeComponent();
        }

        private void frmInputAmbil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.mobil' table. You can move, or remove it, as needed.
            this.mobilTableAdapter.Fill(this.sinarekDataSet.mobil);
            // TODO: This line of code loads data into the 'sinarekDataSet.vallsup' table. You can move, or remove it, as needed.
            this.vallsupTableAdapter.Fill(this.sinarekDataSet.vallsup);

        }

        private bool ValidateFields()
        {
            bool bValid = false;
            if (rddNama.SelectedValue == null)
            {
                helper.ErrorMessage("Silahkan Pilih Nama yang akan belanja.");
                rddNama.Focus();
                return bValid;
            }
            if (string.IsNullOrEmpty(txtKeterangan.Text))
            {
                helper.ErrorMessage("Silahkan input keterangan belanja.");
                txtKeterangan.Focus();
                return bValid;
            }
            if (decimal.Parse(txtJumlah.Text) < 1)
            {
                helper.ErrorMessage("Silahkan input jumlah uang belanja. Uang Belanja Harus melebihi 0.");
                txtKeterangan.Focus();
                return bValid;
            }
            return true;
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string UJID;
                //Create UJ
                using (sinarekDataSetTableAdapters.uangjalanTableAdapter tbl = new sinarekDataSetTableAdapters.uangjalanTableAdapter())
                {
                    UJID = tbl.pInsertUangJalan(-2
                        , "DALAM KOTA"
                        , "KAS"
                        , rddNama.Text
                        , rddMobil.Text
                        , txtKeterangan.Text
                        , -1
                        , decimal.Parse(txtJumlah.Text)
                        , 0, NBConfig.ValidUserName).ToString();
                }
                //Print
                DialogResult res = RadMessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                    , MessageBoxButtons.OKCancel
                    , RadMessageIcon.Question
                    , MessageBoxDefaultButton.Button2);
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    PrinterSettings printerSettings;
                    ReportProcessor reportProcessor;

                    rptUJ rpt = new rptUJ();
                    rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                    rpt.ReportParameters["UJid"].Value = UJID;

                    IReportDocument iRpt = (IReportDocument)rpt;

                    iRpt.DocumentName = "UJ_" + rddNama.Text + "_"
                                        + rddMobil.Text;
                    //// PrinterSettings 
                    printerSettings = new PrinterSettings();
                    try
                    {
                        InstanceReportSource reportSource = new InstanceReportSource();
                        reportSource.ReportDocument = iRpt;
                        reportProcessor = new ReportProcessor();

                        reportProcessor.PrintReport(reportSource, printerSettings);
                        using (sinarekDataSetTableAdapters.uangjalanTableAdapter tbl = new sinarekDataSetTableAdapters.uangjalanTableAdapter())
                        {
                            tbl.UpdatePrinted(1
                                , NBConfig.ValidUserName
                                , int.Parse(UJID));
                        }
                        helper.PrintLog(this.GetType().Name, rpt.Name, "Print:" + UJID);
                    }
                    catch (Exception ex)
                    {
                        helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                        helper.ErrorMessage(ex.Message);
                    }
                }
                this.Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
