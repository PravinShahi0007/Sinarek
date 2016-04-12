using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.IO;
using NB.sinarekDataSetTableAdapters;
using NB;

namespace NB
{
    public partial class frmBorongan : Telerik.WinControls.UI.RadForm
    {
        #region Variables
        private bool add_ = false;
        private bool edit_ = false;
        private bool delete_ = false;
        #endregion


        #region Fields
        //TableViewDefinition tableView;         
        //ColumnGroupsViewDefinition columnGroupsView;         
        HtmlViewDefinition htmlView;          
        #endregion
        private int _iBoronganID = 0;

        public frmBorongan()
        {
            InitializeComponent();          

            // html view             
            this.htmlView = new HtmlViewDefinition();             
            this.htmlView.RowTemplate.Rows.Add(new RowDefinition(25));
            this.htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("Nama"));
            this.htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("MulaiBorongan"));
            this.htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("SelesaiBorongan"));
            this.htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("TipeBorongan"));
            this.htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("HasilBorongan"));            
            this.htmlView.RowTemplate.Rows.Add(new RowDefinition(25));
            this.htmlView.RowTemplate.Rows[1].Cells.Add(new CellDefinition("JumlahOrang"));
            this.htmlView.RowTemplate.Rows[1].Cells.Add(new CellDefinition("Jam"));
            this.htmlView.RowTemplate.Rows[1].Cells[1].ColSpan = 2;
            this.htmlView.RowTemplate.Rows[1].Cells.Add(new CellDefinition("Pecah"));
            this.htmlView.RowTemplate.Rows[1].Cells.Add(new CellDefinition("Peti"));
            this.htmlView.RowTemplate.Rows.Add(new RowDefinition(30));
            this.htmlView.RowTemplate.Rows[2].Cells.Add(new CellDefinition("nopeti"));
            this.htmlView.RowTemplate.Rows[2].Cells[0].ColSpan = 5;

            this.radGridView1.ViewDefinition = htmlView;
            //this.radGridView1.Columns["nopeti"].
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
            this.radGridView1.TableElement.RowSpacing = 5; 

            //default tgl value
            dtPilihTanggal.Value = DateTime.Now;

            //Potongan Total Info
            //Add Total info Hasil Borongan
            //this.radGridView4.GroupDescriptors[0].Aggregates.Add("sum(iif(trim(tipeborongan) = 'PB',hasilborongan,0))");
            //this.radGridView4.GroupDescriptors[0].Aggregates.Add("sum(iif(trim(tipeborongan) = 'LB2',hasilborongan,0))");
            //this.radGridView4.GroupDescriptors[0].Aggregates.Add("sum(iif(trim(tipeborongan) = 'LB3',hasilborongan,0))");
            //this.radGridView4.GroupDescriptors[0].Aggregates.Add("sum(iif(trim(tipeborongan) = 'LK2',hasilborongan,0))");
            //this.radGridView4.GroupDescriptors[0].Aggregates.Add("sum(iif(trim(tipeborongan) = 'LK3',hasilborongan,0))");
            //this.radGridView4.GroupDescriptors[0].Aggregates.Add("sum(iif(trim(tipeborongan) = 'TB',hasilborongan,0))");
            //this.radGridView4.GroupDescriptors[0].Format = @"{1:dd MMM yyy} [PB - {2:#,###.##}] [LB2 - {3:#,###.##}] [LB3 - {4:#,###.##}] [LK2 - {5:#,###.##}] [LK3 - {6:#,###.##}] [TB - {7:#,###.##}]";
            //this.radGridView4.GroupDescriptors[0].Format = @"{1:dd MMM yyy} [PB - {2:}] [LB2 - {3}] [LB3 - {4}] [LK2 - {5}] [LK3 - {6}] [TB - {7}]";
            
            //Add Total Info Potongan
            this.radGridView5.GroupDescriptors[0].Aggregates.Add("sum(jamhitung * gajiperjam)");
            this.radGridView5.GroupDescriptors[0].Format = @"{1} - {2:Rp #,###.00}";
        }

        private void frmBorongan_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            this.memberTableAdapter.Fill(this.sinarekDataSet.member);
            this.vproductbaseTableAdapter.Fill(this.sinarekDataSet.vproductbase);
            this.vboronganallTableAdapter.Fill(this.sinarekDataSet.vboronganall, NBConfig.IGMID);
            //this.vboronganallTableAdapter.Fill(this.sinarekDataSet.vboronganall, 28);
            ResetInputForm();
        }
        #region Methods
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            helper.GetPermissions(frmName, this.Tag.ToString(), out add_, out edit_, out delete_);
            
            foreach (Control ctrl in radPanel1.Controls)
            {
                if (ctrl is RadButton)
                {
                    RadButton btn = (RadButton)ctrl;
                    switch (btn.Tag.ToString())
                    {
                        case "add":
                            btn.Visible = (add_ || delete_);
                            btn.Enabled = (add_ || delete_);
                            break;
                        case "edit":
                            btn.Visible = (edit_ || delete_);
                            btn.Enabled = (edit_ || delete_);
                            break;
                        case "delete":
                            btn.Visible = delete_;
                            btn.Enabled = delete_;
                            break;
                    }
                }
            }
        }
        
        private bool ValidateForm()
        {
            bool bValid = false;
            //Tanggal
            if (!cValidation.ValidDate(txtTanggal.Text))
            {
                MessageBox.Show("Tanggal out of range!");
                txtTanggal.Focus();
                return bValid;
            }
            //Jam Mulai and selesai
            if (TimeSpan.Parse(txtMulai.Text) >= TimeSpan.Parse(txtSelesai.Text))
            {
                MessageBox.Show("Jam Selesai Borongan harus diatas jam mulai borongan!");
                txtMulai.Focus();
                return bValid;
            }
            //nama
            if (radGridView2.Rows.Count < 1)
            {
                MessageBox.Show("Anda belum menginput nama buruh yang borongan!");

                rddNama.Focus();
                return bValid;
            }
            //jumlah
            if (decimal.Parse(txtJumlah.Text) <= 0)
            {
                MessageBox.Show("Anda belum menginput jumlah hasil borongan!");
                txtJumlah.Focus();
                return bValid;
            }
            //tipe
            if (string.IsNullOrEmpty(rddTipe.Text))
            {
                MessageBox.Show("Anda belum menginput tipe borongan!");
                rddTipe.Focus();
                return bValid;
            }
            //no peti
            decimal noPeti = (decimal.Parse(txtJumlah.Text) / 25);
            noPeti = Math.Round(noPeti);
            int iPeti = int.Parse(noPeti.ToString());
            if (lstNoPeti.Items.Count != int.Parse(noPeti.ToString()))
            {
                int iJum = lstNoPeti.Items.Count;
                if (iJum > iPeti)
                {
                    MessageBox.Show("Jumlah peti yang di input terlalu banyak.\n Kelebihan peti akan dihapus!");
                    for (int i = iPeti; i < iJum; i++)
                    {
                        lstNoPeti.Items.RemoveAt(i - 1);
                    }
                }
                else
                {
                    MessageBox.Show("Jumlah peti yang di input tidak sesuai!");
                }
                txtNoPeti.Select();
                return bValid;
            }

            //pass all checks
            bValid = true;
            return bValid;
        }

        private void ResetInputForm()
        {
            //Reset Form
            txtJumlah.ResetText();
            txtMulai.ResetText();
            txtNoPeti.ResetText();
            txtSelesai.ResetText();
            txtTanggal.ResetText();
            txtPecah.ResetText();
            txtPecah.Value = 0;
            lstNoPeti.Items.Clear();
            radGridView2.DataSource = null;
            radGridView2.Rows.Clear();

            txtTanggal.Value = DateTime.Now;
        }

        private bool ValidateContent()
        {
            int iCount = 0;
            bool iValid = false;
            using (sinarekDataSetTableAdapters.boronganTableAdapter tbl = new boronganTableAdapter())
            {
                foreach (GridViewRowInfo item in radGridView2.Rows)
                {
                    iCount = int.Parse(tbl.pValidateBorongan(DateTime.Parse(txtTanggal.Text)
                                                            , TimeSpan.Parse(txtMulai.Text)
                                                            , int.Parse(item.Cells["MemberID"].Value.ToString())).ToString());
                    if (iCount > 0)
                    {
                        helper.NotifMessage("Data borongan sudah terinput");
                        txtMulai.Focus();
                        return iValid;
                    }
                    
                }
            }
            iValid = true;
            return iValid;
        }
        
        private void SaveNewItem()
        {
            //Validate Borongan
            //if (ValidateContent())
            //{
                try
                {
                    string nopeti = string.Empty;
                    bool first = true;
                    foreach (ListViewDataItem item in lstNoPeti.Items)
                    {
                        if (first)
                        {
                            nopeti = item.Text;
                            first = false;
                        }
                        else
                        {
                            nopeti = nopeti + "," + item.Text;
                        }
                    }

                    decimal hargasatuan = 0;
                    decimal hargab = 0;
                    DataRowView row = (DataRowView)rddTipe.SelectedItem.DataBoundItem;
                    hargab = decimal.Parse(row.Row["hargab"].ToString());
                    hargasatuan = decimal.Parse(row.Row["price"].ToString()) / 12;
                    //Save borongan record                
                    string iBoronganID = this.vboronganTableAdapter.pInsertBoronganNew(DateTime.Parse(txtTanggal.Text)
                                                                , TimeSpan.Parse(txtMulai.Text)
                                                                , TimeSpan.Parse(txtSelesai.Text)
                                                                , rddTipe.Text
                                                                , hargab
                                                                , int.Parse(rddTipe.SelectedValue.ToString())
                                                                , hargasatuan
                                                                , decimal.Parse(txtJumlah.Value.ToString())
                                                                , int.Parse(txtPecah.Text)
                                                                , nopeti
                                                                , NBConfig.ValidUserName).ToString();
                    foreach (GridViewRowInfo item in radGridView2.Rows)
                    {
                        this.vboronganTableAdapter.InsertBoronganBuruh(int.Parse(iBoronganID), int.Parse(item.Cells["MemberID"].Value.ToString()));
                    }

                    //Refresh Grid
                    this.sinarekDataSet.vborongan.Clear();
                    this.vboronganTableAdapter.FillByTanggal(this.sinarekDataSet.vborongan, dtPilihTanggal.Value.Date);
                    this.sinarekDataSet.vboronganall.Clear();
                    this.vboronganallTableAdapter.Fill(this.sinarekDataSet.vboronganall, NBConfig.IGMID);
                    radGridView5.Refresh();
                    radGridView4.Refresh();
                    lblInfo.Text = "(" + radGridView1.RowCount.ToString() + ")";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message + "\nData gagal tersimpan.!");
                }
            //}
        }

        private void SaveEditItem()
        {

            try
            {
                string nopeti = string.Empty;
                bool first = true;
                foreach (ListViewDataItem item in lstNoPeti.Items)
                {
                    if (first)
                    {
                        nopeti = item.Text;
                        first = false;
                    }
                    else
                    {
                        nopeti = nopeti + "," + item.Text;
                    }
                }
                //Save borongan record                
                this.vboronganTableAdapter.pUpdateBorongan(_iBoronganID
                                                            ,DateTime.Parse(txtTanggal.Text)
                                                            , TimeSpan.Parse(txtMulai.Text)
                                                            , TimeSpan.Parse(txtSelesai.Text)
                                                            , rddTipe.Text
                                                            , decimal.Parse(txtJumlah.Value.ToString())
                                                            , int.Parse(txtPecah.Text)
                                                            , nopeti
                                                            , NBConfig.ValidUserName).ToString();
                foreach (GridViewRowInfo item in radGridView2.Rows)
                {                    
                    this.vboronganTableAdapter.UpdateBorBur(int.Parse(item.Cells["BuruhID"].Value.ToString()),_iBoronganID,int.Parse(item.Cells["BoronganBuruhID"].Value.ToString()));
                }

                //Refresh Grid
                this.sinarekDataSet.vborongan.Clear();
                this.vboronganTableAdapter.FillByTanggal(this.sinarekDataSet.vborongan, dtPilihTanggal.Value.Date);
                this.sinarekDataSet.vboronganall.Clear();
                this.vboronganallTableAdapter.Fill(this.sinarekDataSet.vboronganall, NBConfig.IGMID);
                radGridView5.Refresh();
                radGridView4.Refresh();
                lblInfo.Text = "(" + radGridView1.RowCount.ToString() + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message + "\nData gagal tersimpan.!");
            }
        }

        private void PrepareEditForm()
        {
            string sBuruh = string.Empty;
            //Set Selected BoronganID
            _iBoronganID = int.Parse(radGridView1.SelectedRows[0].Cells["boronganid"].Value.ToString());

            //Populate form for editing 
            //tanggal
            txtTanggal.Value = DateTime.Parse(radGridView1.SelectedRows[0].Cells["tanggal"].Value.ToString());
            
            //Jam Mulai
            txtMulai.Value = DateTime.Parse(radGridView1.SelectedRows[0].Cells["mulaiborongan"].Value.ToString());
            txtSelesai.Value = DateTime.Parse(radGridView1.SelectedRows[0].Cells["selesaiborongan"].Value.ToString());
            //get buruhid            
            using (NB.sinarekDataSetTableAdapters.boronganburuhTableAdapter bb = new boronganburuhTableAdapter())
            {
                radGridView2.DataSource = bb.GetBuruhByBoronganID(_iBoronganID);
                sBuruh = bb.GetBuruhID(_iBoronganID).ToString();
            }
            
            char[] chr = { ',' };

            //Tipe
            rddTipe.SelectedItem = rddTipe.FindItemExact(radGridView1.SelectedRows[0].Cells["tipeborongan"].Value.ToString(), false);
            //Pecah
            txtPecah.Value = radGridView1.SelectedRows[0].Cells["pecah"].Value.ToString();
            //Jumlah
            txtJumlah.Text = radGridView1.SelectedRows[0].Cells["hasilborongan"].Value.ToString();
            //No peti
            txtNoPeti.ResetText();
            lstNoPeti.Items.Clear();
            string nopeti = radGridView1.SelectedRows[0].Cells["nopeti"].Value.ToString();
            string ket = string.Empty;

            string[] list = nopeti.Split(chr, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in list)
            {
                lstNoPeti.Items.Add(str);
            }
        }
        #endregion

        #region "Control Events"
        private void dtPilihTanggal_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //this.sinarekDataSet.vborongan.Clear();
                //Update data
                this.vboronganTableAdapter.FillByTanggal(this.sinarekDataSet.vborongan, dtPilihTanggal.Value);
                radGridView1.Refresh();
                lblInfo.Text = "(" + radGridView1.RowCount.ToString() + ")"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (delete_)
            {
                PrepareEditForm();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResetInputForm();

            radPanel1.Enabled = false;
            radGroupBox1.Enabled = true;
            rddNama.Enabled = true;
            btnNext.Enabled = true;
            radGroupBox1.Text = "Input Borongan";
            txtTanggal.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (radGridView1.SelectedRows.Count == 1)
            {
                PrepareEditForm();

                radPanel1.Enabled = false;
                radGroupBox1.Enabled = true;
                radGroupBox1.Text = "Ubah Borongan";
                rddNama.Enabled = false;
                btnNext.Enabled = false;
                //populate control with values
                //PrepareEditForm();
                txtTanggal.Focus();
            }
            else
            {
                helper.NotifMessage("Silahkan pilih borongan untuk di ubah.");
            }
        }
        
        private void frmBorongan_Activated(object sender, EventArgs e)
        {
            lblInfo.Text = "(" + radGridView1.RowCount.ToString() + ")";  
        }

        private void txtNoPeti_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            if (e.KeyChar == (char)Keys.Return)
            {
                lstNoPeti.Items.Add(txtNoPeti.Text.ToUpper());
                txtNoPeti.ResetText();
                txtNoPeti.Select();
            }
        }

        private void rddNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                GridViewRowInfo row = radGridView2.Rows.AddNew();
                row.Cells["MemberID"].Value = rddNama.SelectedValue;
            }
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //TODO:Save New Data
                SaveNewItem();
                ResetInputForm();
                //next
                txtTanggal.Focus();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //TODO:Save New Data. Always refresh grid
                if (!radGroupBox1.Text.Contains("Ubah"))
                {
                    SaveNewItem();
                }
                else
                {
                    SaveEditItem();
                }
                ResetInputForm();

                radPanel1.Enabled = true;
                radGroupBox1.Enabled = false;
                radGroupBox1.Text = "Input/Ubah Borongan";
                dtPilihTanggal.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetInputForm();

            radPanel1.Enabled = true;
            radGroupBox1.Enabled = false;
            radGroupBox1.Text = "Input/Ubah Borongan";
            dtPilihTanggal.Focus();            
        }
        
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (radGridView1.SelectedRows.Count == 1)
            {
                DialogResult res;
                res = System.Windows.Forms.DialogResult.No;
                if (dtPilihTanggal.Value.Date == DateTime.Now.Date)
                {
                    res = RadMessageBox.Show("Borongan " + DateTime.Parse(radGridView1.SelectedRows[0].Cells["Tanggal"].Value.ToString()).ToString("dd MMM yy")
                    + " " + radGridView1.SelectedRows[0].Cells["Nama"].Value.ToString()
                    + " - " + DateTime.Parse(radGridView1.SelectedRows[0].Cells["MulaiBorongan"].Value.ToString()).ToString("hh:mm")
                    + " " + DateTime.Parse(radGridView1.SelectedRows[0].Cells["SelesaiBorongan"].Value.ToString()).ToString("hh:mm")
                    + " akan di hapus?", "SMS - Verification"
                    , MessageBoxButtons.YesNo
                    , RadMessageIcon.Question);
                }
                else
                {
                    if (delete_)
                    {
                        res = RadMessageBox.Show("Borongan " + DateTime.Parse(radGridView1.SelectedRows[0].Cells["Tanggal"].Value.ToString()).ToString("dd MMM yy")
                        + " " + radGridView1.SelectedRows[0].Cells["Nama"].Value.ToString()
                        + " - " + DateTime.Parse(radGridView1.SelectedRows[0].Cells["MulaiBorongan"].Value.ToString()).ToString("hh:mm")
                        + " " + DateTime.Parse(radGridView1.SelectedRows[0].Cells["SelesaiBorongan"].Value.ToString()).ToString("hh:mm")
                        + " akan di hapus?", "SMS - Verification"
                        , MessageBoxButtons.YesNo
                        , RadMessageIcon.Question);
                    }
                    else
                    {
                        RadMessageBox.Show("Borongan tidak dapat di hapus");
                    }
                }

                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        this.vboronganTableAdapter.pDeleteBorongan(int.Parse(radGridView1.SelectedRows[0].Cells["BoronganID"].Value.ToString()));
                        helper.NotifMessage("Borongan telah terhapus.");

                        //Refresh Grid
                        this.sinarekDataSet.vborongan.Clear();
                        this.vboronganTableAdapter.FillByTanggal(this.sinarekDataSet.vborongan, dtPilihTanggal.Value.Date);
                        lblInfo.Text = "(" + radGridView1.RowCount.ToString() + ")";

                    }
                    catch (Exception ex)
                    {
                        helper.ErrorMessage("Borongan tidak berhasil dihapus.");
                        helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                    }
                }
            }
            else
            {
                helper.NotifMessage("Silahkan pilih borongan untuk dihapus");
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            this.sinarekDataSet.vborongan.Clear();
            vboronganTableAdapter.FillByCari(this.sinarekDataSet.vborongan, txtCariNoPeti.Text, rddTipeCari.Text);
            radGridView3.Refresh();
        }

        private void btnDenda_Click(object sender, EventArgs e)
        {
            frmInputDenda frm = new frmInputDenda();
            frm.ShowDialog(this);
        }

        private void radGridView4_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            //Get Summary Value
            string PB = vboronganTableAdapter.GetSumTipeTanggal("PB", DateTime.Parse(e.Value.ToString())).ToString();
            string LB2 = vboronganTableAdapter.GetSumTipeTanggal("LB2", DateTime.Parse(e.Value.ToString())).ToString();
            string LB3 = vboronganTableAdapter.GetSumTipeTanggal("LB3", DateTime.Parse(e.Value.ToString())).ToString();
            string LK2 = vboronganTableAdapter.GetSumTipeTanggal("LK2", DateTime.Parse(e.Value.ToString())).ToString();
            string LK3 = vboronganTableAdapter.GetSumTipeTanggal("LK3", DateTime.Parse(e.Value.ToString())).ToString();
            string TB = vboronganTableAdapter.GetSumTipeTanggal("TB", DateTime.Parse(e.Value.ToString())).ToString();
            e.FormatString = @"{1:dd MMM yyy} " 
                            + (string.IsNullOrEmpty(PB)?"":"[PB - " + PB + "] ")
                            + (string.IsNullOrEmpty(LB2)?"":"[LB2 - " + LB2 + "] ")
                            + (string.IsNullOrEmpty(LB3)?"":"[LB3 - " + LB3 + "] ")
                            + (string.IsNullOrEmpty(LK2) ? "" : "[LK2 - " + LK2 + "] ")
                            + (string.IsNullOrEmpty(LK3) ? "" :"[LK3 - " + LK3 + "] ")
                             + (string.IsNullOrEmpty(TB) ? "" :"[TB - " + TB + "] ");

            //e.FormatString = "Ada Deh";
        }
        #endregion

    }
}
