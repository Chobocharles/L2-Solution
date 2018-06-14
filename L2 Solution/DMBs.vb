Public Class DMBs

    Dim levelTwoNotification As String = "This may be solved by Level 2."
    Dim levelTwoNotificationCaption As String = "Level 2 Resolution"
    Dim levelTwoNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

    Dim levelThreeNotification As String = "This is a level 3 incident. Please assign a ticket to the CV Dev Team."
    Dim levelThreeNotificationCaption As String = "Escalation Required"
    Dim levelThreeNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmPageTwo.Show()
        Hide()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Database.Close()
        CardIssues.Close()
        CustomerEd.Close()
        'DMBs.Close()
        Hardware.Close()
        Home.Close()
        NewStore.Close()
        OCB.Close()
        Online.Close()
        Reports.Close()
        Software.Close()
    End Sub

    Private Sub btnAllureIssues_Click(sender As Object, e As EventArgs) Handles btnAllureIssues.Click
        'DMBAllure.Show()
        MessageBox.Show(levelThreeNotification, levelThreeNotificationCaption, levelThreeNotificationButtons, MessageBoxIcon.Information)

    End Sub

    Private Sub btnBlankScreens_Click(sender As Object, e As EventArgs) Handles btnBlankScreens.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Information)
        DMBBlankScreens.Show()

    End Sub

    Private Sub btnHardwareMalfunctions_Click(sender As Object, e As EventArgs) Handles btnHardwareMalfunctions.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Information)
        DMBHardware.Show()

    End Sub

    Private Sub btnMissingImages_Click(sender As Object, e As EventArgs) Handles btnMissingImages.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Information)
        DMBMissingImages.Show()

    End Sub

    Private Sub btnPriceChangeRequests_Click(sender As Object, e As EventArgs) Handles btnPriceChangeRequests.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Information)
        DMBMissingImages.Show()

    End Sub

    Private Sub btnStaticUpdates_Click(sender As Object, e As EventArgs) Handles btnStaticUpdates.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Information)
        DMBMissingImages.Show()
    End Sub

    Private Sub btnWrongImages_Click(sender As Object, e As EventArgs) Handles btnWrongImages.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Information)
        DMBMissingImages.Show()
    End Sub
End Class