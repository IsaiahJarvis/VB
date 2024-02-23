Public Class PongTable
     Dim speed As Single = 15
     Dim rndInst As New Random()
     Dim xVel As Single = Math.Cos(rndInst.Next(5, 10)) * speed
     Dim yVel As Single = Math.Sin(rndInst.Next(5, 10)) * speed
     Dim playerScore As Decimal = 0
     Dim compScore As Decimal = 0
     Dim ballStart As New Point(304, 213)
     Dim mBoxPrompt As String = "Do you want to continue?"
     Dim response As MsgBoxResult
     Dim title As String = "Pong"

     Private Sub PongTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          'hide cursor
          Windows.Forms.Cursor.Hide()
     End Sub

     Private Sub BallTimer_Tick(sender As Object, e As EventArgs) Handles BallTimer.Tick
          'reverse yVel when ball hits the ScoreBox (top)
          If Ball.Bounds.IntersectsWith(ScoreBox.Bounds) Then
               yVel = -yVel
          End If

          TextBox1.Text = xVel.ToString

          'reverse yVel when ball goes off the bottom of the form
          If Ball.Location.Y > Me.Height - Ball.Size.Height - 45 Then
               yVel = -yVel
          End If

          'reverse x direction and make new location point (to avoid the ball
          'bouncing inside the paddle) when the ball hits either paddle
          If Ball.Bounds.IntersectsWith(RPad.Bounds) Then
               xVel = -xVel
               Ball.Location = New Point(587, Ball.Location.Y)
          End If
          If Ball.Bounds.IntersectsWith(LPad.Bounds) Then
               xVel = -xVel
               Ball.Location = New Point(21, Ball.Location.Y)
          End If

          'update balls location every tick
          Ball.Location = New Point(Ball.Location.X + xVel, Ball.Location.Y + yVel)

          'unbeatable computer paddle
          If Ball.Location.Y > 5 And Ball.Location.Y < Me.Height - 40 - LPad.Height Then
               LPad.Location = New Point(LPad.Location.X, Ball.Location.Y)
          End If

          'check if a point is scored, if yes, reset the ball location and
          'check if the game is over
          If Ball.Location.X < 0 Then
               playerScore += 1
               Pscore.Text = playerScore
               Restart()
               EndGame()
          ElseIf Ball.Location.X > 640 Then
               compScore += 1
               Cscore.Text = compScore
               Restart()
               EndGame()
          End If
     End Sub

     Private Sub PongTable_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
          'make the mouse move
          If e.Y > 5 And e.Y < Me.Height - 40 - RPad.Height Then
               RPad.Location = New Point(RPad.Location.X, e.Y)
          End If

     End Sub

     Sub Restart()
          'reset only the balls location
          Ball.Location = ballStart
          rndInst = New Random()
          xVel = Math.Cos(rndInst.Next(5, 10)) * speed
          yVel = Math.Sin(rndInst.Next(5, 10)) * speed
     End Sub

     Sub EndGame()
          'if either score is at 5 the game ends
          If Pscore.Text.Equals("5") Then
               Label4.Visible = True
               Windows.Forms.Cursor.Show()
               Ball.Location = ballStart
               BallTimer.Enabled = False
               EndMenu()
               PlayWinSoundResource()
          ElseIf Cscore.Text.Equals("5") Then
               Label3.Visible = True
               Windows.Forms.Cursor.Show()
               Ball.Location = ballStart
               BallTimer.Enabled = False
               PlayLoseSoundResource()
               EndMenu()
          End If

     End Sub

     Private Sub ResetGame()
          'reset the game
          playerScore = 0
          compScore = 0
          Pscore.Text = "0"
          Cscore.Text = "0"
          Ball.Location = ballStart
          rndInst = New Random()
          xVel = Math.Cos(rndInst.Next(5, 10)) * speed
          yVel = Math.Sin(rndInst.Next(5, 10)) * speed
          Label3.Visible = False
          Windows.Forms.Cursor.Hide()
          BallTimer.Enabled = True
     End Sub

     Private Sub EndMenu()
          'close or reset game with a msg box after the game ends
          response = MsgBox(mBoxPrompt, vbYesNo, title)
          If response = vbYes Then
               ResetGame()
          Else
               Me.Close()
          End If
     End Sub

     Sub PlayWinSoundResource()
          'play the win sound (just here for formality since winning isnt possible)
          My.Computer.Audio.Play(My.Resources.gameOverSound,
              AudioPlayMode.Background)
     End Sub

     Sub PlayLoseSoundResource()
          'play the lose sound
          My.Computer.Audio.Play(My.Resources.gameOverSound,
              AudioPlayMode.Background)
     End Sub

End Class