Public Class frmNewPayment
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    'Private mystring As String = ""
    Private mysite As String = ""
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        idData = "-1"
        Dim lite As New SQLi(dblite)
        'lite.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
        'If lite.getDataSet("getdbstring") > 0 Then
        '    mystring = lite.getDataSet("getdbstring", 0, "dbstring")
        'End If
        lite.DMLQuery("select siteurl from siteconn where active=1 order by idsiteconn desc", "getdbstring")
        If lite.getDataSet("getdbstring") > 0 Then
            'mystring = lite.getDataSet("getdbstring", 0, "dbstring")
            mysite = lite.getDataSet("getdbstring", 0, "siteurl")
            mysite = CheckAndRepairValidURL(mysite)
        End If

        'Dim client As System.Net.WebClient
        'Dim strvalue As String
        'client = New System.Net.WebClient()
        'strvalue = ""

        'Dim sqls As New SQLs(mystring)
        'sqls.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "content")
        'If sqls.getDataSet("content") > 0 Then 'strvalue.Contains("ERROR") = False Then
        '    Dim tmptgl As String = sqls.getDataSet("content", 0, "tanggal") 'strvalue.Split(" ")(0)
        '    Dim tmpwaktu As String = sqls.getDataSet("content", 0, "waktu") 'strvalue.Split(" ")(1)
        '    tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
        'Else
        '    tmpnowTime = Now
        'End If

        Dim json_result As String = ""
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        mparam.AddRange(New String() {"param", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"currentdatetime", tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Core", mparam, mvalue)
        If json_result.Length > 2 Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            Dim tmptgl As String = table.Rows(0).Item("tanggal") 'strvalue.Split(" ")(0)
            Dim tmpwaktu As String = table.Rows(0).Item("waktu") 'strvalue.Split(" ")(1)
            tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
        Else
            tmpnowTime = nowTime
        End If

        teVoucher.Text = ""

        tePaymentNo.Text = "INV/" & Format(tmpnowTime, "yyyyMMdd") & "/XXXX"
        teNamaPerusahaan.Text = ""
        teNamaProduk.Text = ""
        teHardwareCode.Text = ""

        lueRekening.EditValue = Nothing
        deTanggal.EditValue = nowTime
        tePaket.Text = 0
        luePaket.EditValue = Nothing

        seNominal.EditValue = 0
        teBank.Text = ""
        teNorek.Text = ""
        teNama.Text = ""
        meRemarks.Text = ""

        tmpidcompany = -1
        tmpidproduct = -1
        tmpproductcode = ""

        'Dim sqli As New SQLi(dblite)
        lite.DMLQuery("select value from appsetting where variable='CompanyName'", "comp")
        If lite.getDataSet("comp") > 0 Then
            teNamaPerusahaan.Text = lite.getDataSet("comp", 0, "value")
            lite.DMLQuery("select value from appsetting where variable='CompanyID'", "compid")
            tmpidcompany = lite.getDataSet("compid", 0, "value")
        End If
        If teNamaPerusahaan.Text = "" Then
            dizMsgbox("Data Perusahaan tidak ditemukan", dizMsgboxStyle.Peringatan, me)
            Me.Dispose()
        End If

        'sqls = New SQLs(mystring)
        'sqls.DMLQuery("select top 1 idtoken,tokenkey1,tokenkey2 from token order by createddate desc", "content")
        If table IsNot Nothing Then table.Clear()
        json_result = modCore.HttpPOSTRequestSelect(mysite & "CurrentToken")
        If json_result.Length > 2 Then 'IsNumeric(strvalue) = False Then 'MYs.getDataSet("token") > 0 Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            tmpidtoken = table.Rows(0).Item("idtoken")
            tmptokenkey1 = table.Rows(0).Item("tokenkey1")
            tmptokenkey2 = table.Rows(0).Item("tokenkey2")
            'MYs.getDataSet("token", 0, "idtoken")
            'MYs.getDataSet("token", 0, "tokenkey1")
            'MYs.getDataSet("token", 0, "tokenkey2")
        Else
            tmpidtoken = "E82EC129-868C-4FEB-9AEB-0ADB46428F1E"
            tmptokenkey1 = "ABF"
            tmptokenkey2 = "123"
        End If
        idtoken = tmpidtoken
        tokenkey1 = tmptokenkey1
        tokenkey2 = tmptokenkey2

        tmphardwareid = getBoardID()
        tmphardwarecode = getHardwareCode(tmphardwareid, tmptokenkey1, tmptokenkey2)
        'mys.DMLQuery("select idhardware from hardware where hardwareid='" & tmphardwareid & "'", "existhw")

        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"cekhwid", tmphardwareid, tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Hardware", mparam, mvalue)
        If json_result.Length > 2 Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            tmpidhardware = table.Rows(0).Item("idhardware") 'strvalue 
        Else
            If table IsNot Nothing Then table.Clear()
            mparam.Clear()
            mvalue.Clear()
            mparam.AddRange(New String() {"param", "tkey1", "tkey2"})
            mvalue.AddRange(New String() {"currentdatetime", tmptokenkey1, tmptokenkey2})
            json_result = modCore.HttpPOSTRequestSelect(mysite & "Core", mparam, mvalue)
            If json_result.Length > 2 Then
                table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
                Dim tmptgl As String = table.Rows(0).Item("tanggal")
                Dim tmpwaktu As String = table.Rows(0).Item("waktu")
                tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
            Else
                tmpnowTime = nowTime
            End If
            tmpidhardware = GenerateGUID()

            If table IsNot Nothing Then table.Clear()
            mparam.Clear()
            mvalue.Clear()
            'Dim mysqls As New dtsetSQLS(mystring)
            Dim fl As New List(Of String)
            Dim vl As New List(Of String)
            fl.AddRange(New String() {"idhardware", "hardwareid", "idtoken", "tokenkey1", "tokenkey2", "hardwarecode", "createdby", "createddate"})
            vl.AddRange(New String() {tmpidhardware, tmphardwareid, tmpidtoken, tmptokenkey1, tmptokenkey2, tmphardwarecode, "B07F6E12-85F7-4EA1-88A3-58BDC7CDAF6A", Format(tmpnowTime, "yyyy-MM-dd HH:mm:ss")})
            'mysqls.datasetSave("hardware", tmpidhardware, fl, vl, False)

            If table IsNot Nothing Then table.Clear()
            mparam.AddRange(fl)
            mvalue.AddRange(vl)
            mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
            mvalue.AddRange(New String() {"baru", tmpidhardware, tmptokenkey1, tmptokenkey2})
            json_result = modCore.HttpPOSTRequestInsert(mysite & "Hardware", mparam, mvalue)
            'table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

            If table IsNot Nothing Then table.Clear()
            mparam.Clear()
            mvalue.Clear()
            mparam.AddRange(New String() {"param", "value", "hardwareid", "tkey1", "tkey2"})
            mvalue.AddRange(New String() {"cekhwid", "", tmphardwareid, tmptokenkey1, tmptokenkey2})
            json_result = modCore.HttpPOSTRequestSelect(mysite & "Hardware", mparam, mvalue)
            If json_result.Length > 2 Then
                table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
                tmpidhardware = table.Rows(0).Item("idhardware")
            End If
        End If

        lite.DMLQuery("update appsetting set value='" & tmpidhardware & "' where variable='HardwareID'", False)
        lite.DMLQuery("update appsetting set value='" & tmphardwarecode & "' where variable='HardwareCode'", False)

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("update sys_appsetting set value='" & tmpidhardware & "' where variable='HardwareID'", False)
        sqls.DMLQuery("update sys_appsetting set value='" & tmphardwarecode & "' where variable='HardwareCode'", False)

        teHardwareCode.Text = tmphardwarecode
        hardwarecode = tmphardwarecode
        hardwareid = tmphardwareid
        idhardware = tmpidhardware

        'tmpidcompanyproduct = getidcompanyproduct(tmpidcompany, tmpidhardware)
        'If tmpidcompanyproduct = "-1" Then

        'Dim dtsqls As New dtsetSQLS(mystring)
        Dim fcp As New List(Of String)
            Dim vcp As New List(Of String)
            Dim idtmp As String = GenerateGUID()

            fcp.AddRange(New String() {"idcompanyproduct", "idcompany", "idhardware", "idcompanyrefferal", "quotaamount", "quotaused", "isdeleted", "deletereason", "createdby", "createddate"})
            vcp.AddRange(New String() {idtmp, tmpidcompany, tmpidhardware, IIf(tmpidcompanyrefferal = "-1", "", tmpidcompanyrefferal), 0, 0, 0, "", tmpUserID, Format(tmpnowTime, "yyyy-MM-dd HH:mm:ss")})
        'dtsqls.datasetSave("companyproduct", idtmp, fcp, vcp, False)

        'If table IsNot Nothing Then table.Clear()
        'mparam.Clear()
        'mvalue.Clear()
        'mparam.AddRange(fcp)
        'mvalue.AddRange(vcp)
        'mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
        'mvalue.AddRange(New String() {"baru", "", tmptokenkey1, tmptokenkey2})
        'json_result = modCore.HttpPOSTRequestInsert(mysite & "CompanyProduct", mparam, mvalue)
        'If json_result.Length > 2 Then
        '    table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
        'End If

        'tmpidcompanyproduct = getidcompanyproduct(tmpidcompany, tmpidhardware)
        '    idcompanyproduct = tmpidcompanyproduct
        '    lite.DMLQuery("update appsetting set value='" & tmpidcompanyproduct & "' where variable='CompanyProductID'", False)
        '    Dim tmpdt As DataTable = getidproducttype(tmpidcompanyproduct)
        '    idproducttype.Clear()
        '    For i As Integer = 0 To tmpdt.Rows.Count - 1
        '        idproducttype.Add(tmpdt.Rows(i).Item("idproducttype"))
        '    Next
        'Else
        '    idcompanyproduct = tmpidcompanyproduct
        '    lite.DMLQuery("update appsetting set value='" & tmpidcompanyproduct & "' where variable='CompanyProductID'", False)
        '    Dim tmpdt As DataTable = getidproducttype(tmpidcompanyproduct)
        '    idproducttype.Clear()
        '    For i As Integer = 0 To tmpdt.Rows.Count - 1
        '        idproducttype.Add(tmpdt.Rows(i).Item("idproducttype"))
        '    Next
        'End If

        Dim colname As New List(Of String)
        Dim colcaption As New List(Of String)
        Dim coltype As New List(Of Type)
        Dim dtbank As DataTable = Nothing
        Dim dtpayment As DataTable = Nothing

        'SQLs = New SQLs(mystring)
        'SQLs.DMLQuery("select bo.idbankoption as id,bo.nomorrekening + ' '+'(' + b.bank  +' - '+ bo.accountname+ ')'  as content,b.bank,bo.accountname from bankoption bo left join bank b on bo.idbank=b.idbank where bo.isdeleted=0 order by bo.accountname asc,b.bank asc", "bankoption")

        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"cekbankoption", "", tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "BankOption", mparam, mvalue)
        If json_result.Length > 2 Then
            dtbank = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
        End If

        'dsbank = New DataSet
        colname.Clear()
        colcaption.Clear()
        coltype.Clear()
        colname.AddRange(New String() {"id", "content"})
        colcaption.AddRange(New String() {"ID", "Content"})
        coltype.AddRange(New Type() {GetType(Long), GetType(String)})
        'dsbank = SQLs.dataSet 'dsbank = createDataTable(strvalue, "bankoption", colname, colcaption, coltype)

        lueRekening.Properties.DataSource = dtbank 'dsbank.Tables("bankoption")
        lueRekening.Properties.DisplayMember = "content"
        lueRekening.Properties.ValueMember = "id"
        lueRekening.EditValue = Nothing
        lueRekening.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueRekening.Properties.BestFit()

        'SQLs = New SQLs(mystring)
        'SQLs.DMLQuery("select po.idpaymentoption as id,replace(replace(convert(varchar,convert(Money, po.nominalbayar),1),'.00',''),',','.')+',00' as content from paymentoption po where po.isdeleted=0 order by po.nominalbayar asc", "paymentoption")

        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"cekpaymentoption", "", tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "PaymentOption", mparam, mvalue)
        If json_result.Length > 2 Then
            dtpayment = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
        End If

        'dspayment = New DataSet
        colname.Clear()
        colcaption.Clear()
        coltype.Clear()
        colname.AddRange(New String() {"id", "content"})
        colcaption.AddRange(New String() {"ID", "Content"})
        coltype.AddRange(New Type() {GetType(Long), GetType(String)})
        'dspayment = SQLs.dataSet 'createDataTable(strvalue, "paymentoption", colname, colcaption, coltype)

        luePaket.Properties.DataSource = dtpayment 'dspayment.Tables("paymentoption") 'MYs.dataTable("paymentoption")
        luePaket.Properties.DisplayMember = "content" '
        luePaket.Properties.ValueMember = "id"
        luePaket.EditValue = Nothing
        luePaket.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        luePaket.Properties.BestFit()

        lueRekening.Focus()
    End Sub

    'Private Function getidcompanyproduct(idcompany As String, idhardware As String) As String
    '    Dim retval As String = -1
    '    'Dim sqls As New SQLs(mystring)
    '    Dim json_result As String = ""
    '    Dim table As DataTable = Nothing
    '    Dim mparam As New List(Of String)
    '    Dim mvalue As New List(Of String)
    '    'mparam.Clear()
    '    'mvalue.Clear()
    '    'mparam.AddRange(New String() {"param", "tkey1", "tkey2", "idcompany", "idhardware"})
    '    'mvalue.AddRange(New String() {"cekcomphw", tmptokenkey1, tmptokenkey2, idcompany, idhardware})
    '    'json_result = modCore.HttpPOSTRequestSelect(mysite & "CompanyProduct", mparam, mvalue)
    '    'If json_result.Length > 2 Then
    '    '    table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
    '    '    If table.Rows.Count > 0 Then 'sqls.getDataSet("getidcompproduct") > 0 Then
    '    '        retval = table.Rows(0).Item("idcompanyproduct") 'SQLs.getDataSet("getidcompproduct", 0, "idcompanyproduct")
    '    '    Else
    '    '        Dim idtmp As String = GenerateGUID()
    '    '        'Dim dtsqls As New dtsetSQLS(mystring)
    '    '        Dim fs As New List(Of String)
    '    '        Dim vs As New List(Of String)
    '    '        fs.AddRange(New String() {"idcompanyproduct", "idcompany", "idhardware", "idcompanyrefferal", "quotaamount", "quotaused", "isdeleted", "deletereason", "createdby", "createddate"})
    '    '        vs.AddRange(New String() {idtmp, idcompany, idhardware, IIf(tmpidcompanyrefferal = "-1", "0", tmpidcompanyrefferal), 0, 0, 0, "", tmpUserID, Format(tmpnowTime, "yyyy-MM-dd HH:mm:ss")})
    '    '        'dtsqls.datasetSave("companyproduct", idtmp, fs, vs, False)

    '    '        If table IsNot Nothing Then table.Clear()
    '    '        mparam.Clear()
    '    '        mvalue.Clear()
    '    '        mparam.AddRange(fs)
    '    '        mvalue.AddRange(vs)
    '    '        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
    '    '        mvalue.AddRange(New String() {"baru", idtmp, tmptokenkey1, tmptokenkey2})
    '    '        json_result = modCore.HttpPOSTRequestInsert(mysite & "CompanyProduct", mparam, mvalue)
    '    '        retval = idtmp
    '    '    End If
    '    'Else
    '    'If table IsNot Nothing Then table.Clear()
    '    'mparam.Clear()
    '    'mvalue.Clear()
    '    'mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "idcompany"})
    '    'mvalue.AddRange(New String() {"cekcomp", "", tmptokenkey1, tmptokenkey2, idcompany})
    '    'json_result = modCore.HttpPOSTRequestInsert(mysite & "CompanyProduct", mparam, mvalue)
    '    'If json_result.Length > 2 Then
    '    '    table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
    '    '    retval = table.Rows(0).Item("idcompanyproduct") 'SQLs.getDataSet("getidcompproduct", 0, "idcompanyproduct")
    '    'End If

    '    'Dim idtmp As String = table.Rows(0).Item("idcompanyproduct")
    '    ''Dim dtsqls As New dtsetSQLS(mystring)
    '    'Dim fs As New List(Of String)
    '    'Dim vs As New List(Of String)
    '    'fs.AddRange(New String() {"idcompanyproduct", "idcompany", "idhardware", "idcompanyrefferal", "quotaamount", "quotaused", "isdeleted", "deletereason", "createdby", "createddate"})
    '    'vs.AddRange(New String() {idtmp, idcompany, idhardware, IIf(tmpidcompanyrefferal = "-1", "0", tmpidcompanyrefferal), 0, 0, 0, "", tmpUserID, Format(tmpnowTime, "yyyy-MM-dd HH:mm:ss")})
    '    ''dtsqls.datasetSave("companyproduct", idtmp, fs, vs, False)

    '    'If table IsNot Nothing Then table.Clear()
    '    'mparam.Clear()
    '    'mvalue.Clear()
    '    'mparam.AddRange(fs)
    '    'mvalue.AddRange(vs)
    '    'mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
    '    'mvalue.AddRange(New String() {"edit", idtmp, tmptokenkey1, tmptokenkey2})
    '    'json_result = modCore.HttpPOSTRequestInsert(mysite & "CompanyProduct", mparam, mvalue)
    '    'retval = idtmp
    '    'End If
    '    Return retval
    'End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If checkEntry() = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Kesalahan, me)
            Exit Sub
        End If
        If meRemarks.Text = "" Then
            If dizMsgbox("Catatan masih kosong" & vbCrLf & "Tetap melanjutkan ?", dizMsgboxStyle.Konfirmasi, me) = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If

        Dim json_result As String = ""
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)

        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"currentdatetime", tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Core", mparam, mvalue)
        If json_result.Length > 2 Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            Dim tmptgl As String = table.Rows(0).Item("tanggal")
            Dim tmpwaktu As String = table.Rows(0).Item("waktu")
            tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
        Else
            tmpnowTime = nowTime
        End If

        tePaymentNo.Text = generateNO("INV", tmpnowTime, "yyyyMMdd", "belakang", 4)
        'Dim idcompanyproduct As String = getidcompanyproduct(tmpidcompany, tmpidhardware)
        'Dim tmpdt As DataTable = getidproducttype(tmpidcompanyproduct)
        'idproducttype.Clear()
        'For i As Integer = 0 To tmpdt.Rows.Count - 1
        '    idproducttype.Add(tmpdt.Rows(i).Item("idproducttype"))
        'Next

        'Dim dtsqls As New dtsetSQLS(mystring)
        Dim fs As New List(Of String)
        Dim vs As New List(Of String)
        Dim idpaymentonline As String = GenerateGUID()
        fs.AddRange(New String() {"idpayment", "idvoucher", "idbankoption", "idcompany", "idcompanyproduct", "idpaymentoption", "paymentno", "tanggalbayar", "nominalbayar", "nominaldata", "bankpengirim", "norekpengirim", "atasnamapengirim", "remarks", "isvalid", "isdeleted", "deletereason", "createdby", "createddate"})
        vs.AddRange(New String() {idpaymentonline, "0", lueRekening.EditValue, tmpidcompany, "0", luePaket.EditValue, tePaymentNo.Text, Format(CDate(deTanggal.EditValue), "yyyy-MM-dd"), CStr(CLng(seNominal.EditValue)), tePaket.Text, teBank.Text, teNorek.Text, teNama.Text, meRemarks.Text, 0, 0, "-", tmpUserID, Format(CDate(nowTime), "yyyy-MM-dd HH:mm:ss")})

        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"baru", idpaymentonline, tmptokenkey1, tmptokenkey2})
        mparam.AddRange(fs)
        mvalue.AddRange(vs)
        json_result = modCore.HttpPOSTRequestInsert(mysite & "Payment", mparam, mvalue)
        'table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

        If json_result = "true" Then 'table.Rows.Count > 0 Then 'If dtsqls.datasetSave("payment", idpaymentonline, fs, vs, False) = True Then
            ' Dim idtmp As String = GenerateGUID()
            Dim flite As New List(Of String)
            Dim vlite As New List(Of Object)
            ' idtmp = GenerateGUID()
            flite.AddRange(New String() {"idpayment", "idbankoption", "idcompany", "idcompanyproduct", "idpaymentoption", "paymentno", "tanggalbayar", "nominalbayar", "nominaldata", "bankpengirim", "norekpengirim", "atasnamapengirim", "remarks", "isvalid", "isdeleted", "deletereason", "createddate", "createdby"})
            vlite.AddRange(New Object() {idpaymentonline, lueRekening.EditValue, tmpidcompany, "0", luePaket.EditValue, tePaymentNo.Text, CDate(deTanggal.EditValue), tePaket.Tag, tePaket.Text, teBank.Text, teNorek.Text, teNama.Text, meRemarks.Text, 0, 0, "", Format(tmpnowTime, "yyyy-MM-dd"), tmpUserID})
            Dim dtlite As New dtsetSQLI(dblite)
            dtlite.datasetSave("payment", idpaymentonline, flite, vlite, False)

            dizMsgbox("Data Pembayaran telah tersimpan" & vbCrLf & "Tunggu validasi dari kami beberapa saat lagi", dizMsgboxStyle.Info, Me)
            btnSave.Enabled = False
        End If
    End Sub

    Private Function generateNO(ByVal prefix As String, waktu As Date, ByVal periodeformat As String, ByVal posisinomor As String, ByVal digitnomor As Integer) As String
        Dim retval As String = ""
        Dim tblname As String = prefix & Format(waktu, periodeformat)

        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        Dim json_result As String = ""

        mparam.Clear()
        mvalue.Clear()

        mparam.AddRange(New String() {"param", "value", "tablename", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"cekgeneratenumber", "", tblname, tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "GenerateNumber", mparam, mvalue)

        Dim idgen As String = "-1"
        Dim formatStr As String = ""
        Dim currid As Long = 0
        Dim currStrId As String = ""
        Dim posnumber As String = ""
        Dim lenStr As String = ""
        Dim lenId As Long = 0
        Dim statdata As statusData = statusData.Baru

        If json_result.Length > 2 Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

            statdata = statusData.Edit
            idgen = table.Rows(0).Item("idgeneratenumber")

            formatStr = table.Rows(0).Item("formatstring")
            currid = CInt(table.Rows(0).Item("lastnumber")) + 1
            posnumber = table.Rows(0).Item("positionnumber")
            lenId = CInt(table.Rows(0).Item("digitnumber"))
        Else
            statdata = statusData.Baru
            idgen = GenerateGUID()

            formatStr = prefix & "/" & Format(waktu, periodeformat)
            currid = 1
            posnumber = posisinomor
            lenId = digitnomor
        End If
        For i As Integer = 0 To lenId - 1
            If i = 0 Then
                lenStr = "0"
            Else
                lenStr &= "#"
            End If
        Next
        currStrId = Format(currid, lenStr)

        If posnumber.ToLower = "belakang" Then
            retval = formatStr & "/" & currStrId
        ElseIf posnumber.ToLower = "tengah" Then
            formatStr = prefix & "/" & currStrId & "/" & Format(waktu, periodeformat)
            retval = formatStr
        ElseIf posnumber.ToLower = "depan" Then
            retval = currStrId & "/" & formatStr
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of String)
        field.AddRange(New String() {"idgeneratenumber", "tablename", "formatstring", "lastnumber", "positionnumber", "digitnumber"})
        value.AddRange(New String() {idgen, tblname, formatStr, currid, posnumber, lenId})

        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()

        mparam.AddRange(field)
        mvalue.AddRange(value)
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
        If statdata = statusData.Baru Then
            mvalue.AddRange(New String() {"baru", idgen, tmptokenkey1, tmptokenkey2})
        Else
            mvalue.AddRange(New String() {"edit", idgen, tmptokenkey1, tmptokenkey2})
        End If
        json_result = modCore.HttpPOSTRequestInsert(mysite & "GenerateNumber", mparam, mvalue)
        Return retval
    End Function

    Private Function checkEntry() As Boolean
        Dim retval As Boolean = True
        If lueRekening.EditValue Is Nothing Then
            retval = False
        End If
        If deTanggal.EditValue Is Nothing Then
            retval = False
        End If
        If luePaket.EditValue Is Nothing Then
            retval = False
        End If
        If tePaket.Text = 0 Then
            retval = False
        End If
        If teBank.Text = "" Then
            retval = False
        End If
        If teNorek.Text = "" Then
            retval = False
        End If
        If teNama.Text = "" Then
            retval = False
        End If
        Return retval
    End Function

    Private Sub luePaket_EditValueChanged(sender As Object, e As EventArgs) Handles luePaket.EditValueChanged
        If luePaket.EditValue Is Nothing Then
            tePaket.Text = 0
            Exit Sub
        End If

        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        Dim json_result As String = ""

        mparam.Clear()
        mvalue.Clear()

        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"cekid", luePaket.EditValue, tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "PaymentOption", mparam, mvalue)
        table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

        'Dim mys As New SQLs(mystring)
        'mys.DMLQuery("select nominaldata,nominalbayar from paymentoption po where po.idpaymentoption='" & luePaket.EditValue & "'", "nominaldata")
        Dim strunik As String = cekUnik()
        If table.Rows.Count > 0 Then 'mys.getDataSet("nominaldata") > 0 Then
            tePaket.Text = CLng(table.Rows(0).Item("nominaldata")) 'MYs.getDataSet("nominaldata", 0, "nominaldata"))
            tePaket.Tag = CLng(table.Rows(0).Item("nominalbayar").ToString.Replace(".00", "")) 'MYs.getDataSet("nominaldata", 0, "nominalbayar"))
            seNominal.EditValue = CLng(table.Rows(0).Item("nominalbayar").ToString.Replace(".00", "")) + CLng(strunik)
        Else
            tePaket.Text = 0
            tePaket.Tag = 0
            seNominal.EditValue = 0
        End If
    End Sub

    Private Function cekUnik() As String
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        Dim json_result As String = ""

        mparam.Clear()
        mvalue.Clear()

        Dim intRand As Integer = 0
        Dim rand As New Random
        intRand = rand.Next(101, 999)
        Dim retval As String = Format(intRand, "0##")
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"custom", "select distinct right(replace(convert(nominalbayar,char),'.00',''),3) as content from payment where isvalid=1 and right(replace(convert(nominalbayar,char),'.00',''),3)='" & retval & "'", tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Core", mparam, mvalue)
        table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

        If table.Rows.Count > 0 Then
            retval = cekUnik()
        End If
        Return retval
    End Function

    Private Sub teNorek_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teNorek.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNorek) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub teNama_LostFocus(sender As Object, e As EventArgs) Handles teNama.LostFocus
        teNama.Text = StrConv(teNama.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub btnExistCheck_Click(sender As Object, e As EventArgs) Handles btnExistCheck.Click
        If teVoucher.Text = "" Then
            dizMsgbox("Kode Voucher tidak valid", dizMsgboxStyle.Peringatan, me)
            Exit Sub
        End If

        Dim vidtoken As String = ""
        Dim vtokenkey1 As String = ""
        Dim vtokenkey2 As String = ""
        Dim vdata As String = ""
        Dim vnominal As Decimal = 0
        Dim vnominaldata As Decimal = 0
        Dim vstring As String = teVoucher.Text
        Dim vcode As String = ""
        Dim vid As String = ""

        Dim json_result As String = ""
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        mparam.AddRange(New String() {"param", "value", "voucherstring", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"cekvoucher", "", teVoucher.Text, tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Voucher", mparam, mvalue)

        'Dim sqls As New SQLs(mystring)
        'SQLs.DMLQuery("select idvoucher,idtoken,tokenkey1,tokenkey2,voucherdata,vouchernominal,nominaldata,vouchercode from voucher where duedate > getdate() And isdeleted=0 And voucherstring='" & teVoucher.Text & "'", "cekvoucher")

        If json_result.Length = 2 Then 'sqls.getDataSet("cekvoucher") = 0 Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            dizMsgbox("Voucher tidak valid", dizMsgboxStyle.Kesalahan, Me)
            teVoucher.Text = ""
            teVoucher.Focus()
            Exit Sub
        Else
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            vidtoken = table.Rows(0).Item("idtoken") 'sqls.getDataSet("cekvoucher", 0, "idtoken")
            vtokenkey1 = table.Rows(0).Item("tokenkey1") 'sqls.getDataSet("cekvoucher", 0, "tokenkey1")
            vtokenkey2 = table.Rows(0).Item("tokenkey2") 'sqls.getDataSet("cekvoucher", 0, "tokenkey2")
            vdata = table.Rows(0).Item("voucherdata") 'sqls.getDataSet("cekvoucher", 0, "voucherdata")
            vnominal = CDec(table.Rows(0).Item("vouchernominal").ToString.Replace(".00", "")) 'sqls.getDataSet("cekvoucher", 0, "vouchernominal"))
            vnominaldata = CDec(table.Rows(0).Item("nominaldata")) 'sqls.getDataSet("cekvoucher", 0, "nominaldata"))
            vcode = table.Rows(0).Item("vouchercode") 'sqls.getDataSet("cekvoucher", 0, "vouchercode")
            vid = table.Rows(0).Item("idvoucher") 'sqls.getDataSet("cekvoucher", 0, "idvoucher")

            If table IsNot Nothing Then table.Clear()
            mparam.Clear()
            mvalue.Clear()
            mparam.AddRange(New String() {"param", "value", "idvoucher", "tkey1", "tkey2"})
            mvalue.AddRange(New String() {"cekvoucher", "", vid, tmptokenkey1, tmptokenkey2})
            json_result = modCore.HttpPOSTRequestSelect(mysite & "Payment", mparam, mvalue)

            'SQLs.DMLQuery("select idvoucher from payment where isvalid=1 and isdeleted=0 and idvoucher='" & vid & "'", "cekvoucherused")
            If json_result.Length > 2 Then  'sqls.getDataSet("cekvoucherused") > 0 Then
                table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
                dizMsgbox("Voucher sudah digunakan", dizMsgboxStyle.Kesalahan, Me)
                teVoucher.Text = ""
                teVoucher.Focus()
                Exit Sub
            End If

            Dim resenc As String = ""
            For i As Integer = 0 To vdata.Length - 1
                If CInt(vdata.Chars(i).ToString) = 0 Then
                    resenc &= "0"
                Else
                    resenc &= Chr(64 + CInt(vdata.Chars(i).ToString))
                End If
            Next
            resenc = resenc.ToUpper
            Dim resdata As Decimal = CLng(vnominal / 42)
            Dim resstring As String = getGenerateCode(resenc, vtokenkey1, vtokenkey2, 50, getFrom.belakang)
            Dim rescode As String = getGenerateCode(resenc, vtokenkey1, vtokenkey2, 8000, getFrom.belakang)
            'MsgBox(resdata & vbCrLf & vnominaldata)
            If resdata <> vnominaldata Then
                dizMsgbox("Voucher tidak valid", dizMsgboxStyle.Kesalahan, Me)
                teVoucher.Text = ""
                teVoucher.Focus()
                Exit Sub
            End If
            If resstring <> teVoucher.Text Then
                dizMsgbox("Voucher tidak valid", dizMsgboxStyle.Kesalahan, Me)
                teVoucher.Text = ""
                teVoucher.Focus()
                Exit Sub
            End If
            If vcode <> rescode Then
                dizMsgbox("Voucher tidak valid", dizMsgboxStyle.Kesalahan, Me)
                teVoucher.Text = ""
                teVoucher.Focus()
                Exit Sub
            End If
        End If

        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"currentdatetime", tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Core", mparam, mvalue)
        table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
        If table.Rows.Count > 0 Then
            Dim tmptgl As String = table.Rows(0).Item("tanggal")
            Dim tmpwaktu As String = table.Rows(0).Item("waktu")
            tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
        Else
            tmpnowTime = nowTime
        End If

        tePaymentNo.Text = generateNO("INV", tmpnowTime, "yyyyMMdd", "belakang", 4)
        Dim idpaymentonline As String = GenerateGUID()
        'Dim idcompanyproduct As String = getidcompanyproduct(tmpidcompany, tmpidhardware)
        'Dim tmpdt As DataTable = getidproducttype(tmpidcompanyproduct)
        'idproducttype.Clear()
        'For i As Integer = 0 To tmpdt.Rows.Count - 1
        '    idproducttype.Add(tmpdt.Rows(i).Item("idproducttype"))
        'Next

        'Dim dtsqls As New dtsetSQLS(mystring)
        Dim fs As New List(Of String)
        Dim vs As New List(Of String)

        fs.AddRange(New String() {"idpayment", "idvoucher", "idbankoption", "idcompany", "idcompanyproduct", "idpaymentoption", "paymentno", "tanggalbayar", "nominalbayar", "nominaldata", "bankpengirim", "norekpengirim", "atasnamapengirim", "remarks", "isvalid", "isdeleted", "deletereason", "createdby", "createddate"})
        vs.AddRange(New String() {idpaymentonline, vid, "29B5A27C-1716-11E9-B068-28924AD3C84E", tmpidcompany, "0", 0, tePaymentNo.Text, Format(tmpnowTime, "yyyy-MM-dd"), vnominal, vnominaldata, "Voucher", "-", "Voucher", "Voucher", 1, 0, "-", tmpUserID, Format(tmpnowTime, "yyyy-MM-dd HH:mm:ss")})

        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"baru", idpaymentonline, tmptokenkey1, tmptokenkey2})
        mparam.AddRange(fs)
        mvalue.AddRange(vs)
        json_result = modCore.HttpPOSTRequestInsert(mysite & "Payment", mparam, mvalue)
        'table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

        If json_result = "true" Then 'table.Rows.Count > 0 Then 'dtsqls.datasetSave("payment", idpaymentonline, fs, vs, False) = True Then
            'SQLs = New SQLs(mystring)

            Dim flite As New List(Of String)
            Dim vlite As New List(Of Object)
            flite.AddRange(New String() {"idpayment", "idvoucher", "idbankoption", "idcompany", "idcompanyproduct", "idpaymentoption", "paymentno", "tanggalbayar", "nominalbayar", "nominaldata", "bankpengirim", "norekpengirim", "atasnamapengirim", "remarks", "isvalid", "isdeleted", "deletereason", "createddate", "createdby"})
            vlite.AddRange(New Object() {idpaymentonline, vid, "29B5A27C-1716-11E9-B068-28924AD3C84E", tmpidcompany, "0", "", tePaymentNo.Text, tmpnowTime, vnominal, vnominaldata, teBank.Text, teNorek.Text, teNama.Text, meRemarks.Text, 1, 0, "", Format(tmpnowTime, "yyyy-MM-dd HH:mm:ss"), tmpUserID})
            Dim dtlite As New dtsetSQLI(dblite)
            dtlite.datasetSave("payment", idpaymentonline, flite, vlite, False)

            qtyQuota = qtyQuota + vnominaldata

            'SQLs = New SQLs(mystring)
            Dim sqlss As New SQLs(dbstring)
            Dim lite As New SQLi(dblite)
            Dim quota As New List(Of String)
            quota.Add(tmpidcompany)
            quota.Add(qtyQuota)

            If table IsNot Nothing Then table.Clear()
            mparam.Clear()
            mvalue.Clear()
            mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "quotaamount", "updatedby"})
            mvalue.AddRange(New String() {"setamountc", tmpidcompany, tmptokenkey1, tmptokenkey2, qtyQuota, tmpUserID})
            json_result = modCore.HttpPOSTRequestInsert(mysite & "Company", mparam, mvalue)
            'table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

            'SQLs.DMLQuery("update companyproduct set quotaamount='" & qtyQuota & "' where idcompanyproduct='" & tmpidcompanyproduct & "'", False)
            sqlss.DMLQuery("update sys_appsetting set value='" & qtyQuota & "' where variable='QuotaAmount'", False)
            lite.DMLQuery("update appsetting set value='" & qtyQuota & "' where variable='QuotaAmount'", False)
            Dim dizEngine As New dizEngine.engine
            Dim qtyquotacode As String = dizEngine.processE(qtyQuota)
            sqlss.DMLQuery("update sys_appsetting set value='" & qtyquotacode & "' where variable='QuotaAmountCode'", False)
            lite.DMLQuery("update appsetting set value='" & qtyquotacode & "' where variable='QuotaAmountCode'", False)

            dizMsgbox("Data Voucher telah tersimpan" & vbCrLf & "Kuota anda telah bertambah " & vnominaldata, dizMsgboxStyle.Info, Me)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Dispose()
        End If
    End Sub

    'Private Function getidproducttype(idcompanyproduct As String) As DataTable
    '    Dim retval As DataTable = Nothing
    '    Dim table As DataTable = Nothing
    '    Dim field As New List(Of String)
    '    Dim value As New List(Of String)
    '    Dim json_result As String = ""

    '    field.Clear()
    '    value.Clear()
    '    field.AddRange(New String() {"param", "value", "tkey1", "tkey2", "idcompanyproduct"})
    '    value.AddRange(New String() {"cekcomppro", "", tmptokenkey1, tmptokenkey2, idcompanyproduct})
    '    json_result = modCore.HttpPOSTRequestSelect(mysite & "CompanyProductType", field, value)
    '    table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

    '    'Dim sqls As New SQLs(mystring)
    '    'sqls.DMLQuery("select p.idproducttype from companyproduct cp left join product p on cp.idproduct=p.idproduct where cp.idcompany='" & idcompany & "' and cp.idproduct='" & idproduct & "' and cp.idhardware='" & idhardware & "'", "getidproducttype")

    '    retval = table 'sqls.getDataSet("getidproducttype", 0, "idproducttype")
    '    Return retval
    'End Function

    Private Sub btnCheckQuota_Click(sender As Object, e As EventArgs) Handles btnCheckQuota.Click
        Dim tkuota As Decimal = 0
        Dim tusage As Decimal = 0
        Dim tpayment As Decimal = 0

        'Dim idcompanyproduct As String = getidcompanyproduct(tmpidcompany, tmpidhardware)
        'Dim tmpdt As DataTable = getidproducttype(tmpidcompanyproduct)
        'idproducttype.Clear()
        'For i As Integer = 0 To tmpdt.Rows.Count - 1
        '    idproducttype.Add(tmpdt.Rows(i).Item("idproducttype"))
        'Next

        Dim json_result As String = ""
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"ceknominalc", tmpidcompany, tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Company", mparam, mvalue)
        table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

        'Dim sqls As New SQLs(mystring)
        'Dim val As New List(Of String)
        'val.Add(idcompanyproduct)

        'sqls.DMLQuery("select (select isnull(sum(nominaldata),0) as nominaldata from payment where idcompanyproduct='" & idcompanyproduct & "' and isvalid=1 and isdeleted=0)-(select isnull(sum(nominaldata),0) as nominaldata from usage where idcompanyproduct='" & idcompanyproduct & "' and isdeleted=0 and periode=(select max(periode) as peridoe from usage where idcompanyproduct='" & idcompanyproduct & "' and isdeleted=0)) as nominaldata", "getkuota")
        If table.Rows.Count > 0 Then 'sqls.getDataSet("getkuota") > 0 Then
            tkuota = CDec(table.Rows(0).Item("nominaldata")) 'SQLs.getDataSet("getkuota", 0, "nominaldata"))
        End If
        'Val.Add(tkuota)

        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "quotaamount"})
        mvalue.AddRange(New String() {"setamountc", tmpidcompany, tmptokenkey1, tmptokenkey2, tkuota})
        json_result = modCore.HttpPOSTRequestInsert(mysite & "Company", mparam, mvalue)
        'table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

        'SQLs.DMLQuery("update companyproduct set quotaamount='" & tkuota & "' where idcompanyproduct='" & idcompanyproduct & "'", False)

        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "idcompany"})
        mvalue.AddRange(New String() {"ceknominalc", "", tmptokenkey1, tmptokenkey2, tmpidcompany})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Payment", mparam, mvalue)

        'Val.Clear()
        'val.Add(idcompanyproduct)

        'sqls.DMLQuery("select isnull(sum(nominaldata),0) as nominaldata from payment where idcompanyproduct='" & idcompanyproduct & "' and isvalid=1 and isdeleted=0", "getpayment")
        If json_result > 2 Then 'sqls.getDataSet("getpayment") > 0 Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            tpayment = CDec(table.Rows(0).Item("nominaldata")) 'SQLs.getDataSet("getpayment", 0, "nominaldata"))
        End If

        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "idcompany"})
        mvalue.AddRange(New String() {"ceknominalc", "", tmptokenkey1, tmptokenkey2, tmpidcompany})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Usage", mparam, mvalue)

        'SQLs.DMLQuery("select isnull(sum(nominaldata),0) as nominaldata from dailyusage where idcompanyproduct='" & idcompanyproduct & "' and isdeleted=0 and convert(varchar,postdate,105)=convert(varchar,(select max(postdate) as postdate from dailyusage where idcompanyproduct='" & idcompanyproduct & "' and isdeleted=0),105)", "getusage")
        If json_result > 2 Then 'sqls.getDataSet("getusage") > 0 Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            tusage = CDec(table.Rows(0).Item("nominaldata")) 'SQLs.getDataSet("getusage", 0, "nominaldata"))
        End If

        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "quotaused"})
        mvalue.AddRange(New String() {"setusedc", tmpidcompany, tmptokenkey1, tmptokenkey2, tusage})
        json_result = modCore.HttpPOSTRequestInsert(mysite & "Company", mparam, mvalue)
        'If json_result.Length > 2 Then
        '    table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
        'End If

        'Val.Add(tusage)

        'sqls.DMLQuery("update companyproduct set quotaused='" & tusage & "' where idcompanyproduct='" & idcompanyproduct & "'", False)

        ' If tkuota > 0 Then
        Dim sqlss As New SQLs(dbstring)
        Dim lite As New SQLi(dblite)
        sqlss.DMLQuery("update sys_appsetting set value='" & tpayment & "' where variable='QuotaAmount'", False)
        lite.DMLQuery("update appsetting set value='" & tpayment & "' where variable='QuotaAmount'", False)

        sqlss.DMLQuery("update sys_appsetting set value='" & tusage & "' where variable='QuotaUsed'", False)
        lite.DMLQuery("update appsetting set value='" & tusage & "' where variable='QuotaUsed'", False)

        Dim dizEngine As New dizEngine.engine
        Dim qtyquotacode As String = dizEngine.processE(tpayment)
        sqlss.DMLQuery("update sys_appsetting set value='" & qtyquotacode & "' where variable='QuotaAmountCode'", False)
        lite.DMLQuery("update appsetting set value='" & qtyquotacode & "' where variable='QuotaAmountCode'", False)

        Dim qtyusagecode As String = dizEngine.processE(tusage)
        sqlss.DMLQuery("update sys_appsetting set value='" & qtyusagecode & "' where variable='QuotaUsedCode'", False)
        lite.DMLQuery("update appsetting set value='" & qtyusagecode & "' where variable='QuotaUsedCode'", False)

        dizMsgbox("Kuota anda: " & tkuota & vbCrLf & "Total pembelian: " & tpayment & vbCrLf & "Total pemakaian: " & tusage, dizMsgboxStyle.Info, Me)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Dispose()
        'Else
        '    dizMsgbox("Kuota anda: " & tkuota, dizMsgboxStyle.Peringatan, Me)
        'End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim hp As New frmHistoryPayment(tmpidcompany)
        hp.ShowDialog()
    End Sub

End Class