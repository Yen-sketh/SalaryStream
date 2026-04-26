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
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        Name = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 30)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 30)
        Label2.TabIndex = 1
        Label2.Text = "Position:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(342, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 30)
        Label3.TabIndex = 2
        Label3.Text = "Daily Rate:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(342, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 30)
        Label4.TabIndex = 3
        Label4.Text = "Attendance:"
        ' 
        ' txtboxName
        ' 
        txtboxName.Location = New Point(88, 99)
        txtboxName.Name = "txtboxName"
        txtboxName.Size = New Size(175, 35)
        txtboxName.TabIndex = 4
        ' 
        ' txtboxPosition
        ' 
        txtboxPosition.Location = New Point(105, 174)
        txtboxPosition.Name = "txtboxPosition"
        txtboxPosition.Size = New Size(175, 35)
        txtboxPosition.TabIndex = 5
        ' 
        ' txtboxAttendance
        ' 
        txtboxAttendance.Location = New Point(473, 177)
        txtboxAttendance.Name = "txtboxAttendance"
        txtboxAttendance.Size = New Size(175, 35)
        txtboxAttendance.TabIndex = 6
        ' 
        ' txtboxDailyRate
        ' 
        txtboxDailyRate.Location = New Point(473, 99)
        txtboxDailyRate.Name = "txtboxDailyRate"
        txtboxDailyRate.Size = New Size(175, 35)
        txtboxDailyRate.TabIndex = 7
        ' 
        ' txtboxOvertime
        ' 
        txtboxOvertime.Location = New Point(773, 102)
        txtboxOvertime.Name = "txtboxOvertime"
        txtboxOvertime.Size = New Size(150, 35)
        txtboxOvertime.TabIndex = 9
        ' 
        ' z
        ' 
        z.AutoSize = True
        z.Location = New Point(664, 102)
        z.Name = "z"
        z.Size = New Size(103, 30)
        z.TabIndex = 8
        z.Text = "Overtime:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20F)
        Label5.Location = New Point(316, 9)
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(25, 250)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(915, 35)
        TextBox1.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Name, Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(25, 317)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 72
        DataGridView1.Size = New Size(945, 439)
        DataGridView1.TabIndex = 14
        ' 
        ' Name
        ' 
        Name.HeaderText = "Name"
        Name.MinimumWidth = 9
        Name.Name = "Name"
        Name.Width = 175
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Position"
        Column1.MinimumWidth = 9
        Column1.Name = "Column1"
        Column1.Width = 175
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Daily Rate"
        Column2.MinimumWidth = 9
        Column2.Name = "Column2"
        Column2.Width = 175
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Attendance (days worked)"
        Column3.MinimumWidth = 9
        Column3.Name = "Column3"
        Column3.Width = 175
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Overtime (in hrs)"
        Column4.MinimumWidth = 9
        Column4.Name = "Column4"
        Column4.Width = 175
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 768)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
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
        Name = "RegisterForm"
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
