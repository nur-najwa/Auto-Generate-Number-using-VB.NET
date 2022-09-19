Public Class Form1

    Dim x As String = ""
    Dim rand As Random = New Random()

    Sub generate()
        For y As Integer = 1 To 7
            x = Date.Now.Year
            If y = 7 Then
                x += "000"
            End If
        Next
        For y As Integer = 1 To 6
            x += Convert.ToString(rand.Next(0, 9))
        Next

        AutoNumbers.Text = x
        If AutoNumbers.Text = x Then
            x = Nothing
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        generate()
    End Sub
End Class
