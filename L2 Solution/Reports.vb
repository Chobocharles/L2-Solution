Public Class Reports

    Dim levelTwoNotification As String = "This may be solved by Level 2."
    Dim levelTwoNotificationCaption As String = "Level 2 Resolution"
    Dim levelTwoNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

    Dim levelThreeNotification As String = "This is a level 3 incident. Please assign a ticket to the CV Dev Team."
    Dim levelThreeNotificationCaption As String = "Escalation Required"
    Dim levelThreeNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK


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
        Hardware.Close()
        Home.Close()
        NewStore.Close()
        OCB.Close()
        Online.Close()
        ' PizzaPortal.Close()
        Software.Close()
    End Sub

    Private Sub btnCards_Click(sender As Object, e As EventArgs) Handles btnOCB.Click
        'ReportsOCB.Show()
        MessageBox.Show(levelThreeNotification, levelThreeNotificationCaption, levelThreeNotificationButtons, MessageBoxIcon.Stop)

    End Sub

    Private Sub btnDMBs_Click(sender As Object, e As EventArgs) Handles btnIVR.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        ReportsIVR.Show()

    End Sub

    Private Sub btnCustomerEd_Click(sender As Object, e As EventArgs) Handles btnCOGS.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        ReportsCOGS.Show()

    End Sub

    Private Sub btnHardware_Click(sender As Object, e As EventArgs) Handles btnKeyItem.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        ReportsKeyItem.Show()

    End Sub

    Private Sub btnOCB_Click(sender As Object, e As EventArgs) Handles btnBlueLine.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        ReportsBlueLine.Show()

    End Sub

    Private Sub btnDailySummary_Click(sender As Object, e As EventArgs) Handles btnDailySummary.Click
        'ReportsDailySummary.Show()
        MessageBox.Show(levelThreeNotification, levelThreeNotificationCaption, levelThreeNotificationButtons, MessageBoxIcon.Stop)
    End Sub

    Private Sub btnVerifyDay_Click(sender As Object, e As EventArgs) Handles btnVerifyDay.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        ReportsVerifyDay.Show()

    End Sub
End Class