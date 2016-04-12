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
    public partial class frmAddGajiDetail : Telerik.WinControls.UI.RadForm
    {
        int _iTipeBonus;
        string sformTitle;
        int tipebayarid_;
        int gid_;

        public frmAddGajiDetail(int iTipeBonus,int GID,int TipeBayarID, string formTitle,decimal defaultValue)
        {
            InitializeComponent();
            bool bDate = true;
            bool bUnit = true;
            bool bValue = true;

            _iTipeBonus = iTipeBonus;
            gid_ = GID;
            tipebayarid_ = TipeBayarID;
            if (tipebayarid_ == 1)
            {
                memberBindingSource.Filter = "active = 1 and tipememberid in (2,3)";
            }
            else if(tipebayarid_ == 2)
            {
                memberBindingSource.Filter = "active = 1 and tipememberid in (2)";
            }
            else if (tipebayarid_ == 3)
            {
                tipebayarid_ = 1;
                memberBindingSource.Filter = "active = 1 and tipememberid = 1";
            }
            if (iTipeBonus == 9)
            {
                memberBindingSource.Filter += "and gender = 'P'";
            }
            sformTitle = formTitle;
            this.Text = "Input " + formTitle;
            startDateDateTimePicker.Value = DateTime.Now;
            
            if (_iTipeBonus == 10)
            {
                startDateDateTimePicker.Enabled = true;
            }
            if (_iTipeBonus == 12)
            {
            }
            this.Tag = iTipeBonus;
            unitradMaskedEditBox.Value = 1;
            unitvalueRadMaskedEditBox.Value = defaultValue;
            switch (_iTipeBonus)
            {
                case 9:
                    bValue = false;
                    //this.buruhIDRadDropDownList.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.buruhBindingSource1, "CurrentWage", true));
                    break;
                case 12:
                    bDate = false;
                    bUnit = false;
                    bValue = false;
                    break;
                case 19:
                    //bDate = false;
                    bValue = false;
                    break;
                case 25:
                    bValue = false;
                    //this.buruhIDRadDropDownList.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.buruhBindingSource1, "CurrentWage", true));
                    break;
                case 26:
                    bValue = false;
                    //this.buruhIDRadDropDownList.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.buruhBindingSource1, "PreviousWage", true));
                    break;
            }
            unitradMaskedEditBox.Enabled = bUnit;
            startDateDateTimePicker.Enabled = bDate;
            unitvalueRadMaskedEditBox.Enabled = bValue;
        }

        private void frmAddGajiDetail_Load(object sender, EventArgs e)
        {
            this.memberTableAdapter.Fill(this.sinarekDataSet.member);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //create gajidetailtemp / gajitetap
            SimpanDataGajiMember();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //simpan data
            //clear form
            //set focus on nama
            SimpanDataGajiMember();
            buruhIDRadDropDownList.Focus();
            //this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void SimpanDataGajiMember()
        {
            using (sinarekDataSetTableAdapters.rinciangajiTableAdapter tempAdapt = new sinarekDataSetTableAdapters.rinciangajiTableAdapter())
            {
                int memberid = int.Parse(buruhIDRadDropDownList.SelectedValue.ToString());
                decimal unitvalue = decimal.Parse(unitvalueRadMaskedEditBox.Value.ToString());
                try
                {
                    tempAdapt.InsertRincianGaji(memberid
                        ,gid_
                        ,tipebayarid_
                        , startDateDateTimePicker.Value
                        , int.Parse((this.Tag != null ? this.Tag.ToString() : ""))
                        , decimal.Parse(unitradMaskedEditBox.Value.ToString()), unitvalue
                        , keteranganTextBox.Text
                        , null,4, NBConfig.ValidUserName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this.Text.Replace("Input", "").Trim() + " untuk " + buruhIDRadDropDownList.Text + " sudah di input!");
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

        private void buruhIDRadDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            
        }

        private void buruhIDRadDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_iTipeBonus == 9 || _iTipeBonus == 25 || _iTipeBonus == 26)
            {
                //Get Gaji Pokok
                RadDropDownList rdl = (RadDropDownList)sender;
                if (rdl.SelectedValue != null)
                {
                    using (sinarekDataSetTableAdapters.memberTableAdapter tbl = new sinarekDataSetTableAdapters.memberTableAdapter())
                    {
                        unitvalueRadMaskedEditBox.Value = tbl.GetGajiPokok(1, int.Parse(rdl.SelectedValue.ToString()));
                    }
                }

            }
        }
    }
}
