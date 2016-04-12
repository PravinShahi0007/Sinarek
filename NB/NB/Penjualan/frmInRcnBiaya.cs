using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NB
{
    public partial class frmInRcnBiaya : Telerik.WinControls.UI.RadForm
    {
        private string salesid_;
        private string kotaid_;
        private string logid_;
        private string lappenid_;
        private string kotaName_;
        private string ujid_ = "-1";
        private bool bensin_ = false;
        public frmInRcnBiaya(string LogID,string LapPenID)
            : this("1","1",LogID,LapPenID)
        {
        }
        public frmInRcnBiaya(string SalesID, string KotaID,string KotaName, string LogID, string LapPenID, string LogPelID)
            : this(SalesID, KotaID, LogID, LapPenID)
        {
            ujid_ = LogPelID;
            kotaName_ = KotaName;
        }
        public frmInRcnBiaya(string SalesID, string KotaID, string LogID, string LapPenID, string LogPelID)
            : this(SalesID, KotaID, LogID, LapPenID)
        {
            ujid_ = LogPelID;
        }
        public frmInRcnBiaya(string SalesID,string KotaID, string LogID,string LapPenID)
        {
            InitializeComponent();
            salesid_ = SalesID;
            kotaid_ = KotaID;
            logid_ = LogID;
            lappenid_ = LapPenID;
        }
        
        private void frmInRcnBiaya_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.pelTableAdapter.Fill(this.sinarekDataSet.pel);
            this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
            this.logotherTableAdapter.Fill(this.sinarekDataSet.logother);

            if(string.IsNullOrEmpty(kotaName_))
            {
                DataRow[] dt = sinarekDataSet.kota.Select("kotaid = " + kotaid_);
                kotaName_ = dt[0]["nama"].ToString();
            }
            rddKota.FindItemExact(kotaName_, false).Selected = true;
            dtpTanggal.Value = DateTime.Now.AddDays(-1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region "Methods"
        private void InitializeButtons()
        {

        }
        private bool ValidateFields()
        {
            //kota, kernet, sopir, mobil
            if (dtpTanggal.Value == null)
            {
                MessageBox.Show("Silahkan tanggal !", "SMS - Validation Error");
                dtpTanggal.Focus();
                return false;
            }
            if (rddProduct.SelectedValue == null)
            {
                MessageBox.Show("Silahkan pilih tipe biaya !", "SMS - Validation Error");
                rddProduct.Focus();
                return false;
            }

            if (txtPrice.Text == "0.00")
            {
                MessageBox.Show("Silahkan input harga !", "SMS - Validation Error");
                txtPrice.Focus();
                return false;
            }
            if (txtQuantity.Text == "0.0")
            {
                MessageBox.Show("Silahkan input jumlah !", "SMS - Validation Error");
                txtQuantity.Focus();
                return false;
            }
            if (rddProduct.Text.ToLower() == "isi bensin")
            {
                if(string.IsNullOrEmpty(txtKeterangan.Text))
                {
                    MessageBox.Show("Silahkan input no spbu !", "SMS - Validation Error");
                    txtKeterangan.Select();
                    return false;
                }
            }
            if (bensin_)
            {
                //validate spbu and km too
                
            }

            return true;
        }
        private void SaveNewItem()
        {
            int sign = 1;
            if ((bool)rddProduct.Tag)
            {
                sign = -1;
            }
            //SaveItem                      
            using (sinarekDataSetTableAdapters.logotherTableAdapter tbl = new sinarekDataSetTableAdapters.logotherTableAdapter())
            {
                tbl.InsertDataPenjualan(long.Parse(logid_)
                                        , int.Parse(ujid_)
                                        ,int.Parse(lappenid_)
                                        , dtpTanggal.Value
                                        , txtKeterangan.Text
                                        , 0
                                        , -1
                                        , dtpTanggal.Value
                                        , (sign *decimal.Parse(txtQuantity.Text))
                                        , int.Parse(rddProduct.SelectedValue.ToString())
                                        , decimal.Parse(txtPrice.Text)
                                        , int.Parse(rddKota.SelectedValue.ToString())
                                        , ""
                                        , txtDetail2.Text
                                        , txtTime.Text
                                        , NBConfig.ValidUserName);
            }
        }
        private void ResetForm()
        {
            rddKota.FindItemExact(kotaName_, false).Selected = true;
            rddProduct.ResetText();
            txtPrice.ResetText();
            txtQuantity.ResetText();
            txtQuantity.Value = 0;
            txtPrice.Value = 0;
            txtKeterangan.ResetText();
            txtDetail2.ResetText();
        }
        private void UpdatePriceText()
        {
            if (rddKota.SelectedValue != null && rddProduct.SelectedValue != null)
            {
                decimal price_ = 0;
                //get price according to kota and 
                if (bool.Parse(rddProduct.Tag.ToString()))
                {
                    txtPrice.Value = 0;
                    txtPrice.Enabled = true;
                }
                else
                {
                    //get price
                    using (sinarekDataSetTableAdapters.productpriceTableAdapter tbl = new sinarekDataSetTableAdapters.productpriceTableAdapter())
                    {
                        price_ = decimal.Parse(tbl.GetPrice(int.Parse(rddProduct.SelectedValue.ToString())
                            , int.Parse(rddKota.SelectedValue.ToString())).ToString());
                    }
                    txtPrice.Value = price_;
                    txtPrice.Enabled = false;
                }
            }
        }
        private void UpdateKeteranganText()
        {
            if (rddProduct.Text.ToLower() == "isi bensin")
            {
                lblKet1.Text = "No. SPBU";
            }
        }
        #endregion        

        private void rddProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            //UpdatePriceText();
            //Change
            if (rddProduct.Text.ToLower().Contains("bensin"))
            {
                bensin_ = true;
                lblKet1.Text = "SPBU :";
                lblKet2.Text = "KM :";
                txtKeterangan.MaskType = MaskType.Standard;
                txtKeterangan.Mask = @"990\.990\.990";
                txtKeterangan.PromptChar = '0';
                txtDetail2.MaskType = MaskType.Numeric;
                txtDetail2.Mask = "d8";
                txtTime.MaskType = MaskType.DateTime;
                txtTime.Mask = "HH:mm";
                txtTime.Visible = true;
                lblTime.Visible = true;
            }
            else
            {
                bensin_ = false;
                lblKet1.Text = "Keterangan 1 :";
                lblKet2.Text = "Keterangan 2 :";
                txtDetail2.MaskType = MaskType.None;
                txtDetail2.Mask = "";
                txtKeterangan.MaskType = MaskType.None;
                txtKeterangan.Mask = "";
                txtTime.MaskType = MaskType.None;
                txtTime.Mask = "";
                txtTime.Visible = false;
                lblTime.Visible = false;
            }
        }

        private void rddKota_SelectedValueChanged(object sender, EventArgs e)
        {
            //UpdatePriceText();
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {            
            if (ValidateFields())
            {
                SaveNewItem();
                this.Close();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                SaveNewItem();
                ResetForm();
                dtpTanggal.Focus();
            }
        }

        
    }
}
