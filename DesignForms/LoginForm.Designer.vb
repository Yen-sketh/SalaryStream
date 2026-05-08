<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        btnClear = New Button()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(367, 174)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 30)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 40F)
        Label2.Location = New Point(11, 98)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(296, 125)
        Label2.TabIndex = 1
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 40F)
        Label3.Location = New Point(11, 242)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(462, 125)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 20F)
        TextBox1.Location = New Point(292, 134)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(321, 70)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 20F)
        TextBox2.Location = New Point(452, 276)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(321, 70)
        TextBox2.TabIndex = 4
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(11, 377)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(399, 112)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(452, 377)
        btnLogin.Margin = New Padding(2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(346, 112)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(809, 500)
        Controls.Add(btnLogin)
        Controls.Add(btnClear)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Salary Stream"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnLogin As Button

End Class
