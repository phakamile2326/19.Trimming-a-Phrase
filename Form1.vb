Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Azure
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim MyPhrase As String
        MyPhrase = InputBox("Enter Your Phrase")
        TextBox1.Text = Trim(MyPhrase)
    End Sub
End Class
