Imports DevExpress.XtraGrid.Views.Base

Public Class frmKasbon
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
        sqli.DMLQuery("select k.idkasbon,k.nominal,t.generalcode as typekasbon,k.createddate,k.nama,k.isdeleted from kasbon k left join generalcode t on k.jeniskasbon=t.idgeneral and t.gctype='JENISKASBON' where k.isdeleted=0 and k.islunas=0 and k.transaksidate like '" & Format(nowTime, "dd-MM-yyyy") & "%' order by k.createddate desc", "data")
        gcData.DataSource = sqli.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadLOV()
        Dim sqli As New SQLi(dblite)
        sqli.DMLQuery("select idgeneral as id,generalcode as content from generalcode where gctype='JENISKASBON'", "jenis")
        lueJenis.Properties.DataSource = sqli.dataTable("jenis")
        lueJenis.Properties.ValueMember = "id"
        lueJenis.Properties.DisplayMember = "content"
        lueJenis.EditValue = Nothing

        sqli.DMLQuery("select idkaryawan as id,nama as content from karyawan where isdeleted=0", "karyawan")
        slueNama.Properties.DataSource = sqli.dataTable("karyawan")
        slueNama.Properties.ValueMember = "id"
        slueNama.Properties.DisplayMember = "content"
        slueNama.EditValue = Nothing
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        loadLOV()
        lueJenis.EditValue = Nothing
        slueNama.EditValue = Nothing
        seNominal.EditValue = 0
        btnSave.Enabled = True
    End Sub

    Private iddata As Long = -1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If seNominal.EditValue = 0 Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If slueNama.EditValue Is Nothing Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim dtsqli As New dtsetSQLI(dblite)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
        field.AddRange(New String() {"idkasbon", "idpelanggan", "nominal", "nama", "createddate", "transaksidate", "jeniskasbon"})
        value.AddRange(New Object() {-1, slueNama.EditValue, seNominal.EditValue, slueNama.Text, Format(nowTime, "dd-MM-yyyy HH:mm:ss"), Format(nowTime, "dd-MM-yyyy HH:mm:ss"), If(lueJenis.EditValue, 0)})
        If dtsqli.datasetSave("kasbon", -1, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
        End If

        loadGrid()
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "HAPUS" Then
            Dim dtsqli As New dtsetSQLI(dblite)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idkasbon", "isdeleted", "updateddate"})
            value.AddRange(New Object() {iddata, 1, Format(nowTime, "dd-MM-yyyy")})
            If dtsqli.datasetSave("kasbon", iddata, field, value, False) = True Then
                btnDelete.Text = "AKTIF"
                dizMsgbox("Data terhapus", dizMsgboxStyle.Info, Me)
            End If
        ElseIf btnDelete.Text = "AKTIF" Then
            Dim dtsqli As New dtsetSQLI(dblite)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idkasbon", "isdeleted", "updateddate"})
            value.AddRange(New Object() {iddata, 0, Format(nowTime, "dd-MM-yyyy")})
            If dtsqli.datasetSave("kasbon", iddata, field, value, False) = True Then
                btnDelete.Text = "HAPUS"
                dizMsgbox("Data terhapus", dizMsgboxStyle.Info, Me)
            End If
        End If
        loadGrid()
    End Sub

    Private Sub gvData_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Dim dr As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
        iddata = dr("idkasbon")
        If dr("isdeleted") = 1 Then
            btnDelete.Text = "AKTIF"
        ElseIf dr("isdeleted") = 0 Then
            btnDelete.Text = "HAPUS"
        End If
        btnSave.Enabled = False
    End Sub

    Private Sub frmKaryawan_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadGrid()
        btnNew_Click(Me, Nothing)
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

    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        Dim kary As New frmKaryawan()
        kary.ShowDialog(Me)

        btnNew_Click(Me, Nothing)
    End Sub

End Class