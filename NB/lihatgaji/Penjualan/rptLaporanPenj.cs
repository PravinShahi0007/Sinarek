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
    using System.Configuration;
    /// <summary>
    /// Summary description for rptLaporanPenj.
    /// </summary>
    public partial class rptLaporanPenj : Telerik.Reporting.Report
    {
        private string value_ = "0";
        private string value2_ = "0";
        private string value3_ = "0";
        public rptLaporanPenj()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public static string GetDaerah(int lappenid)
        {
            string daerah = string.Empty;
            DataTable dt = new DataTable("Test");
            //StringBuilder sQuery = new StringBuilder();
            //sQuery.Append("call pgetdatapenjualandaerah(" + lappenid.ToString() + ")" );
            MySqlDataAdapter adapt = new MySqlDataAdapter(""
                                                , ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);
            adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapt.SelectCommand.CommandText = "pgetdatapenjualandaerah";
            adapt.SelectCommand.Parameters.AddWithValue("lappenid_", lappenid);            
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                {
                    daerah = dt.Rows[0][0].ToString();
                }
            }
            return daerah;
        }
        public static string GetBotolPrices(int lappenid)
        {
            StringBuilder daerah = new StringBuilder();
            DataTable dt = new DataTable("Test");
            MySqlDataAdapter adapt = new MySqlDataAdapter(""
                                                            , ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);
            adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapt.SelectCommand.CommandText = "pgetdatapenjualanpackage";
            adapt.SelectCommand.Parameters.AddWithValue("lappenid_", lappenid);
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (!string.IsNullOrEmpty(row[0].ToString()))
                    {
                        daerah.AppendFormat("({2}) {0} {1:Rp #,##0.00} {3} <br />", row[0], row[1], row[2], row[3]);
                    }
                }
            }
            return daerah.ToString();
        }
        private void subReport2_ItemDataBound(object sender, EventArgs e)
        {
            try
            {
                Telerik.Reporting.Processing.SubReport sub = (Telerik.Reporting.Processing.SubReport)sender;
                Telerik.Reporting.Processing.TextBox txt = (Telerik.Reporting.Processing.TextBox)sub.ChildElements.Find("textBox8", true)[0];
                Telerik.Reporting.Processing.Report rep = sub.Report;
                Telerik.Reporting.Processing.TextBox txt2 = (Telerik.Reporting.Processing.TextBox)rep.ChildElements.Find("textBox1", true)[0];
                value_ = "0";
                value_ = txt.Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void subReport1_ItemDataBound(object sender, EventArgs e)
        {
            try
            {
                Telerik.Reporting.Processing.SubReport sub = (Telerik.Reporting.Processing.SubReport)sender;
                Telerik.Reporting.Processing.TextBox txt = (Telerik.Reporting.Processing.TextBox)sub.ChildElements.Find("textBox23", true)[0];
                Telerik.Reporting.Processing.Report rep = sub.Report;
                Telerik.Reporting.Processing.TextBox txt2 = (Telerik.Reporting.Processing.TextBox)rep.ChildElements.Find("textBox1", true)[0];

                value2_ = txt.Value.ToString();
                
            }
            catch (Exception ex)
            {

            }
        }

        private void rptLaporanPenj_ItemDataBound(object sender, EventArgs e)
        {
            if (value_ == "0")
            {
                subReport2.Visible = false;
            }
            if (value2_ == "0")
            {
                subReport1.Visible = false;
            }
            textBox1.Value = "="+ (decimal.Parse(value3_)  - decimal.Parse(value_)).ToString();
            textBox27.Value = "=" + decimal.Parse(value2_).ToString();
            textBox30.Value = "=" + (decimal.Parse(value3_) - decimal.Parse(value_) + decimal.Parse(value2_)).ToString();
        }

        private void subReport4_ItemDataBound(object sender, EventArgs e)
        {
            try
            {
                Telerik.Reporting.Processing.SubReport sub = (Telerik.Reporting.Processing.SubReport)sender;
                Telerik.Reporting.Processing.TextBox txt = (Telerik.Reporting.Processing.TextBox)sub.ChildElements.Find("textBox23", true)[0];
                Telerik.Reporting.Processing.Report rep = sub.Report;
                Telerik.Reporting.Processing.TextBox txt2 = (Telerik.Reporting.Processing.TextBox)rep.ChildElements.Find("textBox1", true)[0];

                value3_ = txt.Value.ToString();

            }
            catch (Exception ex)
            {

            }
        }


        
    }
}