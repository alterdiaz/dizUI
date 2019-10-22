Public Class frmRMRequestMulti
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

    Private Sub frmManajemenBerkasRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.EditValue = nowTime
        lueLokasi.EditValue = Nothing
        lueUsernameRequest.EditValue = Nothing

        gvData.ViewCaption = " "
        Threading.Thread.Sleep(100)

        kosongkanisian()
        loadlov()

        If usersuper = 0 Then
            lueUsernameRequest.EditValue = userid
            lueUsernameRequest.Enabled = False
        Else
            lueUsernameRequest.EditValue = userid
        End If
    End Sub

    Private Sub loadlov()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='jenisperiode' order by generalcode asc", "jt")
        lueJenis.Properties.DataSource = sqls.dataTable("jt")
        lueJenis.Properties.ValueMember = "id"
        lueJenis.Properties.DisplayMember = "content"
        lueJenis.EditValue = Nothing

        sqls.DMLQuery("select iduser as id,username as content from sys_user order by username asc", "userreq")
        lueUsernameRequest.Properties.DataSource = sqls.dataTable("userreq")
        lueUsernameRequest.Properties.ValueMember = "id"
        lueUsernameRequest.Properties.DisplayMember = "content"
        lueUsernameRequest.EditValue = Nothing

        sqls.DMLQuery("select idlokasi as id,nama as content from lokasi order by nama asc", "lokasi")
        lueLokasi.Properties.DataSource = sqls.dataTable("lokasi")
        lueLokasi.Properties.ValueMember = "id"
        lueLokasi.Properties.DisplayMember = "content"
        lueLokasi.EditValue = Nothing
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        deTanggal_EditValueChanged(deTanggal, Nothing)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sqls As New SQLs(dbstring)
        Dim cekbool As Boolean = False
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dra As DataRow = gvData.GetDataRow(i)
            If dra.RowState = DataRowState.Modified Then
                If dra("cek") = "True" Then
                    cekbool = True
                End If
            End If
        Next
        If cekbool = False Then
            dizMsgbox("Rekam Medis belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If lueUsernameRequest.EditValue Is Nothing Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If lueLokasi.EditValue Is Nothing Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        sqls = New SQLs(dbstring)
        Dim idunit As String = ""
        Dim iddept As String = ""
        sqls.DMLQuery("select iddepartment,idunit from lokasi where idlokasi='" & lueLokasi.EditValue & "'", "lokasi")
        idunit = sqls.getDataSet("lokasi", 0, "idunit")
        iddept = sqls.getDataSet("lokasi", 0, "iddepartment")

        Dim iddata As String = GenerateGUID()
        Dim currtime As Date = nowTime

        For i As Integer = 0 To gvData.RowCount - 1
            Dim dra As DataRow = gvData.GetDataRow(i)
            If dra.RowState = DataRowState.Modified Then
                If dra("cek") = "True" Then
                    Dim idrm As String = dra("idrekammedis")
                    Dim norm As String = dra("rekammedisno")

                    Dim pair As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Request RM", False)
                    Dim notrans As String = pair.Value

                    iddata = GenerateGUID()
                    Dim dtsqls As New dtsetSQLS(dbstring)
                    Dim field As New List(Of String)
                    Dim value As New List(Of Object)
                    field.AddRange(New String() {"idtracking", "idreff", "tablereff", "noreff", "idreff2", "tablereff2", "noreff2", "trackingtype", "createdby", "createddate", "trackingdate", "trackingno", "borrowedby", "borroweddate", "requestby", "requestdate", "receivedby", "receiveddate", "idunit", "iddepartment", "idlokasi"})
                    value.AddRange(New Object() {iddata, idrm, "Pasien", norm, "0", "-", "0", 2, userid, currtime, currtime, notrans, DBNull.Value, DBNull.Value, lueUsernameRequest.EditValue, currtime, DBNull.Value, DBNull.Value, idunit, iddept, lueLokasi.EditValue})
                    dtsqls.datasetSave("tracking", iddata, field, value, False)
                End If
                dra("cek") = 0
            End If
        Next
        kosongkanisian()
    End Sub

    Private Sub kosongkanisian()
        lueLokasi.EditValue = Nothing
        lueUsernameRequest.EditValue = Nothing

        If usersuper = 0 Then
            lueUsernameRequest.EditValue = userid
            lueUsernameRequest.Enabled = False
        Else
            lueUsernameRequest.EditValue = userid
        End If
    End Sub

    Private Sub deTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles deTanggal.EditValueChanged
        If lueJenis.EditValue Is Nothing Then Exit Sub
        If deTanggal.EditValue Is Nothing Then Exit Sub

        Dim sqls As New SQLs(dbstring)
        If lueJenis.EditValue = 1 Then
            sqls.DMLQuery("select convert(bit,0) as cek,rm.idrekammedis,rm.isdeleted,dbo.fFormatNoRM(rm.rekammedisno) as rekammedisno,rm.nama,rm.jeniskelamin,st.generalcode as sextype,convert(varchar,rm.tanggallahir,105) as tanggallahir,case when reg.counter=0 then 'Batal' when reg.counter=1 then 'Baru' else 'Lama' end as kunjungan  from rekammedis rm left join (select count(idregistrasi) as counter,idrekammedis from registrasi where isdeleted=0 and registrasidate<=convert(date,'" & Format(CDate(deTanggal.EditValue), "yyyy/MM/dd") & "') group by idrekammedis) reg on rm.idrekammedis=reg.idrekammedis left join sys_generalcode st on rm.jeniskelamin=st.idgeneral and st.gctype='SEXTYPE' where rm.rekammedisno<>0 and rm.idrekammedis in (select distinct idrekammedis from registrasi where convert(varchar,registrasidate,105) = '" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "') order by rm.rekammedisno asc", "lama")
        Else
            sqls.DMLQuery("select convert(bit,0) as cek,rm.idrekammedis,rm.isdeleted,dbo.fFormatNoRM(rm.rekammedisno) as rekammedisno,rm.nama,rm.jeniskelamin,st.generalcode as sextype,convert(varchar,rm.tanggallahir,105) as tanggallahir,case when reg.counter=0 then 'Batal' when reg.counter=1 then 'Baru' else 'Lama' end as kunjungan from rekammedis rm left join (select count(idregistrasi) as counter,idrekammedis from registrasi where isdeleted=0 and registrasidate<=(select max(registrasidate) from registrasi where convert(varchar,registrasidate,105) like '%" & Format(CDate(deTanggal.EditValue), "MM-yyyy") & "') group by idrekammedis) reg on rm.idrekammedis=reg.idrekammedis left join sys_generalcode st on rm.jeniskelamin=st.idgeneral and st.gctype='SEXTYPE' where rm.rekammedisno<>0 and rm.idrekammedis in (select distinct idrekammedis from registrasi where convert(varchar,registrasidate,105) like '%" & Format(CDate(deTanggal.EditValue), "MM-yyyy") & "') order by rm.rekammedisno asc", "lama")
        End If
        gcData.DataSource = sqls.dataTable("lama")
        gvData.BestFitColumns()
    End Sub

    Private Sub lueJenis_EditValueChanged(sender As Object, e As EventArgs) Handles lueJenis.EditValueChanged
        If lueJenis.EditValue Is Nothing Then
            Label1.Text = ""
            deTanggal.EditValue = Nothing
            Exit Sub
        End If

        If lueJenis.EditValue = 1 Then
            Label1.Text = "Tanggal"
            deTanggal.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.MonthView
            deTanggal.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView
            deTanggal.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
            deTanggal.Properties.EditFormat.FormatString = "dd-MM-yyyy"
            deTanggal.Properties.EditMask = "dd-MM-yyyy"
        Else
            Label1.Text = "Bulan"
            deTanggal.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView
            deTanggal.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView
            deTanggal.Properties.DisplayFormat.FormatString = "MM-yyyy"
            deTanggal.Properties.EditFormat.FormatString = "MM-yyyy"
            deTanggal.Properties.EditMask = "MM-yyyy"
        End If

        deTanggal_EditValueChanged(deTanggal, Nothing)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        loadlov()
        lueUsernameRequest.EditValue = userid
        deTanggal.EditValue = Nothing
        lueJenis.EditValue = Nothing
        lueLokasi.EditValue = Nothing
    End Sub

End Class