using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace NB
{
    public partial class frmLihatKartuL : Telerik.WinControls.UI.RadForm
    {
        private bool add_ =false, edit_ = false, delete_ = false;
        public frmLihatKartuL()
        {
            InitializeComponent();
        }
        private void RefreshDataProduct()
        {
            try
            {
                string sQuery = "Select distinct productid,Description From vproductbase Where tipeid not in (1,9,11) Group by productid";
                MySqlConnection oConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);
                MySqlCommand oCom = new MySqlCommand(sQuery, oConn);
                MySqlDataAdapter adapt = new MySqlDataAdapter(oCom);
                DataTable tb = new DataTable();
                adapt.Fill(tb);

                rddProduct.DataSource = tb;
            }
            catch (Exception ex)
            {
                helper.ErrorMessage(ex.Message + ex.StackTrace);
            }
        }
        private void RefreshDataProductTotal()
        {
            //Clear display list
            displayList.Items.Clear();
            displayList.Columns.Clear();
            try
            {
                string sQuery = "Select * From producttotal Where (tanggal ='" + dtpTanggal.Value.ToString("yyyy-MM-dd") 
                    + "' or tanggal = '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "') and baseid in (Select baseid from productbase where productid =" + rddProduct.SelectedValue.ToString() + ")";
                MySqlConnection oConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);
                MySqlCommand oCom = new MySqlCommand(sQuery, oConn);
                MySqlDataAdapter adapt = new MySqlDataAdapter(oCom);
                DataTable productTotal = new DataTable();
                adapt.Fill(productTotal);

                //Get data awal
                //sQuery = "Select baseid from vproductbase where productid =" + rddProduct.SelectedValue.ToString();
                string sColumnQuery = "Select Distinct unitid,Short from vproductbase where productid =" + rddProduct.SelectedValue.ToString() + " order by convrate desc ";
                DataTable tipeProduct = new DataTable();
                oCom.CommandText = sColumnQuery;
                adapt.Fill(tipeProduct);

                //Create column for each product type
                displayList.Columns.Add(new ListViewDetailColumn("TransactionType", ""));
                ListViewDataItem awalItem = new ListViewDataItem("AWAL");
                ListViewDataItem akhirItem = new ListViewDataItem("AKHIR");
                awalItem.TextAlignment = ContentAlignment.MiddleCenter;
                awalItem[displayList.Columns[0]] = "SALDO AWAL As of " + dtpTanggal.Value.ToString("dd MMM yyy");
                akhirItem.TextAlignment = ContentAlignment.MiddleCenter;
                akhirItem[displayList.Columns[0]] = "SALDO AKHIR As of " + dtpEndDate.Value.ToString("dd MMM yyy");
                
                var i = 1;
                foreach (DataRow row in tipeProduct.Rows)
                {
                    ListViewDetailColumn col = new ListViewDetailColumn(row["short"].ToString(), row["short"].ToString());
                    //col.PropertyValues
                    displayList.Columns.Add(col);
                    //get saldo awal dan akhir
                    using (sinarekDataSetTableAdapters.QueriesTableAdapter query = new sinarekDataSetTableAdapters.QueriesTableAdapter())
                    {
                        //get data awal dan akhir
                        string baseID = query.GetBaseID(int.Parse(rddProduct.SelectedValue.ToString())
                            , int.Parse(row["unitid"].ToString())).ToString();
                        //get awal
                        var res = query.pGetSaldoProductBase(int.Parse(baseID), dtpTanggal.Value.ToString("yyyy-MM-dd"), "AWAL");
                        string awal = ( res == null ? "No DATA" : res.ToString());
                        awalItem[displayList.Columns[i]] = awal;

                        res = query.pGetSaldoProductBase(int.Parse(baseID), dtpEndDate.Value.ToString("yyyy-MM-dd"), "AKHIR");
                        string akhir = (res == null ? "No DATA" : res.ToString());
                        akhirItem[displayList.Columns[i]] = akhir;
                    }
                    i++;
                }

                displayList.Items.Add(awalItem);
                displayList.Items.Add(akhirItem);
            }
            catch (Exception ex)
            {
                helper.ErrorMessage(ex.Message + ex.StackTrace);
            }
        }
        private void frmLihatKartu_Load(object sender, EventArgs e)
        {
            rddProduct.ValueMember = "productid";
            rddProduct.DisplayMember = "description";

            RefreshDataProduct();
            this.gajimingguanTableAdapter.Fill(this.sinarekDataSet.gajimingguan);
            rddMingguan.SelectedValue = NBConfig.IGMID;
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            //SetConditions();
            InitializeButtons();
            dtpEndDate.Value = DateTime.Now;
            dtpTanggal.Value = DateTime.Now.AddMonths(-1);
            RefreshDataProductTotal();
        }

        private void SetConditions()
        {
            //Kemarin
            //ConditionalFormattingObject c4 = new ConditionalFormattingObject("Light Blue, applied to entire row", ConditionTypes.Less, dtpTanggal.Value.ToString("dd MMM yy"), "", true);
            //c4.RowBackColor = Color.LightBlue;
            //radGridView1.Columns["created"].ConditionalFormattingObjectList.Clear();
            //radGridView1.Columns["created"].ConditionalFormattingObjectList.Add(c4);
        }
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            helper.GetPermissions(frmName, this.Tag.ToString(), out add_, out edit_, out delete_);

            dtpTanggal.Enabled = delete_;
            dtpEndDate.Enabled = delete_;
            rddMingguan.Enabled = delete_;
            rddMingguan.Visible = delete_;
            btnPrint.Enabled = delete_;
        }
        private void rddProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddProduct.SelectedValue != null)
            {
                RefreshDataProductTotal();

                this.vperhitunganbarangTableAdapter.FillByTanggalProduct(this.sinarekDataSet.vperhitunganbarang
                                                , dtpTanggal.Value, dtpEndDate.Value
                                                , int.Parse(rddProduct.SelectedValue.ToString()));
                //SetConditions();
            }
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            if (rddProduct.SelectedValue != null)
            {
                RefreshDataProductTotal();
                //SetConditions();
                this.vperhitunganbarangTableAdapter.FillByTanggalProduct(this.sinarekDataSet.vperhitunganbarang
                                                , dtpTanggal.Value, dtpEndDate.Value
                                                , int.Parse(rddProduct.SelectedValue.ToString()));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if ((rddProduct.SelectedValue != null) && (dtpTanggal.Value != null) && (dtpEndDate.Value != null))
            {
                //get perhitungan stock awal for the selected date

                this.vperhitunganbarangTableAdapter.FillByTanggalProduct(this.sinarekDataSet.vperhitunganbarang
                                                    , dtpTanggal.Value, dtpEndDate.Value
                                                    , int.Parse(rddProduct.SelectedValue.ToString()));
            }
        }

        private void rddMingguan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddMingguan.SelectedItem != null)
            {
                DataRowView row = (DataRowView)rddMingguan.SelectedItem.DataBoundItem;
                dtpTanggal.Value = DateTime.Parse(row.Row["startdate"].ToString());
                dtpEndDate.Value = DateTime.Parse(row.Row["enddate"].ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the count for stock and create data for awal and akhir
        }

        
        

    }
}
