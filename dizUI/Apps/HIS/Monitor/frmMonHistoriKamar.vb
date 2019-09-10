Public Class frmMonHistoriKamar
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1
    Private idreg As String = "-1"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        idreg = id
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

    Private Sub frmMonHistoriKamar_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sqls As New SQLs(dbstring)
        If idreg = "-1" Then
            teNama.EditValue = Nothing
            teNoRegistrasi.EditValue = Nothing
            teNoRM.EditValue = Nothing
        Else
            sqls.DMLQuery("select r.registrasino,convert(bigint,rm.rekammedisno) as rekammedisno,rm.nama,r.idlokasi from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis where r.idregistrasi='" & idreg & "'", "data")
            teNama.Text = sqls.getDataSet("data", 0, "nama")
            teNoRegistrasi.Text = sqls.getDataSet("data", 0, "registrasino")
            teNoRM.Text = Format(CLng(sqls.getDataSet("data", 0, "rekammedisno")), "0#######")
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@vardept"})
        value.AddRange(New Object() {"idirnadept"})
        sqls.CallSP("spMonKamarAktif", "data", field, value)

        Dim cari As New frmSearch(sqls.dataSet, "data", "id")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idreg = cari.GetIDSelectData
            frmMonHistoriKamar_Load(Me, Nothing)
            loadGrid(idreg)
        End If
    End Sub

    Private Sub loadGrid(id As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select 0 as nomor,rkm.idregistrasikamar as id,k.kelas,l.nama as content,convert(varchar,rkm.checkin,105)+' '+convert(varchar,rkm.checkin,108) as checkin,isnull(convert(varchar,rkm.checkout,105)+' '+convert(varchar,rkm.checkout,108),'Masih Digunakan') as checkout,cb.username as createdby,isnull(ub.username,'-') as updatedby from registrasikamar rkm left join lokasi l on rkm.idlokasi=l.idlokasi left join kelaskamar kk on kk.idlokasi=rkm.idlokasi left join kelas k on k.idkelas=kk.idkelas left join sys_user cb on cb.iduser=rkm.createdby left join sys_user ub on ub.iduser=rkm.updatedby where rkm.idregistrasi='" & id & "' order by rkm.checkin desc", "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.ViewCaption = "Riwayat Kamar - " & teNama.Text & " (" & teNoRM.Text & ")"
        For i As Integer = 0 To gvData.RowCount - 1
            gvData.SetRowCellValue(i, GridColumn1, i + 1)
        Next
        gvData.BestFitColumns()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If idreg <> "-1" Then
            loadGrid(idreg)
        Else
            dizMsgbox("Registrasi belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
    End Sub

End Class