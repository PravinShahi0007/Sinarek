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
    public partial class frmBotolTier : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool edit_;
        private bool delete_;
        private bool New_;

        private DataRow row_;

        public frmBotolTier(decimal Kapasitas,bool New)
        {
            InitializeComponent();
            txtKapasitas.Value = Kapasitas;
            New_ = New;
        }
        public frmBotolTier(DataRow Row,decimal Kapasitas):this(Kapasitas,false)
        {            
            row_ = Row;
        }
        
        private void frmBotolTier_Load(object sender, EventArgs e)
        {
            if (!New_)
            {
                this.storeuseTableAdapter.FillByStore(this.sinarekDataSet.storeuse, int.Parse(row_["storeid"].ToString()));
                this.storeinTableAdapter.FillByStore(this.sinarekDataSet.storein, int.Parse(row_["storeid"].ToString()));
                this.storeoutTableAdapter.FillByStore(this.sinarekDataSet.storeout, int.Parse(row_["storeid"].ToString()));
            }
            else
            {
                //disable all other tabs
                rpvKeluar.Visible = false;
                rpvMasuk.Visible = false;
                rpvPakai.Visible = false;
                rpvSaldoBotol.Visible = false;
            }
            this.statbotTableAdapter.Fill(this.sinarekDataSet.statbot);
            this.supTableAdapter.Fill(this.sinarekDataSet.sup);
            this.tierTableAdapter.Fill(this.sinarekDataSet.tier);
            this.productbaseTableAdapter.Fill(this.sinarekDataSet.productbase);
            
            if (!New_)
            {
                LoadData();
            }
            else
            {
                
            }
        }

        private void LoadData()
        {
            rddTier.SelectedValue = int.Parse(row_["tierid"].ToString());
            rddSupplier.SelectedValue = int.Parse(row_["supid"].ToString());
            rddStatus.SelectedValue = short.Parse(row_["statusid"].ToString());
            rddBarang.SelectedValue = int.Parse(row_["baseid"].ToString());
            dtpMulaiIsi.Value = DateTime.Parse(row_["startdate"].ToString());
            dtpPenuh.Value = DateTime.Parse(row_["enddate"].ToString());
            dtpMulaiPakai.Value = DateTime.Parse(row_["startusedate"].ToString());
            dtpSelesai.Value =DateTime.Parse(row_["endusedate"].ToString());

            txtPanjar.Value = decimal.Parse(row_["panjarpercent"].ToString());
            txtPanjarCuci.Value = decimal.Parse(row_["panjarcuci"].ToString());
            txtOngkosCuci.Value = decimal.Parse(row_["ongkoscuci"].ToString());
            this.Text = rddTier.Text + " - " + rddSupplier.Text + " - [Status]";
            
        }

        private void InitializeButtons()
        {
            frmTier frm = (frmTier)this.Owner;
            frm.GetPermission(out add_, out edit_, out delete_);

            btnSimpan.Enabled = New_ || delete_;
            btnCancel.Enabled = New_ || delete_;

            btnSimpan.Visible = New_ || delete_;
            btnCancel.Visible = New_ || delete_;
        }

        private void LoadForm()
        {

        }
        private bool ValidateFields()
        {

            return true;
        }
        private void SaveData()
        {
            
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }

    }
}
