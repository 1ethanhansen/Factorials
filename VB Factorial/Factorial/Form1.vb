'Ethan Hansen
'11-3-2017
'Does factorial operations

Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim factorial As Double = 1
        Dim number As Integer = Val(txtInput.Text)

        For count As Integer = 1 To number
            factorial *= count
        Next count

        lblOutput.Text = factorial
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        lblOutput.Text = ""
    End Sub
End Class
