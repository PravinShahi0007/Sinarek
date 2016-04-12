using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySql.Data.Types;

using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using Telerik.Reporting;
using Telerik.Reporting.Processing;

namespace NB
{
    public partial class frmEditSJOLD : RadForm
    {
        #region "Private Variables"

        //private int statusid_ = 4;
        private long logid_ = -1;
        private string custType_;
        private bool isEdit_ = false;
        private bool diAntar_ = false;
        private DataRow editRow_;
        private bool add_, edit_, delete_;

        #endregion

        public frmEditSJOLD(string sValue)
        {
            InitializeComponent();
            add_ = false;
            edit_ = false;
            delete_ = false;

            isEdit_ = true;
            custType_ = sValue;
            //if editing
            if (isEdit_)
            {
                this.Text = "Surat Jalan - " + sValue;
                btnSimpan.Text = "&Simpan";
            }
        }
        #region "Control Events"
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.logdetail' table. You can move, or remove it, as needed.
            //this.logdetailTableAdapter.Fill(this.sinarekDataSet.logdetail);
            this.sopirTableAdapter.Fill(this.sinarekDataSet.sopir);
            this.kernetTableAdapter.Fill(this.sinarekDataSet.kernet);
            this.salesTableAdapter.Fill(this.sinarekDataSet.sales);
            this.pelTableAdapter.Fill(this.sinarekDataSet.pel);
            this.mobilTableAdapter.Fill(this.sinarekDataSet.mobil);
            this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
            this.tunitTableAdapter.Fill(this.sinarekDataSet.tunit);
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.custtypeTableAdapter.Fill(this.sinarekDataSet.custtype);

            LoadDataSJ(custType_);
            InitializeButtons();            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }    

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {                
                SaveEditItem();
                this.Close();
            }

        }       
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rddProduct.SelectedValue == null)
            {
                helper.ErrorMessage("Silahkan pilih produk");
                txtQuantity.Focus();
            }else
            if (decimal.Parse(txtQuantity.Text) <= 0)
            {
                helper.ErrorMessage("Jumlah produk harus lebih dari 0");
                txtQuantity.Focus();
            }
            else
            {
                GridViewRowInfo row = radGridView1.Rows.AddNew();
                row.Cells["productid"].Value = rddProduct.SelectedValue;
                row.Cells["quantity"].Value = txtQuantity.Text;
                row.Cells["custtypeid"].Value = rddProduct.Tag.ToString();

                rddProduct.ResetText();
                txtQuantity.ResetText();
                rddProduct.Focus();
            }
        }
        
        private void rddTipe_SelectedValueChanged(object sender, EventArgs e)
        {
            string sLogID =string.Empty;
            string sopirid = string.Empty;
            string mobilid = string.Empty;
            string kernetid = string.Empty;
            string salesid = string.Empty;
            string custid = string.Empty;
            string kotaid = string.Empty;
            string nosj = string.Empty;

            if (isEdit_ && editRow_ != null)
            {            
                sLogID = editRow_["logid"].ToString();
                sopirid = editRow_["sopirid"].ToString();
                salesid = editRow_["salesid"].ToString();
                custid = editRow_["custid"].ToString();
                mobilid = editRow_["mobilid"].ToString();
                kernetid = editRow_["kernetid"].ToString();
                kotaid = editRow_["kotaid"].ToString();
                nosj = editRow_["nosj"].ToString();

                //Allow Edit Row Log Details
                //show no sj
                txtSJ.Visible = true;
                txtSJ.Text = nosj;
                txtSJ.Enabled = false;

                //Load Details
                sinarekDataSet.logdetail.Clear();
                logdetailTableAdapter.FillBySJ(sinarekDataSet.logdetail, long.Parse(sLogID));
                radGridView1.DataSource = logdetailBindingSource;
            }
            switch (rddTipe.SelectedText.ToLower())
            {
                case "contoh":
                    radPageView1.SelectedPage = radPageViewPage4;
                    //Tipe harus dalam kota
                    rddTujuan.FindItemExact("dalam kota", false).Selected = true;
                    rddTujuan.Enabled = false;
                    if (isEdit_)
                    {
                    }                       
                    break;
                case "sales":
                    radPageView1.SelectedPage = radPageViewPage1;
                    
                    if (isEdit_ && editRow_ != null)
                    {
                        rddTujuan.SelectedValue = int.Parse(kotaid);
                        DataRow[] dr = this.sinarekDataSet.sales.Select("salesid = " + salesid);
                        rddSales.FindItemExact(dr[0]["short"].ToString(), false).Selected = true;
                        
                        rddSopir.SelectedValue = int.Parse(sopirid);
                        rddMobil.SelectedValue = int.Parse(mobilid);
                        dr = this.sinarekDataSet.kernet.Select("kernetid = " + kernetid);
                        rddKernet.FindItemExact(dr[0]["nama"].ToString(), false).Selected = true;                      
                    }                    
                    break;
                case "pelanggan":
                    //TODO : Format untuk print pelanggan sale should be different
                    radPageView1.SelectedPage = radPageViewPage2;
                    
                    RadMultiColumnComboBoxElement multiColumnComboElement = this.mrddPel.MultiColumnComboBoxElement;
                    multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
                    multiColumnComboElement.DropDownWidth = 400;
                    multiColumnComboElement.DropDownHeight = 300;
                    multiColumnComboElement.EditorControl.MasterTemplate.AutoGenerateColumns = false;
                    multiColumnComboElement.EditorControl.Size = new Size(420, 300);

                    GridViewTextBoxColumn column = new GridViewTextBoxColumn("Name");
                    column.HeaderText = "NAMA";
                    column.Width = 150;
                    multiColumnComboElement.Columns.Add(column);
                    column = new GridViewTextBoxColumn("Address");
                    column.HeaderText = "Alamat";
                    column.Width = 225;
                    multiColumnComboElement.Columns.Add(column);
                    column = new GridViewTextBoxColumn("CustID");
                    column.HeaderText = "CustID";
                    column.Width = 225;
                    column.IsVisible = false;
                    multiColumnComboElement.Columns.Add(column);

                    mrddPel.DataSource = pelBindingSource;


                    if (isEdit_ && editRow_ != null)
                    {
                        rddTujuan.SelectedValue = int.Parse(kotaid);
                        mrddPel.SelectedValue = int.Parse(custid);
                        DataRow[] dr = this.sinarekDataSet.sales.Select("salesid = " + salesid);
                        rddPelSales.FindItemExact(dr[0]["short"].ToString(), false).Selected = true;
                        if (mobilid != "-1")
                        {
                            chkAntar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                            rddPelMobil.SelectedValue = int.Parse(mobilid);
                            dr = this.sinarekDataSet.kernet.Select("kernetid = " + kernetid);
                            rddPelKernet.FindItemExact(dr[0]["nama"].ToString(), false).Selected = true;
                            rddPelSopir.SelectedValue = int.Parse(sopirid);
                        }
                        else
                        {
                            chkAntar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
                            txtMobil.Text = editRow_["mobilname"].ToString();
                            txtSopir.Text = editRow_["sopirname"].ToString();
                        }
                    }
                    else
                    {
                        chkAntar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                    }
                    break;
                case "staff":
                case "buruh":
                case "satpam":
                    radPageView1.SelectedPage = radPageViewPage3;
                    //Tipe harus dalam kota
                    rddTujuan.FindItemExact("dalam kota",false).Selected = true;
                    rddTujuan.Enabled = false;
                    rddPelSales.FindItemExact("KTR", false).Selected = true;
                    //Load Data 
                    switch (rddTipe.SelectedText.ToLower())
                    { 
                        case "buruh":
                            rddCust.DisplayMember = "name";
                            rddCust.ValueMember = "buruhid";
                            rddCust.DataSource = buruhBindingSource;
                            break;
                        case "staff":
                            this.staffTableAdapter.Fill(this.fingermachDataSet.staff);
                            rddCust.DisplayMember = "name";
                            rddCust.ValueMember = "staffid";
                            rddCust.DataSource = staffBindingSource;
                            break;
                        case "satpam":
                            this.satpamTableAdapter.Fill(this.fingermachDataSet.satpam);
                            rddCust.DisplayMember = "name";
                            rddCust.ValueMember = "satpamid";
                            rddCust.DataSource = satpamBindingSource;
                            break;
                    }
                    if (isEdit_ && editRow_ != null)
                    {
                        rddCust.SelectedValue = int.Parse(custid);
                    }
                    break;
                
            }
            radPageView1.SelectedPage.Enabled = true;
            foreach (RadPageViewPage page in radPageView1.Pages)
            {
                if (page != radPageView1.SelectedPage)
                {
                    page.Enabled = false;
                }
            }
        }

        private void mrddPel_Enter(object sender, EventArgs e)
        {
            mrddPel.MultiColumnComboBoxElement.ShowPopup();
        }   
       
        private void chkAntar_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (chkAntar.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                diAntar_ = true;                
            }
            else
            {
                diAntar_ = false;
            }
            txtMobil.Enabled = (!diAntar_);
            txtSopir.Enabled = (!diAntar_);
            
            rddPelKernet.Enabled = diAntar_;
            rddPelMobil.Enabled = diAntar_;
            rddPelSopir.Enabled = diAntar_;
        }

        private void radGridView1_UserDeletingRow(object sender, GridViewRowCancelEventArgs e)
        {
            if (e.Rows[0].Cells["detailid"].Value != null)
            {
                try
                {
                    DialogResult res = RadMessageBox.Show("Pilihan anda akan di hapus. Pilih [Yes] untuk menghapus."
                        , "SMS - Verification"                       
                        , MessageBoxButtons.YesNo, RadMessageIcon.Question);
                    //Delete row from db
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        logdetailTableAdapter.DeleteItem(int.Parse(e.Rows[0].Cells["detailid"].Value.ToString()));
                    }
                }
                catch (Exception ex)
                {
                    helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                    helper.ErrorMessage("Gagal menghapus data");
                    e.Cancel = true;
                }
            }
            
        }
        #endregion

        #region "Methods"
        private void InitializeButtons()
        {
            string frmName = this.Owner.GetType().Name;
            add_ = NBConfig.CheckPermission((this.Owner.Tag != null ? this.Owner.Tag.ToString() : ""), frmName, "add");
            edit_ = NBConfig.CheckPermission((this.Owner.Tag != null ? this.Owner.Tag.ToString() : ""), frmName, "edit");
            delete_ = NBConfig.CheckPermission((this.Owner.Tag != null ? this.Owner.Tag.ToString() : ""), frmName, "delete");
            
            tanggalDateTimePicker.Enabled = delete_;
            rddCust.Enabled = delete_;
            mrddPel.Enabled = delete_;
            rddSales.Enabled = delete_;

            if (DateTime.Parse(editRow_["modified"].ToString()).Date == DateTime.Now.Date)
            {
                rddKernet.Enabled = true;
                rddMobil.Enabled = true;
                rddSopir.Enabled = true;

                rddPelKernet.Enabled = true;
                rddPelSopir.Enabled = true;
                rddPelMobil.Enabled = true;
                rddPelSales.Enabled = true;

                rddTujuan.Enabled = true;

                radGridView1.ReadOnly = false;
                radGroupBox2.Enabled = true;
            }
            else
            {
                rddKernet.Enabled = edit_ || delete_;
                rddMobil.Enabled = edit_ || delete_;
                rddSopir.Enabled = edit_ || delete_;

                rddPelKernet.Enabled = edit_ || delete_;
                rddPelSopir.Enabled = edit_ || delete_;
                rddPelMobil.Enabled = edit_ || delete_;
                rddPelSales.Enabled = delete_;

                rddTujuan.Enabled = delete_;

                radGridView1.ReadOnly = (!delete_);
                radGroupBox2.Enabled = delete_;
            }
            
        }

        private void LoadDataSJ(string NoSJ)
        {
            sinarekDataSet.vlogproductDataTable tb = new NB.sinarekDataSet.vlogproductDataTable();
            using (sinarekDataSetTableAdapters.vlogproductTableAdapter tbAdapt = new sinarekDataSetTableAdapters.vlogproductTableAdapter())
            {
                tbAdapt.FillBySJ(tb, NoSJ);
            }

            editRow_ = tb.Rows[0];
            string transtypeid = editRow_["transtypetypeid"].ToString();
            logid_ = long.Parse(editRow_["logid"].ToString());

            if (int.Parse(rddTipe.SelectedValue.ToString()) == int.Parse(transtypeid))
            {
                rddTipe_SelectedValueChanged(rddTipe, new EventArgs());
            }
            else
            {
                rddTipe.SelectedValue = int.Parse(transtypeid);
            }

            tanggalDateTimePicker.Value = DateTime.Parse(editRow_["tanggal"].ToString());

            switch (rddTipe.Text.ToLower())
            {
                case "pelanggan":
                    mrddPel.SelectedValue = int.Parse(editRow_["custid"].ToString());
                    rddPelSales.FindItemExact(editRow_["SalesShort"].ToString(), false).Selected = true;
                    if (editRow_["sopirid"].ToString() != "-1")
                    {
                        chkAntar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                    }
                    if (chkAntar.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        rddPelSopir.FindItemExact(editRow_["sopirname"].ToString(),false).Selected = true;
                        rddPelMobil.FindItemExact(editRow_["mobilname"].ToString(), false).Selected = true;
                        rddPelKernet.FindItemExact(editRow_["kernetname"].ToString(), false).Selected = true;
                    }
            
                    break;
                case "sales":
                    rddSales.FindItemExact(editRow_["SalesShort"].ToString(),false).Selected = true;
                    //rddCust.FindItemExact(editRow_["SalesShort"].ToString(), false).Selected = true;
                    rddSopir.FindItemExact(editRow_["sopirname"].ToString(),false).Selected = true;
                    rddMobil.FindItemExact(editRow_["mobilname"].ToString(), false).Selected = true;
                    rddKernet.FindItemExact(editRow_["kernetname"].ToString(), false).Selected = true;
                    break;
                case "staff":
                case "satpam":
                case "buruh":
                    rddPelSales.FindItemExact(editRow_["SalesShort"].ToString(),false).Selected = true;
                    rddCust.FindItemExact(editRow_["CustName"].ToString(), false).Selected = true;
                    break;
                case "contoh":
                    break;
                case "rusak":
                    break;
                case "return":
                    //custtypeid and custtypetoid is switched
                    break;
            }
            //Load Product
            //radGridView1.DataSource = logdetailBindingSource;
            radGridView1.DataSource = null;
            this.sinarekDataSet.logdetail.Clear();
            logdetailTableAdapter.FillBySJ(this.sinarekDataSet.logdetail, long.Parse(editRow_["logid"].ToString()));
            foreach (DataRow row in sinarekDataSet.logdetail.Rows)
            {
                GridViewRowInfo newRow = radGridView1.Rows.AddNew();
                newRow.Cells["detailid"].Value = row["detailid"];
                newRow.Cells["productid"].Value = row["baseid"];
                newRow.Cells["custtypeid"].Value = row["custtypeid"];
                newRow.Cells["quantity"].Value = row["quantity"];
            }
        }

        private bool ValidateFields()
        {
            //kota, kernet, sopir, mobil
            if (rddTujuan.SelectedValue == null)
            {
                MessageBox.Show("Silahkan pilih kota !");
                rddTujuan.Focus();
                return false;
            }

            switch (rddTipe.SelectedText.ToLower())
            {
                case "sales":
                    //sales
                    if (rddSales.SelectedValue == null)
                    {
                        MessageBox.Show("Silahkan pilih nama pelanggan yang akan membeli barang!");
                        rddSales.Focus();
                        return false;
                    }

                    if (rddSopir.SelectedValue == null)
                    {
                        MessageBox.Show("Silahkan pilih sopir untuk pengantaran barang!");
                        rddSopir.Focus();
                        return false;
                    }

                    if (rddKernet.SelectedValue == null)
                    {
                        MessageBox.Show("Silahkan pilih kernet untuk pengantaran barang!");
                        rddKernet.Focus();
                        return false;
                    }

                    if (rddMobil.SelectedValue == null)
                    {
                        MessageBox.Show("Silahkan pilih kendaraan untuk pengantaran barang!");
                        rddMobil.Focus();
                        return false;
                    }
                    
                    break;
                case "pelanggan":
                    //pelanggan
                    if (mrddPel.SelectedValue == null)
                    {
                        MessageBox.Show("Silahkan pilih nama pelanggan yang akan membeli barang!");
                        rddCust.Focus();
                        return false;
                    }
                    //kota, nama sopir and dd mobil
                    if (chkAntar.ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off)
                    {
                        if (string.IsNullOrEmpty(txtSopir.Text))
                        {
                            MessageBox.Show("Nama sopir pelanggan belum di input");
                            txtMobil.SelectAll();
                            return false;
                        }
                        if (string.IsNullOrEmpty(txtMobil.Text))
                        {
                            MessageBox.Show("No Polis Kendaraan Pelanggan belum di input");
                            txtMobil.SelectAll();
                            return false;
                        }
                    }
                    else
                    {
                        if (rddPelSopir.SelectedValue == null)
                        {
                            MessageBox.Show("Silahkan pilih sopir untuk pengantaran barang!");
                            rddPelSopir.Focus();
                            return false;
                        }

                        if (rddPelKernet.SelectedValue == null)
                        {
                            MessageBox.Show("Silahkan pilih kernet untuk pengantaran barang!");
                            rddPelKernet.Focus();
                            return false;
                        }

                        if (rddPelMobil.SelectedValue == null)
                        {
                            MessageBox.Show("Silahkan pilih kendaraan untuk pengantaran barang!");
                            rddPelMobil.Focus();
                            return false;
                        }
                    }
                    
                    break;
                case "staff":
                case "buruh":
                case "satpam":
                    if (rddCust.SelectedValue == null)
                    {
                        MessageBox.Show("Silahkan pilih nama pegawai yang akan membeli barang!");
                        rddCust.Focus();
                        return false;
                    }
                    //rddcust                                        
                    break;
            }
            //Validate Product
            if (radGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Belum ada produk yang di pilih.", "SMS - Validation Error");
                rddProduct.Focus();
                return false;
            }

            return true;
        }
        
        private void SetDefault()
        {
            rddTujuan.FindItemExact("dalam kota", false).Selected = true;

            //by default always set tipe to sales
            rddTipe.Enabled = true;
            rddTipe.FindItemExact(custType_, false).Selected = true;
            rddTipe.Enabled = false;

            if (!delete_)
            {
                tanggalDateTimePicker.Value = DateTime.Now;
                tanggalDateTimePicker.MinDate = DateTime.Now.Date;
                if (DateTime.Now.AddDays(1).DayOfWeek == DayOfWeek.Sunday)
                {
                    tanggalDateTimePicker.MaxDate = DateTime.Now.AddDays(2);
                }
                else
                {
                    tanggalDateTimePicker.MaxDate = DateTime.Now.AddDays(1);
                }
            }

            rddPelSales.FindItemExact("KTR", false).Selected = true;

            chkAntar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            rddPelKernet.Enabled = false;
            rddPelMobil.Enabled = false;
            rddPelSopir.Enabled = false;


        }       

        private void SaveEditItem()
        {
            //Can only update items / kernet / sopir
            string iLogID = string.Empty;
            string mobil = string.Empty
                , sopir = string.Empty
                , keterangan = null;
            int kernetid = -1
                , sopirid = -1
                , mobilid = -1
                , kotaid = -1
                , salesid = -1
                , custtypetoid = -1;

            custtypetoid = int.Parse(rddTipe.SelectedValue.ToString());
            kotaid = int.Parse(rddTujuan.SelectedValue.ToString());
            salesid = int.Parse(rddPelSales.SelectedValue.ToString());

            switch (rddTipe.Text.ToLower())
            {
                case "pelanggan":
                    if (chkAntar.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        sopirid = int.Parse(rddPelSopir.SelectedValue.ToString());
                        mobilid = int.Parse(rddPelMobil.SelectedValue.ToString());
                        kernetid = int.Parse(rddPelKernet.SelectedValue.ToString());
                    }
                    else
                    {
                        sopir = txtSopir.Text;
                        mobil = txtMobil.Text;
                    }
                    break;
                case "sales":
                    salesid = int.Parse(rddSales.SelectedValue.ToString());
                    sopirid = int.Parse(rddSopir.SelectedValue.ToString());
                    mobilid = int.Parse(rddMobil.SelectedValue.ToString());
                    kernetid = int.Parse(rddKernet.SelectedValue.ToString());
                    break;
                case "staff":
                case "satpam":
                case "buruh":
                case "contoh":
                    break;
            }
            using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
            {
                //Update SJ
                tbl.UpdateSJ(tanggalDateTimePicker.Value
                                            , kernetid
                                            , kotaid
                                            , sopirid
                                            , mobil
                                            , mobilid
                                            , salesid
                                            , sopir
                                            , keterangan
                                            , NBConfig.ValidUserName
                                            , logid_).ToString();
            }
            using (sinarekDataSetTableAdapters.logdetailTableAdapter tbl = new sinarekDataSetTableAdapters.logdetailTableAdapter())
            {
                foreach (GridViewRowInfo item in radGridView1.Rows)
                {
                    if (item.Cells["detailid"].Value != null)
                    {
                        //Update
                        tbl.UpdateItem(int.Parse(item.Cells["productid"].Value.ToString())
                            , int.Parse(item.Cells["custtypeid"].Value.ToString())
                            , custtypetoid
                            , ""
                            , decimal.Parse(item.Cells["quantity"].Value.ToString())
                            , NBConfig.ValidUserName
                            , long.Parse(item.Cells["detailid"].Value.ToString()));
                    }
                    else
                    {
                        //Insert
                        tbl.pInsertLogDetail(int.Parse(logid_.ToString())
                            , int.Parse(item.Cells["productid"].Value.ToString())
                            , decimal.Parse(item.Cells["quantity"].Value.ToString())
                            , custtypetoid
                            , int.Parse(item.Cells["custtypeid"].Value.ToString())
                            , 1
                            , NBConfig.ValidUserName);
                    }
                }
            }
            helper.NotifMessage("SJ sudah tersimpan!");
        }
        #endregion


    }
}
