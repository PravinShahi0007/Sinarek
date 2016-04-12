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
    public partial class frmInputSJ : RadForm
    {
        #region "Private Variables"

        private string custType_;
        private bool isEdit_ = false;
        private bool add_, edit_, delete_;

        #endregion

        public frmInputSJ():this("Sales",true)
        {
            
        }
        public frmInputSJ(string sValue,bool bIsNew)
        {
            InitializeComponent();

            isEdit_ = (!bIsNew);
            custType_ = sValue;
            
        }
        #region "Control Events"
        private void Form1_Load(object sender, EventArgs e)
        {
            this.vallsupTableAdapter.Fill(this.sinarekDataSet.vallsup);
            this.sopirTableAdapter.Fill(this.sinarekDataSet.sopir);
            this.kernetTableAdapter.Fill(this.sinarekDataSet.kernet);
            this.salesTableAdapter.Fill(this.sinarekDataSet.sales);
            this.mobilTableAdapter.Fill(this.sinarekDataSet.mobil);
            this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.custtypeTableAdapter.Fill(this.sinarekDataSet.custtype);

            InitializeButtons();
            SetDefault();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //ClearInputForm();
            Close();
        }    
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                //Save input
                SaveNewItem();
                //Clear input fields
                ClearInputForm();
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
                row.Cells["status"].Value = 1;
                row.Cells["quantity"].Value = txtQuantity.Text;
                row.Cells["custtypeid"].Value = rddProduct.Tag.ToString();
                row.Cells["custtypetoid"].Value = rddTipe.SelectedValue.ToString();
                row.Cells["keterangan"].Value = txtKeteranganDetail.Text;

                rddProduct.ResetText();
                txtQuantity.ResetText();
                txtKeteranganDetail.ResetText();
                rddProduct.Focus();
            }
        }
        private void rddTipe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddTipe.SelectedValue != null)
            {
                //Always reset form if tipe is changed
                ClearInputForm();
                //Load Data 
                vallsupBindingSource.Filter = "custtypeid = " + rddTipe.SelectedValue.ToString();

                switch (rddTipe.SelectedText.ToLower())
                {
                    case "contoh":
                        //Tipe harus dalam kota
                        rddSales.FindItemExact("KTR", false).Selected = true;
                        rddTujuan.FindItemExact("dalam kota", false).Selected = true;
                        rddPel.Text = "SINAR";

                        rddTujuan.Enabled = false;
                        rddPel.Enabled = false;
                        rddSales.Enabled = false;
                        //Transport
                        radGroupBox1.Enabled = false;
                        break;
                    case "sales":
                        rddSales.FindItemExact("KTR", false).Selected = true;
                        rddTujuan.FindItemExact("dalam kota", false).Selected = true;

                        rddPel.Text = rddSales.Text;
                        rddPel.Enabled = false;
                        rddTujuan.Enabled = true;
                        rddSales.Enabled = true;
                        //Transport
                        radGroupBox1.Enabled = true;
                        break;
                    case "pelanggan":
                        rddSales.FindItemExact("KTR", false).Selected = true;
                        rddTujuan.FindItemExact("dalam kota", false).Selected = true;

                        rddPel.Enabled = true;
                        rddTujuan.Enabled = true;
                        rddSales.Enabled = true;
                        //Transport
                        radGroupBox1.Enabled = true;

                        //chkAntar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                        break;
                    case "staff":
                    case "pegawai":
                    case "satpam":
                        rddSales.FindItemExact("KTR", false).Selected = true;
                        rddTujuan.FindItemExact("dalam kota", false).Selected = true;

                        rddPel.Enabled = true;
                        rddTujuan.Enabled = false;
                        rddSales.Enabled = false;
                        //Transport
                        radGroupBox1.Enabled = false;
                        break;

                }
                SetDefault();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                //Save input
                SaveNewItem();

                //Clear input fields
                ClearInputForm();
                SetDefault();
                tanggalDateTimePicker.Focus();
            }
        }
        private void chkAntar_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            txtMobil.Enabled = !chkAntar.Checked;
            txtSopir.Enabled = !chkAntar.Checked;
            rddKernet.Enabled = chkAntar.Checked;
            rddMobil.Enabled = chkAntar.Checked;
            rddSopir.Enabled = chkAntar.Checked;
        }
        private void radGridView1_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if ((e.Action == NotifyCollectionChangedAction.Add) || (e.Action == NotifyCollectionChangedAction.Remove))
            {
                foreach (GridViewRowInfo row in radGridView1.Rows)
                {
                    row.Cells["NoRow"].Value = row.Index + 1;
                }
            }
        }
        private void rddSales_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddTipe.Text.ToLower() == "sales")
            {
                rddPel.Text = rddSales.Text;
            }
        }
        private void rddTipe_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Force tipe to be chosen
            if (rddTipe.SelectedValue == null)
            {
                helper.ErrorMessage("Silahkan memilih tipe surat jalan!");
                e.Cancel = true;
                rddTipe.Focus();
                if (!string.IsNullOrEmpty(rddTipe.Text))
                {
                    rddTipe.SelectAllText();
                }
            }
            else
            {
                rddTipe.Text = rddTipe.SelectedItem.DisplayValue.ToString();
            }
        }             
        #endregion

        #region "Methods"
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            helper.GetPermissions(frmName, this.Tag.ToString(), out add_, out edit_, out delete_);            
        }
        private bool ValidateFields()
        {
            //Tanggal

            //Tujuan
            if (rddTujuan.SelectedValue == null)
            {
                MessageBox.Show("Silahkan pilih kota !");
                rddTujuan.Focus();
                return false;
            }
            switch (rddTipe.SelectedText.ToLower())
            {
                case "sales":
                case "pelanggan":
                    //pelanggan
                    if (rddPel.SelectedValue == null)
                    {
                        MessageBox.Show("Silahkan pilih nama pelanggan yang akan membeli barang!");
                        rddPel.Focus();
                        return false;
                    }
                    //sales
                    if (rddSales.SelectedValue == null)
                    {
                        MessageBox.Show("Silahkan pilih nama pelanggan yang akan membeli barang!");
                        rddSales.Focus();
                        return false;
                    }
                    if (chkAntar.ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off)
                    {
                        if (string.IsNullOrEmpty(txtSopir.Text))
                        {
                            MessageBox.Show("Nama sopir pelanggan belum di input");
                            txtSopir.SelectAll();
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
                    }
                    
                    break;
                case "staff":
                case "pegawai":
                case "satpam":
                    if (rddPel.SelectedValue == null)
                    {
                        MessageBox.Show("Silahkan pilih nama pelanggan yang akan membeli barang!");
                        rddPel.Focus();
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
            rddPel.ResetText();
            rddSales.ResetText();
            rddSopir.ResetText();
            rddMobil.ResetText();
            rddKernet.ResetText();
            rddProduct.ResetText();
            rddTujuan.ResetText();

            //radGridView1.DataSource = null;
            radGridView1.Rows.Clear();
        }
        private void SetDefault()
        {
            if (!delete_)
            {
                switch (rddTipe.Text.ToLower())
                {
                    case "sales":
                    case "pelanggan":
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
                        break;
                    default:
                        tanggalDateTimePicker.Value = DateTime.Now;
                        tanggalDateTimePicker.MinDate = DateTime.Now.Date;
                        tanggalDateTimePicker.MaxDate = DateTime.Now.Date;
                        break;
                }
            }
            else
            {
                tanggalDateTimePicker.MinDate = DateTime.MinValue.AddYears(1900);
                tanggalDateTimePicker.MaxDate = DateTime.MinValue.AddYears(3999);
            }

            chkAntar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            rddKernet.Enabled = false;
            rddMobil.Enabled = false;
            rddSopir.Enabled = false;

        }     
        private void SaveNewItem()
        {
            short StatusID = 4;
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
                , custtypeid = -1
                , transtypeid = -1;
            int paid = 0;

            transtypeid = int.Parse(rddTipe.SelectedValue.ToString());            
            kotaid = int.Parse(rddTujuan.SelectedValue.ToString());
            salesid = int.Parse(rddSales.SelectedValue.ToString());

            if (chkAntar.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                sopirid = int.Parse(rddSopir.SelectedValue.ToString());
                mobilid = int.Parse(rddMobil.SelectedValue.ToString());
                kernetid = int.Parse(rddKernet.SelectedValue.ToString());
            }
            else
            {
                sopir = txtSopir.Text;
                mobil = txtMobil.Text;
            }

            switch (rddTipe.Text.ToLower())
            {
                case "pelanggan":
                case "staff":
                case "pegawai":
                case "satpam":
                    custid = int.Parse(rddPel.SelectedValue.ToString());
                    custtypeid = int.Parse(rddPel.Tag.ToString());
                    break;
                case "sales":
                    custid = int.Parse(rddSales.SelectedValue.ToString());
                    custtypeid = int.Parse(rddPel.Tag.ToString());
                    break;
                case "contoh":
                    break;                
            }
            using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
            {
                //Always Create with status created
                iLogID = tbl.pInsertLogProd(tanggalDateTimePicker.Value
                                            , 0
                                            , kernetid
                                            , sopirid
                                            , mobilid
                                            , kotaid
                                            , salesid
                                            , mobil
                                            , sopir
                                            , keterangan
                                            , custid
                                            , custtypeid
                                            , transtypeid
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
                        , int.Parse(item.Cells["custtypetoid"].Value.ToString())
                        , int.Parse(item.Cells["custtypeid"].Value.ToString())
                        , int.Parse(item.Cells["status"].Value.ToString())
                        , item.Cells["keterangan"].Value.ToString()
                        , NBConfig.ValidUserName);
                }
            }

            RadMessageBox.Show("Data sudah terinput.", "SMS");

            //Print
            DialogResult res = RadMessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , RadMessageIcon.Question
                , MessageBoxDefaultButton.Button1);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                PrinterSettings printerSettings;
                ReportProcessor reportProcessor;

                rptSJ rpt = new rptSJ();
                rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                rpt.ReportParameters["logid"].Value = iLogID;
                //rpt.ReportParameters["custtypetoid"].Value = rddTipe.SelectedValue;

                IReportDocument iRpt = (IReportDocument)rpt;
                //// PrinterSettings 
                printerSettings = new PrinterSettings();
                //// Adjust the printer settings if necessary...
                InstanceReportSource reportSource = new InstanceReportSource();
                reportSource.ReportDocument = iRpt;
                // Print the report using the printer settings.
                reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(reportSource, printerSettings);

                using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
                {
                    tbl.UpdatePrinted(NBConfig.ValidUserName, long.Parse(iLogID));
                }
                helper.PrintLog(this.GetType().Name, rpt.Name, this.Text + ":LogID-" + iLogID );
            }
            else
            {
                MessageBox.Show("Surat Jalan ini dapat dilihat di daftar surat jalan yg belum di print.");
            }

        }

        #endregion
        

                
    }
}
