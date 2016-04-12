namespace NB
{
    partial class frmGajiSatpam
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
            this.components = new System.ComponentModel.Container();
            this.btnInputLembur = new Telerik.WinControls.UI.RadButton();
            this.btnTambahan = new Telerik.WinControls.UI.RadButton();
            this.btnAngsuran = new Telerik.WinControls.UI.RadButton();
            this.btnPanjar = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnPotongan = new Telerik.WinControls.UI.RadButton();
            this.fingermachDataSet = new NB.fingermachDataSet();
            this.vabsengajisatpamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vabsengajisatpamTableAdapter = new NB.fingermachDataSetTableAdapters.vabsengajisatpamTableAdapter();
            this.btnPrintTotal = new Telerik.WinControls.UI.RadButton();
            this.btnPrintSlip = new Telerik.WinControls.UI.RadButton();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.btnInputLembur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambahan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAngsuran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPanjar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPotongan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vabsengajisatpamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintSlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInputLembur
            // 
            this.btnInputLembur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnInputLembur.Location = new System.Drawing.Point(438, 23);
            this.btnInputLembur.Name = "btnInputLembur";
            this.btnInputLembur.Size = new System.Drawing.Size(92, 26);
            this.btnInputLembur.TabIndex = 0;
            this.btnInputLembur.Tag = "27";
            this.btnInputLembur.Text = "&Lembur";
            this.btnInputLembur.Click += new System.EventHandler(this.btnInputLembur_Click);
            // 
            // btnTambahan
            // 
            this.btnTambahan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTambahan.Location = new System.Drawing.Point(176, 23);
            this.btnTambahan.Name = "btnTambahan";
            this.btnTambahan.Size = new System.Drawing.Size(92, 26);
            this.btnTambahan.TabIndex = 1;
            this.btnTambahan.Tag = "23";
            this.btnTambahan.Text = "&Tambahan";
            this.btnTambahan.Click += new System.EventHandler(this.btnTambahan_Click);
            // 
            // btnAngsuran
            // 
            this.btnAngsuran.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAngsuran.Location = new System.Drawing.Point(9, 23);
            this.btnAngsuran.Name = "btnAngsuran";
            this.btnAngsuran.Size = new System.Drawing.Size(128, 26);
            this.btnAngsuran.TabIndex = 2;
            this.btnAngsuran.Tag = "5";
            this.btnAngsuran.Text = "&Angsuran Pinjaman";
            this.btnAngsuran.Click += new System.EventHandler(this.btnAngsuran_Click);
            // 
            // btnPanjar
            // 
            this.btnPanjar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPanjar.Location = new System.Drawing.Point(307, 23);
            this.btnPanjar.Name = "btnPanjar";
            this.btnPanjar.Size = new System.Drawing.Size(92, 26);
            this.btnPanjar.TabIndex = 3;
            this.btnPanjar.Tag = "29";
            this.btnPanjar.Text = "&Panjar";
            this.btnPanjar.Click += new System.EventHandler(this.btnPanjar_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnPotongan);
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
            this.radGroupBox1.Size = new System.Drawing.Size(673, 62);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Tag = "Add";
            this.radGroupBox1.Text = "Input";
            // 
            // btnPotongan
            // 
            this.btnPotongan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPotongan.Location = new System.Drawing.Point(569, 23);
            this.btnPotongan.Name = "btnPotongan";
            this.btnPotongan.Size = new System.Drawing.Size(92, 26);
            this.btnPotongan.TabIndex = 4;
            this.btnPotongan.Tag = "24";
            this.btnPotongan.Text = "P&otongan";
            this.btnPotongan.Click += new System.EventHandler(this.btnPotongan_Click);
            // 
            // fingermachDataSet
            // 
            this.fingermachDataSet.DataSetName = "fingermachDataSet";
            this.fingermachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vabsengajisatpamBindingSource
            // 
            this.vabsengajisatpamBindingSource.DataMember = "vabsengajisatpam";
            this.vabsengajisatpamBindingSource.DataSource = this.fingermachDataSet;
            // 
            // vabsengajisatpamTableAdapter
            // 
            this.vabsengajisatpamTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrintTotal
            // 
            this.btnPrintTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrintTotal.Location = new System.Drawing.Point(21, 68);
            this.btnPrintTotal.Name = "btnPrintTotal";
            this.btnPrintTotal.Size = new System.Drawing.Size(275, 26);
            this.btnPrintTotal.TabIndex = 6;
            this.btnPrintTotal.Text = "Print &Total";
            this.btnPrintTotal.Click += new System.EventHandler(this.btnPrintTotal_Click);
            // 
            // btnPrintSlip
            // 
            this.btnPrintSlip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrintSlip.Location = new System.Drawing.Point(368, 69);
            this.btnPrintSlip.Name = "btnPrintSlip";
            this.btnPrintSlip.Size = new System.Drawing.Size(275, 26);
            this.btnPrintSlip.TabIndex = 7;
            this.btnPrintSlip.Text = "Print &Slip Gaji";
            this.btnPrintSlip.Click += new System.EventHandler(this.btnPrintSlip_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(98, 126);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ParametersAreaVisible = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowPageSetupButton = false;
            this.reportViewer1.ShowParametersButton = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowPrintPreviewButton = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoom = false;
            this.reportViewer1.Size = new System.Drawing.Size(466, 300);
            this.reportViewer1.TabIndex = 8;
            // 
            // frmGajiSatpam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 519);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnPrintSlip);
            this.Controls.Add(this.btnPrintTotal);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmGajiSatpam";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Gaji Bulanan";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmGajiSatpam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnInputLembur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambahan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAngsuran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPanjar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPotongan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vabsengajisatpamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintSlip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnInputLembur;
        private Telerik.WinControls.UI.RadButton btnTambahan;
        private Telerik.WinControls.UI.RadButton btnAngsuran;
        private Telerik.WinControls.UI.RadButton btnPanjar;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.BindingSource vabsengajisatpamBindingSource;
        private fingermachDataSet fingermachDataSet;
        private fingermachDataSetTableAdapters.vabsengajisatpamTableAdapter vabsengajisatpamTableAdapter;
        private Telerik.WinControls.UI.RadButton btnPrintTotal;
        private Telerik.WinControls.UI.RadButton btnPrintSlip;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
        private Telerik.WinControls.UI.RadButton btnPotongan;
    }
}
