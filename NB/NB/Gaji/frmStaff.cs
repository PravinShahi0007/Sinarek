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
    public partial class frmStaff : Telerik.WinControls.UI.RadForm
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            this.memberTableAdapter.Fill(this.sinarekDataSet.member);
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
