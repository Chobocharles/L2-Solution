Public Class DBChangeError
    Private Sub btnWorked_Click(sender As Object, e As EventArgs) Handles btnWorked.Click
        Close()

    End Sub

    Private Sub btnDidntWork_Click(sender As Object, e As EventArgs) Handles btnDidntWork.Click
        Dim levelThreeNotification As String = "Please elevate to level 3."
        Dim levelThreeNotificationCaption As String = "Elevate"
        Dim levelThreeNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

        Dim didntWorkMessage As String = "If this solution didn't work, please press 'review similar incidents'."
        Dim didntWorkMessageCaption As String = "Didn't Work"
        Dim didntWorkMessageButtons As MessageBoxButtons = MessageBoxButtons.OK

        Dim levelElevationResponse As String = "Is the database corrupted, broken, or in suspect mode?"
        Dim levelElevationResponseCaption As String = "Database Maintenance"
        Dim levelElevationResponseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim response As String = MessageBox.Show(levelElevationResponse, levelElevationResponseCaption, levelElevationResponseButtons, MessageBoxIcon.Question)
        If response = vbYes Then
            MessageBox.Show(levelThreeNotification, levelThreeNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        ElseIf response = vbNo Then
            MessageBox.Show(didntWorkMessage, didntWorkMessageCaption, didntWorkMessageButtons)

        End If
    End Sub
End Class