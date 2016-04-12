namespace NB
{
    partial class frmEditSJ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            System.Windows.Forms.Label tujuanIDLabel;
            System.Windows.Forms.Label label3;
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.vproductbaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.mobilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sopirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kernetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tanggalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rddTujuan = new Telerik.WinControls.UI.RadDropDownList();
            this.kotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSimpan = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.tableAdapterManager = new NB.fingermachDataSetTableAdapters.TableAdapterManager();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.rddTipe = new Telerik.WinControls.UI.RadDropDownList();
            this.custtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtKeteranganDetail = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.txtQuantity = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.rddProduct = new Telerik.WinControls.UI.RadDropDownList();
            this.rddPel = new Telerik.WinControls.UI.RadDropDownList();
            this.vallsupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.chkAntar = new Telerik.WinControls.UI.RadCheckBox();
            this.rddKernet = new Telerik.WinControls.UI.RadDropDownList();
            this.rddMobil = new Telerik.WinControls.UI.RadDropDownList();
            this.rddSopir = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.rddSales = new Telerik.WinControls.UI.RadDropDownList();
            this.txtMobil = new Telerik.WinControls.UI.RadTextBox();
            this.txtSopir = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radMultiColumnComboBox1 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radMultiColumnComboBox2 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.txtSJ = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel11 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.vproductbaseTableAdapter = new NB.sinarekDataSetTableAdapters.vproductbaseTableAdapter();
            this.kotaTableAdapter = new NB.sinarekDataSetTableAdapters.kotaTableAdapter();
            this.mobilTableAdapter = new NB.sinarekDataSetTableAdapters.mobilTableAdapter();
            this.salesTableAdapter = new NB.sinarekDataSetTableAdapters.salesTableAdapter();
            this.kernetTableAdapter = new NB.sinarekDataSetTableAdapters.kernetTableAdapter();
            this.sopirTableAdapter = new NB.sinarekDataSetTableAdapters.sopirTableAdapter();
            this.custtypeTableAdapter = new NB.sinarekDataSetTableAdapters.custtypeTableAdapter();
            this.vallsupTableAdapter = new NB.sinarekDataSetTableAdapters.vallsupTableAdapter();
            this.logdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logdetailTableAdapter = new NB.sinarekDataSetTableAdapters.logdetailTableAdapter();
            tujuanIDLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sopirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTujuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeteranganDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddPel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vallsupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAntar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddKernet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddMobil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddSopir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSopir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tujuanIDLabel
            // 
            tujuanIDLabel.AutoSize = true;
            tujuanIDLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            tujuanIDLabel.Location = new System.Drawing.Point(292, 71);
            tujuanIDLabel.Name = "tujuanIDLabel";
            tujuanIDLabel.Size = new System.Drawing.Size(53, 19);
            tujuanIDLabel.TabIndex = 22;
            tujuanIDLabel.Text = "Tujuan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            label3.Location = new System.Drawing.Point(334, 26);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 19);
            label3.TabIndex = 45;
            label3.Text = "Jumlah:";
            // 
            // vproductbaseBindingSource
            // 
            this.vproductbaseBindingSource.DataMember = "vproductbase";
            this.vproductbaseBindingSource.DataSource = this.sinarekDataSet;
            this.vproductbaseBindingSource.Filter = "sellable = 1 and active = 1";
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mobilBindingSource1
            // 
            this.mobilBindingSource1.DataMember = "mobil";
            this.mobilBindingSource1.DataSource = this.sinarekDataSet;
            // 
            // sopirBindingSource
            // 
            this.sopirBindingSource.DataMember = "sopir";
            this.sopirBindingSource.DataSource = this.sinarekDataSet;
            this.sopirBindingSource.Sort = "nama asc";
            // 
            // kernetBindingSource
            // 
            this.kernetBindingSource.DataMember = "kernet";
            this.kernetBindingSource.DataSource = this.sinarekDataSet;
            this.kernetBindingSource.Sort = "nama asc";
            // 
            // tanggalDateTimePicker
            // 
            this.tanggalDateTimePicker.CustomFormat = "dddd, dd MMM yyy";
            this.tanggalDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tanggalDateTimePicker.Location = new System.Drawing.Point(94, 39);
            this.tanggalDateTimePicker.Name = "tanggalDateTimePicker";
            this.tanggalDateTimePicker.Size = new System.Drawing.Size(187, 25);
            this.tanggalDateTimePicker.TabIndex = 2;
            // 
            // rddTujuan
            // 
            this.rddTujuan.AutoCompleteDisplayMember = "Nama";
            this.rddTujuan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddTujuan.AutoCompleteValueMember = "KotaID";
            this.rddTujuan.DataSource = this.kotaBindingSource;
            this.rddTujuan.DisplayMember = "Nama";
            this.rddTujuan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddTujuan.Location = new System.Drawing.Point(376, 69);
            this.rddTujuan.Name = "rddTujuan";
            this.rddTujuan.Size = new System.Drawing.Size(187, 23);
            this.rddTujuan.TabIndex = 5;
            this.rddTujuan.ThemeName = "Office2007Black";
            this.rddTujuan.ValueMember = "KotaID";
            // 
            // kotaBindingSource
            // 
            this.kotaBindingSource.DataMember = "kota";
            this.kotaBindingSource.DataSource = this.sinarekDataSet;
            this.kotaBindingSource.Filter = "systemonly = 0";
            this.kotaBindingSource.Sort = "Nama Asc";
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.sinarekDataSet;
            this.salesBindingSource.Sort = "short asc";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.Location = new System.Drawing.Point(128, 475);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(124, 28);
            this.btnSimpan.TabIndex = 21;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(372, 475);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 28);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "&Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.tdatafingerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NB.fingermachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // radGridView1
            // 
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGridView1.Location = new System.Drawing.Point(4, 317);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AllowEditRow = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.HeaderText = "#";
            gridViewTextBoxColumn1.Name = "NoRow";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 40;
            gridViewTextBoxColumn2.DataType = typeof(long);
            gridViewTextBoxColumn2.FieldName = "detailid";
            gridViewTextBoxColumn2.HeaderText = "detailid";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "detailid";
            gridViewDecimalColumn1.FieldName = "quantity";
            gridViewDecimalColumn1.HeaderText = "Jumlah";
            gridViewDecimalColumn1.Name = "quantity";
            gridViewDecimalColumn1.Width = 125;
            gridViewComboBoxColumn1.DataSource = this.vproductbaseBindingSource;
            gridViewComboBoxColumn1.DataType = typeof(int);
            gridViewComboBoxColumn1.DisplayMember = "ProductLong";
            gridViewComboBoxColumn1.FieldName = "baseid";
            gridViewComboBoxColumn1.HeaderText = "Nama Barang";
            gridViewComboBoxColumn1.Name = "productid";
            gridViewComboBoxColumn1.ValueMember = "baseid";
            gridViewComboBoxColumn1.Width = 200;
            gridViewTextBoxColumn3.FieldName = "keterangan";
            gridViewTextBoxColumn3.HeaderText = "Keterangan";
            gridViewTextBoxColumn3.Name = "keterangan";
            gridViewTextBoxColumn3.Width = 100;
            gridViewDecimalColumn2.FieldName = "custtypetoid";
            gridViewDecimalColumn2.HeaderText = "custtypetoid";
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "custtypetoid";
            gridViewDecimalColumn3.FieldName = "custtypeid";
            gridViewDecimalColumn3.HeaderText = "custtypeid";
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "custtypeid";
            gridViewDecimalColumn4.FieldName = "status";
            gridViewDecimalColumn4.HeaderText = "statusid";
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "status";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn1,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(584, 153);
            this.radGridView1.TabIndex = 37;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.CellEditorInitialized += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEditorInitialized);
            this.radGridView1.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEndEdit);
            this.radGridView1.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.radGridView1_UserDeletingRow);
            this.radGridView1.RowsChanged += new Telerik.WinControls.UI.GridViewCollectionChangedEventHandler(this.radGridView1_RowsChanged);
            // 
            // rddTipe
            // 
            this.rddTipe.AutoCompleteDisplayMember = "Name";
            this.rddTipe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddTipe.AutoCompleteValueMember = "CustTypeID";
            this.rddTipe.DataSource = this.custtypeBindingSource;
            this.rddTipe.DisplayMember = "Name";
            this.rddTipe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddTipe.Location = new System.Drawing.Point(94, 11);
            this.rddTipe.Name = "rddTipe";
            this.rddTipe.Size = new System.Drawing.Size(187, 23);
            this.rddTipe.TabIndex = 1;
            this.rddTipe.ValueMember = "CustTypeID";
            this.rddTipe.SelectedValueChanged += new System.EventHandler(this.rddTipe_SelectedValueChanged);
            this.rddTipe.Validating += new System.ComponentModel.CancelEventHandler(this.rddTipe_Validating);
            // 
            // custtypeBindingSource
            // 
            this.custtypeBindingSource.DataMember = "custtype";
            this.custtypeBindingSource.DataSource = this.sinarekDataSet;
            this.custtypeBindingSource.Filter = "custtypeid in (1,2,3,4,5,6)";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radLabel7);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.txtKeteranganDetail);
            this.radGroupBox2.Controls.Add(this.btnAdd);
            this.radGroupBox2.Controls.Add(label3);
            this.radGroupBox2.Controls.Add(this.txtQuantity);
            this.radGroupBox2.Controls.Add(this.rddProduct);
            this.radGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox2.HeaderText = "Input Produk";
            this.radGroupBox2.Location = new System.Drawing.Point(4, 225);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(584, 86);
            this.radGroupBox2.TabIndex = 10;
            this.radGroupBox2.TabStop = false;
            this.radGroupBox2.Text = "Input Produk";
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(10, 25);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(47, 18);
            this.radLabel7.TabIndex = 53;
            this.radLabel7.Text = "Produk :";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(9, 54);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(69, 18);
            this.radLabel3.TabIndex = 52;
            this.radLabel3.Text = "Keterangan :";
            // 
            // txtKeteranganDetail
            // 
            this.txtKeteranganDetail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKeteranganDetail.Location = new System.Drawing.Point(92, 53);
            this.txtKeteranganDetail.Name = "txtKeteranganDetail";
            this.txtKeteranganDetail.Size = new System.Drawing.Size(366, 23);
            this.txtKeteranganDetail.TabIndex = 12;
            this.txtKeteranganDetail.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Location = new System.Drawing.Point(475, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 25);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Tag = "add";
            this.btnAdd.Text = "&Add";
            this.btnAdd.ThemeName = "Office2007Black";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQuantity.Location = new System.Drawing.Point(391, 24);
            this.txtQuantity.Mask = "n1";
            this.txtQuantity.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(67, 23);
            this.txtQuantity.TabIndex = 11;
            this.txtQuantity.TabStop = false;
            this.txtQuantity.Text = "0.0";
            // 
            // rddProduct
            // 
            this.rddProduct.AutoCompleteDisplayMember = "ProdName";
            this.rddProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddProduct.AutoCompleteValueMember = "baseid";
            this.rddProduct.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vproductbaseBindingSource, "custtypeid", true));
            this.rddProduct.DataSource = this.vproductbaseBindingSource;
            this.rddProduct.DescriptionTextMember = "UnitName";
            this.rddProduct.DisplayMember = "ProdName";
            this.rddProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddProduct.Location = new System.Drawing.Point(93, 24);
            this.rddProduct.Name = "rddProduct";
            this.rddProduct.Size = new System.Drawing.Size(196, 23);
            this.rddProduct.TabIndex = 10;
            this.rddProduct.ValueMember = "baseid";
            // 
            // rddPel
            // 
            this.rddPel.AutoCompleteDisplayMember = "Nama";
            this.rddPel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddPel.AutoCompleteValueMember = "ID";
            this.rddPel.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vallsupBindingSource, "CustTypeID", true));
            this.rddPel.DataSource = this.vallsupBindingSource;
            this.rddPel.DescriptionTextMember = "TableName";
            this.rddPel.DisplayMember = "Nama";
            this.rddPel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddPel.Location = new System.Drawing.Point(94, 69);
            this.rddPel.Name = "rddPel";
            this.rddPel.Size = new System.Drawing.Size(187, 23);
            this.rddPel.TabIndex = 4;
            this.rddPel.ValueMember = "ID";
            // 
            // vallsupBindingSource
            // 
            this.vallsupBindingSource.DataMember = "vallsup";
            this.vallsupBindingSource.DataSource = this.sinarekDataSet;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(296, 65);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(38, 18);
            this.radLabel2.TabIndex = 22;
            this.radLabel2.Text = "Sopir :";
            // 
            // chkAntar
            // 
            this.chkAntar.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAntar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAntar.Location = new System.Drawing.Point(12, 10);
            this.chkAntar.Name = "chkAntar";
            this.chkAntar.Size = new System.Drawing.Size(143, 21);
            this.chkAntar.TabIndex = 6;
            this.chkAntar.Text = "Di Antar Mobil Sinar";
            this.chkAntar.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkAntar_ToggleStateChanged);
            // 
            // rddKernet
            // 
            this.rddKernet.AutoCompleteDisplayMember = "Nama";
            this.rddKernet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddKernet.AutoCompleteValueMember = "KernetID";
            this.rddKernet.DataSource = this.kernetBindingSource;
            this.rddKernet.DisplayMember = "Nama";
            this.rddKernet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddKernet.Location = new System.Drawing.Point(96, 94);
            this.rddKernet.Name = "rddKernet";
            this.rddKernet.Size = new System.Drawing.Size(187, 23);
            this.rddKernet.TabIndex = 9;
            this.rddKernet.ValueMember = "KernetID";
            // 
            // rddMobil
            // 
            this.rddMobil.AutoCompleteDisplayMember = "NoPolis";
            this.rddMobil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddMobil.AutoCompleteValueMember = "MobilID";
            this.rddMobil.DataSource = this.mobilBindingSource1;
            this.rddMobil.DisplayMember = "NoPolis";
            this.rddMobil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddMobil.Location = new System.Drawing.Point(96, 36);
            this.rddMobil.Name = "rddMobil";
            this.rddMobil.Size = new System.Drawing.Size(187, 23);
            this.rddMobil.TabIndex = 7;
            this.rddMobil.ValueMember = "MobilID";
            // 
            // rddSopir
            // 
            this.rddSopir.AutoCompleteDisplayMember = "Nama";
            this.rddSopir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddSopir.AutoCompleteValueMember = "SopirID";
            this.rddSopir.DataSource = this.sopirBindingSource;
            this.rddSopir.DisplayMember = "Nama";
            this.rddSopir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddSopir.Location = new System.Drawing.Point(96, 65);
            this.rddSopir.Name = "rddSopir";
            this.rddSopir.Size = new System.Drawing.Size(187, 23);
            this.rddSopir.TabIndex = 8;
            this.rddSopir.ValueMember = "SopirID";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(296, 41);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(37, 18);
            this.radLabel5.TabIndex = 9;
            this.radLabel5.Text = "Sales :";
            // 
            // rddSales
            // 
            this.rddSales.AutoCompleteDisplayMember = "Short";
            this.rddSales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddSales.AutoCompleteValueMember = "SalesID";
            this.rddSales.DataSource = this.salesBindingSource;
            this.rddSales.DisplayMember = "Short";
            this.rddSales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddSales.Location = new System.Drawing.Point(376, 40);
            this.rddSales.Name = "rddSales";
            this.rddSales.Size = new System.Drawing.Size(187, 23);
            this.rddSales.TabIndex = 3;
            this.rddSales.ValueMember = "SalesID";
            this.rddSales.SelectedValueChanged += new System.EventHandler(this.rddSales_SelectedValueChanged);
            // 
            // txtMobil
            // 
            this.txtMobil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMobil.Location = new System.Drawing.Point(376, 35);
            this.txtMobil.Name = "txtMobil";
            this.txtMobil.Size = new System.Drawing.Size(187, 23);
            this.txtMobil.TabIndex = 7;
            this.txtMobil.TabStop = false;
            // 
            // txtSopir
            // 
            this.txtSopir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSopir.Location = new System.Drawing.Point(376, 64);
            this.txtSopir.Name = "txtSopir";
            this.txtSopir.Size = new System.Drawing.Size(187, 23);
            this.txtSopir.TabIndex = 8;
            this.txtSopir.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 70);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(41, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Nama :";
            // 
            // radMultiColumnComboBox1
            // 
            this.radMultiColumnComboBox1.AutoFilter = true;
            this.radMultiColumnComboBox1.DisplayMember = "Name";
            this.radMultiColumnComboBox1.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.radMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.radMultiColumnComboBox1.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radMultiColumnComboBox1.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.EnableFiltering = true;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView";
            this.radMultiColumnComboBox1.EditorControl.ReadOnly = true;
            this.radMultiColumnComboBox1.EditorControl.ShowGroupPanel = false;
            this.radMultiColumnComboBox1.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.radMultiColumnComboBox1.EditorControl.TabIndex = 0;
            this.radMultiColumnComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radMultiColumnComboBox1.Location = new System.Drawing.Point(201, -21);
            this.radMultiColumnComboBox1.Name = "radMultiColumnComboBox1";
            // 
            // 
            // 
            this.radMultiColumnComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radMultiColumnComboBox1.Size = new System.Drawing.Size(221, 23);
            this.radMultiColumnComboBox1.TabIndex = 6;
            this.radMultiColumnComboBox1.TabStop = false;
            this.radMultiColumnComboBox1.ValueMember = "custid";
            // 
            // radMultiColumnComboBox2
            // 
            this.radMultiColumnComboBox2.AutoFilter = true;
            this.radMultiColumnComboBox2.DisplayMember = "Name";
            this.radMultiColumnComboBox2.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            // 
            // radMultiColumnComboBox2.NestedRadGridView
            // 
            this.radMultiColumnComboBox2.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.radMultiColumnComboBox2.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMultiColumnComboBox2.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radMultiColumnComboBox2.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.EnableFiltering = true;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.EnableGrouping = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.radMultiColumnComboBox2.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.radMultiColumnComboBox2.EditorControl.Name = "NestedRadGridView";
            this.radMultiColumnComboBox2.EditorControl.ReadOnly = true;
            this.radMultiColumnComboBox2.EditorControl.ShowGroupPanel = false;
            this.radMultiColumnComboBox2.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.radMultiColumnComboBox2.EditorControl.TabIndex = 0;
            this.radMultiColumnComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radMultiColumnComboBox2.Location = new System.Drawing.Point(201, -21);
            this.radMultiColumnComboBox2.Name = "radMultiColumnComboBox2";
            // 
            // 
            // 
            this.radMultiColumnComboBox2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radMultiColumnComboBox2.Size = new System.Drawing.Size(221, 23);
            this.radMultiColumnComboBox2.TabIndex = 6;
            this.radMultiColumnComboBox2.TabStop = false;
            this.radMultiColumnComboBox2.ValueMember = "custid";
            // 
            // txtSJ
            // 
            this.txtSJ.Enabled = false;
            this.txtSJ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtSJ.Location = new System.Drawing.Point(376, 9);
            this.txtSJ.Name = "txtSJ";
            this.txtSJ.Size = new System.Drawing.Size(187, 27);
            this.txtSJ.TabIndex = 50;
            this.txtSJ.TabStop = false;
            this.txtSJ.Text = "No SJ";
            this.txtSJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.chkAntar);
            this.radGroupBox1.Controls.Add(this.txtSopir);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.rddSopir);
            this.radGroupBox1.Controls.Add(this.txtMobil);
            this.radGroupBox1.Controls.Add(this.radLabel12);
            this.radGroupBox1.Controls.Add(this.rddMobil);
            this.radGroupBox1.Controls.Add(this.rddKernet);
            this.radGroupBox1.Controls.Add(this.radLabel11);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(4, 101);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(584, 124);
            this.radGroupBox1.TabIndex = 6;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(12, 37);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(65, 18);
            this.radLabel4.TabIndex = 56;
            this.radLabel4.Text = "Kendaraan :";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(12, 66);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(38, 18);
            this.radLabel6.TabIndex = 55;
            this.radLabel6.Text = "Sopir :";
            // 
            // radLabel12
            // 
            this.radLabel12.Location = new System.Drawing.Point(12, 95);
            this.radLabel12.Name = "radLabel12";
            this.radLabel12.Size = new System.Drawing.Size(44, 18);
            this.radLabel12.TabIndex = 54;
            this.radLabel12.Text = "Kernet :";
            // 
            // radLabel11
            // 
            this.radLabel11.Location = new System.Drawing.Point(296, 36);
            this.radLabel11.Name = "radLabel11";
            this.radLabel11.Size = new System.Drawing.Size(65, 18);
            this.radLabel11.TabIndex = 53;
            this.radLabel11.Text = "Kendaraan :";
            // 
            // radLabel10
            // 
            this.radLabel10.Location = new System.Drawing.Point(12, 12);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(46, 18);
            this.radLabel10.TabIndex = 52;
            this.radLabel10.Text = "Tipe SJ :";
            // 
            // radLabel9
            // 
            this.radLabel9.Location = new System.Drawing.Point(12, 41);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(52, 18);
            this.radLabel9.TabIndex = 51;
            this.radLabel9.Text = "Tanggal :";
            // 
            // vproductbaseTableAdapter
            // 
            this.vproductbaseTableAdapter.ClearBeforeFill = true;
            // 
            // kotaTableAdapter
            // 
            this.kotaTableAdapter.ClearBeforeFill = true;
            // 
            // mobilTableAdapter
            // 
            this.mobilTableAdapter.ClearBeforeFill = true;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // kernetTableAdapter
            // 
            this.kernetTableAdapter.ClearBeforeFill = true;
            // 
            // sopirTableAdapter
            // 
            this.sopirTableAdapter.ClearBeforeFill = true;
            // 
            // custtypeTableAdapter
            // 
            this.custtypeTableAdapter.ClearBeforeFill = true;
            // 
            // vallsupTableAdapter
            // 
            this.vallsupTableAdapter.ClearBeforeFill = true;
            // 
            // logdetailBindingSource
            // 
            this.logdetailBindingSource.DataMember = "logdetail";
            this.logdetailBindingSource.DataSource = this.sinarekDataSet;
            // 
            // logdetailTableAdapter
            // 
            this.logdetailTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditSJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 506);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radLabel10);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.tanggalDateTimePicker);
            this.Controls.Add(this.radLabel9);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rddPel);
            this.Controls.Add(this.rddSales);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(tujuanIDLabel);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtSJ);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.rddTipe);
            this.Controls.Add(this.rddTujuan);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditSJ";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Surat Jalan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sopirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTujuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeteranganDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddPel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vallsupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAntar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddKernet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddMobil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddSopir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSopir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private fingermachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker tanggalDateTimePicker;
        private Telerik.WinControls.UI.RadDropDownList rddTujuan;
        private Telerik.WinControls.UI.RadButton btnSimpan;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadDropDownList rddProduct;
        private Telerik.WinControls.UI.RadMaskedEditBox txtQuantity;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadDropDownList rddTipe;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource vproductbaseBindingSource;
        private sinarekDataSetTableAdapters.vproductbaseTableAdapter vproductbaseTableAdapter;
        private System.Windows.Forms.BindingSource kotaBindingSource;
        private sinarekDataSetTableAdapters.kotaTableAdapter kotaTableAdapter;
        private System.Windows.Forms.BindingSource mobilBindingSource1;
        private sinarekDataSetTableAdapters.mobilTableAdapter mobilTableAdapter;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtMobil;
        private Telerik.WinControls.UI.RadTextBox txtSopir;
        private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox2;
        private Telerik.WinControls.UI.RadTextBox txtSJ;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDropDownList rddSales;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private sinarekDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadDropDownList rddKernet;
        private Telerik.WinControls.UI.RadDropDownList rddMobil;
        private Telerik.WinControls.UI.RadDropDownList rddSopir;
        private Telerik.WinControls.UI.RadCheckBox chkAntar;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.BindingSource kernetBindingSource;
        private sinarekDataSetTableAdapters.kernetTableAdapter kernetTableAdapter;
        private System.Windows.Forms.BindingSource sopirBindingSource;
        private sinarekDataSetTableAdapters.sopirTableAdapter sopirTableAdapter;
        private System.Windows.Forms.BindingSource custtypeBindingSource;
        private sinarekDataSetTableAdapters.custtypeTableAdapter custtypeTableAdapter;
        private Telerik.WinControls.UI.RadDropDownList rddPel;
        private Telerik.WinControls.UI.RadMaskedEditBox txtKeteranganDetail;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabel12;
        private Telerik.WinControls.UI.RadLabel radLabel11;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private System.Windows.Forms.BindingSource vallsupBindingSource;
        private sinarekDataSetTableAdapters.vallsupTableAdapter vallsupTableAdapter;
        private System.Windows.Forms.BindingSource logdetailBindingSource;
        private sinarekDataSetTableAdapters.logdetailTableAdapter logdetailTableAdapter;
    }
}

