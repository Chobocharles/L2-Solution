<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SWUpdates
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
        Me.btnWorked = New System.Windows.Forms.Button()
        Me.txtExplanationSolution = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnWorked
        '
        Me.btnWorked.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnWorked.Location = New System.Drawing.Point(95, 194)
        Me.btnWorked.Name = "btnWorked"
        Me.btnWorked.Size = New System.Drawing.Size(111, 51)
        Me.btnWorked.TabIndex = 1
        Me.btnWorked.Text = "O&k"
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
        Me.txtExplanationSolution.Text = "Description:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & " Updated version #'s will be found here:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "-------------------------" &
    "--------------------------------------------------------------      "
        '
        'SWUpdates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 257)
        Me.Controls.Add(Me.btnWorked)
        Me.Controls.Add(Me.txtExplanationSolution)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SWUpdates"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Updates"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnWorked As Button
    Friend WithEvents txtExplanationSolution As RichTextBox
End Class
