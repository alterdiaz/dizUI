Public Class frmAnggaran
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
        mysqls.DMLQuery("select idcoa,coa,remarks from coa where len(convert(decimal(20,0),COA))>=3 and (isnull(isdeleted,0)=0 or coa<>'-1') order by convert(varchar(20),COA) asc", "coa")
        slueCOA.Properties.DataSource = mysqls.dataTable("coa")
        slueCOA.Properties.DisplayMember = "coa"
        slueCOA.Properties.ValueMember = "idcoa"
        slueCOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        mysqls.DMLQuery("select idgeneral as idjenis,generalcode as jenis from sys_generalcode where gctype='ANGGARAN' ", "angg")
        lueJenis.Properties.DataSource = mysqls.dataTable("angg")
        lueJenis.Properties.DisplayMember = "jenis"
        lueJenis.Properties.ValueMember = "idjenis"
    End Sub

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select a.idanggaran,a.idcoa,a.isdeleted,c.coa,c.remarks,a.anggarantype,tp.generalcode as jenis,a.periode,a.jumlahuang,del.generalcode as statdata from anggaran a left join coa c on a.idcoa=c.idcoa left join sys_generalcode tp on a.anggarantype=tp.idgeneral and tp.gctype='ANGGARAN' left join sys_generalcode del on del.idgeneral=a.isdeleted and del.gctype='DELETE' where a.periode like '" & nowTime.Year & "%' order by a.periode desc", "data")

        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()
        slueCOA.Enabled = True
        slueCOA.Properties.ReadOnly = False
        slueCOA.BackColor = canWrite
        slueCOA.ForeColor = Color.Black

        kosongkanIsian(tlpField)
        idData = "-1"
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        statData = statusData.Baru

        dePeriode.Properties.MinValue = New Date(nowTime.Year, 1, 1)
        dePeriode.Properties.MaxValue = New Date(nowTime.Year, 12, 31)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cekentry As Boolean = True
        If slueCOA.EditValue Is Nothing Then
            cekentry = False
        End If
        If lueJenis.EditValue Is Nothing Then
            cekentry = False
        End If
        If nudJumlahUang.Value = 0 Then
            cekentry = False
        End If
        If dePeriode.EditValue Is Nothing Then
            cekentry = False
        End If
        If cekentry = False Then
            dizmsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select a.anggarantype from anggaran a where a.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and (idcoa='" & slueCOA.EditValue & "' and len(periode)=4 and periode='" & CDate(dePeriode.EditValue).Year & "') or (idcoa='" & slueCOA.EditValue & "' and len(periode)=7 and periode='" & Format(CDate(dePeriode.EditValue), "yyyy-MM") & "') order by a.periode desc", "exist")
            If sqls.getDataSet("exist") = 0 Then
                idData = GenerateGUID()
            Else
                dizmsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                slueCOA.Focus()
                Exit Sub
            End If
        End If
        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If statData = statusData.Baru Then
            field.AddRange(New String() {"idanggaran", "idcompany", "idcoa", "anggarantype", "jumlahuang", "periode", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, idcomp, slueCOA.EditValue, lueJenis.EditValue, nudJumlahUang.Value, dePeriode.Text, 0, userid, nowTime})
        Else
            field.AddRange(New String() {"idanggaran", "idcoa", "anggarantype", "jumlahuang", "periode", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, slueCOA.EditValue, lueJenis.EditValue, nudJumlahUang.Value, dePeriode.Text, userid, nowTime})
        End If
        If dtSQL.datasetSave("anggaran", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "anggaran")

            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim retval As Boolean = False
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"idanggaran", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("anggaran", idData, field, value, False)
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"idanggaran", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("anggaran", idData, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "anggaran")
        btnNew_Click(Me, Nothing)
    End Sub

    Private isdeleted As String = ""
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            slueCOA.Enabled = False
            slueCOA.Properties.ReadOnly = True
            slueCOA.BackColor = justRead
            slueCOA.ForeColor = Color.Black

            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            slueCOA.EditValue = dcol("idcoa")
            lueJenis.EditValue = dcol("anggarantype")
            idData = dcol("idanggaran")
            nudJumlahUang.Value = dcol("jumlahuang")
            If dcol("periode").ToString.Length = 4 Then
                dePeriode.EditValue = New DateTime(dcol("periode"), nowTime.Month, nowTime.Day)
            Else
                dePeriode.EditValue = New DateTime(dcol("periode").ToString.Split("-")(0), dcol("periode").ToString.Split("-")(1), nowTime.Day)
            End If
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

    Private Sub frmJabatan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        checkFieldMaxLength(dbstring, tlpField, "anggaran")
        loadLOV()
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub lueJenis_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueJenis.EditValueChanged
        If lueJenis.EditValue = 0 Then
            dePeriode.Properties.DisplayFormat.FormatString = "yyyy-MM"
            dePeriode.Properties.EditFormat.FormatString = "yyyy-MM"
            dePeriode.Properties.Mask.EditMask = "yyyy-MM"
            dePeriode.Properties.EditMask = "yyyy-MM"
        ElseIf lueJenis.EditValue = 1 Then
            dePeriode.Properties.DisplayFormat.FormatString = "yyyy"
            dePeriode.Properties.EditFormat.FormatString = "yyyy"
            dePeriode.Properties.Mask.EditMask = "yyyy"
            dePeriode.Properties.EditMask = "yyyy"
        End If
    End Sub

    Private Sub slueCOA_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slueCOA.EditValueChanged
        If slueCOA.EditValue Is Nothing Then
            teCOA.Text = ""
            Exit Sub
        End If
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select remarks from coa where idcoa='" & slueCOA.EditValue & "'", "selectcoa")
        If mysqls.getDataSet("selectcoa") > 0 Then
            teCOA.Text = mysqls.getDataSet("selectcoa", 0, "remarks")
        Else
            teCOA.Text = ""
        End If
    End Sub

End Class