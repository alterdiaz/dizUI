Public Class frmNotifbox

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
        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idnotifications", "duedate"})
        value.AddRange(New Object() {tbid, nowTime.AddMinutes(30)})
        dtsqls.datasetSave("sys_notifications", tbid, field, value, False)
        idnotif.RemoveAll(Function(val As String)
                              Return val = tbid
                          End Function)
        Me.Dispose()
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
            Return Me.tbid
        End Get
    End Property
    Private Sub enableMMX(bmin As Boolean, bmax As Boolean, bexit As Boolean)
        btnMinimize.Visible = bmin
        btnMaximize.Visible = bmax
        btnExit.Visible = bexit

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

    Public Sub New(NotifID As String, TitleStr As String, ContentStr As String, ContentType As MsgType, tableid As String, tablename As String, tablecolumnid As String, tablecolumndate As String, tablecolumnflag As String, tablecolumniduser As String, formcolor As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.notifid = NotifID
        Me.titStr = TitleStr
        Me.conStr = ContentStr
        Me.conType = ContentType
        Me.tbid = tableid
        Me.tbname = tablename
        Me.tbcolid = tablecolumnid
        Me.tbcoldate = tablecolumndate
        Me.tbcolflag = tablecolumnflag
        Me.tbcoliduser = tablecolumniduser
        Dim r, g, b As Integer
        b = formcolor / 65536
        g = (formcolor - (b * 65536)) / 256
        r = (formcolor - (b * 65536)) - (g * 256)
        If r > 255 Then r = 255
        If r < 0 Then r = 0
        If g > 255 Then g = 255
        If g < 0 Then g = 0
        If b > 255 Then b = 255
        If b < 0 Then b = 0

        Me.formColor = Color.FromArgb(255, r, g, b)
        'MsgBox(Me.formColor.R & "," & Me.formColor.G & "," & Me.formColor.B)
    End Sub

    Private notifid As String = "0"
    Private conType As MsgType
    Private conStr As String
    Private titStr As String
    Private tbid As String = "-"
    Private tbname As String = "-"
    Private tbcolid As String = "-"

    Private tbcoldate As String = "-"
    Private tbcolflag As String = "-"
    Private tbcoliduser As String = "-"

    Private formColor As Color = Color.FromArgb(128, 0, 255)
    Private queryOK As String = ""

    Private Sub generateQuery()
        If tbcolflag = "-" And tbcoldate <> "-" And tbcoliduser <> "-" Then
            queryOK = "update " & tbname & " set " & tbcoldate & "=getdate()," & tbcoliduser & "='" & userid & "' where " & tbcolid & "='" & tbid & "'"
        ElseIf tbcolflag <> "-" And tbcoldate = "-" And tbcoliduser <> "-" Then
            queryOK = "update " & tbname & " set " & tbcolflag & "=1," & tbcoliduser & "='" & userid & "' where " & tbcolid & "='" & tbid & "'"
        ElseIf tbcolflag <> "-" And tbcoldate <> "-" And tbcoliduser = "-" Then
            queryOK = "update " & tbname & " set " & tbcoldate & "=getdate()," & tbcolflag & "=1 where " & tbcolid & "='" & tbid & "'"
        End If
    End Sub

    Private Sub frmMessageBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        generateQuery()
        'Me.BackColor = Me.formColor
        tlpForm.BackColor = Me.formColor
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
        'MsgBox(queryOK)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(queryOK, False)
        sqls.DMLQuery("update sys_notifications set konfirmdate=getdate(),konfirmby='" & userid & "',iskonfirm=1 where idnotifications='" & notifid & "'", "cekdata")
        tmrWaktu.Stop()
        Me.Dispose()
    End Sub

    Private Sub tmrWaktu_Tick(sender As Object, e As EventArgs) Handles tmrWaktu.Tick
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idnotifications from sys_notifications where idnotifications='" & tbid & "' and iskonfirm=1", "cekdata")
        If sqls.getDataSet("cekdata") > 0 Then
            Me.Dispose()
        End If
    End Sub

End Class