Public Class AddGame

    Private mGame As New Game
    Private mLocation As New Location

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub AddGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GameInformationDataSet.Game' table. You can move, or remove it, as needed.
        Me.GameTableAdapter.Fill(Me.GameInformationDataSet.Game)

        cboPlace.DataSource = mLocation.Items
        cboPlace.DisplayMember = "Date"
        cboPlace.ValueMember = "Location"



    End Sub
End Class