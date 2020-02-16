Public Class frmSeminarNonMedis
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

    Private Sub lnkTanggalAkhir_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkTanggalAkhir.LinkClicked
        deTanggalAkhir.EditValue = Nothing
    End Sub

    Private iddata As String = "-1"
    Private statdata As statusData = statusData.Baru
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        teJudul.EditValue = Nothing
        tePenyelenggara.EditValue = Nothing
        teTempat.EditValue = Nothing
        deTanggalAwal.EditValue = Nothing
        deTanggalAkhir.EditValue = Nothing
        teNoSertifikat.EditValue = Nothing
        nudPemateri.EditValue = 0
        nudPanitia.EditValue = 0
        nudPeserta.EditValue = 0
        teRemarks.EditValue = Nothing
        statdata = statusData.Baru
        iddata = "-1"
        loadGrid()
    End Sub

    Private Sub loadGrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select l.idpelatihan,l.idreff,s.nama,l.istrainer,it.generalcode as trainer,l.remarks from pelatihan l left join staff s on l.idreff=s.idstaff and l.tablereff='KARYAWAN' left join sys_generalcode it on l.istrainer=it.idgeneral and it.gctype='ISTRAINER' where 1=0", "data")
        gcData.DataSource = sqls.dataTable("data")
    End Sub

    Private Sub loadGrid(id As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select l.idpelatihan,l.idreff,s.nama,l.istrainer,it.generalcode as trainer,l.remarks from pelatihan l left join staff s on l.idreff=s.idstaff and l.tablereff='KARYAWAN' left join sys_generalcode it on l.istrainer=it.idgeneral and it.gctype='ISTRAINER' where l.idseminar='" & id & "' order by s.nama asc", "data")
        gcData.DataSource = sqls.dataTable("data")
    End Sub

    Private Sub btnBaruDT_Click(sender As Object, e As EventArgs) Handles btnBaruDT.Click
        formTitle = "Tambah Peserta"
        Dim frmMon As New frmSeminarNonMedisTambah
        tambahChild(frmMon)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text

        If frmMon.idstaff <> "" Then
            Dim tmpidstaff As String = frmMon.idstaff
            If gvData.RowCount > 0 Then
                Dim retval As Boolean = True
                For i As Integer = 0 To gvData.RowCount - 1
                    Dim dr As DataRow = gvData.GetDataRow(i)
                    Dim curidstaff As String = dr("idreff")
                    If tmpidstaff = curidstaff Then
                        retval = False
                        Exit For
                    End If
                Next
                If retval = False Then
                    dizMsgbox("Karyawan tersebut sudah ada", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If
            End If
            Dim tmpistrainer As Long = frmMon.istrainer
            Dim tmpremarks As String = frmMon.remarks
        End If
    End Sub

End Class