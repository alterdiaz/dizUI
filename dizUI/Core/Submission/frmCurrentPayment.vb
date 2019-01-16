Public Class frmCurrentPayment
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'Private Property mys As MYs

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

    Private mystring As String = ""
    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        tmpUserID = "-1"
        If tmpUserID = "-1" Then
            texUsername.Text = ""
            texPassword.Text = ""
            btnUserCheck.Enabled = True
            panelLogin.Visible = True
            panelLogin.BringToFront()
            tlpEntry.Visible = False
            btnExistCheck.Enabled = False

            btnCheckQuota.Enabled = False
            btnHistory.Enabled = False
            btnSave.Enabled = False
            tlpEntry.SendToBack()
        End If
        idData = "-1"
        Dim lite As New SQLi(dblite)
        lite.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
        If lite.getDataSet("getdbstring") > 0 Then
            mystring = lite.getDataSet("getdbstring", 0, "dbstring")
        End If

        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "content")
        If sqls.getDataSet("content") > 0 Then 'strvalue.Contains("ERROR") = False Then
            Dim tmptgl As String = sqls.getDataSet("content", 0, "tanggal") 'strvalue.Split(" ")(0)
            Dim tmpwaktu As String = sqls.getDataSet("content", 0, "waktu") 'strvalue.Split(" ")(1)
            tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
        Else
            tmpnowTime = Now
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

        teBank.Text = ""
        teNorek.Text = ""
        teNama.Text = ""
        meRemarks.Text = ""

        Dim sqli As New SQLi(dblite)
        sqli.DMLQuery("select value from appsetting where variable='CompanyName'", "comp")
        If sqli.getDataSet("comp") > 0 Then
            teNamaPerusahaan.Text = sqli.getDataSet("comp", 0, "value")
            sqli.DMLQuery("select value from appsetting where variable='CompanyID'", "compid")
            tmpidcompany = sqli.getDataSet("compid", 0, "value")
        End If
        If teNamaPerusahaan.Text = "" Then
            dizMsgbox("Data Perusahaan tidak ditemukan", dizMsgboxStyle.Peringatan)
            Me.Dispose()
        End If
        sqli.DMLQuery("select value from appsetting where variable='ProductName'", "prod")
        If sqli.getDataSet("prod") > 0 Then
            teNamaProduk.Text = sqli.getDataSet("prod", 0, "value")
            sqli.DMLQuery("select value from appsetting where variable='ProductID'", "prodid")
            tmpidproduct = sqli.getDataSet("prodid", 0, "value")
            sqli.DMLQuery("select value from appsetting where variable='ProductTypeID'", "prodtypeid")
            tmpidproducttype = sqli.getDataSet("prodtypeid", 0, "value")
            sqli.DMLQuery("select value from appsetting where variable='ProductCode'", "prodcode")
            tmpproductcode = sqli.getDataSet("prodid", 0, "value")

            modCore.productname = teNamaProduk.Text
            modCore.idproduct = tmpidproduct
            modCore.productcode = tmpproductcode
            modCore.idproducttype = tmpidproducttype
        End If
        If teNamaProduk.Text = "" Then
            dizMsgbox("Data Produk tidak ditemukan", dizMsgboxStyle.Peringatan)
            Me.Dispose()
        End If

        sqls = New SQLs(mystring)
        sqls.DMLQuery("select top 1 idtoken,tokenkey1,tokenkey2 from token order by createddate desc", "content")
        If sqls.getDataSet("content") > 0 Then 'IsNumeric(strvalue) = False Then 'MYs.getDataSet("token") > 0 Then
            tmpidtoken = sqls.getDataSet("content", 0, "idtoken")
            'MYs.getDataSet("token", 0, "idtoken")
            tmptokenkey1 = sqls.getDataSet("content", 0, "tokenkey1")
            'MYs.getDataSet("token", 0, "tokenkey1")
            tmptokenkey2 = sqls.getDataSet("content", 0, "tokenkey2")
            'MYs.getDataSet("token", 0, "tokenkey2")
        Else
            tmpidtoken = 1
            tmptokenkey1 = "ABF"
            tmptokenkey2 = "123"
        End If
        idtoken = tmpidtoken
        tokenkey1 = tmptokenkey1
        tokenkey2 = tmptokenkey2

        tmphardwareid = getBoardID()
        tmphardwarecode = getHardwareCode(tmphardwareid, tmptokenkey1, tmptokenkey2)
        'mys.DMLQuery("select idhardware from hardware where hardwareid='" & tmphardwareid & "'", "existhw")

        sqls.DMLQuery("select idhardware from hardware where hardwareid='" & tmphardwareid & "'", "existhw")
        If sqls.getDataSet("existhw") > 0 Then 'strvalue.Contains("ERROR") = False Then 
            tmpidhardware = sqls.getDataSet("existhw", 0, "idhardware") 'strvalue 
        Else
            sqls.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "cekwaktu")
            If sqls.getDataSet("content") > 0 Then 'strvalue.Contains("ERROR") = False Then
                Dim tmptgl As String = sqls.getDataSet("cekwaktu", 0, "tanggal") 'strvalue.Split(" ")(0)
                Dim tmpwaktu As String = sqls.getDataSet("cekwaktu", 0, "waktu") 'strvalue.Split(" ")(1)
                tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
            Else
                tmpnowTime = Now
            End If

            tmpidhardware = -1

            Dim mysqls As New dtsetSQLS(mystring)
            Dim fl As New List(Of String)
            Dim vl As New List(Of Object)
            fl.AddRange(New String() {"idhardware", "hardwareid", "idtoken", "tokenkey1", "tokenkey2", "hardwarecode", "createdby", "createddate"})
            vl.AddRange(New Object() {tmpidhardware, tmphardwareid, tmpidtoken, tmptokenkey1, tmptokenkey2, tmphardwarecode, 1, tmpnowTime})
            mysqls.datasetSave("hardware", tmpidhardware, fl, vl, False)

            sqls.DMLQuery("select idhardware from hardware where hardwareid='" & tmphardwareid & "'", "hardware")
            tmpidhardware = sqls.getDataSet("hardware", 0, "idhardware") 'strvalue
        End If

        lite.DMLQuery("update appsetting set value='" & tmpidhardware & "' where variable='HardwareID'", False)
        lite.DMLQuery("update appsetting set value='" & tmphardwarecode & "' where variable='HardwareCode'", False)

        teHardwareCode.Text = tmphardwarecode
        hardwarecode = tmphardwarecode
        hardwareid = tmphardwareid
        idhardware = tmpidhardware

        tmpidcompanyproduct = getidcompanyproduct(tmpidcompany, tmpidproduct, tmpidhardware)
        If tmpidcompanyproduct = "-1" Then
            Dim dtsqls As New dtsetSQLS(mystring)
            Dim fcp As New List(Of String)
            Dim vcp As New List(Of Object)
            Dim idtmp As String = GenerateGUID()

            fcp.AddRange(New String() {"idcompanyproduct", "idcompany", "idproduct", "idhardware", "idcompanyrefferal", "quotaamount", "quotaused", "isdeleted", "deletereason", "createdby", "createddate"})
            vcp.AddRange(New Object() {idtmp, tmpidcompany, tmpidproduct, tmpidhardware, IIf(tmpidcompanyrefferal = -1, DBNull.Value, tmpidcompanyrefferal), 0, 0, 0, "", tmpUserID, tmpnowTime})
            dtsqls.datasetSave("companyproduct", idtmp, fcp, vcp, False)

            tmpidcompanyproduct = getidcompanyproduct(tmpidcompany, tmpidproduct, tmpidhardware)
            idcompanyproduct = tmpidcompanyproduct
            sqli.DMLQuery("update appsetting set value='" & tmpidcompanyproduct & "' where variable='CompanyProductID'", False)
            idproducttype = getidproducttype(tmpidcompany, tmpidproduct, tmpidhardware)
        Else
            idcompanyproduct = tmpidcompanyproduct
            sqli.DMLQuery("update appsetting set value='" & tmpidcompanyproduct & "' where variable='CompanyProductID'", False)
            idproducttype = getidproducttype(tmpidcompany, tmpidproduct, tmpidhardware)
        End If

        Dim colname As New List(Of String)
        Dim colcaption As New List(Of String)
        Dim coltype As New List(Of Type)
        Dim dsbank As DataSet
        Dim dspayment As DataSet

        
        sqls = New SQLs(mystring)
        sqls.DMLQuery("select bo.idbankoption as id,bo.nomorrekening + ' '+'(' + b.bank  +' - '+ bo.accountname+ ')'  as content,b.bank,bo.accountname from bankoption bo left join bank b on bo.idbank=b.idbank where bo.isdeleted=0 order by bo.accountname asc,b.bank asc", "bankoption")

        dsbank = New DataSet
        colname.Clear()
        colcaption.Clear()
        coltype.Clear()
        colname.AddRange(New String() {"id", "content"})
        colcaption.AddRange(New String() {"ID", "Content"})
        coltype.AddRange(New Type() {GetType(Long), GetType(String)})
        dsbank = sqls.dataSet 'dsbank = createDataTable(strvalue, "bankoption", colname, colcaption, coltype)

        lueRekening.Properties.DataSource = dsbank.Tables("bankoption")
        lueRekening.Properties.DisplayMember = "content"
        lueRekening.Properties.ValueMember = "id"
        lueRekening.EditValue = Nothing
        lueRekening.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueRekening.Properties.BestFit()

        sqls = New SQLs(mystring)
        sqls.DMLQuery("select po.idpaymentoption as id,replace(replace(convert(varchar,convert(Money, po.nominalbayar),1),'.00',''),',','.')+',00' as content from paymentoption po where po.isdeleted=0 order by po.nominalbayar asc", "paymentoption")

        dspayment = New DataSet
        colname.Clear()
        colcaption.Clear()
        coltype.Clear()
        colname.AddRange(New String() {"id", "content"})
        colcaption.AddRange(New String() {"ID", "Content"})
        coltype.AddRange(New Type() {GetType(Long), GetType(String)})
        dspayment = sqls.dataSet 'createDataTable(strvalue, "paymentoption", colname, colcaption, coltype)

        luePaket.Properties.DataSource = dspayment.Tables("paymentoption") 'MYs.dataTable("paymentoption")
        luePaket.Properties.DisplayMember = "content" '
        luePaket.Properties.ValueMember = "id"
        luePaket.EditValue = Nothing
        luePaket.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        luePaket.Properties.BestFit()

        If tmpUserID = "-1" Then
            texUsername.Focus()
        Else
            lueRekening.Focus()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If checkEntry() = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Kesalahan)
            Exit Sub
        End If
        If meRemarks.Text = "" Then
            If dizMsgbox("Catatan masih kosong" & vbCrLf & "Tetap melanjutkan ?", dizMsgboxStyle.Konfirmasi) = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If

        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "content")
        If sqls.getDataSet("content") > 0 Then
            Dim tmptgl As String = sqls.getDataSet("content", 0, "tanggal")
            Dim tmpwaktu As String = sqls.getDataSet("content", 0, "waktu")
            tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
        Else
            tmpnowTime = Now
        End If

        tePaymentNo.Text = generateNO("INV", tmpnowTime, "yyyyMMdd", "belakang", 4)
        Dim idpaymentonline As String = 0
        Dim idcompanyproduct As String = getidcompanyproduct(tmpidcompany, tmpidproduct, tmpidhardware)
        Dim idproducttype As String = getidproducttype(tmpidcompany, tmpidproduct, tmpidhardware)

        Dim dtsqls As New dtsetSQLS(mystring)
        Dim fs As New List(Of String)
        Dim vs As New List(Of Object)
        Dim idtmp As String = GenerateGUID()
        fs.AddRange(New String() {"idpayment", "idbankoption", "idcompanyproduct", "idpaymentoption", "paymentno", "tanggalbayar", "nominalbayar", "nominaldata", "bankpengirim", "norekpengirim", "atasnamapengirim", "remarks", "isvalid", "isdeleted", "deletereason", "createddate", "createdby"})
        vs.AddRange(New Object() {idtmp, lueRekening.EditValue, IIf(idcompanyproduct = -1, "", idcompanyproduct), luePaket.EditValue, tePaymentNo.Text, Format(CDate(deTanggal.EditValue), "dd-MM-yyyy"), tePaket.Tag, tePaket.Text, teBank.Text, teNorek.Text, teNama.Text, meRemarks.Text, 0, 0, "-", tmpUserID})
        sqls.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "lasttime")

        If dtsqls.datasetSave("payment", idtmp, fs, vs, False) = True Then
            sqls = New SQLs(mystring)
            sqls.DMLQuery("select idpayment from payment where paymentno='" & tePaymentNo.Text & "'", "getidpayment")
            idpaymentonline = sqls.getDataSet("getidpayment", 0, "idpayment")

            Dim flite As New List(Of String)
            Dim vlite As New List(Of Object)
            idtmp = GenerateGUID()
            flite.AddRange(New String() {"idpayment", "idpaymentonline", "idbankoption", "idcompanyproduct", "idpaymentoption", "paymentno", "tanggalbayar", "nominalbayar", "nominaldata", "bankpengirim", "norekpengirim", "atasnamapengirim", "remarks", "isvalid", "isdeleted", "deletereason", "createddate", "createdby"})
            vlite.AddRange(New Object() {idtmp, idpaymentonline, lueRekening.EditValue, IIf(idcompanyproduct = -1, DBNull.Value, idcompanyproduct), luePaket.EditValue, tePaymentNo.Text, CDate(deTanggal.EditValue), tePaket.Tag, tePaket.Text, teBank.Text, teNorek.Text, teNama.Text, meRemarks.Text, 0, 0, "", tmpnowTime, tmpUserID})
            Dim dtlite As New dtsetSQLI(dblite)
            dtlite.datasetSave("payment", idtmp, flite, vlite, False)

            dizMsgbox("Data Pembayaran telah tersimpan" & vbCrLf & "Tunggu validasi dari kami beberapa saat lagi", dizMsgboxStyle.Info, Me)
            btnSave.Enabled = False
        End If
    End Sub

    Private Function generateNO(ByVal prefix As String, waktu As Date, ByVal periodeformat As String, ByVal posisinomor As String, ByVal digitnomor As Integer) As String
        Dim retval As String = ""
        Dim sqls As New SQLs(mystring)
        Dim tblname As String = prefix & Format(waktu, periodeformat)

        sqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from generatenumber where tablename='" & tblname & "'", "GetLast")
        Dim idgen As String = -1
        Dim formatStr As String = ""
        Dim currid As Long = 0
        Dim currStrId As String = ""
        Dim posnumber As String = ""
        Dim lenStr As String = ""
        Dim lenId As Long = 0

        If sqls.getDataSet("GetLast") = 0 Then
            formatStr = prefix & "/" & Format(waktu, periodeformat)
            currid = 1
            posnumber = posisinomor
            lenId = digitnomor
        Else
            idgen = sqls.getDataSet("GetLast", 0, "idgeneratenumber")
            formatStr = sqls.getDataSet("GetLast", 0, "formatstring")
            currid = CInt(sqls.getDataSet("GetLast", 0, "lastnumber")) + 1
            posnumber = sqls.getDataSet("GetLast", 0, "positionnumber")
            lenId = CInt(sqls.getDataSet("GetLast", 0, "digitnumber"))
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

        Dim dtsave As New dtsetSQLS(mystring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idgeneratenumber", "tablename", "formatstring", "lastnumber", "positionnumber", "digitnumber"})
        value.AddRange(New String() {idgen, tblname, formatStr, currid, posnumber, lenId})
        dtsave.datasetSave("generatenumber", idgen, field, value, False)

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

        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select nominaldata,nominalbayar from paymentoption po where po.idpaymentoption='" & luePaket.EditValue & "'", "nominaldata")
        If sqls.getDataSet("nominaldata") > 0 Then
            tePaket.Text = CLng(sqls.getDataSet("nominaldata", 0, "nominaldata"))
            tePaket.Tag = CLng(sqls.getDataSet("nominaldata", 0, "nominalbayar"))
        Else
            tePaket.Text = 0
            tePaket.Tag = 0
        End If
    End Sub

    Private Sub teNorek_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teNorek.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNorek) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub teNama_LostFocus(sender As Object, e As EventArgs) Handles teNama.LostFocus
        teNama.Text = StrConv(teNama.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub btnExistCheck_Click(sender As Object, e As EventArgs) Handles btnExistCheck.Click
        Dim vidtoken As String = ""
        Dim vtokenkey1 As String = ""
        Dim vtokenkey2 As String = ""
        Dim vdata As String = ""
        Dim vnominal As Decimal = 0
        Dim vnominaldata As Decimal = 0
        Dim vstring As String = teVoucher.Text
        Dim vcode As String = ""
        Dim vid As String = ""

        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select idvoucher,idtoken,tokenkey1,tokenkey2,voucherdata,vouchernominal,nominaldata,vouchercode from voucher where duedate > getdate() and isdeleted=0 and voucherstring='" & teVoucher.Text & "'", "cekvoucher")

        If sqls.getDataSet("cekvoucher") = 0 Then
            dizMsgbox("Voucher tidak valid", dizMsgboxStyle.Kesalahan, Me)
            teVoucher.Text = ""
            teVoucher.Focus()
            Exit Sub
        Else

            vidtoken = sqls.getDataSet("cekvoucher", 0, "idtoken")
            vtokenkey1 = sqls.getDataSet("cekvoucher", 0, "tokenkey1")
            vtokenkey2 = sqls.getDataSet("cekvoucher", 0, "tokenkey2")
            vdata = sqls.getDataSet("cekvoucher", 0, "voucherdata")
            vnominal = CDec(sqls.getDataSet("cekvoucher", 0, "vouchernominal"))
            vnominaldata = CDec(sqls.getDataSet("cekvoucher", 0, "nominaldata"))
            vcode = sqls.getDataSet("cekvoucher", 0, "vouchercode")
            vid = sqls.getDataSet("cekvoucher", 0, "idvoucher")

            sqls.DMLQuery("select idvoucher from payment where isvalid=1 and isdeleted=0 and idvoucher='" & vid & "'", "cekvoucherused")
            If sqls.getDataSet("cekvoucherused") > 0 Then
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

        sqls.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "content")
        If sqls.getDataSet("content") > 0 Then
            Dim tmptgl As String = sqls.getDataSet("content", 0, "tanggal")
            Dim tmpwaktu As String = sqls.getDataSet("content", 0, "waktu")
            tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
        Else
            tmpnowTime = Now
        End If

        tePaymentNo.Text = generateNO("INV", tmpnowTime, "yyyyMMdd", "belakang", 4)
        Dim idpaymentonline As String = 0
        Dim idcompanyproduct As String = getidcompanyproduct(tmpidcompany, tmpidproduct, tmpidhardware)
        Dim idproducttype As String = getidproducttype(tmpidcompany, tmpidproduct, tmpidhardware)

        Dim dtsqls As New dtsetSQLS(mystring)
        Dim fs As New List(Of String)
        Dim vs As New List(Of Object)
        Dim idbankvoucher As String = 1
        Dim idbankoption As String = 1
        sqls.DMLQuery("select idbank from bank where bank='Voucher'", "getidbankvoucher")
        If sqls.getDataSet("getidbankvoucher") > 0 Then
            idbankvoucher = sqls.getDataSet("getidbankvoucher", 0, "idbank")
        End If
        sqls.DMLQuery("select idbankoption from bankoption where accountname='Voucher'", "getidbankoption")
        If sqls.getDataSet("getidbankoption") > 0 Then
            idbankoption = sqls.getDataSet("getidbankoption", 0, "idbankoption")
        End If

        Dim idtmp As String = GenerateGUID()
        fs.AddRange(New String() {"idpayment", "idvoucher", "idbankoption", "idcompanyproduct", "idpaymentoption", "paymentno", "tanggalbayar", "nominalbayar", "nominaldata", "bankpengirim", "norekpengirim", "atasnamapengirim", "remarks", "isvalid", "isdeleted", "deletereason", "createdby", "createddate"})
        vs.AddRange(New Object() {idtmp, vid, idbankoption, idcompanyproduct, 0, tePaymentNo.Text, Format(tmpnowTime, "dd-MM-yyyy"), vnominal, vnominaldata, "Voucher", "-", "Voucher", "Voucher", 1, 0, "-", tmpUserID, tmpnowTime})

        If dtsqls.datasetSave("payment", idtmp, fs, vs, False) = True Then
            Dim sqlss As New SQLs(mystring)
            idtmp = GenerateGUID()
            'sqlss.DMLQuery("select idpayment from payment where paymentno='" & tePaymentNo.Text & "'", "getidpayment")
            'idpaymentonline = sqlss.getDataSet("getidpayment", 0, "idpayment")

            Dim flite As New List(Of String)
            Dim vlite As New List(Of Object)
            flite.AddRange(New String() {"idpayment", "idvoucher", "idbankoption", "idcompanyproduct", "idpaymentoption", "paymentno", "tanggalbayar", "nominalbayar", "nominaldata", "bankpengirim", "norekpengirim", "atasnamapengirim", "remarks", "isvalid", "isdeleted", "deletereason", "createddate", "createdby"})
            vlite.AddRange(New Object() {idtmp, vid, 1, idcompanyproduct, DBNull.Value, tePaymentNo.Text, tmpnowTime, vnominal, vnominaldata, teBank.Text, teNorek.Text, teNama.Text, meRemarks.Text, 1, 0, "", tmpnowTime, tmpUserID})
            Dim dtlite As New dtsetSQLI(dblite)
            dtlite.datasetSave("payment", idtmp, flite, vlite, False)

            qtyQuota = qtyQuota + vnominaldata

            sqls = New SQLs(dbstring)
            sqlss = New SQLs(mystring)
            Dim lite As New SQLi(dblite)
            Dim quota As New List(Of String)
            quota.Add(tmpidcompanyproduct)
            quota.Add(qtyQuota)

            sqlss.DMLQuery("update companyproduct set quotaamount='" & qtyQuota & "' where idcompanyproduct='" & tmpidcompanyproduct & "'", False)
            'MsgBox(qtyQuota & vbCrLf & vnominaldata)
            sqls.DMLQuery("update sys_appsetting set value='" & qtyQuota & "' where variable='QuotaAmount'", False)
            lite.DMLQuery("update appsetting set value='" & qtyQuota & "' where variable='QuotaAmount'", False)
            Dim dizEngine As New dizEngine.engine
            Dim qtyquotacode As String = dizEngine.processE(qtyQuota)
            sqls.DMLQuery("update sys_appsetting set value='" & qtyquotacode & "' where variable='QuotaAmountCode'", False)
            lite.DMLQuery("update appsetting set value='" & qtyquotacode & "' where variable='QuotaAmountCode'", False)

            dizMsgbox("Data Voucher telah tersimpan" & vbCrLf & "Kuota anda telah bertambah " & vnominaldata, dizMsgboxStyle.Info, Me)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Dispose()
        End If
    End Sub

    Private Function getidproducttype(idcompany As String, idproduct As String, idhardware As String) As String
        Dim retval As String = -1
        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select p.idproducttype from companyproduct cp left join product p on cp.idproduct=p.idproduct where cp.idcompany='" & idcompany & "' and cp.idproduct='" & idproduct & "' and cp.idhardware='" & idhardware & "'", "getidproducttype")

        retval = sqls.getDataSet("getidproducttype", 0, "idproducttype")
        Return retval
    End Function

    Private Function getidcompanyproduct(idcompany As String, idproduct As String, idhardware As String) As String
        Dim retval As String = -1
        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select idcompanyproduct from companyproduct where idcompany='" & idcompany & "' and idproduct='" & idproduct & "' and idhardware='" & idhardware & "'", "getidcompproduct")
        If sqls.getDataSet("getidcompproduct") > 0 Then
            retval = sqls.getDataSet("getidcompproduct", 0, "idcompanyproduct")
        ElseIf sqls.getDataSet("getidcompproduct") = 0 Then
            Dim idtmp As String = GenerateGUID()
            Dim dtsqls As New dtsetSQLS(mystring)
            Dim fs As New List(Of String)
            Dim vs As New List(Of Object)
            fs.AddRange(New String() {"idcompanyproduct", "idcompany", "idproduct", "idhardware", "idcompanyrefferal", "quotaamount", "quotaused", "isdeleted", "deletereason", "createdby", "createddate"})
            vs.AddRange(New Object() {idtmp, idcompany, idproduct, idhardware, IIf(tmpidcompanyrefferal = -1, DBNull.Value, tmpidcompanyrefferal), 0, 0, 0, "", tmpUserID, tmpnowTime})
            dtsqls.datasetSave("companyproduct", idtmp, fs, vs, False)

            sqls = New SQLs(mystring)
            sqls.DMLQuery("select idcompanyproduct from companyproduct where idcompany='" & idcompany & "' and idproduct='" & idproduct & "' and idhardware='" & idhardware & "'", "getidcompproduct")
            retval = sqls.getDataSet("getidcompproduct", 0, "idcompanyproduct")
        End If
        Return retval
    End Function

    Private Sub btnCheckQuota_Click(sender As Object, e As EventArgs) Handles btnCheckQuota.Click
        Dim tkuota As Decimal = 0
        Dim tusage As Decimal = 0
        Dim tpayment As Decimal = 0

        Dim idcompanyproduct As String = getidcompanyproduct(tmpidcompany, tmpidproduct, tmpidhardware)
        Dim idproducttype As String = getidproducttype(tmpidcompany, tmpidproduct, tmpidhardware)

        Dim sqls As New SQLs(mystring)
        Dim val As New List(Of String)
        val.Add(idcompanyproduct)

        sqls.DMLQuery("select (select isnull(sum(nominaldata),0) as nominaldata from payment where idcompanyproduct='" & idcompanyproduct & "' and isvalid=1 and isdeleted=0)-(select isnull(sum(nominaldata),0) as nominaldata from dailyusage where idcompanyproduct='" & idcompanyproduct & "' and isdeleted=0 and postdate=(select max(postdate) as postdate from dailyusage where idcompanyproduct='" & idcompanyproduct & "' and isdeleted=0)) as nominaldata", "getkuota")
        If sqls.getDataSet("getkuota") > 0 Then
            tkuota = CDec(sqls.getDataSet("getkuota", 0, "nominaldata"))
        End If
        val.Add(tkuota)

        sqls.DMLQuery("update companyproduct set quotaamount='" & tkuota & "' where idcompanyproduct='" & idcompanyproduct & "'", False)

        val.Clear()
        val.Add(idcompanyproduct)

        sqls.DMLQuery("select isnull(sum(nominaldata),0) as nominaldata from payment where idcompanyproduct='" & idcompanyproduct & "' and isvalid=1 and isdeleted=0", "getpayment")
        If sqls.getDataSet("getpayment") > 0 Then
            tpayment = CDec(sqls.getDataSet("getpayment", 0, "nominaldata"))
        End If

        sqls.DMLQuery("select isnull(sum(nominaldata),0) as nominaldata from dailyusage where idcompanyproduct='" & idcompanyproduct & "' and isdeleted=0 and convert(varchar,postdate,105)=convert(varchar,(select max(postdate) as postdate from dailyusage where idcompanyproduct='" & idcompanyproduct & "' and isdeleted=0),105)", "getusage")
        If sqls.getDataSet("getusage") > 0 Then
            tusage = CDec(sqls.getDataSet("getusage", 0, "nominaldata"))
        End If
        val.Add(tusage)

        sqls.DMLQuery("update companyproduct set quotaused='" & tusage & "' where idcompanyproduct='" & idcompanyproduct & "'", False)

        ' If tkuota > 0 Then
        Dim sqlss As New SQLs(dbstring)
        Dim lite As New SQLi(dblite)
        sqlss.DMLQuery("update sys_appsetting set value='" & tpayment & "' where variable='QuotaAmount'", False)
        lite.DMLQuery("update appsetting set value='" & tpayment & "' where variable='QuotaAmount'", False)

        Dim dizEngine As New dizEngine.engine
        Dim qtyquotacode As String = dizEngine.processE(tpayment)
        sqlss.DMLQuery("update sys_appsetting set value='" & qtyquotacode & "' where variable='QuotaAmountCode'", False)
        lite.DMLQuery("update appsetting set value='" & qtyquotacode & "' where variable='QuotaAmountCode'", False)

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

    Private Sub btnUserCheck_Click(sender As Object, e As EventArgs) Handles btnUserCheck.Click
        Me.Cursor = Cursors.WaitCursor
        Dim sqls As New SQLs(mystring)
        
        sqls.DMLQuery("select iduser,idtoken,tokenkey1,tokenkey2,password from [user] where username='" & texUsername.Text & "'", "user")
        If sqls.getDataSet("user") > 0 Then
            tmpidtoken = sqls.getDataSet("user", 0, "idtoken")
            tmptokenkey1 = sqls.getDataSet("user", 0, "tokenkey1")
            tmptokenkey2 = sqls.getDataSet("user", 0, "tokenkey2")
            Dim tmppassword As String = sqls.getDataSet("user", 0, "password")
            Dim strpassword As String = GeneratePass(texPassword.Text, tmptokenkey1, tmptokenkey2, 8000)
            If tmppassword = strpassword Then
                
                sqls.DMLQuery("select iduser,namalengkap,personalno,cardtype,address,zipcode,email,handphone,hint,recoveryquestion,recoveryanswer,username,password from [user] where username='" & texUsername.Text & "'", "useronline")
                tmpUserID = sqls.getDataSet("useronline", 0, "iduser")
                tmpUserFromOnline = True
                Me.Cursor = Cursors.Default

                texUsername.Text = ""
                texPassword.Text = ""
                btnUserCheck.Enabled = False
                panelLogin.Visible = False
                panelLogin.SendToBack()
                tlpEntry.Visible = True
                btnExistCheck.Enabled = True

                btnCheckQuota.Enabled = True
                btnHistory.Enabled = True
                btnSave.Enabled = True
                tlpEntry.BringToFront()
            Else
                tmpUserFromOnline = False
                dizMsgbox("Password tidak valid", dizMsgboxStyle.Info, Me)
                texPassword.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        Else
            tmpUserFromOnline = False
            dizMsgbox("Pengguna tidak ditemukan", dizMsgboxStyle.Info, Me)
            texUsername.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim hp As New frmHistoryPayment(idcompanyproduct)
        hp.ShowDialog()
    End Sub

    Private Sub texPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            btnUserCheck_Click(Me, Nothing)
        End If
    End Sub

    Private Sub texUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texUsername.KeyPress
        If Asc(e.KeyChar) = 13 Then
            texPassword.Focus()
            e.Handled = True
        End If
    End Sub

End Class