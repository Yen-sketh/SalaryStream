
Imports System.Globalization

Public Class PayrollForm

    Public Shared totalDeductionArray(99) As Double
    Dim philCulture As New CultureInfo("fil-PH")

    Private Sub PayrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupGridRows()
    End Sub

    Private Sub PayrollForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            ComboBox1.Items.Clear()
            For i As Integer = 0 To RegisterForm.count - 1
                ComboBox1.Items.Add(RegisterForm.nameArray(i))
            Next
            SetupGridRows()
        End If
    End Sub

    Private Sub SetupGridRows()
        DataGridView2.Rows.Clear()
        DataGridView2.Rows.Add("Daily Rate: ")
        DataGridView2.Rows.Add("Days Worked: ")
        DataGridView2.Rows.Add("Overtime Rate: ")
        DataGridView2.Rows.Add("Hours of Overtime: ")
        DataGridView2.Rows.Add("Total Overtime Pay: ")
        DataGridView2.Rows.Add("Total Gross Pay: ")
        DataGridView2.Rows.Add("SSS: ")
        DataGridView2.Rows.Add("PhilHealth: ")
        DataGridView2.Rows.Add("PAG-IBIG: ")
        DataGridView2.Rows.Add("Total Deductions: ")
        DataGridView2.Rows.Add("Total Net Pay: ")
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

        While DataGridView2.ColumnCount > 1
            DataGridView2.Columns.RemoveAt(1)
        End While

        Dim i As Integer = ComboBox1.SelectedIndex

        If i = -1 Then
            MessageBox.Show("Please Select an Employee")
        End If

        Dim empName As String = RegisterForm.nameArray(i)
        DataGridView2.Columns.Add("column" & empName, empName)

        'Pay Calculation
        Dim dailyRate As Double = RegisterForm.dailyRateArray(i)
        Dim daysWorked As Integer = RegisterForm.attendaceArray(i)
        Dim overTime As Integer = RegisterForm.overtimeArray(i)
        Dim overTimeRate As Double = (dailyRate / 8) * 1.25
        Dim overTimePay As Double = overTimeRate * overTime
        Dim grossPay As Double = (dailyRate * daysWorked) + overTimePay

        'Variables for deductions
        Dim sssTotal = grossPay * 0.045
        Dim phTotal = grossPay * 0.02
        Dim piTotal = grossPay * 0.05

        totalDeductionArray(i) = sssTotal + phTotal + piTotal

        'Deduction Calculation
        Dim netPay As Double = grossPay - totalDeductionArray(i)

        DataGridView2.Rows(0).Cells(1).Value = dailyRate.ToString("C0", philCulture)
        DataGridView2.Rows(1).Cells(1).Value = daysWorked.ToString()
        DataGridView2.Rows(2).Cells(1).Value = overTimeRate.ToString("C0", philCulture)
        DataGridView2.Rows(3).Cells(1).Value = overTime.ToString()
        DataGridView2.Rows(4).Cells(1).Value = overTimePay.ToString("C0", philCulture)
        DataGridView2.Rows(5).Cells(1).Value = grossPay.ToString("C0", philCulture)
        DataGridView2.Rows(6).Cells(1).Value = sssTotal.ToString("C0", philCulture)
        DataGridView2.Rows(7).Cells(1).Value = phTotal.ToString("C0", philCulture)
        DataGridView2.Rows(8).Cells(1).Value = piTotal.ToString("C0", philCulture)
        DataGridView2.Rows(9).Cells(1).Value = totalDeductionArray(i).ToString("C0", philCulture)
        DataGridView2.Rows(10).Cells(1).Value = netPay.ToString("C0", philCulture)

    End Sub

    Private Sub BtnBackRegister_Click(sender As Object, e As EventArgs) Handles BtnBackRegister.Click
        Me.Hide()
        RegisterForm.Show()
    End Sub
End Class