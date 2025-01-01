Public Class Calculator
    Public Function Add(ByRef Num1 As Double, ByRef Num2 As Double) As Double
        Return Num1 + Num2
    End Function

    Public Function Subtract(ByRef Num1 As Double, ByRef Num2 As Double) As Double
        Return Num1 - Num2
    End Function

    Public Function Multiply(ByRef Num1 As Double, ByRef Num2 As Double) As Double
        Return Num1 * Num2
    End Function

    Public Function Divide(ByRef Num1 As Double, ByRef Num2 As Double) As Double
        If Num2.Equals(0.0) Then
            MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Else
            Return Num1 / Num2
        End If
    End Function

End Class
