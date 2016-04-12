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
    public partial class frmLihatKartu : Telerik.WinControls.UI.RadForm
    {
        public frmLihatKartu()
        {
            InitializeComponent();
        }

        private void frmLihatKartu_Load(object sender, EventArgs e)
        {
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            dtpTanggal.Value = DateTime.Now;
            SetConditions();
        }

        private void SetConditions()
        {
            //Kemarin
            ConditionalFormattingObject c4 = new ConditionalFormattingObject("Light Blue, applied to entire row", ConditionTypes.Less, dtpTanggal.Value.ToString("dd MMM yy"), "", true);
            c4.RowBackColor = Color.LightBlue;
            radGridView1.Columns["created"].ConditionalFormattingObjectList.Clear();
            radGridView1.Columns["created"].ConditionalFormattingObjectList.Add(c4);
        }
        
        private void rddProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddProduct.SelectedValue != null)
            {
                this.vperhitunganbarangTableAdapter.FillByTanggalStock(this.sinarekDataSet.vperhitunganbarang
                    , dtpTanggal.Value, dtpTanggal.Value, int.Parse(rddProduct.SelectedValue.ToString()));
                SetConditions();
            }
        }

        private void GetStockAwal()
        {
            //TODO: get nilai stock awal and calculate current stock
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            if (rddProduct.SelectedValue != null)
            {
                this.vperhitunganbarangTableAdapter.FillByTanggalStock(this.sinarekDataSet.vperhitunganbarang
                    , dtpTanggal.Value, dtpTanggal.Value, int.Parse(rddProduct.SelectedValue.ToString()));
                SetConditions();
            }
        }
    }
}
