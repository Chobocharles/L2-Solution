<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.btnBlueLine = New System.Windows.Forms.Button()
        Me.btnIVR = New System.Windows.Forms.Button()
        Me.btnVerifyDay = New System.Windows.Forms.Button()
        Me.btnKeyItem = New System.Windows.Forms.Button()
        Me.btnOCB = New System.Windows.Forms.Button()
        Me.btnCOGS = New System.Windows.Forms.Button()
        Me.lblReports = New System.Windows.Forms.Label()
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
        Me.grpButtons.Controls.Add(Me.btnBlueLine)
        Me.grpButtons.Controls.Add(Me.btnIVR)
        Me.grpButtons.Controls.Add(Me.btnVerifyDay)
        Me.grpButtons.Controls.Add(Me.btnKeyItem)
        Me.grpButtons.Controls.Add(Me.btnOCB)
        Me.grpButtons.Controls.Add(Me.btnCOGS)
        Me.grpButtons.Location = New System.Drawing.Point(12, 56)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(317, 332)
        Me.grpButtons.TabIndex = 1
        Me.grpButtons.TabStop = False
        '
        'btnDailySummary
        '
        Me.btnDailySummary.Location = New System.Drawing.Point(5, 77)
        Me.btnDailySummary.Name = "btnDailySummary"
        Me.btnDailySummary.Size = New System.Drawing.Size(306, 23)
        Me.btnDailySummary.TabIndex = 2
        Me.btnDailySummary.Text = "&Daily Summary Report"
        Me.btnDailySummary.UseVisualStyleBackColor = True
        '
        'btnBlueLine
        '
        Me.btnBlueLine.Location = New System.Drawing.Point(5, 19)
        Me.btnBlueLine.Name = "btnBlueLine"
        Me.btnBlueLine.Size = New System.Drawing.Size(306, 23)
        Me.btnBlueLine.TabIndex = 0
        Me.btnBlueLine.Text = "&Blue Line"
        Me.btnBlueLine.UseVisualStyleBackColor = True
        '
        'btnIVR
        '
        Me.btnIVR.Location = New System.Drawing.Point(5, 106)
        Me.btnIVR.Name = "btnIVR"
        Me.btnIVR.Size = New System.Drawing.Size(306, 23)
        Me.btnIVR.TabIndex = 3
        Me.btnIVR.Text = "I&VR Reports"
        Me.btnIVR.UseVisualStyleBackColor = True
        '
        'btnVerifyDay
        '
        Me.btnVerifyDay.Location = New System.Drawing.Point(5, 193)
        Me.btnVerifyDay.Name = "btnVerifyDay"
        Me.btnVerifyDay.Size = New System.Drawing.Size(306, 23)
        Me.btnVerifyDay.TabIndex = 6
        Me.btnVerifyDay.Text = "&Verify Day Issues"
        Me.btnVerifyDay.UseVisualStyleBackColor = True
        '
        'btnKeyItem
        '
        Me.btnKeyItem.Enabled = False
        Me.btnKeyItem.Location = New System.Drawing.Point(5, 135)
        Me.btnKeyItem.Name = "btnKeyItem"
        Me.btnKeyItem.Size = New System.Drawing.Size(306, 23)
        Me.btnKeyItem.TabIndex = 4
        Me.btnKeyItem.Text = "&Key Item Report"
        Me.btnKeyItem.UseVisualStyleBackColor = True
        '
        'btnOCB
        '
        Me.btnOCB.Location = New System.Drawing.Point(5, 164)
        Me.btnOCB.Name = "btnOCB"
        Me.btnOCB.Size = New System.Drawing.Size(306, 23)
        Me.btnOCB.TabIndex = 5
        Me.btnOCB.Text = "OCB &Reports"
        Me.btnOCB.UseVisualStyleBackColor = True
        '
        'btnCOGS
        '
        Me.btnCOGS.Location = New System.Drawing.Point(5, 48)
        Me.btnCOGS.Name = "btnCOGS"
        Me.btnCOGS.Size = New System.Drawing.Size(306, 23)
        Me.btnCOGS.TabIndex = 1
        Me.btnCOGS.Text = "&COGS Report"
        Me.btnCOGS.UseVisualStyleBackColor = True
        '
        'lblReports
        '
        Me.lblReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReports.Location = New System.Drawing.Point(12, 9)
        Me.lblReports.Name = "lblReports"
        Me.lblReports.Size = New System.Drawing.Size(317, 44)
        Me.lblReports.TabIndex = 0
        Me.lblReports.Text = "Reports"
        Me.lblReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(341, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblReports)
        Me.Controls.Add(Me.grpButtons)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnDailySummary As Button
    Friend WithEvents btnBlueLine As Button
    Friend WithEvents btnIVR As Button
    Friend WithEvents btnVerifyDay As Button
    Friend WithEvents btnKeyItem As Button
    Friend WithEvents btnOCB As Button
    Friend WithEvents btnCOGS As Button
    Friend WithEvents lblReports As Label
End Class
