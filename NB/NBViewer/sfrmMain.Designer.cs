namespace NBViewer
{
    partial class sfrmMain
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
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.roundRectShapeTitle = new Telerik.WinControls.RoundRectShape(this.components);
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radPivotGrid1 = new Telerik.WinControls.UI.RadPivotGrid();
            this.sinarek = new NBViewer.Sinarek();
            this.pGetStockTransTanggalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pGetStockTransTanggalTableAdapter = new NBViewer.SinarekTableAdapters.pGetStockTransTanggalTableAdapter();
            this.radPivotFieldList1 = new Telerik.WinControls.UI.RadPivotFieldList();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGetStockTransTanggalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTitleBar1.Location = new System.Drawing.Point(1, 1);
            this.radTitleBar1.Name = "radTitleBar1";
            // 
            // 
            // 
            this.radTitleBar1.RootElement.ApplyShapeToControl = true;
            this.radTitleBar1.RootElement.Shape = this.roundRectShapeTitle;
            this.radTitleBar1.Size = new System.Drawing.Size(1126, 23);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "sfrmMain";
            // 
            // roundRectShapeTitle
            // 
            this.roundRectShapeTitle.BottomLeftRounded = false;
            this.roundRectShapeTitle.BottomRightRounded = false;
            // 
            // radPivotGrid1
            // 
            this.radPivotGrid1.DataSource = this.pGetStockTransTanggalBindingSource;
            this.radPivotGrid1.Location = new System.Drawing.Point(12, 30);
            this.radPivotGrid1.Name = "radPivotGrid1";
            this.radPivotGrid1.Size = new System.Drawing.Size(840, 707);
            this.radPivotGrid1.TabIndex = 1;
            this.radPivotGrid1.Text = "radPivotGrid1";
            this.radPivotGrid1.ThemeName = "VisualStudio2012Light";
            // 
            // sinarek
            // 
            this.sinarek.DataSetName = "Sinarek";
            this.sinarek.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pGetStockTransTanggalBindingSource
            // 
            this.pGetStockTransTanggalBindingSource.DataMember = "pGetStockTransTanggal";
            this.pGetStockTransTanggalBindingSource.DataSource = this.sinarek;
            // 
            // pGetStockTransTanggalTableAdapter
            // 
            this.pGetStockTransTanggalTableAdapter.ClearBeforeFill = true;
            // 
            // radPivotFieldList1
            // 
            this.radPivotFieldList1.AssociatedPivotGrid = this.radPivotGrid1;
            this.radPivotFieldList1.Location = new System.Drawing.Point(858, 30);
            this.radPivotFieldList1.MinimumSize = new System.Drawing.Size(225, 305);
            this.radPivotFieldList1.Name = "radPivotFieldList1";
            this.radPivotFieldList1.Size = new System.Drawing.Size(258, 707);
            this.radPivotFieldList1.TabIndex = 2;
            this.radPivotFieldList1.ThemeName = "VisualStudio2012Light";
            // 
            // sfrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 749);
            this.Controls.Add(this.radPivotFieldList1);
            this.Controls.Add(this.radPivotGrid1);
            this.Controls.Add(this.radTitleBar1);
            this.Name = "sfrmMain";
            this.Shape = this.roundRectShapeForm;
            this.Text = "sfrmMain";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinarek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGetStockTransTanggalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.RoundRectShape roundRectShapeTitle;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadPivotGrid radPivotGrid1;
        private System.Windows.Forms.BindingSource pGetStockTransTanggalBindingSource;
        private Sinarek sinarek;
        private SinarekTableAdapters.pGetStockTransTanggalTableAdapter pGetStockTransTanggalTableAdapter;
        private Telerik.WinControls.UI.RadPivotFieldList radPivotFieldList1;
    }
}
