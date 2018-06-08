<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Software
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
        Me.btnNewStore = New System.Windows.Forms.Button()
        Me.btnOnline = New System.Windows.Forms.Button()
        Me.btnPizzaPortal = New System.Windows.Forms.Button()
        Me.btnDMBs = New System.Windows.Forms.Button()
        Me.btnCaesarVision = New System.Windows.Forms.Button()
        Me.btnCards = New System.Windows.Forms.Button()
        Me.btnCustomerEd = New System.Windows.Forms.Button()
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
        Me.grpButtons.Controls.Add(Me.btnNewStore)
        Me.grpButtons.Controls.Add(Me.btnOnline)
        Me.grpButtons.Controls.Add(Me.btnPizzaPortal)
        Me.grpButtons.Controls.Add(Me.btnDMBs)
        Me.grpButtons.Controls.Add(Me.btnCaesarVision)
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
        Me.btnNewStore.Location = New System.Drawing.Point(5, 19)
        Me.btnNewStore.Name = "btnNewStore"
        Me.btnNewStore.Size = New System.Drawing.Size(306, 23)
        Me.btnNewStore.TabIndex = 0
        Me.btnNewStore.Text = "&Blue Line Issues"
        Me.btnNewStore.UseVisualStyleBackColor = True
        '
        'btnOnline
        '
        Me.btnOnline.Location = New System.Drawing.Point(5, 77)
        Me.btnOnline.Name = "btnOnline"
        Me.btnOnline.Size = New System.Drawing.Size(306, 23)
        Me.btnOnline.TabIndex = 2
        Me.btnOnline.Text = "Online Ordering/&Mobile"
        Me.btnOnline.UseVisualStyleBackColor = True
        '
        'btnPizzaPortal
        '
        Me.btnPizzaPortal.Location = New System.Drawing.Point(5, 106)
        Me.btnPizzaPortal.Name = "btnPizzaPortal"
        Me.btnPizzaPortal.Size = New System.Drawing.Size(306, 23)
        Me.btnPizzaPortal.TabIndex = 3
        Me.btnPizzaPortal.Text = "&Pizza Portal"
        Me.btnPizzaPortal.UseVisualStyleBackColor = True
        '
        'btnDMBs
        '
        Me.btnDMBs.Location = New System.Drawing.Point(5, 48)
        Me.btnDMBs.Name = "btnDMBs"
        Me.btnDMBs.Size = New System.Drawing.Size(306, 23)
        Me.btnDMBs.TabIndex = 1
        Me.btnDMBs.Text = "&Database Issues (Including Taxrates)"
        Me.btnDMBs.UseVisualStyleBackColor = True
        '
        'btnCaesarVision
        '
        Me.btnCaesarVision.Location = New System.Drawing.Point(5, 193)
        Me.btnCaesarVision.Name = "btnCaesarVision"
        Me.btnCaesarVision.Size = New System.Drawing.Size(306, 23)
        Me.btnCaesarVision.TabIndex = 6
        Me.btnCaesarVision.Text = "&Version Updates"
        Me.btnCaesarVision.UseVisualStyleBackColor = True
        '
        'btnCards
        '
        Me.btnCards.Enabled = False
        Me.btnCards.Location = New System.Drawing.Point(5, 164)
        Me.btnCards.Name = "btnCards"
        Me.btnCards.Size = New System.Drawing.Size(306, 23)
        Me.btnCards.TabIndex = 5
        Me.btnCards.Text = "&Team Viewer Issues"
        Me.btnCards.UseVisualStyleBackColor = True
        '
        'btnCustomerEd
        '
        Me.btnCustomerEd.Location = New System.Drawing.Point(5, 135)
        Me.btnCustomerEd.Name = "btnCustomerEd"
        Me.btnCustomerEd.Size = New System.Drawing.Size(306, 23)
        Me.btnCustomerEd.TabIndex = 4
        Me.btnCustomerEd.Text = "Point of Sales/&Caesar Vision"
        Me.btnCustomerEd.UseVisualStyleBackColor = True
        '
        'lblSelectIssue
        '
        Me.lblSelectIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectIssue.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectIssue.Name = "lblSelectIssue"
        Me.lblSelectIssue.Size = New System.Drawing.Size(317, 44)
        Me.lblSelectIssue.TabIndex = 0
        Me.lblSelectIssue.Text = "Software"
        Me.lblSelectIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Software
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
        Me.Name = "Software"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Software"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnNewStore As Button
    Friend WithEvents btnOnline As Button
    Friend WithEvents btnPizzaPortal As Button
    Friend WithEvents btnDMBs As Button
    Friend WithEvents btnCaesarVision As Button
    Friend WithEvents btnCards As Button
    Friend WithEvents btnCustomerEd As Button
    Friend WithEvents lblSelectIssue As Label
End Class
