namespace Cashier
{
    partial class frmCashier
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
            this.btnPenjualanSales = new Telerik.WinControls.UI.RadButton();
            this.btnUangBelanja = new Telerik.WinControls.UI.RadButton();
            this.btnBills = new Telerik.WinControls.UI.RadButton();
            this.btnSisaBelanja = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnPenjualanSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUangBelanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSisaBelanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPenjualanSales
            // 
            this.btnPenjualanSales.Location = new System.Drawing.Point(294, 353);
            this.btnPenjualanSales.Name = "btnPenjualanSales";
            this.btnPenjualanSales.Size = new System.Drawing.Size(118, 109);
            this.btnPenjualanSales.TabIndex = 0;
            this.btnPenjualanSales.Text = "Penjualan Sales";
            // 
            // btnUangBelanja
            // 
            this.btnUangBelanja.Location = new System.Drawing.Point(12, 22);
            this.btnUangBelanja.Name = "btnUangBelanja";
            this.btnUangBelanja.Size = new System.Drawing.Size(118, 109);
            this.btnUangBelanja.TabIndex = 1;
            this.btnUangBelanja.Text = "Uang Belanja";
            // 
            // btnBills
            // 
            this.btnBills.Location = new System.Drawing.Point(150, 22);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(118, 109);
            this.btnBills.TabIndex = 2;
            this.btnBills.Text = "Bayar Bills";
            // 
            // btnSisaBelanja
            // 
            this.btnSisaBelanja.Location = new System.Drawing.Point(150, 353);
            this.btnSisaBelanja.Name = "btnSisaBelanja";
            this.btnSisaBelanja.Size = new System.Drawing.Size(118, 109);
            this.btnSisaBelanja.TabIndex = 3;
            this.btnSisaBelanja.Text = "Sisa Uang Belanja";
            // 
            // frmCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 474);
            this.Controls.Add(this.btnSisaBelanja);
            this.Controls.Add(this.btnBills);
            this.Controls.Add(this.btnUangBelanja);
            this.Controls.Add(this.btnPenjualanSales);
            this.Name = "frmCashier";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmCashier";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.btnPenjualanSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUangBelanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSisaBelanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnPenjualanSales;
        private Telerik.WinControls.UI.RadButton btnUangBelanja;
        private Telerik.WinControls.UI.RadButton btnBills;
        private Telerik.WinControls.UI.RadButton btnSisaBelanja;
    }
}
