<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupportRate
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(833, 608)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(215, 42)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back To HomePage"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(52, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(972, 527)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teams Support Rate"
        '
        'SupportRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 691)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "SupportRate"
        Me.Text = "Support Rate"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnBack As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
