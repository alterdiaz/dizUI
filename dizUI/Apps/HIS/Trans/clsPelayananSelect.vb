Public Class clsPelayananSelect

    Private kdpelayanan As String
    Public Sub New(strpelayanan As String)
        kdpelayanan = strpelayanan
    End Sub

    Public Function getStringPilih() As String
        Return kdpelayanan
    End Function

End Class
