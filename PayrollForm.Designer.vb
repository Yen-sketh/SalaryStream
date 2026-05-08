<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollForm
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
        ComboBox1 = New ComboBox()
        DataGridView2 = New DataGridView()
        CalculationCategories = New DataGridViewTextBoxColumn()
        BtnCalculate = New Button()
        Label1 = New Label()
        Label5 = New Label()
        BtnBackRegister = New Button()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(370, 132)
        ComboBox1.Margin = New Padding(4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(354, 38)
        ComboBox1.TabIndex = 0
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {CalculationCategories})
        DataGridView2.Location = New Point(52, 206)
        DataGridView2.Margin = New Padding(4)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 62
        DataGridView2.Size = New Size(728, 504)
        DataGridView2.TabIndex = 1
        ' 
        ' CalculationCategories
        ' 
        CalculationCategories.HeaderText = "Categories"
        CalculationCategories.MinimumWidth = 8
        CalculationCategories.Name = "CalculationCategories"
        CalculationCategories.Width = 150
        ' 
        ' BtnCalculate
        ' 
        BtnCalculate.Location = New Point(646, 737)
        BtnCalculate.Margin = New Padding(4)
        BtnCalculate.Name = "BtnCalculate"
        BtnCalculate.Size = New Size(134, 41)
        BtnCalculate.TabIndex = 2
        BtnCalculate.Text = "Calculate"
        BtnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(134, 136)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 30)
        Label1.TabIndex = 3
        Label1.Text = "SELECT EMPLOYEE:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20F)
        Label5.Location = New Point(248, 11)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(307, 62)
        Label5.TabIndex = 11
        Label5.Text = "Salary Stream"
        ' 
        ' BtnBackRegister
        ' 
        BtnBackRegister.Location = New Point(52, 737)
        BtnBackRegister.Margin = New Padding(4)
        BtnBackRegister.Name = "BtnBackRegister"
        BtnBackRegister.Size = New Size(186, 41)
        BtnBackRegister.TabIndex = 12
        BtnBackRegister.Text = "Back to Register Window"
        BtnBackRegister.UseVisualStyleBackColor = True
        ' 
        ' PayrollForm
        ' 
        AcceptButton = BtnCalculate
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(821, 805)
        Controls.Add(BtnBackRegister)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(BtnCalculate)
        Controls.Add(DataGridView2)
        Controls.Add(ComboBox1)
        Margin = New Padding(4)
        Name = "PayrollForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payroll "
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents CalculationCategories As DataGridViewTextBoxColumn
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnBackRegister As Button
End Class
