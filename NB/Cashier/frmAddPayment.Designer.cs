namespace Cashier
{
    partial class frmAddPayment
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtValue = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.lblket1 = new Telerik.WinControls.UI.RadLabel();
            this.lblKet2 = new Telerik.WinControls.UI.RadLabel();
            this.lblket3 = new Telerik.WinControls.UI.RadLabel();
            this.btnSimpan = new Telerik.WinControls.UI.RadButton();
            this.btnBatal = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.rddPayment = new Telerik.WinControls.UI.RadDropDownList();
            this.tipeaccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new Cashier.sinarekDataSet();
            this.tipeaccountTableAdapter = new Cashier.sinarekDataSetTableAdapters.tipeaccountTableAdapter();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.dtpTanggal = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.rddAcc = new Telerik.WinControls.UI.RadDropDownList();
            this.tipeaccountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtKet1 = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtket2 = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtket3 = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtUnit = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.rbtnMasuk = new Telerik.WinControls.UI.RadRadioButton();
            this.rbtnKeluar = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblket3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeaccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeaccountBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtket3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnMasuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnKeluar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 178);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(87, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Nilai :            Rp.";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtValue.Location = new System.Drawing.Point(124, 177);
            this.txtValue.Mask = "n2";
            this.txtValue.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(184, 23);
            this.txtValue.TabIndex = 7;
            this.txtValue.TabStop = false;
            this.txtValue.Text = "0.00";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblket1
            // 
            this.lblket1.Location = new System.Drawing.Point(12, 207);
            this.lblket1.Name = "lblket1";
            this.lblket1.Size = new System.Drawing.Size(69, 18);
            this.lblket1.TabIndex = 2;
            this.lblket1.Text = "Keterangan :";
            // 
            // lblKet2
            // 
            this.lblKet2.Location = new System.Drawing.Point(12, 238);
            this.lblKet2.Name = "lblKet2";
            this.lblKet2.Size = new System.Drawing.Size(37, 18);
            this.lblKet2.TabIndex = 6;
            this.lblKet2.Text = "Ket 2 :";
            // 
            // lblket3
            // 
            this.lblket3.Location = new System.Drawing.Point(12, 267);
            this.lblket3.Name = "lblket3";
            this.lblket3.Size = new System.Drawing.Size(37, 18);
            this.lblket3.TabIndex = 7;
            this.lblket3.Text = "Ket 3 :";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.Location = new System.Drawing.Point(137, 305);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(93, 24);
            this.btnSimpan.TabIndex = 21;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.Location = new System.Drawing.Point(252, 305);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(93, 24);
            this.btnBatal.TabIndex = 22;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 122);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(33, 18);
            this.radLabel2.TabIndex = 10;
            this.radLabel2.Text = "Tipe :";
            // 
            // rddPayment
            // 
            this.rddPayment.AutoCompleteDisplayMember = "Nama";
            this.rddPayment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddPayment.AutoCompleteValueMember = "accountid";
            this.rddPayment.DataSource = this.tipeaccountBindingSource;
            this.rddPayment.DisplayMember = "Nama";
            this.rddPayment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddPayment.Location = new System.Drawing.Point(123, 121);
            this.rddPayment.Name = "rddPayment";
            this.rddPayment.Size = new System.Drawing.Size(185, 23);
            this.rddPayment.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.rddPayment.TabIndex = 5;
            this.rddPayment.ValueMember = "accountid";
            this.rddPayment.SelectedValueChanged += new System.EventHandler(this.rddPayment_SelectedValueChanged);
            // 
            // tipeaccountBindingSource
            // 
            this.tipeaccountBindingSource.DataMember = "tipeaccount";
            this.tipeaccountBindingSource.DataSource = this.sinarekDataSet;
            this.tipeaccountBindingSource.Filter = "payment = 1";
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipeaccountTableAdapter
            // 
            this.tipeaccountTableAdapter.ClearBeforeFill = true;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radButton1.Location = new System.Drawing.Point(22, 305);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(93, 24);
            this.radButton1.TabIndex = 20;
            this.radButton1.Text = "&Next";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 12);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(52, 18);
            this.radLabel3.TabIndex = 13;
            this.radLabel3.Text = "Tanggal :";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd MMM yyyy";
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(123, 9);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(162, 23);
            this.dtpTanggal.TabIndex = 1;
            this.dtpTanggal.TabStop = false;
            this.dtpTanggal.Text = "27 May 2012";
            this.dtpTanggal.Value = new System.DateTime(2012, 5, 27, 23, 33, 32, 86);
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(12, 45);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(53, 18);
            this.radLabel4.TabIndex = 23;
            this.radLabel4.Text = "Account :";
            // 
            // rddAcc
            // 
            this.rddAcc.AutoCompleteDisplayMember = "Nama";
            this.rddAcc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddAcc.AutoCompleteValueMember = "accountid";
            this.rddAcc.DataSource = this.tipeaccountBindingSource1;
            this.rddAcc.DisplayMember = "Nama";
            this.rddAcc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddAcc.Location = new System.Drawing.Point(123, 45);
            this.rddAcc.Name = "rddAcc";
            this.rddAcc.Size = new System.Drawing.Size(185, 23);
            this.rddAcc.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.rddAcc.TabIndex = 2;
            this.rddAcc.ValueMember = "accountid";
            // 
            // tipeaccountBindingSource1
            // 
            this.tipeaccountBindingSource1.DataMember = "tipeaccount";
            this.tipeaccountBindingSource1.DataSource = this.sinarekDataSet;
            this.tipeaccountBindingSource1.Filter = "payment = 0";
            // 
            // txtKet1
            // 
            this.txtKet1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKet1.Location = new System.Drawing.Point(124, 206);
            this.txtKet1.Name = "txtKet1";
            this.txtKet1.Size = new System.Drawing.Size(227, 23);
            this.txtKet1.TabIndex = 8;
            this.txtKet1.TabStop = false;
            // 
            // txtket2
            // 
            this.txtket2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtket2.Location = new System.Drawing.Point(124, 237);
            this.txtket2.Name = "txtket2";
            this.txtket2.Size = new System.Drawing.Size(227, 23);
            this.txtket2.TabIndex = 9;
            this.txtket2.TabStop = false;
            // 
            // txtket3
            // 
            this.txtket3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtket3.Location = new System.Drawing.Point(124, 266);
            this.txtket3.Name = "txtket3";
            this.txtket3.Size = new System.Drawing.Size(227, 23);
            this.txtket3.TabIndex = 10;
            this.txtket3.TabStop = false;
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUnit.Location = new System.Drawing.Point(124, 150);
            this.txtUnit.Mask = "n2";
            this.txtUnit.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(106, 23);
            this.txtUnit.TabIndex = 6;
            this.txtUnit.TabStop = false;
            this.txtUnit.Text = "0.00";
            this.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(12, 151);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(33, 18);
            this.radLabel5.TabIndex = 38;
            this.radLabel5.Text = "Unit :";
            // 
            // rbtnMasuk
            // 
            this.rbtnMasuk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbtnMasuk.Location = new System.Drawing.Point(126, 14);
            this.rbtnMasuk.Name = "rbtnMasuk";
            this.rbtnMasuk.Size = new System.Drawing.Size(61, 21);
            this.rbtnMasuk.TabIndex = 3;
            this.rbtnMasuk.Text = "Masuk";
            // 
            // rbtnKeluar
            // 
            this.rbtnKeluar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbtnKeluar.Location = new System.Drawing.Point(213, 14);
            this.rbtnKeluar.Name = "rbtnKeluar";
            this.rbtnKeluar.Size = new System.Drawing.Size(59, 21);
            this.rbtnKeluar.TabIndex = 4;
            this.rbtnKeluar.Text = "Keluar";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(12, 14);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(82, 18);
            this.radLabel6.TabIndex = 41;
            this.radLabel6.Text = "Tipe Transaksi :";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.rbtnKeluar);
            this.radGroupBox1.Controls.Add(this.rbtnMasuk);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Left;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 70);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(368, 49);
            this.radGroupBox1.TabIndex = 3;
            // 
            // frmAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 347);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.txtket3);
            this.Controls.Add(this.txtket2);
            this.Controls.Add(this.txtKet1);
            this.Controls.Add(this.rddAcc);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.rddPayment);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblket3);
            this.Controls.Add(this.lblKet2);
            this.Controls.Add(this.lblket1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddPayment";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Rincian Transaksi";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAddPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblket3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeaccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeaccountBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtket3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnMasuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnKeluar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadMaskedEditBox txtValue;
        private Telerik.WinControls.UI.RadLabel lblket1;
        private Telerik.WinControls.UI.RadLabel lblKet2;
        private Telerik.WinControls.UI.RadLabel lblket3;
        private Telerik.WinControls.UI.RadButton btnSimpan;
        private Telerik.WinControls.UI.RadButton btnBatal;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList rddPayment;
        private System.Windows.Forms.BindingSource tipeaccountBindingSource;
        private sinarekDataSetTableAdapters.tipeaccountTableAdapter tipeaccountTableAdapter;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTanggal;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList rddAcc;
        private Telerik.WinControls.UI.RadMaskedEditBox txtKet1;
        private Telerik.WinControls.UI.RadMaskedEditBox txtket2;
        private Telerik.WinControls.UI.RadMaskedEditBox txtket3;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource tipeaccountBindingSource1;
        private Telerik.WinControls.UI.RadMaskedEditBox txtUnit;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadRadioButton rbtnMasuk;
        private Telerik.WinControls.UI.RadRadioButton rbtnKeluar;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}
