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
    public partial class frmProductTotal : Telerik.WinControls.UI.RadForm
    {
        public frmProductTotal()
        {
            InitializeComponent();
        }

        private void frmProductTotal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.tipeprod' table. You can move, or remove it, as needed.
            this.tipeprodTableAdapter.Fill(this.sinarekDataSet.tipeprod);

            //set current date
            dtpTanggal.Value = DateTime.Now;

            //set default tipe
            rddCategory.SelectedText = "Raw";
        }
    }
}
