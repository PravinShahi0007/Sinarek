using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.Sql;

namespace NB
{
    public partial class frmInputReturn : Telerik.WinControls.UI.RadForm
    {
        private DataRow row_;
        private string lappenid_;
        private DateTime dtTanggal_,dtKembali_,dtSJ_;

        public frmInputReturn(DataRow DataRow_,string lappenid ,DateTime tglKembali,DateTime tglSJ, DateTime tglLaporan)
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
            this.radGridView2.GroupDescriptors[0].Aggregates.Add("sum(total)");
            this.radGridView2.GroupDescriptors[0].Format = "Total : {2:Rp #,###.00}";
            radGridView2.AutoExpandGroups = true;    
        }

        private void frmInputPenjualan_Load(object sender, EventArgs e)
        {
            this.vlogpelTableAdapter.FillByID(this.sinarekDataSet.vlogpel,int.Parse(row_["logid"].ToString()));
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.pelTableAdapter.Fill(this.sinarekDataSet.pel);
            this.logpelTableAdapter.Fill(this.sinarekDataSet.logpel);
            this.productbaseTableAdapter.Fill(this.sinarekDataSet.productbase);
            this.logotherTableAdapter.Fill(this.sinarekDataSet.logother);
            this.salesTableAdapter.Fill(this.sinarekDataSet.sales);

            rddSales.FindItemExact(row_["salesname"].ToString(), false).Selected = true;
            logpelBindingSource.Filter = "logid = " + row_["logid"].ToString();
            logotherBindingSource.Filter = "logid = " + row_["logid"].ToString() + " and logpelid = -1";         
        }

        #region "Methods"
        private void GetSJDetail()
        {
            //sinarekDataSet.vsuratjalanDataTable sjData = new sinarekDataSet.vsuratjalanDataTable();
            //using (sinarekDataSetTableAdapters.vsuratjalanTableAdapter tbl = new sinarekDataSetTableAdapters.vsuratjalanTableAdapter())
            //{
            //    try
            //    {
            //        tbl.FillByNoSJ(sjData, txtSuratJalan.Text);

            //        //Fill the necessary fields
            //        if (sjData.Rows.Count == 1)
            //        {
            //            row_ = sjData.Rows[0];
            //            rddSales.SelectedValue = int.Parse(row_["SalesID"].ToString());
            //            dtpTglSJ.Value = DateTime.Parse(row_["Tanggal"].ToString());
            //            txtSuratJalan.Enabled = false;
            //            //btnMulai.Enabled = false;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Surat Jalan tidak ada");                        
            //            txtSuratJalan.SelectAll();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
                    
            //    }
            //}
        }
        private void SaveNewItem()
        {

        }
        #endregion

        private void btnMulai_Click(object sender, EventArgs e)
        {
            GetSJDetail();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSJ_Click(object sender, EventArgs e)
        {
            frmInRcnPenjualan frm = new frmInRcnPenjualan(row_["salesid"].ToString()
                ,row_["kotaid"].ToString()
                , row_["logid"].ToString()
                ,lappenid_);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(this);

            this.logotherTableAdapter.Fill(this.sinarekDataSet.logother);
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.pelTableAdapter.Fill(this.sinarekDataSet.pel);
            this.vlogpelTableAdapter.FillByID(this.sinarekDataSet.vlogpel, int.Parse(row_["logid"].ToString()));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Check if there is at least one rincian

            //Check nota sequence

            //Check nilai surat jalan vs nilai uang setoran

            //Others info connected to this transaction
        }

        private void btnBiaya_Click(object sender, EventArgs e)
        {
            frmInRcnBiaya frm = new frmInRcnBiaya(row_["salesid"].ToString()
                , row_["kotaid"].ToString()
                , row_["logid"].ToString()
                , lappenid_);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(this);

            this.logotherTableAdapter.Fill(this.sinarekDataSet.logother);
        }

    }
}
