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
    public partial class frmSup : Telerik.WinControls.UI.RadForm
    {
        public frmSup()
        {
            InitializeComponent();
        }


        private void frmAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.logproduct' table. You can move, or remove it, as needed.
            this.logproductTableAdapter.Fill(this.sinarekDataSet.logproduct);
            // TODO: This line of code loads data into the 'sinarekDataSet.sup' table. You can move, or remove it, as needed.
            this.supTableAdapter.Fill(this.sinarekDataSet.sup);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                supTableAdapter.InsertSupplier(txtName.Text,"","","",0,0,NBConfig.ValidUserName);
                this.supTableAdapter.Fill(this.sinarekDataSet.sup);

                txtName.ResetText();
            }
            catch (Exception ex)
            {
                helper.ErrorMessage("Ada Masalah Menyimpan Account Baru");
            }
        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (!(e.Row is GridViewFilteringRowInfo))
            {
                supTableAdapter.UpdateSupplier(e.Row.Cells["Name"].Value.ToString()
                                                , e.Row.Cells["Address"].Value.ToString()
                                                , e.Row.Cells["Kota"].Value.ToString()
                                                , e.Row.Cells["Contact"].Value.ToString()
                                                , e.Row.Cells["Expedisi"].Value
                                                , e.Row.Cells["Botol"].Value
                                                , NBConfig.ValidUserName
                                                , int.Parse(e.Row.Cells["SupID"].Value.ToString()));
                this.supTableAdapter.Fill(this.sinarekDataSet.sup);
                radGridView1.TableElement.ScrollToRow(radGridView1.Rows[e.RowIndex]);
           }
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            if (cell.CommandButton.Text.ToLower() == "del")
            {
                supTableAdapter.DeleteSupplier(int.Parse(cell.RowInfo.Cells["SupID"].Value.ToString()));
                this.supTableAdapter.Fill(this.sinarekDataSet.sup);
            }
        }

    }
}
