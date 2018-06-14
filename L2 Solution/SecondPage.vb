Public Class frmPageTwo
    Dim levelTwoNotification As String = "This may be solved by Level 2."
    Dim levelTwoNotificationCaption As String = "Level 2 Resolution"
    Dim levelTwoNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

    Dim levelThreeNotification As String = "This is a level 3 incident. Please assign a ticket to the CV Dev Team."
    Dim levelThreeNotificationCaption As String = "Escalation Required"
    Dim levelThreeNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

    Dim pizzaPortalNotification As String = "All issues related to Pizza Portal, aside from validation, are sent to Apex for troubleshooting."
    Dim pizzaPortalNotificationCaption As String = "Pizza Portal Process"
    Dim pizzaPortalNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

    Dim helpMessage As String = "Any questions or suggestions on this application can be directed to: charles.napierala@lcecorp.com."
    Dim helpCaption As String = "Help"
    Dim helpButtons As MessageBoxButtons = MessageBoxButtons.OK

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Home.Close()
        Database.Close()
        CardIssues.Close()
        CustomerEd.Close()
        DMBs.Close()
        Hardware.Close()
        NewStore.Close()
        OCB.Close()
        Online.Close()
        Reports.Close()
        Software.Close()
    End Sub

    Private Sub btnCustomerEd_Click(sender As Object, e As EventArgs) Handles btnCustomerEd.Click
        CustomerEd.Show()
        Hide()

    End Sub

    Private Sub btnDatabases_Click(sender As Object, e As EventArgs) Handles btnDatabase.Click
        Database.Show()
        Hide()
    End Sub

    Private Sub btnCards_Click(sender As Object, e As EventArgs) Handles btnCards.Click
        CardIssues.Show()
        Hide()
    End Sub

    Private Sub btnDMBs_Click(sender As Object, e As EventArgs) Handles btnDMBs.Click
        DMBs.Show()
        Hide()
    End Sub

    Private Sub btnHardware_Click(sender As Object, e As EventArgs) Handles btnHardware.Click
        Hardware.Show()
        Hide()

    End Sub

    Private Sub btnNewStore_Click(sender As Object, e As EventArgs) Handles btnNewStore.Click
        NewStore.Show()
        Hide()

    End Sub

    Private Sub btnOCB_Click(sender As Object, e As EventArgs) Handles btnOCB.Click
        OCB.Show()
        Hide()

    End Sub

    Private Sub btnOnline_Click(sender As Object, e As EventArgs) Handles btnOnline.Click
        Online.Show()
        Hide()

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Reports.Show()
        Hide()

    End Sub

    Private Sub btnSoftware_Click(sender As Object, e As EventArgs) Handles btnSoftware.Click
        Software.Show()
        Hide()

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MessageBox.Show(helpMessage, helpCaption, helpButtons)
    End Sub
End Class