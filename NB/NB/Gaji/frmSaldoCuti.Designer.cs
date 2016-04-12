namespace NB
{
    partial class frmSaldoCuti
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn10 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewRelation gridViewRelation1 = new Telerik.WinControls.UI.GridViewRelation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaldoCuti));
            this.gridViewTemplate2 = new Telerik.WinControls.UI.GridViewTemplate();
            this.absenallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.absenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vsaldocutiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gajidetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vsaldocutiTableAdapter = new NB.sinarekDataSetTableAdapters.vsaldocutiTableAdapter();
            this.absenallTableAdapter = new NB.sinarekDataSetTableAdapters.absenallTableAdapter();
            this.memberTableAdapter = new NB.sinarekDataSetTableAdapters.memberTableAdapter();
            this.btnRefreshCuti = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsaldocutiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gajidetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshCuti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewTemplate2
            // 
            this.gridViewTemplate2.AutoGenerateColumns = false;
            gridViewDateTimeColumn1.FieldName = "tanggal";
            gridViewDateTimeColumn1.FormatString = "{0:dd MMM yyy}";
            gridViewDateTimeColumn1.HeaderText = "Tanggal";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "tanggal";
            gridViewDateTimeColumn1.Width = 150;
            gridViewDecimalColumn1.DataType = typeof(uint);
            gridViewDecimalColumn1.FieldName = "Absenid";
            gridViewDecimalColumn1.HeaderText = "Absenid";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "Absenid";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "memberid";
            gridViewDecimalColumn2.HeaderText = "memberid";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "memberid";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn1.FieldName = "keterangan";
            gridViewTextBoxColumn1.HeaderText = "keterangan";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "keterangan";
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.FieldName = "gmid";
            gridViewDecimalColumn3.HeaderText = "gmid";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "gmid";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn4.DataType = typeof(int);
            gridViewDecimalColumn4.FieldName = "tipehadirid";
            gridViewDecimalColumn4.HeaderText = "tipehadirid";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "tipehadirid";
            gridViewDecimalColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn5.DataType = typeof(bool);
            gridViewDecimalColumn5.FieldName = "pagi";
            gridViewDecimalColumn5.HeaderText = "pagi";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.IsVisible = false;
            gridViewDecimalColumn5.Name = "pagi";
            gridViewDecimalColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn6.DataType = typeof(bool);
            gridViewDecimalColumn6.FieldName = "sore";
            gridViewDecimalColumn6.HeaderText = "sore";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.IsVisible = false;
            gridViewDecimalColumn6.Name = "sore";
            gridViewDecimalColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.gridViewTemplate2.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDateTimeColumn1,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6});
            this.gridViewTemplate2.DataSource = this.absenallBindingSource;
            // 
            // absenallBindingSource
            // 
            this.absenallBindingSource.DataMember = "absenall";
            this.absenallBindingSource.DataSource = this.sinarekDataSet;
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
            this.radGridView1.Location = new System.Drawing.Point(0, 33);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn2.DataType = typeof(int);
            gridViewTextBoxColumn2.FieldName = "MemberID";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "MemberID";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "MemberID";
            gridViewTextBoxColumn3.FieldName = "Name";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Name";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Name";
            gridViewTextBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn3.Width = 250;
            gridViewDateTimeColumn2.AllowFiltering = false;
            gridViewDateTimeColumn2.FieldName = "MasukKerja";
            gridViewDateTimeColumn2.FormatString = "{0:dd MMM yyy}";
            gridViewDateTimeColumn2.HeaderText = "Mulai Kerja";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "MasukKerja";
            gridViewDateTimeColumn2.Width = 100;
            gridViewDecimalColumn7.AllowFiltering = false;
            gridViewDecimalColumn7.DataType = typeof(short);
            gridViewDecimalColumn7.FieldName = "Saldo";
            gridViewDecimalColumn7.FormatString = "";
            gridViewDecimalColumn7.HeaderText = "Saldo";
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.Name = "Saldo";
            gridViewDecimalColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn8.AllowFiltering = false;
            gridViewDecimalColumn8.DataType = typeof(short);
            gridViewDecimalColumn8.FieldName = "Tahun";
            gridViewDecimalColumn8.FormatString = "";
            gridViewDecimalColumn8.HeaderText = "Tahun";
            gridViewDecimalColumn8.IsAutoGenerated = true;
            gridViewDecimalColumn8.IsVisible = false;
            gridViewDecimalColumn8.Name = "Tahun";
            gridViewDecimalColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn9.AllowFiltering = false;
            gridViewDecimalColumn9.DataType = typeof(short);
            gridViewDecimalColumn9.FieldName = "Terpakai";
            gridViewDecimalColumn9.FormatString = "";
            gridViewDecimalColumn9.HeaderText = "Pakai";
            gridViewDecimalColumn9.IsAutoGenerated = true;
            gridViewDecimalColumn9.Name = "Terpakai";
            gridViewDecimalColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn10.AllowFiltering = false;
            gridViewDecimalColumn10.DataType = typeof(short);
            gridViewDecimalColumn10.FieldName = "CutiBersama";
            gridViewDecimalColumn10.FormatString = "";
            gridViewDecimalColumn10.HeaderText = "CutiBersama";
            gridViewDecimalColumn10.IsAutoGenerated = true;
            gridViewDecimalColumn10.IsVisible = false;
            gridViewDecimalColumn10.Name = "CutiBersama";
            gridViewDecimalColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewCheckBoxColumn1.AllowFiltering = false;
            gridViewCheckBoxColumn1.FieldName = "Active";
            gridViewCheckBoxColumn1.FormatString = "";
            gridViewCheckBoxColumn1.HeaderText = "Active";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.IsVisible = false;
            gridViewCheckBoxColumn1.Name = "Active";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewDecimalColumn9,
            gridViewDecimalColumn10,
            gridViewCheckBoxColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.vsaldocutiBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "Name";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView1.MasterTemplate.Templates.AddRange(new Telerik.WinControls.UI.GridViewTemplate[] {
            this.gridViewTemplate2});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            gridViewRelation1.ChildColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ChildColumnNames")));
            gridViewRelation1.ChildTemplate = this.gridViewTemplate2;
            gridViewRelation1.ParentColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ParentColumnNames")));
            gridViewRelation1.ParentTemplate = this.radGridView1.MasterTemplate;
            this.radGridView1.Relations.AddRange(new Telerik.WinControls.UI.GridViewRelation[] {
            gridViewRelation1});
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(524, 478);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this.sinarekDataSet;
            this.memberBindingSource.Filter = "active = 1";
            // 
            // absenBindingSource
            // 
            this.absenBindingSource.DataMember = "absen";
            this.absenBindingSource.DataSource = this.sinarekDataSet;
            // 
            // vsaldocutiBindingSource
            // 
            this.vsaldocutiBindingSource.DataMember = "vsaldocuti";
            this.vsaldocutiBindingSource.DataSource = this.sinarekDataSet;
            // 
            // gajidetailBindingSource
            // 
            this.gajidetailBindingSource.DataMember = "gajidetail";
            this.gajidetailBindingSource.DataSource = this.sinarekDataSet;
            // 
            // vsaldocutiTableAdapter
            // 
            this.vsaldocutiTableAdapter.ClearBeforeFill = true;
            // 
            // absenallTableAdapter
            // 
            this.absenallTableAdapter.ClearBeforeFill = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefreshCuti
            // 
            this.btnRefreshCuti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefreshCuti.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRefreshCuti.Location = new System.Drawing.Point(0, 0);
            this.btnRefreshCuti.Name = "btnRefreshCuti";
            this.btnRefreshCuti.Size = new System.Drawing.Size(524, 33);
            this.btnRefreshCuti.TabIndex = 1;
            this.btnRefreshCuti.Text = "&Refresh Cuti";
            this.btnRefreshCuti.Click += new System.EventHandler(this.btnRefreshCuti_Click);
            // 
            // frmSaldoCuti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 511);
            this.Controls.Add(this.btnRefreshCuti);
            this.Controls.Add(this.radGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSaldoCuti";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Saldo Cuti Pegawai";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmSaldoCuti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.absenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsaldocutiBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.gajidetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshCuti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource vsaldocutiBindingSource;
        private sinarekDataSetTableAdapters.vsaldocutiTableAdapter vsaldocutiTableAdapter;
        private System.Windows.Forms.BindingSource gajidetailBindingSource;
        private Telerik.WinControls.UI.GridViewTemplate gridViewTemplate2;
        private System.Windows.Forms.BindingSource absenBindingSource;
        private System.Windows.Forms.BindingSource absenallBindingSource;
        private sinarekDataSetTableAdapters.absenallTableAdapter absenallTableAdapter;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private sinarekDataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private Telerik.WinControls.UI.RadButton btnRefreshCuti;
    }
}
