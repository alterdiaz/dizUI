Public Class frmWilayah
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
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idgeneral as levelwilayah, generalcode as levelwilayah from sys_generalcode gc where gc.gctype='LEVELAREA'", "level")
        lueLevel.Properties.DataSource = mysqls.dataTable("level")
        lueLevel.Properties.DisplayMember = "levelwilayah"
        lueLevel.Properties.ValueMember = "levelwilayah"
    End Sub

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select w.idwilayah, isnull(w.idparent,0) as idparent, isnull(p.wilayah,'-') as induk, w.levelwilayah, w.wilayah, w.kodepos, w.isdeleted, w.kodewilayah, del.generalcode as statdata from wilayah w left join wilayah p on p.idwilayah=w.idparent left join sys_generalcode del on del.idgeneral=w.isdeleted and del.gctype='DELETE' where w.levelwilayah>0 and w.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID')", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()

        tlData.DataSource = mysqls.dataTable("data")
        tlData.ParentFieldName = "idparent"
        tlData.KeyFieldName = "idwilayah"
        tlData.ExpandAll()
        tlData.BestFitVisibleOnly = True
        tlData.BestFitColumns()

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
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            Dim sqls1 As New SQLs(dbstring)
            sqls1.DMLQuery("select wilayah from wilayah where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and replace(wilayah,' ','')='" & teWilayah.Text.Replace(" ", "") & "'", "exist")
            If sqls1.getDataSet("exist") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teWilayah.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Baru Then
            Dim sqls1 As New SQLs(dbstring)
            sqls1.DMLQuery("select wilayah from wilayah where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and replace(wilayah,' ','')='" & teWilayah.Text.Replace(" ", "") & "' and idwilayah<>'" & idData & "'", "exist")
            If sqls1.getDataSet("exist") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teWilayah.Focus()
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
            field.AddRange(New String() {"idwilayah", "idcompany", "idparent", "levelwilayah", "wilayah", "kodepos", "kodewilayah", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, idcomp, If(lueParent.EditValue, CObj(DBNull.Value)), If(lueLevel.EditValue, CObj(DBNull.Value)), teWilayah.Text, nudKodepos.Value, teKodeWilayah.Text, 0, userid, nowTime})
        Else
            field.AddRange(New String() {"idwilayah", "idcompany", "idparent", "levelwilayah", "wilayah", "kodepos", "kodewilayah", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, idcomp, If(lueParent.EditValue, CObj(DBNull.Value)), If(lueLevel.EditValue, CObj(DBNull.Value)), teWilayah.Text, nudKodepos.Value, teKodeWilayah.Text, userid, nowTime})
        End If
        If dtSQL.datasetSave("wilayah", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "wilayah")

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
            field.AddRange(New String() {"idwilayah", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("wilayah", idData, field, value, False)
            isiLog(userid, dbstring, field, value, "wilayah")
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"idwilayah", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("wilayah", idData, field, value, False)
            isiLog(userid, dbstring, field, value, "wilayah")
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        btnNew_Click(Me, Nothing)
    End Sub

    Private isdeleted As String = ""
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            teWilayah.Text = dcol("wilayah")
            nudKodepos.Value = dcol("kodepos")
            lueLevel.EditValue = dcol("levelwilayah")
            lueParent.EditValue = dcol("idparent")
            isdeleted = dcol("isdeleted")
            idData = dcol("idwilayah")
            statData = statusData.Edit

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

    Private Sub lueLevel_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueLevel.EditValueChanged
        If Not lueLevel.EditValue Is Nothing Then
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select w.idwilayah, isnull(w.wilayah,'-') as induk from wilayah w where w.levelwilayah='" & CInt(lueLevel.EditValue) - 1 & "'", "parent")
            lueParent.Properties.DataSource = mysqls.dataTable("parent")
            lueParent.Properties.ValueMember = "idwilayah"
            lueParent.Properties.DisplayMember = "induk"
        End If
    End Sub

    Private Sub frmWilayah_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        'checkFieldMaxLength(tlpField, "wilayah")
        loadLOV()
        btnNew_Click(Me, Nothing)
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub tlData_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles tlData.FocusedNodeChanged
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.Node.Id)
            teWilayah.Text = dcol("wilayah")
            nudKodepos.Value = dcol("kodepos")
            lueLevel.EditValue = dcol("levelwilayah")
            lueParent.EditValue = dcol("idparent")
            idData = dcol("idwilayah")
            statData = statusData.Edit

            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True

        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

End Class