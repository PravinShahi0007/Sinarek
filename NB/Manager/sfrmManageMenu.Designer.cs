namespace Manager
{
    partial class sfrmManageMenu
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
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.authBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fingermachDataSet = new Manager.fingermachDataSet();
            this.authTableAdapter = new Manager.fingermachDataSetTableAdapters.authTableAdapter();
            this.btnMove = new Telerik.WinControls.UI.RadButton();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.authBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.txtGroupName = new Telerik.WinControls.UI.RadTextBox();
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.btnAddMenu = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtMenuName = new Telerik.WinControls.UI.RadTextBox();
            this.btnRename = new Telerik.WinControls.UI.RadButton();
            this.btnDown = new Telerik.WinControls.UI.RadButton();
            this.btnUp = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMenuName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).BeginInit();
            this.SuspendLayout();
            // 
            // radTreeView1
            // 
            this.radTreeView1.ChildMember = "authid";
            this.radTreeView1.DataSource = this.authBindingSource;
            this.radTreeView1.DisplayMember = "Name";
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radTreeView1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.MultiSelect = true;
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.ParentMember = "parentid";
            this.radTreeView1.Size = new System.Drawing.Size(198, 464);
            this.radTreeView1.SpacingBetweenNodes = 1;
            this.radTreeView1.TabIndex = 3;
            this.radTreeView1.Text = "radTreeView1";
            this.radTreeView1.ThemeName = "TelerikMetroBlue";
            this.radTreeView1.ValueMember = "authid";
            this.radTreeView1.SelectedNodeChanged += new Telerik.WinControls.UI.RadTreeView.RadTreeViewEventHandler(this.radTreeView1_SelectedNodeChanged);
            // 
            // authBindingSource
            // 
            this.authBindingSource.DataMember = "auth";
            this.authBindingSource.DataSource = this.fingermachDataSet;
            // 
            // fingermachDataSet
            // 
            this.fingermachDataSet.DataSetName = "fingermachDataSet";
            this.fingermachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authTableAdapter
            // 
            this.authTableAdapter.ClearBeforeFill = true;
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMove.Location = new System.Drawing.Point(14, 59);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(156, 25);
            this.btnMove.TabIndex = 4;
            this.btnMove.Text = "M&ove to Group";
            this.btnMove.ThemeName = "Office2010Blue";
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.AutoCompleteDisplayMember = "Name";
            this.radDropDownList1.AutoCompleteValueMember = "authid";
            this.radDropDownList1.DataSource = this.authBindingSource1;
            this.radDropDownList1.DisplayMember = "Name";
            this.radDropDownList1.DropDownAnimationEnabled = true;
            this.radDropDownList1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radDropDownList1.Location = new System.Drawing.Point(14, 28);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.ShowImageInEditorArea = true;
            this.radDropDownList1.Size = new System.Drawing.Size(156, 23);
            this.radDropDownList1.TabIndex = 5;
            this.radDropDownList1.Text = "radDropDownList1";
            this.radDropDownList1.ThemeName = "TelerikMetroBlue";
            this.radDropDownList1.ValueMember = "authid";
            // 
            // authBindingSource1
            // 
            this.authBindingSource1.DataMember = "auth";
            this.authBindingSource1.DataSource = this.fingermachDataSet;
            this.authBindingSource1.Filter = "form is null";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Location = new System.Drawing.Point(12, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 25);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add Group";
            this.btnAdd.ThemeName = "Office2010Blue";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGroupName.Location = new System.Drawing.Point(12, 30);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.NullText = "Input Group Name";
            this.txtGroupName.Size = new System.Drawing.Size(156, 23);
            this.txtGroupName.TabIndex = 7;
            this.txtGroupName.TabStop = false;
            // 
            // radListControl1
            // 
            this.radListControl1.CaseSensitiveSort = true;
            this.radListControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radListControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radListControl1.ItemHeight = 18;
            this.radListControl1.Location = new System.Drawing.Point(404, 0);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.radListControl1.Size = new System.Drawing.Size(198, 464);
            this.radListControl1.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.radListControl1.TabIndex = 8;
            this.radListControl1.Text = "radListControl1";
            this.radListControl1.ThemeName = "TelerikMetroBlue";
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddMenu.Location = new System.Drawing.Point(223, 369);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(156, 25);
            this.btnAddMenu.TabIndex = 9;
            this.btnAddMenu.Text = "Add &Menu";
            this.btnAddMenu.ThemeName = "Office2010Blue";
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDelete.Location = new System.Drawing.Point(223, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 25);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&Delete Menu";
            this.btnDelete.ThemeName = "Office2010Blue";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Location = new System.Drawing.Point(223, 431);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 25);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "&Close";
            this.btnClose.ThemeName = "Office2010Blue";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radDropDownList1);
            this.radGroupBox1.Controls.Add(this.btnMove);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Grouping";
            this.radGroupBox1.Location = new System.Drawing.Point(210, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(183, 96);
            this.radGroupBox1.TabIndex = 10;
            this.radGroupBox1.Text = "Grouping";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.txtGroupName);
            this.radGroupBox2.Controls.Add(this.btnAdd);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Manage Group";
            this.radGroupBox2.Location = new System.Drawing.Point(210, 107);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(183, 96);
            this.radGroupBox2.TabIndex = 11;
            this.radGroupBox2.Text = "Manage Group";
            this.radGroupBox2.ThemeName = "TelerikMetroBlue";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.txtMenuName);
            this.radGroupBox3.Controls.Add(this.btnRename);
            this.radGroupBox3.FooterImageIndex = -1;
            this.radGroupBox3.FooterImageKey = "";
            this.radGroupBox3.HeaderImageIndex = -1;
            this.radGroupBox3.HeaderImageKey = "";
            this.radGroupBox3.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox3.HeaderText = "Rename Menu";
            this.radGroupBox3.Location = new System.Drawing.Point(210, 207);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox3.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox3.Size = new System.Drawing.Size(183, 96);
            this.radGroupBox3.TabIndex = 12;
            this.radGroupBox3.Text = "Rename Menu";
            this.radGroupBox3.ThemeName = "TelerikMetroBlue";
            // 
            // txtMenuName
            // 
            this.txtMenuName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMenuName.Location = new System.Drawing.Point(12, 30);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.NullText = "Input Menu Name";
            this.txtMenuName.Size = new System.Drawing.Size(156, 23);
            this.txtMenuName.TabIndex = 7;
            this.txtMenuName.TabStop = false;
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRename.Location = new System.Drawing.Point(12, 59);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(156, 25);
            this.btnRename.TabIndex = 6;
            this.btnRename.Text = "&Rename";
            this.btnRename.ThemeName = "Office2010Blue";
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDown.Location = new System.Drawing.Point(223, 341);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(156, 25);
            this.btnDown.TabIndex = 14;
            this.btnDown.Text = "Menu &Down";
            this.btnDown.ThemeName = "Office2010Blue";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUp.Location = new System.Drawing.Point(223, 310);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(156, 25);
            this.btnUp.TabIndex = 13;
            this.btnUp.Text = "Menu &Up";
            this.btnUp.ThemeName = "Office2010Blue";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // sfrmManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 464);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.radListControl1);
            this.Controls.Add(this.radTreeView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "sfrmManageMenu";
            this.Shape = this.roundRectShapeForm;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "sfrmMain";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.sfrmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.sfrmMain_DragDrop);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fingermachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMenuName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private fingermachDataSet fingermachDataSet;
        private System.Windows.Forms.BindingSource authBindingSource;
        private fingermachDataSetTableAdapters.authTableAdapter authTableAdapter;
        private Telerik.WinControls.UI.RadButton btnMove;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private System.Windows.Forms.BindingSource authBindingSource1;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadTextBox txtGroupName;
        private Telerik.WinControls.UI.RadListControl radListControl1;
        private Telerik.WinControls.UI.RadButton btnAddMenu;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadTextBox txtMenuName;
        private Telerik.WinControls.UI.RadButton btnRename;
        private Telerik.WinControls.UI.RadButton btnDown;
        private Telerik.WinControls.UI.RadButton btnUp;
    }
}
