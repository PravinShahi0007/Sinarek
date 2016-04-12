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
    public partial class frmEditSJ : RadForm
    {
        #region "Private Variables"
        private long logid_;
        private string custType_;
        private bool isEdit_ = false;
        private bool diAntar_ = false;
        private bool add_, edit_, delete_;
        private DataRow editRow_;
        
        #endregion

        public frmEditSJ(DataRow EditRow)
        {
            InitializeComponent();
            add_ = false;
            edit_ = false;
            delete_ = false;

            editRow_ = EditRow;

            isEdit_ = true;
            //if editing
            if (isEdit_)
            {
                this.Text = "Surat Jalan - " + editRow_["NOSJ"].ToString();
                btnSimpan.Text = "&Simpan";
            }            
        }

        #region "Control Events"
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            this.vallsupTableAdapter.Fill(this.sinarekDataSet.vallsup);
            this.sopirTableAdapter.Fill(this.sinarekDataSet.sopir);
            this.kernetTableAdapter.Fill(this.sinarekDataSet.kernet);
            this.salesTableAdapter.Fill(this.sinarekDataSet.sales);
            this.mobilTableAdapter.Fill(this.sinarekDataSet.mobil);
            this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.custtypeTableAdapter.Fill(this.sinarekDataSet.custtype);

            LoadDataSJ();
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
                row.Cells["detailid"].Value = -1;
                row.Cells["productid"].Value = rddProduct.SelectedValue;
                row.Cells["quantity"].Value = txtQuantity.Text;
                row.Cells["custtypeid"].Value = rddProduct.Tag.ToString();
                row.Cells["custtypetoid"].Value = rddTipe.SelectedValue.ToString();
                row.Cells["status"].Value = 1;
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
            if ((e.Action == NotifyCollectionChangedAction.Add) 
                || (e.Action == NotifyCollectionChangedAction.Remove)
                || (e.Action == NotifyCollectionChangedAction.Reset)
                )
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
        private void radGridView1_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.ToLower() == "productid")
            {
                //GridViewEditManager mng = (GridViewEditManager)sender;
                ////GridComboBoxCellElement cell = (GridComboBoxCellElement)mng.ActiveEditor;
                //RadDropDownListEditor rdd = (RadDropDownListEditor)mng.GridViewElement.CurrentCell.Editor;
                //RadDropDownListEditorElement el = (RadDropDownListEditorElement)rdd.EditorElement;
                              
            }
        }
        private void radGridView1_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.ToLower() == "productid")
            {
                RadDropDownListEditor rdd = (RadDropDownListEditor)e.ActiveEditor;
                //rdd.OnValueChanged += 
                RadDropDownListEditorElement el = (RadDropDownListEditorElement)rdd.EditorElement;
                el.ValueChanged += new EventHandler(rddEdit_SelectedValueChanged);
            }
        }
        private void rddEdit_SelectedValueChanged(object sender, EventArgs e)
        {

            RadDropDownListEditorElement rdd = (RadDropDownListEditorElement)sender;
            if (rdd.SelectedItem != null)
            {
                DataRowView data = (DataRowView)rdd.SelectedItem.DataBoundItem;
                radGridView1.CurrentCell.RowInfo.Cells["custtypeid"].Value = data.Row["custtypeid"];
            }
        }
        
        #endregion

        #region "Methods"
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            frmLihatSJ frm = (frmLihatSJ)this.Owner;
            frm.GetPermissions(out add_, out edit_, out delete_);            
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
            rddTipe.Enabled = delete_;
            rddPel.Enabled = delete_;
            rddSales.Enabled = delete_;
            tanggalDateTimePicker.Enabled = delete_;
            if (DateTime.Parse(editRow_["created"].ToString()).Date != DateTime.Now.Date)
            {
                rddKernet.Enabled = ((edit_ || delete_) && chkAntar.Checked);
                rddSopir.Enabled = ((edit_ || delete_) && chkAntar.Checked);
                rddMobil.Enabled = ((edit_ || delete_) && chkAntar.Checked);
                txtMobil.Enabled = ((edit_ || delete_) && (!chkAntar.Checked));
                txtSopir.Enabled = ((edit_ || delete_) && (!chkAntar.Checked));
                radGridView1.AllowEditRow = (edit_ || delete_);
            }
            else
            {
                if (bool.Parse(editRow_["Printed"].ToString()))
                {
                    rddKernet.Enabled = ((edit_ || delete_) && chkAntar.Checked);
                    rddSopir.Enabled = ((edit_ || delete_) && chkAntar.Checked);
                    rddMobil.Enabled = ((edit_ || delete_) && chkAntar.Checked);
                    txtMobil.Enabled = ((edit_ || delete_) && (!chkAntar.Checked));
                    txtSopir.Enabled = ((edit_ || delete_) && (!chkAntar.Checked));
                    radGridView1.AllowEditRow = (edit_ || delete_);
                }
                else
                {
                    rddKernet.Enabled = ((add_ || edit_ || delete_) && chkAntar.Checked);
                    rddSopir.Enabled = ((add_ || edit_ || delete_) && chkAntar.Checked);
                    rddMobil.Enabled = ((add_ || edit_ || delete_) && chkAntar.Checked);
                    txtMobil.Enabled = ((add_ || edit_ || delete_) && (!chkAntar.Checked));
                    txtSopir.Enabled = ((add_ || edit_ || delete_) && (!chkAntar.Checked));
                    radGridView1.AllowEditRow = (add_ || edit_ || delete_);
                }
            }
        }       
        private void SaveEditItem()
        {
            string mobil = string.Empty
                , sopir = string.Empty
                , keterangan = null;
            int kernetid = -1
                ,custid  = -1
                , sopirid = -1
                , mobilid = -1
                , kotaid = -1
                , salesid = -1
                , custtypeid = -1
                , transtypeid = -1;

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
                    custid = int.Parse(rddPel.SelectedValue.ToString());
                    custtypeid = int.Parse(rddPel.Tag.ToString());
                    break;
                case "sales":
                    custid = int.Parse(rddSales.SelectedValue.ToString());
                    custtypeid = 2;
                    break;
                case "staff":
                case "satpam":
                case "pegawai":
                    custid = int.Parse(rddPel.SelectedValue.ToString());
                    custtypeid = int.Parse(rddPel.Tag.ToString());
                    break;
                case "contoh":
                    break;
            }
            using (sinarekDataSetTableAdapters.logproductTableAdapter tbl = new sinarekDataSetTableAdapters.logproductTableAdapter())
            {
                //Update SJ
                tbl.UpdateSJ(tanggalDateTimePicker.Value
                                , transtypeid
                                , custtypeid
                                , custid
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
            try
            {
                //logdetailTableAdapter.Update(this.sinarekDataSet.logdetail);
                //insert new records
                using (sinarekDataSetTableAdapters.logdetailTableAdapter tbl = new sinarekDataSetTableAdapters.logdetailTableAdapter())
                {
                    foreach (GridViewRowInfo item in radGridView1.Rows)
                    {
                        if (item.Cells["detailid"].Value.ToString() == "-1")
                        {
                            tbl.pInsertLogDetail(int.Parse(logid_.ToString())
                                , int.Parse(item.Cells["productid"].Value.ToString())
                                , decimal.Parse(item.Cells["quantity"].Value.ToString())
                                , int.Parse(item.Cells["custtypetoid"].Value.ToString())
                                , int.Parse(item.Cells["custtypeid"].Value.ToString())
                                , int.Parse(item.Cells["status"].Value.ToString())
                                , (item.Cells["keterangan"].Value == null ? "" : item.Cells["keterangan"].Value.ToString())
                                , NBConfig.ValidUserName);
                        }
                        else
                        {
                            tbl.UpdateItem(int.Parse(item.Cells["productid"].Value.ToString())
                                , int.Parse(item.Cells["custtypeid"].Value.ToString())
                                , int.Parse(item.Cells["custtypetoid"].Value.ToString())
                                , (item.Cells["keterangan"].Value == null ? "" : item.Cells["keterangan"].Value.ToString())
                                , decimal.Parse(item.Cells["quantity"].Value.ToString())
                                , NBConfig.ValidUserName, long.Parse(item.Cells["detailid"].Value.ToString()));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
            helper.NotifMessage("SJ sudah tersimpan!");
        }
        private void LoadDataSJ()
        {
            txtSJ.Text = editRow_["NOSJ"].ToString();
            string transtypeid = editRow_["transtypeid"].ToString();
            logid_ = long.Parse(editRow_["logid"].ToString());

            if (int.Parse(rddTipe.SelectedValue.ToString()) == int.Parse(transtypeid))
            {
                rddTipe_SelectedValueChanged(rddTipe, new EventArgs());
            }
            else
            {
                rddTipe.SelectedValue = int.Parse(transtypeid);
            }
            rddTujuan.FindItemExact(editRow_["tujuan"].ToString(), false).Selected = true;

            tanggalDateTimePicker.Value = DateTime.Parse(editRow_["tanggal"].ToString());
            if (editRow_["sopirid"].ToString() != "-1")
            {
                chkAntar.Checked = true;
                chkAntar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                rddSopir.FindItemExact(editRow_["sopirname"].ToString(), false).Selected = true;
                rddMobil.FindItemExact(editRow_["mobilname"].ToString(), false).Selected = true;
                rddKernet.FindItemExact(editRow_["kernetname"].ToString(), false).Selected = true;
            }
            else
            {
                chkAntar.Checked = false;
                chkAntar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
                txtMobil.Text = editRow_["mobil"].ToString();
                txtSopir.Text = editRow_["sopir"].ToString();
            }

            switch (rddTipe.Text.ToLower())
            {
                case "pelanggan":
                    rddPel.SelectedValue = int.Parse(editRow_["custid"].ToString());
                    rddSales.FindItemExact(editRow_["SalesShort"].ToString(), false).Selected = true;                   
                    break;
                case "sales":
                    rddSales.FindItemExact(editRow_["SalesShort"].ToString(), false).Selected = true;
                    break;
                case "staff":
                case "satpam":
                case "pegawai":
                    rddSales.FindItemExact(editRow_["SalesShort"].ToString(), false).Selected = true;
                    if (!string.IsNullOrEmpty(editRow_["CustName"].ToString()))
                    {
                        rddPel.FindItemExact(editRow_["CustName"].ToString(), false).Selected = true;
                    }
                    break;
                case "contoh":
                    break;
            }

            //Load Product
            radGridView1.DataSource = null;
            logdetailTableAdapter.FillBySJ(this.sinarekDataSet.logdetail, long.Parse(editRow_["logid"].ToString()));
            foreach (DataRow row in this.sinarekDataSet.logdetail.Rows)
            {
                GridViewRowInfo dtrow = radGridView1.Rows.AddNew();
                dtrow.Cells["detailid"].Value = row["detailid"];
                dtrow.Cells["productid"].Value = row["baseid"];
                dtrow.Cells["quantity"].Value = row["quantity"];
                dtrow.Cells["custtypeid"].Value = row["custtypeid"];
                dtrow.Cells["custtypetoid"].Value = row["custtypetoid"];
                dtrow.Cells["status"].Value = row["status"];
                dtrow.Cells["keterangan"].Value = row["keterangan"];
            }
        }
        #endregion

        private void radGridView1_UserDeletingRow(object sender, GridViewRowCancelEventArgs e)
        {
            GridViewRowInfo row = e.Rows[0];
            //Print
            DialogResult res = RadMessageBox.Show("Data akan terhapus? Pilih [Cancel] untuk membatalkan penghapusan.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , RadMessageIcon.Question
                , MessageBoxDefaultButton.Button2);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                logdetailTableAdapter.DeleteItem(long.Parse(row.Cells["detailid"].Value.ToString()));
            }
            else
            {
                e.Cancel = true;
            }
            
        }
                
    }
}
