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
        txtboxDailyRate.Text = 0
        txtboxName.Text = ""
        txtboxPosition.Text = ""
        txtboxOvertime.Text = 0
        txtboxAttendance.Text = 0

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
        dailyRateArray(count) = Val(txtboxDailyRate.Text)
        attendaceArray(count) = Val(txtboxAttendance.Text)
        overtimeArray(count) = Val(txtboxOvertime.Text)

        DataGridView1.Rows.Add(nameArray(count), positionArray(count), dailyRateArray(count),
                                   attendaceArray(count), overtimeArray(count))


        If Not cBoxEmployee.Items.Contains(nameArray(count)) Then
            cBoxEmployee.Items.Add(nameArray(count))

        End If

        If Not cboxPosition.Items.Contains(positionArray(count)) Then
            cboxPosition.Items.Add(positionArray(count))
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

    Private Sub cBoxEmployee_SelectedIndexChanged(sender As Object, e As EventArgs)

        'if CBoxEmployee is empty, reset list to original.
        If cBoxEmployee.SelectedIndex = -1 Then
            show_original_list()
        Else
            search_employee()
        End If
    End Sub

    Private Sub cBoxPosition_SelectedIndexChanged(sender As Object, e As EventArgs)

        'if cBoxPosition is empty, reset list to original.
        If cboxPosition.SelectedIndex = -1 Then
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
            If cboxPosition.Text = pos_employee Then
                DataGridView1.Rows(i).Visible = True
            Else
                DataGridView1.Rows(i).Visible = False
            End If
        Next

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim index = DataGridView1.SelectedRows(0).Index
        DataGridView1.Rows.RemoveAt(index)
        adjustArray(index)
        update_list()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        update_list()
    End Sub

    Private Sub btnMainList_Click(sender As Object, e As EventArgs) Handles btnMainList.Click
        main_list()
    End Sub


    Sub update_list()
        cBoxEmployee.SelectedIndex = -1
        cboxPosition.SelectedIndex = -1

    End Sub

    Sub main_list()
        cBoxEmployee.SelectedIndex = -1
        cboxPosition.SelectedIndex = -1
        show_original_list()

    End Sub

    Sub show_original_list()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Visible = True
        Next
    End Sub

    Sub update_after_delete()

        'update combobox list
        cBoxEmployee.Items.Clear()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim afterDelCellValue = DataGridView1.Rows(i).Cells(0).Value

            If Not cBoxEmployee.Items.Contains(afterDelCellValue) Then
                cBoxEmployee.Items.Add(afterDelCellValue)
            End If
        Next

        'update position combobox
        cboxPosition.Items.Clear()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim afterDelCellValuePos = DataGridView1.Rows(i).Cells(0).Value

            If Not cboxPosition.Items.Contains(afterDelCellValuePos) Then
                cboxPosition.Items.Add(afterDelCellValuePos)
            End If
        Next

    End Sub

    Sub adjustArray(index As Integer)
        ' THIS IS JUST AN EXPLANATION ON HOW adjustArray WORKS
        ' numArray = (1,2,3,4,5) (5 count)
        ' 2 is the sample index, to be deleted is the 3rd element. to count(5) - 2 = 3
        ' numArray(2) = numArray(2+1 = 3): looks like ---> 3 = 4 
        ' so at index 2 of numArray, it will be 4.
        '
        For i As Integer = index To count - 2
            nameArray(i) = nameArray(i + 1)
            positionArray(i) = positionArray(i + 1)
            dailyRateArray(i) = dailyRateArray(i + 1)
            overtimeArray(i) = overtimeArray(i + 1)
            attendaceArray(i) = attendaceArray(i + 1)
        Next

        'Defaults the upper bound value of the array as the following:
        nameArray(count - 1) = ""
        positionArray(count - 1) = ""
        dailyRateArray(count - 1) = 0
        overtimeArray(count - 1) = 0
        attendaceArray(count - 1) = 0

        'Decreases count of Array so that the next delete will not make an indexing error.
        count -= 1
    End Sub



    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        'DataGrid automatically adds a new row per entry, causing an index error.
        'This is remedized by adding this two safety checks + turning the AllowUserToAddRow--
        'property of DataGrid to false.

        If e.RowIndex < 0 Then Exit Sub
        If DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Is Nothing Then Exit Sub


        ' Gets Emp_name index
        If e.ColumnIndex = 0 Then

            cBoxEmployee.Items.Clear()
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                Dim newName = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString().ToUpper()
                nameArray(e.RowIndex) = newName

                Dim updatedCellName = DataGridView1.Rows(i).Cells(0).Value
                If Not cBoxEmployee.Items.Contains(updatedCellName) Then
                    cBoxEmployee.Items.Add(updatedCellName.ToString())
                End If
            Next
        End If

        ' Gets Emp_position index
        If e.ColumnIndex = 1 Then

            cboxPosition.Items.Clear()

            'updates 
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                Dim newPosition = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString().ToUpper()
                positionArray(e.RowIndex) = newPosition
                Dim updatedCellPosition = DataGridView1.Rows(i).Cells(1).Value
                If Not cboxPosition.Items.Contains(updatedCellPosition) Then
                    cboxPosition.Items.Add(updatedCellPosition.ToString())
                End If
            Next

        End If

        'daily rate
        If e.ColumnIndex = 2 Then
            'updates 
            dailyRateArray(e.RowIndex) = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        End If

        'Attendance
        If e.ColumnIndex = 3 Then
            'updates 
            attendaceArray(e.RowIndex) = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        End If

        'overtime
        If e.ColumnIndex = 4 Then
            'updates 
            overtimeArray(e.RowIndex) = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        End If

    End Sub

    Private Sub DataGridView1_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        adjustArray(DataGridView1.SelectedRows(0).Index)
        update_after_delete()
    End Sub

End Class