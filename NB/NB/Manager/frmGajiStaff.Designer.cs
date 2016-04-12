namespace NB
{
    partial class frmGajiStaff
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
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.reportViewer2 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnTambahan = new Telerik.WinControls.UI.RadButton();
            this.btnPanjar = new Telerik.WinControls.UI.RadButton();
            this.btnInputLembur = new Telerik.WinControls.UI.RadButton();
            this.btnAngsuran = new Telerik.WinControls.UI.RadButton();
            this.btnGajiPokok = new Telerik.WinControls.UI.RadButton();
            this.btnUangMakan = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            this.radPageViewPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambahan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPanjar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInputLembur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAngsuran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGajiPokok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUangMakan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowHistoryButtons = false;
            this.reportViewer1.ShowPrintPreviewButton = false;
            this.reportViewer1.ShowZoom = false;
            this.reportViewer1.Size = new System.Drawing.Size(897, 397);
            this.reportViewer1.TabIndex = 0;
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPageView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radPageView1.Location = new System.Drawing.Point(0, 70);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(918, 448);
            this.radPageView1.TabIndex = 1;
            this.radPageView1.Text = "radPageView1";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.reportViewer1);
            this.radPageViewPage1.Location = new System.Drawing.Point(10, 40);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(897, 397);
            this.radPageViewPage1.Text = "Print Gaji Staff";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Controls.Add(this.reportViewer2);
            this.radPageViewPage2.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(897, 377);
            this.radPageViewPage2.Text = "Print Rangkuman Gaji";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ShowDocumentMapButton = false;
            this.reportViewer2.ShowHistoryButtons = false;
            this.reportViewer2.ShowPageSetupButton = false;
            this.reportViewer2.ShowZoom = false;
            this.reportViewer2.Size = new System.Drawing.Size(897, 377);
            this.reportViewer2.TabIndex = 0;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnUangMakan);
            this.radGroupBox1.Controls.Add(this.btnGajiPokok);
            this.radGroupBox1.Controls.Add(this.btnTambahan);
            this.radGroupBox1.Controls.Add(this.btnPanjar);
            this.radGroupBox1.Controls.Add(this.btnInputLembur);
            this.radGroupBox1.Controls.Add(this.btnAngsuran);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Input";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(918, 64);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Tag = "Add";
            this.radGroupBox1.Text = "Input";
            // 
            // btnTambahan
            // 
            this.btnTambahan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTambahan.Location = new System.Drawing.Point(189, 23);
            this.btnTambahan.Name = "btnTambahan";
            this.btnTambahan.Size = new System.Drawing.Size(128, 26);
            this.btnTambahan.TabIndex = 1;
            this.btnTambahan.Tag = "23";
            this.btnTambahan.Text = "&Tambahan";
            this.btnTambahan.Click += new System.EventHandler(this.btnTambahan_Click);
            // 
            // btnPanjar
            // 
            this.btnPanjar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPanjar.Location = new System.Drawing.Point(352, 23);
            this.btnPanjar.Name = "btnPanjar";
            this.btnPanjar.Size = new System.Drawing.Size(128, 26);
            this.btnPanjar.TabIndex = 3;
            this.btnPanjar.Tag = "29";
            this.btnPanjar.Text = "&Panjar";
            this.btnPanjar.Click += new System.EventHandler(this.btnPanjar_Click);
            // 
            // btnInputLembur
            // 
            this.btnInputLembur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnInputLembur.Location = new System.Drawing.Point(515, 23);
            this.btnInputLembur.Name = "btnInputLembur";
            this.btnInputLembur.Size = new System.Drawing.Size(128, 26);
            this.btnInputLembur.TabIndex = 0;
            this.btnInputLembur.Tag = "24";
            this.btnInputLembur.Text = "&Lembur";
            this.btnInputLembur.Click += new System.EventHandler(this.btnInputLembur_Click);
            // 
            // btnAngsuran
            // 
            this.btnAngsuran.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAngsuran.Location = new System.Drawing.Point(26, 23);
            this.btnAngsuran.Name = "btnAngsuran";
            this.btnAngsuran.Size = new System.Drawing.Size(128, 26);
            this.btnAngsuran.TabIndex = 2;
            this.btnAngsuran.Tag = "5";
            this.btnAngsuran.Text = "&Angsuran Pinjaman";
            this.btnAngsuran.Click += new System.EventHandler(this.btnAngsuran_Click);
            // 
            // btnGajiPokok
            // 
            this.btnGajiPokok.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGajiPokok.Location = new System.Drawing.Point(668, 21);
            this.btnGajiPokok.Name = "btnGajiPokok";
            this.btnGajiPokok.Size = new System.Drawing.Size(105, 26);
            this.btnGajiPokok.TabIndex = 4;
            this.btnGajiPokok.Tag = "1";
            this.btnGajiPokok.Text = "&Gaji Pokok";
            this.btnGajiPokok.Click += new System.EventHandler(this.btnGajiPokok_Click);
            // 
            // btnUangMakan
            // 
            this.btnUangMakan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUangMakan.Location = new System.Drawing.Point(811, 21);
            this.btnUangMakan.Name = "btnUangMakan";
            this.btnUangMakan.Size = new System.Drawing.Size(83, 26);
            this.btnUangMakan.TabIndex = 5;
            this.btnUangMakan.Tag = "13";
            this.btnUangMakan.Text = "&Uang Makan";
            this.btnUangMakan.Click += new System.EventHandler(this.btnUangMakan_Click);
            // 
            // frmGajiStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 518);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radPageView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmGajiStaff";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Gaji Staff";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmGajiStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnTambahan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPanjar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInputLembur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAngsuran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGajiPokok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUangMakan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnTambahan;
        private Telerik.WinControls.UI.RadButton btnPanjar;
        private Telerik.WinControls.UI.RadButton btnInputLembur;
        private Telerik.WinControls.UI.RadButton btnAngsuran;
        private Telerik.WinControls.UI.RadButton btnGajiPokok;
        private Telerik.WinControls.UI.RadButton btnUangMakan;
    }
}
