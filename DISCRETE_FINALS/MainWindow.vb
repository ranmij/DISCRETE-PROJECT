Public Class MainWindow
    Private Sub Button_Event_Click(sender As Object, e As EventArgs) Handles TopicsButton.Click, MembersButton.Click, AboutButton.Click

        If sender.Equals(TopicsButton) Then
            Me.Hide()
            TopicsWindow.Show()
        ElseIf sender.Equals(MembersButton) Then
            Dim ModalWindow As New Members
            ModalWindow.Owner = Me
            ModalWindow.ShowDialog()
        Else

        End If
    End Sub
End Class
