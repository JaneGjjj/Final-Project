<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchByDate
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
        Me.dtpGameDay = New System.Windows.Forms.DateTimePicker()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgvGamesInDay = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvGamesInDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpGameDay
        '
        Me.dtpGameDay.Location = New System.Drawing.Point(200, 65)
        Me.dtpGameDay.Name = "dtpGameDay"
        Me.dtpGameDay.Size = New System.Drawing.Size(305, 26)
        Me.dtpGameDay.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(196, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(309, 20)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Select A day You Want to Watch Games : "
        '
        'dgvGamesInDay
        '
        Me.dgvGamesInDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGamesInDay.Location = New System.Drawing.Point(52, 131)
        Me.dgvGamesInDay.Name = "dgvGamesInDay"
        Me.dgvGamesInDay.RowTemplate.Height = 28
        Me.dgvGamesInDay.Size = New System.Drawing.Size(608, 264)
        Me.dgvGamesInDay.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(41, 431)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(144, 29)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(200, 431)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 29)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(499, 431)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(172, 29)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back To HomePage"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'SearchByDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 535)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvGamesInDay)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dtpGameDay)
        Me.Name = "SearchByDate"
        Me.Text = "Search By Date"
        CType(Me.dgvGamesInDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dtpGameDay As DateTimePicker
    Private WithEvents label1 As Label
    Private WithEvents dgvGamesInDay As DataGridView
    Private WithEvents btnSearch As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnBack As Button
End Class
