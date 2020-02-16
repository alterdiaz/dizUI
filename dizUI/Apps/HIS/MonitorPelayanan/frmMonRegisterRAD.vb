Public Class frmMonRegisterRAD
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

    Private dttbl As New DataTable
    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged
        Dim iscek As Boolean = False
        If deTanggal.EditValue Is Nothing Then
            iscek = True
        End If
        If iscek = True Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = ""
            Exit Sub
        End If

        'Dim loadScr As New frmLoading()
        'splashClosed = False
        'loadScr.Show(Me)
        'loadScr.BringToFront()
        'Application.DoEvents()
        'Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@tahun", "@bulan"})
        value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month})
        sqls.CallSP("spMonRegisterRAD", "monregrad", field, value)
        dttbl = New DataTable
        dttbl = sqls.dataTable("monregrad")

        'For i As Integer = 0 To gvData.RowCount - 1
        '    gvData.SetRowCellValue(i, GridColumn1, i + 1)
        'Next

        sqls.DMLQuery("select distinct im.itemmonitor from itemmonitor im where im.iddepartment in (select value from sys_appsetting where variable='IDRADDept')", "getim")
        For i As Integer = 0 To sqls.getDataSet("getim") - 1
            Dim dc As New DataColumn
            dc.AllowDBNull = False
            dc.ColumnName = sqls.getDataSet("getim", i, "itemmonitor").ToString.Replace(" ", "")
            dc.Caption = sqls.getDataSet("getim", i, "itemmonitor").ToString
            dc.DefaultValue = 0
            dttbl.Columns.Add(dc)
        Next

        For i As Integer = 0 To dttbl.Rows.Count - 1
            Dim dr As DataRow = dttbl.Rows(i)
            Dim sqls1 As New SQLs(dbstring)
            sqls1.DMLQuery("select replace(im.itemmonitor,' ','') as itemmonitor,count(dt.iditem) as counter from transaksidt dt left join transaksi t on dt.idtransaksi=t.idtransaksi left join item i on dt.iditem=i.iditem left join itemmonitor im on im.iditem=i.iditem where dt.isdeleted=0 and t.idtransaksireff='" & dr("idregistrasi") & "' and im.iddepartment in (select value from sys_appsetting where variable='IDRADDept') group by im.itemmonitor", "getimdt")
            For a As Integer = 0 To sqls1.getDataSet("getimdt") - 1
                dr(sqls1.getDataSet("getimdt", a, "itemmonitor")) = sqls1.getDataSet("getimdt", a, "counter")
            Next
        Next

        gcData.DataSource = dttbl
        GridColumn18.GroupIndex = 1
        gvData.ExpandAllGroups()
        gvData.BestFitColumns()
        gvData.ViewCaption = "Register RAD - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year

        'Me.Cursor = Cursors.Default
        'splashClosed = True
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select distinct im.itemmonitor from itemmonitor im where im.iddepartment in (select value from sys_appsetting where variable='IDRADDept') order by itemmonitor asc", "getim")

        For i As Integer = 0 To sqls.getDataSet("getim") - 1
            Dim gcim As New DevExpress.XtraGrid.Columns.GridColumn
            gcim.AppearanceHeader.Options.UseTextOptions = True
            gcim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            gcim.Width = 100
            gcim.MaxWidth = 100
            gcim.MinWidth = 100
            gcim.Caption = sqls.getDataSet("getim", i, "itemmonitor").ToString
            gcim.ColumnEdit = Me.RepositoryItemSpinEdit1
            gcim.FieldName = sqls.getDataSet("getim", i, "itemmonitor").ToString.Replace(" ", "")
            gcim.Name = "gcHarga" & (i + 1)
            gcim.Tag = sqls.getDataSet("getim", i, "itemmonitor").ToString.Replace(" ", "")
            gcim.Visible = True
            gcim.VisibleIndex = 30 + i
            gcim.OptionsColumn.AllowEdit = False
            gcim.OptionsColumn.ReadOnly = True

            gvData.Columns.Add(gcim)
        Next
        deTanggal.EditValue = Nothing
        gvData.ViewCaption = ""
    End Sub

    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        deTanggal_EditValueChanged(deTanggal, Nothing)
    End Sub

    Private Sub btnItemMonitor_Click(sender As Object, e As EventArgs) Handles btnItemMonitor.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select value from sys_appsetting where variable='IDRADDept'", "getdept")
        Dim iddept As String = ""
        If sqls.getDataSet("getdept") > 0 Then
            iddept = sqls.getDataSet("getdept", 0, "value")
        End If

        formTitle = "Item Monitor / Grup"
        Dim frmMon As New frmItemMonitor(iddept)
        tambahChild(frmMon)
        frmMon.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmMon.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Enabled = False
        frmMon.pMaximize.Enabled = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub gvData_KeyDown(sender As Object, e As KeyEventArgs) Handles gvData.KeyDown
        If gvData.FocusedRowHandle < 0 Then Exit Sub
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gvData
        If e.Control AndAlso e.KeyCode = Keys.C Then
            If view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn) IsNot Nothing AndAlso view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString() <> [String].Empty Then
                Clipboard.SetText(view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString())
            End If
            e.Handled = True
        End If
    End Sub

End Class