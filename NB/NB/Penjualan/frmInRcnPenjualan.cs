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
    public partial class frmInRcnPenjualan : Telerik.WinControls.UI.RadForm
    {
        #region "Private Variables"
        private string salesid_;
        private string kotaid_;
        private string logid_;
        private string lappenid_;
        private bool add_;
        private bool edit_;
        private bool delete_;
        #endregion

        #region "Control Events"
        public frmInRcnPenjualan(string LogID,string LapPenID)
            : this("1", "1", LogID, LapPenID)
        {
        }
        public frmInRcnPenjualan(string SalesID,string KotaID, string LogID, string LapPenID)
        {
            InitializeComponent();
            salesid_ = SalesID;
            kotaid_ = KotaID;
            logid_ = LogID;
            lappenid_ = LapPenID;

            //Add Total info         
            this.radGridView1.GroupDescriptors[0].Aggregates.Add("sum(iif(statusid = 1,0,total))");
            this.radGridView1.GroupDescriptors[0].Format = "Total : {2:Rp #,###.00}";
            radGridView1.AutoExpandGroups = true;  
  
        }     
        private void frmInRcnPenjualan_Load(object sender, EventArgs e)
        {
            SetConditions();
            // TODO: This line of code loads data into the 'sinarekDataSet.vproductbase' table. You can move, or remove it, as needed.
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            // TODO: This line of code loads data into the 'sinarekDataSet.pel' table. You can move, or remove it, as needed.
            this.pelTableAdapter.Fill(this.sinarekDataSet.pel);
            // TODO: This line of code loads data into the 'sinarekDataSet.kota' table. You can move, or remove it, as needed.
            this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
            //this.logotherTableAdapter.Fill(this.sinarekDataSet.logother);

            rddKota.SelectedValue = int.Parse(kotaid_);
            dtpTanggal.Value = DateTime.Now;
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNota.Text == "000000")
            {
                MessageBox.Show("Silahkan input no nota!", "SMS - Validation Error");
                txtNota.Focus();                
            }else if (decimal.Parse(txtQuantity.Text) <= 0)
            {
                MessageBox.Show("Jumlah produk harus lebih dari 0", "SMS - Validation Error");
                txtQuantity.Focus();
            }
            else
            {
                GridViewRowInfo row = radGridView1.Rows.AddNew();
                row.Cells["productid"].Value = rddProduct.SelectedValue;
                row.Cells["nota"].Value = txtNota.Text;
                row.Cells["kotaid"].Value = rddKota.SelectedValue;
                row.Cells["harga"].Value = txtPrice.Text;
                if(bool.Parse(rddProduct.Tag.ToString()))
                {
                    row.Cells["quantity"].Value = "-" + txtQuantity.Text;
                }else
                {
                    row.Cells["quantity"].Value = txtQuantity.Text;
                }
                row.Cells["keterangan"].Value = txtKeterangan.Text;
                if (chkTukar.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                {
                    row.Cells["statusid"].Value = 1;
                }
                else
                {
                    row.Cells["statusid"].Value = 0;
                }
                txtNota.ResetText();
                rddProduct.ResetText();
                txtQuantity.ResetText();
                txtPrice.ResetText();
                txtKeterangan.ResetText();
                txtNota.Focus();
                chkTukar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;

            }
        }
        private void rddProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdatePriceText();
        }
        private void btnNewPel_Click(object sender, EventArgs e)
        {
            frmAddPelanggan frm = new frmAddPelanggan(int.Parse(salesid_),int.Parse(rddKota.SelectedValue.ToString()));
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowIcon = false;
            frm.ShowDialog(this);

            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.pelTableAdapter.Fill(this.sinarekDataSet.pel);
                rddPel.FindItemExact(frm.PELNAME,false).Selected = true;
                rddPel.Focus();
            }
        }
        private void rddKota_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdatePriceText();
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
                rddKota.Focus();
            }
        }

        #endregion

        #region "Methods"
        
        private bool ValidateFields()
        {
            //kota, kernet, sopir, mobil
            if (rddKota.SelectedValue == null)
            {
                MessageBox.Show("Silahkan pilih kota !", "SMS - Validation Error");
                rddKota.Focus();
                return false;
            }
            if (rddPel.SelectedValue == null)
            {
                MessageBox.Show("Silahkan pilih pelanggan !", "SMS - Validation Error");
                rddPel.Focus();
                return false;
            }

            if (dtpTanggal.Value == null)
            {
                MessageBox.Show("Silahkan pilih tanggal !", "SMS - Validation Error");
                dtpTanggal.Focus();
                return false;
            }
            
            //Validate Product
            if (radGridView1.Rows.Count < 1 && (chkKunjungan.ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off))
            {
                MessageBox.Show("Belum ada produk yang di pilih.", "SMS - Validation Error");
                rddProduct.Focus();
                return false;
            }

            return true;
        }
        private void SaveNewItem()
        {
            string logpelid;
            try
            {
                //SaveItem
                using (sinarekDataSetTableAdapters.logpelTableAdapter tbl = new sinarekDataSetTableAdapters.logpelTableAdapter())
                {
                    logpelid = tbl.pDataPenjPelanggan(int.Parse(rddPel.SelectedValue.ToString())
                                                        , int.Parse(logid_)                                                        
                                                        , dtpTanggal.Value
                                                        , int.Parse(salesid_)
                                                        , (chkCredit.Checked ? 1 : 0)
                                                        , NBConfig.ValidUserName).ToString();
                }

                if (chkKunjungan.ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off)
                {
                    using (sinarekDataSetTableAdapters.logotherTableAdapter tbl = new sinarekDataSetTableAdapters.logotherTableAdapter())
                    {
                        foreach (GridViewRowInfo item in radGridView1.Rows)
                        {
                            tbl.InsertDataPenjualan(long.Parse(logid_)
                                                    , int.Parse(logpelid)
                                                    , int.Parse(lappenid_)
                                                    , dtpTanggal.Value
                                                    , (item.Cells["keterangan"].Value == null ? "" : item.Cells["keterangan"].Value.ToString())
                                                    , 0
                                                    , short.Parse(item.Cells["statusid"].Value.ToString())
                                                    , null
                                                    , decimal.Parse(item.Cells["quantity"].Value.ToString())
                                                    , int.Parse(item.Cells["productid"].Value.ToString())
                                                    , decimal.Parse(item.Cells["harga"].Value.ToString())
                                                    , int.Parse(item.Cells["kotaid"].Value.ToString())
                                                    , item.Cells["nota"].Value.ToString()
                                                    , ""
                                                    , ""
                                                    , NBConfig.ValidUserName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                helper.ErrorMessage("Error menyimpan data penjualan");
                helper.SysLog(this.GetType().Name, this.Text, ex.Message + " : " + ex.StackTrace);
            }
        }
        private void ResetForm()
        {
            rddKota.SelectedValue = int.Parse(kotaid_);
            rddPel.ResetText();
            rddProduct.ResetText();
            txtPrice.Value = 0;
            chkCredit.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            chkKunjungan.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            radGridView1.Rows.Clear();
        }
        private void UpdatePriceText()
        {
            try
            {
                if (rddKota.SelectedValue != null && rddProduct.SelectedValue != null)
                {
                    decimal price_ = 0;
                    //get price according to kota and 
                    if (bool.Parse(rddProduct.Tag.ToString()))
                    {
                        txtPrice.Value = 0;
                        txtPrice.Enabled = true;
                        chkTukar.Enabled = false;
                    }
                    else
                    {
                        chkTukar.Enabled = true;
                        //get price
                        try
                        {
                            using (sinarekDataSetTableAdapters.productpriceTableAdapter tbl = new sinarekDataSetTableAdapters.productpriceTableAdapter())
                            {
                                price_ = decimal.Parse(tbl.GetPrice(int.Parse(rddProduct.SelectedValue.ToString())
                                    , int.Parse(rddKota.SelectedValue.ToString())).ToString());
                            }
                        }
                        catch (Exception ex)
                        {
                            helper.SysLog(this.GetType().Name, "ERROR :" + this.Text, ex.Message + ":" + ex.StackTrace);
                        }
                        if (price_ == 0)
                        {
                            txtPrice.Value = 0;
                            txtPrice.Enabled = true;
                        }
                        else
                        {
                            txtPrice.Value = price_;
                            txtPrice.Enabled = false;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                helper.SysLog(this.GetType().Name, this.Text, "ERROR :" + ex.Message + ":" + ex.StackTrace);
                txtPrice.Value = 0;
                txtPrice.Enabled = true;
            }
        }
        private void SetConditions()
        {
            //Tukar
            ConditionalFormattingObject c2 = new ConditionalFormattingObject("Light Sea Green, applied to entire row", ConditionTypes.Equal, "1", "", true);
            c2.RowBackColor = Color.LightSeaGreen;
            radGridView1.Columns["statusid"].ConditionalFormattingObjectList.Add(c2);          
        }
        #endregion

        private void chkKunjungan_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                radGroupBox1.Enabled = false;
            }
            else
            {
                radGroupBox1.Enabled = true;
            }
        }

        private void btnKunjungan_Click(object sender, EventArgs e)
        {

        }




    }
}
