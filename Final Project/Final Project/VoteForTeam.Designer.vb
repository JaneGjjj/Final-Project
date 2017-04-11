<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VoteForTeam
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
        Me.btnSupportRate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSupportRate
        '
        Me.btnSupportRate.Location = New System.Drawing.Point(520, 445)
        Me.btnSupportRate.Name = "btnSupportRate"
        Me.btnSupportRate.Size = New System.Drawing.Size(198, 26)
        Me.btnSupportRate.TabIndex = 9
        Me.btnSupportRate.Text = "Show me Support Rate"
        Me.btnSupportRate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(520, 491)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(198, 28)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back To HomePage"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(92, 492)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 27)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnVote
        '
        Me.btnVote.Location = New System.Drawing.Point(92, 443)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(112, 28)
        Me.btnVote.TabIndex = 6
        Me.btnVote.Text = "Vote"
        Me.btnVote.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(282, 22)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(169, 29)
        Me.btnAll.TabIndex = 5
        Me.btnAll.Text = "Show me ALL teams"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'VoteForTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 578)
        Me.Controls.Add(Me.btnSupportRate)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.btnAll)
        Me.Name = "VoteForTeam"
        Me.Text = "Vote For Your Team"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnSupportRate As Button
    Private WithEvents btnBack As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnVote As Button
    Private WithEvents btnAll As Button
End Class
