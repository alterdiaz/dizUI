Public Class frmCOA
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
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
        splashClosed = True
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
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idgeneral as iddk, generalcode as dk from sys_generalcode where gctype='POSISIDK' order by idgeneral asc", "dk")
        luePosisi.Properties.DataSource = mysqls.dataTable("dk")
        luePosisi.Properties.DisplayMember = "dk"
        luePosisi.Properties.ValueMember = "iddk"
    End Sub

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select k.idcoa, k.coa, k.remarks, k.isdeleted, k.posisidk, del.generalcode as statdata, t.generalcode as statdk from coa k left join sys_generalcode t on t.idgeneral=k.posisidk and t.gctype='POSISIDK' left join sys_generalcode del on del.idgeneral=k.isdeleted and del.gctype='DELETE' where k.coa<> '-1' order by k.coa asc", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        kosongkanIsian(tlpField)
        seCOA.Value = seCOA.Properties.MinValue
        luePosisi.EditValue = 0
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        statData = statusData.Baru
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select coa from coa where replace(coa,' ','')='" & seCOA.Value.ToString.Replace(" ", "") & "'", "exist")
            If sqls.getDataSet("exist") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                seCOA.Focus()
                Exit Sub
            End If
            sqls.DMLQuery("select coa from coa where replace(remarks,' ','')='" & teRemarks.Text.Replace(" ", "") & "'", "exist")
            If sqls.getDataSet("exist") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                seCOA.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Edit Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select coa from coa where replace(coa,' ','')='" & seCOA.Value.ToString.Replace(" ", "") & "' and idcoa<>'" & idData & "'", "exist")
            If sqls.getDataSet("exist") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                seCOA.Focus()
                Exit Sub
            End If
            sqls.DMLQuery("select coa from coa where replace(remarks,' ','')='" & teRemarks.Text.Replace(" ", "") & "' and idcoa<>'" & idData & "'", "exist")
            If sqls.getDataSet("exist") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                seCOA.Focus()
                Exit Sub
            End If
        End If
        'check remarks
        If statData = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select coa from coa where replace(remarks,' ','')='" & teRemarks.Text.Replace(" ", "") & "'", "exist")
            If sqls.getDataSet("exist") = 0 Then
                idData = GenerateGUID()
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                seCOA.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Edit Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select coa from coa where replace(remarks,' ','')='" & teRemarks.Text.Replace(" ", "") & "' and idcoa<>" & idData, "exist")
            If sqls.getDataSet("exist") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                seCOA.Focus()
                Exit Sub
            End If
        End If

        Dim tipecoa As String = ""
        If statData = statusData.Baru Or statData = statusData.Edit Then
            Dim sqls As New SQLs(dbstring)
            Dim strcoainduk As String = seCOA.Value
            If IsNumeric(strcoainduk.Chars(0)) = False Then
                strcoainduk = strcoainduk.Substring(0, 2)
            Else
                strcoainduk = strcoainduk.Chars(0)
            End If
            sqls.DMLQuery("select tipecoa from coa where coa='" & strcoainduk & "'", "existkatcoa")
            If sqls.getDataSet("existkatcoa") > 0 Then
                tipecoa = sqls.getDataSet("existkatcoa", 0, "tipecoa")
            End If
        End If

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If idData = "-1" Then
            field.AddRange(New String() {"idcoa", "idcompany", "tipecoa", "coa", "remarks", "posisidk", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, idcomp, tipecoa, seCOA.Value, teRemarks.Text, If(luePosisi.EditValue, CObj(DBNull.Value)), 0, userid, nowTime})
        Else
            field.AddRange(New String() {"idcoa", "tipecoa", "coa", "remarks", "posisidk", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, tipecoa, seCOA.Value, teRemarks.Text, If(luePosisi.EditValue, CObj(DBNull.Value)), userid, nowTime})
        End If
        If dtSQL.datasetSave("coa", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "coa")

            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim retval As Boolean = False
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"idcoa", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("coa", idData, field, value, False)
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"idcoa", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("coa", idData, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "coa")
        btnNew_Click(Me, Nothing)
    End Sub

    Private isdeleted As String = ""
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        If isExport = True Then Exit Sub
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            seCOA.Value = dcol("coa")
            teRemarks.Text = dcol("remarks")
            luePosisi.EditValue = dcol("posisidk")
            idData = dcol("idcoa")
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
            If dcol("coa") = "-1" Then
                btnSave.Enabled = False
                btnDelete.Enabled = False
            End If
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        checkFieldMaxLength(dbstring, tlpField, "coa")
        loadLOV()
        btnNew_Click(Me, Nothing)
    End Sub

    Private isExport As Boolean = False
    Private Sub btnExportFormat_Click(sender As Object, e As EventArgs) Handles btnExportFormat.Click
        isExport = True
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select k.idcoa, k.coa, k.remarks, k.isdeleted, k.posisidk, del.generalcode as statdata, t.generalcode as statdk from coa k left join sys_generalcode t on t.idgeneral=k.posisidk and t.gctype='POSISIDK' left join sys_generalcode del on del.idgeneral=k.isdeleted and del.gctype='DELETE' where 1=0", "data")
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
                    Dim coa As String = If(dr(0), "")
                    Dim remarks As String = If(dr(1), "")
                    Dim brgstat As String = If(dr(2), "")

                    If coa = "" Or remarks = "" Or (coa = "" And remarks = "") Then Exit Try
                    coa = coa.Replace(",", "")
                    coa = coa.Replace(".", "")
                    coa = coa.Replace("-", "")
                    coa = coa.Replace("_", "")
                    coa = coa.Replace("/", "")
                    coa = coa.Replace("\", "")
                    coa = coa.Replace("|", "")
                    If IsNumeric(coa) = False Then Exit Try

                    Dim idcoa As String = "0"

                    Dim sqls As New SQLs(dbstring)
                    If coa <> "" Then
                        sqls.DMLQuery("select * from coa where replace(coa,' ','')='" & coa.Replace(" ", "") & "'", "cekcoa")
                        If sqls.getDataSet("cekcoa") > 0 Then
                            idcoa = sqls.getDataSet("cekitem", 0, "idcoa")
                        End If
                    End If
                    If remarks <> "" Then
                        sqls.DMLQuery("select * from coa where replace(remarks,' ','')='" & remarks.Replace(" ", "") & "'", "cekremarks")
                        If sqls.getDataSet("cekremarks") > 0 Then
                            idcoa = sqls.getDataSet("cekremarks", 0, "idcoa")
                        End If
                    End If

                    If idcoa = "0" Then
                        sqls.CallSP("spGetCompany", "CompID")
                        Dim idcomp As String = sqls.getDataSet("CompID", 0, "value")

                        Dim tipecoa As String = ""
                        Dim strcoainduk As String = seCOA.Value
                        If IsNumeric(strcoainduk.Chars(0)) = False Then
                            strcoainduk = strcoainduk.Substring(0, 2)
                        Else
                            strcoainduk = strcoainduk.Chars(0)
                        End If
                        sqls.DMLQuery("select tipecoa from coa where coa='" & strcoainduk & "'", "existkatcoa")
                        If sqls.getDataSet("existkatcoa") > 0 Then
                            tipecoa = sqls.getDataSet("existkatcoa", 0, "tipecoa")
                        End If

                        idcoa = GenerateGUID()
                        Dim field1 As New List(Of String)
                        Dim value1 As New List(Of Object)
                        Dim dtsqls1 As New dtsetSQLS(dbstring)
                        field1.AddRange(New String() {"idcoa", "idcompany", "tipecoa", "coa", "remarks", "posisidk", "isdeleted", "createdby", "createddate"})
                        value1.AddRange(New Object() {idcoa, idcomp, tipecoa, coa, remarks, CObj(DBNull.Value), 0, userid, nowTime})

                        If dtsqls1.datasetSave("coa", idcoa, field1, value1, False) = True Then
                            cnt += 1
                        End If
                    End If
                Catch ex As Exception
                End Try
            Next
            If cnt > 0 Then
                dizMsgbox("COA Baru terimport sebanyak " & cnt, dizMsgboxStyle.Info)
            Else
                dizMsgbox("Tidak ada COA Baru yang diimport", dizMsgboxStyle.Info)
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

End Class