using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NB
{
    public partial class frmAddPayment : Telerik.WinControls.UI.RadForm
    {
        private bool bMasuk_ = false;
        public frmAddPayment():this(DateTime.Now,false)
        {
            
        }

        public frmAddPayment(DateTime tanggal, bool bMasuk)
        {
            InitializeComponent();
            dtpTanggal.Value = tanggal;
            bMasuk_ = bMasuk;
        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.tipeaccount' table. You can move, or remove it, as needed.
            this.tipeaccountTableAdapter.Fill(this.sinarekDataSet.tipeaccount);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rddPayment_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddPayment.SelectedValue != null)
            {
                switch (rddPayment.Text.ToLower())
                {
                    case "cek":
                    case "bg":
                    case "giro":
                    case "transfer":
                        lblket1.Text = "Bank :";
                        lblKet2.Text = "Tanggal : ";
                        txtket2.MaskType = Telerik.WinControls.UI.MaskType.DateTime;
                        txtket2.Mask = "dd MMM yy";
                        txtKet1.MaskType = Telerik.WinControls.UI.MaskType.None;
                        txtKet1.Mask = "";
                        lblket3.Text = "Keterangan :";
                        break;
                    case "titipan":
                        lblket1.Text = "Tanggal :";
                        lblKet2.Text = "Keterangan : ";
                        txtket2.MaskType = Telerik.WinControls.UI.MaskType.None;
                        txtket2.Mask = "";
                        txtKet1.MaskType = Telerik.WinControls.UI.MaskType.DateTime;
                        txtKet1.Mask = "dd MMM yy";
                        lblket3.Text = "";
                        break;
                    case "cash":
                        lblket1.Text = "Keterangan :";
                        lblKet2.Text = "";
                        txtKet1.MaskType = Telerik.WinControls.UI.MaskType.None;
                        txtKet1.Mask = "";
                        txtket2.MaskType = Telerik.WinControls.UI.MaskType.None;
                        txtket2.Mask = "";
                        lblket3.Text = "";
                        break;
                }
            }
        }

        private bool ValidateFields()
        {
            return true;
        }
        private void ClearForm()
        {
            txtKet1.ResetText();
            txtket2.ResetText();
            txtket3.ResetText();
            txtUnit.ResetText();
            txtValue.ResetText();

            rddAcc.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                AddPayment();
                this.Close();
            }
        }

        private void AddPayment()
        {
            frmInputKas frm = (frmInputKas)this.Owner;
            RadGridView grid = frm.getTable();

            GridViewRowInfo row = grid.Rows.AddNew();
            row.Cells["account"].Value = rddAcc.SelectedValue;
            row.Cells["tipe"].Value = rddPayment.SelectedValue;
            row.Cells["unit"].Value = txtUnit.Value;
            row.Cells["value"].Value = txtValue.Value;
            row.Cells["tanggal"].Value = dtpTanggal.Value;
            row.Cells["keterangan1"].Value = txtKet1.Text;
            row.Cells["keterangan2"].Value = txtket2.Text;
            row.Cells["keterangan3"].Value = txtket3.Text;
            row.Cells["category"].Value = (rbtnMasuk.IsChecked);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                AddPayment();
                //clear form

            }
        }

    }
}
