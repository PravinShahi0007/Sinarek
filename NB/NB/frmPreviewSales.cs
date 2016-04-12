using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace NB
{
    public partial class frmPreviewSales : Telerik.WinControls.UI.RadForm
    {
        public frmPreviewSales(string SalesShort,DateTime Tanggal)
        {
            InitializeComponent();
            rptLaporanPenjSales1.ReportParameters["user"].Value = NBConfig.ValidUserName;
            rptLaporanPenjSales1.ReportParameters["salesname"].Value = SalesShort;
            rptLaporanPenjSales1.ReportParameters["tanggal"].Value = Tanggal;
        }

        private void frmPreviewSales_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }
    }
}
