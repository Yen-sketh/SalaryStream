Public Class RegisterForm
    Dim nameArray(99) As String
    Dim positionArray(99) As String
    Dim dailyRateArray(99) As Double
    Dim attendaceArray(99) As Integer
    Dim overtimeArray(99) As Double

    Dim count As Integer = 0
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

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
        search_employee(txtboxSearchEmployee.Text)




    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



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
    End Sub

    Sub search_employee(employee)


        Dim index As Integer = DataGridView1.CurrentRow.Index
        Dim name As String = DataGridView1.Rows(index).Cells(0).Value
        Dim position As String = DataGridView1.Rows(index).Cells(1).Value
        Dim dailyRate As Double = DataGridView1.Rows(index).Cells(2).Value
        Dim attendace As Integer = DataGridView1.Rows(index).Cells(3).Value
        Dim overtime As Integer = DataGridView1.Rows(index).Cells(4).Value



    End Sub

    Private Sub txtboxName_TextChanged(sender As Object, e As EventArgs) Handles txtboxName.TextChanged

    End Sub
End Class