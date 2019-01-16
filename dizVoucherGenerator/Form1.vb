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

    Private appPath As String = ""
    Private dblite As String = ""
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
        myi.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || schema || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
        Dim dbstring As String = myi.getDataSet("getdbstring", 0, "dbstring")
        Dim mys As New SQLs(dbstring)
        Dim val As New List(Of String)
        mys.DMLQuery("select top 1 idtoken,tokenkey1,tokenkey2 from token order by createddate desc", "token")
        If mys.getDataSet("token") > 0 Then
            tboKey1.Tag = mys.getDataSet("token", 0, "idtoken")
            tboKey2.Tag = mys.getDataSet("token", 0, "idtoken")
            tboKey1.Text = mys.getDataSet("token", 0, "tokenkey1")
            tboKey2.Text = mys.getDataSet("token", 0, "tokenkey2")
        End If

        Dim nominaldata As Long = CLng(nudNominal.Value / 42)
        Dim duedate As Date = Now.AddDays(30)

        tboEnc.Text = getGenerateCode(srcstr.ToUpper, tboKey1.Text, tboKey2.Text, 50, getFrom.belakang)
        tboDst.Text = getGenerateCode(srcstr.ToUpper, tboKey1.Text, tboKey2.Text, 8000, getFrom.belakang)

        Dim dtmys As New dtsetSQLS(dbstring)
        Dim fs As New List(Of String)
        Dim vs As New List(Of Object)
        fs.AddRange(New String() {"idvoucher", "voucherdata", "voucherstring", "idtoken", "tokenkey1", "tokenkey2", "vouchercode", "vouchernominal", "nominaldata", "duedate", "isdeleted", "deletereason", "createdby"})
        vs.AddRange(New String() {-1, voucherdata, tboEnc.Text, tboKey1.Tag, tboKey1.Text, tboKey2.Text, tboDst.Text, nudNominal.Value, nominaldata, duedate, 0, "-", 1})
        'dtmys.datasetSave("voucher", -1, fs, vs, False)
    End Sub

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
