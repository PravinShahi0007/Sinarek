namespace NB
{
    partial class frmAddPelanggan
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label kotaidLabel;
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.pelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelTableAdapter = new NB.sinarekDataSetTableAdapters.pelTableAdapter();
            this.rddKota = new Telerik.WinControls.UI.RadDropDownList();
            this.btnSimpan = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.txtAddress = new Telerik.WinControls.UI.RadTextBox();
            this.kotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kotaTableAdapter = new NB.sinarekDataSetTableAdapters.kotaTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            kotaidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddKota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(5, 11);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(48, 19);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(5, 39);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(98, 19);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Alamat:      Jln.";
            // 
            // kotaidLabel
            // 
            kotaidLabel.AutoSize = true;
            kotaidLabel.Location = new System.Drawing.Point(5, 64);
            kotaidLabel.Name = "kotaidLabel";
            kotaidLabel.Size = new System.Drawing.Size(44, 19);
            kotaidLabel.TabIndex = 7;
            kotaidLabel.Text = "Kota :";
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pelBindingSource
            // 
            this.pelBindingSource.DataMember = "pel";
            this.pelBindingSource.DataSource = this.sinarekDataSet;
            // 
            // pelTableAdapter
            // 
            this.pelTableAdapter.ClearBeforeFill = true;
            // 
            // rddKota
            // 
            this.rddKota.AutoCompleteDisplayMember = "Nama";
            this.rddKota.AutoCompleteValueMember = "KotaID";
            this.rddKota.DataSource = this.kotaBindingSource;
            this.rddKota.DescriptionTextMember = "Nama";
            this.rddKota.DisplayMember = "Nama";
            this.rddKota.DropDownAnimationEnabled = true;
            this.rddKota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddKota.Location = new System.Drawing.Point(79, 64);
            this.rddKota.Name = "rddKota";
            this.rddKota.ShowImageInEditorArea = true;
            this.rddKota.Size = new System.Drawing.Size(206, 23);
            this.rddKota.TabIndex = 3;
            this.rddKota.ValueMember = "KotaID";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.Location = new System.Drawing.Point(10, 102);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(160, 32);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(202, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 32);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(79, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(109, 37);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(217, 23);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TabStop = false;
            // 
            // kotaBindingSource
            // 
            this.kotaBindingSource.DataMember = "kota";
            this.kotaBindingSource.DataSource = this.sinarekDataSet;
            this.kotaBindingSource.Filter = "systemonly =0";
            // 
            // kotaTableAdapter
            // 
            this.kotaTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 143);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(nameLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(kotaidLabel);
            this.Controls.Add(this.rddKota);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddPelanggan";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Input Pelanggan";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAddPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddKota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource pelBindingSource;
        private sinarekDataSetTableAdapters.pelTableAdapter pelTableAdapter;
        private Telerik.WinControls.UI.RadDropDownList rddKota;
        private Telerik.WinControls.UI.RadButton btnSimpan;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadTextBox txtAddress;
        private System.Windows.Forms.BindingSource kotaBindingSource;
        private sinarekDataSetTableAdapters.kotaTableAdapter kotaTableAdapter;

    }
}
