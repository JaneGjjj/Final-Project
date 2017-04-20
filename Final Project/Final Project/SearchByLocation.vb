Public Class SearchByLocation
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub SearchByLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GameInformationDataSet.Game' table. You can move, or remove it, as needed.
        Me.GameTableAdapter.Fill(Me.GameInformationDataSet.Game)
        'TODO: This line of code loads data into the 'GameInformationDataSet.Location' table. You can move, or remove it, as needed.
        Me.LocationTableAdapter.Fill(Me.GameInformationDataSet.Location)
        cboPlace.SelectedIndex = -1
    End Sub


End Class