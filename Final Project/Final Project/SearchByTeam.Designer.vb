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
        Me.components = New System.ComponentModel.Container()
        Me.dgvTeamGame = New System.Windows.Forms.DataGridView()
        Me.cboTeam = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GameInformationDataSet = New Final_Project.GameInformationDataSet()
        Me.TeamsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamsTableAdapter = New Final_Project.GameInformationDataSetTableAdapters.TeamsTableAdapter()
        Me.GameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GameTableAdapter = New Final_Project.GameInformationDataSetTableAdapters.GameTableAdapter()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Team1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Team1BestPlaceInWorldCupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Team2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Team2BestPlceInWorldCupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistoryResultBetween2TeamsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TodayWinnerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TodayResultDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvTeamGame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameInformationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTeamGame
        '
        Me.dgvTeamGame.AutoGenerateColumns = False
        Me.dgvTeamGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeamGame.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.Team1DataGridViewTextBoxColumn, Me.Team1BestPlaceInWorldCupDataGridViewTextBoxColumn, Me.Team2DataGridViewTextBoxColumn, Me.Team2BestPlceInWorldCupDataGridViewTextBoxColumn, Me.HistoryResultBetween2TeamsDataGridViewTextBoxColumn, Me.TodayWinnerDataGridViewTextBoxColumn, Me.TodayResultDataGridViewTextBoxColumn})
        Me.dgvTeamGame.DataSource = Me.GameBindingSource
        Me.dgvTeamGame.Location = New System.Drawing.Point(31, 151)
        Me.dgvTeamGame.Name = "dgvTeamGame"
        Me.dgvTeamGame.RowTemplate.Height = 28
        Me.dgvTeamGame.Size = New System.Drawing.Size(1029, 252)
        Me.dgvTeamGame.TabIndex = 11
        '
        'cboTeam
        '
        Me.cboTeam.DataSource = Me.TeamsBindingSource
        Me.cboTeam.DisplayMember = "TeamName"
        Me.cboTeam.FormattingEnabled = True
        Me.cboTeam.Location = New System.Drawing.Point(255, 78)
        Me.cboTeam.Name = "cboTeam"
        Me.cboTeam.Size = New System.Drawing.Size(195, 28)
        Me.cboTeam.TabIndex = 10
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
        Me.btnClose.Location = New System.Drawing.Point(886, 490)
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
        'GameInformationDataSet
        '
        Me.GameInformationDataSet.DataSetName = "GameInformationDataSet"
        Me.GameInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeamsBindingSource
        '
        Me.TeamsBindingSource.DataMember = "Teams"
        Me.TeamsBindingSource.DataSource = Me.GameInformationDataSet
        '
        'TeamsTableAdapter
        '
        Me.TeamsTableAdapter.ClearBeforeFill = True
        '
        'GameBindingSource
        '
        Me.GameBindingSource.DataMember = "Game"
        Me.GameBindingSource.DataSource = Me.GameInformationDataSet
        '
        'GameTableAdapter
        '
        Me.GameTableAdapter.ClearBeforeFill = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        '
        'Team1DataGridViewTextBoxColumn
        '
        Me.Team1DataGridViewTextBoxColumn.DataPropertyName = "Team 1"
        Me.Team1DataGridViewTextBoxColumn.HeaderText = "Team 1"
        Me.Team1DataGridViewTextBoxColumn.Name = "Team1DataGridViewTextBoxColumn"
        '
        'Team1BestPlaceInWorldCupDataGridViewTextBoxColumn
        '
        Me.Team1BestPlaceInWorldCupDataGridViewTextBoxColumn.DataPropertyName = "Team 1 Best Place in World Cup"
        Me.Team1BestPlaceInWorldCupDataGridViewTextBoxColumn.HeaderText = "Team 1 Best Place in World Cup"
        Me.Team1BestPlaceInWorldCupDataGridViewTextBoxColumn.Name = "Team1BestPlaceInWorldCupDataGridViewTextBoxColumn"
        '
        'Team2DataGridViewTextBoxColumn
        '
        Me.Team2DataGridViewTextBoxColumn.DataPropertyName = "Team 2"
        Me.Team2DataGridViewTextBoxColumn.HeaderText = "Team 2"
        Me.Team2DataGridViewTextBoxColumn.Name = "Team2DataGridViewTextBoxColumn"
        '
        'Team2BestPlceInWorldCupDataGridViewTextBoxColumn
        '
        Me.Team2BestPlceInWorldCupDataGridViewTextBoxColumn.DataPropertyName = "Team 2 Best Plce in World Cup"
        Me.Team2BestPlceInWorldCupDataGridViewTextBoxColumn.HeaderText = "Team 2 Best Plce in World Cup"
        Me.Team2BestPlceInWorldCupDataGridViewTextBoxColumn.Name = "Team2BestPlceInWorldCupDataGridViewTextBoxColumn"
        '
        'HistoryResultBetween2TeamsDataGridViewTextBoxColumn
        '
        Me.HistoryResultBetween2TeamsDataGridViewTextBoxColumn.DataPropertyName = "History Result between 2 teams"
        Me.HistoryResultBetween2TeamsDataGridViewTextBoxColumn.HeaderText = "History Result between 2 teams"
        Me.HistoryResultBetween2TeamsDataGridViewTextBoxColumn.Name = "HistoryResultBetween2TeamsDataGridViewTextBoxColumn"
        '
        'TodayWinnerDataGridViewTextBoxColumn
        '
        Me.TodayWinnerDataGridViewTextBoxColumn.DataPropertyName = "Today winner"
        Me.TodayWinnerDataGridViewTextBoxColumn.HeaderText = "Today winner"
        Me.TodayWinnerDataGridViewTextBoxColumn.Name = "TodayWinnerDataGridViewTextBoxColumn"
        '
        'TodayResultDataGridViewTextBoxColumn
        '
        Me.TodayResultDataGridViewTextBoxColumn.DataPropertyName = "Today Result"
        Me.TodayResultDataGridViewTextBoxColumn.HeaderText = "Today Result"
        Me.TodayResultDataGridViewTextBoxColumn.Name = "TodayResultDataGridViewTextBoxColumn"
        '
        'SearchByTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 588)
        Me.Controls.Add(Me.dgvTeamGame)
        Me.Controls.Add(Me.cboTeam)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "SearchByTeam"
        Me.Text = "Search Game By Team"
        CType(Me.dgvTeamGame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameInformationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dgvTeamGame As DataGridView
    Private WithEvents cboTeam As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents btnClose As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnSearch As Button
    Friend WithEvents GameInformationDataSet As GameInformationDataSet
    Friend WithEvents TeamsBindingSource As BindingSource
    Friend WithEvents TeamsTableAdapter As GameInformationDataSetTableAdapters.TeamsTableAdapter
    Friend WithEvents GameBindingSource As BindingSource
    Friend WithEvents GameTableAdapter As GameInformationDataSetTableAdapters.GameTableAdapter
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Team1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Team1BestPlaceInWorldCupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Team2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Team2BestPlceInWorldCupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HistoryResultBetween2TeamsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TodayWinnerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TodayResultDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
