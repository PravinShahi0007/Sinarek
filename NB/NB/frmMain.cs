using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using System.Reflection;

namespace NB
{
    public partial class frmMain : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool edit_;
        private bool delete_;

        private int counter = 0;
        public frmMain()
        {
            InitializeComponent();
            //this.Owner.Hide();
            this.Text += " - " + NBConfig.ValidUserName;
            RadForm frm = this;
            frm.FormElement.TitleBar.TitlePrimitive.Font = new System.Drawing.Font("Segoe UI", 12);
            radLabelElement1.Text = DateTime.Now.ToString("dd MMM yyy   HH:mm:ss tt");
            //set up menu
            timer1.Start();
            cMenu.LoadAllowedMenu();
            mainradMenu.Items.AddRange(cMenu.MenuItems.Items);
            foreach (RadMenuItem item in mainradMenu.Items)
            {
                if (item.HasChildren)
                {
                    setEvent(item);
                }
                else
                {
                    item.Click += mainradMenu_Click;
                }
            }
            this.WindowState = FormWindowState.Maximized;
            
            //For 
        }

        private void mainradMenu_Click(object sender, EventArgs e)
        {
            string menuText = string.Empty;
            string MenuName = string.Empty;
            string Menu = string.Empty;
            if (sender is RadMenuItem)
            {
                RadMenuItem item = (RadMenuItem)sender;
                menuText = item.Text.Replace("&","");
                MenuName = (item.Tag != null?item.Tag.ToString():"");                
                RadForm frm = new RadForm();
                string tipe;
                switch (MenuName)
                {
                    case "":
                        NBConfig.bLoggedIn = false;
                        helper.SysLog(this.GetType().Name, NBConfig.ValidUserName, "Logout");
                        //this.Owner.Show();
                        this.Close();      
                        break;
                    case "frmInputLP":
                        //get tipe
                        menuText = menuText.Split('.')[1];
                        tipe = menuText.Replace("Input", "");
                        tipe = tipe.Trim();
                        frm = new frmInputLP(tipe);
                        break;                    
                    case "frmInputTMR":
                        menuText = menuText.Split('.')[1];
                        frm = new frmInputTMR(menuText,true);
                        break;
                    case "frmLihatTotal":
                        menuText = menuText.Split('.')[1];
                        frm = new frmLihatTotal(menuText.ToLower().Replace("stock ", ""));
                        break;
                    case "frmLihatSJ":
                        menuText = menuText.Split('.')[1];
                        tipe = menuText.Replace("Lihat SJ", "");
                        tipe = tipe.Trim();
                        frm = new frmLihatSJ(tipe);
                        break;
                    case "frmLihatTM":
                        menuText = menuText.Split('.')[1];
                        tipe = menuText.Replace("Lihat Transaksi", "");
                        tipe = tipe.Trim();
                        frm = new frmLihatTM(tipe);
                        break;
                    case "frmLihatNR":
                        menuText = menuText.Split('.')[1];
                        tipe = menuText.Replace("Check", "");
                        tipe = tipe.Trim();
                        frm = new frmLihatNR(tipe);
                        break;
                    case "frmInputIntern":
                        menuText = menuText.Split('.')[1];
                        frm = new frmInputIntern(menuText,true);
                        break;
                    default:
                       SetForm(MenuName, out frm);
                       break;
                }
                if (!string.IsNullOrEmpty(MenuName))
                {
                    Menu = item.Text.Split('.')[1];
                    frm.Tag = Menu;
                    frm.MaximizeBox = false;
                    frm.MinimizeBox = false;
                    frm.FormElement.TitleBar.TitlePrimitive.Font = new System.Drawing.Font("Lucida Bright", 12, FontStyle.Bold);
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog(this);
                }
            }
        }

        private void setEvent(RadMenuItem item)
        {
            foreach (RadMenuItem i in item.Items)
            {                
                i.Click += mainradMenu_Click;
            
                if (i.HasChildren)
                {
                    setEvent(i);
                }
            }
        }
        
        private void SetForm(string MenuName, out RadForm frm)
        {
            Assembly a = Assembly.GetExecutingAssembly();
            System.Type t = a.GetType("NB." + MenuName);

            Object o = Activator.CreateInstance(t);
            frm = (RadForm)o;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {  
            radLabelElement1.Text = DateTime.Now.ToString("dd MMM yyy   HH:mm:ss tt");
            counter += timer1.Interval;
            if (counter == 60000)
            {
                this.actionlogTableAdapter.FillByStatus(this.sinarekDataSet.actionlog, 1);
                counter = 0;
            }
            //Also refresh messagebox

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.actionlogTableAdapter.FillByStatus(this.sinarekDataSet.actionlog,1);
            delete_ = NBConfig.CheckPermission("Main Form", this.GetType().Name, "delete");
            radGridView1.Columns["cmdFixed"].IsVisible = delete_;
        }
        private void InitializeButton()
        {

        }
        private void txtKeterangan_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtKeterangan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //create record
                if (!string.IsNullOrEmpty(txtKeterangan.Text))
                {
                    actionlogTableAdapter.Insert(DateTime.Now, 1, NBConfig.ValidUserName, txtKeterangan.Text, NBConfig.ValidUserName);
                    txtKeterangan.ResetText();
                    this.actionlogTableAdapter.FillByStatus(this.sinarekDataSet.actionlog, 1);
                }
            }
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            GridCommandCellElement cell = (GridCommandCellElement)sender;
            switch (cell.CommandButton.Text.ToLower())
            {
                case "fixed":
                    if (delete_)
                    {
                        actionlogTableAdapter.UpdateAction(2, NBConfig.ValidUserName
                            , int.Parse(cell.RowInfo.Cells["actionid"].Value.ToString()));
                        this.actionlogTableAdapter.FillByStatus(this.sinarekDataSet.actionlog, 1);
                    }
                    break;
                case "batal":
                    if (NBConfig.ValidUserName == cell.RowInfo.Cells["createdby"].Value.ToString())
                    {
                        this.actionlogTableAdapter.DeleteAction(int.Parse(cell.RowInfo.Cells["actionid"].Value.ToString()));
                        this.actionlogTableAdapter.FillByStatus(this.sinarekDataSet.actionlog, 1);
                    }
                    break;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (NBConfig.ValidUserID != -1 && (!string.IsNullOrEmpty(txtPwd.Text)))
            {
                DialogResult res = RadMessageBox.Show("Yakin akan  mengubah password anda?", "SMS - Verification", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    using (fingermachDataSetTableAdapters.staffTableAdapter tbl = new fingermachDataSetTableAdapters.staffTableAdapter())
                    {
                        tbl.UpdatePassword(txtPwd.Text, NBConfig.ValidUserID);
                    }
                    helper.NotifMessage("Password has been changed successfully");
                    txtPwd.ResetText();
                }
                else
                {
                    //do nothing
                }
            }
        }


    }
}
