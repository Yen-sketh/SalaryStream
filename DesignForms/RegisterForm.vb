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


        If Not cBoxEmployee.items.Contains(nameArray(count)) Then
            cBoxEmployee.Items.Add(nameArray(count))

        End If

        If Not cBoxPosition.Items.Contains(positionArray(count)) Then
            cBoxPosition.Items.Add(positionArray(count))
        End If

    End Sub


    Private Sub BtnPayRoll_Click(sender As Object, e As EventArgs) Handles BtnPayRoll.Click

        PayrollForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        LoginForm.Close()
    End Sub

    Private Sub cBoxEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxEmployee.SelectedIndexChanged

        If cBoxEmployee.SelectedIndex = -1 Then
            show_original_list()
        Else
            search_employee()
        End If
    End Sub

    Private Sub cBoxPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxPosition.SelectedIndexChanged

        If cBoxPosition.SelectedIndex = -1 Then
            show_original_list()
        Else
            search_employeePos()
        End If
    End Sub


    Sub search_employee()

        For i As Integer = 0 To DataGridView1.RowCount - 1
            Dim name_employee = DataGridView1.Rows(i).Cells(0).Value
            If cBoxEmployee.Text = name_employee Then
                DataGridView1.Rows(i).Visible = True
            Else
                DataGridView1.Rows(i).Visible = False
            End If
        Next

    End Sub

    Sub search_employeePos()

        For i As Integer = 0 To DataGridView1.RowCount - 1
            Dim pos_employee = DataGridView1.Rows(i).Cells(1).Value
            If cBoxPosition.Text = pos_employee Then
                DataGridView1.Rows(i).Visible = True
            Else
                DataGridView1.Rows(i).Visible = False
            End If
        Next

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refresh_list()
    End Sub

    Sub refresh_list()
        cBoxEmployee.SelectedIndex = -1
        cBoxPosition.SelectedIndex = -1
        show_original_list()

    End Sub

    Sub show_original_list()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Visible = True
        Next
    End Sub


End Class