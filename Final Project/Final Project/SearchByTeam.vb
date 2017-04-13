Public Class SearchByTeam
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub SearchByTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboTeam.SelectedIndex = -1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboTeam.SelectedIndex = -1

    End Sub
End Class