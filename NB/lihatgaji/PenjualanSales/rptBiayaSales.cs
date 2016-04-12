namespace NB
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for rptPenjualan.
    /// </summary>
    public partial class rptBiayaSales : Telerik.Reporting.Report
    {
        public rptBiayaSales()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        private decimal biaya_;
        public decimal TotalBiaya
        {
            get { return biaya_; }
            set { biaya_ = value;}
        }
        private void GetTotalBiaya()
        {
            decimal.TryParse(this.textBox8.Value,out biaya_);
        }

        private void rptBiaya_ItemDataBound(object sender, EventArgs e)
        {
            GetTotalBiaya();
        }
    }
}