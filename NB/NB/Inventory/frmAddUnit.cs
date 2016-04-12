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
    public partial class frmAddUnit : Telerik.WinControls.UI.RadForm
    {
        public frmAddUnit()
        {
            InitializeComponent();
        }

        private void frmAddUnit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.tunit' table. You can move, or remove it, as needed.
            this.tunitTableAdapter.Fill(this.sinarekDataSet.tunit);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            short convRate = short.Parse(txtConv.Text);
            int parentid = -1;
            if(convRate > 2)
            {
                parentid = int.Parse(rddUnit.SelectedValue.ToString());
            }
            tunitTableAdapter.InsertUnit(txtShort.Text, txtDescription.Text, parentid, convRate, NBConfig.ValidUserName);

            this.Close();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            frmAddUnit frm = new frmAddUnit();
            frm.ShowDialog();

            //refresh
            this.sinarekDataSet.tunit.Clear();
            tunitTableAdapter.Fill(this.sinarekDataSet.tunit);
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
