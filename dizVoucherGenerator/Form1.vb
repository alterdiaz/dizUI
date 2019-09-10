Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        appPath = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If
        Dim de As New dizEngine.engine
        dblite = appPath & de.processD("l59ruEcWFgphomWNjDb5gA==")

        tboSrc.Text = ""
        tboKey1.Text = ""
        tboKey2.Text = ""
        nudLength.Value = nudLength.Minimum
        nudNominal.Value = nudNominal.Minimum
        tboDst.Text = ""
    End Sub

    Public Function CheckAndRepairValidURL(ByVal pathstring As String) As String
        Dim retval As String = ""
        If pathstring.Chars(pathstring.Length - 1) = "/" Then
            retval = pathstring
        Else
            retval = pathstring & "/"
        End If
        Return retval
    End Function

    Public Function HttpPOSTRequestSelect(ByVal url As String, Optional ByVal mparam As List(Of String) = Nothing, Optional ByVal mvalue As List(Of String) = Nothing) As String
        Dim retval As String = ""
        If mparam IsNot Nothing Then
            If mparam.Count <> mvalue.Count Then
                MsgBox("List Parameter is not equal with List Value Parameter")
                Return False
                Exit Function
            End If
        End If
        Using client As New Net.WebClient
            Dim reqparm As New Specialized.NameValueCollection
            If mparam IsNot Nothing Then
                For i As Integer = 0 To mparam.Count - 1
                    reqparm.Add(mparam(i), mvalue(i))
                Next
            End If
            client.Headers.Add("user-agent", "Datacube Engine (diznet)")
            Dim responsebytes As Byte() = client.UploadValues(url, "POST", reqparm)
            Dim responsebody As String = (New Text.UTF8Encoding).GetString(responsebytes) '(New Text.UTF8Encoding).GetString(responsebytes)
            'MsgBox(responsebody)
            retval = responsebody
        End Using
        Return retval
    End Function

    Public Function HttpPOSTRequestInsert(ByVal url As String, Optional ByVal mparam As List(Of String) = Nothing, Optional ByVal mvalue As List(Of String) = Nothing) As String
        Dim retval As String = ""
        If mparam IsNot Nothing Then
            If mparam.Count <> mvalue.Count Then
                MsgBox("List Parameter is not equal with List Value Parameter")
                Return False
                Exit Function
            End If
        End If
        Using client As New Net.WebClient
            Dim reqparm As New Specialized.NameValueCollection
            If mparam IsNot Nothing Then
                For i As Integer = 0 To mparam.Count - 1
                    reqparm.Add(mparam(i), mvalue(i))
                Next
            End If
            client.Headers.Add("user-agent", "Datacube Engine (diznet)")
            Dim responsebytes As Byte() = client.UploadValues(url, "POST", reqparm)
            Dim responsebody As String = (New Text.UTF8Encoding).GetString(responsebytes) '(New Text.UTF8Encoding).GetString(responsebytes)
            'MsgBox(responsebody)
            retval = responsebody
        End Using
        Return retval
    End Function

    Private appPath As String = ""
    Private dblite As String = ""
    Private mysite As String = ""
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim voucherdata As String = Format(Now, "yyyyMMddHHmmssffffff")
        tboSrc.Text = voucherdata
        Dim srcstr As String = ""
        For i As Integer = 0 To tboSrc.Text.Length - 1
            If CInt(tboSrc.Text.Chars(i).ToString) = 0 Then
                srcstr &= "0"
            Else
                srcstr &= Chr(64 + CInt(tboSrc.Text.Chars(i).ToString))
            End If
        Next
        tboSrc.Text = srcstr.ToUpper
        Dim enc As New dizEngine.engine

        Dim myi As New SQLi(dblite)
        'myi.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || schema || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
        'Dim dbstring As String = myi.getDataSet("getdbstring", 0, "dbstring")
        myi.DMLQuery("select siteurl from siteconn where active=1 order by idsiteconn desc", "getdbstring")
        If myi.getDataSet("getdbstring") > 0 Then
            'mystring = lite.getDataSet("getdbstring", 0, "dbstring")
            mysite = myi.getDataSet("getdbstring", 0, "siteurl")
            mysite = CheckAndRepairValidURL(mysite)
        End If

        'Dim mys As New SQLs(dbstring)
        'Dim val As New List(Of String)
        Dim json_result As String = ""
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        json_result = HttpPOSTRequestSelect(mysite & "CurrentToken")
        table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
        'mys.DMLQuery("select top 1 idtoken,tokenkey1,tokenkey2 from token order by createddate desc", "token")
        If table.Rows.Count > 0 Then 'mys.getDataSet("token") > 0 Then
            tboKey1.Tag = table.Rows(0).Item("idtoken") 'mys.getDataSet("token", 0, "idtoken")
            tboKey2.Tag = table.Rows(0).Item("idtoken") 'mys.getDataSet("token", 0, "idtoken")
            tboKey1.Text = table.Rows(0).Item("tokenkey1") 'mys.getDataSet("token", 0, "tokenkey1")
            tboKey2.Text = table.Rows(0).Item("tokenkey2") 'mys.getDataSet("token", 0, "tokenkey2")
        End If

        Dim nominaldata As Long = CLng(nudNominal.Value / 42)
        Dim duedate As Date = Now.AddDays(30)

        tboEnc.Text = getGenerateCode(srcstr.ToUpper, tboKey1.Text, tboKey2.Text, 50, getFrom.belakang)
        tboDst.Text = getGenerateCode(srcstr.ToUpper, tboKey1.Text, tboKey2.Text, 8000, getFrom.belakang)

        'Dim dtmys As New dtsetSQLS(dbstring)
        Dim idvoucher As String = generateguid
        Dim fs As New List(Of String)
        Dim vs As New List(Of String)
        fs.AddRange(New String() {"idvoucher", "voucherdata", "voucherstring", "idtoken", "tokenkey1", "tokenkey2", "vouchercode", "vouchernominal", "nominaldata", "duedate", "isdeleted", "deletereason", "createdby"})
        vs.AddRange(New String() {idvoucher, voucherdata, tboEnc.Text, tboKey1.Tag, tboKey1.Text, tboKey2.Text, tboDst.Text, nudNominal.Value, nominaldata, Format(duedate, "yyyy-MM-dd"), 0, "-", "B07F6E12-85F7-4EA1-88A3-58BDC7CDAF6A"})

        json_result = ""
        table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"baru", idvoucher, tboKey1.Text, tboKey2.Text})
        mparam.AddRange(fs)
        mvalue.AddRange(vs)
        json_result = HttpPOSTRequestInsert(mysite & "Voucher", mparam, mvalue)
        'table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
        'dtmys.datasetSave("voucher", -1, fs, vs, False)
    End Sub

    Public Function GenerateGUID() As String
        Dim retval As String = System.Guid.NewGuid.ToString().ToUpper()
        Return retval
    End Function


    Public Enum getFrom
        depan = 0
        belakang = 1
    End Enum
    Public Function getGenerateCode(ByVal str As String, tokenkey1 As String, tokenkey2 As String, maxlength As Integer, getLengthFrom As getFrom) As String
        Dim retval As String = String.Empty
        If str = "" Then
            retval = ""
        Else
            For i As Integer = 0 To str.Length - 1
                If System.Text.RegularExpressions.Regex.IsMatch(str.Chars(i).ToString.ToUpper, "[A-Za-z0-9]") = True Then
                    retval &= str.Chars(i).ToString.ToUpper
                Else
                    retval &= ""
                End If
            Next
        End If

        If retval <> "" Then
            Dim engine As New dizEngine.engine
            retval = engine.processE(retval)
            retval = engine.Encrypt(retval, tokenkey1)
            retval = engine.Encrypt(retval, tokenkey2)
            Dim tmp As String = retval
            retval = ""
            For i As Integer = 0 To tmp.Length - 1
                If System.Text.RegularExpressions.Regex.IsMatch(tmp.Chars(i).ToString.ToUpper, "[A-Za-z0-9]") = True Then
                    retval &= tmp.Chars(i).ToString.ToUpper
                Else
                    retval &= ""
                End If
            Next

            If retval.Length > maxlength Then
                If getLengthFrom = getFrom.depan Then
                    retval = retval.Remove(maxlength, retval.Length - maxlength)
                ElseIf getLengthFrom = getFrom.belakang Then
                    retval = retval.Substring(retval.Length - maxlength, maxlength)
                End If
            End If
        End If
        Return retval
    End Function


End Class
