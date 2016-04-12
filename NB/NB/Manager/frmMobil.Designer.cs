namespace NB
{
    partial class frmMobil
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.kotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.mobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipeaccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.tipeaccountTableAdapter = new NB.sinarekDataSetTableAdapters.tipeaccountTableAdapter();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.pelTableAdapter = new NB.sinarekDataSetTableAdapters.pelTableAdapter();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtTipe = new Telerik.WinControls.UI.RadTextBox();
            this.kotaTableAdapter = new NB.sinarekDataSetTableAdapters.kotaTableAdapter();
            this.salesTableAdapter = new NB.sinarekDataSetTableAdapters.salesTableAdapter();
            this.mobilTableAdapter = new NB.sinarekDataSetTableAdapters.mobilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeaccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.sinarekDataSet;
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kotaBindingSource
            // 
            this.kotaBindingSource.DataMember = "kota";
            this.kotaBindingSource.DataSource = this.sinarekDataSet;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGridView1.Location = new System.Drawing.Point(0, 66);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "MobilID";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "MobilID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "MobilID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn1.Width = 125;
            gridViewTextBoxColumn1.FieldName = "NoPolis";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "NoPolis";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "NoPolis";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 125;
            gridViewTextBoxColumn2.FieldName = "Tipe";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Tipe";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Tipe";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 125;
            gridViewDateTimeColumn1.FieldName = "Created";
            gridViewDateTimeColumn1.FormatString = "{0:dd MMM yyy}";
            gridViewDateTimeColumn1.HeaderText = "Created";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "Created";
            gridViewDateTimeColumn1.ReadOnly = true;
            gridViewDateTimeColumn1.Width = 125;
            gridViewCheckBoxColumn1.FieldName = "Active";
            gridViewCheckBoxColumn1.HeaderText = "Active";
            gridViewCheckBoxColumn1.Name = "Active";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1,
            gridViewCheckBoxColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.mobilBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(565, 386);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEndEdit);
            // 
            // mobilBindingSource
            // 
            this.mobilBindingSource.DataMember = "mobil";
            this.mobilBindingSource.DataSource = this.sinarekDataSet;
            // 
            // pelBindingSource
            // 
            this.pelBindingSource.DataMember = "pel";
            this.pelBindingSource.DataSource = this.sinarekDataSet;
            // 
            // tipeaccountBindingSource
            // 
            this.tipeaccountBindingSource.DataMember = "tipeaccount";
            this.tipeaccountBindingSource.DataSource = this.sinarekDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Location = new System.Drawing.Point(437, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tipeaccountTableAdapter
            // 
            this.tipeaccountTableAdapter.ClearBeforeFill = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(70, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TabStop = false;
            // 
            // pelTableAdapter
            // 
            this.pelTableAdapter.ClearBeforeFill = true;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(6, 24);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(64, 21);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "No Polis :";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.txtTipe);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.txtName);
            this.radGroupBox1.Controls.Add(this.btnAdd);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Mobil Baru";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(565, 66);
            this.radGroupBox1.TabIndex = 6;
            this.radGroupBox1.Text = "Mobil Baru";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(234, 25);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(39, 21);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Tipe :";
            // 
            // txtTipe
            // 
            this.txtTipe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTipe.Location = new System.Drawing.Point(273, 24);
            this.txtTipe.Name = "txtTipe";
            this.txtTipe.Size = new System.Drawing.Size(158, 23);
            this.txtTipe.TabIndex = 2;
            this.txtTipe.TabStop = false;
            // 
            // kotaTableAdapter
            // 
            this.kotaTableAdapter.ClearBeforeFill = true;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // mobilTableAdapter
            // 
            this.mobilTableAdapter.ClearBeforeFill = true;
            // 
            // frmMobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 452);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMobil";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Daftar Kendaraan";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeaccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource tipeaccountBindingSource;
        private sinarekDataSetTableAdapters.tipeaccountTableAdapter tipeaccountTableAdapter;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private System.Windows.Forms.BindingSource pelBindingSource;
        private sinarekDataSetTableAdapters.pelTableAdapter pelTableAdapter;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.BindingSource kotaBindingSource;
        private sinarekDataSetTableAdapters.kotaTableAdapter kotaTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private sinarekDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource mobilBindingSource;
        private sinarekDataSetTableAdapters.mobilTableAdapter mobilTableAdapter;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtTipe;
    }
}
