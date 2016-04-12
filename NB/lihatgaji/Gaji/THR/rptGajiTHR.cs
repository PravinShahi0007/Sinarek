namespace NB
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for rptGaji.
    /// </summary>
    public partial class rptGajiTHR : Telerik.Reporting.Report
    {
        public rptGajiTHR()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public static double GetBulat(double value)
        {
            double ori = value;
            double res = value % 500;
            double val = 0;
            double calc = value - res;
            if (res > 0)
            {
                res = 500;
            }
            val = (calc) + res;
            return val;
        }
    }
}