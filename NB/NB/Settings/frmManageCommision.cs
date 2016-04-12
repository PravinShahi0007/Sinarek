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
    public partial class frmManageCommision : Telerik.WinControls.UI.RadForm
    {
        public frmManageCommision()
        {
            InitializeComponent();
            this.radGridView1.EnableCustomGrouping = true;
            this.radGridView1.CustomGrouping += new GridViewCustomGroupingEventHandler(radGridView1_CustomGrouping);
            GroupDescriptor descriptor = new GroupDescriptor("DalamKota");
            this.radGridView1.GroupDescriptors.Add(descriptor);
            //Add Total info         
            this.radGridView1.GroupDescriptors[0].Aggregates.Add("count(commisionid)");
            this.radGridView1.GroupDescriptors[0].Format = "{0} ({1})";

            this.radGridView1.GroupSummaryEvaluate += new GroupSummaryEvaluateEventHandler(radGridView1_GroupSummaryEvaluate);
        }
        private void radGridView1_CustomGrouping(object sender, GridViewCustomGroupingEventArgs e)
        {
            string groupkey = "";
            string status = e.Row.Cells["DalamKota"].Value.ToString();
            switch (status)
            {
                case "True":
                    groupkey = "Dalam Kota";
                    break;
                case "False":
                    groupkey = "Luar Kota";
                    break;
            }
            string tunai = e.Row.Cells["Cash"].Value.ToString();
            switch (tunai)
            {
                case "True":
                    groupkey += " - Tunai";
                    break;
                case "False":
                    groupkey += " - Kredit";
                    break;
            }
            
            e.GroupKey = groupkey;
        }
        private void radGridView1_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if (e.Value == null)
            {
                e.FormatString = e.Group.Key.ToString() + " ({2})";
            }
        }
        private void frmManageCommision_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet1.vproductbase' table. You can move, or remove it, as needed.
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet1.vproductbase);
            this.productbaseTableAdapter.Fill(this.sinarekDataSet.productbase);
            this.comissionTableAdapter.Fill(this.sinarekDataSet.comission);
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            if (cell.CommandButton.Text.ToLower() == "delete")
            {
                this.comissionTableAdapter.DeleteComission(int.Parse(cell.RowInfo.Cells["commisionid"].Value.ToString()));
                helper.NotifMessage("Komisi telah dihapus");
                this.comissionTableAdapter.Fill(this.sinarekDataSet.comission);
            }
        }

        private void btnDKAdd_Click(object sender, EventArgs e)
        {
            this.comissionTableAdapter.InsertComission(int.Parse(rddDKPRoduct.SelectedValue.ToString())
                , decimal.Parse(txtNilai.Text)
                , chkCash.Checked, chkDalamKota.Checked, NBConfig.ValidUserName);
            this.comissionTableAdapter.Fill(this.sinarekDataSet.comission);
            rddDKPRoduct.ResetText();
            txtNilai.ResetText();
            chkCash.Checked = false;
            chkDalamKota.Checked = false;
            rddDKPRoduct.Focus();
        }

        private void radGridView1_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            if (e.Row != null)
            {
                this.comissionTableAdapter.UpdateComission(decimal.Parse(e.Row.Cells["value"].Value.ToString())
                                                            ,e.Row.Cells["cash"].Value,e.Row.Cells["dalamkota"].Value
                                                            ,NBConfig.ValidUserName,int.Parse(e.Row.Cells["commisionid"].Value.ToString()));
            }
        }
    }
}
