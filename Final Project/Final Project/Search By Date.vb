Public Class SearchByDate

    Private mGame As New Game

    Private formload As Boolean = True

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub SearchByDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GameInformationDataSet.Game' table. You can move, or remove it, as needed.
        Me.GameTableAdapter.Fill(Me.GameInformationDataSet.Game)

        formload = False

        dgvGamesInDay.DataSource = mGame.Items


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If Not formload Then
            Dim selectdate As Date = CDate(dtpGameDay.Value)
            dgvGamesInDay.DataSource = mGame.GetbyDate(GameDate)
        End If

    End Sub
End Class