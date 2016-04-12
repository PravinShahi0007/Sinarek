namespace NB
{
    partial class frmAddProductTotal
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
            this.dtpTanggal = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.rddProduct = new Telerik.WinControls.UI.RadDropDownList();
            this.vproductbaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.txtSisa = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.vproductbaseTableAdapter = new NB.sinarekDataSetTableAdapters.vproductbaseTableAdapter();
            this.btnNext = new Telerik.WinControls.UI.RadButton();
            this.btnSimpan = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd MMM yyyy";
            this.dtpTanggal.Enabled = false;
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(77, 12);
            this.dtpTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggal.MinDate = new System.DateTime(((long)(0)));
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.NullableValue = new System.DateTime(2012, 4, 17, 13, 23, 17, 653);
            this.dtpTanggal.NullDate = new System.DateTime(((long)(0)));
            this.dtpTanggal.Size = new System.Drawing.Size(105, 23);
            this.dtpTanggal.TabIndex = 0;
            this.dtpTanggal.TabStop = false;
            this.dtpTanggal.Text = "17 Apr 2012";
            this.dtpTanggal.Value = new System.DateTime(2012, 4, 17, 13, 23, 17, 653);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(11, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(62, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Tanggal :";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 50);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(50, 21);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Nama :";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 87);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(56, 21);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Jumlah :";
            // 
            // rddProduct
            // 
            this.rddProduct.AutoCompleteDisplayMember = "ProductLong";
            this.rddProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddProduct.AutoCompleteValueMember = "baseid";
            this.rddProduct.DataSource = this.vproductbaseBindingSource;
            this.rddProduct.DescriptionTextMember = "UnitName";
            this.rddProduct.DisplayMember = "ProductLong";
            this.rddProduct.DropDownAnimationEnabled = true;
            this.rddProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddProduct.Location = new System.Drawing.Point(77, 49);
            this.rddProduct.Name = "rddProduct";
            this.rddProduct.ShowImageInEditorArea = true;
            this.rddProduct.Size = new System.Drawing.Size(283, 23);
            this.rddProduct.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.rddProduct.TabIndex = 3;
            this.rddProduct.ValueMember = "baseid";
            // 
            // vproductbaseBindingSource
            // 
            this.vproductbaseBindingSource.DataMember = "vproductbase";
            this.vproductbaseBindingSource.DataSource = this.sinarekDataSet;
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSisa
            // 
            this.txtSisa.AllowPromptAsInput = false;
            this.txtSisa.AutoSize = true;
            this.txtSisa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSisa.Location = new System.Drawing.Point(77, 86);
            this.txtSisa.Mask = "n1";
            this.txtSisa.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtSisa.Name = "txtSisa";
            this.txtSisa.Size = new System.Drawing.Size(105, 23);
            this.txtSisa.TabIndex = 4;
            this.txtSisa.TabStop = false;
            this.txtSisa.Text = "0.0";
            this.txtSisa.Value = "0.0";
            // 
            // vproductbaseTableAdapter
            // 
            this.vproductbaseTableAdapter.ClearBeforeFill = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNext.Location = new System.Drawing.Point(12, 129);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 24);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "&Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.Location = new System.Drawing.Point(145, 129);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(85, 24);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(278, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddProductTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 165);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtSisa);
            this.Controls.Add(this.rddProduct);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dtpTanggal);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddProductTotal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Input Sisa Barang";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAddProductTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker dtpTanggal;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList rddProduct;
        private Telerik.WinControls.UI.RadMaskedEditBox txtSisa;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource vproductbaseBindingSource;
        private sinarekDataSetTableAdapters.vproductbaseTableAdapter vproductbaseTableAdapter;
        private Telerik.WinControls.UI.RadButton btnNext;
        private Telerik.WinControls.UI.RadButton btnSimpan;
        private Telerik.WinControls.UI.RadButton btnCancel;
    }
}
