Imports DevExpress.XtraGrid.Views.Base

Public Class frmPenyusutanEntry
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        'If Me.WindowState = FormWindowState.Normal Then
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        'End If
    End Sub

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        splashClosed = True
        Me.Dispose()
    End Sub

    Private Sub pMaximize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub pMinimize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        Me.Hide()
    End Sub

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pMinimize.MouseDown, pMaximize.MouseDown, pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = canWrite
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = canWrite
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.MouseEnter, pMaximize.MouseEnter, pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.MouseLeave, pMaximize.MouseLeave, pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        ElseIf sender Is pMaximize Then
            sender.Image = My.Resources.max_w
        ElseIf sender Is pMinimize Then
            sender.Image = My.Resources.min_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pMinimize.MouseUp, pMaximize.MouseUp, pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub frmPenyusutanEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadGrid()
        loadLOV()
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idcoa,coa,remarks from coa where coa<>'-1' and isdeleted=0 order by coa asc", "coaod")
        sqls.DMLQuery("select idcoa,coa,remarks from coa where coa<>'-1' and isdeleted=0 order by coa asc", "coaok")
        sqls.DMLQuery("select idcoa,coa,remarks from coa where coa<>'-1' and isdeleted=0 order by coa asc", "coapd")
        sqls.DMLQuery("select idcoa,coa,remarks from coa where coa<>'-1' and isdeleted=0 order by coa asc", "coapk")
        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='KategoriPajak' order by generalcode asc", "kp")
        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='KategoriKomersial' order by generalcode asc", "kk")
        sqls.DMLQuery("select idunit as id, unit as content from unit where isdeleted=0 and idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit')) order by unit asc", "unit")

        slueUnit.Properties.DataSource = sqls.dataTable("unit")
        slueUnit.Properties.DisplayMember = "content"
        slueUnit.Properties.ValueMember = "id"
        slueUnit.EditValue = Nothing

        slueCOAod.Properties.DataSource = sqls.dataTable("coaod")
        slueCOAod.Properties.DisplayMember = "coa"
        slueCOAod.Properties.ValueMember = "idcoa"
        slueCOAod.EditValue = Nothing

        slueCOAok.Properties.DataSource = sqls.dataTable("coaok")
        slueCOAok.Properties.ValueMember = "idcoa"
        slueCOAok.Properties.DisplayMember = "coa"
        slueCOAok.EditValue = Nothing

        slueCOApd.Properties.DataSource = sqls.dataTable("coapd")
        slueCOApd.Properties.DisplayMember = "coa"
        slueCOApd.Properties.ValueMember = "idcoa"
        slueCOApd.EditValue = Nothing

        slueCOApk.Properties.DataSource = sqls.dataTable("coapk")
        slueCOApk.Properties.DisplayMember = "coa"
        slueCOApk.Properties.ValueMember = "idcoa"
        slueCOApk.EditValue = Nothing

        slueKategoriPajak.Properties.DataSource = sqls.dataTable("kp")
        slueKategoriPajak.Properties.DisplayMember = "content"
        slueKategoriPajak.Properties.ValueMember = "id"
        slueKategoriPajak.EditValue = Nothing

        slueKategoriKomersial.Properties.DataSource = sqls.dataTable("kk")
        slueKategoriKomersial.Properties.DisplayMember = "content"
        slueKategoriKomersial.Properties.ValueMember = "id"
        slueKategoriKomersial.EditValue = Nothing
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        RemoveHandler slueKategoriKomersial.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
        RemoveHandler slueKategoriPajak.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
        RemoveHandler seTotal.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
        RemoveHandler seMasaPakai.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged

        deTanggal.EditValue = nowTime
        teItem.EditValue = Nothing
        seJumlah.EditValue = 0
        seHarga.EditValue = 0
        seTotal.EditValue = 0
        seMasaPakai.EditValue = 0
        seNominal.EditValue = 0

        slueUnit.EditValue = Nothing
        slueKategoriKomersial.EditValue = Nothing
        slueKategoriPajak.EditValue = Nothing
        slueCOAod.EditValue = Nothing
        slueCOAok.EditValue = Nothing
        slueCOApd.EditValue = Nothing
        slueCOApk.EditValue = Nothing

        AddHandler slueKategoriKomersial.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
        AddHandler slueKategoriPajak.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
        AddHandler seTotal.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
        AddHandler seMasaPakai.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
    End Sub

    Private Sub seJumlah_EditValueChanged(sender As Object, e As EventArgs) Handles seJumlah.EditValueChanged, seHarga.EditValueChanged
        seTotal.EditValue = CDec(seJumlah.EditValue) * CDec(seHarga.EditValue)
    End Sub

    'Private Sub seMasaPakai_EditValueChanged(sender As Object, e As EventArgs) Handles seMasaPakai.EditValueChanged
    '    If CDec(seMasaPakai.EditValue) = CDec(0) Then
    '        seNominal.EditValue = 0
    '        Exit Sub
    '    End If
    '    If slueKategoriPajak.EditValue Is Nothing Or slueKategoriPajak.EditValue = CLng(0) Then
    '        seNominal.EditValue = 0
    '        Exit Sub
    '    End If
    '    If slueKategoriKomersial.EditValue = CLng(1) Then
    '        seNominal.EditValue = (CDec(seTotal.EditValue) * (garislurus / 100)) / 12
    '    ElseIf slueKategoriKomersial.EditValue = CLng(2) Then
    '        seNominal.EditValue = (CDec(seTotal.EditValue) * (saldoturun / 100)) / 12
    '    Else
    '        seNominal.EditValue = 0
    '    End If
    'End Sub

    'Private Sub seTotal_EditValueChanged(sender As Object, e As EventArgs) Handles seTotal.EditValueChanged
    '    RemoveHandler seJumlah.EditValueChanged, AddressOf seJumlah_EditValueChanged
    '    RemoveHandler seHarga.EditValueChanged, AddressOf seJumlah_EditValueChanged

    '    If seJumlah.EditValue = 0 Then seJumlah.EditValue = 1

    '    seHarga.EditValue = CDec(seTotal.EditValue) / CDec(seJumlah.EditValue)
    '    seMasaPakai_EditValueChanged(seMasaPakai, Nothing)

    '    AddHandler seJumlah.EditValueChanged, AddressOf seJumlah_EditValueChanged
    '    AddHandler seHarga.EditValueChanged, AddressOf seJumlah_EditValueChanged
    'End Sub

    Private Sub btnMonPenyusutan_Click(sender As Object, e As EventArgs) Handles btnMonPenyusutan.Click
        formTitle = "Monitoring Penyusutan"
        Dim frmMon As New frmPenyusutanMon
        tambahChild(frmMon)
        frmMon.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmMon.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Enabled = False
        frmMon.pMaximize.Enabled = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Function cekIsian() As Boolean
        Dim retval As Boolean = True
        If teItem.EditValue Is Nothing Then
            retval = False
        End If
        If seJumlah.EditValue = 0 Then
            retval = False
        End If
        If seHarga.EditValue = 0 Then
            retval = False
        End If
        If seTotal.EditValue = 0 Then
            retval = False
        End If
        If seMasaPakai.EditValue = 0 Then
            retval = False
        End If
        If seNominal.EditValue = 0 Then
            retval = False
        End If

        If slueUnit.EditValue Is Nothing Then
            retval = False
        End If
        If slueKategoriKomersial.EditValue Is Nothing Then
            retval = False
        End If
        If slueKategoriPajak.EditValue Is Nothing Then
            retval = False
        End If
        If slueCOAod.EditValue Is Nothing Then
            retval = False
        End If
        If slueCOAok.EditValue Is Nothing Then
            retval = False
        End If
        If slueCOApd.EditValue Is Nothing Then
            retval = False
        End If
        If slueCOApk.EditValue Is Nothing Then
            retval = False
        End If
        Return retval
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cekIsian() = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim tmp1 As String = Format(nowTime, "yyyy")
        Dim tmp2 As String = CStr(CInt(Format(nowTime, "MM").Substring(0, 1)) + CInt(Format(nowTime, "MM").Substring(1, 1)))
        Dim tmp3 As String = CStr(CInt(Format(nowTime, "dd").Substring(0, 1)) + CInt(Format(nowTime, "dd").Substring(0, 1)))
        Dim tmp4 As String = Format(nowTime, "HHmmssfff")
        If Len(CStr(tmp3)) = 2 Then
            tmp3 = CInt(CStr(tmp3).Substring(0, 1)) + CInt(CStr(tmp3).Substring(1, 1))
        End If
        Dim tmp11 As Integer = 0
        tmp11 = CInt(tmp1.Substring(0, 1)) + CInt(tmp1.Substring(1, 1)) + CInt(tmp1.Substring(2, 1)) + CInt(tmp1.Substring(3, 1))
        tmp1 = CStr(tmp11)

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iditem from item where upper(replace(replace(item,' ',''),'-',''))='" & teItem.Text.ToUpper.Replace(" ", "").Replace("-", "").ToUpper & "'", "cekitem")
        If sqls.getDataSet("cekitem") > 0 Then
            dizMsgbox("Data Item tersebut sudah ada", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        Dim kodeitem As String = Format(nowTime, "yyyyMMddHHmmssfff")
        Dim kodeupc As String = tmp1 + tmp2 + tmp3 + tmp4
        Dim iditem As String = GenerateGUID()
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)

        field = New List(Of String)
        value = New List(Of Object)
        dtsqls = New dtsetSQLS(dbstring)

        field.AddRange(New String() {"iditem", "iditembrand", "idsatuan", "iditemgrup", "itemtype", "kode", "kodeupc", "item", "remarks", "isdeleted", "createdby", "createddate"})
        value.AddRange(New Object() {iditem, "0", "0", "0", 11, kodeitem, kodeupc, teItem.Text.ToUpper, "", 0, userid, nowTime})
        dtsqls.datasetSave("item", iditem, field, value, False)

        Dim nodok As String = "PENYUSUTAN " & Format(nowTime, "yyyyMMssfff")
        Dim remarkso As String = "PEROLEHAN " & teItem.Text.ToUpper
        Dim remarksp As String = "PENYUSUTAN " & teItem.Text.ToUpper
        Dim iddata As String = GenerateGUID()
        Dim idjurnal As String
        Dim cekbool As Boolean = False

        field = New List(Of String)
        value = New List(Of Object)
        dtsqls = New dtsetSQLS(dbstring)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        field.AddRange(New String() {"idpenyusutan", "idunit", "iditem", "qty", "hargasatuan", "subtotal", "perolehandate", "kategoripajak", "kategorikomersial", "perolehand", "perolehank", "penyusutand", "penyusutank", "masapakai", "isdeleted", "createdby", "createddate", "updatedby", "updateddate", "idcompany"})
        value.AddRange(New Object() {iddata, slueUnit.EditValue, iditem, seJumlah.EditValue, seHarga.EditValue, seTotal.EditValue, nowTime, slueKategoriPajak.EditValue, slueKategoriKomersial.EditValue, slueCOAod.EditValue, slueCOAok.EditValue, slueCOApd.EditValue, slueCOApk.EditValue, seMasaPakai.EditValue, 0, userid, nowTime, DBNull.Value, DBNull.Value, idcomp})
        cekbool = dtsqls.datasetSave("penyusutan", iddata, field, value, False)

        idjurnal = GenerateGUID()
        field = New List(Of String)
        value = New List(Of Object)
        dtsqls = New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idjurnal", "idcoalama", "idcoa", "idreff", "tablereff", "idreff2", "tablereff2", "idunit", "tanggaljurnal", "jumlahuang", "remarks", "nodokumen", "posisidk", "isdeleted", "createdby", "createddate", "nobukti", "issystem", "jurnaltype"})
        value.AddRange(New Object() {idjurnal, slueCOAod.EditValue, slueCOAod.EditValue, iddata, "Penyusutan", "0", "-", slueUnit.EditValue, nowTime, seNominal.EditValue, remarkso, nodok, 1, 0, userid, nowTime, nodok, 0, 3})
        cekbool = dtsqls.datasetSave("jurnal", idjurnal, field, value, False)

        idjurnal = GenerateGUID()
        field = New List(Of String)
        value = New List(Of Object)
        dtsqls = New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idjurnal", "idcoalama", "idcoa", "idreff", "tablereff", "idreff2", "tablereff2", "idunit", "tanggaljurnal", "jumlahuang", "remarks", "nodokumen", "posisidk", "isdeleted", "createdby", "createddate", "nobukti", "issystem", "jurnaltype"})
        value.AddRange(New Object() {idjurnal, slueCOApk.EditValue, slueCOApd.EditValue, iddata, "Penyusutan", "0", "-", slueUnit.EditValue, nowTime, seNominal.EditValue, remarkso, nodok, 2, 0, userid, nowTime, nodok, 0, 3})
        cekbool = dtsqls.datasetSave("jurnal", idjurnal, field, value, False)

        sqls.DMLQuery("select [value] from sys_appsetting where variable='IDLogDept'", "getidlog")
        Dim iddept As String = ""
        If sqls.getDataSet("getidlog") > 0 Then
            iddept = sqls.getDataSet("getidlog", 0, "value")
        End If

        Dim dtsql2 As New dtsetSQLS(dbstring)
        Dim fieldlog As New List(Of String)
        Dim valuelog As New List(Of Object)
        Dim iditemlog As String = GenerateGUID()
        Dim qty As Long = CLng(seJumlah.EditValue)
        fieldlog.AddRange(New String() {"iditemlog", "iditem", "iddepartment", "idunit", "idreff", "tablereff", "idreff2", "tablereff2", "noreff", "trfreff", "qty", "io", "remarks", "createdby", "createddate"})
        valuelog.AddRange(New Object() {iditemlog, iditem, iddept, slueUnit.EditValue, iddata, "Penyusutan", "0", "-", iditem, "Perolehan Aset", qty, 1, "Perolehan Aset " & vbCrLf & kodeitem, userid, nowTime})
        dtsql2 = New dtsetSQLS(dbstring)
        dtsql2.datasetSave("itemlog", iditemlog, fieldlog, valuelog, False)

        fieldlog.Clear()
        valuelog.Clear()
        fieldlog = New List(Of String)
        valuelog = New List(Of Object)
        Dim iditemunit As String = ""
        Dim sqls2 As New SQLs(dbstring)
        sqls2.DMLQuery("select iditemunit,qty from itemunit where iditem='" & iditem & "' and idunit='" & slueUnit.EditValue & "' and iddepartment='" & iddept & "'", "cekitemunit")
        If sqls2.getDataSet("cekitemunit") > 0 Then
            iditemunit = CStr(sqls2.getDataSet("cekitemunit", 0, "iditemunit"))
            Dim qtyexist As Decimal = CDbl(sqls2.getDataSet("cekitemunit", 0, "qty"))
            qty = qtyexist + qty

            fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "updatedby", "updateddate"})
            valuelog.AddRange(New Object() {iditemunit, iditem, iddept, slueUnit.EditValue, qty, userid, nowTime})
        Else
            iditemunit = GenerateGUID()
            fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "createdby", "createddate"})
            valuelog.AddRange(New Object() {iditemunit, iditem, iddept, slueUnit.EditValue, qty, userid, nowTime})
        End If
        dtsql2 = New dtsetSQLS(dbstring)
        dtsql2.datasetSave("itemunit", iditemunit, fieldlog, valuelog, False)

        For i As Integer = 0 To (CInt(seMasaPakai.EditValue) * 12) - 1
            Dim iddatadt As String = GenerateGUID()
            field = New List(Of String)
            value = New List(Of Object)
            dtsqls = New dtsetSQLS(dbstring)

            field.AddRange(New String() {"idpenyusutandt", "idpenyusutan", "penyusutandate", "penyusutand", "penyusutank", "jumlahuang", "isdeleted", "createdby", "createddate", "updatedby", "updateddate", "idcompany"})
            value.AddRange(New Object() {iddatadt, iddata, nowTime.AddMonths(i), slueCOApd.EditValue, slueCOApk.EditValue, seNominal.EditValue, 0, userid, nowTime, DBNull.Value, DBNull.Value, idcomp})
            cekbool = dtsqls.datasetSave("penyusutandt", iddatadt, field, value, False)

            idjurnal = GenerateGUID()
            field = New List(Of String)
            value = New List(Of Object)
            dtsqls = New dtsetSQLS(dbstring)
            field.AddRange(New String() {"idjurnal", "idcoalama", "idcoa", "idreff", "tablereff", "idreff2", "tablereff2", "idunit", "tanggaljurnal", "jumlahuang", "remarks", "nodokumen", "posisidk", "isdeleted", "createdby", "createddate", "nobukti", "issystem", "jurnaltype"})
            value.AddRange(New Object() {idjurnal, slueCOApd.EditValue, slueCOApd.EditValue, iddata, "Penyusutan", iddatadt, "PenyusutanDT", slueUnit.EditValue, nowTime.AddMonths(i), seNominal.EditValue, remarksp, nodok, 1, 0, userid, nowTime, nodok, 0, 3})
            cekbool = dtsqls.datasetSave("jurnal", idjurnal, field, value, False)

            idjurnal = GenerateGUID()
            field = New List(Of String)
            value = New List(Of Object)
            dtsqls = New dtsetSQLS(dbstring)
            field.AddRange(New String() {"idjurnal", "idcoalama", "idcoa", "idreff", "tablereff", "idreff2", "tablereff2", "idunit", "tanggaljurnal", "jumlahuang", "remarks", "nodokumen", "posisidk", "isdeleted", "createdby", "createddate", "nobukti", "issystem", "jurnaltype"})
            value.AddRange(New Object() {idjurnal, slueCOApk.EditValue, slueCOApd.EditValue, iddata, "Penyusutan", iddatadt, "PenyusutanDT", slueUnit.EditValue, nowTime.AddMonths(i), seNominal.EditValue, remarksp, nodok, 2, 0, userid, nowTime, nodok, 0, 3})
            cekbool = dtsqls.datasetSave("jurnal", idjurnal, field, value, False)
        Next
        If cekbool = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            loadGrid()
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Private Sub loadGrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select p.idpenyusutan,p.iditem,i.kode,i.item,p.idunit,u.unit,convert(varchar,p.perolehandate,105) as perolehandate,p.hargasatuan,p.qty,p.subtotal,p.masapakai,p.kategoripajak,p.kategorikomersial,kp.generalcode kp,kk.generalcode kk,p.perolehand,p.perolehank,p.penyusutand,p.penyusutank,pd.coa as coaod,pk.coa as coaok,sd.coa as coapd,sk.coa as coapk,p.isdeleted,del.generalcode as statdata from penyusutan p left join coa pd on p.perolehand=pd.idcoa left join coa pk on p.perolehank=pk.idcoa left join coa sd on p.penyusutand=sd.idcoa left join coa sk on p.penyusutank=sk.idcoa left join sys_generalcode kp on p.kategoripajak=kp.idgeneral and kp.gctype='kategoripajak' left join sys_generalcode kk on p.kategorikomersial=kk.idgeneral and kk.gctype='kategorikomersial' left join sys_generalcode del on p.isdeleted=del.idgeneral and del.gctype='DELETE' left join item i on p.iditem=i.iditem left join unit u on p.idunit=u.idunit order by p.perolehandate desc", "penyusutan")
        gcData.DataSource = sqls.dataTable("penyusutan")
        bgvData.BestFitColumns()
    End Sub

    Private tahun As Integer = 0
    Private garislurus As Double = 0
    Private saldoturun As Double = 0
    Private Sub slueKategoriPajak_EditValueChanged(sender As Object, e As EventArgs) Handles slueKategoriPajak.EditValueChanged, slueKategoriKomersial.EditValueChanged, seTotal.EditValueChanged, seMasaPakai.EditValueChanged
        'If CDec(seMasaPakai.EditValue) = CDec(0) Then
        '    seNominal.EditValue = 0
        '    Exit Sub
        'End If
        RemoveHandler slueKategoriKomersial.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
        RemoveHandler slueKategoriPajak.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
        RemoveHandler seTotal.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
        RemoveHandler seMasaPakai.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged

        If slueKategoriPajak.EditValue Is Nothing Or slueKategoriPajak.EditValue = CLng(0) Then
            seNominal.EditValue = 0

            AddHandler slueKategoriKomersial.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
            AddHandler slueKategoriPajak.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
            AddHandler seTotal.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
            AddHandler seMasaPakai.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged

            Exit Sub
        End If
        If slueKategoriKomersial.EditValue Is Nothing Or slueKategoriKomersial.EditValue = CLng(0) Then
            seNominal.EditValue = 0

            AddHandler slueKategoriKomersial.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
            AddHandler slueKategoriPajak.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
            AddHandler seTotal.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
            AddHandler seMasaPakai.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged

            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select * from sys_generalcode where gctype='KategoriPajak' and idgeneral=" & slueKategoriPajak.EditValue, "getvalue")
        tahun = sqls.getDataSet("getvalue", 0, "idreff")
        garislurus = CDbl(sqls.getDataSet("getvalue", 0, "value1"))
        saldoturun = CDbl(sqls.getDataSet("getvalue", 0, "value2"))

        If seJumlah.EditValue = 0 Then seJumlah.EditValue = 1
        seHarga.EditValue = CDec(seTotal.EditValue) / CDec(seJumlah.EditValue)

        seMasaPakai.EditValue = tahun
        If slueKategoriKomersial.EditValue = CLng(1) Then
            seNominal.EditValue = (CDec(seTotal.EditValue) * (garislurus / 100)) / 12
        ElseIf slueKategoriKomersial.EditValue = CLng(2) Then
            seNominal.EditValue = (CDec(seTotal.EditValue) * (saldoturun / 100)) / 12
        Else
            seNominal.EditValue = 0
        End If

        AddHandler slueKategoriKomersial.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
        AddHandler slueKategoriPajak.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
        AddHandler seTotal.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
        AddHandler seMasaPakai.EditValueChanged, AddressOf slueKategoriPajak_EditValueChanged
    End Sub

    Private Sub bgvData_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles bgvData.FocusedRowChanged
        If bgvData.RowCount = 1 Then
            idxFocus = 0
        Else
            idxFocus = bgvData.FocusedRowHandle
        End If

        Dim dr As DataRow = bgvData.GetDataRow(idxFocus)
        If dr("isdeleted") = 0 Then
            btnDelete.Text = "HAPUS"
        Else
            btnDelete.Text = "AKTIF"
        End If
    End Sub

    Private idxFocus As Integer = 0
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If bgvData.FocusedRowHandle < 0 Then Exit Sub
        If bgvData.RowCount = 1 Then
            idxFocus = 0
        Else
            idxFocus = bgvData.FocusedRowHandle
        End If

        Dim dr As DataRow = bgvData.GetDataRow(idxFocus)
        Dim iddata As String = dr("idpenyusutan")
        Dim idunit As String = dr("idunit")
        Dim iditem As String = dr("iditem")
        Dim kodeitem As String = dr("kode")
        Dim retval As Boolean = False
        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"idpenyusutan", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = dtsqls.datasetSave("penyusutan", iddata, field, value, False)
            If retval Then
                sqls.DMLQuery("update penyusutandt set isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where idpenyusutan='" & iddata & "'", False)
                sqls.DMLQuery("update jurnal set isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where idreff='" & iddata & "' and tablereff='Penyusutan'", False)

                sqls.DMLQuery("select [value] from sys_appsetting where variable='IDLogDept'", "getidlog")
                Dim iddept As String = ""
                If sqls.getDataSet("getidlog") > 0 Then
                    iddept = sqls.getDataSet("getidlog", 0, "value")
                End If
                Dim dtsql2 As New dtsetSQLS(dbstring)
                Dim fieldlog As New List(Of String)
                Dim valuelog As New List(Of Object)
                Dim iditemlog As String = GenerateGUID()
                Dim qty As Long = CLng(seJumlah.EditValue)
                fieldlog.AddRange(New String() {"iditemlog", "iditem", "iddepartment", "idunit", "idreff", "tablereff", "idreff2", "tablereff2", "noreff", "trfreff", "qty", "io", "remarks", "createdby", "createddate"})
                valuelog.AddRange(New Object() {iditemlog, iditem, iddept, idunit, iddata, "Penyusutan", "0", "-", iditem, "Penghapusan Aset", qty, 2, "Penghapusan Aset " & vbCrLf & kodeitem, userid, nowTime})
                dtsql2 = New dtsetSQLS(dbstring)
                dtsql2.datasetSave("itemlog", iditemlog, fieldlog, valuelog, False)

                fieldlog.Clear()
                valuelog.Clear()
                fieldlog = New List(Of String)
                valuelog = New List(Of Object)
                Dim iditemunit As String = ""
                Dim sqls2 As New SQLs(dbstring)
                sqls2.DMLQuery("select iditemunit,qty from itemunit where iditem='" & iditem & "' and idunit='" & idunit & "' and iddepartment='" & iddept & "'", "cekitemunit")
                If sqls2.getDataSet("cekitemunit") > 0 Then
                    iditemunit = CStr(sqls2.getDataSet("cekitemunit", 0, "iditemunit"))
                    Dim qtyexist As Decimal = CDbl(sqls2.getDataSet("cekitemunit", 0, "qty"))
                    qty = qtyexist - qty

                    fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "updatedby", "updateddate"})
                    valuelog.AddRange(New Object() {iditemunit, iditem, iddept, idunit, qty, userid, nowTime})
                Else
                    iditemunit = GenerateGUID()
                    fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "createdby", "createddate"})
                    valuelog.AddRange(New Object() {iditemunit, iditem, iddept, idunit, qty, userid, nowTime})
                End If
                dtsql2 = New dtsetSQLS(dbstring)
                dtsql2.datasetSave("itemunit", iditemunit, fieldlog, valuelog, False)
            End If
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"idpenyusutan", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = dtsqls.datasetSave("penyusutan", iddata, field, value, False)
            If retval Then
                sqls.DMLQuery("update penyusutandt set isdeleted=0,updatedby='" & userid & "',updateddate=getdate() where idpenyusutan='" & iddata & "'", False)
                sqls.DMLQuery("update jurnal set isdeleted=0,updatedby='" & userid & "',updateddate=getdate() where idreff='" & iddata & "' and tablereff='Penyusutan'", False)

                sqls.DMLQuery("select [value] from sys_appsetting where variable='IDLogDept'", "getidlog")
                Dim iddept As String = ""
                If sqls.getDataSet("getidlog") > 0 Then
                    iddept = sqls.getDataSet("getidlog", 0, "value")
                End If
                Dim dtsql2 As New dtsetSQLS(dbstring)
                Dim fieldlog As New List(Of String)
                Dim valuelog As New List(Of Object)
                Dim iditemlog As String = GenerateGUID()
                Dim qty As Long = CLng(seJumlah.EditValue)
                fieldlog.AddRange(New String() {"iditemlog", "iditem", "iddepartment", "idunit", "idreff", "tablereff", "idreff2", "tablereff2", "noreff", "trfreff", "qty", "io", "remarks", "createdby", "createddate"})
                valuelog.AddRange(New Object() {iditemlog, iditem, iddept, idunit, iddata, "Penyusutan", "0", "-", iditem, "Perolehan Aset", qty, 1, "Perolehan Aset " & vbCrLf & kodeitem, userid, nowTime})
                dtsql2 = New dtsetSQLS(dbstring)
                dtsql2.datasetSave("itemlog", iditemlog, fieldlog, valuelog, False)

                fieldlog.Clear()
                valuelog.Clear()
                fieldlog = New List(Of String)
                valuelog = New List(Of Object)
                Dim iditemunit As String = ""
                Dim sqls2 As New SQLs(dbstring)
                sqls2.DMLQuery("select iditemunit,qty from itemunit where iditem='" & iditem & "' and idunit='" & idunit & "' and iddepartment='" & iddept & "'", "cekitemunit")
                If sqls2.getDataSet("cekitemunit") > 0 Then
                    iditemunit = CStr(sqls2.getDataSet("cekitemunit", 0, "iditemunit"))
                    Dim qtyexist As Decimal = CDbl(sqls2.getDataSet("cekitemunit", 0, "qty"))
                    qty = qtyexist + qty

                    fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "updatedby", "updateddate"})
                    valuelog.AddRange(New Object() {iditemunit, iditem, iddept, idunit, qty, userid, nowTime})
                Else
                    iditemunit = GenerateGUID()
                    fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "createdby", "createddate"})
                    valuelog.AddRange(New Object() {iditemunit, iditem, iddept, idunit, qty, userid, nowTime})
                End If
                dtsql2 = New dtsetSQLS(dbstring)
                dtsql2.datasetSave("itemunit", iditemunit, fieldlog, valuelog, False)
            End If
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        btnNew_Click(Me, Nothing)
        loadGrid()
    End Sub

End Class