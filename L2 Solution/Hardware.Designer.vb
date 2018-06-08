<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hardware
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
        Me.btnSystemConfiguration = New System.Windows.Forms.Button()
        Me.btnFingerPrintReader = New System.Windows.Forms.Button()
        Me.btnCashDrawer = New System.Windows.Forms.Button()
        Me.btnPizzaPortal = New System.Windows.Forms.Button()
        Me.btnScanners = New System.Windows.Forms.Button()
        Me.btnRegistersCountersCC = New System.Windows.Forms.Button()
        Me.btnDMB = New System.Windows.Forms.Button()
        Me.btnCommandScreens = New System.Windows.Forms.Button()
        Me.btnServer = New System.Windows.Forms.Button()
        Me.btnPrinters = New System.Windows.Forms.Button()
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
        Me.grpButtons.Controls.Add(Me.btnSystemConfiguration)
        Me.grpButtons.Controls.Add(Me.btnFingerPrintReader)
        Me.grpButtons.Controls.Add(Me.btnCashDrawer)
        Me.grpButtons.Controls.Add(Me.btnPizzaPortal)
        Me.grpButtons.Controls.Add(Me.btnScanners)
        Me.grpButtons.Controls.Add(Me.btnRegistersCountersCC)
        Me.grpButtons.Controls.Add(Me.btnDMB)
        Me.grpButtons.Controls.Add(Me.btnCommandScreens)
        Me.grpButtons.Controls.Add(Me.btnServer)
        Me.grpButtons.Controls.Add(Me.btnPrinters)
        Me.grpButtons.Location = New System.Drawing.Point(12, 56)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(317, 332)
        Me.grpButtons.TabIndex = 1
        Me.grpButtons.TabStop = False
        '
        'btnSystemConfiguration
        '
        Me.btnSystemConfiguration.Enabled = False
        Me.btnSystemConfiguration.Location = New System.Drawing.Point(5, 280)
        Me.btnSystemConfiguration.Name = "btnSystemConfiguration"
        Me.btnSystemConfiguration.Size = New System.Drawing.Size(306, 23)
        Me.btnSystemConfiguration.TabIndex = 9
        Me.btnSystemConfiguration.Text = "S&ystem Configuration"
        Me.btnSystemConfiguration.UseVisualStyleBackColor = True
        '
        'btnFingerPrintReader
        '
        Me.btnFingerPrintReader.Location = New System.Drawing.Point(5, 77)
        Me.btnFingerPrintReader.Name = "btnFingerPrintReader"
        Me.btnFingerPrintReader.Size = New System.Drawing.Size(306, 23)
        Me.btnFingerPrintReader.TabIndex = 2
        Me.btnFingerPrintReader.Text = "&Finger Print Reader"
        Me.btnFingerPrintReader.UseVisualStyleBackColor = True
        '
        'btnCashDrawer
        '
        Me.btnCashDrawer.Location = New System.Drawing.Point(5, 19)
        Me.btnCashDrawer.Name = "btnCashDrawer"
        Me.btnCashDrawer.Size = New System.Drawing.Size(306, 23)
        Me.btnCashDrawer.TabIndex = 0
        Me.btnCashDrawer.Text = "&Cash Drawer"
        Me.btnCashDrawer.UseVisualStyleBackColor = True
        '
        'btnPizzaPortal
        '
        Me.btnPizzaPortal.Location = New System.Drawing.Point(5, 135)
        Me.btnPizzaPortal.Name = "btnPizzaPortal"
        Me.btnPizzaPortal.Size = New System.Drawing.Size(306, 23)
        Me.btnPizzaPortal.TabIndex = 4
        Me.btnPizzaPortal.Text = "&Pizza Portal"
        Me.btnPizzaPortal.UseVisualStyleBackColor = True
        '
        'btnScanners
        '
        Me.btnScanners.Location = New System.Drawing.Point(5, 222)
        Me.btnScanners.Name = "btnScanners"
        Me.btnScanners.Size = New System.Drawing.Size(306, 23)
        Me.btnScanners.TabIndex = 7
        Me.btnScanners.Text = "&Scanners"
        Me.btnScanners.UseVisualStyleBackColor = True
        '
        'btnRegistersCountersCC
        '
        Me.btnRegistersCountersCC.Location = New System.Drawing.Point(5, 193)
        Me.btnRegistersCountersCC.Name = "btnRegistersCountersCC"
        Me.btnRegistersCountersCC.Size = New System.Drawing.Size(306, 23)
        Me.btnRegistersCountersCC.TabIndex = 6
        Me.btnRegistersCountersCC.Text = "Re&gisters/Counters/Credit Card Machines"
        Me.btnRegistersCountersCC.UseVisualStyleBackColor = True
        '
        'btnDMB
        '
        Me.btnDMB.Location = New System.Drawing.Point(5, 48)
        Me.btnDMB.Name = "btnDMB"
        Me.btnDMB.Size = New System.Drawing.Size(306, 23)
        Me.btnDMB.TabIndex = 1
        Me.btnDMB.Text = "&Digital Menu Boards"
        Me.btnDMB.UseVisualStyleBackColor = True
        '
        'btnCommandScreens
        '
        Me.btnCommandScreens.Location = New System.Drawing.Point(5, 106)
        Me.btnCommandScreens.Name = "btnCommandScreens"
        Me.btnCommandScreens.Size = New System.Drawing.Size(306, 23)
        Me.btnCommandScreens.TabIndex = 3
        Me.btnCommandScreens.Text = "&Landing/Command Screens"
        Me.btnCommandScreens.UseVisualStyleBackColor = True
        '
        'btnServer
        '
        Me.btnServer.Location = New System.Drawing.Point(5, 251)
        Me.btnServer.Name = "btnServer"
        Me.btnServer.Size = New System.Drawing.Size(306, 23)
        Me.btnServer.TabIndex = 8
        Me.btnServer.Text = "Ser&ver Issues (Disk Space Warning)"
        Me.btnServer.UseVisualStyleBackColor = True
        '
        'btnPrinters
        '
        Me.btnPrinters.Location = New System.Drawing.Point(5, 164)
        Me.btnPrinters.Name = "btnPrinters"
        Me.btnPrinters.Size = New System.Drawing.Size(306, 23)
        Me.btnPrinters.TabIndex = 5
        Me.btnPrinters.Text = "P&rinters"
        Me.btnPrinters.UseVisualStyleBackColor = True
        '
        'lblSelectIssue
        '
        Me.lblSelectIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectIssue.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectIssue.Name = "lblSelectIssue"
        Me.lblSelectIssue.Size = New System.Drawing.Size(317, 44)
        Me.lblSelectIssue.TabIndex = 0
        Me.lblSelectIssue.Text = "Hardware"
        Me.lblSelectIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Hardware
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
        Me.Name = "Hardware"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hardware"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnFingerPrintReader As Button
    Friend WithEvents btnCashDrawer As Button
    Friend WithEvents btnPizzaPortal As Button
    Friend WithEvents btnScanners As Button
    Friend WithEvents btnRegistersCountersCC As Button
    Friend WithEvents btnDMB As Button
    Friend WithEvents btnCommandScreens As Button
    Friend WithEvents btnServer As Button
    Friend WithEvents btnPrinters As Button
    Friend WithEvents lblSelectIssue As Label
    Friend WithEvents btnSystemConfiguration As Button
End Class
