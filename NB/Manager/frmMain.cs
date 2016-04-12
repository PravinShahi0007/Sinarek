using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;


namespace Manager
{
    public partial class frmMain : RadForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sfrmManageMenu frm = new sfrmManageMenu();
            frm.ShowDialog(this);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            sfrmManageUser frm = new sfrmManageUser();
            frm.ShowDialog(this);
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            sfrmManageNewUser frm = new sfrmManageNewUser();
            frm.ShowDialog(this);
        }
    }
}
