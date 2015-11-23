Public Class Form1


    Private Sub btnAbsValue_Click(sender As Object, e As EventArgs) Handles btnAbsValue.Click
        Dim numString As String = Me.txtNum.Text
        Dim num As Double

        If IsNumeric(numString) Then
            num = numString
            Me.lblAns.Text = "The absolute value of " & num & " is " & Math.Abs(num)
        Else
            MessageBox.Show("Please enter a number.")
            Me.txtNum.Text = Nothing
        End If
    End Sub

    Private Sub btnSqRt_Click(sender As Object, e As EventArgs) Handles btnSqRt.Click
        Dim numString As String = Me.txtNum.Text
        Dim num As Double

        If IsNumeric(numString) And Val(numString) >= 0 Then
            num = numString
            Me.lblAns.Text = "The square root of " & num & " is " & Math.Sqrt(num)
        Else
            MessageBox.Show("Please enter a number greater than or equal to zero.")
            Me.txtNum.Text = Nothing
            Me.lblAns.Text = Nothing
        End If
    End Sub

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        Dim numString As String = Me.txtNum.Text
        Dim num As Double

        If IsNumeric(numString) Then
            num = numString

            If Math.Sign(num) = 1 Then
                Me.lblAns.Text = num & " is positive"
            ElseIf Math.Sign(num) = 0 Then
                Me.lblAns.Text = num & " is zero"
            ElseIf Math.Sign(num) = -1 Then
                Me.lblAns.Text = num & " is negative"
            End If

        Else
            MessageBox.Show("Please enter a number.")
            Me.txtNum.Text = Nothing
        End If
    End Sub

    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged
        Me.lblAns.Text = Nothing
    End Sub
End Class
