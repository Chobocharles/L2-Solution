Public Class OCB
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
        NewStore.Close()
        'OCB.Close()
        Online.Close()
        Reports.Close()
        Software.Close()
    End Sub

    Private Sub btnOtherReports_Click(sender As Object, e As EventArgs) Handles btnReportIssues.Click
        Reports.Show()
        Hide()

    End Sub

    Private Sub btnBlueLineIssues_Click(sender As Object, e As EventArgs) Handles btnBlueLineErrors.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OCBBlueLine.Show()

    End Sub

    Private Sub btnInventoryIssues_Click(sender As Object, e As EventArgs) Handles btnInventoryIssues.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OCBInventory.Show()

    End Sub

    Private Sub btnItemConfiguration_Click(sender As Object, e As EventArgs) Handles btnItemConfiguration.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OCBItemConfig.Show()

    End Sub

    Private Sub btnNotOpening_Click(sender As Object, e As EventArgs) Handles btnNotOpening.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OCBNotOpeningLoading.Show()

    End Sub

    Private Sub btnNotSaving_Click(sender As Object, e As EventArgs) Handles btnNotSaving.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OCBNotSaving.Show()

    End Sub

    Private Sub btnPriceIssues_Click(sender As Object, e As EventArgs) Handles btnPriceIssues.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OCBPriceIssues.Show()

    End Sub

    Private Sub btnRebuildingNavigation_Click(sender As Object, e As EventArgs) Handles btnRebuildingNavigation.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OCBRebuildNav.Show()

    End Sub

    Private Sub btnSecuritySettings_Click(sender As Object, e As EventArgs) Handles btnSecuritySettings.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OCBSecuritySettings.Show()

    End Sub

    Private Sub btnSyncingIssues_Click(sender As Object, e As EventArgs) Handles btnSyncingIssues.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OCBSyncIssues.Show()

    End Sub
End Class