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
        Me.components = New System.ComponentModel.Container()
        Me.btnSupportRate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.radGer = New System.Windows.Forms.RadioButton()
        Me.radFrance = New System.Windows.Forms.RadioButton()
        Me.radEng = New System.Windows.Forms.RadioButton()
        Me.radIta = New System.Windows.Forms.RadioButton()
        Me.radSwi = New System.Windows.Forms.RadioButton()
        Me.grpTeams = New System.Windows.Forms.GroupBox()
        Me.radAr = New System.Windows.Forms.RadioButton()
        Me.radSp = New System.Windows.Forms.RadioButton()
        Me.radCamer = New System.Windows.Forms.RadioButton()
        Me.radBra = New System.Windows.Forms.RadioButton()
        Me.radNether = New System.Windows.Forms.RadioButton()
        Me.radNig = New System.Windows.Forms.RadioButton()
        Me.radRe = New System.Windows.Forms.RadioButton()
        Me.radPo = New System.Windows.Forms.RadioButton()
        Me.radRu = New System.Windows.Forms.RadioButton()
        Me.radAu = New System.Windows.Forms.RadioButton()
        Me.radK = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpTeams.SuspendLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSupportRate
        '
        Me.btnSupportRate.Location = New System.Drawing.Point(888, 496)
        Me.btnSupportRate.Name = "btnSupportRate"
        Me.btnSupportRate.Size = New System.Drawing.Size(198, 38)
        Me.btnSupportRate.TabIndex = 9
        Me.btnSupportRate.Text = "Show me Support Rate"
        Me.btnSupportRate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(888, 585)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(198, 43)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back To HomePage"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(927, 188)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 42)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnVote
        '
        Me.btnVote.Location = New System.Drawing.Point(927, 114)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(112, 38)
        Me.btnVote.TabIndex = 6
        Me.btnVote.Text = "Vote"
        Me.btnVote.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(282, 22)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(169, 39)
        Me.btnAll.TabIndex = 5
        Me.btnAll.Text = "Show me ALL teams"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'radGer
        '
        Me.radGer.AutoSize = True
        Me.radGer.Location = New System.Drawing.Point(27, 32)
        Me.radGer.Name = "radGer"
        Me.radGer.Size = New System.Drawing.Size(99, 24)
        Me.radGer.TabIndex = 10
        Me.radGer.TabStop = True
        Me.radGer.Text = "Germany"
        Me.radGer.UseVisualStyleBackColor = True
        '
        'radFrance
        '
        Me.radFrance.AutoSize = True
        Me.radFrance.Location = New System.Drawing.Point(27, 176)
        Me.radFrance.Name = "radFrance"
        Me.radFrance.Size = New System.Drawing.Size(84, 24)
        Me.radFrance.TabIndex = 11
        Me.radFrance.TabStop = True
        Me.radFrance.Text = "France"
        Me.radFrance.UseVisualStyleBackColor = True
        '
        'radEng
        '
        Me.radEng.AutoSize = True
        Me.radEng.Location = New System.Drawing.Point(27, 106)
        Me.radEng.Name = "radEng"
        Me.radEng.Size = New System.Drawing.Size(93, 24)
        Me.radEng.TabIndex = 12
        Me.radEng.TabStop = True
        Me.radEng.Text = "England"
        Me.radEng.UseVisualStyleBackColor = True
        '
        'radIta
        '
        Me.radIta.AutoSize = True
        Me.radIta.Location = New System.Drawing.Point(27, 255)
        Me.radIta.Name = "radIta"
        Me.radIta.Size = New System.Drawing.Size(63, 24)
        Me.radIta.TabIndex = 13
        Me.radIta.TabStop = True
        Me.radIta.Text = "Italy"
        Me.radIta.UseVisualStyleBackColor = True
        '
        'radSwi
        '
        Me.radSwi.AutoSize = True
        Me.radSwi.Location = New System.Drawing.Point(27, 326)
        Me.radSwi.Name = "radSwi"
        Me.radSwi.Size = New System.Drawing.Size(116, 24)
        Me.radSwi.TabIndex = 14
        Me.radSwi.TabStop = True
        Me.radSwi.Text = "Switzerland"
        Me.radSwi.UseVisualStyleBackColor = True
        '
        'grpTeams
        '
        Me.grpTeams.Controls.Add(Me.radAr)
        Me.grpTeams.Controls.Add(Me.radSp)
        Me.grpTeams.Controls.Add(Me.radCamer)
        Me.grpTeams.Controls.Add(Me.radBra)
        Me.grpTeams.Controls.Add(Me.radNether)
        Me.grpTeams.Controls.Add(Me.radNig)
        Me.grpTeams.Controls.Add(Me.radRe)
        Me.grpTeams.Controls.Add(Me.radPo)
        Me.grpTeams.Controls.Add(Me.radRu)
        Me.grpTeams.Controls.Add(Me.radAu)
        Me.grpTeams.Controls.Add(Me.radK)
        Me.grpTeams.Controls.Add(Me.radSwi)
        Me.grpTeams.Controls.Add(Me.radIta)
        Me.grpTeams.Controls.Add(Me.radEng)
        Me.grpTeams.Controls.Add(Me.radFrance)
        Me.grpTeams.Controls.Add(Me.radGer)
        Me.grpTeams.Location = New System.Drawing.Point(46, 102)
        Me.grpTeams.Name = "grpTeams"
        Me.grpTeams.Size = New System.Drawing.Size(740, 475)
        Me.grpTeams.TabIndex = 15
        Me.grpTeams.TabStop = False
        Me.grpTeams.Text = "Teams"
        '
        'radAr
        '
        Me.radAr.AutoSize = True
        Me.radAr.Location = New System.Drawing.Point(565, 255)
        Me.radAr.Name = "radAr"
        Me.radAr.Size = New System.Drawing.Size(103, 24)
        Me.radAr.TabIndex = 25
        Me.radAr.TabStop = True
        Me.radAr.Text = "Argentina"
        Me.radAr.UseVisualStyleBackColor = True
        '
        'radSp
        '
        Me.radSp.AutoSize = True
        Me.radSp.Location = New System.Drawing.Point(565, 176)
        Me.radSp.Name = "radSp"
        Me.radSp.Size = New System.Drawing.Size(75, 24)
        Me.radSp.TabIndex = 24
        Me.radSp.TabStop = True
        Me.radSp.Text = "Spain"
        Me.radSp.UseVisualStyleBackColor = True
        '
        'radCamer
        '
        Me.radCamer.AutoSize = True
        Me.radCamer.Location = New System.Drawing.Point(565, 106)
        Me.radCamer.Name = "radCamer"
        Me.radCamer.Size = New System.Drawing.Size(99, 24)
        Me.radCamer.TabIndex = 23
        Me.radCamer.TabStop = True
        Me.radCamer.Text = "Cameron"
        Me.radCamer.UseVisualStyleBackColor = True
        '
        'radBra
        '
        Me.radBra.AutoSize = True
        Me.radBra.Location = New System.Drawing.Point(565, 34)
        Me.radBra.Name = "radBra"
        Me.radBra.Size = New System.Drawing.Size(73, 24)
        Me.radBra.TabIndex = 22
        Me.radBra.TabStop = True
        Me.radBra.Text = "Brazil"
        Me.radBra.UseVisualStyleBackColor = True
        '
        'radNether
        '
        Me.radNether.AutoSize = True
        Me.radNether.Location = New System.Drawing.Point(310, 394)
        Me.radNether.Name = "radNether"
        Me.radNether.Size = New System.Drawing.Size(112, 24)
        Me.radNether.TabIndex = 21
        Me.radNether.TabStop = True
        Me.radNether.Text = "Netherland"
        Me.radNether.UseVisualStyleBackColor = True
        '
        'radNig
        '
        Me.radNig.AutoSize = True
        Me.radNig.Location = New System.Drawing.Point(310, 326)
        Me.radNig.Name = "radNig"
        Me.radNig.Size = New System.Drawing.Size(83, 24)
        Me.radNig.TabIndex = 20
        Me.radNig.TabStop = True
        Me.radNig.Text = "Nigeria"
        Me.radNig.UseVisualStyleBackColor = True
        '
        'radRe
        '
        Me.radRe.AutoSize = True
        Me.radRe.Location = New System.Drawing.Point(310, 255)
        Me.radRe.Name = "radRe"
        Me.radRe.Size = New System.Drawing.Size(145, 24)
        Me.radRe.TabIndex = 19
        Me.radRe.TabStop = True
        Me.radRe.Text = "Czech Republic"
        Me.radRe.UseVisualStyleBackColor = True
        '
        'radPo
        '
        Me.radPo.AutoSize = True
        Me.radPo.Location = New System.Drawing.Point(310, 176)
        Me.radPo.Name = "radPo"
        Me.radPo.Size = New System.Drawing.Size(93, 24)
        Me.radPo.TabIndex = 18
        Me.radPo.TabStop = True
        Me.radPo.Text = "Portugal"
        Me.radPo.UseVisualStyleBackColor = True
        '
        'radRu
        '
        Me.radRu.AutoSize = True
        Me.radRu.Location = New System.Drawing.Point(310, 106)
        Me.radRu.Name = "radRu"
        Me.radRu.Size = New System.Drawing.Size(83, 24)
        Me.radRu.TabIndex = 17
        Me.radRu.TabStop = True
        Me.radRu.Text = "Russia"
        Me.radRu.UseVisualStyleBackColor = True
        '
        'radAu
        '
        Me.radAu.AutoSize = True
        Me.radAu.Location = New System.Drawing.Point(310, 32)
        Me.radAu.Name = "radAu"
        Me.radAu.Size = New System.Drawing.Size(96, 24)
        Me.radAu.TabIndex = 16
        Me.radAu.TabStop = True
        Me.radAu.Text = "Australia"
        Me.radAu.UseVisualStyleBackColor = True
        '
        'radK
        '
        Me.radK.AutoSize = True
        Me.radK.Location = New System.Drawing.Point(27, 394)
        Me.radK.Name = "radK"
        Me.radK.Size = New System.Drawing.Size(76, 24)
        Me.radK.TabIndex = 15
        Me.radK.TabStop = True
        Me.radK.Text = "Korea"
        Me.radK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(211, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 57)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Click here to show teams"
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'VoteForTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 737)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpTeams)
        Me.Controls.Add(Me.btnSupportRate)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.btnAll)
        Me.Name = "VoteForTeam"
        Me.Text = "Vote For Your Team"
        Me.grpTeams.ResumeLayout(False)
        Me.grpTeams.PerformLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnSupportRate As Button
    Private WithEvents btnBack As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnVote As Button
    Private WithEvents btnAll As Button
    Friend WithEvents radGer As RadioButton
    Friend WithEvents radFrance As RadioButton
    Friend WithEvents radEng As RadioButton
    Friend WithEvents radIta As RadioButton
    Friend WithEvents radSwi As RadioButton
    Friend WithEvents grpTeams As GroupBox
    Friend WithEvents radAu As RadioButton
    Friend WithEvents radK As RadioButton
    Friend WithEvents radRu As RadioButton
    Friend WithEvents radPo As RadioButton
    Friend WithEvents radRe As RadioButton
    Friend WithEvents radNig As RadioButton
    Friend WithEvents radNether As RadioButton
    Friend WithEvents radBra As RadioButton
    Friend WithEvents radCamer As RadioButton
    Friend WithEvents radSp As RadioButton
    Friend WithEvents radAr As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents errProvider As ErrorProvider
End Class
