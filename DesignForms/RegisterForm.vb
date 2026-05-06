Public Class RegisterForm

    Public Shared sssStatus(99) As Boolean
    Public Shared philHealthStatus(99) As Boolean
    Public Shared pagibigStatus(99) As Boolean

    Public Shared nameArray(99) As String
    Public Shared positionArray(99) As String
    Public Shared dailyRateArray(99) As Double
    Public Shared attendaceArray(99) As Integer
    Public Shared overtimeArray(99) As Double

    Public Shared count As Integer = 0
    Public Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtboxDailyRate.Text = ""
        txtboxName.Text = ""
        txtboxPosition.Text = ""
        txtboxOvertime.Text = ""
        txtboxAttendance.Text = ""
        txtboxSearchEmployee.Text = ""
        checkboxEmployee.Checked = False
        chBoxPagibig.Checked = False
        chBoxPhilHealth.Checked = False
        chBoxSSS.Checked = False
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

        sssStatus(count) = chBoxSSS.Checked
        philHealthStatus(count) = chBoxPhilHealth.Checked
        pagibigStatus(count) = chBoxPagibig.Checked


        DataGridView1.Rows.Add(nameArray(count), positionArray(count), dailyRateArray(count),
                                   attendaceArray(count), overtimeArray(count))
    End Sub

    Sub search_employee()

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(0).Value = txtboxSearchEmployee.Text.ToUpper Then
                DataGridView1.Rows(i).Visible = True
            Else
                DataGridView1.Rows(i).Visible = False
            End If
        Next


    End Sub

    Sub search_employee_position()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(1).Value = txtboxEmpPos.Text.ToUpper Then
                DataGridView1.Rows(i).Visible = True
            Else
                DataGridView1.Rows(i).Visible = False
            End If
        Next

    End Sub

    Private Sub txtboxSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearchEmployee.TextChanged
        If checkboxEmployee.Checked Then
            search_employee()

        ElseIf checkboxEmployee.Checked = False Then

            For i = 0 To DataGridView1.Rows.Count - 1
                DataGridView1.Rows(i).Visible = True
            Next
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtboxEmpPos.TextChanged
        If checkboxEmpPos.Checked Then
            search_employee_position()

        ElseIf checkboxEmployee.Checked = False Then

            For i = 0 To DataGridView1.Rows.Count - 1
                DataGridView1.Rows(i).Visible = True
            Next
        End If
    End Sub

    Private Sub BtnPayRoll_Click(sender As Object, e As EventArgs) Handles BtnPayRoll.Click
        PayrollForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        LoginForm.Show()
    End Sub
End Class