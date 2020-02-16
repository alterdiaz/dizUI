Imports DevExpress.XtraGrid.Views.Base
Public Class frmInternalSearch
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

    Private Sub frmInternalNote_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
        teSearch.EditValue = Nothing
        sluePeriode.EditValue = "0"
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("(select '0' as id,'Bulan Ini' as content ) union (select '1' as id,'3 Bulan Terakhir' as content ) union (select '2' as id,'6 Bulan Terakhir' as content ) union (select '3' as id,'12 Bulan Terakhir' as content ) union (select '4' as id,'Semua Periode' as content )", "dt")

        sluePeriode.Properties.DataSource = sqls.dataTable("dt")
        sluePeriode.Properties.ValueMember = "id"
        sluePeriode.Properties.DisplayMember = "content"
    End Sub

    Private iddept As String = ""
    Private idunit As String = ""
    Public Sub New(idunit As String, iddept As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.iddept = iddept
        Me.idunit = idunit
    End Sub

    Private Sub loadGrid(idunit As String, iddept As String, idperiode As String, strsearch As String)
        Dim sqls As New SQLs(dbstring)
        Dim iddept2 As New List(Of String)
        Dim iddepttmp As String = ""
        sqls.DMLQuery("WITH DepartmentCTE AS ( SELECT iddepartment, department, idparent,1 as Level FROM dbo.department WHERE iddepartment='" & iddept & "' UNION ALL SELECT a.iddepartment, a.department, a.idparent,Level+1 FROM dbo.department a INNER JOIN DepartmentCTE s ON a.idparent = s.iddepartment ) SELECT iddepartment FROM DepartmentCTE", "alldept")
        For i As Integer = 0 To sqls.getDataSet("alldept") - 1
            iddept2.Add("'" & sqls.getDataSet("alldept", i, "iddepartment").ToString & "'")
            iddepttmp &= ("'" & sqls.getDataSet("alldept", i, "iddepartment").ToString & "'")
            If i <> sqls.getDataSet("alldept") - 1 Then
                iddepttmp &= ","
            End If
        Next

        Dim strperiode As String = ""
        If sluePeriode.EditValue = "0" Then 'bulan ini
            strperiode = " and right(convert(varchar,ni.createddate,105),7) in "
            strperiode &= "('" & Format(nowTime, "MM-yyyy") & "')"
        ElseIf sluePeriode.EditValue = "1" Then 'bulan ini
            strperiode = " and right(convert(varchar,ni.createddate,105),7) in "
            strperiode &= "('" & Format(nowTime, "MM-yyyy") & "','" & Format(nowTime.AddMonths(-1), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-2), "MM-yyyy") & "')"
        ElseIf sluePeriode.EditValue = "2" Then 'bulan ini
            strperiode = " and right(convert(varchar,ni.createddate,105),7) in "
            strperiode &= "('" & Format(nowTime, "MM-yyyy") & "','" & Format(nowTime.AddMonths(-1), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-2), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-3), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-4), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-5), "MM-yyyy") & "')"
        ElseIf sluePeriode.EditValue = "3" Then 'bulan ini
            strperiode = " and right(convert(varchar,ni.createddate,105),7) in "
            strperiode &= "('" & Format(nowTime, "MM-yyyy") & "','" & Format(nowTime.AddMonths(-1), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-2), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-3), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-4), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-5), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-6), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-7), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-8), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-9), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-10), "MM-yyyy") & "','" & Format(nowTime.AddMonths(-11), "MM-yyyy") & "')"
        ElseIf sluePeriode.EditValue = "4" Then 'bulan ini
            strperiode = ""
        End If
        sqls.DMLQuery("select ni.idinternalnote,ni.iddepartment,ni.judul,ni.remarks as isi,convert(varchar,ni.createddate,105)+' '+convert(varchar,ni.createddate,108) as notedate,ni.isdeleted,ni.isreviewed,case when reviewedby is null then d.department + ' Dibuat '+convert(varchar,ni.createddate,105)+' '+convert(varchar,ni.createddate,108) +' '+ uc.username else d.department + ' Dibuat '+convert(varchar,ni.createddate,105)+' '+convert(varchar,ni.createddate,108) +' '+ uc.username + ' Direview '+convert(varchar,ni.revieweddate,105)+' '+convert(varchar,ni.revieweddate,108) +' '+ ur.username end as note,'JUDUL ' + ni.judul + char(13) + char(10) + ni.remarks as catatan from internalnote ni left join department d on ni.iddepartment=d.iddepartment left join sys_user uc on ni.createdby=uc.iduser left join sys_user ur on ni.reviewedby=ur.iduser where ni.remarks like '%" & strsearch & "%' and ni.isdeleted=0 and ni.idunit='" & idunit & "' and ni.iddepartment in (" & iddepttmp & ") " & strperiode & " order by ni.createddate desc", "getdata")

        gcData.DataSource = sqls.dataTable("getdata")
        gvData.BestFitColumns()
        gvData.PreviewIndent = 0 'GridColumn2.Width
        gvData.ViewCaption = "Catatan Internal " & sluePeriode.Text
    End Sub

    Private Sub teSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teSearch.KeyPress, sluePeriode.KeyPress
        If sluePeriode.EditValue Is Nothing Then Exit Sub
        If teSearch.EditValue Is Nothing Then Exit Sub
        If teSearch.Text = "" Then Exit Sub
        If Asc(e.KeyChar) = 13 Then
            btnCari_Click(btnCari, Nothing)
        End If
    End Sub

    Private Sub sluePeriode_EditValueChanged(sender As Object, e As EventArgs) Handles sluePeriode.EditValueChanged
        If sluePeriode.EditValue Is Nothing Then Exit Sub
        If teSearch.EditValue Is Nothing Then Exit Sub
        If teSearch.Text = "" Then Exit Sub

        btnCari_Click(btnCari, Nothing)
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If sluePeriode.EditValue Is Nothing Then Exit Sub
        If teSearch.EditValue Is Nothing Then Exit Sub
        If teSearch.Text = "" Then Exit Sub

        loadGrid(Me.idunit, Me.iddept, sluePeriode.EditValue, teSearch.Text)
    End Sub

End Class