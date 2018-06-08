<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Database
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
        Me.btnTaxRates = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.btnSchema = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnSuspectMode = New System.Windows.Forms.Button()
        Me.btnRecovery = New System.Windows.Forms.Button()
        Me.btnSyncing = New System.Windows.Forms.Button()
        Me.btnCorrupt = New System.Windows.Forms.Button()
        Me.btnDatabaseChangeError = New System.Windows.Forms.Button()
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
        Me.grpButtons.Controls.Add(Me.btnTaxRates)
        Me.grpButtons.Controls.Add(Me.btnMaintenance)
        Me.grpButtons.Controls.Add(Me.btnSchema)
        Me.grpButtons.Controls.Add(Me.btnBackup)
        Me.grpButtons.Controls.Add(Me.btnSuspectMode)
        Me.grpButtons.Controls.Add(Me.btnRecovery)
        Me.grpButtons.Controls.Add(Me.btnSyncing)
        Me.grpButtons.Controls.Add(Me.btnCorrupt)
        Me.grpButtons.Controls.Add(Me.btnDatabaseChangeError)
        Me.grpButtons.Location = New System.Drawing.Point(12, 56)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(317, 332)
        Me.grpButtons.TabIndex = 1
        Me.grpButtons.TabStop = False
        '
        'btnTaxRates
        '
        Me.btnTaxRates.Location = New System.Drawing.Point(5, 251)
        Me.btnTaxRates.Name = "btnTaxRates"
        Me.btnTaxRates.Size = New System.Drawing.Size(306, 23)
        Me.btnTaxRates.TabIndex = 8
        Me.btnTaxRates.Text = "&Tax Rate Issues"
        Me.btnTaxRates.UseVisualStyleBackColor = True
        '
        'btnMaintenance
        '
        Me.btnMaintenance.Location = New System.Drawing.Point(5, 135)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(306, 23)
        Me.btnMaintenance.TabIndex = 4
        Me.btnMaintenance.Text = "Database &Maintenance"
        Me.btnMaintenance.UseVisualStyleBackColor = True
        '
        'btnSchema
        '
        Me.btnSchema.Location = New System.Drawing.Point(5, 193)
        Me.btnSchema.Name = "btnSchema"
        Me.btnSchema.Size = New System.Drawing.Size(306, 23)
        Me.btnSchema.TabIndex = 6
        Me.btnSchema.Text = "Sc&hema Issues"
        Me.btnSchema.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(5, 48)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(306, 23)
        Me.btnBackup.TabIndex = 1
        Me.btnBackup.Text = "Database &Backups"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnSuspectMode
        '
        Me.btnSuspectMode.Location = New System.Drawing.Point(5, 106)
        Me.btnSuspectMode.Name = "btnSuspectMode"
        Me.btnSuspectMode.Size = New System.Drawing.Size(306, 23)
        Me.btnSuspectMode.TabIndex = 3
        Me.btnSuspectMode.Text = "Database in &Suspect Mode"
        Me.btnSuspectMode.UseVisualStyleBackColor = True
        '
        'btnRecovery
        '
        Me.btnRecovery.Location = New System.Drawing.Point(5, 164)
        Me.btnRecovery.Name = "btnRecovery"
        Me.btnRecovery.Size = New System.Drawing.Size(306, 23)
        Me.btnRecovery.TabIndex = 5
        Me.btnRecovery.Text = "Database &Recovery"
        Me.btnRecovery.UseVisualStyleBackColor = True
        '
        'btnSyncing
        '
        Me.btnSyncing.Location = New System.Drawing.Point(5, 222)
        Me.btnSyncing.Name = "btnSyncing"
        Me.btnSyncing.Size = New System.Drawing.Size(306, 23)
        Me.btnSyncing.TabIndex = 7
        Me.btnSyncing.Text = "S&yncing Errors"
        Me.btnSyncing.UseVisualStyleBackColor = True
        '
        'btnCorrupt
        '
        Me.btnCorrupt.Location = New System.Drawing.Point(5, 19)
        Me.btnCorrupt.Name = "btnCorrupt"
        Me.btnCorrupt.Size = New System.Drawing.Size(306, 23)
        Me.btnCorrupt.TabIndex = 0
        Me.btnCorrupt.Text = "&Corrupt Database"
        Me.btnCorrupt.UseVisualStyleBackColor = True
        '
        'btnDatabaseChangeError
        '
        Me.btnDatabaseChangeError.Location = New System.Drawing.Point(5, 77)
        Me.btnDatabaseChangeError.Name = "btnDatabaseChangeError"
        Me.btnDatabaseChangeError.Size = New System.Drawing.Size(306, 23)
        Me.btnDatabaseChangeError.TabIndex = 2
        Me.btnDatabaseChangeError.Text = "&Database Change Error"
        Me.btnDatabaseChangeError.UseVisualStyleBackColor = True
        '
        'lblSelectIssue
        '
        Me.lblSelectIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectIssue.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectIssue.Name = "lblSelectIssue"
        Me.lblSelectIssue.Size = New System.Drawing.Size(317, 44)
        Me.lblSelectIssue.TabIndex = 0
        Me.lblSelectIssue.Text = "Database Management"
        Me.lblSelectIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Database
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
        Me.Name = "Database"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Management"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnMaintenance As Button
    Friend WithEvents btnSchema As Button
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnSuspectMode As Button
    Friend WithEvents btnRecovery As Button
    Friend WithEvents btnSyncing As Button
    Friend WithEvents btnCorrupt As Button
    Friend WithEvents btnDatabaseChangeError As Button
    Friend WithEvents lblSelectIssue As Label
    Friend WithEvents btnTaxRates As Button
End Class
