namespace NB
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    using System.Text;
    using System.Data;
    using MySql.Data;
    using MySql.Data.MySqlClient;
    using System.Configuration;
    using Telerik.Reporting.Processing;
    /// <summary>
    /// Summary description for rptSuratJalan.
    /// </summary>
    public partial class rptSJ : Telerik.Reporting.Report
    {
        public rptSJ()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public static string GetParentSJ(long LogID)
        {
            string text = string.Empty;
            DataTable dt = new DataTable("Test");
            StringBuilder sQuery = new StringBuilder();
            sQuery.AppendLine("Select v.NoSJ From logproduct l left join logproduct v on l.parentlogid = v.logid Where l.logid = " + LogID.ToString());
            MySqlDataAdapter adapt = new MySqlDataAdapter(sQuery.ToString()
                                    , ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);
            adapt.Fill(dt);
            if (!string.IsNullOrEmpty(dt.Rows[0][0].ToString()))
            {
                text = "( " + dt.Rows[0][0].ToString() + " )";
            }

            return text;
            
        }
    }
}