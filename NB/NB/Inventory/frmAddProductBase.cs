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
    public partial class frmAddProductBase : Telerik.WinControls.UI.RadForm
    {
        public frmAddProductBase()
        {
            InitializeComponent();
        }

        private void frmAddProductBase_Load(object sender, EventArgs e)
        {
            this.custtypeTableAdapter.Fill(this.sinarekDataSet.custtype);
            this.tipeprodTableAdapter.Fill(this.sinarekDataSet.tipeprod);
            this.productTableAdapter.Fill(this.sinarekDataSet.product);
            this.tunitTableAdapter.Fill(this.sinarekDataSet.tunit);
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            frmAddProduct frm = new frmAddProduct();
            frm.ShowDialog();

            this.sinarekDataSet.product.Clear();
            this.productTableAdapter.Fill(this.sinarekDataSet.product);
            rddProd.Focus();
            rddProd.SelectText(0, rddProd.Text.Length);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SaveItem();
            this.Close();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            frmAddUnit frm = new frmAddUnit();
            frm.ShowDialog();

            this.sinarekDataSet.tunit.Clear();
            this.tunitTableAdapter.Fill(this.sinarekDataSet.tunit);
            rddUnit.Focus();
            rddUnit.SelectText(0,rddUnit.Text.Length);
        }

        private void btnNewTipe_Click(object sender, EventArgs e)
        {
            tipeprodTableAdapter.InsertTipeProd(txtTipeNama.Text);

            this.sinarekDataSet.tipeprod.Clear();
            tipeprodTableAdapter.Fill(this.sinarekDataSet.tipeprod);
            rddTipe.Focus();
            txtTipeNama.ResetText();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ResetForm();
            this.Close();
        }
        
        private void ResetForm()
        {
            //rddLoc.ResetText();
            rddProd.ResetText();
            //rddTipe.ResetText();
            rddUnit.ResetText();

            txtTipeNama.ResetText();
            txtPrice.ResetText();

            chkGoods.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            chkOthers.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            chkSellable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;

        }

        private void SaveItem()
        {
            try
            {
                using (sinarekDataSetTableAdapters.productbaseTableAdapter tbl = new sinarekDataSetTableAdapters.productbaseTableAdapter())
                {
                    //tbl.pInsertNewPackage(int.Parse(rddProd.SelectedValue.ToString())
                    //                      , int.Parse(rddUnit.SelectedValue.ToString())
                    //                      , decimal.Parse(txtPrice.Text));
                    tbl.pInsertProductBase(int.Parse(rddProd.SelectedValue.ToString())
                                          , int.Parse(rddUnit.SelectedValue.ToString())
                                          , decimal.Parse(txtPrice.Text)
                                          , (chkSellable.Checked ? 1 : 0)
                                          , (chkGoods.Checked ? 1 : 0)
                                          , (chkOthers.Checked ? 1 : 0)
                                          , int.Parse(rddTipe.SelectedValue.ToString())
                                          , int.Parse(rddLoc.SelectedValue.ToString()));
                }
            }
            catch (Exception ex)
            {
                helper.ErrorMessage("Ada masalah untuk menyimpan produk baru." + ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveItem();
            ResetForm();
            rddProd.Select();
            //rddTipe.SelectText(0, rddTipe.Text.Length);
        }
    }
}
