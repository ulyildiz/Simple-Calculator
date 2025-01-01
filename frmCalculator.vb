
Public Class frmCalculator
    Dim calculator As New Calculator

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lblResult.Text = calculator.Add(CDbl(txtFirstNum.Text), CDbl(txtSecondNum.Text)).ToString()
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        lblResult.Text = calculator.Subtract(CDbl(txtFirstNum.Text), CDbl(txtSecondNum.Text)).ToString()
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        lblResult.Text = calculator.Multiply(CDbl(txtFirstNum.Text), CDbl(txtSecondNum.Text)).ToString()
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        lblResult.Text = calculator.Divide(CDbl(txtFirstNum.Text), CDbl(txtSecondNum.Text)).ToString()
    End Sub

    Private Sub txtSecondNum_TextChanged(sender As Object, e As EventArgs) Handles txtSecondNum.TextChanged
        If Not IsNumeric(txtSecondNum.Text) Then
            txtSecondNum.Clear()
            MessageBox.Show("Enter numeric input to second number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtFirstNum_TextChanged(sender As Object, e As EventArgs) Handles txtFirstNum.TextChanged
        If Not IsNumeric(txtFirstNum.Text) Then
            txtFirstNum.Clear()
            MessageBox.Show("Enter numeric input to first number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
