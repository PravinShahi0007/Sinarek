namespace NB
{
    partial class frmInputLB
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
            this.productbaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rddSales = new Telerik.WinControls.UI.RadDropDownList();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new NB.sinarekDataSetTableAdapters.salesTableAdapter();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dtpTanggal = new Telerik.WinControls.UI.RadDateTimePicker();
            this.logotherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnMulai = new Telerik.WinControls.UI.RadButton();
            this.dtpTglSJ = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.dtpKembali = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.logotherTableAdapter = new NB.sinarekDataSetTableAdapters.logotherTableAdapter();
            this.productbaseTableAdapter = new NB.sinarekDataSetTableAdapters.productbaseTableAdapter();
            this.btnSimpan = new Telerik.WinControls.UI.RadButton();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.txtSuratJalan = new Telerik.WinControls.UI.RadMaskedEditBox();
            ((System.ComponentModel.ISupportInitialize)(this.productbaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logotherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMulai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpKembali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuratJalan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // productbaseBindingSource
            // 
            this.productbaseBindingSource.DataMember = "productbase";
            this.productbaseBindingSource.DataSource = this.sinarekDataSet;
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 60);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(50, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Nama :";
            // 
            // rddSales
            // 
            this.rddSales.AutoCompleteDisplayMember = "Nama";
            this.rddSales.AutoCompleteValueMember = "SalesID";
            this.rddSales.DataSource = this.salesBindingSource;
            this.rddSales.DescriptionTextMember = "Short";
            this.rddSales.DisplayMember = "Nama";
            this.rddSales.DropDownAnimationEnabled = true;
            this.rddSales.Enabled = false;
            this.rddSales.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddSales.Location = new System.Drawing.Point(131, 59);
            this.rddSales.Name = "rddSales";
            this.rddSales.ShowImageInEditorArea = true;
            this.rddSales.Size = new System.Drawing.Size(201, 23);
            this.rddSales.TabIndex = 2;
            this.rddSales.ValueMember = "SalesID";
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.sinarekDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 118);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(83, 21);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Mulai Pakai :";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd MMM yyyy";
            this.dtpTanggal.Enabled = false;
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(131, 117);
            this.dtpTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggal.MinDate = new System.DateTime(((long)(0)));
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.NullableValue = null;
            this.dtpTanggal.NullDate = new System.DateTime(((long)(0)));
            this.dtpTanggal.Size = new System.Drawing.Size(151, 23);
            this.dtpTanggal.TabIndex = 4;
            this.dtpTanggal.TabStop = false;
            this.dtpTanggal.Value = new System.DateTime(((long)(0)));
            // 
            // logotherBindingSource
            // 
            this.logotherBindingSource.DataMember = "logother";
            this.logotherBindingSource.DataSource = this.sinarekDataSet;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 12);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(68, 21);
            this.radLabel3.TabIndex = 12;
            this.radLabel3.Text = "No Trans :";
            // 
            // btnMulai
            // 
            this.btnMulai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMulai.Location = new System.Drawing.Point(343, 10);
            this.btnMulai.Name = "btnMulai";
            this.btnMulai.Size = new System.Drawing.Size(88, 24);
            this.btnMulai.TabIndex = 14;
            this.btnMulai.Text = "&Check";
            this.btnMulai.Click += new System.EventHandler(this.btnMulai_Click);
            // 
            // dtpTglSJ
            // 
            this.dtpTglSJ.CustomFormat = "dd MMM yyyy";
            this.dtpTglSJ.Enabled = false;
            this.dtpTglSJ.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTglSJ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTglSJ.Location = new System.Drawing.Point(131, 88);
            this.dtpTglSJ.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTglSJ.MinDate = new System.DateTime(((long)(0)));
            this.dtpTglSJ.Name = "dtpTglSJ";
            this.dtpTglSJ.NullableValue = null;
            this.dtpTglSJ.NullDate = new System.DateTime(((long)(0)));
            this.dtpTglSJ.Size = new System.Drawing.Size(138, 23);
            this.dtpTglSJ.TabIndex = 3;
            this.dtpTglSJ.TabStop = false;
            this.dtpTglSJ.Value = new System.DateTime(((long)(0)));
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(12, 89);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(78, 21);
            this.radLabel4.TabIndex = 12;
            this.radLabel4.Text = "Tanggal SJ :";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(12, 147);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(115, 21);
            this.radLabel5.TabIndex = 18;
            this.radLabel5.Text = "Tanggal Kembali :";
            // 
            // dtpKembali
            // 
            this.dtpKembali.CustomFormat = "dd MMM yyyy";
            this.dtpKembali.Enabled = false;
            this.dtpKembali.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKembali.Location = new System.Drawing.Point(131, 146);
            this.dtpKembali.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpKembali.MinDate = new System.DateTime(((long)(0)));
            this.dtpKembali.Name = "dtpKembali";
            this.dtpKembali.NullableValue = null;
            this.dtpKembali.NullDate = new System.DateTime(((long)(0)));
            this.dtpKembali.Size = new System.Drawing.Size(151, 23);
            this.dtpKembali.TabIndex = 5;
            this.dtpKembali.TabStop = false;
            this.dtpKembali.Value = new System.DateTime(((long)(0)));
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(288, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 24);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // logotherTableAdapter
            // 
            this.logotherTableAdapter.ClearBeforeFill = true;
            // 
            // productbaseTableAdapter
            // 
            this.productbaseTableAdapter.ClearBeforeFill = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Enabled = false;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.Location = new System.Drawing.Point(73, 191);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(82, 24);
            this.btnSimpan.TabIndex = 20;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(9, 41);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.ShadowOffset = new System.Drawing.Point(0, 0);
            this.radSeparator1.Size = new System.Drawing.Size(425, 18);
            this.radSeparator1.TabIndex = 21;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // txtSuratJalan
            // 
            this.txtSuratJalan.AllowPromptAsInput = false;
            this.txtSuratJalan.AutoSize = true;
            this.txtSuratJalan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSuratJalan.Location = new System.Drawing.Point(131, 11);
            this.txtSuratJalan.Mask = "LL999990";
            this.txtSuratJalan.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtSuratJalan.Name = "txtSuratJalan";
            this.txtSuratJalan.Size = new System.Drawing.Size(150, 23);
            this.txtSuratJalan.TabIndex = 1;
            this.txtSuratJalan.TabStop = false;
            this.txtSuratJalan.Text = "________";
            // 
            // frmInputLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 224);
            this.Controls.Add(this.txtSuratJalan);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.dtpKembali);
            this.Controls.Add(this.dtpTglSJ);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.btnMulai);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rddSales);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmInputLB";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Laporan Penjualan";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmInputLP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productbaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logotherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMulai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTglSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpKembali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuratJalan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList rddSales;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private sinarekDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTanggal;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnMulai;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTglSJ;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadDateTimePicker dtpKembali;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private System.Windows.Forms.BindingSource logotherBindingSource;
        private sinarekDataSetTableAdapters.logotherTableAdapter logotherTableAdapter;
        private System.Windows.Forms.BindingSource productbaseBindingSource;
        private sinarekDataSetTableAdapters.productbaseTableAdapter productbaseTableAdapter;
        private Telerik.WinControls.UI.RadButton btnSimpan;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadMaskedEditBox txtSuratJalan;
    }
}
