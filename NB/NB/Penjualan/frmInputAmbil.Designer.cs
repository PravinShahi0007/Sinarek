namespace NB
{
    partial class frmInputAmbil
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
            this.rddNama = new Telerik.WinControls.UI.RadDropDownList();
            this.rddMobil = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.vallsupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vallsupTableAdapter = new NB.sinarekDataSetTableAdapters.vallsupTableAdapter();
            this.txtJumlah = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.mobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobilTableAdapter = new NB.sinarekDataSetTableAdapters.mobilTableAdapter();
            this.btnSimpan = new Telerik.WinControls.UI.RadButton();
            this.txtKeterangan = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.btnBatal = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rddNama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddMobil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vallsupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeterangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rddNama
            // 
            this.rddNama.AutoCompleteDisplayMember = "Nama";
            this.rddNama.AutoCompleteValueMember = "Nama";
            this.rddNama.DataSource = this.vallsupBindingSource;
            this.rddNama.DisplayMember = "Nama";
            this.rddNama.DropDownAnimationEnabled = true;
            this.rddNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddNama.Location = new System.Drawing.Point(101, 8);
            this.rddNama.Name = "rddNama";
            this.rddNama.ShowImageInEditorArea = true;
            this.rddNama.Size = new System.Drawing.Size(245, 23);
            this.rddNama.TabIndex = 0;
            this.rddNama.ValueMember = "Nama";
            // 
            // rddMobil
            // 
            this.rddMobil.AutoCompleteDisplayMember = "NoPolis";
            this.rddMobil.AutoCompleteValueMember = "NoPolis";
            this.rddMobil.DataSource = this.mobilBindingSource;
            this.rddMobil.DisplayMember = "NoPolis";
            this.rddMobil.DropDownAnimationEnabled = true;
            this.rddMobil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddMobil.Location = new System.Drawing.Point(101, 54);
            this.rddMobil.Name = "rddMobil";
            this.rddMobil.ShowImageInEditorArea = true;
            this.rddMobil.Size = new System.Drawing.Size(245, 23);
            this.rddMobil.TabIndex = 1;
            this.rddMobil.ValueMember = "NoPolis";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(18, 9);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(50, 21);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Nama :";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(18, 55);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(78, 21);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Kendaraan :";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(18, 100);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(56, 21);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Jumlah :";
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vallsupBindingSource
            // 
            this.vallsupBindingSource.DataMember = "vallsup";
            this.vallsupBindingSource.DataSource = this.sinarekDataSet;
            this.vallsupBindingSource.Filter = "custtypeid in (3,4)";
            // 
            // vallsupTableAdapter
            // 
            this.vallsupTableAdapter.ClearBeforeFill = true;
            // 
            // txtJumlah
            // 
            this.txtJumlah.AllowPromptAsInput = false;
            this.txtJumlah.AutoSize = true;
            this.txtJumlah.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtJumlah.Location = new System.Drawing.Point(101, 99);
            this.txtJumlah.Mask = "n2";
            this.txtJumlah.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(141, 23);
            this.txtJumlah.TabIndex = 5;
            this.txtJumlah.TabStop = false;
            this.txtJumlah.Text = "0.00";
            this.txtJumlah.Value = "0.00";
            // 
            // mobilBindingSource
            // 
            this.mobilBindingSource.DataMember = "mobil";
            this.mobilBindingSource.DataSource = this.sinarekDataSet;
            // 
            // mobilTableAdapter
            // 
            this.mobilTableAdapter.ClearBeforeFill = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.Location = new System.Drawing.Point(21, 182);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(138, 31);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "&Simpan && Print";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.AllowPromptAsInput = false;
            this.txtKeterangan.AutoSize = true;
            this.txtKeterangan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKeterangan.Location = new System.Drawing.Point(101, 144);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(244, 23);
            this.txtKeterangan.TabIndex = 8;
            this.txtKeterangan.TabStop = false;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(18, 145);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(83, 21);
            this.radLabel4.TabIndex = 7;
            this.radLabel4.Text = "Keterangan :";
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.Location = new System.Drawing.Point(206, 182);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(138, 31);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // frmInputAmbil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 231);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rddMobil);
            this.Controls.Add(this.rddNama);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmInputAmbil";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ambil Uang Belanja";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmInputAmbil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rddNama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddMobil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vallsupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeterangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList rddNama;
        private Telerik.WinControls.UI.RadDropDownList rddMobil;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource vallsupBindingSource;
        private sinarekDataSetTableAdapters.vallsupTableAdapter vallsupTableAdapter;
        private Telerik.WinControls.UI.RadMaskedEditBox txtJumlah;
        private System.Windows.Forms.BindingSource mobilBindingSource;
        private sinarekDataSetTableAdapters.mobilTableAdapter mobilTableAdapter;
        private Telerik.WinControls.UI.RadButton btnSimpan;
        private Telerik.WinControls.UI.RadMaskedEditBox txtKeterangan;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton btnBatal;
    }
}
