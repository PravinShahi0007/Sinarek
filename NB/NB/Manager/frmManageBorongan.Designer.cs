namespace NB
{
    partial class frmManageBorongan
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn25 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn26 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn27 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn28 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn29 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn10 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn11 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn30 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn31 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn19 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn32 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn20 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn21 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn22 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn23 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn24 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn12 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor4 = new Telerik.WinControls.Data.SortDescriptor();
            this.productbaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.tipeprodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productbaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.productbaseTableAdapter = new NB.sinarekDataSetTableAdapters.productbaseTableAdapter();
            this.btnNew = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnMoveGroup = new Telerik.WinControls.UI.RadButton();
            this.rddTipe = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.tipeprodTableAdapter = new NB.sinarekDataSetTableAdapters.tipeprodTableAdapter();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnPrintList = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.productbaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeprodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productbaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMoveGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // productbaseBindingSource1
            // 
            this.productbaseBindingSource1.DataMember = "productbase";
            this.productbaseBindingSource1.DataSource = this.sinarekDataSet;
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipeprodBindingSource
            // 
            this.tipeprodBindingSource.DataMember = "tipeprod";
            this.tipeprodBindingSource.DataSource = this.sinarekDataSet;
            // 
            // productbaseBindingSource
            // 
            this.productbaseBindingSource.DataMember = "productbase";
            this.productbaseBindingSource.DataSource = this.sinarekDataSet;
            this.productbaseBindingSource.Filter = "updatable = 1";
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGridView1.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.radGridView1.HideSelection = true;
            this.radGridView1.Location = new System.Drawing.Point(0, 55);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AutoExpandGroups = true;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn25.DataType = typeof(int);
            gridViewDecimalColumn25.FieldName = "baseid";
            gridViewDecimalColumn25.FormatString = "";
            gridViewDecimalColumn25.HeaderText = "baseid";
            gridViewDecimalColumn25.IsAutoGenerated = true;
            gridViewDecimalColumn25.IsVisible = false;
            gridViewDecimalColumn25.Name = "baseid";
            gridViewDecimalColumn25.ReadOnly = true;
            gridViewDecimalColumn25.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn26.DataType = typeof(int);
            gridViewDecimalColumn26.FieldName = "parentid";
            gridViewDecimalColumn26.FormatString = "";
            gridViewDecimalColumn26.HeaderText = "parentid";
            gridViewDecimalColumn26.IsAutoGenerated = true;
            gridViewDecimalColumn26.IsVisible = false;
            gridViewDecimalColumn26.Name = "parentid";
            gridViewDecimalColumn26.ReadOnly = true;
            gridViewDecimalColumn26.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn27.DataType = typeof(int);
            gridViewDecimalColumn27.FieldName = "productid";
            gridViewDecimalColumn27.FormatString = "";
            gridViewDecimalColumn27.HeaderText = "productid";
            gridViewDecimalColumn27.IsAutoGenerated = true;
            gridViewDecimalColumn27.IsVisible = false;
            gridViewDecimalColumn27.Name = "productid";
            gridViewDecimalColumn27.ReadOnly = true;
            gridViewDecimalColumn27.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn16.FieldName = "ProductShort";
            gridViewTextBoxColumn16.FormatString = "";
            gridViewTextBoxColumn16.HeaderText = "Kode";
            gridViewTextBoxColumn16.IsAutoGenerated = true;
            gridViewTextBoxColumn16.Name = "ProductShort";
            gridViewTextBoxColumn16.ReadOnly = true;
            gridViewTextBoxColumn16.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn16.Width = 100;
            gridViewTextBoxColumn17.FieldName = "ProductName";
            gridViewTextBoxColumn17.FormatString = "";
            gridViewTextBoxColumn17.HeaderText = "Nama";
            gridViewTextBoxColumn17.IsAutoGenerated = true;
            gridViewTextBoxColumn17.Name = "ProductName";
            gridViewTextBoxColumn17.ReadOnly = true;
            gridViewTextBoxColumn17.Width = 200;
            gridViewDecimalColumn28.FieldName = "price";
            gridViewDecimalColumn28.FormatString = "{0:Rp #,###.00}";
            gridViewDecimalColumn28.HeaderText = "Harga";
            gridViewDecimalColumn28.IsAutoGenerated = true;
            gridViewDecimalColumn28.Name = "price";
            gridViewDecimalColumn28.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn28.Width = 125;
            gridViewTextBoxColumn18.FieldName = "UnitShort";
            gridViewTextBoxColumn18.FormatString = "";
            gridViewTextBoxColumn18.HeaderText = "Unit";
            gridViewTextBoxColumn18.IsAutoGenerated = true;
            gridViewTextBoxColumn18.Name = "UnitShort";
            gridViewTextBoxColumn18.ReadOnly = true;
            gridViewDecimalColumn29.FieldName = "ConvRate";
            gridViewDecimalColumn29.FormatString = "";
            gridViewDecimalColumn29.HeaderText = "Qty";
            gridViewDecimalColumn29.IsAutoGenerated = true;
            gridViewDecimalColumn29.Name = "ConvRate";
            gridViewDecimalColumn29.ReadOnly = true;
            gridViewDecimalColumn29.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn29.Width = 75;
            gridViewComboBoxColumn10.DataSource = this.productbaseBindingSource1;
            gridViewComboBoxColumn10.DataType = typeof(int);
            gridViewComboBoxColumn10.DisplayMember = "UnitShort";
            gridViewComboBoxColumn10.FieldName = "parentid";
            gridViewComboBoxColumn10.FormatString = "";
            gridViewComboBoxColumn10.HeaderText = "Satuan";
            gridViewComboBoxColumn10.Name = "parentunit";
            gridViewComboBoxColumn10.ReadOnly = true;
            gridViewComboBoxColumn10.ValueMember = "baseid";
            gridViewComboBoxColumn10.Width = 70;
            gridViewComboBoxColumn11.DataSource = this.productbaseBindingSource1;
            gridViewComboBoxColumn11.DataType = typeof(int);
            gridViewComboBoxColumn11.DisplayMember = "price";
            gridViewComboBoxColumn11.FieldName = "parentid";
            gridViewComboBoxColumn11.FormatString = "{0:Rp #,###.00}";
            gridViewComboBoxColumn11.HeaderText = "Harga Satuan";
            gridViewComboBoxColumn11.Name = "parentprice";
            gridViewComboBoxColumn11.ReadOnly = true;
            gridViewComboBoxColumn11.ValueMember = "baseid";
            gridViewComboBoxColumn11.Width = 100;
            gridViewDecimalColumn30.FieldName = "HargaB";
            gridViewDecimalColumn30.FormatString = "";
            gridViewDecimalColumn30.HeaderText = "Borongan";
            gridViewDecimalColumn30.IsAutoGenerated = true;
            gridViewDecimalColumn30.Name = "HargaB";
            gridViewDecimalColumn30.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn30.Width = 100;
            gridViewDecimalColumn31.DataType = typeof(int);
            gridViewDecimalColumn31.FieldName = "unitid";
            gridViewDecimalColumn31.FormatString = "";
            gridViewDecimalColumn31.HeaderText = "unitid";
            gridViewDecimalColumn31.IsAutoGenerated = true;
            gridViewDecimalColumn31.IsVisible = false;
            gridViewDecimalColumn31.Name = "unitid";
            gridViewDecimalColumn31.ReadOnly = true;
            gridViewDecimalColumn31.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn19.FieldName = "Keterangan";
            gridViewTextBoxColumn19.FormatString = "";
            gridViewTextBoxColumn19.HeaderText = "Keterangan";
            gridViewTextBoxColumn19.IsAutoGenerated = true;
            gridViewTextBoxColumn19.IsVisible = false;
            gridViewTextBoxColumn19.Name = "Keterangan";
            gridViewTextBoxColumn19.ReadOnly = true;
            gridViewTextBoxColumn20.FieldName = "UnitName";
            gridViewTextBoxColumn20.FormatString = "";
            gridViewTextBoxColumn20.HeaderText = "Nama Unit";
            gridViewTextBoxColumn20.IsAutoGenerated = true;
            gridViewTextBoxColumn20.IsVisible = false;
            gridViewTextBoxColumn20.Name = "UnitName";
            gridViewTextBoxColumn20.ReadOnly = true;
            gridViewTextBoxColumn20.Width = 75;
            gridViewDateTimeColumn4.FieldName = "modified";
            gridViewDateTimeColumn4.FormatString = "";
            gridViewDateTimeColumn4.HeaderText = "modified";
            gridViewDateTimeColumn4.IsAutoGenerated = true;
            gridViewDateTimeColumn4.IsVisible = false;
            gridViewDateTimeColumn4.Name = "modified";
            gridViewDateTimeColumn4.ReadOnly = true;
            gridViewCheckBoxColumn19.FieldName = "Active";
            gridViewCheckBoxColumn19.FormatString = "";
            gridViewCheckBoxColumn19.HeaderText = "Active";
            gridViewCheckBoxColumn19.IsAutoGenerated = true;
            gridViewCheckBoxColumn19.IsVisible = false;
            gridViewCheckBoxColumn19.Name = "Active";
            gridViewCheckBoxColumn19.ReadOnly = true;
            gridViewDecimalColumn32.DataType = typeof(int);
            gridViewDecimalColumn32.FieldName = "custtypeid";
            gridViewDecimalColumn32.FormatString = "";
            gridViewDecimalColumn32.HeaderText = "custtypeid";
            gridViewDecimalColumn32.IsAutoGenerated = true;
            gridViewDecimalColumn32.IsVisible = false;
            gridViewDecimalColumn32.Name = "custtypeid";
            gridViewDecimalColumn32.ReadOnly = true;
            gridViewDecimalColumn32.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewCheckBoxColumn20.FieldName = "Sellable";
            gridViewCheckBoxColumn20.FormatString = "";
            gridViewCheckBoxColumn20.HeaderText = "S";
            gridViewCheckBoxColumn20.IsAutoGenerated = true;
            gridViewCheckBoxColumn20.Name = "Sellable";
            gridViewCheckBoxColumn20.ReadOnly = true;
            gridViewCheckBoxColumn21.FieldName = "Goods";
            gridViewCheckBoxColumn21.FormatString = "";
            gridViewCheckBoxColumn21.HeaderText = "G";
            gridViewCheckBoxColumn21.IsAutoGenerated = true;
            gridViewCheckBoxColumn21.Name = "Goods";
            gridViewCheckBoxColumn21.ReadOnly = true;
            gridViewCheckBoxColumn22.FieldName = "Others";
            gridViewCheckBoxColumn22.FormatString = "";
            gridViewCheckBoxColumn22.HeaderText = "O";
            gridViewCheckBoxColumn22.IsAutoGenerated = true;
            gridViewCheckBoxColumn22.Name = "Others";
            gridViewCheckBoxColumn22.ReadOnly = true;
            gridViewCheckBoxColumn23.FieldName = "Borongan";
            gridViewCheckBoxColumn23.FormatString = "";
            gridViewCheckBoxColumn23.HeaderText = "B";
            gridViewCheckBoxColumn23.IsAutoGenerated = true;
            gridViewCheckBoxColumn23.Name = "Borongan";
            gridViewCheckBoxColumn23.ReadOnly = true;
            gridViewCheckBoxColumn24.FieldName = "updatable";
            gridViewCheckBoxColumn24.FormatString = "";
            gridViewCheckBoxColumn24.HeaderText = "U";
            gridViewCheckBoxColumn24.Name = "updatable";
            gridViewComboBoxColumn12.DataSource = this.tipeprodBindingSource;
            gridViewComboBoxColumn12.DataType = typeof(int);
            gridViewComboBoxColumn12.DisplayMember = "Name";
            gridViewComboBoxColumn12.FieldName = "tipeid";
            gridViewComboBoxColumn12.FormatString = "";
            gridViewComboBoxColumn12.HeaderText = "Grup";
            gridViewComboBoxColumn12.IsVisible = false;
            gridViewComboBoxColumn12.Name = "TipeID";
            gridViewComboBoxColumn12.ValueMember = "tipeid";
            gridViewComboBoxColumn12.Width = 100;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn25,
            gridViewDecimalColumn26,
            gridViewDecimalColumn27,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewDecimalColumn28,
            gridViewTextBoxColumn18,
            gridViewDecimalColumn29,
            gridViewComboBoxColumn10,
            gridViewComboBoxColumn11,
            gridViewDecimalColumn30,
            gridViewDecimalColumn31,
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewDateTimeColumn4,
            gridViewCheckBoxColumn19,
            gridViewDecimalColumn32,
            gridViewCheckBoxColumn20,
            gridViewCheckBoxColumn21,
            gridViewCheckBoxColumn22,
            gridViewCheckBoxColumn23,
            gridViewCheckBoxColumn24,
            gridViewComboBoxColumn12});
            this.radGridView1.MasterTemplate.DataSource = this.productbaseBindingSource;
            sortDescriptor4.PropertyName = "ProductShort";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor4});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(1185, 511);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellValueChanged);
            // 
            // productbaseTableAdapter
            // 
            this.productbaseTableAdapter.ClearBeforeFill = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNew.Location = new System.Drawing.Point(460, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(161, 29);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New &Product Package";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnPrintList);
            this.radGroupBox1.Controls.Add(this.btnDelete);
            this.radGroupBox1.Controls.Add(this.btnMoveGroup);
            this.radGroupBox1.Controls.Add(this.rddTipe);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.btnNew);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
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
            this.radGroupBox1.Size = new System.Drawing.Size(1185, 55);
            this.radGroupBox1.TabIndex = 2;
            // 
            // btnMoveGroup
            // 
            this.btnMoveGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMoveGroup.Location = new System.Drawing.Point(638, 12);
            this.btnMoveGroup.Name = "btnMoveGroup";
            this.btnMoveGroup.Size = new System.Drawing.Size(134, 29);
            this.btnMoveGroup.TabIndex = 4;
            this.btnMoveGroup.Text = "Move &Group";
            this.btnMoveGroup.Click += new System.EventHandler(this.btnMoveGroup_Click);
            // 
            // rddTipe
            // 
            this.rddTipe.AutoCompleteDisplayMember = "Name";
            this.rddTipe.AutoCompleteValueMember = "tipeid";
            this.rddTipe.DataSource = this.tipeprodBindingSource;
            this.rddTipe.DescriptionTextMember = "Description";
            this.rddTipe.DisplayMember = "Name";
            this.rddTipe.DropDownAnimationEnabled = true;
            this.rddTipe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddTipe.Location = new System.Drawing.Point(163, 14);
            this.rddTipe.Name = "rddTipe";
            this.rddTipe.ShowImageInEditorArea = true;
            this.rddTipe.Size = new System.Drawing.Size(197, 23);
            this.rddTipe.TabIndex = 3;
            this.rddTipe.ValueMember = "tipeid";
            this.rddTipe.SelectedValueChanged += new System.EventHandler(this.rddTipe_SelectedValueChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 17);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(143, 21);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Filter By Product Tipe :";
            // 
            // tipeprodTableAdapter
            // 
            this.tipeprodTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDelete.Location = new System.Drawing.Point(796, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrintList
            // 
            this.btnPrintList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrintList.Location = new System.Drawing.Point(958, 12);
            this.btnPrintList.Name = "btnPrintList";
            this.btnPrintList.Size = new System.Drawing.Size(134, 29);
            this.btnPrintList.TabIndex = 6;
            this.btnPrintList.Text = "&Print List";
            this.btnPrintList.Click += new System.EventHandler(this.btnPrintList_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 566);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmProduct";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Daftar Barang";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productbaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeprodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productbaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMoveGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource productbaseBindingSource;
        private sinarekDataSetTableAdapters.productbaseTableAdapter productbaseTableAdapter;
        private System.Windows.Forms.BindingSource productbaseBindingSource1;
        private Telerik.WinControls.UI.RadButton btnNew;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.BindingSource tipeprodBindingSource;
        private sinarekDataSetTableAdapters.tipeprodTableAdapter tipeprodTableAdapter;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList rddTipe;
        private Telerik.WinControls.UI.RadButton btnMoveGroup;
        private Telerik.WinControls.UI.RadButton btnPrintList;
        private Telerik.WinControls.UI.RadButton btnDelete;
    }
}
