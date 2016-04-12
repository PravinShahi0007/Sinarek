namespace NB
{
    using System;
    using System.Configuration;
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
    public partial class rptTotalBarangNEW : Telerik.Reporting.Report
    {
        public rptTotalBarangNEW()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public static string GetRealValue(int baseid, string tanggal)
        {
            string value = "";
            DataTable dt = new DataTable("Result");
            StringBuilder sQuery = new StringBuilder();
            sQuery.Append("Select max(sisa) From producttotaluser Where baseid = "
                            + baseid.ToString() + " and tanggal = '"
                            + tanggal + "' group by baseid");
            MySqlDataAdapter adapt = new MySqlDataAdapter(sQuery.ToString()
                                    , ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);
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