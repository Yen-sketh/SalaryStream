Public Class RegisterForm

    Public Shared sssStatus(99) As Double
    Public Shared philHealthStatus(99) As Double
    Public Shared pagibigStatus(99) As Double

    Public Shared nameArray(99) As String
    Public Shared positionArray(99) As String
    Public Shared dailyRateArray(99) As Double
    Public Shared attendaceArray(99) As Integer
    Public Shared overtimeArray(99) As Double


    Public Shared count As Integer = 0


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtboxDailyRate.Text = ""
        txtboxName.Text = ""
        txtboxPosition.Text = ""
        txtboxOvertime.Text = ""
        txtboxAttendance.Text = ""

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        add_items()
        add_count()

    End Sub

    Sub add_count()
        count += 1

    End Sub

    Sub add_items()
        nameArray(count) = txtboxName.Text.ToUpper
        positionArray(count) = txtboxPosition.Text.ToUpper
        dailyRateArray(count) = txtboxDailyRate.Text
        attendaceArray(count) = txtboxAttendance.Text
        overtimeArray(count) = txtboxOvertime.Text

        DataGridView1.Rows.Add(nameArray(count), positionArray(count), dailyRateArray(count),
                                   attendaceArray(count), overtimeArray(count))


        cBoxEmployee.Items.Add(nameArray(count))
        cBoxPosition.Items.Add(positionArray(count))

    End Sub




    Private Sub BtnPayRoll_Click(sender As Object, e As EventArgs) Handles BtnPayRoll.Click

        PayrollForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        LoginForm.Close()
    End Sub


End Class