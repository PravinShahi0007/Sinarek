using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

using NB;
using Telerik.Data;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI.Export;
using Telerik.Reporting;
using Telerik.Reporting.Processing;

namespace NB
{
    internal static class helper
    {
        const string PROGNAME = "SMS";
        internal static ExportToExcelML excelExporter;   
        //Unified Error Messaging System
        internal static void ErrorMessage(string Message)
        {
            RadMessageBox.Show(Message, PROGNAME + " - Notification", MessageBoxButtons.OK, RadMessageIcon.Error);  
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Message"></param>
        internal static void NotifMessage(string Message)
        {
            RadMessageBox.Show(Message, PROGNAME + " - Notification", MessageBoxButtons.OK, RadMessageIcon.Info); 
        }
        /// <summary>
        /// Log every printing for every users
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="ReportName"></param>
        internal static void PrintLog(string TableName, string ReportName,string Details)
        {
            using(sinarekDataSetTableAdapters.printlogTableAdapter tbl = new sinarekDataSetTableAdapters.printlogTableAdapter())
            {
                tbl.InsertPrintLog(TableName,ReportName,Details,NBConfig.ValidUserName);
            }
        }

        /// <summary>
        /// Log every errors and logins
        /// </summary>
        /// <param name="formName"></param>
        /// <param name="formText"></param>
        /// <param name="Message"></param>
        internal static void SysLog(string formName, string formText, string Message)
        {
            using (sinarekDataSetTableAdapters.syslogTableAdapter tbl = new sinarekDataSetTableAdapters.syslogTableAdapter())
            {
                tbl.InsertSysLog(formName, formText, Message, NBConfig.ValidUserName + "-" + Environment.MachineName + "-" + Environment.UserName);
            }
        }
        /// <summary>
        /// Update System Theme According to Selection
        /// </summary>
        /// <param name="c"></param>
        /// <param name="themeName"></param>
        internal static void UpdateControlTheme(Control c, string themeName)
        {
            if (c is RadMaskedEditBox)
            {
                RadMaskedEditBox rm = (RadMaskedEditBox)c;
                rm.ThemeName = themeName;
            }
            if (c is RadTextBox)
            {
                RadTextBox txt = (RadTextBox)c;
                txt.ThemeName = themeName;
            }
            if (c is RadDropDownList)
            {
                RadDropDownList ddl = (RadDropDownList)c;
                ddl.ThemeName = themeName;
            }
            if (c is RadGridView)
            {
                RadGridView ddl = (RadGridView)c;
                ddl.ThemeName = themeName;
            }
            if (c is RadGroupBox)
            {
                RadGroupBox rg = (RadGroupBox)c;
                rg.ThemeName = themeName;
            }
            if (c is RadButton)
            {
                RadButton btn = (RadButton)c;
                btn.ThemeName = themeName;
            }
            if (c is RadDateTimePicker)
            {
                RadDateTimePicker dtp = (RadDateTimePicker)c;
                dtp.ThemeName = themeName;
            }
            if (c is RadPageView)
            {
                RadPageView pv = new RadPageView();
                pv.ThemeName = themeName;
            }
            //Also update theme for children
            foreach (Control ch in c.Controls)
            {
                UpdateControlTheme(ch, themeName);
            }
            

        }

        /// <summary>
        /// Get user permission for a menu / form
        /// </summary>
        /// <param name="frmName"></param>
        /// <param name="MenuName"></param>
        /// <param name="add"></param>
        /// <param name="edit"></param>
        /// <param name="delete"></param>
        internal static void GetPermissions(string frmName, string MenuName, out bool add, out bool edit, out bool delete)
        {
            add = NBConfig.CheckPermission(MenuName, frmName, "add");
            edit = NBConfig.CheckPermission(MenuName, frmName, "edit");
            delete = NBConfig.CheckPermission(MenuName, frmName, "delete");
        }

        /// <summary>
        /// Save Report to a file to a specified location
        /// </summary>
        /// <param name="rptDoc"></param>
        /// <param name="Location"></param>
        internal static void SavedToPDF(IReportDocument rptDoc, string Location)
        {
            Telerik.Reporting.Processing.ReportProcessor reportProcessor = new Telerik.Reporting.Processing.ReportProcessor();

            //set any deviceInfo settings if necessary
            System.Collections.Hashtable deviceInfo = new System.Collections.Hashtable();

            InstanceReportSource reportSource = new InstanceReportSource();
            reportSource.ReportDocument = rptDoc;

            Telerik.Reporting.Processing.RenderingResult result = reportProcessor.RenderReport("PDF", reportSource, deviceInfo);
            string fileName = result.DocumentName + "." + result.Extension;
            string filePath = System.IO.Path.Combine(Location, fileName);

            using (System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            }
        }

        /// <summary>
        /// Save Report to a file to a specified location
        /// </summary>
        /// <param name="rptDoc"></param>
        /// <param name="Location"></param>
        internal static void SavedToEXCEL(IReportDocument rptDoc, string Location)
        {
            ReportProcessor reportProcessor = new ReportProcessor();
            InstanceReportSource reportSource = new InstanceReportSource();
            reportSource.ReportDocument = rptDoc;
            string rptName = string.Empty;
            Hashtable htbl = new Hashtable();

            //set any deviceInfo settings if necessary
            System.Collections.Hashtable deviceInfo = new System.Collections.Hashtable();
            Telerik.Reporting.Processing.RenderingResult result = reportProcessor.RenderReport("XLS", reportSource, deviceInfo);
            string fileName = result.DocumentName + "." + result.Extension;
            string filePath = System.IO.Path.Combine(Location, fileName);

            using (System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            }
        }

        internal static void RunExportToExcelML(string fileName, ref bool openExportFile, ref RadGridView gridView)         
        {
            excelExporter = new ExportToExcelML(gridView);              
            //if (this.radTextBoxSheet.Text != String.Empty)             
            //{                 
            //    excelExporter.SheetName = this.radTextBoxSheet.Text;              
            //}              
            
            //switch (this.radComboBoxSummaries.SelectedIndex)             
            //{                 
            //    case 0:                     
            //        excelExporter.SummariesExportOption = SummariesOption.ExportAll;                     
            //        break;                 
            //    case 1:                     
            //        excelExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;                     
            //        break;                 
            //    case 2:                     
            //        excelExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;                     
            //        break;                 
            //    case 3:                     
            //        excelExporter.SummariesExportOption = SummariesOption.DoNotExport;                    
            //        break;             
            //}              
            //set max sheet rows             
            //if (this.radRadioButton1.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)             
            //{                 
            //    excelExporter.SheetMaxRows = ExcelMaxRows._1048576;             
            //}             
            //else if (this.radRadioButton2.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)             
            //{                 
            //    excelExporter.SheetMaxRows = ExcelMaxRows._65536;             
            //}              
            //set exporting visual settings             
            //excelExporter.ExportVisualSettings = this.exportVisualSettings;              
            try             
            {
                excelExporter.RunExport(fileName);                  
                RadMessageBox.SetThemeName(gridView.ThemeName);                 
                DialogResult dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to Excel", MessageBoxButtons.YesNo, RadMessageIcon.Question);                
                if (dr == DialogResult.Yes)                 
                {                     
                    openExportFile = true;                 
                }             
            }             
            catch (IOException ex)             
            {                 
                RadMessageBox.SetThemeName(gridView.ThemeName);                 
                RadMessageBox.Show(ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);             
            }         
        }
        internal static void RunExportToPDF(string fileName, ref bool openExportFile, ref RadGridView gridView)
        {

        }
    }
}
