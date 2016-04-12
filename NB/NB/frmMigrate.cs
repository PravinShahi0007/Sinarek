using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Configuration;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace NB
{
    public partial class frmMigrate : Telerik.WinControls.UI.RadForm
    {
        public frmMigrate()
        {
            InitializeComponent();
        }
        private void moveSJ(string sTableName)
        {
            string sj, prevsj;
            int sjid;

            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SinarConnString"].ToString());
            MySqlDataAdapter adapt = new MySqlDataAdapter("Select * From " + sTableName, conn);
            DataTable dt = new DataTable(sTableName);
            adapt.Fill(dt);
            prevsj = string.Empty;
            sjid = -1;


            foreach (DataRow row in dt.Rows)
            {
                if (!string.IsNullOrEmpty(row["baseid"].ToString()))
                {
                    sj = row["Nota"].ToString();
                    if (prevsj != sj)
                    {
                        using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
                        {
                            try
                            {
                                sjid = int.Parse(tbl.pInsertLogProd(DateTime.Parse(row["tgl"].ToString())
                                                        ,-1
                                                        , -2
                                                        , -2
                                                        , -2
                                                        , int.Parse(row["KOTAID"].ToString())
                                                        , int.Parse(row["salesid"].ToString())
                                                        , row["KERNET"].ToString()
                                                        , row["SOPIR"].ToString()
                                                        , row["NOTA"].ToString()
                                                        , int.Parse(row["salesid"].ToString())
                                                        , 2
                                                        , row["KA"].ToString()
                                                        , 4, 0, 0).ToString());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }

                    if (sjid != -1)
                    {
                        using (sinarekDataSetTableAdapters.logdetailTableAdapter tbl = new sinarekDataSetTableAdapters.logdetailTableAdapter())
                        {
                            try
                            {
                                tbl.pInsertLogDetail(sjid
                                    , int.Parse(row["baseid"].ToString())
                                    , decimal.Parse(row["keluar"].ToString())
                                    ,-1
                                    , -1
                                    ,1
                                    , row["KA"].ToString());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }

                    prevsj = sj;
                }
            }

        }
        private void moveSJPel(string sTableName)
        {
            string sj, prevsj;
            int sjid;

            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["SinarConnString"].ToString());
            MySqlDataAdapter adapt = new MySqlDataAdapter("Select * From " + sTableName, conn);
            DataTable dt = new DataTable(sTableName);
            adapt.Fill(dt);
            prevsj = string.Empty;
            sjid = -1;


            foreach (DataRow row in dt.Rows)
            {
                if (!string.IsNullOrEmpty(row["baseid"].ToString()))
                {
                    sj = row["Nota"].ToString();
                    if (prevsj != sj)
                    {
                        using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
                        {
                            try
                            {
                                sjid = int.Parse(tbl.pInsertLogProd(DateTime.Parse(row["tgl"].ToString())
                                                        , 0
                                                        , -2
                                                        , -2
                                                        , -2
                                                        , int.Parse(row["KOTAID"].ToString())
                                                        , int.Parse(row["SalesID"].ToString())
                                                        , row["KERNET"].ToString()
                                                        , row["SOPIR"].ToString()
                                                        , row["NOTA"].ToString()
                                                        , int.Parse(row["pelid"].ToString())
                                                        , 1
                                                        , row["KA"].ToString()
                                                        , 4, 0, 0).ToString());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }

                    if (sjid != -1)
                    {
                        using (sinarekDataSetTableAdapters.logdetailTableAdapter tbl = new sinarekDataSetTableAdapters.logdetailTableAdapter())
                        {
                            try
                            {
                                tbl.pInsertLogDetail(sjid
                                    , int.Parse(row["baseid"].ToString())
                                    , decimal.Parse(row["keluar"].ToString())
                                    ,-1
                                    ,1
                                    ,1
                                    , row["KA"].ToString());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }

                    prevsj = sj;
                }
            }

        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            moveSJPel("vPelSJ");
        }
    }
}
