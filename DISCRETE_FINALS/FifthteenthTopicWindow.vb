Public Class FifthteenthTopicWindow
    Private Sub Button_Event_Click(sender As Object, e As EventArgs) Handles BackButton.Click, PreviousButton.Click
        Me.Hide()
        If sender.Equals(BackButton) Then
            MainWindow.Show()
        Else
            FourthteenthTopicWindow.Show()
        End If
    End Sub
End Class