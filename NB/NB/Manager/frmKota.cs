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
    public partial class frmKota : Telerik.WinControls.UI.RadForm
    {
        public frmKota()
        {
            InitializeComponent();
        }
        
        private void frmKota_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.kota' table. You can move, or remove it, as needed.
            this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
        }

        private void kotaRadGridView_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Value != null)
            {
                //Save Changes
                kotaTableAdapter.UpdateKota(decimal.Parse(e.Row.Cells["Jarak"].Value.ToString())
                                            , e.Row.Cells["SHORT"].Value.ToString()
                                            , decimal.Parse(e.Row.Cells["ResSopir"].Value.ToString())
                                            , decimal.Parse(e.Row.Cells["ResSopirBulanan"].Value.ToString())
                                            , decimal.Parse(e.Row.Cells["ResKernet"].Value.ToString())
                                            , short.Parse(e.Row.Cells["zone"].Value.ToString())
                                            , decimal.Parse(e.Row.Cells["Tambahan"].Value.ToString())
                                            , e.Row.Cells["Jarak"].Value
                                            , decimal.Parse(e.Row.Cells["UangJalan"].Value.ToString())
                                            , int.Parse(e.Row.Cells["KotaID"].Value.ToString()));
                this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
            }


        }

    }
}
