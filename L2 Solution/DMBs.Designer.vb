<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMBs
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
        Me.btnBlankScreens = New System.Windows.Forms.Button()
        Me.btnHardwareMalfunctions = New System.Windows.Forms.Button()
        Me.btnAllureIssues = New System.Windows.Forms.Button()
        Me.btnMissingImages = New System.Windows.Forms.Button()
        Me.btnWrongImages = New System.Windows.Forms.Button()
        Me.btnStaticUpdates = New System.Windows.Forms.Button()
        Me.lblSelectIssue = New System.Windows.Forms.Label()
        Me.btnPriceChangeRequests = New System.Windows.Forms.Button()
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
        Me.grpButtons.Controls.Add(Me.btnBlankScreens)
        Me.grpButtons.Controls.Add(Me.btnHardwareMalfunctions)
        Me.grpButtons.Controls.Add(Me.btnPriceChangeRequests)
        Me.grpButtons.Controls.Add(Me.btnAllureIssues)
        Me.grpButtons.Controls.Add(Me.btnMissingImages)
        Me.grpButtons.Controls.Add(Me.btnWrongImages)
        Me.grpButtons.Controls.Add(Me.btnStaticUpdates)
        Me.grpButtons.Location = New System.Drawing.Point(12, 56)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(317, 332)
        Me.grpButtons.TabIndex = 1
        Me.grpButtons.TabStop = False
        '
        'btnBlankScreens
        '
        Me.btnBlankScreens.Location = New System.Drawing.Point(5, 48)
        Me.btnBlankScreens.Name = "btnBlankScreens"
        Me.btnBlankScreens.Size = New System.Drawing.Size(306, 23)
        Me.btnBlankScreens.TabIndex = 1
        Me.btnBlankScreens.Text = "&Blank Screens"
        Me.btnBlankScreens.UseVisualStyleBackColor = True
        '
        'btnHardwareMalfunctions
        '
        Me.btnHardwareMalfunctions.Location = New System.Drawing.Point(5, 77)
        Me.btnHardwareMalfunctions.Name = "btnHardwareMalfunctions"
        Me.btnHardwareMalfunctions.Size = New System.Drawing.Size(306, 23)
        Me.btnHardwareMalfunctions.TabIndex = 2
        Me.btnHardwareMalfunctions.Text = "&Hardware Malfunctions"
        Me.btnHardwareMalfunctions.UseVisualStyleBackColor = True
        '
        'btnAllureIssues
        '
        Me.btnAllureIssues.Location = New System.Drawing.Point(5, 19)
        Me.btnAllureIssues.Name = "btnAllureIssues"
        Me.btnAllureIssues.Size = New System.Drawing.Size(306, 23)
        Me.btnAllureIssues.TabIndex = 0
        Me.btnAllureIssues.Text = "A&llure Issues"
        Me.btnAllureIssues.UseVisualStyleBackColor = True
        '
        'btnMissingImages
        '
        Me.btnMissingImages.Location = New System.Drawing.Point(5, 106)
        Me.btnMissingImages.Name = "btnMissingImages"
        Me.btnMissingImages.Size = New System.Drawing.Size(306, 23)
        Me.btnMissingImages.TabIndex = 3
        Me.btnMissingImages.Text = "&Missing Images"
        Me.btnMissingImages.UseVisualStyleBackColor = True
        '
        'btnWrongImages
        '
        Me.btnWrongImages.Location = New System.Drawing.Point(5, 193)
        Me.btnWrongImages.Name = "btnWrongImages"
        Me.btnWrongImages.Size = New System.Drawing.Size(306, 23)
        Me.btnWrongImages.TabIndex = 6
        Me.btnWrongImages.Text = "&Wrong Images"
        Me.btnWrongImages.UseVisualStyleBackColor = True
        '
        'btnStaticUpdates
        '
        Me.btnStaticUpdates.Location = New System.Drawing.Point(5, 164)
        Me.btnStaticUpdates.Name = "btnStaticUpdates"
        Me.btnStaticUpdates.Size = New System.Drawing.Size(306, 23)
        Me.btnStaticUpdates.TabIndex = 5
        Me.btnStaticUpdates.Text = "&Static Updates"
        Me.btnStaticUpdates.UseVisualStyleBackColor = True
        '
        'lblSelectIssue
        '
        Me.lblSelectIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectIssue.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectIssue.Name = "lblSelectIssue"
        Me.lblSelectIssue.Size = New System.Drawing.Size(317, 44)
        Me.lblSelectIssue.TabIndex = 0
        Me.lblSelectIssue.Text = "Digital Menu Boards (DMBs)"
        Me.lblSelectIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPriceChangeRequests
        '
        Me.btnPriceChangeRequests.Location = New System.Drawing.Point(5, 135)
        Me.btnPriceChangeRequests.Name = "btnPriceChangeRequests"
        Me.btnPriceChangeRequests.Size = New System.Drawing.Size(306, 23)
        Me.btnPriceChangeRequests.TabIndex = 4
        Me.btnPriceChangeRequests.Text = "&Price Change Requests"
        Me.btnPriceChangeRequests.UseVisualStyleBackColor = True
        '
        'DMBs
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
        Me.Name = "DMBs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Digital Menu Boards"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnBlankScreens As Button
    Friend WithEvents btnHardwareMalfunctions As Button
    Friend WithEvents btnAllureIssues As Button
    Friend WithEvents btnMissingImages As Button
    Friend WithEvents btnWrongImages As Button
    Friend WithEvents btnStaticUpdates As Button
    Friend WithEvents lblSelectIssue As Label
    Friend WithEvents btnPriceChangeRequests As Button
End Class
