namespace NB
{
    partial class frmAbsenAll
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
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            this.rddGBID = new Telerik.WinControls.UI.RadDropDownList();
            this.gajibulananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.rddMember = new Telerik.WinControls.UI.RadDropDownList();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new NB.sinarekDataSetTableAdapters.memberTableAdapter();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.gajibulananTableAdapter = new NB.sinarekDataSetTableAdapters.gajibulananTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddGBID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gajibulananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrint.Location = new System.Drawing.Point(644, 23);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(151, 28);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "&Print Absen";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rddGBID
            // 
            this.rddGBID.AutoCompleteDisplayMember = "StartDate";
            this.rddGBID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddGBID.AutoCompleteValueMember = "GBID";
            this.rddGBID.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.gajibulananBindingSource, "StartDate", true));
            this.rddGBID.DataSource = this.gajibulananBindingSource;
            this.rddGBID.DisplayMember = "StartDate";
            this.rddGBID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddGBID.FormatString = "MMM yy";
            this.rddGBID.Location = new System.Drawing.Point(60, 26);
            this.rddGBID.Name = "rddGBID";
            this.rddGBID.Size = new System.Drawing.Size(167, 23);
            this.rddGBID.TabIndex = 6;
            this.rddGBID.ValueMember = "GBID";
            this.rddGBID.SelectedValueChanged += new System.EventHandler(this.rddGBID_SelectedValueChanged);
            // 
            // gajibulananBindingSource
            // 
            this.gajibulananBindingSource.DataMember = "gajibulanan";
            this.gajibulananBindingSource.DataSource = this.sinarekDataSet;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 27);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(40, 18);
            this.radLabel1.TabIndex = 7;
            this.radLabel1.Text = "Bulan :";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(327, 27);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(41, 18);
            this.radLabel2.TabIndex = 9;
            this.radLabel2.Text = "Nama :";
            // 
            // rddMember
            // 
            this.rddMember.AutoCompleteDisplayMember = "Name";
            this.rddMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rddMember.AutoCompleteValueMember = "MemberID";
            this.rddMember.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.gajibulananBindingSource, "StartDate", true));
            this.rddMember.DataSource = this.memberBindingSource;
            this.rddMember.DisplayMember = "Name";
            this.rddMember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rddMember.Location = new System.Drawing.Point(377, 26);
            this.rddMember.Name = "rddMember";
            this.rddMember.Size = new System.Drawing.Size(194, 23);
            this.rddMember.TabIndex = 8;
            this.rddMember.ValueMember = "MemberID";
            this.rddMember.SelectedValueChanged += new System.EventHandler(this.rddMember_SelectedValueChanged);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this.sinarekDataSet;
            this.memberBindingSource.Filter = "active = 1";
            this.memberBindingSource.Sort = "";
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.rddMember);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.rddGBID);
            this.radGroupBox1.Controls.Add(this.btnPrint);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(846, 69);
            this.radGroupBox1.TabIndex = 10;
            // 
            // radScheduler1
            // 
            this.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Month;
            this.radScheduler1.AppointmentTitleFormat = null;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radScheduler1.Location = new System.Drawing.Point(0, 69);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2016, 2, 14, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2016, 2, 9, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.ReadOnly = true;
            this.radScheduler1.Size = new System.Drawing.Size(846, 480);
            this.radScheduler1.TabIndex = 11;
            this.radScheduler1.Text = "radScheduler1";
            // 
            // gajibulananTableAdapter
            // 
            this.gajibulananTableAdapter.ClearBeforeFill = true;
            // 
            // frmAbsenAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 549);
            this.Controls.Add(this.radScheduler1);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAbsenAll";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Lihat Absen Bulanan";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAbsenSatpam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddGBID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gajibulananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sinarekDataSet sinarekDataSet;
        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.UI.RadDropDownList rddGBID;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.BindingSource gajibulananBindingSource;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList rddMember;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private sinarekDataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private sinarekDataSetTableAdapters.gajibulananTableAdapter gajibulananTableAdapter;


    }
}
