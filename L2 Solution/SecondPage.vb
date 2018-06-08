﻿Public Class frmPageTwo

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

    Private Sub btnCategoryThree_Click(sender As Object, e As EventArgs) Handles btnCustomerEd.Click
        CustomerEd.Show()
        Hide()

    End Sub

    Private Sub btnCategoryOne_Click(sender As Object, e As EventArgs) Handles btnDatabase.Click
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

    Private Sub btnPizzaPortal_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Reports.Show()
        Hide()

    End Sub

    Private Sub btnSoftware_Click(sender As Object, e As EventArgs) Handles btnSoftware.Click
        Software.Show()
        Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim helpMessage As String = "Any questions or suggestions on this application can be directed to: charles.napierala@lcecorp.com."
        Dim helpCaption As String = "Help"
        Dim helpButtons As MessageBoxButtons = MessageBoxButtons.OK
        MessageBox.Show(helpMessage, helpCaption, helpButtons)
    End Sub
End Class