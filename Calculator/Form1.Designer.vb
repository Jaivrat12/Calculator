<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Num1 = New System.Windows.Forms.TextBox()
        Me.Num2 = New System.Windows.Forms.TextBox()
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.Subtract_Button = New System.Windows.Forms.Button()
        Me.Multiply_Button = New System.Windows.Forms.Button()
        Me.Divide_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NUM 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NUM 2:"
        '
        'Num1
        '
        Me.Num1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Num1.Location = New System.Drawing.Point(115, 43)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(167, 24)
        Me.Num1.TabIndex = 2
        '
        'Num2
        '
        Me.Num2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Num2.Location = New System.Drawing.Point(115, 85)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(167, 24)
        Me.Num2.TabIndex = 3
        '
        'Add_Button
        '
        Me.Add_Button.BackColor = System.Drawing.Color.Indigo
        Me.Add_Button.Location = New System.Drawing.Point(65, 131)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(84, 34)
        Me.Add_Button.TabIndex = 4
        Me.Add_Button.Text = "ADD"
        Me.Add_Button.UseVisualStyleBackColor = False
        '
        'Subtract_Button
        '
        Me.Subtract_Button.BackColor = System.Drawing.Color.Indigo
        Me.Subtract_Button.Location = New System.Drawing.Point(173, 131)
        Me.Subtract_Button.Name = "Subtract_Button"
        Me.Subtract_Button.Size = New System.Drawing.Size(83, 34)
        Me.Subtract_Button.TabIndex = 7
        Me.Subtract_Button.Text = "SUBTRACT"
        Me.Subtract_Button.UseVisualStyleBackColor = False
        '
        'Multiply_Button
        '
        Me.Multiply_Button.BackColor = System.Drawing.Color.Indigo
        Me.Multiply_Button.Location = New System.Drawing.Point(65, 184)
        Me.Multiply_Button.Name = "Multiply_Button"
        Me.Multiply_Button.Size = New System.Drawing.Size(84, 34)
        Me.Multiply_Button.TabIndex = 8
        Me.Multiply_Button.Text = "MULTIPLY"
        Me.Multiply_Button.UseVisualStyleBackColor = False
        '
        'Divide_Button
        '
        Me.Divide_Button.BackColor = System.Drawing.Color.Indigo
        Me.Divide_Button.Location = New System.Drawing.Point(173, 184)
        Me.Divide_Button.Name = "Divide_Button"
        Me.Divide_Button.Size = New System.Drawing.Size(84, 34)
        Me.Divide_Button.TabIndex = 9
        Me.Divide_Button.Text = "DIVIDE"
        Me.Divide_Button.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(321, 250)
        Me.Controls.Add(Me.Divide_Button)
        Me.Controls.Add(Me.Multiply_Button)
        Me.Controls.Add(Me.Subtract_Button)
        Me.Controls.Add(Me.Add_Button)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Num1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Name = "Form1"
        Me.Text = "Calculator 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Num1 As TextBox
    Friend WithEvents Num2 As TextBox
    Friend WithEvents Add_Button As Button
    Friend WithEvents Subtract_Button As Button
    Friend WithEvents Multiply_Button As Button
    Friend WithEvents Divide_Button As Button
End Class
