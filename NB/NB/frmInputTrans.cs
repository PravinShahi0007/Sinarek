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
    public partial class frmInputTrans : RadForm
    {
        #region "Private Variables"

        private string custType_;
        private bool diAntar_;

        #endregion

        public frmInputTrans(string custType)
        {
            InitializeComponent();
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
            
            custType_ = custType;            
        }

        #region "Control Events"
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet1.sopir' table. You can move, or remove it, as needed.
            this.sopirTableAdapter.Fill(this.sinarekDataSet1.sopir);
            // TODO: This line of code loads data into the 'sinarekDataSet1.kernet' table. You can move, or remove it, as needed.
            this.kernetTableAdapter.Fill(this.sinarekDataSet1.kernet);
            this.salesTableAdapter.Fill(this.sinarekDataSet.sales);
            this.pelTableAdapter.Fill(this.sinarekDataSet.pel);
            this.custtypeTableAdapter.Fill(this.sinarekDataSet.custtype);
            this.mobilTableAdapter1.Fill(this.sinarekDataSet.mobil);
            this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
            this.tunitTableAdapter.Fill(this.sinarekDataSet.tunit);
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
                        
            SetDefault();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputForm();
            Close();
        }
        
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                //Save input
                SaveNewItem(4, true);
                //Clear input fields
                ClearInputForm();                
                Close();
            }

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(txtQuantity.Text) <= 0)
            {
                MessageBox.Show("Jumlah produk harus lebih dari 0");
                txtQuantity.Focus();
            }
            else
            {

                GridViewRowInfo row = radGridView1.Rows.AddNew();
                row.Cells["productid"].Value = rddProduct.SelectedValue;

                row.Cells["quantity"].Value = txtQuantity.Text;
                row.Cells["unitid"].Value = rddProduct.Tag.ToString();

                rddProduct.ResetText();
                txtQuantity.ResetText();
                rddProduct.Focus();
            }
        }

        private void btnCancelSJ_Click(object sender, EventArgs e)
        {
            //Input alasan untuk membatalkan
            //Save batal and print surat jalan yg telah dibatalkan
        }

        private void rddTipe_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (rddTipe.SelectedText.ToLower())
            {
                case "contoh":
                    radPageView1.SelectedPage = radPageViewPage4;
                    //Tipe harus dalam kota
                    rddTujuan.FindItemExact("dalam kota", false).Selected = true;
                    rddTujuan.Enabled = false;
                    break;
                case "sales":
                    radPageView1.SelectedPage = radPageViewPage1;
                    break;
                case "pelanggan":
                    //TODO : Format untuk print pelanggan sale should be different
                    radPageView1.SelectedPage = radPageViewPage2;
                    break;
                case "staff":
                case "buruh":
                case "satpam":
                    radPageView1.SelectedPage = radPageViewPage3;
                    //Tipe harus dalam kota
                    rddTujuan.FindItemExact("dalam kota",false).Selected = true;
                    rddTujuan.Enabled = false;
                    //Load Data 
                    switch (rddTipe.SelectedText.ToLower())
                    { 
                        case "buruh":
                            this.buruhTableAdapter.Fill(this.sinarekDataSet.buruh);
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

        private void rddTujuan_SelectedValueChanged(object sender, EventArgs e)
        {
            //Make Sure all the right rdd has been filter according to location
            //Nama Pelanggan
        }

        private void chkSales_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                rddPelSales.Enabled = true;
            }
            else
            {
                rddPelSales.Enabled = false;
            }
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                //Save input
                SaveNewItem(4, false);

                //Clear input fields
                ClearInputForm();
                SetDefault();
                tanggalDateTimePicker.Focus();
            }
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
        #endregion

        #region "Methods"
        private void LoadDataSJ()
        {

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
                        MessageBox.Show("Silahkan pilih nama pegawaiyang akan membeli barang!");
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

        private void ClearInputForm()
        {
            tanggalDateTimePicker.Value = DateTime.Now;
            rddCust.ResetText();
            rddKernet.ResetText();
            rddMobil.ResetText();
            rddPelSales.ResetText();
            rddPelSopir.ResetText();
            rddPelMobil.ResetText();
            rddPelKernet.ResetText();
            rddProduct.ResetText();
            rddSales.ResetText();
            rddSopir.ResetText();
            rddTujuan.ResetText();

            radGridView1.Rows.Clear();
        }

        private void SetDefault()
        {
            rddTujuan.FindItemExact("dalam kota", false).Selected = true;

            //by default always set tipe to sales
            rddTipe.Enabled = true;
            rddTipe.FindItemExact(custType_, false).Selected = true;
            rddTipe.Enabled = false;

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

            rddPelSales.FindItemExact("Kantor", false).Selected = true;

            chkAntar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            rddPelKernet.Enabled = false;
            rddPelMobil.Enabled = false;
            rddPelSopir.Enabled = false;

            //switch (rddTipe.Text.ToLower())
            //{
            //    case "pelanggan":
            //        rddPelSales.FindItemExact("Kantor", false).Selected = true;
            //        break;
            //    case "sales":
            //        break;
            //    case "buruh":
            //    case "staff":
            //    case "satpam":
            //        rddPelSales.FindItemExact("Kantor", false).Selected = true;
            //        break;
            //}

        }
        
        private void SaveNewItem(short StatusID, bool print)
        {
            string iLogID = string.Empty;
            string mobil = string.Empty
                , sopir = string.Empty
                , keterangan = null;
            int kernetid = -1
                , sopirid = -1
                , mobilid = -1
                , kotaid = -1
                , salesid = -1
                , custid = -1
                , custtypetoid = -1;
            int paid = 0;

            custtypetoid = int.Parse(rddTipe.SelectedValue.ToString());
            kotaid = int.Parse(rddTujuan.SelectedValue.ToString());
            salesid = int.Parse(rddPelSales.SelectedValue.ToString());
            switch (rddTipe.Text.ToLower())
            {
                case "pelanggan":
                    custid = int.Parse(mrddPel.SelectedValue.ToString());
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
                    custid = int.Parse(rddSales.SelectedValue.ToString());
                    sopirid = int.Parse(rddSopir.SelectedValue.ToString());
                    mobilid = int.Parse(rddMobil.SelectedValue.ToString());
                    kernetid = int.Parse(rddKernet.SelectedValue.ToString());
                    break;
                case "staff":
                case "satpam":
                case "buruh":
                    custid = int.Parse(rddCust.SelectedValue.ToString());
                    salesid = int.Parse(rddPelSales.SelectedValue.ToString());
                    break;
                case "contoh":
                    break;
                case "rusak":
                    break;
                case "return":
                    //custtypeid and custtypetoid is switched
                    break;
            }
            using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
            {
                //Always Create with status created
                iLogID = tbl.pInsertLogProd(tanggalDateTimePicker.Value
                                            ,1
                                            , kernetid
                                            , sopirid
                                            , mobilid
                                            , kotaid
                                            , salesid
                                            , mobil
                                            , sopir
                                            , keterangan
                                            , custid
                                            , custtypetoid
                                            , NBConfig.ValidUserName
                                            , StatusID, paid, 0).ToString();
            }

            foreach (GridViewRowInfo item in radGridView1.Rows)
            {
                using (sinarekDataSetTableAdapters.logdetailTableAdapter tbl = new sinarekDataSetTableAdapters.logdetailTableAdapter())
                {
                    tbl.pInsertLogDetail(int.Parse(iLogID)
                        , int.Parse(item.Cells["productid"].Value.ToString())
                        , decimal.Parse(item.Cells["quantity"].Value.ToString())
                        ,-1
                        ,1
                        , 1
                        , NBConfig.ValidUserName);
                }
            }

            MessageBox.Show("Data sudah terinput.", "SMS");

            //Print
            DialogResult res = MessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                PrinterSettings printerSettings;
                ReportProcessor reportProcessor;

                rptSJ rpt = new rptSJ();
                rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                rpt.ReportParameters["logid"].Value = iLogID;
                rpt.ReportParameters["custtypetoid"].Value = rddTipe.SelectedValue;

                IReportDocument iRpt = (IReportDocument)rpt;
                //// PrinterSettings 
                printerSettings = new PrinterSettings();
                //// Adjust the printer settings if necessary...

                // Print the report using the printer settings.
                reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(iRpt, printerSettings); 
            }
            else
            {
                MessageBox.Show("Surat Jalan ini dapat dilihat di daftar surat jalan yg belum di print.");
            }

        }
        
        #endregion

    }
}
