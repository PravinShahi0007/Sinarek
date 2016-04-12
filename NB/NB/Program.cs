using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Telerik.WinControls.Themes;
using Telerik.WinControls;
using Telerik.WinControls.UI;
namespace NB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processItems = Process.GetProcessesByName(currentProcess.ProcessName);
            foreach (Process item in processItems) 
            { 
                if (item.Id != currentProcess.Id) 
                { 
                    helper.ErrorMessage("Program sudah terbuka!"); 
                    return; 
                } 
            }
            ThemeResolutionService.ApplicationThemeName = NBConfig.THEMENAME;
            if (NBConfig.BLoggedIn)
            {             
                frmMain frm = new frmMain();
                //frm.MaximizeBox = false;
                //frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();  
            }


            
        }
    }
}
