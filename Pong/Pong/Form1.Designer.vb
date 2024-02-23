<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PongTable
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
          Me.components = New System.ComponentModel.Container()
          Me.Ball = New System.Windows.Forms.RadioButton()
          Me.BallTimer = New System.Windows.Forms.Timer(Me.components)
          Me.RPad = New System.Windows.Forms.PictureBox()
          Me.LPad = New System.Windows.Forms.PictureBox()
          Me.Pscore = New System.Windows.Forms.TextBox()
          Me.Cscore = New System.Windows.Forms.TextBox()
          Me.Label1 = New System.Windows.Forms.Label()
          Me.Label2 = New System.Windows.Forms.Label()
          Me.ScoreBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.RPad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ball
        '
        Me.Ball.AutoSize = True
        Me.Ball.Checked = True
        Me.Ball.Location = New System.Drawing.Point(304, 213)
        Me.Ball.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Ball.Name = "Ball"
        Me.Ball.Padding = New System.Windows.Forms.Padding(1)
        Me.Ball.Size = New System.Drawing.Size(16, 15)
        Me.Ball.TabIndex = 0
        Me.Ball.TabStop = True
        Me.Ball.UseVisualStyleBackColor = True
        '
        'BallTimer
        '
        Me.BallTimer.Enabled = True
        Me.BallTimer.Interval = 25
        '
        'RPad
        '
        Me.RPad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RPad.Location = New System.Drawing.Point(600, 197)
        Me.RPad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RPad.Name = "RPad"
        Me.RPad.Size = New System.Drawing.Size(12, 47)
        Me.RPad.TabIndex = 1
        Me.RPad.TabStop = False
        '
        'LPad
        '
        Me.LPad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LPad.Location = New System.Drawing.Point(10, 197)
        Me.LPad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LPad.Name = "LPad"
        Me.LPad.Size = New System.Drawing.Size(12, 47)
        Me.LPad.TabIndex = 2
        Me.LPad.TabStop = False
        '
        'Pscore
        '
        Me.Pscore.Location = New System.Drawing.Point(597, -1)
        Me.Pscore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pscore.Name = "Pscore"
        Me.Pscore.Size = New System.Drawing.Size(28, 23)
        Me.Pscore.TabIndex = 3
        '
        'Cscore
        '
        Me.Cscore.Location = New System.Drawing.Point(-1, -1)
        Me.Cscore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cscore.Name = "Cscore"
        Me.Cscore.Size = New System.Drawing.Size(28, 23)
        Me.Cscore.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Computer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(550, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Player"
        '
        'ScoreBox
        '
        Me.ScoreBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ScoreBox.Location = New System.Drawing.Point(-8, -2)
        Me.ScoreBox.Name = "ScoreBox"
        Me.ScoreBox.Size = New System.Drawing.Size(640, 24)
        Me.ScoreBox.TabIndex = 7
        Me.ScoreBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(62, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 37)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Computer Wins"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(397, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 37)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Player Wins"
        Me.Label4.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(189, 332)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 11
        '
        'PongTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cscore)
        Me.Controls.Add(Me.Pscore)
        Me.Controls.Add(Me.LPad)
        Me.Controls.Add(Me.RPad)
        Me.Controls.Add(Me.Ball)
        Me.Controls.Add(Me.ScoreBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PongTable"
        Me.Text = "Pong"
        CType(Me.RPad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ball As RadioButton
     Friend WithEvents BallTimer As Timer
     Friend WithEvents RPad As PictureBox
     Friend WithEvents LPad As PictureBox
     Friend WithEvents Pscore As TextBox
     Friend WithEvents Cscore As TextBox
     Friend WithEvents Label1 As Label
     Friend WithEvents Label2 As Label
     Friend WithEvents ScoreBox As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
