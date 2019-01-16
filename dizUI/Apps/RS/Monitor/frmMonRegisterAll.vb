Public Class frmMonRegisterAll
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
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iddepartment as id,department as content from department where iddepartment in(select value from sys_appsetting where variable in('idemergencydept','idicudept','idinpatientdept','idlabdept','idnicudept','idoperatingdept','idoutpatientdept','idpicudept','idphysiodept','idraddept')) order by department asc", "dept")
        lueDepartment.Properties.DataSource = sqls.dataTable("dept")
        lueDepartment.Properties.ValueMember = "id"
        lueDepartment.Properties.DisplayMember = "content"
        lueDepartment.EditValue = Nothing

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='JENISPERIODE' order by idgeneral asc", "jp")
        lueJenis.Properties.DataSource = sqls.dataTable("jp")
        lueJenis.Properties.ValueMember = "id"
        lueJenis.Properties.DisplayMember = "content"
        lueJenis.EditValue = Nothing
    End Sub

    Private Sub loadgrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        sqls.DMLQuery("select variable,value from sys_appsetting where variable in('idemergencydept','idicudept','idinpatientdept','idlabdept','idnicudept','idoperatingdept','idoutpatientdept','idpicudept','idphysiodept','idraddept') and convert(varchar,value)='" & lueDepartment.EditValue & "'", "cek")
        If lueJenis.EditValue = CLng(1) Then
            If CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idemergencydept" Then
                field.AddRange(New String() {"@tahun", "@bulan", "@tanggal"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, CDate(deTanggal.EditValue).Day})
                sqls.CallSP("spMonRegisterIGDDay", "monreg", field, value)
                gvData.ViewCaption = "Register IGD - " & CDate(deTanggal.EditValue).Day & " " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idoutpatientdept" Then
                field.AddRange(New String() {"@tahun", "@bulan", "@tanggal"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, CDate(deTanggal.EditValue).Day})
                sqls.CallSP("spMonRegisterRJDay", "monreg", field, value)
                gvData.ViewCaption = "Register IRJ - " & CDate(deTanggal.EditValue).Day & " " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idphysiodept" Then
                field.AddRange(New String() {"@tahun", "@bulan", "@tanggal"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, CDate(deTanggal.EditValue).Day})
                sqls.CallSP("spMonRegisterRHBDay", "monreg", field, value)
                gvData.ViewCaption = "Register IRM - " & CDate(deTanggal.EditValue).Day & " " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idicudept" Then
                field.AddRange(New String() {"@tahun", "@bulan", "@tanggal"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, CDate(deTanggal.EditValue).Day})
                sqls.CallSP("spMonRegisterICUDay", "monreg", field, value)
                gvData.ViewCaption = "Register ICU - " & CDate(deTanggal.EditValue).Day & " " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idlabdept" Then
                field.AddRange(New String() {"@tahun", "@bulan", "@tanggal"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, CDate(deTanggal.EditValue).Day})
                sqls.CallSP("spMonRegisterLABDay", "monreg", field, value)
                gvData.ViewCaption = "Register LAB - " & CDate(deTanggal.EditValue).Day & " " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idnicudept" Then
                field.AddRange(New String() {"@tahun", "@bulan", "@tanggal"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, CDate(deTanggal.EditValue).Day})
                sqls.CallSP("spMonRegisterNICUDay", "monreg", field, value)
                gvData.ViewCaption = "Register NICU - " & CDate(deTanggal.EditValue).Day & " " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idoperatingdept" Then
                field.AddRange(New String() {"@tahun", "@bulan", "@tanggal"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, CDate(deTanggal.EditValue).Day})
                sqls.CallSP("spMonRegisterIBSDay", "monreg", field, value)
                gvData.ViewCaption = "Register IBS - " & CDate(deTanggal.EditValue).Day & " " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idpicudept" Then
                field.AddRange(New String() {"@tahun", "@bulan", "@tanggal"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, CDate(deTanggal.EditValue).Day})
                sqls.CallSP("spMonRegisterPICUDay", "monreg", field, value)
                gvData.ViewCaption = "Register PICU - " & CDate(deTanggal.EditValue).Day & " " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idraddept" Then
                field.AddRange(New String() {"@tahun", "@bulan", "@tanggal"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, CDate(deTanggal.EditValue).Day})
                sqls.CallSP("spMonRegisterRADDay", "monreg", field, value)
                gvData.ViewCaption = "Register RAD - " & CDate(deTanggal.EditValue).Day & " " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            End If
        Else
            If CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idemergencydept" Then
                field.AddRange(New String() {"@tahun", "@bulan"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month})
                sqls.CallSP("spMonRegisterIGD", "monreg", field, value)
                gvData.ViewCaption = "Register IGD - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idoutpatientdept" Then
                field.AddRange(New String() {"@tahun", "@bulan"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month})
                sqls.CallSP("spMonRegisterRJ", "monreg", field, value)
                gvData.ViewCaption = "Register IRJ - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idphysiodept" Then
                field.AddRange(New String() {"@tahun", "@bulan"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month})
                sqls.CallSP("spMonRegisterRHB", "monreg", field, value)
                gvData.ViewCaption = "Register IRM - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idicudept" Then
                field.AddRange(New String() {"@tahun", "@bulan"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month})
                sqls.CallSP("spMonRegisterICU", "monreg", field, value)
                gvData.ViewCaption = "Register ICU - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idlabdept" Then
                field.AddRange(New String() {"@tahun", "@bulan"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month})
                sqls.CallSP("spMonRegisterLAB", "monreg", field, value)
                gvData.ViewCaption = "Register LAB - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idnicudept" Then
                field.AddRange(New String() {"@tahun", "@bulan"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month})
                sqls.CallSP("spMonRegisterNICU", "monreg", field, value)
                gvData.ViewCaption = "Register NICU - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idoperatingdept" Then
                field.AddRange(New String() {"@tahun", "@bulan"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month})
                sqls.CallSP("spMonRegisterIBS", "monreg", field, value)
                gvData.ViewCaption = "Register IBS - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idpicudept" Then
                field.AddRange(New String() {"@tahun", "@bulan"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month})
                sqls.CallSP("spMonRegisterPICU", "monreg", field, value)
                gvData.ViewCaption = "Register PICU - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            ElseIf CStr(sqls.getDataSet("cek", 0, "variable")).ToLower = "idraddept" Then
                field.AddRange(New String() {"@tahun", "@bulan"})
                value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month})
                sqls.CallSP("spMonRegisterRAD", "monreg", field, value)
                gvData.ViewCaption = "Register RAD - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
            End If
        End If

        If sqls.getDataSet("monreg") = 0 Then
            gcData.DataSource = Nothing
        Else
            gcData.DataSource = sqls.dataTable("monreg")
        End If

        'Dim cnt As Long = 1
        'Dim paramname As String = ""
        'For i As Integer = 0 To sqls.dataTable("monreg").Rows.Count - 1
        '    Dim dr As DataRow = gvData.GetDataRow(i)
        '    If paramname <> dr("dokterruangan") Then
        '        cnt = 1
        '        paramname = dr("dokterruangan")
        '    End If
        '    gvData.SetRowCellValue(i, GridColumn1, cnt)
        '    cnt += 1
        'Next
        GridColumn18.GroupIndex = 1
        gvData.ExpandAllGroups()
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadAll()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If lueJenis.EditValue = CLng(1) Then
            field.AddRange(New String() {"@tahun", "@bulan", "@tanggal"})
            value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, CDate(deTanggal.EditValue).Day})
            sqls.CallSP("spMonRegisterAllDay", "monreg", field, value)
            gvData.ViewCaption = "Semua Register - " & CDate(deTanggal.EditValue).Day & " " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
        Else
            field.AddRange(New String() {"@tahun", "@bulan"})
            value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month})
            sqls.CallSP("spMonRegisterAll", "monreg", field, value)
            gvData.ViewCaption = "Semua Register - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
        End If

        If sqls.getDataSet("monreg") = 0 Then
            gcData.DataSource = Nothing
        Else
            gcData.DataSource = sqls.dataTable("monreg")
        End If

        'Dim cnt As Long = 1
        'Dim paramname As String = ""
        'For i As Integer = 0 To sqls.dataTable("monreg").Rows.Count - 1
        '    Dim dr As DataRow = gvData.GetDataRow(i)
        '    If paramname <> dr("dokterruangan") Then
        '        cnt = 1
        '        paramname = dr("dokterruangan")
        '    End If
        '    gvData.SetRowCellValue(i, GridColumn1, cnt)
        '    cnt += 1
        'Next
        GridColumn18.GroupIndex = 1
        gvData.ExpandAllGroups()
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged, lueDepartment.EditValueChanged
        Dim iscek As Boolean = False
        If deTanggal.EditValue Is Nothing Then
            iscek = True
        End If
        If iscek = True Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = " "
            Exit Sub
        End If
        If lueDepartment.EditValue Is Nothing Then
            loadAll()
        Else
            loadgrid()
        End If
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
        lblPeriode.Text = ""
        lblPeriode.Visible = False
        deTanggal.EditValue = Nothing
        deTanggal.Visible = False
        gvData.ViewCaption = " "
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

    Private Sub btnClearDept_Click(sender As Object, e As EventArgs) Handles btnClearDept.Click
        lueDepartment.EditValue = Nothing
    End Sub

    Private Sub lueJenis_EditValueChanged(sender As Object, e As EventArgs) Handles lueJenis.EditValueChanged
        If lueJenis.EditValue Is Nothing Then
            lblPeriode.Visible = False
            deTanggal.EditValue = Nothing
            deTanggal.Visible = False
            Exit Sub
        End If
        If lueJenis.EditValue = CLng(1) Then
            lblPeriode.Text = "Tanggal"
            lblPeriode.Visible = True
            deTanggal.EditValue = Nothing
            deTanggal.Visible = True
            deTanggal.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
            deTanggal.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False
            deTanggal.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView
            deTanggal.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.Default
            deTanggal.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
            deTanggal.Properties.EditFormat.FormatString = "dd-MM-yyyy"
            deTanggal.Properties.EditMask = "dd-MM-yyyy"
        Else
            lblPeriode.Text = "Periode Bulan"
            lblPeriode.Visible = True
            deTanggal.EditValue = Nothing
            deTanggal.Visible = True
            deTanggal.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
            deTanggal.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True
            deTanggal.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView
            deTanggal.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView
            deTanggal.Properties.DisplayFormat.FormatString = "MM-yyyy"
            deTanggal.Properties.EditFormat.FormatString = "MM-yyyy"
            deTanggal.Properties.EditMask = "MM-yyyy"
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        deTanggal_EditValueChanged(deTanggal, Nothing)
    End Sub

End Class