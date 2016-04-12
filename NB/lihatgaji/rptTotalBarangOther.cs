namespace NB
{
    using System;
    using System.Data;
    using System.Text;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using Telerik.Reporting.Processing;
    using MySql.Data.MySqlClient;

    /// <summary>
    /// Summary description for rptTotalBarang.
    /// </summary>
    public partial class rptTotalBarangOther : Telerik.Reporting.Report
    {
        public rptTotalBarangOther()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public static string GetValue(string tipe, int baseid, DateTime tanggal)
        {
            string value = "0";
            DataTable dt = new DataTable("Result");
            StringBuilder sQuery = new StringBuilder();
            sQuery.Append("Select (case when adjustedval > 0 then adjustedval else value end) As Value From producttotal Where tipetransaksi = '" 
                                + tipe + "' and tanggal = '" + tanggal.ToString("yyyy-MM-dd") 
                                + "' and baseid = " + baseid.ToString());
            MySqlDataAdapter adapt = new MySqlDataAdapter(sQuery.ToString()
                                    , "server=196.10.0.75;User Id=reader;password=r3ader;database=sinarek");
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                {
                    value = dt.Rows[0][0].ToString();
                }
            }
            return value;
        }
        public static string GetRealValue(int baseid, DateTime tanggal)
        {
            string value = "0";
            DataTable dt = new DataTable("Result");
            StringBuilder sQuery = new StringBuilder();
            sQuery.Append("Select max(sisa) From producttotaluser Where baseid = " 
                            + baseid.ToString() + " and tanggal = '" 
                            + tanggal.ToString("yyyy-MM-dd") + "' group by baseid");
            MySqlDataAdapter adapt = new MySqlDataAdapter(sQuery.ToString()
                                    , "server=196.10.0.75;User Id=reader;password=r3ader;database=sinarek");
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                {
                    value = dt.Rows[0][0].ToString();
                }
            }
            return value;
        }
    }
}