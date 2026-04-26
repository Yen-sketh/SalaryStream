<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtboxName = New TextBox()
        txtboxPosition = New TextBox()
        txtboxAttendance = New TextBox()
        txtboxDailyRate = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 30)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 173)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 30)
        Label2.TabIndex = 1
        Label2.Text = "Position:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(343, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 30)
        Label3.TabIndex = 2
        Label3.Text = "Daily Rate:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(343, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 30)
        Label4.TabIndex = 3
        Label4.Text = "Attendance:"
        ' 
        ' txtboxName
        ' 
        txtboxName.Location = New Point(89, 95)
        txtboxName.Name = "txtboxName"
        txtboxName.Size = New Size(175, 35)
        txtboxName.TabIndex = 4
        ' 
        ' txtboxPosition
        ' 
        txtboxPosition.Location = New Point(106, 170)
        txtboxPosition.Name = "txtboxPosition"
        txtboxPosition.Size = New Size(175, 35)
        txtboxPosition.TabIndex = 5
        ' 
        ' txtboxAttendance
        ' 
        txtboxAttendance.Location = New Point(474, 173)
        txtboxAttendance.Name = "txtboxAttendance"
        txtboxAttendance.Size = New Size(175, 35)
        txtboxAttendance.TabIndex = 6
        ' 
        ' txtboxDailyRate
        ' 
        txtboxDailyRate.Location = New Point(474, 95)
        txtboxDailyRate.Name = "txtboxDailyRate"
        txtboxDailyRate.Size = New Size(175, 35)
        txtboxDailyRate.TabIndex = 7
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(796, 98)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 35)
        TextBox1.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(665, 98)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 30)
        Label5.TabIndex = 8
        Label5.Text = "Attendance:"
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1099, 340)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(txtboxDailyRate)
        Controls.Add(txtboxAttendance)
        Controls.Add(txtboxPosition)
        Controls.Add(txtboxName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "RegisterForm"
        Text = "Register Employee"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents txtboxPosition As TextBox
    Friend WithEvents txtboxAttendance As TextBox
    Friend WithEvents txtboxDailyRate As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
End Class
