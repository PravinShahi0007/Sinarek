namespace NB
{
    partial class frmMain
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainradStatusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.mainradMenu = new Telerik.WinControls.UI.RadMenu();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.actionlogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtPwd = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.btnChange = new Telerik.WinControls.UI.RadButton();
            this.txtKeterangan = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.actionlogTableAdapter = new NB.sinarekDataSetTableAdapters.actionlogTableAdapter();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.mainradStatusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainradMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionlogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeterangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mainradStatusStrip
            // 
            this.mainradStatusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1});
            this.mainradStatusStrip.Location = new System.Drawing.Point(0, 602);
            this.mainradStatusStrip.Name = "mainradStatusStrip";
            this.mainradStatusStrip.Size = new System.Drawing.Size(966, 35);
            this.mainradStatusStrip.TabIndex = 1;
            this.mainradStatusStrip.Text = "radStatusStrip1";
            this.mainradStatusStrip.ThemeName = "Windows8";
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabelElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radLabelElement1.Name = "radLabelElement1";
            this.mainradStatusStrip.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "radLabelElement1";
            this.radLabelElement1.TextWrap = true;
            // 
            // mainradMenu
            // 
            this.mainradMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainradMenu.Location = new System.Drawing.Point(0, 0);
            this.mainradMenu.Name = "mainradMenu";
            this.mainradMenu.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.mainradMenu.Size = new System.Drawing.Size(966, 31);
            this.mainradMenu.TabIndex = 2;
            this.mainradMenu.Text = "radMenu1";
            this.mainradMenu.ThemeName = "Windows8";
            this.mainradMenu.Click += new System.EventHandler(this.mainradMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.AutoSizeRows = true;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGridView1.Location = new System.Drawing.Point(12, 41);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "actionid";
            gridViewDecimalColumn1.HeaderText = "actionid";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "actionid";
            gridViewDateTimeColumn1.FieldName = "Tanggal";
            gridViewDateTimeColumn1.FormatString = "{0:dd MMM yy hh:mm tt}";
            gridViewDateTimeColumn1.HeaderText = "Tanggal";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "Tanggal";
            gridViewDateTimeColumn1.Width = 150;
            gridViewTextBoxColumn1.FieldName = "createdby";
            gridViewTextBoxColumn1.HeaderText = "Nama";
            gridViewTextBoxColumn1.Name = "createdby";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "keterangan";
            gridViewTextBoxColumn2.HeaderText = "Keterangan";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "keterangan";
            gridViewTextBoxColumn2.Width = 250;
            gridViewTextBoxColumn2.WrapText = true;
            gridViewDecimalColumn2.DataType = typeof(short);
            gridViewDecimalColumn2.FieldName = "statusid";
            gridViewDecimalColumn2.HeaderText = "statusid";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "statusid";
            gridViewTextBoxColumn3.FieldName = "actionby";
            gridViewTextBoxColumn3.HeaderText = "";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "actionby";
            gridViewCommandColumn1.DefaultText = "fixed";
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Name = "cmdFixed";
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 80;
            gridViewCommandColumn2.DefaultText = "Batal";
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Name = "cmd";
            gridViewCommandColumn2.UseDefaultText = true;
            gridViewCommandColumn2.Width = 80;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.radGridView1.MasterTemplate.DataSource = this.actionlogBindingSource;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(5);
            this.radGridView1.ReadOnly = true;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(709, 229);
            this.radGridView1.TabIndex = 4;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Windows8";
            this.radGridView1.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.radGridView1_CommandCellClick);
            // 
            // actionlogBindingSource
            // 
            this.actionlogBindingSource.DataMember = "actionlog";
            this.actionlogBindingSource.DataSource = this.sinarekDataSet;
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.txtPwd);
            this.radGroupBox1.Controls.Add(this.btnChange);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "Change Password";
            this.radGroupBox1.Location = new System.Drawing.Point(735, 43);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(222, 96);
            this.radGroupBox1.TabIndex = 6;
            this.radGroupBox1.Text = "Change Password";
            this.radGroupBox1.ThemeName = "Windows8";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPwd.Location = new System.Drawing.Point(20, 33);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.NullText = "type new password here";
            this.txtPwd.Size = new System.Drawing.Size(181, 23);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.TabStop = false;
            this.txtPwd.ThemeName = "Windows8";
            // 
            // btnChange
            // 
            this.btnChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnChange.Location = new System.Drawing.Point(2, 72);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(218, 22);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Simpan";
            this.btnChange.ThemeName = "Windows8";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeterangan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKeterangan.Location = new System.Drawing.Point(12, 276);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.NullText = "keterangan koreksi .  .  .  .";
            this.txtKeterangan.Size = new System.Drawing.Size(709, 23);
            this.txtKeterangan.TabIndex = 0;
            this.txtKeterangan.TabStop = false;
            this.txtKeterangan.ThemeName = "Windows8";
            this.txtKeterangan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeterangan_KeyPress);
            this.txtKeterangan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeterangan_KeyUp);
            // 
            // actionlogTableAdapter
            // 
            this.actionlogTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(966, 637);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.mainradMenu);
            this.Controls.Add(this.mainradStatusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "frmMain";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Sinarek Management System";
            this.ThemeName = "Windows8";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainradStatusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainradMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionlogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeterangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip mainradStatusStrip;
        private Telerik.WinControls.UI.RadMenu mainradMenu;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private sinarekDataSet sinarekDataSet;
        private System.Windows.Forms.BindingSource actionlogBindingSource;
        private sinarekDataSetTableAdapters.actionlogTableAdapter actionlogTableAdapter;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnChange;
        private Telerik.WinControls.UI.RadMaskedEditBox txtPwd;
        private Telerik.WinControls.UI.RadMaskedEditBox txtKeterangan;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}
