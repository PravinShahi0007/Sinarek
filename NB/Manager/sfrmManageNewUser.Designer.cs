namespace Manager
{
    partial class sfrmManageNewUser
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
            this.authBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fingermachDataSet = new Manager.fingermachDataSet();
            this.pSelectMenuAuthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pSelectMenuAuthBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.pSelectMenuAuthTableAdapter = new Manager.fingermachDataSetTableAdapters.pSelectMenuAuthTableAdapter();
            this.authuserTableAdapter = new Manager.fingermachDataSetTableAdapters.authuserTableAdapter();
            this.authTableAdapter = new Manager.fingermachDataSetTableAdapters.authTableAdapter();
            this.rddStaff = new Telerik.WinControls.UI.RadDropDownList();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Manager.fingermachDataSetTableAdapters.staffTableAdapter();
            this.btnExit = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnCreate = new Telerik.WinControls.UI.RadButton();
            this.txtPwd = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtUser = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSelectMenuAuthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSelectMenuAuthBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // authBindingSource
            // 
            this.authBindingSource.DataMember = "auth";
            this.authBindingSource.DataSource = this.fingermachDataSet;
            this.authBindingSource.Filter = "";
            // 
            // fingermachDataSet
            // 
            this.fingermachDataSet.DataSetName = "fingermachDataSet";
            this.fingermachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pSelectMenuAuthBindingSource
            // 
            this.pSelectMenuAuthBindingSource.DataMember = "pSelectMenuAuth";
            this.pSelectMenuAuthBindingSource.DataSource = this.fingermachDataSet;
            this.pSelectMenuAuthBindingSource.Filter = "parentid = 0";
            // 
            // authBindingSource1
            // 
            this.authBindingSource1.DataMember = "auth";
            this.authBindingSource1.DataSource = this.fingermachDataSet;
            // 
            // pSelectMenuAuthBindingSource1
            // 
            this.pSelectMenuAuthBindingSource1.DataMember = "pSelectMenuAuth";
            this.pSelectMenuAuthBindingSource1.DataSource = this.fingermachDataSet;
            // 
            // pSelectMenuAuthTableAdapter
            // 
            this.pSelectMenuAuthTableAdapter.ClearBeforeFill = true;
            // 
            // authuserTableAdapter
            // 
            this.authuserTableAdapter.ClearBeforeFill = true;
            // 
            // authTableAdapter
            // 
            this.authTableAdapter.ClearBeforeFill = true;
            // 
            // rddStaff
            // 
            this.rddStaff.AutoCompleteDisplayMember = "logname";
            this.rddStaff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddStaff.AutoCompleteValueMember = "StaffID";
            this.rddStaff.DataSource = this.staffBindingSource;
            this.rddStaff.DisplayMember = "logname";
            this.rddStaff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddStaff.Location = new System.Drawing.Point(164, 95);
            this.rddStaff.Name = "rddStaff";
            this.rddStaff.Size = new System.Drawing.Size(161, 23);
            this.rddStaff.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.rddStaff.TabIndex = 1;
            this.rddStaff.Text = "radDropDownList1";
            this.rddStaff.ThemeName = "TelerikMetro";
            this.rddStaff.ValueMember = "StaffID";
            this.rddStaff.SelectedValueChanged += new System.EventHandler(this.rddStaff_SelectedValueChanged);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.AllowNew = false;
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.fingermachDataSet;
            this.staffBindingSource.Filter = "logname is not null";
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExit.Location = new System.Drawing.Point(228, 135);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.ThemeName = "TelerikMetro";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel4.Location = new System.Drawing.Point(9, 97);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(149, 21);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "Copy Permission From :";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.btnCreate);
            this.radGroupBox2.Controls.Add(this.btnExit);
            this.radGroupBox2.Controls.Add(this.radLabel4);
            this.radGroupBox2.Controls.Add(this.txtPwd);
            this.radGroupBox2.Controls.Add(this.txtUser);
            this.radGroupBox2.Controls.Add(this.rddStaff);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox2.HeaderText = "Create New User";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(438, 225);
            this.radGroupBox2.TabIndex = 6;
            this.radGroupBox2.Text = "Create New User";
            this.radGroupBox2.ThemeName = "TelerikMetro";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCreate.Location = new System.Drawing.Point(14, 135);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(149, 34);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Tag = "start";
            this.btnCreate.Text = "Save &New User";
            this.btnCreate.ThemeName = "TelerikMetro";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPwd.Location = new System.Drawing.Point(164, 60);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.NullText = "type password here";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(161, 23);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.TabStop = false;
            this.txtPwd.ThemeName = "TelerikMetro";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUser.Location = new System.Drawing.Point(164, 21);
            this.txtUser.Name = "txtUser";
            this.txtUser.NullText = "type log in name";
            this.txtUser.Size = new System.Drawing.Size(161, 23);
            this.txtUser.TabIndex = 2;
            this.txtUser.TabStop = false;
            this.txtUser.ThemeName = "TelerikMetro";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(9, 57);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(71, 21);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Password :";
            this.radLabel2.ThemeName = "TelerikMetro";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(9, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(50, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Nama :";
            this.radLabel1.ThemeName = "TelerikMetro";
            // 
            // sfrmManageNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(466, 252);
            this.Controls.Add(this.radGroupBox2);
            this.Name = "sfrmManageNewUser";
            this.Shape = this.roundRectShapeForm;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "sfrmManageUser";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.sfrmManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSelectMenuAuthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSelectMenuAuthBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private System.Windows.Forms.BindingSource pSelectMenuAuthBindingSource;
        private fingermachDataSet fingermachDataSet;
        private fingermachDataSetTableAdapters.pSelectMenuAuthTableAdapter pSelectMenuAuthTableAdapter;
        private System.Windows.Forms.BindingSource authBindingSource;
        private fingermachDataSetTableAdapters.authTableAdapter authTableAdapter;
        private System.Windows.Forms.BindingSource pSelectMenuAuthBindingSource1;
        private System.Windows.Forms.BindingSource authBindingSource1;
        private Telerik.WinControls.UI.RadDropDownList rddStaff;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private fingermachDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private Telerik.WinControls.UI.RadButton btnExit;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton btnCreate;
        private Telerik.WinControls.UI.RadMaskedEditBox txtPwd;
        private Telerik.WinControls.UI.RadMaskedEditBox txtUser;
        private fingermachDataSetTableAdapters.authuserTableAdapter authuserTableAdapter;
    }
}
