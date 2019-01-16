Public Class clsRenumberingDocument
    Private strYear As String = ""
    Private formatStr As String = ""
    Private fldno As String = ""
    Private flddt As String = ""
    Private fldid As String = ""
    Private tbName As String = ""
    Private positionStr As String = ""
    Private lenNumber As Integer = 3
    Private pfix As String = ""

    Public Property prefix() As String
        Get
            Return pfix
        End Get
        Set(ByVal value As String)
            pfix = value
        End Set
    End Property

    Public Property positionString() As String
        Get
            Return positionStr
        End Get
        Set(ByVal value As String)
            positionStr = value
        End Set
    End Property

    Public Property lengthNo() As Integer
        Get
            Return lenNumber
        End Get
        Set(ByVal value As Integer)
            lenNumber = value
        End Set
    End Property

    Public Property tbYear() As String
        Get
            Return strYear
        End Get
        Set(ByVal value As String)
            strYear = value
        End Set
    End Property

    Public Property tableName() As String
        Get
            Return tbName
        End Get
        Set(ByVal value As String)
            tbName = value
        End Set
    End Property

    Public Property formatString() As String
        Get
            Return formatStr
        End Get
        Set(ByVal value As String)
            formatStr = value
        End Set
    End Property

    Public Property fieldNo() As String
        Get
            Return fldno
        End Get
        Set(ByVal value As String)
            fldno = value
        End Set
    End Property

    Public Property fieldDate() As String
        Get
            Return flddt
        End Get
        Set(ByVal value As String)
            flddt = value
        End Set
    End Property

    Public Property fieldID() As String
        Get
            Return fldid
        End Get
        Set(ByVal value As String)
            fldid = value
        End Set
    End Property

    Public Sub calculate(ByVal tblstr As String, ByVal prefix As String, ByVal yearstr As String, ByVal formatstr As String, ByVal fieldno As String, ByVal fieldid As String, ByVal fielddate As String, ByVal positionstring As String, ByVal lengthnumber As Integer)
        Me.tableName = tblstr
        Me.tbYear = yearstr
        Me.formatString = formatstr
        Me.fieldNo = fieldno
        Me.fieldID = fieldid
        Me.fieldDate = fielddate
        Me.positionString = positionstring
        Me.lengthNo = lengthnumber
        Me.pfix = prefix

        calculate()
    End Sub

    Private Sub calculate()
        If Me.tbName = "" Then
            dizMsgbox("Table Name not set", dizMsgboxStyle.Kesalahan)
            Exit Sub
        End If
        If Me.strYear = "" Then
            dizMsgbox("Year not set", dizMsgboxStyle.Kesalahan)
            Exit Sub
        End If
        If Me.formatStr = "" Then
            dizMsgbox("Format String not set", dizMsgboxStyle.Kesalahan)
            Exit Sub
        End If
        If Me.fldno = "" Then
            dizMsgbox("Field No not set", dizMsgboxStyle.Kesalahan)
            Exit Sub
        End If
        If Me.fldid = "" Then
            dizMsgbox("Field ID not set", dizMsgboxStyle.Kesalahan)
            Exit Sub
        End If
        If Me.flddt = "" Then
            dizMsgbox("Field Date not set", dizMsgboxStyle.Kesalahan)
            Exit Sub
        End If
        If Me.positionStr = "" Then
            dizMsgbox("Position not set", dizMsgboxStyle.Kesalahan)
            Exit Sub
        End If
        If Me.lenNumber = 0 Then
            dizMsgbox("Length Number not set", dizMsgboxStyle.Kesalahan)
            Exit Sub
        End If
        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select " & fldid & "," & fldno & "," & flddt & " from " & tbName & " where datepart(yyyy," & flddt & ")='" & strYear & "' order by " & flddt & " asc", "allcount")
        Dim counter As Integer = mys.getDataSet("allcount")
        mys.DMLQuery("DELETE FROM sys_generatenumber where tablename='" & tbName & pfix & strYear & "'", False)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {fldid, fldno})
        Dim mydt As New dtsetSQLS(dbstring)
        Dim currid As String = ""
        Dim lastNo As String = ""
        For i As Integer = 0 To counter - 1
            lastNo = generateNumber(Me.tbName & Me.pfix & Me.strYear, Me.formatStr, Me.lenNumber, Me.positionStr)

            mydt = New dtsetSQLS(dbstring)

            value.Clear()
            currid = mys.getDataSet("allcount", i, fldid)
            value.AddRange(New Object() {currid, lastNo})
            mydt.datasetSave(Me.tbName, currid, field, value, False)
        Next
    End Sub

    Private Function generateNumber(ByVal tbStr As String, ByVal formatStr As String, ByVal lenNumber As Integer, ByVal posNumber As String) As String
        Dim retval As String = ""
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tbStr & "'", "GetLast")
        Dim idgen As Integer = -1
        Dim currid As Integer = 0
        Dim currStrId As String = ""
        Dim lenStr As String = ""

        If mysqls.getDataSet("GetLast") = 0 Then
            currid = 1
            posNumber = positionStr
        Else
            idgen = mysqls.getDataSet("GetLast", 0, "idgeneratenumber")

            formatStr = mysqls.getDataSet("GetLast", 0, "formatstring")
            currid = CInt(mysqls.getDataSet("GetLast", 0, "lastnumber")) + 1
            posNumber = mysqls.getDataSet("GetLast", 0, "positionnumber")
            lenNumber = CInt(mysqls.getDataSet("GetLast", 0, "digitnumber"))
        End If
        For i As Integer = 0 To lenNumber - 1
            If i = 0 Then
                lenStr = "0"
            Else
                lenStr &= "#"
            End If
        Next
        currStrId = Format(currid, lenStr)

        If posNumber = "Belakang" Then
            retval = formatStr & currStrId
        ElseIf posNumber = "Depan" Then
            retval = currStrId & formatStr
        End If

        Dim dtsave As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idgeneratenumber", "tablename", "formatstring", "lastnumber", "positionnumber", "digitnumber"})
        value.AddRange(New String() {idgen, tbStr, formatStr, currid, posNumber, lenNumber})
        dtsave.datasetSave("sys_generatenumber", idgen, field, value, False)

        Return retval
    End Function

End Class