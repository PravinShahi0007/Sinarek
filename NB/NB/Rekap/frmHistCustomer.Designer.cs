namespace NB
{
    partial class frmHistCustomer
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
            this.kotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelTableAdapter = new NB.sinarekDataSetTableAdapters.pelTableAdapter();
            this.salesTableAdapter = new NB.sinarekDataSetTableAdapters.salesTableAdapter();
            this.kotaTableAdapter = new NB.sinarekDataSetTableAdapters.kotaTableAdapter();
            this.logproductTableAdapter = new NB.sinarekDataSetTableAdapters.logproductTableAdapter();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.rdtMulai = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rdtSelesai = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtMulai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtSelesai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // kotaBindingSource
            // 
            this.kotaBindingSource.DataMember = "kota";
            this.kotaBindingSource.DataSource = this.sinarekDataSet;
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.sinarekDataSet;
            // 
            // logproductBindingSource
            // 
            this.logproductBindingSource.DataMember = "logproduct";
            this.logproductBindingSource.DataSource = this.sinarekDataSet;
            this.logproductBindingSource.Filter = "custtypeid = 1 ";
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
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // kotaTableAdapter
            // 
            this.kotaTableAdapter.ClearBeforeFill = true;
            // 
            // logproductTableAdapter
            // 
            this.logproductTableAdapter.ClearBeforeFill = true;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(89, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Pilih Pelanggan :";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.Location = new System.Drawing.Point(118, 11);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(433, 20);
            this.radDropDownList1.TabIndex = 2;
            this.radDropDownList1.Text = "radDropDownList1";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 53);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(83, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Tanggal Mulai :";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(292, 52);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(89, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Tanggal Selesai :";
            // 
            // rdtMulai
            // 
            this.rdtMulai.Location = new System.Drawing.Point(118, 50);
            this.rdtMulai.Name = "rdtMulai";
            this.rdtMulai.Size = new System.Drawing.Size(164, 20);
            this.rdtMulai.TabIndex = 5;
            this.rdtMulai.TabStop = false;
            this.rdtMulai.Text = "Thursday, 6 August 2015";
            this.rdtMulai.Value = new System.DateTime(2015, 8, 6, 11, 46, 49, 705);
            // 
            // rdtSelesai
            // 
            this.rdtSelesai.Location = new System.Drawing.Point(387, 50);
            this.rdtSelesai.Name = "rdtSelesai";
            this.rdtSelesai.Size = new System.Drawing.Size(164, 20);
            this.rdtSelesai.TabIndex = 6;
            this.rdtSelesai.TabStop = false;
            this.rdtSelesai.Text = "Thursday, 6 August 2015";
            this.rdtSelesai.Value = new System.DateTime(2015, 8, 6, 11, 46, 49, 705);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(13, 89);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(538, 24);
            this.radButton1.TabIndex = 7;
            this.radButton1.Text = "radButton1";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(194, 484);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(240, 150);
            this.radGridView1.TabIndex = 8;
            this.radGridView1.Text = "radGridView1";
            // 
            // frmHistCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 650);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.rdtSelesai);
            this.Controls.Add(this.rdtMulai);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radDropDownList1);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmHistCustomer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmHistCustomer";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmHistCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtMulai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtSelesai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource pelBindingSource;
        private sinarekDataSetTableAdapters.pelTableAdapter pelTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private sinarekDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource kotaBindingSource;
        private sinarekDataSetTableAdapters.kotaTableAdapter kotaTableAdapter;
        private System.Windows.Forms.BindingSource logproductBindingSource;
        private sinarekDataSetTableAdapters.logproductTableAdapter logproductTableAdapter;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDateTimePicker rdtMulai;
        private Telerik.WinControls.UI.RadDateTimePicker rdtSelesai;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}
