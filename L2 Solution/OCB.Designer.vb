<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OCB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.btnDailySummary = New System.Windows.Forms.Button()
        Me.btnNotSaving = New System.Windows.Forms.Button()
        Me.btnOtherReports = New System.Windows.Forms.Button()
        Me.btnItemConfiguration = New System.Windows.Forms.Button()
        Me.btnNotOpening = New System.Windows.Forms.Button()
        Me.btnRebuildingNavigation = New System.Windows.Forms.Button()
        Me.btnSyncingIssues = New System.Windows.Forms.Button()
        Me.btnSecuritySettings = New System.Windows.Forms.Button()
        Me.btnInventoryIssues = New System.Windows.Forms.Button()
        Me.btnPriceIssues = New System.Windows.Forms.Button()
        Me.lblSelectIssue = New System.Windows.Forms.Label()
        Me.grpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(167, 398)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 2
        Me.btnHome.Text = "&Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(248, 398)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpButtons
        '
        Me.grpButtons.BackColor = System.Drawing.SystemColors.Control
        Me.grpButtons.Controls.Add(Me.btnDailySummary)
        Me.grpButtons.Controls.Add(Me.btnNotSaving)
        Me.grpButtons.Controls.Add(Me.btnOtherReports)
        Me.grpButtons.Controls.Add(Me.btnItemConfiguration)
        Me.grpButtons.Controls.Add(Me.btnNotOpening)
        Me.grpButtons.Controls.Add(Me.btnRebuildingNavigation)
        Me.grpButtons.Controls.Add(Me.btnSyncingIssues)
        Me.grpButtons.Controls.Add(Me.btnSecuritySettings)
        Me.grpButtons.Controls.Add(Me.btnInventoryIssues)
        Me.grpButtons.Controls.Add(Me.btnPriceIssues)
        Me.grpButtons.Location = New System.Drawing.Point(12, 56)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(317, 332)
        Me.grpButtons.TabIndex = 1
        Me.grpButtons.TabStop = False
        '
        'btnDailySummary
        '
        Me.btnDailySummary.Enabled = False
        Me.btnDailySummary.Location = New System.Drawing.Point(5, 19)
        Me.btnDailySummary.Name = "btnDailySummary"
        Me.btnDailySummary.Size = New System.Drawing.Size(306, 23)
        Me.btnDailySummary.TabIndex = 0
        Me.btnDailySummary.Text = "&Blue Line Errors"
        Me.btnDailySummary.UseVisualStyleBackColor = True
        '
        'btnNotSaving
        '
        Me.btnNotSaving.Enabled = False
        Me.btnNotSaving.Location = New System.Drawing.Point(5, 135)
        Me.btnNotSaving.Name = "btnNotSaving"
        Me.btnNotSaving.Size = New System.Drawing.Size(306, 23)
        Me.btnNotSaving.TabIndex = 4
        Me.btnNotSaving.Text = "Not &Saving Data"
        Me.btnNotSaving.UseVisualStyleBackColor = True
        '
        'btnOtherReports
        '
        Me.btnOtherReports.Location = New System.Drawing.Point(5, 222)
        Me.btnOtherReports.Name = "btnOtherReports"
        Me.btnOtherReports.Size = New System.Drawing.Size(306, 23)
        Me.btnOtherReports.TabIndex = 7
        Me.btnOtherReports.Text = "Repor&t Issues"
        Me.btnOtherReports.UseVisualStyleBackColor = True
        '
        'btnItemConfiguration
        '
        Me.btnItemConfiguration.Location = New System.Drawing.Point(5, 77)
        Me.btnItemConfiguration.Name = "btnItemConfiguration"
        Me.btnItemConfiguration.Size = New System.Drawing.Size(306, 23)
        Me.btnItemConfiguration.TabIndex = 2
        Me.btnItemConfiguration.Text = "I&tem Configuration / Price Issues"
        Me.btnItemConfiguration.UseVisualStyleBackColor = True
        '
        'btnNotOpening
        '
        Me.btnNotOpening.Location = New System.Drawing.Point(5, 106)
        Me.btnNotOpening.Name = "btnNotOpening"
        Me.btnNotOpening.Size = New System.Drawing.Size(306, 23)
        Me.btnNotOpening.TabIndex = 3
        Me.btnNotOpening.Text = "&Not Opening or Loading"
        Me.btnNotOpening.UseVisualStyleBackColor = True
        '
        'btnRebuildingNavigation
        '
        Me.btnRebuildingNavigation.Location = New System.Drawing.Point(5, 193)
        Me.btnRebuildingNavigation.Name = "btnRebuildingNavigation"
        Me.btnRebuildingNavigation.Size = New System.Drawing.Size(306, 23)
        Me.btnRebuildingNavigation.TabIndex = 6
        Me.btnRebuildingNavigation.Text = "&Rebuilding Navigation"
        Me.btnRebuildingNavigation.UseVisualStyleBackColor = True
        '
        'btnSyncingIssues
        '
        Me.btnSyncingIssues.Location = New System.Drawing.Point(5, 280)
        Me.btnSyncingIssues.Name = "btnSyncingIssues"
        Me.btnSyncingIssues.Size = New System.Drawing.Size(306, 23)
        Me.btnSyncingIssues.TabIndex = 9
        Me.btnSyncingIssues.Text = "S&yncing Issues"
        Me.btnSyncingIssues.UseVisualStyleBackColor = True
        '
        'btnSecuritySettings
        '
        Me.btnSecuritySettings.Location = New System.Drawing.Point(5, 251)
        Me.btnSecuritySettings.Name = "btnSecuritySettings"
        Me.btnSecuritySettings.Size = New System.Drawing.Size(306, 23)
        Me.btnSecuritySettings.TabIndex = 8
        Me.btnSecuritySettings.Text = "Se&curity Settings"
        Me.btnSecuritySettings.UseVisualStyleBackColor = True
        '
        'btnInventoryIssues
        '
        Me.btnInventoryIssues.Location = New System.Drawing.Point(5, 48)
        Me.btnInventoryIssues.Name = "btnInventoryIssues"
        Me.btnInventoryIssues.Size = New System.Drawing.Size(306, 23)
        Me.btnInventoryIssues.TabIndex = 1
        Me.btnInventoryIssues.Text = "I&nventory Issues"
        Me.btnInventoryIssues.UseVisualStyleBackColor = True
        '
        'btnPriceIssues
        '
        Me.btnPriceIssues.Enabled = False
        Me.btnPriceIssues.Location = New System.Drawing.Point(5, 164)
        Me.btnPriceIssues.Name = "btnPriceIssues"
        Me.btnPriceIssues.Size = New System.Drawing.Size(306, 23)
        Me.btnPriceIssues.TabIndex = 5
        Me.btnPriceIssues.Text = "&Price Issues"
        Me.btnPriceIssues.UseVisualStyleBackColor = True
        '
        'lblSelectIssue
        '
        Me.lblSelectIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectIssue.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectIssue.Name = "lblSelectIssue"
        Me.lblSelectIssue.Size = New System.Drawing.Size(317, 44)
        Me.lblSelectIssue.TabIndex = 0
        Me.lblSelectIssue.Text = "OCB/SCB"
        Me.lblSelectIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OCB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(341, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSelectIssue)
        Me.Controls.Add(Me.grpButtons)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "OCB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OCB/SCB"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnDailySummary As Button
    Friend WithEvents btnNotSaving As Button
    Friend WithEvents btnOtherReports As Button
    Friend WithEvents btnItemConfiguration As Button
    Friend WithEvents btnNotOpening As Button
    Friend WithEvents btnRebuildingNavigation As Button
    Friend WithEvents btnSyncingIssues As Button
    Friend WithEvents btnSecuritySettings As Button
    Friend WithEvents btnInventoryIssues As Button
    Friend WithEvents btnPriceIssues As Button
    Friend WithEvents lblSelectIssue As Label
End Class
