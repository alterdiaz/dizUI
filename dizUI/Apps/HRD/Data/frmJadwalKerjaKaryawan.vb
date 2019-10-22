Imports DevExpress.XtraGrid.Views.Base

Public Class frmJadwalKerjaKaryawan
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

    Dim dtset As DataSet
    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged, lueDepartment.EditValueChanged, lueUnit.EditValueChanged
        Dim nmonth As Date = New Date(CDate(deTanggal.EditValue).AddMonths(1).Year, CDate(deTanggal.EditValue).AddMonths(1).Month, 1)
        Dim lastdate As Integer = nmonth.AddDays(-1).Day

        For Each gcol As DevExpress.XtraGrid.Columns.GridColumn In gvData.Columns
            If gcol.Name.Contains("gc") Then
                Dim tmpname As String = gcol.Name
                Dim tmpint As Integer = 0
                tmpint = CInt(tmpname.Remove(0, 2))
                If tmpint > lastdate Then
                    gcol.Visible = False
                Else
                    gcol.Visible = True
                    gcol.VisibleIndex = 3000 + tmpint
                End If
            End If
        Next

        Dim iscek As Boolean = False
        If deTanggal.EditValue Is Nothing Then
            iscek = True
        End If
        If lueUnit.EditValue Is Nothing Then
            iscek = True
        End If
        If iscek = True Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = " "
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Try
            If lueDepartment.EditValue Is Nothing Then
                Dim sqls As New SQLs(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"@periode", "@idunit"})
                value.AddRange(New Object() {Format(CDate(deTanggal.EditValue), "MMyyyy"), lueUnit.EditValue})
                sqls.CallSP("spGetJadwalKaryawanUnit", "data", field, value)
                Threading.Thread.Sleep(200)

                dtset = sqls.dataSet
                gcData.DataSource = dtset.Tables("data")
                gvData.BestFitColumns()
                gvData.OptionsView.ColumnAutoWidth = False
                gvData.ViewCaption = "Jadwal Kerja Karyawan - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year & " " & lueUnit.Text
            Else
                Dim sqls As New SQLs(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"@periode", "@iddept", "@idunit"})
                value.AddRange(New Object() {Format(CDate(deTanggal.EditValue), "MMyyyy"), lueDepartment.EditValue, lueUnit.EditValue})
                sqls.CallSP("spGetJadwalKaryawanUnitDept", "data", field, value)
                Threading.Thread.Sleep(200)

                dtset = sqls.dataSet
                gcData.DataSource = dtset.Tables("data")
                gvData.BestFitColumns()
                gvData.OptionsView.ColumnAutoWidth = False
                gvData.ViewCaption = "Jadwal Kerja Karyawan - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year & " " & lueUnit.Text
            End If
        Catch ex As Exception
        End Try

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
        lueDepartment.EditValue = Nothing
        lueUnit.EditValue = Nothing
        deTanggal.EditValue = Nothing
        gvData.ViewCaption = ""
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iddepartment as id,department as content from department where isdeleted=0", "dept")
        lueDepartment.Properties.DataSource = sqls.dataTable("dept")
        lueDepartment.Properties.ValueMember = "id"
        lueDepartment.Properties.DisplayMember = "content"
        lueDepartment.EditValue = Nothing

        sqls.DMLQuery("select idunit as id,unit as content from unit where idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit')) and isdeleted=0", "unit")
        lueUnit.Properties.DataSource = sqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
        lueUnit.EditValue = Nothing

        sqls.DMLQuery("select idjadwalsesi,kode,nama,left(convert(varchar,jammulai,108),5) as jammulai,left(convert(varchar,jamselesai,108),5) as jamselesai from jadwalsesi where isdeleted=0 union select '0' as idjadwalsesi,'NULL' as kode,'Belum Dipilih' as nama,'00:00' as jammulai,'00:00' as jamselesai order by jammulai asc,nama asc", "jadwal")
        riLUE.DataSource = sqls.dataTable("jadwal")
        riLUE.ValueMember = "idjadwalsesi"
        riLUE.DisplayMember = "kode"
        riLUE.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        deTanggal_EditValueChanged(deTanggal, Nothing)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If deTanggal.EditValue Is Nothing Then
            dizMsgbox("Periode belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If lueUnit.EditValue Is Nothing Then
            dizMsgbox("Unit belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If gvData.RowCount = 0 Then
            dizMsgbox("Data Jadwal tidak ditemukan", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        If dizMsgbox("Akan menggantikan data sebelumnya. Tetap melanjutkan ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim SQLs As New SQLs(dbstring)
        SQLs.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = SQLs.getDataSet("CompID", 0, "value")

        Dim colcnt As Long = 0
        Dim cnt As Long = 0
        Dim tmpdate As String = Format(CDate(deTanggal.EditValue), "MM-yyyy")
        For i As Integer = 0 To gvData.RowCount - 1
            Try
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim karyid As String = dr("idstaff")

                Dim cntday As Integer = 0
                For a As Integer = 0 To gvData.Columns.Count - 1
                    Dim gcol As DevExpress.XtraGrid.Columns.GridColumn = gvData.Columns(a)
                    If gcol.Name.Contains("gc") Then
                        If gcol.Visible = True Then
                            cntday = CInt(gcol.Name.Remove(0, 2))
                            SQLs = New SQLs(dbstring)
                            Dim tmpidjs As String = dr(gcol.FieldName)
                            'MsgBox(tmpidjs & vbCrLf & gcol.Name & vbCrLf & gcol.FieldName)
                            Dim tmpdate2 As String = Format(cntday, "0#") & "-" & tmpdate
                            Dim tmpdate3 As Date = Strdate2Date(tmpdate2)

                            SQLs.DMLQuery("select idstaffjadwal from staffjadwal where idstaff='" & karyid & "' and convert(varchar,tanggal,105)='" & tmpdate2 & "'", "getidjad")

                            Dim dtsqls As New dtsetSQLS(dbstring)
                            Dim field As New List(Of String)
                            Dim value As New List(Of Object)
                            Dim iddata As String = ""
                            If SQLs.getDataSet("getidjad") = 0 Then
                                If tmpidjs <> "0" Then
                                    iddata = GenerateGUID()
                                    field.AddRange(New String() {"idstaffjadwal", "idstaff", "idjadwalsesi", "tanggal", "kehadiran", "isdeleted", "createdby", "idcompany"})
                                    value.AddRange(New Object() {iddata, karyid, tmpidjs, tmpdate3, 4, 0, userid, idcomp})
                                    dtsqls.datasetSave("staffjadwal", iddata, field, value, False)
                                End If
                            Else
                                iddata = SQLs.getDataSet("getidjad", 0, "idstaffjadwal")
                                field.AddRange(New String() {"idstaffjadwal", "idstaff", "idjadwalsesi", "updateddate", "updatedby"})
                                value.AddRange(New Object() {iddata, karyid, tmpidjs, nowTime, userid})
                                dtsqls.datasetSave("staffjadwal", iddata, field, value, False)
                            End If
                        End If
                    End If
                Next
                cnt += 1
            Catch ex As Exception
            End Try
        Next

        Me.Cursor = Cursors.Default
        splashClosed = True

        If cnt > 0 Then
            dizMsgbox("Jadwal Karyawan tersimpan", dizMsgboxStyle.Info, Me)
        Else
            dizMsgbox("Tidak ada Jadwal Karyawan tersimpan", dizMsgboxStyle.Info, Me)
        End If
        btnRefresh_Click(Me, Nothing)
    End Sub

    Private Sub btnClearDept_Click(sender As Object, e As EventArgs) Handles btnClearDept.Click
        If lueDepartment.EditValue IsNot Nothing Then
            lueDepartment.EditValue = Nothing
        End If
    End Sub

    Private Sub gvData_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvData.CellValueChanged
        RemoveHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged
        gvData.BestFitColumns()
        AddHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged
    End Sub

    Private isExport As Boolean = False
    Private Sub btnExportFormat_Click(sender As Object, e As EventArgs) Handles btnExportFormat.Click
        If deTanggal.EditValue Is Nothing Then
            dizMsgbox("Periode belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If lueUnit.EditValue Is Nothing Then
            dizMsgbox("Unit belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If gvData.RowCount = 0 Then
            dizMsgbox("Data Jadwal tidak ditemukan", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        isExport = True

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

        isExport = False

        For Each gcol As DevExpress.XtraGrid.Columns.GridColumn In gvData.Columns
            If gcol.Name.Contains("gc") Then
                gcol.ColumnEdit = riLUE
                gcol.Width = 50
                gcol.MinWidth = 20
            End If
        Next
        gvData.BestFitColumns()
    End Sub

    Private Sub btnImportFormat_Click(sender As Object, e As EventArgs) Handles btnImportFormat.Click
        If deTanggal.EditValue Is Nothing Then
            dizMsgbox("Periode belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If lueUnit.EditValue Is Nothing Then
            dizMsgbox("Unit belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If gvData.RowCount = 0 Then
            dizMsgbox("Data Jadwal tidak ditemukan", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

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
            If dizMsgbox("Akan menggantikan data sebelumnya. Tetap melanjutkan ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                Exit Sub
            End If

            Dim loadScr As New frmLoading()
            splashClosed = False
            loadScr.Show(Me)
            loadScr.BringToFront()
            Application.DoEvents()
            Me.Cursor = Cursors.WaitCursor

            Dim sqls As New SQLs(dbstring)
            sqls.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqls.getDataSet("CompID", 0, "value")
            Dim tmpdate As String = Format(CDate(deTanggal.EditValue), "MM-yyyy")

            Dim colcnt As Long = 0
            Dim cnt As Long = 0
            Dim dt As DataTable = ImportExcelXLS(open.FileName)
            If dt.Rows.Count - 1 <> gvData.RowCount Then
                dizMsgbox("Data Jadwal tidak sama", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
            colcnt = dt.Columns.Count - 4
            For i As Integer = 0 To dt.Rows.Count - 1
                Try
                    Dim dr As DataRow = dt.Rows(i)
                    Dim karynama As String = If(dr(2), "")
                    Dim karyid As String = If(dr(4), "")
                    If karynama = "" Then Exit Try
                    If karyid = "" Then Exit Try

                    sqls = New SQLs(dbstring)
                    Dim cntday As Integer = 1
                    For a As Integer = 5 To dt.Columns.Count - 1
                        sqls = New SQLs(dbstring)
                        Dim tmpstr As String = dr(a)
                        Dim tmpidjs As String = "0"
                        If tmpstr <> "" Then
                            sqls.DMLQuery("select idjadwalsesi from jadwalsesi where replace(kode,' ','')='" & tmpstr & "'", "getidjs")
                            If sqls.getDataSet("getidjs") > 0 Then
                                tmpidjs = sqls.getDataSet("getidjs", 0, "idjadwalsesi")
                            Else
                                tmpidjs = "0"
                            End If
                        End If

                        Dim tmpdate2 As String = Format(cntday, "0#") & "-" & tmpdate
                        Dim tmpdate3 As Date = Strdate2Date(tmpdate2)

                        sqls.DMLQuery("select idstaffjadwal from staffjadwal where idstaff='" & karyid & "' and convert(varchar,tanggal,105)='" & tmpdate2 & "'", "getidjad")

                        Dim dtsqls As New dtsetSQLS(dbstring)
                        Dim field As New List(Of String)
                        Dim value As New List(Of Object)
                        Dim iddata As String = ""
                        If sqls.getDataSet("getidjad") = 0 Then
                            If tmpidjs <> "0" Then
                                iddata = GenerateGUID()
                                field.AddRange(New String() {"idstaffjadwal", "idstaff", "idjadwalsesi", "tanggal", "kehadiran", "isdeleted", "createdby", "idcompany"})
                                value.AddRange(New Object() {iddata, karyid, tmpidjs, tmpdate3, 4, 0, userid, idcomp})
                                If dtsqls.datasetSave("staffjadwal", iddata, field, value, False) = True Then
                                    cnt += 1
                                End If
                            End If
                        Else
                            iddata = sqls.getDataSet("getidjad", 0, "idstaffjadwal")
                            sqls.DMLQuery("select idstaffjadwal from staffjadwal where isreviewed=0 and idstaffjadwal='" & iddata & "'", "cekreview")
                            If sqls.getDataSet("cekreview") > 0 Then
                                field.AddRange(New String() {"idstaffjadwal", "idstaff", "idjadwalsesi", "updateddate", "updatedby"})
                                value.AddRange(New Object() {iddata, karyid, tmpidjs, nowTime, userid})
                                If dtsqls.datasetSave("staffjadwal", iddata, field, value, False) = True Then
                                    cnt += 1
                                End If
                            End If
                        End If
                        cntday += 1
                    Next
                Catch ex As Exception
                End Try
            Next

            Me.Cursor = Cursors.Default
            splashClosed = True

            If cnt > 0 Then
                dizMsgbox("Jadwal terimport sebanyak " & cnt, dizMsgboxStyle.Info, Me)
            Else
                dizMsgbox("Tidak ada Jadwal yang diimport", dizMsgboxStyle.Info, Me)
            End If
            btnRefresh_Click(Me, Nothing)
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

End Class