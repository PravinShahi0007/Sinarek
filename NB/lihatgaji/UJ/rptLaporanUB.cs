namespace NB
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for frmLaporanUJ.
    /// </summary>
    public partial class rptLaporanUB : Telerik.Reporting.Report
    {
        public rptLaporanUB()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void frmLaporanUJ_ItemDataBound(object sender, EventArgs e)
        {
            decimal value3;
            Telerik.Reporting.Processing.Report rpt = (Telerik.Reporting.Processing.Report)sender;
            Telerik.Reporting.Processing.TextBox txt = (Telerik.Reporting.Processing.TextBox)rpt.ChildElements.Find("textBox33", true)[0];
            Telerik.Reporting.Processing.TextBox txt2 = (Telerik.Reporting.Processing.TextBox)rpt.ChildElements.Find("textBox20", true)[0];
            if (txt2.Value != null)
            {
                value3 = decimal.Parse(txt.Value.ToString()) - decimal.Parse(txt2.Value.ToString());
            }
            else
            {
                value3 = decimal.Parse(txt.Value.ToString());
            }
            if (value3 > 0)
            {
                textBox31.Value = "LEBIH";
            }
            else
            {
                textBox31.Value = "KURANG";
            }
            textBox32.Value = value3.ToString("Rp #,###.00");

        }
    }
}