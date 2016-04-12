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
    public partial class frmSaldoCuti : Telerik.WinControls.UI.RadForm
    {
        public frmSaldoCuti()
        {
            InitializeComponent();
        }

        private void frmSaldoCuti_Load(object sender, EventArgs e)
        {
            this.memberTableAdapter.Fill(this.sinarekDataSet.member);
            this.absenallTableAdapter.FillByTahunTipe(this.sinarekDataSet.absenall, 6, DateTime.Now.Year);
            this.vsaldocutiTableAdapter.Fill(this.sinarekDataSet.vsaldocuti, short.Parse(DateTime.Now.Year.ToString()));
        }

        private void btnRefreshCuti_Click(object sender, EventArgs e)
        {
            this.absenallTableAdapter.pUpdateSaldoCuti(DateTime.Now.Year);
            this.absenallTableAdapter.FillByTahunTipe(this.sinarekDataSet.absenall, 6, DateTime.Now.Year);
            this.vsaldocutiTableAdapter.Fill(this.sinarekDataSet.vsaldocuti, short.Parse(DateTime.Now.Year.ToString()));

        }
    }
}
