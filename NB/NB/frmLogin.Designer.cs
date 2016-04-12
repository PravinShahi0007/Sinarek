namespace NB
{
    partial class frmLogin
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
            System.Windows.Forms.Label lognameLabel;
            System.Windows.Forms.Label passthroughLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lognameRadMaskedEditBox = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.btnLogin = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.fingermachDataSet = new NB.fingermachDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new NB.fingermachDataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new NB.fingermachDataSetTableAdapters.TableAdapterManager();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            lognameLabel = new System.Windows.Forms.Label();
            passthroughLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lognameRadMaskedEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lognameLabel
            // 
            lognameLabel.AutoSize = true;
            lognameLabel.Location = new System.Drawing.Point(22, 14);
            lognameLabel.Name = "lognameLabel";
            lognameLabel.Size = new System.Drawing.Size(84, 21);
            lognameLabel.TabIndex = 1;
            lognameLabel.Text = "Username:";
            // 
            // passthroughLabel
            // 
            passthroughLabel.AutoSize = true;
            passthroughLabel.Location = new System.Drawing.Point(22, 44);
            passthroughLabel.Name = "passthroughLabel";
            passthroughLabel.Size = new System.Drawing.Size(80, 21);
            passthroughLabel.TabIndex = 2;
            passthroughLabel.Text = "Password:";
            // 
            // lognameRadMaskedEditBox
            // 
            this.lognameRadMaskedEditBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lognameRadMaskedEditBox.Location = new System.Drawing.Point(111, 12);
            this.lognameRadMaskedEditBox.Name = "lognameRadMaskedEditBox";
            this.lognameRadMaskedEditBox.Size = new System.Drawing.Size(182, 30);
            this.lognameRadMaskedEditBox.TabIndex = 1;
            this.lognameRadMaskedEditBox.TabStop = false;
            this.lognameRadMaskedEditBox.ThemeName = "TelerikMetro";
            this.lognameRadMaskedEditBox.Enter += new System.EventHandler(this.lognameRadMaskedEditBox_Enter);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogin.Location = new System.Drawing.Point(69, 85);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(64, 25);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "&Login";
            this.btnLogin.ThemeName = "TelerikMetroBlue";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radButton1.Location = new System.Drawing.Point(186, 85);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(77, 25);
            this.radButton1.TabIndex = 5;
            this.radButton1.Text = "&Batal";
            this.radButton1.ThemeName = "TelerikMetroBlue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(111, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 30);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.ThemeName = "TelerikMetro";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // fingermachDataSet
            // 
            this.fingermachDataSet.DataSetName = "fingermachDataSet";
            this.fingermachDataSet.EnforceConstraints = false;
            this.fingermachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.fingermachDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.staffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.tdatafingerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NB.fingermachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 127);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(passthroughLabel);
            this.Controls.Add(lognameLabel);
            this.Controls.Add(this.lognameRadMaskedEditBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinarek Management System";
            this.ThemeName = "Windows7";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lognameRadMaskedEditBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private fingermachDataSet fingermachDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private fingermachDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private fingermachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Telerik.WinControls.UI.RadMaskedEditBox lognameRadMaskedEditBox;
        private Telerik.WinControls.UI.RadButton btnLogin;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}
