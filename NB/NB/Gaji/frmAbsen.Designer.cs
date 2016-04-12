namespace NB
{
    partial class frmAbsen
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
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            this.buruhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.tipehadirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.absenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new NB.sinarekDataSetTableAdapters.TableAdapterManager();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlNama = new Telerik.WinControls.UI.RadDropDownList();
            this.btnClearFilter = new Telerik.WinControls.UI.RadButton();
            this.dtpTanggal = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rbTanggal = new Telerik.WinControls.UI.RadRadioButton();
            this.ddlTipeAbsen = new Telerik.WinControls.UI.RadDropDownList();
            this.tipehadirBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rbTipeAbsen = new Telerik.WinControls.UI.RadRadioButton();
            this.rbNama = new Telerik.WinControls.UI.RadRadioButton();
            this.tipehadirTableAdapter1 = new NB.sinarekDataSetTableAdapters.tipehadirTableAdapter();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.buruhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipehadirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlNama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTipeAbsen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipehadirBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbTipeAbsen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // buruhBindingSource
            // 
            this.buruhBindingSource.DataMember = "buruh";
            this.buruhBindingSource.DataSource = this.sinarekDataSet;
            this.buruhBindingSource.Filter = "active = 1";
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
            // absenBindingSource
            // 
            this.absenBindingSource.DataMember = "absen";
            this.absenBindingSource.DataSource = this.sinarekDataSet;
            this.absenBindingSource.Filter = "";
            this.tableAdapterManager.UpdateOrder = NB.sinarekDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vpengisianTableAdapter = null;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.ddlNama);
            this.radGroupBox1.Controls.Add(this.btnClearFilter);
            this.radGroupBox1.Controls.Add(this.dtpTanggal);
            this.radGroupBox1.Controls.Add(this.rbTanggal);
            this.radGroupBox1.Controls.Add(this.ddlTipeAbsen);
            this.radGroupBox1.Controls.Add(this.rbTipeAbsen);
            this.radGroupBox1.Controls.Add(this.rbNama);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Filter Absen";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 5);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(637, 88);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "Filter Absen";
            // 
            // ddlNama
            // 
            this.ddlNama.AutoCompleteDisplayMember = "Name";
            this.ddlNama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlNama.AutoCompleteValueMember = "BuruhID";
            this.ddlNama.DataSource = this.buruhBindingSource;
            this.ddlNama.DisplayMember = "Name";
            this.ddlNama.DropDownAnimationEnabled = true;
            this.ddlNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ddlNama.Location = new System.Drawing.Point(117, 17);
            this.ddlNama.Name = "ddlNama";
            this.ddlNama.ShowImageInEditorArea = true;
            this.ddlNama.Size = new System.Drawing.Size(141, 23);
            this.ddlNama.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.ddlNama.TabIndex = 8;
            this.ddlNama.ValueMember = "BuruhID";
            this.ddlNama.SelectedValueChanged += new System.EventHandler(this.ddlNama_SelectedValueChanged);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClearFilter.Location = new System.Drawing.Point(344, 55);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(237, 25);
            this.btnClearFilter.TabIndex = 7;
            this.btnClearFilter.Text = "&Lihat Semua";
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd MMM yyyy";
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(117, 49);
            this.dtpTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.NullableValue = new System.DateTime(2011, 11, 7, 0, 0, 0, 0);
            this.dtpTanggal.NullDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTanggal.ShowUpDown = true;
            this.dtpTanggal.Size = new System.Drawing.Size(141, 23);
            this.dtpTanggal.TabIndex = 5;
            this.dtpTanggal.TabStop = false;
            this.dtpTanggal.Text = "07 Nov 2011";
            this.dtpTanggal.Value = new System.DateTime(2011, 11, 7, 0, 0, 0, 0);
            this.dtpTanggal.ValueChanged += new System.EventHandler(this.dtpTanggal_ValueChanged);
            // 
            // rbTanggal
            // 
            this.rbTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbTanggal.Location = new System.Drawing.Point(8, 53);
            this.rbTanggal.Name = "rbTanggal";
            this.rbTanggal.Size = new System.Drawing.Size(79, 18);
            this.rbTanggal.TabIndex = 4;
            this.rbTanggal.Text = "&Tanggal";
            // 
            // ddlTipeAbsen
            // 
            this.ddlTipeAbsen.AutoCompleteDisplayMember = "Nama";
            this.ddlTipeAbsen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlTipeAbsen.AutoCompleteValueMember = "tipehadirid";
            this.ddlTipeAbsen.DataSource = this.tipehadirBindingSource1;
            this.ddlTipeAbsen.DisplayMember = "Nama";
            this.ddlTipeAbsen.DropDownAnimationEnabled = true;
            this.ddlTipeAbsen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ddlTipeAbsen.Location = new System.Drawing.Point(457, 17);
            this.ddlTipeAbsen.Name = "ddlTipeAbsen";
            this.ddlTipeAbsen.ShowImageInEditorArea = true;
            this.ddlTipeAbsen.Size = new System.Drawing.Size(123, 23);
            this.ddlTipeAbsen.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.ddlTipeAbsen.TabIndex = 3;
            this.ddlTipeAbsen.ValueMember = "tipehadirid";
            this.ddlTipeAbsen.SelectedValueChanged += new System.EventHandler(this.ddlTipeAbsen_SelectedValueChanged);
            // 
            // tipehadirBindingSource1
            // 
            this.tipehadirBindingSource1.DataMember = "tipehadir";
            this.tipehadirBindingSource1.DataSource = this.sinarekDataSet;
            // 
            // rbTipeAbsen
            // 
            this.rbTipeAbsen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbTipeAbsen.Location = new System.Drawing.Point(343, 21);
            this.rbTipeAbsen.Name = "rbTipeAbsen";
            this.rbTipeAbsen.Size = new System.Drawing.Size(108, 18);
            this.rbTipeAbsen.TabIndex = 2;
            this.rbTipeAbsen.Text = "Tipe &Absen";
            this.rbTipeAbsen.Click += new System.EventHandler(this.rbButton_Click);
            // 
            // rbNama
            // 
            this.rbNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbNama.Location = new System.Drawing.Point(9, 21);
            this.rbNama.Name = "rbNama";
            this.rbNama.Size = new System.Drawing.Size(78, 18);
            this.rbNama.TabIndex = 0;
            this.rbNama.Text = "&Nama";
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
            this.radGridView1.Location = new System.Drawing.Point(0, 107);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AllowDeleteRow = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn1.DataType = typeof(uint);
            gridViewDecimalColumn1.FieldName = "Absenid";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "Absenid";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "Absenid";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn1.VisibleInColumnChooser = false;
            gridViewComboBoxColumn1.DataSource = this.buruhBindingSource;
            gridViewComboBoxColumn1.DataType = typeof(int);
            gridViewComboBoxColumn1.DisplayMember = "Name";
            gridViewComboBoxColumn1.DisplayMemberSort = true;
            gridViewComboBoxColumn1.FieldName = "MemberID";
            gridViewComboBoxColumn1.FormatString = "";
            gridViewComboBoxColumn1.HeaderText = "Nama";
            gridViewComboBoxColumn1.Name = "MemberID";
            gridViewComboBoxColumn1.ReadOnly = true;
            gridViewComboBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewComboBoxColumn1.ValueMember = "BuruhID";
            gridViewComboBoxColumn1.Width = 160;
            gridViewDateTimeColumn1.CustomFormat = "dd MMM yyyy";
            gridViewDateTimeColumn1.FieldName = "tanggal";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn1.FormatString = "{0:dd MMM yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Tanggal";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "tanggal";
            gridViewDateTimeColumn1.ReadOnly = true;
            gridViewDateTimeColumn1.Width = 100;
            gridViewComboBoxColumn2.AllowGroup = false;
            gridViewComboBoxColumn2.DataSource = this.tipehadirBindingSource;
            gridViewComboBoxColumn2.DataType = typeof(short);
            gridViewComboBoxColumn2.DisplayMember = "Nama";
            gridViewComboBoxColumn2.DisplayMemberSort = true;
            gridViewComboBoxColumn2.FieldName = "tipehadirid";
            gridViewComboBoxColumn2.FormatString = "";
            gridViewComboBoxColumn2.HeaderText = "Absensi";
            gridViewComboBoxColumn2.Name = "tipehadirid";
            gridViewComboBoxColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewComboBoxColumn2.ValueMember = "tipehadirid";
            gridViewComboBoxColumn2.Width = 80;
            gridViewComboBoxColumn2.WrapText = true;
            gridViewCheckBoxColumn1.AllowGroup = false;
            gridViewCheckBoxColumn1.DataType = typeof(sbyte);
            gridViewCheckBoxColumn1.FieldName = "Pagi";
            gridViewCheckBoxColumn1.FormatString = "";
            gridViewCheckBoxColumn1.HeaderText = "Pagi";
            gridViewCheckBoxColumn1.Name = "Pagi";
            gridViewCheckBoxColumn2.AllowGroup = false;
            gridViewCheckBoxColumn2.DataType = typeof(sbyte);
            gridViewCheckBoxColumn2.FieldName = "sore";
            gridViewCheckBoxColumn2.FormatString = "";
            gridViewCheckBoxColumn2.HeaderText = "Sore";
            gridViewCheckBoxColumn2.Name = "Sore";
            gridViewTextBoxColumn1.AllowGroup = false;
            gridViewTextBoxColumn1.FieldName = "keterangan";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Keterangan";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.IsPinned = true;
            gridViewTextBoxColumn1.MaxLength = 160000;
            gridViewTextBoxColumn1.MaxWidth = 250;
            gridViewTextBoxColumn1.MinWidth = 100;
            gridViewTextBoxColumn1.Name = "keterangan";
            gridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Right;
            gridViewTextBoxColumn1.Width = 150;
            gridViewTextBoxColumn1.WrapText = true;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewComboBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewComboBoxColumn2,
            gridViewCheckBoxColumn1,
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.absenBindingSource;
            this.radGridView1.MasterTemplate.EnableAlternatingRowColor = true;
            sortDescriptor1.PropertyName = "MemberID";
            sortDescriptor2.PropertyName = "tipehadirid";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1,
            sortDescriptor2});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(666, 376);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.CellBeginEdit += new Telerik.WinControls.UI.GridViewCellCancelEventHandler(this.radGridView1_CellBeginEdit);
            this.radGridView1.CellEditorInitialized += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEditorInitialized);
            this.radGridView1.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEndEdit);
            // 
            // frmAbsen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 483);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbsen";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Data Kehadiran";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAbsen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buruhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipehadirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlNama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTipeAbsen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipehadirBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbTipeAbsen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource absenBindingSource;
        private sinarekDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnClearFilter;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTanggal;
        private Telerik.WinControls.UI.RadRadioButton rbTanggal;
        private Telerik.WinControls.UI.RadDropDownList ddlTipeAbsen;
        private Telerik.WinControls.UI.RadRadioButton rbTipeAbsen;
        private Telerik.WinControls.UI.RadRadioButton rbNama;
        private System.Windows.Forms.BindingSource buruhBindingSource;
        private System.Windows.Forms.BindingSource tipehadirBindingSource;
        private sinarekDataSetTableAdapters.tipehadirTableAdapter tipehadirTableAdapter1;
        private Telerik.WinControls.UI.RadDropDownList ddlNama;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource tipehadirBindingSource1;
    }
}
