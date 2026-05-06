<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtboxName = New TextBox()
        txtboxPosition = New TextBox()
        txtboxAttendance = New TextBox()
        txtboxDailyRate = New TextBox()
        txtboxOvertime = New TextBox()
        z = New Label()
        Label5 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        btnDone = New Button()
        btnClear = New Button()
        Label6 = New Label()
        txtboxSearchEmployee = New TextBox()
        checkboxEmployee = New CheckBox()
        lbl = New Label()
        checkboxEmpPos = New CheckBox()
        txtboxEmpPos = New TextBox()
        BtnPayRoll = New Button()
        chBoxSSS = New CheckBox()
        chBoxPhilHealth = New CheckBox()
        chBoxPagibig = New CheckBox()
        Label7 = New Label()
        btnLogOut = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 98)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 30)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 178)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 30)
        Label2.TabIndex = 1
        Label2.Text = "Position:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(342, 98)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 30)
        Label3.TabIndex = 2
        Label3.Text = "Daily Rate:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(342, 178)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 30)
        Label4.TabIndex = 3
        Label4.Text = "Attendance:"
        ' 
        ' txtboxName
        ' 
        txtboxName.Location = New Point(88, 98)
        txtboxName.Margin = New Padding(2)
        txtboxName.Name = "txtboxName"
        txtboxName.Size = New Size(174, 35)
        txtboxName.TabIndex = 4
        ' 
        ' txtboxPosition
        ' 
        txtboxPosition.Location = New Point(106, 174)
        txtboxPosition.Margin = New Padding(2)
        txtboxPosition.Name = "txtboxPosition"
        txtboxPosition.Size = New Size(174, 35)
        txtboxPosition.TabIndex = 5
        ' 
        ' txtboxAttendance
        ' 
        txtboxAttendance.Location = New Point(473, 178)
        txtboxAttendance.Margin = New Padding(2)
        txtboxAttendance.Name = "txtboxAttendance"
        txtboxAttendance.Size = New Size(174, 35)
        txtboxAttendance.TabIndex = 6
        ' 
        ' txtboxDailyRate
        ' 
        txtboxDailyRate.Location = New Point(473, 98)
        txtboxDailyRate.Margin = New Padding(2)
        txtboxDailyRate.Name = "txtboxDailyRate"
        txtboxDailyRate.Size = New Size(174, 35)
        txtboxDailyRate.TabIndex = 7
        ' 
        ' txtboxOvertime
        ' 
        txtboxOvertime.Location = New Point(773, 102)
        txtboxOvertime.Margin = New Padding(2)
        txtboxOvertime.Name = "txtboxOvertime"
        txtboxOvertime.Size = New Size(150, 35)
        txtboxOvertime.TabIndex = 9
        ' 
        ' z
        ' 
        z.AutoSize = True
        z.Location = New Point(664, 102)
        z.Margin = New Padding(2, 0, 2, 0)
        z.Name = "z"
        z.Size = New Size(103, 30)
        z.TabIndex = 8
        z.Text = "Overtime:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20F)
        Label5.Location = New Point(427, 11)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(307, 62)
        Label5.TabIndex = 10
        Label5.Text = "Salary Stream"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(28, 28)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(36, 366)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 72
        DataGridView1.Size = New Size(1138, 350)
        DataGridView1.TabIndex = 14
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Name"
        Column1.MinimumWidth = 9
        Column1.Name = "Column1"
        Column1.Width = 175
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Position"
        Column2.MinimumWidth = 9
        Column2.Name = "Column2"
        Column2.Width = 175
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Daily Rate"
        Column3.MinimumWidth = 9
        Column3.Name = "Column3"
        Column3.Width = 175
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Attendance (days worked)"
        Column4.MinimumWidth = 9
        Column4.Name = "Column4"
        Column4.Width = 175
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Overtime (in hrs)"
        Column5.MinimumWidth = 9
        Column5.Name = "Column5"
        Column5.Width = 175
        ' 
        ' btnDone
        ' 
        btnDone.Location = New Point(25, 246)
        btnDone.Margin = New Padding(2)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(448, 40)
        btnDone.TabIndex = 17
        btnDone.Text = "Done"
        btnDone.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(502, 246)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(468, 40)
        btnClear.TabIndex = 18
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(25, 305)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(176, 30)
        Label6.TabIndex = 19
        Label6.Text = "Search Employee:"
        ' 
        ' txtboxSearchEmployee
        ' 
        txtboxSearchEmployee.Location = New Point(212, 301)
        txtboxSearchEmployee.Margin = New Padding(2)
        txtboxSearchEmployee.Name = "txtboxSearchEmployee"
        txtboxSearchEmployee.Size = New Size(174, 35)
        txtboxSearchEmployee.TabIndex = 20
        ' 
        ' checkboxEmployee
        ' 
        checkboxEmployee.AutoSize = True
        checkboxEmployee.Location = New Point(394, 313)
        checkboxEmployee.Margin = New Padding(2)
        checkboxEmployee.Name = "checkboxEmployee"
        checkboxEmployee.Size = New Size(22, 21)
        checkboxEmployee.TabIndex = 21
        checkboxEmployee.UseVisualStyleBackColor = True
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Location = New Point(502, 301)
        lbl.Margin = New Padding(2, 0, 2, 0)
        lbl.Name = "lbl"
        lbl.Size = New Size(283, 30)
        lbl.TabIndex = 22
        lbl.Text = "Search by Employee Position:"
        ' 
        ' checkboxEmpPos
        ' 
        checkboxEmpPos.AutoSize = True
        checkboxEmpPos.Location = New Point(972, 311)
        checkboxEmpPos.Margin = New Padding(2)
        checkboxEmpPos.Name = "checkboxEmpPos"
        checkboxEmpPos.Size = New Size(22, 21)
        checkboxEmpPos.TabIndex = 24
        checkboxEmpPos.UseVisualStyleBackColor = True
        ' 
        ' txtboxEmpPos
        ' 
        txtboxEmpPos.Location = New Point(791, 301)
        txtboxEmpPos.Margin = New Padding(2)
        txtboxEmpPos.Name = "txtboxEmpPos"
        txtboxEmpPos.Size = New Size(174, 35)
        txtboxEmpPos.TabIndex = 23
        ' 
        ' BtnPayRoll
        ' 
        BtnPayRoll.Location = New Point(955, 722)
        BtnPayRoll.Margin = New Padding(4)
        BtnPayRoll.Name = "BtnPayRoll"
        BtnPayRoll.Size = New Size(223, 68)
        BtnPayRoll.TabIndex = 25
        BtnPayRoll.Text = "Calculate  Payroll"
        BtnPayRoll.UseVisualStyleBackColor = True
        ' 
        ' chBoxSSS
        ' 
        chBoxSSS.AutoSize = True
        chBoxSSS.Location = New Point(1056, 160)
        chBoxSSS.Margin = New Padding(4)
        chBoxSSS.Name = "chBoxSSS"
        chBoxSSS.Size = New Size(72, 34)
        chBoxSSS.TabIndex = 26
        chBoxSSS.Text = "SSS"
        chBoxSSS.UseVisualStyleBackColor = True
        ' 
        ' chBoxPhilHealth
        ' 
        chBoxPhilHealth.AutoSize = True
        chBoxPhilHealth.Location = New Point(1056, 220)
        chBoxPhilHealth.Margin = New Padding(4)
        chBoxPhilHealth.Name = "chBoxPhilHealth"
        chBoxPhilHealth.Size = New Size(134, 34)
        chBoxPhilHealth.TabIndex = 27
        chBoxPhilHealth.Text = "PhilHealth"
        chBoxPhilHealth.UseVisualStyleBackColor = True
        ' 
        ' chBoxPagibig
        ' 
        chBoxPagibig.AutoSize = True
        chBoxPagibig.Location = New Point(1056, 286)
        chBoxPagibig.Margin = New Padding(4)
        chBoxPagibig.Name = "chBoxPagibig"
        chBoxPagibig.Size = New Size(122, 34)
        chBoxPagibig.TabIndex = 28
        chBoxPagibig.Text = "PAG IBIG"
        chBoxPagibig.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1021, 109)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(222, 30)
        Label7.TabIndex = 29
        Label7.Text = "Government Agencies:"
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Location = New Point(36, 736)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(131, 40)
        btnLogOut.TabIndex = 30
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1271, 932)
        Controls.Add(btnLogOut)
        Controls.Add(Label7)
        Controls.Add(chBoxPagibig)
        Controls.Add(chBoxPhilHealth)
        Controls.Add(chBoxSSS)
        Controls.Add(BtnPayRoll)
        Controls.Add(checkboxEmpPos)
        Controls.Add(txtboxEmpPos)
        Controls.Add(lbl)
        Controls.Add(checkboxEmployee)
        Controls.Add(txtboxSearchEmployee)
        Controls.Add(Label6)
        Controls.Add(btnClear)
        Controls.Add(btnDone)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(txtboxOvertime)
        Controls.Add(z)
        Controls.Add(txtboxDailyRate)
        Controls.Add(txtboxAttendance)
        Controls.Add(txtboxPosition)
        Controls.Add(txtboxName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register Employee"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents txtboxPosition As TextBox
    Friend WithEvents txtboxAttendance As TextBox
    Friend WithEvents txtboxDailyRate As TextBox
    Friend WithEvents txtboxOvertime As TextBox
    Friend WithEvents z As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btnDone As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtboxSearchEmployee As TextBox
    Friend WithEvents checkboxEmployee As CheckBox
    Friend WithEvents lbl As Label
    Friend WithEvents checkboxEmpPos As CheckBox
    Friend WithEvents txtboxEmpPos As TextBox
    Friend WithEvents BtnPayRoll As Button
    Friend WithEvents chBoxSSS As CheckBox
    Friend WithEvents chBoxPhilHealth As CheckBox
    Friend WithEvents chBoxPagibig As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnLogOut As Button
End Class
