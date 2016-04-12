namespace NB
{
    partial class rptGajiTHR
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptGajiTHR));
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter3 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter4 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataGMID = new Telerik.Reporting.SqlDataSource();
            this.sqlGaji = new Telerik.Reporting.SqlDataSource();
            this.nameGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.sqlGajiMingguan = new Telerik.Reporting.SqlDataSource();
            this.nameGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.nameGroup = new Telerik.Reporting.Group();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.total1DataTextBox = new Telerik.Reporting.TextBox();
            this.htmlTextBox1 = new Telerik.Reporting.HtmlTextBox();
            this.Gender = new Telerik.Reporting.Group();
            this.groupFooterSection1 = new Telerik.Reporting.GroupFooterSection();
            this.groupHeaderSection1 = new Telerik.Reporting.GroupHeaderSection();
            this.textBox2 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataGMID
            // 
            this.sqlDataGMID.ConnectionString = "lihatgaji.Properties.Settings.sinarekConnectionString";
            this.sqlDataGMID.Name = "sqlDataGMID";
            this.sqlDataGMID.SelectCommand = "Select * From GajiMingguan";
            // 
            // sqlGaji
            // 
            this.sqlGaji.ConnectionString = "lihatgaji.Properties.Settings.sinarekConnectionString";
            this.sqlGaji.Name = "sqlGaji";
            this.sqlGaji.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@tipepembayaranid", System.Data.DbType.Int32, "=Parameters.tipepembayaranid.Value"),
            new Telerik.Reporting.SqlDataSourceParameter("@templateid", System.Data.DbType.Int32, "=Parameters.templateid.Value"),
            new Telerik.Reporting.SqlDataSourceParameter("@tahun", System.Data.DbType.Int32, "=Parameters.tahun.Value")});
            this.sqlGaji.SelectCommand = resources.GetString("sqlGaji.SelectCommand");
            // 
            // nameGroupHeader
            // 
            this.nameGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.33591189980506897D);
            this.nameGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox8,
            this.textBox5});
            this.nameGroupHeader.Name = "nameGroupHeader";
            // 
            // textBox8
            // 
            this.textBox8.CanGrow = true;
            this.textBox8.Format = "{0:Rp # ##0.00 ; Rp (# ##0.00)}";
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.050000030547380447D), Telerik.Reporting.Drawing.Unit.Inch(0.085911907255649567D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0081753730773926D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox8.Style.Font.Bold = true;
            this.textBox8.Style.Font.Name = "Lucida Console";
            this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.textBox8.Style.Font.Underline = true;
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox8.StyleName = "Data";
            this.textBox8.Value = "= Fields.Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0582542419433594D), Telerik.Reporting.Drawing.Unit.Inch(0.085911907255649567D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.9302875995635986D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox5.Style.Font.Name = "Lucida Console";
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox5.StyleName = "PageInfo";
            this.textBox5.Value = "=\"THR TAHUN \" + Fields.tanggal.Year";
            // 
            // sqlGajiMingguan
            // 
            this.sqlGajiMingguan.ConnectionString = "lihatgaji.Properties.Settings.sinarekConnectionString";
            this.sqlGajiMingguan.Name = "sqlGajiMingguan";
            this.sqlGajiMingguan.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@GMID", System.Data.DbType.UInt32, "=Parameters.GMID.Value")});
            this.sqlGajiMingguan.SelectCommand = "Select StartDate , EndDate From GajiMingguan\r\nWhere GMID = @GMID";
            // 
            // nameGroupFooter
            // 
            this.nameGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(1.3037500381469727D);
            this.nameGroupFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox6,
            this.currentTimeTextBox,
            this.textBox10,
            this.textBox3,
            this.textBox4,
            this.textBox11,
            this.textBox1});
            this.nameGroupFooter.Name = "nameGroupFooter";
            this.nameGroupFooter.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.nameGroupFooter.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Dotted;
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6000003814697266D), Telerik.Reporting.Drawing.Unit.Inch(0.75000017881393433D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.388541579246521D), Telerik.Reporting.Drawing.Unit.Inch(0.24162738025188446D));
            this.textBox6.Style.Font.Bold = true;
            this.textBox6.Style.Font.Name = "Courier New";
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox6.Value = "(______________)";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.85132426023483276D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2645835876464844D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.currentTimeTextBox.Style.Font.Name = "Courier New";
            this.currentTimeTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "= \"Printed By \" + Parameters.User.Value + \" at \" + NOW()";
            // 
            // textBox10
            // 
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6000003814697266D), Telerik.Reporting.Drawing.Unit.Inch(0.450000137090683D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.388541579246521D), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985D));
            this.textBox10.Style.Font.Bold = false;
            this.textBox10.Style.Font.Name = "Lucida Console";
            this.textBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox10.Value = "TTD";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7000000476837158D), Telerik.Reporting.Drawing.Unit.Inch(0.14380931854248047D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.58541679382324219D), Telerik.Reporting.Drawing.Unit.Inch(0.24583323299884796D));
            this.textBox3.Style.Font.Bold = false;
            this.textBox3.Style.Font.Name = "Lucida Console";
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.Value = "Total";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Format = "{0:Rp #,##0.00 ; Rp (#,##0.00)}";
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.3489582538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.14380931854248047D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6395835876464844D), Telerik.Reporting.Drawing.Unit.Inch(0.21954889595508575D));
            this.textBox4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.Font.Bold = true;
            this.textBox4.Style.Font.Name = "Lucida Console";
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "= NB.rptGajiMingguan.GetBulat(Sum(Fields.Unit* Fields.unitvalue))";
            // 
            // textBox11
            // 
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.049999993294477463D), Telerik.Reporting.Drawing.Unit.Inch(0.2438092976808548D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985D));
            this.textBox11.Style.Font.Bold = false;
            this.textBox11.Style.Font.Name = "Lucida Console";
            this.textBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox11.Value = "Keterangan:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.049999993294477463D), Telerik.Reporting.Drawing.Unit.Inch(0.45132431387901306D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2354168891906738D), Telerik.Reporting.Drawing.Unit.Inch(0.34992107748985291D));
            this.textBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.Font.Name = "Lucida Console";
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            this.textBox1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0.05000000074505806D);
            this.textBox1.Value = "=IIf(Fields.KetTHR <> \"\", Fields.KetTHR + \", Mulai Kerja \" + Format(\"{0:dd MMM yy" +
    "}\", Fields.masukkerja.Date),\"\" )";
            // 
            // nameGroup
            // 
            this.nameGroup.GroupFooter = this.nameGroupFooter;
            this.nameGroup.GroupHeader = this.nameGroupHeader;
            this.nameGroup.Groupings.AddRange(new Telerik.Reporting.Grouping[] {
            new Telerik.Reporting.Grouping("=Fields.memberid")});
            this.nameGroup.GroupKeepTogether = Telerik.Reporting.GroupKeepTogether.All;
            this.nameGroup.Name = "nameGroup";
            this.nameGroup.Sortings.AddRange(new Telerik.Reporting.Sorting[] {
            new Telerik.Reporting.Sorting("=Fields.Name", Telerik.Reporting.SortDirection.Asc)});
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageInfoTextBox,
            this.textBox17});
            this.pageFooter.Name = "pageFooter";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9000003337860107D), Telerik.Reporting.Drawing.Unit.Inch(0.0416666679084301D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0374997854232788D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.pageInfoTextBox.Style.Font.Name = "Courier New";
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber + \" of \" + PageCount";
            // 
            // textBox17
            // 
            this.textBox17.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.049999993294477463D), Telerik.Reporting.Drawing.Unit.Inch(0.041666824370622635D));
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8187496662139893D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox17.Style.Font.Name = "Courier New";
            this.textBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox17.StyleName = "PageInfo";
            this.textBox17.Value = "= \"Printed By \" + Parameters.User.Value + \" at \" + NOW()";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40408802032470703D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.total1DataTextBox,
            this.htmlTextBox1});
            this.detail.Name = "detail";
            // 
            // total1DataTextBox
            // 
            this.total1DataTextBox.CanGrow = true;
            this.total1DataTextBox.Format = "{0:Rp #,##0.00 ; Rp (#,##0.00)}";
            this.total1DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.3489582538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.1020440086722374D));
            this.total1DataTextBox.Name = "total1DataTextBox";
            this.total1DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6395835876464844D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.total1DataTextBox.Style.Font.Name = "Lucida Console";
            this.total1DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.total1DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.total1DataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.total1DataTextBox.StyleName = "Data";
            this.total1DataTextBox.Value = "= Fields.Unit * Fields.UnitValue";
            // 
            // htmlTextBox1
            // 
            this.htmlTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.081852912902832031D));
            this.htmlTextBox1.Name = "htmlTextBox1";
            this.htmlTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2645835876464844D), Telerik.Reporting.Drawing.Unit.Inch(0.24038219451904297D));
            this.htmlTextBox1.Style.Font.Name = "Lucida Console";
            this.htmlTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.htmlTextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.htmlTextBox1.Value = "{Fields.nama}";
            // 
            // Gender
            // 
            this.Gender.GroupFooter = this.groupFooterSection1;
            this.Gender.GroupHeader = this.groupHeaderSection1;
            this.Gender.Groupings.AddRange(new Telerik.Reporting.Grouping[] {
            new Telerik.Reporting.Grouping("=Fields.gender")});
            this.Gender.GroupKeepTogether = Telerik.Reporting.GroupKeepTogether.All;
            this.Gender.Name = "Gender";
            // 
            // groupFooterSection1
            // 
            this.groupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699D);
            this.groupFooterSection1.Name = "groupFooterSection1";
            // 
            // groupHeaderSection1
            // 
            this.groupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.295911967754364D);
            this.groupHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox2});
            this.groupHeaderSection1.Name = "groupHeaderSection1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.049999993294477463D), Telerik.Reporting.Drawing.Unit.Inch(0.0416666679084301D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.9302875995635986D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox2.Style.Font.Name = "Lucida Console";
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox2.StyleName = "PageInfo";
            this.textBox2.Value = "=iif(Fields.gender = \"P\",\"Perempuan\",\"Laki-Laki\")";
            // 
            // rptGajiTHR
            // 
            this.DataSource = this.sqlGaji;
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            this.Gender,
            this.nameGroup});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.groupHeaderSection1,
            this.groupFooterSection1,
            this.nameGroupHeader,
            this.nameGroupFooter,
            this.pageFooter,
            this.detail});
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(0.17000000178813934D);
            this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11999999731779099D);
            this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(0.11999999731779099D);
            this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Inch(0.18000000715255737D);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PageSettings.PaperSize = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.3999996185302734D), Telerik.Reporting.Drawing.Unit.Inch(5.5D));
            reportParameter1.Name = "User";
            reportParameter1.Text = "Admin";
            reportParameter1.Value = "Admin";
            reportParameter2.Name = "templateid";
            reportParameter2.Text = "templateid";
            reportParameter2.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter2.Value = "-2";
            reportParameter2.Visible = true;
            reportParameter3.Name = "tipepembayaranid";
            reportParameter3.Text = "tipepembayaranid";
            reportParameter3.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter3.Value = "4";
            reportParameter3.Visible = true;
            reportParameter4.Name = "tahun";
            reportParameter4.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter4.Value = "2013";
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            this.ReportParameters.Add(reportParameter3);
            this.ReportParameters.Add(reportParameter4);
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule1.Style.Color = System.Drawing.Color.Black;
            styleRule1.Style.Font.Bold = true;
            styleRule1.Style.Font.Italic = false;
            styleRule1.Style.Font.Name = "Tahoma";
            styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(20D);
            styleRule1.Style.Font.Strikeout = false;
            styleRule1.Style.Font.Underline = false;
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule2.Style.Color = System.Drawing.Color.Black;
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(5D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlGaji;
        private Telerik.Reporting.GroupHeaderSection nameGroupHeader;
        private Telerik.Reporting.GroupFooterSection nameGroupFooter;
        private Telerik.Reporting.Group nameGroup;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox total1DataTextBox;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.Group Gender;
        private Telerik.Reporting.GroupFooterSection groupFooterSection1;
        private Telerik.Reporting.GroupHeaderSection groupHeaderSection1;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.SqlDataSource sqlGajiMingguan;
        private Telerik.Reporting.SqlDataSource sqlDataGMID;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.HtmlTextBox htmlTextBox1;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;

    }
}