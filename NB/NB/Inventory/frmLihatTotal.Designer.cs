namespace NB
{
    partial class frmLihatTotal
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.vproductbaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.producttotaluserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnPrintBSJ = new Telerik.WinControls.UI.RadButton();
            this.btnPrintBJ = new Telerik.WinControls.UI.RadButton();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.rddNama = new Telerik.WinControls.UI.RadDropDownList();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fingermachDataSet = new NB.fingermachDataSet();
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dtpTanggal = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rddTipe = new Telerik.WinControls.UI.RadDropDownList();
            this.tipeprodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInput = new Telerik.WinControls.UI.RadButton();
            this.producttotaluserTableAdapter = new NB.sinarekDataSetTableAdapters.producttotaluserTableAdapter();
            this.vproductbaseTableAdapter = new NB.sinarekDataSetTableAdapters.vproductbaseTableAdapter();
            this.tipeprodTableAdapter = new NB.sinarekDataSetTableAdapters.tipeprodTableAdapter();
            this.staffTableAdapter = new NB.fingermachDataSetTableAdapters.staffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttotaluserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintBSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintBJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddNama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeprodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // vproductbaseBindingSource
            // 
            this.vproductbaseBindingSource.DataMember = "vproductbase";
            this.vproductbaseBindingSource.DataSource = this.sinarekDataSet;
            this.vproductbaseBindingSource.Filter = "active = 1";
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGridView1.Location = new System.Drawing.Point(0, 131);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AllowEditRow = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "totalid";
            gridViewDecimalColumn1.HeaderText = "totalid";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "totalid";
            gridViewDecimalColumn2.DataType = typeof(System.DateTime);
            gridViewDecimalColumn2.FieldName = "tanggal";
            gridViewDecimalColumn2.HeaderText = "tanggal";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "tanggal";
            gridViewTextBoxColumn1.FieldName = "keterangan";
            gridViewTextBoxColumn1.HeaderText = "keterangan";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "keterangan";
            gridViewDateTimeColumn1.FieldName = "modified";
            gridViewDateTimeColumn1.HeaderText = "modified";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.IsVisible = false;
            gridViewDateTimeColumn1.Name = "modified";
            gridViewTextBoxColumn2.FieldName = "createdby";
            gridViewTextBoxColumn2.HeaderText = "createdby";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "createdby";
            gridViewDateTimeColumn2.FieldName = "created";
            gridViewDateTimeColumn2.HeaderText = "created";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.IsVisible = false;
            gridViewDateTimeColumn2.Name = "created";
            gridViewTextBoxColumn3.FieldName = "modifiedby";
            gridViewTextBoxColumn3.HeaderText = "modifiedby";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "modifiedby";
            gridViewComboBoxColumn1.DataSource = this.vproductbaseBindingSource;
            gridViewComboBoxColumn1.DataType = typeof(int);
            gridViewComboBoxColumn1.DisplayMember = "ProductLong";
            gridViewComboBoxColumn1.FieldName = "baseid";
            gridViewComboBoxColumn1.HeaderText = "Nama";
            gridViewComboBoxColumn1.Name = "baseid";
            gridViewComboBoxColumn1.ValueMember = "baseid";
            gridViewComboBoxColumn1.Width = 250;
            gridViewDecimalColumn3.FieldName = "sisa";
            gridViewDecimalColumn3.HeaderText = "Jumlah";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "sisa";
            gridViewDecimalColumn3.ThousandsSeparator = true;
            gridViewDecimalColumn3.Width = 100;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn3,
            gridViewComboBoxColumn1,
            gridViewDecimalColumn3});
            this.radGridView1.MasterTemplate.DataSource = this.producttotaluserBindingSource;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(645, 330);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.radGridView1_UserDeletingRow);
            // 
            // producttotaluserBindingSource
            // 
            this.producttotaluserBindingSource.DataMember = "producttotaluser";
            this.producttotaluserBindingSource.DataSource = this.sinarekDataSet;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnPrintBSJ);
            this.radGroupBox1.Controls.Add(this.btnPrintBJ);
            this.radGroupBox1.Controls.Add(this.radSeparator1);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.rddNama);
            this.radGroupBox1.Controls.Add(this.btnPrint);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.dtpTanggal);
            this.radGroupBox1.Controls.Add(this.rddTipe);
            this.radGroupBox1.Controls.Add(this.btnInput);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(645, 125);
            this.radGroupBox1.TabIndex = 1;
            // 
            // btnPrintBSJ
            // 
            this.btnPrintBSJ.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrintBSJ.Location = new System.Drawing.Point(419, 67);
            this.btnPrintBSJ.Name = "btnPrintBSJ";
            this.btnPrintBSJ.Size = new System.Drawing.Size(216, 26);
            this.btnPrintBSJ.TabIndex = 10;
            this.btnPrintBSJ.Text = "Laporan &Barang Setengah Jadi";
            this.btnPrintBSJ.Click += new System.EventHandler(this.btnPrintBSJ_Click);
            // 
            // btnPrintBJ
            // 
            this.btnPrintBJ.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrintBJ.Location = new System.Drawing.Point(449, 23);
            this.btnPrintBJ.Name = "btnPrintBJ";
            this.btnPrintBJ.Size = new System.Drawing.Size(151, 26);
            this.btnPrintBJ.TabIndex = 9;
            this.btnPrintBJ.Text = "&Laporan Barang Jadi";
            this.btnPrintBJ.Click += new System.EventHandler(this.btnPrintBJ_Click);
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(396, 10);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radSeparator1.Size = new System.Drawing.Size(8, 104);
            this.radSeparator1.TabIndex = 8;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(17, 4);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(41, 18);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "Nama :";
            // 
            // rddNama
            // 
            this.rddNama.AutoCompleteDisplayMember = "logname";
            this.rddNama.AutoCompleteValueMember = "StaffID";
            this.rddNama.DataSource = this.staffBindingSource;
            this.rddNama.DisplayMember = "logname";
            this.rddNama.Enabled = false;
            this.rddNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddNama.Location = new System.Drawing.Point(97, 4);
            this.rddNama.Name = "rddNama";
            this.rddNama.Size = new System.Drawing.Size(177, 23);
            this.rddNama.TabIndex = 1;
            this.rddNama.ValueMember = "StaffID";
            this.rddNama.SelectedValueChanged += new System.EventHandler(this.rddNama_SelectedValueChanged);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.fingermachDataSet;
            this.staffBindingSource.Filter = "active = 1 and logname is not null";
            // 
            // fingermachDataSet
            // 
            this.fingermachDataSet.DataSetName = "fingermachDataSet";
            this.fingermachDataSet.EnforceConstraints = false;
            this.fingermachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrint.Location = new System.Drawing.Point(97, 94);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(177, 26);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "&Print Laporan";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(17, 63);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(33, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Tipe :";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(17, 34);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(52, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Tanggal :";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd MMM yyyy";
            this.dtpTanggal.Enabled = false;
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(97, 33);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(148, 23);
            this.dtpTanggal.TabIndex = 2;
            this.dtpTanggal.TabStop = false;
            this.dtpTanggal.Text = "18 Apr 2012";
            this.dtpTanggal.Value = new System.DateTime(2012, 4, 18, 16, 35, 0, 511);
            this.dtpTanggal.ValueChanged += new System.EventHandler(this.dtpTanggal_ValueChanged);
            // 
            // rddTipe
            // 
            this.rddTipe.AutoCompleteDisplayMember = "Description";
            this.rddTipe.AutoCompleteValueMember = "tipeid";
            this.rddTipe.DataSource = this.tipeprodBindingSource;
            this.rddTipe.DescriptionTextMember = "Name";
            this.rddTipe.DisplayMember = "Description";
            this.rddTipe.Enabled = false;
            this.rddTipe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddTipe.Location = new System.Drawing.Point(97, 63);
            this.rddTipe.Name = "rddTipe";
            this.rddTipe.Size = new System.Drawing.Size(177, 23);
            this.rddTipe.TabIndex = 3;
            this.rddTipe.ValueMember = "tipeid";
            this.rddTipe.SelectedValueChanged += new System.EventHandler(this.rddTipe_SelectedValueChanged);
            // 
            // tipeprodBindingSource
            // 
            this.tipeprodBindingSource.DataMember = "tipeprod";
            this.tipeprodBindingSource.DataSource = this.sinarekDataSet;
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnInput.Location = new System.Drawing.Point(289, 6);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(78, 26);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "&Input";
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // producttotaluserTableAdapter
            // 
            this.producttotaluserTableAdapter.ClearBeforeFill = true;
            // 
            // vproductbaseTableAdapter
            // 
            this.vproductbaseTableAdapter.ClearBeforeFill = true;
            // 
            // tipeprodTableAdapter
            // 
            this.tipeprodTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // frmLihatTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 461);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLihatTotal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Laporan Sisa Barang";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmLihatTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttotaluserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintBSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintBJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddNama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeprodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource producttotaluserBindingSource;
        private sinarekDataSetTableAdapters.producttotaluserTableAdapter producttotaluserTableAdapter;
        private System.Windows.Forms.BindingSource vproductbaseBindingSource;
        private sinarekDataSetTableAdapters.vproductbaseTableAdapter vproductbaseTableAdapter;
        private Telerik.WinControls.UI.RadButton btnInput;
        private Telerik.WinControls.UI.RadDropDownList rddTipe;
        private System.Windows.Forms.BindingSource tipeprodBindingSource;
        private sinarekDataSetTableAdapters.tipeprodTableAdapter tipeprodTableAdapter;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTanggal;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList rddNama;
        private fingermachDataSet fingermachDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private fingermachDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private Telerik.WinControls.UI.RadButton btnPrintBSJ;
        private Telerik.WinControls.UI.RadButton btnPrintBJ;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
    }
}
