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
    public partial class frmInputDenda : Telerik.WinControls.UI.RadForm
    {
        public frmInputDenda()
        {
            InitializeComponent();
        }

        private void frmInputDenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.tipedenda' table. You can move, or remove it, as needed.
            this.tipedendaTableAdapter.Fill(this.sinarekDataSet.tipedenda);
            // TODO: This line of code loads data into the 'sinarekDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sinarekDataSet.product);

        }
    }
}
