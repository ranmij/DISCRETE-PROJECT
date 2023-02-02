Public Class FirstTopicWindow
    Private Sub Button_Event_Click(sender As Object, e As EventArgs) Handles BackButton.Click, NextButton.Click
        Me.Hide()
        If sender.Equals(BackButton) Then
            MainWindow.Show()
        Else
            SecondTopicWindow.Show()
        End If
    End Sub
End Class