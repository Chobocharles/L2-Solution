﻿Public Class NewStoreNewServer
    Private Sub btnWorked_Click(sender As Object, e As EventArgs) Handles btnWorked.Click
        Close()

    End Sub

    Private Sub btnDidntWork_Click(sender As Object, e As EventArgs) Handles btnDidntWork.Click
        Dim didntWorkMessage As String = "If this solution didn't work, please press 'review similar incidents'."
        Dim didntWorkMessageCaption As String = "Didn't Work"
        Dim didntWorkMessageButtons As MessageBoxButtons = MessageBoxButtons.OK
        MessageBox.Show(didntWorkMessage, didntWorkMessageCaption, didntWorkMessageButtons)
    End Sub
End Class