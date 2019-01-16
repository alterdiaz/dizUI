Public Class frmPembelianNI
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
        Threading.Thread.Sleep(1000)
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

        sqls.DMLQuery("select idunit as id,unit as content from unit where isdeleted=0", "unit")
        lueUnit.Properties.DataSource = sqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
    End Sub

    Private dttbl As New DataTable
    Private Sub kosongkangrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,d.discamount,d.discpersen,d.harga,d.subtotal,d.qtycharges,0 as qtymax,'' as remarks from transaksidt d where 1=0", "data")
        dttbl = sqls.dataTable("data")
        gcData.DataSource = dttbl
    End Sub

    Private Sub loadItem(idtrans As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@idtrans"})
        value.AddRange(New Object() {idtrans})
        sqls.CallSP("spLoadLOVItemSPP", "getitem", field, value)
        gcItem.DataSource = sqls.dataTable("getitem")
    End Sub

    Private Sub frmPembelian_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        sccForm.SplitterPosition = sccForm.Width - 275

        kosongkangrid()
        kosongkanIsian(tlpField)

        idData = "-1"
        isVoid = False
        teKode.Text = "XXXX/XXX/XXX" & Format(nowTime, "") & "/XXXX"
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
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,c.username as createdby,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate from transaksi t left join sys_user c on t.createdby=c.iduser left join (select idtransaksi2,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi2) dt on t.idtransaksi=dt.idtransaksi2 left join (select idtransaksi2,sum(qtycharges) as total from transaksidt dt group by idtransaksi2) dtot on t.idtransaksi=dtot.idtransaksi2 where t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodePermintaanPembelian')) and t.idcompany=(select [value] from sys_appsetting where [variable]='CompanyID') and t.reviewedby is not null and t.isdeleted=0 and t.transaksistatus=6 order by t.createddate desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idtransaksi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            kosongkangrid()
            kosongkanIsian(tlpField)

            idData = cari.GetIDSelectData
            isVoid = False
            teKode.Text = "XXXX/XXX/XXX" & Format(nowTime, "") & "/XXXX"
            deTanggal.EditValue = nowTime
            teNote.Properties.ReadOnly = False
            teNote.EditValue = Nothing
            lueSupplier.Properties.ReadOnly = False
            lueSupplier.EditValue = Nothing
            lueUnit.Properties.ReadOnly = True
            lueUnit.EditValue = Nothing

            btnSearch.Enabled = True
            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = False
            btnDelete.Text = "VOID"
            statData = statusData.Baru

            sqls.DMLQuery("select idasal from transaksi where idtransaksi='" & idData & "'", "getidunit")
            lueUnit.EditValue = CStr(sqls.getDataSet("getidunit", 0, "idasal"))

            gcData.Enabled = True
            gcQty.OptionsColumn.ReadOnly = False
            gcQty.OptionsColumn.AllowEdit = True
            gcQty.AppearanceCell.BackColor = canWrite
            GridColumn1.OptionsColumn.ReadOnly = False
            GridColumn1.OptionsColumn.AllowEdit = True
            GridColumn1.AppearanceCell.BackColor = canWrite

            loadItem(idData)
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

        Dim pair As KeyValuePair(Of String, String) = generateno2(lueUnit.EditValue, iddeptpurc, "Pembelian", False)
        Dim idtrans As String = pair.Key
        Dim notrans As String = pair.Value
        teKode.Text = notrans

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim retval As Boolean = False
        Dim sqls As New SQLs(dbstring)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")
        idData = GenerateGUID()

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idtransaksi", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "iddeptasal", "isdeleted", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany"})
        value.AddRange(New Object() {idData, idtrans, teKode.Text, 1, lueUnit.EditValue, "Unit", iddeptpurc, 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp})
        retval = dtsql.datasetSave("transaksi", idData, field, value, False)
        'sqls.DMLQuery("select idtransaksi from transaksi where guid='" & hashcode & "'", "getid")
        'idData = sqls.getDataSet("getid", 0, "idtransaksi")

        Dim fielddt As New List(Of String)
        Dim valuedt As New List(Of Object)
        fielddt.AddRange(New String() {"idtransaksidt", "idtransaksi", "iditem", "idsatuan", "kodeitem", "item", "itemtype", "type", "qtycharges", "satuan", "isdeleted", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany"})
        For i As Integer = 0 To gvData.RowCount - 1
            Dim iddt As String = GenerateGUID()
            dtsql = New dtsetSQLS(dbstring)
            valuedt = New List(Of Object)
            Dim dr As DataRow = gvData.GetDataRow(i)
            valuedt.AddRange(New Object() {iddt, idData, dr("iditem"), dr("idsatuan"), dr("kode"), dr("item"), dr("itemtype"), dr("type"), dr("qtycharges"), dr("satuan"), 0, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp})
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
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,t.remarks,c.username from transaksi t left join sys_user c on c.iduser=t.createdby left join (select idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi) dtot on t.idtransaksi=dtot.idtransaksi where t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodePembelian')) and t.idcompany=(select [value] from sys_appsetting where [variable]='CompanyID') and t.transaksistatus in (1) and reviewedby is null and t.isdeleted=0 order by t.createddate desc", "gettotal")
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

            btnSearch.Enabled = True
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnDelete.Enabled = True
            btnDelete.Text = "VOID"
            statData = statusData.Edit

            sqls.DMLQuery("select transaksino,convert(varchar,createddate,105) as tanggal,convert(varchar,createddate,108) as waktu,remarks from transaksi where idtransaksi='" & idData & "'", "header")

            teKode.EditValue = sqls.getDataSet("header", 0, "transaksino")
            teNote.EditValue = sqls.getDataSet("header", 0, "remarks")

            Dim tmptgl As String = sqls.getDataSet("header", 0, "tanggal").ToString
            Dim tmpwaktu As String = sqls.getDataSet("header", 0, "waktu").ToString
            deTanggal.EditValue = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)

            Dim sqls1 As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"@id"})
            value.AddRange(New Object() {idData})
            sqls1.CallSP("spPOcurrent", "po", field, value)
            dttbl = sqls1.dataTable("po")
            gcData.DataSource = dttbl
        End If
    End Sub

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dizMsgbox("Anda akan melakukan void Permintaan Barang ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then

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
            teKode.Text = "XXXX/XXX/XXX" & Format(nowTime, "") & "/XXXX"
            iddeptpurc = ""
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iddepartment from department where iddepartment in(select value from sys_appsetting where variable='IDPurchaseDept')", "getidpurc")
            If sqls.getDataSet("getidpurc") > 0 Then
                iddeptpurc = sqls.getDataSet("getidpurc", 0, "iddepartment")
                Dim pair As KeyValuePair(Of String, String) = generateno2(lueUnit.EditValue, iddept, "Pembelian", True)
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
                    dr("iditem") = dra("iditem")
                    sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where i.iditem='" & dra("iditem") & "'", "dataitem")
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("remarks") = "-"
                    dr("qtycharges") = 0

                    Dim idtrans As String = idData
                    Dim iditem As String = dra("iditem")
                    Dim field As New List(Of String)
                    Dim value As New List(Of Object)
                    field.AddRange(New String() {"@idtrans", "@iditem"})
                    value.AddRange(New Object() {idtrans, iditem})

                    sqls.CallSP("spLoadLOVItemSPPGetItem", "getqty", field, value)
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
                    dr("iditem") = dra("iditem")
                    sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where i.iditem='" & dra("iditem") & "'", "dataitem")
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("remarks") = "-"
                    dr("qtycharges") = 0

                    Dim idtrans As String = idData
                    Dim iditem As String = dra("iditem")
                    Dim field As New List(Of String)
                    Dim value As New List(Of Object)
                    field.AddRange(New String() {"@idtrans", "@iditem"})
                    value.AddRange(New Object() {idtrans, iditem})

                    sqls.CallSP("spLoadLOVItemSPPGetItem", "getqty", field, value)
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
    End Sub

End Class