Public Class VoteForTeam
    Private Sub btnSupportRate_Click(sender As Object, e As EventArgs) Handles btnSupportRate.Click
        SupportRate.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub VoteForTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grpTeams.Visible = False




    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click

        grpTeams.Visible = True
        Label1.Visible = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        grpTeams.Visible = True
        Label1.Visible = False

        radGer.Checked = False
        radFrance.Checked = False
        radBra.Checked = False
        radCamer.Checked = False
        radEng.Checked = False
        radAu.Checked = False
        radAr.Checked = False
        radIta.Checked = False
        radK.Checked = False
        radNether.Checked = False
        radNig.Checked = False
        radPo.Checked = False
        radRe.Checked = False
        radRu.Checked = False
        radSp.Checked = False
        radSwi.Checked = False


    End Sub



End Class