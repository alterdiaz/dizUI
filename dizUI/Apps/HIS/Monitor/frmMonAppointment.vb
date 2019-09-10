Public Class frmMonAppointment
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

    Private Sub loadDokter(tanggal As Date)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@tanggal"})
        value.AddRange(New Object() {tanggal})
        sqls.CallSP("spMonParamedisJadwalTanggal", "dokter", field, value)
        lueParamedis.Properties.DataSource = sqls.dataTable("dokter")
        lueParamedis.Properties.ValueMember = "id"
        lueParamedis.Properties.DisplayMember = "content"
        lueParamedis.EditValue = Nothing
    End Sub

    Private Sub loadSesi(idparamedis As String, tanggal As Date)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@paramedis", "@tanggal", "@hari"})
        value.AddRange(New Object() {idparamedis, tanggal, CLng(tanggal.DayOfWeek)})
        sqls.CallSP("spMonParamedisJadwalSesi", "jadwalsesi", field, value)
        lueJadwalSesi.Properties.DataSource = sqls.dataTable("jadwalsesi")
        lueJadwalSesi.Properties.ValueMember = "id"
        lueJadwalSesi.Properties.DisplayMember = "content"
        lueJadwalSesi.EditValue = Nothing
    End Sub

    Private Sub loadGrid(idparamedis As String, idsesi As String, tanggal As Date)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@tanggal", "@paramedis", "@sesi"})
        value.AddRange(New Object() {tanggal, idparamedis, idsesi})
        sqls.CallSP("spMonAppointment", "monapp", field, value)
        gcData.DataSource = sqls.dataTable("monapp")
        gvData.BestFitColumns()
        If gvData.RowCount > 0 Then
            gvData.ViewCaption = "Appointment - " & Format(CDate(deTanggal.EditValue), "dd") & " " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
        Else
            gvData.ViewCaption = " "
        End If

        If gvData.RowCount > 0 Then
            sqls = New SQLs(dbstring)
            field = New List(Of String)
            value = New List(Of Object)

            field.Clear()
            value.Clear()
            field.AddRange(New String() {"@paramedis", "@tanggal", "@hari"})
            value.AddRange(New Object() {lueParamedis.EditValue, CDate(deTanggal.EditValue), CLng(CDate(deTanggal.EditValue).DayOfWeek)})
            sqls.CallSP("spMonParamedisJadwalSesi", "getsesi", field, value)
            If sqls.getDataSet("getsesi") > 0 Then
                Dim dr As DataRow = sqls.dataTable("getsesi").Select("id='" & lueJadwalSesi.EditValue & "'")(0)
                Dim strjammulai As String = dr("jammulai").ToString.Split(":")(0)
                Dim strminmulai As String = dr("jammulai").ToString.Split(":")(1)
                Dim jammulai As Date = New Date(CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, CDate(deTanggal.EditValue).Day, strjammulai, strminmulai, 0)
                Dim durasi As Long = dr("durasi")
                Dim maxapp As Long = dr("maxapp")

                For i As Integer = 0 To gvData.RowCount - 1
                    Dim dra As DataRow = gvData.GetDataRow(i)
                    dra("timeslot") = jammulai.AddMinutes(durasi * CLng(dra("nomorurut")))
                Next
                For i As Integer = 0 To gvData.RowCount - 1
                    gvData.SetRowCellValue(i, GridColumn1, i + 1)
                Next
                gvData.BestFitColumns()
            End If
        End If

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub frmMonAppointment_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.EditValue = Nothing
        lueParamedis.EditValue = Nothing
        lueJadwalSesi.EditValue = Nothing
        gcData.DataSource = Nothing
        gvData.ViewCaption = " "
    End Sub

    Private Sub deTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles deTanggal.EditValueChanged
        If deTanggal.EditValue Is Nothing Then
            lueParamedis.Properties.DataSource = Nothing
            lueJadwalSesi.Properties.DataSource = Nothing
            lueParamedis.EditValue = Nothing
            lueJadwalSesi.EditValue = Nothing
            gcData.DataSource = Nothing
            gvData.ViewCaption = " "
            Exit Sub
        End If

        loadDokter(CDate(deTanggal.EditValue))
    End Sub

    Private Sub lueParamedis_EditValueChanged(sender As Object, e As EventArgs) Handles lueParamedis.EditValueChanged
        If deTanggal.EditValue Is Nothing Then
            lueParamedis.Properties.DataSource = Nothing
            lueParamedis.EditValue = Nothing
            gcData.DataSource = Nothing
            gvData.ViewCaption = " "
            Exit Sub
        End If
        If lueParamedis.EditValue Is Nothing Then
            lueJadwalSesi.Properties.DataSource = Nothing
            lueJadwalSesi.EditValue = Nothing
            gcData.DataSource = Nothing
            gvData.ViewCaption = " "
            Exit Sub
        End If

        loadSesi(lueParamedis.EditValue, CDate(deTanggal.EditValue))
    End Sub

    Private Sub lueJadwalSesi_EditValueChanged(sender As Object, e As EventArgs) Handles lueJadwalSesi.EditValueChanged
        If lueJadwalSesi.EditValue Is Nothing Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = " "
            Exit Sub
        End If

        loadGrid(lueParamedis.EditValue, lueJadwalSesi.EditValue, CDate(deTanggal.EditValue))
    End Sub

    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

End Class