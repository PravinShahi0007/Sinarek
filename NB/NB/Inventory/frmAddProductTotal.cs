using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace NB
{
    public partial class frmAddProductTotal : Telerik.WinControls.UI.RadForm
    {
        private int tipe_ = 1;
        private string user_ = string.Empty;
        public frmAddProductTotal(int TipeID, DateTime Tanggal, string User)
        {
            InitializeComponent();
            tipe_ = TipeID;
            dtpTanggal.Value = Tanggal;
            user_ = User;
        }
        public frmAddProductTotal(int TipeID,DateTime Tanggal):this(TipeID,Tanggal,NBConfig.ValidUserName)
        {
            
        }

        private void frmAddProductTotal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.vproductbase' table. You can move, or remove it, as needed.
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            vproductbaseBindingSource.Filter = "tipeid = " + tipe_;
        }

        #region "Methods"

        private bool  validateFields()
        {

            bool bValid = false;
            if (rddProduct.SelectedValue == null)
            {
                MessageBox.Show("Silahkan pilih nama produk!.", "SMS - Validation Notification");
                rddProduct.Focus();
                return bValid;
            }
            if (decimal.Parse(txtSisa.Value.ToString()) < 0)
            {
                MessageBox.Show("Silahkan input sisa produk!.", "SMS - Validation Notification");
                txtSisa.Focus();
                return bValid;
            }
            bValid = true;
            return bValid;
        }
        private void SaveNewItem()
        {
            if (validateFields())
            {
                using (sinarekDataSetTableAdapters.producttotaluserTableAdapter tbl = new sinarekDataSetTableAdapters.producttotaluserTableAdapter())
                {
                    try
                    {
                        tbl.InsertProductTotalUSer(dtpTanggal.Value
                                                    , ""
                                                    , int.Parse(rddProduct.SelectedValue.ToString())
                                                    , decimal.Parse(txtSisa.Value.ToString())
                                                    , user_);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(rddProduct.Text + " sudah terinput.", "SMS - Error Notification");
                    }
                }
            }
        }

        private void ResetFields()
        {
            rddProduct.ResetText();
            txtSisa.ResetText();            
        }
        #endregion

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveNewItem();
            ResetFields();
            rddProduct.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SaveNewItem();
            ResetFields();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
