Imports zkemkeeper
Imports MySql
Imports MySql.Data
Imports MySql.Data.MySqlClient

Imports System.Configuration

Namespace AutoGrab
    Public Class Form1
        Public config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
            Dim oAbsen As cFPFUnctions = New cFPFUnctions()
            oAbsen.IPADDRESS = "196.10.0.200"
            oAbsen.PORT = 4370
            Dim oCom As MySqlCommand = New MySqlCommand()

            oCom.Connection = New MySqlConnection(ConfigurationManager.ConnectionStrings("fingermachConnectionString").ConnectionString)
            ListBox1.Items.Add("Get Data From Finger Machine at " & DateAndTime.Now)
            oAbsen.getData(oCom)
            ListBox1.Items.Add("Completed at " & DateAndTime.Now)
        End Sub

        Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
            Dim oAbsen As cFPFUnctions = New cFPFUnctions()
            oAbsen.IPADDRESS = "196.10.0.200"
            oAbsen.PORT = 4370
            Dim oCom As MySqlCommand = New MySqlCommand()

            oCom.Connection = New MySqlConnection(ConfigurationManager.ConnectionStrings("fingermachConnectionString").ConnectionString)

            ListBox1.Items.Add("Clear Data From Finger Machine at " & DateAndTime.Now)
            oAbsen.ClearRecord()
            ListBox1.Items.Add("Completed at " & DateAndTime.Now)

        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            Dim oAbsen As cFPFUnctions = New cFPFUnctions()
            oAbsen.IPADDRESS = "196.10.0.200"
            oAbsen.PORT = 4370
            Dim oCom As MySqlCommand = New MySqlCommand()

            oCom.Connection = New MySqlConnection(ConfigurationManager.ConnectionStrings("fingermachConnectionString").ConnectionString)
            ListBox1.Items.Add("Get Data From DB at " & DateAndTime.Now)
            oAbsen.setMemberFPID()
            ListBox1.Items.Add("Upload User Data Completed at " & DateAndTime.Now)
        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            Dim oAbsen As cFPFUnctions = New cFPFUnctions()
            oAbsen.IPADDRESS = "196.10.0.200"
            oAbsen.PORT = 4370
            Dim oCom As MySqlCommand = New MySqlCommand()

            oCom.Connection = New MySqlConnection(ConfigurationManager.ConnectionStrings("fingermachConnectionString").ConnectionString)
            ListBox1.Items.Add("Get Data From Machine at " & DateAndTime.Now)
            oAbsen.getUserData(oCom)
            ListBox1.Items.Add("Upload User Data Completed at " & DateAndTime.Now)
        End Sub

        Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
            Dim oAbsen As cFPFUnctions = New cFPFUnctions()
            oAbsen.IPADDRESS = "196.10.0.200"
            oAbsen.PORT = 4370
            Dim oCom As MySqlCommand = New MySqlCommand()

            oCom.Connection = New MySqlConnection(ConfigurationManager.ConnectionStrings("fingermachConnectionString").ConnectionString)
            ListBox1.Items.Add("Delete In-Active User from Machine at " & DateAndTime.Now)
            oAbsen.DeleteInactiveMember()
            ListBox1.Items.Add("Delete In-Active User Completed at " & DateAndTime.Now)
        End Sub

        Private Sub btnSetAdministratorName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetAdministratorName.Click
            Dim oAbsen As cFPFUnctions = New cFPFUnctions()
            oAbsen.IPADDRESS = "196.10.0.200"
            oAbsen.PORT = 4370
            Dim oCom As MySqlCommand = New MySqlCommand()

            oCom.Connection = New MySqlConnection(ConfigurationManager.ConnectionStrings("fingermachConnectionString").ConnectionString)
            ListBox1.Items.Add("Set Admin Names at " & DateAndTime.Now)
            oAbsen.RegisterAdminFPUser(1001, "Nelson", "2308")
            oAbsen.RegisterAdminFPUser(1002, "Budi", "3007")
            oAbsen.RegisterAdminFPUser(1003, "Vina", "3001")
            oAbsen.RegisterAdminFPUser(1004, "Dian", "2301")
            ListBox1.Items.Add("Set Admin Names Completed at " & DateAndTime.Now)
        End Sub
    End Class
End Namespace
