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
    public partial class frmAddProduct : Telerik.WinControls.UI.RadForm
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            using (sinarekDataSetTableAdapters.productTableAdapter tbl = new sinarekDataSetTableAdapters.productTableAdapter())
            {
                tbl.InsertProduct(txtDescription.Text, txtShort.Text);
            }
            MessageBox.Show(txtDescription.Text + " sudah tersimpan.");
            this.Close();
        }
    }
}
