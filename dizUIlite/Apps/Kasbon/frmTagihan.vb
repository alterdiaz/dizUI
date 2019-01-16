Imports DevExpress.XtraGrid.Views.Base

Public Class frmTagihan
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
        sqli.DMLQuery("select substr(k.transaksidate,0,11) as transaksidate,t.generalcode as typekasbon,k.nama,sum(k.nominal) as nominal from kasbon k left join karyawan w on k.idpelanggan=w.idkaryawan left join generalcode t on k.jeniskasbon=t.idgeneral and t.gctype='JENISKASBON' where substr(k.transaksidate,0,11)<>'" & Format(nowTime, "dd-MM-yyyy") & "' and (w.idkaryawan=" & slueAtasan.EditValue & " or w.idatasan=" & slueAtasan.EditValue & ") and k.isdeleted=0 and k.islunas=0 group by substr(k.transaksidate,0,11),jeniskasbon,k.nama order by k.nama asc,k.transaksidate desc", "data")
        gcData.DataSource = sqli.dataTable("data")
        gvData.BestFitColumns()
        If gvData.RowCount > 0 Then
            gvData.ViewCaption = "Tagihan - " & slueAtasan.Text & " (" & Format(nowTime, "dd-MM-yyyy") & ")"
        Else
            gvData.ViewCaption = "-"
        End If

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadlov()
        Dim sqli As New SQLi(dblite)
        sqli.DMLQuery("select idkaryawan as id,nama as content from karyawan where isdeleted=0 and isatasan=1", "atasan")
        slueAtasan.Properties.DataSource = SQLi.dataTable("atasan")
        slueAtasan.Properties.ValueMember = "id"
        slueAtasan.Properties.DisplayMember = "content"
        slueAtasan.EditValue = Nothing
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If slueAtasan.EditValue Is Nothing Then
            dizMsgbox("Nama Atasan belum diisi", dizMsgboxStyle.Peringatan, Me)
        Else
            loadGrid()
        End If
    End Sub

    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        Dim kary As New frmKaryawan()
        kary.ShowDialog(Me)

        loadlov()
    End Sub

    Private Sub btnLunas_Click(sender As Object, e As EventArgs) Handles btnLunas.Click
        If gvData.RowCount > 0 Then
            Dim sqli As New SQLi(dblite)
            sqli.DMLQuery("select k.idkasbon from kasbon k left join karyawan w on k.idpelanggan=w.idkaryawan where substr(k.transaksidate,0,11)<>'" & Format(nowTime, "dd-MM-yyyy") & "' and (w.idkaryawan=" & slueAtasan.EditValue & " or w.idatasan=" & slueAtasan.EditValue & ") and k.isdeleted=0 and k.islunas=0 order by k.idkasbon asc", "getdata")
            For i As Integer = 0 To sqli.getDataSet("getdata") - 1
                sqli.DMLQuery("update kasbon set islunas=1 where idkasbon=" & sqli.getDataSet("getdata", i, "idkasbon"), False)
            Next

            Dim total As Long = CLng(GridColumn5.SummaryText.Replace(",00", "").Replace(".", ""))
            Dim dtlite As New dtsetSQLI(dblite)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idlunas", "lunasno", "lunasdate", "nominal"})
            value.AddRange(New Object() {-1, Format(nowTime, "ddMMyyyyHHmmss"), Format(nowTime, "dd-MM-yyyy HH:mm:ss"), total})
            dtlite.datasetSave("lunas", -1, field, value, False)

            dizMsgbox("Tagihan sudah dilunasi", dizMsgboxStyle.Peringatan, Me)
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub frmTagihan_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadlov()
    End Sub

End Class