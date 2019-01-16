Imports System.Data.SqlClient

Public Class frmDepartment
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
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
        mysqls.DMLQuery("select iddepartment, department from department", "dept")
        lueParent.Properties.DataSource = mysqls.dataTable("dept")
        lueParent.Properties.DisplayMember = "department"
        lueParent.Properties.ValueMember = "iddepartment"
    End Sub

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select d.iddepartment, d.idparent, isnull(p.department,'-') as induk, d.department, d.kode,d.kodeangka, d.isdeleted, s.generalcode as statdata from department d left join department p on p.iddepartment=d.idparent and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join sys_generalcode s on s.idgeneral=d.isdeleted and s.gctype='DELETE' where d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and d.department <>'SYSTEM' and d.department <>'VENDOR'", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()
        tlData.DataSource = Nothing
        tlData.DataSource = mysqls.dataTable("data")
        tlData.BestFitColumns()
        tlData.ParentFieldName = "idparent"
        tlData.KeyFieldName = "iddepartment"
        tlData.ExpandAll()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        kosongkanIsian(tlpField)
        lueParent.EditValue = Nothing
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        statData = statusData.Baru
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If teDepartment.Text.Replace(" ", "") = "SYSTEM" Then
            dizMsgbox("DEPARTMENT tidak boleh SYSTEM, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If teDepartment.Text.Replace(" ", "") = "VENDOR" Then
            dizMsgbox("DEPARTMENT tidak boleh VENDOR, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim cnt As Integer = 0
        Dim sqls As New SQLs(dbstring)
        If statData = statusData.Baru Then
            sqls.DMLQuery("select count(kode) as kode from department where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and kode='" & teKode.Text & "'", "dept")
            cnt = CInt(sqls.getDataSet("dept", 0, "kode"))

            If cnt = 0 Then
                sqls.DMLQuery("select count(kodeangka) as kode from department where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and kodeangka='" & teKodeAngka.Text & "'", "deptangka")
                cnt = CInt(sqls.getDataSet("deptangka", 0, "kode"))
            End If
        ElseIf statData = statusData.Edit Then
            sqls.DMLQuery("select count(kode) as kode from department where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and kode='" & teKode.Text & "' and iddepartment <>'" & idData & "'", "dept")
            cnt = CInt(sqls.getDataSet("dept", 0, "kode"))
            If cnt = 0 Then
                sqls.DMLQuery("select count(kodeangka) as kode from department where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and kodeangka='" & teKodeAngka.Text & "' and iddepartment <>'" & idData & "'", "deptangka")
                cnt = CInt(sqls.getDataSet("deptangka", 0, "kode"))
            End If
        End If
        If cnt > 0 Then
            dizMsgbox("Kode Department ini sudah digunakan", dizMsgboxStyle.Peringatan, Me)
            teKode.Focus()
            Exit Sub
        End If

        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            sqls.DMLQuery("select department from department where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and replace(department,' ','')='" & teDepartment.Text.Replace(" ", "") & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teDepartment.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Edit Then
            sqls.DMLQuery("select department from department where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and replace(department,' ','')='" & teDepartment.Text.Replace(" ", "") & "' and iddepartment<>'" & idData & "'", "cek")
            If sqls.getDataSet("cek") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teDepartment.Focus()
                Exit Sub
            End If
        End If

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        Dim sqls1 As New SQLs(dbstring)
        sqls1.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqls1.getDataSet("CompID", 0, "value")

        If statData = statusData.Baru Then
            idData = GenerateGUID()
            field.AddRange(New String() {"iddepartment", "idcompany", "idparent", "department", "kode", "kodeangka", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, idcomp, If(lueParent.EditValue, CObj(DBNull.Value)), teDepartment.Text, teKode.Text, teKodeAngka.Text, 0, userid, nowTime})
        Else
            field.AddRange(New String() {"iddepartment", "idparent", "department", "kode", "kodeangka", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, If(lueParent.EditValue, CObj(DBNull.Value)), teDepartment.Text, teKode.Text, teKodeAngka.Text, userid, nowTime})
        End If
        If dtSQL.datasetSave("department", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "department")

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
            field.AddRange(New String() {"iddepartment", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("department", idData, field, value, False)
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"iddepartment", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("department", idData, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "department")
        btnNew_Click(Me, Nothing)
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private isdeleted As String = ""
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            teDepartment.Text = dcol("department")
            teKode.Text = dcol("kode")
            teKodeAngka.Text = dcol("kodeangka")
            lueParent.EditValue = dcol("idparent")
            idData = dcol("iddepartment")
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
            If dcol("department") = "VENDOR" Then
                btnSave.Enabled = False
                btnDelete.Enabled = False
            End If
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub frmDepartment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        checkFieldMaxLength(dbstring, tlpField, "department")
        loadLOV()
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub tlData_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles tlData.FocusedNodeChanged
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.Node.Id)
            teDepartment.Text = dcol("department")
            teKode.Text = dcol("kode")
            lueParent.EditValue = dcol("idparent")
            idData = dcol("iddepartment")
            statData = statusData.Edit

            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub teKode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teKode.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub teKodeAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teKodeAngka.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

End Class