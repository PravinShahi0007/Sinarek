using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NB
{
    public partial class frmAddGajiDetailSatpam : Telerik.WinControls.UI.RadForm
    {
        int _iTipeBonus;
        string sformTitle;

        public frmAddGajiDetailSatpam(int iTipeBonus, string formTitle,decimal defaultValue)
        {
            InitializeComponent();
            bool bDate = false;
            bool bUnit = true;
            bool bValue = true;

            _iTipeBonus = iTipeBonus;
            sformTitle = formTitle;
            this.Text = formTitle;
            startDateDateTimePicker.Value = DateTime.Now;
            
            this.Tag = iTipeBonus;
            unitradMaskedEditBox.Value = 1;
            unitvalueRadMaskedEditBox.Value = defaultValue;
            switch (_iTipeBonus)
            {
                case 27: //Lembur
                    bValue = false;
                    break;
            }
            unitradMaskedEditBox.Enabled = bUnit;
            startDateDateTimePicker.Enabled = bDate;
            unitvalueRadMaskedEditBox.Enabled = bValue;
        }

        private void frmAddGajiDetailOther_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fingermachDataSet.satpam' table. You can move, or remove it, as needed.
            this.satpamTableAdapter.Fill(this.fingermachDataSet.satpam);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //create gajidetailtemp / gajitetap
            SimpanData();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //simpan data
            //clear form
            //set focus on nama
            SimpanData();
            buruhIDRadDropDownList.Focus();
            //this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void SimpanData()
        {

            using (fingermachDataSetTableAdapters.gajidetailtempTableAdapter tempAdapt = new fingermachDataSetTableAdapters.gajidetailtempTableAdapter())
            {
                int satpam = int.Parse(buruhIDRadDropDownList.SelectedValue.ToString());
                decimal unitvalue = decimal.Parse(unitvalueRadMaskedEditBox.Value.ToString());
                decimal unit = decimal.Parse(unitradMaskedEditBox.Value.ToString());
                try
                {
                    tempAdapt.pInsertGajiDetailTemp(satpam
                        ,"satpam"
                        ,NBConfig.IGBID
                        ,startDateDateTimePicker.Value
                        ,_iTipeBonus
                        ,unit
                        ,unitvalue
                        ,keteranganTextBox.Text
                        ,NBConfig.ValidUserName);
                }
                catch (Exception ex)
                {
                    helper.SysLog(this.GetType().Name, this.Text, ex.Message);
                    helper.ErrorMessage(this.Text.Replace("Input", "").Trim() + " untuk " + buruhIDRadDropDownList.Text + " sudah di input!");
                }
            }

            buruhIDRadDropDownList.ResetText();
            if (unitradMaskedEditBox.Enabled)
            {
                unitradMaskedEditBox.ResetText();
            }
            if (unitvalueRadMaskedEditBox.Enabled)
            {
                unitvalueRadMaskedEditBox.ResetText();
            }
            keteranganTextBox.ResetText();
        }

    }
}
