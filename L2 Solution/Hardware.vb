Public Class Hardware
    Dim levelTwoNotification As String = "This may be solved by Level 2."
    Dim levelTwoNotificationCaption As String = "Level 2 Resolution"
    Dim levelTwoNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

    Dim levelThreeNotification As String = "This is a level 3 incident. Please assign a ticket to the CV Dev Team."
    Dim levelThreeNotificationCaption As String = "Escalation Required"
    Dim levelThreeNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

    Dim pizzaPortalNotification As String = "All hardware issues related to Pizza Portal are sent to Apex for troubleshooting."
    Dim pizzaPortalNotificationCaption As String = "Pizza Portal Process"
    Dim pizzaPortalNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmPageTwo.Show()
        Hide()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Database.Close()
        CardIssues.Close()
        CustomerEd.Close()
        DMBs.Close()
        'Hardware.Close()
        Home.Close()
        NewStore.Close()
        OCB.Close()
        Online.Close()
        Reports.Close()
        Software.Close()
    End Sub

    Private Sub btnCaesarVision_Click(sender As Object, e As EventArgs) Handles btnDMB.Click
        DMBs.Show()
        Hide()

    End Sub

    Private Sub btnPizzaPortal_Click(sender As Object, e As EventArgs) Handles btnPizzaPortal.Click
        'HWPizzaPortal.Show()
        MessageBox.Show(pizzaPortalNotification, pizzaPortalNotificationCaption, pizzaPortalNotificationButtons, MessageBoxIcon.Stop)
    End Sub

    Private Sub btnCashDrawer_Click(sender As Object, e As EventArgs) Handles btnCashDrawer.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        HWCashDrawer.Show()

    End Sub

    Private Sub btnFingerPrintReader_Click(sender As Object, e As EventArgs) Handles btnFingerPrintReader.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        HWFPR.Show()

    End Sub

    Private Sub btnCommandScreens_Click(sender As Object, e As EventArgs) Handles btnCommandScreens.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        HWLCS.Show()

    End Sub

    Private Sub btnPrinters_Click(sender As Object, e As EventArgs) Handles btnPrinters.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        HWPrinters.Show()

    End Sub

    Private Sub btnRegistersCountersCC_Click(sender As Object, e As EventArgs) Handles btnRegistersCountersCC.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        HWRegistersCountersCCMachine.Show()

    End Sub

    Private Sub btnScanners_Click(sender As Object, e As EventArgs) Handles btnScanners.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        HWScanners.Show()

    End Sub

    Private Sub btnServer_Click(sender As Object, e As EventArgs) Handles btnServer.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        HWServer.Show()

    End Sub

    Private Sub btnSystemConfiguration_Click(sender As Object, e As EventArgs) Handles btnSystemConfiguration.Click
        'HWSystemConfig.Show()

    End Sub
End Class