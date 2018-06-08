<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewStore
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
        Me.btnInitialSetup = New System.Windows.Forms.Button()
        Me.btnUpdates = New System.Windows.Forms.Button()
        Me.btnDMBSetup = New System.Windows.Forms.Button()
        Me.btnComputerImaging = New System.Windows.Forms.Button()
        Me.btnSoftwareInstallation = New System.Windows.Forms.Button()
        Me.btnNewServer = New System.Windows.Forms.Button()
        Me.btnStoreTransfer = New System.Windows.Forms.Button()
        Me.btnNewStore = New System.Windows.Forms.Button()
        Me.btnStoreValidation = New System.Windows.Forms.Button()
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
        Me.grpButtons.Controls.Add(Me.btnInitialSetup)
        Me.grpButtons.Controls.Add(Me.btnUpdates)
        Me.grpButtons.Controls.Add(Me.btnDMBSetup)
        Me.grpButtons.Controls.Add(Me.btnComputerImaging)
        Me.grpButtons.Controls.Add(Me.btnSoftwareInstallation)
        Me.grpButtons.Controls.Add(Me.btnNewServer)
        Me.grpButtons.Controls.Add(Me.btnStoreTransfer)
        Me.grpButtons.Controls.Add(Me.btnNewStore)
        Me.grpButtons.Controls.Add(Me.btnStoreValidation)
        Me.grpButtons.Location = New System.Drawing.Point(12, 56)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(317, 332)
        Me.grpButtons.TabIndex = 1
        Me.grpButtons.TabStop = False
        '
        'btnInitialSetup
        '
        Me.btnInitialSetup.Enabled = False
        Me.btnInitialSetup.Location = New System.Drawing.Point(5, 77)
        Me.btnInitialSetup.Name = "btnInitialSetup"
        Me.btnInitialSetup.Size = New System.Drawing.Size(306, 23)
        Me.btnInitialSetup.TabIndex = 2
        Me.btnInitialSetup.Text = "Initial &Setup"
        Me.btnInitialSetup.UseVisualStyleBackColor = True
        '
        'btnUpdates
        '
        Me.btnUpdates.Location = New System.Drawing.Point(6, 251)
        Me.btnUpdates.Name = "btnUpdates"
        Me.btnUpdates.Size = New System.Drawing.Size(306, 23)
        Me.btnUpdates.TabIndex = 8
        Me.btnUpdates.Text = "U&pdates"
        Me.btnUpdates.UseVisualStyleBackColor = True
        '
        'btnDMBSetup
        '
        Me.btnDMBSetup.Enabled = False
        Me.btnDMBSetup.Location = New System.Drawing.Point(5, 48)
        Me.btnDMBSetup.Name = "btnDMBSetup"
        Me.btnDMBSetup.Size = New System.Drawing.Size(306, 23)
        Me.btnDMBSetup.TabIndex = 1
        Me.btnDMBSetup.Text = "&DMB Setup"
        Me.btnDMBSetup.UseVisualStyleBackColor = True
        '
        'btnComputerImaging
        '
        Me.btnComputerImaging.Enabled = False
        Me.btnComputerImaging.Location = New System.Drawing.Point(5, 19)
        Me.btnComputerImaging.Name = "btnComputerImaging"
        Me.btnComputerImaging.Size = New System.Drawing.Size(306, 23)
        Me.btnComputerImaging.TabIndex = 0
        Me.btnComputerImaging.Text = "&Computer Imaging"
        Me.btnComputerImaging.UseVisualStyleBackColor = True
        '
        'btnSoftwareInstallation
        '
        Me.btnSoftwareInstallation.Enabled = False
        Me.btnSoftwareInstallation.Location = New System.Drawing.Point(5, 164)
        Me.btnSoftwareInstallation.Name = "btnSoftwareInstallation"
        Me.btnSoftwareInstallation.Size = New System.Drawing.Size(306, 23)
        Me.btnSoftwareInstallation.TabIndex = 5
        Me.btnSoftwareInstallation.Text = "&Software Installation"
        Me.btnSoftwareInstallation.UseVisualStyleBackColor = True
        '
        'btnNewServer
        '
        Me.btnNewServer.Enabled = False
        Me.btnNewServer.Location = New System.Drawing.Point(5, 106)
        Me.btnNewServer.Name = "btnNewServer"
        Me.btnNewServer.Size = New System.Drawing.Size(306, 23)
        Me.btnNewServer.TabIndex = 3
        Me.btnNewServer.Text = "&New Server"
        Me.btnNewServer.UseVisualStyleBackColor = True
        '
        'btnStoreTransfer
        '
        Me.btnStoreTransfer.Enabled = False
        Me.btnStoreTransfer.Location = New System.Drawing.Point(5, 193)
        Me.btnStoreTransfer.Name = "btnStoreTransfer"
        Me.btnStoreTransfer.Size = New System.Drawing.Size(306, 23)
        Me.btnStoreTransfer.TabIndex = 6
        Me.btnStoreTransfer.Text = "S&tore Transfer"
        Me.btnStoreTransfer.UseVisualStyleBackColor = True
        '
        'btnNewStore
        '
        Me.btnNewStore.Location = New System.Drawing.Point(5, 135)
        Me.btnNewStore.Name = "btnNewStore"
        Me.btnNewStore.Size = New System.Drawing.Size(306, 23)
        Me.btnNewStore.TabIndex = 4
        Me.btnNewStore.Text = "Ne&w Store / Buy - Sell"
        Me.btnNewStore.UseVisualStyleBackColor = True
        '
        'btnStoreValidation
        '
        Me.btnStoreValidation.Location = New System.Drawing.Point(6, 222)
        Me.btnStoreValidation.Name = "btnStoreValidation"
        Me.btnStoreValidation.Size = New System.Drawing.Size(306, 23)
        Me.btnStoreValidation.TabIndex = 7
        Me.btnStoreValidation.Text = "Store &Validation"
        Me.btnStoreValidation.UseVisualStyleBackColor = True
        '
        'lblSelectIssue
        '
        Me.lblSelectIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectIssue.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectIssue.Name = "lblSelectIssue"
        Me.lblSelectIssue.Size = New System.Drawing.Size(317, 44)
        Me.lblSelectIssue.TabIndex = 0
        Me.lblSelectIssue.Text = "Store Transfers and Buy/Sells"
        Me.lblSelectIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewStore
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
        Me.Name = "NewStore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Store/Store Transfers"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnInitialSetup As Button
    Friend WithEvents btnUpdates As Button
    Friend WithEvents btnDMBSetup As Button
    Friend WithEvents btnComputerImaging As Button
    Friend WithEvents btnSoftwareInstallation As Button
    Friend WithEvents btnNewServer As Button
    Friend WithEvents btnStoreTransfer As Button
    Friend WithEvents btnNewStore As Button
    Friend WithEvents btnStoreValidation As Button
    Friend WithEvents lblSelectIssue As Label
End Class
