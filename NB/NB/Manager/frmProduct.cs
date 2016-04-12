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
    public partial class frmProduct : Telerik.WinControls.UI.RadForm
    {
        //private int sellable_;
        //private int goods_;
        //private int others_;
                
        public frmProduct(): this("supply")
        {            
        }

        public frmProduct(string Tipe_)
        {
            InitializeComponent();

            //this.radGridView1.EnableCustomGrouping = true;
            //this.radGridView1.CustomGrouping += new GridViewCustomGroupingEventHandler(radGridView1_CustomGrouping);

            GroupDescriptor descriptor = new GroupDescriptor("TipeID");
            this.radGridView1.GroupDescriptors.Add(descriptor);
            //Add Total info         
            this.radGridView1.GroupDescriptors[0].Aggregates.Add("count(baseid)");
            this.radGridView1.GroupDescriptors[0].Format = "{1} ({2})";

            //this.radGridView1.GroupSummaryEvaluate += new GroupSummaryEvaluateEventHandler(radGridView1_GroupSummaryEvaluate);

            //switch (Tipe_.ToLower())
            //{
            //    case "supply":
            //        this.Text = "Supplies";
            //        sellable_ = 0;
            //        goods_ = 1;
            //        others_ = 0;
            //        break;
            //    case "stock":
            //        this.Text = "Stocks";
            //        sellable_ = 1;
            //        goods_ = 1;
            //        others_ = 0;
            //        break;
            //}                       
        }


        private void radGridView1_CustomGrouping(object sender, GridViewCustomGroupingEventArgs e)
        {
            //string groupkey = "";
            //bool bsellable = bool.Parse(e.Row.Cells["sellable"].Value.ToString());
            //bool bgoods = bool.Parse(e.Row.Cells["goods"].Value.ToString());
            //bool bothers = bool.Parse(e.Row.Cells["others"].Value.ToString());
            //bool bupdatable = bool.Parse(e.Row.Cells["updatable"].Value.ToString());

            //if (bsellable)
            //{
            //    if (bothers)
            //    {
            //        groupkey = "By Product";
            //    }
            //    else
            //    {
            //        groupkey = "Product";
            //    }
            //}
            //else
            //{
            //    groupkey = "Supply";

            //}
            //e.GroupKey = groupkey;
        }
        private void radGridView1_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            //if (e.Value == null)
            //{
            //    e.FormatString = e.Group.Key.ToString() + " ({2})";
            //}
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.tipeprod' table. You can move, or remove it, as needed.
            this.tipeprodTableAdapter.Fill(this.sinarekDataSet.tipeprod);
            // TODO: This line of code loads data into the 'sinarekDataSet.productbase' table. You can move, or remove it, as needed.
            this.productbaseTableAdapter.Fill(this.sinarekDataSet.productbase);
        }

        private void radGridView1_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            //Update harga barang
            if(e.Column.FieldName == "price")
            {
                int baseid = int.Parse(e.Row.Cells["baseid"].Value.ToString());
                decimal price = decimal.Parse(e.Row.Cells["price"].Value.ToString());
                this.productbaseTableAdapter.pUpdateProductPriceWithParent(baseid,price);
            }
            //Update Harga borongan
            if (e.Column.FieldName == "HargaB")
            {
                int baseid = int.Parse(e.Row.Cells["baseid"].Value.ToString());
                decimal price = decimal.Parse(e.Row.Cells["hargab"].Value.ToString());
                this.productbaseTableAdapter.UpdateBorongan(price, 1, baseid);

            }
            this.productbaseTableAdapter.Fill(this.sinarekDataSet.productbase);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddProductBase frm = new frmAddProductBase();
            frm.ShowDialog();

            this.sinarekDataSet.productbase.Clear();
            this.productbaseTableAdapter.Fill(this.sinarekDataSet.productbase);
        }

        private void rddTipe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddTipe.SelectedValue != null)
            {
                productbaseBindingSource.Filter = "tipeid = " + rddTipe.SelectedValue.ToString() + " and updatable = 1 and active = 1" ;
            }
        }

        private void btnMoveGroup_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            Telerik.WinControls.Export.GridViewPdfExport pdfExporter = new Telerik.WinControls.Export.GridViewPdfExport(this.radGridView1);
            string fileNameAsync = "c:\\Users\\Vina\\Downloads\\Test.pdf";
            pdfExporter.RunExport(fileNameAsync);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete the " + lblSelected.Text.ToLower(), "Delete confirmation", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                productbaseTableAdapter.ChangeProductBaseStatus(0, int.Parse(lblBaseID.Text));
                this.productbaseTableAdapter.Fill(this.sinarekDataSet.productbase);
            }
        }

        private void radGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //GridViewRowInfo row = radGridView1.SelectedRows[0];
            //lblSelected.Text = "Selected Item: " + row.Cells["ProductName"].Value.ToString();
            //lblBaseID.Text = row.Cells["BaseID"].Value.ToString();
        }

    
    }
}
