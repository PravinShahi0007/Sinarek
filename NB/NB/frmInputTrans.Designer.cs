namespace NB
{
    partial class frmInputTrans
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
            System.Windows.Forms.Label sopirIDLabel;
            System.Windows.Forms.Label kernetIDLabel;
            System.Windows.Forms.Label tanggalLabel;
            System.Windows.Forms.Label tujuanIDLabel;
            System.Windows.Forms.Label salesLabel;
            System.Windows.Forms.Label mobilIDLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label1;
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            this.vproductbaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.tunitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rddMobil = new Telerik.WinControls.UI.RadDropDownList();
            this.mobilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rddSopir = new Telerik.WinControls.UI.RadDropDownList();
            this.sopirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet1 = new NB.sinarekDataSet();
            this.rddKernet = new Telerik.WinControls.UI.RadDropDownList();
            this.kernetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tanggalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rddTujuan = new Telerik.WinControls.UI.RadDropDownList();
            this.kotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rddSales = new Telerik.WinControls.UI.RadDropDownList();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSimpan = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.tableAdapterManager = new NB.fingermachDataSetTableAdapters.TableAdapterManager();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.btnNext = new Telerik.WinControls.UI.RadButton();
            this.rddTipe = new Telerik.WinControls.UI.RadDropDownList();
            this.custtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.txtQuantity = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.rddProduct = new Telerik.WinControls.UI.RadDropDownList();
            this.btnCancelSJ = new Telerik.WinControls.UI.RadButton();
            this.vproductbaseTableAdapter = new NB.sinarekDataSetTableAdapters.vproductbaseTableAdapter();
            this.tunitTableAdapter = new NB.sinarekDataSetTableAdapters.tunitTableAdapter();
            this.kotaTableAdapter = new NB.sinarekDataSetTableAdapters.kotaTableAdapter();
            this.mobilTableAdapter1 = new NB.sinarekDataSetTableAdapters.mobilTableAdapter();
            this.custtypeTableAdapter = new NB.sinarekDataSetTableAdapters.custtypeTableAdapter();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.chkAntar = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.rddPelKernet = new Telerik.WinControls.UI.RadDropDownList();
            this.rddPelMobil = new Telerik.WinControls.UI.RadDropDownList();
            this.rddPelSopir = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.rddPelSales = new Telerik.WinControls.UI.RadDropDownList();
            this.txtMobil = new Telerik.WinControls.UI.RadTextBox();
            this.txtSopir = new Telerik.WinControls.UI.RadTextBox();
            this.mrddPel = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.rddCust = new Telerik.WinControls.UI.RadDropDownList();
            this.satpamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fingermachDataSet = new NB.fingermachDataSet();
            this.radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            this.pelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelTableAdapter = new NB.sinarekDataSetTableAdapters.pelTableAdapter();
            this.radMultiColumnComboBox1 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radMultiColumnComboBox2 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.txtSJ = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.salesTableAdapter = new NB.sinarekDataSetTableAdapters.salesTableAdapter();
            this.buruhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buruhTableAdapter = new NB.sinarekDataSetTableAdapters.buruhTableAdapter();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new NB.fingermachDataSetTableAdapters.staffTableAdapter();
            this.satpamTableAdapter = new NB.fingermachDataSetTableAdapters.satpamTableAdapter();
            this.kernetTableAdapter = new NB.sinarekDataSetTableAdapters.kernetTableAdapter();
            this.sopirTableAdapter = new NB.sinarekDataSetTableAdapters.sopirTableAdapter();
            sopirIDLabel = new System.Windows.Forms.Label();
            kernetIDLabel = new System.Windows.Forms.Label();
            tanggalLabel = new System.Windows.Forms.Label();
            tujuanIDLabel = new System.Windows.Forms.Label();
            salesLabel = new System.Windows.Forms.Label();
            mobilIDLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tunitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddMobil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddSopir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sopirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddKernet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTujuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            this.radPageViewPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAntar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddPelKernet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddPelMobil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddPelSopir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddPelSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSopir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrddPel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.radPageViewPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satpamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buruhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // sopirIDLabel
            // 
            sopirIDLabel.AutoSize = true;
            sopirIDLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            sopirIDLabel.Location = new System.Drawing.Point(2, 31);
            sopirIDLabel.Name = "sopirIDLabel";
            sopirIDLabel.Size = new System.Drawing.Size(43, 19);
            sopirIDLabel.TabIndex = 10;
            sopirIDLabel.Text = "Sopir:";
            // 
            // kernetIDLabel
            // 
            kernetIDLabel.AutoSize = true;
            kernetIDLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            kernetIDLabel.Location = new System.Drawing.Point(2, 60);
            kernetIDLabel.Name = "kernetIDLabel";
            kernetIDLabel.Size = new System.Drawing.Size(52, 19);
            kernetIDLabel.TabIndex = 14;
            kernetIDLabel.Text = "Kernet:";
            // 
            // tanggalLabel
            // 
            tanggalLabel.AutoSize = true;
            tanggalLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            tanggalLabel.Location = new System.Drawing.Point(15, 48);
            tanggalLabel.Name = "tanggalLabel";
            tanggalLabel.Size = new System.Drawing.Size(60, 19);
            tanggalLabel.TabIndex = 20;
            tanggalLabel.Text = "Tanggal:";
            // 
            // tujuanIDLabel
            // 
            tujuanIDLabel.AutoSize = true;
            tujuanIDLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            tujuanIDLabel.Location = new System.Drawing.Point(15, 82);
            tujuanIDLabel.Name = "tujuanIDLabel";
            tujuanIDLabel.Size = new System.Drawing.Size(53, 19);
            tujuanIDLabel.TabIndex = 22;
            tujuanIDLabel.Text = "Tujuan:";
            // 
            // salesLabel
            // 
            salesLabel.AutoSize = true;
            salesLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            salesLabel.Location = new System.Drawing.Point(2, 4);
            salesLabel.Name = "salesLabel";
            salesLabel.Size = new System.Drawing.Size(52, 19);
            salesLabel.TabIndex = 26;
            salesLabel.Text = "Nama :";
            // 
            // mobilIDLabel
            // 
            mobilIDLabel.AutoSize = true;
            mobilIDLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            mobilIDLabel.Location = new System.Drawing.Point(2, 89);
            mobilIDLabel.Name = "mobilIDLabel";
            mobilIDLabel.Size = new System.Drawing.Size(77, 19);
            mobilIDLabel.TabIndex = 8;
            mobilIDLabel.Text = "Kendaraan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            label3.Location = new System.Drawing.Point(232, 25);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 19);
            label3.TabIndex = 45;
            label3.Text = "Jumlah:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            label2.Location = new System.Drawing.Point(16, 13);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 19);
            label2.TabIndex = 49;
            label2.Text = "Tipe:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            label4.Location = new System.Drawing.Point(239, 96);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 19);
            label4.TabIndex = 18;
            label4.Text = "Mobil :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            label5.Location = new System.Drawing.Point(239, 66);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 19);
            label5.TabIndex = 20;
            label5.Text = "Kernet:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(-1, 96);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 19);
            label1.TabIndex = 23;
            label1.Text = "Mobil :";
            // 
            // vproductbaseBindingSource
            // 
            this.vproductbaseBindingSource.DataMember = "vproductbase";
            this.vproductbaseBindingSource.DataSource = this.sinarekDataSet;
            this.vproductbaseBindingSource.Filter = "sellable = 1";
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tunitBindingSource
            // 
            this.tunitBindingSource.DataMember = "tunit";
            this.tunitBindingSource.DataSource = this.sinarekDataSet;
            // 
            // rddMobil
            // 
            this.rddMobil.AutoCompleteDisplayMember = "NoPolis";
            this.rddMobil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddMobil.AutoCompleteValueMember = "MobilID";
            this.rddMobil.DataSource = this.mobilBindingSource1;
            this.rddMobil.DisplayMember = "NoPolis";
            this.rddMobil.DropDownAnimationEnabled = true;
            this.rddMobil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddMobil.Location = new System.Drawing.Point(85, 89);
            this.rddMobil.Name = "rddMobil";
            this.rddMobil.ShowImageInEditorArea = true;
            this.rddMobil.Size = new System.Drawing.Size(163, 23);
            this.rddMobil.TabIndex = 6;
            this.rddMobil.ThemeName = "Office2007Black";
            this.rddMobil.ValueMember = "MobilID";
            // 
            // mobilBindingSource1
            // 
            this.mobilBindingSource1.DataMember = "mobil";
            this.mobilBindingSource1.DataSource = this.sinarekDataSet;
            // 
            // rddSopir
            // 
            this.rddSopir.AutoCompleteDisplayMember = "Nama";
            this.rddSopir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddSopir.AutoCompleteValueMember = "SopirID";
            this.rddSopir.DataSource = this.sopirBindingSource;
            this.rddSopir.DisplayMember = "Nama";
            this.rddSopir.DropDownAnimationEnabled = true;
            this.rddSopir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddSopir.Location = new System.Drawing.Point(85, 31);
            this.rddSopir.Name = "rddSopir";
            this.rddSopir.ShowImageInEditorArea = true;
            this.rddSopir.Size = new System.Drawing.Size(163, 23);
            this.rddSopir.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.rddSopir.TabIndex = 5;
            this.rddSopir.ThemeName = "Office2007Black";
            this.rddSopir.ValueMember = "SopirID";
            // 
            // sopirBindingSource
            // 
            this.sopirBindingSource.DataMember = "sopir";
            this.sopirBindingSource.DataSource = this.sinarekDataSet1;
            // 
            // sinarekDataSet1
            // 
            this.sinarekDataSet1.DataSetName = "sinarekDataSet";
            this.sinarekDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rddKernet
            // 
            this.rddKernet.AutoCompleteDisplayMember = "Nama";
            this.rddKernet.AutoCompleteValueMember = "KernetID";
            this.rddKernet.DataSource = this.kernetBindingSource;
            this.rddKernet.DisplayMember = "Nama";
            this.rddKernet.DropDownAnimationEnabled = true;
            this.rddKernet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddKernet.Location = new System.Drawing.Point(85, 60);
            this.rddKernet.Name = "rddKernet";
            this.rddKernet.ShowImageInEditorArea = true;
            this.rddKernet.Size = new System.Drawing.Size(163, 23);
            this.rddKernet.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.rddKernet.TabIndex = 4;
            this.rddKernet.ThemeName = "Office2007Black";
            this.rddKernet.ValueMember = "KernetID";
            // 
            // kernetBindingSource
            // 
            this.kernetBindingSource.DataMember = "kernet";
            this.kernetBindingSource.DataSource = this.sinarekDataSet1;
            // 
            // tanggalDateTimePicker
            // 
            this.tanggalDateTimePicker.CustomFormat = "dddd, dd MMM yyy";
            this.tanggalDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tanggalDateTimePicker.Location = new System.Drawing.Point(76, 45);
            this.tanggalDateTimePicker.Name = "tanggalDateTimePicker";
            this.tanggalDateTimePicker.Size = new System.Drawing.Size(187, 25);
            this.tanggalDateTimePicker.TabIndex = 1;
            // 
            // rddTujuan
            // 
            this.rddTujuan.AutoCompleteDisplayMember = "Nama";
            this.rddTujuan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddTujuan.AutoCompleteValueMember = "KotaID";
            this.rddTujuan.DataSource = this.kotaBindingSource;
            this.rddTujuan.DisplayMember = "Nama";
            this.rddTujuan.DropDownAnimationEnabled = true;
            this.rddTujuan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddTujuan.Location = new System.Drawing.Point(76, 80);
            this.rddTujuan.Name = "rddTujuan";
            this.rddTujuan.ShowImageInEditorArea = true;
            this.rddTujuan.Size = new System.Drawing.Size(187, 23);
            this.rddTujuan.TabIndex = 2;
            this.rddTujuan.ThemeName = "Office2007Black";
            this.rddTujuan.ValueMember = "KotaID";
            this.rddTujuan.SelectedValueChanged += new System.EventHandler(this.rddTujuan_SelectedValueChanged);
            // 
            // kotaBindingSource
            // 
            this.kotaBindingSource.DataMember = "kota";
            this.kotaBindingSource.DataSource = this.sinarekDataSet;
            this.kotaBindingSource.Filter = "systemonly = 0";
            this.kotaBindingSource.Sort = "Nama Asc";
            // 
            // rddSales
            // 
            this.rddSales.AutoCompleteDisplayMember = "Nama";
            this.rddSales.AutoCompleteValueMember = "SalesID";
            this.rddSales.DataSource = this.salesBindingSource;
            this.rddSales.DisplayMember = "Nama";
            this.rddSales.DropDownAnimationEnabled = true;
            this.rddSales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddSales.Location = new System.Drawing.Point(85, 4);
            this.rddSales.Name = "rddSales";
            this.rddSales.ShowImageInEditorArea = true;
            this.rddSales.Size = new System.Drawing.Size(163, 23);
            this.rddSales.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.rddSales.TabIndex = 3;
            this.rddSales.Text = "Sales";
            this.rddSales.ThemeName = "Office2007Black";
            this.rddSales.ValueMember = "SalesID";
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.sinarekDataSet;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.Location = new System.Drawing.Point(196, 467);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(124, 28);
            this.btnSimpan.TabIndex = 21;
            this.btnSimpan.Text = "&Simpan and Print";
            this.btnSimpan.ThemeName = "Office2007Black";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(407, 467);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 28);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "&Batal";
            this.btnCancel.ThemeName = "Office2007Black";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.absenbulananTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.gajibulananTableAdapter = null;
            this.tableAdapterManager.gajidetailtempTableAdapter = null;
            this.tableAdapterManager.mobilTableAdapter = null;
            this.tableAdapterManager.satpamTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.tipehadirTableAdapter = null;
            this.tableAdapterManager.tproductTableAdapter = null;
            this.tableAdapterManager.tujuanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NB.fingermachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // radGridView1
            // 
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGridView1.Location = new System.Drawing.Point(10, 335);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn1.FieldName = "detailid";
            gridViewTextBoxColumn1.HeaderText = "detailid";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "detailid";
            gridViewComboBoxColumn1.DataSource = this.vproductbaseBindingSource;
            gridViewComboBoxColumn1.DisplayMember = "ProdShort";
            gridViewComboBoxColumn1.FieldName = "productid";
            gridViewComboBoxColumn1.FormatString = "";
            gridViewComboBoxColumn1.HeaderText = "Nama Barang";
            gridViewComboBoxColumn1.Name = "productid";
            gridViewComboBoxColumn1.ValueMember = "baseid";
            gridViewComboBoxColumn1.Width = 250;
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "Jumlah";
            gridViewDecimalColumn1.Name = "quantity";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn1.Width = 150;
            gridViewComboBoxColumn2.DataSource = this.tunitBindingSource;
            gridViewComboBoxColumn2.DisplayMember = "Short";
            gridViewComboBoxColumn2.FieldName = "unitid";
            gridViewComboBoxColumn2.FormatString = "";
            gridViewComboBoxColumn2.HeaderText = "";
            gridViewComboBoxColumn2.IsPinned = true;
            gridViewComboBoxColumn2.Name = "unitid";
            gridViewComboBoxColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Right;
            gridViewComboBoxColumn2.ValueMember = "unitid";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewComboBoxColumn1,
            gridViewDecimalColumn1,
            gridViewComboBoxColumn2});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(491, 123);
            this.radGridView1.TabIndex = 37;
            this.radGridView1.Text = "radGridView1";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNext.Location = new System.Drawing.Point(10, 467);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 28);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Print and &Next";
            this.btnNext.ThemeName = "Office2007Black";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rddTipe
            // 
            this.rddTipe.AutoCompleteDisplayMember = "Name";
            this.rddTipe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddTipe.AutoCompleteValueMember = "CustTypeID";
            this.rddTipe.DataSource = this.custtypeBindingSource;
            this.rddTipe.DisplayMember = "Name";
            this.rddTipe.DropDownAnimationEnabled = true;
            this.rddTipe.Enabled = false;
            this.rddTipe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddTipe.Location = new System.Drawing.Point(76, 9);
            this.rddTipe.Name = "rddTipe";
            this.rddTipe.ShowImageInEditorArea = true;
            this.rddTipe.Size = new System.Drawing.Size(146, 23);
            this.rddTipe.TabIndex = 0;
            this.rddTipe.ValueMember = "CustTypeID";
            this.rddTipe.SelectedValueChanged += new System.EventHandler(this.rddTipe_SelectedValueChanged);
            // 
            // custtypeBindingSource
            // 
            this.custtypeBindingSource.DataMember = "custtype";
            this.custtypeBindingSource.DataSource = this.sinarekDataSet;
            this.custtypeBindingSource.Filter = "";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.btnAdd);
            this.radGroupBox2.Controls.Add(label3);
            this.radGroupBox2.Controls.Add(this.txtQuantity);
            this.radGroupBox2.Controls.Add(this.rddProduct);
            this.radGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Produk";
            this.radGroupBox2.Location = new System.Drawing.Point(10, 278);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(491, 53);
            this.radGroupBox2.TabIndex = 7;
            this.radGroupBox2.TabStop = false;
            this.radGroupBox2.Text = "Produk";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Location = new System.Drawing.Point(398, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 25);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Tag = "add";
            this.btnAdd.Text = "&Add";
            this.btnAdd.ThemeName = "Office2007Black";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.AllowPromptAsInput = false;
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQuantity.Location = new System.Drawing.Point(289, 21);
            this.txtQuantity.Mask = "n1";
            this.txtQuantity.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(67, 23);
            this.txtQuantity.TabIndex = 11;
            this.txtQuantity.TabStop = false;
            this.txtQuantity.Text = "0.0";
            this.txtQuantity.Value = "0.0";
            // 
            // rddProduct
            // 
            this.rddProduct.AutoCompleteDisplayMember = "ProdName";
            this.rddProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddProduct.AutoCompleteValueMember = "baseid";
            this.rddProduct.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vproductbaseBindingSource, "unitid", true));
            this.rddProduct.DataSource = this.vproductbaseBindingSource;
            this.rddProduct.DisplayMember = "ProdName";
            this.rddProduct.DropDownAnimationEnabled = true;
            this.rddProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddProduct.Location = new System.Drawing.Point(9, 21);
            this.rddProduct.Name = "rddProduct";
            this.rddProduct.ShowImageInEditorArea = true;
            this.rddProduct.Size = new System.Drawing.Size(197, 23);
            this.rddProduct.TabIndex = 10;
            this.rddProduct.ValueMember = "baseid";
            // 
            // btnCancelSJ
            // 
            this.btnCancelSJ.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelSJ.Location = new System.Drawing.Point(317, 44);
            this.btnCancelSJ.Name = "btnCancelSJ";
            this.btnCancelSJ.Size = new System.Drawing.Size(184, 23);
            this.btnCancelSJ.TabIndex = 39;
            this.btnCancelSJ.Tag = "delete";
            this.btnCancelSJ.Text = "Batalkan Surat &Jalan";
            this.btnCancelSJ.ThemeName = "Office2007Black";
            this.btnCancelSJ.Visible = false;
            this.btnCancelSJ.Click += new System.EventHandler(this.btnCancelSJ_Click);
            // 
            // vproductbaseTableAdapter
            // 
            this.vproductbaseTableAdapter.ClearBeforeFill = true;
            // 
            // tunitTableAdapter
            // 
            this.tunitTableAdapter.ClearBeforeFill = true;
            // 
            // kotaTableAdapter
            // 
            this.kotaTableAdapter.ClearBeforeFill = true;
            // 
            // mobilTableAdapter1
            // 
            this.mobilTableAdapter1.ClearBeforeFill = true;
            // 
            // custtypeTableAdapter
            // 
            this.custtypeTableAdapter.ClearBeforeFill = true;
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Controls.Add(this.radPageViewPage3);
            this.radPageView1.Controls.Add(this.radPageViewPage4);
            this.radPageView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radPageView1.Location = new System.Drawing.Point(5, 104);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage4;
            this.radPageView1.Size = new System.Drawing.Size(505, 177);
            this.radPageView1.TabIndex = 3;
            this.radPageView1.TabStop = false;
            this.radPageView1.Text = "Sales";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.rddSales);
            this.radPageViewPage1.Controls.Add(sopirIDLabel);
            this.radPageViewPage1.Controls.Add(mobilIDLabel);
            this.radPageViewPage1.Controls.Add(salesLabel);
            this.radPageViewPage1.Controls.Add(this.rddKernet);
            this.radPageViewPage1.Controls.Add(this.rddMobil);
            this.radPageViewPage1.Controls.Add(this.rddSopir);
            this.radPageViewPage1.Controls.Add(kernetIDLabel);
            this.radPageViewPage1.Location = new System.Drawing.Point(10, 40);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(484, 126);
            this.radPageViewPage1.Text = "Sales";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Controls.Add(label1);
            this.radPageViewPage2.Controls.Add(this.radLabel2);
            this.radPageViewPage2.Controls.Add(this.chkAntar);
            this.radPageViewPage2.Controls.Add(this.radLabel6);
            this.radPageViewPage2.Controls.Add(this.rddPelKernet);
            this.radPageViewPage2.Controls.Add(label4);
            this.radPageViewPage2.Controls.Add(this.rddPelMobil);
            this.radPageViewPage2.Controls.Add(this.rddPelSopir);
            this.radPageViewPage2.Controls.Add(label5);
            this.radPageViewPage2.Controls.Add(this.radLabel5);
            this.radPageViewPage2.Controls.Add(this.rddPelSales);
            this.radPageViewPage2.Controls.Add(this.txtMobil);
            this.radPageViewPage2.Controls.Add(this.txtSopir);
            this.radPageViewPage2.Controls.Add(this.mrddPel);
            this.radPageViewPage2.Controls.Add(this.radLabel1);
            this.radPageViewPage2.Location = new System.Drawing.Point(10, 40);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(484, 126);
            this.radPageViewPage2.Text = "Pelanggan";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(-1, 65);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(45, 21);
            this.radLabel2.TabIndex = 22;
            this.radLabel2.Text = "Sopir :";
            // 
            // chkAntar
            // 
            this.chkAntar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAntar.Location = new System.Drawing.Point(243, 9);
            this.chkAntar.Name = "chkAntar";
            this.chkAntar.Size = new System.Drawing.Size(71, 21);
            this.chkAntar.TabIndex = 4;
            this.chkAntar.Text = "Di Antar";
            this.chkAntar.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkAntar_ToggleStateChanged);
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(239, 35);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(45, 21);
            this.radLabel6.TabIndex = 21;
            this.radLabel6.Text = "Sopir :";
            // 
            // rddPelKernet
            // 
            this.rddPelKernet.AutoCompleteDisplayMember = "Nama";
            this.rddPelKernet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddPelKernet.AutoCompleteValueMember = "KernetID";
            this.rddPelKernet.DataSource = this.kernetBindingSource;
            this.rddPelKernet.DisplayMember = "Nama";
            this.rddPelKernet.DropDownAnimationEnabled = true;
            this.rddPelKernet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddPelKernet.Location = new System.Drawing.Point(317, 64);
            this.rddPelKernet.Name = "rddPelKernet";
            this.rddPelKernet.ShowImageInEditorArea = true;
            this.rddPelKernet.Size = new System.Drawing.Size(163, 23);
            this.rddPelKernet.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.rddPelKernet.TabIndex = 7;
            this.rddPelKernet.ThemeName = "Office2007Black";
            this.rddPelKernet.ValueMember = "KernetID";
            // 
            // rddPelMobil
            // 
            this.rddPelMobil.AutoCompleteDisplayMember = "NoPolis";
            this.rddPelMobil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddPelMobil.AutoCompleteValueMember = "MobilID";
            this.rddPelMobil.DataSource = this.mobilBindingSource1;
            this.rddPelMobil.DisplayMember = "NoPolis";
            this.rddPelMobil.DropDownAnimationEnabled = true;
            this.rddPelMobil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddPelMobil.Location = new System.Drawing.Point(317, 94);
            this.rddPelMobil.Name = "rddPelMobil";
            this.rddPelMobil.ShowImageInEditorArea = true;
            this.rddPelMobil.Size = new System.Drawing.Size(163, 23);
            this.rddPelMobil.TabIndex = 8;
            this.rddPelMobil.ThemeName = "Office2007Black";
            this.rddPelMobil.ValueMember = "MobilID";
            // 
            // rddPelSopir
            // 
            this.rddPelSopir.AutoCompleteDisplayMember = "Nama";
            this.rddPelSopir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddPelSopir.AutoCompleteValueMember = "SopirID";
            this.rddPelSopir.DataSource = this.sopirBindingSource;
            this.rddPelSopir.DisplayMember = "Nama";
            this.rddPelSopir.DropDownAnimationEnabled = true;
            this.rddPelSopir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddPelSopir.Location = new System.Drawing.Point(317, 34);
            this.rddPelSopir.Name = "rddPelSopir";
            this.rddPelSopir.ShowImageInEditorArea = true;
            this.rddPelSopir.Size = new System.Drawing.Size(163, 23);
            this.rddPelSopir.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.rddPelSopir.TabIndex = 6;
            this.rddPelSopir.ThemeName = "Office2007Black";
            this.rddPelSopir.ValueMember = "SopirID";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(-1, 35);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(44, 21);
            this.radLabel5.TabIndex = 9;
            this.radLabel5.Text = "Sales :";
            // 
            // rddPelSales
            // 
            this.rddPelSales.AutoCompleteDisplayMember = "Nama";
            this.rddPelSales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddPelSales.AutoCompleteValueMember = "SalesID";
            this.rddPelSales.DataSource = this.salesBindingSource;
            this.rddPelSales.DisplayMember = "Nama";
            this.rddPelSales.DropDownAnimationEnabled = true;
            this.rddPelSales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddPelSales.Location = new System.Drawing.Point(63, 34);
            this.rddPelSales.Name = "rddPelSales";
            this.rddPelSales.ShowImageInEditorArea = true;
            this.rddPelSales.Size = new System.Drawing.Size(173, 23);
            this.rddPelSales.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.rddPelSales.TabIndex = 5;
            this.rddPelSales.ThemeName = "Office2007Black";
            this.rddPelSales.ValueMember = "SalesID";
            // 
            // txtMobil
            // 
            this.txtMobil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMobil.Location = new System.Drawing.Point(62, 94);
            this.txtMobil.Name = "txtMobil";
            this.txtMobil.Size = new System.Drawing.Size(173, 23);
            this.txtMobil.TabIndex = 7;
            this.txtMobil.TabStop = false;
            // 
            // txtSopir
            // 
            this.txtSopir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSopir.Location = new System.Drawing.Point(62, 64);
            this.txtSopir.Name = "txtSopir";
            this.txtSopir.Size = new System.Drawing.Size(173, 23);
            this.txtSopir.TabIndex = 6;
            this.txtSopir.TabStop = false;
            // 
            // mrddPel
            // 
            this.mrddPel.AutoFilter = true;
            this.mrddPel.DisplayMember = "Name";
            this.mrddPel.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            // 
            // mrddPel.NestedRadGridView
            // 
            this.mrddPel.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.mrddPel.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrddPel.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mrddPel.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.mrddPel.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.mrddPel.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.mrddPel.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.mrddPel.EditorControl.MasterTemplate.EnableFiltering = true;
            this.mrddPel.EditorControl.MasterTemplate.EnableGrouping = false;
            this.mrddPel.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.mrddPel.EditorControl.Name = "NestedRadGridView";
            this.mrddPel.EditorControl.ReadOnly = true;
            this.mrddPel.EditorControl.ShowGroupPanel = false;
            this.mrddPel.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.mrddPel.EditorControl.TabIndex = 0;
            this.mrddPel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mrddPel.Location = new System.Drawing.Point(63, 4);
            this.mrddPel.Name = "mrddPel";
            // 
            // 
            // 
            this.mrddPel.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.mrddPel.Size = new System.Drawing.Size(173, 23);
            this.mrddPel.TabIndex = 3;
            this.mrddPel.TabStop = false;
            this.mrddPel.ValueMember = "custid";
            this.mrddPel.Enter += new System.EventHandler(this.mrddPel_Enter);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(-1, 5);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(46, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Nama:";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.Controls.Add(this.radLabel4);
            this.radPageViewPage3.Controls.Add(this.rddCust);
            this.radPageViewPage3.Location = new System.Drawing.Point(10, 40);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(484, 126);
            this.radPageViewPage3.Text = "Buruh / Staff / Satpam";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(7, 20);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(50, 21);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "Nama :";
            // 
            // rddCust
            // 
            this.rddCust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddCust.DataSource = this.satpamBindingSource;
            this.rddCust.DropDownAnimationEnabled = true;
            this.rddCust.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddCust.Location = new System.Drawing.Point(78, 19);
            this.rddCust.Name = "rddCust";
            this.rddCust.ShowImageInEditorArea = true;
            this.rddCust.Size = new System.Drawing.Size(242, 23);
            this.rddCust.TabIndex = 3;
            // 
            // satpamBindingSource
            // 
            this.satpamBindingSource.DataMember = "satpam";
            this.satpamBindingSource.DataSource = this.fingermachDataSet;
            this.satpamBindingSource.Filter = "active = 1";
            // 
            // fingermachDataSet
            // 
            this.fingermachDataSet.DataSetName = "fingermachDataSet";
            this.fingermachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radPageViewPage4
            // 
            this.radPageViewPage4.Location = new System.Drawing.Point(10, 40);
            this.radPageViewPage4.Name = "radPageViewPage4";
            this.radPageViewPage4.Size = new System.Drawing.Size(484, 126);
            this.radPageViewPage4.Text = "Contoh";
            // 
            // pelBindingSource
            // 
            this.pelBindingSource.DataMember = "pel";
            this.pelBindingSource.DataSource = this.sinarekDataSet;
            this.pelBindingSource.Filter = "Direct =1";
            this.pelBindingSource.Sort = "Name Asc";
            // 
            // pelTableAdapter
            // 
            this.pelTableAdapter.ClearBeforeFill = true;
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
            this.txtSJ.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSJ.Location = new System.Drawing.Point(318, 80);
            this.txtSJ.Name = "txtSJ";
            this.txtSJ.Size = new System.Drawing.Size(182, 23);
            this.txtSJ.TabIndex = 50;
            this.txtSJ.TabStop = false;
            this.txtSJ.Text = "No SJ";
            this.txtSJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSJ.Visible = false;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(label2);
            this.radGroupBox1.Controls.Add(this.txtSJ);
            this.radGroupBox1.Controls.Add(this.rddTipe);
            this.radGroupBox1.Controls.Add(this.radPageView1);
            this.radGroupBox1.Controls.Add(this.rddTujuan);
            this.radGroupBox1.Controls.Add(this.radGroupBox2);
            this.radGroupBox1.Controls.Add(this.btnSimpan);
            this.radGroupBox1.Controls.Add(this.btnCancelSJ);
            this.radGroupBox1.Controls.Add(tujuanIDLabel);
            this.radGroupBox1.Controls.Add(tanggalLabel);
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.Controls.Add(this.btnNext);
            this.radGroupBox1.Controls.Add(this.tanggalDateTimePicker);
            this.radGroupBox1.Controls.Add(this.radGridView1);
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
            this.radGroupBox1.Size = new System.Drawing.Size(516, 509);
            this.radGroupBox1.TabIndex = 51;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // buruhBindingSource
            // 
            this.buruhBindingSource.DataMember = "buruh";
            this.buruhBindingSource.DataSource = this.sinarekDataSet;
            this.buruhBindingSource.Filter = "active = 1";
            // 
            // buruhTableAdapter
            // 
            this.buruhTableAdapter.ClearBeforeFill = true;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.fingermachDataSet;
            this.staffBindingSource.Filter = "active = 1";
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // satpamTableAdapter
            // 
            this.satpamTableAdapter.ClearBeforeFill = true;
            // 
            // kernetTableAdapter
            // 
            this.kernetTableAdapter.ClearBeforeFill = true;
            // 
            // sopirTableAdapter
            // 
            this.sopirTableAdapter.ClearBeforeFill = true;
            // 
            // frmInputSJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 509);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInputSJ";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Surat Jalan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tunitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddMobil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddSopir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sopirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddKernet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTujuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage1.PerformLayout();
            this.radPageViewPage2.ResumeLayout(false);
            this.radPageViewPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAntar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddPelKernet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddPelMobil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddPelSopir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddPelSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSopir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrddPel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.radPageViewPage3.ResumeLayout(false);
            this.radPageViewPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satpamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buruhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private fingermachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Telerik.WinControls.UI.RadDropDownList rddMobil;
        private Telerik.WinControls.UI.RadDropDownList rddSopir;
        private Telerik.WinControls.UI.RadDropDownList rddKernet;
        private System.Windows.Forms.DateTimePicker tanggalDateTimePicker;
        private Telerik.WinControls.UI.RadDropDownList rddTujuan;
        private Telerik.WinControls.UI.RadDropDownList rddSales;
        private Telerik.WinControls.UI.RadButton btnSimpan;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton btnNext;
        private Telerik.WinControls.UI.RadButton btnCancelSJ;
        private Telerik.WinControls.UI.RadDropDownList rddProduct;
        private Telerik.WinControls.UI.RadMaskedEditBox txtQuantity;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadDropDownList rddTipe;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource vproductbaseBindingSource;
        private sinarekDataSetTableAdapters.vproductbaseTableAdapter vproductbaseTableAdapter;
        private System.Windows.Forms.BindingSource tunitBindingSource;
        private sinarekDataSetTableAdapters.tunitTableAdapter tunitTableAdapter;
        private System.Windows.Forms.BindingSource kotaBindingSource;
        private sinarekDataSetTableAdapters.kotaTableAdapter kotaTableAdapter;
        private System.Windows.Forms.BindingSource mobilBindingSource1;
        private sinarekDataSetTableAdapters.mobilTableAdapter mobilTableAdapter1;
        private System.Windows.Forms.BindingSource custtypeBindingSource;
        private sinarekDataSetTableAdapters.custtypeTableAdapter custtypeTableAdapter;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtMobil;
        private Telerik.WinControls.UI.RadMultiColumnComboBox mrddPel;
        private Telerik.WinControls.UI.RadTextBox txtSopir;
        private System.Windows.Forms.BindingSource pelBindingSource;
        private sinarekDataSetTableAdapters.pelTableAdapter pelTableAdapter;
        private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox2;
        private Telerik.WinControls.UI.RadDropDownList rddCust;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtSJ;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDropDownList rddPelSales;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private sinarekDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource buruhBindingSource;
        private sinarekDataSetTableAdapters.buruhTableAdapter buruhTableAdapter;
        private fingermachDataSet fingermachDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private fingermachDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource satpamBindingSource;
        private fingermachDataSetTableAdapters.satpamTableAdapter satpamTableAdapter;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadDropDownList rddPelKernet;
        private Telerik.WinControls.UI.RadDropDownList rddPelMobil;
        private Telerik.WinControls.UI.RadDropDownList rddPelSopir;
        private Telerik.WinControls.UI.RadCheckBox chkAntar;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private sinarekDataSet sinarekDataSet1;
        private System.Windows.Forms.BindingSource kernetBindingSource;
        private sinarekDataSetTableAdapters.kernetTableAdapter kernetTableAdapter;
        private System.Windows.Forms.BindingSource sopirBindingSource;
        private sinarekDataSetTableAdapters.sopirTableAdapter sopirTableAdapter;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage4;
    }
}

