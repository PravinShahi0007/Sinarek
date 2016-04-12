namespace NB
{
    partial class frmProductPrice
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn3 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.vproductbaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.kotaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.productpriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rddKota = new Telerik.WinControls.UI.RadDropDownList();
            this.kotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.kotaTableAdapter = new NB.sinarekDataSetTableAdapters.kotaTableAdapter();
            this.productpriceTableAdapter = new NB.sinarekDataSetTableAdapters.productpriceTableAdapter();
            this.vproductbaseTableAdapter = new NB.sinarekDataSetTableAdapters.vproductbaseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddKota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
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
            // kotaBindingSource1
            // 
            this.kotaBindingSource1.DataMember = "kota";
            this.kotaBindingSource1.DataSource = this.sinarekDataSet;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGridView1.Location = new System.Drawing.Point(0, 75);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "ProdPriceID";
            gridViewDecimalColumn1.HeaderText = "ProdPriceID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ProdPriceID";
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "BaseID";
            gridViewDecimalColumn2.HeaderText = "BaseID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "BaseID";
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.FieldName = "KotaID";
            gridViewDecimalColumn3.HeaderText = "KotaID";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "KotaID";
            gridViewDateTimeColumn1.FieldName = "Modified";
            gridViewDateTimeColumn1.HeaderText = "Modified";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.IsVisible = false;
            gridViewDateTimeColumn1.Name = "Modified";
            gridViewTextBoxColumn1.FieldName = "ModifiedBy";
            gridViewTextBoxColumn1.HeaderText = "ModifiedBy";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ModifiedBy";
            gridViewComboBoxColumn1.DataSource = this.vproductbaseBindingSource;
            gridViewComboBoxColumn1.DataType = typeof(int);
            gridViewComboBoxColumn1.DisplayMember = "Description";
            gridViewComboBoxColumn1.DisplayMemberSort = true;
            gridViewComboBoxColumn1.FieldName = "BaseID";
            gridViewComboBoxColumn1.HeaderText = "Product";
            gridViewComboBoxColumn1.Name = "ProductName";
            gridViewComboBoxColumn1.ValueMember = "baseid";
            gridViewComboBoxColumn1.Width = 250;
            gridViewComboBoxColumn2.DataSource = this.vproductbaseBindingSource;
            gridViewComboBoxColumn2.DataType = typeof(int);
            gridViewComboBoxColumn2.DisplayMember = "Short";
            gridViewComboBoxColumn2.FieldName = "baseid";
            gridViewComboBoxColumn2.HeaderText = "Unit";
            gridViewComboBoxColumn2.Name = "column3";
            gridViewComboBoxColumn2.ValueMember = "baseid";
            gridViewComboBoxColumn2.Width = 100;
            gridViewComboBoxColumn3.DataSource = this.kotaBindingSource1;
            gridViewComboBoxColumn3.DataType = typeof(int);
            gridViewComboBoxColumn3.DisplayMember = "Nama";
            gridViewComboBoxColumn3.FieldName = "KotaID";
            gridViewComboBoxColumn3.HeaderText = "Kota";
            gridViewComboBoxColumn3.Name = "column1";
            gridViewComboBoxColumn3.ValueMember = "KotaID";
            gridViewComboBoxColumn3.Width = 150;
            gridViewDecimalColumn4.FieldName = "price";
            gridViewDecimalColumn4.FormatString = "{0:Rp #,##0.00}";
            gridViewDecimalColumn4.HeaderText = "Harga";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "price";
            gridViewDecimalColumn4.Width = 100;
            gridViewCheckBoxColumn1.FieldName = "Active";
            gridViewCheckBoxColumn1.HeaderText = "Active";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.Name = "Active";
            gridViewCheckBoxColumn1.Width = 80;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1,
            gridViewComboBoxColumn1,
            gridViewComboBoxColumn2,
            gridViewComboBoxColumn3,
            gridViewDecimalColumn4,
            gridViewCheckBoxColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.productpriceBindingSource;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(748, 396);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // productpriceBindingSource
            // 
            this.productpriceBindingSource.DataMember = "productprice";
            this.productpriceBindingSource.DataSource = this.sinarekDataSet;
            // 
            // rddKota
            // 
            this.rddKota.AutoCompleteDisplayMember = "Nama";
            this.rddKota.AutoCompleteValueMember = "KotaID";
            this.rddKota.DataSource = this.kotaBindingSource;
            this.rddKota.DisplayMember = "Nama";
            this.rddKota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddKota.Location = new System.Drawing.Point(84, 21);
            this.rddKota.Name = "rddKota";
            this.rddKota.Size = new System.Drawing.Size(211, 23);
            this.rddKota.TabIndex = 1;
            this.rddKota.ValueMember = "KotaID";
            this.rddKota.SelectedValueChanged += new System.EventHandler(this.RadDropDownList_SelectedValueChanged);
            // 
            // kotaBindingSource
            // 
            this.kotaBindingSource.DataMember = "kota";
            this.kotaBindingSource.DataSource = this.sinarekDataSet;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefresh.Location = new System.Drawing.Point(316, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 24);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Recalculate Price";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(25, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(35, 21);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Kota";
            // 
            // kotaTableAdapter
            // 
            this.kotaTableAdapter.ClearBeforeFill = true;
            // 
            // productpriceTableAdapter
            // 
            this.productpriceTableAdapter.ClearBeforeFill = true;
            // 
            // vproductbaseTableAdapter
            // 
            this.vproductbaseTableAdapter.ClearBeforeFill = true;
            // 
            // frmProductPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 471);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.rddKota);
            this.Controls.Add(this.radGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmProductPrice";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Product Price By City";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmProductPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddKota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadDropDownList rddKota;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource kotaBindingSource;
        private sinarekDataSetTableAdapters.kotaTableAdapter kotaTableAdapter;
        private Telerik.WinControls.UI.RadButton btnRefresh;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.BindingSource productpriceBindingSource;
        private sinarekDataSetTableAdapters.productpriceTableAdapter productpriceTableAdapter;
        private System.Windows.Forms.BindingSource kotaBindingSource1;
        private System.Windows.Forms.BindingSource vproductbaseBindingSource;
        private sinarekDataSetTableAdapters.vproductbaseTableAdapter vproductbaseTableAdapter;
    }
}
