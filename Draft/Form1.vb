Public Class Form1
    Public Shared i As New Random
    Public Shared x As Integer
    Public Shared y As Integer
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        TextBox1.Focus()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox1.Focused And TextBox1.Text = "a" Then
            TextBox2.Focus()
        End If
        If TextBox2.Focused And TextBox2.Text = "a" Then
            TextBox3.Focus()
        End If
    End Sub
End Class
