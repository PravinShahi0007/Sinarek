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
    public partial class frmInputTMR : RadForm
    {
        #region "Private Variables"
        private bool add_;
        private bool edit_;
        private bool delete_;
        private string custType_;
        private bool isEdit_ = false;
        private DataRow editRow_;
        private int statusbarang_ = 1;

        #endregion

        public frmInputTMR():this("Barang Return",true)
        {
            
        }

        public frmInputTMR(string sValue, bool bIsNew)
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
                    //custtypeBindingSource1.Filter = "custtypeid in (2)";
                    vallsupBindingSource.Filter = "custtypeid in (2)";
                    vproductbaseBindingSource.Filter = "tipeid = 1 and others = 0";
                    radGroupBox3.Visible = true;
                    break;
                case "botol kotor": //Botol Kotor
                    vproductbaseBindingSource.Filter = "tipeid = 1 and others = 1";
                    vallsupBindingSource.Filter = "custtypeid in (1,2)";
                    radGridView1.Columns["expireddate"].IsVisible = false;
                    rbtnRusak.Text = "Sumbing";
                    rbtnExpire.Visible = false;
                    radGroupBox3.Visible = true;
                    dtpExpire.Visible = false;
                    lblTanggal.Visible = false;
                    break;                
            }
            //if editing
            if (isEdit_)
            {
                this.Text = "Transaksi No - " + sValue;
            }

            //InitializeButtons();
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
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Jumlah barang harus lebih dari 0", "SMS - Error Notification");
                txtQuantity.Focus();
            }else if(string.IsNullOrEmpty(dtpExpire.Text) )
            {
                MessageBox.Show("Tanggal belum di input.", "SMS - Error Notification");
                dtpExpire.Focus();
            }
            else
            {
                GridViewRowInfo row = radGridView1.Rows.AddNew();
                row.Cells["productid"].Value = rddProduct.SelectedValue;
                row.Cells["custtypeid"].Value = rddProduct.Tag;
                row.Cells["custtypetoid"].Value = rddProduct.Tag;
                row.Cells["keterangan"].Value = txtKeterangan.Text;
                row.Cells["quantity"].Value = txtQuantity.Text;
                row.Cells["expireddate"].Value = dtpExpire.Value;
                
                row.Cells["status"].Value = statusbarang_;
                                
                //reset fields
                rddProduct.ResetText();
                txtQuantity.ResetText();
                rddProduct.Focus();
                dtpExpire.Value = DateTime.Now;
                rbtnBaik.IsChecked = true;
                
                txtKeterangan.ResetText();
            }
        }

        private void btnCancelSJ_Click(object sender, EventArgs e)
        {
            //Input alasan untuk membatalkan
            //Save batal and print surat jalan yg telah dibatalkan
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
            if (btn.IsChecked)
            {
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

        #endregion

        #region "Methods"                     
        private void SetConditions()
        {             
            //Pecah
            ConditionalFormattingObject c2 = new ConditionalFormattingObject("Light Sea Green, applied to entire row", ConditionTypes.Equal, "2", "", true);
            c2.RowBackColor = Color.LightSeaGreen;
            radGridView1.Columns["status"].ConditionalFormattingObjectList.Add(c2);
            //Rusak
            ConditionalFormattingObject c3 = new ConditionalFormattingObject("Light Yellow, applied to entire row", ConditionTypes.Equal, "3", "", true);
            c3.RowBackColor = Color.LightSteelBlue;
            radGridView1.Columns["status"].ConditionalFormattingObjectList.Add(c3);
            //Sumbing
            ConditionalFormattingObject c4 = new ConditionalFormattingObject("Corn Flower Blue, applied to entire row", ConditionTypes.Equal, "4", "", true);
            c4.RowBackColor = Color.CornflowerBlue;
            radGridView1.Columns["status"].ConditionalFormattingObjectList.Add(c4); 
            //Expire
            ConditionalFormattingObject c5 = new ConditionalFormattingObject("Purple, applied to entire row", ConditionTypes.Equal, "5", "", true);
            c5.RowBackColor = Color.MediumPurple;
            radGridView1.Columns["status"].ConditionalFormattingObjectList.Add(c5);             
        }       
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            add_ = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "add");
            edit_ = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "edit");
            delete_ = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "delete");

            btnAdd.Enabled = (add_ || edit_);
            btnNext.Enabled = (add_ && (!isEdit_));
            if (isEdit_)
            {
                btnSimpan.Text = "Save Changes";
            }
            btnSimpan.Enabled = (add_ ||edit_);
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

            rbtnBaik.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            rbtnExpire.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            rbtnRusak.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            dtpExpire.Value = DateTime.Now;

            statusbarang_ = 1;
        }
        private void SetDefault()
        {
            dtpTanggal.Value = DateTime.Now;
            dtpExpire.Value = DateTime.Now;
            string frmName = this.GetType().Name;
            bool delete = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "delete");
            if (!delete)
            {
                dtpTanggal.MinDate = DateTime.Now.Date;
                dtpTanggal.MaxDate = DateTime.Now.Date;
            }

            rbtnBaik.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            rbtnExpire.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            rbtnRusak.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
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
                , kotaid = -1
                , salesid = -1
                , custid = -1
                //, custtypetoid = -1
                ,transtypeid = -1
                , custtypeid = -1;
            int paid = 0;
            string[] sep = { "_" };
            custid = int.Parse(rddSup.SelectedValue.ToString().Split(sep, StringSplitOptions.RemoveEmptyEntries)[0]);
            custtypeid = int.Parse(rddSup.Tag.ToString());
                       
            if (custType_ == "Barang Return")
            {
                DataRow[] dr = this.sinarekDataSet.custtype.Select("name = 'return'");
                transtypeid = int.Parse(dr[0]["custtypeid"].ToString());
                
                //dr = this.sinarekDataSet.custtype.Select("name = 'supplier'");
                salesid = custid;
            }
            else
            {
                transtypeid = custtypeid;
            }
            
            
            using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
            {
                //Always Create with status created
                iLogID = tbl.pInsertLogProd(dtpTanggal.Value
                                            , 1
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
                            , transtypeid
                            , int.Parse(item.Cells["custtypetoid"].Value.ToString())
                            , DateTime.Parse(item.Cells["expireddate"].Value.ToString())
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
            DialogResult res = MessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question);
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
            }
            else
            {
                MessageBox.Show("Transaksi masuk ini dapat dilihat di daftar transaksi yg belum di print.");
            }

        }
        #endregion
    
    }
}
