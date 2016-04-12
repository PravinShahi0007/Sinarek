using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NB
{
    public partial class frmTier : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool edit_;
        private bool delete_;
        public frmTier()
        {
            InitializeComponent();
        }

        private void frmTier_Load(object sender, EventArgs e)
        {
            try
            {
                this.statbotTableAdapter.Fill(this.sinarekDataSet.statbot);
                this.supTableAdapter.Fill(this.sinarekDataSet.sup);
                this.storeTableAdapter.Fill(this.sinarekDataSet.store);
                this.tierTableAdapter.Fill(this.sinarekDataSet.tier);
            }
            catch (Exception ex)
            {
                helper.ErrorMessage(ex.Message + " " + ex.StackTrace);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tierTableAdapter.InsertTier(txtNama.Text, int.Parse(txtKapasitas.Value.ToString()), 0, NBConfig.ValidUserName);
            this.tierTableAdapter.Fill(this.sinarekDataSet.tier);
        }

        public void GetPermission(out bool Add,out bool Edit,out bool Delete)
        {
            Add = add_;
            Edit = edit_;
            Delete = delete_;
        }

        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            string menuName = this.Tag.ToString();
            helper.GetPermissions(frmName, menuName, out add_, out edit_, out delete_);
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            if (cell.CommandButton.Text.ToLower() == "&isi")
            {
                //check if the tir is currently empty if not don't allow fill
            }
            //RadMessageBox.Show(cell.CommandButton.Text.ToString() + " : " + cell.RowInfo.Cells["Nama"].Value.ToString());
        }

        private void radGridView1_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            storeBindingSource.Filter = "tierid= " + e.CurrentRow.Cells["tierid"].Value.ToString();
        }

        private void radGridView2_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (e.Action == Telerik.WinControls.Data.NotifyCollectionChangedAction.Reset)
            {
                foreach (GridViewRowInfo row in radGridView2.Rows)
                {
                    row.Cells["NoRow"].Value = row.Index+ 1;
                }
            }
        }

        private void radGridView2_CommandCellClick(object sender, EventArgs e)
        {
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            if (cell.CommandButton.Text.ToLower() =="&view")
            {
                DataRowView dt = (DataRowView)cell.RowInfo.DataBoundItem;

                frmBotolTier frm = new frmBotolTier(dt.Row,decimal.Parse(radGridView1.CurrentRow.Cells["capacity"].Value.ToString()));
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog(this);
            }

        }


    }
}
