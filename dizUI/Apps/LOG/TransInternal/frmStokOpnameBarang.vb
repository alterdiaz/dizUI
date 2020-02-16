Imports DevExpress.XtraGrid.Views.Base
Public Class frmStokOpnameBarang

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
        loadLOV()
        loadgrid("", "")
        kosongkan()
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

    Private Sub loadgrid(idunit As String, iddept As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select convert(varchar(50),'0') as idtransaksidt,ROW_NUMBER() OVER (Order by i.item asc) as nomor,i.iditem,ig.itemgrup,i.kode,i.item,convert(decimal(8,2),0) as qtyselisih,isnull(iu.qty,0) as qty,isnull(iu.qty,0) as qtyinput from item i left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join itemunit iu on iu.iditem=i.iditem and iu.idunit='" & idunit & "' and iu.iddepartment='" & iddept & "' where i.itemtype in (1,11) order by i.item asc", "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub

    Private iddata As String = "-1"
    Private statdata As statusData = statusData.Baru
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        loadgrid("", "")
        kosongkan()
        iddata = "-1"
        statdata = statusData.Baru
    End Sub

    Private Sub lueUnit_EditValueChanged(sender As Object, e As EventArgs) Handles lueUnit.EditValueChanged, lueDept.EditValueChanged
        loadgrid(If(lueUnit.EditValue, "0"), If(lueDept.EditValue, "0"))
        gvData.ViewCaption = "Stok Opname"

        If lueUnit.EditValue Is Nothing Then Exit Sub
        If lueDept.EditValue Is Nothing Then Exit Sub

        gvData.ViewCaption = Format(nowTime, "dd-MM-yyyy") & "|" & lueUnit.EditValue & "|" & lueDept.EditValue

        If statdata = statusData.Baru Then
            Dim pair As KeyValuePair(Of String, String) = generateno2(If(lueUnit.EditValue, "0"), If(lueDept.EditValue, "0"), "Opname Barang", True)
            teNoTransaksi.Text = pair.Value
            teNoTransaksi.Tag = pair.Key
        End If
    End Sub

    Private isExport As Boolean = False
    Private Sub btnExportFormat_Click(sender As Object, e As EventArgs) Handles btnExportFormat.Click
        If lueUnit.EditValue Is Nothing Then Exit Sub
        If lueDept.EditValue Is Nothing Then Exit Sub

        isExport = True

        riseQty.IsFloatValue = True
        GridColumn5.ColumnEdit = riseQty
        GridColumn6.ColumnEdit = riseQty

        GridColumn23.Visible = True
        GridColumn23.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

        GridColumn23.VisibleIndex = 0
        GridColumn1.VisibleIndex = 1
        GridColumn2.VisibleIndex = 2
        GridColumn3.VisibleIndex = 3
        GridColumn24.VisibleIndex = 4
        GridColumn5.VisibleIndex = 5
        GridColumn6.VisibleIndex = 6
        gvData.BestFitColumns()

        Dim gctmp As New DevExpress.XtraGrid.GridControl
        Dim gvtmp As New DevExpress.XtraGrid.Views.Grid.GridView
        gctmp = gcData
        gvtmp = gvData
        For Each gc As DevExpress.XtraGrid.Columns.GridColumn In gvtmp.Columns
            gc.AppearanceCell.BackColor = Nothing
            gc.ColumnEdit = Nothing

            For Each gc1 As DevExpress.XtraGrid.Columns.GridColumn In gvData.Columns
                If gc.Name = gc1.Name Then
                    gc.Width = gc1.Width
                    gc.MinWidth = gc1.Width
                End If
            Next
        Next
        gvtmp.BestFitColumns()

        Dim exp As New frmExportExcel(gvtmp, True, False, False)
        tambahChild(exp)
        exp.ShowDialog()

        riseQty.IsFloatValue = True
        GridColumn5.ColumnEdit = riseQty
        GridColumn6.ColumnEdit = riseQty

        GridColumn23.Visible = False
        GridColumn1.VisibleIndex = 0
        GridColumn2.VisibleIndex = 1
        GridColumn3.VisibleIndex = 2
        GridColumn24.VisibleIndex = 3
        GridColumn5.VisibleIndex = 4
        GridColumn6.VisibleIndex = 5
        GridColumn6.AppearanceCell.BackColor = Color.FromArgb(192, 255, 192)
        GridColumn6.OptionsColumn.AllowEdit = True
        GridColumn6.OptionsColumn.ReadOnly = False

        isExport = False
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

                    fieldlog.AddRange(New String() {"iditemlog", "iditem", "iddepartment", "idunit", "idreff", "tablereff", "idreff2", "tablereff2", "noreff", "trfreff", "qty", "io", "remarks", "createdby", "createddate", "idcompany"})
                    If dr("qtyselisih") < 0 Then
                        valuelog.AddRange(New Object() {iditemlog, idlogitem, lueDept.EditValue, lueUnit.EditValue, iddata, "Transaksi", iddatalog, "TransaksiDT", teNoTransaksi.Text, "Stok Opname", qty, 2, "Opname Kurang " & vbCrLf & teNoTransaksi.Text, userid, nowTime, idcomp})
                    Else
                        valuelog.AddRange(New Object() {iditemlog, iditem, lueDept.EditValue, lueUnit.EditValue, iddata, "Transaksi", iddatalog, "TransaksiDT", teNoTransaksi.Text, "Stok Opname", qty, 1, "Opname Lebih " & vbCrLf & teNoTransaksi.Text, userid, nowTime, idcomp})
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
                        fieldunit.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "createdby", "createddate", "idcompany"})
                        valueunit.AddRange(New Object() {iditemunit, iditem, lueDept.EditValue, lueUnit.EditValue, qtyexist, userid, nowTime, idcomp})
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

    Private Sub btnImportFormat_Click(sender As Object, e As EventArgs) Handles btnImportFormat.Click
        If lueUnit.EditValue Is Nothing Then Exit Sub
        If lueDept.EditValue Is Nothing Then Exit Sub

        Dim open As New OpenFileDialog
        open.AddExtension = False
        open.AutoUpgradeEnabled = True
        open.CheckFileExists = True
        open.CheckPathExists = True
        open.DefaultExt = "xls"
        open.Filter = "Old Excel Files|*.xls"
        open.FilterIndex = 1
        open.InitialDirectory = pathTemp
        open.Multiselect = False
        open.ShowHelp = False

        If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim cnt As Long = 0
            Dim dt As DataTable = ImportExcelXLS(open.FileName)
            For i As Integer = 0 To dt.Rows.Count - 1
                Try
                    Dim dra As DataRow = dt.Rows(i)
                    'For a As Integer = 0 To dt.Columns.Count - 1
                    '    MsgBox(dra(a))
                    'Next

                    Dim dr As DataRow = dt.Rows(i)
                    Dim brggrup As String = If(dr(0), "")
                    Dim brgtipe As String = If(dr(1), "")
                    Dim brgkode As String = If(dr(2), "")
                    Dim brgbrand As String = If(dr(3), "")
                    Dim brgname As String = If(dr(4), "")
                    Dim brgsat As String = If(dr(5), "")
                    Dim brgstat As String = If(dr(6), "")

                    If brgname = "" Or brggrup = "" Or brgtipe = "" Or brgsat = "" Or brgbrand = "" Or (brgname = "" And brggrup = "" And brgtipe = "" And brgsat = "" And brgbrand = "") Then Exit Try

                    Dim iditem As String = "0"
                    Dim idgrup As String = "0"
                    Dim idsat As String = "0"
                    Dim idtipe As String = "0"
                    Dim idbrand As String = "0"

                    If brgkode = "" Or brgkode = "-" Or brgkode = "0" Then brgkode = Format(nowTime, "yyyyMMddHHmmssfff")
                    Dim sqls As New SQLs(dbstring)
                    If brgname <> "" Then
                        sqls.DMLQuery("select * from item where replace(item,' ','')='" & brgname.Replace(" ", "") & "'", "cekitem")
                        If sqls.getDataSet("cekitem") > 0 Then
                            iditem = sqls.getDataSet("cekitem", 0, "iditem")
                        End If
                    End If
                    If brggrup <> "" Then
                        sqls.DMLQuery("select * from itemgrup where replace(itemgrup,' ','')='" & brggrup.Replace(" ", "") & "'", "cekgrup")
                        If sqls.getDataSet("cekgrup") > 0 Then
                            idgrup = sqls.getDataSet("cekgrup", 0, "iditemgrup")
                        End If
                    End If
                    If brgsat <> "" Then
                        sqls.DMLQuery("select * from satuan where replace(satuan,' ','')='" & brgsat.Replace(" ", "") & "'", "ceksat")
                        If sqls.getDataSet("ceksat") > 0 Then
                            idsat = sqls.getDataSet("ceksat", 0, "idsatuan")
                        End If
                    End If
                    If brgbrand <> "" Then
                        sqls.DMLQuery("select * from itembrand where replace(nama,' ','')='" & brgbrand.Replace(" ", "") & "'", "cekbrand")
                        If sqls.getDataSet("cekbrand") > 0 Then
                            idbrand = sqls.getDataSet("cekbrand", 0, "iditembrand")
                        End If
                    End If
                    If brgtipe <> "" Then
                        sqls.DMLQuery("select idgeneral,generalcode from sys_generalcode where gctype='ITEMTYPE' and replace(generalcode,' ','')='" & brgtipe.Replace(" ", "") & "'", "cektipe")
                        idtipe = "1"
                        If sqls.getDataSet("cektipe") > 0 Then
                            idtipe = sqls.getDataSet("cektipe", 0, "idgeneral")
                        End If
                    End If

                    If iditem = "0" Then
                        sqls.CallSP("spGetCompany", "CompID")
                        Dim idcomp As String = sqls.getDataSet("CompID", 0, "value")

                        If idsat = "0" Then
                            idsat = GenerateGUID()
                            Dim field As New List(Of String)
                            Dim value As New List(Of Object)
                            Dim dtsqls As New dtsetSQLS(dbstring)
                            field.AddRange(New String() {"idsatuan", "satuan", "isdeleted", "createdby", "idcompany"})
                            value.AddRange(New Object() {idsat, brgsat, 0, userid, idcomp})
                            dtsqls.datasetSave("satuan", idsat, field, value, False)
                        End If
                        If idgrup = "0" Then
                            idgrup = GenerateGUID()
                            Dim field As New List(Of String)
                            Dim value As New List(Of Object)
                            Dim dtsqls As New dtsetSQLS(dbstring)
                            field.AddRange(New String() {"iditemgrup", "itemgrup", "isdeleted", "createdby", "idcompany"})
                            value.AddRange(New Object() {idgrup, brggrup, 0, userid, idcomp})
                            dtsqls.datasetSave("itemgrup", idsat, field, value, False)
                        End If
                        If idbrand = "0" Then
                            idbrand = GenerateGUID()
                            Dim field As New List(Of String)
                            Dim value As New List(Of Object)
                            Dim dtsqls As New dtsetSQLS(dbstring)
                            field.AddRange(New String() {"iditembrand", "nama", "isdeleted", "createdby", "idcompany"})
                            value.AddRange(New Object() {idbrand, brgbrand, 0, userid, idcomp})
                            dtsqls.datasetSave("itembrand", idbrand, field, value, False)
                        End If

                        iditem = GenerateGUID()
                        Dim field1 As New List(Of String)
                        Dim value1 As New List(Of Object)
                        Dim dtsqls1 As New dtsetSQLS(dbstring)
                        field1.AddRange(New String() {"iditem", "iditembrand", "idsatuan", "iditemgrup", "itemtype", "kode", "item", "isppn", "ispph", "remarks", "isdeleted", "createdby", "idcompany"})
                        value1.AddRange(New Object() {iditem, idbrand, idsat, idgrup, idtipe, brgkode, brgname, 0, 0, "-", 0, userid, idcomp})

                        If dtsqls1.datasetSave("item", iditem, field1, value1, False) = True Then
                            cnt += 1
                        End If
                    End If
                Catch ex As Exception
                End Try
            Next
            If cnt > 0 Then
                dizMsgbox("Item Baru terimport sebanyak " & cnt, dizMsgboxStyle.Info)
            Else
                dizMsgbox("Tidak ada Item Baru yang diimport", dizMsgboxStyle.Info)
            End If
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Public Shared Function ImportExcelXLS(ByVal FileName As String) As DataTable
        Dim res As DataTable = Nothing
        Dim odbcConn = New Data.Odbc.OdbcConnection()
        Try
            Dim path As String = System.IO.Path.GetFullPath(FileName)
            odbcConn = New Data.Odbc.OdbcConnection("Driver={Microsoft Excel Driver (*.xls)};Dbq=" & path & ";ReadOnly=0;")
            odbcConn.Open()
            Dim cmd As Data.Odbc.OdbcCommand = New Data.Odbc.OdbcCommand()
            Dim oleda As Data.Odbc.OdbcDataAdapter = New Data.Odbc.OdbcDataAdapter()
            Dim ds As DataSet = New DataSet()
            Dim dt As DataTable = odbcConn.GetSchema("Tables")
            Dim sheetName As String = String.Empty

            If dt IsNot Nothing Then
                sheetName = dt.Rows(0)("TABLE_NAME").ToString()
            End If

            cmd.Connection = odbcConn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM [" & sheetName & "]"
            oleda = New Data.Odbc.OdbcDataAdapter(cmd)
            oleda.Fill(ds, "excelData")
            res = ds.Tables("excelData")
        Catch ex As Exception
        Finally
            odbcConn.Close()
        End Try
        Return res
    End Function

    Private Sub gvData_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvData.CellValueChanged
        RemoveHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged

        If e.Column Is GridColumn6 Then
            Dim selisih As Decimal = 0
            selisih = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn6)) - CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn5))
            gvData.SetFocusedRowCellValue(GridColumn8, selisih)
        End If

        AddHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged
    End Sub

End Class