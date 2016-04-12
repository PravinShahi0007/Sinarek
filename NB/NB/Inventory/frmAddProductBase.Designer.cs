namespace NB
{
    partial class frmAddProductBase
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
            this.rddProd = new Telerik.WinControls.UI.RadDropDownList();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnAddProd = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.rddUnit = new Telerik.WinControls.UI.RadDropDownList();
            this.tunitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrice = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.btnAddUnit = new Telerik.WinControls.UI.RadButton();
            this.btnBatal = new Telerik.WinControls.UI.RadButton();
            this.btnSimpan = new Telerik.WinControls.UI.RadButton();
            this.tunitTableAdapter = new NB.sinarekDataSetTableAdapters.tunitTableAdapter();
            this.productTableAdapter = new NB.sinarekDataSetTableAdapters.productTableAdapter();
            this.rddTipe = new Telerik.WinControls.UI.RadDropDownList();
            this.tipeprodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.chkSellable = new Telerik.WinControls.UI.RadCheckBox();
            this.chkGoods = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.chkOthers = new Telerik.WinControls.UI.RadCheckBox();
            this.btnNewTipe = new Telerik.WinControls.UI.RadButton();
            this.tipeprodTableAdapter = new NB.sinarekDataSetTableAdapters.tipeprodTableAdapter();
            this.txtTipeNama = new Telerik.WinControls.UI.RadTextBox();
            this.rddLoc = new Telerik.WinControls.UI.RadDropDownList();
            this.custtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.custtypeTableAdapter = new NB.sinarekDataSetTableAdapters.custtypeTableAdapter();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnNext = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rddProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tunitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeprodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSellable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOthers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewTipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipeNama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rddProd
            // 
            this.rddProd.AutoCompleteDisplayMember = "Description";
            this.rddProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddProd.AutoCompleteValueMember = "productid";
            this.rddProd.DataSource = this.productBindingSource;
            this.rddProd.DisplayMember = "Description";
            this.rddProd.DropDownAnimationEnabled = true;
            this.rddProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddProd.Location = new System.Drawing.Point(75, 86);
            this.rddProd.Name = "rddProd";
            this.rddProd.ShowImageInEditorArea = true;
            this.rddProd.Size = new System.Drawing.Size(269, 23);
            this.rddProd.TabIndex = 2;
            this.rddProd.ValueMember = "productid";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.sinarekDataSet;
            this.productBindingSource.Sort = "description asc";
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(11, 87);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(47, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Nama ";
            // 
            // btnAddProd
            // 
            this.btnAddProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddProd.Location = new System.Drawing.Point(370, 86);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(122, 23);
            this.btnAddProd.TabIndex = 2;
            this.btnAddProd.TabStop = false;
            this.btnAddProd.Text = "New &Product";
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(11, 118);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(32, 21);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Unit";
            // 
            // rddUnit
            // 
            this.rddUnit.AutoCompleteDisplayMember = "Name";
            this.rddUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddUnit.AutoCompleteValueMember = "unitid";
            this.rddUnit.DataSource = this.tunitBindingSource;
            this.rddUnit.DisplayMember = "Name";
            this.rddUnit.DropDownAnimationEnabled = true;
            this.rddUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddUnit.Location = new System.Drawing.Point(75, 117);
            this.rddUnit.Name = "rddUnit";
            this.rddUnit.ShowImageInEditorArea = true;
            this.rddUnit.Size = new System.Drawing.Size(226, 23);
            this.rddUnit.TabIndex = 3;
            this.rddUnit.ValueMember = "unitid";
            // 
            // tunitBindingSource
            // 
            this.tunitBindingSource.DataMember = "tunit";
            this.tunitBindingSource.DataSource = this.sinarekDataSet;
            this.tunitBindingSource.Filter = "";
            this.tunitBindingSource.Sort = "name asc";
            // 
            // txtPrice
            // 
            this.txtPrice.AllowPromptAsInput = false;
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(75, 267);
            this.txtPrice.Mask = "n2";
            this.txtPrice.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(226, 23);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.TabStop = false;
            this.txtPrice.Text = "0.00";
            this.txtPrice.Value = "0.00";
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddUnit.Location = new System.Drawing.Point(370, 117);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(122, 23);
            this.btnAddUnit.TabIndex = 7;
            this.btnAddUnit.TabStop = false;
            this.btnAddUnit.Text = "New P&ackage";
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.Location = new System.Drawing.Point(313, 307);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(106, 23);
            this.btnBatal.TabIndex = 16;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.Location = new System.Drawing.Point(166, 307);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(115, 23);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // tunitTableAdapter
            // 
            this.tunitTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // rddTipe
            // 
            this.rddTipe.AutoCompleteDisplayMember = "Name";
            this.rddTipe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddTipe.AutoCompleteValueMember = "tipeid";
            this.rddTipe.DataSource = this.tipeprodBindingSource;
            this.rddTipe.DisplayMember = "Name";
            this.rddTipe.DropDownAnimationEnabled = true;
            this.rddTipe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddTipe.Location = new System.Drawing.Point(75, 54);
            this.rddTipe.Name = "rddTipe";
            this.rddTipe.ShowImageInEditorArea = true;
            this.rddTipe.Size = new System.Drawing.Size(226, 23);
            this.rddTipe.TabIndex = 1;
            this.rddTipe.ValueMember = "tipeid";
            // 
            // tipeprodBindingSource
            // 
            this.tipeprodBindingSource.DataMember = "tipeprod";
            this.tipeprodBindingSource.DataSource = this.sinarekDataSet;
            this.tipeprodBindingSource.Sort = "name asc";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(11, 56);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(33, 21);
            this.radLabel4.TabIndex = 11;
            this.radLabel4.Text = "Tipe";
            // 
            // chkSellable
            // 
            this.chkSellable.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSellable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkSellable.Location = new System.Drawing.Point(11, 212);
            this.chkSellable.Name = "chkSellable";
            this.chkSellable.Size = new System.Drawing.Size(90, 21);
            this.chkSellable.TabIndex = 6;
            this.chkSellable.Text = "Sellable      ";
            // 
            // chkGoods
            // 
            this.chkGoods.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.chkGoods.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkGoods.Location = new System.Drawing.Point(11, 183);
            this.chkGoods.Name = "chkGoods";
            this.chkGoods.Size = new System.Drawing.Size(90, 21);
            this.chkGoods.TabIndex = 5;
            this.chkGoods.Text = "Goods        ";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(11, 268);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(34, 21);
            this.radLabel3.TabIndex = 14;
            this.radLabel3.Text = "Nilai";
            // 
            // chkOthers
            // 
            this.chkOthers.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.chkOthers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkOthers.Location = new System.Drawing.Point(11, 241);
            this.chkOthers.Name = "chkOthers";
            this.chkOthers.Size = new System.Drawing.Size(92, 21);
            this.chkOthers.TabIndex = 7;
            this.chkOthers.Text = "Others        ";
            // 
            // btnNewTipe
            // 
            this.btnNewTipe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewTipe.Location = new System.Drawing.Point(370, 13);
            this.btnNewTipe.Name = "btnNewTipe";
            this.btnNewTipe.Size = new System.Drawing.Size(122, 23);
            this.btnNewTipe.TabIndex = 15;
            this.btnNewTipe.TabStop = false;
            this.btnNewTipe.Text = "New &Tipe";
            this.btnNewTipe.Click += new System.EventHandler(this.btnNewTipe_Click);
            // 
            // tipeprodTableAdapter
            // 
            this.tipeprodTableAdapter.ClearBeforeFill = true;
            // 
            // txtTipeNama
            // 
            this.txtTipeNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTipeNama.Location = new System.Drawing.Point(75, 13);
            this.txtTipeNama.Name = "txtTipeNama";
            this.txtTipeNama.Size = new System.Drawing.Size(226, 23);
            this.txtTipeNama.TabIndex = 16;
            this.txtTipeNama.TabStop = false;
            // 
            // rddLoc
            // 
            this.rddLoc.AutoCompleteDisplayMember = "Name";
            this.rddLoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddLoc.AutoCompleteValueMember = "CustTypeID";
            this.rddLoc.DataSource = this.custtypeBindingSource;
            this.rddLoc.DisplayMember = "Name";
            this.rddLoc.DropDownAnimationEnabled = true;
            this.rddLoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddLoc.Location = new System.Drawing.Point(75, 147);
            this.rddLoc.Name = "rddLoc";
            this.rddLoc.ShowImageInEditorArea = true;
            this.rddLoc.Size = new System.Drawing.Size(226, 23);
            this.rddLoc.TabIndex = 4;
            this.rddLoc.ValueMember = "CustTypeID";
            // 
            // custtypeBindingSource
            // 
            this.custtypeBindingSource.DataMember = "custtype";
            this.custtypeBindingSource.DataSource = this.sinarekDataSet;
            this.custtypeBindingSource.Filter = "storage = 1";
            this.custtypeBindingSource.Sort = "name asc";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(11, 148);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(44, 21);
            this.radLabel5.TabIndex = 18;
            this.radLabel5.Text = "Lokasi";
            // 
            // custtypeTableAdapter
            // 
            this.custtypeTableAdapter.ClearBeforeFill = true;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.txtTipeNama);
            this.radGroupBox1.Controls.Add(this.btnNewTipe);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(504, 48);
            this.radGroupBox1.TabIndex = 19;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNext.Location = new System.Drawing.Point(24, 307);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 23);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "&Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmAddProductBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 338);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.rddLoc);
            this.Controls.Add(this.chkOthers);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.chkGoods);
            this.Controls.Add(this.chkSellable);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.rddTipe);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnAddUnit);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.rddUnit);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rddProd);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddProductBase";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New Product";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAddProductBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rddProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tunitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeprodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSellable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOthers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewTipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipeNama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList rddProd;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnAddProd;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList rddUnit;
        private Telerik.WinControls.UI.RadMaskedEditBox txtPrice;
        private Telerik.WinControls.UI.RadButton btnAddUnit;
        private Telerik.WinControls.UI.RadButton btnBatal;
        private Telerik.WinControls.UI.RadButton btnSimpan;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource tunitBindingSource;
        private sinarekDataSetTableAdapters.tunitTableAdapter tunitTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private sinarekDataSetTableAdapters.productTableAdapter productTableAdapter;
        private Telerik.WinControls.UI.RadDropDownList rddTipe;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadCheckBox chkSellable;
        private Telerik.WinControls.UI.RadCheckBox chkGoods;
        private Telerik.WinControls.UI.RadCheckBox chkOthers;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnNewTipe;
        private System.Windows.Forms.BindingSource tipeprodBindingSource;
        private sinarekDataSetTableAdapters.tipeprodTableAdapter tipeprodTableAdapter;
        private Telerik.WinControls.UI.RadTextBox txtTipeNama;
        private Telerik.WinControls.UI.RadDropDownList rddLoc;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.Windows.Forms.BindingSource custtypeBindingSource;
        private sinarekDataSetTableAdapters.custtypeTableAdapter custtypeTableAdapter;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnNext;
    }
}
