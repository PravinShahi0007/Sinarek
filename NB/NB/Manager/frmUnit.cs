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
    public partial class frmUnit : Telerik.WinControls.UI.RadForm
    {
        public frmUnit()
        {
            InitializeComponent();
        }

        private void frmUnit_Load(object sender, EventArgs e)
        {
            this.tunitTableAdapter.Fill(this.sinarekDataSet.tunit);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddUnit frm = new frmAddUnit();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            this.sinarekDataSet.tunit.Clear();
            this.tunitTableAdapter.Fill(this.sinarekDataSet.tunit);
        }
    }
}
