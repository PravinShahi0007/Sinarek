using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Management;

using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using Telerik.Reporting;
using Telerik.Reporting.Processing;

namespace NB
{
    public partial class frmLihatNR : Telerik.WinControls.UI.RadForm
    {
        private string tipe_;
        public frmLihatNR():this("SJ")
        {
            //InitializeButtons();
            //PopulateInstalledPrintersCombo();
        }
        public frmLihatNR(string Tipe)
        {
            InitializeComponent();
            tipe_ = Tipe;
            
        }

        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            bool add = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "add");
            bool edit = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "edit");
            bool delete = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "delete");
        }

        private void frmLihatNR_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeButtons();
                switch (tipe_.ToLower())
                {
                    case "sj":
                        this.Text = "Surat Jalan Tanpa Laporan";
                        this.vlogproductTableAdapter.FillByNoReport(this.sinarekDataSet.vlogproduct);
                        vlogproductBindingSource.Filter = "category = 0 and statusid = 4";
                        break;
                    case "return":
                        this.Text = "Barang Return tanpa SJ";
                        this.vlogproductTableAdapter.FillByRNSJ(this.sinarekDataSet.vlogproduct);
                        vlogproductBindingSource.Filter = "category = 1 and statusid = 4";
                        break;
                    case "contoh":
                        break;
                }
                this.logdetailTableAdapter.Fill(this.sinarekDataSet.logdetail);
                this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            }
            catch (Exception ex)
            {
                helper.ErrorMessage(ex.Message);
            }
        }

        private void radGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                switch (tipe_.ToLower())
                {
                    case "sj":
                        this.Text = "Surat Jalan Tanpa Laporan";
                        this.vlogproductTableAdapter.FillByNoReport(this.sinarekDataSet.vlogproduct);
                        break;
                    case "return":
                        this.Text = "Barang Return tanpa SJ";
                        this.vlogproductTableAdapter.FillByRNSJ(this.sinarekDataSet.vlogproduct);
                        break;
                }
                this.logdetailTableAdapter.Fill(this.sinarekDataSet.logdetail);
                this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            }
        }
    }
}
