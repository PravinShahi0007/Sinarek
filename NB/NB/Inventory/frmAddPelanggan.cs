using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace NB
{
    public partial class frmAddPelanggan : Telerik.WinControls.UI.RadForm
    {
        private int salesid_;
        private int kotaid_;
        public string PELNAME;
        
        public frmAddPelanggan(int SalesID, int KotaID)
        {
            InitializeComponent();
            salesid_ = SalesID;
            kotaid_ = KotaID;            
        }

        private void frmAddPelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.kota' table. You can move, or remove it, as needed.
            this.kotaTableAdapter.Fill(this.sinarekDataSet.kota);
            // TODO: This line of code loads data into the 'sinarekDataSet.pel' table. You can move, or remove it, as needed.
            this.pelTableAdapter.Fill(this.sinarekDataSet.pel);

            rddKota.SelectedValue = kotaid_;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string pelid = string.Empty;
            try
            {
                using (sinarekDataSetTableAdapters.pelTableAdapter tbl = new sinarekDataSetTableAdapters.pelTableAdapter())
                {

                    pelid = tbl.InsertPelanggan(txtName.Text
                        , txtAddress.Text
                        , int.Parse(rddKota.SelectedValue.ToString())
                        , salesid_, NBConfig.ValidUserName).ToString();
                }
                this.PELNAME = txtName.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ada Problem dengan penyimpanan data pelanggan.", "SMS - Error Notification");
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            finally
            {
                this.Close();
            }
        }
        
    }
}
