namespace NB
{
    partial class frmHistoryGaji
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
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.gajimingguanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinarekDataSet = new NB.sinarekDataSet();
            this.gajimingguanTableAdapter = new NB.sinarekDataSetTableAdapters.gajimingguanTableAdapter();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.rptGajiPreview1 = new lihatgaji.rptGajiPreview();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gajimingguanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptGajiPreview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(23, 13);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(247, 21);
            this.radLabel4.TabIndex = 13;
            this.radLabel4.Text = "Gaji Mingguan Dengan Awalan Tanggal";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.AutoCompleteDisplayMember = "StartDate";
            this.radDropDownList1.AutoCompleteValueMember = "GMID";
            this.radDropDownList1.DataSource = this.gajimingguanBindingSource;
            this.radDropDownList1.DisplayMember = "StartDate";
            this.radDropDownList1.DropDownAnimationEnabled = true;
            this.radDropDownList1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDropDownList1.FormatString = "dd MMM yyy";
            this.radDropDownList1.Location = new System.Drawing.Point(276, 11);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.ShowImageInEditorArea = true;
            this.radDropDownList1.Size = new System.Drawing.Size(260, 27);
            this.radDropDownList1.TabIndex = 11;
            this.radDropDownList1.ValueMember = "GMID";
            this.radDropDownList1.SelectedValueChanged += new System.EventHandler(this.radDropDownList1_SelectedValueChanged);
            // 
            // gajimingguanBindingSource
            // 
            this.gajimingguanBindingSource.DataMember = "gajimingguan";
            this.gajimingguanBindingSource.DataSource = this.sinarekDataSet;
            this.gajimingguanBindingSource.Sort = "GMID Desc";
            // 
            // sinarekDataSet
            // 
            this.sinarekDataSet.DataSetName = "sinarekDataSet";
            this.sinarekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gajimingguanTableAdapter
            // 
            this.gajimingguanTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.Location = new System.Drawing.Point(0, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Report = this.rptGajiPreview1;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowHistoryButtons = false;
            this.reportViewer1.ShowPageSetupButton = false;
            this.reportViewer1.ShowParametersButton = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowPrintPreviewButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoom = false;
            this.reportViewer1.Size = new System.Drawing.Size(574, 459);
            this.reportViewer1.TabIndex = 14;
            this.reportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            // 
            // rptGajiPreview1
            // 
            this.rptGajiPreview1.Name = "rptGajiPreview1";
            // 
            // frmHistoryGaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 516);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radDropDownList1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmHistoryGaji";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History Gaji";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmHistoryGaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gajimingguanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptGajiPreview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private sinarekDataSetTableAdapters.gajimingguanTableAdapter gajimingguanTableAdapter;
        private System.Windows.Forms.BindingSource gajimingguanBindingSource;
        private sinarekDataSet sinarekDataSet;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
        private lihatgaji.rptGajiPreview rptGajiPreview1;
    }
}
