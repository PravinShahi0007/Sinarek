using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Reporting;
using Telerik.Reporting.Processing;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace NB
{
    public partial class frmBotolKotor : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool edit_;
        private bool delete_;

        public frmBotolKotor()
        {
            InitializeComponent();
        }
        #region "Methods"
        private void SetConditions()
        {
            ConditionalFormattingObject c1 = new ConditionalFormattingObject("Light Sea Green, applied to entire row", ConditionTypes.Less, "0", "", true);
            c1.RowBackColor = Color.LawnGreen;
            radGridView1.Columns["K100"].ConditionalFormattingObjectList.Add(c1);
            ConditionalFormattingObject c3 = new ConditionalFormattingObject("Light Sea Green, applied to entire row", ConditionTypes.Less, "0", "", true);
            c3.RowBackColor = Color.LawnGreen;
            radGridView1.Columns["K98"].ConditionalFormattingObjectList.Add(c3);
            //Pecah
            ConditionalFormattingObject c2 = new ConditionalFormattingObject("Light Sea Green, applied to cell only", ConditionTypes.Greater, "0", "", false);
            c2.CellBackColor = Color.LightCoral;
            radGridView1.Columns["PECAH"].ConditionalFormattingObjectList.Add(c2);
            //Sumbing
            ConditionalFormattingObject c4 = new ConditionalFormattingObject("Corn Flower Blue, applied to cell only", ConditionTypes.Greater, "0", "", false);
            c4.CellBackColor = Color.CornflowerBlue;
            radGridView1.Columns["SUMBING"].ConditionalFormattingObjectList.Add(c4);
            //Total
            ConditionalFormattingObject c5 = new ConditionalFormattingObject("Corn Flower Blue, applied to cell only", ConditionTypes.Greater, "0", "", false);
            c5.CellBackColor = Color.LightBlue;
            radGridView2.Columns["Total"].ConditionalFormattingObjectList.Add(c5);
           
        }
        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            add_ = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "add");
            edit_ = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "edit");
            delete_ = NBConfig.CheckPermission((this.Tag != null ? this.Tag.ToString() : ""), frmName, "delete");

            dtpTanggal.Enabled = delete_;
        }
        private void RefreshAll()
        {
            this.radGridView1.SummaryRowsBottom.Clear();
            // TODO: This line of code loads data into the 'sinarekDataSet.vbotolkotor' table. You can move, or remove it, as needed.
            this.vbotolkotorTableAdapter.FillByTanggal(this.sinarekDataSet.vbotolkotor, dtpTanggal.Value);
            sinarekDataSet.vbotolkotorDataTable tbl = new sinarekDataSet.vbotolkotorDataTable();
            this.vbotolkotorTableAdapter.FillByTipeTanggal(tbl, dtpTanggal.Value, "AWAL");
            radGridView2.DataSource = tbl;

            if (radGridView2.Rows.Count == 1 && radGridView1.Rows.Count > 0)
            {
                string K100, K99, K98, K16, BTL, Total;
                K100 = radGridView2.Rows[0].Cells["K100"].Value.ToString();
                K99 = radGridView2.Rows[0].Cells["K99"].Value.ToString();
                K98 = radGridView2.Rows[0].Cells["K98"].Value.ToString();
                K16 = radGridView2.Rows[0].Cells["K16"].Value.ToString();
                BTL = radGridView2.Rows[0].Cells["BTL"].Value.ToString();
                Total = radGridView2.Rows[0].Cells["Total"].Value.ToString();
                GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
                GridViewSummaryItem summaryItem = new GridViewSummaryItem();
                summaryItem.Name = "K100";
                summaryItem.FormatString = "{0:#,###}";
                summaryItem.AggregateExpression = K100.ToString() + " + Sum(K100)";
                summaryRowItem.Add(summaryItem);
                GridViewSummaryItem summaryItem2 = new GridViewSummaryItem();
                summaryItem2.Name = "K98";
                summaryItem2.FormatString = "{0:#,###}";
                summaryItem2.AggregateExpression = K98.ToString() + " + Sum(K99) + Sum(K98)";
                summaryRowItem.Add(summaryItem2);                
                GridViewSummaryItem summaryItem9 = new GridViewSummaryItem();
                summaryItem9.Name = "K16";
                summaryItem9.FormatString = "{0:#,###}";
                summaryItem9.AggregateExpression = "("+ K16 + "*16) + " + " Sum(K16*16) + Sum(BTL) + " + BTL;
                summaryRowItem.Add(summaryItem9);
                GridViewSummaryItem summaryItem4 = new GridViewSummaryItem();
                summaryItem4.Name = "BTL";
                summaryItem4.AggregateExpression = "0";
                summaryRowItem.Add(summaryItem4);
                GridViewSummaryItem summaryItem5 = new GridViewSummaryItem();
                summaryItem5.Name = "NoSJ";
                summaryItem5.Aggregate = GridAggregateFunction.Last;
                summaryItem5.FormatString = "AKHIR";
                summaryRowItem.Add(summaryItem5);
                GridViewSummaryItem summaryItem8 = new GridViewSummaryItem();
                summaryItem8.Name = "Total";
                summaryItem8.Aggregate = GridAggregateFunction.Sum;
                summaryItem8.FormatString = "{0:#,###}";
                summaryRowItem.Add(summaryItem8);
                this.radGridView1.SummaryRowsBottom.Add(summaryRowItem);

                int val = 0
                    , div = 0
                    , rem = 0;
                try
                {
                    GridViewSummaryItem summaryItem3 = radGridView1.SummaryRowsBottom[0][2];
                    string value = summaryItem3.Evaluate(radGridView1.MasterTemplate).ToString();
                    val = int.Parse(value.Split('.')[0]);
                    div = Math.DivRem(val, 16, out rem);
                    summaryItem3.AggregateExpression = div.ToString();
                    summaryItem4.AggregateExpression = rem.ToString();
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(ex.Message + " : " + ex.StackTrace, "SMS - Error");
                }

                GridViewSummaryRowItem summaryRowItem2 = new GridViewSummaryRowItem();
                GridViewSummaryItem summaryItem6 = new GridViewSummaryItem();
                summaryItem6.Name = "K100";
                summaryItem6.AggregateExpression = Total + " + ((Sum(K100)*100)"
                    + " + ((Sum(K99) + Sum(K98))* 98)"
                    + " + (Sum(K16)*16)"
                    + " + Sum(BTL))";
                summaryItem6.FormatString = "{0:#,###}";
                summaryRowItem2.Add(summaryItem6);
                GridViewSummaryItem summaryItem7 = new GridViewSummaryItem();
                summaryItem7.Name = "NoSJ";
                summaryItem7.Aggregate = GridAggregateFunction.Last;
                summaryItem7.FormatString = "TOTAL BTL :";
                summaryRowItem2.Add(summaryItem7);
                this.radGridView1.SummaryRowsBottom.Add(summaryRowItem2);
            }

        }
        #endregion
        #region "Control Events"
        private void frmBotolKotor_Load(object sender, EventArgs e)
        {
            //Check if AWAL for the current date has been created if not the create
            InitializeButtons();
            SetConditions();
            dtpTanggal.Value = DateTime.Now;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //TODO: After print update total in db
            //If total existed then delete and insert new one
            DialogResult res = RadMessageBox.Show("Siapkan kertas untuk print.", "SMS - Verification"
                , MessageBoxButtons.OKCancel
                , RadMessageIcon.Question);
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                PrinterSettings printerSettings;
                ReportProcessor reportProcessor;

                rptBotolKotor rpt = new rptBotolKotor();
                rpt.ReportParameters["user"].Value = NBConfig.ValidUserName;
                rpt.ReportParameters["tanggal"].Value = dtpTanggal.Value;
                //rpt.ReportParameters["custtypetoid"].Value = custtypetoid;

                IReportDocument iRpt = (IReportDocument)rpt;
                //// PrinterSettings 
                printerSettings = new PrinterSettings();

                try
                {
                    InstanceReportSource reportSource = new InstanceReportSource();
                    reportSource.ReportDocument = iRpt;

                    reportProcessor = new ReportProcessor();
                    reportProcessor.PrintReport(reportSource, printerSettings);
                    helper.PrintLog(this.GetType().Name, rpt.Name, this.Text + ":tanggal-" + dtpTanggal.Value.ToString());
                }
                catch (Exception ex)
                {
                    helper.ErrorMessage(ex.Message);
                }


                sinarekDataSet.productbaseDataTable dt = new sinarekDataSet.productbaseDataTable();
                using (sinarekDataSetTableAdapters.productbaseTableAdapter tbl = new sinarekDataSetTableAdapters.productbaseTableAdapter())
                {
                    tbl.Fill(dt);
                }

                using (sinarekDataSetTableAdapters.producttotalTableAdapter tbl = new sinarekDataSetTableAdapters.producttotalTableAdapter())
                {
                    foreach (GridViewSummaryItem item in radGridView1.SummaryRowsBottom[0])
                    {
                        if (item.Name != "NoSJ" && item.Name != "Total")
                        {
                            string baseid = dt.Select("productshort = 'BK' and unitshort = '" + item.Name + "'")[0]["baseid"].ToString();
                            string obj = item.Evaluate(radGridView1.MasterTemplate).ToString();
                            tbl.InsertProductTotal(dtpTanggal.Value
                                                    , ""
                                                    , "AKHIR"
                                                    , ""
                                                    , int.Parse(baseid)
                                                    , decimal.Parse(obj)
                                                    , "", NBConfig.ValidUserName);
                        }

                    }
                }
            }
        }
        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            RefreshAll();
        }
        private void InsertOtherTotal(string custType_,int Quantity)
        {
            int K16, BTL;
            string baseid;
            
            sinarekDataSet.productbaseDataTable dt = new sinarekDataSet.productbaseDataTable();
            using (sinarekDataSetTableAdapters.productbaseTableAdapter tbl = new sinarekDataSetTableAdapters.productbaseTableAdapter())
            {
                tbl.Fill(dt);
            }
            using (sinarekDataSetTableAdapters.producttotalTableAdapter tbl = new sinarekDataSetTableAdapters.producttotalTableAdapter())
            {
                switch (custType_.ToLower())
                {
                    case "jadi":
                        baseid = dt.Select("productshort = 'BK'and unitshort = 'K100'")[0]["Baseid"].ToString();
                        K16 = Math.DivRem((Quantity*100),16,out BTL); 
                        tbl.InsertProductTotal(dtpTanggal.Value
                            ,"","JADI KARUNG","",int.Parse(baseid),Quantity,"",NBConfig.ValidUserName);
                        baseid = dt.Select("productshort = 'BK' and unitshort = 'K16'")[0]["Baseid"].ToString();
                        tbl.InsertProductTotal(dtpTanggal.Value
                            , "", "JADI KARUNG", "", int.Parse(baseid), -1 * K16, "", NBConfig.ValidUserName);
                        baseid = dt.Select("productshort = 'BK' and unitshort = 'BTL'")[0]["Baseid"].ToString();
                        tbl.InsertProductTotal(dtpTanggal.Value
                            , "", "JADI KARUNG", "", int.Parse(baseid), -1 * BTL, "", NBConfig.ValidUserName);
                        break;
                    case "rusak":
                        K16 = Math.DivRem(Quantity,16,out BTL);
                        baseid = dt.Select("productshort = 'BK' and unitshort = 'K16'")[0]["Baseid"].ToString();
                        tbl.InsertProductTotal(dtpTanggal.Value
                            ,"","BARANG RUSAK","",int.Parse(baseid),K16,"",NBConfig.ValidUserName);
                        baseid = dt.Select("productshort = 'BK' and unitshort = 'BTL'")[0]["Baseid"].ToString();
                        tbl.InsertProductTotal(dtpTanggal.Value
                            ,"","BARANG RUSAK","",int.Parse(baseid),BTL,"",NBConfig.ValidUserName);
                        break;
                }
            }
        }
        private void btnJadi_Click(object sender, EventArgs e)
        {
            InsertOtherTotal("Jadi", int.Parse(txtJadi.Value.ToString()));
            txtJadi.ResetText();
            RefreshAll();
        }
        private void btnRusakMasuk_Click(object sender, EventArgs e)
        {
            InsertOtherTotal("Rusak", int.Parse(txtRusak.Value.ToString()));
            txtRusak.ResetText();
            RefreshAll();
        }
        #endregion
    }
}
