Imports DevExpress.XtraGrid.Views.Base
Public Class frmReturPembelianBarang

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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring)
        Dim dset As New DataSet
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,bp.nama,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,c.username from transaksi t left join businesspartner bp on t.idtujuan=bp.idbusinesspartner left join sys_user c on c.iduser=t.createdby left join (select idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi) dtot on t.idtransaksi=dtot.idtransaksi where (convert(varchar,t.createddate,105) like '%" & Format(nowTime.AddMonths(-1), "MM-yyyy") & "' or convert(varchar,t.createddate,105) like '%" & Format(nowTime, "MM-yyyy") & "') and dtot.total<>0 and t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodeReturPembelianBarang')) and t.transaksistatus in (1) and t.reviewedby is null and t.isdeleted=0 order by t.createddate desc", "gettotal")
        dset = sqls.dataSet
        Dim cari As New frmSearch(dset, "gettotal", "idtransaksi")
        tambahChild(cari)
        If cari.ShowDialog() = Windows.Forms.DialogResult.OK Then
            kosongkangrid()
            kosongkanIsian(tlpField)

            idData = cari.GetIDSelectData
            idparent = "-1"
            isVoid = False

            idunit = "0"
            idsupplier = "0"

            teKode.Text = ""
            teSupplier.Text = ""
            teDokumen.Text = ""
            teNote.Text = ""
            deTanggal.EditValue = nowTime
            teUnit.Text = ""
            teReturNo.Text = ""

            gcData.Enabled = True

            btnSearch.Enabled = True
            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            btnDelete.Text = "VOID"
            statData = statusData.Edit

            sqls.DMLQuery("Select t.transaksitype, t.idtransaksireff, isnull(tr.transaksino,'-') as pnbno, isnull(tr.dokumenno,'-') as pnbdokno, t.transaksino, Convert(varchar, t.createddate, 105) As tanggal, Convert(varchar, t.createddate, 108) As waktu, t.remarks, t.idasal, t.idtujuan, s.nama As tujuan, u.unit As asal, t.dokumenno from transaksi t left join transaksi tr on t.idtransaksireff=tr.idtransaksi left join businesspartner s on t.idtujuan=s.idbusinesspartner left join unit u on t.idasal=u.idunit where t.idtransaksi='" & idData & "'", "header")

            sqls.DMLQuery("select [value] from sys_appsetting where variable='IDLogDept'", "getidlog")
            If sqls.getDataSet("getidlog") > 0 Then
                iddept = sqls.getDataSet("getidlog", 0, "value")
            End If

            idunit = sqls.getDataSet("header", 0, "idasal")
            idsupplier = sqls.getDataSet("header", 0, "idtujuan")

            teKode.EditValue = sqls.getDataSet("header", 0, "pnbno")
            teUnit.EditValue = sqls.getDataSet("header", 0, "asal")
            teSupplier.EditValue = sqls.getDataSet("header", 0, "tujuan")
            teDokumen.EditValue = sqls.getDataSet("header", 0, "pnbdokno")
            teNote.EditValue = sqls.getDataSet("header", 0, "remarks")
            deTanggal.EditValue = nowTime
            teReturNo.Text = sqls.getDataSet("header", 0, "transaksino")
            idtrans = sqls.getDataSet("header", 0, "transaksitype")
            idparent = sqls.getDataSet("header", 0, "idtransaksireff")

            Dim tmptgl As String = sqls.getDataSet("header", 0, "tanggal").ToString
            Dim tmpwaktu As String = sqls.getDataSet("header", 0, "waktu").ToString
            deTanggal.EditValue = nowTime 'Strdatetime2Datetime(tmptgl & " " & tmpwaktu)

            Dim sqls1 As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"@id"})
            value.AddRange(New Object() {idData})
            sqls1.CallSP("spPNBRETcurrent", "pnb", field, value)
            dttbl = sqls1.dataTable("pnb")
            gcData.DataSource = dttbl
            gvData.BestFitColumns()
        End If
    End Sub

    Private iddept As String = "0"
    Private idunit As String = "0"
    Private idsupplier As String = "0"
    Private idtrans As String = "0"

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
                If dr("qtycharges2") <= 0 Then
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
        If gvData.RowCount > 0 Then
            For i As Integer = 0 To gvData.RowCount - 1
                Dim dr As DataRow = gvData.GetDataRow(i)
                If dr("qtycharges2") > dr("qtycharges") Then
                    bEntry = False
                    If sEntry.Length = 0 Then
                        sEntry = "Qty Retur melebih Qty Pembelian"
                    Else
                        sEntry &= vbCrLf & "Qty Retur melebih Qty Pembelian"
                    End If
                    Exit For
                End If
            Next
        End If
        If bEntry = False Then
            dizMsgbox("Isian belum valid" & vbCrLf & sEntry, dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        If statData = statusData.Baru Then
            Dim pair As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Retur Pembelian Barang", False)
            Dim idtrans As String = pair.Key
            Dim notrans As String = pair.Value
            teReturNo.Text = notrans
            Me.idtrans = idtrans
        End If

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim retval As Boolean = False
        Dim sqls As New SQLs(dbstring)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        sqls.DMLQuery("select top 1 convert(bigint, value) As value from sys_appsetting where variable='AllowAutoReviewRETB'", "autoreview")
        Dim isautoreview As String = sqls.getDataSet("autoreview", 0, "value")

        If idData = "-1" Then
            idData = GenerateGUID()
        End If

        Dim subtotal As Decimal = 0
        Dim discsubtotal As Decimal = 0
        Dim subtotaldisc As Decimal = 0
        Dim ppn As Decimal = 0
        Dim subtotaldiscppn As Decimal = 0
        Dim subtotaldiscppnongkir As Decimal = 0

        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)

            Dim qty As Decimal = dr("qtycharges2")
            Dim harga As Decimal = dr("harga")
            Dim hargatot As Decimal = harga * qty
            Dim disca As Long = dr("discamount")
            Dim disct As Decimal = disca * qty
            Dim subtot As Decimal = hargatot - disct

            subtotal += hargatot
            discsubtotal += disct
            subtotaldisc += subtot
            subtotaldiscppn += subtot
            subtotaldiscppnongkir += subtot
        Next

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If isautoreview = "0" Then
            If statData = statusData.Baru Then
                field.AddRange(New String() {"idtransaksi", "idtransaksireff", "transaksitype", "transaksino", "transaksistatus", "idtujuan", "tujuantype", "idasal", "asaltype", "iddeptasal", "isdeleted", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany", "subtotal", "discsubtotal", "subtotaldisc", "subtotaldiscppn", "subtotaldiscppnongkir"})
            Else
                field.AddRange(New String() {"idtransaksi", "idtransaksireff", "transaksitype", "transaksino", "transaksistatus", "idtujuan", "tujuantype", "idasal", "asaltype", "iddeptasal", "isdeleted", "remarks", "updatedby", "updateddate", "updatedfromip", "updatedfromhostname", "idcompany", "subtotal", "discsubtotal", "subtotaldisc", "subtotaldiscppn", "subtotaldiscppnongkir"})
            End If
            value.AddRange(New Object() {idData, idparent, idtrans, teReturNo.Text, 1, idsupplier, "BusinessPartner", idunit, "Unit", iddept, 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp, subtotal, discsubtotal, subtotaldisc, subtotaldiscppn, subtotaldiscppnongkir})
            retval = dtsql.datasetSave("transaksi", idData, field, value, False)
        Else
            field.AddRange(New String() {"idtransaksi", "idtransaksireff", "transaksitype", "transaksino", "transaksistatus", "idtujuan", "tujuantype", "idasal", "asaltype", "iddeptasal", "isdeleted", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany", "reviewedby", "revieweddate", "reviewedfromip", "reviewedfromhostname"})
            value.AddRange(New Object() {idData, idparent, idtrans, teReturNo.Text, 6, idsupplier, "BusinessPartner", idunit, "Unit", iddept, 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
            retval = dtsql.datasetSave("transaksi", idData, field, value, False)

            'item log
            For i As Integer = 0 To gvData.RowCount - 1
                Dim fieldlog As New List(Of String)
                Dim valuelog As New List(Of Object)
                Dim iditemlog As String = GenerateGUID()
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim iddatadt As String = CStr(dr("idtransaksidt"))
                Dim iditem As String = CStr(dr("iditem"))
                Dim qty As Long = CLng(dr("qtyreceive"))
                fieldlog.AddRange(New String() {"iditemlog", "iditem", "iddepartment", "idunit", "idreff", "tablereff", "idreff2", "tablereff2", "noreff", "trfreff", "qty", "io", "remarks", "createdby", "createddate"})
                valuelog.AddRange(New Object() {iditemlog, iditem, iddept, idunit, idData, "Transaksi", iddatadt, "TransaksiDT", teKode.Text, "Retur Pembelian Barang", qty, 2, "Retur Pembelian " & teReturNo.Text, userid, nowTime})
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

                Dim dtsql2 As New dtsetSQLS(dbstring)
                dtsql2.datasetSave("itemunit", iditemunit, fieldlog, valuelog, False)
            Next
        End If

        If retval = True Then
            sqls = New SQLs(dbstring)
            'retval = sqls.DMLQuery("update transaksi set transaksistatus=3 where idtransaksi='" & idParent & "'", False)

            Dim fielddt As New List(Of String)
            Dim valuedt As New List(Of Object)
            fielddt.AddRange(New String() {"idtransaksidt", "idtransaksi", "iditem", "kodeitem", "item", "itemtype", "type", "qtydispose", "qtycharges", "qtyreceive", "idsatuan", "satuan", "qtycontent", "idsatuan2", "satuan2", "remarks", "isdeleted", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany", "harga", "subtotal", "discamount", "discsubtotal", "subtotaldisc", "subtotaldisclain", "subtotaldisclainppn"})
            For i As Integer = 0 To gvData.RowCount - 1
                dtsql = New dtsetSQLS(dbstring)
                valuedt = New List(Of Object)
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim iddt As String = dr("idtransaksidt2")
                If iddt = "0" Then
                    iddt = GenerateGUID()
                End If

                Dim subtotal2 As Decimal = CDec(dr("qtycharges2")) * CDec(dr("harga"))
                Dim discsubtotal2 As Decimal = CDec(dr("qtycharges2")) * CDec(dr("discamount"))
                Dim subtotaldisc2 As Decimal = subtotal - discsubtotal

                valuedt.AddRange(New Object() {iddt, idData, dr("iditem"), dr("kode"), dr("item"), dr("itemtype"), dr("type"), dr("qtycharges"), dr("qtycharges"), dr("qty"), dr("idsatuan"), dr("satuan"), dr("qtycontent"), dr("idsatuan2"), dr("satuan2"), dr("remarks"), 0, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp, dr("harga"), subtotal2, dr("discamount"), discsubtotal2, subtotaldisc2, subtotaldisc2, subtotaldisc2})
                retval = dtsql.datasetSave("transaksidt", iddt, fielddt, valuedt, False)
            Next
            If retval = True Then
                dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
                kosongkan()
            End If
        End If
    End Sub

    Private Sub kosongkan()
        kosongkangrid()
        kosongkanIsian(tlpField)

        idData = "-1"
        idparent = "-1"
        isVoid = False

        idunit = "0"
        idsupplier = "0"

        teKode.Text = ""
        teSupplier.Text = ""
        teDokumen.Text = ""
        teNote.Text = ""
        deTanggal.EditValue = nowTime
        teUnit.Text = ""
        teReturNo.Text = ""

        gcData.Enabled = False

        btnSearch.Enabled = True
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = True
        btnDelete.Text = "VOID"
    End Sub

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If idData = "-1" Then
            dizMsgbox("Belum memilih transaksi", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If dizMsgbox("Anda akan melakukan void Retur Barang ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then

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
            strreason = "DELETE NOTE :  " & vbCrLf & reason.reason

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

    Private Sub kosongkangrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idtransaksidt,d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,d.discamount,d.discpersen,d.discsubtotal,d.harga,d.subtotal,d.qtycharges,d.qtycontent,d.qtyreceive,d.idsatuan2,d.satuan2,0 as qtymax,'' as remarks,d.isppn,d.ppn,d.subtotaldisclainppn from transaksidt d where 1=0", "kosong")
        dttbl = sqls.dataTable("kosong")
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private idparent As String = "-1"
    Private idData As String = "-1"
    Private statData As statusData = statusData.Baru
    Private Sub frmReturBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.Properties.ReadOnly = True
        teKode.Properties.ReadOnly = True

        seQty.MinValue = 0
        seQty.MaxValue = 1000

        checkFieldMaxLength(dbstring, tlpField, "transaksi")
        'btnNew_Click(btnNew, Nothing)
        kosongkangrid()
        kosongkanIsian(tlpField)

        idparent = "-1"
        idData = "-1"
        isVoid = False
        teReturNo.Text = "XXXX/XXX/XXX/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teReturNo.ReadOnly = True
        teKode.Text = "XXXX/XXX/XXX/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teKode.ReadOnly = True
        deTanggal.EditValue = nowTime
        teNote.Properties.ReadOnly = False
        teNote.EditValue = Nothing

        btnSearch.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnDelete.Text = "VOID"
        statData = statusData.Baru
        kosongkan()
    End Sub

    Private dttbl As New DataTable
    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Item yang dipilih tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If gvData.RowCount = 1 Then
            dizMsgbox("Item tidak bisa dihapus", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        Dim dr As DataRow = dttbl.Rows(gvData.FocusedRowHandle)
        If dizMsgbox("Item dibawah ini" & vbCrLf & "Item (" & dr("item") & ")" & vbCrLf & "Akan dihapus dari daftar, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            dttbl.Rows.Remove(dr)
            gcData.DataSource = dttbl
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim sqls As New SQLs(dbstring)
        Dim dset As New DataSet
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,bp.nama,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,c.username from transaksi t left join businesspartner bp on t.idasal=bp.idbusinesspartner left join sys_user c on c.iduser=t.createdby left join (select idtransaksi2,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi2) dt on t.idtransaksi=dt.idtransaksi2 left join (select idtransaksi2,sum(qtycharges) as total from transaksidt dt group by idtransaksi2) dtot on t.idtransaksi=dtot.idtransaksi2 where (convert(varchar,t.createddate,105) like '%" & Format(nowTime.AddMonths(-1), "MM-yyyy") & "' or convert(varchar,t.createddate,105) like '%" & Format(nowTime, "MM-yyyy") & "') and dtot.total<>0 and t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodePenerimaanBarang')) and t.transaksistatus not in (1,2,3,4,5) and reviewedby is not null and t.isdeleted=0 order by t.createddate desc", "gettotal")
        dset = sqls.dataSet
        Dim cari As New frmSearch(dset, "gettotal", "idtransaksi")
        tambahChild(cari)
        If cari.ShowDialog() = Windows.Forms.DialogResult.OK Then
            kosongkangrid()
            kosongkanIsian(tlpField)

            idData = "-1"
            idparent = cari.GetIDSelectData
            isVoid = False

            idunit = "0"
            idsupplier = "0"

            teKode.Text = ""
            teSupplier.Text = ""
            teDokumen.Text = ""
            teNote.Text = ""
            deTanggal.EditValue = nowTime
            teUnit.Text = ""
            teReturNo.Text = ""

            gcData.Enabled = True

            btnSearch.Enabled = True
            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            btnDelete.Text = "VOID"
            statData = statusData.Baru

            sqls.DMLQuery("select t.transaksino,convert(varchar,t.createddate,105) as tanggal,convert(varchar,t.createddate,108) as waktu,t.remarks,t.idasal,t.idtujuan,s.nama as asal,u.unit as tujuan,t.dokumenno from transaksi t left join businesspartner s on t.idasal=s.idbusinesspartner left join unit u on t.idtujuan=u.idunit where t.idtransaksi='" & idparent & "'", "header")

            sqls.DMLQuery("select [value] from sys_appsetting where variable='IDLogDept'", "getidlog")
            If sqls.getDataSet("getidlog") > 0 Then
                iddept = sqls.getDataSet("getidlog", 0, "value")
            End If

            idunit = sqls.getDataSet("header", 0, "idtujuan")
            idsupplier = sqls.getDataSet("header", 0, "idasal")

            teKode.EditValue = sqls.getDataSet("header", 0, "transaksino")
            teUnit.EditValue = sqls.getDataSet("header", 0, "tujuan")
            teSupplier.EditValue = sqls.getDataSet("header", 0, "asal")
            teDokumen.EditValue = sqls.getDataSet("header", 0, "dokumenno")
            teNote.EditValue = ""
            deTanggal.EditValue = nowTime

            Dim pair As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Retur Pembelian Barang", True)
            Dim idtrans As String = pair.Key
            Dim notrans As String = pair.Value
            teReturNo.Text = notrans
            Me.idtrans = idtrans

            Dim tmptgl As String = sqls.getDataSet("header", 0, "tanggal").ToString
            Dim tmpwaktu As String = sqls.getDataSet("header", 0, "waktu").ToString
            deTanggal.EditValue = nowTime 'Strdatetime2Datetime(tmptgl & " " & tmpwaktu)

            Dim sqls1 As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"@id"})
            value.AddRange(New Object() {idparent})
            sqls1.CallSP("spPNBcurrent", "pnb", field, value)
            dttbl = sqls1.dataTable("pnb")
            gcData.DataSource = dttbl
            gvData.BestFitColumns()
        End If
    End Sub

    Private Sub gvData_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvData.CellValueChanged
        If e.RowHandle < 0 Then Exit Sub
        RemoveHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged

        If e.Column Is gcQty Then
            If CDec(e.Value) > 0 Then
                Dim subtotal As Decimal = 0
                Dim harga As Decimal = 0
                Dim disc As Decimal = 0
                Dim ppn As Decimal = 0
                harga = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn10))
                disc = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn9))
                ppn = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn11))
                subtotal = (harga - disc - ppn) * CDec(e.Value)
                gvData.SetRowCellValue(e.RowHandle, GridColumn7, subtotal)
            Else
                Dim subtotal As Decimal = 0
                gvData.SetRowCellValue(e.RowHandle, GridColumn7, subtotal)
            End If
        End If

        gvData.BestFitColumns()
        AddHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged
    End Sub

End Class