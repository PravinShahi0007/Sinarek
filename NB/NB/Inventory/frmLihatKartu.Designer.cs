namespace NB
{
    partial class frmLihatKartu
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem2 = new Telerik.WinControls.UI.GridViewSummaryItem();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.vperhitunganbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.vlogproductdetaillapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rddProduct = new Telerik.WinControls.UI.RadDropDownList();
            this.vproductbaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dtpTanggal = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblTanggal = new Telerik.WinControls.UI.RadLabel();
            this.vproductbaseTableAdapter = new NB.sinarekDataSetTableAdapters.vproductbaseTableAdapter();
            this.vperhitunganbarangTableAdapter = new NB.sinarekDataSetTableAdapters.vperhitunganbarangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vperhitunganbarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlogproductdetaillapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGridView1.Location = new System.Drawing.Point(0, 62);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FieldName = "NoSJ";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "No SJ";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "NoSJ";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "TransTypeName";
            gridViewTextBoxColumn2.HeaderText = "Tipe";
            gridViewTextBoxColumn2.Name = "TransTypeName";
            gridViewTextBoxColumn2.Width = 100;
            gridViewDateTimeColumn1.FieldName = "Tanggal";
            gridViewDateTimeColumn1.FormatString = "{0:dd MMM yy}";
            gridViewDateTimeColumn1.HeaderText = "Tanggal";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "Tanggal";
            gridViewDateTimeColumn1.Width = 100;
            gridViewTextBoxColumn3.FieldName = "CUSTNAME";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Nama";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "CUSTNAME";
            gridViewTextBoxColumn3.Width = 150;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.Expression = "";
            gridViewDecimalColumn1.FieldName = "quantity";
            gridViewDecimalColumn1.FormatString = "{0:#,##0.00}";
            gridViewDecimalColumn1.HeaderText = "Jumlah";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "quantity";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn1.ThousandsSeparator = true;
            gridViewDecimalColumn1.Width = 100;
            gridViewDecimalColumn2.FieldName = "Masuk";
            gridViewDecimalColumn2.FormatString = "{0:#,##0.00}";
            gridViewDecimalColumn2.HeaderText = "Masuk";
            gridViewDecimalColumn2.Name = "Masuk";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn2.Width = 100;
            gridViewDecimalColumn3.FieldName = "Keluar";
            gridViewDecimalColumn3.FormatString = "{0:#,##0.00}";
            gridViewDecimalColumn3.HeaderText = "Keluar";
            gridViewDecimalColumn3.Name = "Keluar";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "namastatusbarang";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Status";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "namastatusbarang";
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.FieldName = "keterangan";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Keterangan";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "keterangandetail";
            gridViewTextBoxColumn5.Width = 150;
            gridViewTextBoxColumn6.FieldName = "ModifiedBy";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "ModifiedBy";
            gridViewTextBoxColumn7.EnableExpressionEditor = true;
            gridViewTextBoxColumn7.Expression = "productshort + \" ( \" + unitshort + \")\"";
            gridViewTextBoxColumn7.FieldName = "productshort";
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "Barang";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "productname";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 120;
            gridViewDecimalColumn4.DataType = typeof(long);
            gridViewDecimalColumn4.FieldName = "Logid";
            gridViewDecimalColumn4.FormatString = "";
            gridViewDecimalColumn4.HeaderText = "Logid";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "Logid";
            gridViewDecimalColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDateTimeColumn2.FieldName = "created";
            gridViewDateTimeColumn2.HeaderText = "created";
            gridViewDateTimeColumn2.IsVisible = false;
            gridViewDateTimeColumn2.Name = "created";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn4,
            gridViewDateTimeColumn2});
            this.radGridView1.MasterTemplate.DataSource = this.vperhitunganbarangBindingSource;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            gridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem1.FormatString = "Total : {0:#,###.00}";
            gridViewSummaryItem1.Name = "Masuk";
            gridViewSummaryItem2.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem2.FormatString = "Total : {0:#,###.00}";
            gridViewSummaryItem2.Name = "Keluar";
            this.radGridView1.MasterTemplate.SummaryRowsTop.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1,
                gridViewSummaryItem2}));
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(1054, 454);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // vperhitunganbarangBindingSource
            // 
            this.vperhitunganbarangBindingSource.DataMember = "vperhitunganbarang";
            this.vperhitunganbarangBindingSource.DataSource = this.sinarekDataSet;
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rddProduct
            // 
            this.rddProduct.AutoCompleteDisplayMember = "ProductLong";
            this.rddProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddProduct.AutoCompleteValueMember = "baseid";
            this.rddProduct.DataSource = this.vproductbaseBindingSource;
            this.rddProduct.DisplayMember = "ProductLong";
            this.rddProduct.DropDownAnimationEnabled = true;
            this.rddProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddProduct.Location = new System.Drawing.Point(67, 19);
            this.rddProduct.Name = "rddProduct";
            this.rddProduct.ShowImageInEditorArea = true;
            this.rddProduct.Size = new System.Drawing.Size(242, 23);
            this.rddProduct.TabIndex = 1;
            this.rddProduct.ValueMember = "baseid";
            this.rddProduct.SelectedValueChanged += new System.EventHandler(this.rddProduct_SelectedValueChanged);
            // 
            // vproductbaseBindingSource
            // 
            this.vproductbaseBindingSource.DataMember = "vproductbase";
            this.vproductbaseBindingSource.DataSource = this.sinarekDataSet;
            this.vproductbaseBindingSource.Filter = "tipeid = 1";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 19);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(47, 21);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Stock :";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTanggal.Location = new System.Drawing.Point(395, 19);
            this.dtpTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggal.MinDate = new System.DateTime(((long)(0)));
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.NullableValue = new System.DateTime(2012, 5, 15, 9, 41, 11, 776);
            this.dtpTanggal.NullDate = new System.DateTime(((long)(0)));
            this.dtpTanggal.Size = new System.Drawing.Size(190, 23);
            this.dtpTanggal.TabIndex = 3;
            this.dtpTanggal.TabStop = false;
            this.dtpTanggal.Text = "Tuesday, May 15, 2012";
            this.dtpTanggal.Value = new System.DateTime(2012, 5, 15, 9, 41, 11, 776);
            this.dtpTanggal.ValueChanged += new System.EventHandler(this.dtpTanggal_ValueChanged);
            // 
            // lblTanggal
            // 
            this.lblTanggal.Location = new System.Drawing.Point(315, 19);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(62, 21);
            this.lblTanggal.TabIndex = 4;
            this.lblTanggal.Text = "Tanggal :";
            // 
            // vproductbaseTableAdapter
            // 
            this.vproductbaseTableAdapter.ClearBeforeFill = true;
            // 
            // vperhitunganbarangTableAdapter
            // 
            this.vperhitunganbarangTableAdapter.ClearBeforeFill = true;
            // 
            // frmLihatKartu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 516);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rddProduct);
            this.Controls.Add(this.radGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLihatKartu";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Lihat Kartu Stock";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmLihatKartu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vperhitunganbarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlogproductdetaillapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource vlogproductdetaillapBindingSource;
        private Telerik.WinControls.UI.RadDropDownList rddProduct;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTanggal;
        private Telerik.WinControls.UI.RadLabel lblTanggal;
        private System.Windows.Forms.BindingSource vproductbaseBindingSource;
        private sinarekDataSetTableAdapters.vproductbaseTableAdapter vproductbaseTableAdapter;
        private System.Windows.Forms.BindingSource vperhitunganbarangBindingSource;
        private sinarekDataSetTableAdapters.vperhitunganbarangTableAdapter vperhitunganbarangTableAdapter;
    }
}
