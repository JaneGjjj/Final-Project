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

        Label1.Visible = True




    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click

        grpTeams.Visible = True
        Label1.Visible = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        grpTeams.Visible = True
        Label1.Visible = False


        For Each rad As RadioButton In Controls.OfType(Of RadioButton)
            rad.Checked = False
        Next


    End Sub

    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click

        errProvider.Clear()


        For i As Integer = Controls.Count - 1 To 0 Step -1

            If TypeOf Controls(i) Is RadioButton Then
                Dim rad As RadioButton = CType(Controls(i), RadioButton)

                'check controls are not empty
                If rad.Checked = False Then
                    errProvider.SetError(rad, rad.Tag.ToString & " is not selected.")
                    rad.Focus()
                    Return

                End If
            End If

        Next
    End Sub
End Class