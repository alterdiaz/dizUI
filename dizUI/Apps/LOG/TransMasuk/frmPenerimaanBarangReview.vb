Imports DevExpress.XtraGrid.Views.Base

Public Class frmPenerimaanBarangReview

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

    Private Sub frmPermintaanPembelian_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        checkFieldMaxLength(dbstring, tlpField, "transaksi")
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub loadgrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,d.discamount,d.discpersen,d.harga,d.subtotal,d.qtycharges,d.qtycontent,d.qtyreceive,d.idsatuan2,d.satuan2,0 as qtymax,'' as remarks from transaksidt d where 1=0", "getnull")
        dttbl = sqls.dataTable("getnull")
        gcData.DataSource = dttbl
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"
    Private idParent As String = "-1"

    Private idunit2 As String
    Private iddept2 As String

    Private Sub loadlov()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idcoa, coa, remarks from coa where isdeleted=0 and (COA<>'-1' and LEN(COA)>=3) order by convert(varchar(20),COA) asc", "dcoa")
        slueDCOA.Properties.DataSource = SQLs.dataTable("dcoa")
        slueDCOA.Properties.DisplayMember = "coa"
        slueDCOA.Properties.ValueMember = "idcoa"
        slueDCOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        slueDCOA.EditValue = Nothing

        SQLs.DMLQuery("select idcoa, coa, remarks from coa where isdeleted=0 and (COA<>'-1' and LEN(COA)>=3) order by convert(varchar(20),COA) asc", "kcoa")
        slueKCOA.Properties.DataSource = SQLs.dataTable("kcoa")
        slueKCOA.Properties.DisplayMember = "coa"
        slueKCOA.Properties.ValueMember = "idcoa"
        slueKCOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        slueKCOA.EditValue = Nothing
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadlov()
        loadgrid()
        kosongkanIsian(tlpField)

        idData = "-1"
        idParent = "-1"
        isVoid = False

        teKode.Text = ""
        teKode.ReadOnly = True
        deTanggal.EditValue = nowTime
        deTanggal.ReadOnly = True
        teNote.ReadOnly = True
        teDokumen.ReadOnly = True

        slueDCOA.ReadOnly = False
        slueKCOA.ReadOnly = False
        slueDCOA.EditValue = Nothing
        slueKCOA.EditValue = Nothing

        gcData.Enabled = True

        btnSearch.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnDelete.Text = "VOID"
        statData = statusData.Baru

        If usersuper = 1 Then
            Dim selkary As New frmSelectKaryawan2()
            tambahChild(selkary)
            If selkary.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
            Dim tmpstaffid As String = ""
            tmpstaffid = String.Join(",", selkary.getID)
            selkary.Dispose()

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iddepartment,idunit from staff where idstaff='" & tmpstaffid & "' order by createddate desc", "getDU")
            If sqls.getDataSet("getDU") > 0 Then
                idunit2 = sqls.getDataSet("getDU", 0, "idunit")
                iddept2 = sqls.getDataSet("getDU", 0, "iddepartment")
            End If
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iddepartment,idunit from staff where iduser='" & userid & "' order by createddate desc", "getDU")
            If sqls.getDataSet("getDU") > 0 Then
                idunit2 = sqls.getDataSet("getDU", 0, "idunit")
                iddept2 = sqls.getDataSet("getDU", 0, "iddepartment")
            End If
        End If
    End Sub

    Private dttbl As New DataTable
    Private Sub kosongkangrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,d.discamount,d.discpersen,d.harga,d.subtotal,d.qtycharges,d.qtycontent,d.qtyreceive,d.idsatuan2,d.satuan2,0 as qtymax,'' as remarks from transaksidt d where 1=0", "getnull")
        dttbl = sqls.dataTable("getnull")
        gcData.DataSource = dttbl

        iddetil.Clear()
    End Sub

    Private iddetil As New List(Of String)
    Private Sub loadgrid(idunit As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        field.AddRange(New String() {"@idasal", "@asaltype"})
        value.AddRange(New Object() {idunit, "Unit"})
        sqls.CallSP("spSPP", "spp", field, value)
        dttbl = sqls.dataTable("spp")
        gcData.DataSource = dttbl

        Dim sqls1 As New SQLs(dbstring)
        sqls1.CallSP("spSPPturunan", "sppturunan", field, value)
        For i As Integer = 0 To sqls1.getDataSet("sppturunan") - 1
            Dim dr As DataRow = sqls1.dataTable("sppturunan").Rows(i)
            Dim curridparent As Long = dr("idtransaksi")
            Dim curriddetil As Long = dr("idtransaksidt")

            If iddetil.Contains(curriddetil) = False Then
                iddetil.Add(curriddetil)
            End If
        Next
    End Sub

    Private Function generateNO(idunit As String, iddept As String, isbaru As Boolean) As KeyValuePair(Of String, String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idtransactiontype,formatstring,formatperiode,positionnumber,digitnumber from transactiontype where idunit='" & idunit & "' and iddepartment='" & iddept & "'", "getformat")

        Dim idtrans As String = sqls.getDataSet("getformat", 0, "idtransactiontype")
        Dim formatstr As String = sqls.getDataSet("getformat", 0, "formatstring")
        Dim formatperiode As String = sqls.getDataSet("getformat", 0, "formatperiode")
        Dim posnumber As String = sqls.getDataSet("getformat", 0, "positionnumber")
        Dim digitno As String = sqls.getDataSet("getformat", 0, "digitnumber")

        Dim notrans As String = generateNO(formatstr, formatperiode, posnumber, digitno, isbaru)
        Dim retval As New KeyValuePair(Of String, String)(idtrans, notrans)
        Return retval
    End Function

    Private Function generateNO(ByVal prefix As String, ByVal periodeformat As String, ByVal posisinomor As String, ByVal digitnomor As Integer, isbaru As Boolean) As String
        Dim retval As String = ""
        Dim mysqls As New SQLs(dbstring)
        Dim tblname As String = prefix & Format(nowTime, periodeformat)
        mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & "'", "GetLast")
        Dim idgen As Integer = -1
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

    'Private idunit As String = ""
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring)
        Dim dset As New DataSet
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,u.unit,bp.nama,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,c.username from transaksi t left join unit u on t.idtujuan=u.idunit left join businesspartner bp on t.idasal=bp.idbusinesspartner left join sys_user c on c.iduser=t.createdby left join (select idtransaksi2,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi2) dt on t.idtransaksi=dt.idtransaksi2 left join (select idtransaksi2,sum(qtycharges) as total from transaksidt dt group by idtransaksi2) dtot on t.idtransaksi=dtot.idtransaksi2 where t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodePenerimaanBarang')) and t.transaksistatus in (1) and t.reviewedby is null and t.isdeleted=0 order by t.createddate desc", "gettotal")
        dset = sqls.dataSet
        Dim cari As New frmSearch(dset, "gettotal", "idtransaksi")
        tambahChild(cari)
        If cari.ShowDialog() = Windows.Forms.DialogResult.OK Then
            kosongkangrid()
            kosongkanIsian(tlpField)

            idData = cari.GetIDSelectData
            isVoid = False

            idunit2 = ""
            iddept2 = ""
            teKode.Text = ""
            deTanggal.EditValue = nowTime
            teUnit.EditValue = Nothing
            teSupplier.EditValue = Nothing
            teNote.EditValue = Nothing

            gcData.Enabled = True
            gcQty.OptionsColumn.ReadOnly = True
            gcQty.OptionsColumn.AllowEdit = False
            gcQty.AppearanceCell.BackColor = Nothing
            GridColumn1.OptionsColumn.ReadOnly = True
            GridColumn1.OptionsColumn.AllowEdit = False
            GridColumn1.AppearanceCell.BackColor = Nothing

            btnSearch.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            btnDelete.Text = "VOID"
            statData = statusData.Edit

            sqls.DMLQuery("select t.idtransaksireff,t.transaksino,t.dokumenno,convert(varchar,t.createddate,105) as tanggal,convert(varchar,t.createddate,108) as waktu,t.remarks,t.idasal,t.idtujuan,u.unit as asal,t.iddepttujuan,bp.nama as tujuan,convert(varchar,kirimdate,105)+' '+convert(varchar,kirimdate,108) as kirimdate,convert(varchar,tempodate,105)+' '+convert(varchar,tempodate,108) as tempodate,t.subtotaldiscppnongkir from transaksi t left join unit u on t.idtujuan=u.idunit left join businesspartner bp on t.idasal=bp.idbusinesspartner where t.idtransaksi='" & idData & "'", "header")

            idParent = sqls.getDataSet("header", 0, "idtransaksireff")
            idunit2 = sqls.getDataSet("header", 0, "idtujuan")
            iddept2 = sqls.getDataSet("header", 0, "iddepttujuan")
            teUnit.EditValue = sqls.getDataSet("header", 0, "tujuan")
            teSupplier.EditValue = sqls.getDataSet("header", 0, "asal")

            teKode.EditValue = sqls.getDataSet("header", 0, "transaksino")
            teNote.EditValue = sqls.getDataSet("header", 0, "remarks")
            teDokumen.EditValue = sqls.getDataSet("header", 0, "dokumenno")

            Dim tmptgl As String = sqls.getDataSet("header", 0, "tanggal").ToString
            Dim tmpwaktu As String = sqls.getDataSet("header", 0, "waktu").ToString
            deTanggal.EditValue = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)

            Dim sqls1 As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"@id"})
            value.AddRange(New Object() {idData})
            sqls1.CallSP("spPOFAKTcurrent", "po", field, value)
            dttbl = sqls1.dataTable("po")
            gcData.DataSource = dttbl
            gvData.BestFitColumns()

            sqls.DMLQuery("select idcoa from jurnal where posisidk=1 and tablereff='Transaksi' and idreff='" & idData & "'", "getjurnald")
            sqls.DMLQuery("select idcoa from jurnal where posisidk=2 and tablereff='Transaksi' and idreff='" & idData & "'", "getjurnalk")
            If sqls.getDataSet("getjurnald") > 0 Then
                slueDCOA.EditValue = sqls.getDataSet("getjurnald", 0, "idcoa")
            Else
                slueDCOA.EditValue = Nothing
            End If
            If sqls.getDataSet("getjurnalk") > 0 Then
                slueKCOA.EditValue = sqls.getDataSet("getjurnalk", 0, "idcoa")
            Else
                slueKCOA.EditValue = Nothing
            End If
            sqls.DMLQuery("select top 1 idcoad1,idcoak1 from transactioncoa where jenistransaksi='Penerimaan Barang' and idunit='" & idunit2 & "' and iddepartment='" & iddept2 & "'", "getcoatrans")
            If sqls.getDataSet("getcoatrans") = 0 Then
                sqls.DMLQuery("select top 1 idcoad1,idcoak1 from transactioncoa where jenistransaksi='Penerimaan Barang' and idunit='" & idunit2 & "' and iddepartment='0'", "getcoatrans")
            End If
            If slueDCOA.EditValue Is Nothing Then
                If sqls.getDataSet("getcoatrans") > 0 Then
                    slueDCOA.EditValue = sqls.getDataSet("getcoatrans", 0, "idcoad1")
                End If
            End If
            If slueKCOA.EditValue Is Nothing Then
                If sqls.getDataSet("getcoatrans") > 0 Then
                    slueKCOA.EditValue = sqls.getDataSet("getcoatrans", 0, "idcoak1")
                End If
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If idData = "-1" Then
            dizMsgbox("Penerimaan Barang belum dipilih", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If gvData.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        Dim cekcoa1 As Boolean = True
        If slueDCOA.EditValue Is Nothing Then
            cekcoa1 = False
        End If
            If slueKCOA.EditValue Is Nothing Then
            cekcoa1 = False
        End If
        If cekcoa1 = False Then
            If dizMsgbox("COA Debet/Kredit belum dipilih, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If

        If gvData.RowCount > 0 Then
            If dizMsgbox("Penerimaan Barang akan masuk Stok Gudang" & vbCrLf & "Apakah melanjutkan ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If

        If teNote.EditValue = Nothing Then
            teNote.EditValue = "-"
        End If
        If teNote.Text.Replace(" ", "") = "" Then
            teNote.EditValue = "-"
        End If

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim retval As Boolean = False
        Dim sqls As New SQLs(dbstring)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

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

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idtransaksi", "transaksistatus", "reviewedby", "revieweddate", "reviewedfromip", "reviewedfromhostname", "idcompany"})
        value.AddRange(New Object() {idData, 6, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp})
        retval = dtsql.datasetSave("transaksi", idData, field, value, False)

        Dim cekcoa As Boolean = True
        If slueDCOA.EditValue Is Nothing Then
            cekcoa = False
        End If
        If slueKCOA.EditValue Is Nothing Then
            cekcoa = False
        End If
        If cekcoa = True Then
            sqls.DMLQuery("delete from jurnal where tablereff='Transaksi' and idreff='" & idData & "'", False)

            Dim dtjurnal As New dtsetSQLS(dbstring)
            Dim fieldj As New List(Of String)
            Dim valuej As New List(Of Object)
            Dim idjurnal As String = ""
            Dim tgljurnal As DateTime
            tgljurnal = nowTime

            fieldj.AddRange(New String() {"idjurnal", "tanggaljurnal", "jumlahuang", "remarks", "nodokumen", "posisidk", "isdeleted", "createdby", "createddate", "nobukti", "issystem", "jurnaltype", "tablereff", "tablereff2", "idcoa", "idcoalama", "idreff", "idreff2", "idunit", "idcompany"})

            idjurnal = GenerateGUID()
            valuej = New List(Of Object)
            dtjurnal = New dtsetSQLS(dbstring)

            valuej.Clear()
            valuej.AddRange(New Object() {idjurnal, tgljurnal, subtotaldiscppnongkir, "Penerimaan Barang " & vbCrLf & teKode.Text, teDokumen.Text, 2, 0, userid, tgljurnal, teDokumen.Text, 0, 1, "Transaksi", "-", slueKCOA.EditValue, slueKCOA.EditValue, idData, "0", idunit2, idcomp})
            dtjurnal.datasetSave("jurnal", idjurnal, fieldj, valuej, False)

            idjurnal = GenerateGUID()
            valuej = New List(Of Object)
            dtjurnal = New dtsetSQLS(dbstring)

            valuej.Clear()
            valuej.AddRange(New Object() {idjurnal, tgljurnal, subtotaldiscppnongkir, "Penerimaan Barang " & vbCrLf & teKode.Text, teDokumen.Text, 1, 0, userid, tgljurnal, teDokumen.Text, 0, 1, "Transaksi", "-", slueDCOA.EditValue, slueDCOA.EditValue, idData, "0", idunit2, idcomp})
            dtjurnal.datasetSave("jurnal", idjurnal, fieldj, valuej, False)
        End If

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
            valuelog.AddRange(New Object() {iditemlog, iditem, iddept2, idunit2, idData, "Transaksi", iddatadt, "TransaksiDT", teKode.Text, "Penerimaan Barang", qty, 1, "Penerimaan Barang " & vbCrLf & teKode.Text, userid, nowTime, idcomp})
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

        If retval = True Then
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
            kosongkan()
        End If
    End Sub

    Private Sub kosongkan()
        kosongkangrid()
        kosongkanIsian(tlpField)

        idData = "-1"
        idParent = "-1"
        isVoid = False

        teKode.Text = ""
        teSupplier.Text = ""
        deTanggalKirim.EditValue = Nothing
        deTanggalTempo.EditValue = Nothing

        deTanggal.EditValue = nowTime
        teNote.Text = ""
        teUnit.Text = ""
        teDokumen.Text = ""

        slueDCOA.EditValue = Nothing
        slueKCOA.EditValue = Nothing

        gcData.Enabled = False

        btnSearch.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = True
        btnDelete.Text = "VOID"
    End Sub

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dizMsgbox("Anda akan melakukan void Penerimaan Barang ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then

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

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update transaksi set transaksistatus=2,isdeleted=1,deletereason='SPP " & strreason & "',updateddate=getdate(),updatedfromip='" & getIPAddress(ipaddparam.IP) & "',updatedfromhostname='" & getIPAddress(ipaddparam.Host) & "',updatedby='" & userid & "' where idtransaksi in (select idtransaksi from transaksidt where idtransaksi2='" & idData & "')", False)

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

End Class