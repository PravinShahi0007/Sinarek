namespace NB
{
    partial class frmLihatStock
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.vproductbaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.producttotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dtpTanggal = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rddTipe = new Telerik.WinControls.UI.RadDropDownList();
            this.tipeprodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInput = new Telerik.WinControls.UI.RadButton();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fingermachDataSet = new NB.fingermachDataSet();
            this.vproductbaseTableAdapter = new NB.sinarekDataSetTableAdapters.vproductbaseTableAdapter();
            this.tipeprodTableAdapter = new NB.sinarekDataSetTableAdapters.tipeprodTableAdapter();
            this.staffTableAdapter = new NB.fingermachDataSetTableAdapters.staffTableAdapter();
            this.producttotalTableAdapter = new NB.sinarekDataSetTableAdapters.producttotalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeprodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // vproductbaseBindingSource
            // 
            this.vproductbaseBindingSource.DataMember = "vproductbase";
            this.vproductbaseBindingSource.DataSource = this.sinarekDataSet;
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
            this.radGridView1.Location = new System.Drawing.Point(0, 74);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewDateTimeColumn1.FieldName = "tanggal";
            gridViewDateTimeColumn1.FormatString = "{0:dd MMM yy}";
            gridViewDateTimeColumn1.HeaderText = "Tanggal";
            gridViewDateTimeColumn1.Name = "tanggal";
            gridViewDateTimeColumn1.ReadOnly = true;
            gridViewDateTimeColumn1.Width = 100;
            gridViewComboBoxColumn1.DataSource = this.vproductbaseBindingSource;
            gridViewComboBoxColumn1.DataType = typeof(int);
            gridViewComboBoxColumn1.DisplayMember = "ProductLong";
            gridViewComboBoxColumn1.FieldName = "baseid";
            gridViewComboBoxColumn1.FormatString = "";
            gridViewComboBoxColumn1.HeaderText = "Nama";
            gridViewComboBoxColumn1.Name = "baseid";
            gridViewComboBoxColumn1.ReadOnly = true;
            gridViewComboBoxColumn1.ValueMember = "baseid";
            gridViewComboBoxColumn1.Width = 250;
            gridViewTextBoxColumn1.FieldName = "tipetransaksi";
            gridViewTextBoxColumn1.HeaderText = "Tipe";
            gridViewTextBoxColumn1.Name = "tipetransaksi";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 80;
            gridViewDecimalColumn1.FieldName = "value";
            gridViewDecimalColumn1.FormatString = "{0:#,###.00}";
            gridViewDecimalColumn1.HeaderText = "Jumlah";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "value";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn1.Width = 100;
            gridViewDecimalColumn2.FieldName = "adjustedval";
            gridViewDecimalColumn2.FormatString = "{0:#,###.00}";
            gridViewDecimalColumn2.HeaderText = "Koreksi";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "adjustedval";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn2.Width = 100;
            gridViewTextBoxColumn2.FieldName = "keterangan";
            gridViewTextBoxColumn2.HeaderText = "Keterangan";
            gridViewTextBoxColumn2.Name = "keterangan";
            gridViewTextBoxColumn2.Width = 150;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.FieldName = "totalid";
            gridViewDecimalColumn3.FormatString = "";
            gridViewDecimalColumn3.HeaderText = "totalid";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "totalid";
            gridViewDecimalColumn3.ReadOnly = true;
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDateTimeColumn2.FieldName = "modified";
            gridViewDateTimeColumn2.FormatString = "";
            gridViewDateTimeColumn2.HeaderText = "modified";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.IsVisible = false;
            gridViewDateTimeColumn2.Name = "modified";
            gridViewDateTimeColumn2.ReadOnly = true;
            gridViewTextBoxColumn3.FieldName = "createdby";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "createdby";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "createdby";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewDateTimeColumn3.FieldName = "created";
            gridViewDateTimeColumn3.FormatString = "";
            gridViewDateTimeColumn3.HeaderText = "created";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.IsVisible = false;
            gridViewDateTimeColumn3.Name = "created";
            gridViewDateTimeColumn3.ReadOnly = true;
            gridViewTextBoxColumn4.FieldName = "modifiedby";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "modifiedby";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "modifiedby";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewCheckBoxColumn1.FieldName = "adjusted";
            gridViewCheckBoxColumn1.HeaderText = "adjusted";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.IsVisible = false;
            gridViewCheckBoxColumn1.Name = "adjusted";
            gridViewCheckBoxColumn1.ReadOnly = true;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDateTimeColumn1,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn3,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn3,
            gridViewDateTimeColumn3,
            gridViewTextBoxColumn4,
            gridViewCheckBoxColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.producttotalBindingSource;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(854, 357);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // producttotalBindingSource
            // 
            this.producttotalBindingSource.DataMember = "producttotal";
            this.producttotalBindingSource.DataSource = this.sinarekDataSet;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.dtpTanggal);
            this.radGroupBox1.Controls.Add(this.rddTipe);
            this.radGroupBox1.Controls.Add(this.btnInput);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(854, 74);
            this.radGroupBox1.TabIndex = 1;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(17, 39);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(39, 21);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Tipe :";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(17, 10);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(62, 21);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Tanggal :";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd MMM yyyy";
            this.dtpTanggal.Enabled = false;
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(97, 9);
            this.dtpTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggal.MinDate = new System.DateTime(((long)(0)));
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.NullableValue = new System.DateTime(2012, 4, 18, 16, 35, 0, 511);
            this.dtpTanggal.NullDate = new System.DateTime(((long)(0)));
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
            this.rddTipe.DropDownAnimationEnabled = true;
            this.rddTipe.Enabled = false;
            this.rddTipe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddTipe.Location = new System.Drawing.Point(97, 39);
            this.rddTipe.Name = "rddTipe";
            this.rddTipe.ShowImageInEditorArea = true;
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
            this.btnInput.Location = new System.Drawing.Point(354, 6);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(117, 26);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "&Input";
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
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
            this.fingermachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // producttotalTableAdapter
            // 
            this.producttotalTableAdapter.ClearBeforeFill = true;
            // 
            // frmLihatStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 431);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLihatStock";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Stock Awal Barang";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmLihatTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeprodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource vproductbaseBindingSource;
        private sinarekDataSetTableAdapters.vproductbaseTableAdapter vproductbaseTableAdapter;
        private Telerik.WinControls.UI.RadButton btnInput;
        private Telerik.WinControls.UI.RadDropDownList rddTipe;
        private System.Windows.Forms.BindingSource tipeprodBindingSource;
        private sinarekDataSetTableAdapters.tipeprodTableAdapter tipeprodTableAdapter;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTanggal;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private fingermachDataSet fingermachDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private fingermachDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource producttotalBindingSource;
        private sinarekDataSetTableAdapters.producttotalTableAdapter producttotalTableAdapter;
    }
}
