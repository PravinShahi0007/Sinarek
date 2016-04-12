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
    public partial class frmHistoryGaji : Telerik.WinControls.UI.RadForm
    {
        public frmHistoryGaji()
        {
            InitializeComponent();
        }

        private void frmHistoryGaji_Load(object sender, EventArgs e)
        {
            this.gajimingguanTableAdapter.Fill(this.sinarekDataSet.gajimingguan);
            if (!NBConfig.GetGMIDPrinted())
            {
                rptGajiPreview1.ReportParameters["GMID"].Value = NBConfig.IGMID - 1;

                //Always filter gajimingguan value to only historical
                gajimingguanBindingSource.Filter = "GMID < " + NBConfig.IGMID;
            }
            else
            {
                //Always filter gajimingguan value to only historical
                gajimingguanBindingSource.Filter = "GMID <= " + NBConfig.IGMID;
            }
        }

        private void radDropDownList1_SelectedValueChanged(object sender, EventArgs e)
        {
            rptGajiPreview1.ReportParameters["GMID"].Value = radDropDownList1.SelectedValue;
            reportViewer1.RefreshReport();
        }
    }
}
