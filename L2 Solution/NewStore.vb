Public Class NewStore
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
        DMBs.Close()
        Hardware.Close()
        Home.Close()
        'NewStore.Close()
        OCB.Close()
        Online.Close()
        Reports.Close()
        Software.Close()
    End Sub

    Private Sub btnDMBSetup_Click(sender As Object, e As EventArgs) Handles btnDMBSetup.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        NewStoreDMB.Show()

    End Sub

    Private Sub btnComputerImaging_Click(sender As Object, e As EventArgs) Handles btnComputerImaging.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        NewStoreNewStore.Show()

    End Sub

    Private Sub btnInitialSetup_Click(sender As Object, e As EventArgs) Handles btnInitialSetup.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        NewStoreInitialSetup.Show()

    End Sub

    Private Sub btnNewServer_Click(sender As Object, e As EventArgs) Handles btnNewServer.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        NewStoreNewServer.Show()

    End Sub

    Private Sub btnNewStore_Click(sender As Object, e As EventArgs) Handles btnNewStore.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        NewStoreNewStore.Show()

    End Sub

    Private Sub btnSoftwareInstallation_Click(sender As Object, e As EventArgs) Handles btnSoftwareInstallation.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        NewStoreSoftwareInstall.Show()

    End Sub

    Private Sub btnStoreTransfer_Click(sender As Object, e As EventArgs) Handles btnStoreTransfer.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        NewStoreTransfer.Show()

    End Sub

    Private Sub btnStoreValidation_Click(sender As Object, e As EventArgs) Handles btnStoreValidation.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        NewStoreStoreValidation.Show()

    End Sub

    Private Sub btnUpdates_Click(sender As Object, e As EventArgs) Handles btnUpdates.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        NewStoreUpdates.Show()

    End Sub
End Class