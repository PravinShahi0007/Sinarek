namespace NB
{
    partial class frmSalesPerformanceReview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle2 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.rpvTotalPenjualan = new Telerik.WinControls.UI.RadPageViewPage();
            this.radGridView4 = new Telerik.WinControls.UI.RadGridView();
            this.rpvLaporanKunjungan = new Telerik.WinControls.UI.RadPageViewPage();
            this.lblKunjungan = new Telerik.WinControls.UI.RadLabel();
            this.rpvSummary = new Telerik.WinControls.UI.RadPageViewPage();
            this.btnProcessData = new Telerik.WinControls.UI.RadButton();
            this.lblBulan = new Telerik.WinControls.UI.RadLabel();
            this.btnProcess = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rpvPenjualan = new Telerik.WinControls.UI.RadPageView();
            this.radPagePenjualan = new Telerik.WinControls.UI.RadPageViewPage();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.rpvReturn = new Telerik.WinControls.UI.RadPageViewPage();
            this.radGridView3 = new Telerik.WinControls.UI.RadGridView();
            this.rpvJadwal = new Telerik.WinControls.UI.RadPageViewPage();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.rpvKomisi = new Telerik.WinControls.UI.RadPageViewPage();
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            this.rpvKunjungan = new Telerik.WinControls.UI.RadPageViewPage();
            this.radGridView5 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.rpvTotalPenjualan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView4.MasterTemplate)).BeginInit();
            this.rpvLaporanKunjungan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblKunjungan)).BeginInit();
            this.rpvSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcessData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBulan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpvPenjualan)).BeginInit();
            this.rpvPenjualan.SuspendLayout();
            this.radPagePenjualan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.rpvReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView3.MasterTemplate)).BeginInit();
            this.rpvJadwal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            this.rpvKomisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).BeginInit();
            this.rpvKunjungan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView5.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.rpvTotalPenjualan);
            this.radPageView1.Controls.Add(this.rpvLaporanKunjungan);
            this.radPageView1.Controls.Add(this.rpvSummary);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.ItemSizeMode = ((Telerik.WinControls.UI.PageViewItemSizeMode)((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth | Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight)));
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.rpvSummary;
            this.radPageView1.Size = new System.Drawing.Size(298, 496);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack;
            this.radPageView1.SelectedPageChanged += new System.EventHandler(this.radPageView1_SelectedPageChanged);
            // 
            // rpvTotalPenjualan
            // 
            this.rpvTotalPenjualan.Controls.Add(this.radGridView4);
            this.rpvTotalPenjualan.ItemSize = new System.Drawing.SizeF(298F, 32F);
            this.rpvTotalPenjualan.Location = new System.Drawing.Point(5, 29);
            this.rpvTotalPenjualan.Name = "rpvTotalPenjualan";
            this.rpvTotalPenjualan.Size = new System.Drawing.Size(288, 370);
            this.rpvTotalPenjualan.Text = "Total Penjualan";
            // 
            // radGridView4
            // 
            this.radGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView4.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridView4
            // 
            this.radGridView4.MasterTemplate.AllowAddNewRow = false;
            this.radGridView4.MasterTemplate.AllowColumnReorder = false;
            this.radGridView4.Name = "radGridView4";
            this.radGridView4.ReadOnly = true;
            this.radGridView4.ShowGroupPanel = false;
            this.radGridView4.Size = new System.Drawing.Size(288, 370);
            this.radGridView4.TabIndex = 0;
            this.radGridView4.Text = "radGridView4";
            // 
            // rpvLaporanKunjungan
            // 
            this.rpvLaporanKunjungan.Controls.Add(this.lblKunjungan);
            this.rpvLaporanKunjungan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rpvLaporanKunjungan.ItemSize = new System.Drawing.SizeF(298F, 32F);
            this.rpvLaporanKunjungan.Location = new System.Drawing.Point(5, 29);
            this.rpvLaporanKunjungan.Name = "rpvLaporanKunjungan";
            this.rpvLaporanKunjungan.Size = new System.Drawing.Size(288, 370);
            this.rpvLaporanKunjungan.Text = "Laporan Kunjungan";
            // 
            // lblKunjungan
            // 
            this.lblKunjungan.Location = new System.Drawing.Point(7, 11);
            this.lblKunjungan.Name = "lblKunjungan";
            this.lblKunjungan.Size = new System.Drawing.Size(168, 21);
            this.lblKunjungan.TabIndex = 2;
            this.lblKunjungan.Text = "Penjualan Bulan June 2012";
            // 
            // rpvSummary
            // 
            this.rpvSummary.Controls.Add(this.btnProcessData);
            this.rpvSummary.Controls.Add(this.lblBulan);
            this.rpvSummary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rpvSummary.ItemSize = new System.Drawing.SizeF(298F, 32F);
            this.rpvSummary.Location = new System.Drawing.Point(5, 29);
            this.rpvSummary.Name = "rpvSummary";
            this.rpvSummary.Size = new System.Drawing.Size(288, 370);
            this.rpvSummary.Text = "Summary";
            // 
            // btnProcessData
            // 
            this.btnProcessData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcessData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProcessData.Location = new System.Drawing.Point(0, 0);
            this.btnProcessData.Name = "btnProcessData";
            this.btnProcessData.Size = new System.Drawing.Size(288, 32);
            this.btnProcessData.TabIndex = 2;
            this.btnProcessData.Text = "&Refresh";
            this.btnProcessData.Click += new System.EventHandler(this.btnProcessData_Click);
            // 
            // lblBulan
            // 
            this.lblBulan.Location = new System.Drawing.Point(5, 36);
            this.lblBulan.Name = "lblBulan";
            this.lblBulan.Size = new System.Drawing.Size(86, 18);
            this.lblBulan.TabIndex = 1;
            this.lblBulan.Text = "Penjualan Bulan";
            // 
            // btnProcess
            // 
            this.btnProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProcess.Location = new System.Drawing.Point(0, 0);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(701, 37);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "&Process Komisi";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radPageView1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.Size = new System.Drawing.Size(298, 496);
            this.radGroupBox1.TabIndex = 1;
            // 
            // rpvPenjualan
            // 
            this.rpvPenjualan.Controls.Add(this.radPagePenjualan);
            this.rpvPenjualan.Controls.Add(this.rpvReturn);
            this.rpvPenjualan.Controls.Add(this.rpvJadwal);
            this.rpvPenjualan.Controls.Add(this.rpvKomisi);
            this.rpvPenjualan.Controls.Add(this.rpvKunjungan);
            this.rpvPenjualan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvPenjualan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rpvPenjualan.Location = new System.Drawing.Point(298, 0);
            this.rpvPenjualan.Name = "rpvPenjualan";
            this.rpvPenjualan.SelectedPage = this.rpvKomisi;
            this.rpvPenjualan.Size = new System.Drawing.Size(722, 496);
            this.rpvPenjualan.TabIndex = 2;
            this.rpvPenjualan.Text = "radPageView2";
            this.rpvPenjualan.SelectedPageChanged += new System.EventHandler(this.radPageView2_SelectedPageChanged);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.rpvPenjualan.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // radPagePenjualan
            // 
            this.radPagePenjualan.Controls.Add(this.radGridView1);
            this.radPagePenjualan.ItemSize = new System.Drawing.SizeF(117F, 31F);
            this.radPagePenjualan.Location = new System.Drawing.Point(10, 40);
            this.radPagePenjualan.Name = "radPagePenjualan";
            this.radPagePenjualan.Size = new System.Drawing.Size(701, 445);
            this.radPagePenjualan.Text = "Daftar Penjualan";
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(701, 445);
            this.radGridView1.StandardTab = true;
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // rpvReturn
            // 
            this.rpvReturn.Controls.Add(this.radGridView3);
            this.rpvReturn.ItemSize = new System.Drawing.SizeF(104F, 31F);
            this.rpvReturn.Location = new System.Drawing.Point(10, 40);
            this.rpvReturn.Name = "rpvReturn";
            this.rpvReturn.Size = new System.Drawing.Size(701, 445);
            this.rpvReturn.Text = "Barang Return";
            // 
            // radGridView3
            // 
            this.radGridView3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGridView3.Location = new System.Drawing.Point(0, 75);
            this.radGridView3.Name = "radGridView3";
            this.radGridView3.Size = new System.Drawing.Size(701, 370);
            this.radGridView3.TabIndex = 1;
            this.radGridView3.Text = "radGridView3";
            // 
            // rpvJadwal
            // 
            this.rpvJadwal.Controls.Add(this.radScheduler1);
            this.rpvJadwal.ItemSize = new System.Drawing.SizeF(141F, 31F);
            this.rpvJadwal.Location = new System.Drawing.Point(10, 40);
            this.rpvJadwal.Name = "rpvJadwal";
            this.rpvJadwal.Size = new System.Drawing.Size(701, 445);
            this.rpvJadwal.Text = "Jadwal Sesuai Absen";
            // 
            // radScheduler1
            // 
            this.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Month;
            this.radScheduler1.AppointmentTitleFormat = null;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.FocusedDate = new System.DateTime(2012, 6, 1, 0, 0, 0, 0);
            this.radScheduler1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radScheduler1.HighlightToday = false;
            this.radScheduler1.Location = new System.Drawing.Point(0, 0);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle2.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle2.DateEndRange = new System.DateTime(2013, 1, 6, 0, 0, 0, 0);
            schedulerDailyPrintStyle2.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle2.DateStartRange = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            schedulerDailyPrintStyle2.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle2;
            this.radScheduler1.ReadOnly = true;
            this.radScheduler1.ShowAppointmentStatus = false;
            this.radScheduler1.ShowNavigationElements = false;
            this.radScheduler1.Size = new System.Drawing.Size(701, 445);
            this.radScheduler1.TabIndex = 0;
            this.radScheduler1.Text = "radScheduler1";
            // 
            // rpvKomisi
            // 
            this.rpvKomisi.Controls.Add(this.btnProcess);
            this.rpvKomisi.Controls.Add(this.radGridView2);
            this.rpvKomisi.ItemSize = new System.Drawing.SizeF(57F, 31F);
            this.rpvKomisi.Location = new System.Drawing.Point(10, 40);
            this.rpvKomisi.Name = "rpvKomisi";
            this.rpvKomisi.Size = new System.Drawing.Size(701, 445);
            this.rpvKomisi.Text = "Komisi";
            // 
            // radGridView2
            // 
            this.radGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGridView2.Location = new System.Drawing.Point(0, 37);
            // 
            // radGridView2
            // 
            this.radGridView2.MasterTemplate.AllowAddNewRow = false;
            this.radGridView2.MasterTemplate.AllowColumnReorder = false;
            this.radGridView2.Name = "radGridView2";
            this.radGridView2.ReadOnly = true;
            this.radGridView2.ShowGroupPanel = false;
            this.radGridView2.Size = new System.Drawing.Size(701, 408);
            this.radGridView2.TabIndex = 1;
            this.radGridView2.Text = "radGridView2";
            // 
            // rpvKunjungan
            // 
            this.rpvKunjungan.Controls.Add(this.radGridView5);
            this.rpvKunjungan.ItemSize = new System.Drawing.SizeF(82F, 31F);
            this.rpvKunjungan.Location = new System.Drawing.Point(10, 40);
            this.rpvKunjungan.Name = "rpvKunjungan";
            this.rpvKunjungan.Size = new System.Drawing.Size(701, 445);
            this.rpvKunjungan.Text = "Kunjungan";
            // 
            // radGridView5
            // 
            this.radGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView5.Location = new System.Drawing.Point(0, 0);
            this.radGridView5.Name = "radGridView5";
            this.radGridView5.Size = new System.Drawing.Size(701, 445);
            this.radGridView5.TabIndex = 0;
            this.radGridView5.Text = "radGridView5";
            // 
            // frmSalesPerformanceReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 496);
            this.Controls.Add(this.rpvPenjualan);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSalesPerformanceReview";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Sales Performance";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmSalesPerformanceReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.rpvTotalPenjualan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView4.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView4)).EndInit();
            this.rpvLaporanKunjungan.ResumeLayout(false);
            this.rpvLaporanKunjungan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblKunjungan)).EndInit();
            this.rpvSummary.ResumeLayout(false);
            this.rpvSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcessData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBulan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rpvPenjualan)).EndInit();
            this.rpvPenjualan.ResumeLayout(false);
            this.radPagePenjualan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.rpvReturn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView3.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView3)).EndInit();
            this.rpvJadwal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            this.rpvKomisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            this.rpvKunjungan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView5.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage rpvTotalPenjualan;
        private Telerik.WinControls.UI.RadPageViewPage rpvLaporanKunjungan;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnProcess;
        private Telerik.WinControls.UI.RadLabel lblBulan;
        private Telerik.WinControls.UI.RadPageView rpvPenjualan;
        private Telerik.WinControls.UI.RadPageViewPage radPagePenjualan;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadPageViewPage rpvReturn;
        private Telerik.WinControls.UI.RadGridView radGridView4;
        private Telerik.WinControls.UI.RadGridView radGridView3;
        private Telerik.WinControls.UI.RadPageViewPage rpvSummary;
        private Telerik.WinControls.UI.RadLabel lblKunjungan;
        private Telerik.WinControls.UI.RadPageViewPage rpvJadwal;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadPageViewPage rpvKomisi;
        private Telerik.WinControls.UI.RadGridView radGridView2;
        private Telerik.WinControls.UI.RadButton btnProcessData;
        private Telerik.WinControls.UI.RadPageViewPage rpvKunjungan;
        private Telerik.WinControls.UI.RadGridView radGridView5;
    }
}
