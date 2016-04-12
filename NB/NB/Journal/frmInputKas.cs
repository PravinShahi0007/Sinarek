using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Xml;

namespace NB
{
    public enum TipeTransaksi
    {
        In = 0, Out = 1
    };

    public partial class frmInputKas : Telerik.WinControls.UI.RadForm
    {
        private bool bMasuk;
        private decimal sisa_ = -1;
        
        

        /// <summary>
        /// 
        /// </summary>
        public frmInputKas() : this(TipeTransaksi.In)
        {
            //Set up form according to tipe pembayaran
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipe"></param>
        public frmInputKas(TipeTransaksi tipe)
        {
            InitializeComponent();
            dtpTanggal.Value = DateTime.Now;

            if (tipe == TipeTransaksi.In)
            {   //transaksi masuk
                rbtnMasuk.CheckState = CheckState.Checked;
                this.Text = String.Format("Transaksi Masuk - {0}", NBConfig.ValidUserName);
            }
            else if (tipe == TipeTransaksi.Out)
            {   //transaksi keluar
                rbtnKeluar.CheckState = CheckState.Checked;
                this.Text = String.Format("Transaksi Keluar - {0}", NBConfig.ValidUserName);
            }
        }

        private void SetFormValues(string Tipe)
        {

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputPayment(string Tipe)
        {
            frmAddPayment frm = new frmAddPayment(dtpTanggal.Value,bMasuk);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(this);
        }
        private void frmInputKas_Load(object sender, EventArgs e)
        {
            this.tipeaccountTableAdapter.Fill(this.sinarekDataSet.tipeaccount);
            this.accpaymentTableAdapter.Fill(this.sinarekDataSet.accpayment);
            this.vallsupTableAdapter.Fill(this.sinarekDataSet.vallsup);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //Validation total payment must be equal to the price or sisa = 0
        }

        private bool ValidateFields()
        {
            if (sisa_ != 0)
            {
                helper.ErrorMessage("Pembayaran tidak sesuai dengan total biaya.");
                btnAddPayment.Focus();
            }
            if (radGridView1.Rows.Count < 1)
            {
                helper.ErrorMessage("Belum ada record pembayaran. Silahkan Input Pembayaran");
                btnAddPayment.Focus();
            }
            return true;
        }
        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            InputPayment("Cash");
        }

        internal RadGridView getTable()
        {
            return this.radGridView1;
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Value = decimal.Parse(txtPrice.Value.ToString()) + decimal.Parse(txtAdjusted.Value.ToString());
        }

        private void txtAdjusted_Click(object sender, EventArgs e)
        {
            txtTotal.Value = decimal.Parse(txtPrice.Value.ToString()) + decimal.Parse(txtAdjusted.Value.ToString());
        }

        private void txtAdjusted_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Value = decimal.Parse(txtPrice.Value.ToString()) + decimal.Parse(txtAdjusted.Value.ToString());
        }

        private void txtAdjusted_Validating(object sender, CancelEventArgs e)
        {
            //Nilai pembulatan -99 < X < 99
            if (decimal.Parse(txtAdjusted.Value.ToString()) < 100 && decimal.Parse(txtAdjusted.Value.ToString()) > -100)
            {

            }
            else
            {
                e.Cancel = true;
                helper.ErrorMessage("Nilai Pembulatan antara Rp (100) sampe Rp 100");
                txtAdjusted.ResetText();
                txtAdjusted.Focus();
            }
        }
    }
}
