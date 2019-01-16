Public Class frmInfoboxRegPrepare

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
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose() 'Environment.Exit(0)
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public ReadOnly Property getid() As String
        Get
            Return Me.id
        End Get
    End Property
    Private Sub enableMMX(bmin As Boolean, bmax As Boolean, bexit As Boolean)
        btnMinimize.Enabled = bmin
        btnMaximize.Enabled = bmax
        btnExit.Enabled = bexit
    End Sub

    Public Enum MsgType
        CriticalIcon
        InfoIcon
        WarningIcon
        QuestionIcon
    End Enum

    Public Sub New(TitleStr As String, ContentStr As String, ContentType As MsgType, id As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.titStr = TitleStr
        Me.conStr = ContentStr
        Me.conType = ContentType
        Me.id = id
    End Sub

    Private conType As MsgType
    Private conStr As String
    Private titStr As String
    Private id As String = -1
    Private Sub frmMessageBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        enableMMX(False, False, True)

        If conType = MsgType.CriticalIcon Then
            pbLogo.Image = My.Resources.ico_critical
        ElseIf conType = MsgType.InfoIcon Then
            pbLogo.Image = My.Resources.ico_info
        ElseIf conType = MsgType.QuestionIcon Then
            pbLogo.Image = My.Resources.ico_question
        ElseIf conType = MsgType.WarningIcon Then
            pbLogo.Image = My.Resources.ico_warning
        End If
        lblContent.Text = conStr
        lblTitle.Text = titStr
        Me.Text = titStr

        Dim pnt As New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Size.Width - 8, Screen.PrimaryScreen.WorkingArea.Height - Me.Size.Height - 8)
        Me.Location = pnt
        tmrWaktu.Start()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("update registrasi set prepareddate=getdate(),preparedby='" & userid & "' where idregistrasi='" & id & "'", False)
        Me.Dispose()
    End Sub

    Private cnt As Integer = 0
    Private Sub tmrWaktu_Tick(sender As Object, e As EventArgs) Handles tmrWaktu.Tick
        cnt += 3
        If cnt Mod 3 = 0 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idregistrasi from registrasi where idregistrasi='" & id & "' and preparedby is not null", "cekdata")
        If sqls.getDataSet("cekdata") > 0 Then
            Me.Dispose()
        End If
    End Sub

End Class