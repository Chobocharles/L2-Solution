<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardIssues
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
        Me.btnReportDiscrepancy = New System.Windows.Forms.Button()
        Me.btnGCTransactionsMissing = New System.Windows.Forms.Button()
        Me.btnGCActivationIssues = New System.Windows.Forms.Button()
        Me.btnGCRedemptionIssues = New System.Windows.Forms.Button()
        Me.btnFraud = New System.Windows.Forms.Button()
        Me.btnCCMachineDown = New System.Windows.Forms.Button()
        Me.btnDuplicateTransactions = New System.Windows.Forms.Button()
        Me.btnCCMachineNotPairing = New System.Windows.Forms.Button()
        Me.lblSelectIssue = New System.Windows.Forms.Label()
        Me.grpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel
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
        Me.grpButtons.Controls.Add(Me.btnReportDiscrepancy)
        Me.grpButtons.Controls.Add(Me.btnGCTransactionsMissing)
        Me.grpButtons.Controls.Add(Me.btnGCActivationIssues)
        Me.grpButtons.Controls.Add(Me.btnGCRedemptionIssues)
        Me.grpButtons.Controls.Add(Me.btnFraud)
        Me.grpButtons.Controls.Add(Me.btnCCMachineDown)
        Me.grpButtons.Controls.Add(Me.btnDuplicateTransactions)
        Me.grpButtons.Controls.Add(Me.btnCCMachineNotPairing)
        Me.grpButtons.Location = New System.Drawing.Point(12, 56)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(317, 332)
        Me.grpButtons.TabIndex = 1
        Me.grpButtons.TabStop = False
        '
        'btnReportDiscrepancy
        '
        Me.btnReportDiscrepancy.Location = New System.Drawing.Point(5, 77)
        Me.btnReportDiscrepancy.Name = "btnReportDiscrepancy"
        Me.btnReportDiscrepancy.Size = New System.Drawing.Size(306, 23)
        Me.btnReportDiscrepancy.TabIndex = 2
        Me.btnReportDiscrepancy.Text = "&Discrepancies in Reports"
        Me.btnReportDiscrepancy.UseVisualStyleBackColor = True
        '
        'btnGCTransactionsMissing
        '
        Me.btnGCTransactionsMissing.Location = New System.Drawing.Point(5, 222)
        Me.btnGCTransactionsMissing.Name = "btnGCTransactionsMissing"
        Me.btnGCTransactionsMissing.Size = New System.Drawing.Size(306, 23)
        Me.btnGCTransactionsMissing.TabIndex = 7
        Me.btnGCTransactionsMissing.Text = "Gift Card Tra&nsactions Missing"
        Me.btnGCTransactionsMissing.UseVisualStyleBackColor = True
        '
        'btnGCActivationIssues
        '
        Me.btnGCActivationIssues.Location = New System.Drawing.Point(5, 164)
        Me.btnGCActivationIssues.Name = "btnGCActivationIssues"
        Me.btnGCActivationIssues.Size = New System.Drawing.Size(306, 23)
        Me.btnGCActivationIssues.TabIndex = 5
        Me.btnGCActivationIssues.Text = "&Gift Card Activation Issues"
        Me.btnGCActivationIssues.UseVisualStyleBackColor = True
        '
        'btnGCRedemptionIssues
        '
        Me.btnGCRedemptionIssues.Location = New System.Drawing.Point(5, 193)
        Me.btnGCRedemptionIssues.Name = "btnGCRedemptionIssues"
        Me.btnGCRedemptionIssues.Size = New System.Drawing.Size(306, 23)
        Me.btnGCRedemptionIssues.TabIndex = 6
        Me.btnGCRedemptionIssues.Text = "Gif&t Card Redemption Issues"
        Me.btnGCRedemptionIssues.UseVisualStyleBackColor = True
        '
        'btnFraud
        '
        Me.btnFraud.Location = New System.Drawing.Point(5, 135)
        Me.btnFraud.Name = "btnFraud"
        Me.btnFraud.Size = New System.Drawing.Size(306, 23)
        Me.btnFraud.TabIndex = 4
        Me.btnFraud.Text = "&Fraudulent Charges"
        Me.btnFraud.UseVisualStyleBackColor = True
        '
        'btnCCMachineDown
        '
        Me.btnCCMachineDown.Location = New System.Drawing.Point(5, 19)
        Me.btnCCMachineDown.Name = "btnCCMachineDown"
        Me.btnCCMachineDown.Size = New System.Drawing.Size(306, 23)
        Me.btnCCMachineDown.TabIndex = 0
        Me.btnCCMachineDown.Text = "&Credit Card Machine Down"
        Me.btnCCMachineDown.UseVisualStyleBackColor = True
        '
        'btnDuplicateTransactions
        '
        Me.btnDuplicateTransactions.Location = New System.Drawing.Point(5, 106)
        Me.btnDuplicateTransactions.Name = "btnDuplicateTransactions"
        Me.btnDuplicateTransactions.Size = New System.Drawing.Size(306, 23)
        Me.btnDuplicateTransactions.TabIndex = 3
        Me.btnDuplicateTransactions.Text = "Du&plicate Transactions"
        Me.btnDuplicateTransactions.UseVisualStyleBackColor = True
        '
        'btnCCMachineNotPairing
        '
        Me.btnCCMachineNotPairing.Location = New System.Drawing.Point(5, 48)
        Me.btnCCMachineNotPairing.Name = "btnCCMachineNotPairing"
        Me.btnCCMachineNotPairing.Size = New System.Drawing.Size(306, 23)
        Me.btnCCMachineNotPairing.TabIndex = 1
        Me.btnCCMachineNotPairing.Text = "C&redit Card Machines Not Pairing/Syncing with Register"
        Me.btnCCMachineNotPairing.UseVisualStyleBackColor = True
        '
        'lblSelectIssue
        '
        Me.lblSelectIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectIssue.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectIssue.Name = "lblSelectIssue"
        Me.lblSelectIssue.Size = New System.Drawing.Size(317, 44)
        Me.lblSelectIssue.TabIndex = 0
        Me.lblSelectIssue.Text = "Gift/Credit Cards"
        Me.lblSelectIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CardIssues
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
        Me.Name = "CardIssues"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Card Issues (Credit/Gift)"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnReportDiscrepancy As Button
    Friend WithEvents btnGCTransactionsMissing As Button
    Friend WithEvents btnGCActivationIssues As Button
    Friend WithEvents btnGCRedemptionIssues As Button
    Friend WithEvents btnFraud As Button
    Friend WithEvents btnCCMachineDown As Button
    Friend WithEvents btnDuplicateTransactions As Button
    Friend WithEvents btnCCMachineNotPairing As Button
    Friend WithEvents lblSelectIssue As Label
End Class
