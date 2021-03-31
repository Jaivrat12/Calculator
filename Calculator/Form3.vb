Public Class Form3

    Dim a As Decimal = 0
    Dim b As Decimal = 0
    Dim op As String
    Dim f4 As New Form4()

    Function Calculate()
        f4.Label1.Text &= $"Processing {a} {op} {Label1.Text}"
        If (op = "+") Then
            a += Label1.Text
        ElseIf (op = "-") Then
            a -= Label1.Text
        ElseIf (op = "x") Then
            a *= Label1.Text
        ElseIf (op = "/") Then
            a /= Label1.Text
        ElseIf (op = "%") Then
            a = a Mod Label1.Text
        End If
        f4.Label1.Text &= $" (a = {a}){vbCrLf}"
        Set_Title()

        Return 0

    End Function

    Private Sub Set_Title()
        f4.Text = $"(a = {a})"
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        f4.Show()
        Set_Title()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click, ButtonDot.Click, Button9.Click,
        Button8.Click, Button7.Click, Button6.Click, Button5.Click,
        Button4.Click, Button3.Click, Button2.Click, Button0.Click

        If (Label1.Text = "0") Then
            Label1.Text = ""
        End If
        f4.Label1.Text &= $"Pressed {sender.text}{vbCrLf}"
        Label1.Text &= sender.Text

    End Sub

    Private Sub OpButton_Click(sender As Object, e As EventArgs) _
        Handles ButtonPlus.Click, ButtonMultiply.Click, ButtonModulus.Click,
        ButtonMinus.Click, ButtonDivide.Click

        f4.Label1.Text &= $"{sender.name} click {vbCrLf}"
        If (a = 0) Then
            a = Label1.Text
            'f4.Label1.Text &= $"set a = {a}{vbCrLf}"
            Set_Title()
        Else
            Calculate()
        End If
        op = sender.Text
        Label1.Text = "0"

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) _
        Handles ButtonClear.Click

        Label1.Text = "0"
        a = 0
        f4.Label1.Text &= $"CLEAR (A = {a}){vbCrLf}"
        Set_Title()

    End Sub

    Private Sub ButtonResult_Click(sender As Object, e As EventArgs) _
        Handles ButtonResult.Click

        Calculate()
        Label1.Text = a
        a = 0

    End Sub

End Class