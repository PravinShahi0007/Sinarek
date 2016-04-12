using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.Reporting;
using Telerik.Reporting.Processing;
using System.Drawing.Printing;

using System.IO;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

using NB;

namespace lihatgaji
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Console.WriteLine(NB.rptSJ.GetParentSJ(3));
            //Console.Read();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Form1());

            ////On Printing Surat Jalan Make sure after printing surat jalan has been updated to 
            ////printed so the next time surat jalan is printing COPY is appended to the title.
            //IReportDocument report1 = new rptGaji();
            ////set parameters when necessary


            //// PrinterSettings 
            PrinterSettings printerSettings = new PrinterSettings();
            //// Adjust the printer settings if necessary...

            //// Print the report using the printer settings.

            ////FileStream fs = new FileStream("c:\\report1.pdf", FileMode.Create);
            ////fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            ////fs.Flush();
            ////fs.Close();
            //rptGajiMingguan rpt = new rptGajiMingguan();
            //rpt.ReportParameters["gmid"].Value = 37;
            //rpt.ReportParameters["user"].Value = "test";
            //IReportDocument report1 = rpt.Report;
            //ReportProcessor reportProcessor = new ReportProcessor();
            //reportProcessor.PrintReport(report1, printerSettings);

        }
    }
}
