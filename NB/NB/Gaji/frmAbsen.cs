using System;
using System.Collections.Generic;
using Telerik.WinControls.UI;
using Telerik.WinControls.Keyboard;
using Telerik.WinControls.Commands;
using Telerik.WinControls;
using System.Windows.Forms;


namespace NB
{
    public partial class frmAbsen : Telerik.WinControls.UI.RadForm
    {
        #region "Variables"
        private string currentFilter = string.Empty;
        #endregion
        public frmAbsen()
        {
            InitializeComponent();

            dtpTanggal.Value = DateTime.Now;

            rbNama.Click += new EventHandler(rbButton_Click);
            rbTanggal.Click += new EventHandler(rbButton_Click);
            rbTipeAbsen.Click += new EventHandler(rbButton_Click);
            rbNama.ToggleStateChanged += new StateChangedEventHandler(rb_ToggleStateChanged);
            rbTanggal.ToggleStateChanged += new StateChangedEventHandler(rb_ToggleStateChanged);
            rbTipeAbsen.ToggleStateChanged += new StateChangedEventHandler(rb_ToggleStateChanged);
            
            ResetFilter();           
        }
        #region "Control Event Handler"
        private void frmAbsen_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'sinarekDataSet.tipehadir' table. You can move, or remove it, as needed.
                this.tipehadirTableAdapter1.Fill(this.sinarekDataSet.tipehadir);
                // TODO: This line of code loads data into the 'sinarekDataSet.buruh' table. You can move, or remove it, as needed.
                this.buruhTableAdapter.Fill(this.sinarekDataSet.buruh);
                // TODO: This line of code loads data into the 'sinarekDataSet.absen' table. You can move, or remove it, as needed.
                long lResult = 0;
                if (!long.TryParse(absenTableAdapter.CheckAbsen(NBConfig.IGMID).ToString(), out lResult))
                {
                    absenTableAdapter.FillDataAbsen(NBConfig.IGMID);
                    absenTableAdapter.pCreateDataAbsen(NBConfig.IGMID, NBConfig.ValidUserName);
                    radGridView1.Refresh();
                }
                this.absenTableAdapter.Fill(this.sinarekDataSet.absen, NBConfig.IGMID);
                ddlNama.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
        private void rbButton_Click(object sender, EventArgs e)
        {
            RadRadioButton rb = (RadRadioButton)sender;
            setRadioButton(rb);
        }
        private void FilterAbsen(string currentFilter)
        {
            string filterValue = string.Empty;
            switch (currentFilter)
            {
                case "memberid":
                    filterValue = ddlNama.SelectedValue.ToString();
                    break;
                case "tipehadirid":
                    filterValue = ddlTipeAbsen.SelectedValue.ToString();
                    break;
                case "tanggal":
                    filterValue = dtpTanggal.Value.ToString("yyyy-MM-dd");
                    filterValue = String.Format("'{0}'", filterValue);
                    break;               

            }
            filterValue = String.Format("{0} = {1}", currentFilter, filterValue);

            absenBindingSource.Filter = filterValue;
            radGridView1.Refresh();
        }
        private void radGridView1_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            if (e.Value != null)
            {
                //Update Absen
                string sKeterangan;
                int pagi = 1;
                int sore = 1;
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
                pagi = int.Parse(e.Row.Cells["pagi"].Value.ToString());
                sore = int.Parse(e.Row.Cells["sore"].Value.ToString());

                if (e.Column.Name.Equals("tipehadirid"))
                {
                    if (iTipeHadir == 2 || iTipeHadir == 3 || iTipeHadir == 4 || iTipeHadir == 5 || iTipeHadir == 6)
                    {
                        pagi = 0;
                        sore = 0;
                    }
                    else
                    {
                        pagi = 1;
                        sore = 1;
                    }
                }

                int sisaCuti = 0;
                if (e.Row.Cells["TipeHadirID"].Value.ToString() == "6")
                {
                    //Check Saldo Cuti Sebelum Ambil Cuti
                    int buruhid = int.Parse(e.Row.Cells["MemberID"].Value.ToString());
                    DateTime tanggal = DateTime.Parse(e.Row.Cells["Tanggal"].Value.ToString());
                    //Saldo Cuti Harus di sisakan untuk cuti bersama kira2 3 hari
                    using (sinarekDataSetTableAdapters.saldocutiTableAdapter tbl = new sinarekDataSetTableAdapters.saldocutiTableAdapter())
                    {
                        sisaCuti = int.Parse(tbl.GetSaldoCuti(buruhid, short.Parse(tanggal.Year.ToString())).ToString());
                    }                                 
                }

                if (e.Row.Cells["TipeHadirID"].Value.ToString() == "6" && sisaCuti <= 1)
                {
                    MessageBox.Show("Saldo cuti tidak mengcukupi untuk mengambil cuti tahunan.", "SMS Validation Error");
                }
                else
                {
                    int iAbsenId = int.Parse(e.Row.Cells["AbsenId"].Value.ToString());
                    absenTableAdapter.UpdateAbsen(sKeterangan, iTipeHadir, pagi, sore, NBConfig.ValidUserName, iAbsenId);
                    int rowIndex = e.RowIndex;

                    //changing value of checkeditem
                    this.sinarekDataSet.absen.Clear();
                    this.absenTableAdapter.Fill(this.sinarekDataSet.absen, NBConfig.IGMID);
                    radGridView1.Refresh();
                }
                
            }
        }
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            ResetFilter();
            absenBindingSource.Filter = "";
            radGridView1.Refresh();
        }
        private void rb_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            RadRadioButton rb = (RadRadioButton)sender;
            setRadioButton(rb);
        }
        private void ddlNama_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterAbsen("memberid");
        }
        private void ddlTipeAbsen_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterAbsen("tipehadirid");
        }
        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            FilterAbsen("tanggal");
        }       
        
        #endregion
        #region "Methods"
        private void ResetFilter()
        {
            currentFilter = "nama";
            rbNama.IsChecked = true;
            rbNama.PerformClick();
            //ddlNama.Enabled = true;
            //ddlTipeAbsen.Enabled = true;
            //dtpTanggal.Enabled = true;
            //ddlNama.ResetText();
            //ddlTipeAbsen.ResetText();
            //dtpTanggal.ResetText();
            //ddlNama.Enabled = true;
            //ddlTipeAbsen.Enabled = false;
            //dtpTanggal.Enabled = false;

        }
        private void setRadioButton(RadRadioButton rb)
        {
            switch (rb.Text.Replace("&","").ToLower())
            {
                case "nama":
                    ddlNama.Enabled = true;
                    ddlNama.Focus();
                    ddlTipeAbsen.Enabled = false;
                    dtpTanggal.Enabled = false;
                    currentFilter = "memberid";
                    break;
                case "tanggal":
                    ddlNama.Enabled = false;
                    ddlTipeAbsen.Enabled = false;
                    dtpTanggal.Enabled = true;
                    dtpTanggal.Focus();
                    currentFilter = "tanggal";
                    break;
                case "tipe absen":
                    ddlNama.Enabled = false;
                    ddlTipeAbsen.Enabled = true;
                    ddlTipeAbsen.Focus();
                    dtpTanggal.Enabled = false;
                    currentFilter = "tipehadirid";
                    break;
            }

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
                
                
            }
        }

        private void radGridView1_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            if (!NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""),this.GetType().Name,"Delete"))
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



    }
     
            
        
}
