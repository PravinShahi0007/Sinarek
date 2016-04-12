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
    public partial class frmBuruh : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool edit_;
        private bool delete_;
        public frmBuruh()
        {
            InitializeComponent();
        }
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            string MenuName = (this.Tag != null ? this.Tag.ToString() : "");

            helper.GetPermissions(frmName, MenuName, out add_, out edit_, out delete_);
        }
        private void frmBuruh_Load(object sender, EventArgs e)
        {
            this.gajitemplateallTableAdapter.Fill(this.sinarekDataSet.gajitemplateall);
            this.memberTableAdapter.Fill(this.sinarekDataSet.member);
            
            InitializeButtons();

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
