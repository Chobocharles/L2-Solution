<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OCBItemConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OCBItemConfig))
        Me.btnSimilarIncidents = New System.Windows.Forms.Button()
        Me.btnDidntWork = New System.Windows.Forms.Button()
        Me.btnWorked = New System.Windows.Forms.Button()
        Me.txtExplanationSolution = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnSimilarIncidents
        '
        Me.btnSimilarIncidents.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSimilarIncidents.Location = New System.Drawing.Point(102, 223)
        Me.btnSimilarIncidents.Name = "btnSimilarIncidents"
        Me.btnSimilarIncidents.Size = New System.Drawing.Size(111, 23)
        Me.btnSimilarIncidents.TabIndex = 3
        Me.btnSimilarIncidents.Text = "&Similar Incidents"
        Me.btnSimilarIncidents.UseVisualStyleBackColor = True
        '
        'btnDidntWork
        '
        Me.btnDidntWork.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDidntWork.Location = New System.Drawing.Point(176, 194)
        Me.btnDidntWork.Name = "btnDidntWork"
        Me.btnDidntWork.Size = New System.Drawing.Size(111, 23)
        Me.btnDidntWork.TabIndex = 2
        Me.btnDidntWork.Text = "This &Didn't Work"
        Me.btnDidntWork.UseVisualStyleBackColor = True
        '
        'btnWorked
        '
        Me.btnWorked.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnWorked.Location = New System.Drawing.Point(22, 194)
        Me.btnWorked.Name = "btnWorked"
        Me.btnWorked.Size = New System.Drawing.Size(111, 23)
        Me.btnWorked.TabIndex = 1
        Me.btnWorked.Text = "This &Worked"
        Me.btnWorked.UseVisualStyleBackColor = True
        '
        'txtExplanationSolution
        '
        Me.txtExplanationSolution.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtExplanationSolution.Location = New System.Drawing.Point(12, 10)
        Me.txtExplanationSolution.Name = "txtExplanationSolution"
        Me.txtExplanationSolution.ReadOnly = True
        Me.txtExplanationSolution.Size = New System.Drawing.Size(285, 178)
        Me.txtExplanationSolution.TabIndex = 0
        Me.txtExplanationSolution.Text = resources.GetString("txtExplanationSolution.Text")
        '
        'OCBItemConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 257)
        Me.Controls.Add(Me.btnSimilarIncidents)
        Me.Controls.Add(Me.btnDidntWork)
        Me.Controls.Add(Me.btnWorked)
        Me.Controls.Add(Me.txtExplanationSolution)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OCBItemConfig"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OCB Items"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSimilarIncidents As Button
    Friend WithEvents btnDidntWork As Button
    Friend WithEvents btnWorked As Button
    Friend WithEvents txtExplanationSolution As RichTextBox
End Class
