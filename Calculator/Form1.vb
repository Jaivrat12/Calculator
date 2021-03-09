Public Class Form1

    Private Sub Sum_Click(sender As Object, e As EventArgs) Handles Add_Button.Click

        Dim a, b As Integer
        a = Num1.Text
        b = Num2.Text

        MessageBox.Show(a + b)

    End Sub

    Private Sub Subtract_Click(sender As Object, e As EventArgs) Handles Subtract_Button.Click

        Dim a, b As Integer
        a = Num1.Text
        b = Num2.Text

        MessageBox.Show(a - b)

    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply_Button.Click

        Dim a, b As Integer
        a = Num1.Text
        b = Num2.Text

        MessageBox.Show(a * b)

    End Sub

    Private Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide_Button.Click

        Dim a, b As Integer
        a = Num1.Text
        b = Num2.Text

        MessageBox.Show(a / b)

    End Sub

End Class
