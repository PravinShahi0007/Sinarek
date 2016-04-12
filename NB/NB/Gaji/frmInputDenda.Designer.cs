namespace NB
{
    partial class frmInputDenda
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
            this.rddProduct = new Telerik.WinControls.UI.RadDropDownList();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.productTableAdapter = new NB.sinarekDataSetTableAdapters.productTableAdapter();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rddTipeDenda = new Telerik.WinControls.UI.RadDropDownList();
            this.tipedendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipedendaTableAdapter = new NB.sinarekDataSetTableAdapters.tipedendaTableAdapter();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtUnit = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtNoPeti = new Telerik.WinControls.UI.RadTextBox();
            this.btnSimpan = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipeDenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipedendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoPeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rddProduct
            // 
            this.rddProduct.AutoCompleteDisplayMember = "Short";
            this.rddProduct.AutoCompleteValueMember = "Short";
            this.rddProduct.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.productBindingSource, "HargaSatuan", true));
            this.rddProduct.DataSource = this.productBindingSource;
            this.rddProduct.DisplayMember = "Short";
            this.rddProduct.DropDownAnimationEnabled = true;
            this.rddProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddProduct.Location = new System.Drawing.Point(101, 12);
            this.rddProduct.Name = "rddProduct";
            this.rddProduct.ShowImageInEditorArea = true;
            this.rddProduct.Size = new System.Drawing.Size(200, 23);
            this.rddProduct.TabIndex = 1;
            this.rddProduct.Text = "radDropDownList1";
            this.rddProduct.ValueMember = "Short";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.sinarekDataSet;
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(8, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(82, 21);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Jenis Barang";
            // 
            // rddTipeDenda
            // 
            this.rddTipeDenda.AutoCompleteDisplayMember = "Nama";
            this.rddTipeDenda.AutoCompleteValueMember = "tipedendaid";
            this.rddTipeDenda.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tipedendaBindingSource, "DefaultValue", true));
            this.rddTipeDenda.DataSource = this.tipedendaBindingSource;
            this.rddTipeDenda.DisplayMember = "Nama";
            this.rddTipeDenda.DropDownAnimationEnabled = true;
            this.rddTipeDenda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddTipeDenda.Location = new System.Drawing.Point(101, 58);
            this.rddTipeDenda.Name = "rddTipeDenda";
            this.rddTipeDenda.ShowImageInEditorArea = true;
            this.rddTipeDenda.Size = new System.Drawing.Size(200, 23);
            this.rddTipeDenda.TabIndex = 3;
            this.rddTipeDenda.ValueMember = "tipedendaid";
            // 
            // tipedendaBindingSource
            // 
            this.tipedendaBindingSource.DataMember = "tipedenda";
            this.tipedendaBindingSource.DataSource = this.sinarekDataSet;
            // 
            // tipedendaTableAdapter
            // 
            this.tipedendaTableAdapter.ClearBeforeFill = true;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(8, 58);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(76, 21);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Tipe Denda";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(8, 104);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(32, 21);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Unit";
            // 
            // txtUnit
            // 
            this.txtUnit.AllowPromptAsInput = false;
            this.txtUnit.AutoSize = true;
            this.txtUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUnit.Location = new System.Drawing.Point(101, 99);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.NullText = "input unit";
            this.txtUnit.Size = new System.Drawing.Size(200, 23);
            this.txtUnit.TabIndex = 5;
            this.txtUnit.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotal.Location = new System.Drawing.Point(13, 145);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(288, 23);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "radTextBox1";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(8, 187);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(52, 21);
            this.radLabel4.TabIndex = 7;
            this.radLabel4.Text = "No Peti";
            // 
            // txtNoPeti
            // 
            this.txtNoPeti.Enabled = false;
            this.txtNoPeti.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNoPeti.Location = new System.Drawing.Point(101, 187);
            this.txtNoPeti.Name = "txtNoPeti";
            this.txtNoPeti.Size = new System.Drawing.Size(200, 23);
            this.txtNoPeti.TabIndex = 8;
            this.txtNoPeti.TabStop = false;
            this.txtNoPeti.Text = "radTextBox1";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.Location = new System.Drawing.Point(8, 237);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(117, 28);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "&Simpan";
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(170, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            // 
            // frmInputDenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 279);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNoPeti);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.rddTipeDenda);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rddProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInputDenda";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Input Denda";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmInputDenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipeDenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipedendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoPeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList rddProduct;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private sinarekDataSetTableAdapters.productTableAdapter productTableAdapter;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList rddTipeDenda;
        private System.Windows.Forms.BindingSource tipedendaBindingSource;
        private sinarekDataSetTableAdapters.tipedendaTableAdapter tipedendaTableAdapter;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadMaskedEditBox txtUnit;
        private Telerik.WinControls.UI.RadTextBox txtTotal;
        private Telerik.WinControls.UI.RadTextBox txtNoPeti;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton btnSimpan;
        private Telerik.WinControls.UI.RadButton btnCancel;
    }
}
