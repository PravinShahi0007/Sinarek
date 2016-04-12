namespace Cashier
{
    partial class frmKasBesar
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnMasuk = new Telerik.WinControls.UI.RadButton();
            this.btnTutup = new Telerik.WinControls.UI.RadButton();
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            this.radgridKas = new Telerik.WinControls.UI.RadGridView();
            this.vacctransBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new Cashier.sinarekDataSet();
            this.acctransBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCash = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.dtpTanggal = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.btnKeluar = new Telerik.WinControls.UI.RadButton();
            this.acctransTableAdapter = new Cashier.sinarekDataSetTableAdapters.acctransTableAdapter();
            this.vacctransTableAdapter = new Cashier.sinarekDataSetTableAdapters.vacctransTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.btnMasuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTutup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgridKas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgridKas.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacctransBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acctransBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKeluar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMasuk
            // 
            this.btnMasuk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMasuk.Location = new System.Drawing.Point(240, 12);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(100, 24);
            this.btnMasuk.TabIndex = 5;
            this.btnMasuk.Text = "&Masuk";
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTutup.Location = new System.Drawing.Point(485, 12);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(130, 24);
            this.btnTutup.TabIndex = 7;
            this.btnTutup.Text = "&Tutup Kasir";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrint.Location = new System.Drawing.Point(639, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 24);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "&Print Statement";
            // 
            // radgridKas
            // 
            this.radgridKas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radgridKas.Location = new System.Drawing.Point(12, 112);
            // 
            // 
            // 
            this.radgridKas.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.radgridKas.Name = "radgridKas";
            this.radgridKas.ShowGroupPanel = false;
            this.radgridKas.Size = new System.Drawing.Size(646, 437);
            this.radgridKas.TabIndex = 10;
            this.radgridKas.Text = "radGridView1";
            // 
            // vacctransBindingSource
            // 
            this.vacctransBindingSource.DataMember = "vacctrans";
            this.vacctransBindingSource.DataSource = this.sinarekDataSet;
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acctransBindingSource
            // 
            this.acctransBindingSource.DataMember = "acctrans";
            this.acctransBindingSource.DataSource = this.sinarekDataSet;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = false;
            this.lblCash.Location = new System.Drawing.Point(6, 56);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(652, 50);
            this.lblCash.TabIndex = 11;
            this.lblCash.Text = "<html><b>Total Kas :</b> </html>";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.dtpTanggal);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radSeparator1);
            this.radGroupBox1.Controls.Add(this.btnKeluar);
            this.radGroupBox1.Controls.Add(this.btnTutup);
            this.radGroupBox1.Controls.Add(this.btnMasuk);
            this.radGroupBox1.Controls.Add(this.btnPrint);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(782, 46);
            this.radGroupBox1.TabIndex = 15;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd MMM yyyy";
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(80, 13);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(150, 23);
            this.dtpTanggal.TabIndex = 13;
            this.dtpTanggal.TabStop = false;
            this.dtpTanggal.Text = "22 Feb 2016";
            this.dtpTanggal.Value = new System.DateTime(2016, 2, 22, 0, 0, 0, 0);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(11, 14);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(52, 18);
            this.radLabel1.TabIndex = 12;
            this.radLabel1.Text = "Tanggal :";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(470, 4);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radSeparator1.Size = new System.Drawing.Size(8, 38);
            this.radSeparator1.TabIndex = 11;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // btnKeluar
            // 
            this.btnKeluar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKeluar.Location = new System.Drawing.Point(357, 12);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(103, 24);
            this.btnKeluar.TabIndex = 10;
            this.btnKeluar.Text = "&Keluar";
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // acctransTableAdapter
            // 
            this.acctransTableAdapter.ClearBeforeFill = true;
            // 
            // vacctransTableAdapter
            // 
            this.vacctransTableAdapter.ClearBeforeFill = true;
            // 
            // frmKasBesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 561);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.radgridKas);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKasBesar";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Journal Harian";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmKasBesar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMasuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTutup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgridKas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radgridKas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacctransBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acctransBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKeluar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnMasuk;
        private Telerik.WinControls.UI.RadButton btnTutup;
        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.UI.RadGridView radgridKas;
        private Telerik.WinControls.UI.RadLabel lblCash;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnKeluar;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource acctransBindingSource;
        private sinarekDataSetTableAdapters.acctransTableAdapter acctransTableAdapter;
        private System.Windows.Forms.BindingSource vacctransBindingSource;
        private sinarekDataSetTableAdapters.vacctransTableAdapter vacctransTableAdapter;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTanggal;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
