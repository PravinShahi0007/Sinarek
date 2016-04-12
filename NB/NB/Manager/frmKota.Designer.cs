namespace NB
{
    partial class frmKota
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.kotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kotaTableAdapter = new NB.sinarekDataSetTableAdapters.kotaTableAdapter();
            this.tableAdapterManager = new NB.sinarekDataSetTableAdapters.TableAdapterManager();
            this.kotaRadGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
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
            // kotaTableAdapter
            // 
            this.kotaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.absenallTableAdapter = null;
            this.tableAdapterManager.accpaymentTableAdapter = null;
            this.tableAdapterManager.acctransTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.boronganburuhTableAdapter = null;
            this.tableAdapterManager.boronganTableAdapter = null;
            this.tableAdapterManager.comissionTableAdapter = null;
            this.tableAdapterManager.companyTableAdapter = null;
            this.tableAdapterManager.custtypeTableAdapter = null;
            this.tableAdapterManager.formulaTableAdapter = null;
            this.tableAdapterManager.gajibulananTableAdapter = null;
            this.tableAdapterManager.gajimingguanTableAdapter = null;
            this.tableAdapterManager.gajitemplateallTableAdapter = null;
            this.tableAdapterManager.gajitetapTableAdapter = null;
            this.tableAdapterManager.genderTableAdapter = null;
            this.tableAdapterManager.kernetTableAdapter = null;
            this.tableAdapterManager.kotaTableAdapter = this.kotaTableAdapter;
            this.tableAdapterManager.lappenTableAdapter = null;
            this.tableAdapterManager.logotherTableAdapter = null;
            this.tableAdapterManager.logpelTableAdapter = null;
            this.tableAdapterManager.logproductTableAdapter = null;
            this.tableAdapterManager.memberTableAdapter = null;
            this.tableAdapterManager.mobilTableAdapter = null;
            this.tableAdapterManager.payrolltypeTableAdapter = null;
            this.tableAdapterManager.pelTableAdapter = null;
            this.tableAdapterManager.pinjamanTableAdapter = null;
            this.tableAdapterManager.printlogTableAdapter = null;
            this.tableAdapterManager.productbaseTableAdapter = null;
            this.tableAdapterManager.productpriceTableAdapter = null;
            this.tableAdapterManager.productsuptotalTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.producttotalTableAdapter = null;
            this.tableAdapterManager.producttotaluserTableAdapter = null;
            this.tableAdapterManager.producttransTableAdapter = null;
            this.tableAdapterManager.rinciangajiTableAdapter = null;
            this.tableAdapterManager.saldocutiTableAdapter = null;
            this.tableAdapterManager.salescomissionTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.shiftdayTableAdapter = null;
            this.tableAdapterManager.shiftTableAdapter = null;
            this.tableAdapterManager.sopirTableAdapter = null;
            this.tableAdapterManager.storeinTableAdapter = null;
            this.tableAdapterManager.storeoutTableAdapter = null;
            this.tableAdapterManager.storeTableAdapter = null;
            this.tableAdapterManager.supTableAdapter = null;
            this.tableAdapterManager.syslogTableAdapter = null;
            this.tableAdapterManager.tierTableAdapter = null;
            this.tableAdapterManager.tipeaccountTableAdapter = null;
            this.tableAdapterManager.tipedendaTableAdapter = null;
            this.tableAdapterManager.tipememberTableAdapter = null;
            this.tableAdapterManager.tipepembayaranTableAdapter = null;
            this.tableAdapterManager.tipeprodTableAdapter = null;
            this.tableAdapterManager.tiperinciangajiTableAdapter = null;
            this.tableAdapterManager.transportTableAdapter = null;
            this.tableAdapterManager.tunitTableAdapter = null;
            this.tableAdapterManager.uangjalanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NB.sinarekDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vpengisianTableAdapter = null;
            // 
            // kotaRadGridView
            // 
            this.kotaRadGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kotaRadGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kotaRadGridView.Location = new System.Drawing.Point(0, 51);
            // 
            // kotaRadGridView
            // 
            this.kotaRadGridView.MasterTemplate.AllowAddNewRow = false;
            this.kotaRadGridView.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "KotaID";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "KotaID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "KotaID";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn1.FieldName = "Nama";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Nama";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Nama";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "short";
            gridViewTextBoxColumn2.HeaderText = "Short";
            gridViewTextBoxColumn2.Name = "short";
            gridViewDecimalColumn2.FieldName = "Jarak";
            gridViewDecimalColumn2.FormatString = "";
            gridViewDecimalColumn2.HeaderText = "Jarak";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Jarak";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn2.Width = 100;
            gridViewDecimalColumn3.DataType = typeof(short);
            gridViewDecimalColumn3.FieldName = "Zone";
            gridViewDecimalColumn3.FormatString = "";
            gridViewDecimalColumn3.HeaderText = "Zone";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "Zone";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn3.Width = 100;
            gridViewDecimalColumn4.FieldName = "Tambahan";
            gridViewDecimalColumn4.FormatString = "{0:Rp #,##0.00}";
            gridViewDecimalColumn4.HeaderText = "Tambahan";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "Tambahan";
            gridViewDecimalColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn4.Width = 100;
            gridViewDecimalColumn5.FieldName = "ResSopirBulanan";
            gridViewDecimalColumn5.FormatString = "{0:Rp #,###.00}";
            gridViewDecimalColumn5.HeaderText = "Res Sopir Bulanan";
            gridViewDecimalColumn5.Name = "ResSopirBulanan";
            gridViewDecimalColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn5.Width = 120;
            gridViewDecimalColumn6.FieldName = "ResSopir";
            gridViewDecimalColumn6.FormatString = "{0:Rp #,###.00}";
            gridViewDecimalColumn6.HeaderText = "Res Sopir";
            gridViewDecimalColumn6.Name = "ResSopir";
            gridViewDecimalColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn6.Width = 120;
            gridViewDecimalColumn7.FieldName = "ResKernet";
            gridViewDecimalColumn7.FormatString = "{0:Rp #,###.00}";
            gridViewDecimalColumn7.HeaderText = "Res Kernet";
            gridViewDecimalColumn7.Name = "ResKernet";
            gridViewDecimalColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn7.Width = 120;
            gridViewDecimalColumn8.FieldName = "UangJalan";
            gridViewDecimalColumn8.FormatString = "{0:Rp #,##0.00}";
            gridViewDecimalColumn8.HeaderText = "Uang Jalan";
            gridViewDecimalColumn8.IsAutoGenerated = true;
            gridViewDecimalColumn8.Name = "UangJalan";
            gridViewDecimalColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn8.Width = 100;
            this.kotaRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8});
            this.kotaRadGridView.MasterTemplate.DataSource = this.kotaBindingSource;
            this.kotaRadGridView.Name = "kotaRadGridView";
            this.kotaRadGridView.ShowGroupPanel = false;
            this.kotaRadGridView.Size = new System.Drawing.Size(989, 368);
            this.kotaRadGridView.TabIndex = 1;
            this.kotaRadGridView.Text = "radGridView1";
            this.kotaRadGridView.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.kotaRadGridView_CellEndEdit);
            // 
            // frmKota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 419);
            this.Controls.Add(this.kotaRadGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmKota";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Manage Kota";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmKota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource kotaBindingSource;
        private sinarekDataSetTableAdapters.kotaTableAdapter kotaTableAdapter;
        private sinarekDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Telerik.WinControls.UI.RadGridView kotaRadGridView;




    }
}
