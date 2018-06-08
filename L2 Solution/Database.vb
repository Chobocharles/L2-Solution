Public Class Database

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
        ' CaesarVision.Close()
        CardIssues.Close()
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

    Private Sub btnCorrupt_Click(sender As Object, e As EventArgs) Handles btnCorrupt.Click
        MessageBox.Show(levelThreeNotification, levelThreeNotificationCaption, levelThreeNotificationButtons, MessageBoxIcon.Information)
        'DBCorrupt.Show()

    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)

        DBBackup.Show()

    End Sub

    Private Sub btnDatabaseChangeError_Click(sender As Object, e As EventArgs) Handles btnDatabaseChangeError.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        DBChangeError.Show()

    End Sub

    Private Sub btnSuspectMode_Click(sender As Object, e As EventArgs) Handles btnSuspectMode.Click
        'DBSuspectMode.Show()
        MessageBox.Show(levelThreeNotification, levelThreeNotificationCaption, levelThreeNotificationButtons, MessageBoxIcon.Information)
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        DBMaintenance.Show()

    End Sub

    Private Sub btnRecovery_Click(sender As Object, e As EventArgs) Handles btnRecovery.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        DBRecovery.Show()

    End Sub

    Private Sub btnSchema_Click(sender As Object, e As EventArgs) Handles btnSchema.Click
        'DBSchema.Show()
        MessageBox.Show(levelThreeNotification, levelThreeNotificationCaption, levelThreeNotificationButtons, MessageBoxIcon.Information)

    End Sub

    Private Sub btnSyncing_Click(sender As Object, e As EventArgs) Handles btnSyncing.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        DBSyncing.Show()

    End Sub

    Private Sub btnTaxRates_Click(sender As Object, e As EventArgs) Handles btnTaxRates.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        DBTaxes.Show()

    End Sub
End Class