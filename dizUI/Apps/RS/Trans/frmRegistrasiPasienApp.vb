Imports DevExpress.XtraTab

Public Class frmRegistrasiPasienApp
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

    Private Sub frmRegistrasiPasienApp_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        pAppointment.Controls.Clear()
        pPasien.Controls.Clear()
        pRegister.Controls.Clear()

        xtcAdmisi.SelectedTabPage = xtpAppointment
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs)
        If pAppointment.Controls.Count = 0 Then
            pAppointment.Controls.Clear()

            pAppointment.Visible = False
            formTitle = "Appointment"
            Dim frmapp As New frmAppointment
            frmapp.Location = New Point(0, 0)
            frmapp.Size = New Size(pPasien.Size.Width, pPasien.Size.Height)
            frmapp.StartPosition = FormStartPosition.CenterScreen
            frmapp.WindowState = FormWindowState.Maximized
            frmapp.pMinimize.Visible = False
            frmapp.pMaximize.Visible = False
            frmapp.pExit.Visible = False
            'frmapp.tlpForm.RowCount = 4
            'frmapp.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
            frmapp.TopLevel = False
            pAppointment.Controls.Add(frmapp)
            frmapp.Show()
            pAppointment.Visible = True

            formTitle = Me.lblTitle.Text
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs)
        If pRegister.Controls.Count = 0 Then
            pRegister.Controls.Clear()

            pRegister.Visible = False
            formTitle = "Registrasi Pasien"
            Dim frmapp As New frmRegistrasi
            frmapp.Location = New Point(0, 0)
            frmapp.Size = New Size(pPasien.Size.Width, pPasien.Size.Height)
            frmapp.StartPosition = FormStartPosition.CenterScreen
            frmapp.WindowState = FormWindowState.Maximized
            frmapp.pMinimize.Visible = False
            frmapp.pMaximize.Visible = False
            frmapp.pExit.Visible = False
            'frmapp.tlpForm.RowCount = 4
            'frmapp.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
            frmapp.TopLevel = False
            pRegister.Controls.Add(frmapp)
            frmapp.Show()
            pRegister.Visible = True

            formTitle = Me.lblTitle.Text
        End If
    End Sub

    Private Sub btnPasien_Click(sender As Object, e As EventArgs)
        If pPasien.Controls.Count = 0 Then
            pPasien.Controls.Clear()

            pPasien.Visible = False
            formTitle = "Pasien Baru"
            Dim frmapp As New frmPasienSimple
            frmapp.Location = New Point(0, 0)
            frmapp.Size = New Size(pPasien.Size.Width, pPasien.Size.Height)
            frmapp.StartPosition = FormStartPosition.CenterScreen
            frmapp.WindowState = FormWindowState.Maximized
            frmapp.pMinimize.Visible = False
            frmapp.pMaximize.Visible = False
            frmapp.pExit.Visible = False
            'frmapp.tlpForm.RowCount = 4
            'frmapp.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
            frmapp.TopLevel = False
            pPasien.Controls.Add(frmapp)
            frmapp.Show()
            pPasien.Visible = True

            formTitle = Me.lblTitle.Text
        End If
    End Sub

    Private Sub xtcAdmisi_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles xtcAdmisi.SelectedPageChanged
        If xtcAdmisi.SelectedTabPage Is xtpPasien Then
            btnPasien_Click(Me, Nothing)
        ElseIf xtcAdmisi.SelectedTabPage Is xtpregister Then
            btnRegister_Click(Me, Nothing)
        ElseIf xtcAdmisi.SelectedTabPage Is xtpAppointment Then
            btnAppointment_Click(Me, Nothing)
        End If
    End Sub

End Class