Public Class DemoLow
    Private Sub RandomizeArray(ByVal items() As String)
        Dim max_index As Integer = items.Length - 1
        Dim rnd As New Random
        For i As Integer = 0 To max_index - 1
            ' Pick an item for position i.
            Dim j As Integer = rnd.Next(i, max_index + 1)

            ' Swap them.
            Dim temp As String = items(i)
            items(i) = items(j)
            items(j) = temp
        Next i
    End Sub

    Private Sub CenterDot_Click(sender As Object, e As EventArgs) Handles CenterDot.Click

    End Sub

    Private Sub Demo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        o1.Hide()
        o2.Hide()
        o3.Hide()
        o4.Hide()
        o5.Hide()
        o6.Hide()
        QuestionMark.Hide()
        CenterDot.Hide()
        SoundCount.Hide()
        CloseButton.Hide()
    End Sub

    Private Sub Start_KeyDown(sender As Object, e As KeyEventArgs) Handles StartButton.KeyDown
        If e.KeyCode = Keys.Up And TrackSoundID.Enabled = True And GlobalVariables.TrialNumber < 8 Then
            GlobalVariables.SoundID = GlobalVariables.SoundID + 1
            If GlobalVariables.TrialNumber = 2 Or GlobalVariables.TrialNumber = 5 Then
                GlobalVariables.CorrectSoundID = GlobalVariables.CorrectSoundID + 1
            End If
            TrackSoundID.Stop()
        End If
        If e.KeyCode = Keys.Left And TrackTask.Enabled = True Then
            GlobalVariables.LetterID = "X"
            TrackTask.Stop()
        ElseIf e.KeyCode = Keys.Right And TrackTask.Enabled = True Then
            GlobalVariables.LetterID = "N"
            TrackTask.Stop()
        End If
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        If GlobalVariables.TrialNumber = 2 Then
            My.Computer.Audio.Play(My.Resources.DeviantTone, AudioPlayMode.Background)
            GlobalVariables.TonePlayed = True
            o1.Show()
            o2.Show()
            o3.Show()
            o4.Show()
            o5.Show()
            o6.Show()
            CenterDot.Hide()
            Timer11.Stop()
            Timer22.Start()
            TrackTask.Start()
        Else
            GlobalVariables.TonePlayed = False
            o1.Show()
            o2.Show()
            o3.Show()
            o4.Show()
            o5.Show()
            o6.Show()
            CenterDot.Hide()
            Timer11.Stop()
            Timer22.Start()
            TrackTask.Start()
        End If
    End Sub

    Private Sub Timer22_Tick(sender As Object, e As EventArgs) Handles Timer22.Tick
        o1.Hide()
        o2.Hide()
        o3.Hide()
        o4.Hide()
        o5.Hide()
        o6.Hide()
        Timer22.Stop()
        My.Computer.Audio.Stop()
        Timer33.Start()
    End Sub

    Private Sub Timer33_Tick(sender As Object, e As EventArgs) Handles Timer33.Tick
        QuestionMark.Show()
        Timer33.Stop()
        Timer44.Start()
        TrackSoundID.Start()
        TrackTask.Stop()
    End Sub

    Private Sub Timer44_Tick(sender As Object, e As EventArgs) Handles Timer44.Tick
        QuestionMark.Hide()
        Timer44.Stop()
        Timer55.Start()
    End Sub

    Private Sub Timer55_Tick(sender As Object, e As EventArgs) Handles Timer55.Tick
        Timer55.Stop()
        StartButton.Show()
        TrackSoundID.Stop()
        If GlobalVariables.LetterID = "X" And GlobalVariables.TrialNumber < 8 Then
            If o1.Text = "X" Or o2.Text = "X" Or o3.Text = "X" Or o4.Text = "X" Or o5.Text = "X" Or o6.Text = "X" Then
                SearchTaskResult.Text = "Letter ID Correct!"
                GlobalVariables.VisualTaskCorrect = GlobalVariables.VisualTaskCorrect + 1
            Else
                SearchTaskResult.Text = "Letter ID Incorrect!"
            End If
        ElseIf GlobalVariables.LetterID = "N" And GlobalVariables.TrialNumber < 8 Then
            If o1.Text = "N" Or o2.Text = "N" Or o3.Text = "N" Or o4.Text = "N" Or o5.Text = "N" Or o6.Text = "N" Then
                SearchTaskResult.Text = "Letter ID Correct!"
                GlobalVariables.VisualTaskCorrect = GlobalVariables.VisualTaskCorrect + 1
            Else
                SearchTaskResult.Text = "Letter ID Incorrect!"
            End If
        ElseIf GlobalVariables.TrialNumber < 8 Then
            SearchTaskResult.Text = "Letter ID Incorrect!"
        End If
        SearchTaskResult.Show()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        GlobalVariables.LetterID = ""
        GlobalVariables.TrialNumber = GlobalVariables.TrialNumber + 1
        If GlobalVariables.TrialNumber > 1 Then
            Delay.Interval = 2000
            Timer11.Interval = 1000
            Timer22.Interval = 150
            Timer33.Interval = 1850
            Timer44.Interval = 150
            Timer55.Interval = 1850
        End If
        Delay.Start()
        Dim i As Integer
        Dim rdm As New Random
        i = rdm.Next(1, 13)
        If i = 1 Then
            o1.Text = "X"
            o2.Text = "O"
            o3.Text = "O"
            o4.Text = "O"
            o5.Text = "O"
            o6.Text = "O"
            o1.Font = New Font("Times New Roman", 36)
            o2.Font = New Font("Times New Roman", 20)
            o3.Font = New Font("Times New Roman", 20)
            o4.Font = New Font("Times New Roman", 20)
            o5.Font = New Font("Times New Roman", 20)
            o6.Font = New Font("Times New Roman", 20)
        ElseIf i = 2 Then
            o2.Text = "X"
            o1.Text = "O"
            o3.Text = "O"
            o4.Text = "O"
            o5.Text = "O"
            o6.Text = "O"
            o2.Font = New Font("Times New Roman", 36)
            o1.Font = New Font("Times New Roman", 20)
            o3.Font = New Font("Times New Roman", 20)
            o4.Font = New Font("Times New Roman", 20)
            o5.Font = New Font("Times New Roman", 20)
            o6.Font = New Font("Times New Roman", 20)
        ElseIf i = 3 Then
            o3.Text = "X"
            o2.Text = "O"
            o1.Text = "O"
            o4.Text = "O"
            o5.Text = "O"
            o6.Text = "O"
            o3.Font = New Font("Times New Roman", 36)
            o2.Font = New Font("Times New Roman", 20)
            o1.Font = New Font("Times New Roman", 20)
            o4.Font = New Font("Times New Roman", 20)
            o5.Font = New Font("Times New Roman", 20)
            o6.Font = New Font("Times New Roman", 20)
        ElseIf i = 4 Then
            o4.Text = "X"
            o2.Text = "O"
            o3.Text = "O"
            o1.Text = "O"
            o5.Text = "O"
            o6.Text = "O"
            o4.Font = New Font("Times New Roman", 36)
            o2.Font = New Font("Times New Roman", 20)
            o3.Font = New Font("Times New Roman", 20)
            o1.Font = New Font("Times New Roman", 20)
            o5.Font = New Font("Times New Roman", 20)
            o6.Font = New Font("Times New Roman", 20)
        ElseIf i = 5 Then
            o5.Text = "X"
            o2.Text = "O"
            o3.Text = "O"
            o4.Text = "O"
            o1.Text = "O"
            o6.Text = "O"
            o5.Font = New Font("Times New Roman", 36)
            o2.Font = New Font("Times New Roman", 20)
            o3.Font = New Font("Times New Roman", 20)
            o4.Font = New Font("Times New Roman", 20)
            o1.Font = New Font("Times New Roman", 20)
            o6.Font = New Font("Times New Roman", 20)
        ElseIf i = 6 Then
            o6.Text = "X"
            o2.Text = "O"
            o3.Text = "O"
            o4.Text = "O"
            o5.Text = "O"
            o1.Text = "O"
            o6.Font = New Font("Times New Roman", 36)
            o2.Font = New Font("Times New Roman", 20)
            o3.Font = New Font("Times New Roman", 20)
            o4.Font = New Font("Times New Roman", 20)
            o5.Font = New Font("Times New Roman", 20)
            o1.Font = New Font("Times New Roman", 20)
        ElseIf i = 7 Then
            o1.Text = "N"
            o2.Text = "O"
            o3.Text = "O"
            o4.Text = "O"
            o5.Text = "O"
            o6.Text = "O"
            o1.Font = New Font("Times New Roman", 36)
            o2.Font = New Font("Times New Roman", 20)
            o3.Font = New Font("Times New Roman", 20)
            o4.Font = New Font("Times New Roman", 20)
            o5.Font = New Font("Times New Roman", 20)
            o6.Font = New Font("Times New Roman", 20)
        ElseIf i = 8 Then
            o2.Text = "N"
            o1.Text = "O"
            o3.Text = "O"
            o4.Text = "O"
            o5.Text = "O"
            o6.Text = "O"
            o2.Font = New Font("Times New Roman", 36)
            o1.Font = New Font("Times New Roman", 20)
            o3.Font = New Font("Times New Roman", 20)
            o4.Font = New Font("Times New Roman", 20)
            o5.Font = New Font("Times New Roman", 20)
            o6.Font = New Font("Times New Roman", 20)
        ElseIf i = 9 Then
            o3.Text = "N"
            o2.Text = "O"
            o1.Text = "O"
            o4.Text = "O"
            o5.Text = "O"
            o6.Text = "O"
            o3.Font = New Font("Times New Roman", 36)
            o2.Font = New Font("Times New Roman", 20)
            o1.Font = New Font("Times New Roman", 20)
            o4.Font = New Font("Times New Roman", 20)
            o5.Font = New Font("Times New Roman", 20)
            o6.Font = New Font("Times New Roman", 20)
        ElseIf i = 10 Then
            o4.Text = "N"
            o2.Text = "O"
            o3.Text = "O"
            o1.Text = "O"
            o5.Text = "O"
            o6.Text = "O"
            o4.Font = New Font("Times New Roman", 36)
            o2.Font = New Font("Times New Roman", 20)
            o3.Font = New Font("Times New Roman", 20)
            o1.Font = New Font("Times New Roman", 20)
            o5.Font = New Font("Times New Roman", 20)
            o6.Font = New Font("Times New Roman", 20)
        ElseIf i = 11 Then
            o5.Text = "N"
            o2.Text = "O"
            o3.Text = "O"
            o4.Text = "O"
            o1.Text = "O"
            o6.Text = "O"
            o5.Font = New Font("Times New Roman", 36)
            o2.Font = New Font("Times New Roman", 20)
            o3.Font = New Font("Times New Roman", 20)
            o4.Font = New Font("Times New Roman", 20)
            o1.Font = New Font("Times New Roman", 20)
            o6.Font = New Font("Times New Roman", 20)
        ElseIf i = 12 Then
            o6.Text = "N"
            o2.Text = "O"
            o3.Text = "O"
            o4.Text = "O"
            o5.Text = "O"
            o1.Text = "O"
            o6.Font = New Font("Times New Roman", 36)
            o2.Font = New Font("Times New Roman", 20)
            o3.Font = New Font("Times New Roman", 20)
            o4.Font = New Font("Times New Roman", 20)
            o5.Font = New Font("Times New Roman", 20)
            o1.Font = New Font("Times New Roman", 20)
        End If
        StartButton.Hide()
        SearchTaskResult.Hide()
    End Sub

    Private Sub Result_DoubleClick(sender As Object, e As EventArgs) Handles Result.MouseDoubleClick
        Dim Text As String = ""
        If GlobalVariables.CorrectSoundID = 1 Then
            Text = "Yes"
        Else
            Text = "No"
        End If
        StartButton.Hide()
        SoundCount.Text = "False ID = " & GlobalVariables.SoundID - GlobalVariables.CorrectSoundID & "; " & "Correct ID: " & Text & "; " & "Trial Number: " & GlobalVariables.TrialNumber & "; Correct Visual Task: " & GlobalVariables.VisualTaskCorrect
        SoundCount.Show()
        CloseButton.Show()

    End Sub

    Private Sub SoundCount_DoubleClick(sender As Object, e As EventArgs) Handles SoundCount.MouseDoubleClick

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Entry.Close()
        Me.Close()
    End Sub

    Private Sub SoundCount_DoubleClick(sender As Object, e As MouseEventArgs) Handles SoundCount.MouseDoubleClick
        StartButton.Show()
        CloseButton.Hide()
        SoundCount.Hide()
    End Sub

    Private Sub Result_MouseHover(sender As Object, e As EventArgs) Handles Result.MouseHover
        Result.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub SoundCount_Click(sender As Object, e As EventArgs) Handles SoundCount.Click

    End Sub

    Private Sub SoundCount_MouseHover(sender As Object, e As EventArgs) Handles SoundCount.MouseHover
        SoundCount.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub Result_Click(sender As Object, e As EventArgs) Handles Result.Click

    End Sub

    Private Sub Delay_Tick(sender As Object, e As EventArgs) Handles Delay.Tick
        CenterDot.Show()
        Delay.Stop()
        Timer11.Start()
    End Sub
End Class