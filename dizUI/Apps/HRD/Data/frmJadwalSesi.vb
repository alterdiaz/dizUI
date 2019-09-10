Imports DevExpress.XtraGrid.Views.Base

Public Class frmJadwalSesi

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
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select js.idjadwalsesi,js.priority,js.kode,js.nama,js.isdeleted,del.generalcode as statdata,left(convert(varchar,js.jammulai,108),5) as jammulai,left(convert(varchar,js.jamselesai,108),5) as jamselesai from jadwalsesi js left join sys_generalcode del on js.isdeleted=del.idgeneral and del.gctype='delete' order by js.priority asc", "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        sePrioritas.EditValue = 0
        teKode.Text = ""
        teJadwalSesi.Text = ""
        teJamMulai.EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
        teJamSelesai.EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
        statData = statusData.Baru
        idData = "-1"
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"
    Private Function cekIsian() As Boolean
        Dim retval As Boolean = True

        If sePrioritas.EditValue = 0 Then
            retval = False
        End If
        If teKode.Text = "" Then
            retval = False
        End If
        If teJadwalSesi.Text = "" Then
            retval = False
        End If

        If sePrioritas.EditValue Is Nothing Then
            retval = False
        End If
        If teKode.EditValue Is Nothing Then
            retval = False
        End If
        If teJadwalSesi.EditValue Is Nothing Then
            retval = False
        End If

        Return retval
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cekIsian() = False Then Exit Sub

        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If statData = statusData.Baru Then
            idData = GenerateGUID()
            field.AddRange(New String() {"idjadwalsesi", "priority", "kode", "nama", "isdeleted", "jammulai", "jamselesai", "createdby"})
            value.AddRange(New Object() {idData, sePrioritas.EditValue, teKode.EditValue, teJadwalSesi.EditValue, 0, CDate(teJamMulai.EditValue).TimeOfDay, CDate(teJamSelesai.EditValue).TimeOfDay, userid})
        Else
            field.AddRange(New String() {"idjadwalsesi", "priority", "kode", "nama", "jammulai", "jamselesai", "updateddate", "updatedby"})
            value.AddRange(New Object() {idData, sePrioritas.EditValue, teKode.EditValue, teJadwalSesi.EditValue, CDate(teJamMulai.EditValue).TimeOfDay, CDate(teJamSelesai.EditValue).TimeOfDay, nowTime, userid})
        End If

        If dtsqls.datasetSave("jadwalsesi", idData, field, value, False) Then
            dizMsgbox("Jadwal telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
        End If
        loadGrid()
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        field.AddRange(New String() {"idjadwalsesi", "isdeleted", "updatedby", "updateddate"})
        If btnDelete.Text = "HAPUS" Then
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            dtsql.datasetSave("jadwalsesi", idData, field, value, False)
            btnDelete.Text = "AKTIF"
        ElseIf btnDelete.Text = "AKTIF" Then
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            dtsql.datasetSave("jadwalsesi", idData, field, value, False)
            btnDelete.Text = "HAPUS"
        End If
        loadGrid()
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub gvData_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then Exit Sub

        Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
        statData = statusData.Edit
        idData = dcol("idjadwalsesi")
        sePrioritas.EditValue = dcol("priority")
        teJadwalSesi.EditValue = dcol("nama")
        teJamMulai.EditValue = dcol("jammulai")
        teJamSelesai.EditValue = dcol("jamselesai")
        teKode.EditValue = dcol("kode")

        If dcol("isdeleted") = 0 Then
            btnDelete.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDelete.Text = "AKTIF"
        End If

        btnNew.Enabled = True
        btnSave.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub frmJadwalSesi_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        checkFieldMaxLength(dbstring, tlpField, "jadwalsesi")

        loadGrid()
        btnNew_Click(Me, Nothing)
    End Sub

End Class