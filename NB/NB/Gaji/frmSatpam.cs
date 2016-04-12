using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace NB
{
    public partial class frmSatpam : Telerik.WinControls.UI.RadForm
    {
        public frmSatpam()
        {
            InitializeComponent();

        }

        private void frmSatpam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.sinarekDataSet.member);
            radGridView1.DisplayedRowCount(false);
        }

        private void radGridView1_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Reset)
            {
                foreach (GridViewRowInfo row in radGridView1.Rows)
                {
                    row.Cells["norow"].Value = row.Index + 1;
                }
            }
        }

    }
}
