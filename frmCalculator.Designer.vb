<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtSecondNum = New TextBox()
        txtFirstNum = New TextBox()
        lblResult = New Label()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        btnMultiply = New Button()
        btnSubtract = New Button()
        btnDivide = New Button()
        btnAdd = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtSecondNum
        ' 
        txtSecondNum.Location = New Point(12, 96)
        txtSecondNum.Name = "txtSecondNum"
        txtSecondNum.Size = New Size(303, 23)
        txtSecondNum.TabIndex = 0
        ' 
        ' txtFirstNum
        ' 
        txtFirstNum.Location = New Point(12, 49)
        txtFirstNum.Name = "txtFirstNum"
        txtFirstNum.Size = New Size(303, 23)
        txtFirstNum.TabIndex = 1
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        lblResult.Location = New Point(169, 9)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(67, 25)
        lblResult.TabIndex = 2
        lblResult.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(330, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 3
        Label2.Text = "Second number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(330, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 15)
        Label3.TabIndex = 4
        Label3.Text = "First number"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnMultiply)
        GroupBox1.Controls.Add(btnSubtract)
        GroupBox1.Controls.Add(btnDivide)
        GroupBox1.Controls.Add(btnAdd)
        GroupBox1.Location = New Point(12, 143)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(392, 229)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        btnMultiply.Location = New Point(6, 131)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(182, 83)
        btnMultiply.TabIndex = 3
        btnMultiply.Text = "Multiply (x)"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        btnSubtract.Location = New Point(204, 33)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(182, 83)
        btnSubtract.TabIndex = 2
        btnSubtract.Text = "Subtract (-)"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btnDivide
        ' 
        btnDivide.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        btnDivide.Location = New Point(204, 131)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(182, 83)
        btnDivide.TabIndex = 1
        btnDivide.Text = "Divide (÷)"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        btnAdd.Location = New Point(6, 33)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(182, 83)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add (+)"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' frmCalculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(433, 391)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblResult)
        Controls.Add(txtFirstNum)
        Controls.Add(txtSecondNum)
        Name = "frmCalculator"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSecondNum As TextBox
    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnAdd As Button

End Class
