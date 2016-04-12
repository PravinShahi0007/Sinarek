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

namespace NB
{
    public partial class frmGajiTemplate : Telerik.WinControls.UI.RadForm
    {
        public frmGajiTemplate()
        {
            InitializeComponent();

        }
        
        private void radGridView1_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if (e.Value == null)
            {
                e.FormatString = e.Group.Key.ToString();
            }
        }

        private void frmKerajinan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.formula' table. You can move, or remove it, as needed.
            this.formulaTableAdapter.Fill(this.sinarekDataSet.formula);
            // TODO: This line of code loads data into the 'sinarekDataSet.tipepembayaran' table. You can move, or remove it, as needed.
            this.tipepembayaranTableAdapter.Fill(this.sinarekDataSet.tipepembayaran);
            this.tiperinciangajiTableAdapter.Fill(this.sinarekDataSet.tiperinciangaji);
            this.memberTableAdapter.Fill(this.sinarekDataSet.member);
        }

        private void rddTipe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddTipe.SelectedValue != null)
            {
                this.gajitemplateallTableAdapter.FillByTipe(this.sinarekDataSet.gajitemplateall,int.Parse(rddTipe.SelectedValue.ToString()));
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.gajitemplateallTableAdapter.Fill(this.sinarekDataSet.gajitemplateall);
            rddTipe.ResetText();
        }
    }
}
