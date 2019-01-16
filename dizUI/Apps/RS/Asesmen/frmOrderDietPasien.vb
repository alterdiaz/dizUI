Public Class frmOrderDietPasien
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

    Private statData As statusData = statusData.Baru
    Private statDataChild As statusData = statusData.Baru
    Private idData As String = "-1"
    Private idDataChild As String = "-1"

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)

        sqls.DMLQuery("select iddietmenu,dietmenu from dietmenu dm where diettype=1", "dm")
        clbcDiet.DataSource = sqls.dataTable("dm")
        clbcDiet.ValueMember = "iddietmenu"
        clbcDiet.DisplayMember = "dietmenu"

        sqls.DMLQuery("select iddietmenu,dietmenu from dietmenu dm where diettype=2", "jm")
        clbcMakanan.DataSource = sqls.dataTable("jm")
        clbcMakanan.ValueMember = "iddietmenu"
        clbcMakanan.DisplayMember = "dietmenu"

        sqls.DMLQuery("select iddietmenu,dietmenu from dietmenu dm where diettype=3", "jb")
        clbcBuah.DataSource = sqls.dataTable("jb")
        clbcBuah.ValueMember = "iddietmenu"
        clbcBuah.DisplayMember = "dietmenu"

        sqls.DMLQuery("select iddietmenu,dietmenu from dietmenu dm where diettype=4", "ja")
        clbcAlergi.DataSource = sqls.dataTable("ja")
        clbcAlergi.ValueMember = "iddietmenu"
        clbcAlergi.DisplayMember = "dietmenu"

        sqls.DMLQuery("select iddietmenu,dietmenu from dietmenu dm where diettype=5", "tm")
        clbcTidakMakan.DataSource = sqls.dataTable("tm")
        clbcTidakMakan.ValueMember = "iddietmenu"
        clbcTidakMakan.DisplayMember = "dietmenu"
    End Sub

    Private Sub frmOrderDietPasien_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
    End Sub

    Private Sub btnDietMenu_Click(sender As Object, e As EventArgs) Handles btnDietMenu.Click
        formTitle = "Diet Menu"
        Dim frmMon As New frmDietMenu
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

End Class