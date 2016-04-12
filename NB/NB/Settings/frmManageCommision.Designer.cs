namespace NB
{
    partial class frmManageCommision
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.productbaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.comissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.chkDalamKota = new Telerik.WinControls.UI.RadCheckBox();
            this.rddDKPRoduct = new Telerik.WinControls.UI.RadDropDownList();
            this.vproductbaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet1 = new NB.sinarekDataSet();
            this.btnDKAdd = new Telerik.WinControls.UI.RadButton();
            this.txtNilai = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.chkCash = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.comissionTableAdapter = new NB.sinarekDataSetTableAdapters.comissionTableAdapter();
            this.productbaseTableAdapter = new NB.sinarekDataSetTableAdapters.productbaseTableAdapter();
            this.vproductbaseTableAdapter = new NB.sinarekDataSetTableAdapters.vproductbaseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productbaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDalamKota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddDKPRoduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDKAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNilai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // productbaseBindingSource
            // 
            this.productbaseBindingSource.DataMember = "productbase";
            this.productbaseBindingSource.DataSource = this.sinarekDataSet;
            this.productbaseBindingSource.Filter = "tipeid = 1 and parentid = -1";
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
            this.radGridView1.Location = new System.Drawing.Point(2, 154);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "CommisionID";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "CommisionID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "CommisionID";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDateTimeColumn1.FieldName = "Modified";
            gridViewDateTimeColumn1.FormatString = "";
            gridViewDateTimeColumn1.HeaderText = "Modified";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.IsVisible = false;
            gridViewDateTimeColumn1.Name = "Modified";
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "BaseID";
            gridViewDecimalColumn2.FormatString = "";
            gridViewDecimalColumn2.HeaderText = "BaseID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "BaseID";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewCommandColumn1.DefaultText = "Delete";
            gridViewCommandColumn1.FormatString = "";
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Name = "cmdDelete";
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 75;
            gridViewComboBoxColumn1.DataSource = this.productbaseBindingSource;
            gridViewComboBoxColumn1.DataType = typeof(int);
            gridViewComboBoxColumn1.DisplayMember = "ProductName";
            gridViewComboBoxColumn1.FieldName = "baseid";
            gridViewComboBoxColumn1.FormatString = "";
            gridViewComboBoxColumn1.HeaderText = "Produk";
            gridViewComboBoxColumn1.Name = "product";
            gridViewComboBoxColumn1.ReadOnly = true;
            gridViewComboBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewComboBoxColumn1.ValueMember = "baseid";
            gridViewComboBoxColumn1.Width = 120;
            gridViewComboBoxColumn2.DataSource = this.productbaseBindingSource;
            gridViewComboBoxColumn2.DataType = typeof(int);
            gridViewComboBoxColumn2.DisplayMember = "UnitName";
            gridViewComboBoxColumn2.FieldName = "baseid";
            gridViewComboBoxColumn2.FormatString = "";
            gridViewComboBoxColumn2.HeaderText = "Unit";
            gridViewComboBoxColumn2.Name = "unit";
            gridViewComboBoxColumn2.ReadOnly = true;
            gridViewComboBoxColumn2.ValueMember = "baseid";
            gridViewComboBoxColumn2.Width = 100;
            gridViewDecimalColumn3.FieldName = "Value";
            gridViewDecimalColumn3.FormatString = "";
            gridViewDecimalColumn3.HeaderText = "Value";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "Value";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn3.Width = 100;
            gridViewCheckBoxColumn1.FieldName = "Cash";
            gridViewCheckBoxColumn1.FormatString = "";
            gridViewCheckBoxColumn1.HeaderText = "Tunai";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.Name = "Cash";
            gridViewCheckBoxColumn1.ReadOnly = true;
            gridViewCheckBoxColumn2.FieldName = "DalamKota";
            gridViewCheckBoxColumn2.FormatString = "";
            gridViewCheckBoxColumn2.HeaderText = "DK";
            gridViewCheckBoxColumn2.IsAutoGenerated = true;
            gridViewCheckBoxColumn2.Name = "DalamKota";
            gridViewCheckBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn1.FieldName = "ModifiedBy";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "ModifiedBy";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 100;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn2,
            gridViewCommandColumn1,
            gridViewComboBoxColumn1,
            gridViewComboBoxColumn2,
            gridViewDecimalColumn3,
            gridViewCheckBoxColumn1,
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.comissionBindingSource;
            sortDescriptor1.PropertyName = "product";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(645, 335);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEndEdit);
            this.radGridView1.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.radGridView1_CommandCellClick);
            // 
            // comissionBindingSource
            // 
            this.comissionBindingSource.DataMember = "comission";
            this.comissionBindingSource.DataSource = this.sinarekDataSet;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radGroupBox2);
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
            this.radGroupBox1.Size = new System.Drawing.Size(649, 491);
            this.radGroupBox1.TabIndex = 1;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.Controls.Add(this.chkDalamKota);
            this.radGroupBox2.Controls.Add(this.rddDKPRoduct);
            this.radGroupBox2.Controls.Add(this.btnDKAdd);
            this.radGroupBox2.Controls.Add(this.txtNilai);
            this.radGroupBox2.Controls.Add(this.chkCash);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Insert Komisi";
            this.radGroupBox2.Location = new System.Drawing.Point(2, 18);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(328, 136);
            this.radGroupBox2.TabIndex = 8;
            this.radGroupBox2.Text = "Insert Komisi";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(17, 24);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(101, 21);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Nama Product :";
            // 
            // chkDalamKota
            // 
            this.chkDalamKota.AutoSize = false;
            this.chkDalamKota.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDalamKota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkDalamKota.Location = new System.Drawing.Point(191, 79);
            this.chkDalamKota.Name = "chkDalamKota";
            this.chkDalamKota.Size = new System.Drawing.Size(122, 18);
            this.chkDalamKota.TabIndex = 4;
            this.chkDalamKota.Text = "Dalam Kota";
            // 
            // rddDKPRoduct
            // 
            this.rddDKPRoduct.AutoCompleteDisplayMember = "ProductLong";
            this.rddDKPRoduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddDKPRoduct.AutoCompleteValueMember = "baseid";
            this.rddDKPRoduct.DataSource = this.vproductbaseBindingSource;
            this.rddDKPRoduct.DisplayMember = "ProductLong";
            this.rddDKPRoduct.DropDownAnimationEnabled = true;
            this.rddDKPRoduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddDKPRoduct.Location = new System.Drawing.Point(124, 22);
            this.rddDKPRoduct.Name = "rddDKPRoduct";
            this.rddDKPRoduct.ShowImageInEditorArea = true;
            this.rddDKPRoduct.Size = new System.Drawing.Size(189, 23);
            this.rddDKPRoduct.TabIndex = 1;
            this.rddDKPRoduct.ValueMember = "baseid";
            // 
            // vproductbaseBindingSource
            // 
            this.vproductbaseBindingSource.DataMember = "vproductbase";
            this.vproductbaseBindingSource.DataSource = this.sinarekDataSet1;
            this.vproductbaseBindingSource.Filter = "tipeid = 1 and parentid = -1";
            // 
            // sinarekDataSet1
            // 
            this.sinarekDataSet1.DataSetName = "sinarekDataSet";
            this.sinarekDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDKAdd
            // 
            this.btnDKAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDKAdd.Location = new System.Drawing.Point(21, 101);
            this.btnDKAdd.Name = "btnDKAdd";
            this.btnDKAdd.Size = new System.Drawing.Size(296, 25);
            this.btnDKAdd.TabIndex = 10;
            this.btnDKAdd.Text = "&Add";
            this.btnDKAdd.Click += new System.EventHandler(this.btnDKAdd_Click);
            // 
            // txtNilai
            // 
            this.txtNilai.AllowPromptAsInput = false;
            this.txtNilai.AutoSize = true;
            this.txtNilai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNilai.Location = new System.Drawing.Point(123, 52);
            this.txtNilai.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(190, 23);
            this.txtNilai.TabIndex = 2;
            this.txtNilai.TabStop = false;
            this.txtNilai.Text = "0";
            this.txtNilai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNilai.Value = "0";
            // 
            // chkCash
            // 
            this.chkCash.AutoSize = false;
            this.chkCash.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCash.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkCash.Location = new System.Drawing.Point(17, 79);
            this.chkCash.Name = "chkCash";
            this.chkCash.Size = new System.Drawing.Size(122, 18);
            this.chkCash.TabIndex = 3;
            this.chkCash.Text = "Tunai";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(17, 54);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(41, 21);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Nilai :";
            // 
            // comissionTableAdapter
            // 
            this.comissionTableAdapter.ClearBeforeFill = true;
            // 
            // productbaseTableAdapter
            // 
            this.productbaseTableAdapter.ClearBeforeFill = true;
            // 
            // vproductbaseTableAdapter
            // 
            this.vproductbaseTableAdapter.ClearBeforeFill = true;
            // 
            // frmManageCommision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 491);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmManageCommision";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Manage Komisi";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmManageCommision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productbaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDalamKota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddDKPRoduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDKAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNilai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadMaskedEditBox txtNilai;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList rddDKPRoduct;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadCheckBox chkCash;
        private Telerik.WinControls.UI.RadButton btnDKAdd;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource comissionBindingSource;
        private sinarekDataSetTableAdapters.comissionTableAdapter comissionTableAdapter;
        private System.Windows.Forms.BindingSource productbaseBindingSource;
        private sinarekDataSetTableAdapters.productbaseTableAdapter productbaseTableAdapter;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadCheckBox chkDalamKota;
        private sinarekDataSet sinarekDataSet1;
        private System.Windows.Forms.BindingSource vproductbaseBindingSource;
        private sinarekDataSetTableAdapters.vproductbaseTableAdapter vproductbaseTableAdapter;
    }
}
