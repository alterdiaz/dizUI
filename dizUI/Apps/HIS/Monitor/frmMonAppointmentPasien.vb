Public Class frmMonAppointmentPasien
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

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select r.idrekammedis as id,dbo.fFormatNoRM(r.rekammedisno) as 'rekammedisno',r.nama,convert(varchar,r.tanggallahir,105) as tanggallahir from rekammedis r where r.isdeleted=0 and r.idrekammedis in (select distinct(idrekammedis) as idrekammedis from appointment) order by r.rekammedisno asc", "pasiennama")

        slueLamaNama.Properties.DataSource = mysqls.dataTable("pasiennama")
        slueLamaNama.Properties.DisplayMember = "nama"
        slueLamaNama.Properties.ValueMember = "id"
        slueLamaNama.EditValue = Nothing
        slueLamaNama.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        lueLamaNoRM.Properties.DataSource = mysqls.dataTable("pasiennama")
        lueLamaNoRM.Properties.DisplayMember = "rekammedisno"
        lueLamaNoRM.Properties.ValueMember = "id"
        lueLamaNoRM.EditValue = Nothing
    End Sub

    Private Sub frmAppointment_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
        lueLamaNoRM.EditValue = Nothing
        slueLamaNama.EditValue = Nothing
        gcData.DataSource = Nothing
    End Sub

    Private isPatient As Boolean = False
    Private isMRN As Boolean = False
    Private Sub lueLamaNoRM_EditValueChanged(sender As Object, e As EventArgs) Handles lueLamaNoRM.EditValueChanged
        If lueLamaNoRM.EditValue Is Nothing Then
            Exit Sub
        End If
        If isMRN = True Then
            Exit Sub
        End If
        isMRN = True
        slueLamaNama.EditValue = lueLamaNoRM.EditValue
        loadData()
        isMRN = False
    End Sub

    Private Sub slueLamaNama_EditValueChanged(sender As Object, e As EventArgs) Handles slueLamaNama.EditValueChanged
        If isPatient = True Then Exit Sub
        isPatient = True
        lueLamaNoRM.EditValue = slueLamaNama.EditValue
        loadData()
        isPatient = False
    End Sub

    Private Sub loadData()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@idpasien"})
        value.AddRange(New Object() {lueLamaNoRM.EditValue})
        sqls.CallSP("spMonAppointmentPasien", "monapp", field, value)
        gcData.DataSource = sqls.dataTable("monapp")
        gvData.BestFitColumns()
        If gvData.RowCount > 0 Then
            gvData.ViewCaption = "Appointment - " & slueLamaNama.Text
        Else
            gvData.ViewCaption = " "
        End If

        If gvData.RowCount > 0 Then
            sqls = New SQLs(dbstring)
            field = New List(Of String)
            value = New List(Of Object)

            For i As Integer = 0 To gvData.RowCount - 1
                Dim dra As DataRow = gvData.GetDataRow(i)
                Dim idjadwalsesi As String = dra("idjadwalsesi")
                Dim idparamedis As String = dra("idparamedisspesialis")
                Dim bookingdate As Date = Strdate2Date(dra("bookingdate").ToString)
                field.Clear()
                value.Clear()
                field.AddRange(New String() {"@paramedis", "@tanggal", "@hari"})
                value.AddRange(New Object() {idparamedis, bookingdate, CLng(bookingdate.DayOfWeek)})
                Dim sqls2 As New SQLs(dbstring)
                sqls2.clearDataSet()
                sqls2.CallSP("spMonParamedisJadwalSesi", "getsesi", field, value)
                If sqls2.getDataSet("getsesi") > 0 Then
                    Dim dr As DataRow = sqls2.dataTable("getsesi").Select("id='" & idjadwalsesi & "'")(0)
                    Dim strjammulai As String = dr("jammulai").ToString.Split(":")(0)
                    Dim strminmulai As String = dr("jammulai").ToString.Split(":")(1)
                    Dim jammulai As Date = New Date(bookingdate.Year, bookingdate.Month, bookingdate.Day, strjammulai, strminmulai, 0)
                    Dim durasi As Long = dr("durasi")
                    Dim maxapp As Long = dr("maxapp")
                    Dim timeslot As Date = jammulai.AddMinutes(durasi * CLng(dra("nomorurut")))
                    dra("timeslot") = Format(timeslot, "dd-MM-yyyy HH:mm:ss")
                End If
                sqls2.Dispose()
                gvData.BestFitColumns()
            Next
            For i As Integer = 0 To gvData.RowCount - 1
                gvData.SetRowCellValue(i, GridColumn1, i + 1)
            Next
        End If

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

End Class