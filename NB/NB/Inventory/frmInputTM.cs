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
    public partial class frmInputTM : RadForm
    {
        #region "Private Variables"

        private bool isEdit_ = false;
        private bool add_;
        private bool edit_;
        private bool delete_;
        private DataRow editRow_;
        private int statusbarang_ = 1;
        private int category_ = 1;
        #endregion

        /// <summary>
        /// By Default Raw is chosen
        /// </summary>
        public frmInputTM():this(bIsNew:true)
        {
            
        }
        public frmInputTM(bool bIsNew)
        {
            add_ = false;
            edit_ = false;
            delete_ = false;

            InitializeComponent();
            isEdit_ = (!bIsNew);
            sinarekDataSet.tipeprodDataTable dt = new sinarekDataSet.tipeprodDataTable();
            using (sinarekDataSetTableAdapters.tipeprodTableAdapter tbl = new sinarekDataSetTableAdapters.tipeprodTableAdapter())
            {
                tbl.Fill(dt);
            }
            this.Text = "Transaksi Masuk";
            //vproductbaseBindingSource.Filter =

            
        }
        #region "Control Events"
        private void Form_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            this.vallsupTableAdapter.Fill(this.sinarekDataSet.vallsup);
            this.logdetailTableAdapter.Fill(this.sinarekDataSet.logdetail);
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.custtypeTableAdapter.Fill(this.sinarekDataSet.custtype);
            this.SetConditions();
            //Filter accordingly            
            vproductbaseBindingSource.Filter = "(systemonly = 0 and ((tipeid = 1 and others = 1) or tipeid <> 1))";
            if (!isEdit_)
            {
                SetDefault();
            }
            else
            {
                //LoadDataSJ(custType_);
            }
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
            }
            else
            {
                GridViewRowInfo row = radGridView1.Rows.AddNew();
                row.Cells["productid"].Value = rddProduct.SelectedValue;
                row.Cells["custtypeid"].Value = rddSup.Tag;
                row.Cells["keterangan"].Value = txtKeterangan.Text;
                row.Cells["quantity"].Value = txtQuantity.Text;
                row.Cells["custtypetoid"].Value = rddProduct.Tag;
                row.Cells["status"].Value = statusbarang_;
                row.Cells["harga"].Value = 0;
                                
                //reset fields
                rddProduct.ResetText();
                txtQuantity.ResetText();
                rddProduct.Focus();
                
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
                tanggalDateTimePicker.Focus();
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
            helper.GetPermissions(frmName, this.Tag.ToString(), out add_, out edit_, out delete_);

            btnAdd.Enabled = (add_ || delete_);
            btnNext.Enabled = (add_ && (!isEdit_));
            if (isEdit_)
            {
                btnSimpan.Text = "Save Changes";
            }
            btnSimpan.Enabled = (add_ || delete_);
        }

        private void LoadDataSJ(string NoSJ)
        {
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
            tanggalDateTimePicker.Value = DateTime.Now.Date;
            rddSup.ResetText();
            rddProduct.ResetText();

            radGridView1.DataSource = null;
            radGridView1.Rows.Clear();

            statusbarang_ = 1;
        }

        private void SetDefault()
        {
            tanggalDateTimePicker.Value = DateTime.Now;
            if (!delete_)
            {          
                tanggalDateTimePicker.MinDate = DateTime.Now.Date;
                tanggalDateTimePicker.MaxDate = DateTime.Now.Date.AddHours(23);
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
                , kotaid = -1
                , salesid = -1
                , custid = -1
                //, custtypetoid = -1
                , transtypeid = -1
                , custtypeid = -1;
            int paid = 0;

            //DataRow[] dr = this.sinarekDataSet.custtype.Select("name = 'gudang barang'");
            transtypeid = int.Parse(radGridView1.Rows[0].Cells["custtypeid"].Value.ToString());
            //dr = this.sinarekDataSet.custtype.Select("name = 'supplier'");
            custtypeid = int.Parse(rddSup.Tag.ToString());
            mobil = txtAntar.Text;

            string[] sep = { "_" };
            custid = int.Parse(rddSup.SelectedValue.ToString().Split(sep, StringSplitOptions.RemoveEmptyEntries)[0]);                                    
            
            using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
            {
                //Always Create with status created
                iLogID = tbl.pInsertLogProd(tanggalDateTimePicker.Value
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

            foreach (GridViewRowInfo item in radGridView1.Rows)
            {
                using (sinarekDataSetTableAdapters.logdetailTableAdapter tbl = new sinarekDataSetTableAdapters.logdetailTableAdapter())
                {
                    try
                    {
                        tbl.pInsertLogOther(int.Parse(iLogID)
                            , item.Cells["keterangan"].Value.ToString()
                            , 0
                            , int.Parse(item.Cells["custtypeid"].Value.ToString())
                            , int.Parse(item.Cells["custtypetoid"].Value.ToString())
                            , null
                            , decimal.Parse(item.Cells["quantity"].Value.ToString())
                            , int.Parse(item.Cells["productid"].Value.ToString())
                            , int.Parse(item.Cells["status"].Value.ToString())
                            , decimal.Parse(item.Cells["harga"].Value.ToString())
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
                reportSource.ReportDocument = rpt;
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
        private void SaveEditItem(short StatusID, bool print)
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
                , custid = -1;            
            short custtypetoid = -1
                , custtypeid = -1;
            int paid = 0;

            DataRow[] dr = this.sinarekDataSet.custtype.Select("name = 'gudang barang'");
            custtypetoid = short.Parse(dr[0]["custtypeid"].ToString());
            dr = this.sinarekDataSet.custtype.Select("name = 'supplier'");
            custtypeid = short.Parse(dr[0]["custtypeid"].ToString());
            string[] sep = { "_" };

            custid = int.Parse(rddSup.SelectedValue.ToString().Split(sep, StringSplitOptions.RemoveEmptyEntries)[0]);

            using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
            {
                //Always Create with status created
                iLogID = tbl.pInsertLogProd(tanggalDateTimePicker.Value
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
                                            , custtypetoid
                                            , custtypetoid
                                            , NBConfig.ValidUserName
                                            , StatusID, paid, 0).ToString();
            }

            foreach (GridViewRowInfo item in radGridView1.Rows)
            {
                using (sinarekDataSetTableAdapters.logotherTableAdapter tbl = new sinarekDataSetTableAdapters.logotherTableAdapter())
                {
                    try
                    {
                        tbl.InsertLogOtherDetail(int.Parse(iLogID)
                            , item.Cells["keterangan"].Value.ToString()
                            , 0
                            , custtypeid
                            , null
                            , decimal.Parse(item.Cells["quantity"].Value.ToString())
                            , int.Parse(item.Cells["productid"].Value.ToString())
                            , decimal.Parse(item.Cells["harga"].Value.ToString())
                            , NBConfig.ValidUserName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            helper.NotifMessage("Data sudah terinput.\nTransaksi masuk ini dapat dilihat di daftar transaksi yg belum di print.");
        }
        #endregion

        private void rddTipe_SelectedValueChanged(object sender, EventArgs e)
        {
                    
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



        
    }
}
