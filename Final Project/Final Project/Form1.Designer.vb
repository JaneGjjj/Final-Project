<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mtnInformation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mtnSearchByTeam = New System.Windows.Forms.ToolStripMenuItem()
        Me.mtnSearchByDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mtnSearchByLocation = New System.Windows.Forms.ToolStripMenuItem()
        Me.makeYourPredictionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.voteForYourTeamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.seeYourTeamsSupportRateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.voteForFinalPhraseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(55, 84)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(593, 220)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 2
        Me.pictureBox2.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Showcard Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label1.Location = New System.Drawing.Point(28, 363)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(647, 104)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Hello everyone!!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do you want to predict the champion for World Cup 2018?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do yo" &
    "u want to know the game timetable in details?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "There is the right place for you!" &
    "!! Enjoy!!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(681, 101)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(290, 366)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(402, 522)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(246, 39)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'menuStrip1
        '
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtnInformation, Me.ToolStripMenuItem1, Me.exitToolStripMenuItem, Me.makeYourPredictionToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(1003, 33)
        Me.menuStrip1.TabIndex = 6
        Me.menuStrip1.Text = "menuStrip1"
        '
        'mtnInformation
        '
        Me.mtnInformation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtnSearchByTeam, Me.mtnSearchByDate, Me.mtnSearchByLocation})
        Me.mtnInformation.Name = "mtnInformation"
        Me.mtnInformation.Size = New System.Drawing.Size(213, 29)
        Me.mtnInformation.Text = "Get Game's Information"
        '
        'mtnSearchByTeam
        '
        Me.mtnSearchByTeam.Name = "mtnSearchByTeam"
        Me.mtnSearchByTeam.Size = New System.Drawing.Size(246, 30)
        Me.mtnSearchByTeam.Text = "Search by Team"
        '
        'mtnSearchByDate
        '
        Me.mtnSearchByDate.Name = "mtnSearchByDate"
        Me.mtnSearchByDate.Size = New System.Drawing.Size(246, 30)
        Me.mtnSearchByDate.Text = "Search by Date"
        '
        'mtnSearchByLocation
        '
        Me.mtnSearchByLocation.Name = "mtnSearchByLocation"
        Me.mtnSearchByLocation.Size = New System.Drawing.Size(246, 30)
        Me.mtnSearchByLocation.Text = "Search by Location"
        '
        'makeYourPredictionToolStripMenuItem
        '
        Me.makeYourPredictionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.voteForYourTeamToolStripMenuItem, Me.seeYourTeamsSupportRateToolStripMenuItem, Me.voteForFinalPhraseToolStripMenuItem})
        Me.makeYourPredictionToolStripMenuItem.Name = "makeYourPredictionToolStripMenuItem"
        Me.makeYourPredictionToolStripMenuItem.Size = New System.Drawing.Size(191, 29)
        Me.makeYourPredictionToolStripMenuItem.Text = "Make Your Prediction"
        '
        'voteForYourTeamToolStripMenuItem
        '
        Me.voteForYourTeamToolStripMenuItem.Name = "voteForYourTeamToolStripMenuItem"
        Me.voteForYourTeamToolStripMenuItem.Size = New System.Drawing.Size(333, 30)
        Me.voteForYourTeamToolStripMenuItem.Text = "Vote For Your Team"
        '
        'seeYourTeamsSupportRateToolStripMenuItem
        '
        Me.seeYourTeamsSupportRateToolStripMenuItem.Name = "seeYourTeamsSupportRateToolStripMenuItem"
        Me.seeYourTeamsSupportRateToolStripMenuItem.Size = New System.Drawing.Size(333, 30)
        Me.seeYourTeamsSupportRateToolStripMenuItem.Text = "See Your Team's Support Rate"
        '
        'voteForFinalPhraseToolStripMenuItem
        '
        Me.voteForFinalPhraseToolStripMenuItem.Name = "voteForFinalPhraseToolStripMenuItem"
        Me.voteForFinalPhraseToolStripMenuItem.Size = New System.Drawing.Size(333, 30)
        Me.voteForFinalPhraseToolStripMenuItem.Text = "Vote For Final Phrase"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(209, 29)
        Me.exitToolStripMenuItem.Text = "About World Cup 2018"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(208, 29)
        Me.ToolStripMenuItem1.Text = "Add Game Information"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 587)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Name = "frmMain"
        Me.Text = "World Cup 2018"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnExit As Button
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents mtnInformation As ToolStripMenuItem
    Private WithEvents mtnSearchByTeam As ToolStripMenuItem
    Private WithEvents mtnSearchByDate As ToolStripMenuItem
    Private WithEvents mtnSearchByLocation As ToolStripMenuItem
    Private WithEvents makeYourPredictionToolStripMenuItem As ToolStripMenuItem
    Private WithEvents voteForYourTeamToolStripMenuItem As ToolStripMenuItem
    Private WithEvents seeYourTeamsSupportRateToolStripMenuItem As ToolStripMenuItem
    Private WithEvents voteForFinalPhraseToolStripMenuItem As ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
