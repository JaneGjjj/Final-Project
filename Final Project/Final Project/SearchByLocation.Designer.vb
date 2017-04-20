<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchByLocation
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
        Me.components = New System.ComponentModel.Container()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvGamesPlace = New System.Windows.Forms.DataGridView()
        Me.cboPlace = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GameInformationDataSet = New Final_Project.GameInformationDataSet()
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationTableAdapter = New Final_Project.GameInformationDataSetTableAdapters.LocationTableAdapter()
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
        Me.NewGameInformationDataSet = New Final_Project.NewGameInformationDataSet()
        Me.GameTableAdapter1 = New Final_Project.NewGameInformationDataSetTableAdapters.GameTableAdapter()
        Me.TableAdapterManager = New Final_Project.NewGameInformationDataSetTableAdapters.TableAdapterManager()
        CType(Me.dgvGamesPlace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameInformationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewGameInformationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(892, 374)
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
        Me.dgvGamesPlace.AllowUserToAddRows = False
        Me.dgvGamesPlace.AllowUserToDeleteRows = False
        Me.dgvGamesPlace.AutoGenerateColumns = False
        Me.dgvGamesPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGamesPlace.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.Team1DataGridViewTextBoxColumn, Me.Team1BestPlaceInWorldCupDataGridViewTextBoxColumn, Me.Team2DataGridViewTextBoxColumn, Me.Team2BestPlceInWorldCupDataGridViewTextBoxColumn, Me.HistoryResultBetween2TeamsDataGridViewTextBoxColumn, Me.TodayWinnerDataGridViewTextBoxColumn, Me.TodayResultDataGridViewTextBoxColumn})
        Me.dgvGamesPlace.DataSource = Me.GameBindingSource
        Me.dgvGamesPlace.Location = New System.Drawing.Point(77, 94)
        Me.dgvGamesPlace.Name = "dgvGamesPlace"
        Me.dgvGamesPlace.ReadOnly = True
        Me.dgvGamesPlace.RowTemplate.Height = 28
        Me.dgvGamesPlace.Size = New System.Drawing.Size(971, 244)
        Me.dgvGamesPlace.TabIndex = 8
        '
        'cboPlace
        '
        Me.cboPlace.DataSource = Me.LocationBindingSource
        Me.cboPlace.DisplayMember = "Location"
        Me.cboPlace.FormattingEnabled = True
        Me.cboPlace.Location = New System.Drawing.Point(297, 30)
        Me.cboPlace.Name = "cboPlace"
        Me.cboPlace.Size = New System.Drawing.Size(246, 28)
        Me.cboPlace.TabIndex = 7
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
        'GameInformationDataSet
        '
        Me.GameInformationDataSet.DataSetName = "GameInformationDataSet"
        Me.GameInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocationBindingSource
        '
        Me.LocationBindingSource.DataMember = "Location"
        Me.LocationBindingSource.DataSource = Me.GameInformationDataSet
        '
        'LocationTableAdapter
        '
        Me.LocationTableAdapter.ClearBeforeFill = True
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
        'NewGameInformationDataSet
        '
        Me.NewGameInformationDataSet.DataSetName = "NewGameInformationDataSet"
        Me.NewGameInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GameTableAdapter1
        '
        Me.GameTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GameTableAdapter = Me.GameTableAdapter1
        Me.TableAdapterManager.UpdateOrder = Final_Project.NewGameInformationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SearchByLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 440)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvGamesPlace)
        Me.Controls.Add(Me.cboPlace)
        Me.Controls.Add(Me.label1)
        Me.Name = "SearchByLocation"
        Me.Text = "Search Game By Location"
        CType(Me.dgvGamesPlace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameInformationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewGameInformationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnBack As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnSearch As Button
    Private WithEvents dgvGamesPlace As DataGridView
    Private WithEvents cboPlace As ComboBox
    Private WithEvents label1 As Label
    Friend WithEvents GameInformationDataSet As GameInformationDataSet
    Friend WithEvents LocationBindingSource As BindingSource
    Friend WithEvents LocationTableAdapter As GameInformationDataSetTableAdapters.LocationTableAdapter
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
    Friend WithEvents NewGameInformationDataSet As NewGameInformationDataSet
    Friend WithEvents GameTableAdapter1 As NewGameInformationDataSetTableAdapters.GameTableAdapter
    Friend WithEvents TableAdapterManager As NewGameInformationDataSetTableAdapters.TableAdapterManager
End Class
