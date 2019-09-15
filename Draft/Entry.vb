Public Class Entry
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LowLoad.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HighLoad.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DemoHigh.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DemoLow.Show()
        Me.Hide()
    End Sub
End Class
Public Class GlobalVariables
    'Declare a variable that can be accessed by public
    Public Shared SoundID As Integer
    Public Shared CorrectSoundID As Integer
    Public Shared LetterID As String = ""
    Public Shared TrialNumber As Integer = 0
    Public Shared TonePlayed As Boolean = False
    Public Shared VisualTaskCorrect As Integer = 0
End Class