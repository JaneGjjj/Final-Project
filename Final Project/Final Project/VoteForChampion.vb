Public Class VoteForChampion
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        MessageBox.Show("Are you sure to change your mind?")

        chk1.Checked = False
        chk2.Checked = False
    End Sub

    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click
        MessageBox.Show("Thank you for your vote")

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Close()
    End Sub
End Class