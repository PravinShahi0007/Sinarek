using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

using Cashier;
using Telerik.Data;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI.Export;

namespace Cashier
{
    internal static class helper
    {
        const string PROGNAME = "SMS - Cashier";
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

    }
}
