<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoteForChampion
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
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(413, 143)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(207, 24)
        Me.chk2.TabIndex = 13
        Me.chk2.Text = "Team 2 will be champion"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(69, 143)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(207, 24)
        Me.chk1.TabIndex = 12
        Me.chk1.Text = "Team 1 will be champion"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(479, 87)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(62, 20)
        Me.lbl2.TabIndex = 11
        Me.lbl2.Text = "Team 2"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(119, 87)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(62, 20)
        Me.lbl1.TabIndex = 10
        Me.lbl1.Text = "Team 1"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(55, 389)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(143, 29)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Change my mind"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(469, 377)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(171, 40)
        Me.button1.TabIndex = 8
        Me.button1.Text = "Back To HomePage"
        Me.button1.UseVisualStyleBackColor = True
        '
        'btnVote
        '
        Me.btnVote.Location = New System.Drawing.Point(55, 354)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(125, 29)
        Me.btnVote.TabIndex = 7
        Me.btnVote.Text = "VOTE!!!"
        Me.btnVote.UseVisualStyleBackColor = True
        '
        'VoteForChampion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 468)
        Me.Controls.Add(Me.chk2)
        Me.Controls.Add(Me.chk1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.btnVote)
        Me.Name = "VoteForChampion"
        Me.Text = "Vote For Champion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents chk2 As CheckBox
    Private WithEvents chk1 As CheckBox
    Private WithEvents lbl2 As Label
    Private WithEvents lbl1 As Label
    Private WithEvents btnClear As Button
    Private WithEvents button1 As Button
    Private WithEvents btnVote As Button
End Class
