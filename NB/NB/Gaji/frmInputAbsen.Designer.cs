namespace NB
{
    partial class frmInputAbsen
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn3 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn4 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor4 = new Telerik.WinControls.Data.SortDescriptor();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.tipehadirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buruhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.absenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new NB.sinarekDataSetTableAdapters.TableAdapterManager();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rddTipeHadir = new Telerik.WinControls.UI.RadDropDownList();
            this.btnSetSelected = new Telerik.WinControls.UI.RadButton();
            this.dtpTanggal = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ddlTipeAbsen = new Telerik.WinControls.UI.RadDropDownList();
            this.tipememberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipehadirBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tipehadirTableAdapter1 = new NB.sinarekDataSetTableAdapters.tipehadirTableAdapter();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.absenallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new NB.sinarekDataSetTableAdapters.memberTableAdapter();
            this.tipememberTableAdapter = new NB.sinarekDataSetTableAdapters.tipememberTableAdapter();
            this.absenallTableAdapter = new NB.sinarekDataSetTableAdapters.absenallTableAdapter();
            this.btnCheckData = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipehadirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buruhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipeHadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTipeAbsen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipememberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipehadirBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this.sinarekDataSet;
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipehadirBindingSource
            // 
            this.tipehadirBindingSource.DataMember = "tipehadir";
            this.tipehadirBindingSource.DataSource = this.sinarekDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.absenallTableAdapter = null;
            this.tableAdapterManager.accpaymentTableAdapter = null;
            this.tableAdapterManager.acctransTableAdapter = null;
            this.tableAdapterManager.actionlogTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.boronganburuhTableAdapter = null;
            this.tableAdapterManager.boronganTableAdapter = null;
            this.tableAdapterManager.comissionTableAdapter = null;
            this.tableAdapterManager.companyTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.custtypeTableAdapter = null;
            this.tableAdapterManager.formulaTableAdapter = null;
            this.tableAdapterManager.gajibulananTableAdapter = null;
            this.tableAdapterManager.gajimingguanTableAdapter = null;
            this.tableAdapterManager.gajitemplateallTableAdapter = null;
            this.tableAdapterManager.gajitetapTableAdapter = null;
            this.tableAdapterManager.genderTableAdapter = null;
            this.tableAdapterManager.kernetTableAdapter = null;
            this.tableAdapterManager.kotaTableAdapter = null;
            this.tableAdapterManager.lappenTableAdapter = null;
            this.tableAdapterManager.logdetailTableAdapter = null;
            this.tableAdapterManager.logotherTableAdapter = null;
            this.tableAdapterManager.logpelTableAdapter = null;
            this.tableAdapterManager.logproductTableAdapter = null;
            this.tableAdapterManager.memberTableAdapter = null;
            this.tableAdapterManager.mobilTableAdapter = null;
            this.tableAdapterManager.payrolltypeTableAdapter = null;
            this.tableAdapterManager.pelTableAdapter = null;
            this.tableAdapterManager.pengisianTableAdapter = null;
            this.tableAdapterManager.pinjamanTableAdapter = null;
            this.tableAdapterManager.printlogTableAdapter = null;
            this.tableAdapterManager.productbaseTableAdapter = null;
            this.tableAdapterManager.productpriceTableAdapter = null;
            this.tableAdapterManager.productsuptotalTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.producttotalTableAdapter = null;
            this.tableAdapterManager.producttotaluserTableAdapter = null;
            this.tableAdapterManager.producttransTableAdapter = null;
            this.tableAdapterManager.rinciangajiTableAdapter = null;
            this.tableAdapterManager.saldocutiTableAdapter = null;
            this.tableAdapterManager.salescomissionTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.shiftdayTableAdapter = null;
            this.tableAdapterManager.shiftTableAdapter = null;
            this.tableAdapterManager.sopirTableAdapter = null;
            this.tableAdapterManager.statbotTableAdapter = null;
            this.tableAdapterManager.storeinTableAdapter = null;
            this.tableAdapterManager.storeoutTableAdapter = null;
            this.tableAdapterManager.storeTableAdapter = null;
            this.tableAdapterManager.storeuseTableAdapter = null;
            this.tableAdapterManager.supTableAdapter = null;
            this.tableAdapterManager.syslogTableAdapter = null;
            this.tableAdapterManager.tierTableAdapter = null;
            this.tableAdapterManager.tipeaccountTableAdapter = null;
            this.tableAdapterManager.tipedendaTableAdapter = null;
            this.tableAdapterManager.tipememberTableAdapter = null;
            this.tableAdapterManager.tipepembayaranTableAdapter = null;
            this.tableAdapterManager.tipeprodTableAdapter = null;
            this.tableAdapterManager.tiperinciangajiTableAdapter = null;
            this.tableAdapterManager.transportTableAdapter = null;
            this.tableAdapterManager.tunitTableAdapter = null;
            this.tableAdapterManager.uangjalanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NB.sinarekDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vpengisianTableAdapter = null;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnCheckData);
            this.radGroupBox1.Controls.Add(this.rddTipeHadir);
            this.radGroupBox1.Controls.Add(this.btnSetSelected);
            this.radGroupBox1.Controls.Add(this.dtpTanggal);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.ddlTipeAbsen);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "Absen";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(655, 100);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "Absen";
            // 
            // rddTipeHadir
            // 
            this.rddTipeHadir.AutoCompleteDisplayMember = "Nama";
            this.rddTipeHadir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddTipeHadir.AutoCompleteValueMember = "tipehadirid";
            this.rddTipeHadir.DataSource = this.tipehadirBindingSource;
            this.rddTipeHadir.DisplayMember = "Nama";
            this.rddTipeHadir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddTipeHadir.Location = new System.Drawing.Point(346, 22);
            this.rddTipeHadir.Name = "rddTipeHadir";
            this.rddTipeHadir.Size = new System.Drawing.Size(156, 23);
            this.rddTipeHadir.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.rddTipeHadir.TabIndex = 8;
            this.rddTipeHadir.ValueMember = "tipehadirid";
            // 
            // btnSetSelected
            // 
            this.btnSetSelected.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSetSelected.Location = new System.Drawing.Point(508, 22);
            this.btnSetSelected.Name = "btnSetSelected";
            this.btnSetSelected.Size = new System.Drawing.Size(135, 22);
            this.btnSetSelected.TabIndex = 7;
            this.btnSetSelected.Text = "Set Day as Selection";
            this.btnSetSelected.Click += new System.EventHandler(this.btnSetSelected_Click);
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd MMM yyy";
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(112, 21);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(189, 23);
            this.dtpTanggal.TabIndex = 6;
            this.dtpTanggal.TabStop = false;
            this.dtpTanggal.Text = "29 Jun 2012";
            this.dtpTanggal.Value = new System.DateTime(2012, 6, 29, 20, 59, 55, 133);
            this.dtpTanggal.ValueChanged += new System.EventHandler(this.dtpTanggal_ValueChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(24, 21);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(52, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Tanggal :";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(24, 59);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(67, 18);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Tipe Absen :";
            // 
            // ddlTipeAbsen
            // 
            this.ddlTipeAbsen.AutoCompleteDisplayMember = "Description";
            this.ddlTipeAbsen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlTipeAbsen.AutoCompleteValueMember = "tipememberid";
            this.ddlTipeAbsen.DataSource = this.tipememberBindingSource;
            this.ddlTipeAbsen.DisplayMember = "Description";
            this.ddlTipeAbsen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ddlTipeAbsen.Location = new System.Drawing.Point(111, 59);
            this.ddlTipeAbsen.Name = "ddlTipeAbsen";
            this.ddlTipeAbsen.Size = new System.Drawing.Size(190, 23);
            this.ddlTipeAbsen.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.ddlTipeAbsen.TabIndex = 3;
            this.ddlTipeAbsen.ValueMember = "tipememberid";
            this.ddlTipeAbsen.SelectedValueChanged += new System.EventHandler(this.ddlTipeAbsen_SelectedValueChanged);
            // 
            // tipememberBindingSource
            // 
            this.tipememberBindingSource.DataMember = "tipemember";
            this.tipememberBindingSource.DataSource = this.sinarekDataSet;
            // 
            // tipehadirBindingSource1
            // 
            this.tipehadirBindingSource1.DataMember = "tipehadir";
            this.tipehadirBindingSource1.DataSource = this.sinarekDataSet;
            // 
            // tipehadirTableAdapter1
            // 
            this.tipehadirTableAdapter1.ClearBeforeFill = true;
            // 
            // radGridView1
            // 
            this.radGridView1.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnF2;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGridView1.EnableKeyMap = true;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGridView1.Location = new System.Drawing.Point(0, 100);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AllowDeleteRow = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn2.DataType = typeof(uint);
            gridViewDecimalColumn2.FieldName = "Absenid";
            gridViewDecimalColumn2.HeaderText = "Absenid";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "Absenid";
            gridViewDecimalColumn2.VisibleInColumnChooser = false;
            gridViewComboBoxColumn3.DataSource = this.memberBindingSource;
            gridViewComboBoxColumn3.DataType = typeof(int);
            gridViewComboBoxColumn3.DisplayMember = "Name";
            gridViewComboBoxColumn3.DisplayMemberSort = true;
            gridViewComboBoxColumn3.FieldName = "MemberID";
            gridViewComboBoxColumn3.HeaderText = "Nama";
            gridViewComboBoxColumn3.Name = "MemberID";
            gridViewComboBoxColumn3.ReadOnly = true;
            gridViewComboBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewComboBoxColumn3.ValueMember = "MemberID";
            gridViewComboBoxColumn3.Width = 160;
            gridViewDateTimeColumn2.AllowFiltering = false;
            gridViewDateTimeColumn2.CustomFormat = "dd MMM yyyy";
            gridViewDateTimeColumn2.FieldName = "tanggal";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn2.FormatString = "{0:dd MMM yyyy}";
            gridViewDateTimeColumn2.HeaderText = "Tanggal";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "tanggal";
            gridViewDateTimeColumn2.ReadOnly = true;
            gridViewDateTimeColumn2.Width = 100;
            gridViewComboBoxColumn4.AllowFiltering = false;
            gridViewComboBoxColumn4.AllowGroup = false;
            gridViewComboBoxColumn4.DataSource = this.tipehadirBindingSource;
            gridViewComboBoxColumn4.DataType = typeof(short);
            gridViewComboBoxColumn4.DisplayMember = "Nama";
            gridViewComboBoxColumn4.DisplayMemberSort = true;
            gridViewComboBoxColumn4.FieldName = "tipehadirid";
            gridViewComboBoxColumn4.HeaderText = "Absensi";
            gridViewComboBoxColumn4.Name = "tipehadirid";
            gridViewComboBoxColumn4.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewComboBoxColumn4.ValueMember = "tipehadirid";
            gridViewComboBoxColumn4.Width = 80;
            gridViewComboBoxColumn4.WrapText = true;
            gridViewCheckBoxColumn3.AllowFiltering = false;
            gridViewCheckBoxColumn3.AllowGroup = false;
            gridViewCheckBoxColumn3.DataType = typeof(sbyte);
            gridViewCheckBoxColumn3.FieldName = "Pagi";
            gridViewCheckBoxColumn3.HeaderText = "Pagi";
            gridViewCheckBoxColumn3.Name = "Pagi";
            gridViewCheckBoxColumn4.AllowFiltering = false;
            gridViewCheckBoxColumn4.AllowGroup = false;
            gridViewCheckBoxColumn4.DataType = typeof(sbyte);
            gridViewCheckBoxColumn4.FieldName = "sore";
            gridViewCheckBoxColumn4.HeaderText = "Sore";
            gridViewCheckBoxColumn4.Name = "Sore";
            gridViewTextBoxColumn2.AllowFiltering = false;
            gridViewTextBoxColumn2.AllowGroup = false;
            gridViewTextBoxColumn2.FieldName = "keterangan";
            gridViewTextBoxColumn2.HeaderText = "Keterangan";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.IsPinned = true;
            gridViewTextBoxColumn2.MaxLength = 160000;
            gridViewTextBoxColumn2.MaxWidth = 250;
            gridViewTextBoxColumn2.MinWidth = 100;
            gridViewTextBoxColumn2.Name = "keterangan";
            gridViewTextBoxColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Right;
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn2.WrapText = true;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewComboBoxColumn3,
            gridViewDateTimeColumn2,
            gridViewComboBoxColumn4,
            gridViewCheckBoxColumn3,
            gridViewCheckBoxColumn4,
            gridViewTextBoxColumn2});
            this.radGridView1.MasterTemplate.DataSource = this.absenallBindingSource;
            this.radGridView1.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            sortDescriptor3.PropertyName = "MemberID";
            sortDescriptor4.PropertyName = "tipehadirid";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3,
            sortDescriptor4});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(655, 383);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.CellBeginEdit += new Telerik.WinControls.UI.GridViewCellCancelEventHandler(this.radGridView1_CellBeginEdit);
            this.radGridView1.CellEditorInitialized += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEditorInitialized);
            this.radGridView1.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEndEdit);
            // 
            // absenallBindingSource
            // 
            this.absenallBindingSource.DataMember = "absenall";
            this.absenallBindingSource.DataSource = this.sinarekDataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tipememberTableAdapter
            // 
            this.tipememberTableAdapter.ClearBeforeFill = true;
            // 
            // absenallTableAdapter
            // 
            this.absenallTableAdapter.ClearBeforeFill = true;
            // 
            // btnCheckData
            // 
            this.btnCheckData.Location = new System.Drawing.Point(508, 57);
            this.btnCheckData.Name = "btnCheckData";
            this.btnCheckData.Size = new System.Drawing.Size(135, 24);
            this.btnCheckData.TabIndex = 9;
            this.btnCheckData.Text = "Check Data Absen";
            this.btnCheckData.Click += new System.EventHandler(this.btnCheckData_Click);
            // 
            // frmInputAbsen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 483);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInputAbsen";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Data Kehadiran";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAbsen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipehadirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buruhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipeHadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTipeAbsen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipememberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipehadirBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource absenBindingSource;
        private sinarekDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDropDownList ddlTipeAbsen;
        private System.Windows.Forms.BindingSource buruhBindingSource;
        private System.Windows.Forms.BindingSource tipehadirBindingSource;
        private sinarekDataSetTableAdapters.tipehadirTableAdapter tipehadirTableAdapter1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource tipehadirBindingSource1;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTanggal;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private sinarekDataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private System.Windows.Forms.BindingSource tipememberBindingSource;
        private sinarekDataSetTableAdapters.tipememberTableAdapter tipememberTableAdapter;
        private System.Windows.Forms.BindingSource absenallBindingSource;
        private sinarekDataSetTableAdapters.absenallTableAdapter absenallTableAdapter;
        private Telerik.WinControls.UI.RadButton btnSetSelected;
        private Telerik.WinControls.UI.RadDropDownList rddTipeHadir;
        private Telerik.WinControls.UI.RadButton btnCheckData;
    }
}
