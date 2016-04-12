namespace NB
{
    partial class frmAbsenStaff
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn29 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn33 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn9 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn5 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn10 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn34 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn35 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn30 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn31 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn32 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn33 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn34 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn35 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn36 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn37 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn38 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn39 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn40 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor5 = new Telerik.WinControls.Data.SortDescriptor();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fingermachDataSet = new NB.fingermachDataSet();
            this.tipehadirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.absenbulananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.absenbulananTableAdapter = new NB.fingermachDataSetTableAdapters.absenbulananTableAdapter();
            this.tipehadirTableAdapter = new NB.sinarekDataSetTableAdapters.tipehadirTableAdapter();
            this.staffTableAdapter = new NB.fingermachDataSetTableAdapters.staffTableAdapter();
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            this.vsummaryabsenbulananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vsummaryabsenbulananTableAdapter = new NB.fingermachDataSetTableAdapters.vsummaryabsenbulananTableAdapter();
            this.txtInfo = new Telerik.WinControls.UI.RadTextBox();
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rddGBID = new Telerik.WinControls.UI.RadDropDownList();
            this.gajibulananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gajibulananTableAdapter = new NB.fingermachDataSetTableAdapters.gajibulananTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipehadirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenbulananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsummaryabsenbulananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddGBID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gajibulananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.fingermachDataSet;
            // 
            // fingermachDataSet
            // 
            this.fingermachDataSet.DataSetName = "fingermachDataSet";
            this.fingermachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipehadirBindingSource
            // 
            this.tipehadirBindingSource.DataMember = "tipehadir";
            this.tipehadirBindingSource.DataSource = this.sinarekDataSet;
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radCalendar1
            // 
            this.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCalendar1.CellMargin = new System.Windows.Forms.Padding(0);
            this.radCalendar1.CellPadding = new System.Windows.Forms.Padding(0);
            this.radCalendar1.FocusedDate = new System.DateTime(2012, 2, 1, 0, 0, 0, 0);
            this.radCalendar1.HeaderHeight = 17;
            this.radCalendar1.HeaderWidth = 17;
            this.radCalendar1.Location = new System.Drawing.Point(4, 55);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.RangeMaxDate = new System.DateTime(2999, 2, 28, 0, 0, 0, 0);
            this.radCalendar1.RangeMinDate = new System.DateTime(((long)(0)));
            this.radCalendar1.ShowFastNavigationButtons = false;
            this.radCalendar1.ShowNavigationButtons = false;
            this.radCalendar1.Size = new System.Drawing.Size(257, 227);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.Text = "Absen Calendar";
            this.radCalendar1.SelectionChanged += new System.EventHandler(this.radCalendar1_SelectionChanged);
            // 
            // radGridView1
            // 
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radGridView1.Location = new System.Drawing.Point(267, 56);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn29.DataType = typeof(int);
            gridViewDecimalColumn29.FieldName = "abid";
            gridViewDecimalColumn29.FormatString = "";
            gridViewDecimalColumn29.HeaderText = "abid";
            gridViewDecimalColumn29.IsAutoGenerated = true;
            gridViewDecimalColumn29.IsVisible = false;
            gridViewDecimalColumn29.Name = "abid";
            gridViewDecimalColumn29.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn33.FieldName = "tipeabsen";
            gridViewTextBoxColumn33.FormatString = "";
            gridViewTextBoxColumn33.HeaderText = "tipeabsen";
            gridViewTextBoxColumn33.IsAutoGenerated = true;
            gridViewTextBoxColumn33.IsVisible = false;
            gridViewTextBoxColumn33.Name = "tipeabsen";
            gridViewComboBoxColumn9.DataSource = this.staffBindingSource;
            gridViewComboBoxColumn9.DataType = typeof(int);
            gridViewComboBoxColumn9.DisplayMember = "Name";
            gridViewComboBoxColumn9.FieldName = "memberid";
            gridViewComboBoxColumn9.FormatString = "";
            gridViewComboBoxColumn9.HeaderText = "Nama";
            gridViewComboBoxColumn9.Name = "memberid";
            gridViewComboBoxColumn9.ReadOnly = true;
            gridViewComboBoxColumn9.ValueMember = "staffid";
            gridViewComboBoxColumn9.Width = 150;
            gridViewDateTimeColumn5.FieldName = "tanggal";
            gridViewDateTimeColumn5.FormatString = "{0:dd MMM yyyy}";
            gridViewDateTimeColumn5.HeaderText = "Tanggal";
            gridViewDateTimeColumn5.IsAutoGenerated = true;
            gridViewDateTimeColumn5.Name = "tanggal";
            gridViewDateTimeColumn5.ReadOnly = true;
            gridViewDateTimeColumn5.Width = 120;
            gridViewComboBoxColumn10.DataSource = this.tipehadirBindingSource;
            gridViewComboBoxColumn10.DataType = typeof(int);
            gridViewComboBoxColumn10.DisplayMember = "Nama";
            gridViewComboBoxColumn10.FieldName = "tipehadirid";
            gridViewComboBoxColumn10.FormatString = "";
            gridViewComboBoxColumn10.HeaderText = "Status";
            gridViewComboBoxColumn10.Name = "tipehadirid";
            gridViewComboBoxColumn10.ValueMember = "tipehadirid";
            gridViewComboBoxColumn10.Width = 120;
            gridViewTextBoxColumn34.FieldName = "keterangan";
            gridViewTextBoxColumn34.HeaderText = "Keterangan";
            gridViewTextBoxColumn34.Name = "keterangan";
            gridViewTextBoxColumn34.Width = 120;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn29,
            gridViewTextBoxColumn33,
            gridViewComboBoxColumn9,
            gridViewDateTimeColumn5,
            gridViewComboBoxColumn10,
            gridViewTextBoxColumn34});
            this.radGridView1.MasterTemplate.DataSource = this.absenbulananBindingSource;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(533, 226);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEndEdit);
            // 
            // absenbulananBindingSource
            // 
            this.absenbulananBindingSource.DataMember = "absenbulanan";
            this.absenbulananBindingSource.DataSource = this.fingermachDataSet;
            // 
            // absenbulananTableAdapter
            // 
            this.absenbulananTableAdapter.ClearBeforeFill = true;
            // 
            // tipehadirTableAdapter
            // 
            this.tipehadirTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // radGridView2
            // 
            this.radGridView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radGridView2.Location = new System.Drawing.Point(0, 291);
            // 
            // radGridView2
            // 
            this.radGridView2.MasterTemplate.AllowAddNewRow = false;
            this.radGridView2.MasterTemplate.AllowColumnReorder = false;
            this.radGridView2.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn35.FieldName = "name";
            gridViewTextBoxColumn35.HeaderText = "Nama";
            gridViewTextBoxColumn35.IsAutoGenerated = true;
            gridViewTextBoxColumn35.Name = "name";
            gridViewTextBoxColumn35.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn35.Width = 200;
            gridViewDecimalColumn30.FieldName = "Hadir";
            gridViewDecimalColumn30.HeaderText = "Hadir";
            gridViewDecimalColumn30.IsAutoGenerated = true;
            gridViewDecimalColumn30.Name = "Hadir";
            gridViewDecimalColumn30.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn30.Width = 70;
            gridViewDecimalColumn31.FieldName = "Ijin";
            gridViewDecimalColumn31.HeaderText = "Ijin";
            gridViewDecimalColumn31.IsAutoGenerated = true;
            gridViewDecimalColumn31.Name = "Ijin";
            gridViewDecimalColumn31.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn31.Width = 70;
            gridViewDecimalColumn32.FieldName = "Alpa";
            gridViewDecimalColumn32.HeaderText = "Alpa";
            gridViewDecimalColumn32.IsAutoGenerated = true;
            gridViewDecimalColumn32.Name = "Alpa";
            gridViewDecimalColumn32.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn32.Width = 70;
            gridViewDecimalColumn33.FieldName = "Cuti";
            gridViewDecimalColumn33.HeaderText = "Cuti";
            gridViewDecimalColumn33.IsAutoGenerated = true;
            gridViewDecimalColumn33.Name = "Cuti";
            gridViewDecimalColumn33.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn33.Width = 70;
            gridViewDecimalColumn34.FieldName = "Sakit";
            gridViewDecimalColumn34.HeaderText = "Sakit";
            gridViewDecimalColumn34.IsAutoGenerated = true;
            gridViewDecimalColumn34.Name = "Sakit";
            gridViewDecimalColumn34.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn34.Width = 70;
            gridViewDecimalColumn35.FieldName = "CutiTahunan";
            gridViewDecimalColumn35.HeaderText = "Cuti Tahunan";
            gridViewDecimalColumn35.IsAutoGenerated = true;
            gridViewDecimalColumn35.Name = "CutiTahunan";
            gridViewDecimalColumn35.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn35.Width = 120;
            gridViewDecimalColumn35.WrapText = true;
            gridViewTextBoxColumn36.FieldName = "ketalpa";
            gridViewTextBoxColumn36.HeaderText = "keterangan2";
            gridViewTextBoxColumn36.IsVisible = false;
            gridViewTextBoxColumn36.Name = "ketalpa";
            gridViewTextBoxColumn37.FieldName = "ketcuti";
            gridViewTextBoxColumn37.HeaderText = "Keterangan1";
            gridViewTextBoxColumn37.IsVisible = false;
            gridViewTextBoxColumn37.Multiline = true;
            gridViewTextBoxColumn37.Name = "ketcuti";
            gridViewTextBoxColumn37.ReadOnly = true;
            gridViewTextBoxColumn37.Width = 100;
            gridViewTextBoxColumn37.WrapText = true;
            gridViewTextBoxColumn38.FieldName = "ketijin";
            gridViewTextBoxColumn38.HeaderText = "keterangan3";
            gridViewTextBoxColumn38.IsVisible = false;
            gridViewTextBoxColumn38.Name = "ketijin";
            gridViewTextBoxColumn39.FieldName = "ketsakit";
            gridViewTextBoxColumn39.HeaderText = "keterangan4";
            gridViewTextBoxColumn39.IsVisible = false;
            gridViewTextBoxColumn39.Name = "ketsakit";
            gridViewTextBoxColumn40.FieldName = "ketcutitahunan";
            gridViewTextBoxColumn40.HeaderText = "keterangan5";
            gridViewTextBoxColumn40.IsVisible = false;
            gridViewTextBoxColumn40.Name = "ketcutitahunan";
            this.radGridView2.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn35,
            gridViewDecimalColumn30,
            gridViewDecimalColumn31,
            gridViewDecimalColumn32,
            gridViewDecimalColumn33,
            gridViewDecimalColumn34,
            gridViewDecimalColumn35,
            gridViewTextBoxColumn36,
            gridViewTextBoxColumn37,
            gridViewTextBoxColumn38,
            gridViewTextBoxColumn39,
            gridViewTextBoxColumn40});
            this.radGridView2.MasterTemplate.DataSource = this.vsummaryabsenbulananBindingSource;
            this.radGridView2.MasterTemplate.ShowRowHeaderColumn = false;
            sortDescriptor5.PropertyName = "name";
            this.radGridView2.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor5});
            this.radGridView2.Name = "radGridView2";
            this.radGridView2.ReadOnly = true;
            this.radGridView2.ShowGroupPanel = false;
            this.radGridView2.Size = new System.Drawing.Size(800, 166);
            this.radGridView2.TabIndex = 2;
            this.radGridView2.Text = "radGridView2";
            this.radGridView2.SelectionChanged += new System.EventHandler(this.radGridView2_SelectionChanged);
            // 
            // vsummaryabsenbulananBindingSource
            // 
            this.vsummaryabsenbulananBindingSource.DataMember = "vsummaryabsenbulanan";
            this.vsummaryabsenbulananBindingSource.DataSource = this.fingermachDataSet;
            // 
            // vsummaryabsenbulananTableAdapter
            // 
            this.vsummaryabsenbulananTableAdapter.ClearBeforeFill = true;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtInfo.Location = new System.Drawing.Point(4, 463);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.NullText = "Bekerja Sesuai Jadwal";
            this.txtInfo.ReadOnly = true;
            // 
            // 
            // 
            this.txtInfo.RootElement.StretchVertically = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(796, 93);
            this.txtInfo.TabIndex = 3;
            this.txtInfo.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrint.Location = new System.Drawing.Point(267, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(147, 30);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "&Print Absen";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(11, 15);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(56, 25);
            this.radLabel1.TabIndex = 9;
            this.radLabel1.Text = "Bulan :";
            // 
            // rddGBID
            // 
            this.rddGBID.AutoCompleteDisplayMember = "StartDate";
            this.rddGBID.AutoCompleteValueMember = "GBID";
            this.rddGBID.DataSource = this.gajibulananBindingSource;
            this.rddGBID.DisplayMember = "StartDate";
            this.rddGBID.DropDownAnimationEnabled = true;
            this.rddGBID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddGBID.FormatString = "MMM yy";
            this.rddGBID.Location = new System.Drawing.Point(67, 16);
            this.rddGBID.Name = "rddGBID";
            this.rddGBID.ShowImageInEditorArea = true;
            this.rddGBID.Size = new System.Drawing.Size(194, 23);
            this.rddGBID.TabIndex = 8;
            this.rddGBID.ValueMember = "GBID";
            this.rddGBID.SelectedValueChanged += new System.EventHandler(this.rddGBID_SelectedValueChanged);
            // 
            // gajibulananBindingSource
            // 
            this.gajibulananBindingSource.DataMember = "gajibulanan";
            this.gajibulananBindingSource.DataSource = this.fingermachDataSet;
            // 
            // gajibulananTableAdapter
            // 
            this.gajibulananTableAdapter.ClearBeforeFill = true;
            // 
            // frmAbsenStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 559);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rddGBID);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.radGridView2);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radCalendar1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAbsenStaff";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Absen Staff";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAbsenStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipehadirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenbulananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsummaryabsenbulananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddGBID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gajibulananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private fingermachDataSet fingermachDataSet;
        private System.Windows.Forms.BindingSource absenbulananBindingSource;
        private fingermachDataSetTableAdapters.absenbulananTableAdapter absenbulananTableAdapter;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource tipehadirBindingSource;
        private sinarekDataSetTableAdapters.tipehadirTableAdapter tipehadirTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private fingermachDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private Telerik.WinControls.UI.RadGridView radGridView2;
        private System.Windows.Forms.BindingSource vsummaryabsenbulananBindingSource;
        private fingermachDataSetTableAdapters.vsummaryabsenbulananTableAdapter vsummaryabsenbulananTableAdapter;
        private Telerik.WinControls.UI.RadTextBox txtInfo;
        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList rddGBID;
        private System.Windows.Forms.BindingSource gajibulananBindingSource;
        private fingermachDataSetTableAdapters.gajibulananTableAdapter gajibulananTableAdapter;


    }
}
