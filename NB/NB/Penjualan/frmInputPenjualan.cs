using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

using Telerik.Reporting;
using Telerik.Reporting.Processing;
using Telerik.WinControls;
using Telerik.WinControls.UI;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.Sql;


using Telerik.WinControls.UI;

namespace NB
{
    public partial class frmInputPenjualan : Telerik.WinControls.UI.RadForm
    {
        private DataRow row_;
        private string lappenid_;
        private DateTime dtTanggal_,dtKembali_,dtSJ_;
        private bool printed_ = false;
        private bool add_, edit_, delete_;

        public frmInputPenjualan(DataRow DataRow_,string lappenid ,DateTime tglKembali,DateTime tglSJ, DateTime tglLaporan)
        {
            InitializeComponent();
            lappenid_ = lappenid;
             row_ = DataRow_;

            dtpKembali.Value = tglKembali;
            dtpTglSJ.Value = tglSJ;
            dtpTanggal.Value = tglLaporan;
            dtKembali_ = tglKembali;
            dtTanggal_ = tglLaporan;
            dtSJ_ = tglSJ;
            txtSuratJalan.Text = row_["nosj"].ToString();

            //Add Total info     
            this.radGridView1.GroupDescriptors[0].Aggregates.Add("sum(Total)");
            this.radGridView1.GroupDescriptors[0].Aggregates.Add("count(Total)");
            this.radGridView1.GroupDescriptors[0].Format = "Total ({3}) : {2:Rp #,###.00}";
            this.radGridView2.GroupDescriptors[0].Aggregates.Add("sum(total)");
            this.radGridView2.GroupDescriptors[0].Aggregates.Add("count(Total)");
            this.radGridView2.GroupDescriptors[0].Format = "Total ({3}): {2:Rp #,###.00}";

            using (sinarekDataSetTableAdapters.vlappenTableAdapter tbl = new sinarekDataSetTableAdapters.vlappenTableAdapter())
            {
                printed_ = (bool)tbl.CheckLappenPrinted(int.Parse(lappenid_));
            }

        }

        private void frmInputPenjualan_Load(object sender, EventArgs e)
        {
            SetConditions();
            try
            {
                this.vlogpelTableAdapter.FillByID(this.sinarekDataSet.vlogpel, int.Parse(row_["logid"].ToString()));
            }
            catch(Exception ex)
            {
                RadMessageBox.Show(ex.StackTrace);
            }
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.productbaseTableAdapter.Fill(this.sinarekDataSet.productbase);
            this.logotherTableAdapter.FillBySJ(this.sinarekDataSet.logother,int.Parse(row_["logid"].ToString()));
            this.salesTableAdapter.Fill(this.sinarekDataSet.sales);
            
            this.vlogproductdetailTableAdapter.FillByParent(this.sinarekDataSet.vlogproductdetail, int.Parse(row_["logid"].ToString()));
            
            rddSales.FindItemExact(row_["salesname"].ToString(), false).Selected = true;
            logotherBindingSource.Filter = "lappenid = " + lappenid_ + " and logpelid = -1";

            rptLaporanPenj rpt = (rptLaporanPenj)reportViewer1.Report;
            rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
            rpt.ReportParameters["lappenid"].Value = lappenid_;
            reportViewer1.RefreshReport();

            InitialiazeButtons();

        }

        #region "Methods"

        private void DeleteLogOther(string LogDetailID)
        {
            try
            {
                using (sinarekDataSetTableAdapters.logotherTableAdapter tbl = new sinarekDataSetTableAdapters.logotherTableAdapter())
                {
                    tbl.DeleteLogOther(int.Parse(LogDetailID));
                }
            }
            catch (Exception ex)
            {
                helper.SysLog(this.GetType().Name, this.Text, "DeleteLogOther : " + ex.Message);
            }


        }

        private void DeleteLogPel(string LogPelID)
        {
            try
            {
                using (sinarekDataSetTableAdapters.logpelTableAdapter tbl = new sinarekDataSetTableAdapters.logpelTableAdapter())
                {
                    tbl.DeleteLogPel(int.Parse(LogPelID));
                }
            }
            catch (Exception ex)
            {
                helper.SysLog(this.GetType().Name, this.Text, "DeleteLogPel : " + ex.Message);
            }


        }

        private void SetConditions()
        {
            //Tukar
            ConditionalFormattingObject c2 = new ConditionalFormattingObject("Light Sea Green, applied to entire row", ConditionTypes.Equal, "1", "", true);
            c2.RowBackColor = Color.LightSeaGreen;
            radGridView5.Columns["statusid"].ConditionalFormattingObjectList.Add(c2);
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSJ_Click(object sender, EventArgs e)
        {
            try
            {
                frmInRcnPenjualan frm = new frmInRcnPenjualan(row_["salesid"].ToString()
                    , row_["kotaid"].ToString()
                    , row_["logid"].ToString()
                    , lappenid_);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                helper.ErrorMessage(ex.Message + ex.StackTrace);
                helper.SysLog(this.GetType().Name, this.Tag.ToString(), ex.Message + ex.StackTrace);
            }

            this.logotherTableAdapter.FillBySJ(this.sinarekDataSet.logother, int.Parse(row_["logid"].ToString()));
            this.sinarekDataSet.vlogpel.Clear();
            this.vlogpelTableAdapter.FillByID(this.sinarekDataSet.vlogpel, int.Parse(row_["logid"].ToString()));
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Check if there is at least one rincian

            //Check nota sequence

            //Check nilai surat jalan vs nilai uang setoran

            //Others info connected to this transaction
            //Print Selected Transaction
            //Print
            DialogResult res = MessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                PrinterSettings printerSettings;
                ReportProcessor reportProcessor;

                rptLaporanPenj rpt = new rptLaporanPenj();
                rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                rpt.ReportParameters["lappenid"].Value = lappenid_;
                //rpt.ReportParameters["custtypetoid"].Value = custtypetoid;

                IReportDocument iRpt = (IReportDocument)rpt;
                //// PrinterSettings 
                printerSettings = new PrinterSettings();
                try
                {
                    InstanceReportSource reportSource = new InstanceReportSource();
                    reportSource.ReportDocument = iRpt;

                    reportProcessor = new ReportProcessor();
                    reportProcessor.PrintReport(reportSource, printerSettings);
                    using (sinarekDataSetTableAdapters.lappenTableAdapter tbl = new sinarekDataSetTableAdapters.lappenTableAdapter())
                    {
                        tbl.UpdateLapPenj(NBConfig.ValidUserName
                                            , 1
                                            , 1
                                            , int.Parse(lappenid_));
                    }
                    SetFormPrinted();
                }
                catch (Exception ex)
                {
                    helper.ErrorMessage(ex.Message);
                }
            }
        }

        private void btnBiaya_Click(object sender, EventArgs e)
        {
            //if (!printed_)
            //{
                frmInRcnBiaya frm = new frmInRcnBiaya(row_["salesid"].ToString()
                    , row_["kotaid"].ToString()
                    , row_["logid"].ToString()
                    , lappenid_);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog(this);

                this.logotherTableAdapter.FillBySJ(this.sinarekDataSet.logother, int.Parse(row_["logid"].ToString()));
            //}
            //else
            //{
            //    helper.NotifMessage("Laporan tidak dapat di edit!");
            //}
        }

        private void SetFormPrinted()
        {
            
            btnInputBiaya.Enabled = (!printed_) || delete_;
            btnInputRincian.Enabled = (!printed_) || delete_;

            btnDelBiaya.Enabled = (!printed_) || delete_;
            btnDelRincian.Enabled = (!printed_) || delete_;

            btnSimpanBotol.Enabled = (!printed_) || delete_;
            btnPrint.Enabled = (!printed_) || delete_;
            btnAddTrans.Enabled = (!printed_) || delete_;

            txtSisa.Enabled = false;
            if (radGridView4.Rows.Count >= 1)
            {
                txtSisa.Text = radGridView4.Rows[0].Cells["nosj"].Value.ToString();
            }
            if (radGridView3.Rows.Count == 0)
            {
                btnAddTrans.Enabled = ((add_ || edit_) && (!printed_)) || delete_;
            }
            else
            {
                btnAddTrans.Enabled = delete_;
                txtReturn.Enabled = delete_;
                txtReturn.Text = radGridView3.Rows[0].Cells["nosj"].Value.ToString();
            }
            
            if (radGridView6.Rows.Count >= 1)
            {
                txtBotol.Text = radGridView6.Rows[0].Cells["nosj"].Value.ToString();
                btnSimpanBotol.Enabled = delete_;
                txtBotol.Enabled = delete_;
            }
            else
            {
                btnSimpanBotol.Enabled = ((add_ || edit_) && (!printed_)) || delete_;
            }
        }

        private void InitialiazeButtons()
        {
            string frmName = this.Owner.GetType().Name;
            frmLihatLP frm = (frmLihatLP)this.Owner;
            frm.GetPermissions(out add_, out edit_, out delete_);

            SetFormPrinted();
                        
        }

        private void radGridView1_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (!(e.CurrentRow is GridViewGroupRowInfo))
            {
                if (e.CurrentRow.Cells["LogpelID"].Value != null)
                {
                    logotherBindingSource1.Filter = "logpelid =" + e.CurrentRow.Cells["LogpelID"].Value.ToString();
                }
                else
                {
                    logotherBindingSource1.Filter = "logpelid = -2";
                }
            }
            else
            {
                logotherBindingSource1.Filter = "logpelid = -2";
            }
        }

        private void btnAddTrans_Click(object sender, EventArgs e)
        {
            string logid = string.Empty;
            string parentid = string.Empty;

            if (txtReturn.Text != "________")
            {
                try
                {
                    using (sinarekDataSetTableAdapters.vlogproductTableAdapter tbl = new sinarekDataSetTableAdapters.vlogproductTableAdapter())
                    {
                        logid = row_["logid"].ToString();
                        parentid = tbl.CheckParent(txtReturn.Text.Replace(" ", "")).ToString();
          
                    }
                    if (parentid == "-1")
                    {
                        using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
                        {
                            tbl.UpdateParent(int.Parse(logid), NBConfig.ValidUserName,int.Parse(rddSales.SelectedValue.ToString()), txtReturn.Text);
                        }
                        this.vlogproductdetailTableAdapter.FillByParent(this.sinarekDataSet.vlogproductdetail, int.Parse(row_["logid"].ToString()));
                        btnAddTrans.Enabled = false;
                        txtReturn.Enabled = false;
                    }
                    else
                    {
                        helper.ErrorMessage("Surat jalan sudah terpakai!");
                        txtReturn.ResetText();
                    }
                }
                catch (Exception ex)
                {
                    helper.ErrorMessage("No Transaksi Tidak ada!");
                    helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                }
            }

        }

        private void btnDelRincian_Click(object sender, EventArgs e)
        {           
            if (!(radGridView1.SelectedRows[0] is GridViewGroupRowInfo))
            {
                DeleteLogPel(radGridView1.SelectedRows[0].Cells["logpelid"].Value.ToString());
                this.logotherTableAdapter.FillBySJ(this.sinarekDataSet.logother, int.Parse(row_["logid"].ToString()));
                this.sinarekDataSet.vlogpel.Clear();
                this.vlogpelTableAdapter.FillByID(this.sinarekDataSet.vlogpel, int.Parse(row_["logid"].ToString()));
            }
            
        }

        private void btnDelBiaya_Click(object sender, EventArgs e)
        {           
            if (!(radGridView2.SelectedRows[0] is GridViewGroupRowInfo))
            {
                DeleteLogOther(radGridView2.SelectedRows[0].Cells["logdetailid"].Value.ToString());
                this.logotherTableAdapter.FillBySJ(this.sinarekDataSet.logother, int.Parse(row_["logid"].ToString()));
            }
        }

        private void btnSimpanBotol_Click(object sender, EventArgs e)
        {
            string parentid = string.Empty;
            string logid = string.Empty;
            if (txtBotol.Text != "________")
            {
                try
                {
                    using (sinarekDataSetTableAdapters.vlogproductTableAdapter tbl = new sinarekDataSetTableAdapters.vlogproductTableAdapter())
                    {
                        logid = row_["logid"].ToString();
                        parentid = tbl.CheckParent(txtBotol.Text.Replace(" ", "")).ToString();

                    }
                    if (parentid == "-1")
                    {
                        using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
                        {
                            tbl.UpdateParent(int.Parse(logid), NBConfig.ValidUserName,int.Parse(rddSales.SelectedValue.ToString()), txtBotol.Text);
                        }
                        this.vlogproductdetailTableAdapter.FillByParent(this.sinarekDataSet.vlogproductdetail, int.Parse(row_["logid"].ToString()));
                        btnSimpanBotol.Enabled = false;
                        txtBotol.Enabled = false;
                    }
                    else
                    {
                        helper.ErrorMessage("Surat jalan sudah terpakai!");
                        txtReturn.ResetText();
                    }
                }
                catch (Exception ex)
                {
                    helper.ErrorMessage("No Transaksi Tidak ada!");
                    helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                }
                //Associate barang return dgn sj
            }
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (radPageView1.SelectedPage == radPagePreview)
            {
                reportViewer1.RefreshReport();
            }
        }

        
    }
}
