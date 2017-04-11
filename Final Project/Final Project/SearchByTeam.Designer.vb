<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchByTeam
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
        Me.dgvTeamGame = New System.Windows.Forms.DataGridView()
        Me.cboTeam = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.dgvTeamGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTeamGame
        '
        Me.dgvTeamGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeamGame.Location = New System.Drawing.Point(110, 151)
        Me.dgvTeamGame.Name = "dgvTeamGame"
        Me.dgvTeamGame.RowTemplate.Height = 28
        Me.dgvTeamGame.Size = New System.Drawing.Size(689, 252)
        Me.dgvTeamGame.TabIndex = 11
        '
        'cboTeam
        '
        Me.cboTeam.FormattingEnabled = True
        Me.cboTeam.Location = New System.Drawing.Point(255, 78)
        Me.cboTeam.Name = "cboTeam"
        Me.cboTeam.Size = New System.Drawing.Size(195, 28)
        Me.cboTeam.TabIndex = 10
        Me.cboTeam.Text = "Please Select"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(86, 81)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(149, 20)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Select Team Here : "
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(641, 480)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(174, 42)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Back To HomePage"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(255, 479)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 43)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(91, 479)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(112, 43)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'SearchByTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 588)
        Me.Controls.Add(Me.dgvTeamGame)
        Me.Controls.Add(Me.cboTeam)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "SearchByTeam"
        Me.Text = "Search Game By Team"
        CType(Me.dgvTeamGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dgvTeamGame As DataGridView
    Private WithEvents cboTeam As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents btnClose As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnSearch As Button
End Class
