﻿namespace NB
{
    partial class frmAccount
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.tipeaccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.tipeaccountTableAdapter = new NB.sinarekDataSetTableAdapters.tipeaccountTableAdapter();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeaccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGridView1.Location = new System.Drawing.Point(0, 67);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "accountid";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "accountid";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "accountid";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn2.DataType = typeof(short);
            gridViewDecimalColumn2.FieldName = "accNum";
            gridViewDecimalColumn2.FormatString = "";
            gridViewDecimalColumn2.HeaderText = "accNum";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "accNum";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn3.DataType = typeof(sbyte);
            gridViewDecimalColumn3.FieldName = "accTipe";
            gridViewDecimalColumn3.FormatString = "";
            gridViewDecimalColumn3.HeaderText = "accTipe";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "accTipe";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewCheckBoxColumn1.FieldName = "category";
            gridViewCheckBoxColumn1.FormatString = "";
            gridViewCheckBoxColumn1.HeaderText = "category";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.IsVisible = false;
            gridViewCheckBoxColumn1.Name = "category";
            gridViewDateTimeColumn1.FieldName = "modified";
            gridViewDateTimeColumn1.FormatString = "";
            gridViewDateTimeColumn1.HeaderText = "modified";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.IsVisible = false;
            gridViewDateTimeColumn1.Name = "modified";
            gridViewTextBoxColumn1.FieldName = "modifiedby";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "modifiedby";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "modifiedby";
            gridViewTextBoxColumn2.FieldName = "Nama";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Nama";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Nama";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 280;
            gridViewCheckBoxColumn2.FieldName = "payment";
            gridViewCheckBoxColumn2.HeaderText = "Payment";
            gridViewCheckBoxColumn2.Name = "payment";
            gridViewCheckBoxColumn2.Width = 75;
            gridViewCheckBoxColumn3.FieldName = "systemonly";
            gridViewCheckBoxColumn3.HeaderText = "System Only";
            gridViewCheckBoxColumn3.Name = "systemonly";
            gridViewCheckBoxColumn3.Width = 100;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewCheckBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCheckBoxColumn2,
            gridViewCheckBoxColumn3});
            this.radGridView1.MasterTemplate.DataSource = this.tipeaccountBindingSource;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(486, 354);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEndEdit);
            // 
            // tipeaccountBindingSource
            // 
            this.tipeaccountBindingSource.DataMember = "tipeaccount";
            this.tipeaccountBindingSource.DataSource = this.sinarekDataSet;
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Location = new System.Drawing.Point(231, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 28);
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
            this.txtName.Location = new System.Drawing.Point(12, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 23);
            this.txtName.TabIndex = 4;
            this.txtName.TabStop = false;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 421);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAccount";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Daftar Accounts";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipeaccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource tipeaccountBindingSource;
        private sinarekDataSetTableAdapters.tipeaccountTableAdapter tipeaccountTableAdapter;
        private Telerik.WinControls.UI.RadTextBox txtName;
    }
}
