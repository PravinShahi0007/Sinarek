Imports zkemkeeper

Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Configuration

Friend Class cFPFUnctions
    Private Const MACH_IP As String = "196.10.0.199"
    Private Const MACH_PORT As Long = 4370
    Protected Friend Sub RegisterUser(ByVal ID As Integer, ByVal sName As String, ByVal sPass As String)
        Dim machine As New CZKEM
        If machine.Connect_Net(MACH_IP, MACH_PORT) Then
            machine.SetUserInfo(1, ID, sName, sPass, 0, True)
            'Disconnect after creating user 
            machine.Disconnect()
        Else
            MsgBox("Connection Failed", MsgBoxStyle.Information)
        End If
    End Sub
    Protected Friend Sub RegisterAdminFPUser(ByVal ID As Integer, ByVal sName As String, ByVal sPass As String)
        Dim machine As New CZKEM
        If machine.Connect_Net(MACH_IP, MACH_PORT) Then
            machine.SetUserInfo(1, 1000 + ID, sName, sPass, 3, True)
            'Disconnect after creating user 
            machine.Disconnect()
        Else
            MsgBox("Connection Failed", MsgBoxStyle.Information)
        End If
    End Sub
    Protected Friend Sub SetTime()
        Dim machine As New CZKEM
        If machine.Connect_Net(MACH_IP, MACH_PORT) Then
            machine.SetDeviceTime2(1, DateTime.Now.Year, DateTime.Now.Month, Now.Day, Now.Hour, Now.Minute, Now.Second)
        Else
            MsgBox("Connection Failed", MsgBoxStyle.Information)
        End If
    End Sub
    Protected Friend Sub getData()
        Dim cZ As New CZKEM
        Dim a, b, c, d, e, f, g, h, i, j As Integer

        Dim oConn As New MySqlConnection(ConfigurationManager.AppSettings("NB.Properties.Settings.fingermachConnectionString"))

        Dim sQuery As String
        Dim oCom As New MySqlCommand()
        oCom.Connection = oConn
        oCom.CommandType = CommandType.Text


        If cZ.Connect_Net(MACH_IP, MACH_PORT) Then
            If cZ.ReadAllGLogData(1) Then
                While cZ.GetAllGLogData(1, dwTMachineNumber:=a, dwEnrollNumber:=b, dwEMachineNumber:=c, dwVerifyMode:=d, _
                                       dwInOutMode:=e, dwYear:=f, dwMonth:=g, dwDay:=h, dwHour:=i, dwMinute:=j)
                    sQuery = "INSERT INTO `tDataFinger` ( `MachineNum` ,`EnrolNum` ," & _
                            "`VerifyMode` ," & _
                            "`InOutMode` ," & _
                            "`Year` ," & _
                            "`Month` ," & _
                            "`Day` ," & _
                            "`Hour` ," & _
                            "`Minute`) VALUES (" & _
                            a.ToString() & ", " & b.ToString() & "," & _
                            d.ToString() & ", " & e.ToString() & " ," & f.ToString() & "," & _
                            g.ToString() & ", " & h.ToString() & " ," & i.ToString() & "," & j.ToString() & ");"
                    oCom.CommandText = sQuery
                    Debug.Print(sQuery)
                    oConn.Open()
                    oCom.ExecuteNonQuery()
                    oConn.Close()
                End While
            End If
        End If
    End Sub
    Protected Friend Sub getUserData()
        Dim cZ As New CZKEM
        Dim a, d, e As Integer
        Dim b, c As String
        Dim oConn As New MySqlConnection(ConfigurationManager.AppSettings("NB.Properties.Settings.fingermachConnectionString"))

        Dim sQuery As String
        Dim oCom As New MySqlCommand()
        oCom.Connection = oConn
        oCom.CommandType = CommandType.Text

        'Always replace old data with new ones
        oCom.CommandText = "Truncate table `DataNewUser`;"
        Debug.Print("Truncate table `DataNewUser`;")
        oConn.Open()
        oCom.ExecuteNonQuery()
        oConn.Close()

        If cZ.Connect_Net(MACH_IP, MACH_PORT) Then

            While cZ.GetAllUserInfo(1, dwEnrollNumber:=a, Name:=b, Password:=c, Privilege:=d, Enabled:=e)
                sQuery = "INSERT INTO `DataNewUser` ( `EnrollNum` ," & _
                        "`Name` ," & _
                        "`Password` ," & _
                        "`Privilige` ," & _
                        "`Enable` ) VALUES (" & _
                        a.ToString() & ", '" & b & "','" & _
                        c & "', " & d.ToString() & " ," & e.ToString() & ");"
                oCom.CommandText = sQuery
                Debug.Print(sQuery)
                oConn.Open()
                oCom.ExecuteNonQuery()
                oConn.Close()
            End While

        End If
    End Sub
    Protected Friend Sub setFPIDName()
        Dim cZ As New CZKEM

        Dim oConn As New MySqlConnection(ConfigurationManager.AppSettings("NB.Properties.Settings.fingermachConnectionString"))

        Dim oCom As New MySqlCommand()
        oCom.Connection = oConn
        oCom.CommandType = CommandType.Text
        oCom.CommandText = "Select BuruhID,Name,FingerID from `Buruh`;"
        Dim oAdapter As New MySqlDataAdapter(oCom)

        Dim dtBuruh As New DataTable("Buruh")
        Dim dtRow As DataRow
        Dim iLine As Integer
        iLine = 1

        oAdapter.Fill(dtBuruh)

        If cZ.Connect_Net("196.10.0.199", 4370) Then
            For Each dtRow In dtBuruh.Rows
                'txtPrint.Text = txtPrint.Text & Chr(13) & dtRow("BuruhID").ToString() & " " & dtRow("Name").ToString()
                RegisterUser(Integer.Parse(dtRow("FingerID")), dtRow("Name"), "")
                'txtPrint.Refresh()
            Next
            cZ.Disconnect()
        End If


    End Sub
    Protected Friend Sub ClearRecord()
        Dim machine As New CZKEM
        If machine.Connect_Net(MACH_IP, MACH_PORT) Then
            machine.ClearGLog(1)
        Else
            MsgBox("Connection Failed", MsgBoxStyle.Information)
        End If
    End Sub
    Protected Friend Sub ClearAllUsers()
        Dim machine As New CZKEM
        If machine.Connect_Net(MACH_IP, MACH_PORT) Then
            machine.ClearKeeperData(1)
        Else
            MsgBox("Connection Failed", MsgBoxStyle.Information)
        End If
    End Sub
    Protected Friend Sub ClearUser(ByVal id As Integer)
        Dim machine As New CZKEM
        If machine.Connect_Net(MACH_IP, MACH_PORT) Then
            machine.SetUserInfo(1, id, "", "", 0, False)

        Else
            MsgBox("Connection Failed", MsgBoxStyle.Information)
        End If
    End Sub
    Protected Friend Sub SetFPMTime()
        Dim machine As New CZKEM
        If machine.Connect_Net(MACH_IP, MACH_PORT) Then
            'machine.
        Else
            MsgBox("Connection Failed", MsgBoxStyle.Information)
        End If
    End Sub
End Class

