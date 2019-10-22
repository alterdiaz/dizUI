Imports DevExpress.XtraGrid.Views.Base
Public Class frmStokOpnameBarangItem

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

    Private Sub frmStokOpname_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        sccForm.SplitterPosition = sccForm.Width - 275
        loadItem()
        loadLOV()
        kosongkan()
    End Sub

    Private Sub loadItem()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select i.iditem,i.item,'('+ gc.generalcode +')' as note,convert(bit,0) as cek from item i left join sys_generalcode gc on i.itemtype=gc.idgeneral and gc.gctype='ITEMTYPE' where i.itemtype in (1,11) order by i.item asc", "getitem")

        gcItem.DataSource = sqls.dataTable("getitem")
        gvItem.BestFitColumns()
    End Sub

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idunit as id,unit as content from unit where isdeleted=0 order by unit asc", "unit")
        lueUnit.Properties.DataSource = sqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
        lueUnit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueUnit.EditValue = Nothing

        sqls.DMLQuery("select iddepartment as id,department as content from department where isdeleted=0 order by department", "dept")
        lueDept.Properties.DataSource = sqls.dataTable("dept")
        lueDept.Properties.ValueMember = "id"
        lueDept.Properties.DisplayMember = "content"
        lueDept.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueDept.EditValue = Nothing
    End Sub

    Private Sub kosongkan()
        teNoTransaksi.Text = "XXXX/XXX/OPB/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teTglTransaksi.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        lueUnit.EditValue = Nothing
        lueDept.EditValue = Nothing
        teNote.Text = ""
    End Sub

    Private dttbl As DataTable
    Private Sub kosongkangrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select convert(varchar(50),'0') as idtransaksidt,ROW_NUMBER() OVER (Order by i.item asc) as nomor,i.iditem,ig.itemgrup,i.kode,i.item,convert(decimal(8,2),0) as qtyselisih,isnull(iu.qty,0) as qty,isnull(iu.qty,0) as qtyinput from item i left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join itemunit iu on iu.iditem=i.iditem where 1=0", "data")
        dttbl = sqls.dataTable("data")
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private iddata As String = "-1"
    Private statdata As statusData = statusData.Baru
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        kosongkan()
        kosongkangrid()
        iddata = "-1"
        statdata = statusData.Baru
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lueUnit.EditValue Is Nothing Then Exit Sub
        If lueDept.EditValue Is Nothing Then Exit Sub

        If dizMsgbox("Data yang tersimpan, tidak dapat dibatalkan." & vbCrLf & "Tetap menyimpan ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If

        Dim idcomp As String = ""
        If statdata = statusData.Baru Then
            Dim pair As KeyValuePair(Of String, String) = generateno2(If(lueUnit.EditValue, "0"), If(lueDept.EditValue, "0"), "Opname Barang", False)
            teNoTransaksi.Text = pair.Value
            teNoTransaksi.Tag = pair.Key
            teTglTransaksi.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            idcomp = sqlscomp.getDataSet("CompID", 0, "value")

            iddata = GenerateGUID()
        End If

        Dim retval As Boolean = False
        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        dtsqls = New dtsetSQLS(dbstring)
        field = New List(Of String)
        value = New List(Of Object)

        field.Clear()
        value.Clear()

        If statdata = statusData.Baru Then
            field.AddRange(New String() {"idtransaksi", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "iddeptasal", "isdeleted", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany"})
            value.AddRange(New Object() {iddata, teNoTransaksi.Tag, teNoTransaksi.Text, 1, lueUnit.EditValue, "Unit", lueDept.EditValue, 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp})
        ElseIf statdata = statusData.Edit Then
            field.AddRange(New String() {"idtransaksi", "remarks", "updatedby", "updateddate", "updatedfromip", "updatedfromhostname"})
            value.AddRange(New Object() {iddata, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
        End If
        retval = dtsqls.datasetSave("transaksi", iddata, field, value, False)

        If retval = True Then

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim fielddt As New List(Of String)
            Dim valuedt As New List(Of Object)
            fielddt.AddRange(New String() {"idtransaksidt", "idtransaksi", "iditem", "kodeitem", "item", "itemtype", "type", "valueqty1", "valueqty2", "qtydispose", "qtycharges", "qtyreceive", "idsatuan", "satuan", "isdeleted", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany"})

            For i As Integer = 0 To gvData.RowCount - 1
                dtsql = New dtsetSQLS(dbstring)
                valuedt = New List(Of Object)
                Dim sqlsdt As New SQLs(dbstring)

                Dim dr As DataRow = gvData.GetDataRow(i)
                If dr("qtyselisih") <> 0 Then
                    Dim iddt As String = dr("idtransaksidt")
                    If iddt = "0" Then
                        iddt = GenerateGUID()
                    End If

                    Dim iditem As String = dr("iditem")
                    Dim itemtype As String = ""
                    Dim itemtypestr As String = ""
                    Dim idsatuan As String = ""
                    Dim satuan As String = ""
                    sqlsdt.DMLQuery("select i.itemtype,it.generalcode as type,i.idsatuan,s.satuan from item i left join satuan s on i.idsatuan=s.idsatuan left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='itemtype' where i.iditem='" & iditem & "'", "itemtype")

                    itemtype = sqlsdt.getDataSet("itemtype", 0, "itemtype")
                    itemtypestr = sqlsdt.getDataSet("itemtype", 0, "type")
                    idsatuan = sqlsdt.getDataSet("itemtype", 0, "idsatuan")
                    satuan = sqlsdt.getDataSet("itemtype", 0, "satuan")

                    valuedt.AddRange(New Object() {iddt, iddata, iditem, dr("kode"), dr("item"), itemtype, itemtypestr, dr("qty"), dr("qtyinput"), dr("qtyselisih"), dr("qtyselisih"), dr("qtyselisih"), idsatuan, satuan, 0, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp})
                    retval = dtsql.datasetSave("transaksidt", iddt, fielddt, valuedt, False)

                    'item log
                    Dim fieldlog As New List(Of String)
                    Dim valuelog As New List(Of Object)
                    Dim iditemlog As String = GenerateGUID()
                    Dim drlog As DataRow = gvData.GetDataRow(i)
                    Dim iddatalog As String = CStr(dr("idtransaksidt"))
                    Dim idlogitem As String = CStr(dr("iditem"))
                    Dim qty As Long = CLng(dr("qtyselisih"))
                    If qty < 0 Then
                        qty = qty * -1
                    End If

                    fieldlog.AddRange(New String() {"iditemlog", "iditem", "iddepartment", "idunit", "idreff", "tablereff", "idreff2", "tablereff2", "noreff", "trfreff", "qty", "io", "remarks", "createdby", "createddate"})
                    If dr("qtyselisih") < 0 Then
                        valuelog.AddRange(New Object() {iditemlog, idlogitem, lueDept.EditValue, lueUnit.EditValue, iddata, "Transaksi", iddatalog, "TransaksiDT", teNoTransaksi.Text, "Stok Opname", qty, 2, "Opname Kurang " & vbCrLf & teNoTransaksi.Text, userid, nowTime})
                    Else
                        valuelog.AddRange(New Object() {iditemlog, iditem, lueDept.EditValue, lueUnit.EditValue, iddata, "Transaksi", iddatalog, "TransaksiDT", teNoTransaksi.Text, "Stok Opname", qty, 1, "Opname Lebih " & vbCrLf & teNoTransaksi.Text, userid, nowTime})
                    End If
                    Dim dtsql2 As New dtsetSQLS(dbstring)
                    dtsql2.datasetSave("itemlog", iditemlog, fieldlog, valuelog, False)

                    'item unit
                    Dim fieldunit As New List(Of String)
                    Dim valueunit As New List(Of Object)
                    Dim iditemunit As String = ""

                    Dim sqls2 As New SQLs(dbstring)
                    sqls2.DMLQuery("select iditemunit,qty from itemunit where iditem='" & iditem & "' and idunit='" & lueUnit.EditValue & "' and iddepartment='" & lueDept.EditValue & "'", "cekitemunit")
                    If sqls2.getDataSet("cekitemunit") > 0 Then
                        iditemunit = CStr(sqls2.getDataSet("cekitemunit", 0, "iditemunit"))
                        Dim qtyexist As Decimal = CDbl(dr("qtyinput")) 'CDbl(sqls2.getDataSet("cekitemunit", 0, "qty"))
                        'qty = qtyexist - qty

                        fieldunit.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "updatedby", "updateddate"})
                        valueunit.AddRange(New Object() {iditemunit, iditem, lueDept.EditValue, lueUnit.EditValue, qtyexist, userid, nowTime})
                    Else
                        iditemunit = GenerateGUID()
                        Dim qtyexist As Decimal = CDbl(dr("qtyinput"))
                        fieldunit.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "createdby", "createddate"})
                        valueunit.AddRange(New Object() {iditemunit, iditem, lueDept.EditValue, lueUnit.EditValue, qtyexist, userid, nowTime})
                    End If

                    Dim dtsql3 As New dtsetSQLS(dbstring)
                    dtsql3.datasetSave("itemunit", iditemunit, fieldunit, valueunit, False)
                End If
            Next

            If retval = True Then
                dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
                btnNew_Click(btnNew, Nothing)
            End If
        End If
    End Sub

    Private Sub gvData_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvData.CellValueChanged
        RemoveHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged

        If e.Column Is GridColumn6 Then
            Dim selisih As Decimal = 0
            selisih = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn6)) - CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn5))
            gvData.SetFocusedRowCellValue(GridColumn8, selisih)
        End If

        AddHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged
    End Sub

    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        Dim cekunitdept As Boolean = True
        If lueUnit.EditValue Is Nothing Then
            cekunitdept = False
        End If
        If lueDept.EditValue Is Nothing Then
            cekunitdept = False
        End If
        If cekunitdept = False Then
            dizMsgbox("Unit Department belum dipilih", dizMsgboxStyle.Peringatan, Me)
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
            lueDept.ReadOnly = False

            kosongkangrid()
            gvData.ViewCaption = "Stok Opname"
        Else
            btnLock.ForeColor = Color.White
            btnLock.BackColor = Color.Maroon
            lueUnit.ReadOnly = True
            lueDept.ReadOnly = True

            kosongkangrid()
            gvData.ViewCaption = "Stok Opname"
            If statdata = statusData.Baru Then
                Dim pair As KeyValuePair(Of String, String) = generateno2(If(lueUnit.EditValue, "0"), If(lueDept.EditValue, "0"), "Opname Barang", True)
                teNoTransaksi.Text = pair.Value
                teNoTransaksi.Tag = pair.Key
            End If
        End If
    End Sub

    Private Sub btnItemSelect_Click(sender As Object, e As EventArgs) Handles btnItemSelect.Click
        If btnLock.BackColor <> Color.Maroon Then
            dizMsgbox("Unit Department belum dilock", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If gvItem.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        For i As Integer = 0 To gvItem.RowCount - 1
            Dim dra As DataRow = gvItem.GetDataRow(i)
            Dim idx As Integer = 0
            Dim qtyinput As Integer = 0

            If dra("cek") = "True" Then
                Dim sqls As New SQLs(dbstring)
                Dim cekExist As Boolean = False
                For a As Integer = 0 To gvData.RowCount - 1
                    Dim drc As DataRow = gvData.GetDataRow(a)
                    If drc("iditem") = dra("iditem") Then
                        cekExist = True
                        qtyinput = CInt(drc("qtyinput"))
                        idx = a
                        Exit For
                    End If
                Next
                If cekExist = False Then
                    Dim dr As DataRow = dttbl.NewRow
                    'convert(varchar(50),'0') as idtransaksidt,ROW_NUMBER() OVER (Order by i.item asc) as nomor,i.iditem,ig.itemgrup,i.kode,i.item,convert(decimal(8,2),0) as qtyselisih,isnull(iu.qty,0) as qty,isnull(iu.qty,0) as qtyinput

                    sqls.DMLQuery("select i.iditem,ig.itemgrup,i.kode,i.item,convert(decimal(8,2),0) as qtyselisih,isnull(iu.qty,0) as qty,isnull(iu.qty,1) as qtyinput from item i left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join itemunit iu on iu.iditem=i.iditem and iu.idunit='" & lueUnit.EditValue & "' and iu.iddepartment='" & lueDept.EditValue & "' where i.iditem='" & dra("iditem") & "'", "dataitem")

                    dr("idtransaksidt") = GenerateGUID()
                    dr("nomor") = "0"
                    dr("iditem") = dra("iditem")
                    dr("itemgrup") = sqls.getDataSet("dataitem", 0, "itemgrup")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("qty") = sqls.getDataSet("dataitem", 0, "qty")
                    dr("qtyselisih") = sqls.getDataSet("dataitem", 0, "qtyselisih")
                    dr("qtyinput") = sqls.getDataSet("dataitem", 0, "qtyinput")
                    dttbl.Rows.Add(dr)
                Else
                    Dim dr As DataRow = dttbl.Rows(idx)
                    dr("qtyinput") = qtyinput + 1
                    gcData.DataSource = dttbl
                    gvData.BestFitColumns()
                End If
                dra("cek") = 0
            End If
        Next
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = dttbl.Rows(i)
            dr("nomor") = CInt(i + 1)
        Next
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private Sub btnAllItem_Click(sender As Object, e As EventArgs) Handles btnAllItem.Click
        If btnLock.BackColor <> Color.Maroon Then
            dizMsgbox("Unit Department belum dilock", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If gvItem.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        For i As Integer = 0 To gvItem.RowCount - 1
            Dim dra As DataRow = gvItem.GetDataRow(i)
            Dim idx As Integer = 0
            Dim qtyinput As Integer = 0

            Dim sqls As New SQLs(dbstring)
            Dim cekExist As Boolean = False
            For a As Integer = 0 To gvData.RowCount - 1
                Dim drc As DataRow = gvData.GetDataRow(a)
                If drc("iditem") = dra("iditem") Then
                    cekExist = True
                    qtyinput = CInt(drc("qtyinput"))
                    idx = a
                    Exit For
                End If
            Next
            If cekExist = False Then
                Dim dr As DataRow = dttbl.NewRow
                'convert(varchar(50),'0') as idtransaksidt,ROW_NUMBER() OVER (Order by i.item asc) as nomor,i.iditem,ig.itemgrup,i.kode,i.item,convert(decimal(8,2),0) as qtyselisih,isnull(iu.qty,0) as qty,isnull(iu.qty,0) as qtyinput

                sqls.DMLQuery("select i.iditem,ig.itemgrup,i.kode,i.item,convert(decimal(8,2),0) as qtyselisih,isnull(iu.qty,0) as qty,isnull(iu.qty,1) as qtyinput from item i left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join itemunit iu on iu.iditem=i.iditem and iu.idunit='" & lueUnit.EditValue & "' and iu.iddepartment='" & lueDept.EditValue & "' where i.iditem='" & dra("iditem") & "'", "dataitem")

                dr("idtransaksidt") = GenerateGUID()
                dr("nomor") = "0"
                dr("iditem") = dra("iditem")
                dr("itemgrup") = sqls.getDataSet("dataitem", 0, "itemgrup")
                dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                dr("item") = sqls.getDataSet("dataitem", 0, "item")
                dr("qty") = sqls.getDataSet("dataitem", 0, "qty")
                dr("qtyselisih") = sqls.getDataSet("dataitem", 0, "qtyselisih")
                dr("qtyinput") = sqls.getDataSet("dataitem", 0, "qtyinput")
                dttbl.Rows.Add(dr)
            Else
                Dim dr As DataRow = dttbl.Rows(idx)
                dr("qtyinput") = qtyinput + 1
                gcData.DataSource = dttbl
                gvData.BestFitColumns()
            End If
            dra("cek") = 0
        Next
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = dttbl.Rows(i)
            dr("nomor") = CInt(i + 1)
        Next
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private Sub teSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teSearch.KeyPress
        If lueUnit.EditValue Is Nothing Then Exit Sub
        If lueDept.EditValue Is Nothing Then Exit Sub
        If teSearch.Text.Length = 0 Then Exit Sub

        If Asc(e.KeyChar) = 13 Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select i.iditem,i.item,'('+ gc.generalcode +')' as note,convert(bit,0) as cek from item i left join sys_generalcode gc on i.itemtype=gc.idgeneral and gc.gctype='ITEMTYPE' where i.itemtype in (1,11) and (i.iditem='" & teSearch.Text & "' or i.kodeupc='" & teSearch.Text & "')", "getitem")

            If sqls.getDataSet("getitem") > 0 Then
                Dim iditem As String = sqls.getDataSet("getitem", 0, "iditem")
                Dim idx As Integer = 0
                Dim qtyinput As Integer = 0
                Dim cekExist As Boolean = False
                For a As Integer = 0 To gvData.RowCount - 1
                    Dim drc As DataRow = gvData.GetDataRow(a)
                    If drc("iditem") = iditem Then
                        cekExist = True
                        qtyinput = CInt(drc("qtyinput"))
                        idx = a
                        Exit For
                    End If
                Next
                If cekExist = False Then
                    Dim dr As DataRow = dttbl.NewRow
                    'convert(varchar(50),'0') as idtransaksidt,ROW_NUMBER() OVER (Order by i.item asc) as nomor,i.iditem,ig.itemgrup,i.kode,i.item,convert(decimal(8,2),0) as qtyselisih,isnull(iu.qty,0) as qty,isnull(iu.qty,0) as qtyinput

                    sqls.DMLQuery("select i.iditem,ig.itemgrup,i.kode,i.item,convert(decimal(8,2),0) as qtyselisih,isnull(iu.qty,0) as qty,isnull(iu.qty,1) as qtyinput from item i left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join itemunit iu on iu.iditem=i.iditem and iu.idunit='" & lueUnit.EditValue & "' and iu.iddepartment='" & lueDept.EditValue & "' where i.iditem='" & iditem & "'", "dataitem")

                    dr("idtransaksidt") = GenerateGUID()
                    dr("nomor") = "0"
                    dr("iditem") = iditem
                    dr("itemgrup") = sqls.getDataSet("dataitem", 0, "itemgrup")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("qty") = sqls.getDataSet("dataitem", 0, "qty")
                    dr("qtyselisih") = sqls.getDataSet("dataitem", 0, "qtyselisih")
                    dr("qtyinput") = sqls.getDataSet("dataitem", 0, "qtyinput")

                    dttbl.Rows.Add(dr)
                    For i As Integer = 0 To gvData.RowCount - 1
                        Dim dra As DataRow = dttbl.Rows(i)
                        dra("nomor") = CInt(i + 1)
                    Next
                    gcData.DataSource = dttbl
                    gvData.BestFitColumns()
                Else
                    Dim dr As DataRow = dttbl.Rows(idx)
                    dr("qtyinput") = qtyinput + 1
                    gcData.DataSource = dttbl
                    gvData.BestFitColumns()
                End If
            End If
            teSearch.Text = ""
        End If
    End Sub

    Private Sub Search_KeyDown(sender As Object, e As KeyEventArgs) Handles gvData.KeyDown, gcData.KeyDown, lueUnit.KeyDown, gvItem.KeyDown, gcItem.KeyDown, btnAllItem.KeyDown, btnDeleteItem.KeyDown, btnItemSelect.KeyDown, btnNew.KeyDown, btnSave.KeyDown, tlpForm.KeyDown, pTitle.KeyDown, pBody.KeyDown, Panel1.KeyDown, tlpField.KeyDown, xtcItem.KeyDown, xtpItem.KeyDown, pItem.KeyDown, pHeader.KeyDown, pSearch.KeyDown, lueDept.KeyDown, lueUnit.KeyDown, teNote.KeyDown, btnLock.KeyDown
        If e.KeyData = Keys.F3 Then
            teSearch.Focus()
        End If
    End Sub

End Class