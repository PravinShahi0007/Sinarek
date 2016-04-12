using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace NB
{
    public class cMenu
    {
        public static RadItemsContainer MenuItems = new RadItemsContainer();
               
        private static void AddMenu(RadMenuItem tmp)
        {
            MenuItems.Items.Add(tmp);
        }
        private static void AddMenu(RadMenuItem parent, string text, string appName)
        {
            RadMenuItem tmp = new RadMenuItem() { Text = text, Tag = appName };
            tmp.Font = new Font("Segoe UI", 10);
            parent.Items.Add(tmp);
        }

        private static void AddMenu(RadMenuItem parent, string key, string text,string appName)
        {
            RadMenuItem tmp = new RadMenuItem() { Text = text, Name = key, Tag = appName };
            tmp.Font = new Font("Segoe UI", 10);
            parent.Items.Add(tmp);
        }

        public static void LoadAllowedMenu()
        {
            if (NBConfig.dtPerm != null)
            {
                NBConfig.dtPerm = null;
                MenuItems.Items.Clear();
            }
            fingermachDataSet.pMenuDataTable dtTbl = new fingermachDataSet.pMenuDataTable();            
            using (fingermachDataSetTableAdapters.pMenuTableAdapter tbl = new fingermachDataSetTableAdapters.pMenuTableAdapter())
            {  
                if (NBConfig.ValidUserID < 0)
                {
                    tbl.FillAll(dtTbl, NBConfig.ValidUserID.ToString());
                }
                else
                {
                    tbl.FillByUserID(dtTbl, NBConfig.ValidUserID);
                }   
            }

            NBConfig.dtPerm = dtTbl;
            
            DataRow[] ParentRows = dtTbl.Select("parentid = 0 and view = 1");
            int i, o;
            i = 1;            
            foreach (DataRow row in ParentRows)
            {
                int ordNum = int.Parse(row["ordernum"].ToString()) + 1;                
                RadMenuItem parentMenu = new RadMenuItem(row["name"].ToString());
                //RadMenuItem parentMenu = new RadMenuItem("&" + i.ToString() + "." + row["name"].ToString().Replace("&", ""));
                DataRow[] childRows = dtTbl.Select("parentid =" + row["authid"].ToString());
                o = 1;
                foreach (DataRow childRow in childRows)
                {
                    if (childRow["view"].ToString() == "1")
                    {
                        int orderNum = int.Parse(childRow["ordernum"].ToString()) + 1;
                        //AddMenu(parentMenu, childRow["name"].ToString(), childRow["form"].ToString());
                        AddMenu(parentMenu,"&" + o.ToString() + "." + childRow["name"].ToString().Replace("&", ""), childRow["form"].ToString());
                        o++;
                    }
                }
                AddMenu(parentMenu);
                i++;
            }

            //Always Add Logout menu
            RadMenuItem logout = new RadMenuItem("Log &Out") { Name = "O" };
            AddMenu(logout);
            
        }        
    }
}
