using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

using lihatgaji;
using Telerik.Reporting;
using Telerik.Reporting.Processing;
using System.Drawing.Printing;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace NB
{
    public partial class frmAbsenAll : Telerik.WinControls.UI.RadForm
    {
        private bool add_;
        private bool edit_;
        private bool delete_;
        public frmAbsenAll()
        {
            InitializeComponent();                  
        }

        private void frmAbsenSatpam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinarekDataSet.gajibulanan' table. You can move, or remove it, as needed.
            this.gajibulananTableAdapter.Fill(this.sinarekDataSet.gajibulanan);
            // TODO: This line of code loads data into the 'sinarekDataSet.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.sinarekDataSet.member);
            InitializeButtons();
            //SetDefaults();
            rddGBID.SelectedValue = NBConfig.IGBID;
            this.radScheduler1.AppointmentTitleFormat = "{2}";
        }
        private void SetUpScheduler()
        {
            //Get Total Penjualan Uptodate
            string sQuery = "Select Tanggal,Keterangan,a.tipehadirid ,t.nama "
                + " from AbsenaLL a "
                + " left join tipehadir t on a.tipehadirid = t.tipehadirid "
                +"Where memberid = " + rddMember.SelectedValue.ToString() 
                + " and (keterangan <> '' or a.tipehadirid <> 1)"
                + " and gbid = " + rddGBID.SelectedValue.ToString() ;
            MySqlDataAdapter adapt = new MySqlDataAdapter(sQuery
                , ConfigurationManager.ConnectionStrings["NB.Properties.Settings.sinarekConnectionString"].ConnectionString);

            DataTable dt = new DataTable("Data");
            adapt.Fill(dt);
            DataRowView row = (DataRowView)rddGBID.SelectedItem.DataBoundItem;
            radScheduler1.ActiveView.StartDate = DateTime.Parse(row["startdate"].ToString());
            radScheduler1.ActiveView.ReadOnly = true;
            radScheduler1.GetMonthView().ShowWeeksHeader = false;
            radScheduler1.GetMonthView().EnableWeeksHeader = false;
            radScheduler1.GetMonthView().WeekCount = 5;


            this.radScheduler1.Appointments.Clear();
            foreach (DataRow drow in dt.Rows)
            {
                //Create All day appointment
                //Appointment appointment = new Appointment(DateTime.Parse(row["tanggal"].ToString()).Date
                //    , TimeSpan.FromDays(1), row["keterangan"].ToString());
                if (drow["tipehadirid"].ToString() != "1")
                {
                    //Appointment appointment1 = new Appointment(DateTime.Parse(drow["tanggal"].ToString()).Date
                    //, TimeSpan.FromDays(1), drow["nama"].ToString());
                    Appointment appointment1 = new Appointment();
                    appointment1.AllDay = true;
                    appointment1.Start = DateTime.Parse(drow["tanggal"].ToString()).Date;
                    appointment1.End = DateTime.Parse(drow["tanggal"].ToString()).Date;
                    appointment1.StatusId = 3;
                    appointment1.BackgroundId = 4; //red color
                    appointment1.Summary = drow["nama"].ToString();                  
                    this.radScheduler1.Appointments.Add(appointment1);
                }
                if (!string.IsNullOrEmpty(drow["Keterangan"].ToString()))
                {
                    //Appointment appointment2 = new Appointment(DateTime.Parse(drow["tanggal"].ToString()).Date
                    //, TimeSpan.FromDays(1), drow["keterangan"].ToString());
                    Appointment appointment2 = new Appointment();
                    appointment2.AllDay = true;
                    appointment2.Start = DateTime.Parse(drow["tanggal"].ToString()).Date;
                    appointment2.End = DateTime.Parse(drow["tanggal"].ToString()).Date;
                    appointment2.StatusId = 1;
                    appointment2.BackgroundId = 7; //green color
                    appointment2.Summary = drow["keterangan"].ToString();   
                    this.radScheduler1.Appointments.Add(appointment2);
                    
                }                
            }

        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult res = RadMessageBox.Show("Print Absen Staff. Siap kan kertas di printer."
                              , "Print Absen Staff"
                              , MessageBoxButtons.OKCancel
                              , RadMessageIcon.Question
                              , MessageBoxDefaultButton.Button2);

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //Print Slip Gaji                
                rptAbsenOther ab = new rptAbsenOther();
                ab.ReportParameters[0].Value = "satpam";
                ab.ReportParameters[1].Value = rddGBID.SelectedValue;
                IReportDocument report1 = (IReportDocument)ab;
                ////set parameters when necessary

                //// PrinterSettings 
                PrinterSettings printerSettings = new PrinterSettings();
                //// Adjust the printer settings if necessary...

                InstanceReportSource reportSource = new InstanceReportSource();
                reportSource.ReportDocument = report1;

                // Print the report using the printer settings.
                ReportProcessor reportProcessor = new ReportProcessor();
                reportProcessor.PrintReport(reportSource, printerSettings);
                helper.PrintLog(this.GetType().Name, ab.Name, "Memberid : " + rddMember.Text + "; GBID:" + rddGBID.Text);
            }
        }

        private void rddGBID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddMember.SelectedValue != null && rddGBID.SelectedValue != null)
            {
                SetUpScheduler();
            }
        }

        private void InitializeButtons()
        {
            string frmName = this.GetType().Name;
            helper.GetPermissions(frmName, this.Tag.ToString(), out add_, out edit_, out delete_);

            btnPrint.Enabled = delete_;
            rddGBID.Enabled = delete_;
            rddMember.Enabled = add_;
        }

        private void rddMember_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rddMember.SelectedValue != null && rddGBID.SelectedValue != null)
            {
                SetUpScheduler();
            }
        }

    }
}
