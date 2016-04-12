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
    public partial class frmBBM : Telerik.WinControls.UI.RadForm
    {
        public frmBBM()
        {
            InitializeComponent();
        }

        private void rddProduct_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void frmBBM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.pengisian' table. You can move, or remove it, as needed.
            this.pengisianTableAdapter.Fill(this.sinarekDataSet.pengisian);

        }
    }
}
