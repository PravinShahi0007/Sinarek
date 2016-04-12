using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Telerik.WinControls.Themes;
using Telerik.WinControls;
using Telerik.WinControls.UI;
namespace Manager
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
            //ThemeResolutionService.ApplicationThemeName = "TelerikMetro";
            using (frmLogin frm = new frmLogin())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmMainAdmin());
                    //Application.Run(new sfrmManageMenu());
                }
                else
                {
                    Application.Exit();
                }
            }

            
        }
    }
}
