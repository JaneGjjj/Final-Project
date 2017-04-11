Public Class frmMain
    Private Sub mtnSearchByTeam_Click(sender As Object, e As EventArgs) Handles mtnSearchByTeam.Click
        SearchByTeam.ShowDialog()
    End Sub

    Private Sub mtnSearchByDate_Click(sender As Object, e As EventArgs) Handles mtnSearchByDate.Click
        SearchByDate.ShowDialog()
    End Sub

    Private Sub mtnSearchByLocation_Click(sender As Object, e As EventArgs) Handles mtnSearchByLocation.Click
        SearchByLocation.ShowDialog()
    End Sub

    Private Sub voteForYourTeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles voteForYourTeamToolStripMenuItem.Click
        VoteForTeam.ShowDialog()
    End Sub

    Private Sub seeYourTeamsSupportRateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles seeYourTeamsSupportRateToolStripMenuItem.Click
        SupportRate.ShowDialog()
    End Sub

    Private Sub voteForFinalPhraseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles voteForFinalPhraseToolStripMenuItem.Click
        VoteForChampion.ShowDialog()
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
