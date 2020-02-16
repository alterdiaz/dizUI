Imports DevExpress.XtraGrid.Views.Base
Public Class frmMonPasien
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

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        teSearch.EditValue = ""
        teSearch.Focus()
    End Sub

    Private Sub teSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSearch_Click(btnSearch, Nothing)
            btnApply_Click(btnApply, Nothing)

            teSearch.Focus()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If teSearch.EditValue Is Nothing Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = ""
            Exit Sub
        End If
        If teSearch.EditValue = "" Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = ""
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@search"})
        value.AddRange(New Object() {teSearch.Text})
        sqls.CallSP("spMonDataPasien", "monpx", field, value)
        gcData.DataSource = sqls.dataTable("monpx")
        gvData.BestFitColumns()
        gvData.ViewCaption = "Pencarian Data Pasien"

        Threading.Thread.Sleep(100)
        Me.Cursor = Cursors.Default
        splashClosed = True

        teSearch.Focus()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gcData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub gvData_KeyDown(sender As Object, e As KeyEventArgs) Handles gvData.KeyDown
        'If gvData.FocusedRowHandle < 0 Then Exit Sub
        'Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gvData
        'If e.Control AndAlso e.KeyCode = Keys.C Then
        '    If view.GetSelectedCells(view.FocusedRowHandle) IsNot Nothing AndAlso view.GetSelectedCells(view.FocusedRowHandle).ToString() <> [String].Empty Then
        '        For i As Integer = 0 To view.GetSelectedRows.Count - 1

        '        Next
        '    End If
        '    'If view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn) IsNot Nothing AndAlso view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString() <> [String].Empty Then
        '    '        Clipboard.SetText(view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString())
        '    '    End If
        '    e.Handled = True
        'End If
    End Sub

    Private Sub btnAllData_Click(sender As Object, e As EventArgs) Handles btnAllData.Click
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@search"})
        value.AddRange(New Object() {""})
        sqls.CallSP("spMonDataPasien", "monpx", field, value)
        gcData.DataSource = sqls.dataTable("monpx")
        gvData.BestFitColumns()
        gvData.ViewCaption = "Pencarian Data Pasien"

        Threading.Thread.Sleep(100)
        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        formTitle = "Format Grid"
        Dim frmMon As New frmFormatGrid
        frmMon.frmName = Me.Name
        frmMon.gridName = gvData.Name
        frmMon.gridView = gvData
        tambahChild(frmMon)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Visible = False
        frmMon.pMaximize.Visible = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private idtype As Long = 0
    Private _ipclient As String = ""
    Private _frmname As String = ""
    Private _gridname As String = ""
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If gcData.ViewCollection(0).RowCount > 300 Then
            dizMsgbox("Data lebih dari 300 data", dizMsgboxStyle.Info, "Peringatan", Me)
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        _ipclient = getIPAddress(ipaddparam.IP)
        _frmname = Me.Name
        _gridname = gcData.Views(0).Name
        Dim gvbaru As DevExpress.XtraGrid.Views.Grid.GridView = applyFormatGrid(_ipclient, _frmname, _gridname, gcData.Views(0))
        Me.gcData.ViewCollection.RemoveAt(0)
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {gvbaru})

        Threading.Thread.Sleep(100)
        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btn300Data_Click(sender As Object, e As EventArgs) Handles btn300Data.Click
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@limit"})
        value.AddRange(New Object() {300})
        sqls.CallSP("spMonDataPasienLimit", "monpx", field, value)
        gcData.DataSource = sqls.dataTable("monpx")
        gvData.BestFitColumns()
        gvData.ViewCaption = "Pencarian Data Pasien"

        Threading.Thread.Sleep(100)
        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

End Class