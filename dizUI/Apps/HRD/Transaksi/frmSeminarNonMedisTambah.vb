Public Class frmSeminarNonMedisTambah
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

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISTRAINER' order by generalcode asc", "it")
        lueTrainer.Properties.DataSource = sqls.dataTable("it")
        lueTrainer.Properties.ValueMember = "id"
        lueTrainer.Properties.DisplayMember = "content"
        lueTrainer.EditValue = Nothing

        sqls.DMLQuery("select idstaff as id,nama as content from staff order by nama asc", "st")
        lueStaff.Properties.DataSource = sqls.dataTable("st")
        lueStaff.Properties.ValueMember = "id"
        lueStaff.Properties.DisplayMember = "content"
        lueStaff.EditValue = Nothing
    End Sub

    Private Sub baru()
        loadLOV()

        lueStaff.EditValue = Nothing
        lueTrainer.EditValue = Nothing
        teRemarks.EditValue = Nothing
    End Sub

    Private Sub frmSeminarNonMedisTambah_Load(sender As Object, e As EventArgs) Handles Me.Load
        baru()
    End Sub

    Private Function cekIsian() As Boolean
        Dim retval As Boolean = True
        If lueStaff.EditValue Is Nothing Then retval = False
        If lueTrainer.EditValue Is Nothing Then retval = False
        Return retval
    End Function
    Private Sub btnSaveDT_Click(sender As Object, e As EventArgs) Handles btnSaveDT.Click
        If cekIsian() = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        _idstaff = lueStaff.EditValue
        _idtrainer = lueTrainer.EditValue
        _remarks = teRemarks.EditValue

        Me.Close()
    End Sub

    Private _idstaff As String = ""
    Private _idtrainer As Long = 0
    Private _remarks As String = ""
    Public Property idstaff() As String
        Get
            Return _idstaff
        End Get
        Set(value As String)
            _idstaff = value
        End Set
    End Property

    Public Property istrainer() As Long
        Get
            Return _idtrainer
        End Get
        Set(value As Long)
            _idtrainer = value
        End Set
    End Property

    Public Property remarks() As String
        Get
            Return _remarks
        End Get
        Set(value As String)
            _remarks = value
        End Set
    End Property

End Class