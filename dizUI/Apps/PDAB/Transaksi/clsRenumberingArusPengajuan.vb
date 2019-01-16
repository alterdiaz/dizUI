Public Class clsRenumberingArusPengajuan

    Private strYear As String = ""
    Private intPosisiDK As Integer = 0
    Public Property tbYear() As String
        Get
            Return strYear
        End Get
        Set(ByVal value As String)
            Me.strYear = value
        End Set
    End Property

    Public Property tbPosisiDK() As String
        Get
            Return intPosisiDK
        End Get
        Set(ByVal value As String)
            Me.intPosisiDK = value
        End Set
    End Property

    Public Sub calculate(ByVal yearstr As String, posisidkstr As String)
        Me.tbYear = yearstr
        If posisidkstr = "M" Then
            Me.tbPosisiDK = 1
        Else
            Me.tbPosisiDK = 2
        End If

        calculate()
    End Sub

    Private Sub calculate()
        If Me.strYear = "" Then
            dizMsgbox("Year not set", dizMsgboxStyle.Kesalahan)
            Exit Sub
        End If
        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select hd.idaruspengajuan,hd.noaruspengajuan,hd.tanggalpemohon,dt.posisidk from aruspengajuan hd left join (select distinct idaruspengajuan,posisidk from aruspengajuandt) dt on hd.idaruspengajuan=dt.idaruspengajuan where datepart(yyyy,hd.tanggalpemohon)='" & strYear & "' and posisidk='" & intPosisiDK & "' order by hd.tanggalpemohon asc", "allcount")
        Dim counter As Integer = mys.getDataSet("allcount")
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idaruspengajuan", "noaruspengajuan"})
        Dim mydt As New dtsetSQLS(dbstring)
        Dim currid As String = ""
        Dim lastNo As String = ""
        For i As Integer = 0 To counter - 1
            mydt = New dtsetSQLS(dbstring)
            Threading.Thread.Sleep(200)

            value.Clear()
            currid = mys.getDataSet("allcount", i, "idaruspengajuan")
            If intPosisiDK = 1 Then
                lastNo = "PPM" & strYear & "/" & Format(i + 1, "0###")
            Else
                lastNo = "PPK" & strYear & "/" & Format(i + 1, "0###")
            End If
            value.AddRange(New Object() {currid, lastNo})
            mydt.datasetSave("aruspengajuan", currid, field, value, False)
        Next
    End Sub

End Class
