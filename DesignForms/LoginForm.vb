Public Class LoginForm


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'para hindi visible ung pass, dot lang lilitaw
        TextBox2.UseSystemPasswordChar = True

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = "Admin"
        Dim password As String = "6789"

        If TextBox1.Text = username And TextBox2.Text = password Then
            MessageBox.Show("Login Successful!", "Payroll System", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'mag oopen sya ng bagong form after mag log in
            Dim main As New RegisterForm

            main.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TextBox2.Clear()
            TextBox1.Focus()

        End If
    End Sub

End Class
