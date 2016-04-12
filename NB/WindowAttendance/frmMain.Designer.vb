<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnGetData = New System.Windows.Forms.Button
        Me.btnUserData = New System.Windows.Forms.Button
        Me.btnRegisterUser = New System.Windows.Forms.Button
        Me.btnSync = New System.Windows.Forms.Button
        Me.FingermachDataSet = New Attendance.fingermachDataSet
        Me.BuruhBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuruhTableAdapter = New Attendance.fingermachDataSetTableAdapters.buruhTableAdapter
        Me.TableAdapterManager = New Attendance.fingermachDataSetTableAdapters.TableAdapterManager
        CType(Me.FingermachDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuruhBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGetData
        '
        Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetData.Location = New System.Drawing.Point(56, 21)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(130, 41)
        Me.btnGetData.TabIndex = 0
        Me.btnGetData.Text = "Retrieve Data"
        Me.btnGetData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'btnUserData
        '
        Me.btnUserData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserData.Location = New System.Drawing.Point(56, 77)
        Me.btnUserData.Name = "btnUserData"
        Me.btnUserData.Size = New System.Drawing.Size(130, 41)
        Me.btnUserData.TabIndex = 1
        Me.btnUserData.Text = "Refresh User Data"
        Me.btnUserData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUserData.UseVisualStyleBackColor = True
        '
        'btnRegisterUser
        '
        Me.btnRegisterUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterUser.Location = New System.Drawing.Point(56, 133)
        Me.btnRegisterUser.Name = "btnRegisterUser"
        Me.btnRegisterUser.Size = New System.Drawing.Size(130, 41)
        Me.btnRegisterUser.TabIndex = 2
        Me.btnRegisterUser.Text = "Register New User"
        Me.btnRegisterUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRegisterUser.UseVisualStyleBackColor = True
        '
        'btnSync
        '
        Me.btnSync.Location = New System.Drawing.Point(56, 185)
        Me.btnSync.Name = "btnSync"
        Me.btnSync.Size = New System.Drawing.Size(130, 41)
        Me.btnSync.TabIndex = 3
        Me.btnSync.Text = "Sync Time"
        Me.btnSync.UseVisualStyleBackColor = True
        '
        'FingermachDataSet
        '
        Me.FingermachDataSet.DataSetName = "fingermachDataSet"
        Me.FingermachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuruhBindingSource
        '
        Me.BuruhBindingSource.DataMember = "buruh"
        Me.BuruhBindingSource.DataSource = Me.FingermachDataSet
        '
        'BuruhTableAdapter
        '
        Me.BuruhTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.buruhTableAdapter = Me.BuruhTableAdapter
        Me.TableAdapterManager.UpdateOrder = Attendance.fingermachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 257)
        Me.Controls.Add(Me.btnSync)
        Me.Controls.Add(Me.btnRegisterUser)
        Me.Controls.Add(Me.btnUserData)
        Me.Controls.Add(Me.btnGetData)
        Me.Name = "frmMain"
        Me.Text = "Absen Utilities"
        CType(Me.FingermachDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuruhBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents btnUserData As System.Windows.Forms.Button
    Friend WithEvents btnRegisterUser As System.Windows.Forms.Button
    Friend WithEvents btnSync As System.Windows.Forms.Button
    Friend WithEvents FingermachDataSet As Attendance.fingermachDataSet
    Friend WithEvents BuruhBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuruhTableAdapter As Attendance.fingermachDataSetTableAdapters.buruhTableAdapter
    Friend WithEvents TableAdapterManager As Attendance.fingermachDataSetTableAdapters.TableAdapterManager

End Class
