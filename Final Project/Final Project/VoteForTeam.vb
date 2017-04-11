Public Class VoteForTeam
    Private Sub btnSupportRate_Click(sender As Object, e As EventArgs) Handles btnSupportRate.Click
        SupportRate.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class