Public Class Software

    Dim levelTwoNotification As String = "This may be solved by Level 2."
    Dim levelTwoNotificationCaption As String = "Level 2 Resolution"
    Dim levelTwoNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

    Dim levelThreeNotification As String = "This is a level 3 incident. Please assign a ticket to the CV Dev Team."
    Dim levelThreeNotificationCaption As String = "Escalation Required"
    Dim levelThreeNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

    Dim pizzaPortalNotification As String = "All issues related to Pizza Portal, aside from validation, are sent to Apex for troubleshooting."
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
        Hardware.Close()
        Home.Close()
        NewStore.Close()
        OCB.Close()
        Online.Close()
        Reports.Close()
        'Software.Close()
    End Sub

    Private Sub btnDMBs_Click(sender As Object, e As EventArgs) Handles btnDMBs.Click
        Database.Show()
        Hide()

    End Sub

    Private Sub btnPizzaPortal_Click(sender As Object, e As EventArgs) Handles btnPizzaPortal.Click
        MessageBox.Show(pizzaPortalNotification, pizzaPortalNotificationCaption, pizzaPortalNotificationButtons, MessageBoxIcon.Stop)
        'SWPizzaPortal.Show()


    End Sub

    Private Sub btnOnline_Click(sender As Object, e As EventArgs) Handles btnOnline.Click
        Online.Show()
        Hide()

    End Sub

    Private Sub btnNewStore_Click(sender As Object, e As EventArgs) Handles btnNewStore.Click
        SWBlueLine.Show()

    End Sub

    Private Sub btnCustomerEd_Click(sender As Object, e As EventArgs) Handles btnCustomerEd.Click
        SWPOSCV.Show()

    End Sub

    Private Sub btnCards_Click(sender As Object, e As EventArgs) Handles btnCards.Click
        SWTeamViewer.Show()

    End Sub

    Private Sub btnCaesarVision_Click(sender As Object, e As EventArgs) Handles btnCaesarVision.Click
        SWUpdates.Show()

    End Sub
End Class