Imports DevExpress.XtraGrid.Views.Base
Public Class frmReturPembelianReview

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
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,bp.nama,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,c.username from transaksi t left join businesspartner bp on t.idtujuan=bp.idbusinesspartner left join sys_user c on c.iduser=t.createdby left join (select idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi) dtot on t.idtransaksi=dtot.idtransaksi where (convert(varchar,t.createddate,105) like '%" & Format(nowTime.AddMonths(-1), "MM-yyyy") & "' or convert(varchar,t.createddate,105) like '%" & Format(nowTime, "MM-yyyy") & "') and dtot.total<>0 and t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodeReturPembelian')) and t.transaksistatus in (1) and reviewedby is null and t.isdeleted=0 order by t.createddate desc", "gettotal")
        dset = sqls.dataSet
        Dim cari As New frmSearch(dset, "gettotal", "idtransaksi")
        tambahChild(cari)
        If cari.ShowDialog() = Windows.Forms.DialogResult.OK Then
            kosongkangrid()
            kosongkanIsian(tlpField)

            idData = cari.GetIDSelectData
            idparent = "-1"
            isVoid = False

            teKode.Text = ""
            teSupplier.Text = ""
            teDokumen.Text = ""
            teNote.Text = ""
            deTanggal.EditValue = nowTime
            teUnit.Text = ""
            teReturNo.Text = ""

            slueDCOA.EditValue = Nothing
            slueKCOA.EditValue = Nothing

            gcData.Enabled = True

            btnSearch.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            btnDelete.Text = "VOID"

            sqls.DMLQuery("Select t.transaksitype, t.idtransaksireff, isnull(tr.transaksino,'-') as pnbno, isnull(tr.dokumenno,'-') as pnbdokno, t.transaksino, Convert(varchar, t.createddate, 105) As tanggal, Convert(varchar, t.createddate, 108) As waktu, t.remarks, t.idasal, t.idtujuan, s.nama As tujuan, u.unit As asal, t.dokumenno,t.subtotaldiscppnongkir from transaksi t left join transaksi tr on t.idtransaksireff=tr.idtransaksi left join businesspartner s on t.idtujuan=s.idbusinesspartner left join unit u on t.idasal=u.idunit where t.idtransaksi='" & idData & "'", "header")

            teKode.EditValue = sqls.getDataSet("header", 0, "pnbno")
            teUnit.EditValue = sqls.getDataSet("header", 0, "asal")
            teSupplier.EditValue = sqls.getDataSet("header", 0, "tujuan")
            teDokumen.EditValue = sqls.getDataSet("header", 0, "pnbdokno")
            teNote.EditValue = sqls.getDataSet("header", 0, "remarks")
            deTanggal.EditValue = nowTime
            teReturNo.Text = sqls.getDataSet("header", 0, "transaksino")
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

            seTotalRetur.Value = subtotaldiscppnongkir


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
        End If
    End Sub

    Private Sub kosongkan()
        kosongkangrid()
        kosongkanIsian(tlpField)

        idData = "-1"
        idparent = "-1"
        isVoid = False

        teKode.Text = ""
        teSupplier.Text = ""
        teDokumen.Text = ""
        teNote.Text = ""
        deTanggal.EditValue = nowTime
        teUnit.Text = ""
        teReturNo.Text = ""
        seTotalRetur.Value = 0

        gcData.Enabled = False

        btnSearch.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = True
        btnDelete.Text = "VOID"
    End Sub

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If iddata = "-1" Then
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
            strreason = "DELETE NOTE : " & vbCrLf & reason.reason

            Dim dtsets As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idtransaksi", "transaksistatus", "isdeleted", "deletereason"})
            value.AddRange(New Object() {iddata, 2, 1, strreason})
            dtsets.datasetSave("transaksi", iddata, field, value, False)

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

    Private dttbl As New DataTable
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
        loadLOV()

        checkFieldMaxLength(dbstring, tlpField, "transaksi")
        'btnNew_Click(btnNew, Nothing)
        kosongkangrid()
        kosongkanIsian(tlpField)

        idparent = "-1"
        iddata = "-1"
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

    Private Sub loadLOV()
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

    Private Sub kosongkangrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idtransaksidt,d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,d.discamount,d.discpersen,d.discsubtotal,d.harga,d.subtotal,d.qtycharges,d.qtycontent,d.qtyreceive,d.idsatuan2,d.satuan2,0 as qtymax,'' as remarks,d.isppn,d.ppn,d.subtotaldisclainppn from transaksidt d where 1=0", "kosong")
        dttbl = sqls.dataTable("kosong")
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private idunit2 As String
    Private iddept2 As String
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        kosongkangrid()
        kosongkanIsian(tlpField)

        idData = "-1"
        idparent = "-1"
        isVoid = False

        teKode.Text = ""
        teKode.ReadOnly = True
        deTanggal.EditValue = nowTime
        deTanggal.ReadOnly = True
        teNote.ReadOnly = True

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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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
            dizMsgbox("COA Debet/Kredit belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If gvData.RowCount = 0 Then
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
        field.AddRange(New String() {"idtransaksi", "transaksistatus", "reviewedby", "revieweddate", "reviewedfromip", "reviewedfromhostname", "idcompany", "subtotal", "discsubtotal", "subtotaldisc", "subtotaldiscppn", "subtotaldiscppnongkir"})
        value.AddRange(New Object() {idData, 6, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp, subtotal, discsubtotal, subtotaldisc, subtotaldiscppn, subtotaldiscppnongkir})
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
            valuej.AddRange(New Object() {idjurnal, tgljurnal, subtotaldiscppnongkir, "Retur Pembelian " & vbCrLf & teKode.Text, teDokumen.Text, 2, 0, userid, tgljurnal, teDokumen.Text, 0, 1, "Transaksi", "-", slueKCOA.EditValue, slueKCOA.EditValue, idData, "0", idunit2, idcomp})
            dtjurnal.datasetSave("jurnal", idjurnal, fieldj, valuej, False)

            idjurnal = GenerateGUID()
            valuej = New List(Of Object)
            dtjurnal = New dtsetSQLS(dbstring)

            valuej.Clear()
            valuej.AddRange(New Object() {idjurnal, tgljurnal, subtotaldiscppnongkir, "Retur Pembelian " & vbCrLf & teKode.Text, teDokumen.Text, 1, 0, userid, tgljurnal, teDokumen.Text, 0, 1, "Transaksi", "-", slueDCOA.EditValue, slueDCOA.EditValue, idData, "0", idunit2, idcomp})
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
            fieldlog.AddRange(New String() {"iditemlog", "iditem", "iddepartment", "idunit", "idreff", "tablereff", "idreff2", "tablereff2", "noreff", "trfreff", "qty", "io", "remarks", "createdby", "createddate"})
            valuelog.AddRange(New Object() {iditemlog, iditem, iddept2, idunit2, idData, "Transaksi", iddatadt, "TransaksiDT", teKode.Text, "Penerimaan Barang", qty, 2, "Retur Pembelian " & vbCrLf & teKode.Text, userid, nowTime})
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
                qty = qtyexist - qty

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

End Class