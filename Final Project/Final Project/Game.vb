Public Class Game

    Private adapter As New _
        GameInformationDataSetTableAdapters.GameTableAdapter

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

    Public Function Add(ByVal GameDate As DateTime,
                        ByVal Location As String, ByVal Team1 As String,
                        ByVal Team1Best As Integer, ByVal Team2 As String,
                        ByVal Team2Best As Integer, ByVal History As String,
                        ByVal todayWinner As String, ByVal todayResult As String) As Boolean

        Try

            adapter.Add(GameDate, Location,
                        Team1, Team1Best, Team2, Team2Best,
                        History, todayWinner, todayResult)
            Return True
        Catch ex As Exception

            Return False
        End Try


    End Function


End Class
