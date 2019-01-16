Imports DevExpress.XtraGrid.Views.Base

Public Class frmMonKasbon
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

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqli As New SQLi(dblite)
        If slueAtasan.EditValue IsNot Nothing And slueNama.EditValue Is Nothing And lueJenis.EditValue Is Nothing Then
            sqli.DMLQuery("select k.idkasbon,k.nominal,m.generalcode as lunas,t.generalcode as typekasbon,k.createddate,k.nama,k.isdeleted from kasbon k left join karyawan w on w.idkaryawan=k.idpelanggan left join generalcode t on k.jeniskasbon=t.idgeneral and t.gctype='JENISKASBON' left join generalcode m on k.islunas=m.idgeneral and m.gctype='ISPPN' where k.isdeleted=0 and w.idatasan=" & slueAtasan.EditValue & " order by k.createddate desc", "data")
        ElseIf slueAtasan.EditValue IsNot Nothing And slueNama.EditValue IsNot Nothing And lueJenis.EditValue Is Nothing Then
            sqli.DMLQuery("select k.idkasbon,k.nominal,m.generalcode as lunas,t.generalcode as typekasbon,k.createddate,k.nama,k.isdeleted from kasbon k left join karyawan w on w.idkaryawan=k.idpelanggan left join generalcode t on k.jeniskasbon=t.idgeneral and t.gctype='JENISKASBON' left join generalcode m on k.islunas=m.idgeneral and m.gctype='ISPPN' where k.isdeleted=0 and w.idatasan=" & slueAtasan.EditValue & " and k.idpelanggan=" & slueNama.EditValue & " order by k.createddate desc", "data")
        ElseIf slueAtasan.EditValue IsNot Nothing And slueNama.EditValue IsNot Nothing And lueJenis.EditValue IsNot Nothing Then
            If lueJenis.EditValue = 0 Then
                sqli.DMLQuery("select k.idkasbon,k.nominal,m.generalcode as lunas,t.generalcode as typekasbon,k.createddate,k.nama,k.isdeleted from kasbon k left join karyawan w on w.idkaryawan=k.idpelanggan left join generalcode t on k.jeniskasbon=t.idgeneral and t.gctype='JENISKASBON' left join generalcode m on k.islunas=m.idgeneral and m.gctype='ISPPN' where k.isdeleted=0 and w.idatasan=" & slueAtasan.EditValue & " and k.idpelanggan=" & slueNama.EditValue & " order by k.createddate desc", "data")
            ElseIf lueJenis.EditValue = 1 Then
                sqli.DMLQuery("select k.idkasbon,k.nominal,m.generalcode as lunas,t.generalcode as typekasbon,k.createddate,k.nama,k.isdeleted from kasbon k left join karyawan w on w.idkaryawan=k.idpelanggan left join generalcode t on k.jeniskasbon=t.idgeneral and t.gctype='JENISKASBON' left join generalcode m on k.islunas=m.idgeneral and m.gctype='ISPPN' where k.isdeleted=0 and w.idatasan=" & slueAtasan.EditValue & " and k.islunas=0 and k.idpelanggan=" & slueNama.EditValue & " order by k.createddate desc", "data")
            ElseIf lueJenis.EditValue = 2 Then
                sqli.DMLQuery("select k.idkasbon,k.nominal,m.generalcode as lunas,t.generalcode as typekasbon,k.createddate,k.nama,k.isdeleted from kasbon k left join karyawan w on w.idkaryawan=k.idpelanggan left join generalcode t on k.jeniskasbon=t.idgeneral and t.gctype='JENISKASBON' left join generalcode m on k.islunas=m.idgeneral and m.gctype='ISPPN' where k.isdeleted=0 and w.idatasan=" & slueAtasan.EditValue & " and k.islunas=1 and k.idpelanggan=" & slueNama.EditValue & " order by k.createddate desc", "data")
            End If
        ElseIf slueAtasan.EditValue IsNot Nothing And slueNama.EditValue Is Nothing And lueJenis.EditValue IsNot Nothing Then
            If lueJenis.EditValue = 0 Then
                sqli.DMLQuery("select k.idkasbon,k.nominal,m.generalcode as lunas,t.generalcode as typekasbon,k.createddate,k.nama,k.isdeleted from kasbon k left join karyawan w on w.idkaryawan=k.idpelanggan left join generalcode t on k.jeniskasbon=t.idgeneral and t.gctype='JENISKASBON' left join generalcode m on k.islunas=m.idgeneral and m.gctype='ISPPN' where k.isdeleted=0 and w.idatasan=" & slueAtasan.EditValue & " order by k.createddate desc", "data")
            ElseIf lueJenis.EditValue = 1 Then
                sqli.DMLQuery("select k.idkasbon,k.nominal,m.generalcode as lunas,t.generalcode as typekasbon,k.createddate,k.nama,k.isdeleted from kasbon k left join karyawan w on w.idkaryawan=k.idpelanggan left join generalcode t on k.jeniskasbon=t.idgeneral and t.gctype='JENISKASBON' left join generalcode m on k.islunas=m.idgeneral and m.gctype='ISPPN' where k.isdeleted=0 and w.idatasan=" & slueAtasan.EditValue & " and k.islunas=0 order by k.createddate desc", "data")
            ElseIf lueJenis.EditValue = 2 Then
                sqli.DMLQuery("select k.idkasbon,k.nominal,m.generalcode as lunas,t.generalcode as typekasbon,k.createddate,k.nama,k.isdeleted from kasbon k left join karyawan w on w.idkaryawan=k.idpelanggan left join generalcode t on k.jeniskasbon=t.idgeneral and t.gctype='JENISKASBON' left join generalcode m on k.islunas=m.idgeneral and m.gctype='ISPPN' where k.isdeleted=0 and w.idatasan=" & slueAtasan.EditValue & " and k.islunas=1 order by k.createddate desc", "data")
            End If
        End If
        gcData.DataSource = sqli.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadLOV()
        Dim sqli As New SQLi(dblite)
        sqli.DMLQuery("select idgeneral as id,generalcode as content from generalcode where gctype='JENISMONKASBON'", "jenis")
        lueJenis.Properties.DataSource = sqli.dataTable("jenis")
        lueJenis.Properties.ValueMember = "id"
        lueJenis.Properties.DisplayMember = "content"
        lueJenis.EditValue = Nothing

        sqli.DMLQuery("select idkaryawan as id,nama as content from karyawan where isdeleted=0 and isatasan=1", "atasan")
        slueAtasan.Properties.DataSource = sqli.dataTable("atasan")
        slueAtasan.Properties.ValueMember = "id"
        slueAtasan.Properties.DisplayMember = "content"
        slueAtasan.EditValue = Nothing

        sqli.DMLQuery("select idkaryawan as id,nama as content from karyawan where isdeleted=0 and 1=0", "karyawan")
        slueNama.Properties.DataSource = sqli.dataTable("karyawan")
        slueNama.Properties.ValueMember = "id"
        slueNama.Properties.DisplayMember = "content"
        slueNama.EditValue = Nothing
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadGrid()
    End Sub

    Private Sub frmMonKasbon_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadLOV()
    End Sub

    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        Dim kary As New frmKaryawan()
        kary.ShowDialog(Me)

        loadLOV()
    End Sub

    Private Sub slueAtasan_EditValueChanged(sender As Object, e As EventArgs) Handles slueAtasan.EditValueChanged
        If slueAtasan.EditValue Is Nothing Then
            slueNama.Properties.DataSource = Nothing
            slueNama.Properties.ValueMember = "id"
            slueNama.Properties.DisplayMember = "content"
            slueNama.EditValue = Nothing
        Else
            Dim sqli As New SQLi(dblite)
            sqli.DMLQuery("select idkaryawan as id,nama as content from karyawan where isdeleted=0 and idatasan=" & slueAtasan.EditValue, "karyawan")
            slueNama.Properties.DataSource = sqli.dataTable("karyawan")
            slueNama.Properties.ValueMember = "id"
            slueNama.Properties.DisplayMember = "content"
            slueNama.EditValue = Nothing
        End If
    End Sub

    Private Sub btnClearAtasan_Click(sender As Object, e As EventArgs) Handles btnClearAtasan.Click
        slueAtasan.EditValue = Nothing
    End Sub

    Private Sub btnClearNama_Click(sender As Object, e As EventArgs) Handles btnClearNama.Click
        slueNama.EditValue = Nothing
    End Sub

    Private Sub btnClearJenis_Click(sender As Object, e As EventArgs) Handles btnClearJenis.Click
        lueJenis.EditValue = Nothing
    End Sub

End Class