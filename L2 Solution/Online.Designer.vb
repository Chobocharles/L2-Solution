<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Online
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
        Me.btnEnableDisableOnlineOrdering = New System.Windows.Forms.Button()
        Me.btnEPayValidation = New System.Windows.Forms.Button()
        Me.btnPizzaPortalValidation = New System.Windows.Forms.Button()
        Me.btnMissingItems = New System.Windows.Forms.Button()
        Me.lblSelectIssue = New System.Windows.Forms.Label()
        Me.btnMissingButtons = New System.Windows.Forms.Button()
        Me.btnPizzaPortalLabels = New System.Windows.Forms.Button()
        Me.btnPizzaPortalOrdersNotClearing = New System.Windows.Forms.Button()
        Me.btnPriceDiscrepancies = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.grpButtons.Controls.Add(Me.Button1)
        Me.grpButtons.Controls.Add(Me.btnPriceDiscrepancies)
        Me.grpButtons.Controls.Add(Me.btnPizzaPortalOrdersNotClearing)
        Me.grpButtons.Controls.Add(Me.btnPizzaPortalLabels)
        Me.grpButtons.Controls.Add(Me.btnMissingButtons)
        Me.grpButtons.Controls.Add(Me.btnEnableDisableOnlineOrdering)
        Me.grpButtons.Controls.Add(Me.btnEPayValidation)
        Me.grpButtons.Controls.Add(Me.btnPizzaPortalValidation)
        Me.grpButtons.Controls.Add(Me.btnMissingItems)
        Me.grpButtons.Location = New System.Drawing.Point(12, 56)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(317, 332)
        Me.grpButtons.TabIndex = 1
        Me.grpButtons.TabStop = False
        '
        'btnEnableDisableOnlineOrdering
        '
        Me.btnEnableDisableOnlineOrdering.Location = New System.Drawing.Point(5, 48)
        Me.btnEnableDisableOnlineOrdering.Name = "btnEnableDisableOnlineOrdering"
        Me.btnEnableDisableOnlineOrdering.Size = New System.Drawing.Size(306, 23)
        Me.btnEnableDisableOnlineOrdering.TabIndex = 1
        Me.btnEnableDisableOnlineOrdering.Text = "Enabling/&Disabling Online Ordering"
        Me.btnEnableDisableOnlineOrdering.UseVisualStyleBackColor = True
        '
        'btnEPayValidation
        '
        Me.btnEPayValidation.Location = New System.Drawing.Point(5, 77)
        Me.btnEPayValidation.Name = "btnEPayValidation"
        Me.btnEPayValidation.Size = New System.Drawing.Size(306, 23)
        Me.btnEPayValidation.TabIndex = 2
        Me.btnEPayValidation.Text = "ePay &Validation Issues"
        Me.btnEPayValidation.UseVisualStyleBackColor = True
        '
        'btnPizzaPortalValidation
        '
        Me.btnPizzaPortalValidation.Location = New System.Drawing.Point(5, 135)
        Me.btnPizzaPortalValidation.Name = "btnPizzaPortalValidation"
        Me.btnPizzaPortalValidation.Size = New System.Drawing.Size(306, 23)
        Me.btnPizzaPortalValidation.TabIndex = 4
        Me.btnPizzaPortalValidation.Text = "&Pizza Portal Validations"
        Me.btnPizzaPortalValidation.UseVisualStyleBackColor = True
        '
        'btnMissingItems
        '
        Me.btnMissingItems.Location = New System.Drawing.Point(5, 106)
        Me.btnMissingItems.Name = "btnMissingItems"
        Me.btnMissingItems.Size = New System.Drawing.Size(306, 23)
        Me.btnMissingItems.TabIndex = 3
        Me.btnMissingItems.Text = "I&tem Adjustments on App/Site"
        Me.btnMissingItems.UseVisualStyleBackColor = True
        '
        'lblSelectIssue
        '
        Me.lblSelectIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectIssue.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectIssue.Name = "lblSelectIssue"
        Me.lblSelectIssue.Size = New System.Drawing.Size(317, 44)
        Me.lblSelectIssue.TabIndex = 0
        Me.lblSelectIssue.Text = "Online/Mobile Orders"
        Me.lblSelectIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMissingButtons
        '
        Me.btnMissingButtons.Location = New System.Drawing.Point(5, 19)
        Me.btnMissingButtons.Name = "btnMissingButtons"
        Me.btnMissingButtons.Size = New System.Drawing.Size(306, 23)
        Me.btnMissingButtons.TabIndex = 0
        Me.btnMissingButtons.Text = "&Buttons Missing"
        Me.btnMissingButtons.UseVisualStyleBackColor = True
        '
        'btnPizzaPortalLabels
        '
        Me.btnPizzaPortalLabels.Location = New System.Drawing.Point(5, 164)
        Me.btnPizzaPortalLabels.Name = "btnPizzaPortalLabels"
        Me.btnPizzaPortalLabels.Size = New System.Drawing.Size(306, 23)
        Me.btnPizzaPortalLabels.TabIndex = 5
        Me.btnPizzaPortalLabels.Text = "Pizza Portal &Labels Not Scanning"
        Me.btnPizzaPortalLabels.UseVisualStyleBackColor = True
        '
        'btnPizzaPortalOrdersNotClearing
        '
        Me.btnPizzaPortalOrdersNotClearing.Location = New System.Drawing.Point(5, 193)
        Me.btnPizzaPortalOrdersNotClearing.Name = "btnPizzaPortalOrdersNotClearing"
        Me.btnPizzaPortalOrdersNotClearing.Size = New System.Drawing.Size(306, 23)
        Me.btnPizzaPortalOrdersNotClearing.TabIndex = 6
        Me.btnPizzaPortalOrdersNotClearing.Text = "Pizza Portal O&rders Not Clearing"
        Me.btnPizzaPortalOrdersNotClearing.UseVisualStyleBackColor = True
        '
        'btnPriceDiscrepancies
        '
        Me.btnPriceDiscrepancies.Location = New System.Drawing.Point(5, 222)
        Me.btnPriceDiscrepancies.Name = "btnPriceDiscrepancies"
        Me.btnPriceDiscrepancies.Size = New System.Drawing.Size(306, 23)
        Me.btnPriceDiscrepancies.TabIndex = 7
        Me.btnPriceDiscrepancies.Text = "Pri&ce Discrepancies"
        Me.btnPriceDiscrepancies.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(306, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Time Issues"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Online
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
        Me.Name = "Online"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Online Ordering/Mobile"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnEnableDisableOnlineOrdering As Button
    Friend WithEvents btnEPayValidation As Button
    Friend WithEvents btnPizzaPortalValidation As Button
    Friend WithEvents btnMissingItems As Button
    Friend WithEvents lblSelectIssue As Label
    Friend WithEvents btnMissingButtons As Button
    Friend WithEvents btnPriceDiscrepancies As Button
    Friend WithEvents btnPizzaPortalOrdersNotClearing As Button
    Friend WithEvents btnPizzaPortalLabels As Button
    Friend WithEvents Button1 As Button
End Class
