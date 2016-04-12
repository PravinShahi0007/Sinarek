using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace NB
{
    public partial class frmAccount : Telerik.WinControls.UI.RadForm
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            this.tipeaccountTableAdapter.Fill(this.sinarekDataSet.tipeaccount);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                tipeaccountTableAdapter.InsertAccount(txtName.Text, NBConfig.ValidUserName);
                this.tipeaccountTableAdapter.Fill(this.sinarekDataSet.tipeaccount);

                txtName.ResetText();
            }
            catch (Exception ex)
            {
                helper.ErrorMessage("Ada Masalah Menyimpan Account Baru");
            }
        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            tipeaccountTableAdapter.UpdateAccount(null, null
                , e.Row.Cells["Nama"].Value.ToString()
                , e.Row.Cells["SystemOnly"].Value
                , e.Row.Cells["Payment"].Value
                , NBConfig.ValidUserName
                , int.Parse(e.Row.Cells["accountid"].Value.ToString()));
            this.tipeaccountTableAdapter.Fill(this.sinarekDataSet.tipeaccount);
        }
    }
}
