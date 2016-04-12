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
    public partial class frmInputIntern : RadForm
    {
        #region "Private Variables"

        private string custType_;
        private bool isEdit_ = false;
        private DataRow editRow_;
        private int statusbarang_ = 1;
        private int category_ = 0;

        #endregion

        public frmInputIntern():this("Barang Pecah",true)
        {
            
        }

        public frmInputIntern(string sValue, bool bIsNew)
        {
            InitializeComponent();
            isEdit_ = (!bIsNew);
            this.Text = sValue;
            vproductbaseBindingSource.Filter = "tipeid = 1 and goods = 0 and others = 0";            

            //if editing
            if (isEdit_)
            {
                this.Text = "Transaksi No - " + sValue;
            }
            else
            {
                radGroupBox3.Enabled = false;
                rddSup.Enabled = false;
                switch (sValue.ToLower())
                {
                    case "barang pecah":
                        category_ = 0;
                        custType_ = "pecah";
                        radGroupBox3.Enabled = true;
                        break;
                    case "masuk produksi":
                        category_ = 1;
                        custType_ = "produksi";
                        break;
                    case "pindah barang":
                        category_ = 0;
                        custType_ = "pindah";
                        vproductbaseBindingSource.Filter = "tipeid = 1 and goods = 1 and parentid <> -1 and others = 0";     
                        break; 
                    case "barang jadi":
                        category_ = 1;
                        custType_ = "jadi";
                        vproductbaseBindingSource.Filter = "tipeid = 1 and goods = 1 and others = 0";     
                        break;
                    case "pakai barang":
                        rddSup.Enabled = true;
                        rddSup.DataSource = vallsupBindingSource;
                        category_ = 0;
                        custType_ = "pakai";
                        vproductbaseBindingSource.Filter = "(systemonly = 0 and ((tipeid = 1 and others = 1) or tipeid <> 1))";
                        break;
                }
            }
        }

        #region "Control Events"
        private void Form_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            // TODO: This line of code loads data into the 'sinarekDataSet.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.sinarekDataSet.sales);
            this.vallsupTableAdapter.Fill(this.sinarekDataSet.vallsup);
            this.logdetailTableAdapter.Fill(this.sinarekDataSet.logdetail);
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.custtypeTableAdapter.Fill(this.sinarekDataSet.custtype);
            this.SetConditions();                      
            
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
                DataRow[] dr = this.sinarekDataSet.custtype.Select("name = '" + custType_ + "'");
                int transtypeid = int.Parse(dr[0]["custtypeid"].ToString());

                GridViewRowInfo row = radGridView1.Rows.AddNew();
                row.Cells["productid"].Value = rddProduct.SelectedValue;
                if (category_ == 0)
                {
                    row.Cells["custtypetoid"].Value = transtypeid;
                    row.Cells["custtypeid"].Value = rddProduct.Tag;

                }
                else
                {
                    row.Cells["custtypeid"].Value = transtypeid;
                    row.Cells["custtypetoid"].Value = rddProduct.Tag;
                }
                row.Cells["keterangan"].Value = txtKeterangan.Text;
                row.Cells["quantity"].Value = txtQuantity.Text;
                
                row.Cells["status"].Value = statusbarang_;
                                
                //reset fields
                rddProduct.ResetText();
                txtQuantity.ResetText();
                rddProduct.Focus();
                rbtnBorongan.IsChecked = true;
                
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
                switch (btn.Text.ToLower().Replace("pecah","").Trim())
                {                    
                    case "mesin":
                        statusbarang_ = 6;
                        break;
                    case "borongan":
                        statusbarang_ = 7;
                        break;
                    case "meja":
                        statusbarang_ = 8;
                        break;
                    default:
                        statusbarang_ = 1;
                        break;
                }
            }
        }

        #endregion

        #region "Methods"                     
        private void SetConditions()
        {             
            //Mesin
            ConditionalFormattingObject c2 = new ConditionalFormattingObject("Light Sea Green, applied to entire row", ConditionTypes.Equal, "6", "", true);
            c2.RowBackColor = Color.LightSeaGreen;
            radGridView1.Columns["status"].ConditionalFormattingObjectList.Add(c2);
            //Borongan
            ConditionalFormattingObject c3 = new ConditionalFormattingObject("Light Yellow, applied to entire row", ConditionTypes.Equal, "7", "", true);
            c3.RowBackColor = Color.LightSteelBlue;
            radGridView1.Columns["status"].ConditionalFormattingObjectList.Add(c3);
            //Meja
            ConditionalFormattingObject c4 = new ConditionalFormattingObject("Corn Flower Blue, applied to entire row", ConditionTypes.Equal, "8", "", true);
            c4.RowBackColor = Color.CornflowerBlue;
            radGridView1.Columns["status"].ConditionalFormattingObjectList.Add(c4); 
                        
        }       
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            bool add = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "add");
            bool edit = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "edit");
            bool delete = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "delete");

            btnAdd.Enabled = (add || edit);
            btnNext.Enabled = (add && (!isEdit_));
            if (isEdit_)
            {
                btnSimpan.Text = "Save Changes";
            }
            btnSimpan.Enabled = (add ||edit);
            btnCancelSJ.Enabled = delete;
        }
        private bool ValidateFields()
        {
            
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
            dtpTanggal.Value = DateTime.Now.Date;
            rddSup.ResetText();
            rddProduct.ResetText();

            radGridView1.DataSource = null;
            radGridView1.Rows.Clear();

            rbtnBorongan.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            rbtnMeja.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            rbtnMesin.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            statusbarang_ = 1;
        }
        private void SetDefault()
        {
            dtpTanggal.Value = DateTime.Now;

            string frmName = this.GetType().Name;
            bool delete = NBConfig.CheckPermission((this.Tag != null? this.Tag.ToString():""), frmName, "delete");
            if (!delete)
            {
                dtpTanggal.MinDate = DateTime.Now.Date;
                dtpTanggal.MaxDate = DateTime.Now.Date;
            }

            if (custType_ == "pecah")
            {
                radGroupBox3.Visible = true;
                rbtnMesin.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
                rbtnBorongan.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                rbtnMeja.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
                statusbarang_ = 7;
            }
            else
            {
                statusbarang_ = 1;
            }

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

            DataRow[] dr = this.sinarekDataSet.custtype.Select("name = '" + custType_ + "'");
            transtypeid = int.Parse(dr[0]["custtypeid"].ToString());
            if (custType_ == "pakai")
            {
                custid = int.Parse(rddSup.SelectedValue.ToString());
                custtypeid = int.Parse(rddSup.Tag.ToString());
            }
            
            //dr = this.sinarekDataSet.custtype.Select("name = 'supplier'");                        
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

            //custtypeid = int.Parse(rddSup.Tag.ToString());
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

            helper.NotifMessage("Data sudah terinput.\nTransaksi masuk ini dapat dilihat di daftar transaksi yg belum di print.");

        }
        #endregion
        
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

        private void radGridView1_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove || e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (GridViewRowInfo row in radGridView1.Rows)
                {
                    row.Cells["NoRow"].Value = row.Index + 1;
                }
            }
        }



        
    }
}
