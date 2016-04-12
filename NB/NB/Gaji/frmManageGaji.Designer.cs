namespace NB
{
    partial class frmManageGaji
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.rddStaff = new Telerik.WinControls.UI.RadDropDownList();
            this.lblStaff = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.btnEditTemplate = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.rddTipe = new Telerik.WinControls.UI.RadDropDownList();
            this.txtNilai = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNilai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(26, 5);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(66, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "radLabel1";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(36, 97);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.ShadowOffset = new System.Drawing.Point(0, 0);
            this.radSeparator1.Size = new System.Drawing.Size(438, 17);
            this.radSeparator1.TabIndex = 1;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // rddStaff
            // 
            this.rddStaff.DropDownAnimationEnabled = true;
            this.rddStaff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddStaff.Location = new System.Drawing.Point(126, 124);
            this.rddStaff.Name = "rddStaff";
            this.rddStaff.ShowImageInEditorArea = true;
            this.rddStaff.Size = new System.Drawing.Size(206, 23);
            this.rddStaff.TabIndex = 2;
            this.rddStaff.Text = "radDropDownList1";
            // 
            // lblStaff
            // 
            this.lblStaff.Location = new System.Drawing.Point(59, 125);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(50, 21);
            this.lblStaff.TabIndex = 3;
            this.lblStaff.Text = "Nama :";
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radButton1.Location = new System.Drawing.Point(350, 125);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(102, 21);
            this.radButton1.TabIndex = 4;
            this.radButton1.Text = "Staff &Baru";
            // 
            // btnEditTemplate
            // 
            this.btnEditTemplate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditTemplate.Location = new System.Drawing.Point(60, 162);
            this.btnEditTemplate.Name = "btnEditTemplate";
            this.btnEditTemplate.Size = new System.Drawing.Size(391, 29);
            this.btnEditTemplate.TabIndex = 5;
            this.btnEditTemplate.Text = "Edit Template Gaji";
            this.btnEditTemplate.Click += new System.EventHandler(this.btnEditTemplate_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(61, 299);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(390, 142);
            this.radGridView1.TabIndex = 6;
            this.radGridView1.Text = "radGridView1";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(19, 27);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(66, 21);
            this.radLabel2.TabIndex = 8;
            this.radLabel2.Text = "Tipe Gaji :";
            // 
            // rddTipe
            // 
            this.rddTipe.DropDownAnimationEnabled = true;
            this.rddTipe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddTipe.Location = new System.Drawing.Point(86, 26);
            this.rddTipe.Name = "rddTipe";
            this.rddTipe.ShowImageInEditorArea = true;
            this.rddTipe.Size = new System.Drawing.Size(206, 23);
            this.rddTipe.TabIndex = 7;
            // 
            // txtNilai
            // 
            this.txtNilai.AllowPromptAsInput = false;
            this.txtNilai.AutoSize = true;
            this.txtNilai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNilai.Location = new System.Drawing.Point(86, 57);
            this.txtNilai.Mask = "n2";
            this.txtNilai.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(205, 23);
            this.txtNilai.TabIndex = 9;
            this.txtNilai.TabStop = false;
            this.txtNilai.Text = "0.00";
            this.txtNilai.Value = "0.00";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(19, 59);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(41, 21);
            this.radLabel3.TabIndex = 10;
            this.radLabel3.Text = "Nilai :";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Location = new System.Drawing.Point(309, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 21);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "&Add";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnAdd);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.txtNilai);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.rddTipe);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center;
            this.radGroupBox1.HeaderImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Manage Template";
            this.radGroupBox1.Location = new System.Drawing.Point(43, 205);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(424, 86);
            this.radGroupBox1.TabIndex = 12;
            this.radGroupBox1.Text = "Manage Template";
            // 
            // frmManageGaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 458);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.btnEditTemplate);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.rddStaff);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmManageGaji";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Manage Gaji Staff Template";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddTipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNilai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadDropDownList rddStaff;
        private Telerik.WinControls.UI.RadLabel lblStaff;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton btnEditTemplate;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadDropDownList rddTipe;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadMaskedEditBox txtNilai;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;

    }
}
