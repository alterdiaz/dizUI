﻿Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Management
Imports System.Net
Module modCore

    Public Function updateSetting(path As String) As Boolean
        Dim retval As Boolean = False

        For Each i As String In IO.Directory.GetFiles(path)
            IO.File.Delete(i)
        Next

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idappsettingfiles,filename,appversion,createddate,filebinary from sys_appsettingfiles where appversion=(select value from sys_appsetting where variable='ProductSettingVersion')", "appfiles")
        Dim tmpbyte As Byte() = Nothing
        Dim filename As String = ""

        For i As Integer = 0 To sqls.getDataSet("appfiles") - 1
            Dim msqls As New SQLs(dbstring)
            GC.Collect()
            tmpbyte = Nothing
            filename = sqls.getDataSet("appfiles", i, "filename")
            If filename.ToLower <> IO.Path.GetFileName(path).ToLower Then
                If filename <> "" Then
                    tmpbyte = msqls.getData("sys_appsettingfiles", "filebinary", "filename", filename, False)
                End If
                Try
                    Dim errBool As Boolean = False
                    If IO.File.Exists(path & filename) = True Then
                        Try
                            IO.File.Delete(path & filename)
                        Catch ex As Exception
                            'MsgBox("error delete" & vbCrLf & filename & vbCrLf & sqls.getDataSet("appfiles", i, "createddate"))
                            errBool = True
                        End Try
                        Application.DoEvents()
                    End If
                    If errBool = False Then
                        Try
                            IO.File.WriteAllBytes(path & filename, tmpbyte)
                        Catch ex As Exception
                            'MsgBox("error write" & vbCrLf & filename & vbCrLf & sqls.getDataSet("appfiles", i, "createddate"))
                        End Try
                    End If
                    'MsgBox(updpath & filename)
                    Application.DoEvents()
                    Threading.Thread.Sleep(50)
                Catch ex As Exception
                    'MsgBox("unknown error" & vbCrLf & filename & vbCrLf & ex.Message)
                End Try
            End If
        Next

        Return retval
    End Function

    Public Function applyFormatGrid(_ipclient As String, _frmname As String, _gridname As String, gridview As DevExpress.XtraGrid.Views.Grid.GridView) As DevExpress.XtraGrid.Views.Grid.GridView
        Dim gvtemp As DevExpress.XtraGrid.Views.Grid.GridView = gridview
        Dim value As New List(Of Object)
        Dim field As New List(Of String)
        Dim sqls As New SQLs(dbstring)
        field.AddRange(New String() {"@ipclient", "@iduserlevel", "@iduser", "@frmname", "@gridname"})
        value.AddRange(New Object() {_ipclient, userlevelid, userid, _frmname, _gridname})
        Dim idtype As Long = 0
        sqls.CallSP("spCekFormatGrid", "cekfg", field, value)
        idtype = sqls.getDataSet("cekfg", 0, "cek")

        If idtype = CLng(1) Then
            sqls.DMLQuery("select idformatgrid,columnstring,halignment,valuerules1,valuerules2,valuerules3 from formatgrid where idreff='" & _ipclient & "' and refftype='IPCLIENT' and frmname='" & _frmname & "' and gridname='" & _gridname & "' and ((valuerules1<>0 and valuerules2=0 and valuerules3=0) or (valuerules1<>0 and valuerules2<>0 and valuerules3=0) or (valuerules1<>0 and valuerules2<>0 and valuerules3<>0)) order by columnstring asc", "data")
        ElseIf idtype = CLng(2) Then
            sqls.DMLQuery("select idformatgrid,columnstring,halignment,valuerules1,valuerules2,valuerules3 from formatgrid where idreff='" & userlevelid & "' and refftype='USERLEVEL' and frmname='" & _frmname & "' and gridname='" & _gridname & "' order by columnstring asc", "data")
        ElseIf idtype = CLng(3) Then
            sqls.DMLQuery("select idformatgrid,columnstring,halignment,valuerules1,valuerules2,valuerules3 from formatgrid where idreff='" & userid & "' and refftype='USER' and frmname='" & _frmname & "' and gridname='" & _gridname & "' order by columnstring asc", "data")
        End If
        If idtype <> CLng(0) Then
            For a As Integer = 0 To sqls.getDataSet("data") - 1
                For i As Integer = 0 To gvtemp.Columns.Count - 1
                    Dim colnamei As String = gvtemp.Columns(i).Caption
                    Dim colnamea As String = sqls.getDataSet("data", a, "columnstring")
                    Dim rule1 As Long = sqls.getDataSet("data", a, "valuerules1")
                    Dim rule2 As Long = sqls.getDataSet("data", a, "valuerules2")
                    Dim rule3 As Long = sqls.getDataSet("data", a, "valuerules3")
                    If colnamei = colnamea Then
                        If rule1 <> CLng(0) Then
                            Dim rule As Long = rule1
                            gvtemp = formatGrid(rule, i, gvtemp)
                        End If
                        If rule1 <> CLng(0) And rule2 <> CLng(0) Then
                            Dim rule As Long = rule2
                            gvtemp = formatGrid(rule, i, gvtemp)
                        End If
                        If rule1 <> CLng(0) And rule2 <> CLng(0) And rule3 <> CLng(0) Then
                            Dim rule As Long = rule3
                            gvtemp = formatGrid(rule, i, gvtemp)
                        End If
                    End If
                Next
            Next
        End If
        Return gvtemp
    End Function

    Private Function formatGrid(idrule As Long, idx As Integer, gridview As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim rule As Long = idrule
        Dim gvtemp As DevExpress.XtraGrid.Views.Grid.GridView = gridview
        Dim retErr As Boolean = False
        For b As Integer = 0 To gvtemp.RowCount - 1
            If retErr = False Then
                If rule = CLng(1) Then
                    Try
                        Dim tmpval As String = gvtemp.GetRowCellValue(b, gvtemp.Columns(idx))
                        Dim tmpres As Long = CLng(tmpval)
                        gvtemp.SetRowCellValue(b, gvtemp.Columns(idx), tmpres)
                    Catch ex As Exception
                        retErr = True
                    End Try
                ElseIf rule = CLng(2) Then
                    Try
                        Dim tmpval As String = gvtemp.GetRowCellValue(b, gvtemp.Columns(idx))
                        Dim tmpres As String = tmpval.Replace("-", "")
                        gvtemp.SetRowCellValue(b, gvtemp.Columns(idx), tmpres)
                    Catch ex As Exception
                        retErr = True
                    End Try
                ElseIf rule = CLng(3) Then
                    Try
                        Dim tmpval As String = gvtemp.GetRowCellValue(b, gvtemp.Columns(idx))
                        Dim tmpres As String = tmpval.Replace(".", "")
                        gvtemp.SetRowCellValue(b, gvtemp.Columns(idx), tmpres)
                    Catch ex As Exception
                        retErr = True
                    End Try
                ElseIf rule = CLng(4) Then
                    Try
                        Dim tmpval As String = gvtemp.GetRowCellValue(b, gvtemp.Columns(idx))
                        Dim tmpres As String = tmpval.Replace(".", "-")
                        gvtemp.SetRowCellValue(b, gvtemp.Columns(idx), tmpres)
                    Catch ex As Exception
                        retErr = True
                    End Try
                ElseIf rule = CLng(5) Then
                    Try
                        Dim tmpval As String = gvtemp.GetRowCellValue(b, gvtemp.Columns(idx))
                        Dim tmpres As String = tmpval.Replace("-", ".")
                        gvtemp.SetRowCellValue(b, gvtemp.Columns(idx), tmpres)
                    Catch ex As Exception
                        retErr = True
                    End Try
                End If
            End If
        Next
        Return gvtemp
    End Function

    Public Function centerScreen(obj As Object) As Point
        Dim x As Integer
        Dim y As Integer
        Dim r As Rectangle

        r = Screen.PrimaryScreen.WorkingArea
        'MsgBox(r.Width & " " & r.Height)
        'MsgBox(obj.Width & " " & obj.Height)

        x = r.Width - obj.Width
        y = r.Height - obj.Height

        x = CInt(x / 2)
        y = CInt(y / 2)

        'MsgBox(x & " " & y)
        Dim pnt As New Point(x, y)
        Return pnt
    End Function

    'TelegramBot
    Public telegramToken As String = ""
    Public bott As Telegram.Bot.TelegramBotClient

    Public Sub initTelegramBot()
        Try
            bott = New Telegram.Bot.TelegramBotClient(modCore.telegramToken)
        Catch ex As Exception
        End Try
    End Sub

    Public Async Function sendMessage(ByVal destID As String, ByVal text As String) As System.Threading.Tasks.Task
        Try
            Await bott.SendTextMessageAsync(destID, text, Telegram.Bot.Types.Enums.ParseMode.Markdown, False, False, 0, Nothing)
        Catch e As Exception
        End Try
    End Function

    Public isDemo As Integer = 0
    Public timeoutApps As Integer = 180
    'Public siteonline As String = ""
    Public dbonline As String = ""
    Public dblite As String = ""
    Public bClose As Boolean = True
    Public rClose As String = ""

    Public justRead As Color = Color.FromArgb(255, 192, 192)
    Public canWrite As Color = Color.FromArgb(192, 255, 192)
    Public nowTime As DateTime = Now

    Public longDateFormat As String
    Public longTimeFormat As String
    Public shortDateFormat As String
    Public shortTimeFormat As String
    Public curTh As Thread
    Public culInfo As String = "id-ID"

    Public appPath As String = CheckAndRepairValidPath(Application.StartupPath)
    Public pathTemp As String = appPath & "Temp\"
    Public pathSetting As String = appPath & "Setting\"
    Public pathReport As String = appPath & "Report\"
    Public pathImg64 As String = appPath & "Img64\"
    Public pathImg As String = appPath & "Img\"
    Public pathLog As String = appPath & "Log\"
    Public pathIcon As String = appPath & "Icon\"
    Public pathMap As String = appPath & "Map\"
    Public uCounter, dCounter As Long
    Public svrstat As Boolean = False
    Public startTime As DateTime
    Public splashClosed As Boolean = False

    'Public dbname As String
    Public dbsvr As String
    'Public dbuid As String
    'Public dbpwd As String
    'Public dbport As String = 1433
    Public dbstring As String
    Public trustConn As Boolean = False

    Public isQuotaValid As Boolean = False
    Public isServer As Boolean = False
    Public idhostname As String = ""
    Public iphostname As String = ""

    Public idhardware As String = ""
    Public hardwareid As String = ""
    Public hardwarecode As String = ""

    Public idcompany As String = "-1"
    Public companyname As String = ""
    Public companycode As String = ""

    Public productname As String = ""
    Public productversion As String = ""
    Public idproducttype As New List(Of String)

    Public idcompanyrefferal As String = "-1"
    'Public idcompanyproduct As String = "-1"

    Public formTitle As String = ""
    'Public statData As statusData = statusData.Baru
    'Public statDataChild As statusData = statusData.Baru

    'Public idData As String = "-1"
    'Public idDataChild As String = "-1"
    Public isVoid As Boolean = False

    Public idtoken As String = ""
    Public tokenkey1 As String = ""
    Public tokenkey2 As String = ""

    Public qtyQuota As Decimal = 0

    Public userid As String = 0
    Public username As String = ""
    Public userlevelid As String = "0"
    Public userlevel As String = ""
    Public usersuper As Long = 0
    Public userdata As Long = 0

    Public fromMain As Boolean = False
    Public statLogin As Boolean = False

    Public rNoID As String = ""
    Public rNorek As String = ""
    Public rNumeric As String = ""
    Public rEmail As String = ""
    Public rVarcharCaps As String = ""
    Public rVarcharSmall As String = ""
    Public rVarchar As String = ""
    Public rCharCaps As String = ""
    Public rCharSmall As String = ""
    Public rChar As String = ""
    Public rNIK As String = ""
    Public rIP As String = ""
    Public rDot As String = ""
    Public rTanggal As String = ""

    Public retForm As String = ""

    Public Function ContainsNumber(str As String) As Boolean
        Dim retval As Boolean = False
        Const numbers = "0123456789"
        If str.IndexOfAny(numbers.ToArray) > -1 Then
            retval = True
        Else
            retval = False
        End If
        Return retval
    End Function

    Public Sub cetakWristband(data As List(Of String), printername As String)
        If data.Count <> 8 Then Exit Sub

        Dim strdata As String = "^XA^FWR^FO140,1300^BQN,2,5,H,7^FD--*IDREG*^FS^CF0,60^FO190,1470^A0,90,60^FD*HEADER*^FS^CF0,50^FO160,1470^A0,40,40^FD*NORM*^FS^CF0,50^FO160,1880^A0,40,40^FD*TGLLAHIR*^FS^CF0,50^FO120,1470^A0,40,40^FD*NOREG*^FS^FO120,2040^A0,40,40^FD*SEX*^FS^CF0,50^FO80,1880^A0,40,40^FD*UMUR*^FS^CF0,50^FO80,1470^A0,40,40^FD*FOOTER*^FS^CF0,50^XZ"
        Dim id As String = data(0)
        strdata = strdata.Replace("*IDREG*", id)
        Dim header As String = data(1)
        strdata = strdata.Replace("*HEADER*", header)
        Dim norm As String = data(2)
        strdata = strdata.Replace("*NORM*", norm)
        Dim tgllahir As String = data(3)
        strdata = strdata.Replace("*TGLLAHIR*", tgllahir)
        Dim noreg As String = data(4)
        strdata = strdata.Replace("*NOREG*", noreg)
        Dim umur As String = data(5)
        strdata = strdata.Replace("*UMUR*", umur)
        Dim footer As String = data(6)
        strdata = strdata.Replace("*FOOTER*", footer)
        Dim sex As String = data(7)
        strdata = strdata.Replace("*SEX*", sex)

        Try
            Dim pw As New PrintingRaw.PrintingRaw
            'MsgBox(printername)
            pw.OpenPrinter(printername)
            pw.StartDocPrinter()
            pw.Send(strdata)
            pw.EndPagePrinter()
            pw.EndDocPrinter()
            pw.ClosePrinter()
        Catch ex As Exception
            dizMsgbox("Printer tidak ditemukan/tidak ada akses", dizMsgboxStyle.Peringatan)
        End Try
    End Sub

    Public Function JSONtoDatatable(url As String) As DataTable
        Dim webclient_server7 As New System.Net.WebClient
        Dim json_result As String = webclient_server7.DownloadString(url)
        Dim table As DataTable = Nothing

        Try
            Dim setting = New Newtonsoft.Json.JsonSerializerSettings With {.Converters = {New TypeInferringDataTableConverter()}}
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result, setting)
        Catch ex As Exception
            MsgBox("An exception occured: " & ex.Message)
        End Try
        Return table
    End Function

    Public Function getPrinter(param As String)
        Dim ipaddress As String = "0"
        ipaddress = getIPAddress(ipaddparam.IP)
        Dim sharename As String = ""
        Dim sqlsp As New SQLs(dbstring)
        Dim fieldp As New List(Of String)
        Dim valuep As New List(Of Object)
        fieldp.AddRange(New String() {"@eventcode", "@ipaddress"})
        valuep.AddRange(New String() {param, ipaddress})
        sqlsp.CallSP("spGetPrinter", "getp", fieldp, valuep)
        If sqlsp.getDataSet("getp") > 0 Then
            sharename = CStr(sqlsp.getDataSet("getp", 0, "sharename"))
        End If
        Return sharename
    End Function

    Public Function Strdatetime2Datetime(param As String) As Date
        Dim retVal As Date
        If param Is Nothing Then
            retVal = nowTime
        Else
            Dim strdate As String = param
            retVal = New Date(strdate.Split(" ")(0).Split("-")(2), strdate.Split(" ")(0).Split("-")(1), strdate.Split(" ")(0).Split("-")(0), strdate.Split(" ")(1).Split(":")(0), strdate.Split(" ")(1).Split(":")(1), strdate.Split(" ")(1).Split(":")(2))
        End If
        Return retVal
    End Function

    Public Function Strdate2Date(param As String) As Date
        Dim retVal As Date
        If param Is Nothing Then
            retVal = nowTime
        Else
            Dim strdate As String = param
            retVal = New Date(strdate.Split("-")(2), strdate.Split("-")(1), strdate.Split("-")(0))
        End If
        Return retVal
    End Function

    Public Sub getRegex(dbstring As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexNoID'", "rNoID")
        If sqls.getDataSet("rNoID") > 0 Then
            rNoID = sqls.getDataSet("rNoID", 0, 0)
        Else
            rNoID = ""
        End If

        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexNorek'", "rNorek")
        If sqls.getDataSet("rNorek") > 0 Then
            rNorek = sqls.getDataSet("rNorek", 0, 0)
        Else
            rNorek = ""
        End If

        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexNumeric'", "rNumeric")
        If sqls.getDataSet("rNumeric") > 0 Then
            rNumeric = sqls.getDataSet("rNumeric", 0, 0)
        Else
            rNumeric = ""
        End If

        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexEmail'", "rEmail")
        If sqls.getDataSet("rEmail") > 0 Then
            rEmail = sqls.getDataSet("rEmail", 0, 0)
        Else
            rEmail = ""
        End If

        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexVarcharCaps'", "rVarcharCaps")
        If sqls.getDataSet("rVarcharCaps") > 0 Then
            rVarcharCaps = sqls.getDataSet("rVarcharCaps", 0, 0)
        Else
            rVarcharCaps = ""
        End If

        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexVarcharSmall'", "rVarcharSmall")
        If sqls.getDataSet("rVarcharSmall") > 0 Then
            rVarcharSmall = sqls.getDataSet("rVarcharSmall", 0, 0)
        Else
            rVarcharSmall = ""
        End If

        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexVarchar'", "rVarchar")
        If sqls.getDataSet("rVarchar") > 0 Then
            rVarchar = sqls.getDataSet("rVarchar", 0, 0)
        Else
            rVarchar = ""
        End If


        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexCharCaps'", "rCharCaps")
        If sqls.getDataSet("rCharCaps") > 0 Then
            rCharCaps = sqls.getDataSet("rCharCaps", 0, 0)
        Else
            rCharCaps = ""
        End If

        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexCharSmall'", "rCharSmall")
        If sqls.getDataSet("rCharSmall") > 0 Then
            rCharSmall = sqls.getDataSet("rCharSmall", 0, 0)
        Else
            rCharSmall = ""
        End If

        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexChar'", "rChar")
        If sqls.getDataSet("rChar") > 0 Then
            rChar = sqls.getDataSet("rChar", 0, 0)
        Else
            rChar = ""
        End If

        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexNIK'", "rNIK")
        If sqls.getDataSet("rNIK") > 0 Then
            rNIK = sqls.getDataSet("rNIK", 0, 0)
        Else
            rNIK = ""
        End If

        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexIP'", "rIP")
        If sqls.getDataSet("rIP") > 0 Then
            rIP = sqls.getDataSet("rIP", 0, 0)
        Else
            rIP = ""
        End If

        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexDot'", "rDot")
        If sqls.getDataSet("rDot") > 0 Then
            rDot = sqls.getDataSet("rDot", 0, 0)
        Else
            rDot = ""
        End If

        sqls.DMLQuery("select isnull(value,'') from sys_appsetting where variable='RegexTanggal'", "rTanggal")
        If sqls.getDataSet("rTanggal") > 0 Then
            rTanggal = sqls.getDataSet("rTanggal", 0, 0)
        Else
            rTanggal = ""
        End If
    End Sub

    'Public Function createDataTable(SourceValue As String, DatatableName As String, ColumnName As List(Of String), ColumnCaption As List(Of String), ColumnType As List(Of Type)) As DataSet
    '    Dim ds As New DataSet
    '    If ColumnName.Count <> ColumnCaption.Count Or ColumnCaption.Count <> ColumnType.Count Or ColumnName.Count <> ColumnType.Count Then
    '        dizMsgbox("Parameter tidak benar", dizMsgboxStyle.Kesalahan, me)
    '    Else
    '        ds = New DataSet
    '        Dim dttbl As New DataTable(DatatableName)
    '        Dim dc As New DataColumn

    '        For i As Integer = 0 To ColumnName.Count - 1
    '            dc = New DataColumn
    '            dc.Caption = ColumnCaption.Item(i)
    '            dc.ColumnName = ColumnName.Item(i)
    '            dc.DataType = ColumnType.Item(i)
    '            dttbl.Columns.Add(dc)
    '        Next
    '        If SourceValue.Contains("ERROR") = False Then
    '            For i As Integer = 0 To SourceValue.Split("~").Length - 1
    '                Dim arrstr() As String = SourceValue.Split("~")(i).ToString.Split("|").ToArray
    '                Dim dr As DataRow = dttbl.NewRow
    '                If arrstr(0).Length > 0 Then
    '                    For a As Integer = 0 To dttbl.Columns.Count - 1
    '                        dr(dttbl.Columns(a).ColumnName) = arrstr(a)
    '                    Next
    '                    dttbl.Rows.Add(dr)
    '                End If
    '            Next
    '        End If

    '        ds.Tables.Add(dttbl)
    '    End If
    '    Return ds
    'End Function

    Public Function GeneratePass(ByVal str As String, ByVal token1 As String, ByVal token2 As String, ByVal maxlength As Integer) As String
        Dim retval As String = ""
        Dim engine As New dizEngine.engine
        str = engine.processE(str)
        str = engine.Encrypt(str, token1)
        str = engine.Encrypt(str, token2)
        If str.Length > maxlength Then
            str = str.Remove(str.Length - maxlength, maxlength)
            'LAMA str = str.Remove(maxlength, str.Length - maxlength)
        End If
        retval = getCharsNumeric(str, True)
        Return retval
    End Function

    Public Enum statusData
        Baru = 0
        Edit = 1
    End Enum

    Public Enum dizMsgboxStyle As Integer
        Info = 0
        Peringatan = 1
        Kesalahan = 2
        Konfirmasi = 3
    End Enum

    Public Enum dizMsgboxValue As Integer
        Batal = 0
        OK = 1
    End Enum

    Public Function dizMsgbox(content As String, boxstyle As dizMsgboxStyle) As dizMsgboxValue
        Dim dizbox As New frmMessagebox(content, boxstyle)
        Dim retval As dizMsgboxValue = dizMsgboxValue.Batal
        Dim dr As DialogResult = dizbox.ShowDialog()
        If dr = DialogResult.OK Then
            retval = dizMsgboxValue.OK
        ElseIf dr = DialogResult.Cancel Then
            retval = dizMsgboxValue.Batal
        End If
        Return retval
    End Function

    Public Function dizMsgbox(content As String, boxstyle As dizMsgboxStyle, title As String) As dizMsgboxValue
        Dim dizbox As New frmMessagebox(content, boxstyle, False, title)
        Dim retval As dizMsgboxValue = dizMsgboxValue.Batal
        Dim dr As DialogResult = dizbox.ShowDialog()
        If dr = DialogResult.OK Then
            retval = dizMsgboxValue.OK
        ElseIf dr = DialogResult.Cancel Then
            retval = dizMsgboxValue.Batal
        End If
        Return retval
    End Function

    Public Function dizMsgbox(content As String, boxstyle As dizMsgboxStyle, title As String, parent As Form) As dizMsgboxValue
        Dim dizbox As New frmMessagebox(content, boxstyle, parent, False, title)
        Dim retval As dizMsgboxValue = dizMsgboxValue.Batal
        Dim dr As DialogResult = DialogResult.Cancel
        If parent.Size.Width > 725 Then
            dr = dizbox.ShowDialog(parent)
        Else
            dr = dizbox.ShowDialog()
        End If
        If dr = DialogResult.OK Then
            retval = dizMsgboxValue.OK
        ElseIf dr = DialogResult.Cancel Then
            retval = dizMsgboxValue.Batal
        End If
        Return retval
    End Function

    Public Function dizMsgbox(content As String, boxstyle As dizMsgboxStyle, title As String, additionalinfo As String, parent As Form) As dizMsgboxValue
        Dim dizbox As New frmMessagebox(content, boxstyle, parent, False, title, additionalinfo)
        Dim retval As dizMsgboxValue = dizMsgboxValue.Batal
        Dim dr As DialogResult = DialogResult.Cancel
        If parent.Size.Width > 725 Then
            dr = dizbox.ShowDialog(parent)
        Else
            dr = dizbox.ShowDialog()
        End If
        If dr = DialogResult.OK Then
            retval = dizMsgboxValue.OK
        ElseIf dr = DialogResult.Cancel Then
            retval = dizMsgboxValue.Batal
        End If
        Return retval
    End Function

    Public Function dizMsgbox(content As String, boxstyle As dizMsgboxStyle, parent As Form) As dizMsgboxValue
        Dim dizbox As New frmMessagebox(content, boxstyle, parent, False)
        Dim retval As dizMsgboxValue = dizMsgboxValue.Batal
        Dim dr As DialogResult = DialogResult.Cancel
        If parent.Size.Width > 725 Then
            dr = dizbox.ShowDialog(parent)
        Else
            dr = dizbox.ShowDialog()
        End If
        If dr = DialogResult.OK Then
            retval = dizMsgboxValue.OK
        ElseIf dr = DialogResult.Cancel Then
            retval = dizMsgboxValue.Batal
        End If
        Return retval
    End Function

    Public Function isEmail(ByVal str As String) As Boolean
        Dim retval As Boolean = True
        Dim countAt As Integer = 0
        Dim countDot As Integer = 0
        For i As Integer = 0 To str.Length - 1
            If str.Chars(i).ToString = "@" Then
                countAt += 1
            End If
        Next
        If countAt <> 1 Then
            retval = False
        Else
            Dim lineStr As String() = str.Split("@")
            For i As Integer = 0 To lineStr(1).Length - 1
                If lineStr(1).Chars(i).ToString = "." Then
                    countDot += 1
                End If
            Next
            If countDot = 0 Then
                retval = False
            End If
        End If
        Return retval
    End Function

    Public Function getNoSpace(ByVal str As String) As String
        Dim retval As String = String.Empty
        If str = "" Then
            retval = ""
        Else
            retval = str.Replace(" ", "")
        End If
        Return retval
    End Function

    Public Function getChars(ByVal str As String) As String
        Dim retval As String = String.Empty
        If str = "" Then
            retval = ""
        Else
            For i As Integer = 0 To str.Length - 1
                If System.Text.RegularExpressions.Regex.IsMatch(str.ToUpper.Chars(i).ToString, "[A-Z]") = True Then
                    retval &= str.Chars(i).ToString
                Else
                    retval &= ""
                End If
            Next
        End If
        Return retval
    End Function

    Public Function getCharsUpper(ByVal str As String) As String
        Dim retval As String = String.Empty
        If str = "" Then
            retval = ""
        Else
            For i As Integer = 0 To str.Length - 1
                If System.Text.RegularExpressions.Regex.IsMatch(str.Chars(i).ToString.ToUpper, "[A-Z]") = True Then
                    retval &= str.Chars(i).ToString.ToUpper
                Else
                    retval &= ""
                End If
            Next
        End If
        Return retval
    End Function

    Public Function getCharsUpperNumeric(ByVal str As String) As String
        Dim retval As String = String.Empty
        If str = "" Then
            retval = ""
        Else
            For i As Integer = 0 To str.Length - 1
                If System.Text.RegularExpressions.Regex.IsMatch(str.Chars(i).ToString.ToUpper, "[A-Z0-9]") = True Then
                    retval &= str.Chars(i).ToString.ToUpper
                Else
                    retval &= ""
                End If
            Next
        End If
        Return retval
    End Function

    Public Function getCharsNumeric(ByVal str As String, Optional nullaszero As Boolean = False) As String
        Dim retval As String = String.Empty
        If str = "" Then
            retval = ""
        Else
            For i As Integer = 0 To str.Length - 1
                If System.Text.RegularExpressions.Regex.IsMatch(str.Chars(i).ToString.ToUpper, "[A-Za-z0-9]") = True Then
                    retval &= str.Chars(i).ToString.ToUpper
                Else
                    If nullaszero = True Then
                        retval &= "0"
                    Else
                        retval &= ""
                    End If
                End If
            Next
        End If
        Return retval.ToUpper
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
            Dim engine As New dizEngine.engine()
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

    Public Function getNumber(ByVal str As String) As String
        Dim retval As String = String.Empty
        For i As Integer = 0 To str.Length - 1
            If IsNumeric(str.Chars(i).ToString) = True Then
                retval &= str.Chars(i).ToString
            End If
        Next
        Return retval
    End Function

    Public Function getStringToNumber(ByVal str As String) As String
        Dim retval As String = String.Empty
        For i As Integer = 0 To str.Length - 1
            If IsNumeric(str.Chars(i).ToString) = False Then
                If System.Text.RegularExpressions.Regex.IsMatch(str.Chars(i).ToString.ToUpper, rCharCaps) = True Then
                    retval &= CStr(Asc(str.Chars(i).ToString.ToUpper) - 64).Chars(CStr(Asc(str.Chars(i).ToString.ToUpper) - 64).Length - 1).ToString
                Else
                    retval &= 0
                End If
            Else
                retval &= str.Chars(i).ToString
            End If
        Next
        Return retval
    End Function

    Public Function getBoardID() As String
        Dim strMotherBoardID As String = String.Empty
        Dim query As New SelectQuery("Win32_Processor")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strMotherBoardID = info("ProcessorId").ToString()
        Next
        Return strMotherBoardID
    End Function

    Public Function getHardwareCode(hardwareid As String, tokenkey1 As String, tokenkey2 As String) As String
        Dim retval As String = ""
        retval = getGenerateCode(hardwareid, tokenkey1, tokenkey2, 2000, getFrom.belakang)
        Return retval
    End Function

    Public Function CheckAndRepairValidPath(ByVal pathstring As String) As String
        Dim retval As String = ""
        If pathstring.Chars(pathstring.Length - 1) = "\" Then
            retval = pathstring
        Else
            retval = pathstring & "\"
        End If
        Return retval
    End Function

    Public Function CheckAndRepairValidURL(ByVal pathstring As String) As String
        Dim retval As String = ""
        If pathstring.Chars(pathstring.Length - 1) = "/" Then
            retval = pathstring
        Else
            retval = pathstring & "/"
        End If
        Return retval
    End Function


    Public Sub writeSettingFile(ByVal content As String)
        Try
            'If IO.File.Exists(pathSetting & filename) Then
            '    IO.File.Delete(pathSetting & filename)
            'End If

            'Dim arrStr(0) As String
            'arrStr(0) = content
            'IO.File.WriteAllLines(pathSetting & filename, arrStr)

            Dim iset As New dtsetSQLI(dblite)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            Dim myi As New SQLi(dblite)
            Dim tmplist As String()
            tmplist = content.Split("|")
            myi.DMLQuery("select iddbconn from dbconn where ipserver='" & tmplist(1) & "' and databasename='" & tmplist(0) & "' and dbtype='SQLS' and dblocation='SERVER'", "getid")
            Dim iddbconn As Integer = -1
            If myi.getDataSet("getid") > 0 Then
                iddbconn = myi.getDataSet("getid", 0, "iddbconn")
            End If
            field.AddRange(New String() {"iddbconn", "databasename", "ipserver", "port", "username", "password", "dbtype", "dblocation"})
            value.AddRange(New Object() {iddbconn, tmplist(0), tmplist(1), tmplist(2), tmplist(3), tmplist(4), "SQLS", "SERVER"})
            iset.datasetSave("dbconn", iddbconn, field, value, False)

        Catch ex As Exception
            'MsgBox(setPath & filename & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Function readSettingFile() As String
        Dim retval As String = ""
        'retval = IO.File.ReadAllLines(pathSetting & filename)(0)

        Dim myi As New SQLi(dblite)
        If isDemo = 0 Then
            myi.DMLQuery("select databasename || '|' || ipserver || '|' || instance || '|' || port || '|' || schema || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='SERVER'", "getdbstring")
        Else
            myi.DMLQuery("select databasename || '_DEMO|' || ipserver || '|' || instance || '|' || port || '|' || schema || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='SERVER'", "getdbstring")
        End If
        myi.DMLQuery("select ipserver from dbconn where dbtype='SQLS' and dblocation='SERVER'", "getipsvr")
        If myi.getDataSet("getdbstring") > 0 Then
            dbsvr = myi.getDataSet("getipsvr", 0, "ipserver")
            retval = myi.getDataSet("getdbstring", 0, "dbstring")
        End If
        Return retval
    End Function

    Public Function readSettingOnline() As String
        Dim retval As String = ""
        Dim lite As New SQLi(dblite)
        lite.DMLQuery("select siteurl from siteconn where active=1 order by idsiteconn desc", "getdbstring")
        If lite.getDataSet("getdbstring") > 0 Then
            'mystring = lite.getDataSet("getdbstring", 0, "dbstring")
            retval = lite.getDataSet("getdbstring", 0, "siteurl")
            retval = CheckAndRepairValidURL(retval)
        End If
        Return retval
    End Function


    'Public Function readSiteOnline() As String
    '    Dim retval As String = ""
    '    Dim myi As New SQLi(dblite)
    '    myi.DMLQuery("select siteurl from siteconn order by idsiteconn asc limit 1", "getsite")
    '    If myi.getDataSet("getsite") > 0 Then
    '        retval = myi.getDataSet("getsite", 0, "siteurl")
    '    End If
    '    Return retval
    'End Function

    Public Function readSettingFileOnline() As String
        Dim retval As String = ""
        'retval = IO.File.ReadAllLines(pathSetting & filename)(0)

        Dim myi As New SQLi(dblite)
        myi.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || schema || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
        If myi.getDataSet("getdbstring") > 0 Then
            retval = myi.getDataSet("getdbstring", 0, "dbstring")
        End If
        Return retval
    End Function

    Public Sub checkPath()
        pathTemp = appPath & "Temp\"
        pathSetting = appPath & "Setting\"
        pathReport = appPath & "Report\"
        pathImg64 = appPath & "Img64\"
        pathImg = appPath & "Img\"
        pathLog = appPath & "Log\"
        pathIcon = appPath & "Icon\"
        pathMap = appPath & "Map\"

        writeLog("Check & Create Directory " & pathTemp)
        If IO.Directory.Exists(pathTemp) = False Then IO.Directory.CreateDirectory(pathTemp)
        writeLog("Check & Create Directory " & pathSetting)
        If IO.Directory.Exists(pathSetting) = False Then IO.Directory.CreateDirectory(pathSetting)
        writeLog("Check & Create Directory " & pathReport)
        If IO.Directory.Exists(pathReport) = False Then IO.Directory.CreateDirectory(pathReport)
        writeLog("Check & Create Directory " & pathImg64)
        If IO.Directory.Exists(pathImg64) = False Then IO.Directory.CreateDirectory(pathImg64)
        writeLog("Check & Create Directory " & pathImg)
        If IO.Directory.Exists(pathImg) = False Then IO.Directory.CreateDirectory(pathImg)
        writeLog("Check & Create Directory " & pathLog)
        If IO.Directory.Exists(pathLog) = False Then IO.Directory.CreateDirectory(pathLog)
        writeLog("Check & Create Directory " & pathIcon)
        If IO.Directory.Exists(pathIcon) = False Then IO.Directory.CreateDirectory(pathIcon)
        writeLog("Check & Create Directory " & pathMap)
        If IO.Directory.Exists(pathMap) = False Then IO.Directory.CreateDirectory(pathMap)
    End Sub

    Public Function isLocalhost() As Boolean
        Dim retval As Boolean = False
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = Dns.GetHostName()
        strIPAddress = Dns.GetHostEntry(strHostName).AddressList(0).ToString()
        Dim str123 As String = ""
        Dim str12 As String = ""

        Dim tmpsvr As String = dbsvr
        Dim currsvr As String = dbsvr
        If tmpsvr.Contains("\") Then
            tmpsvr = tmpsvr.Split("\")(0)
            If tmpsvr.Contains(".") Then
                Dim tmpstr As String = tmpsvr.Replace(".", "")
                If IsNumeric(tmpstr) = False Then
                    For i As Integer = 0 To System.Net.Dns.GetHostAddresses(tmpsvr).Length - 1
                        If System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString.Contains(".") Then
                            currsvr = System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString
                        End If
                    Next
                End If
            End If
        Else
            If tmpsvr.Contains(".") Then
                Dim tmpstr As String = tmpsvr.Replace(".", "")
                If IsNumeric(tmpstr) = False Then
                    For i As Integer = 0 To System.Net.Dns.GetHostAddresses(tmpsvr).Length - 1
                        currsvr = System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString
                    Next
                End If
            Else
                For i As Integer = 0 To System.Net.Dns.GetHostAddresses(tmpsvr).Length - 1
                    currsvr = System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString
                Next
            End If
        End If
        If currsvr.Contains(".") Then
            str123 = currsvr.Split(".")(0) & "." & currsvr.Split(".")(1) & "." & currsvr.Split(".")(2) & "."
            str12 = currsvr.Split(".")(0) & "." & currsvr.Split(".")(1) & "."
        End If

        If currsvr = "127.0.0.1" Then
            strIPAddress = "127.0.0.1"
        Else
            Dim isFound As Boolean = False
            For i As Integer = 0 To Dns.GetHostEntry(strHostName).AddressList.Length - 1
                If Dns.GetHostEntry(strHostName).AddressList(i).ToString.Contains(str123) Then
                    strIPAddress = Dns.GetHostEntry(strHostName).AddressList(i).ToString
                    isFound = True
                    Exit For
                End If
            Next
            If isFound = False Then
                For i As Integer = 0 To System.Net.Dns.GetHostEntry(strHostName).AddressList.Length - 1
                    If System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString.Contains(str12) Then
                        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString
                        isFound = True
                        Exit For
                    End If
                Next
            End If
        End If

        If (strIPAddress = currsvr) Then
            retval = True
        Else
            retval = False
        End If
        Return retval
    End Function

    Public Function getIPPublic() As String
        Dim outputIP As System.Net.IPAddress
        Using wClient As New System.Net.WebClient
            wClient.Headers("User-Agent") = "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0)(compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)"
            Dim myIP As String = "0.0.0.0"
            Try
                myIP = wClient.DownloadString("http://diznet.co.id/getippublic.php")
            Catch ex As Exception
            End Try
            outputIP = System.Net.IPAddress.Parse(myIP)
        End Using
        Return outputIP.ToString
    End Function

    Public Enum ipaddparam
        Host = 1
        IP = 2
    End Enum

    Public Function getIPAddress(ByVal param As ipaddparam) As String
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()
        Dim str123 As String = ""
        Dim str12 As String = ""
        Dim str1 As String = ""

        Dim tmpsvr As String = dbsvr
        Dim currsvr As String = dbsvr
        If tmpsvr.Contains("\") Then
            tmpsvr = tmpsvr.Split("\")(0)
            If tmpsvr.Contains(".") Then
                Dim tmpstr As String = tmpsvr.Replace(".", "")
                If IsNumeric(tmpstr) = False Then
                    For i As Integer = 0 To System.Net.Dns.GetHostAddresses(tmpsvr).Length - 1
                        If System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString.Contains(".") Then
                            currsvr = System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString
                        End If
                    Next
                End If
            End If
        Else
            If tmpsvr.Contains(".") Then
                Dim tmpstr As String = tmpsvr.Replace(".", "")
                If IsNumeric(tmpstr) = False Then
                    For i As Integer = 0 To System.Net.Dns.GetHostAddresses(tmpsvr).Length - 1
                        currsvr = System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString
                    Next
                End If
            Else
                For i As Integer = 0 To System.Net.Dns.GetHostAddresses(tmpsvr).Length - 1
                    currsvr = System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString
                Next
            End If
        End If
        If currsvr.Contains(".") Then
            str123 = currsvr.Split(".")(0) & "." & currsvr.Split(".")(1) & "." & currsvr.Split(".")(2) & "."
            str12 = currsvr.Split(".")(0) & "." & currsvr.Split(".")(1) & "."
            str1 = currsvr.Split(".")(0) & "."
        End If

        If currsvr = "127.0.0.1" Then
            strIPAddress = "127.0.0.1"
        Else
            Dim isFound As Boolean = False
            For i As Integer = 0 To System.Net.Dns.GetHostEntry(strHostName).AddressList.Length - 1
                If System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString.Contains(str123) Then
                    strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString
                    isFound = True
                    Exit For
                End If
            Next
            If isFound = False Then
                For i As Integer = 0 To System.Net.Dns.GetHostEntry(strHostName).AddressList.Length - 1
                    If System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString.Contains(str12) Then
                        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString
                        isFound = True
                        Exit For
                    End If
                Next
            End If
            If isFound = False Then
                For i As Integer = 0 To System.Net.Dns.GetHostEntry(strHostName).AddressList.Length - 1
                    If System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString.Contains(str1) Then
                        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString
                        isFound = True
                        Exit For
                    End If
                Next
            End If
        End If

        Dim retval As String = ""
        If param = ipaddparam.Host Then
            retval = strHostName
        ElseIf param = ipaddparam.IP Then
            retval = strIPAddress
        End If
        Return retval
    End Function

    Public Function getMacAddress(ByVal ipAddress As String) As String
        Dim retval As String = ""
        Dim nics() As System.Net.NetworkInformation.NetworkInterface = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces
        For i As Integer = 0 To nics.Length - 1
            For a As Integer = 0 To nics(i).GetIPProperties.UnicastAddresses.Count - 1
                If nics(i).GetIPProperties.UnicastAddresses.Item(a).Address.ToString = ipAddress Then
                    retval = nics(i).GetPhysicalAddress.ToString
                End If
            Next
        Next
        Return retval
    End Function

    Public Function isRestrictedString(srcString As String, dbstr As String) As Boolean
        Dim retval As Boolean = False
        Dim sqls As New SQLs(dbstr)
        Dim str As String = srcString.Replace(" ", "")
        sqls.DMLQuery("select idrestrictedstring from restrictedstring where stringname='" & str & "' and isdeleted=0", "cekstr")
        If sqls.getDataSet("cekstr") > 0 Then
            retval = True
        End If
        Return retval
    End Function

    Public Function HttpPOSTRequestSelect(ByVal url As String, Optional ByVal mparam As List(Of String) = Nothing, Optional ByVal mvalue As List(Of String) = Nothing) As String
        System.Net.ServicePointManager.Expect100Continue = False

        Dim retval As String = ""
        If mparam IsNot Nothing Then
            If mparam.Count <> mvalue.Count Then
                MsgBox("List Parameter is not equal with List Value Parameter")
                Return False
                Exit Function
            End If
        End If

        Dim client As New Net.WebClient
        client.Proxy = Nothing
        Dim reqparm As New Specialized.NameValueCollection
        If mparam IsNot Nothing Then
            For i As Integer = 0 To mparam.Count - 1
                reqparm.Add(mparam(i), mvalue(i))
            Next
        Else
            reqparm.Add("test", "aaaa")
        End If

        Dim strdebug As String = "" '"[{"
        Try
            client.Headers.Add("user-agent", "Datacube Engine (diznet)")
            If mparam IsNot Nothing Then
                For i As Integer = 0 To mparam.Count - 1
                strdebug &= mparam(i) & ":" & mvalue(i)
                If i <> mparam.Count - 1 Then
                    strdebug &= vbCrLf
                End If
            Next
            End If
            'strdebug &= "}]"
            'strdebug = strdebug.Replace("`", Chr(34))
            'writeLog(strdebug)
            'writeLog(url)
            'Clipboard.SetText(strdebug)
            Dim responsebytes As Byte() = client.UploadValues(url, "POST", reqparm)
            Dim responsebody As String = (New Text.UTF8Encoding).GetString(responsebytes) '(New Text.UTF8Encoding).GetString(responsebytes)
            If responsebody = "" Then writeLog("kosong") Else writeLog(responsebody)
            retval = responsebody
        Catch ex As Exception
            'MsgBox(url & vbCrLf & ex.Message)
            'dizMsgbox(ex.Message, dizMsgboxStyle.Kesalahan)
            'Environment.Exit(0)
        End Try
        client.Dispose()
        Return retval
    End Function

    Public Function HttpPOSTRequestInsert(ByVal url As String, Optional ByVal mparam As List(Of String) = Nothing, Optional ByVal mvalue As List(Of String) = Nothing) As String
        System.Net.ServicePointManager.Expect100Continue = False

        Dim retval As String = ""
        If mparam IsNot Nothing Then
            If mparam.Count <> mvalue.Count Then
                MsgBox("List Parameter is not equal with List Value Parameter")
                Return False
                Exit Function
            End If
        End If
        Dim client As New Net.WebClient
        client.Proxy = Nothing
        Dim reqparm As New Specialized.NameValueCollection
        If mparam IsNot Nothing Then
            For i As Integer = 0 To mparam.Count - 1
                reqparm.Add(mparam(i), mvalue(i))
            Next
        Else
            reqparm.Add("test", "aaaa")
        End If
        Try
            client.Headers.Add("user-agent", "Datacube Engine (diznet)")
            Dim strdebug As String = "" ' "[{"
            If mparam IsNot Nothing Then
                For i As Integer = 0 To mparam.Count - 1
                    strdebug &= mparam(i) & ":" & mvalue(i)
                    If i <> mparam.Count - 1 Then
                        strdebug &= vbCrLf
                    End If
                Next
            End If
            'strdebug &= "}]"
            'strdebug = strdebug.Replace("`", Chr(34))
            'writeLog(strdebug)
            'writeLog(url)
            Dim responsebytes As Byte() = client.UploadValues(url, "POST", reqparm)
            Dim responsebody As String = (New Text.UTF8Encoding).GetString(responsebytes) '(New Text.UTF8Encoding).GetString(responsebytes)
            If responsebody = "" Then writeLog("kosong") Else writeLog(responsebody)
            'MsgBox(responsebody)
            retval = responsebody
        Catch ex As Exception
            'MsgBox(url & vbCrLf & ex.Message)
            'dizMsgbox(ex.Message, dizMsgboxStyle.Kesalahan)
            'Environment.Exit(0)
        End Try
        client.Dispose()
        Return retval
    End Function

    Public Enum databaseType
        mySql = 1
        sqLite = 2
        'Oracle = 3
        sqlServer2000 = 4
        sqlServer2005 = 5
        sqlServer2008 = 6
        sqlServer2012 = 7
    End Enum

    Public Enum iconNotif
        info = 1
        warning = 2
        critical = 3
    End Enum

    Public Sub writeLog(ByVal logname As String, ByVal content As String)
        Dim pathfile As String = pathLog & "\" & logname
        If IO.File.Exists(pathfile) = True Then
            IO.File.AppendAllText(pathfile, Format(nowTime, "HH:mm:ss") & "|" & content)
        Else
            IO.File.WriteAllText(pathfile, Format(nowTime, "HH:mm:ss") & "|" & content)
        End If
    End Sub

    Public Sub writeLog(ByVal content As String)
        If IO.Directory.Exists(pathLog) = False Then
            IO.Directory.CreateDirectory(pathLog)
            writeLog("Create Directory " & pathLog)
        End If
        Dim pathfile As String = pathLog & Format(nowTime, "yyyyMMdd") & ".log"
        If IO.File.Exists(pathfile) = True Then
            IO.File.AppendAllText(pathfile, vbCrLf & content)
        Else
            IO.File.WriteAllText(pathfile, content)
        End If
    End Sub

    Public Sub checkFieldMaxLength(ByVal dbstring As String, ByRef PanelName As Panel, ByVal TableName As String)
        For Each ctrl As Control In PanelName.Controls
            If ctrl.Tag <> "" Then
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select c.max_length,c.is_nullable from sys.types t left join sys.all_columns c on t.system_type_id=c.system_type_id left join sys.tables b on b.object_id=c.object_id where c.name='" & ctrl.Tag & "' and b.name='" & TableName & "'", "cekType")
                If sqls.getDataSet("cekType") > 0 Then
                    If ctrl.ToString.Contains("System.Windows.Forms.TextBox") Then
                        CType(ctrl, TextBox).MaxLength = sqls.getDataSet("cekType", 0, 0)
                    ElseIf ctrl.ToString.Contains("System.Windows.Forms.NumericUpDown") Then
                        Dim str As String = ""
                        For i As Integer = 0 To CInt(sqls.getDataSet("cekType", 0, 0)) - 1
                            str &= "9"
                        Next
                        CType(ctrl, NumericUpDown).Maximum = CInt(str) 'sqls.getDataSet("cekType", 0, 0)
                    ElseIf ctrl.ToString.Contains("System.Windows.Forms.ComboBox") Then
                        CType(ctrl, ComboBox).SelectedIndex = 0
                    ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.TextEdit") Then
                        CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.MaxLength = sqls.getDataSet("cekType", 0, 0)
                    ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.MemoEdit") Then
                        CType(ctrl, DevExpress.XtraEditors.MemoEdit).Properties.MaxLength = sqls.getDataSet("cekType", 0, 0)
                    ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.DateEdit") Then
                        CType(ctrl, DevExpress.XtraEditors.DateEdit).EditValue = nowTime
                    ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.TimeEdit") Then
                        CType(ctrl, DevExpress.XtraEditors.TimeEdit).EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
                    ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.CheckedComboBoxEdit") Then
                        For i As Integer = 0 To CType(ctrl, DevExpress.XtraEditors.CheckedComboBoxEdit).Properties.Items.Count - 1
                            CType(ctrl, DevExpress.XtraEditors.CheckedComboBoxEdit).Properties.Items.Item(i).CheckState = CheckState.Unchecked
                        Next
                    ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.ToggleSwitch") Then
                        CType(ctrl, DevExpress.XtraEditors.ToggleSwitch).IsOn = False
                    ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.SpinEdit") Then
                        Dim str As String = ""
                        For i As Integer = 0 To CInt(sqls.getDataSet("cekType", 0, 0)) - 1
                            str &= "9"
                        Next
                        CType(ctrl, DevExpress.XtraEditors.SpinEdit).Properties.MaxValue = CLng(str)
                        CType(ctrl, DevExpress.XtraEditors.SpinEdit).Properties.MaxLength = sqls.getDataSet("cekType", 0, 0)
                    End If
                    If sqls.getDataSet("cekType", 0, 1) = "False" Then
                        If ctrl.Tag.ToString.Chars(ctrl.Tag.ToString.Length - 1) <> "*" Then
                            ctrl.Tag &= "*"
                        End If
                    Else
                        If ctrl.ToString.Contains("DevExpress.XtraEditors.TextEdit") Then
                            CType(ctrl, DevExpress.XtraEditors.TextEdit).EditValue = Nothing
                        ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.MemoEdit") Then
                            CType(ctrl, DevExpress.XtraEditors.MemoEdit).EditValue = Nothing
                        ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.DateEdit") Then
                            CType(ctrl, DevExpress.XtraEditors.DateEdit).EditValue = Nothing
                        ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.TimeEdit") Then
                            CType(ctrl, DevExpress.XtraEditors.TimeEdit).EditValue = Nothing
                        End If
                    End If
                End If
            End If
        Next
    End Sub

    Public Sub checkFieldMaxLength(ByVal dbstring As String, ByRef PanelName As TableLayoutPanel, ByVal TableName As String)
        For Each ctrl As Control In PanelName.Controls
            Try
                If ctrl.Tag <> "" Then
                    Dim sqls As New SQLs(dbstring)
                    sqls.DMLQuery("select c.max_length,c.is_nullable from sys.types t left join sys.all_columns c on t.system_type_id=c.system_type_id left join sys.tables b on b.object_id=c.object_id where c.name='" & ctrl.Tag & "' and b.name='" & TableName & "'", "cekType")
                    If sqls.getDataSet("cekType") > 0 Then
                        If ctrl.ToString.Contains("System.Windows.Forms.TextBox") Then
                            CType(ctrl, TextBox).MaxLength = sqls.getDataSet("cekType", 0, 0)
                        ElseIf ctrl.ToString.Contains("System.Windows.Forms.NumericUpDown") Then
                            Dim str As String = ""
                            For i As Integer = 0 To CInt(sqls.getDataSet("cekType", 0, 0)) - 1
                                str &= "9"
                            Next
                            CType(ctrl, NumericUpDown).Maximum = CInt(str) 'sqls.getDataSet("cekType", 0, 0)
                        ElseIf ctrl.ToString.Contains("System.Windows.Forms.ComboBox") Then
                            CType(ctrl, ComboBox).SelectedIndex = 0
                        ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.TextEdit") Then
                            CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.MaxLength = sqls.getDataSet("cekType", 0, 0)
                        ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.MemoEdit") Then
                            CType(ctrl, DevExpress.XtraEditors.MemoEdit).Properties.MaxLength = sqls.getDataSet("cekType", 0, 0)
                        ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.TimeEdit") Then
                            CType(ctrl, DevExpress.XtraEditors.TimeEdit).EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
                        ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.DateEdit") Then
                            CType(ctrl, DevExpress.XtraEditors.DateEdit).EditValue = nowTime
                        ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.CheckedComboBoxEdit") Then
                            For i As Integer = 0 To CType(ctrl, DevExpress.XtraEditors.CheckedComboBoxEdit).Properties.Items.Count - 1
                                CType(ctrl, DevExpress.XtraEditors.CheckedComboBoxEdit).Properties.Items.Item(i).CheckState = CheckState.Unchecked
                            Next
                        ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.ToggleSwitch") Then
                            CType(ctrl, DevExpress.XtraEditors.ToggleSwitch).IsOn = False
                        ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.SpinEdit") Then
                            Dim str As String = ""
                            For i As Integer = 0 To CInt(sqls.getDataSet("cekType", 0, 0)) - 1
                                str &= "9"
                            Next
                            CType(ctrl, DevExpress.XtraEditors.SpinEdit).Properties.MaxValue = CLng(str)
                            CType(ctrl, DevExpress.XtraEditors.SpinEdit).Properties.MaxLength = sqls.getDataSet("cekType", 0, 0)
                        End If
                        If sqls.getDataSet("cekType", 0, 1) = "False" Then
                            If ctrl.Tag.ToString.Chars(ctrl.Tag.ToString.Length - 1) <> "*" Then
                                ctrl.Tag &= "*"
                                'MsgBox(ctrl.Tag)
                            End If
                        Else
                            If ctrl.ToString.Contains("DevExpress.XtraEditors.TextEdit") Then
                                CType(ctrl, DevExpress.XtraEditors.TextEdit).EditValue = Nothing
                            ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.MemoEdit") Then
                                CType(ctrl, DevExpress.XtraEditors.MemoEdit).EditValue = Nothing
                            ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.DateEdit") Then
                                CType(ctrl, DevExpress.XtraEditors.DateEdit).EditValue = Nothing
                            ElseIf ctrl.ToString.Contains("DevExpress.XtraEditors.TimeEdit") Then
                                CType(ctrl, DevExpress.XtraEditors.TimeEdit).EditValue = Nothing
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub

    Public ctrlname As String = ""
    Public Function checkEntry(ByVal ObjPanel As TableLayoutPanel) As Boolean
        Dim retVal As Boolean = True
        ctrlName = ""
        For Each a As Object In ObjPanel.Controls
            If a.Enabled = True Then
                Try
                    If Not a.Tag Is Nothing Then
                        If a.Tag.ToString.Contains("*") Then
                            If CType(a, Control).Visible = True Or CType(a, Control).BackColor = justRead Or (CType(a, Control).Visible = True And CType(a, Control).BackColor = justRead) Then
                                If a.ToString.Contains("System.Windows.Forms.TextBox") Then
                                    If Not a.tag Is Nothing Then
                                        If a.tag.ToString.Contains("telepon") Or a.tag.ToString.Contains("phone") Then
                                            If IsNumeric(a.text) = False Then
                                                retVal = False
                                                ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                'msgBox(a.Name & vbCrLf & a.Tag)
                                            End If
                                        ElseIf a.tag.ToString.Contains("email") Then
                                            If a.text.ToString.Contains(".") And a.text.ToString.Contains("@") Then
                                                If a.text.ToString.Split("@").Length = 2 Then
                                                    Dim tmp() As String = a.text.ToString.Split("@")
                                                    If tmp(0).Split(".").Length > 1 Then
                                                        retVal = False
                                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                        'msgBox(a.Name & vbCrLf & a.Tag)
                                                    End If
                                                    If tmp(1).Split(".").Length <> 2 Then
                                                        retVal = False
                                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                                    End If
                                                Else
                                                    retVal = False
                                                    ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                    'MsgBox(a.Name & vbCrLf & a.Tag)
                                                End If
                                            Else
                                                retVal = False
                                                ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                'MsgBox(a.Name & vbCrLf & a.Tag)
                                            End If
                                        Else
                                            If a.text = "" Then
                                                retVal = False
                                                ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                'MsgBox(a.Name & vbCrLf & a.Tag)
                                            End If
                                        End If
                                    End If
                                ElseIf a.ToString.Contains("System.Windows.Forms.ComboBox") Then
                                    If a.text.length = 0 Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    End If
                                ElseIf a.ToString.Contains("System.Windows.Forms.NumericUpDown") Then
                                    If a.value = a.minimum Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    End If
                                ElseIf a.ToString.Contains("System.Windows.Forms.DateTimePicker") Then
                                    If a.value = Now Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    End If
                                ElseIf a.ToString.Contains("System.Windows.Forms.CheckBox") Then
                                    If a.checked = False Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    End If
                                ElseIf a.ToString.Contains("DevExpress.XtraEditors.TextEdit") Then
                                    If Not a.tag Is Nothing Then
                                        If a.tag.ToString.Contains("telepon") Or a.tag.ToString.Contains("phone") Then
                                            If IsNumeric(a.text) = False Then
                                                retVal = False
                                                ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                'MsgBox(a.Name & vbCrLf & a.Tag)
                                            End If
                                        ElseIf a.tag.ToString.Contains("email") Then
                                            If a.text.ToString.Contains(".") And a.text.ToString.Contains("@") Then
                                                If a.text.ToString.Split("@").Length = 2 Then
                                                    Dim tmp() As String = a.text.ToString.Split("@")
                                                    If tmp(0).Split(".").Length > 1 Then
                                                        retVal = False
                                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                                    End If
                                                    If tmp(1).Split(".").Length <> 2 Then
                                                        retVal = False
                                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                                    End If
                                                Else
                                                    retVal = False
                                                    ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                    'MsgBox(a.Name & vbCrLf & a.Tag)
                                                End If
                                            Else
                                                retVal = False
                                                ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                'MsgBox(a.Name & vbCrLf & a.Tag)
                                            End If
                                        Else
                                            If CType(a, DevExpress.XtraEditors.TextEdit).Text = "" Then
                                                retVal = False
                                                ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                'MsgBox(a.Name & vbCrLf & a.Tag)
                                            End If
                                        End If
                                    End If
                                ElseIf a.ToString.Contains("DevExpress.XtraEditors.LookUpEdit") Then
                                    If CType(a, DevExpress.XtraEditors.LookUpEdit).EditValue Is Nothing Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    End If
                                ElseIf a.ToString.Contains("DevExpress.XtraEditors.SpinEdit") Then
                                    If CType(a, DevExpress.XtraEditors.SpinEdit).Value = 0 Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    End If
                                ElseIf a.ToString.Contains("DevExpress.XtraEditors.MemoEdit") Then
                                    If CType(a, DevExpress.XtraEditors.MemoEdit).Text = "" Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    Else
                                        If CType(a, DevExpress.XtraEditors.MemoEdit).Text.Replace(" ", "") = "" Then
                                            retVal = False
                                            ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                            'MsgBox(a.Name & vbCrLf & a.Tag)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                    'MsgBox(a.Name & vbCrLf & a.Tag)
                End Try
            End If
        Next
        Return retVal
    End Function

    Public Function checkEntry(ByVal ObjPanel As Panel) As Boolean
        Dim retVal As Boolean = True
        ctrlName = ""
        For Each a As Object In ObjPanel.Controls
            If a.Enabled = True Then
                Try
                    If Not a.Tag Is Nothing Then
                        If a.Tag.ToString.Contains("*") Then
                            If CType(a, Control).Visible = True Or CType(a, Control).BackColor = justRead Or (CType(a, Control).Visible = True And CType(a, Control).BackColor = justRead) Then
                                If a.ToString.Contains("System.Windows.Forms.TextBox") Then
                                    If Not a.tag Is Nothing Then
                                        If a.tag.ToString.Contains("telepon") Or a.tag.ToString.Contains("phone") Then
                                            If IsNumeric(a.text) = False Then
                                                retVal = False
                                                ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                'MsgBox(a.Name & vbCrLf & a.Tag)
                                            End If
                                        ElseIf a.tag.ToString.Contains("email") Then
                                            If a.text.ToString.Contains(".") And a.text.ToString.Contains("@") Then
                                                If a.text.ToString.Split("@").Length = 2 Then
                                                    Dim tmp() As String = a.text.ToString.Split("@")
                                                    If tmp(0).Split(".").Length > 1 Then
                                                        retVal = False
                                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                                    End If
                                                    If tmp(1).Split(".").Length <> 2 Then
                                                        retVal = False
                                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                                    End If
                                                Else
                                                    retVal = False
                                                    ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                    'MsgBox(a.Name & vbCrLf & a.Tag)
                                                End If
                                            Else
                                                retVal = False
                                                ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                'MsgBox(a.Name & vbCrLf & a.Tag)
                                            End If
                                        Else
                                            If a.text = "" Then
                                                retVal = False
                                                ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                'MsgBox(a.Name & vbCrLf & a.Tag)
                                            End If
                                        End If
                                    End If
                                ElseIf a.ToString.Contains("System.Windows.Forms.ComboBox") Then
                                    If a.text.length = 0 Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    End If
                                ElseIf a.ToString.Contains("System.Windows.Forms.NumericUpDown") Then
                                    If a.value = a.minimum Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    End If
                                ElseIf a.ToString.Contains("System.Windows.Forms.DateTimePicker") Then
                                    If a.value = Now Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    End If
                                ElseIf a.ToString.Contains("System.Windows.Forms.CheckBox") Then
                                    If a.checked = False Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    End If
                                ElseIf a.ToString.Contains("DevExpress.XtraEditors.TextEdit") Then
                                    If Not a.tag Is Nothing Then
                                        If a.tag.ToString.Contains("telepon") Or a.tag.ToString.Contains("phone") Then
                                            If IsNumeric(a.text) = False Then
                                                retVal = False
                                                ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                'MsgBox(a.Name & vbCrLf & a.Tag)
                                            End If
                                        ElseIf a.tag.ToString.Contains("email") Then
                                            If a.text.ToString.Contains(".") And a.text.ToString.Contains("@") Then
                                                If a.text.ToString.Split("@").Length = 2 Then
                                                    Dim tmp() As String = a.text.ToString.Split("@")
                                                    If tmp(0).Split(".").Length > 1 Then
                                                        retVal = False
                                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                                    End If
                                                    If tmp(1).Split(".").Length <> 2 Then
                                                        retVal = False
                                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                                    End If
                                                Else
                                                    retVal = False
                                                    ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                    'MsgBox(a.Name & vbCrLf & a.Tag)
                                                End If
                                            Else
                                                retVal = False
                                                ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                'MsgBox(a.Name & vbCrLf & a.Tag)
                                            End If
                                        Else
                                            If CType(a, DevExpress.XtraEditors.TextEdit).Text = "" Then
                                                retVal = False
                                                ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                                'MsgBox(a.Name & vbCrLf & a.Tag)
                                            End If
                                        End If
                                    End If
                                ElseIf a.ToString.Contains("DevExpress.XtraEditors.LookUpEdit") Then
                                    If CType(a, DevExpress.XtraEditors.LookUpEdit).EditValue Is Nothing Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    End If
                                ElseIf a.ToString.Contains("DevExpress.XtraEditors.SpinEdit") Then
                                    If CType(a, DevExpress.XtraEditors.SpinEdit).Value = 0 Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    End If
                                ElseIf a.ToString.Contains("DevExpress.XtraEditors.MemoEdit") Then
                                    If CType(a, DevExpress.XtraEditors.MemoEdit).Text = "" Then
                                        retVal = False
                                        ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                        'MsgBox(a.Name & vbCrLf & a.Tag)
                                    Else
                                        If CType(a, DevExpress.XtraEditors.MemoEdit).Text.Replace(" ", "") = "" Then
                                            retVal = False
                                            ctrlname = String.Join(",", New String() {ctrlname, a.tag})
                                            'MsgBox(a.Name & vbCrLf & a.Tag)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                    'MsgBox(a.Name & vbCrLf & a.Tag)
                End Try
            End If
        Next
        Return retVal
    End Function

    Public Sub kosongkanIsian(ByVal objpanel As Panel)
        For Each a As Object In objpanel.Controls
            Try
                If a.ToString = "System.Windows.Forms.TextBox" Then
                    CType(a, Windows.Forms.TextBox).Text = ""
                ElseIf a.ToString = "System.Windows.Forms.ComboBox" Then
                    Try
                        CType(a, Windows.Forms.ComboBox).SelectedValue = Nothing
                    Catch ex As Exception
                    End Try
                ElseIf a.ToString = "System.Windows.Forms.NumericUpDown" Then
                    CType(a, Windows.Forms.NumericUpDown).Value = CType(a, Windows.Forms.NumericUpDown).Minimum
                ElseIf a.ToString = "System.Windows.Forms.DateTimePicker" Then
                    CType(a, Windows.Forms.DateTimePicker).Value = CType(a, Windows.Forms.DateTimePicker).MinDate
                ElseIf a.ToString = "System.Windows.Forms.CheckBox" Then
                    CType(a, Windows.Forms.CheckBox).Checked = False
                ElseIf a.ToString = "DevExpress.XtraEditors.DateEdit" Then
                    If CType(a, DevExpress.XtraEditors.DateEdit).Tag.ToString.Contains("*") Then
                        CType(a, DevExpress.XtraEditors.DateEdit).EditValue = Now
                    Else
                        CType(a, DevExpress.XtraEditors.DateEdit).EditValue = Nothing
                    End If
                ElseIf a.ToString = "DevExpress.XtraEditors.TextEdit" Then
                    CType(a, DevExpress.XtraEditors.TextEdit).EditValue = Nothing
                ElseIf a.ToString = "DevExpress.XtraEditors.MemoEdit" Then
                    CType(a, DevExpress.XtraEditors.MemoEdit).Text = ""
                    CType(a, DevExpress.XtraEditors.MemoEdit).EditValue = Nothing
                ElseIf a.ToString = "DevExpress.XtraEditors.LookUpEdit" Then
                    CType(a, DevExpress.XtraEditors.LookUpEdit).EditValue = Nothing
                ElseIf a.ToString = "DevExpress.XtraEditors.SearchLookUpEdit" Then
                    CType(a, DevExpress.XtraEditors.SearchLookUpEdit).EditValue = Nothing
                ElseIf a.ToString = "DevExpress.XtraEditors.SpinEdit" Then
                    CType(a, DevExpress.XtraEditors.SpinEdit).Value = CType(a, DevExpress.XtraEditors.SpinEdit).Properties.MinValue
                ElseIf a.ToString = "DevExpress.XtraEditors.CheckEdit" Then
                    CType(a, DevExpress.XtraEditors.CheckEdit).EditValue = False
                ElseIf a.ToString = "DevExpress.XtraEditors.ToggleSwitch" Then
                    CType(a, DevExpress.XtraEditors.ToggleSwitch).IsOn = False
                ElseIf a.ToString = "DevExpress.XtraEditors.TimeEdit" Then
                    If CType(a, DevExpress.XtraEditors.TimeEdit).Tag.ToString.Contains("*") Then
                        CType(a, DevExpress.XtraEditors.TimeEdit).EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
                    Else
                        CType(a, DevExpress.XtraEditors.TimeEdit).EditValue = Nothing
                    End If
                ElseIf a.ToString = "DevExpress.XtraEditors.CheckedComboBoxEdit" Then
                    For i As Integer = 0 To CType(a, DevExpress.XtraEditors.CheckedComboBoxEdit).Properties.Items.Count - 1
                        CType(a, DevExpress.XtraEditors.CheckedComboBoxEdit).Properties.Items.Item(i).CheckState = CheckState.Unchecked
                    Next
                ElseIf a.ToString = "System.Windows.Forms.TableLayoutPanel" Then
                    kosongkanIsian(CType(a, System.Windows.Forms.TableLayoutPanel))
                ElseIf a.ToString = "System.Windows.Forms.Panel" Then
                    kosongkanIsian(CType(a, System.Windows.Forms.Panel))
                End If
            Catch ex As Exception
                'MsgBox(a.name & vbCrLf & ex.Message)
            End Try
        Next
    End Sub

    Public Sub kosongkanIsian(ByVal objpanel As TableLayoutPanel)
        For Each a As Object In objpanel.Controls
            Try
                If a.ToString = "System.Windows.Forms.TextBox" Then
                    CType(a, Windows.Forms.TextBox).Text = ""
                ElseIf a.ToString = "System.Windows.Forms.ComboBox" Then
                    Try
                        CType(a, Windows.Forms.ComboBox).SelectedValue = Nothing
                    Catch ex As Exception
                    End Try
                ElseIf a.ToString = "System.Windows.Forms.NumericUpDown" Then
                    CType(a, Windows.Forms.NumericUpDown).Value = CType(a, Windows.Forms.NumericUpDown).Minimum
                ElseIf a.ToString = "System.Windows.Forms.DateTimePicker" Then
                    CType(a, Windows.Forms.DateTimePicker).Value = CType(a, Windows.Forms.DateTimePicker).MinDate
                ElseIf a.ToString = "System.Windows.Forms.CheckBox" Then
                    CType(a, Windows.Forms.CheckBox).Checked = False
                ElseIf a.ToString = "DevExpress.XtraEditors.DateEdit" Then
                    If CType(a, DevExpress.XtraEditors.DateEdit).Tag.ToString.Contains("*") Then
                        CType(a, DevExpress.XtraEditors.DateEdit).EditValue = Now
                    Else
                        CType(a, DevExpress.XtraEditors.DateEdit).EditValue = Nothing
                    End If
                ElseIf a.ToString = "DevExpress.XtraEditors.TextEdit" Then
                    CType(a, DevExpress.XtraEditors.TextEdit).EditValue = Nothing
                ElseIf a.ToString = "DevExpress.XtraEditors.MemoEdit" Then
                    CType(a, DevExpress.XtraEditors.MemoEdit).Text = ""
                    CType(a, DevExpress.XtraEditors.MemoEdit).EditValue = Nothing
                ElseIf a.ToString = "DevExpress.XtraEditors.LookUpEdit" Then
                    CType(a, DevExpress.XtraEditors.LookUpEdit).EditValue = Nothing
                ElseIf a.ToString = "DevExpress.XtraEditors.SearchLookUpEdit" Then
                    CType(a, DevExpress.XtraEditors.SearchLookUpEdit).EditValue = Nothing
                ElseIf a.ToString = "DevExpress.XtraEditors.SpinEdit" Then
                    CType(a, DevExpress.XtraEditors.SpinEdit).Value = CType(a, DevExpress.XtraEditors.SpinEdit).Properties.MinValue
                ElseIf a.ToString = "DevExpress.XtraEditors.CheckEdit" Then
                    CType(a, DevExpress.XtraEditors.CheckEdit).EditValue = False
                ElseIf a.ToString = "DevExpress.XtraEditors.ToggleSwitch" Then
                    CType(a, DevExpress.XtraEditors.ToggleSwitch).IsOn = False
                ElseIf a.ToString = "DevExpress.XtraEditors.TimeEdit" Then
                    If CType(a, DevExpress.XtraEditors.TimeEdit).Tag.ToString.Contains("*") Then
                        CType(a, DevExpress.XtraEditors.TimeEdit).EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
                    Else
                        CType(a, DevExpress.XtraEditors.TimeEdit).EditValue = Nothing
                    End If
                ElseIf a.ToString = "DevExpress.XtraEditors.CheckedComboBoxEdit" Then
                    For i As Integer = 0 To CType(a, DevExpress.XtraEditors.CheckedComboBoxEdit).Properties.Items.Count - 1
                        CType(a, DevExpress.XtraEditors.CheckedComboBoxEdit).Properties.Items.Item(i).CheckState = CheckState.Unchecked
                    Next
                ElseIf a.ToString = "System.Windows.Forms.TableLayoutPanel" Then
                    kosongkanIsian(CType(a, System.Windows.Forms.TableLayoutPanel))
                ElseIf a.ToString = "System.Windows.Forms.Panel" Then
                    kosongkanIsian(CType(a, System.Windows.Forms.Panel))
                End If
            Catch ex As Exception
                'MsgBox(a.name & vbCrLf & ex.Message)
            End Try
        Next
    End Sub

    Public Function NamaHari(ByVal param As DayOfWeek) As String
        Dim retval As String = ""
        If param = DayOfWeek.Sunday Then
            retval = "Minggu"
        ElseIf param = DayOfWeek.Monday Then
            retval = "Senin"
        ElseIf param = DayOfWeek.Tuesday Then
            retval = "Selasa"
        ElseIf param = DayOfWeek.Wednesday Then
            retval = "Rabu"
        ElseIf param = DayOfWeek.Thursday Then
            retval = "Kamis"
        ElseIf param = DayOfWeek.Friday Then
            retval = "Jumat"
        ElseIf param = DayOfWeek.Saturday Then
            retval = "Sabtu"
        End If
        Return retval
    End Function

    Public Function NamaBulan(ByVal intMonth As Integer) As String
        Dim retval As String = ""
        If intMonth = 1 Then
            retval = "Januari"
        ElseIf intMonth = 2 Then
            retval = "Februari"
        ElseIf intMonth = 3 Then
            retval = "Maret"
        ElseIf intMonth = 4 Then
            retval = "April"
        ElseIf intMonth = 5 Then
            retval = "Mei"
        ElseIf intMonth = 6 Then
            retval = "Juni"
        ElseIf intMonth = 7 Then
            retval = "Juli"
        ElseIf intMonth = 8 Then
            retval = "Agustus"
        ElseIf intMonth = 9 Then
            retval = "September"
        ElseIf intMonth = 10 Then
            retval = "Oktober"
        ElseIf intMonth = 11 Then
            retval = "November"
        ElseIf intMonth = 12 Then
            retval = "Desember"
        End If
        Return retval
    End Function

    Public Function Terbilang(ByVal nilai As Long) As String
        Dim retval As String = ""
        Dim bilangan As String() = {"", "satu", "dua", "tiga", "empat", "lima",
        "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas"}
        If nilai < 12 Then
            retval = " " & bilangan(nilai)
        ElseIf nilai < 20 Then
            retval = Terbilang(nilai - 10) & " belas"
        ElseIf nilai < 100 Then
            retval = (Terbilang(CInt((nilai \ 10))) & " puluh") + Terbilang(nilai Mod 10)
        ElseIf nilai < 200 Then
            retval = " seratus" & Terbilang(nilai - 100)
        ElseIf nilai < 1000 Then
            retval = (Terbilang(CInt((nilai \ 100))) & " ratus") + Terbilang(nilai Mod 100)
        ElseIf nilai < 2000 Then
            retval = " seribu" & Terbilang(nilai - 1000)
        ElseIf nilai < 1000000 Then
            retval = (Terbilang(CInt((nilai \ 1000))) & " ribu") + Terbilang(nilai Mod 1000)
        ElseIf nilai < 1000000000 Then
            retval = (Terbilang(CInt((nilai \ 1000000))) & " juta") + Terbilang(nilai Mod 1000000)
        ElseIf nilai < 1000000000000 Then
            retval = (Terbilang(CInt((nilai \ 1000000000))) & " milyar") + Terbilang(nilai Mod 1000000000)
        ElseIf nilai < 1000000000000000 Then
            retval = (Terbilang(CInt((nilai \ 1000000000000))) & " trilyun") + Terbilang(nilai Mod 1000000000000)
        Else
            retval = ""
        End If
        Return retval
    End Function

    Public Function generateno2(idunit As String, iddept As String, jenistransaksi As String, isbaru As Boolean) As KeyValuePair(Of String, String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select tt.idtransactiontype,tt.formatstring,tt.formatperiode,tt.positionnumber,tt.digitnumber,u.kode as kodeunit,d.kode as kodedept from transactiontype tt left join unit u on tt.idunit=u.idunit left join department d on tt.iddepartment=d.iddepartment where tt.jenistransaksi='" & jenistransaksi & "' and tt.idunit='" & idunit & "' and tt.iddepartment='" & iddept & "'", "getformat")

        If sqls.getDataSet("getformat") = 0 Then
            Dim idcomp As String = 0
            Dim kdtrans As String = ""
            Dim fmttrans As String = ""

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            idcomp = sqlscomp.getDataSet("CompID", 0, "value")

            sqls.DMLQuery("select top 1 convert(varchar,value) as value from sys_appsetting where variable='Kode" & jenistransaksi.Replace(" ", "") & "'", "getkd")
            If sqls.getDataSet("getkd") > 0 Then
                kdtrans = sqls.getDataSet("getkd", 0, "value")
            End If
            sqls.DMLQuery("select top 1 convert(varchar,value) as value from sys_appsetting where variable='Format" & jenistransaksi.Replace(" ", "") & "'", "getfrmt")
            If sqls.getDataSet("getfrmt") > 0 Then
                fmttrans = sqls.getDataSet("getfrmt", 0, "value")
            End If

            Dim dtsqls As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            Dim idtmp As String = GenerateGUID()

            field.AddRange(New String() {"idtransactiontype", "iddepartment", "idunit", "kodetransaksi", "jenistransaksi", "formatstring", "formatperiode", "positionnumber", "digitnumber", "idcompany"})
            value.AddRange(New Object() {idtmp, iddept, idunit, kdtrans, jenistransaksi, kdtrans & "/", fmttrans, "Belakang", 4, idcomp})
            dtsqls.datasetSave("transactiontype", idtmp, field, value, False)
        End If
        sqls = New SQLs(dbstring)
        sqls.DMLQuery("select tt.idtransactiontype,tt.formatstring,tt.formatperiode,tt.positionnumber,tt.digitnumber,u.kode as kodeunit,d.kode as kodedept from transactiontype tt left join unit u on tt.idunit=u.idunit left join department d on tt.iddepartment=d.iddepartment where tt.jenistransaksi='" & jenistransaksi & "' and tt.idunit='" & idunit & "' and tt.iddepartment='" & iddept & "'", "getformat")

        Dim idtrans As String = sqls.getDataSet("getformat", 0, "idtransactiontype")
        Dim formatstr As String = ""
        If idunit = "" Then
            formatstr = sqls.getDataSet("getformat", 0, "formatstring")
        ElseIf idunit <> "" And iddept = "" Then
            formatstr = sqls.getDataSet("getformat", 0, "kodeunit") & "/" & sqls.getDataSet("getformat", 0, "formatstring")
        ElseIf idunit <> "" And iddept <> "" Then
            formatstr = sqls.getDataSet("getformat", 0, "kodeunit") & "/" & sqls.getDataSet("getformat", 0, "kodedept") & "/" & sqls.getDataSet("getformat", 0, "formatstring")
        End If
        Dim formatperiode As String = sqls.getDataSet("getformat", 0, "formatperiode")
        Dim posnumber As String = sqls.getDataSet("getformat", 0, "positionnumber")
        Dim digitno As String = sqls.getDataSet("getformat", 0, "digitnumber")

        Dim notrans As String = generateno1(formatstr, formatperiode, posnumber, CLng(digitno), isbaru)
        Dim retval As New KeyValuePair(Of String, String)(idtrans, notrans)
        Return retval
    End Function

    Public Function generateno1(ByVal prefix As String, ByVal periodeformat As String, ByVal posisinomor As String, ByVal digitnomor As Long, isbaru As Boolean) As String
        Dim retval As String = ""
        Dim mysqls As New SQLs(dbstring)
        Dim tblname As String = prefix & Format(nowTime, periodeformat)
        mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & "'", "GetLast")
        Dim idgen As String = GenerateGUID()
        Dim formatStr As String = ""
        Dim currid As Integer = 0
        Dim currStrId As String = ""
        Dim posnumber As String = ""
        Dim lenStr As String = ""
        Dim lenId As Integer = 0

        If mysqls.getDataSet("GetLast") = 0 Then
            formatStr = prefix & Format(nowTime, periodeformat)
            currid = 1
            posnumber = posisinomor
            lenId = digitnomor
        Else
            idgen = mysqls.getDataSet("GetLast", 0, "idgeneratenumber")

            formatStr = prefix & Format(nowTime, periodeformat)
            currid = CInt(mysqls.getDataSet("GetLast", 0, "lastnumber")) + 1
            posnumber = mysqls.getDataSet("GetLast", 0, "positionnumber")
            lenId = CInt(mysqls.getDataSet("GetLast", 0, "digitnumber"))
        End If
        For i As Integer = 0 To lenId - 1
            If isbaru = True Then
                lenStr &= "X"
            Else
                If i = 0 Then
                    lenStr = "0"
                Else
                    lenStr &= "#"
                End If
            End If
        Next
        currStrId = Format(currid, lenStr)

        If posnumber.ToLower = "belakang" Then
            retval = formatStr & "/" & currStrId
        ElseIf posnumber.ToLower = "tengah" Then
            formatStr = prefix & "/" & currStrId & "/" & Format(nowTime, periodeformat)
            retval = formatStr
        ElseIf posnumber.ToLower = "depan" Then
            retval = currStrId & "/" & formatStr
        End If

        If isbaru = False Then
            Dim dtsave As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idgeneratenumber", "tablename", "formatstring", "lastnumber", "positionnumber", "digitnumber"})
            value.AddRange(New String() {idgen, tblname, formatStr, currid, posnumber, lenId})
            dtsave.datasetSave("sys_generatenumber", idgen, field, value, False)
        End If

        Return retval
    End Function

    Public Function generateno3(tablename As String, ByVal prefix As String, formatperiode As String, isbaru As Boolean) As String
        Dim retval As String = ""
        Dim mysqls As New SQLs(dbstring)
        Dim tblname As String = tablename & prefix & Format(nowTime, formatperiode)
        mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & "'", "GetLast")
        Dim idgen As String = GenerateGUID()
        Dim formatStr As String = ""
        Dim currid As Integer = 0
        Dim currStrId As String = ""
        Dim posnumber As String = ""
        Dim lenStr As String = ""
        Dim lenId As Integer = 0

        If mysqls.getDataSet("GetLast") = 0 Then
            formatStr = prefix & Format(nowTime, formatperiode)
            currid = 1
            posnumber = "Belakang"
            lenId = 4
        Else
            idgen = mysqls.getDataSet("GetLast", 0, "idgeneratenumber")

            formatStr = mysqls.getDataSet("GetLast", 0, "formatstring")
            currid = CInt(mysqls.getDataSet("GetLast", 0, "lastnumber")) + 1
            posnumber = mysqls.getDataSet("GetLast", 0, "positionnumber")
            lenId = CInt(mysqls.getDataSet("GetLast", 0, "digitnumber"))
        End If
        For i As Integer = 0 To lenId - 1
            If isbaru = True Then
                lenStr &= "X"
            Else
                If i = 0 Then
                    lenStr = "0"
                Else
                    lenStr &= "#"
                End If
            End If
        Next
        currStrId = Format(currid, lenStr)

        If posnumber.ToLower = "belakang" Then
            retval = formatStr & "/" & currStrId
        ElseIf posnumber.ToLower = "tengah" Then
            formatStr = prefix & "/" & currStrId & "/" & Format(nowTime, formatperiode)
            retval = formatStr
        ElseIf posnumber.ToLower = "depan" Then
            retval = currStrId & "/" & formatStr
        End If

        If isbaru = False Then
            Dim dtsave As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idgeneratenumber", "tablename", "formatstring", "lastnumber", "positionnumber", "digitnumber"})
            value.AddRange(New String() {idgen, tblname, formatStr, currid, posnumber, lenId})
            dtsave.datasetSave("sys_generatenumber", idgen, field, value, False)
        End If

        Return retval
    End Function

    Public Function GenerateHash(ByVal SourceText As String) As String
        'Create an encoding object to ensure the encoding standard for the source text
        Dim Ue As New System.Text.UnicodeEncoding()
        'Retrieve a byte array based on the source text
        Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
        'Instantiate an MD5 Provider object
        Dim Md5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
        'Compute the hash value from the source
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
        'And convert it to String format for return
        Return Convert.ToBase64String(ByteHash)
    End Function

    Public Function GenerateGUID() As String
        Dim retval As String = System.Guid.NewGuid.ToString().ToUpper()
        Return retval
    End Function

    Public Function GenerateUUID(dbstring As String) As String
        Dim retval As String
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select convert(varchar(50),newid(),0) as id", "uuid")
        retval = sqls.getDataSet("uuid", 0, "id").ToString
        Return retval
    End Function

    Public Function GenerateUniqueID(ByVal StrSource As String, ByVal MaxLength As Integer) As String
        Dim retval As String = GenerateHash(StrSource)
        Dim rgx As New System.Text.RegularExpressions.Regex("[^A-Za-z0-9]")
        retval = rgx.Replace(retval, "0")
        If retval.Length > MaxLength Then
            retval = retval.Remove(MaxLength, retval.Length - MaxLength)
        End If
        retval = retval.ToUpper
        Return retval
    End Function

    Public Function GenerateUniqueID(ByVal DateTimeSource As Date, ByVal MaxLength As Integer) As String
        Dim retval As String = GenerateHash(Format(DateTimeSource, "yyyyMMddssHHmmffffff"))
        Dim rgx As New System.Text.RegularExpressions.Regex("[^a-z0-9]")
        retval = rgx.Replace(retval, "0")
        If retval.Length > MaxLength Then
            retval = retval.Remove(MaxLength, retval.Length - MaxLength)
        End If
        retval = retval.ToUpper
        Return retval
    End Function

    Public Sub isiLog(ByVal userid As String, ByVal connString As String, ByVal field As List(Of String), ByVal value As List(Of Object), ByVal tablename As String)
        Dim strremarks As String = ""
        For i As Integer = 0 To field.Count - 1
            strremarks &= "<" & field(i) & "=" & value(i) & ">;"
            If i <> field.Count - 1 Then
                strremarks &= vbCrLf
            End If
        Next
        Dim sqls As New dtsetSQLS(connString)
        Dim cfield As New List(Of String)
        Dim cvalue As New List(Of Object)
        Dim strHostName As String = System.Net.Dns.GetHostName
        Dim strIPAddress As String = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()

        Dim str123 As String = ""
        Dim str12 As String = ""

        Dim tmpsvr As String = dbsvr
        Dim currsvr As String = dbsvr
        If tmpsvr.Contains("\") Then
            tmpsvr = tmpsvr.Split("\")(0)
            If tmpsvr.Contains(".") Then
                Dim tmpstr As String = tmpsvr.Replace(".", "")
                If IsNumeric(tmpstr) = False Then
                    For i As Integer = 0 To System.Net.Dns.GetHostAddresses(tmpsvr).Length - 1
                        If System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString.Contains(".") Then
                            currsvr = System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString
                        End If
                    Next
                End If
            End If
        Else
            If tmpsvr.Contains(".") Then
                Dim tmpstr As String = tmpsvr.Replace(".", "")
                If IsNumeric(tmpstr) = False Then
                    For i As Integer = 0 To System.Net.Dns.GetHostAddresses(tmpsvr).Length - 1
                        currsvr = System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString
                    Next
                End If
            Else
                For i As Integer = 0 To System.Net.Dns.GetHostAddresses(tmpsvr).Length - 1
                    currsvr = System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString
                Next
            End If
        End If
        If currsvr.Contains(".") Then
            str123 = currsvr.Split(".")(0) & "." & currsvr.Split(".")(1) & "." & currsvr.Split(".")(2) & "."
            str12 = currsvr.Split(".")(0) & "." & currsvr.Split(".")(1) & "."
        End If

        If currsvr = "127.0.0.1" Then
            strIPAddress = "127.0.0.1"
        Else
            Dim isFound As Boolean = False
            For i As Integer = 0 To System.Net.Dns.GetHostEntry(strHostName).AddressList.Length - 1
                If System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString.Contains(str123) Then
                    strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString
                    isFound = True
                    Exit For
                End If
            Next
            If isFound = False Then
                For i As Integer = 0 To System.Net.Dns.GetHostEntry(strHostName).AddressList.Length - 1
                    If System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString.Contains(str12) Then
                        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString
                        isFound = True
                        Exit For
                    End If
                Next
            End If
        End If

        Dim idtmp As String = GenerateGUID()
        cfield.AddRange(New String() {"iduserlog", "remarks", "tablename", "ipclient", "hostname", "createddate", "createdby"})
        cvalue.AddRange(New Object() {idtmp, strremarks, tablename, strIPAddress, strHostName, nowTime, userid})
        sqls.datasetSave("sys_userlog", idtmp, cfield, cvalue, False)
    End Sub

    Private Function TakeScreenShot(ByVal Control As Control) As Bitmap
        Dim tmpImg As New Bitmap(Control.Width, Control.Height)
        Using g As Graphics = Graphics.FromImage(tmpImg)
            g.CopyFromScreen(Control.PointToScreen(New Point(0, 0)), New Point(0, 0), New Size(Control.Width, Control.Height))
        End Using
        Return tmpImg
    End Function

    Public coll_child As New Collection
    Public Sub tambahChild(childform As Windows.Forms.Form)
        GC.Collect()

        Dim myasm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim nsud As Form

        Try
            nsud = myasm.CreateInstance(myasm.GetName.Name.Replace(" ", "_") & "." & childform.Name)
            AddHandler nsud.Disposed, AddressOf disposechild
            coll_child.Add(nsud, nsud.Name.ToString)
        Catch ex As Exception
            clearchild()
        End Try
    End Sub

    Public Sub disposeChild(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            coll_child.Remove(CType(sender, Windows.Forms.Form).Name)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub clearChild()
        coll_child.Clear()
    End Sub

    Public Sub debugList(ByVal lstValue As List(Of Object))
        Dim str As Object = Nothing
        For i As Integer = 0 To lstValue.Count - 1
            str = lstValue(i)
            MsgBox(str)
        Next
    End Sub
    Public Sub setRegionalSetting()
        Dim dirReg As String = "HKEY_CURRENT_USER\Control Panel\International"

        '1-10
        My.Computer.Registry.SetValue(dirReg, "iCalendarType", "1")
        My.Computer.Registry.SetValue(dirReg, "iCountry", "1")
        My.Computer.Registry.SetValue(dirReg, "iCurrDigits", "2")
        My.Computer.Registry.SetValue(dirReg, "iCurrency", "0")
        My.Computer.Registry.SetValue(dirReg, "iDate", "1")

        My.Computer.Registry.SetValue(dirReg, "iDigits", "2")
        My.Computer.Registry.SetValue(dirReg, "iFirstDayOfWeek", "6")
        My.Computer.Registry.SetValue(dirReg, "iFirstWeekOfYear", "0")
        My.Computer.Registry.SetValue(dirReg, "iLZero", "1")
        My.Computer.Registry.SetValue(dirReg, "iMeasure", "0")

        '11-20
        My.Computer.Registry.SetValue(dirReg, "iNegCurr", "0")
        My.Computer.Registry.SetValue(dirReg, "iNegNumber", "1")
        My.Computer.Registry.SetValue(dirReg, "iPaperSize", "9")
        My.Computer.Registry.SetValue(dirReg, "iTime", "1")
        My.Computer.Registry.SetValue(dirReg, "iTimePrefix", "0")

        My.Computer.Registry.SetValue(dirReg, "iTLZero", "1")
        My.Computer.Registry.SetValue(dirReg, "Locale", "00000421")
        My.Computer.Registry.SetValue(dirReg, "LocaleName", "id-ID")
        My.Computer.Registry.SetValue(dirReg, "NumShape", "1")
        My.Computer.Registry.SetValue(dirReg, "s1159", "AM")
        culInfo = "id-ID"
        '21-30
        My.Computer.Registry.SetValue(dirReg, "s2359", "PM")
        My.Computer.Registry.SetValue(dirReg, "sCountry", "United States")
        My.Computer.Registry.SetValue(dirReg, "sCurrency", "Rp")
        My.Computer.Registry.SetValue(dirReg, "sDate", "-")
        My.Computer.Registry.SetValue(dirReg, "sDecimal", ",")

        My.Computer.Registry.SetValue(dirReg, "sGrouping", "3;0")
        My.Computer.Registry.SetValue(dirReg, "sLanguage", "ENU")
        My.Computer.Registry.SetValue(dirReg, "sList", ",")
        My.Computer.Registry.SetValue(dirReg, "sLongDate", "dd MMMM yyyy")
        My.Computer.Registry.SetValue(dirReg, "sMonDecimalSep", ".")

        '31-40
        My.Computer.Registry.SetValue(dirReg, "sMonGrouping", "3;0")
        My.Computer.Registry.SetValue(dirReg, "sMonThousandSep", ".")
        My.Computer.Registry.SetValue(dirReg, "sNativeDigits", "0123456789")
        My.Computer.Registry.SetValue(dirReg, "sNegativeSign", "-")
        My.Computer.Registry.SetValue(dirReg, "sPositiveSign", "")

        My.Computer.Registry.SetValue(dirReg, "sShortDate", "dd-MM-yyyy")
        My.Computer.Registry.SetValue(dirReg, "sShortTime", "HH:mm")
        My.Computer.Registry.SetValue(dirReg, "sThousand", ".")
        My.Computer.Registry.SetValue(dirReg, "sTime", ":")
        My.Computer.Registry.SetValue(dirReg, "sTimeFormat", "HH:mm:ss")

        '41
        My.Computer.Registry.SetValue(dirReg, "sYearMonth", "MMMM yyyy")
    End Sub

End Module
