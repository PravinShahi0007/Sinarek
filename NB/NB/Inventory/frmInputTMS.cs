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
    public partial class frmInputTMS : RadForm
    {
        #region "Private Variables"
        private bool add_;
        private bool edit_;
        private bool delete_;
        private string custType_;
        private string transtypeid_;
        private bool isEdit_ = false;
        private DataRow editRow_;
        private int statusbarang_ = 1;
        private int parentid_ = -1;
        #endregion

        public frmInputTMS():this("Sisa Penjualan",true)
        {
            
        }

        public frmInputTMS(string sValue, bool bIsNew)
        {
            add_ = false;
            edit_ = false;
            delete_ = false;

            InitializeComponent();
            isEdit_ = (!bIsNew);
            custType_ = sValue;
            this.Text = sValue;
            switch (sValue.ToLower())
            {
                case "barang return": //Barang Produksi
                    custtypeBindingSource1.Filter = "custtypeid in (2)";
                    vproductbaseBindingSource.Filter = "tipeid = 1 and others = 0";
                    radGroupBox3.Visible = true;
                    break;
                case "botol kotor": //Botol Kotor
                    custtypeBindingSource1.Filter = "custtypeid in (1,2,3,4,5)";
                    vproductbaseBindingSource.Filter = "tipeid = 1 and others = 1";
                    rbtnRusak.Text = "Sumbing";
                    radGroupBox3.Visible = true;
                    break;
                case "transaksi masuk": //barang dari supplier
                    rddTipe.Enabled = false;
                    custtypeBindingSource1.Filter = "custtypeid = 18";
                    vproductbaseBindingSource.Filter = "tipeid not in (1,9)";
                    break;
                case "sisa penjualan":
                    rddTipe.Enabled = false;
                    custtypeBindingSource1.Filter = "custtypeid = 2";
                    vproductbaseBindingSource.Filter = "tipeid = 1 and others = 0";
                    break;
            }

            //InitializeButtons();
            //SetDefault();
        }

        #region "Control Events"
        private void Form_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            // TODO: This line of code loads data into the 'sinarekDataSet.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.sinarekDataSet.sales);
            this.vallsupTableAdapter.Fill(this.sinarekDataSet.vallsup);
            this.logdetailTableAdapter.Fill(this.sinarekDataSet.logdetail);
            this.logotherTableAdapter.Fill(this.sinarekDataSet.logother);
            this.supTableAdapter.Fill(this.sinarekDataSet.sup);
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.custtypeTableAdapter.Fill(this.sinarekDataSet.custtype);
            this.SetConditions();                    
           
            SetDefault();
            DataRow[] dr = this.sinarekDataSet.custtype.Select("name = 'sisa'");
            transtypeid_ = dr[0]["custtypeid"].ToString();
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MessageBox.Show("Jumlah barang harus lebih dari 0", "SMS - Error Notification");
                txtQuantity.Focus();
            }else if(dtpExpire.Value == null )
            {
                MessageBox.Show("Tanggal belum di input.", "SMS - Error Notification");
                dtpExpire.Focus();
            }
            else
            {
                GridViewRowInfo row = radGridView1.Rows.AddNew();
                row.Cells["productid"].Value = rddProduct.SelectedValue;
                row.Cells["custtypeid"].Value = transtypeid_;
                row.Cells["custtypetoid"].Value = rddProduct.Tag;
                row.Cells["keterangan"].Value = txtKeterangan.Text;
                row.Cells["quantity"].Value = txtQuantity.Text;
                row.Cells["expireddate"].Value = dtpExpire.Value;
                row.Cells["status"].Value = statusbarang_;
                                
                //reset fields
                rddProduct.ResetText();
                txtQuantity.ResetText();
                rddProduct.Focus();
                dtpExpire.ResetText();
                rbtnBaik.IsChecked = true;
                
                txtKeterangan.ResetText();
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
                dtpTanggal.Focus();
            }
        }
        private void rbtn_Changed(object sender, StateChangedEventArgs args)
        {
            RadRadioButton btn = (RadRadioButton)sender;
            switch (btn.Text.ToLower())
            {
                case "baik":
                    statusbarang_ = 1;
                    break;
                case "pecah":
                    statusbarang_ = 2;
                    break;
                case "rusak":
                    statusbarang_ = 3;
                    break;
                case "sumbing":
                    statusbarang_ = 4;
                    break;
                case "expire":
                    statusbarang_ = 5;
                    break;
            }
        }
        private void rddTipe_SelectedValueChanged(object sender, EventArgs e)
        {
            vallsupBindingSource.Filter = "custtypeid = " + rddTipe.SelectedValue.ToString();
        }
        private void rddProduct_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(!string.IsNullOrEmpty(rddProduct.Text))
            {
                RadListDataItem item = rddProduct.FindItemExact(rddProduct.Text, false);
                if (item == null)
                {
                    e.Cancel = true;
                }
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string logParentID = string.Empty;
            string salesname = string.Empty;
            List<String> basefilter =new List<String>();
            string filter ;
            long result;
            sinarekDataSet.vlogproductdetailDataTable dt = new sinarekDataSet.vlogproductdetailDataTable();
            //check if surat jalan exist and blum dikembalikan
            using (sinarekDataSetTableAdapters.vlogproductdetailTableAdapter tbl = new sinarekDataSetTableAdapters.vlogproductdetailTableAdapter())
            {
                result = long.Parse(tbl.pCheckSJBarangSisa(txtNoSJ.Text, NBConfig.ValidUserName).ToString());
                if (result > 0)
                {
                    tbl.FillByNoSJ(dt, txtNoSJ.Text);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            if (string.IsNullOrEmpty(logParentID))
                            {
                                logParentID = row["logid"].ToString();
                                salesname = row["salesname"].ToString();
                            }
                            DataRow[] res = this.sinarekDataSet.vproductbase.Select("baseid=" + row["baseid"].ToString());
                            foreach (DataRow resRow in res)
                            {
                                if (resRow["parentid"].ToString() != "-1")
                                {
                                    basefilter.Add(resRow["parentid"].ToString());
                                }
                            }
                            basefilter.Add(row["baseid"].ToString());
                        }
                        filter = String.Join(",", basefilter);
                        vproductbaseBindingSource.Filter = "baseid in (" + filter + ")";
                        
                        this.vlogproductdetailTableAdapter.FillByNoSJ(this.sinarekDataSet.vlogproductdetail, txtNoSJ.Text);

                        radGroupBox1.Enabled = true;
                        txtNoSJ.Enabled = false;
                        btnCheck.Enabled = false;
                        rddSup.FindItemExact(salesname, false).Selected = true;
                        parentid_ = int.Parse(logParentID);
                        dtpTanggal.Focus();

                    }
                    else
                    {
                        helper.ErrorMessage("Surat Jalan tidak ada di database");
                        txtSJ.SelectAll();
                    }

                }
                else
                {
                    if (result == -1)
                    {
                        helper.ErrorMessage("Barang sisa sudah terinput");
                    }
                    else if (result == -2)
                    {
                        helper.ErrorMessage("Ini Bukan Surat Jalan");
                    }
                    else
                    {
                        helper.ErrorMessage("Tidak Bisa Menginput sisa barang untuk surat jalan");
                    }
                    txtSJ.SelectAll();
                }
            }

        }

        #endregion

        #region "Methods"
        private void SetConditions()         
        {             
            //Pecah             
            ConditionalFormattingObject c1 = new ConditionalFormattingObject("Yellow, applied to entire row", ConditionTypes.Equal, "2", "", true);             
            c1.RowBackColor = Color.Yellow;
            c1.CellBackColor = Color.Yellow;             
            //c1.RowForeColor = Color.Black;             
            radGridView1.Columns["status"].ConditionalFormattingObjectList.Add(c1);
            //Rusak
            ConditionalFormattingObject c2 = new ConditionalFormattingObject("Green, applied to entire row", ConditionTypes.Equal, "3", "", true);             
            c2.RowBackColor = Color.Red;             
            //c2.RowForeColor = Color.Black;             
            c2.CellBackColor = Color.Red;
            radGridView1.Columns["status"].ConditionalFormattingObjectList.Add(c2);              
            ConditionalFormattingObject c3 = new ConditionalFormattingObject("Orange, applied to entire row", ConditionTypes.Equal, "5", "", true);
            c3.RowBackColor = Color.Orange;
            //c2.RowForeColor = Color.Black;             
            c3.CellBackColor = Color.Orange;
            radGridView1.Columns["status"].ConditionalFormattingObjectList.Add(c3);
            //update the grid view for the conditional formatting to take effect             
        }       
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            add_ = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "add");
            edit_ = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "edit");
            delete_ = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "delete");

            btnAdd.Enabled = (add_ || edit_);
            btnNext.Enabled = (add_ && (!isEdit_));
            if (isEdit_)
            {
                btnSimpan.Text = "Save Changes";
            }
            btnSimpan.Enabled = (add_ ||edit_);
            btnCheck.Enabled = (add_ ||edit_);

            dtpTanggal.Enabled = delete_;
        }
        private bool ValidateFields()
        {
            if (rddSup.SelectedValue == null)
            {
                MessageBox.Show("Silahkan pilih nama supplier barang!", "SMS - Validation Error");
                rddSup.Focus();
                return false;
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
            dtpTanggal.Value = DateTime.Now;
            rddSup.ResetText();
            rddProduct.ResetText();

            radGridView1.DataSource = null;
            radGridView1.Rows.Clear();

            parentid_ = -1;
        }
        private void SetDefault()
        {
            dtpTanggal.Value = DateTime.Now;

            string frmName = this.GetType().Name;
            bool delete = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "delete");
            if (!delete)
            {
                dtpTanggal.MaxDate = DateTime.Now.Date;
                dtpTanggal.MinDate = DateTime.Now.Date.AddDays(-1);
            }
            statusbarang_ = 1;

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
                , kotaid = -19
                , salesid = -1
                , custid = -1
                , custtypeid = -1;
            int paid = 0;

            custtypeid = 2;
            
            string[] sep = { "_" };
            custid = int.Parse(rddSup.SelectedValue.ToString().Split(sep, StringSplitOptions.RemoveEmptyEntries)[0]);                                    
            
            using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
            {
                //Always Create with status created
                iLogID = tbl.pInsertLogProdChild(dtpTanggal.Value
                                            , parentid_
                                            , 1
                                            , kernetid
                                            , sopirid
                                            , mobilid
                                            , kotaid
                                            , custid
                                            , mobil
                                            , sopir
                                            , keterangan
                                            , custid
                                            , custtypeid  
                                            , int.Parse(transtypeid_)                                                                                      
                                            , NBConfig.ValidUserName
                                            , StatusID, paid, 0).ToString();
            }

            custtypeid = int.Parse(rddSup.Tag.ToString());
            foreach (GridViewRowInfo item in radGridView1.Rows)
            {
                using (sinarekDataSetTableAdapters.logdetailTableAdapter tbl = new sinarekDataSetTableAdapters.logdetailTableAdapter())
                {
                    try
                    {
                        tbl.pInsertLogOther(int.Parse(iLogID)
                            , item.Cells["keterangan"].Value.ToString()
                            , (int.Parse(item.Cells["status"].Value.ToString()) == 5 ? 1 : 0)
                            , int.Parse(item.Cells["custtypeid"].Value.ToString())
                            , int.Parse(item.Cells["custtypetoid"].Value.ToString())
                            , null
                            , decimal.Parse(item.Cells["quantity"].Value.ToString())
                            , int.Parse(item.Cells["productid"].Value.ToString())
                            , int.Parse(item.Cells["status"].Value.ToString())
                            , 0
                            , NBConfig.ValidUserName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            MessageBox.Show("Data sudah terinput.", "SMS");

            //Print
            DialogResult res = RadMessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , RadMessageIcon.Question);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                PrinterSettings printerSettings;
                ReportProcessor reportProcessor;

                rptTM rpt = new rptTM();
                rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                rpt.ReportParameters["logid"].Value = iLogID;

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
                helper.PrintLog(this.GetType().Name, rpt.Name, this.Text + ":LogID-" + iLogID);
            }
            else
            {
                helper.NotifMessage("Transaksi masuk ini dapat dilihat di daftar transaksi yg belum di print.");
            }

        }
        #endregion





        
    }
}
