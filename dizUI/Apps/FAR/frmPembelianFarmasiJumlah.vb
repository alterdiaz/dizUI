Imports DevExpress.XtraGrid.Views.Base

Public Class frmPembelianFarmasiJumlah
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
        Threading.Thread.Sleep(100)
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

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=1", "supp")
        lueSupplier.Properties.DataSource = sqls.dataTable("supp")
        lueSupplier.Properties.ValueMember = "id"
        lueSupplier.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idunit as id,unit as content from unit where idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit')) and isdeleted=0", "unit")
        lueUnit.Properties.DataSource = sqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idsatuan as id,satuan as content from satuan where isdeleted=0", "satuan")
        RepositoryItemLookUpEdit1.DataSource = sqls.dataTable("satuan")
        RepositoryItemLookUpEdit1.ValueMember = "id"
        RepositoryItemLookUpEdit1.DisplayMember = "content"
    End Sub

    Private dttbl As New DataTable
    Private Sub kosongkangrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idtransaksidt,d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,d.discamount,d.discpersen,d.discsubtotal,d.harga,d.subtotal,d.qtycharges,d.qtycontent,d.qtyreceive,d.idsatuan2,d.satuan2,0 as qtymax,'' as remarks,d.isppn,d.ppn,d.subtotaldisclainppn from transaksidt d where 1=0", "data")
        dttbl = sqls.dataTable("data")
        gcData.DataSource = dttbl
    End Sub

    Private Sub loadItem(idtrans As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@idtrans"})
        value.AddRange(New Object() {idtrans})
        sqls.CallSP("spLoadLOVItemSPPF", "getitem", field, value)
        gcItem.DataSource = sqls.dataTable("getitem")
    End Sub

    Private Sub frmPembelianBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.Properties.ReadOnly = True
        teKode.Properties.ReadOnly = True

        seQty.MinValue = 0
        seQty.MaxValue = 1000
        loadLOV()

        checkFieldMaxLength(dbstring, tlpField, "transaksi")
        'btnNew_Click(btnNew, Nothing)
        kosongkangrid()
        kosongkanIsian(tlpField)

        idData = "-1"
        isVoid = False
        teKode.Text = "XXXX/XXX/XXX/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teKode.ReadOnly = True
        deTanggal.EditValue = nowTime
        teNote.Properties.ReadOnly = False
        teNote.EditValue = Nothing
        lueSupplier.Properties.ReadOnly = False
        lueSupplier.EditValue = Nothing
        lueUnit.Properties.ReadOnly = True
        lueUnit.EditValue = Nothing

        btnSearch.Enabled = True
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnDelete.Text = "VOID"
        statData = statusData.Baru

        xtcItem.Visible = True
        btnShowHideItem.Tag = 2
        btnShowHideItem.Text = ">> ITEM DATA"
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"
    Private idParent As String = "-1"

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        kosongkangrid()
        kosongkanIsian(tlpField)

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,c.username as createdby,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate from transaksi t left join sys_user c on t.createdby=c.iduser left join (select idtransaksi2,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi2) dt on t.idtransaksi=dt.idtransaksi2 left join (select idtransaksi2,sum(qtycharges) as total from transaksidt dt group by idtransaksi2) dtot on t.idtransaksi=dtot.idtransaksi2 where t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodePermintaanPembelianFarmasi')) and t.reviewedby is not null and t.isdeleted=0 and t.transaksistatus=6 order by t.createddate desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idtransaksi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idData = cari.GetIDSelectData
            idParent = cari.GetIDSelectData
            isVoid = False
            teKode.Text = "XXXX/XXX/XXX/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
            deTanggal.EditValue = nowTime
            teNote.Properties.ReadOnly = False
            teNote.EditValue = Nothing
            lueSupplier.Properties.ReadOnly = False
            lueSupplier.EditValue = Nothing
            lueUnit.Properties.ReadOnly = True
            lueUnit.EditValue = Nothing
            deTanggalKirim.Properties.ReadOnly = False
            deTanggalKirim.EditValue = nowTime.AddDays(7)
            deTanggalTempo.Properties.ReadOnly = False
            deTanggalTempo.EditValue = nowTime.AddDays(7).AddMonths(1)

            btnSearch.Enabled = True
            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = False
            btnDelete.Text = "VOID"
            statData = statusData.Baru

            sqls.DMLQuery("select idasal from transaksi where idtransaksi='" & idData & "'", "getidunit")
            lueUnit.EditValue = CStr(sqls.getDataSet("getidunit", 0, "idasal"))

            gcData.Enabled = True
            'gcQty.OptionsColumn.ReadOnly = False
            'gcQty.OptionsColumn.AllowEdit = True
            'gcQty.AppearanceCell.BackColor = canWrite
            'GridColumn1.OptionsColumn.ReadOnly = False
            'GridColumn1.OptionsColumn.AllowEdit = True
            'GridColumn1.AppearanceCell.BackColor = canWrite
            'GridColumn3.OptionsColumn.ReadOnly = False
            'GridColumn3.OptionsColumn.AllowEdit = True
            'GridColumn3.AppearanceCell.BackColor = canWrite
            'GridColumn4.OptionsColumn.ReadOnly = False
            'GridColumn4.OptionsColumn.AllowEdit = True
            'GridColumn4.AppearanceCell.BackColor = canWrite
            'GridColumn5.OptionsColumn.ReadOnly = False
            'GridColumn5.OptionsColumn.AllowEdit = True
            'GridColumn5.AppearanceCell.BackColor = canWrite

            loadItem(idData)
            idData = "-1"
        End If
    End Sub

    Private iddept As String

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim bEntry As Boolean = True
        Dim sEntry As String = String.Empty
        If gvData.RowCount = 0 Then
            bEntry = False
            If sEntry.Length = 0 Then
                sEntry = "Item masih kosong"
            Else
                sEntry &= vbCrLf & "Item masih kosong"
            End If
        End If
        If gvData.RowCount > 0 Then
            For i As Integer = 0 To gvData.RowCount - 1
                Dim dr As DataRow = gvData.GetDataRow(i)
                If dr("qtycharges") = 0 Then
                    bEntry = False
                    If sEntry.Length = 0 Then
                        sEntry = "Qty ada yang nol"
                    Else
                        sEntry &= vbCrLf & "Qty ada yang nol"
                    End If
                    Exit For
                End If
            Next
        End If
        If bEntry = False Then
            dizMsgbox("Isian belum valid" & vbCrLf & sEntry, dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim pair As KeyValuePair(Of String, String) = generateno2(lueUnit.EditValue, iddeptpurc, "Pembelian Farmasi", False)
        Dim idtrans As String = pair.Key
        Dim notrans As String = pair.Value
        teKode.Text = notrans

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim retval As Boolean = False
        Dim sqls As New SQLs(dbstring)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        sqls.DMLQuery("select top 1 convert(bigint,value) as value from sys_appsetting where variable='AllowAutoReviewPOFjumlah'", "autoreview")
        Dim isautoreview As String = sqls.getDataSet("autoreview", 0, "value")

        If idData = "-1" Then
            idData = GenerateGUID()
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If isautoreview = "0" Then
            If statData = statusData.Baru Then
                field.AddRange(New String() {"idtransaksi", "idtransaksireff", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "iddeptasal", "idtujuan", "tujuantype", "isdeleted", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany", "kirimdate", "tempodate"})
            Else
                field.AddRange(New String() {"idtransaksi", "idtransaksireff", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "iddeptasal", "idtujuan", "tujuantype", "isdeleted", "remarks", "updatedby", "updateddate", "updatedfromip", "updatedfromhostname", "idcompany", "kirimdate", "tempodate"})
            End If
            value.AddRange(New Object() {idData, idParent, idtrans, teKode.Text, 1, lueUnit.EditValue, "Unit", iddeptpurc, lueSupplier.EditValue, "BusinessPartner", 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp, If(deTanggalKirim.EditValue Is Nothing, DBNull.Value, CDate(deTanggalKirim.EditValue)), If(deTanggalTempo.EditValue Is Nothing, DBNull.Value, CDate(deTanggalTempo.EditValue))})
        Else
            field.AddRange(New String() {"idtransaksi", "idtransaksireff", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "iddeptasal", "idtujuan", "tujuantype", "isdeleted", "remarks", "updatedby", "updateddate", "createdfromip", "createdfromhostname", "idcompany", "kirimdate", "tempodate", "reviewedby", "revieweddate", "reviewedfromip", "reviewedfromhostname"})
            value.AddRange(New Object() {idData, idParent, idtrans, teKode.Text, 1, lueUnit.EditValue, "Unit", iddeptpurc, lueSupplier.EditValue, "BusinessPartner", 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp, If(deTanggalKirim.EditValue Is Nothing, DBNull.Value, CDate(deTanggalKirim.EditValue)), If(deTanggalTempo.EditValue Is Nothing, DBNull.Value, CDate(deTanggalTempo.EditValue)), userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
        End If

        retval = dtsql.datasetSave("transaksi", idData, field, value, False)

        sqls = New SQLs(dbstring)
        retval = sqls.DMLQuery("update transaksi set transaksistatus=3 where idtransaksi='" & idParent & "'", False)

        Dim fielddt As New List(Of String)
        Dim valuedt As New List(Of Object)
        fielddt.AddRange(New String() {"idtransaksidt", "idtransaksi", "iditem", "kodeitem", "item", "itemtype", "type", "qtydispose", "qtycharges", "qtyreceive", "idsatuan", "satuan", "qtycontent", "idsatuan2", "satuan2", "harga", "subtotal", "discpersen", "discamount", "discsubtotal", "ppn", "remarks", "isdeleted", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany"})
        For i As Integer = 0 To gvData.RowCount - 1
            dtsql = New dtsetSQLS(dbstring)
            valuedt = New List(Of Object)
            Dim dr As DataRow = gvData.GetDataRow(i)
            Dim iddt As String = dr("idtransaksidt")
            If iddt = "0" Then
                iddt = GenerateGUID()
            End If
            valuedt.AddRange(New Object() {iddt, idData, dr("iditem"), dr("kode"), dr("item"), dr("itemtype"), dr("type"), dr("qtycharges"), dr("qtycharges"), dr("qtyreceive"), dr("idsatuan"), dr("satuan"), dr("qtycontent"), dr("idsatuan2"), dr("satuan2"), dr("harga"), dr("subtotal"), dr("discpersen"), dr("discamount"), dr("discsubtotal"), dr("ppn"), dr("remarks"), 0, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp})
            retval = dtsql.datasetSave("transaksidt", iddt, fielddt, valuedt, False)
        Next
        If retval = True Then
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Private Function generateNO(ByVal prefix As String, ByVal periodeformat As String, ByVal posisinomor As String, ByVal digitnomor As Integer) As String
        Dim retval As String = ""
        Dim mysqls As New SQLs(dbstring)
        Dim tblname As String = prefix & Format(nowTime, periodeformat)
        mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & "'", "GetLast")
        Dim idgen As String = -1
        Dim formatStr As String = ""
        Dim currid As Long = 0
        Dim currStrId As String = ""
        Dim posnumber As String = ""
        Dim lenStr As String = ""
        Dim lenId As Long = 0

        If mysqls.getDataSet("GetLast") = 0 Then
            formatStr = prefix & "-" & Format(nowTime, periodeformat)
            currid = 1
            posnumber = posisinomor
            lenId = digitnomor
        Else
            idgen = mysqls.getDataSet("GetLast", 0, "idgeneratenumber")

            formatStr = prefix & "-" & Format(nowTime, periodeformat) 'mysqls.getDataSet("GetLast", 0, "formatstring")
            currid = CInt(mysqls.getDataSet("GetLast", 0, "lastnumber")) + 1
            posnumber = mysqls.getDataSet("GetLast", 0, "positionnumber")
            lenId = CInt(mysqls.getDataSet("GetLast", 0, "digitnumber"))
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
            retval = formatStr & "-" & currStrId
        ElseIf posnumber.ToLower = "tengah" Then
            formatStr = prefix & "-" & currStrId & "-" & Format(nowTime, periodeformat)
            retval = formatStr
        ElseIf posnumber.ToLower = "depan" Then
            retval = currStrId & "-" & formatStr
        End If

        Dim dtsave As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If idgen = "-1" Then idgen = GenerateGUID()

        field.AddRange(New String() {"idgeneratenumber", "tablename", "formatstring", "lastnumber", "positionnumber", "digitnumber"})
        value.AddRange(New String() {idgen, tblname, formatStr, currid, posnumber, lenId})
        dtsave.datasetSave("sys_generatenumber", idgen, field, value, False)

        Return retval
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring)
        Dim dset As New DataSet
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,c.username from transaksi t left join sys_user c on c.iduser=t.createdby left join (select idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi) dtot on t.idtransaksi=dtot.idtransaksi where t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodePembelianFarmasi')) and t.transaksistatus in (1) and reviewedby is null and t.isdeleted=0 order by t.createddate desc", "gettotal")
        dset = sqls.dataSet
        Dim cari As New frmSearch(dset, "gettotal", "idtransaksi")
        tambahChild(cari)
        If cari.ShowDialog() = Windows.Forms.DialogResult.OK Then
            kosongkangrid()
            kosongkanIsian(tlpField)

            idData = cari.GetIDSelectData
            isVoid = False

            lueUnit.EditValue = Nothing
            lueUnit.Properties.ReadOnly = True
            iddept = 0

            teKode.Text = ""
            deTanggal.EditValue = nowTime

            gcData.Enabled = True
            gcQty.OptionsColumn.ReadOnly = True
            gcQty.OptionsColumn.AllowEdit = False
            gcQty.AppearanceCell.BackColor = Nothing
            GridColumn1.OptionsColumn.ReadOnly = True
            GridColumn1.OptionsColumn.AllowEdit = False
            GridColumn1.AppearanceCell.BackColor = Nothing
            GridColumn3.OptionsColumn.ReadOnly = True
            GridColumn3.OptionsColumn.AllowEdit = False
            GridColumn3.AppearanceCell.BackColor = Nothing
            GridColumn4.OptionsColumn.ReadOnly = True
            GridColumn4.OptionsColumn.AllowEdit = False
            GridColumn4.AppearanceCell.BackColor = Nothing
            GridColumn5.OptionsColumn.ReadOnly = True
            GridColumn5.OptionsColumn.AllowEdit = False
            GridColumn5.AppearanceCell.BackColor = Nothing

            btnSearch.Enabled = True
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnDelete.Enabled = True
            btnDelete.Text = "VOID"
            statData = statusData.Edit

            sqls.DMLQuery("select transaksino,convert(varchar,createddate,105) as tanggal,convert(varchar,createddate,108) as waktu,remarks,idasal,idtujuan,convert(varchar,kirimdate,105)+' '+convert(varchar,kirimdate,108) as kirimdate,convert(varchar,tempodate,105)+' '+convert(varchar,tempodate,108) as tempodate from transaksi where idtransaksi='" & idData & "'", "header")

            lueUnit.EditValue = sqls.getDataSet("header", 0, "idasal")
            lueSupplier.EditValue = sqls.getDataSet("header", 0, "idtujuan")

            teKode.EditValue = sqls.getDataSet("header", 0, "transaksino")
            teNote.EditValue = sqls.getDataSet("header", 0, "remarks")

            Dim tmptgl As String = sqls.getDataSet("header", 0, "tanggal").ToString
            Dim tmpwaktu As String = sqls.getDataSet("header", 0, "waktu").ToString
            deTanggal.EditValue = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
            If sqls.getDataSet("header", 0, "kirimdate") Is Nothing Then
                Dim tmptglkrm As String = sqls.getDataSet("header", 0, "kirimdate").ToString
                deTanggalKirim.EditValue = Strdate2Date(tmptglkrm)
            End If
            If sqls.getDataSet("header", 0, "tempodate") Is Nothing Then
                Dim tmptgltempo As String = sqls.getDataSet("header", 0, "tempodate").ToString
                deTanggalTempo.EditValue = Strdate2Date(tmptgltempo)
            End If

            Dim sqls1 As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"@id"})
            value.AddRange(New Object() {idData})
            sqls1.CallSP("spPOFcurrent", "po", field, value)
            dttbl = sqls1.dataTable("po")
            gcData.DataSource = dttbl

            For i As Integer = 0 To gvData.RowCount - 1
                Dim sqls2 As New SQLs(dbstring)
                Dim dra As DataRow = gvData.GetDataRow(i)
                Dim idtrans As String = idData
                Dim iditem As String = dra("iditem")
                Dim field1 As New List(Of String)
                Dim value1 As New List(Of Object)
                field1.AddRange(New String() {"@idtrans", "@iditem"})
                value1.AddRange(New Object() {idtrans, iditem})

                sqls2.CallSP("spLoadLOVItemSPPFGetItem", "getqty", field1, value1)
                If sqls2.getDataSet("getqty") > 0 Then
                    dra("qtymax") = sqls2.getDataSet("getqty", 0, "qty")
                Else
                    dra("qtymax") = 0
                End If
            Next
        End If
    End Sub

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dizMsgbox("Anda akan melakukan void Pembelian Farmasi ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then

            Dim reason As New frmDeleteReason
            Dim strreason As String = ""
            If reason.ShowDialog = Windows.Forms.DialogResult.OK Then
                If reason.reason.Length = 0 Then
                    dizMsgbox("Alasan pembatalan transaksi harus diisi", dizMsgboxStyle.Peringatan, "Peringatan", Me)
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
            strreason = "DELETE NOTE : " & vbCrLf & reason.reason

            Dim dtsets As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idtransaksi", "transaksistatus", "isdeleted", "deletereason"})
            value.AddRange(New Object() {idData, 2, 1, strreason})
            dtsets.datasetSave("transaksi", idData, field, value, False)

            btnDelete.Enabled = False
            isVoid = True

            Dim bmp As Bitmap = My.Resources.stampVoid
            Dim hdc As Int32 = GetDC(0)
            Dim g As Graphics = Graphics.FromHdc(New IntPtr(hdc))
            g.DrawImage(bmp, CInt((Me.Width / 2) - (bmp.Width / 2)), CInt((Me.Height / 2) - (bmp.Height / 2)))
            ReleaseDC(0, hdc)
            g.Dispose()
            bmp.Dispose()
        End If
    End Sub

    Dim iddeptpurc As String
    Private Sub lueUnit_EditValueChanged(sender As Object, e As EventArgs) Handles lueUnit.EditValueChanged
        If lueUnit.EditValue Is Nothing Then
            teKode.Text = "XXXX/XXX/XXX/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
            iddeptpurc = ""
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iddepartment from department where iddepartment in(select value from sys_appsetting where variable='IDPurcDept')", "getidpurc")
            If sqls.getDataSet("getidpurc") > 0 Then
                iddeptpurc = sqls.getDataSet("getidpurc", 0, "iddepartment")
                Dim pair As KeyValuePair(Of String, String) = generateno2(lueUnit.EditValue, iddeptpurc, "Pembelian Farmasi", True)
                Dim idtrans As String = pair.Key
                Dim notrans As String = pair.Value
                teKode.Text = notrans
                teKode.Tag = idtrans
            End If
        End If
    End Sub

    Private Sub btnAllItem_Click(sender As Object, e As EventArgs) Handles btnAllItem.Click
        If gvItem.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If dizMsgbox("Item terpilih sebanyak :  " & gvItem.RowCount & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            For i As Integer = 0 To gvItem.RowCount - 1
                Dim dra As DataRow = gvItem.GetDataRow(i)
                Dim sqls As New SQLs(dbstring)
                Dim cekExist As Boolean = False
                For a As Integer = 0 To gvData.RowCount - 1
                    Dim drc As DataRow = gvData.GetDataRow(a)
                    If drc("iditem") = dra("iditem") Then
                        cekExist = True
                        Exit For
                    End If
                Next
                If cekExist = False Then
                    Dim dr As DataRow = dttbl.NewRow
                    dr("idtransaksidt") = "0"
                    dr("iditem") = dra("iditem")
                    sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,i.isppn,s.satuan,0 as qty from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where i.iditem='" & dra("iditem") & "'", "dataitem")
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("isppn") = sqls.getDataSet("dataitem", 0, "isppn")
                    dr("remarks") = "-"
                    dr("qtycharges") = 0
                    dr("qtycontent") = 1
                    dr("qtyreceive") = 0
                    dr("idsatuan2") = 0
                    dr("satuan2") = "-"
                    dr("harga") = 0
                    dr("subtotal") = 0
                    dr("discpersen") = 0
                    dr("discamount") = 0
                    dr("discsubtotal") = 0
                    dr("ppn") = 0
                    dr("subtotaldisclainppn") = 0

                    Dim idtrans As String = idParent
                    Dim iditem As String = dra("iditem")
                    Dim field As New List(Of String)
                    Dim value As New List(Of Object)
                    field.AddRange(New String() {"@idtrans", "@iditem"})
                    value.AddRange(New Object() {idtrans, iditem})

                    sqls.CallSP("spLoadLOVItemSPPFGetItem", "getqty", field, value)
                    If sqls.getDataSet("getqty") > 0 Then
                        dr("qtymax") = sqls.getDataSet("getqty", 0, "qty")
                    Else
                        dr("qtymax") = 0
                    End If

                    dttbl.Rows.Add(dr)
                End If
                dra("cek") = 0
            Next
            gcData.DataSource = dttbl
            gvData.BestFitColumns()
        End If
    End Sub

    Private Sub btnItemSelect_Click(sender As Object, e As EventArgs) Handles btnItemSelect.Click
        If gvItem.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        For i As Integer = 0 To gvItem.RowCount - 1
            Dim dra As DataRow = gvItem.GetDataRow(i)
            If dra("cek") = "True" Then
                Dim sqls As New SQLs(dbstring)
                Dim cekExist As Boolean = False
                For a As Integer = 0 To gvData.RowCount - 1
                    Dim drc As DataRow = gvData.GetDataRow(a)
                    If drc("iditem") = dra("iditem") Then
                        cekExist = True
                        Exit For
                    End If
                Next
                If cekExist = False Then
                    Dim dr As DataRow = dttbl.NewRow
                    dr("idtransaksidt") = "0"
                    dr("iditem") = dra("iditem")
                    sqls.DMLQuery("Select i.iditem,i.itemtype,i.idsatuan,gc.generalcode As type,i.kode,i.item,i.isppn,s.satuan,0 As qty from item i left join sys_generalcode gc On gc.idgeneral=i.itemtype And gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where i.iditem='" & dra("iditem") & "'", "dataitem")
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("isppn") = sqls.getDataSet("dataitem", 0, "isppn")
                    dr("remarks") = "-"
                    dr("qtycharges") = 0
                    dr("qtycontent") = 1
                    dr("qtyreceive") = 0
                    dr("idsatuan2") = 0
                    dr("satuan2") = "-"
                    dr("harga") = 0
                    dr("subtotal") = 0
                    dr("discpersen") = 0
                    dr("discamount") = 0
                    dr("discsubtotal") = 0
                    dr("ppn") = 0
                    dr("subtotaldisclainppn") = 0

                    Dim idtrans As String = idParent
                    Dim iditem As String = dra("iditem")
                    Dim field As New List(Of String)
                    Dim value As New List(Of Object)
                    field.AddRange(New String() {"@idtrans", "@iditem"})
                    value.AddRange(New Object() {idtrans, iditem})

                    sqls.CallSP("spLoadLOVItemSPPFGetItem", "getqty", field, value)
                    If sqls.getDataSet("getqty") > 0 Then
                        dr("qtymax") = sqls.getDataSet("getqty", 0, "qty")
                    Else
                        dr("qtymax") = 0
                    End If

                    dttbl.Rows.Add(dr)
                End If
                dra("cek") = 0
            End If
        Next
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private strFocus As String = ""
    Private Sub gvData_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvData.CellValueChanged
        If e.RowHandle < 0 Then Exit Sub
        RemoveHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged

        If e.Column Is GridColumn4 Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select satuan from satuan where idsatuan='" & e.Value & "'", "getval")
            If sqls.getDataSet("getval") > 0 Then
                gvData.SetRowCellValue(e.RowHandle, GridColumn6, sqls.getDataSet("getval", 0, "satuan"))
            Else
                gvData.SetRowCellValue(e.RowHandle, GridColumn6, "-")
            End If
        ElseIf e.Column Is GridColumn5 Then
            If e.Value < 1 Then
                gvData.SetRowCellValue(e.RowHandle, GridColumn5, 1)
            End If
            Dim qtyfakt As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn3))
            Dim isi As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn5))
            gvData.SetRowCellValue(e.RowHandle, gcQty, isi * qtyfakt)
        ElseIf e.Column Is GridColumn3 Then
            Dim isi As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn5))
            Dim harga As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn13))
            Dim qtyfakt As Decimal = CDec(e.Value)
            Dim discP As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn7))
            Dim discR As Decimal = (discP / 100) * harga
            Dim discT As Decimal = discR * qtyfakt
            Dim subt As Decimal = qtyfakt * harga
            Dim subtot As Decimal = subt - discT
            Dim ppn As Decimal = 0
            If gvData.GetRowCellValue(e.RowHandle, GridColumn14) = 1 Then
                ppn = subtot * 0.1
            End If
            Dim subtotppn As Decimal = subt - discT - ppn

            gvData.SetRowCellValue(e.RowHandle, gcQty, isi * qtyfakt)
            gvData.SetRowCellValue(e.RowHandle, GridColumn8, discR)
            gvData.SetRowCellValue(e.RowHandle, GridColumn9, discT)
            gvData.SetRowCellValue(e.RowHandle, GridColumn10, subt)
            gvData.SetRowCellValue(e.RowHandle, GridColumn12, subtotppn)
        ElseIf e.Column Is GridColumn13 Then
            Dim harga As Decimal = CDec(e.Value)
            Dim qtyfakt As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn3))
            Dim discP As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn7))
            Dim discR As Decimal = (discP / 100) * harga
            Dim discT As Decimal = discR * qtyfakt
            Dim subt As Decimal = qtyfakt * harga
            Dim subtot As Decimal = subt - discT
            Dim ppn As Decimal = 0
            If gvData.GetRowCellValue(e.RowHandle, GridColumn14) = 1 Then
                ppn = subtot * 0.1
            End If
            Dim subtotppn As Decimal = subt - discT - ppn

            gvData.SetRowCellValue(e.RowHandle, GridColumn8, discR)
            gvData.SetRowCellValue(e.RowHandle, GridColumn9, discT)
            gvData.SetRowCellValue(e.RowHandle, GridColumn10, subt)
            gvData.SetRowCellValue(e.RowHandle, GridColumn12, subtotppn)
        ElseIf e.Column Is GridColumn7 Then
            Dim harga As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn13))
            Dim qtyfakt As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn3))
            Dim discP As Decimal = CDec(e.Value)
            Dim discR As Decimal = (discP / 100) * harga
            Dim discT As Decimal = discR * qtyfakt
            Dim subt As Decimal = qtyfakt * harga
            Dim subtot As Decimal = subt - discT
            Dim ppn As Decimal = 0
            If gvData.GetRowCellValue(e.RowHandle, GridColumn14) = 1 Then
                ppn = subtot * 0.1
            End If
            Dim subtotppn As Decimal = subt - discT - ppn

            gvData.SetRowCellValue(e.RowHandle, GridColumn8, discR)
            gvData.SetRowCellValue(e.RowHandle, GridColumn9, discT)
            gvData.SetRowCellValue(e.RowHandle, GridColumn10, subt)
            gvData.SetRowCellValue(e.RowHandle, GridColumn12, subtotppn)
        ElseIf e.Column Is GridColumn8 Then
            Dim harga As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn13))
            Dim qtyfakt As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn3))
            Dim discP As Decimal = (CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn8)) / harga) * 100
            Dim discR As Decimal = CDec(e.Value)
            Dim discT As Decimal = discR * qtyfakt
            Dim subt As Decimal = qtyfakt * harga
            Dim subtot As Decimal = subt - discT
            Dim ppn As Decimal = 0
            If gvData.GetRowCellValue(e.RowHandle, GridColumn14) = 1 Then
                ppn = subtot * 0.1
            End If
            Dim subtotppn As Decimal = subt - discT - ppn

            gvData.SetRowCellValue(e.RowHandle, GridColumn8, discR)
            gvData.SetRowCellValue(e.RowHandle, GridColumn9, discT)
            gvData.SetRowCellValue(e.RowHandle, GridColumn10, subt)
            gvData.SetRowCellValue(e.RowHandle, GridColumn12, subtotppn)
        End If
        gvData.BestFitColumns()
        AddHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged
    End Sub

    Private Sub btnShowHideItem_Click(sender As Object, e As EventArgs) Handles btnShowHideItem.Click
        If btnShowHideItem.Tag = 1 Then
            xtcItem.Visible = True
            btnShowHideItem.Tag = 2
            btnShowHideItem.Text = "<< ITEM DATA"
        ElseIf btnShowHideItem.Tag = 2 Then
            xtcItem.Visible = False
            btnShowHideItem.Tag = 1
            btnShowHideItem.Text = ">> ITEM DATA"
        End If
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Item yang dipilih tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        Dim dr As DataRow = dttbl.Rows(gvData.FocusedRowHandle)
        If dizMsgbox("Item dibawah ini" & vbCrLf & "Item (" & dr("item") & ")" & vbCrLf & "Akan dihapus dari daftar, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update transaksidt set isdeleted=1 where idtransaksidt='" & dr("idtransaksidt") & "'", False)
            dttbl.Rows.Remove(dr)
            gcData.DataSource = dttbl
        End If
    End Sub

    Private Sub btnDeleteAllItem_Click(sender As Object, e As EventArgs) Handles btnDeleteAllItem.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If dizMsgbox("Item yang telah dipilih" & vbCrLf & "Akan dihapus keseluruhan dari daftar" & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            For i As Integer = 0 To dttbl.Rows.Count - 1
                Dim dr As DataRow = dttbl.Rows(i)
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("update transaksidt set isdeleted=1 where idtransaksidt='" & dr("idtransaksidt") & "'", False)
                dttbl.Rows.Remove(dr)
                gcData.DataSource = dttbl
            Next
        End If
    End Sub

End Class