<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DegF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DegC = New System.Windows.Forms.TextBox()
        Me.convert = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DegF
        '
        Me.DegF.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DegF.Location = New System.Drawing.Point(181, 74)
        Me.DegF.Name = "DegF"
        Me.DegF.Size = New System.Drawing.Size(211, 45)
        Me.DegF.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "deg F"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "deg C"
        '
        'DegC
        '
        Me.DegC.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DegC.Location = New System.Drawing.Point(181, 158)
        Me.DegC.Name = "DegC"
        Me.DegC.Size = New System.Drawing.Size(211, 45)
        Me.DegC.TabIndex = 2
        '
        'convert
        '
        Me.convert.Location = New System.Drawing.Point(45, 241)
        Me.convert.Name = "convert"
        Me.convert.Size = New System.Drawing.Size(347, 43)
        Me.convert.TabIndex = 5
        Me.convert.Text = "Convert"
        Me.convert.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(45, 304)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(347, 43)
        Me.clear.TabIndex = 6
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 369)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.convert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DegC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DegF)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DegF As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DegC As TextBox
    Friend WithEvents convert As Button
    Friend WithEvents clear As Button
End Class
