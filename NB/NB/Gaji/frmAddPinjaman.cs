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
    public partial class frmAddPinjaman : Telerik.WinControls.UI.RadForm
    {
        int _iTipe;

        public frmAddPinjaman(int iTipe)
        {
            InitializeComponent();
            _iTipe = iTipe;
            startDateDateTimePicker.Value = DateTime.Now;            
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
            SimpanDataPinjaman();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        
        private void SimpanDataPinjaman()
        {
            using (sinarekDataSetTableAdapters.pinjamanTableAdapter pinjAdapt = new sinarekDataSetTableAdapters.pinjamanTableAdapter())
            {
                int buruh = int.Parse(buruhIDRadDropDownList.SelectedValue.ToString());
                decimal unitvalue = decimal.Parse(angsuranRadMaskedEditBox.Value.ToString());
                decimal total = decimal.Parse(jumlahMaskedEditBox.Value.ToString());

                //Pinjaman should have reason
                if (string.IsNullOrEmpty(alasanTextBox.Text))
                {
                    MessageBox.Show("Pinjaman harus mempunyai alasan!");
                    return;
                }

                //unit Value need to be at least 1000
                if (unitvalue > 1000)
                {
                    int jumlahangsur = int.Parse((total / unitvalue).ToString());

                    try
                    {
                        pinjAdapt.AddPinjaman(buruh
                            , startDateDateTimePicker.Value
                            , _iTipe
                            , unitvalue
                            , decimal.Parse(jumlahMaskedEditBox.Value.ToString())
                            , int.Parse(jumlahangsur.ToString())
                            , 0
                            , ""
                            , alasanTextBox.Text
                            , NBConfig.ValidUserName);

                        //refresh angsuran pinjaman di gaji temp
                        pinjAdapt.pCreateDataPinjaman(NBConfig.IGMID, NBConfig.ValidUserName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this.Text.Replace("Input", "").Trim() + " untuk " + buruhIDRadDropDownList.Text + " sudah di input!");
                    }
                }
                else
                {
                    MessageBox.Show("Jumlah Angsuran Salah!");
                    return;
                }
            }

            buruhIDRadDropDownList.ResetText();
            if (jumlahMaskedEditBox.Enabled)
            {
                jumlahMaskedEditBox.ResetText();
            }
            if (angsuranRadMaskedEditBox.Enabled)
            {
                angsuranRadMaskedEditBox.ResetText();
            }
            alasanTextBox.ResetText();
        }

        private void alasanTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrEmpty(txt.Text))
            {
                e.Cancel = true;
            }
        }
    }
}
