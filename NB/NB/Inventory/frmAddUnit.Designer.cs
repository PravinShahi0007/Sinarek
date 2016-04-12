namespace NB
{
    partial class frmAddUnit
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
            this.btnSimpan = new Telerik.WinControls.UI.RadButton();
            this.btnBatal = new Telerik.WinControls.UI.RadButton();
            this.txtShort = new Telerik.WinControls.UI.RadTextBox();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rddUnit = new Telerik.WinControls.UI.RadDropDownList();
            this.tunitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.tunitTableAdapter = new NB.sinarekDataSetTableAdapters.tunitTableAdapter();
            this.txtConv = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.btnAddUnit = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBatal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tunitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.Location = new System.Drawing.Point(29, 156);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(106, 26);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.Location = new System.Drawing.Point(214, 156);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(106, 26);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // txtShort
            // 
            this.txtShort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtShort.Location = new System.Drawing.Point(66, 45);
            this.txtShort.Name = "txtShort";
            this.txtShort.Size = new System.Drawing.Size(269, 23);
            this.txtShort.TabIndex = 2;
            this.txtShort.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(66, 8);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(269, 23);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.TabStop = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(12, 46);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(38, 21);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Kode";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(12, 9);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(43, 21);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Nama";
            // 
            // rddUnit
            // 
            this.rddUnit.AutoCompleteDisplayMember = "Name";
            this.rddUnit.AutoCompleteValueMember = "unitid";
            this.rddUnit.DataSource = this.tunitBindingSource;
            this.rddUnit.DisplayMember = "Name";
            this.rddUnit.DropDownAnimationEnabled = true;
            this.rddUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddUnit.Location = new System.Drawing.Point(68, 119);
            this.rddUnit.Name = "rddUnit";
            this.rddUnit.ShowImageInEditorArea = true;
            this.rddUnit.Size = new System.Drawing.Size(267, 23);
            this.rddUnit.TabIndex = 4;
            this.rddUnit.ValueMember = "unitid";
            // 
            // tunitBindingSource
            // 
            this.tunitBindingSource.DataMember = "tunit";
            this.tunitBindingSource.DataSource = this.sinarekDataSet;
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(12, 120);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(48, 21);
            this.radLabel3.TabIndex = 13;
            this.radLabel3.Text = "Satuan";
            // 
            // tunitTableAdapter
            // 
            this.tunitTableAdapter.ClearBeforeFill = true;
            // 
            // txtConv
            // 
            this.txtConv.AllowPromptAsInput = false;
            this.txtConv.AutoSize = true;
            this.txtConv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConv.Location = new System.Drawing.Point(171, 82);
            this.txtConv.Mask = "n2";
            this.txtConv.Name = "txtConv";
            this.txtConv.Size = new System.Drawing.Size(164, 23);
            this.txtConv.TabIndex = 3;
            this.txtConv.TabStop = false;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel4.Location = new System.Drawing.Point(12, 83);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(104, 21);
            this.radLabel4.TabIndex = 15;
            this.radLabel4.Text = "Convertion Rate";
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddUnit.Location = new System.Drawing.Point(344, 119);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(86, 23);
            this.btnAddUnit.TabIndex = 16;
            this.btnAddUnit.TabStop = false;
            this.btnAddUnit.Text = "New &Unit";
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // frmAddUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 191);
            this.Controls.Add(this.btnAddUnit);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.txtConv);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.rddUnit);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.txtShort);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddUnit";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New Package";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAddUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBatal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tunitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnSimpan;
        private Telerik.WinControls.UI.RadButton btnBatal;
        private Telerik.WinControls.UI.RadTextBox txtShort;
        private Telerik.WinControls.UI.RadTextBox txtDescription;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList rddUnit;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource tunitBindingSource;
        private sinarekDataSetTableAdapters.tunitTableAdapter tunitTableAdapter;
        private Telerik.WinControls.UI.RadMaskedEditBox txtConv;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton btnAddUnit;
    }
}
