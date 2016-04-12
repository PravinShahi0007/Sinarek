Namespace AutoGrab
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Form1
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
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.ListBox1 = New System.Windows.Forms.ListBox()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnSetAdministratorName = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'btnUpdate
            '
            Me.btnUpdate.Location = New System.Drawing.Point(16, 15)
            Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
            Me.btnUpdate.Name = "btnUpdate"
            Me.btnUpdate.Size = New System.Drawing.Size(147, 35)
            Me.btnUpdate.TabIndex = 0
            Me.btnUpdate.Text = "&Update Data Absen"
            Me.btnUpdate.UseVisualStyleBackColor = True
            '
            'ListBox1
            '
            Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.ListBox1.FormattingEnabled = True
            Me.ListBox1.ItemHeight = 16
            Me.ListBox1.Location = New System.Drawing.Point(0, 142)
            Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
            Me.ListBox1.Name = "ListBox1"
            Me.ListBox1.Size = New System.Drawing.Size(925, 180)
            Me.ListBox1.TabIndex = 1
            '
            'btnClear
            '
            Me.btnClear.Location = New System.Drawing.Point(192, 16)
            Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(164, 33)
            Me.btnClear.TabIndex = 2
            Me.btnClear.Text = "&Clean Absen Data"
            Me.btnClear.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.Location = New System.Drawing.Point(388, 16)
            Me.Button2.Margin = New System.Windows.Forms.Padding(4)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(164, 33)
            Me.Button2.TabIndex = 3
            Me.Button2.Text = "&Update User Detail"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Button3
            '
            Me.Button3.Location = New System.Drawing.Point(585, 15)
            Me.Button3.Margin = New System.Windows.Forms.Padding(4)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(164, 33)
            Me.Button3.TabIndex = 4
            Me.Button3.Text = "&Refresh User List"
            Me.Button3.UseVisualStyleBackColor = True
            '
            'btnDelete
            '
            Me.btnDelete.Location = New System.Drawing.Point(388, 72)
            Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(164, 33)
            Me.btnDelete.TabIndex = 5
            Me.btnDelete.Text = "&Delete In-Active"
            Me.btnDelete.UseVisualStyleBackColor = True
            '
            'btnSetAdministratorName
            '
            Me.btnSetAdministratorName.Location = New System.Drawing.Point(192, 72)
            Me.btnSetAdministratorName.Margin = New System.Windows.Forms.Padding(4)
            Me.btnSetAdministratorName.Name = "btnSetAdministratorName"
            Me.btnSetAdministratorName.Size = New System.Drawing.Size(164, 33)
            Me.btnSetAdministratorName.TabIndex = 6
            Me.btnSetAdministratorName.Text = "&Set Admin Name"
            Me.btnSetAdministratorName.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(925, 322)
            Me.Controls.Add(Me.btnSetAdministratorName)
            Me.Controls.Add(Me.btnDelete)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.ListBox1)
            Me.Controls.Add(Me.btnUpdate)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Text = "Manage Fingerprint Machine"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnUpdate As System.Windows.Forms.Button
        Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
        Friend WithEvents btnClear As System.Windows.Forms.Button
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Button3 As System.Windows.Forms.Button
        Friend WithEvents btnDelete As System.Windows.Forms.Button
        Friend WithEvents btnSetAdministratorName As System.Windows.Forms.Button

    End Class
End Namespace