Imports zkemkeeper

Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Attendance

Public Class frmMain

    Private oAbsen As New cFPFUnctions

    Private Sub btnUserData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserData.Click
        'oAbsen.getUserData()
        oAbsen.RegisterAdminFPUser(4, "Helmy", "3178")
    End Sub
    Private Sub btnData_Click(ByVal sender As System.Object, ByVal EA As System.EventArgs) Handles btnGetData.Click
        oAbsen.getData()
    End Sub
    
    Private Sub btnSync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSync.Click
        oAbsen.SetTime()
    End Sub

    Private Sub BuruhBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BuruhBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FingermachDataSet)

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FingermachDataSet.buruh' table. You can move, or remove it, as needed.
        Me.BuruhTableAdapter.Fill(Me.FingermachDataSet.buruh)
    End Sub
End Class
