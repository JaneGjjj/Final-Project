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
        Me.components = New System.ComponentModel.Container()
        Me.dtpGameDay = New System.Windows.Forms.DateTimePicker()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgvGamesInDay = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.GameInformationDataSet = New Final_Project.GameInformationDataSet()
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
        CType(Me.dgvGamesInDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameInformationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpGameDay
        '
        Me.dtpGameDay.Location = New System.Drawing.Point(367, 71)
        Me.dtpGameDay.Name = "dtpGameDay"
        Me.dtpGameDay.Size = New System.Drawing.Size(305, 26)
        Me.dtpGameDay.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(363, 36)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(309, 20)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Select A day You Want to Watch Games : "
        '
        'dgvGamesInDay
        '
        Me.dgvGamesInDay.AllowUserToAddRows = False
        Me.dgvGamesInDay.AllowUserToDeleteRows = False
        Me.dgvGamesInDay.AutoGenerateColumns = False
        Me.dgvGamesInDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGamesInDay.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.Team1DataGridViewTextBoxColumn, Me.Team1BestPlaceInWorldCupDataGridViewTextBoxColumn, Me.Team2DataGridViewTextBoxColumn, Me.Team2BestPlceInWorldCupDataGridViewTextBoxColumn, Me.HistoryResultBetween2TeamsDataGridViewTextBoxColumn, Me.TodayWinnerDataGridViewTextBoxColumn, Me.TodayResultDataGridViewTextBoxColumn})
        Me.dgvGamesInDay.DataSource = Me.GameBindingSource
        Me.dgvGamesInDay.Location = New System.Drawing.Point(34, 131)
        Me.dgvGamesInDay.Name = "dgvGamesInDay"
        Me.dgvGamesInDay.ReadOnly = True
        Me.dgvGamesInDay.RowTemplate.Height = 28
        Me.dgvGamesInDay.Size = New System.Drawing.Size(1013, 264)
        Me.dgvGamesInDay.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(34, 467)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(144, 29)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(184, 467)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 29)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(875, 467)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(172, 29)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back To HomePage"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(62, 419)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(597, 33)
        Me.lblStatus.TabIndex = 7
        '
        'GameInformationDataSet
        '
        Me.GameInformationDataSet.DataSetName = "GameInformationDataSet"
        Me.GameInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Team1DataGridViewTextBoxColumn
        '
        Me.Team1DataGridViewTextBoxColumn.DataPropertyName = "Team 1"
        Me.Team1DataGridViewTextBoxColumn.HeaderText = "Team 1"
        Me.Team1DataGridViewTextBoxColumn.Name = "Team1DataGridViewTextBoxColumn"
        Me.Team1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Team1BestPlaceInWorldCupDataGridViewTextBoxColumn
        '
        Me.Team1BestPlaceInWorldCupDataGridViewTextBoxColumn.DataPropertyName = "Team 1 Best Place in World Cup"
        Me.Team1BestPlaceInWorldCupDataGridViewTextBoxColumn.HeaderText = "Team 1 Best Place in World Cup"
        Me.Team1BestPlaceInWorldCupDataGridViewTextBoxColumn.Name = "Team1BestPlaceInWorldCupDataGridViewTextBoxColumn"
        Me.Team1BestPlaceInWorldCupDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Team2DataGridViewTextBoxColumn
        '
        Me.Team2DataGridViewTextBoxColumn.DataPropertyName = "Team 2"
        Me.Team2DataGridViewTextBoxColumn.HeaderText = "Team 2"
        Me.Team2DataGridViewTextBoxColumn.Name = "Team2DataGridViewTextBoxColumn"
        Me.Team2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Team2BestPlceInWorldCupDataGridViewTextBoxColumn
        '
        Me.Team2BestPlceInWorldCupDataGridViewTextBoxColumn.DataPropertyName = "Team 2 Best Plce in World Cup"
        Me.Team2BestPlceInWorldCupDataGridViewTextBoxColumn.HeaderText = "Team 2 Best Plce in World Cup"
        Me.Team2BestPlceInWorldCupDataGridViewTextBoxColumn.Name = "Team2BestPlceInWorldCupDataGridViewTextBoxColumn"
        Me.Team2BestPlceInWorldCupDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HistoryResultBetween2TeamsDataGridViewTextBoxColumn
        '
        Me.HistoryResultBetween2TeamsDataGridViewTextBoxColumn.DataPropertyName = "History Result between 2 teams"
        Me.HistoryResultBetween2TeamsDataGridViewTextBoxColumn.HeaderText = "History Result between 2 teams"
        Me.HistoryResultBetween2TeamsDataGridViewTextBoxColumn.Name = "HistoryResultBetween2TeamsDataGridViewTextBoxColumn"
        Me.HistoryResultBetween2TeamsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TodayWinnerDataGridViewTextBoxColumn
        '
        Me.TodayWinnerDataGridViewTextBoxColumn.DataPropertyName = "Today winner"
        Me.TodayWinnerDataGridViewTextBoxColumn.HeaderText = "Today winner"
        Me.TodayWinnerDataGridViewTextBoxColumn.Name = "TodayWinnerDataGridViewTextBoxColumn"
        Me.TodayWinnerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TodayResultDataGridViewTextBoxColumn
        '
        Me.TodayResultDataGridViewTextBoxColumn.DataPropertyName = "Today Result"
        Me.TodayResultDataGridViewTextBoxColumn.HeaderText = "Today Result"
        Me.TodayResultDataGridViewTextBoxColumn.Name = "TodayResultDataGridViewTextBoxColumn"
        Me.TodayResultDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SearchByDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 535)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvGamesInDay)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dtpGameDay)
        Me.Name = "SearchByDate"
        Me.Text = "Search By Date"
        CType(Me.dgvGamesInDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameInformationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dtpGameDay As DateTimePicker
    Private WithEvents label1 As Label
    Private WithEvents dgvGamesInDay As DataGridView
    Private WithEvents btnSearch As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnBack As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents GameInformationDataSet As GameInformationDataSet
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
