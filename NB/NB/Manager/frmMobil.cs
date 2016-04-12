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
    public partial class frmMobil : Telerik.WinControls.UI.RadForm
    {
        public frmMobil()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.mobil' table. You can move, or remove it, as needed.
            this.mobilTableAdapter.Fill(this.sinarekDataSet.mobil);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                mobilTableAdapter.InsertMobil(txtName.Text, txtTipe.Text);
                this.mobilTableAdapter.Fill(this.sinarekDataSet.mobil);

                txtName.ResetText();
                txtTipe.ResetText();
            }
            catch (Exception ex)
            {
                helper.ErrorMessage("Ada Masalah Menyimpan Mobil Baru");
            }
        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Column.Name.ToLower() == "active")
            {
                mobilTableAdapter.UpdateStatusMobil(e.Row.Cells["active"].Value
                    , int.Parse(e.Row.Cells["mobilid"].Value.ToString()));
            }
        }

    }
}
