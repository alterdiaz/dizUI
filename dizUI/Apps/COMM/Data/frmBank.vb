Public Class frmBank
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

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select k.idbank, k.bank, k.norekening, k.remarks, k.isdeleted, del.generalcode as statdata,k.idcoa,isnull(c.coa,'-') as coa,isnull(c.remarks,'-') as rcoa from bank k left join coa c on k.idcoa=c.idcoa left join sys_generalcode del on del.idgeneral=k.isdeleted and del.gctype='DELETE'", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        kosongkanIsian(tlpField)

        teBank.Enabled = True
        teBank.Properties.ReadOnly = False
        teBank.BackColor = canWrite
        teBank.ForeColor = Color.Black
        teRemarks.Enabled = True
        teRemarks.Properties.ReadOnly = False
        teRemarks.BackColor = canWrite
        teRemarks.ForeColor = Color.Black

        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        statData = statusData.Baru
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select bank from bank where replace(bank,' ','')='" & teBank.Text.Replace(" ", "") & "'", "exist")
            If sqls.getDataSet("exist") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teBank.Focus()
                Exit Sub
            End If

            If slueCOA.EditValue IsNot Nothing Then
                sqls.DMLQuery("select bank from bank where idcoa='" & slueCOA.EditValue & "'", "idcoa")
                If sqls.getDataSet("idcoa") = 0 Then
                    idData = "-1"
                Else
                    dizMsgbox("Data Bank dengan COA tersebut sudah ada", dizMsgboxStyle.Info, Me)
                    slueCOA.Focus()
                    Exit Sub
                End If
            End If
        ElseIf statData = statusData.Edit Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select bank from bank where replace(bank,' ','')='" & teBank.Text.Replace(" ", "") & "' and idbank<>'" & idData & "'", "exist")
            If sqls.getDataSet("exist") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teBank.Focus()
                Exit Sub
            End If

            If slueCOA.EditValue IsNot Nothing Then
                sqls.DMLQuery("select bank from bank where idbank<>'" & idData & "' and idcoa='" & slueCOA.EditValue & "'", "idcoa")
                If sqls.getDataSet("idcoa") > 0 Then
                    dizMsgbox("Data Bank dengan COA tersebut sudah ada", dizMsgboxStyle.Info, Me)
                    slueCOA.Focus()
                    Exit Sub
                End If
            End If
        End If

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If idData = "-1" Then
            Dim sqls1 As New SQLs(dbstring)
            sqls1.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqls1.getDataSet("CompID", 0, "value")
            idData = GenerateGUID()

            field.AddRange(New String() {"idbank", "idcompany", "idcoa", "bank", "norekening", "remarks", "isdeleted", "createdby", "createddate"})

            If slueCOA.EditValue Is Nothing Then
                value.AddRange(New Object() {idData, idcomp, DBNull.Value, teBank.Text, teNoRekening.Text, teRemarks.Text, 0, userid, nowTime})
            Else
                value.AddRange(New Object() {idData, idcomp, slueCOA.EditValue, teBank.Text, teNoRekening.Text, teRemarks.Text, 0, userid, nowTime})
            End If
        Else
            field.AddRange(New String() {"idbank", "idcoa", "bank", "norekening", "remarks", "updatedby", "updateddate"})
            If slueCOA.EditValue Is Nothing Then
                value.AddRange(New Object() {idData, "0", teBank.Text, teNoRekening.Text, teRemarks.Text, userid, nowTime})
            Else
                value.AddRange(New Object() {idData, slueCOA.EditValue, teBank.Text, teNoRekening.Text, teRemarks.Text, userid, nowTime})
            End If
        End If

        If dtSQL.datasetSave("bank", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "bank")

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
            field.AddRange(New String() {"idbank", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("bank", idData, field, value, False)

            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"idbank", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("bank", idData, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "bank")
        btnNew_Click(Me, Nothing)
    End Sub

    Private isdeleted As String = ""
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            teBank.Text = dcol("bank")
            teNoRekening.Text = dcol("norekening")
            teRemarks.Text = dcol("remarks")
            slueCOA.EditValue = dcol("idcoa")
            idData = dcol("idbank")
            statData = statusData.Edit
            isdeleted = dcol("isdeleted")
            If isdeleted = "1" Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If

            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            If dcol("bank") = "KAS" Then
                teBank.Enabled = False
                teBank.Properties.ReadOnly = True
                teBank.BackColor = justRead
                teBank.ForeColor = Color.Black

                teRemarks.Enabled = False
                teRemarks.Properties.ReadOnly = True
                teRemarks.BackColor = justRead
                teRemarks.ForeColor = Color.Black

                btnDelete.Enabled = False
            Else
                teBank.Enabled = True
                teBank.Properties.ReadOnly = False
                teBank.BackColor = canWrite

                teRemarks.Enabled = True
                teRemarks.Properties.ReadOnly = False
                teRemarks.BackColor = canWrite

                btnDelete.Enabled = True
            End If
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub frmJabatan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idcoa, coa, remarks from coa where len(convert(decimal(20,0),COA))>=3 and (isnull(isdeleted,0)=0 or coa<>'-1') order by convert(varchar(20),COA) asc", "coa")
        slueCOA.Properties.DataSource = sqls.dataTable("coa")
        slueCOA.Properties.DisplayMember = "coa"
        slueCOA.Properties.ValueMember = "idcoa"
        slueCOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        checkFieldMaxLength(dbstring, tlpField, "bank")
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub btnClearCOA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearCOA.Click
        slueCOA.EditValue = Nothing
    End Sub

End Class