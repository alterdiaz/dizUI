
Public Class frmInfoPasien
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

    Public Sub New(idpasien As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@idrm"})
        value.AddRange(New Object() {idpasien})
        sqls.CallSP("spGetPasienRegistrasi", "getpx", field, value)

        teNoRM.Text = sqls.getDataSet("getpx", 0, "rekammedisno")
        teJenisKartu.Text = sqls.getDataSet("getpx", 0, "jeniskartu")
        teNomorKartu.Text = sqls.getDataSet("getpx", 0, "nomorkartu")
        teHamil.Text = sqls.getDataSet("getpx", 0, "hamil")
        teGolonganDarah.Text = sqls.getDataSet("getpx", 0, "golongandarah")
        teRhesus.Text = sqls.getDataSet("getpx", 0, "rhesus")

        teNamaPanggilan.Text = sqls.getDataSet("getpx", 0, "namapanggilan")
        teNama.Text = sqls.getDataSet("getpx", 0, "nama")
        teJenisKelamin.Text = sqls.getDataSet("getpx", 0, "jeniskelamin")
        teWarganegara.Text = sqls.getDataSet("getpx", 0, "warganegara")
        teTanggalLahir.Text = sqls.getDataSet("getpx", 0, "tanggallahir")
        teUmur.Text = sqls.getDataSet("getpx", 0, "usia")

        meAlamat.Text = sqls.getDataSet("getpx", 0, "alamat")

        sqls.DMLQuery("select count(r.idregistrasi) as counter,d.kode from registrasi r left join department d on r.iddepartment=d.iddepartment where r.iddepartment in (select value from sys_appsetting where variable in('idigddept','idicudept','idirnadept','idlabdept','idnicudept','idibsdept','IDIRJDept','idpicudept','idirmdept','idraddept')) and idrekammedis='" & idpasien & "' group by d.kode order by d.kode asc", "data")
        Dim str As String = ""
        If sqls.getDataSet("data") = 0 Then
            str = "Registrasi tidak ditemukan"
        Else
            str = "Jumlah Registrasi" & vbCrLf
            For i As Integer = 0 To sqls.getDataSet("data") - 1
                str &= sqls.getDataSet("data", i, "counter")
                str &= " "
                str &= sqls.getDataSet("data", i, "kode")
                If i <> sqls.getDataSet("data") - 1 Then
                    str &= ", "
                End If
            Next
        End If
        lblStatus.Text = str
    End Sub

    Private Sub frmInfoPasien_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.pMinimize.Enabled = False
        Me.pMaximize.Enabled = False
    End Sub

End Class