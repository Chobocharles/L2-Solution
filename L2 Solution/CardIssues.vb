Public Class CardIssues

    Dim levelTwoNotification As String = "This may be solved by Level 2."
    Dim levelTwoNotificationCaption As String = "Level 2 Resolution"
    Dim levelTwoNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

    Dim levelThreeNotification As String = "This is a level 3 incident. Please assign a ticket to the CV Dev Team."
    Dim levelThreeNotificationCaption As String = "Escalation Required"
    Dim levelThreeNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

    Dim levelElevationResponse As String = "Does the customer have a discrepancy between reported amount and deposit amount?"
    Dim levelElevationResponseCaption As String = "Report Discrepancy"
    Dim levelElevationResponseButtons As MessageBoxButtons = MessageBoxButtons.YesNo

    Dim fraudMessage As String = "Report and forward this incident to the loss prevention team."
    Dim fraudAlert As String = "Alert!"
    Dim fraudMessageButtons As MessageBoxButtons = MessageBoxButtons.OK

    Dim giftTransactionMissing As String = "Identify if the gift card is third-party or LCE."
    Dim giftTransactionPicture As String = "Obtain a picture of the gift card's front and back."
    Dim giftTransactionMissingCaption As String = "Documentation"

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmPageTwo.Show()
        Hide()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Database.Close()
        'CardIssues.Close()
        CustomerEd.Close()
        DMBs.Close()
        Hardware.Close()
        Home.Close()
        NewStore.Close()
        OCB.Close()
        Online.Close()
        Reports.Close()
        Software.Close()
    End Sub

    Private Sub btnGeneralQuestions_Click(sender As Object, e As EventArgs)
        CustomerEd.Show()
        Hide()

    End Sub

    Private Sub btnCCMachineDown_Click(sender As Object, e As EventArgs) Handles btnCCMachineDown.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        CCMachineDown.Show()

    End Sub

    Private Sub btnCCMachineNotPairing_Click(sender As Object, e As EventArgs) Handles btnCCMachineNotPairing.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        CCMachineNotPairing.Show()

    End Sub

    Private Sub btnReportDiscrepancy_Click(sender As Object, e As EventArgs) Handles btnReportDiscrepancy.Click
        Dim response As String = MessageBox.Show(levelElevationResponse, levelElevationResponseCaption, levelElevationResponseButtons, MessageBoxIcon.Question)
        If response = vbNo Then
            MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CCReportDiscrepancy.Show()

        Else
            MessageBox.Show(levelThreeNotification, levelThreeNotificationCaption, levelThreeNotificationButtons, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub btnDuplicateTransactions_Click(sender As Object, e As EventArgs) Handles btnDuplicateTransactions.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        CCDuplicateTransactions.Show()

    End Sub

    Private Sub btnFraud_Click(sender As Object, e As EventArgs) Handles btnFraud.Click
        MessageBox.Show(fraudMessage, fraudAlert, fraudMessageButtons, MessageBoxIcon.Stop)
    End Sub

    Private Sub btnGCActivationIssues_Click(sender As Object, e As EventArgs) Handles btnGCActivationIssues.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        CCGiftCardActivation.Show()

    End Sub

    Private Sub btnGCRedemptionIssues_Click(sender As Object, e As EventArgs) Handles btnGCRedemptionIssues.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        CCGiftCardRedemption.Show()

    End Sub

    Private Sub btnGCTransactionsMissing_Click(sender As Object, e As EventArgs) Handles btnGCTransactionsMissing.Click
        MessageBox.Show(giftTransactionMissing, giftTransactionMissingCaption, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        MessageBox.Show(giftTransactionPicture, giftTransactionMissingCaption, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        MessageBox.Show(levelThreeNotification, levelThreeNotificationCaption, levelThreeNotificationButtons, MessageBoxIcon.Information)

    End Sub
End Class