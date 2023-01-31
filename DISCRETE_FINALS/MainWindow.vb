Public Class MainWindow
    Private Sub Button_Event_Click(sender As Object, e As EventArgs) Handles TopicsButton.Click, MembersButton.Click, AboutButton.Click
        Me.Hide()
        If sender.Equals(TopicsButton) Then
            TopicsWindow.Show()
        ElseIf sender.Equals(MembersButton) Then

        Else

        End If
    End Sub
End Class
