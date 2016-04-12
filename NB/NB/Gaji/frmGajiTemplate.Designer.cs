namespace NB
{
    partial class frmGajiTemplate
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
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn3 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn4 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.gajitemplateallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gajitemplateallTableAdapter = new NB.sinarekDataSetTableAdapters.gajitemplateallTableAdapter();
            this.memberTableAdapter = new NB.sinarekDataSetTableAdapters.memberTableAdapter();
            this.rddTipe = new Telerik.WinControls.UI.RadDropDownList();
            this.tiperinciangajiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.tiperinciangajiTableAdapter = new NB.sinarekDataSetTableAdapters.tiperinciangajiTableAdapter();
            this.btnClear = new Telerik.WinControls.UI.RadButton();
            this.tipepembayaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipepembayaranTableAdapter = new NB.sinarekDataSetTableAdapters.tipepembayaranTableAdapter();
            this.formulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formulaTableAdapter = new NB.sinarekDataSetTableAdapters.formulaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gajitemplateallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiperinciangajiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipepembayaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulaBindingSource)).BeginInit();
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
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGridView1.Location = new System.Drawing.Point(0, 57);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AllowEditRow = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "templateid";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "templateid";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "templateid";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewComboBoxColumn1.DataSource = this.memberBindingSource;
            gridViewComboBoxColumn1.DataType = typeof(int);
            gridViewComboBoxColumn1.DisplayMember = "Name";
            gridViewComboBoxColumn1.DisplayMemberSort = true;
            gridViewComboBoxColumn1.FieldName = "MemberID";
            gridViewComboBoxColumn1.FormatString = "";
            gridViewComboBoxColumn1.HeaderText = "Nama";
            gridViewComboBoxColumn1.Name = "MemberID";
            gridViewComboBoxColumn1.ValueMember = "MemberID";
            gridViewComboBoxColumn1.Width = 200;
            gridViewComboBoxColumn2.AllowFiltering = false;
            gridViewComboBoxColumn2.DataSource = this.tiperinciangajiBindingSource;
            gridViewComboBoxColumn2.DataType = typeof(int);
            gridViewComboBoxColumn2.DisplayMember = "Nama";
            gridViewComboBoxColumn2.FieldName = "TipeID";
            gridViewComboBoxColumn2.FormatString = "";
            gridViewComboBoxColumn2.HeaderText = "Tipe";
            gridViewComboBoxColumn2.Name = "TipeID";
            gridViewComboBoxColumn2.ValueMember = "TipeID";
            gridViewComboBoxColumn2.Width = 130;
            gridViewComboBoxColumn3.AllowFiltering = false;
            gridViewComboBoxColumn3.DataSource = this.tipepembayaranBindingSource;
            gridViewComboBoxColumn3.DataType = typeof(short);
            gridViewComboBoxColumn3.DisplayMember = "Nama";
            gridViewComboBoxColumn3.FieldName = "TipePembayaranID";
            gridViewComboBoxColumn3.FormatString = "";
            gridViewComboBoxColumn3.HeaderText = "Frequency";
            gridViewComboBoxColumn3.Name = "TipePembayaranid";
            gridViewComboBoxColumn3.ValueMember = "TipePembayaranID";
            gridViewComboBoxColumn3.Width = 100;
            gridViewDecimalColumn2.AllowFiltering = false;
            gridViewDecimalColumn2.FieldName = "value";
            gridViewDecimalColumn2.FormatString = "{0:Rp #,##0.00}";
            gridViewDecimalColumn2.HeaderText = "Nilai";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "value";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn2.Width = 100;
            gridViewComboBoxColumn4.AllowFiltering = false;
            gridViewComboBoxColumn4.DataSource = this.formulaBindingSource;
            gridViewComboBoxColumn4.DataType = typeof(short);
            gridViewComboBoxColumn4.DisplayMember = "Description";
            gridViewComboBoxColumn4.FieldName = "CalculationID";
            gridViewComboBoxColumn4.FormatString = "";
            gridViewComboBoxColumn4.HeaderText = "Perhitungan";
            gridViewComboBoxColumn4.Name = "CalculationID";
            gridViewComboBoxColumn4.ValueMember = "FormulaID";
            gridViewComboBoxColumn4.Width = 100;
            gridViewTextBoxColumn1.AllowFiltering = false;
            gridViewTextBoxColumn1.FieldName = "keterangan";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Keterangan";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "keterangan";
            gridViewTextBoxColumn1.Width = 150;
            gridViewCheckBoxColumn1.AllowFiltering = false;
            gridViewCheckBoxColumn1.FieldName = "active";
            gridViewCheckBoxColumn1.FormatString = "";
            gridViewCheckBoxColumn1.HeaderText = "Aktif";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.Name = "active";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewComboBoxColumn1,
            gridViewComboBoxColumn2,
            gridViewComboBoxColumn3,
            gridViewDecimalColumn2,
            gridViewComboBoxColumn4,
            gridViewTextBoxColumn1,
            gridViewCheckBoxColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.gajitemplateallBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(896, 509);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // gajitemplateallBindingSource
            // 
            this.gajitemplateallBindingSource.DataMember = "gajitemplateall";
            this.gajitemplateallBindingSource.DataSource = this.sinarekDataSet;
            this.gajitemplateallBindingSource.Filter = "";
            // 
            // gajitemplateallTableAdapter
            // 
            this.gajitemplateallTableAdapter.ClearBeforeFill = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // rddTipe
            // 
            this.rddTipe.AutoCompleteDisplayMember = "Nama";
            this.rddTipe.AutoCompleteValueMember = "TipeID";
            this.rddTipe.DataSource = this.tiperinciangajiBindingSource;
            this.rddTipe.DisplayMember = "Nama";
            this.rddTipe.DropDownAnimationEnabled = true;
            this.rddTipe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddTipe.Location = new System.Drawing.Point(76, 11);
            this.rddTipe.Name = "rddTipe";
            this.rddTipe.ShowImageInEditorArea = true;
            this.rddTipe.Size = new System.Drawing.Size(204, 23);
            this.rddTipe.TabIndex = 1;
            this.rddTipe.ValueMember = "TipeID";
            this.rddTipe.SelectedValueChanged += new System.EventHandler(this.rddTipe_SelectedValueChanged);
            // 
            // tiperinciangajiBindingSource
            // 
            this.tiperinciangajiBindingSource.DataMember = "tiperinciangaji";
            this.tiperinciangajiBindingSource.DataSource = this.sinarekDataSet;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(2, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(66, 21);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Tipe Gaji :";
            // 
            // tiperinciangajiTableAdapter
            // 
            this.tiperinciangajiTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.Location = new System.Drawing.Point(305, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 21);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear &Filter";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tipepembayaranBindingSource
            // 
            this.tipepembayaranBindingSource.DataMember = "tipepembayaran";
            this.tipepembayaranBindingSource.DataSource = this.sinarekDataSet;
            // 
            // tipepembayaranTableAdapter
            // 
            this.tipepembayaranTableAdapter.ClearBeforeFill = true;
            // 
            // formulaBindingSource
            // 
            this.formulaBindingSource.DataMember = "formula";
            this.formulaBindingSource.DataSource = this.sinarekDataSet;
            // 
            // formulaTableAdapter
            // 
            this.formulaTableAdapter.ClearBeforeFill = true;
            // 
            // frmGajiTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 566);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rddTipe);
            this.Controls.Add(this.radGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGajiTemplate";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Daftar Gaji Template";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmKerajinan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gajitemplateallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiperinciangajiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipepembayaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource gajitemplateallBindingSource;
        private sinarekDataSetTableAdapters.gajitemplateallTableAdapter gajitemplateallTableAdapter;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private sinarekDataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private Telerik.WinControls.UI.RadDropDownList rddTipe;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.BindingSource tiperinciangajiBindingSource;
        private sinarekDataSetTableAdapters.tiperinciangajiTableAdapter tiperinciangajiTableAdapter;
        private Telerik.WinControls.UI.RadButton btnClear;
        private System.Windows.Forms.BindingSource tipepembayaranBindingSource;
        private sinarekDataSetTableAdapters.tipepembayaranTableAdapter tipepembayaranTableAdapter;
        private System.Windows.Forms.BindingSource formulaBindingSource;
        private sinarekDataSetTableAdapters.formulaTableAdapter formulaTableAdapter;
    }
}
