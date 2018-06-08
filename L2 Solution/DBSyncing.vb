Public Class DBSyncing
    Private Sub btnWorked_Click(sender As Object, e As EventArgs) Handles btnWorked.Click
        Close()

    End Sub

    Private Sub btnDidntWork_Click(sender As Object, e As EventArgs) Handles btnDidntWork.Click
        Dim levelThreeNotification As String = "Please elevate to level 3."
        Dim levelThreeNotificationCaption As String = "Elevate"
        Dim levelThreeNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

        MessageBox.Show(levelThreeNotification, levelThreeNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class