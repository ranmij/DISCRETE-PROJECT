Public Class FifthTopicWindow
    Private Sub Button_Event_Click(sender As Object, e As EventArgs) Handles BackButton.Click, NextButton.Click, PreviousButton.Click
        Me.Hide()
        If sender.Equals(BackButton) Then
            MainWindow.Show()
        ElseIf sender.Equals(PreviousButton) Then
            FourthTopicWindow.Show()
        Else
            SixthTopicWindow.Show()
        End If
    End Sub
End Class