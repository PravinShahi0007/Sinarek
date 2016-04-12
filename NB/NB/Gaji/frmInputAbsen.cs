using System;
using System.Collections.Generic;
using Telerik.WinControls.UI;
using Telerik.WinControls.Keyboard;
using Telerik.WinControls.Commands;
using Telerik.WinControls;
using System.Windows.Forms;


namespace NB
{
    public partial class frmInputAbsen : Telerik.WinControls.UI.RadForm
    {
        #region "Variables"
        private bool add_;
        private bool edit_;
        private bool delete_;
        #endregion
        public frmInputAbsen()
        {
            InitializeComponent();          
        }
        #region "Control Event Handler"
        private void frmAbsen_Load(object sender, EventArgs e)
        {
            
            try
            {
                //this.absenallTableAdapter.Fill(this.sinarekDataSet.absenall);
                this.tipememberTableAdapter.Fill(this.sinarekDataSet.tipemember);
                this.memberTableAdapter.Fill(this.sinarekDataSet.member);
                this.tipehadirTableAdapter1.Fill(this.sinarekDataSet.tipehadir);
                //long lResult = 0;
                //if (!long.TryParse(absenTableAdapter.CheckAbsen(NBConfig.IGMID).ToString(), out lResult))
                //{
                //    absenTableAdapter.FillDataAbsen(NBConfig.IGMID);
                //    absenTableAdapter.pCreateDataAbsen(NBConfig.IGMID, NBConfig.ValidUserName);
                //    radGridView1.Refresh();
                //}
                dtpTanggal.Value = DateTime.Now;
                InitializeForms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }               
        private void radGridView1_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            if (!(e.Row is GridViewFilteringRowInfo))
            {
                if (e.Value != null)
                {
                    //Update Absen
                    string sKeterangan;
                    bool pagi = true;
                    bool sore = true;
                    //Update Info to the data base
                    int iTipeHadir = int.Parse(e.Row.Cells["tipehadirid"].Value.ToString());
                    if (!string.IsNullOrEmpty(e.Row.Cells["Keterangan"].Value.ToString()))
                    {
                        sKeterangan = e.Row.Cells["Keterangan"].Value.ToString();
                    }
                    else
                    {
                        sKeterangan = null;
                    }

                    //retrieve the actual value of pagi and sore
                    pagi = bool.Parse(e.Row.Cells["pagi"].Value.ToString());
                    sore = bool.Parse(e.Row.Cells["sore"].Value.ToString());

                    if (e.Column.Name.Equals("tipehadirid"))
                    {
                        if (iTipeHadir == 2 || iTipeHadir == 3 || iTipeHadir == 4 || iTipeHadir == 5 || iTipeHadir == 6)
                        {
                            pagi = false;
                            sore = false;
                        }
                        else
                        {
                            pagi = true;
                            sore = true;
                        }
                    }

                    int sisaCuti = 12;
                    if (iTipeHadir == 6)
                    {
                        //Check Saldo Cuti Sebelum Ambil Cuti
                        int buruhid = int.Parse(e.Row.Cells["MemberID"].Value.ToString());
                        DateTime tanggal = DateTime.Parse(e.Row.Cells["Tanggal"].Value.ToString());
                        //Saldo Cuti Harus di sisakan untuk cuti bersama kira2 3 hari
                        //using (sinarekDataSetTableAdapters.saldocutiTableAdapter tbl = new sinarekDataSetTableAdapters.saldocutiTableAdapter())
                        //{
                        //    sisaCuti = int.Parse(tbl.GetSaldoCuti(buruhid, short.Parse(tanggal.Year.ToString())).ToString());
                        //}

                        //if (sisaCuti < 1)
                        //{
                        //    DialogResult res = RadMessageBox.Show("Saldo cuti tidak mengcukupi untuk mengambil cuti tahunan. Tetap berikan Cuti Tahunan? Pilih [Cancel] untuk berikan cuti biasa.", "SMS Verification"
                        //        , MessageBoxButtons.OKCancel, RadMessageIcon.Question);
                        //    if (res == System.Windows.Forms.DialogResult.Cancel)
                        //    {
                        //        iTipeHadir = 4;
                        //    }
                        //}
                    }

                    int iAbsenId = int.Parse(e.Row.Cells["AbsenId"].Value.ToString());
                    absenallTableAdapter.UpdateAbsen(iTipeHadir, pagi, sore, NBConfig.ValidUserName, sKeterangan, iAbsenId);
                    int rowIndex = e.RowIndex;

                    //changing value of checkeditem
                    this.absenallTableAdapter.FillByTipe(this.sinarekDataSet.absenall
                    , dtpTanggal.Value
                    , int.Parse(ddlTipeAbsen.SelectedValue.ToString()));
                }
            }
        }

        #endregion
        #region "Methods"

        private void InitializeForms()
        {
            string formName = this.GetType().Name;
            string menuName = this.Tag.ToString();

            helper.GetPermissions(formName, menuName, out add_, out edit_, out delete_);
            if (!delete_)
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                {
                    dtpTanggal.MinDate = DateTime.Now.Date.AddDays(-1);
                }
                else
                {
                    dtpTanggal.MinDate = DateTime.Now.Date;
                }                
                dtpTanggal.MaxDate = DateTime.Now.Date;
            }
            //dtpTanggal.Enabled = delete_;
            //radGroupBox1.Enabled = delete_;
        }
        #endregion

        private void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (e.Row.Cells["TipeHadirID"].Value != null)
            {
                string frmName = this.GetType().Name;
                bool delete = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""),frmName, "delete");
                if (!delete)
                {
                    //Can not modify absen kalo hari raya
                    if (e.Row.Cells["TipeHadirID"].Value.ToString() == "7")
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    //Edit To Hari raya and ask if the status should be stated as hari raya for all of the members
                }
                
            }
        }

        private void radGridView1_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            if (!delete_)
            {
                //e.ActiveEditor
                if (e.Column.Name == "tipehadirid")
                {
                    int iHariRaya;
                    //    , iCutiTahunan;
                    RadDropDownListEditor rdd = (RadDropDownListEditor)e.ActiveEditor;
                    RadDropDownListEditorElement el = (RadDropDownListEditorElement)rdd.EditorElement;
                    iHariRaya = el.Items.IndexOf("Hari Raya");
                    //iCutiTahunan = el.Items.IndexOf("Cuti Tahunan");
                    el.Items[iHariRaya].Enabled = false;
                    //el.Items[iCutiTahunan].Enabled = false;
                }
            }
        }

        private void ddlTipeAbsen_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dtpTanggal.Value != null && ddlTipeAbsen.SelectedValue != null)
            {
                this.absenallTableAdapter.FillByTipe(this.sinarekDataSet.absenall
                    , dtpTanggal.Value
                    , int.Parse(ddlTipeAbsen.SelectedValue.ToString()));
            }
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTanggal.Value != null && ddlTipeAbsen.SelectedValue != null)
            {
                this.absenallTableAdapter.FillByTipe(this.sinarekDataSet.absenall
                    , dtpTanggal.Value
                    , int.Parse(ddlTipeAbsen.SelectedValue.ToString()));
            }
        }

        private void btnSetSelected_Click(object sender, EventArgs e)
        {
            int pagi = 0;
            int sore = 0;
            int itipehadir = (int)rddTipeHadir.SelectedValue;

            switch(itipehadir)
            {
                case 1:
                case 6: 
                    pagi = 0;
                    sore = 0;
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                    pagi = 0;
                    sore = 0;
                    break;
            }


            this.absenallTableAdapter.UpdateAbsenPerHari(itipehadir, pagi, sore, NBConfig.ValidUserName, dtpTanggal.Value);
            this.absenallTableAdapter.FillByTipe(this.sinarekDataSet.absenall
                    , dtpTanggal.Value
                    , int.Parse(ddlTipeAbsen.SelectedValue.ToString()));
        }

        private void btnCheckData_Click(object sender, EventArgs e)
        {

        }

    }
     
            
        
}
