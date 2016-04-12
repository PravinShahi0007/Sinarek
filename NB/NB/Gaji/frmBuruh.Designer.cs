namespace NB
{
    partial class frmBuruh
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.gajitemplateallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new NB.sinarekDataSetTableAdapters.memberTableAdapter();
            this.gajitemplateallTableAdapter = new NB.sinarekDataSetTableAdapters.gajitemplateallTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gajitemplateallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gajitemplateallBindingSource
            // 
            this.gajitemplateallBindingSource.DataMember = "gajitemplateall";
            this.gajitemplateallBindingSource.DataSource = this.sinarekDataSet;
            this.gajitemplateallBindingSource.Filter = "tipeid = 1 and tipepembayaranid = 2";
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.EnableCustomGrouping = true;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AllowDeleteRow = false;
            this.radGridView1.MasterTemplate.AllowEditRow = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.HeaderText = "#";
            gridViewTextBoxColumn1.IsPinned = true;
            gridViewTextBoxColumn1.Name = "norow";
            gridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "MemberID";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "MemberID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "MemberID";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn2.AllowGroup = false;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Name";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 175;
            gridViewTextBoxColumn3.AllowFiltering = false;
            gridViewTextBoxColumn3.DataType = typeof(long);
            gridViewTextBoxColumn3.Expression = "";
            gridViewTextBoxColumn3.FieldName = "FingerID";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "ID";
            gridViewTextBoxColumn3.Name = "FingerID";
            gridViewTextBoxColumn4.AllowFiltering = false;
            gridViewTextBoxColumn4.AllowGroup = false;
            gridViewTextBoxColumn4.FieldName = "Gender";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "P/L";
            gridViewTextBoxColumn4.Name = "Gender";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewComboBoxColumn1.DataSource = this.gajitemplateallBindingSource;
            gridViewComboBoxColumn1.DataType = typeof(int);
            gridViewComboBoxColumn1.DisplayMember = "Value";
            gridViewComboBoxColumn1.FieldName = "MemberID";
            gridViewComboBoxColumn1.FormatString = "{0:Rp #,##0.00}";
            gridViewComboBoxColumn1.HeaderText = "Gaji Harian";
            gridViewComboBoxColumn1.Name = "GajiHarian";
            gridViewComboBoxColumn1.ValueMember = "MemberID";
            gridViewComboBoxColumn1.Width = 100;
            gridViewDateTimeColumn1.AllowFiltering = false;
            gridViewDateTimeColumn1.AllowGroup = false;
            gridViewDateTimeColumn1.EnableExpressionEditor = true;
            gridViewDateTimeColumn1.Expression = "";
            gridViewDateTimeColumn1.FieldName = "MasukKerja";
            gridViewDateTimeColumn1.FormatString = "{0:dd MMM yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Tgl Masuk";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "MasukKerja";
            gridViewDateTimeColumn1.ReadOnly = true;
            gridViewDateTimeColumn1.Width = 100;
            gridViewDateTimeColumn2.AllowFiltering = false;
            gridViewDateTimeColumn2.FieldName = "keluarkerja";
            gridViewDateTimeColumn2.FormatString = "{0:dd MMM yy}";
            gridViewDateTimeColumn2.HeaderText = "Tgl Keluar";
            gridViewDateTimeColumn2.IsVisible = false;
            gridViewDateTimeColumn2.Name = "keluarkerja";
            gridViewDateTimeColumn2.Width = 100;
            gridViewCheckBoxColumn1.AllowFiltering = false;
            gridViewCheckBoxColumn1.AllowGroup = false;
            gridViewCheckBoxColumn1.FieldName = "Sopir";
            gridViewCheckBoxColumn1.FormatString = "";
            gridViewCheckBoxColumn1.HeaderText = "Sopir";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.Name = "Sopir";
            gridViewCheckBoxColumn1.Width = 55;
            gridViewCheckBoxColumn2.AllowFiltering = false;
            gridViewCheckBoxColumn2.AllowGroup = false;
            gridViewCheckBoxColumn2.FieldName = "Kernet";
            gridViewCheckBoxColumn2.FormatString = "";
            gridViewCheckBoxColumn2.HeaderText = "Kernet";
            gridViewCheckBoxColumn2.IsAutoGenerated = true;
            gridViewCheckBoxColumn2.Name = "Kernet";
            gridViewCheckBoxColumn2.Width = 60;
            gridViewCheckBoxColumn3.AllowFiltering = false;
            gridViewCheckBoxColumn3.AllowGroup = false;
            gridViewCheckBoxColumn3.FieldName = "Sales";
            gridViewCheckBoxColumn3.FormatString = "";
            gridViewCheckBoxColumn3.HeaderText = "Sales";
            gridViewCheckBoxColumn3.IsAutoGenerated = true;
            gridViewCheckBoxColumn3.Name = "Sales";
            gridViewCheckBoxColumn3.Width = 55;
            gridViewCheckBoxColumn4.AllowFiltering = false;
            gridViewCheckBoxColumn4.FieldName = "Active";
            gridViewCheckBoxColumn4.FormatString = "";
            gridViewCheckBoxColumn4.HeaderText = "Kerja";
            gridViewCheckBoxColumn4.IsAutoGenerated = true;
            gridViewCheckBoxColumn4.IsPinned = true;
            gridViewCheckBoxColumn4.IsVisible = false;
            gridViewCheckBoxColumn4.Name = "Active";
            gridViewCheckBoxColumn4.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Right;
            gridViewCheckBoxColumn4.Width = 55;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewComboBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewCheckBoxColumn1,
            gridViewCheckBoxColumn2,
            gridViewCheckBoxColumn3,
            gridViewCheckBoxColumn4});
            this.radGridView1.MasterTemplate.DataSource = this.memberBindingSource;
            this.radGridView1.MasterTemplate.EnableCustomGrouping = true;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ShowFilteringRow = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(740, 431);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.RowsChanged += new Telerik.WinControls.UI.GridViewCollectionChangedEventHandler(this.radGridView1_RowsChanged);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this.sinarekDataSet;
            this.memberBindingSource.Filter = "tipememberid = 2 and active = 1";
            this.memberBindingSource.Sort = "name";
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // gajitemplateallTableAdapter
            // 
            this.gajitemplateallTableAdapter.ClearBeforeFill = true;
            // 
            // frmBuruh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 431);
            this.Controls.Add(this.radGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuruh";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Daftar Pegawai";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmBuruh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gajitemplateallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private sinarekDataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private System.Windows.Forms.BindingSource gajitemplateallBindingSource;
        private sinarekDataSetTableAdapters.gajitemplateallTableAdapter gajitemplateallTableAdapter;
    }
}
