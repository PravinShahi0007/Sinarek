namespace NB
{
    partial class frmCompanyCal
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radMaskedEditBox1 = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.btnSetYear = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMaskedEditBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radSeparator1);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radMaskedEditBox1);
            this.radGroupBox1.Controls.Add(this.btnSetYear);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(327, 483);
            this.radGroupBox1.TabIndex = 0;
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(7, 148);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.ShadowOffset = new System.Drawing.Point(0, 0);
            this.radSeparator1.Size = new System.Drawing.Size(311, 15);
            this.radSeparator1.TabIndex = 6;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // radLabel3
            // 
            this.radLabel3.AutoSize = false;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(12, 106);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(309, 45);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "Changing Current Year For the program  causes current year\'s transactional data t" +
                "o be cleared.";
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.radLabel2.Location = new System.Drawing.Point(12, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(227, 29);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Current Year :";
            // 
            // radMaskedEditBox1
            // 
            this.radMaskedEditBox1.AllowPromptAsInput = false;
            this.radMaskedEditBox1.AutoSize = true;
            this.radMaskedEditBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radMaskedEditBox1.Location = new System.Drawing.Point(12, 73);
            this.radMaskedEditBox1.Mask = "9999";
            this.radMaskedEditBox1.MaskType = Telerik.WinControls.UI.MaskType.Standard;
            this.radMaskedEditBox1.Name = "radMaskedEditBox1";
            this.radMaskedEditBox1.Size = new System.Drawing.Size(65, 27);
            this.radMaskedEditBox1.TabIndex = 3;
            this.radMaskedEditBox1.TabStop = false;
            this.radMaskedEditBox1.Text = "____";
            // 
            // btnSetYear
            // 
            this.btnSetYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSetYear.Location = new System.Drawing.Point(83, 75);
            this.btnSetYear.Name = "btnSetYear";
            this.btnSetYear.Size = new System.Drawing.Size(76, 22);
            this.btnSetYear.TabIndex = 2;
            this.btnSetYear.Text = "&Set Year";
            this.btnSetYear.Click += new System.EventHandler(this.btnSetYear_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(12, 47);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(247, 20);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Silahkan Pilih Tahun Untuk Program Ini";
            // 
            // radCalendar1
            // 
            this.radCalendar1.CellAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radCalendar1.CellMargin = new System.Windows.Forms.Padding(0);
            this.radCalendar1.CellPadding = new System.Windows.Forms.Padding(0);
            this.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.Full;
            this.radCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCalendar1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radCalendar1.HeaderHeight = 17;
            this.radCalendar1.HeaderWidth = 17;
            this.radCalendar1.Location = new System.Drawing.Point(327, 0);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.RangeMaxDate = new System.DateTime(2099, 12, 30, 0, 0, 0, 0);
            // 
            // 
            // 
            this.radCalendar1.RootElement.ChildrenChanged += new Telerik.WinControls.ChildrenChangedEventHandler(this.radCalendar1_RootElement_ChildrenChanged);
            this.radCalendar1.ShowFastNavigationButtons = false;
            this.radCalendar1.ShowNavigationButtons = false;
            this.radCalendar1.ShowRowHeaders = true;
            this.radCalendar1.Size = new System.Drawing.Size(644, 483);
            this.radCalendar1.TabIndex = 1;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.ZoomFactor = 1.5F;
            this.radCalendar1.ElementRender += new Telerik.WinControls.UI.RenderElementEventHandler(this.radCalendar1_ElementRender);
            this.radCalendar1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.radCalendar1_ControlAdded);
            ((Telerik.WinControls.UI.RadCalendarElement)(this.radCalendar1.GetChildAt(0))).ZoomFactor = 1.5F;
            ((Telerik.WinControls.UI.RadCalendarElement)(this.radCalendar1.GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 10F);
            ((Telerik.WinControls.UI.CalendarCellElement)(this.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(49))).ZoomFactor = 1.5F;
            ((Telerik.WinControls.UI.CalendarCellElement)(this.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(49))).WeekEnd = true;
            ((Telerik.WinControls.UI.CalendarCellElement)(this.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(49))).SpecialDay = false;
            ((Telerik.WinControls.UI.CalendarCellElement)(this.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(49))).Image = null;
            ((Telerik.WinControls.UI.CalendarCellElement)(this.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(49))).TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            ((Telerik.WinControls.UI.CalendarCellElement)(this.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(49))).Text = "30";
            ((Telerik.WinControls.UI.CalendarCellElement)(this.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(49))).Font = new System.Drawing.Font("Segoe UI", 10F);
            ((Telerik.WinControls.UI.CalendarCellElement)(this.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1).GetChildAt(49))).ZIndex = 49;
            // 
            // frmCompanyCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 483);
            this.Controls.Add(this.radCalendar1);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCompanyCal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Company Calendar";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmCompanyCal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMaskedEditBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadMaskedEditBox radMaskedEditBox1;
        private Telerik.WinControls.UI.RadButton btnSetYear;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
