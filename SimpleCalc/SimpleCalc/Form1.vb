Public Class Form1
     Dim firstNum As Decimal
     Dim secondNum As Decimal
     Dim operation As Integer
     Dim selector As Boolean = False

     Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click
          removeNaN()

          If TextBox1.Text <> "0" Then
               TextBox1.Text += "0"
          End If
     End Sub

     Private Sub one_Click(sender As Object, e As EventArgs) Handles one.Click
          removeNaN()

          If TextBox1.Text <> "0" Then
               TextBox1.Text += "1"
          Else
               TextBox1.Text = "1"
          End If
     End Sub

     Private Sub two_Click(sender As Object, e As EventArgs) Handles two.Click
          removeNaN()

          If TextBox1.Text <> "0" Then
               TextBox1.Text += "2"
          Else
               TextBox1.Text = "2"
          End If
     End Sub

     Private Sub three_Click(sender As Object, e As EventArgs) Handles three.Click
          removeNaN()

          If TextBox1.Text <> "0" Then
               TextBox1.Text += "3"
          Else
               TextBox1.Text = "3"
          End If
     End Sub

     Private Sub four_Click(sender As Object, e As EventArgs) Handles four.Click
          removeNaN()

          If TextBox1.Text <> "0" Then
               TextBox1.Text += "4"
          Else
               TextBox1.Text = "4"
          End If
     End Sub

     Private Sub five_Click(sender As Object, e As EventArgs) Handles five.Click
          removeNaN()

          If TextBox1.Text <> "0" Then
               TextBox1.Text += "5"
          Else
               TextBox1.Text = "5"
          End If
     End Sub

     Private Sub six_Click(sender As Object, e As EventArgs) Handles six.Click
          removeNaN()

          If TextBox1.Text <> "0" Then
               TextBox1.Text += "6"
          Else
               TextBox1.Text = "6"
          End If
     End Sub

     Private Sub seven_Click(sender As Object, e As EventArgs) Handles seven.Click
          removeNaN()

          If TextBox1.Text <> "0" Then
               TextBox1.Text += "7"
          Else
               TextBox1.Text = "7"
          End If
     End Sub

     Private Sub eight_Click(sender As Object, e As EventArgs) Handles eight.Click
          removeNaN()

          If TextBox1.Text <> "0" Then
               TextBox1.Text += "8"
          Else
               TextBox1.Text = "8"
          End If
     End Sub

     Private Sub nine_Click(sender As Object, e As EventArgs) Handles nine.Click
          removeNaN()

          If TextBox1.Text <> "0" Then
               TextBox1.Text += "9"
          Else
               TextBox1.Text = "9"
          End If
     End Sub

     Private Sub dot_Click(sender As Object, e As EventArgs) Handles dot.Click
          removeNaN()

          If Not TextBox1.Text.Contains(".") Then
               TextBox1.Text += "."
          End If
     End Sub

     Private Sub c_Click(sender As Object, e As EventArgs) Handles c.Click
          TextBox1.Text = "0"
     End Sub

     Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
          TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
     End Sub

     Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
          firstNum = TextBox1.Text
          TextBox1.Text = "0"
          selector = True
          operation = 0
     End Sub

     Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
          firstNum = TextBox1.Text
          TextBox1.Text = "0"
          selector = True
          operation = 1
     End Sub

     Private Sub mult_Click(sender As Object, e As EventArgs) Handles mult.Click
          firstNum = TextBox1.Text
          TextBox1.Text = "0"
          selector = True
          operation = 2
     End Sub

     Private Sub divide_Click(sender As Object, e As EventArgs) Handles divide.Click
          firstNum = TextBox1.Text
          TextBox1.Text = "0"
          selector = True
          operation = 3
     End Sub

     Private Sub equals_Click(sender As Object, e As EventArgs) Handles equals.Click
          secondNum = TextBox1.Text
          TextBox1.Text = "0"
          Try
               If selector.Equals(True) Then
                    If operation.Equals(0) Then
                         TextBox1.Text = (firstNum + secondNum)
                    ElseIf operation.Equals(1) Then
                         TextBox1.Text = firstNum - secondNum
                    ElseIf operation.Equals(2) Then
                         TextBox1.Text = firstNum * secondNum
                    ElseIf operation.Equals(3) Then
                         TextBox1.Text = firstNum / secondNum
                    End If
               End If
          Catch ex As Exception
               TextBox1.Text = "NaN"
          End Try

     End Sub

     Sub removeNaN()
          If TextBox1.Text = "NaN" Then
               TextBox1.Text = "0"
          End If
     End Sub

End Class