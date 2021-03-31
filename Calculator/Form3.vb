Public Class Form3

    Dim a As Decimal = 0
    Dim b As Decimal = 0
    Dim op As String

    Function Calculate()

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

        Return 0

    End Function

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, ButtonDot.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button0.Click

        If (Label1.Text = "0") Then
            Label1.Text = ""
        End If

        Label1.Text &= sender.Text

    End Sub

    Private Sub OpButton_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click, ButtonMultiply.Click, ButtonModulus.Click, ButtonMinus.Click, ButtonDivide.Click

        If (a = 0) Then
            a = Label1.Text
        Else
            Calculate()
        End If
        op = sender.Text
        Label1.Text = "0"

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click

        Label1.Text = "0"
        a = 0

    End Sub

    Private Sub ButtonResult_Click(sender As Object, e As EventArgs) Handles ButtonResult.Click

        Calculate()
        Label1.Text = a
        a = 0

    End Sub

End Class