Public Class Form1
    Private Sub convert_Click(sender As Object, e As EventArgs) Handles convert.Click
        If String.IsNullOrEmpty(DegC.Text) Then
            Dim num As Decimal
            Try
                num = Decimal.Parse(DegF.Text)
            Catch ex As Exception
                MsgBox("Please only enter numbers")
            End Try

            If num <= 150 And num >= -150 Then
                num = (num - 32) * 5 / 9
                DegC.Text = num
            Else
                MsgBox("Number must be no greater than 150 in magnitude")
            End If

        ElseIf String.IsNullOrEmpty(DegF.Text) Then
            Dim num As Decimal
            Try
                num = Decimal.Parse(DegC.Text)
            Catch ex As Exception
                MsgBox("Please only enter numbers")
            End Try

            If num <= 150 And num >= -150 Then
                num = (num * 9 / 5) + 32
                DegF.Text = num
            Else
                MsgBox("Number must be no greater than 150 in magnitude")
            End If
        ElseIf (Not String.IsNullOrEmpty(DegF.Text) And Not String.IsNullOrEmpty(DegC.Text)) Then
            MsgBox("Please only enter one value")
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        DegC.Text = Nothing
        DegF.Text = Nothing
    End Sub
End Class
