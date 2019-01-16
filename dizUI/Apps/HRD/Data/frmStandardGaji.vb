Public Class frmStandardGaji
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
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idunit as id, unit as content from unit where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and (idunit<>(select isnull(value,0) from sys_appsetting where variable='IDSystemUnit') and idunit<>(select isnull(value,0) from sys_appsetting where variable='IDVendorUnit')) order by unit asc", "munit")
        lueUnit.Properties.DataSource = mysqls.dataTable("munit")
        lueUnit.Properties.DisplayMember = "content"
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueUnit.Properties.BestFit()
        If mysqls.getDataSet("munit") = 0 Then
            dizMsgbox("Unit tidak ditemukan" & vbCrLf & "Unit harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select iddepartment as id, department as content from department where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and department<>'SYSTEM'", "mdepartment")
        lueDepartment.Properties.DataSource = mysqls.dataTable("mdepartment")
        lueDepartment.Properties.DisplayMember = "content"
        lueDepartment.Properties.ValueMember = "id"
        lueDepartment.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueDepartment.Properties.BestFit()
        If mysqls.getDataSet("mdepartment") = 0 Then
            dizMsgbox("Department tidak ditemukan" & vbCrLf & "Department harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idposition as id, position as content from position where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and (idposition<>(select isnull(value,0) from sys_appsetting where variable='IDSystemJabatan') and idposition<>(select isnull(value,0) from sys_appsetting where variable='IDVendorJabatan')) order by priority", "mposition")
        lueJabatan.Properties.DataSource = mysqls.dataTable("mposition")
        lueJabatan.Properties.DisplayMember = "content"
        lueJabatan.Properties.ValueMember = "id"
        lueJabatan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJabatan.Properties.BestFit()
        If mysqls.getDataSet("mposition") = 0 Then
            dizMsgbox("Jabatan tidak ditemukan" & vbCrLf & "Jabatan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idstaff as id, nama as content from staff where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and (idposition<>(select isnull(value,0) from sys_appsetting where variable='IDSystemJabatan') and idposition<>(select isnull(value,0) from sys_appsetting where variable='IDVendorJabatan')) order by nama asc", "mstaff")
        lueStaff.Properties.DataSource = mysqls.dataTable("mstaff")
        lueStaff.Properties.DisplayMember = "content"
        lueStaff.Properties.ValueMember = "id"
        lueStaff.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueStaff.Properties.BestFit()
        If mysqls.getDataSet("mstaff") = 0 Then
            dizMsgbox("Karyawan tidak ditemukan" & vbCrLf & "Karyawan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim mysqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@idunit", "@iddept", "@idjabatan", "@idstaff"})
        value.AddRange(New Object() {If(lueUnit.EditValue, 0), If(lueDepartment.EditValue, 0), If(lueJabatan.EditValue, 0), If(lueStaff.EditValue, 0)})
        mysqls.CallSP("spCekStandardGaji", "data", field, value)
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        gcData.DataSource = Nothing
        gvData.BestFitColumns()

        kosongkanIsian(tlpField)
        btnNew.Enabled = True
        btnSave.Enabled = True
        statData = statusData.Baru
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        Dim sqls As New SQLs(dbstring)
        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")
        Dim bcek As Boolean = True
        For i As Integer = 0 To gvData.RowCount - 1
            dtSQL = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)

            Dim dr As DataRow = gvData.GetDataRow(i)
            idData = dr("idstandardgaji")
            Dim idkomp As String = dr("idkomponengaji")
            Dim sg As Long = dr("standardgaji")
            Dim periode As String = dr("periode")
            statData = statusData.Edit
            If Format(nowTime, "MM-yyyy") <> periode Then
                statData = statusData.Baru
            End If
            If statData = statusData.Baru Then
                idData = GenerateGUID()
                field.AddRange(New String() {"idstandardgaji", "idcompany", "idunit", "iddepartment", "idposition", "idstaff", "idkomponengaji", "isdeleted", "periode", "standardgaji", "createdby", "createddate"})
                value.AddRange(New Object() {idData, idcomp, If(lueUnit.EditValue, 0), If(lueDepartment.EditValue, 0), If(lueJabatan.EditValue, 0), If(lueStaff.EditValue, 0), idkomp, 0, nowTime, sg, userid, nowTime})
            Else
                field.AddRange(New String() {"idstandardgaji", "idcompany", "idunit", "iddepartment", "idposition", "idstaff", "idkomponengaji", "isdeleted", "standardgaji", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, idcomp, If(lueUnit.EditValue, 0), If(lueDepartment.EditValue, 0), If(lueJabatan.EditValue, 0), If(lueStaff.EditValue, 0), idkomp, 0, sg, userid, nowTime})
            End If
            bcek = dtSQL.datasetSave("standardgaji", idData, field, value, False)
            isiLog(userid, dbstring, field, value, "standardgaji")
            If bcek = False Then Exit For
        Next
        If bcek = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            btnCheck_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        checkFieldMaxLength(dbstring, tlpField, "komponengaji")
        loadLOV()
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        loadGrid()
    End Sub

End Class