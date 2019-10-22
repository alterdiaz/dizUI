Imports DevExpress.XtraGrid.Views.Base
Public Class frmPenerimaanBarangJumlah

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

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        teKode.EditValue = "XXXX/XXX/XXX/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teNote.EditValue = Nothing
        lueSupplier.EditValue = Nothing
        lueSupplier.ReadOnly = False
        lueUnit.EditValue = Nothing
        lueUnit.ReadOnly = False
        deTanggalKirim.EditValue = Nothing
        deTanggalTempo.EditValue = Nothing
        deTanggal.EditValue = Nothing
        btnLock.ForeColor = Color.White
        btnLock.BackColor = Color.Green
        xtcItem.Enabled = False

        kosongkanGrid()
        kosongkanlovsupp()
        gcItem.DataSource = Nothing
    End Sub

    Private dttbl As New DataTable
    Private Sub kosongkanGrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idtransaksidt,d.iditem,i.itemtype,it.generalcode as type,i.kode,i.item,d.qtycontent,d.qtycharges as qtypo,i.idsatuan,d.idsatuan as idsatuanpo,d.idsatuan2,si.satuan,sp.satuan as satuanpo,ss.satuan as satuan2,convert(decimal(8,2),0) as qtycharges,d.remarks,convert(decimal(8,2),0) as qty from transaksidt d left join item i on d.iditem=i.iditem left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='itemtype' left join satuan sp on d.idsatuan=sp.idsatuan left join satuan ss on d.idsatuan2=ss.idsatuan left join satuan si on i.idsatuan=si.idsatuan where 1=0", "data")
        dttbl = sqls.dataTable("data")
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private Sub btnShowHideItem_Click(sender As Object, e As EventArgs) Handles btnShowHideItem.Click
        If btnShowHideItem.Tag = 1 Then
            xtcItem.Visible = True
            btnShowHideItem.Tag = 2
            btnShowHideItem.Text = "<< PO DATA"
        ElseIf btnShowHideItem.Tag = 2 Then
            xtcItem.Visible = False
            btnShowHideItem.Tag = 1
            btnShowHideItem.Text = ">> PO DATA"
        End If
    End Sub

    Private Sub loadlov()
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

    Private Sub loadlovsupp(idsupplier As String, idunit As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@idasal", "@idtujuan"})
        value.AddRange(New Object() {idsupplier, idunit})
        sqls.CallSP("spLoadLOVItemPNB", "getpo", field, value)
        gcItem.DataSource = sqls.dataTable("getpo")
        gvItem.BestFitColumns()
    End Sub

    Private Sub kosongkanlovsupp()
        gcItem.DataSource = Nothing
        gvItem.BestFitColumns()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring)
        Dim dset As New DataSet
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,bp.nama,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,c.username from transaksi t left join businesspartner bp on t.idasal=bp.idbusinesspartner left join sys_user c on c.iduser=t.createdby left join (select idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi) dtot on t.idtransaksi=dtot.idtransaksi where t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodePenerimaanBarang')) and t.transaksistatus in (1) and t.reviewedby is null and t.isdeleted=0 order by t.createddate desc", "gettotal")
        dset = sqls.dataSet
        Dim cari As New frmSearch(dset, "gettotal", "idtransaksi")
        tambahChild(cari)
        If cari.ShowDialog() = Windows.Forms.DialogResult.OK Then
            kosongkanGrid()
            kosongkanIsian(tlpField)

            iddata = cari.GetIDSelectData
            isVoid = False

            lueUnit.EditValue = Nothing
            lueUnit.Properties.ReadOnly = True

            teKode.Text = ""
            deTanggal.EditValue = nowTime

            gcData.Enabled = True

            btnSearch.Enabled = True
            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            btnDelete.Text = "VOID"
            statdata = statusData.Edit

            sqls.DMLQuery("select transaksino,convert(varchar,createddate,105) as tanggal,convert(varchar,createddate,108) as waktu,remarks,idasal,idtujuan from transaksi where idtransaksi='" & iddata & "'", "header")

            lueUnit.EditValue = sqls.getDataSet("header", 0, "idtujuan")
            lueSupplier.EditValue = sqls.getDataSet("header", 0, "idasal")

            teKode.EditValue = sqls.getDataSet("header", 0, "transaksino")
            teNote.EditValue = sqls.getDataSet("header", 0, "remarks")

            Dim tmptgl As String = sqls.getDataSet("header", 0, "tanggal").ToString
            Dim tmpwaktu As String = sqls.getDataSet("header", 0, "waktu").ToString
            deTanggal.EditValue = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
            If sqls.getDataSet("header", 0, "kirimdate") IsNot Nothing Then
                Dim tmptglkrm As String = sqls.getDataSet("header", 0, "kirimdate").ToString
                deTanggalKirim.EditValue = Strdate2Date(tmptglkrm)
            Else
                deTanggalKirim.EditValue = Nothing
            End If
            If sqls.getDataSet("header", 0, "tempodate") IsNot Nothing Then
                Dim tmptgltempo As String = sqls.getDataSet("header", 0, "tempodate").ToString
                deTanggalTempo.EditValue = Strdate2Date(tmptgltempo)
            Else
                deTanggalTempo.EditValue = Nothing
            End If

            Dim sqls1 As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"@id"})
            value.AddRange(New Object() {iddata})
            sqls1.CallSP("spPOcurrent", "po", field, value)
            dttbl = sqls1.dataTable("po")
            gcData.DataSource = dttbl
            gvData.BestFitColumns()
        End If
    End Sub

    Private statdata As statusData
    Private iddata As String = ""
    Private idtrans As String = ""
    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        Dim ceksuppunit As Boolean = True
        If lueSupplier.EditValue Is Nothing Then
            ceksuppunit = False
        End If
        If lueUnit.EditValue Is Nothing Then
            ceksuppunit = False
        End If
        If ceksuppunit = False Then
            dizMsgbox("Supplier Unit belum dipilih", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If btnLock.BackColor = Color.Maroon Then
            If gvData.RowCount > 0 Then
                If dizMsgbox("Item terpilih akan dihapus" & vbCrLf & "Tetap melanjutkan ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi", Me) = dizMsgboxValue.Batal Then
                    Exit Sub
                End If
            End If

            btnLock.ForeColor = Color.White
            btnLock.BackColor = Color.Green
            lueUnit.ReadOnly = False
            lueSupplier.ReadOnly = False
            xtcItem.Enabled = False
            kosongkanlovsupp()
            idunit = ""
        Else
            btnLock.ForeColor = Color.White
            btnLock.BackColor = Color.Maroon
            lueUnit.ReadOnly = True
            lueSupplier.ReadOnly = True
            xtcItem.Enabled = True
            loadlovsupp(lueSupplier.EditValue, lueUnit.EditValue)
            idunit = lueUnit.EditValue
        End If
    End Sub

    Private Sub frmPenerimaanBarangM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.Properties.ReadOnly = True
        teKode.Properties.ReadOnly = True

        seQty.MinValue = 0
        seQty.MaxValue = 1000
        loadlov()

        checkFieldMaxLength(dbstring, tlpField, "transaksi")
        kosongkanGrid()
        kosongkanIsian(tlpField)

        iddata = "-1"
        isVoid = False
        teKode.Text = "XXXX/XXX/XXX/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teKode.ReadOnly = True
        deTanggal.EditValue = nowTime
        teNote.Properties.ReadOnly = False
        teNote.EditValue = Nothing
        lueSupplier.Properties.ReadOnly = True
        lueSupplier.EditValue = Nothing
        lueUnit.Properties.ReadOnly = True
        lueUnit.EditValue = Nothing

        btnSearch.Enabled = True
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnDelete.Text = "VOID"
        statdata = statusData.Baru

        'sccForm.SplitterPosition = sccForm.Width - 275
        xtcItem.Visible = True
        btnShowHideItem.Tag = 2
        btnShowHideItem.Text = ">> PO DATA"
    End Sub

    Private iddept As String = ""
    Private idunit As String = ""
    Private Sub btnItemSelect_Click(sender As Object, e As EventArgs) Handles btnItemSelect.Click
        If gvItem.FocusedRowHandle < 0 Then Exit Sub

        Dim idpo As String = ""
        Dim idx As Integer = gvItem.FocusedRowHandle
        Dim dr As DataRow = gvItem.GetDataRow(idx)
        idpo = dr("idtransaksi")

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idtransaksidt,d.iditem,i.itemtype,it.generalcode as type,i.kode,i.item,d.qtycontent,d.qtycharges as qtypo,i.idsatuan,d.idsatuan as idsatuanpo,d.idsatuan2,si.satuan,sp.satuan as satuanpo,ss.satuan as satuan2,isnull(d2.qtycharges,d.qtycharges) as qtycharges,d.remarks,isnull(d2.qtycharges,d.qtycharges)*d.qtycontent as qty,d.harga,d.discpersen,d.discamount from transaksidt d left join transaksidt d2 on d.idtransaksi=d2.idtransaksi2 left join item i on d.iditem=i.iditem left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='itemtype' left join satuan sp on d.idsatuan=sp.idsatuan left join satuan ss on d.idsatuan2=ss.idsatuan left join satuan si on i.idsatuan=si.idsatuan where d.idtransaksi='" & idpo & "'", "cekpo")
        dttbl = sqls.dataTable("cekpo")
        gcData.DataSource = dttbl
        gvData.BestFitColumns()

        sqls.DMLQuery("select '-' as remarks,'0' as transaksino,t.remarks,t.kirimdate,t.tempodate from transaksi t where t.idtransaksi='" & idpo & "'", "cekhd")

        sqls.DMLQuery("select [value] from sys_appsetting where variable='IDLogDept'", "getidlog")
        If sqls.getDataSet("getidlog") > 0 Then
            iddept = sqls.getDataSet("getidlog", 0, "value")
        End If

        'sqls.DMLQuery("select idtransaksi from transaksi where transaksistatus=1 and idtransaksireff='" & idpo & "' and transaksitype in (select idtransactiontype from transactiontype tt where tt.jenistransaksi='Penerimaan Barang' and tt.iddepartment=(select [value] from sys_appsetting where variable='IDLogDept') and tt.idunit='" & idunit & "')", "getexist")

        'If sqls.getDataSet("getexist") = 0 Then
        Dim pair As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Penerimaan Barang", True)
        Dim idtrans As String = pair.Key
        Dim notrans As String = pair.Value
        Me.idtrans = idtrans
        teKode.Text = notrans
        teNote.EditValue = "-"
        deTanggal.EditValue = nowTime
        deTanggalKirim.EditValue = nowTime
        deTanggalTempo.EditValue = nowTime
        statdata = statusData.Baru
        'Else
        '    iddata = sqls.getDataSet("getexist", 0, "idtransaksi")
        '    sqls.DMLQuery("select transaksitype,transaksino,convert(varchar,createddate,105)+' '+convert(varchar,createddate,108) as transaksidate,remarks,convert(varchar,kirimdate,105)+' '+convert(varchar,kirimdate,108) as kirimdate,convert(varchar,tempodate,105)+' '+convert(varchar,tempodate,108) as tempodate from transaksi where idtransaksi='" & iddata & "'", "gethd")
        '    Dim idtrans As String = sqls.getDataSet("gethd", 0, "transaksitype")
        '    Dim notrans As String = sqls.getDataSet("gethd", 0, "transaksino")
        '    Dim remarks As String = sqls.getDataSet("gethd", 0, "remarks")
        '    Dim tgltrans As String = sqls.getDataSet("gethd", 0, "createddate")
        '    Dim tglkirim As String = sqls.getDataSet("gethd", 0, "kirimdate")
        '    Dim tgltempo As String = sqls.getDataSet("gethd", 0, "tempodate")

        '    Me.idtrans = idtrans
        '    teKode.Text = notrans
        '    teNote.EditValue = remarks
        '    deTanggal.EditValue = If(tgltrans is nothing, nowTime, Strdatetime2Datetime(tgltrans))
        '    deTanggalKirim.EditValue = If(tglkirim is nothing, nowTime, Strdatetime2Datetime(tglkirim))
        '    deTanggalTempo.EditValue = If(tgltrans is nothing, nowTime, Strdatetime2Datetime(tgltrans))
        '    statdata = statusData.Edit
        'End If

        idParent = idpo

        btnSearch.Enabled = True
        btnNew.Enabled = True
        btnSave.Enabled = True
        btnDelete.Enabled = False
    End Sub

    Private idParent As String = ""
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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

        If statdata = statusData.Baru Then
            Dim pair As KeyValuePair(Of String, String) = generateno2(lueUnit.EditValue, iddept, "Penerimaan Barang", False)
            Dim idtrans As String = pair.Key
            Dim notrans As String = pair.Value
            Me.idtrans = idtrans
            teKode.Text = notrans
        End If

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim retval As Boolean = False
        Dim sqls As New SQLs(dbstring)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        sqls.DMLQuery("Select top 1 convert(bigint, value) As value from sys_appsetting where variable='AllowAutoReviewBPB'", "autoreview")
        Dim isautoreview As String = sqls.getDataSet("autoreview", 0, "value")

        If iddata = "-1" Then
            iddata = GenerateGUID()
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If isautoreview = "0" Then
            If statdata = statusData.Baru Then
                field.AddRange(New String() {"idtransaksi", "idtransaksireff", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "idtujuan", "tujuantype", "iddepttujuan", "isdeleted", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany", "kirimdate", "tempodate"})
            Else
                field.AddRange(New String() {"idtransaksi", "idtransaksireff", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "idtujuan", "tujuantype", "iddepttujuan", "isdeleted", "remarks", "updatedby", "updateddate", "updatedfromip", "updatedfromhostname", "idcompany", "kirimdate", "tempodate"})
            End If
            value.AddRange(New Object() {iddata, idParent, idtrans, teKode.Text, 1, lueSupplier.EditValue, "BusinessPartner", lueUnit.EditValue, "Unit", iddept, 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp, If(deTanggalKirim.EditValue Is Nothing, DBNull.Value, CDate(deTanggalKirim.EditValue)), If(deTanggalTempo.EditValue Is Nothing, Nothing, CDate(deTanggalTempo.EditValue))})
            retval = dtsql.datasetSave("transaksi", iddata, field, value, False)
        Else
            field.AddRange(New String() {"idtransaksi", "idtransaksireff", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "idtujuan", "tujuantype", "iddepttujuan", "isdeleted", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany", "kirimdate", "tempodate", "reviewedby", "revieweddate", "reviewedfromip", "reviewedfromhostname"})
            value.AddRange(New Object() {iddata, idParent, idtrans, teKode.Text, 6, lueSupplier.EditValue, "BusinessPartner", lueUnit.EditValue, "Unit", iddept, 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp, If(deTanggalKirim.EditValue Is Nothing, DBNull.Value, CDate(deTanggalKirim.EditValue)), If(deTanggalTempo.EditValue Is Nothing, Nothing, CDate(deTanggalTempo.EditValue)), userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
            retval = dtsql.datasetSave("transaksi", iddata, field, value, False)

            'item log
            For i As Integer = 0 To gvData.RowCount - 1
                Dim fieldlog As New List(Of String)
                Dim valuelog As New List(Of Object)
                Dim iditemlog As String = GenerateGUID()
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim iddatadt As String = CStr(dr("idtransaksidt"))
                Dim iditem As String = CStr(dr("iditem"))
                Dim qty As Long = CLng(dr("qtyreceive"))
                fieldlog.AddRange(New String() {"iditemlog", "iditem", "iddepartment", "idunit", "idreff", "tablereff", "idreff2", "tablereff2", "noreff", "trfreff", "qty", "io", "remarks", "createdby", "createddate", "idcompany"})
                valuelog.AddRange(New Object() {iditemlog, iditem, iddept, lueUnit.EditValue, iddata, "Transaksi", iddatadt, "TransaksiDT", teKode.Text, "Penerimaan Barang", qty, 1, "Penerimaan Barang " & teKode.Text, userid, nowTime, idcomp})
                Dim dtsql2 As New dtsetSQLS(dbstring)
                dtsql2.datasetSave("itemlog", iditemlog, fieldlog, valuelog, False)
            Next
            'item unit
            For i As Integer = 0 To gvData.RowCount - 1
                Dim fieldlog As New List(Of String)
                Dim valuelog As New List(Of Object)
                Dim iditemunit As String = ""
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim iddatadt As String = CStr(dr("idtransaksidt"))
                Dim iditem As String = CStr(dr("iditem"))
                Dim qty As Decimal = CDbl(dr("qtyreceive"))

                Dim sqls2 As New SQLs(dbstring)
                sqls2.DMLQuery("select iditemunit,qty from itemunit where iditem='" & iditem & "' and idunit='" & lueUnit.EditValue & "' and iddepartment='" & iddept & "'", "cekitemunit")
                If sqls2.getDataSet("cekitemunit") > 0 Then
                    iditemunit = CStr(sqls2.getDataSet("cekitemunit", 0, "iditemunit"))
                    Dim qtyexist As Decimal = CDbl(sqls2.getDataSet("cekitemunit", 0, "qty"))
                    qty = qtyexist - qty

                    fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "updatedby", "updateddate"})
                    valuelog.AddRange(New Object() {iditemunit, iditem, iddept, lueUnit.EditValue, qty, userid, nowTime})
                Else
                    iditemunit = GenerateGUID()
                    fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "createdby", "createddate"})
                    valuelog.AddRange(New Object() {iditemunit, iditem, iddept, lueUnit.EditValue, qty, userid, nowTime})
                End If

                Dim dtsql2 As New dtsetSQLS(dbstring)
                dtsql2.datasetSave("itemunit", iditemunit, fieldlog, valuelog, False)
            Next
        End If

        If retval = True Then
            sqls = New SQLs(dbstring)
            'retval = sqls.DMLQuery("update transaksi set transaksistatus=3 where idtransaksi='" & idParent & "'", False)

            Dim fielddt As New List(Of String)
            Dim valuedt As New List(Of Object)
            fielddt.AddRange(New String() {"idtransaksidt", "idtransaksi2", "iditem", "kodeitem", "item", "itemtype", "type", "qtydispose", "qtycharges", "qtyreceive", "idsatuan", "satuan", "qtycontent", "idsatuan2", "satuan2", "harga", "subtotal", "discpersen", "discamount", "discsubtotal", "ppn", "remarks", "isdeleted", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany"})
            For i As Integer = 0 To gvData.RowCount - 1
                dtsql = New dtsetSQLS(dbstring)
                valuedt = New List(Of Object)
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim iddt As String = dr("idtransaksidt")
                If iddt = "0" Then
                    iddt = GenerateGUID()
                End If

                Dim subtotal As Decimal = 0
                Dim discsubtotal As Decimal = 0
                Dim subtotaldisc As Decimal = 0
                Dim ppn As Decimal = 0
                Dim subtotaldiscppn As Decimal = 0
                Dim subtotaldiscppnongkir As Decimal = 0

                Dim qty As Decimal = dr("qtycharges")
                Dim harga As Decimal = dr("harga")
                Dim hargatot As Decimal = harga * qty
                Dim discp As Long = dr("discpersen")
                Dim disca As Long = dr("discamount")
                Dim disct As Decimal = disca * qty
                Dim subtot As Decimal = hargatot - disct

                subtotal += hargatot
                discsubtotal += disct
                subtotaldisc += subtot
                subtotaldiscppn += subtot
                subtotaldiscppnongkir += subtot

                valuedt.AddRange(New Object() {iddt, iddata, dr("iditem"), dr("kode"), dr("item"), dr("itemtype"), dr("type"), dr("qtycharges"), dr("qtycharges"), dr("qty"), dr("idsatuan"), dr("satuan"), dr("qtycontent"), dr("idsatuan2"), dr("satuan2"), harga, subtot, discp, disca, disct, 0, dr("remarks"), 0, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp})
                retval = dtsql.datasetSave("transaksidt", iddt, fielddt, valuedt, False)
            Next
            If retval = True Then
                dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
                btnNew_Click(btnNew, Nothing)
            End If
        End If
    End Sub

    'Private Sub gvItem_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvItem.CellValueChanged
    '    If gvItem.RowCount = 0 Then Exit Sub
    '    If e.RowHandle < 0 Then Exit Sub
    '    RemoveHandler gvItem.CellValueChanged, AddressOf gvItem_CellValueChanged

    '    Dim idx As Integer = gvItem.FocusedRowHandle
    '    Dim drc As DataRow = gvItem.GetDataRow(idx)
    '    If drc("cek") = "False" Then
    '        AddHandler gvItem.CellValueChanged, AddressOf gvItem_CellValueChanged
    '        Exit Sub
    '    End If
    '    MsgBox(idx)
    '    For i As Integer = 0 To gvItem.RowCount - 1
    '        If i <> idx Then
    '            Dim dr As DataRow = gvItem.GetDataRow(i)
    '            dr("cek") = "False"
    '        End If
    '    Next
    '    AddHandler gvItem.CellValueChanged, AddressOf gvItem_CellValueChanged
    'End Sub

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
        ElseIf e.Column Is GridColumn3 Then
            If e.Value < 1 Then
                gvData.SetRowCellValue(e.RowHandle, GridColumn3, 1)
            End If
            Dim qtyfakt As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn3))
            Dim isi As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn5))
            gvData.SetRowCellValue(e.RowHandle, gcQty, isi * qtyfakt)
        ElseIf e.Column Is GridColumn5 Then
            If e.Value < 1 Then
                gvData.SetRowCellValue(e.RowHandle, GridColumn5, 1)
            End If
            Dim qtyfakt As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn3))
            Dim isi As Decimal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn5))
            gvData.SetRowCellValue(e.RowHandle, gcQty, isi * qtyfakt)
        End If
        gvData.BestFitColumns()
        AddHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim additem As New frmTransaksiItemTambahan()
        tambahChild(additem)
        additem.ShowDialog(Me)
        If additem.IsDisposed = False Then
            Dim iditem As String = additem.getIdItem
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select newid() as idtransaksidt,i.iditem,i.itemtype,it.generalcode as type,i.kode,i.item,convert(bigint,1) as qtycontent,convert(bigint,0) as qtypo,convert(bigint,1) as qtycharges,convert(bigint,1) as qty,i.idsatuan,s.satuan as satuan,'-' as idsatuanpo,i.idsatuan as idsatuan2,s.satuan as satuan2,'-' as remarks from item i left join satuan s on i.idsatuan=s.idsatuan left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='itemtype' where i.iditem='" & iditem & "'", "getitem")

            Dim dr As DataRow = dttbl.NewRow
            dr("idtransaksidt") = "0"
            dr("iditem") = iditem
            dr("itemtype") = sqls.getDataSet("getitem", 0, "itemtype")
            dr("type") = sqls.getDataSet("getitem", 0, "type")
            dr("kode") = sqls.getDataSet("getitem", 0, "kode")

            dr("item") = sqls.getDataSet("getitem", 0, "item")
            dr("qtycontent") = sqls.getDataSet("getitem", 0, "qtycontent")
            dr("qtypo") = sqls.getDataSet("getitem", 0, "qtypo")
            dr("satuan") = sqls.getDataSet("getitem", 0, "satuan")
            dr("idsatuan") = sqls.getDataSet("getitem", 0, "idsatuan")

            dr("idsatuanpo") = sqls.getDataSet("getitem", 0, "idsatuanpo")
            dr("qtycharges") = sqls.getDataSet("getitem", 0, "qtycharges")
            dr("idsatuan2") = sqls.getDataSet("getitem", 0, "idsatuan2")
            dr("qty") = sqls.getDataSet("getitem", 0, "qty")
            dr("satuan2") = sqls.getDataSet("getitem", 0, "satuan2")
            dr("remarks") = sqls.getDataSet("getitem", 0, "remarks")
            dttbl.Rows.Add(dr)
        End If
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Item yang dipilih tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        Dim dr As DataRow = dttbl.Rows(gvData.FocusedRowHandle)
        If dizMsgbox("Item dibawah ini" & vbCrLf & "Item (" & dr("item") & ")" & vbCrLf & "Akan dihapus dari daftar, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            dttbl.Rows.Remove(dr)
            gcData.DataSource = dttbl
        End If
    End Sub

    Private Sub btnDeleteAllItem_Click(sender As Object, e As EventArgs) Handles btnDeleteAllItem.Click
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Item yang dipilih tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If dizMsgbox("Item akan dihapus dari daftar, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            For i As Integer = 0 To gvData.RowCount - 1
                Dim dr As DataRow = dttbl.Rows(gvData.FocusedRowHandle)
                dttbl.Rows.Remove(dr)
            Next
            gcData.DataSource = dttbl
        End If
    End Sub

    Private Sub btnAllItem_Click(sender As Object, e As EventArgs) Handles btnAllItem.Click

    End Sub

    Private Sub teSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teSearch.KeyPress
        If lueUnit.EditValue Is Nothing Then Exit Sub
        If lueSupplier.EditValue Is Nothing Then Exit Sub
        If teSearch.Text.Length = 0 Then Exit Sub
        If idParent = "-1" Then Exit Sub
        If idParent = "" Then Exit Sub
        If idParent = "0" Then Exit Sub

        If Asc(e.KeyChar) = 13 Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select a.idtransaksi from (select t.idtransaksi from transaksi t left join ( select d.idtransaksi,sum(d.qtycharges) as qtys from transaksidt d left join transaksi t on d.idtransaksi=t.idtransaksi where t.idasal='" & lueUnit.EditValue & "' and t.asaltype='Unit' group by d.idtransaksi) qts on t.idtransaksi=qts.idtransaksi left join ( select d.idtransaksi,count(d.qtycharges) as qtyc from transaksidt d left join transaksi t on d.idtransaksi=t.idtransaksi where t.idasal='" & lueUnit.EditValue & "' and t.asaltype='Unit' group by d.idtransaksi) qtc on t.idtransaksi=qtc.idtransaksi where t.transaksistatus=6 and t.idasal='" & lueSupplier.EditValue & "' and t.idtujuan='" & lueUnit.EditValue & "' and t.asaltype='Unit' and t.iddeptasal in (select [value] from sys_appsetting where variable='IDPurcDept') and t.tempodate>getdate() and t.transaksitype in (select idtransactiontype from transactiontype where iddepartment in (select [value] from sys_appsetting where variable='IDPurcDept') and idunit=@idtujuan and jenistransaksi='Pembelian Barang')) a where a.idtransaksi='" & teSearch.Text & "'", "getpo")

            If sqls.getDataSet("getpo") > 0 Then
                Dim idpo As String = ""
                Dim idx As Integer = gvItem.FocusedRowHandle
                Dim dr As DataRow = gvItem.GetDataRow(idx)
                idpo = sqls.getDataSet("getpo", 0, "idtransaksi")

                sqls.DMLQuery("select d.idtransaksidt,d.iditem,i.itemtype,it.generalcode as type,i.kode,i.item,d.qtycontent,d.qtycharges as qtypo,i.idsatuan,d.idsatuan as idsatuanpo,d.idsatuan2,si.satuan,sp.satuan as satuanpo,ss.satuan as satuan2,isnull(d2.qtycharges,d.qtycharges) as qtycharges,d.remarks,isnull(d2.qtycharges,d.qtycharges)*d.qtycontent as qty,d.harga,d.discpersen,d.discamount,d.subtotaldisclainppn from transaksidt d left join transaksidt d2 on d.idtransaksi=d2.idtransaksi2 left join item i on d.iditem=i.iditem left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='itemtype' left join satuan sp on d.idsatuan=sp.idsatuan left join satuan ss on d.idsatuan2=ss.idsatuan left join satuan si on i.idsatuan=si.idsatuan where d.idtransaksi='" & idpo & "'", "cekpo")
                dttbl = sqls.dataTable("cekpo")
                gcData.DataSource = dttbl
                gvData.BestFitColumns()

                sqls.DMLQuery("select '-' as remarks,'0' as transaksino,t.remarks,t.kirimdate,t.tempodate from transaksi t where t.idtransaksi='" & idpo & "'", "cekhd")

                sqls.DMLQuery("select [value] from sys_appsetting where variable='IDLogDept'", "getidlog")
                If sqls.getDataSet("getidlog") > 0 Then
                    iddept = sqls.getDataSet("getidlog", 0, "value")
                End If

                'sqls.DMLQuery("select idtransaksi from transaksi where transaksistatus=1 and idtransaksireff='" & idpo & "' and transaksitype in (select idtransactiontype from transactiontype tt where tt.jenistransaksi='Penerimaan Barang' and tt.iddepartment=(select [value] from sys_appsetting where variable='IDLogDept') and tt.idunit='" & idunit & "')", "getexist")

                'If sqls.getDataSet("getexist") = 0 Then
                Dim pair As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Penerimaan Barang", True)
                Dim idtrans As String = pair.Key
                Dim notrans As String = pair.Value
                Me.idtrans = idtrans
                teKode.Text = notrans
                teNote.EditValue = "-"
                deTanggal.EditValue = nowTime
                deTanggalKirim.EditValue = nowTime
                deTanggalTempo.EditValue = nowTime
                statdata = statusData.Baru
                'Else
                '    iddata = sqls.getDataSet("getexist", 0, "idtransaksi")
                '    sqls.DMLQuery("select transaksitype,transaksino,convert(varchar,createddate,105)+' '+convert(varchar,createddate,108) as transaksidate,remarks,convert(varchar,kirimdate,105)+' '+convert(varchar,kirimdate,108) as kirimdate,convert(varchar,tempodate,105)+' '+convert(varchar,tempodate,108) as tempodate from transaksi where idtransaksi='" & iddata & "'", "gethd")
                '    Dim idtrans As String = sqls.getDataSet("gethd", 0, "transaksitype")
                '    Dim notrans As String = sqls.getDataSet("gethd", 0, "transaksino")
                '    Dim remarks As String = sqls.getDataSet("gethd", 0, "remarks")
                '    Dim tgltrans As String = sqls.getDataSet("gethd", 0, "createddate")
                '    Dim tglkirim As String = sqls.getDataSet("gethd", 0, "kirimdate")
                '    Dim tgltempo As String = sqls.getDataSet("gethd", 0, "tempodate")

                '    Me.idtrans = idtrans
                '    teKode.Text = notrans
                '    teNote.EditValue = remarks
                '    deTanggal.EditValue = If(tgltrans is nothing, nowTime, Strdatetime2Datetime(tgltrans))
                '    deTanggalKirim.EditValue = If(tglkirim is nothing, nowTime, Strdatetime2Datetime(tglkirim))
                '    deTanggalTempo.EditValue = If(tgltrans is nothing, nowTime, Strdatetime2Datetime(tgltrans))
                '    statdata = statusData.Edit
                'End If

                idParent = idpo

                btnSearch.Enabled = True
                btnNew.Enabled = True
                btnSave.Enabled = True
                btnDelete.Enabled = False
            End If
        End If
    End Sub

    Private Sub Search_KeyDown(sender As Object, e As KeyEventArgs) Handles pSearch.KeyDown, lueUnit.KeyDown, xtpItem.KeyDown, xtcItem.KeyDown, tlpForm.KeyDown, tlpField.KeyDown, teNote.KeyDown, teKode.KeyDown, pTitle.KeyDown, pItem.KeyDown, pHeader.KeyDown, pBody.KeyDown, Panel1.KeyDown, lueSupplier.KeyDown, gvItem.KeyDown, gvData.KeyDown, gcItem.KeyDown, gcData.KeyDown, deTanggalTempo.KeyDown, deTanggalKirim.KeyDown, deTanggal.KeyDown, btnShowHideItem.KeyDown, btnSave.KeyDown, btnNew.KeyDown, btnItemSelect.KeyDown, btnDeleteItem.KeyDown, btnDeleteAllItem.KeyDown, btnAllItem.KeyDown
        If e.KeyData = Keys.F3 Then
            teSearch.Focus()
        End If
    End Sub

End Class