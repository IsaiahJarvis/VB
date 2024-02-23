Public Class Form1

    Public H, M, S As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        S += 1
        If S = 60 Then
            M += 1
            S = 0
        ElseIf M = 60 Then
            H += 1
            M = 0
        End If

        Label1.Text = H.ToString("00") & ":" & M.ToString("00") & ":" & S.ToString("00")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled Then
            Timer1.Stop()
            Button1.Text = "Stop"
        ElseIf Not Timer1.Enabled Then
            Timer1.Start()
            Button1.Text = "Start"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = ("00:00:00")
        H = 0
        M = 0
        S = 0
        Button1.Text = "Start"
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
