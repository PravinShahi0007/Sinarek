using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NBViewer
{
    public partial class sfrmMain : Telerik.WinControls.UI.ShapedForm
    {
        public sfrmMain()
        {
            InitializeComponent();

            //populate data
            // TODO: This line of code loads data into the 'sinarekDataSet.producttotal' table. You can move, or remove it, as needed.
            this.pGetStockTransTanggalTableAdapter.Fill(this.sinarek.pGetStockTransTanggal,DateTime.Now.AddDays(-3),DateTime.Now,2);
        }
    }
}
