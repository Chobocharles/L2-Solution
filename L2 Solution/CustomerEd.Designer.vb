<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerEd
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
        Me.btnWalkthroughs = New System.Windows.Forms.Button()
        Me.btnGeneralQuestions = New System.Windows.Forms.Button()
        Me.btnLoggingIn = New System.Windows.Forms.Button()
        Me.btnExplanationOfReports = New System.Windows.Forms.Button()
        Me.btnSelfHelp = New System.Windows.Forms.Button()
        Me.btnPasswords = New System.Windows.Forms.Button()
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
        Me.grpButtons.Controls.Add(Me.btnWalkthroughs)
        Me.grpButtons.Controls.Add(Me.btnGeneralQuestions)
        Me.grpButtons.Controls.Add(Me.btnLoggingIn)
        Me.grpButtons.Controls.Add(Me.btnExplanationOfReports)
        Me.grpButtons.Controls.Add(Me.btnSelfHelp)
        Me.grpButtons.Controls.Add(Me.btnPasswords)
        Me.grpButtons.Location = New System.Drawing.Point(12, 56)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(317, 332)
        Me.grpButtons.TabIndex = 1
        Me.grpButtons.TabStop = False
        '
        'btnWalkthroughs
        '
        Me.btnWalkthroughs.Location = New System.Drawing.Point(6, 164)
        Me.btnWalkthroughs.Name = "btnWalkthroughs"
        Me.btnWalkthroughs.Size = New System.Drawing.Size(306, 23)
        Me.btnWalkthroughs.TabIndex = 5
        Me.btnWalkthroughs.Text = "&Walkthroughs"
        Me.btnWalkthroughs.UseVisualStyleBackColor = True
        '
        'btnGeneralQuestions
        '
        Me.btnGeneralQuestions.Location = New System.Drawing.Point(6, 48)
        Me.btnGeneralQuestions.Name = "btnGeneralQuestions"
        Me.btnGeneralQuestions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGeneralQuestions.Size = New System.Drawing.Size(306, 23)
        Me.btnGeneralQuestions.TabIndex = 1
        Me.btnGeneralQuestions.Text = "&General Questions"
        Me.btnGeneralQuestions.UseVisualStyleBackColor = True
        '
        'btnLoggingIn
        '
        Me.btnLoggingIn.Location = New System.Drawing.Point(6, 77)
        Me.btnLoggingIn.Name = "btnLoggingIn"
        Me.btnLoggingIn.Size = New System.Drawing.Size(306, 23)
        Me.btnLoggingIn.TabIndex = 2
        Me.btnLoggingIn.Text = "&Logging In"
        Me.btnLoggingIn.UseVisualStyleBackColor = True
        '
        'btnExplanationOfReports
        '
        Me.btnExplanationOfReports.Location = New System.Drawing.Point(6, 19)
        Me.btnExplanationOfReports.Name = "btnExplanationOfReports"
        Me.btnExplanationOfReports.Size = New System.Drawing.Size(306, 23)
        Me.btnExplanationOfReports.TabIndex = 0
        Me.btnExplanationOfReports.Text = "Explanation of &Reports"
        Me.btnExplanationOfReports.UseVisualStyleBackColor = True
        '
        'btnSelfHelp
        '
        Me.btnSelfHelp.Location = New System.Drawing.Point(6, 135)
        Me.btnSelfHelp.Name = "btnSelfHelp"
        Me.btnSelfHelp.Size = New System.Drawing.Size(306, 23)
        Me.btnSelfHelp.TabIndex = 4
        Me.btnSelfHelp.Text = "&Self-Help Education"
        Me.btnSelfHelp.UseVisualStyleBackColor = True
        '
        'btnPasswords
        '
        Me.btnPasswords.Location = New System.Drawing.Point(5, 106)
        Me.btnPasswords.Name = "btnPasswords"
        Me.btnPasswords.Size = New System.Drawing.Size(306, 23)
        Me.btnPasswords.TabIndex = 3
        Me.btnPasswords.Text = "&Password Errors"
        Me.btnPasswords.UseVisualStyleBackColor = True
        '
        'lblSelectIssue
        '
        Me.lblSelectIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectIssue.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectIssue.Name = "lblSelectIssue"
        Me.lblSelectIssue.Size = New System.Drawing.Size(317, 44)
        Me.lblSelectIssue.TabIndex = 0
        Me.lblSelectIssue.Text = "Customer Education"
        Me.lblSelectIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomerEd
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
        Me.Name = "CustomerEd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Ed/General Questions"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnGeneralQuestions As Button
    Friend WithEvents btnLoggingIn As Button
    Friend WithEvents btnExplanationOfReports As Button
    Friend WithEvents btnSelfHelp As Button
    Friend WithEvents btnPasswords As Button
    Friend WithEvents lblSelectIssue As Label
    Friend WithEvents btnWalkthroughs As Button
End Class
