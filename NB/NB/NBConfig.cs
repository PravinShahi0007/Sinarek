using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Data;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Telerik.WinControls;
namespace NB
{
    static class NBConfig
    {
        public static string THEMENAME = "VisualStudio2012Light";
        internal static string ValidUserName
        {
            get
            {
                return NBConfig.validUserName;
            }
            set
            {
                NBConfig.validUserName = value;
            }
        }
        private static int validUserID;
        internal static int ValidUserID
        {
            get
            {
                return NBConfig.validUserID;
            }
            set
            {
                NBConfig.validUserID = value;
            }
        }
        private static string validUserName;
        internal static DateTime LoginTime
        {
            get
            {
                return NBConfig.loginTime;
            }
            set
            {
                NBConfig.loginTime = value;
            }
        }
        private static DateTime loginTime;
        internal static long AllowedLoginTime { get; set; }
        internal static bool BLoggedIn
        {
            get
            {
                if (!bLoggedIn)
                {
                    //always show frmlogin to login
                    //ThemeResolutionService.ApplicationThemeName = THEMENAME;
                    frmLogin frm = new frmLogin();
                    frm.ShowDialog();
                }
                //Authenticate
                return NBConfig.bLoggedIn;
            }
            set
            {
                NBConfig.bLoggedIn = value;
            }
        }
        internal static bool bLoggedIn;
        internal static int IGMID
        {
            get
            {
                return NBConfig.iGMID;
            }
            //set
            //{
            //    NBConfig.iGMID = value;
            //}
        }
        private static int iGMID;
        internal static void RetrieveGMID()
        {
            using (sinarekDataSetTableAdapters.gajimingguanTableAdapter gajiMingguanTableAdapter = new sinarekDataSetTableAdapters.gajimingguanTableAdapter())
            {
                iGMID = int.Parse(gajiMingguanTableAdapter.pGetGMID().ToString());
            }
        }
        internal static int IGBID
        {
            get
            {
                return NBConfig.iGBID;
            }
            //set
            //{
            //    NBConfig.iGMID = value;
            //}
        }
        private static int iGBID;
        internal static void RetrieveGBID()
        {
            using (sinarekDataSetTableAdapters.gajibulananTableAdapter gajiBulananTableAdapter = new sinarekDataSetTableAdapters.gajibulananTableAdapter())
            {
                iGBID = int.Parse(gajiBulananTableAdapter.pGETGBID().ToString());
            }
        }
        internal static bool GetGMIDPrinted()
        {
            bool bPrinted = true;
            using (sinarekDataSetTableAdapters.gajimingguanTableAdapter gajiMingguanTableAdapter = new sinarekDataSetTableAdapters.gajimingguanTableAdapter())
            {
                 bPrinted = (gajiMingguanTableAdapter.pGetPrinted(iGMID).ToString().ToLower() == "true" ? true : false);
            }
            return bPrinted;
        }
        internal static bool GetGBIDPrintedStaff()
        {
            bool bPrinted = true;
            using (sinarekDataSetTableAdapters.gajibulananTableAdapter gajiMingguanTableAdapter = new sinarekDataSetTableAdapters.gajibulananTableAdapter())
            {
                bPrinted = (gajiMingguanTableAdapter.PrintedStaff(iGBID).ToString().ToLower() == "true" ? true : false);
            }
            return bPrinted;
        }
        internal static bool GetGBIDPrintedSales()
        {
            bool bPrinted = true;
            using (sinarekDataSetTableAdapters.gajibulananTableAdapter gajiMingguanTableAdapter = new sinarekDataSetTableAdapters.gajibulananTableAdapter())
            {
                bPrinted = (gajiMingguanTableAdapter.PrintedSales(iGBID).ToString().ToLower() == "true" ? true : false);
            }
            return bPrinted;
        }
        internal static bool GetGBIDPrintedOther()
        {
            bool bPrinted = true;
            using (sinarekDataSetTableAdapters.gajibulananTableAdapter gajiMingguanTableAdapter = new sinarekDataSetTableAdapters.gajibulananTableAdapter())
            {
                bPrinted = (gajiMingguanTableAdapter.PrintedOther(iGBID).ToString().ToLower() == "true" ? true : false);
            }
            return bPrinted;
        }
        internal static bool GetGBIDPrintedComission()
        {
            bool bPrinted = true;
            using (sinarekDataSetTableAdapters.gajibulananTableAdapter gajiMingguanTableAdapter = new sinarekDataSetTableAdapters.gajibulananTableAdapter())
            {
                bPrinted = (gajiMingguanTableAdapter.PrintedComission(iGBID).ToString().ToLower() == "true" ? true : false);
            }
            return bPrinted;
        }
        internal static DataTable dtPerm;
        internal static bool CheckPermission(string frmText,string frmName, string PermType)
        {
            bool bAllow = false;
            int iAllow;
            DataRow[] ParentRows = dtPerm.Select("form ='" + frmName + "'" );
            foreach (DataRow row in ParentRows)
            {
                if (row["name"].ToString().Replace("&", "").ToLower() == frmText.ToLower())
                {
                    iAllow = int.Parse(row[PermType].ToString());
                    bAllow = (iAllow == 1 ? true : false);
                    return bAllow;
                }
            }
            return bAllow;
        }
        
    }
}
