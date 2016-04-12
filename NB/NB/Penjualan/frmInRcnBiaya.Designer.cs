namespace NB
{
    partial class frmInRcnBiaya
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
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label baseIDLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label kotaIDLabel;
            this.vproductbaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.logotherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logotherTableAdapter = new NB.sinarekDataSetTableAdapters.logotherTableAdapter();
            this.txtQuantity = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.rddProduct = new Telerik.WinControls.UI.RadDropDownList();
            this.txtPrice = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.pelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblTime = new Telerik.WinControls.UI.RadLabel();
            this.txtTime = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtKeterangan = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtDetail2 = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.lblKet2 = new Telerik.WinControls.UI.RadLabel();
            this.lblKet1 = new Telerik.WinControls.UI.RadLabel();
            this.rddKota = new Telerik.WinControls.UI.RadDropDownList();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSimpan = new Telerik.WinControls.UI.RadButton();
            this.btnNext = new Telerik.WinControls.UI.RadButton();
            this.kotaTableAdapter = new NB.sinarekDataSetTableAdapters.kotaTableAdapter();
            this.pelTableAdapter = new NB.sinarekDataSetTableAdapters.pelTableAdapter();
            this.vproductbaseTableAdapter = new NB.sinarekDataSetTableAdapters.vproductbaseTableAdapter();
            this.dtpTanggal = new Telerik.WinControls.UI.RadDateTimePicker();
            quantityLabel = new System.Windows.Forms.Label();
            baseIDLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            kotaIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logotherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeterangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetail2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddKota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(16, 71);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(59, 19);
            quantityLabel.TabIndex = 13;
            quantityLabel.Text = "Jumlah :";
            // 
            // baseIDLabel
            // 
            baseIDLabel.AutoSize = true;
            baseIDLabel.Location = new System.Drawing.Point(16, 44);
            baseIDLabel.Name = "baseIDLabel";
            baseIDLabel.Size = new System.Drawing.Size(41, 19);
            baseIDLabel.TabIndex = 15;
            baseIDLabel.Text = "Tipe :";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(16, 99);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(96, 19);
            priceLabel.TabIndex = 17;
            priceLabel.Text = "Harga :      Rp.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 19);
            label3.TabIndex = 40;
            label3.Text = "Tanggal :";
            // 
            // kotaIDLabel
            // 
            kotaIDLabel.AutoSize = true;
            kotaIDLabel.Location = new System.Drawing.Point(15, 15);
            kotaIDLabel.Name = "kotaIDLabel";
            kotaIDLabel.Size = new System.Drawing.Size(44, 19);
            kotaIDLabel.TabIndex = 43;
            kotaIDLabel.Text = "Kota :";
            // 
            // vproductbaseBindingSource
            // 
            this.vproductbaseBindingSource.DataMember = "vproductbase";
            this.vproductbaseBindingSource.DataSource = this.sinarekDataSet;
            this.vproductbaseBindingSource.Filter = "tipeid IN (9,11)";
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logotherBindingSource
            // 
            this.logotherBindingSource.DataMember = "logother";
            this.logotherBindingSource.DataSource = this.sinarekDataSet;
            // 
            // logotherTableAdapter
            // 
            this.logotherTableAdapter.ClearBeforeFill = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AllowPromptAsInput = false;
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(114, 69);
            this.txtQuantity.Mask = "n2";
            this.txtQuantity.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(212, 23);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.TabStop = false;
            this.txtQuantity.Text = "0.00";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.Value = "0.00";
            // 
            // rddProduct
            // 
            this.rddProduct.AutoCompleteDisplayMember = "ProductLong";
            this.rddProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddProduct.AutoCompleteValueMember = "baseid";
            this.rddProduct.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vproductbaseBindingSource, "Others", true));
            this.rddProduct.DataSource = this.vproductbaseBindingSource;
            this.rddProduct.DescriptionTextMember = "UnitName";
            this.rddProduct.DisplayMember = "ProductLong";
            this.rddProduct.DropDownAnimationEnabled = true;
            this.rddProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddProduct.Location = new System.Drawing.Point(114, 42);
            this.rddProduct.Name = "rddProduct";
            this.rddProduct.ShowImageInEditorArea = true;
            this.rddProduct.Size = new System.Drawing.Size(258, 23);
            this.rddProduct.TabIndex = 3;
            this.rddProduct.ValueMember = "baseid";
            this.rddProduct.SelectedValueChanged += new System.EventHandler(this.rddProduct_SelectedValueChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.AllowPromptAsInput = false;
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(114, 97);
            this.txtPrice.Mask = "n2";
            this.txtPrice.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(212, 23);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.TabStop = false;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.Value = "0.00";
            // 
            // pelBindingSource
            // 
            this.pelBindingSource.DataMember = "pel";
            this.pelBindingSource.DataSource = this.sinarekDataSet;
            // 
            // kotaBindingSource
            // 
            this.kotaBindingSource.DataMember = "kota";
            this.kotaBindingSource.DataSource = this.sinarekDataSet;
            this.kotaBindingSource.Filter = "systemonly = 0";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.lblTime);
            this.radGroupBox1.Controls.Add(this.txtTime);
            this.radGroupBox1.Controls.Add(this.txtKeterangan);
            this.radGroupBox1.Controls.Add(this.txtDetail2);
            this.radGroupBox1.Controls.Add(this.lblKet2);
            this.radGroupBox1.Controls.Add(this.lblKet1);
            this.radGroupBox1.Controls.Add(kotaIDLabel);
            this.radGroupBox1.Controls.Add(this.rddKota);
            this.radGroupBox1.Controls.Add(quantityLabel);
            this.radGroupBox1.Controls.Add(this.txtQuantity);
            this.radGroupBox1.Controls.Add(baseIDLabel);
            this.radGroupBox1.Controls.Add(this.rddProduct);
            this.radGroupBox1.Controls.Add(priceLabel);
            this.radGroupBox1.Controls.Add(this.txtPrice);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(5, 39);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(454, 192);
            this.radGroupBox1.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(343, 128);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 21);
            this.lblTime.TabIndex = 49;
            this.lblTime.Text = "Jam :";
            // 
            // txtTime
            // 
            this.txtTime.AllowPromptAsInput = false;
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTime.Location = new System.Drawing.Point(386, 127);
            this.txtTime.Mask = " HH:mm";
            this.txtTime.MaskType = Telerik.WinControls.UI.MaskType.DateTime;
            this.txtTime.Name = "txtTime";
            this.txtTime.PlaceHolder = '0';
            this.txtTime.PromptChar = '0';
            this.txtTime.SelectedText = "13";
            this.txtTime.SelectionLength = 2;
            this.txtTime.SelectionStart = 1;
            this.txtTime.Size = new System.Drawing.Size(49, 23);
            this.txtTime.TabIndex = 7;
            this.txtTime.TabStop = false;
            this.txtTime.Text = " 13:58";
            this.txtTime.Value = new System.DateTime(2012, 5, 1, 13, 58, 43, 903);
            this.txtTime.Visible = false;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.AllowPromptAsInput = false;
            this.txtKeterangan.AutoSize = true;
            this.txtKeterangan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKeterangan.Location = new System.Drawing.Point(114, 127);
            this.txtKeterangan.Mask = "990\\.990\\.990";
            this.txtKeterangan.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(212, 23);
            this.txtKeterangan.TabIndex = 6;
            this.txtKeterangan.TabStop = false;
            this.txtKeterangan.Text = "___.___.___";
            this.txtKeterangan.Value = "   .   .";
            // 
            // txtDetail2
            // 
            this.txtDetail2.AllowPromptAsInput = false;
            this.txtDetail2.AutoSize = true;
            this.txtDetail2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDetail2.Location = new System.Drawing.Point(114, 156);
            this.txtDetail2.Name = "txtDetail2";
            this.txtDetail2.Size = new System.Drawing.Size(212, 23);
            this.txtDetail2.TabIndex = 8;
            this.txtDetail2.TabStop = false;
            // 
            // lblKet2
            // 
            this.lblKet2.Location = new System.Drawing.Point(16, 155);
            this.lblKet2.Name = "lblKet2";
            this.lblKet2.Size = new System.Drawing.Size(90, 21);
            this.lblKet2.TabIndex = 47;
            this.lblKet2.Text = "Keterangan 2:";
            // 
            // lblKet1
            // 
            this.lblKet1.Location = new System.Drawing.Point(16, 128);
            this.lblKet1.Name = "lblKet1";
            this.lblKet1.Size = new System.Drawing.Size(90, 21);
            this.lblKet1.TabIndex = 46;
            this.lblKet1.Text = "Keterangan 1:";
            // 
            // rddKota
            // 
            this.rddKota.AutoCompleteDisplayMember = "Nama";
            this.rddKota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddKota.AutoCompleteValueMember = "KotaID";
            this.rddKota.DataSource = this.kotaBindingSource;
            this.rddKota.DescriptionTextMember = "Nama";
            this.rddKota.DisplayMember = "Nama";
            this.rddKota.DropDownAnimationEnabled = true;
            this.rddKota.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddKota.Location = new System.Drawing.Point(113, 13);
            this.rddKota.Name = "rddKota";
            this.rddKota.ShowImageInEditorArea = true;
            this.rddKota.Size = new System.Drawing.Size(229, 23);
            this.rddKota.TabIndex = 2;
            this.rddKota.ValueMember = "KotaID";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(364, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 22);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "&Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.Location = new System.Drawing.Point(177, 243);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(108, 22);
            this.btnSimpan.TabIndex = 21;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNext.Location = new System.Drawing.Point(4, 243);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 22);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "&Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // kotaTableAdapter
            // 
            this.kotaTableAdapter.ClearBeforeFill = true;
            // 
            // pelTableAdapter
            // 
            this.pelTableAdapter.ClearBeforeFill = true;
            // 
            // vproductbaseTableAdapter
            // 
            this.vproductbaseTableAdapter.ClearBeforeFill = true;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd MMM yyyy";
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(119, 11);
            this.dtpTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTanggal.MinDate = new System.DateTime(((long)(0)));
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.NullableValue = new System.DateTime(2012, 4, 5, 10, 40, 32, 455);
            this.dtpTanggal.NullDate = new System.DateTime(((long)(0)));
            this.dtpTanggal.Size = new System.Drawing.Size(179, 23);
            this.dtpTanggal.TabIndex = 1;
            this.dtpTanggal.TabStop = false;
            this.dtpTanggal.Text = "05 Apr 2012";
            this.dtpTanggal.Value = new System.DateTime(2012, 4, 5, 10, 40, 32, 455);
            // 
            // frmInRcnBiaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 274);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmInRcnBiaya";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Input Rincian Biaya";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmInRcnBiaya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vproductbaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logotherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeterangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetail2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddKota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource logotherBindingSource;
        private sinarekDataSetTableAdapters.logotherTableAdapter logotherTableAdapter;
        private Telerik.WinControls.UI.RadMaskedEditBox txtQuantity;
        private Telerik.WinControls.UI.RadDropDownList rddProduct;
        private Telerik.WinControls.UI.RadMaskedEditBox txtPrice;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSimpan;
        private Telerik.WinControls.UI.RadButton btnNext;
        private System.Windows.Forms.BindingSource kotaBindingSource;
        private sinarekDataSetTableAdapters.kotaTableAdapter kotaTableAdapter;
        private System.Windows.Forms.BindingSource pelBindingSource;
        private sinarekDataSetTableAdapters.pelTableAdapter pelTableAdapter;
        private System.Windows.Forms.BindingSource vproductbaseBindingSource;
        private sinarekDataSetTableAdapters.vproductbaseTableAdapter vproductbaseTableAdapter;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTanggal;
        private Telerik.WinControls.UI.RadDropDownList rddKota;
        private Telerik.WinControls.UI.RadLabel lblKet2;
        private Telerik.WinControls.UI.RadLabel lblKet1;
        private Telerik.WinControls.UI.RadMaskedEditBox txtDetail2;
        private Telerik.WinControls.UI.RadMaskedEditBox txtKeterangan;
        private Telerik.WinControls.UI.RadMaskedEditBox txtTime;
        private Telerik.WinControls.UI.RadLabel lblTime;

    }
}
