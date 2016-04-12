namespace NB
{
    partial class frmAddGajiDetail
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
            System.Windows.Forms.Label buruhIDLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label unitvalueLabel;
            System.Windows.Forms.Label keteranganLabel;
            System.Windows.Forms.Label label1;
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSimpan = new Telerik.WinControls.UI.RadButton();
            this.buruhIDRadDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.unitvalueRadMaskedEditBox = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.keteranganTextBox = new System.Windows.Forms.TextBox();
            this.btnNext = new Telerik.WinControls.UI.RadButton();
            this.unitradMaskedEditBox = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.memberTableAdapter = new NB.sinarekDataSetTableAdapters.memberTableAdapter();
            buruhIDLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            unitvalueLabel = new System.Windows.Forms.Label();
            keteranganLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buruhIDRadDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitvalueRadMaskedEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitradMaskedEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // buruhIDLabel
            // 
            buruhIDLabel.AutoSize = true;
            buruhIDLabel.Location = new System.Drawing.Point(9, 49);
            buruhIDLabel.Name = "buruhIDLabel";
            buruhIDLabel.Size = new System.Drawing.Size(59, 21);
            buruhIDLabel.TabIndex = 15;
            buruhIDLabel.Text = "Nama :";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(9, 13);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(68, 21);
            startDateLabel.TabIndex = 17;
            startDateLabel.Text = "Tanggal:";
            // 
            // unitvalueLabel
            // 
            unitvalueLabel.AutoSize = true;
            unitvalueLabel.Location = new System.Drawing.Point(9, 119);
            unitvalueLabel.Name = "unitvalueLabel";
            unitvalueLabel.Size = new System.Drawing.Size(105, 21);
            unitvalueLabel.TabIndex = 19;
            unitvalueLabel.Text = "Jumlah:     Rp.";
            // 
            // keteranganLabel
            // 
            keteranganLabel.AutoSize = true;
            keteranganLabel.Location = new System.Drawing.Point(9, 155);
            keteranganLabel.Name = "keteranganLabel";
            keteranganLabel.Size = new System.Drawing.Size(89, 21);
            keteranganLabel.TabIndex = 21;
            keteranganLabel.Text = "Keterangan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 84);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 21);
            label1.TabIndex = 23;
            label1.Text = "Unit :";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(245, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 25);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSimpan.Location = new System.Drawing.Point(132, 195);
            this.btnSimpan.Name = "btnSimpan";
            // 
            // 
            // 
            this.btnSimpan.RootElement.ToolTipText = "Simpan dan Keluar";
            this.btnSimpan.Size = new System.Drawing.Size(85, 25);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // buruhIDRadDropDownList
            // 
            this.buruhIDRadDropDownList.AutoCompleteDisplayMember = "Name";
            this.buruhIDRadDropDownList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.buruhIDRadDropDownList.AutoCompleteValueMember = "MemberID";
            this.buruhIDRadDropDownList.DataSource = this.memberBindingSource;
            this.buruhIDRadDropDownList.DisplayMember = "Name";
            this.buruhIDRadDropDownList.DropDownAnimationEnabled = true;
            this.buruhIDRadDropDownList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buruhIDRadDropDownList.Location = new System.Drawing.Point(128, 46);
            this.buruhIDRadDropDownList.Name = "buruhIDRadDropDownList";
            this.buruhIDRadDropDownList.ShowImageInEditorArea = true;
            this.buruhIDRadDropDownList.Size = new System.Drawing.Size(200, 27);
            this.buruhIDRadDropDownList.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.buruhIDRadDropDownList.TabIndex = 2;
            this.buruhIDRadDropDownList.ThemeName = "Office2010Blue";
            this.buruhIDRadDropDownList.ValueMember = "MemberID";
            this.buruhIDRadDropDownList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.buruhIDRadDropDownList_SelectedIndexChanged);
            this.buruhIDRadDropDownList.SelectedValueChanged += new System.EventHandler(this.buruhIDRadDropDownList_SelectedValueChanged);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this.sinarekDataSet;
            this.memberBindingSource.Filter = "active = 1 and tipememberid in (2,3)";
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.CustomFormat = "dd MMM yyy";
            this.startDateDateTimePicker.Enabled = false;
            this.startDateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateDateTimePicker.Location = new System.Drawing.Point(128, 9);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.ShowUpDown = true;
            this.startDateDateTimePicker.Size = new System.Drawing.Size(119, 29);
            this.startDateDateTimePicker.TabIndex = 1;
            this.startDateDateTimePicker.Value = new System.DateTime(2011, 11, 7, 0, 0, 0, 0);
            // 
            // unitvalueRadMaskedEditBox
            // 
            this.unitvalueRadMaskedEditBox.AllowPromptAsInput = false;
            this.unitvalueRadMaskedEditBox.AutoSize = true;
            this.unitvalueRadMaskedEditBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitvalueRadMaskedEditBox.Location = new System.Drawing.Point(128, 116);
            this.unitvalueRadMaskedEditBox.Mask = "f";
            this.unitvalueRadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.unitvalueRadMaskedEditBox.Name = "unitvalueRadMaskedEditBox";
            this.unitvalueRadMaskedEditBox.Size = new System.Drawing.Size(200, 27);
            this.unitvalueRadMaskedEditBox.TabIndex = 4;
            this.unitvalueRadMaskedEditBox.TabStop = false;
            this.unitvalueRadMaskedEditBox.Text = "0.00";
            this.unitvalueRadMaskedEditBox.Value = "0.00";
            // 
            // keteranganTextBox
            // 
            this.keteranganTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keteranganTextBox.Location = new System.Drawing.Point(128, 151);
            this.keteranganTextBox.Name = "keteranganTextBox";
            this.keteranganTextBox.Size = new System.Drawing.Size(200, 29);
            this.keteranganTextBox.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNext.Location = new System.Drawing.Point(19, 195);
            this.btnNext.Name = "btnNext";
            // 
            // 
            // 
            this.btnNext.RootElement.ToolTipText = "Simpan dan lanjutkan input";
            this.btnNext.Size = new System.Drawing.Size(85, 25);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "&Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // unitradMaskedEditBox
            // 
            this.unitradMaskedEditBox.AllowPromptAsInput = false;
            this.unitradMaskedEditBox.AutoSize = true;
            this.unitradMaskedEditBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitradMaskedEditBox.Location = new System.Drawing.Point(128, 81);
            this.unitradMaskedEditBox.Mask = "f";
            this.unitradMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.unitradMaskedEditBox.Name = "unitradMaskedEditBox";
            this.unitradMaskedEditBox.Size = new System.Drawing.Size(200, 27);
            this.unitradMaskedEditBox.TabIndex = 3;
            this.unitradMaskedEditBox.TabStop = false;
            this.unitradMaskedEditBox.Text = "0.00";
            this.unitradMaskedEditBox.Value = "0.00";
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddGajiDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 234);
            this.Controls.Add(label1);
            this.Controls.Add(this.unitradMaskedEditBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(buruhIDLabel);
            this.Controls.Add(this.buruhIDRadDropDownList);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(unitvalueLabel);
            this.Controls.Add(this.unitvalueRadMaskedEditBox);
            this.Controls.Add(keteranganLabel);
            this.Controls.Add(this.keteranganTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddGajiDetail";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "[CAPTION]";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAddGajiDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buruhIDRadDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitvalueRadMaskedEditBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitradMaskedEditBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSimpan;
        private Telerik.WinControls.UI.RadDropDownList buruhIDRadDropDownList;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private Telerik.WinControls.UI.RadMaskedEditBox unitvalueRadMaskedEditBox;
        private System.Windows.Forms.TextBox keteranganTextBox;
        private sinarekDataSet sinarekDataSet;
        private Telerik.WinControls.UI.RadButton btnNext;
        private Telerik.WinControls.UI.RadMaskedEditBox unitradMaskedEditBox;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private sinarekDataSetTableAdapters.memberTableAdapter memberTableAdapter;
    }
}
