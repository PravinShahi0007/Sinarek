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
    public partial class frmManageGaji : Telerik.WinControls.UI.RadForm
    {
        private bool isEdit_ = false;
        public frmManageGaji()
        {
            InitializeComponent();

            //Set up notification
            radLabel1.Text = "<html><b>NB :</b> To set up staff salary template" +
                             "<br />1. Create Staff Detail." +
                             "<br />2. Create Salary Template." +
                             "<br />3. Print Staff Contract." +                             
                             "<br />4. Register Staff for fingerprint machine attendance log." +
                             "</html>";
        }

        private void btnEditTemplate_Click(object sender, EventArgs e)
        {
            if (!isEdit_)
            {
                btnEditTemplate.Text = "Changing Template...";
                isEdit_ = true;
            }
            else
            {
                isEdit_ = false;
                btnEditTemplate.Text = "Edit Template Gaji";
            }
            radGroupBox1.Enabled = isEdit_;
            radGridView1.ReadOnly = (!isEdit_);
        }
    }
}
