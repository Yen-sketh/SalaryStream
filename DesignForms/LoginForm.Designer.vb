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
        btnRegister = New Button()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(243, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 30)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F)
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 62)
        Label2.TabIndex = 1
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20F)
        Label3.Location = New Point(12, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 62)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(165, 30)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(175, 35)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(243, 94)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(175, 35)
        TextBox2.TabIndex = 4
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(28, 140)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(131, 40)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(165, 140)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(131, 40)
        btnRegister.TabIndex = 6
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(302, 140)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(131, 40)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(479, 206)
        Controls.Add(btnLogin)
        Controls.Add(btnRegister)
        Controls.Add(btnClear)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
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
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnLogin As Button

End Class
