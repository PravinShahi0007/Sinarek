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
    public partial class frmInputUJ : Telerik.WinControls.UI.RadForm
    {
        private string lappenid_;
        private bool add_;
        private bool edit_;
        private bool delete_;
        private string ujid_;
        private DataRow row_;
        private decimal value_;
        
        private bool printed_ = false;

        public frmInputUJ(DataRow DataRow_, string lappenid,bool printed)
        {
            add_ = false;
            edit_ = false;
            delete_ = false;

            InitializeComponent();
            lappenid_ = lappenid;
            printed_ = printed;
            row_ = DataRow_;

            using (sinarekDataSetTableAdapters.uangjalanTableAdapter tbl = new sinarekDataSetTableAdapters.uangjalanTableAdapter())
            {
                ujid_ = tbl.GetUJID(int.Parse(row_["LogID"].ToString())).ToString();
                DataRow data = tbl.GetDataByUJID(int.Parse(ujid_)).Rows[0];
                lblKernet.Text = "Kernet : " + data["KernetName"].ToString();
                lblSopir.Text = "Sopir : " + data["SopirName"].ToString();
                lblTujuan.Text = "Tujuan : " + data["Tujuan"].ToString();
                lblMobil.Text =  "Mobil : " + data["MobilName"].ToString();
                lblNoSJ.Text = "No. SJ : " + data["NoSJ"].ToString();
                value_ = decimal.Parse(data["value"].ToString());
                lblValue.Text = "Jumlah : " + value_.ToString("Rp #,###.00"); 
            }

        }
        private void InitialiazeButtons()
        {
            string frmName = this.Owner.GetType().Name;
            add_ = NBConfig.CheckPermission((this.Owner.Tag != null ? this.Owner.Tag.ToString() : ""), frmName, "add");
            edit_ = NBConfig.CheckPermission((this.Owner.Tag != null ? this.Owner.Tag.ToString() : ""), frmName, "edit");
            delete_ = NBConfig.CheckPermission((this.Owner.Tag != null ? this.Owner.Tag.ToString() : ""), frmName, "delete");

            btnInputBiaya.Enabled = ((!printed_)|| delete_);
            btnDelBiaya.Enabled = ((!printed_)|| delete_);
        }
        private void frmInputUJ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.kota' table. You can move, or remove it, as needed.
            this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
            // TODO: This line of code loads data into the 'sinarekDataSet.vproductbase' table. You can move, or remove it, as needed.
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            // TODO: This line of code loads data into the 'sinarekDataSet.logother' table. You can move, or remove it, as needed.
            this.logotherTableAdapter.FillByTipeLap(this.sinarekDataSet.logother, int.Parse(ujid_)
                                                , int.Parse(row_["logid"].ToString())
                                                , int.Parse(lappenid_)) ;
            InitialiazeButtons();
            GridViewSummaryRowItem summaryRowItem2 = new GridViewSummaryRowItem();
            GridViewSummaryItem summaryItem = new GridViewSummaryItem();
            summaryItem.Name = "Detail3";
            summaryItem.FormatString = "Sisa Uang Jalan :";
            summaryItem.Aggregate = GridAggregateFunction.Last;
            summaryRowItem2.Add(summaryItem);
            GridViewSummaryItem summaryItem2 = new GridViewSummaryItem();
            summaryItem2.Name = "Total";
            summaryItem2.FormatString = "{0:Rp #,###.00}";
            summaryItem2.AggregateExpression = value_.ToString() + " - Sum(Total)";
            summaryRowItem2.Add(summaryItem2);
            this.radGridView2.SummaryRowsTop.Add(summaryRowItem2);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
            GridViewSummaryItem summaryItem3 = new GridViewSummaryItem();
            summaryItem3.Name = "Total";
            summaryItem3.FormatString = "{0:Rp #,###.00}";
            summaryItem3.Aggregate = GridAggregateFunction.Sum;
            summaryRowItem.Add(summaryItem3);
            GridViewSummaryItem summaryItem4 = new GridViewSummaryItem();
            summaryItem4.Name = "Detail3";
            summaryItem4.FormatString = "Total Biaya :";
            summaryItem4.Aggregate = GridAggregateFunction.Sum;
            summaryRowItem.Add(summaryItem4);
            this.radGridView2.SummaryRowsTop.Add(summaryRowItem);
        }
        private void btnInputBiaya_Click(object sender, EventArgs e)
        {
            frmInRcnBiaya frm = new frmInRcnBiaya(row_["salesid"].ToString()
                                                , row_["kotaid"].ToString()
                                                , row_["logid"].ToString()
                                                , lappenid_
                                                , ujid_);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(this);
            this.logotherTableAdapter.FillByTipeLap(this.sinarekDataSet.logother, int.Parse(ujid_)
                                                , int.Parse(row_["logid"].ToString())
                                                , int.Parse(lappenid_));

        }
        private void btnDelBiaya_Click(object sender, EventArgs e)
        {
            if (!(radGridView2.SelectedRows[0] is GridViewGroupRowInfo))
            {
                DeleteLogOther(radGridView2.SelectedRows[0].Cells["logdetailid"].Value.ToString());

                this.logotherTableAdapter.FillByTipeLap(this.sinarekDataSet.logother, int.Parse(ujid_)
                                                    , int.Parse(row_["logid"].ToString())
                                                    , int.Parse(lappenid_));
            }
        }
        private void DeleteLogOther(string LogDetailID)
        {
            try
            {
                using (sinarekDataSetTableAdapters.logotherTableAdapter tbl = new sinarekDataSetTableAdapters.logotherTableAdapter())
                {
                    tbl.DeleteLogOther(int.Parse(LogDetailID));
                }
            }
            catch (Exception ex)
            {
                helper.SysLog(this.GetType().Name, this.Text, "DeleteLogOther : " + ex.Message);
            }


        }
    }
}
