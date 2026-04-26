Public Class RegisterForm
    Dim nameArray(99) As String
    Dim positionArray(99) As String
    Dim dailyRateArray(99) As Double
    Dim attendaceArray(99) As Integer
    Dim overtimeArray(99) As Double
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtboxDailyRate.Text = ""
        txtboxName.Text = ""
        txtboxPosition.Text = ""
        txtboxOvertime.Text = ""
        txtboxAttendance.Text = ""
    End Sub
End Class