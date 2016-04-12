using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using lihatinventory;
using Telerik.Reporting;
using Telerik.Reporting.Processing;
using System.Drawing.Printing;



namespace NB
{
    public partial class frmSJExport : Telerik.WinControls.UI.RadForm
    {
        public frmSJExport()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Telerik.Reporting.Processing.ReportProcessor reportProcessor = new Telerik.Reporting.Processing.ReportProcessor();

            //set any deviceInfo settings if necessary
            System.Collections.Hashtable deviceInfo = new System.Collections.Hashtable();

            //Print Slip Gaji                
            rptBarangKeluarTabel rpt1 = new rptBarangKeluarTabel();
            rpt1.ReportParameters[0].Value = DateTime.Now;
            //gj.ReportParameters["User"].Value = NBConfig.ValidUserName;
            IReportDocument report1 = (IReportDocument)rpt1;

            Telerik.Reporting.Processing.RenderingResult result = reportProcessor.RenderReport("XLS", report1, deviceInfo);
            string fileName = "SURATJALAN_" + DateTime.Now.ToString("ddMMMyy") + "." + result.Extension;

            const string path = @"\\sinarekserver\forms\";
            string filePath = System.IO.Path.Combine(path, fileName);

            using (System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            //edit sj
        }
    }
}
