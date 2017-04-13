Public Class AddGame

    Private mGame As New Game
    Private mLocation As New Location

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub AddGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboPlace.DataSource = mLocation.Items
        cboPlace.DisplayMember = "Date"
        cboPlace.ValueMember = "Location"



    End Sub
End Class