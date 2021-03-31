Public Class Form4
    Dim SampleText As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SampleText = "Hey... Remember me, the rude kid that's doing a biology project..?
OK, so I was supposed to finish my project by tomorrow because I'm going to Florida, but I didn't finish on time.. So I'm going to have to bring my dad's laptop with us, and I want to work on my project there. Now, my dad's laptop is from like 1998.. it has Windows 98, and when I transferred my VB stuff there, I saw that the form is being cut off .. Now, the resolution is the same on both comptuers, 1024X768
But I noticed that the Width property of the form is 14000 in my computer (I guess VB doesn't use pixels as its units...), but on the laptop it's 10240, and I can't change it to anything greater than that. So obviously that's why my form is being cut off... which is VERY bad for me... So is that form width limit because of Windows 98? Did anyone here hear about that issue and knows if there's any way to fix it?"

        Label1.Text = String.Empty
        'Label1.Text = SampleText
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Clipboard.SetText(Label1.Text)
    End Sub
End Class