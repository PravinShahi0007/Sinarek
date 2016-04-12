using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace NB
{
    public partial class frmPinjaman : Telerik.WinControls.UI.RadForm
    {
        HtmlViewDefinition htmlView;

        public frmPinjaman()
        {
            InitializeComponent();
            // html view             
            this.htmlView = new HtmlViewDefinition();            
            this.htmlView.RowTemplate.Rows.Add(new RowDefinition(25));
            this.htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("BuruhID"));
            this.htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("TotalPinjaman"));
            this.htmlView.RowTemplate.Rows.Add(new RowDefinition(25));
            this.htmlView.RowTemplate.Rows[1].Cells.Add(new CellDefinition("StartDate"));
            this.htmlView.RowTemplate.Rows[1].Cells.Add(new CellDefinition("EndDate"));
            this.htmlView.RowTemplate.Rows.Add(new RowDefinition(25));
            this.htmlView.RowTemplate.Rows[2].Cells.Add(new CellDefinition("UnitValue"));
            this.htmlView.RowTemplate.Rows[2].Cells.Add(new CellDefinition("JumlahAngsuran"));
            this.htmlView.RowTemplate.Rows.Add(new RowDefinition(25));
            this.htmlView.RowTemplate.Rows[3].Cells.Add(new CellDefinition("Bayar"));
            this.htmlView.RowTemplate.Rows[3].Cells.Add(new CellDefinition("TotalBayar"));
            this.htmlView.RowTemplate.Rows.Add(new RowDefinition(30));
            this.htmlView.RowTemplate.Rows[4].Cells.Add(new CellDefinition("Alasan",500,2,1));

            this.radGridView1.ViewDefinition = htmlView;
            //this.radGridView1.Columns["nopeti"].
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
            this.radGridView1.TableElement.RowSpacing = 5; 

            this.radGridView1.EnableCustomGrouping = true;
            this.radGridView1.CustomGrouping += new GridViewCustomGroupingEventHandler(radGridView1_CustomGrouping);

            GroupDescriptor descriptor = new GroupDescriptor("Active");
            this.radGridView1.GroupDescriptors.Add(descriptor);
            this.radGridView1.GroupDescriptors[0].Aggregates.Add("count(pinjamanid)");


            this.radGridView1.GroupSummaryEvaluate += new GroupSummaryEvaluateEventHandler(radGridView1_GroupSummaryEvaluate);
        }
        private void radGridView1_CustomGrouping(object sender, GridViewCustomGroupingEventArgs e)
        {
            string groupkey = "";
            string status = e.Row.Cells["Active"].Value.ToString();
            switch (status)
            {
                case "True":
                    groupkey = "Masih Berjalan";
                    break;
                case "False":
                    groupkey = "Lunas";
                    break;
            }
            
            e.GroupKey = groupkey;
        }
        private void radGridView1_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if (e.Value == null)
            {
                e.FormatString = e.Group.Key.ToString() + " ({2})";
            }
        }
        private void frmPinjaman_Load(object sender, EventArgs e)
        {
            this.memberTableAdapter.Fill(this.sinarekDataSet.member);
            this.rinciangajiTableAdapter.Fill(this.sinarekDataSet.rinciangaji);
            this.gajimingguanTableAdapter.Fill(this.sinarekDataSet.gajimingguan);
            this.pinjamanTableAdapter.Fill(this.sinarekDataSet.pinjaman);
            
            SetDefault();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddPinjaman frm = new frmAddPinjaman(5);
            frm.ShowDialog(this);

            //refresh grid
            this.sinarekDataSet.pinjaman.Clear();
            this.pinjamanTableAdapter.Fill(this.sinarekDataSet.pinjaman);            
        }

        private void SetDefault()
        {
            //Lihat Semua
            rbtnFilterNama.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void rbtn_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            RadRadioButton btn = (RadRadioButton)sender;
            if (btn.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                switch (btn.Name.ToLower().ToString())
                {
                    case "rbtnfilternama":
                        rddNama.Enabled = true;
                        chkLunas.Enabled = false;
                        pinjamanBindingSource.Filter = "buruhid = " + rddNama.SelectedValue.ToString();
                        break;
                    case "rbtnfilterstatus": 
                        rddNama.Enabled = false;
                        chkLunas.Enabled = true;
                        pinjamanBindingSource.Filter = "active = " + (chkLunas.Checked ? "0" : "1");
                        break;
                    case "rbtnall":
                        rddNama.Enabled = false;
                        chkLunas.Enabled = false;
                        pinjamanBindingSource.Filter = "";
                        break;
                }
            }
        }

        private void radGridView1_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow.Cells["pinjamanid"].Value != null)
            {
                rinciangajiBindingSource.Filter = "tipeid = 5 and templateid = " + e.CurrentRow.Cells["pinjamanid"].Value.ToString();
            }
            else
            {
                rinciangajiBindingSource.Filter = "tipeid = 5 and templateid = -1";
            }
        }

        private void rddNama_SelectedValueChanged(object sender, EventArgs e)
        {
            rinciangajiBindingSource.Filter = "templateid = -1";
            if (rddNama.SelectedValue != null)
            {
                pinjamanBindingSource.Filter = "buruhid = " + rddNama.SelectedValue.ToString();
            }
        }

        private void chkLunas_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            rinciangajiBindingSource.Filter = "templateid = -1";
            pinjamanBindingSource.Filter = "active = " + (chkLunas.Checked ? "0" : "1");
        }

        private void btnProcessPinjaman_Click(object sender, EventArgs e)
        {
            pinjamanTableAdapter.pProcessPinjaman(NBConfig.IGMID, NBConfig.ValidUserName);
            this.pinjamanTableAdapter.Fill(this.sinarekDataSet.pinjaman);
            helper.SysLog(this.Tag.ToString(), "btnProcessPinjaman_Click", "Process Pinjaman:" + NBConfig.IGMID);
        }
    }
}
