Public Class HWLCS
    Private Sub btnWorked_Click(sender As Object, e As EventArgs) Handles btnWorked.Click
        Close()

    End Sub

    Private Sub btnDidntWork_Click(sender As Object, e As EventArgs) Handles btnDidntWork.Click
        Dim levelThreeNotification As String = "Please document all running programs, processes, and then elevate to level 3."
        Dim levelThreeNotificationCaption As String = "Elevate"
        Dim levelThreeNotificationButtons As MessageBoxButtons = MessageBoxButtons.OK

        Dim didntWorkMessage As String = "If this solution didn't work, please press 'review similar incidents'."
        Dim didntWorkMessageCaption As String = "Didn't Work"
        Dim didntWorkMessageButtons As MessageBoxButtons = MessageBoxButtons.OK

        Dim levelElevationResponse As String = "Is this inquiry related to special state taxes or taxes not being applied correctly?"
        Dim levelElevationResponseCaption As String = "Taxes"
        Dim levelElevationResponseButtons As MessageBoxButtons = MessageBoxButtons.YesNo
        'Dim response As String = MessageBox.Show(levelElevationResponse, levelElevationResponseCaption, levelElevationResponseButtons, MessageBoxIcon.Question)
        MessageBox.Show(levelThreeNotification, levelThreeNotificationCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class