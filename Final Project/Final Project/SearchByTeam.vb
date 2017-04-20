Public Class SearchByTeam
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub SearchByTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GameInformationDataSet.Game' table. You can move, or remove it, as needed.
        Me.GameTableAdapter.Fill(Me.GameInformationDataSet.Game)
        'TODO: This line of code loads data into the 'GameInformationDataSet.Teams' table. You can move, or remove it, as needed.
        Me.TeamsTableAdapter.Fill(Me.GameInformationDataSet.Teams)

        cboTeam.SelectedIndex = -1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboTeam.SelectedIndex = -1

    End Sub
End Class