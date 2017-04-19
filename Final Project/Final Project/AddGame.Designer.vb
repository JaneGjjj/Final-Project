<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddGame
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPlace = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboTeam1 = New System.Windows.Forms.ComboBox()
        Me.cboTeam2 = New System.Windows.Forms.ComboBox()
        Me.dtpAddDate = New System.Windows.Forms.DateTimePicker()
        Me.txtHistory = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBest1 = New System.Windows.Forms.TextBox()
        Me.txtBest2 = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.GameInformationDataSet = New Final_Project.GameInformationDataSet()
        Me.GameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GameTableAdapter = New Final_Project.GameInformationDataSetTableAdapters.GameTableAdapter()
        CType(Me.GameInformationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Team 1 :  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(502, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Team 2 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Location : "
        '
        'cboPlace
        '
        Me.cboPlace.FormattingEnabled = True
        Me.cboPlace.Location = New System.Drawing.Point(161, 82)
        Me.cboPlace.Name = "cboPlace"
        Me.cboPlace.Size = New System.Drawing.Size(173, 28)
        Me.cboPlace.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(319, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "History result(s) of match between 2 teams :"
        '
        'cboTeam1
        '
        Me.cboTeam1.DataSource = Me.GameBindingSource
        Me.cboTeam1.DisplayMember = "Team 1"
        Me.cboTeam1.FormattingEnabled = True
        Me.cboTeam1.Location = New System.Drawing.Point(162, 152)
        Me.cboTeam1.Name = "cboTeam1"
        Me.cboTeam1.Size = New System.Drawing.Size(172, 28)
        Me.cboTeam1.TabIndex = 6
        Me.cboTeam1.ValueMember = "Date"
        '
        'cboTeam2
        '
        Me.cboTeam2.FormattingEnabled = True
        Me.cboTeam2.Location = New System.Drawing.Point(578, 152)
        Me.cboTeam2.Name = "cboTeam2"
        Me.cboTeam2.Size = New System.Drawing.Size(177, 28)
        Me.cboTeam2.TabIndex = 7
        '
        'dtpAddDate
        '
        Me.dtpAddDate.Location = New System.Drawing.Point(160, 24)
        Me.dtpAddDate.Name = "dtpAddDate"
        Me.dtpAddDate.Size = New System.Drawing.Size(314, 26)
        Me.dtpAddDate.TabIndex = 8
        '
        'txtHistory
        '
        Me.txtHistory.Location = New System.Drawing.Point(70, 354)
        Me.txtHistory.Multiline = True
        Me.txtHistory.Name = "txtHistory"
        Me.txtHistory.Size = New System.Drawing.Size(310, 141)
        Me.txtHistory.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(262, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Best Place in World Cup of Team 1: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(517, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Best Place in World Cup of Team 2: "
        '
        'txtBest1
        '
        Me.txtBest1.Location = New System.Drawing.Point(84, 256)
        Me.txtBest1.Name = "txtBest1"
        Me.txtBest1.Size = New System.Drawing.Size(203, 26)
        Me.txtBest1.TabIndex = 12
        '
        'txtBest2
        '
        Me.txtBest2.Location = New System.Drawing.Point(547, 256)
        Me.txtBest2.Name = "txtBest2"
        Me.txtBest2.Size = New System.Drawing.Size(208, 26)
        Me.txtBest2.TabIndex = 13
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(162, 585)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 33)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(290, 583)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 35)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(578, 583)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(130, 35)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(469, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(439, 40)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Result : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (check the winner of the game, if the result is tie check both) "
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(539, 365)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(88, 24)
        Me.chk1.TabIndex = 18
        Me.chk1.Text = "Team 1"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(667, 365)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(88, 24)
        Me.chk2.TabIndex = 19
        Me.chk2.Text = "Team 2"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(562, 422)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(65, 26)
        Me.txt1.TabIndex = 20
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(652, 422)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(67, 26)
        Me.txt2.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(633, 425)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(574, 451)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "(Type score above)"
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(77, 528)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(777, 28)
        Me.lblStatus.TabIndex = 24
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
        'AddGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 645)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.chk2)
        Me.Controls.Add(Me.chk1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtBest2)
        Me.Controls.Add(Me.txtBest1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHistory)
        Me.Controls.Add(Me.dtpAddDate)
        Me.Controls.Add(Me.cboTeam2)
        Me.Controls.Add(Me.cboTeam1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboPlace)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddGame"
        Me.Text = "Add New Game"
        CType(Me.GameInformationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboPlace As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboTeam1 As ComboBox
    Friend WithEvents cboTeam2 As ComboBox
    Friend WithEvents dtpAddDate As DateTimePicker
    Friend WithEvents txtHistory As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBest1 As TextBox
    Friend WithEvents txtBest2 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents GameInformationDataSet As GameInformationDataSet
    Friend WithEvents GameBindingSource As BindingSource
    Friend WithEvents GameTableAdapter As GameInformationDataSetTableAdapters.GameTableAdapter
End Class
