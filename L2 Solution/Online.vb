Public Class Online
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
        Hardware.Close()
        Home.Close()
        NewStore.Close()
        OCB.Close()
        'Online.Close()
        Reports.Close()
        Software.Close()
    End Sub

    Private Sub btnMissingButtons_Click(sender As Object, e As EventArgs) Handles btnMissingButtons.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OnlineButtonsMissing.Show()

    End Sub

    Private Sub btnEnableDisableOnlineOrdering_Click(sender As Object, e As EventArgs) Handles btnEnableDisableOnlineOrdering.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OnlineEnableDisable.Show()

    End Sub

    Private Sub btnEPayValidation_Click(sender As Object, e As EventArgs) Handles btnEPayValidation.Click
        'OnlineEPayValidation.Show()
        MessageBox.Show(levelThreeNotification, levelThreeNotificationCaption, levelThreeNotificationButtons, MessageBoxIcon.Stop)
    End Sub

    Private Sub btnMissingItems_Click(sender As Object, e As EventArgs) Handles btnMissingItems.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OCBItemConfig.Show()

    End Sub

    Private Sub btnPizzaPortalValidation_Click(sender As Object, e As EventArgs) Handles btnPizzaPortalValidation.Click

        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OnlinePizzaPortalValidation.Show()

    End Sub

    Private Sub btnPizzaPortalLabels_Click(sender As Object, e As EventArgs) Handles btnPizzaPortalLabels.Click


        MessageBox.Show(pizzaPortalNotification, pizzaPortalNotificationCaption, pizzaPortalNotificationButtons, MessageBoxIcon.Stop)

        'OnlinePizzaPortalLabels.Show()

    End Sub

    Private Sub btnPizzaPortalOrdersNotClearing_Click(sender As Object, e As EventArgs) Handles btnPizzaPortalOrdersNotClearing.Click
        MessageBox.Show(pizzaPortalNotification, pizzaPortalNotificationCaption, pizzaPortalNotificationButtons, MessageBoxIcon.Stop)
        'OnlinePizzaPortalNotClearing.Show()

    End Sub

    Private Sub btnPriceDiscrepancies_Click(sender As Object, e As EventArgs) Handles btnPriceDiscrepancies.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OCBItemConfig.Show()
        'OnlinePriceDiscrepancies.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, levelTwoNotificationButtons, MessageBoxIcon.Warning)
        OnlineTimeIssues.Show()

    End Sub
End Class