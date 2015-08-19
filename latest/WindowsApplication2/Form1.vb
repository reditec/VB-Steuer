Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = 1
        Dim str As String = ""
        Do

            str = str & x.ToString() & Environment.NewLine & (Int(x) * 0.19).ToString() & Environment.NewLine & (Int(x) / 1.19).ToString() & Environment.NewLine & Environment.NewLine
            x = x + 1
        Loop Until x = 10000
        TextBox1.Text = str
    End Sub
End Class
