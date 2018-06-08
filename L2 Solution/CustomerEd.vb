Public Class CustomerEd

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
        'CustomerEd.Close()
        DMBs.Close()
        Hardware.Close()
        Home.Close()
        NewStore.Close()
        OCB.Close()
        Online.Close()
        Reports.Close()
        Software.Close()
    End Sub

    Private Sub btnExplanationOfReports_Click(sender As Object, e As EventArgs) Handles btnExplanationOfReports.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        CustomerEdExplanationOfReportsSolution.Show()
    End Sub

    Private Sub btnGeneralQuestions_Click(sender As Object, e As EventArgs) Handles btnGeneralQuestions.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        CustomerEdGeneralQuestionsSolution.Show()

    End Sub

    Private Sub btnLoggingIn_Click(sender As Object, e As EventArgs) Handles btnLoggingIn.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        CustomerEdLoggingIn.Show()

    End Sub

    Private Sub btnPasswords_Click(sender As Object, e As EventArgs) Handles btnPasswords.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        CustomerEdPasswords.Show()

    End Sub

    Private Sub btnSelfHelp_Click(sender As Object, e As EventArgs) Handles btnSelfHelp.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        CustomerEdSelfHelp.Show()

    End Sub

    Private Sub btnUseAndOperation_Click(sender As Object, e As EventArgs) Handles btnWalkthroughs.Click
        MessageBox.Show(levelTwoNotification, levelTwoNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        CustomerEdWalkthroughs.Show()

    End Sub
End Class