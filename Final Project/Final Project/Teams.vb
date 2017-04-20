Public Class Teams

    Private adapter As New _
        GameInformationDataSetTableAdapters.TeamsTableAdapter


    Public Shared Property LastError As String

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property


End Class
