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
        lbl = New Label()
        BtnPayRoll = New Button()
        btnLogOut = New Button()
        cBoxEmployee = New ComboBox()
        cBoxPosition = New ComboBox()
        btnUpdate = New Button()
        btnMainList = New Button()
        btnDelete = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(131, 251)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 30)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(131, 331)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 30)
        Label2.TabIndex = 1
        Label2.Text = "Position:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(447, 251)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 30)
        Label3.TabIndex = 2
        Label3.Text = "Daily Rate:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(447, 331)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 30)
        Label4.TabIndex = 3
        Label4.Text = "Attendance:"
        ' 
        ' txtboxName
        ' 
        txtboxName.Location = New Point(211, 251)
        txtboxName.Margin = New Padding(2)
        txtboxName.Name = "txtboxName"
        txtboxName.Size = New Size(174, 35)
        txtboxName.TabIndex = 4
        ' 
        ' txtboxPosition
        ' 
        txtboxPosition.Location = New Point(226, 331)
        txtboxPosition.Margin = New Padding(2)
        txtboxPosition.Name = "txtboxPosition"
        txtboxPosition.Size = New Size(174, 35)
        txtboxPosition.TabIndex = 5
        ' 
        ' txtboxAttendance
        ' 
        txtboxAttendance.Location = New Point(578, 331)
        txtboxAttendance.Margin = New Padding(2)
        txtboxAttendance.Name = "txtboxAttendance"
        txtboxAttendance.PlaceholderText = "0"
        txtboxAttendance.Size = New Size(174, 35)
        txtboxAttendance.TabIndex = 6
        ' 
        ' txtboxDailyRate
        ' 
        txtboxDailyRate.Location = New Point(578, 251)
        txtboxDailyRate.Margin = New Padding(2)
        txtboxDailyRate.Name = "txtboxDailyRate"
        txtboxDailyRate.PlaceholderText = "0"
        txtboxDailyRate.Size = New Size(174, 35)
        txtboxDailyRate.TabIndex = 7
        ' 
        ' txtboxOvertime
        ' 
        txtboxOvertime.Location = New Point(894, 251)
        txtboxOvertime.Margin = New Padding(2)
        txtboxOvertime.Name = "txtboxOvertime"
        txtboxOvertime.PlaceholderText = "0"
        txtboxOvertime.Size = New Size(150, 35)
        txtboxOvertime.TabIndex = 9
        ' 
        ' z
        ' 
        z.AutoSize = True
        z.Location = New Point(787, 251)
        z.Margin = New Padding(2, 0, 2, 0)
        z.Name = "z"
        z.Size = New Size(103, 30)
        z.TabIndex = 8
        z.Text = "Overtime:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Font = New Font("Segoe UI", 40F)
        Label5.ForeColor = Color.FromArgb(CByte(9), CByte(60), CByte(93))
        Label5.Location = New Point(469, 9)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(618, 127)
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
        DataGridView1.Location = New Point(48, 510)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 72
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1444, 350)
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
        btnDone.Location = New Point(48, 466)
        btnDone.Margin = New Padding(2)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(448, 40)
        btnDone.TabIndex = 17
        btnDone.Text = "Add Employee"
        btnDone.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(500, 466)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(494, 40)
        btnClear.TabIndex = 18
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(48, 390)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(292, 47)
        Label6.TabIndex = 19
        Label6.Text = "Search Employee:"
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Font = New Font("Segoe UI", 15F)
        lbl.Location = New Point(655, 390)
        lbl.Margin = New Padding(2, 0, 2, 0)
        lbl.Name = "lbl"
        lbl.Size = New Size(474, 47)
        lbl.TabIndex = 22
        lbl.Text = "Search by Employee Position:"
        ' 
        ' BtnPayRoll
        ' 
        BtnPayRoll.Location = New Point(1063, 866)
        BtnPayRoll.Margin = New Padding(4)
        BtnPayRoll.Name = "BtnPayRoll"
        BtnPayRoll.Size = New Size(429, 68)
        BtnPayRoll.TabIndex = 25
        BtnPayRoll.Text = "Calculate  Payroll"
        BtnPayRoll.UseVisualStyleBackColor = True
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Location = New Point(48, 866)
        btnLogOut.Margin = New Padding(2)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(430, 68)
        btnLogOut.TabIndex = 30
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' cBoxEmployee
        ' 
        cBoxEmployee.FormattingEnabled = True
        cBoxEmployee.Location = New Point(336, 399)
        cBoxEmployee.Name = "cBoxEmployee"
        cBoxEmployee.Size = New Size(268, 38)
        cBoxEmployee.TabIndex = 31
        ' 
        ' cBoxPosition
        ' 
        cBoxPosition.FormattingEnabled = True
        cBoxPosition.Location = New Point(1134, 401)
        cBoxPosition.Name = "cBoxPosition"
        cBoxPosition.Size = New Size(212, 38)
        cBoxPosition.TabIndex = 32
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(483, 866)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(573, 68)
        btnUpdate.TabIndex = 33
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnMainList
        ' 
        btnMainList.Location = New Point(999, 466)
        btnMainList.Name = "btnMainList"
        btnMainList.Size = New Size(492, 40)
        btnMainList.TabIndex = 34
        btnMainList.Text = "Main List"
        btnMainList.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(483, 940)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(573, 68)
        btnDelete.TabIndex = 35
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' RegisterForm
        ' 
        AcceptButton = btnDone
        AutoScaleDimensions = New SizeF(168F, 168F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        BackColor = Color.FromArgb(CByte(237), CByte(233), CByte(230))
        ClientSize = New Size(1532, 1028)
        Controls.Add(btnDelete)
        Controls.Add(btnMainList)
        Controls.Add(btnUpdate)
        Controls.Add(cBoxPosition)
        Controls.Add(cBoxEmployee)
        Controls.Add(btnLogOut)
        Controls.Add(BtnPayRoll)
        Controls.Add(lbl)
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
        ForeColor = Color.FromArgb(CByte(59), CByte(117), CByte(151))
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
    Friend WithEvents lbl As Label
    Friend WithEvents BtnPayRoll As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents cBoxEmployee As ComboBox
    Friend WithEvents cBoxPosition As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnMainList As Button
    Friend WithEvents btnDelete As Button
End Class
