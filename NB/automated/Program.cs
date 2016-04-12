using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Odbc;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

using lihatinventory;
using Telerik.Reporting;
using Telerik.Reporting.Processing;

namespace automated
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"\\sinarekserver\forms\reports\";
            string source = @"C:\Users\VINA\Desktop\sinar";
            string ip = "196.10.0.75";
            foreach (string arg in args)
            {
                string sArg = arg.Split('=')[0];
                string sVal = arg.Split('=')[1];
                ////-S - Source
                ////-D - Report Destination
                ////-I - Ip
                switch (sArg.ToLower())
                {
                    case "-s":
                        source = sVal;
                        break;
                    case "-d":
                        path = sVal;
                        break;
                    case "-i":
                        ip = sVal;
                        break;
                }
            }
            UpdateDataGUDA(DateTime.Now, source, ip);
            UpdateDataHIST(DateTime.Now, source, ip);
            //UpdateDataGUDA(DateTime.Now.AddMonths(-1), source, ip);
            //UpdateDataHIST(DateTime.Now.AddMonths(-1), source, ip);
            UpdateDataGUDA(DateTime.Now.AddMonths(-2), source, ip);
            UpdateDataHIST(DateTime.Now.AddMonths(-2), source, ip);
            //CreateReport(path);          
            
        }
        static void UpdateDataHIST(DateTime tgl, string sourcePath, string ip)
        {
            //Update to the latest data
            OdbcDataAdapter adapter = new OdbcDataAdapter(@"Select * From Hist" + tgl.ToString("MMyy"),
                @"Driver={Microsoft dBase Driver (*.DBF)};Driver ID=277;Dbq=" + sourcePath);
            MySqlConnection conn = new MySqlConnection("Server =" + ip + "; Database=Sinar;Uid=reader;Pwd=r3ader");
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Hist", conn);
            MySqlCommand ins = new MySqlCommand("INSERT INTO `hist`(`GUDANG`, `PRODUKSI`, `VIA`, `KODE`"
                                            + ", `NAMA`, `SATUAN`, `MASUK`, `KELUAR`, `HARGA`, `TGL`, `LANG`"
                                            + ", `NLANG`, `ALM`, `TLP`, `KOTA`, `HARI`, `NOTA`, `KA`, `MSEMUA`"
                                            + ", `DISC`, `NDISC`, `DISC2`, `NDISC2`, `DISC3`, `NDISC3`, `KB`"
                                            + ", `KEDIT`, `SUPP`, `EXP`, `KS`, `MODAL`, `SATUAN2`, `SATUAN3`"
                                            + ", `C`, `K`, `SALES`, `SUPPLANG`, `KET`, `DIS2`, `DIS3`, `MERK`"
                                            + ", `KETERANGAN`, `MSEMUA2`, `KE`, `KANVAS`, `QTYKANVAS`, `RPKANVAS`"
                                            + ", `QTYK`, `QTYC`, `T`, `BUAT`, `TANGGAL`, `SLS`) "
                                            + "Values (GUDANG,?PRODUKSI,?VIA,?KODE"
                                            + ",?NAMA,?SATUAN,?MASUK,?KELUAR,?HARGA,?TGL,?LANG"
                                            + ",?NLANG,?ALM,?TLP,?KOTA,?HARI,?NOTA,?KA,?MSEMUA"
                                            + ",?DISC,?NDISC,?DISC2,?NDISC2,?DISC3,?NDISC3,?KB"
                                            + ",?KEDIT,?SUPP,?EXP,?KS,?MODAL,?SATUAN2,?SATUAN3"
                                            + ",?C,?K,?SALES,?SUPPLANG,?KET,?DIS2,?DIS3,?MERK"
                                            + ",?KETERANGAN,?MSEMUA2,?KE,?KANVAS,?QTYKANVAS,?RPKANVAS"
                                            + ",?QTYK,?QTYC,?T,?BUAT,?TANGGAL,?SLS)", conn);
            da.InsertCommand = ins;

            ins.UpdatedRowSource = System.Data.UpdateRowSource.None;
            ins.Parameters.Add("?GUDANG", MySqlDbType.VarChar, 200).SourceColumn = "GUDANG";
            ins.Parameters.Add("?PRODUKSI", MySqlDbType.VarChar, 200).SourceColumn = "PRODUKSI";
            ins.Parameters.Add("?VIA", MySqlDbType.VarChar, 200).SourceColumn = "VIA";
            ins.Parameters.Add("?KODE", MySqlDbType.VarChar, 200).SourceColumn = "KODE";
            ins.Parameters.Add("?NAMA", MySqlDbType.VarChar, 200).SourceColumn = "NAMA";
            ins.Parameters.Add("?SATUAN", MySqlDbType.VarChar, 200).SourceColumn = "SATUAN";
            ins.Parameters.Add("?MASUK", MySqlDbType.Double).SourceColumn = "MASUK";
            ins.Parameters.Add("?KELUAR", MySqlDbType.Double).SourceColumn = "KELUAR";
            ins.Parameters.Add("?HARGA", MySqlDbType.Double).SourceColumn = "HARGA";
            ins.Parameters.Add("?TGL", MySqlDbType.Date).SourceColumn = "TGL";
            ins.Parameters.Add("?LANG", MySqlDbType.VarChar, 200).SourceColumn = "LANG";
            ins.Parameters.Add("?NLANG", MySqlDbType.VarChar, 200).SourceColumn = "NLANG";
            ins.Parameters.Add("?ALM", MySqlDbType.VarChar, 200).SourceColumn = "ALM";
            ins.Parameters.Add("?TLP", MySqlDbType.VarChar, 200).SourceColumn = "TLP";
            ins.Parameters.Add("?KOTA", MySqlDbType.VarChar, 200).SourceColumn = "KOTA";
            ins.Parameters.Add("?HARI", MySqlDbType.VarChar, 200).SourceColumn = "HARI";
            ins.Parameters.Add("?NOTA", MySqlDbType.VarChar, 200).SourceColumn = "NOTA";
            ins.Parameters.Add("?KA", MySqlDbType.VarChar, 200).SourceColumn = "KA";
            ins.Parameters.Add("?MSEMUA", MySqlDbType.VarChar, 200).SourceColumn = "MSEMUA";
            ins.Parameters.Add("?DISC", MySqlDbType.Double).SourceColumn = "DISC";
            ins.Parameters.Add("?NDISC", MySqlDbType.Double).SourceColumn = "NDISC";
            ins.Parameters.Add("?DISC2", MySqlDbType.Double).SourceColumn = "DISC2";
            ins.Parameters.Add("?NDISC2", MySqlDbType.Double).SourceColumn = "NDISC2";
            ins.Parameters.Add("?DISC3", MySqlDbType.Double).SourceColumn = "DISC3";
            ins.Parameters.Add("?NDISC3", MySqlDbType.Double).SourceColumn = "NDISC3";
            ins.Parameters.Add("?KB", MySqlDbType.VarChar, 200).SourceColumn = "KB";
            ins.Parameters.Add("?KEDIT", MySqlDbType.VarChar, 200).SourceColumn = "KEDIT";
            ins.Parameters.Add("?SUPP", MySqlDbType.VarChar, 200).SourceColumn = "SUPP";
            ins.Parameters.Add("?EXP", MySqlDbType.VarChar, 200).SourceColumn = "EXP";
            ins.Parameters.Add("?KS", MySqlDbType.VarChar, 200).SourceColumn = "KS";
            ins.Parameters.Add("?MODAL", MySqlDbType.Double, 200).SourceColumn = "MODAL";
            ins.Parameters.Add("?SATUAN2", MySqlDbType.VarChar, 200).SourceColumn = "SATUAN2";
            ins.Parameters.Add("?SATUAN3", MySqlDbType.VarChar, 200).SourceColumn = "SATUAN3";
            ins.Parameters.Add("?C", MySqlDbType.Double).SourceColumn = "C";
            ins.Parameters.Add("?K", MySqlDbType.Double).SourceColumn = "K";
            ins.Parameters.Add("?SALES", MySqlDbType.VarChar, 200).SourceColumn = "SALES";
            ins.Parameters.Add("?SUPPLANG", MySqlDbType.VarChar, 200).SourceColumn = "SUPPLANG";
            ins.Parameters.Add("?KET", MySqlDbType.VarChar, 200).SourceColumn = "KET";
            ins.Parameters.Add("?DIS2", MySqlDbType.Double).SourceColumn = "DIS2";
            ins.Parameters.Add("?DIS3", MySqlDbType.Double).SourceColumn = "DIS3";
            ins.Parameters.Add("?MERK", MySqlDbType.VarChar, 200).SourceColumn = "MERK";
            ins.Parameters.Add("?KETERANGAN", MySqlDbType.VarChar, 200).SourceColumn = "KETERANGAN";
            ins.Parameters.Add("?MSEMUA2", MySqlDbType.VarChar, 200).SourceColumn = "MSEMUA2";
            ins.Parameters.Add("?KE", MySqlDbType.VarChar, 200).SourceColumn = "KE";
            ins.Parameters.Add("?KANVAS", MySqlDbType.VarChar, 200).SourceColumn = "KANVAS";
            ins.Parameters.Add("?QTYKANVAS", MySqlDbType.Double).SourceColumn = "QTYKANVAS";
            ins.Parameters.Add("?RPKANVAS", MySqlDbType.Double).SourceColumn = "RPKANVAS";
            ins.Parameters.Add("?QTYK", MySqlDbType.Double).SourceColumn = "QTYK";
            ins.Parameters.Add("?QTYC", MySqlDbType.Double).SourceColumn = "QTYC";
            ins.Parameters.Add("?T", MySqlDbType.VarChar, 200).SourceColumn = "T";
            ins.Parameters.Add("?BUAT", MySqlDbType.VarChar, 200).SourceColumn = "BUAT";
            ins.Parameters.Add("?TANGGAL", MySqlDbType.Date).SourceColumn = "TANGGAL";
            ins.Parameters.Add("?SLS", MySqlDbType.VarChar, 200).SourceColumn = "SLS";


            //Always Refresh Data Per Bulan
            MySqlCommand cmd = new MySqlCommand("Delete From hist Where Month(TGL)=" + tgl.ToString("MM")
                                                    + " and Year(TGL) = " + tgl.ToString("yyyy"));
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTable dtAdd = new DataTable();
            adapter.Fill(dtAdd);

            foreach (DataRow row in dtAdd.Rows)
            {
                row.SetAdded();
            }

            da.UpdateBatchSize = 1000;
            da.Update(dtAdd);
        }
        static void UpdateDataGUDA(DateTime tgl, string sourcePath,string ip)
        {
            //Update to the latest data
            OdbcDataAdapter adapter = new OdbcDataAdapter(@"Select * From GUDA" + tgl.ToString("MMyy"),
                @"Driver={Microsoft dBase Driver (*.DBF)};Driver ID=277;Dbq=" + sourcePath);
            MySqlConnection conn = new MySqlConnection("Server =" + ip + "; Database=Sinar;Uid=reader;Pwd=r3ader");
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM GUDA", conn);
            MySqlCommand ins = new MySqlCommand("INSERT INTO `guda`(`GUDANG`, `KODE`, `NAMA`, `SATUAN`, "
                + "`MASUK`, `KELUAR`, `HARGA`, `TGL`, `LANG`, `NLANG`, `ALM`, `TLP`, `KOTA`, `HARI`, `NOTA`, "
                + "`KA`, `MSEMUA`, `DISC`, `NDISC`, `DISC2`, `NDISC2`, `DISC3`, `NDISC3`, `KB`, `EXPEDISI`, `KS`, "
                + "`MODAL`, `SATUAN2`, `SATUAN3`, `C`, `K`, `SALES`, `KET`, `MERK`, `KETERANGAN`, `MSEMUA2`, `KE`, `VIA`, "
                + "`KET2`, `KET3`, `KET4`, `KET5`, `SOPIR`, `KERNET`) "
                + "VALUES (?GUDANG,?KODE,?NAMA,?SATUAN,?"
                + "MASUK,?KELUAR,?HARGA,?TGL,?LANG,?NLANG,?ALM,?TLP,?KOTA,?HARI,?NOTA,?"
                + "KA,?MSEMUA,?DISC,?NDISC,?DISC2,?NDISC2,?DISC3,?NDISC3,?KB,?EXPEDISI,?KS,?"
                + "MODAL,?SATUAN2,?SATUAN3,?C,?K,?SALES,?KET,?MERK,?KETERANGAN,?MSEMUA2,?KE,?VIA,?"
                + "KET2,?KET3,?KET4,?KET5,?SOPIR,?KERNET) ", conn);
            da.InsertCommand = ins;

            ins.UpdatedRowSource = System.Data.UpdateRowSource.None;
            ins.Parameters.Add("?GUDANG", MySqlDbType.VarChar, 200).SourceColumn = "GUDANG";
            ins.Parameters.Add("?KODE", MySqlDbType.VarChar, 200).SourceColumn = "KODE";
            ins.Parameters.Add("?NAMA", MySqlDbType.VarChar, 200).SourceColumn = "NAMA";
            ins.Parameters.Add("?SATUAN", MySqlDbType.VarChar, 200).SourceColumn = "SATUAN";
            ins.Parameters.Add("?MASUK", MySqlDbType.Double).SourceColumn = "MASUK";
            ins.Parameters.Add("?KELUAR", MySqlDbType.Double).SourceColumn = "KELUAR";
            ins.Parameters.Add("?HARGA", MySqlDbType.Double).SourceColumn = "HARGA";
            ins.Parameters.Add("?TGL", MySqlDbType.Date).SourceColumn = "TGL";
            ins.Parameters.Add("?LANG", MySqlDbType.VarChar, 200).SourceColumn = "LANG";
            ins.Parameters.Add("?NLANG", MySqlDbType.VarChar, 200).SourceColumn = "NLANG";
            ins.Parameters.Add("?ALM", MySqlDbType.VarChar, 200).SourceColumn = "ALM";
            ins.Parameters.Add("?TLP", MySqlDbType.VarChar, 200).SourceColumn = "TLP";
            ins.Parameters.Add("?KOTA", MySqlDbType.VarChar, 200).SourceColumn = "KOTA";
            ins.Parameters.Add("?HARI", MySqlDbType.VarChar, 200).SourceColumn = "HARI";
            ins.Parameters.Add("?NOTA", MySqlDbType.VarChar, 200).SourceColumn = "NOTA";
            ins.Parameters.Add("?KA", MySqlDbType.VarChar, 200).SourceColumn = "KA";
            ins.Parameters.Add("?MSEMUA", MySqlDbType.VarChar, 200).SourceColumn = "MSEMUA";
            ins.Parameters.Add("?DISC", MySqlDbType.Double).SourceColumn = "DISC";
            ins.Parameters.Add("?NDISC", MySqlDbType.Double).SourceColumn = "NDISC";
            ins.Parameters.Add("?DISC2", MySqlDbType.Double).SourceColumn = "DISC2";
            ins.Parameters.Add("?NDISC2", MySqlDbType.Double).SourceColumn = "NDISC2";
            ins.Parameters.Add("?DISC3", MySqlDbType.Double).SourceColumn = "DISC3";
            ins.Parameters.Add("?NDISC3", MySqlDbType.Double).SourceColumn = "NDISC3";
            ins.Parameters.Add("?KB", MySqlDbType.VarChar, 200).SourceColumn = "KB";
            ins.Parameters.Add("?EXPEDISI", MySqlDbType.VarChar, 200).SourceColumn = "EXPEDISI";
            ins.Parameters.Add("?KS", MySqlDbType.VarChar, 200).SourceColumn = "KS";
            ins.Parameters.Add("?MODAL", MySqlDbType.VarChar, 200).SourceColumn = "MODAL";
            ins.Parameters.Add("?SATUAN2", MySqlDbType.VarChar, 200).SourceColumn = "SATUAN2";
            ins.Parameters.Add("?SATUAN3", MySqlDbType.VarChar, 200).SourceColumn = "SATUAN3";
            ins.Parameters.Add("?C", MySqlDbType.Double).SourceColumn = "C";
            ins.Parameters.Add("?K", MySqlDbType.Double).SourceColumn = "K";
            ins.Parameters.Add("?SALES", MySqlDbType.VarChar, 200).SourceColumn = "SALES";
            ins.Parameters.Add("?KET", MySqlDbType.VarChar, 200).SourceColumn = "KET";
            ins.Parameters.Add("?MERK", MySqlDbType.VarChar, 200).SourceColumn = "MERK";
            ins.Parameters.Add("?KETERANGAN", MySqlDbType.VarChar, 200).SourceColumn = "KETERANGAN";
            ins.Parameters.Add("?MSEMUA2", MySqlDbType.VarChar, 200).SourceColumn = "MSEMUA2";
            ins.Parameters.Add("?KE", MySqlDbType.VarChar, 200).SourceColumn = "KE";
            ins.Parameters.Add("?VIA", MySqlDbType.VarChar, 200).SourceColumn = "VIA";
            ins.Parameters.Add("?KET2", MySqlDbType.VarChar, 200).SourceColumn = "KET2";
            ins.Parameters.Add("?KET3", MySqlDbType.VarChar, 200).SourceColumn = "KET3";
            ins.Parameters.Add("?KET4", MySqlDbType.VarChar, 200).SourceColumn = "KET4";
            ins.Parameters.Add("?KET5", MySqlDbType.VarChar, 200).SourceColumn = "KET5";
            ins.Parameters.Add("?SOPIR", MySqlDbType.VarChar, 200).SourceColumn = "SOPIR";
            ins.Parameters.Add("?KERNET", MySqlDbType.VarChar, 200).SourceColumn = "KERNET";

            //Always Refresh Data Per Bulan
            MySqlCommand cmd = new MySqlCommand("Delete From GUDA Where Month(TGL)=" + tgl.ToString("MM")
                                                    + " and Year(TGL) = " + tgl.ToString("yyyy"));
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTable dtAdd = new DataTable();
            adapter.Fill(dtAdd);

            foreach (DataRow row in dtAdd.Rows)
            {
                row.SetAdded();
            }

            da.UpdateBatchSize = 1000;
            da.Update(dtAdd);
        }
        static void CreateReport(string ReportPath)
        {
            Telerik.Reporting.Processing.ReportProcessor reportProcessor = new Telerik.Reporting.Processing.ReportProcessor();
            //set any deviceInfo settings if necessary
            System.Collections.Hashtable deviceInfo = new System.Collections.Hashtable();
            rptBarangKeluarTabel rpt1 = new rptBarangKeluarTabel();
            //SqlDataSource ds = (SqlDataSource)rpt1.DataSource;
            //ds.SelectCommand = "";             
            rpt1.ReportParameters[0].Value = DateTime.Now;
            //gj.ReportParameters["User"].Value = NBConfig.ValidUserName;
            IReportDocument report1 = (IReportDocument)rpt1;

            InstanceReportSource reportSource = new InstanceReportSource();
            reportSource.ReportDocument = report1;

            Telerik.Reporting.Processing.RenderingResult result = reportProcessor.RenderReport("XLS", reportSource, deviceInfo);
            string fileName = "SURATJALAN_" + DateTime.Now.ToString("ddMMMyy") + "." + result.Extension;
            
            string filePath = System.IO.Path.Combine(ReportPath, fileName);
            using (System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            }
        }

    }
}
