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
    public partial class frmHistCustomer : Telerik.WinControls.UI.RadForm
    {
        public frmHistCustomer()
        {
            InitializeComponent();
        }

        private void frmHistCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.logproduct' table. You can move, or remove it, as needed.
            this.logproductTableAdapter.Fill(this.sinarekDataSet.logproduct);
            // TODO: This line of code loads data into the 'sinarekDataSet.kota' table. You can move, or remove it, as needed.
            this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
            // TODO: This line of code loads data into the 'sinarekDataSet.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.sinarekDataSet.sales);
            // TODO: This line of code loads data into the 'sinarekDataSet.pel' table. You can move, or remove it, as needed.
            this.pelTableAdapter.Fill(this.sinarekDataSet.pel);

        }
    }
}
