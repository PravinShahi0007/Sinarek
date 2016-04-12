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
    public partial class frmPel : Telerik.WinControls.UI.RadForm
    {
        private int Direct = 1;

        public frmPel()
        {
            InitializeComponent();
        }

        private void frmPel_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'sinarekDataSet.DataNotaPelanggan' table. You can move, or remove it, as needed.
            //this.dataNotaPelangganTableAdapter.Fill(this.sinarekDataSet.DataNotaPelanggan);
            this.salesTableAdapter.Fill(this.sinarekDataSet.sales);
            this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
            this.pelTableAdapter.Fill(this.sinarekDataSet.pel);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                pelTableAdapter.InsertPelangganLangsung(txtName.Text,"",18,txtName.Text,12,NBConfig.ValidUserName);
                pelTableAdapter.Fill(this.sinarekDataSet.pel);

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
                int rowindex = e.RowIndex;
                pelTableAdapter.UpdatePelangganDetail(e.Row.Cells["Address"].Value.ToString()
                                                , int.Parse(e.Row.Cells["KotaID"].Value.ToString())
                                                , e.Row.Cells["Contact"].Value.ToString()
                                                , e.Row.Cells["Direct"].Value
                                                , NBConfig.ValidUserName
                                                , int.Parse(e.Row.Cells["CustID"].Value.ToString()));
                pelTableAdapter.Fill(this.sinarekDataSet.pel);
                radGridView1.TableElement.ScrollToRow(radGridView1.Rows[rowindex]);
                radGridView1.Rows[rowindex].IsSelected = true;
                radGridView1.Rows[rowindex].IsCurrent = true;
            }
        }

        private void radGridView1_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            //if (!(e.Row is GridViewFilteringRowInfo))
            //{
            //    int rowindex = e.RowIndex;
            //    pelTableAdapter.UpdatePelangganDetail(e.Row.Cells["Address"].Value.ToString()
            //                                    , int.Parse(e.Row.Cells["KotaID"].Value.ToString())
            //                                    , e.Row.Cells["Contact"].Value.ToString()
            //                                    , e.Row.Cells["Direct"].Value
            //                                    , NBConfig.ValidUserName
            //                                    , int.Parse(e.Row.Cells["CustID"].Value.ToString()));
            //    radGridView1.SuspendLayout();
            //    pelTableAdapter.Fill(this.sinarekDataSet.pel);
            //    radGridView1.ClearSelection();
            //    //radGridView1.CurrentRow = radGridView1.Rows[rowindex];
            //    radGridView1.Rows[rowindex].IsSelected = true;
            //    radGridView1.Rows[rowindex].IsCurrent = true;
            //    radGridView1.PerformLayout();
                
            //}
        }


    }
}
