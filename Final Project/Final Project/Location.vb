Public Class Location

    Private adapter As New _
        GameInformationDataSetTableAdapters.LocationTableAdapter


    Public Shared Property LastError As String

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

End Class
