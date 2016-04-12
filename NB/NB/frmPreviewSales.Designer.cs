namespace NB
{
    partial class frmPreviewSales
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
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.rptLaporanPenjSales1 = new NB.rptLaporanPenjSales();
            ((System.ComponentModel.ISupportInitialize)(this.rptLaporanPenjSales1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ParametersAreaVisible = false;
            this.reportViewer1.Report = this.rptLaporanPenjSales1;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowHistoryButtons = false;
            this.reportViewer1.ShowPageSetupButton = false;
            this.reportViewer1.ShowParametersButton = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowPrintPreviewButton = false;
            this.reportViewer1.ShowZoom = false;
            this.reportViewer1.Size = new System.Drawing.Size(829, 418);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            // 
            // rptLaporanPenjSales1
            // 
            this.rptLaporanPenjSales1.Name = "rptLaporanPenjSales1";
            // 
            // frmPreviewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 418);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPreviewSales";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Preview Penjualan Sales";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmPreviewSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rptLaporanPenjSales1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
        private rptLaporanPenjSales rptLaporanPenjSales1;
    }
}
