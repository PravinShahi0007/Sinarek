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
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Cashier
{
    public partial class frmReceivable : Telerik.WinControls.UI.RadForm
    {
        public frmReceivable()
        {
            InitializeComponent();
        }

        private void RefreshDataReceivable(ref RadGridView oGrid, string sQuery, int Tagih,int Credit)
        {
            //string sQuery = "Select * From LogPel where credit = 1";
            MySqlConnection oConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["Cashier.Properties.Settings.sinarekConnectionString"].ConnectionString);
            MySqlCommand oCom = new MySqlCommand("",oConn);
            oCom.CommandType = CommandType.StoredProcedure;
            oCom.CommandText = sQuery;
            oCom.Parameters.AddWithValue("tagih_", Tagih);
            oCom.Parameters.AddWithValue("credit_", Credit);
            MySqlDataAdapter adapt = new MySqlDataAdapter(oCom);
            DataTable tb = new DataTable();
            adapt.Fill(tb);

            oGrid.DataSource = null;
            oGrid.DataSource = tb;
        }

        private void frmReceivable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.pel' table. You can move, or remove it, as needed.
            this.pelTableAdapter.Fill(this.sinarekDataSet.pel);
            // TODO: This line of code loads data into the 'sinarekDataSet.logother' table. You can move, or remove it, as needed.
            this.logotherTableAdapter.Fill(this.sinarekDataSet.logother);
            // TODO: This line of code loads data into the 'sinarekDataSet.vlogpel' table. You can move, or remove it, as needed.
            //this.vlogpelTableAdapter.Fill(this.sinarekDataSet.vlogpel);
            RefreshDataReceivable(ref radGridView1, "pgetpenjualan",0,1);
            RefreshDataReceivable(ref radGridView3, "pgetpenjualan",1,1);
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            if (cell.CommandButton.TextElement.Text == "Tagih")
            {
                vlogpelTableAdapter.UpdatePiutang(1, NBConfig.ValidUserName
                    , int.Parse(cell.RowInfo.Cells["logpelid"].Value.ToString()));
                RefreshDataReceivable(ref radGridView1, "pgetpenjualan",0,1);
                RefreshDataReceivable(ref radGridView3, "pgetpenjualan",1,1);
            }
        }
    }
}
