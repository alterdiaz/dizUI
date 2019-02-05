Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.DataAccess.Excel

Public Class frmItemPriceKelas

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

    Private cnt As Integer = 1
    Private param As String = ""
    Private Sub frmItemPriceKelas_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        sccForm.SplitterPosition = sccForm.Width - 275

        gvData.OptionsView.ColumnAutoWidth = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idkelas,kelas from kelas where isdeleted=0 order by priority asc", "kelas")

        For i As Integer = 0 To sqls.getDataSet("kelas") - 1
            Dim gcharga As New DevExpress.XtraGrid.Columns.GridColumn

            gcharga.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            gcharga.AppearanceCell.Options.UseBackColor = True
            gcharga.AppearanceHeader.Options.UseTextOptions = True
            gcharga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            gcharga.Width = 100
            gcharga.MaxWidth = 100
            gcharga.MinWidth = 100
            gcharga.Caption = sqls.getDataSet("kelas", i, "kelas")
            gcharga.ColumnEdit = Me.RepositoryItemSpinEdit1
            gcharga.FieldName = sqls.getDataSet("kelas", i, "idkelas")
            gcharga.Name = "gcHarga" & (i + 1)
            gcharga.Tag = sqls.getDataSet("kelas", i, "idkelas")
            gcharga.Visible = True
            gcharga.VisibleIndex = 10 + i

            gvData.Columns.Add(gcharga)
            param &= ",convert(decimal(20,2),0) as '" & sqls.getDataSet("kelas", i, "idkelas") & "'"
            cnt += 1
        Next

        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        lueUnit.EditValue = Nothing
        deTanggalStart.EditValue = Nothing
        deTanggalEnd.EditValue = Nothing

        loadUnit()
        loadgrid(param)
    End Sub

    Private Sub deTanggalStart_EditValueChanged(sender As Object, e As EventArgs) Handles deTanggalStart.EditValueChanged, deTanggalEnd.EditValueChanged
        If deTanggalStart.EditValue Is Nothing Then Exit Sub
        If deTanggalEnd.EditValue Is Nothing Then Exit Sub

        If CDate(deTanggalEnd.EditValue) < CDate(deTanggalStart.EditValue) Then
            dizMsgbox("Tanggal Awal harus dibawah Tanggal Akhir", dizMsgboxStyle.Peringatan, "Kesalahan Tanggal", Me)
            CType(sender, DevExpress.XtraEditors.DateEdit).EditValue = Nothing
            Exit Sub
        End If
    End Sub

    Private dttbl As New DataTable
    Private Sub loadgrid(Optional ByVal param As String = "")
        dttbl = New DataTable
        Dim sqls As New SQLs(dbstring) 'iditem,itemtype,type,iditemgrup,itemgrup,kode,item
        sqls.DMLQuery("select i.iditem,i.itemtype,gc.generalcode as type,i.kode,i.item,i.iditemgrup,ig.itemgrup" & param & " from item i left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' where 1=0", "getnull")
        dttbl = sqls.dataTable("getnull")
        gcData.DataSource = dttbl
    End Sub

    Private Sub loadUnit()
        Dim sqls As New SQLs(dbstring)
        Dim str As String = ""
        sqls.DMLQuery("select u.idunit as id,u.unit as content from unit u where u.isdeleted=0 and u.idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit'))", "getunit")

        lueUnit.Properties.DataSource = sqls.dataTable("getunit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
        If sqls.getDataSet("getunit") = 1 Then
            lueUnit.EditValue = sqls.getDataSet("getunit", 0, "id")
        Else
            lueUnit.EditValue = Nothing
        End If
    End Sub

    Private Sub loadItem(ByVal idunit As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@idunit"})
        value.AddRange(New Object() {idunit})
        sqls.CallSP("spLoadLOVItemAll", "getitem", field, value)
        gcItem.DataSource = sqls.dataTable("getitem")
    End Sub

    Private Sub lueUnit_EditValueChanged(sender As Object, e As EventArgs) Handles lueUnit.EditValueChanged
        If lueUnit.EditValue Is Nothing Then Exit Sub

        loadItem(lueUnit.EditValue)
    End Sub

    Private Sub btnAllItem_Click(sender As Object, e As EventArgs) Handles btnAllItem.Click
        param = param.Replace("convert(decimal(20,2),0) as '", "")
        param = param.Replace("')", "")
        param = param.Replace("'", "")

        Dim kolname As String() = param.Split(",")
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
                    sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty,i.iditemgrup,ig.itemgrup from item i left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where i.iditem='" & dra("iditem") & "'", "dataitem")
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("iditemgrup") = sqls.getDataSet("dataitem", 0, "iditemgrup")
                    dr("itemgrup") = sqls.getDataSet("dataitem", 0, "itemgrup")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    For a As Integer = 0 To kolname.Length - 1
                        If kolname(a) <> "" Then
                            dr(kolname(a)) = CDec(0)
                            Dim sqlsa As New SQLs(dbstring)
                            sqlsa.DMLQuery("select harga from itemharga where startdate<=convert(date,'" & Format(CDate(deTanggalStart.EditValue), "MM-dd-yyyy") & "') and enddate>=convert(date,'" & Format(CDate(deTanggalEnd.EditValue), "MM-dd-yyyy") & "') and isdeleted=0 and idkelas='" & kolname(a) & "' and idunit='" & lueUnit.EditValue & "' and iditem='" & dra("iditem") & "'", "cekexistharga")
                            If sqlsa.getDataSet("cekexistharga") > 0 Then
                                dr(kolname(a)) = CDec(sqlsa.getDataSet("cekexistharga", 0, "harga"))
                            End If
                        End If
                    Next
                    dttbl.Rows.Add(dr)
                End If
            Next
            gcData.DataSource = dttbl
            gvData.BestFitColumns()
        End If
    End Sub

    Private Sub btnItemSelect_Click(sender As Object, e As EventArgs) Handles btnItemSelect.Click
        param = param.Replace("convert(decimal(20,2),0) as '", "")
        param = param.Replace("')", "")
        param = param.Replace("'", "")

        Dim kolname As String() = param.Split(",")
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
                    sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty,i.iditemgrup,ig.itemgrup from item i left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where i.iditem='" & dra("iditem") & "'", "dataitem")
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("iditemgrup") = sqls.getDataSet("dataitem", 0, "iditemgrup")
                    dr("itemgrup") = sqls.getDataSet("dataitem", 0, "itemgrup")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    For a As Integer = 0 To kolname.Length - 1
                        If kolname(a) <> "" Then
                            dr(kolname(a)) = 0
                            Dim sqlsa As New SQLs(dbstring)
                            sqlsa.DMLQuery("select harga from itemharga where startdate<=convert(date,'" & Format(CDate(deTanggalStart.EditValue), "MM-dd-yyyy") & "') and enddate>=convert(date,'" & Format(CDate(deTanggalEnd.EditValue), "MM-dd-yyyy") & "') and isdeleted=0 and idkelas='" & kolname(a) & "' and idunit='" & lueUnit.EditValue & "' and iditem='" & dra("iditem") & "'", "cekexistharga")
                            If sqlsa.getDataSet("cekexistharga") > 0 Then
                                dr(kolname(a)) = CDec(sqlsa.getDataSet("cekexistharga", 0, "harga"))
                            End If
                        End If
                    Next
                    dttbl.Rows.Add(dr)
                End If
            End If
        Next
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private Sub btnDeleteAllItem_Click(sender As Object, e As EventArgs) Handles btnDeleteAllItem.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If dizMsgbox("Item yang telah dipilih" & vbCrLf & "Akan dihapus keseluruhan dari daftar" & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            loadgrid(param)
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
            dttbl.Rows.Remove(dr)
            gcData.DataSource = dttbl
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If deTanggalStart.EditValue Is Nothing Then
            dizMsgbox("Tanggal Berlaku belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If deTanggalEnd.EditValue Is Nothing Then
            dizMsgbox("Tanggal Berakhir belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If CDate(deTanggalStart.EditValue) = CDate(deTanggalEnd.EditValue) Then
            dizMsgbox("Tanggal Mulai dan Selesai belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If CDate(deTanggalStart.EditValue) > CDate(deTanggalEnd.EditValue) Then
            dizMsgbox("Tanggal Mulai dan Selesai belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim cek As Boolean = False
        Dim sqls As New SQLs(dbstring)
        For i As Integer = 0 To gvData.RowCount - 1
            sqls = New SQLs(dbstring)
            Dim dr As DataRow = gvData.GetDataRow(i)
            Dim iditem As String = dr("iditem")
            For a As Integer = 0 To cnt - 1
                Dim idkelas As String = ""
                Dim harga As Decimal = 0
                Dim obj As Object = Nothing
                For Each gc As DevExpress.XtraGrid.Columns.GridColumn In gvData.Columns
                    If gc.Name = "gcHarga" & (a + 1) Then
                        idkelas = gc.Tag
                        obj = gc
                        harga = CDec(dr(idkelas))
                    End If
                Next
                If harga <> CDec(0) Then
                    Dim dtSQL As New dtsetSQLS(dbstring)
                    Dim field As New List(Of String)
                    Dim value As New List(Of Object)

                    sqls.DMLQuery("select iditemharga from itemharga where startdate<=convert(date,'" & Format(CDate(deTanggalStart.EditValue), "MM-dd-yyyy") & "') and enddate>=convert(date,'" & Format(CDate(deTanggalEnd.EditValue), "MM-dd-yyyy") & "') and isdeleted=0 and idkelas='" & idkelas & "' and idunit='" & lueUnit.EditValue & "' and iditem='" & iditem & "'", "cekexistharga")
                    If sqls.getDataSet("cekexistharga") > 0 Then
                        For b As Integer = 0 To sqls.getDataSet("cekexistharga") - 1
                            sqls.DMLQuery("update itemharga set isdeleted=1,updateddate=getdate(),updatedby='" & userid & "' where iditemharga='" & sqls.getDataSet("cekexistharga", b, "iditemharga") & "'", False)
                        Next
                    End If
                    Dim idData As String = GenerateGUID()
                    field.AddRange(New String() {"iditemharga", "iditem", "idunit", "idkelas", "harga", "startdate", "enddate", "createdby", "createddate"})
                    value.AddRange(New Object() {idData, iditem, lueUnit.EditValue, idkelas, harga, CDate(deTanggalStart.EditValue), CDate(deTanggalEnd.EditValue), userid, nowTime})

                    cek = dtSQL.datasetSave("itemharga", idData, field, value, False)
                    If cek = True Then
                        isiLog(userid, dbstring, field, value, "itemharga")
                    End If
                End If
            Next
        Next

        Me.Cursor = Cursors.Default
        splashClosed = True

        If cek = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub btnExportFormat_Click(sender As Object, e As EventArgs) Handles btnExportFormat.Click
        If gvData.RowCount > 0 Then
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

            Dim exp As New frmExportExcel(gvtmp)
            tambahChild(exp)
            exp.ShowDialog()

            For Each gc As DevExpress.XtraGrid.Columns.GridColumn In gvtmp.Columns
                If gc.Name.Contains("gcHarga") = True Then
                    gc.AppearanceCell.BackColor = Color.FromArgb(192, 255, 192)
                    gc.ColumnEdit = RepositoryItemSpinEdit1
                End If
            Next
            gvtmp.BestFitColumns()
        Else
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub btnImportFormat_Click(sender As Object, e As EventArgs) Handles btnImportFormat.Click
        If gvData.RowCount > 0 Then
            Dim open As New OpenFileDialog
            open.AddExtension = False
            open.AutoUpgradeEnabled = True
            open.CheckFileExists = True
            open.CheckPathExists = True
            open.DefaultExt = "xlsx"
            open.Filter = "Old Excel Files|*.xls|Excel Files|*.xlsx"
            open.FilterIndex = 1
            open.InitialDirectory = pathIcon
            open.Multiselect = False
            open.ShowHelp = False

            If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim dt As DataTable = ImportExcelXLS(open.FileName)
                If dt.Rows.Count <> gvData.RowCount Then
                    dizMsgbox("Item tidak sama", dizMsgboxStyle.Kesalahan, Me)
                    Exit Sub
                End If
                Dim cek As Boolean = True
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim dr1 As DataRow = dt.Rows(i)
                    For a As Integer = 0 To gvData.RowCount - 1
                        Dim dr2 As DataRow = gvData.GetDataRow(a)
                        If CStr(dr1(0)) <> CStr(dr2("type")) And CStr(dr1(1)) <> CStr(dr2("itemgrup")) And CStr(dr1(2)) <> CStr(dr2("kode")) And CStr(dr1(3)) <> CStr(dr2("item")) Then
                            cek = False
                        End If
                        If CStr(dr1(0)) = CStr(dr2("type")) And CStr(dr1(1)) = CStr(dr2("itemgrup")) And CStr(dr1(2)) = CStr(dr2("kode")) And CStr(dr1(3)) = CStr(dr2("item")) Then
                            Exit For
                        End If
                        If cek = False Then
                            dizMsgbox("Item tidak sama", dizMsgboxStyle.Kesalahan, Me)
                            Exit Sub
                        End If
                    Next
                Next
                For i As Integer = 0 To dt.Columns.Count - 1
                    For a As Integer = 0 To gvData.Columns.Count - 1
                        Dim gc As DevExpress.XtraGrid.Columns.GridColumn = gvData.Columns(a)
                        If gc.Name.Contains("gcHarga") = True Then
                            If dt.Columns(i).Caption = gc.Caption Then
                                For b As Integer = 0 To dt.Rows.Count - 1
                                    Dim dr1 As DataRow = dt.Rows(b)
                                    Dim dr2 As DataRow = gvData.GetDataRow(b)
                                    If CStr(dr1(i)) <> "0" Then
                                        dr2(a) = dr1(i)
                                    End If
                                Next
                            End If
                        End If
                    Next
                Next
            End If
        Else
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Public Shared Function ImportExcelXLS(ByVal FileName As String) As DataTable
        Dim res As DataTable = Nothing
        Dim odbcConn = New Data.Odbc.OdbcConnection()
        Try
            Dim path As String = System.IO.Path.GetFullPath(FileName)
            odbcConn = New Data.Odbc.OdbcConnection(" Driver={Microsoft Excel Driver (*.xls)};Dbq=" & path & ";ReadOnly=0;")
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

End Class