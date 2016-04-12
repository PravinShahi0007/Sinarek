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
    public partial class frmNaikBarang : Telerik.WinControls.UI.RadForm
    {
        public frmNaikBarang()
        {
            InitializeComponent();
        }

        private void frmNaikBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.vproductbase' table. You can move, or remove it, as needed.
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);

        }
    }
}
