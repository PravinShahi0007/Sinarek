using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NB
{
    public partial class frmInputLB : Telerik.WinControls.UI.RadForm
    {
        private DataRow row_;
        public frmInputLB()
        {
            InitializeComponent();

            dtpKembali.Value = DateTime.Now;
            dtpTanggal.Value = DateTime.Now;
        }

        #region "Methods"
        private void GetSJDetail()
        {
            sinarekDataSet.vlogproductDataTable sjData = new sinarekDataSet.vlogproductDataTable();
            using (sinarekDataSetTableAdapters.vlogproductTableAdapter tbl = new sinarekDataSetTableAdapters.vlogproductTableAdapter())
            {
                try
                {
                    tbl.FillBySJ(sjData, txtSuratJalan.Text.Replace(" ",""));

                    //Fill the necessary fields
                    if (sjData.Rows.Count == 1)
                    {
                        row_ = sjData.Rows[0];
                        //rddSales.SelectedValue = int.Parse(row_["SalesID"].ToString());
                        rddSales.FindItemExact(row_["SalesName"].ToString(), false).Selected = true;
                        dtpTglSJ.Value = DateTime.Parse(row_["Tanggal"].ToString());
                        
                        txtSuratJalan.Enabled = false;
                        btnMulai.Enabled = false;

                        dtpKembali.Enabled = true;
                        dtpTanggal.Enabled = true;
                        btnSimpan.Enabled = true;
                        btnMulai.Enabled = false;
                        dtpKembali.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Surat Jalan tidak ada");
                        txtSuratJalan.SelectAll();
                    }
                }
                catch (Exception ex)
                {
                    helper.ErrorMessage(ex.Message);
                }
            }
        }

        private void SaveNewItem()
        {
            string lappenjid = string.Empty;
            if (ValidateFields())
            {
                using (sinarekDataSetTableAdapters.lappenTableAdapter tbl = new sinarekDataSetTableAdapters.lappenTableAdapter())
                {
                    try
                    {
                        lappenjid = tbl.pInsertLapPenj(int.Parse(row_["logid"].ToString())
                                            , dtpTanggal.Value
                                            , dtpKembali.Value
                                            , NBConfig.ValidUserName
                                            , "Penjualan").ToString();
                    }
                    catch (Exception ex)
                    {
                        helper.NotifMessage("Laporan untuk " + txtSuratJalan.Text + " sudah terinput.");
                        helper.SysLog(this.GetType().Name, this.Text, "SaveNewItem :" + ex.Message);
                        lappenjid = tbl.GetLapPenID(int.Parse(row_["logid"].ToString())
                                            , "Penjualan").ToString();
                    }
                    finally
                    {
                    }
                }


                //Pas Value to other form
                this.Hide();
                frmInputPenjualan frm = new frmInputPenjualan(row_,lappenjid, dtpKembali.Value, dtpTglSJ.Value, dtpTanggal.Value);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog(this.Owner);
                this.Close();
            }
        }

        private bool ValidateFields()
        {
            bool bValid = false;
            if (dtpKembali.Value == null)
            {
                MessageBox.Show("Silahkan Input Tanggal Pulang!", "SMS - Error Notification");
                dtpKembali.Focus();
                return bValid;
            }
            if (dtpTanggal.Value == null)
            {
                MessageBox.Show("Silahkan Input Tanggal Laporan!", "SMS - Error Notification");
                dtpTanggal.Focus();
                return bValid;
            }

            bValid = true;
            return bValid;
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

        private void frmInputLP_Load(object sender, EventArgs e)
        {
            this.salesTableAdapter.Fill(this.sinarekDataSet.sales);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SaveNewItem();
        }
    }
}
