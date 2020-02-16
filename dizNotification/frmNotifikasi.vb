Public Class frmNotifikasi

    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)

        If Me.WindowState = FormWindowState.Normal Then
            Me.Location = pnt
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Visible = False
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        isfocus = False
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private pnt As Point
    Private Sub frmNotifikasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - 433, 0)
        Me.Size = New Size(433, Screen.PrimaryScreen.WorkingArea.Height)
        pnt = New Point(Screen.PrimaryScreen.WorkingArea.Width - 433, 0)
        Me.BringToFront()
        Me.Activate()
        isfocus = True
    End Sub

    Private Sub tmrCek_Tick(sender As Object, e As EventArgs) Handles tmrCek.Tick
        If isfocus = True Then
            Me.BringToFront()
            Me.Activate()
        End If
    End Sub

End Class