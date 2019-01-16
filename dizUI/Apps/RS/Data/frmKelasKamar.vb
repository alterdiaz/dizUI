Imports System.Data.SqlClient

Public Class frmKelasKamar
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

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring) ')db.searchDatabaseServer("sqlsvr"))
        mysqls.DMLQuery("select idkelas as id, kelas as content from kelas order by priority", "kelas")
        lueKelas.Properties.DataSource = mysqls.dataTable("kelas")
        lueKelas.Properties.DisplayMember = "content"
        lueKelas.Properties.ValueMember = "id"

        mysqls.DMLQuery("select idlokasi as id, nama as content from lokasi where lokasitype in (3,4,22)", "kamar")
        lueKamar.Properties.DataSource = mysqls.dataTable("kamar")
        lueKamar.Properties.DisplayMember = "content"
        lueKamar.Properties.ValueMember = "id"
    End Sub

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select kk.idkelaskamar,kk.idkelas,kk.idlokasi,kk.isdeleted,kl.kelas,ka.nama,del.generalcode as statdata from kelaskamar kk left join lokasi ka on kk.idlokasi=ka.idlokasi left join kelas kl on kk.idkelas=kl.idkelas left join sys_generalcode del on kk.isdeleted=del.idgeneral and del.gctype='DELETE' order by kl.kelas asc,ka.nama asc", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        kosongkanIsian(tlpField)
        lueKamar.EditValue = Nothing
        lueKelas.EditValue = Nothing

        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        statData = statusData.Baru
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cnt As Integer = 0
        Dim sqls As New SQLs(dbstring)
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            sqls.DMLQuery("select idlokasi from kelaskamar where idkamar='" & lueKamar.EditValue & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                lueKamar.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Edit Then
            sqls.DMLQuery("select idlokasi from kelaskamar where idkamar='" & lueKamar.EditValue & "' and idkelaskamar<>'" & idData & "'", "cek")
            If sqls.getDataSet("cek") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                lueKamar.Focus()
                Exit Sub
            End If
        End If

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        If statData = statusData.Baru Then
            idData = GenerateGUID()
            field.AddRange(New String() {"idkelaskamar", "idkelas", "idlokasi", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, lueKelas.EditValue, lueKamar.EditValue, 0, userid, nowTime})
        Else
            field.AddRange(New String() {"idkelaskamar", "idkelas", "idlokasi", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, lueKelas.EditValue, lueKamar.EditValue, userid, nowTime})
        End If
        If dtSQL.datasetSave("kelaskamar", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "kelaskamar")

            loadLOV()
            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim retval As Boolean = False
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"idkelaskamar", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("kelaskamar", idData, field, value, False)
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"idkelaskamar", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("kelaskamar", idData, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "kelaskamar")
        btnNew_Click(Me, Nothing)
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private isdeleted As String = ""
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            lueKamar.EditValue = dcol("idlokasi")
            lueKelas.EditValue = dcol("idkelas")
            idData = dcol("idkelaskamar")
            statData = statusData.Edit
            isdeleted = dcol("isdeleted")
            If isdeleted = 1 Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If

            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        checkFieldMaxLength(dbstring, tlpField, "kelaskamar")
        loadLOV()
        btnNew_Click(Me, Nothing)
    End Sub

End Class