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
    public partial class frmKasBesar : Telerik.WinControls.UI.RadForm
    {
        public frmKasBesar()
        {
            InitializeComponent();
            //set current date
            dtpTanggal.Value = DateTime.Now;
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            frmInputKas frm = new frmInputKas(TipeTransaksi.In);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.FormElement.TitleBar.TitlePrimitive.Font = new System.Drawing.Font("Lucida Bright", 12, FontStyle.Bold);
            frm.ShowDialog(this);
        }

        private void UpdateTotals()
        {

        }

        private void frmKasBesar_Load(object sender, EventArgs e)
        {
            //this.vacctransTableAdapter.Fill(this.sinarekDataSet.vacctrans);
            //this.acctransTableAdapter.Fill(this.sinarekDataSet.acctrans);

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            frmInputKas frm = new frmInputKas(TipeTransaksi.Out);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.FormElement.TitleBar.TitlePrimitive.Font = new System.Drawing.Font("Lucida Bright", 12, FontStyle.Bold);
            frm.ShowDialog(this);
        }
    }
}
