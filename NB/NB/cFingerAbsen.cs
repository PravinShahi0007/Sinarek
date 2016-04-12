using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using zkemkeeper;

namespace NB
{
    public static class cFingerAbsen
    {

        public static bool TestConnectMachine(string IPAdd, int portNum, int iPass)
        {
            CZKEM mesinabsen = new CZKEM();
            mesinabsen.SetCommPassword(iPass);
            return mesinabsen.Connect_Net(IPAdd, portNum);
        }
        public static int GrabDataAbsen(string IPAdd, int portNum, int iPass,int machineNumber)
        {
            CZKEM mesinabsen = new CZKEM();
            int b=0,c=0,d=0,e=0,f=0,g=0,h=0,i=0,j=0,iCount = 0;
            mesinabsen.SetCommPassword(iPass);
            string a = "";
            //Only when connected successfully
            if (mesinabsen.Connect_Net(IPAdd, portNum))
            {
                //read all data and store in database
                using (fingermachDataSetTableAdapters.tdatafingerTableAdapter tbl = new fingermachDataSetTableAdapters.tdatafingerTableAdapter())
                {
                    while (mesinabsen.SSR_GetGeneralLogData(machineNumber, out a, out b, out c, out d, out e, out f, out g, out h, out i, ref j))
                    {
                        tbl.Replace(1,int.Parse(a),b,c,d,e,f,g,h,DateTime.Now);
                        iCount++;
                    }
                }
            }else
            {
                //Connection Exception
                throw (new Exception("Fail to connect to fingerprint machine."));
            }
            //clean data
            //mesinabsen.ClearGLog(machineNumber);

            //close connection
            mesinabsen.Disconnect();
            return iCount;
        }

        public static bool RegisterUserName(string IPAdd, int portNum, int iPass, int machineNumber, string enrollNum, string userName)
        {
            CZKEM mesinabsen = new CZKEM();
            mesinabsen.SetCommPassword(iPass);
            if (mesinabsen.Connect_Net(IPAdd, portNum))
            {
                mesinabsen.SSR_SetUserInfo(machineNumber, enrollNum, userName, null, 0, true);
            }
            {
                //Connection Exception
                throw (new Exception("Fail to connect to fingerprint machine."));
            }
            //close connection
            mesinabsen.Disconnect();
            return true;
        }
    }
}
