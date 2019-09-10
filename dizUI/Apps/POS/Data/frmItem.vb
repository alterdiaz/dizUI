Public Class frmItem
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

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select i.iditem,i.iditemgrup,i.itemtype,gc.generalcode as type,g.itemgrup as grup,i.kode,i.iditembrand,ib.nama as itembrand,i.item,i.isdeleted,d.generalcode as statdata,i.idsatuan,s.satuan,i.remarks from item i left join itembrand ib on i.iditembrand=ib.iditembrand left join satuan s on i.idsatuan=s.idsatuan left join itemgrup g on i.iditemgrup=g.iditemgrup left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join sys_generalcode d on d.idgeneral=i.isdeleted and d.gctype='DELETE' order by i.item asc", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select iditembrand as id,nama as content from itembrand where isdeleted=0 order by nama asc", "brand")
        lueBrand.Properties.DataSource = mysqls.dataTable("brand")
        lueBrand.Properties.ValueMember = "id"
        lueBrand.Properties.DisplayMember = "content"

        rlueBrand.DataSource = mysqls.dataTable("brand")
        rlueBrand.ValueMember = "id"
        rlueBrand.DisplayMember = "content"
        rlueBrand.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        mysqls.DMLQuery("select iditemgrup as id,itemgrup as content from itemgrup order by itemgrup asc", "grup")
        lueGrup.Properties.DataSource = mysqls.dataTable("grup")
        lueGrup.Properties.ValueMember = "id"
        lueGrup.Properties.DisplayMember = "content"

        rlueGrup.DataSource = mysqls.dataTable("grup")
        rlueGrup.ValueMember = "id"
        rlueGrup.DisplayMember = "content"
        rlueGrup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ITEMTYPE'", "type")
        lueType.Properties.DataSource = mysqls.dataTable("type")
        lueType.Properties.ValueMember = "id"
        lueType.Properties.DisplayMember = "content"

        rlueTipe.DataSource = mysqls.dataTable("type")
        rlueTipe.ValueMember = "id"
        rlueTipe.DisplayMember = "content"
        rlueTipe.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        mysqls.DMLQuery("select idsatuan as id,satuan as content from satuan where isdeleted=0", "satuan")
        lueSatuan.Properties.DataSource = mysqls.dataTable("satuan")
        lueSatuan.Properties.ValueMember = "id"
        lueSatuan.Properties.DisplayMember = "content"

        rlueSatuan.DataSource = mysqls.dataTable("satuan")
        rlueSatuan.ValueMember = "id"
        rlueSatuan.DisplayMember = "content"
        rlueSatuan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='DELETE'", "statusdata")
        rlueStatus.DataSource = mysqls.dataTable("statusdata")
        rlueStatus.ValueMember = "id"
        rlueStatus.DisplayMember = "content"
        rlueSatuan.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        kosongkanIsian(tlpField)

        lueGrup.Properties.ReadOnly = False
        lueType.Properties.ReadOnly = False
        teKode.Properties.ReadOnly = False

        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        statData = statusData.Baru
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iditem from item where kode='" & teKode.Text & "'", "kodeexist")
            If sqls.getDataSet("kodeexist") > 0 Then
                dizMsgbox("Kode tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teKode.Focus()
                Exit Sub
            End If
            sqls.DMLQuery("select iditem from item where replace(item,' ','')='" & teNama.Text.Replace(" ", "") & "' and itemgrup='" & lueGrup.EditValue & "' and itemtype='" & lueType.EditValue & "'", "exist")
            If sqls.getDataSet("exist") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                teNama.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Edit Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iditem from item where kode='" & teKode.Text & "' and iditem <>'" & idData & "'", "kodeexist")
            If sqls.getDataSet("kodeexist") > 0 Then
                dizMsgbox("Kode tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teKode.Focus()
                Exit Sub
            End If
            sqls.DMLQuery("Select item from item where replace(item,' ','')='" & teNama.Text.Replace(" ", "") & "' and itemgrup='" & lueGrup.EditValue & "' and itemtype='" & lueType.EditValue & "' and iditem<>'" & idData & "'", "exist")
            If sqls.getDataSet("exist") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                teNama.Focus()
                Exit Sub
            End If
        End If

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If statData = statusData.Baru Then
            idData = GenerateGUID()
            teKode.Text = generateno3("", lueType.Text.ToUpper.Chars(0), "yyyy", False)
            field.AddRange(New String() {"iditem", "iditembrand", "idsatuan", "itemgrup", "itemtype", "kode", "item", "remarks", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, lueBrand.EditValue, lueSatuan.EditValue, lueGrup.EditValue, lueType.EditValue, teKode.Text, teNama.Text, teRemarks.Text, 0, userid, nowTime})
        Else
            Dim sql1 As New SQLs(dbstring)
            sql1.DMLQuery("select idtransaksidt from transaksidt where iditem='" & idData & "'", "cektrf")
            If sql1.getDataSet("cektrf") > 0 Then
                field.AddRange(New String() {"iditem", "item", "remarks", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, teNama.Text, teRemarks.Text, userid, nowTime})
            Else
                field.AddRange(New String() {"iditem", "idsatuan", "item", "remarks", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, lueSatuan.EditValue, teNama.Text, teRemarks.Text, userid, nowTime})
            End If
        End If

        If dtSQL.datasetSave("item", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "item")

            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim retval As Boolean = False
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"iditem", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("item", idData, field, value, False)
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"iditem", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("item", idData, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "item")
        btnNew_Click(Me, Nothing)
    End Sub

    Private isdeleted As String = ""
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        If isExport = True Then Exit Sub
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            lueGrup.Properties.ReadOnly = False
            lueType.Properties.ReadOnly = False
            teKode.Properties.ReadOnly = False

            lueBrand.EditValue = dcol("iditembrand")
            lueGrup.EditValue = dcol("iditemgrup")
            lueType.EditValue = dcol("itemtype")
            lueSatuan.EditValue = dcol("idsatuan")
            teKode.Text = dcol("kode")
            teNama.Text = dcol("item")
            teRemarks.Text = dcol("remarks")

            idData = dcol("iditem")

            Dim sql1 As New SQLs(dbstring)
            sql1.DMLQuery("select idtransaksidt from transaksidt where iditem='" & idData & "'", "cektrf")
            If sql1.getDataSet("cektrf") > 0 Then
                lueGrup.Properties.ReadOnly = True
                lueType.Properties.ReadOnly = True
                teKode.Properties.ReadOnly = True
            End If
            statData = statusData.Edit
            isdeleted = dcol("isdeleted")
            If isdeleted = 1 Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If

            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()

        checkFieldMaxLength(dbstring, tlpField, "item")
        btnNew_Click(Me, Nothing)
    End Sub

    Private isExport As Boolean = False
    Private Sub btnExportFormat_Click(sender As Object, e As EventArgs) Handles btnExportFormat.Click
        isExport = True
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select i.iditem,i.iditemgrup,i.itemtype,gc.generalcode as type,g.itemgrup as grup,i.kode,i.item,i.isdeleted,d.generalcode as statdata,i.idsatuan,s.satuan,i.remarks from item i left join satuan s on i.idsatuan=s.idsatuan left join itemgrup g on i.iditemgrup=g.iditemgrup left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join sys_generalcode d on d.idgeneral=i.isdeleted and d.gctype='DELETE' where 1=0", "data")
        gcData.DataSource = sqls.dataTable("data")
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

        btnNew_Click(btnNew, Nothing)
        isExport = False
    End Sub

    Private Sub btnImportFormat_Click(sender As Object, e As EventArgs) Handles btnImportFormat.Click
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

    Private Sub btnSaveAll_Click(sender As Object, e As EventArgs) Handles btnSaveAll.Click
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor
        Threading.Thread.Sleep(1000)

        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            If dr.RowState = DataRowState.Modified Then
                Dim dtsql As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"iditem", "iditembrand", "itemtype", "iditemgrup", "idsatuan", "kode", "item", "isdeleted", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, dr("iditembrand"), dr("itemtype"), dr("iditemgrup"), dr("idsatuan"), dr("kode"), dr("item"), dr("isdeleted"), userid, nowTime})
                dtsql.datasetSave("item", idData, field, value, False)
                isiLog(userid, dbstring, field, value, "item")
            End If
        Next

        Me.Cursor = Cursors.Default
        splashClosed = True

        dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
        btnNew_Click(btnNew, Nothing)
    End Sub

End Class