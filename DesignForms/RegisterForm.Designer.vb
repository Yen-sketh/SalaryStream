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
        btnUpdate = New Button()
        btnMainList = New Button()
        btnDelete = New Button()
        cboxPosition = New ComboBox()
        cboxEmployee = New ComboBox()
        Panel1 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightGray
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(0, 42)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 45)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.Location = New Point(0, 147)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 45)
        Label2.TabIndex = 1
        Label2.Text = "Position:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(607, 156)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 32)
        Label3.TabIndex = 2
        Label3.Text = "Daily Rate:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F)
        Label4.Location = New Point(607, 42)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(193, 45)
        Label4.TabIndex = 3
        Label4.Text = "Attendance:"
        ' 
        ' txtboxName
        ' 
        txtboxName.Font = New Font("Segoe UI", 12F)
        txtboxName.Location = New Point(0, 89)
        txtboxName.Margin = New Padding(2)
        txtboxName.Name = "txtboxName"
        txtboxName.Size = New Size(588, 45)
        txtboxName.TabIndex = 4
        ' 
        ' txtboxPosition
        ' 
        txtboxPosition.Font = New Font("Segoe UI", 12F)
        txtboxPosition.Location = New Point(0, 194)
        txtboxPosition.Margin = New Padding(2)
        txtboxPosition.Name = "txtboxPosition"
        txtboxPosition.Size = New Size(588, 45)
        txtboxPosition.TabIndex = 5
        ' 
        ' txtboxAttendance
        ' 
        txtboxAttendance.Font = New Font("Segoe UI", 12F)
        txtboxAttendance.Location = New Point(607, 89)
        txtboxAttendance.Margin = New Padding(2)
        txtboxAttendance.Name = "txtboxAttendance"
        txtboxAttendance.PlaceholderText = "0"
        txtboxAttendance.Size = New Size(326, 45)
        txtboxAttendance.TabIndex = 6
        ' 
        ' txtboxDailyRate
        ' 
        txtboxDailyRate.Font = New Font("Segoe UI", 12F)
        txtboxDailyRate.Location = New Point(607, 190)
        txtboxDailyRate.Margin = New Padding(2)
        txtboxDailyRate.Name = "txtboxDailyRate"
        txtboxDailyRate.PlaceholderText = "0"
        txtboxDailyRate.Size = New Size(152, 45)
        txtboxDailyRate.TabIndex = 7
        ' 
        ' txtboxOvertime
        ' 
        txtboxOvertime.Font = New Font("Segoe UI", 12F)
        txtboxOvertime.Location = New Point(783, 190)
        txtboxOvertime.Margin = New Padding(2)
        txtboxOvertime.Name = "txtboxOvertime"
        txtboxOvertime.PlaceholderText = "0"
        txtboxOvertime.Size = New Size(150, 45)
        txtboxOvertime.TabIndex = 9
        ' 
        ' z
        ' 
        z.AutoSize = True
        z.Font = New Font("Segoe UI", 10F)
        z.Location = New Point(783, 160)
        z.Margin = New Padding(2, 0, 2, 0)
        z.Name = "z"
        z.Size = New Size(118, 32)
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
        Label5.Location = New Point(438, 9)
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
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Name"
        Column1.MinimumWidth = 9
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Position"
        Column2.MinimumWidth = 9
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Daily Rate"
        Column3.MinimumWidth = 9
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Attendance (days worked)"
        Column4.MinimumWidth = 9
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column5.HeaderText = "Overtime (in hrs)"
        Column5.MinimumWidth = 9
        Column5.Name = "Column5"
        ' 
        ' btnDone
        ' 
        btnDone.Location = New Point(937, 89)
        btnDone.Margin = New Padding(2)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(506, 45)
        btnDone.TabIndex = 17
        btnDone.Text = "Add Employee"
        btnDone.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Gray
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(938, 190)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(506, 45)
        btnClear.TabIndex = 18
        btnClear.Text = "Clear Form"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13F)
        Label6.Location = New Point(48, 393)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(258, 42)
        Label6.TabIndex = 19
        Label6.Text = "Search Employee:"
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Font = New Font("Segoe UI", 13F)
        lbl.Location = New Point(655, 393)
        lbl.Margin = New Padding(2, 0, 2, 0)
        lbl.Name = "lbl"
        lbl.Size = New Size(417, 42)
        lbl.TabIndex = 22
        lbl.Text = "Search by Employee Position:"
        ' 
        ' BtnPayRoll
        ' 
        BtnPayRoll.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        BtnPayRoll.FlatStyle = FlatStyle.Popup
        BtnPayRoll.Location = New Point(1063, 866)
        BtnPayRoll.Margin = New Padding(4)
        BtnPayRoll.Name = "BtnPayRoll"
        BtnPayRoll.Size = New Size(429, 68)
        BtnPayRoll.TabIndex = 25
        BtnPayRoll.Text = "Calculate  Payroll"
        BtnPayRoll.UseVisualStyleBackColor = False
        ' 
        ' btnLogOut
        ' 
        btnLogOut.FlatStyle = FlatStyle.Popup
        btnLogOut.Location = New Point(48, 866)
        btnLogOut.Margin = New Padding(2)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(430, 68)
        btnLogOut.TabIndex = 30
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Location = New Point(483, 866)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(573, 68)
        btnUpdate.TabIndex = 33
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnMainList
        ' 
        btnMainList.Location = New Point(48, 457)
        btnMainList.Name = "btnMainList"
        btnMainList.Size = New Size(1443, 48)
        btnMainList.TabIndex = 34
        btnMainList.Text = "Show List"
        btnMainList.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Salmon
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Location = New Point(483, 940)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(573, 68)
        btnDelete.TabIndex = 35
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' cboxPosition
        ' 
        cboxPosition.FormattingEnabled = True
        cboxPosition.Location = New Point(1077, 399)
        cboxPosition.Name = "cboxPosition"
        cboxPosition.Size = New Size(414, 38)
        cboxPosition.TabIndex = 37
        ' 
        ' cboxEmployee
        ' 
        cboxEmployee.FormattingEnabled = True
        cboxEmployee.Location = New Point(322, 393)
        cboxEmployee.Name = "cboxEmployee"
        cboxEmployee.Size = New Size(314, 38)
        cboxEmployee.TabIndex = 38
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtboxName)
        Panel1.Controls.Add(txtboxPosition)
        Panel1.Controls.Add(txtboxAttendance)
        Panel1.Controls.Add(txtboxDailyRate)
        Panel1.Controls.Add(z)
        Panel1.Controls.Add(txtboxOvertime)
        Panel1.Controls.Add(btnDone)
        Panel1.Controls.Add(btnClear)
        Panel1.Location = New Point(48, 123)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1444, 252)
        Panel1.TabIndex = 39
        ' 
        ' RegisterForm
        ' 
        AcceptButton = btnDone
        AutoScaleDimensions = New SizeF(168F, 168F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        BackColor = Color.FromArgb(CByte(237), CByte(233), CByte(230))
        ClientSize = New Size(1532, 1028)
        Controls.Add(Panel1)
        Controls.Add(cboxEmployee)
        Controls.Add(cboxPosition)
        Controls.Add(btnDelete)
        Controls.Add(btnMainList)
        Controls.Add(btnUpdate)
        Controls.Add(btnLogOut)
        Controls.Add(BtnPayRoll)
        Controls.Add(lbl)
        Controls.Add(Label6)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        ForeColor = Color.FromArgb(CByte(59), CByte(117), CByte(151))
        Margin = New Padding(2)
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register Employee"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents btnDone As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl As Label
    Friend WithEvents BtnPayRoll As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnMainList As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents cboxPosition As ComboBox
    Friend WithEvents cboxEmployee As ComboBox
    Friend WithEvents Panel1 As Panel
End Class
