using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace NB
{
    public partial class frmCheck : Telerik.WinControls.UI.RadForm
    {
        public frmCheck()
        {
            InitializeComponent();

            //Set Default Value
            dtTanggal.Value = DateTime.Now.AddDays(-1);
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {
        }

        private void dtTanggal_ValueChanged(object sender, EventArgs e)
        {
            pCheckAbsenHarianTableAdapter.Fill(this.fingermachDataSet.pCheckAbsenHarian, dtTanggal.Value);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(cFingerAbsen.GrabDataAbsen("196.10.0.200", 4370, 421288,1).ToString());
                MessageBox.Show(cFingerAbsen.GrabDataAbsen("196.10.0.201", 4370, 421288,2).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
            
        }

        
    }
}
