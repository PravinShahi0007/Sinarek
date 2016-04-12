using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

using lihatgaji;

namespace NB
{
    public partial class frmGajiStaff : Telerik.WinControls.UI.RadForm
    {
        public frmGajiStaff()
        {
            InitializeComponent();
            rptGajiOther rpt = new rptGajiOther();
            reportViewer1.Report = rpt;
            rpt.ReportParameters["TipeMember"].Visible = false;
            rpt.ReportParameters["TipeMember"].Value = "staff";            

            rptGajiOtherSummary rpt2 = new rptGajiOtherSummary();
            reportViewer2.Report = rpt2;
            rpt2.ReportParameters["TipeMember"].Visible = false;
            rpt2.ReportParameters["TipeMember"].Value = "staff";
        }
        
        private void AddDetail(int TipeID_, decimal value_, string Title)
        {
            frmAddGajiDetailStaff frm = new frmAddGajiDetailStaff(TipeID_
                , " Input " + Title
                , value_);
            frm.ShowDialog(this);

            //refresh report
            reportViewer1.RefreshReport();
            reportViewer2.RefreshReport();
        }

        private void frmGajiStaff_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
            reportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            reportViewer2.RefreshReport();
            reportViewer2.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
        }

        private void btnAngsuran_Click(object sender, EventArgs e)
        {
            AddDetail(int.Parse(btnAngsuran.Tag.ToString()), 0, "Angsuran Pinjaman");
        }

        private void btnTambahan_Click(object sender, EventArgs e)
        {
            AddDetail(int.Parse(btnTambahan.Tag.ToString()), 0, "Tambahan");
        }

        private void btnPanjar_Click(object sender, EventArgs e)
        {
            AddDetail(int.Parse(btnPanjar.Tag.ToString()), 0, "Panjar");
        }

        private void btnInputLembur_Click(object sender, EventArgs e)
        {
            AddDetail(int.Parse(btnInputLembur.Tag.ToString()), 0, "Lembur");
        }

        private void btnGajiPokok_Click(object sender, EventArgs e)
        {
            AddDetail(int.Parse(btnGajiPokok.Tag.ToString()), 0, "Gaji Pokok");
        }

        private void btnUangMakan_Click(object sender, EventArgs e)
        {
            AddDetail(int.Parse(btnUangMakan.Tag.ToString()), 12000, "Uang Makan");
        }

    }
}
