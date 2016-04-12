Imports zkemkeeper
Imports System
Imports System.Math
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Security
Imports System.Exception

Namespace AutoGrab
    Public Class cFPFUnctions
        Private _ipadd As String

        Private _port As Integer

        Public Property IPADDRESS As String
            Get
                Return Me._ipadd
            End Get
            Set(ByVal value As String)
                Me._ipadd = value
            End Set
        End Property

        Public Property PORT As Integer
            Get
                Return Me._port
            End Get
            Set(ByVal value As Integer)
                Me._port = value
            End Set
        End Property

        <DebuggerNonUserCode()> _
        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub ClearAllUsers()
            Dim machine As CZKEM = New CZKEMClass()
            If (Not machine.Connect_Net(Me._ipadd, Me._port)) Then
                Interaction.MsgBox("Connection Failed", MsgBoxStyle.Information, Nothing)
            Else
                machine.ClearKeeperData(1)
            End If
        End Sub

        Public Sub ClearRecord()
            Dim machine As CZKEM = New CZKEMClass()
            If (Not machine.Connect_Net(Me._ipadd, Me._port)) Then
                Throw New Exception("Connection Failed")
            Else
                machine.ClearGLog(1)
                Return
            End If
        End Sub

        Public Sub ClearUser(ByVal id As Integer)
            Dim machine As CZKEM = New CZKEMClass()
            If (Not machine.Connect_Net(Me._ipadd, Me._port)) Then
                Interaction.MsgBox("Connection Failed", MsgBoxStyle.Information, Nothing)
            Else
                machine.SetUserInfo(1, id, "", "", 0, False)
            End If
        End Sub

        Public Sub getData(ByRef oCom As MySqlCommand)
            Dim a As Integer = 0
            Dim b As Integer = 0
            Dim c As Integer = 0
            Dim d As Integer = 0
            Dim e As Integer = 0
            Dim f As Integer = 0
            Dim g As Integer = 0
            Dim h As Integer = 0
            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim cZ As CZKEM = New CZKEM
            cZ.SetCommPassword(421288)
            Try
                If (cZ.Connect_Net(Me._ipadd, Me._port) AndAlso cZ.ReadAllGLogData(1)) Then
                    While cZ.SSR_GetGeneralLogData(1, a, b, c, d, e, f, g, h, i, j)
                        Dim str(19) As String
                        str(0) = "INSERT INTO `tDataFinger` ( `MachineNum` ,`EnrolNum` ,`VerifyMode` ,`InOutMode` ,`Year` ,`Month` ,`Day` ,`Hour` ,`Minute`) VALUES ("
                        str(1) = "1"
                        str(2) = ", "
                        str(3) = a.ToString()
                        str(4) = ","
                        str(5) = b.ToString()
                        str(6) = ", "
                        str(7) = j.ToString()
                        str(8) = " ,"
                        str(9) = d.ToString()
                        str(10) = ","
                        str(11) = e.ToString()
                        str(12) = ", "
                        str(13) = f.ToString()
                        str(14) = " ,"
                        str(15) = g.ToString()
                        str(16) = ","
                        str(17) = h.ToString()
                        str(18) = ");"
                        Dim sQuery As String = String.Concat(str)
                        oCom.CommandText = sQuery
                        oCom.Connection.Open()
                        oCom.ExecuteNonQuery()
                        oCom.Connection.Close()
                        oCom.Connection.Dispose()
                    End While
                End If
            Catch accessViolationException As AccessViolationException
                
            End Try
        End Sub
        Public Sub setUserData(ByRef oCom As MySqlCommand)
            Dim a As Integer = 0
            Dim d As Integer = 0
            Dim e As Integer = 0
            Dim cZ As CZKEM = New CZKEMClass()
            Dim b As String = String.Empty
            Dim c As String = String.Empty
            oCom.CommandText = "Select * From `DataNewUser`;"
            oCom.Connection.Open()
            oCom.ExecuteReader()
            oCom.Connection.Close()
            If (cZ.Connect_Net(Me._ipadd, Me._port)) Then
                While True
                    Dim flag As Boolean = e > 0
                    e = -(flag > False)
                    If (Not cZ.GetAllUserInfo(1, a, b, c, d, flag)) Then
                        Exit While
                    End If
                    Dim str(11) As String
                    str(0) = "INSERT INTO `DataNewUser` ( `EnrollNum` ,`Name` ,`Password` ,`Privilige` ,`Enable` ) VALUES ("
                    str(1) = a.ToString()
                    str(2) = ", '"
                    str(3) = b
                    str(4) = "','"
                    str(5) = c
                    str(6) = "', "
                    str(7) = d.ToString()
                    str(8) = " ,"
                    str(9) = e.ToString()
                    str(10) = ");"
                    Dim sQuery As String = String.Concat(str)
                    oCom.CommandText = sQuery
                    oCom.Connection.Open()
                    oCom.ExecuteNonQuery()
                    oCom.Connection.Close()
                End While
            End If
        End Sub

        Public Sub getUserData(ByRef oCom As MySqlCommand)
            Dim a As Integer = 0
            Dim d As Integer = 0
            Dim e As Integer = 0
            Dim cZ As CZKEM = New CZKEMClass()
            Dim b As String = String.Empty
            Dim c As String = String.Empty
            'oCom.CommandText = "Truncate table `DataNewUser`;"
            'oCom.Connection.Open()
            'oCom.ExecuteNonQuery()
            'oCom.Connection.Close()
            cZ.SetCommPassword(421288)
            If (cZ.Connect_Net(Me._ipadd, Me._port)) Then
                While True
                    Dim flag As Boolean = e > 0
                    e = -(flag > False)
                    If (Not cZ.SSR_GetAllUserInfo(1, a, b, c, d, flag)) Then
                        Exit While
                    End If
                    Dim str(11) As String
                    str(0) = "INSERT INTO `DataNewUser` ( `EnrollNum` ,`Name` ,`Password` ,`Privilige` ,`Enable` ) VALUES ("
                    str(1) = a.ToString()
                    str(2) = ", '"
                    str(3) = b
                    str(4) = "','"
                    str(5) = c
                    str(6) = "', "
                    str(7) = d.ToString()
                    str(8) = " ,"
                    str(9) = e.ToString()
                    str(10) = ");"
                    Dim sQuery As String = String.Concat(str)
                    oCom.CommandText = sQuery
                    oCom.Connection.Open()
                    oCom.ExecuteNonQuery()
                    oCom.Connection.Close()
                End While
            End If
        End Sub

        Public Sub getUserDataOther()
            Dim a As Integer = 0
            Dim b As Integer = 0
            Dim c As Integer = 0
            Dim d As Integer = 0
            Dim e As Integer = 0
            Dim cZ As CZKEM = New CZKEMClass()
            Dim oConn As MySqlConnection = New MySqlConnection("server=localhost;User Id=root;database=fingermach")
            Dim oCom As MySqlCommand = New MySqlCommand()
            oCom.Connection = oConn
            oCom.CommandType = CommandType.Text
            oCom.CommandText = "Truncate table `DataUserOther`;"
            oConn.Open()
            oCom.ExecuteNonQuery()
            oConn.Close()
            If (cZ.Connect_Net(Me._ipadd, Me._port) AndAlso cZ.ReadAllUserID(1)) Then
                While cZ.GetAllUserID(1, a, b, c, d, e)
                    Dim str(11) As String
                    str(0) = "INSERT INTO `DataUserOther` ( `EnrollNum` ,`Name` ,`Password` ,`Privilige` ,`Enable` ) VALUES ("
                    str(1) = a.ToString()
                    str(2) = ", '"
                    str(3) = b.ToString()
                    str(4) = "','"
                    str(5) = c.ToString()
                    str(6) = "', "
                    str(7) = d.ToString()
                    str(8) = " ,"
                    str(9) = e.ToString()
                    str(10) = ");"
                    Dim sQuery As String = String.Concat(str)
                    oCom.CommandText = sQuery
                    oConn.Open()
                    oCom.ExecuteNonQuery()
                    oConn.Close()
                End While
            End If
        End Sub

        Public Sub RegisterAdminFPUser(ByVal ID As Integer, ByVal sName As String, ByVal sPass As String)
            Dim cZ As CZKEM = New CZKEM
            cZ.SetCommPassword(421288)
            If (cZ.Connect_Net(Me._ipadd, Me._port)) Then
                cZ.SSR_SetUserInfo(1, ID, sName, sPass, 3, True)
                cZ.Disconnect()
            End If
            
        End Sub

        Public Sub RegisterFPUserName(ByVal ID As Integer, ByVal sName As String, ByVal sPass As String)
            Dim machine As CZKEM = New CZKEM
            If (Not machine.Connect_Net(Me._ipadd, Me._port)) Then
                Interaction.MsgBox("Connection Failed", MsgBoxStyle.Information, Nothing)
            Else
                machine.SetUserInfo(1, ID, sName, sPass, 0, True)
                machine.Disconnect()
            End If
        End Sub

        Public Sub RegisterStaffFPUser(ByVal ID As Integer, ByVal sName As String, ByVal sPass As String)
            Dim machine As CZKEM = New CZKEMClass()
            If (Not machine.Connect_Net(Me._ipadd, Me._port)) Then
                Interaction.MsgBox("Connection Failed", MsgBoxStyle.Information, Nothing)
            Else
                machine.SetUserInfo(1, 2000 + ID, sName, sPass, 0, True)
                machine.Disconnect()
            End If
        End Sub

        Public Sub setMemberFPID()
            Dim enumerator As IEnumerator = Nothing
            Dim cZ As CZKEM = New CZKEM
            Dim oConn As MySqlConnection = New MySqlConnection("server=196.10.0.75;User Id=reader;password=r3ader;database=sinarek")
            Dim oCom As MySqlCommand = New MySqlCommand()
            oCom.Connection = oConn
            oCom.CommandType = CommandType.Text
            oCom.CommandText = "Select MemberID,FingerID,Name from `Member` where active = 1;"
            Dim oAdapter As MySqlDataAdapter = New MySqlDataAdapter(oCom)
            Dim dtBuruh As DataTable = New DataTable("Buruh")
            oAdapter.Fill(dtBuruh)
            cZ.SetCommPassword(421288)
            If (cZ.Connect_Net(Me._ipadd, Me._port)) Then

                For Each dtRow As DataRow In dtBuruh.Rows
                    cZ.SSR_SetUserInfo(1, Integer.Parse(dtRow("FingerID").ToString()), dtRow("Name").ToString(), "", 0, True)
                Next
                cZ.Disconnect()
            End If
        End Sub

        Public Sub DeleteInactiveMember()
            Dim enumerator As IEnumerator = Nothing
            Dim cZ As CZKEM = New CZKEM
            Dim oConn As MySqlConnection = New MySqlConnection("server=196.10.0.75;User Id=reader;password=r3ader;database=sinarek")
            Dim oCom As MySqlCommand = New MySqlCommand()
            oCom.Connection = oConn
            oCom.CommandType = CommandType.Text
            oCom.CommandText = "Select MemberID,FingerID,Name from `Member` where active = 0 and fingerid <> 0;"
            Dim oAdapter As MySqlDataAdapter = New MySqlDataAdapter(oCom)
            Dim dtBuruh As DataTable = New DataTable("Member")
            oAdapter.Fill(dtBuruh)
            cZ.SetCommPassword(421288)
            If (cZ.Connect_Net(Me._ipadd, Me._port)) Then

                For Each dtRow As DataRow In dtBuruh.Rows
                    cZ.SSR_DeleteEnrollData(1, dtRow("FingerID").ToString(), 0)
                Next
                cZ.Disconnect()
            End If
        End Sub

        Public Sub SetFPMTime()
            Dim machine As CZKEM = New CZKEMClass()
            If (Not machine.Connect_Net(Me._ipadd, Me._port)) Then
                Interaction.MsgBox("Connection Failed", MsgBoxStyle.Information, Nothing)
            End If
        End Sub

        Public Sub SetTime()
            Dim machine As CZKEM = New CZKEMClass()
            If (Not machine.Connect_Net(Me._ipadd, Me._port)) Then
                Interaction.MsgBox("Connection Failed", MsgBoxStyle.Information, Nothing)
            Else
                Dim now As DateTime = DateAndTime.Now
                Dim dateTime As DateTime = DateAndTime.Now
                Dim now1 As DateTime = DateAndTime.Now
                Dim dateTime1 As DateTime = DateAndTime.Now
                Dim now2 As DateTime = DateAndTime.Now
                Dim dateTime2 As DateTime = DateAndTime.Now
                machine.SetDeviceTime2(1, now.Year, dateTime.Month, now1.Day, dateTime1.Hour, now2.Minute, dateTime2.Second)
            End If
        End Sub
    End Class
End Namespace
