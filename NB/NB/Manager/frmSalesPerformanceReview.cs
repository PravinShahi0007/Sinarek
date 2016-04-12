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
    public partial class frmSalesPerformanceReview : Telerik.WinControls.UI.RadForm
    {
        private DataRow dtBulan_, dtSales_;
        private decimal percent_;
        private decimal value_;
        private int targetbulanan;
        private int targetharian;
        private decimal pencapaian;
        public frmSalesPerformanceReview(DataRow dtSales,DataRow dtBulan)
        {
            InitializeComponent();
            dtBulan_ = dtBulan;
            dtSales_ = dtSales;
            this.FormElement.TitleBar.TitlePrimitive.Font = new System.Drawing.Font("Lucida Bright", 12, FontStyle.Bold);
            this.Text = dtSales["nama"].ToString().ToUpper() + " Sales Performance Bulan " + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("MMMM yyyy");
            
        }

        private void ProcessComission()
        {
            //Update Data
            string sQuery = "call pGetCommision(" + dtSales_["salesid"].ToString()
                               + ",'"
                               + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("yyyy-MM-dd")
                               + "' , '"
                               + DateTime.Parse(dtBulan_["enddate"].ToString()).ToString("yyyy-MM-dd") + "')";
                              
            MySqlDataAdapter adapt = new MySqlDataAdapter(sQuery
                , ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);
            DataTable dt = new DataTable("Data");
            adapt.Fill(dt);

            radGridView2.Columns.Clear();
            radGridView2.DataSource = dt;
            radGridView2.ReadOnly = true;
            radGridView2.Columns["ProductShortChild"].HeaderText = "Barang";
            radGridView2.Columns["ProductShortChild"].Width = 75;

            radGridView2.Columns["DalamKota"].HeaderText = "DK";
            radGridView2.Columns["Credit"].HeaderText = "Credit";

            radGridView2.Columns["Target"].HeaderText = "Target";
            radGridView2.Columns["Target"].Width = 100;
            radGridView2.Columns["Target"].FormatString = "{0:n2}";
            radGridView2.Columns["Jumlah"].HeaderText = "Jumlah";
            radGridView2.Columns["Jumlah"].Width = 100;
            radGridView2.Columns["Jumlah"].FormatString = "{0:n2}";
            radGridView2.Columns["Komisi"].HeaderText = "Komisi";
            radGridView2.Columns["Komisi"].Width = 100;
            radGridView2.Columns["Komisi"].FormatString = "{0:Rp #,##.##}";
            radGridView2.Columns["JumlahKomisi"].HeaderText = "Hasil";
            radGridView2.Columns["JumlahKomisi"].Width = 150;
            radGridView2.Columns["JumlahKomisi"].FormatString = "{0:Rp #,##0.00}";

            if (radGridView2.SummaryRowsTop.Count == 0)
            {
                //Hard Coded
                decimal multiplier = 0.85M;
                if (percent_ == -1M)
                {
                    multiplier = 1M;
                }else if (percent_ < 1)
                {
                    multiplier = 0.85M;
                }
                else if (percent_ >= 1M && percent_ < 1.2M)
                {
                    multiplier = 1M;
                }
                else
                {
                    multiplier = 1.2M;
                }
                //< 100 % , JK * 0.85
                //> 100 % and < 120 %, JK * 1
                //> 120 % , JK * 120 %
                //Get Multiplier 

                GridViewSummaryRowItem summ = new GridViewSummaryRowItem();
                summ.Add(new GridViewSummaryItem("Target", "Total Bayar : x" + multiplier.ToString("n2"),GridAggregateFunction.Sum));
                summ.Add(new GridViewSummaryItem("JumlahKomisi", "{0:Rp #,##0.00}","sum(jumlahkomisi)*" + multiplier.ToString()));
                GridViewSummaryRowItem summ2 = new GridViewSummaryRowItem();
                summ2.Add(new GridViewSummaryItem("Target", "Total :",GridAggregateFunction.Sum));
                summ2.Add(new GridViewSummaryItem("JumlahKomisi", "{0:Rp #,##0.00}",GridAggregateFunction.Sum));
                radGridView2.SummaryRowsTop.Add(summ);
                radGridView2.SummaryRowsTop.Add(summ2);
            }
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
            decimal target = decimal.Parse(dt.Rows[0]["Target"].ToString());

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
                Appointment appointment = new Appointment(DateTime.Parse(row["tanggal"].ToString()).Date
                    , TimeSpan.FromDays (1), row["keterangan"].ToString());
                appointment.StatusId = 1;
                appointment.BackgroundId = 7;
                this.radScheduler1.Appointments.Add(appointment);
            }

        }
        private void frmSalesPerformanceReview_Load(object sender, EventArgs e)
        {
            PrepareLaporan();
            SetUpDaftarPenjualan();
            SetUpLaporanPenjualan();
            //SetUpJadwal();
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

            //GroupDescriptor g1 = new GroupDescriptor();
            //g1.GroupNames.Add("Tanggal", ListSortDirection.Ascending);
            //g1.Aggregates.Add("count(logpelid)");
            //g1.Format = "{1:ddddd,dd MMM yy} - ({2})";
            //this.radGridView5.GroupDescriptors.Add(g1);


        }

        private void SetUpLaporanPenjualan()
        {
            //Update Data
            //string sQuery = "Select ProductShortChild,sum(ConvValue) as Jumlah,sum(convValue*targetquantifier) as Target From vLogOtherReport where salesid = " + dtSales_["salesid"].ToString()
            //                   + " and (tanggal between '"
            //                   + DateTime.Parse(dtBulan_["startdate"].ToString()).ToString("yyyy-MM-dd")
            //                   + "' and '"
            //                   + DateTime.Parse(dtBulan_["enddate"].ToString()).ToString("yyyy-MM-dd") + "')"
            //                   + " and logpelid <> -1 "
            //                   + " and tipeid = 1 and others = 0"
            //                   + " group by productshortchild"
            //                   + " order by productShortChild";
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
            switch (rpvPenjualan.SelectedPage.Text.ToLower())
            {
                case "jadwal sesuai absen":
                    SetUpJadwal();
                    break;
                case "komisi":
                    ProcessComission();
                    break;
                case "daftar penjualan":
                    SetUpDaftarPenjualan();
                    break;
                case "kunjungan":
                    SetUpDaftarKunjungan();
                    break;
            }
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            switch (radPageView1.SelectedPage.Text.ToLower())
            {
                case "total penjualan":
                    SetUpLaporanPenjualan();
                    break;
                case "summary":
                    PrepareLaporan();
                    break;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string value = "0";
            string ori = "0";
            foreach (GridViewSummaryItem item in radGridView2.SummaryRowsTop[0])
            {
                if (item.Name == "JumlahKomisi")
                {
                    value = item.Evaluate(radGridView2.MasterTemplate).ToString();
                }
            }
            foreach (GridViewSummaryItem item in radGridView2.SummaryRowsTop[1])
            {
                if (item.Name == "JumlahKomisi")
                {
                    ori = item.Evaluate(radGridView2.MasterTemplate).ToString();
                }
            }

            //Create Data Komisi Per Sales
            using (sinarekDataSetTableAdapters.salescomissionTableAdapter tbl = new sinarekDataSetTableAdapters.salescomissionTableAdapter())
            {
                tbl.pCreateComissionRecord(int.Parse(dtSales_["salesid"].ToString())
                    , int.Parse(dtBulan_["gbid"].ToString())
                    , decimal.Parse(value)
                    , decimal.Parse(ori)
                    ,targetbulanan,targetharian,pencapaian
                    ,"Komisi", NBConfig.ValidUserName);
            }

            //Create Gaji Komisi Sales if Sales Receive Commision
            using (sinarekDataSetTableAdapters.rinciangajiTableAdapter tbl = new sinarekDataSetTableAdapters.rinciangajiTableAdapter())
            {
                string keterangan = "";
                if (dtSales_["target"].ToString() != "-1")
                {
                    if ((pencapaian / targetbulanan) < 1)
                    {
                        keterangan = "<br />" + "Pencapaian Target : <b><span style='color:red;font-size:20pt;'>" + (pencapaian / targetbulanan).ToString("p") + "</span></b>";
                    }
                    else
                    {
                        keterangan = "<br />" + "Pencapaian Target : <b><span style='font-size:20pt;'>" + (pencapaian / targetbulanan).ToString("p") + "</span></b>";
                    }
                }

                //Komisi Penjualan
                tbl.pCreateSalesComission(int.Parse(dtSales_["salesid"].ToString())
                    , int.Parse(dtBulan_["gbid"].ToString())
                    , 3, 30, NBConfig.ValidUserName, decimal.Parse(value), keterangan);
            }
            helper.NotifMessage("Komisi " + dtSales_["nama"].ToString().ToUpper()  + " telah diperbaharui.");
        }

        private void btnProcessData_Click(object sender, EventArgs e)
        {

        }


    }
}
