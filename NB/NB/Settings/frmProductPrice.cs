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
    public partial class frmProductPrice : Telerik.WinControls.UI.RadForm
    {
        public frmProductPrice()
        {
            InitializeComponent();
        }

        private void frmProductPrice_Load(object sender, EventArgs e)
        {
            try
            {
                this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
                rddKota.FindItemExact("Dalam Kota", false).Selected = true;

                this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
                //this.productpriceTableAdapter.Fill(this.sinarekDataSet.productprice);
                //this.productpriceTableAdapter.FillByKota(this.sinarekDataSet.productprice, (int)rddKota.SelectedValue);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.productpriceTableAdapter.pUpdateProductPrice();
            //Refresh data
            this.productpriceTableAdapter.FillByKota(this.sinarekDataSet.productprice, (int)rddKota.SelectedValue);
        }

        private void RadDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            //Refresh data
            this.productpriceTableAdapter.FillByKota(this.sinarekDataSet.productprice, (int)rddKota.SelectedValue);
        }
    }
}
