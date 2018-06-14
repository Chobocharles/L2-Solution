<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPageTwo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnDatabase = New System.Windows.Forms.Button()
        Me.btnCards = New System.Windows.Forms.Button()
        Me.btnCustomerEd = New System.Windows.Forms.Button()
        Me.btnDMBs = New System.Windows.Forms.Button()
        Me.btnHardware = New System.Windows.Forms.Button()
        Me.btnSoftware = New System.Windows.Forms.Button()
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.btnNewStore = New System.Windows.Forms.Button()
        Me.btnOCB = New System.Windows.Forms.Button()
        Me.btnOnline = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSelectIssue = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.grpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDatabase
        '
        Me.btnDatabase.Location = New System.Drawing.Point(5, 48)
        Me.btnDatabase.Name = "btnDatabase"
        Me.btnDatabase.Size = New System.Drawing.Size(306, 23)
        Me.btnDatabase.TabIndex = 1
        Me.btnDatabase.Text = "&Databases/Taxrates"
        Me.btnDatabase.UseVisualStyleBackColor = True
        '
        'btnCards
        '
        Me.btnCards.Location = New System.Drawing.Point(6, 19)
        Me.btnCards.Name = "btnCards"
        Me.btnCards.Size = New System.Drawing.Size(306, 23)
        Me.btnCards.TabIndex = 0
        Me.btnCards.Text = "Ca&rd Issues (Credit/Gift)"
        Me.btnCards.UseVisualStyleBackColor = True
        '
        'btnCustomerEd
        '
        Me.btnCustomerEd.Location = New System.Drawing.Point(5, 106)
        Me.btnCustomerEd.Name = "btnCustomerEd"
        Me.btnCustomerEd.Size = New System.Drawing.Size(306, 23)
        Me.btnCustomerEd.TabIndex = 3
        Me.btnCustomerEd.Text = "&General Questions/Customer Education/Login Issues"
        Me.btnCustomerEd.UseVisualStyleBackColor = True
        '
        'btnDMBs
        '
        Me.btnDMBs.Location = New System.Drawing.Point(5, 77)
        Me.btnDMBs.Name = "btnDMBs"
        Me.btnDMBs.Size = New System.Drawing.Size(306, 23)
        Me.btnDMBs.TabIndex = 2
        Me.btnDMBs.Text = "Digital Menu &Boards (DMBs)"
        Me.btnDMBs.UseVisualStyleBackColor = True
        '
        'btnHardware
        '
        Me.btnHardware.Location = New System.Drawing.Point(5, 135)
        Me.btnHardware.Name = "btnHardware"
        Me.btnHardware.Size = New System.Drawing.Size(306, 23)
        Me.btnHardware.TabIndex = 4
        Me.btnHardware.Text = "&Hardware"
        Me.btnHardware.UseVisualStyleBackColor = True
        '
        'btnSoftware
        '
        Me.btnSoftware.Location = New System.Drawing.Point(5, 280)
        Me.btnSoftware.Name = "btnSoftware"
        Me.btnSoftware.Size = New System.Drawing.Size(306, 23)
        Me.btnSoftware.TabIndex = 9
        Me.btnSoftware.Text = "&Software"
        Me.btnSoftware.UseVisualStyleBackColor = True
        '
        'grpButtons
        '
        Me.grpButtons.BackColor = System.Drawing.SystemColors.Control
        Me.grpButtons.Controls.Add(Me.btnNewStore)
        Me.grpButtons.Controls.Add(Me.btnOCB)
        Me.grpButtons.Controls.Add(Me.btnOnline)
        Me.grpButtons.Controls.Add(Me.btnReports)
        Me.grpButtons.Controls.Add(Me.btnDMBs)
        Me.grpButtons.Controls.Add(Me.btnSoftware)
        Me.grpButtons.Controls.Add(Me.btnDatabase)
        Me.grpButtons.Controls.Add(Me.btnHardware)
        Me.grpButtons.Controls.Add(Me.btnCards)
        Me.grpButtons.Controls.Add(Me.btnCustomerEd)
        Me.grpButtons.Location = New System.Drawing.Point(12, 56)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(317, 332)
        Me.grpButtons.TabIndex = 1
        Me.grpButtons.TabStop = False
        '
        'btnNewStore
        '
        Me.btnNewStore.Location = New System.Drawing.Point(5, 164)
        Me.btnNewStore.Name = "btnNewStore"
        Me.btnNewStore.Size = New System.Drawing.Size(306, 23)
        Me.btnNewStore.TabIndex = 5
        Me.btnNewStore.Text = "&New Stores and Equipment/Store Transfers"
        Me.btnNewStore.UseVisualStyleBackColor = True
        '
        'btnOCB
        '
        Me.btnOCB.Location = New System.Drawing.Point(5, 193)
        Me.btnOCB.Name = "btnOCB"
        Me.btnOCB.Size = New System.Drawing.Size(306, 23)
        Me.btnOCB.TabIndex = 6
        Me.btnOCB.Text = "O&CB/SCB"
        Me.btnOCB.UseVisualStyleBackColor = True
        '
        'btnOnline
        '
        Me.btnOnline.Location = New System.Drawing.Point(5, 222)
        Me.btnOnline.Name = "btnOnline"
        Me.btnOnline.Size = New System.Drawing.Size(306, 23)
        Me.btnOnline.TabIndex = 7
        Me.btnOnline.Text = "Online Ordering/&Mobile"
        Me.btnOnline.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(5, 251)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(306, 23)
        Me.btnReports.TabIndex = 8
        Me.btnReports.Text = "&Reports"
        Me.btnReports.UseVisualStyleBackColor = True
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
        'lblSelectIssue
        '
        Me.lblSelectIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectIssue.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectIssue.Name = "lblSelectIssue"
        Me.lblSelectIssue.Size = New System.Drawing.Size(317, 44)
        Me.lblSelectIssue.TabIndex = 0
        Me.lblSelectIssue.Text = "Select an Issue"
        Me.lblSelectIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(167, 398)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 2
        Me.btnHelp.Text = "Hel&p"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'frmPageTwo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(341, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblSelectIssue)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmPageTwo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LC Support"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDatabase As Button
    Friend WithEvents btnCards As Button
    Friend WithEvents btnCustomerEd As Button
    Friend WithEvents btnDMBs As Button
    Friend WithEvents btnHardware As Button
    Friend WithEvents btnSoftware As Button
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNewStore As Button
    Friend WithEvents btnOCB As Button
    Friend WithEvents btnOnline As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents lblSelectIssue As Label
    Friend WithEvents btnHelp As Button
End Class
