using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace NB
{
    public partial class frmSalesReview : Telerik.WinControls.UI.RadForm
    {
        private DataRow dtBulan_, dtSales_;
        private decimal percent_;
        private decimal value_;
        private int targetbulanan;
        private int targetharian;
        private decimal pencapaian;
        public frmSalesReview()
        {
            InitializeComponent();
        }
        private void frmSalesPerformanceReview_Load(object sender, EventArgs e)
        {
            this.gajibulananTableAdapter.Fill(this.sinarekDataSet.gajibulanan);
            this.salesTableAdapter.Fill(this.sinarekDataSet.sales);
            rddBulanan.SelectedValue = NBConfig.IGBID;
            //LoadData(radPageView2.SelectedPage.Text.ToLower());
            //LoadSummary(radPageView1.SelectedPage.Text.ToLower());

            //this.FormElement.TitleBar.TitlePrimitive.Font = new System.Drawing.Font("Lucida Bright", 12, FontStyle.Bold);
            //this.Text = dtSales_["nama"].ToString().ToUpper() + " Sales Performance Bulan " + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("MMMM yyyy");         
        }
        private void PrepareLaporan()
        {
            //Get Total Penjualan Uptodate
            string sQuery = "call pGetTotalPenjualanSales(" + dtSales_["salesid"].ToString()
                               + ",'"
                               + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("yyyy-MM-dd")
                               + "' , '"
                               + DateTime.Parse(dtBulan_["enddate"].ToString()).ToString("yyyy-MM-dd") + "')";
            MySqlDataAdapter adapt = new MySqlDataAdapter(sQuery
                , ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);

            DataTable dt = new DataTable("Data");
            adapt.Fill(dt);
            decimal target = 0;
            if (dt.Rows.Count != 0)
            {
                target = decimal.Parse(dt.Rows[0]["Target"].ToString());
            }
            //Get Barang Tukar
            sQuery = "call pGetTotalTukarSales(" + dtSales_["salesid"].ToString()
                               + ",'"
                               + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("yyyy-MM-dd")
                               + "' , '"
                               + DateTime.Parse(dtBulan_["enddate"].ToString()).ToString("yyyy-MM-dd") + "')";
            adapt.SelectCommand.CommandText = sQuery;
            dt.Clear();
            adapt.Fill(dt);
            decimal Tukar = 0;
            decimal TukarE = 0;
            if (dt.Rows.Count == 1)
            {
                Tukar = decimal.Parse(dt.Rows[0]["Target"].ToString());
            }

            //Tukar Barang Expire
            sQuery = "call pGetTotalTukarExpSales(" + dtSales_["salesid"].ToString()
                               + ",'"
                               + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("yyyy-MM-dd")
                               + "' , '"
                               + DateTime.Parse(dtBulan_["enddate"].ToString()).ToString("yyyy-MM-dd") + "')";
            adapt.SelectCommand.CommandText = sQuery;
            dt.Clear();
            adapt.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                TukarE = decimal.Parse(dt.Rows[0]["Target"].ToString());
            }

            //Get Total barang credit and cash
            sQuery = "call pGetRincianPenjualanSales(" + dtSales_["salesid"].ToString()
                               + ",'"
                               + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("yyyy-MM-dd")
                               + "' , '"
                               + DateTime.Parse(dtBulan_["enddate"].ToString()).ToString("yyyy-MM-dd") + "')";
            adapt.SelectCommand.CommandText = sQuery;
            dt.Clear();
            adapt.Fill(dt);
            decimal Credit = 0;
            decimal Cash = 0;
            string daerahCash = "", daerahCredit = "";
            if (dt.Rows.Count == 1)
            {
                Cash = decimal.Parse(dt.Rows[0]["Target"].ToString());
                daerahCash = dt.Rows[0]["daerah"].ToString();
            }
            else if (dt.Rows.Count == 2)
            {
                Cash = decimal.Parse(dt.Rows[0]["Target"].ToString());
                daerahCash = dt.Rows[0]["daerah"].ToString();
                Credit = decimal.Parse(dt.Rows[1]["Target"].ToString());
                daerahCredit = dt.Rows[0]["daerah"].ToString();
            }

            StringBuilder sDisplay = new StringBuilder();
            sDisplay.AppendLine("<html>");
            percent_ = -1M;
            int Target = -1;
            if (dtSales_["target"].ToString() != "-1")
            {
                Target = (int.Parse(dtBulan_["WorkDays"].ToString()) * int.Parse(dtSales_["target"].ToString()));
                percent_ = (target / Target);
                if (((target - TukarE) / Target) < 1)
                {
                    sDisplay.AppendLine("<br />" + "Pencapaian Target : <b><span style='color:red;font-size:20pt;'>" + ((target - TukarE) / Target).ToString("p") + "</span></b>");
                }
                else
                {
                    sDisplay.AppendLine("<br />" + "Pencapaian Target : <b><span style='font-size:20pt;'>" + ((target - TukarE) / Target).ToString("p") + "</span></b>");
                }
                sDisplay.AppendLine("<br />" + "Target Rata-Rata Harian : " + int.Parse(dtSales_["target"].ToString()).ToString("n2"));
                sDisplay.AppendLine("<br />" + "Target Bulanan : <b>" + Target.ToString("n2") + "</b>");
            }
            sDisplay.AppendLine("<br />" + "Total Penjualan Up to Date : " + target.ToString("n2"));
            sDisplay.AppendLine("<br />" + "Total Penjualan Credit Up to Date : " + Credit.ToString("n2"));
            sDisplay.AppendLine("<br />" + "Total Penjualan Tunai Up to Date : " + Cash.ToString("n2"));
            sDisplay.AppendLine("<br />" + "Total Barang Tukar Up to Date : " + Tukar.ToString("n2"));
            sDisplay.AppendLine("<br />" + "Total Barang Tukar Expire Up to Date : " + TukarE.ToString("n2"));
            sDisplay.AppendLine("<br />" + "Total Hari Kerja : " + dtBulan_["WorkDays"].ToString());
            sDisplay.AppendLine("</html>");
            pencapaian = (target - TukarE);
            targetbulanan = Target;
            targetharian = int.Parse(dtSales_["target"].ToString());

            lblBulan.Text = sDisplay.ToString();

            StringBuilder sDisplayK = new StringBuilder();
            sDisplayK.AppendLine("<html>");
            sDisplayK.AppendLine("Daerah Penjualan Tunai : <br />");
            sDisplayK.AppendLine(daerahCash);
            sDisplayK.AppendLine("Daerah Penjualan Credit : <br />");
            sDisplayK.AppendLine(daerahCredit);
            sDisplayK.AppendLine("</html>");
            lblKunjungan.Text = sDisplayK.ToString();

        }
        private void SetUpJadwal()
        {
            //Get Total Penjualan Uptodate
            string sQuery = "Select Tanggal,Keterangan,tipehadirid from AbsenaLL Where memberid = " + dtSales_["id"].ToString() + " and keterangan <> ''";
            MySqlDataAdapter adapt = new MySqlDataAdapter(sQuery
                , ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);

            DataTable dt = new DataTable("Data");
            adapt.Fill(dt);
            radScheduler1.ActiveView.StartDate = DateTime.Parse(dtBulan_["startdate"].ToString());
            radScheduler1.ActiveView.ReadOnly = true;
            radScheduler1.GetMonthView().EnableWeeksHeader = false;
            radScheduler1.GetMonthView().WeekCount = 5;
            
            
            this.radScheduler1.Appointments.Clear();
            foreach (DataRow row in dt.Rows)
            {
                //Create All day appointment
                //Appointment appointment = new Appointment(DateTime.Parse(row["tanggal"].ToString()).Date
                //    , TimeSpan.FromDays (1), row["keterangan"].ToString());
                Appointment appointment = new Appointment();
                appointment.AllDay = true;
                appointment.Start = DateTime.Parse(row["tanggal"].ToString()).Date;
                appointment.End = DateTime.Parse(row["tanggal"].ToString()).Date;
                appointment.StatusId = 1;
                appointment.BackgroundId = 7;
                appointment.Summary = row["keterangan"].ToString();
                this.radScheduler1.Appointments.Add(appointment);
            }

        }
        private void SetUpDaftarPenjualan()
        {
            string sQuery = "call pGetDaftarPenjualan(" + dtSales_["salesid"].ToString()
                               + ",'"
                               + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("yyyy-MM-dd")
                               + "' , '"
                               + DateTime.Parse(dtBulan_["enddate"].ToString()).ToString("yyyy-MM-dd") + "')";
            MySqlDataAdapter adapt = new MySqlDataAdapter(sQuery
                , ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);
            DataTable dt = new DataTable("Data");
            adapt.Fill(dt);

            radGridView1.Columns.Clear();
            radGridView1.DataSource = dt;
            radGridView1.ReadOnly = true;
            radGridView1.Columns["logpelid"].IsVisible = false;

            radGridView1.Columns["Tanggal"].FormatString = "{0:dd MMM yy}";
            radGridView1.Columns["Tanggal"].Width = 80;

            radGridView1.Columns["Pelanggan"].Width = 120;

            radGridView1.Columns["nama"].HeaderText = "Kota";
            radGridView1.Columns["statusid"].HeaderText = "Tukar";
            radGridView1.Columns["ProductShortChild"].HeaderText = "Barang";
            radGridView1.Columns["ProductShortChild"].Width = 100;
            radGridView1.Columns["ConvValue"].HeaderText = "Jumlah";
            radGridView1.Columns["ConvValue"].FormatString = "{0:n1}";
            radGridView1.Columns["ConvValue"].Width = 75;
            radGridView1.Columns["nama"].Width = 150;

            GroupDescriptor g1 = new GroupDescriptor();
            g1.GroupNames.Add("Tanggal", ListSortDirection.Ascending);
            g1.Aggregates.Add("count(logpelid)");
            g1.Format = "{1:ddddd,dd MMM yy} - ({2})";
            this.radGridView1.GroupDescriptors.Add(g1);

                        
        }
        private void SetUpDaftarReturn()
        {
            //pGetTransDetailTanggalSales`(startdate_ date , enddate_ date,SAlesID_ int, transtypeid_ int)
            string sQuery = "call pGetTransDetailTanggalSales('" + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("yyyy-MM-dd")
                               + "' , '"
                               + DateTime.Parse(dtBulan_["enddate"].ToString()).ToString("yyyy-MM-dd")
                               +"' , " + dtSales_["salesid"].ToString()
                               + ",9)";
            MySqlDataAdapter adapt = new MySqlDataAdapter(sQuery
                , ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);
            DataTable dt = new DataTable("Data");
            adapt.Fill(dt);
            radGridView3.DataSource = dt;
        }
        private void SetUpDaftarTukar()
        {
            //pGetTransDetailTanggalSales`(startdate_ date , enddate_ date,SAlesID_ int, transtypeid_ int)
            string sQuery = "call pGetTransDetailTanggalSales('" + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("yyyy-MM-dd")
                               + "' , '"
                               + DateTime.Parse(dtBulan_["enddate"].ToString()).ToString("yyyy-MM-dd")
                               + "' , " + dtSales_["salesid"].ToString()
                               + ",15)";
            MySqlDataAdapter adapt = new MySqlDataAdapter(sQuery
                , ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);
            DataTable dt = new DataTable("Data");
            adapt.Fill(dt);
            radGridView3.DataSource = dt;
        }
        private void SetUpDaftarKunjungan()
        {
            string sQuery = "call pGetDataKunjungan(" + dtSales_["salesid"].ToString()
                               + ",'"
                               + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("yyyy-MM-dd")
                               + "' , '"
                               + DateTime.Parse(dtBulan_["enddate"].ToString()).ToString("yyyy-MM-dd") + "')";
            MySqlDataAdapter adapt = new MySqlDataAdapter(sQuery
                , ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);
            DataTable dt = new DataTable("Data");
            adapt.Fill(dt);

            radGridView5.Columns.Clear();
            radGridView5.DataSource = dt;
            radGridView5.ReadOnly = true;
            radGridView5.Columns["logpelid"].IsVisible = false;
            radGridView5.Columns["logid"].IsVisible = false;
            radGridView5.Columns["salesname"].IsVisible = false;
            //radGridView5.Columns["kunjungan"].IsVisible = false;
            
            radGridView5.Columns["Tanggal"].FormatString = "{0:dd MMM yy}";
            radGridView5.Columns["Tanggal"].Width = 80;

            radGridView5.Columns["Pelanggan"].Width = 120;

            radGridView5.Columns["DaerahJual"].Width = 150;
            radGridView5.Columns["DaerahJual"].HeaderText = "Kota";

            radGridView5.Columns["NoSJ"].HeaderText = "NO. SJ";
            radGridView5.Columns["NoSJ"].Width = 80;

            radGridView5.Columns["Total"].HeaderText = "Jumlah";
            radGridView5.Columns["Total"].FormatString = "{0:Rp #,##0.00}";
            radGridView5.Columns["Total"].Width = 150;

            GroupDescriptor g1 = new GroupDescriptor();
            g1.GroupNames.Add("Tanggal", ListSortDirection.Ascending);
            g1.Aggregates.Add("count(logpelid)");
            g1.Aggregates.Add("sum(kunjungan)");
            //g1.Aggregates.Add("count(iif(total < 1,1,0))");
            g1.Format = "{1:ddddd,dd MMM yy} - Total Kunjungan ({2}) - Tidak Belanja ({3}) ";
            this.radGridView5.GroupDescriptors.Add(g1);


        }
        private void SetUpLaporanPenjualan()
        {
            string sQuery = "call pGetPenjualanSales(" + dtSales_["salesid"].ToString()
                               + ",'"
                               + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("yyyy-MM-dd")
                               + "' , '"
                               + DateTime.Parse(dtBulan_["enddate"].ToString()).ToString("yyyy-MM-dd") + "')";
            MySqlDataAdapter adapt = new MySqlDataAdapter(sQuery
                , ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);
            DataTable dt = new DataTable("Data");
            adapt.Fill(dt);

            radGridView4.Columns.Clear();
            radGridView4.DataSource = dt;
            radGridView4.ReadOnly = true;
            radGridView4.Columns["ProductShortChild"].HeaderText = "Barang";
            radGridView4.Columns["ProductShortChild"].Width = 75;
            radGridView4.Columns["Target"].HeaderText = "Target";
            radGridView4.Columns["Target"].Width = 75;
            radGridView4.Columns["Target"].FormatString = "{0:n2}";
            radGridView4.Columns["Jumlah"].HeaderText = "Jumlah";
            radGridView4.Columns["Jumlah"].Width = 100;
            radGridView4.Columns["Jumlah"].FormatString = "{0:n2}";

            if (radGridView4.SummaryRowsTop.Count == 0)
            {
                GridViewSummaryRowItem summ = new GridViewSummaryRowItem();
                summ.Add(new GridViewSummaryItem("Jumlah", "Total : ", GridAggregateFunction.Sum));
                summ.Add(new GridViewSummaryItem("Target", "{0:n2}", GridAggregateFunction.Sum));
                radGridView4.SummaryRowsTop.Add(summ);
            }

        }

        private void radPageView2_SelectedPageChanged(object sender, EventArgs e)
        {
            LoadData(radPageView2.SelectedPage.Text.ToLower());
        }
        private void LoadData(string Title)
        {
            switch (Title)
            {
                case "jadwal":
                    SetUpJadwal();
                    break;
                case "daftar penjualan":
                    SetUpDaftarPenjualan();
                    break;
                case "kunjungan":
                    SetUpDaftarKunjungan();
                    break;
                case "barang tukar":
                    SetUpDaftarTukar();
                    break;
                case "barang return":
                    SetUpDaftarReturn();
                    break;
            }
        }
        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            LoadSummary(radPageView1.SelectedPage.Text.ToLower());
        }
        private void LoadSummary(string Title)
        {
            switch (Title)
            {
                case "total penjualan":
                    SetUpLaporanPenjualan();
                    break;
                case "summary":
                    PrepareLaporan();
                    break;
            }
        }

        private void rddBulanan_SelectedValueChanged(object sender, EventArgs e)
        {
            radWaitingBar1.Show();
            radWaitingBar1.Visible = true;
            radWaitingBar1.StartWaiting();
            this.SuspendLayout();
            if ((rddBulanan.SelectedValue != null) && (rddSales.SelectedValue != null))
            {
                DataRowView rowV = (DataRowView)rddBulanan.SelectedItem.DataBoundItem;
                dtBulan_ = rowV.Row;
                rowV = (DataRowView)rddSales.SelectedItem.DataBoundItem;
                dtSales_ = rowV.Row;
                LoadData(radPageView2.SelectedPage.Text.ToLower());
                LoadSummary(radPageView1.SelectedPage.Text.ToLower());
                this.FormElement.TitleBar.TitlePrimitive.Font = new System.Drawing.Font("Lucida Bright", 12, FontStyle.Bold);
                this.Text = dtSales_["nama"].ToString().ToUpper() + " Sales Performance Bulan " + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("MMMM yyyy");
            }
            radWaitingBar1.StopWaiting();
            radWaitingBar1.Visible = false;
            this.PerformLayout();
        }
        private void rddSales_SelectedValueChanged(object sender, EventArgs e)
        {
            radWaitingBar1.Show();
            radWaitingBar1.Visible = true;
            radWaitingBar1.StartWaiting();
            if ((rddBulanan.SelectedValue != null) && (rddSales.SelectedValue != null))
            {
                this.SuspendLayout();
                DataRowView rowV = (DataRowView)rddBulanan.SelectedItem.DataBoundItem;
                dtBulan_ = rowV.Row;
                rowV = (DataRowView)rddSales.SelectedItem.DataBoundItem;
                dtSales_ = rowV.Row;
                LoadData(radPageView2.SelectedPage.Text.ToLower());
                LoadSummary(radPageView1.SelectedPage.Text.ToLower());
                this.FormElement.TitleBar.TitlePrimitive.Font = new System.Drawing.Font("Lucida Bright", 12, FontStyle.Bold);
                this.Text = dtSales_["nama"].ToString().ToUpper() + " Sales Performance Bulan " + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("MMMM yyyy");
            }
            radWaitingBar1.StopWaiting();
            radWaitingBar1.Visible = false;
            this.PerformLayout();
        }


    }
}
