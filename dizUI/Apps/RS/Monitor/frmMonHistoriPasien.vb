Public Class frmMonHistoriPasien
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        idrm = -1
        Me.WindowState = FormWindowState.Maximized
    End Sub

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

    Private idrm As String = -1
    Public Sub New(idpasien As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        idrm = idpasien

        Me.WindowState = FormWindowState.Normal
        Me.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        Me.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub frmMonHistoriPasien_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        If idrm = "-1" Then
            btnSearch.Visible = True
            lblKaryawan.Visible = True
            teSearch.Visible = True
            pMinimize.Visible = True
            pMaximize.Visible = True
        Else
            btnSearch.Visible = False
            lblKaryawan.Visible = False
            teSearch.Visible = False
            pMinimize.Visible = False
            pMaximize.Visible = False
        End If
        If idrm <> "-1" Then
            btnSemua_Click(btn10, Nothing)
        End If
    End Sub

    Private Sub btnSemua_Click(sender As Object, e As EventArgs) Handles btn10.Click, btn25.Click, btn50.Click, btnSemua.Click
        btn10.BackColor = Color.FromArgb(192, 64, 0)
        btn25.BackColor = Color.FromArgb(0, 0, 64)
        btn50.BackColor = Color.FromArgb(192, 64, 0)
        btnSemua.BackColor = Color.FromArgb(0, 0, 64)

        CType(sender, Windows.Forms.Button).BackColor = Color.Gray
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@id"})
        value.AddRange(New Object() {idrm})
        If sender Is btn10 Then
            sqls.CallSP("spHistoriPasien10", "Histori", field, value)
            gvData.ViewCaption = "Riwayat Pasien - 10 Register Terakhir"
        ElseIf sender Is btn25 Then
            sqls.CallSP("spHistoriPasien25", "Histori", field, value)
            gvData.ViewCaption = "Riwayat Pasien - 25 Register Terakhir"
        ElseIf sender Is btn50 Then
            sqls.CallSP("spHistoriPasien50", "Histori", field, value)
            gvData.ViewCaption = "Riwayat Pasien - 50 Register Terakhir"
        ElseIf sender Is btnSemua Then
            sqls.CallSP("spHistoriPasienAll", "Histori", field, value)
            gvData.ViewCaption = "Riwayat Pasien - Semua Register"
        End If

        gcData.DataSource = sqls.dataTable("Histori")
        For i As Integer = 0 To gvData.RowCount - 1
            gvData.SetRowCellValue(i, GridColumn1, i + 1)
        Next
        gvData.BestFitColumns()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If teSearch.EditValue Is Nothing Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
        End If
        If teSearch.Text.Replace(" ", "") = "" Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
        End If
        Dim appPath As String = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If

        Dim strQuery As String = ""
        Dim tmparr() As String = IO.File.ReadAllLines(appPath & "SearchPasienLengkap.txt")
        For i As Integer = 0 To tmparr.Length - 1
            strQuery &= tmparr(i)
            If tmparr(i).Length > 0 Then
                If tmparr(i).Chars(tmparr(i).Length - 1) <> " " Then
                    strQuery &= " "
                End If
            End If
        Next
        Dim strfilter As String = ""
        strQuery &= " and r.rekammedisno<>0"
        If teSearch.Text <> "" Then
            strQuery &= " and r.nama like '%" & teSearch.Text & "%'"
        End If
        strQuery &= " order by r.rekammedisno desc"

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(strQuery, "searchpasien")

        Dim cari As New frmSearch(sqls.dataSet, "searchpasien", "ID")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idrm = cari.GetIDSelectData
            btnSemua_Click(btn10, Nothing)
        End If
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

    Private Sub teSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSearch_Click(btnSearch, Nothing)
        End If
    End Sub

End Class