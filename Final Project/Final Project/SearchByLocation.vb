Public Class SearchByLocation
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub SearchByLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboPlace.SelectedIndex = -1
    End Sub


End Class