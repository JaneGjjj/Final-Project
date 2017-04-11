<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchByLocation
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvGamesPlace = New System.Windows.Forms.DataGridView()
        Me.cboPlace = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.dgvGamesPlace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(448, 374)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(170, 46)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back To HomePage"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(221, 374)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 46)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(76, 374)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(125, 46)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgvGamesPlace
        '
        Me.dgvGamesPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGamesPlace.Location = New System.Drawing.Point(77, 94)
        Me.dgvGamesPlace.Name = "dgvGamesPlace"
        Me.dgvGamesPlace.RowTemplate.Height = 28
        Me.dgvGamesPlace.Size = New System.Drawing.Size(542, 244)
        Me.dgvGamesPlace.TabIndex = 8
        '
        'cboPlace
        '
        Me.cboPlace.FormattingEnabled = True
        Me.cboPlace.Location = New System.Drawing.Point(297, 30)
        Me.cboPlace.Name = "cboPlace"
        Me.cboPlace.Size = New System.Drawing.Size(246, 28)
        Me.cboPlace.TabIndex = 7
        Me.cboPlace.Text = "Please choose here"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(64, 36)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(213, 20)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Choose One Sports Center : "
        '
        'SearchByLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 432)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvGamesPlace)
        Me.Controls.Add(Me.cboPlace)
        Me.Controls.Add(Me.label1)
        Me.Name = "SearchByLocation"
        Me.Text = "Search Game By Location"
        CType(Me.dgvGamesPlace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnBack As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnSearch As Button
    Private WithEvents dgvGamesPlace As DataGridView
    Private WithEvents cboPlace As ComboBox
    Private WithEvents label1 As Label
End Class
