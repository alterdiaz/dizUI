Imports DevExpress.XtraGrid.Views.Base
Public Class frmPenerimaanBarangFaktur

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

    Private Sub btnNew_Click()
        idunit2 = ""
        iddept2 = ""

        teKode.EditValue = Nothing
        teNote.EditValue = Nothing
        teSupplier.EditValue = Nothing
        teUnit.EditValue = Nothing
        deTanggalKirim.EditValue = Nothing
        deTanggalTempo.EditValue = Nothing
        deTanggal.EditValue = Nothing

        kosongkanGrid()
    End Sub

    Private dttbl As New DataTable
    Private Sub kosongkanGrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idtransaksidt,d.iditem,i.itemtype,it.generalcode as type,i.kode,i.item,d.qtycontent,d.qtycharges as qtypo,i.idsatuan,d.idsatuan as idsatuanpo,d.idsatuan2,si.satuan,sp.satuan as satuanpo,ss.satuan as satuan2,convert(decimal(8,2),0) as qtycharges,d.remarks,convert(decimal(8,2),0) as qty from transaksidt d  left join item i on d.iditem=i.iditem left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='itemtype' left join satuan sp on d.idsatuan=sp.idsatuan left join satuan ss on d.idsatuan2=ss.idsatuan left join satuan si on i.idsatuan=si.idsatuan where 1=0", "data")
        dttbl = sqls.dataTable("data")
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private Sub loadlov()
        Dim sqls As New SQLs(dbstring)

        'sqls.DMLQuery("select idcoa, coa, remarks from coa where isdeleted=0 and (COA<>'-1' and LEN(COA)>=3) order by convert(varchar(20),COA) asc", "dcoa")
        'slueDCOA.Properties.DataSource = sqls.dataTable("dcoa")
        'slueDCOA.Properties.DisplayMember = "coa"
        'slueDCOA.Properties.ValueMember = "idcoa"
        'slueDCOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        'slueDCOA.EditValue = Nothing

        'sqls.DMLQuery("select idcoa, coa, remarks from coa where isdeleted=0 and (COA<>'-1' and LEN(COA)>=3) order by convert(varchar(20),COA) asc", "kcoa")
        'slueKCOA.Properties.DataSource = sqls.dataTable("kcoa")
        'slueKCOA.Properties.DisplayMember = "coa"
        'slueKCOA.Properties.ValueMember = "idcoa"
        'slueKCOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        'slueKCOA.EditValue = Nothing

        sqls.DMLQuery("select idsatuan as id,satuan as content from satuan where isdeleted=0", "satuan")
        RepositoryItemLookUpEdit1.DataSource = sqls.dataTable("satuan")
        RepositoryItemLookUpEdit1.ValueMember = "id"
        RepositoryItemLookUpEdit1.DisplayMember = "content"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring)
        Dim dset As New DataSet
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,u.unit,bp.nama,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,c.username from transaksi t left join unit u on t.idtujuan=u.idunit left join businesspartner bp on t.idasal=bp.idbusinesspartner left join sys_user c on c.iduser=t.createdby left join (select idtransaksi2 as idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi2) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi2 as idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi2) dtot on t.idtransaksi=dtot.idtransaksi where t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi in (select [value] from sys_appsetting where [variable]='KodePenerimaanBarang')) and t.transaksistatus in (1) and t.reviewedby is null and t.isdeleted=0 order by t.createddate desc", "gettotal")
        dset = sqls.dataSet
        Dim cari As New frmSearch(dset, "gettotal", "idtransaksi")
        tambahChild(cari)
        If cari.ShowDialog() = Windows.Forms.DialogResult.OK Then
            kosongkanGrid()
            kosongkanIsian(tlpField)

            iddata = cari.GetIDSelectData
            isVoid = False

            teUnit.EditValue = Nothing

            teKode.Text = ""
            deTanggal.EditValue = nowTime

            gcData.Enabled = True

            btnSearch.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            btnDelete.Text = "VOID"
            statdata = statusData.Edit

            sqls.DMLQuery("select t.transaksino,convert(varchar,t.createddate,105) as tanggal,convert(varchar,t.createddate,108) as waktu,t.remarks,t.idasal,t.idtujuan,t.iddepttujuan,bp.nama as asal,u.unit as tujuan,dokumenno from transaksi t left join businesspartner bp on t.idasal=bp.idbusinesspartner left join unit u on t.idtujuan=u.idunit where t.idtransaksi='" & iddata & "'", "header")

            idunit2 = sqls.getDataSet("header", 0, "idtujuan")
            iddept2 = sqls.getDataSet("header", 0, "iddepttujuan")
            teUnit.EditValue = sqls.getDataSet("header", 0, "tujuan")
            teSupplier.EditValue = sqls.getDataSet("header", 0, "asal")

            teDokumen.EditValue = sqls.getDataSet("header", 0, "dokumenno")
            teKode.EditValue = sqls.getDataSet("header", 0, "transaksino")
            teNote.EditValue = sqls.getDataSet("header", 0, "remarks")

            'slueDCOA.EditValue = Nothing
            'slueKCOA.EditValue = Nothing

            Dim tmptgl As String = sqls.getDataSet("header", 0, "tanggal").ToString
            Dim tmpwaktu As String = sqls.getDataSet("header", 0, "waktu").ToString
            deTanggal.EditValue = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
            If sqls.getDataSet("header", 0, "kirimdate") IsNot Nothing Then
                Dim tmptglkrm As String = sqls.getDataSet("header", 0, "kirimdate").ToString
                deTanggalKirim.EditValue = Strdate2Date(tmptglkrm)
            End If
            If sqls.getDataSet("header", 0, "tempodate") IsNot Nothing Then
                Dim tmptgltempo As String = sqls.getDataSet("header", 0, "tempodate").ToString
                deTanggalTempo.EditValue = Strdate2Date(tmptgltempo)
            End If

            Dim sqls1 As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"@id"})
            value.AddRange(New Object() {iddata})
            sqls1.CallSP("spPOFAKTcurrent", "po", field, value)
            dttbl = sqls1.dataTable("po")
            gcData.DataSource = dttbl
            gvData.BestFitColumns()

            'sqls.DMLQuery("select idcoa from jurnal where posisidk=1 and tablereff='Transaksi' and idreff='" & iddata & "'", "getjurnald")
            'sqls.DMLQuery("select idcoa from jurnal where posisidk=2 and tablereff='Transaksi' and idreff='" & iddata & "'", "getjurnalk")
            'If sqls.getDataSet("getjurnald") > 0 Then
            '    slueDCOA.EditValue = sqls.getDataSet("getjurnald", 0, "idcoa")
            'Else
            '    slueDCOA.EditValue = Nothing
            'End If
            'If sqls.getDataSet("getjurnalk") > 0 Then
            '    slueKCOA.EditValue = sqls.getDataSet("getjurnalk", 0, "idcoa")
            'Else
            '    slueKCOA.EditValue = Nothing
            'End If
        End If
    End Sub

    Private statdata As statusData
    Private iddata As String = ""
    Private idtrans As String = ""

    Private Sub frmPenerimaanBarangFaktur_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        teSupplier.EditValue = Nothing
        teUnit.EditValue = Nothing

        btnSearch.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnDelete.Text = "VOID"
        statdata = statusData.Baru
    End Sub

    Private idunit2 As String = ""
    Private iddept2 As String = ""

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If iddata = "-1" Then
            dizMsgbox("Penerimaan Barang belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

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
        If gvData.RowCount > 0 Then
            For i As Integer = 0 To gvData.RowCount - 1
                Dim dr As DataRow = gvData.GetDataRow(i)
                If dr("harga") = 0 Then
                    bEntry = False
                    If sEntry.Length = 0 Then
                        sEntry = "Harga ada yang nol"
                    Else
                        sEntry &= vbCrLf & "Harga ada yang nol"
                    End If
                    Exit For
                End If
            Next
        End If
        If bEntry = False Then
            If dizMsgbox("Harga ada yang nol" & vbCrLf & "Tetap melanjutkan menyimpan ?", dizMsgboxStyle.Peringatan, Me) = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If

        Dim subtotal As Decimal = 0
        Dim discsubtotal As Decimal = 0
        Dim subtotaldisc As Decimal = 0
        Dim ppn As Decimal = 0
        Dim subtotaldiscppn As Decimal = 0
        Dim subtotaldiscppnongkir As Decimal = 0

        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)

            Dim qty As Decimal = dr("qtycharges")
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

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim retval As Boolean = False
        Dim sqls As New SQLs(dbstring)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        sqls.DMLQuery("Select top 1 convert(bigint, value) As value from sys_appsetting where variable='AllowAutoReviewBPBFaktur'", "autoreview")
        Dim isautoreview As String = sqls.getDataSet("autoreview", 0, "value")
        If isautoreview = "1" Then
            'Dim cekcoa As Boolean = True
            'If slueDCOA.EditValue Is Nothing Then
            '    cekcoa = False
            'End If
            'If slueKCOA.EditValue Is Nothing Then
            '    cekcoa = False
            'End If
            'If cekcoa = False Then
            '    dizMsgbox("COA Debet/Kredit belum dipilih", dizMsgboxStyle.Peringatan, Me)
            '    Exit Sub
            'End If
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If isautoreview = "0" Then
            If statdata = statusData.Baru Then
                field.AddRange(New String() {"idtransaksi", "transaksino", "dokumenno", "transaksistatus", "isdeleted", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany", "kirimdate", "tempodate", "subtotal", "discsubtotal", "subtotaldisc", "ppn", "subtotaldiscppn", "subtotaldiscppnongkir"})
            Else
                field.AddRange(New String() {"idtransaksi", "transaksino", "dokumenno", "transaksistatus", "isdeleted", "remarks", "updatedby", "updateddate", "updatedfromip", "updatedfromhostname", "idcompany", "kirimdate", "tempodate", "subtotal", "discsubtotal", "subtotaldisc", "ppn", "subtotaldiscppn", "subtotaldiscppnongkir"})
            End If
            value.AddRange(New Object() {iddata, teKode.Text, teDokumen.Text, 1, 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp, If(deTanggalKirim.EditValue Is Nothing, DBNull.Value, CDate(deTanggalKirim.EditValue)), If(deTanggalTempo.EditValue Is Nothing, DBNull.Value, CDate(deTanggalTempo.EditValue)), subtotal, discsubtotal, subtotaldisc, ppn, subtotaldiscppn, subtotaldiscppnongkir})
        Else
            field.AddRange(New String() {"idtransaksi", "transaksino", "dokumenno", "transaksistatus", "isdeleted", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany", "kirimdate", "tempodate", "reviewedby", "revieweddate", "reviewedfromip", "reviewedfromhostname", "subtotal", "discsubtotal", "subtotaldisc", "ppn", "subtotaldiscppn", "subtotaldiscppnongkir"})
            value.AddRange(New Object() {iddata, teKode.Text, teDokumen.Text, 6, 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp, If(deTanggalKirim.EditValue Is Nothing, DBNull.Value, CDate(deTanggalKirim.EditValue)), If(deTanggalTempo.EditValue Is Nothing, DBNull.Value, CDate(deTanggalTempo.EditValue)), userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), subtotal, discsubtotal, subtotaldisc, ppn, subtotaldiscppn, subtotaldiscppnongkir})
        End If
        retval = dtsql.datasetSave("transaksi", iddata, field, value, False)

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
                If iddt = "-1" Then
                    iddt = GenerateGUID()
                End If
                Dim qty As Decimal = dr("qtycharges")
                Dim harga As Decimal = dr("harga")
                Dim hargatot As Decimal = harga * qty
                Dim discp As Long = dr("discpersen")
                Dim disca As Long = dr("discamount")
                Dim disct As Decimal = disca * qty
                Dim subtot As Decimal = hargatot - disct

                valuedt.AddRange(New Object() {iddt, iddata, dr("iditem"), dr("kode"), dr("item"), dr("itemtype"), dr("type"), dr("qtycharges"), dr("qtycharges"), dr("qty"), dr("idsatuan"), dr("satuan"), dr("qtycontent"), dr("idsatuan2"), dr("satuan2"), harga, subtot, discp, disca, disct, 0, dr("remarks"), 0, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp})
                retval = dtsql.datasetSave("transaksidt", iddt, fielddt, valuedt, False)
            Next

            'Dim cekcoa As Boolean = True
            'If slueDCOA.EditValue Is Nothing Then
            '    cekcoa = False
            'End If
            'If slueKCOA.EditValue Is Nothing Then
            '    cekcoa = False
            'End If
            'If cekcoa = True And isautoreview = "1" Then
            '    sqls.DMLQuery("delete from jurnal where tablereff='Transaksi' and idreff='" & iddata & "'", False)

            '    Dim dtjurnal As New dtsetSQLS(dbstring)
            '    Dim fieldj As New List(Of String)
            '    Dim valuej As New List(Of Object)
            '    Dim idjurnal As String = ""
            '    Dim tgljurnal As DateTime
            '    tgljurnal = nowTime

            '    fieldj.AddRange(New String() {"idjurnal", "tanggaljurnal", "jumlahuang", "remarks", "nodokumen", "posisidk", "isdeleted", "createdby", "createddate", "nobukti", "issystem", "jurnaltype", "tablereff", "tablereff2", "idcoa", "idcoalama", "idreff", "idreff2", "idunit", "idcompany"})

            '    idjurnal = GenerateGUID()
            '    valuej = New List(Of Object)
            '    dtjurnal = New dtsetSQLS(dbstring)

            '    valuej.Clear()
            '    valuej.AddRange(New Object() {idjurnal, tgljurnal, subtotaldiscppnongkir, "Penerimaan Barang " & vbCrLf & teKode.Text, teDokumen.Text, 2, 0, userid, tgljurnal, teDokumen.Text, 0, 1, "Transaksi", "-", slueKCOA.EditValue, slueKCOA.EditValue, iddata, "0", idunit2, idcomp})
            '    dtjurnal.datasetSave("jurnal", idjurnal, fieldj, valuej, False)

            '    idjurnal = GenerateGUID()
            '    valuej = New List(Of Object)
            '    dtjurnal = New dtsetSQLS(dbstring)

            '    valuej.Clear()
            '    valuej.AddRange(New Object() {idjurnal, tgljurnal, subtotaldiscppnongkir, "Penerimaan Barang " & vbCrLf & teKode.Text, teDokumen.Text, 1, 0, userid, tgljurnal, teDokumen.Text, 0, 1, "Transaksi", "-", slueDCOA.EditValue, slueDCOA.EditValue, iddata, "0", idunit2, idcomp})
            '    dtjurnal.datasetSave("jurnal", idjurnal, fieldj, valuej, False)
            'End If

            If isautoreview = "1" Then
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
                    valuelog.AddRange(New Object() {iditemlog, iditem, iddept2, idunit2, iddata, "Transaksi", iddatadt, "TransaksiDT", teKode.Text, "Penerimaan Barang", qty, 1, "Penerimaan Barang " & vbCrLf & teKode.Text, userid, nowTime, idcomp})
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
                    sqls2.DMLQuery("select iditemunit,qty from itemunit where iditem='" & iditem & "' and idunit='" & idunit2 & "' and iddepartment='" & iddept2 & "'", "cekitemunit")
                    If sqls2.getDataSet("cekitemunit") > 0 Then
                        iditemunit = CStr(sqls2.getDataSet("cekitemunit", 0, "iditemunit"))
                        Dim qtyexist As Decimal = CDbl(sqls2.getDataSet("cekitemunit", 0, "qty"))
                        qty = qtyexist + qty

                        fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "updatedby", "updateddate"})
                        valuelog.AddRange(New Object() {iditemunit, iditem, iddept2, idunit2, qty, userid, nowTime})
                    Else
                        iditemunit = GenerateGUID()
                        fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "createdby", "createddate"})
                        valuelog.AddRange(New Object() {iditemunit, iditem, iddept2, idunit2, qty, userid, nowTime})
                    End If

                    Dim dtsql2 As New dtsetSQLS(dbstring)
                    dtsql2.datasetSave("itemunit", iditemunit, fieldlog, valuelog, False)
                Next
            End If
            If retval = True Then
                dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
                btnNew_Click()
            End If
        End If
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

            'gvData.SetRowCellValue(e.RowHandle, GridColumn8, discR)
            gvData.SetRowCellValue(e.RowHandle, GridColumn9, discT)
            gvData.SetRowCellValue(e.RowHandle, GridColumn10, subt)
            gvData.SetRowCellValue(e.RowHandle, GridColumn12, subtotppn)
        End If
        gvData.BestFitColumns()
        AddHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged
    End Sub

End Class