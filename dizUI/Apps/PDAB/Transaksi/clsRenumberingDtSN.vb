Public Class clsRenumberingDtSN

    Private strYear As String = ""

    Public Property tbYear() As String
        Get
            Return strYear
        End Get
        Set(ByVal value As String)
            Me.strYear = value
        End Set
    End Property

    Public Sub calculate(ByVal yearstr As String)
        Me.tbYear = yearstr

        calculate()
    End Sub

    Private Sub calculate()
        If Me.strYear = "" Then
            dizMsgbox("Year not set", dizMsgboxStyle.Kesalahan)
            Exit Sub
        End If
        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select hd.tanggalpemohon, dt.idaruspengajuandt, dt.nomorurut from aruspengajuan hd left join aruspengajuandt dt on hd.idaruspengajuan=dt.idaruspengajuan where dt.posisidk=1 and year(hd.tanggalpemohon)='" & strYear & "' order by hd.tanggalpemohon asc", "allcount")
        Dim counter As Integer = mys.getDataSet("allcount")
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idaruspengajuandt", "nomorurut"})
        Dim mydt As New dtsetSQLS(dbstring)
        Dim currid As String = ""
        Dim lastNo As String = ""
        For i As Integer = 0 To counter - 1
            mydt = New dtsetSQLS(dbstring)

            value.Clear()
            currid = mys.getDataSet("allcount", i, "idaruspengajuandt")
            lastNo = strYear & "K" & Format(i + 1, "0###")
            value.AddRange(New Object() {currid, lastNo})
            mydt.datasetSave("aruspengajuandt", currid, field, value, False)
        Next

        mys = New SQLs(dbstring)
        mys.DMLQuery("select hd.tanggalpemohon, dt.idaruspengajuandt, dt.nomorurut from aruspengajuan hd left join aruspengajuandt dt on hd.idaruspengajuan=dt.idaruspengajuan where dt.posisidk=2 and year(hd.tanggalpemohon)='" & strYear & "' order by hd.tanggalpemohon asc", "allcount")
        counter = mys.getDataSet("allcount")
        field.Clear()
        value.Clear()
        field.AddRange(New String() {"idaruspengajuandt", "nomorurut"})
        mydt = New dtsetSQLS(dbstring)
        currid = ""
        lastNo = ""
        For i As Integer = 0 To counter - 1
            mydt = New dtsetSQLS(dbstring)

            value.Clear()
            currid = mys.getDataSet("allcount", i, "idaruspengajuandt")
            lastNo = strYear & "M" & Format(i + 1, "0###")
            value.AddRange(New Object() {currid, lastNo})
            mydt.datasetSave("aruspengajuandt", currid, field, value, False)
        Next

    End Sub

End Class
