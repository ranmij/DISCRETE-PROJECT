Public Class TopicsWindow

#Region "Click Events"
    Private Sub Button_Events_Click(sender As Object, e As EventArgs) Handles BackButton.Click, FirstTopicButton.Click,
            SecondTopicButton.Click, ThirdTopicButton.Click, FourthTopicButton.Click, FifthTopicButton.Click, SixthTopicButton.Click,
            SeventhTopicButton.Click, EightTopicButton.Click, NinethTopicButton.Click, TenthTopicButton.Click, EleventhTopicButton.Click,
            TwelvethTopicButton.Click, ThirteenthTopicButton.Click, FourteenthTopicButton.Click, FifthTopicButton.Click
        Me.Close()
        If sender.Equals(BackButton) Then                           ' Back Button Click Event
            MainWindow.Show()
        ElseIf sender.Equals(FirstTopicButton) Then                 ' First Topic Window
            FirstTopicWindow.Show()
        ElseIf sender.Equals(SecondTopicButton) Then                ' Second Topic Window
            SecondTopicWindow.Show()
        ElseIf sender.Equals(ThirdTopicButton) Then                 ' Third Topic Window
            ThirdTopicWindow.Show()
        ElseIf sender.Equals(FourthTopicButton) Then                ' Fourth Topic Window
            FourthTopicWindow.Show()
        ElseIf sender.Equals(FifthTopicButton) Then                 ' Fifth Topic Window
            FifthTopicWindow.Show()
        ElseIf sender.Equals(SixthTopicButton) Then                 ' Sixth Topic Window
            SixthTopicWindow.Show()
        ElseIf sender.Equals(SeventhTopicButton) Then               ' Seventh Topic Window
            SeventhTopicWindow.Show()
        ElseIf sender.Equals(EightTopicButton) Then                 ' Eigth Topic Window
            EigthTopicWindow.Show()
        ElseIf sender.Equals(NinethTopicButton) Then                ' Nineth Topic Window
            NinethTopicWindow.Show()
        ElseIf sender.Equals(TenthTopicButton) Then                 ' Tenth Topic Window
            TenthTopicWindow.Show()
        ElseIf sender.Equals(EleventhTopicButton) Then              ' Eleventh Topic Window
            EleventhTopicWindow.Show()
        ElseIf sender.Equals(TwelvethTopicButton) Then              ' Twelveth Topic Window
            TwelvethTopicWindow.Show()
        ElseIf sender.Equals(ThirteenthTopicButton) Then            ' Thirteenth Topic Window
            ThirteethTopicWindow.Show()
        ElseIf sender.Equals(FourteenthTopicButton) Then            ' Fourteenth Topic Window
            FourthteenthTopicWindow.Show()
        ElseIf sender.Equals(FifteenthTopicButton) Then             ' Fifteenth Topic Window
            FifthteenthTopicWindow.Show()
        End If
    End Sub

#End Region
End Class