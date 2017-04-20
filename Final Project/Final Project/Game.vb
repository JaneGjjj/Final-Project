Public Class Game

    Private adapter As New _
        GameInformationDataSetTableAdapters.GameTableAdapter

    Public Shared Property LastError As String

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

    Public Function Insert(ByVal GameDate As Date,
                        ByVal Location As String, ByVal Team1 As String,
                        ByVal Team1Best As Integer, ByVal Team2 As String,
                        ByVal Team2Best As Integer, ByVal History As String,
                        ByVal todayWinner As String, ByVal todayResult As String) As Boolean

        Try
            LastError = String.Empty
            adapter.Insert(GameDate, Location,
                        Team1, Team1Best, Team2, Team2Best,
                        History, todayWinner, todayResult)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try


    End Function


    Public Function GetbyDate(ByVal GameDate As Date) As DataTable
        Dim table As DataTable = adapter.GetData()
        table.DefaultView.RowFilter = "Date = " & GameDate

        Return table
    End Function


End Class
