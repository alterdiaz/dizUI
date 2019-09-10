Imports DevExpress.XtraGrid.Views.Base

Public Class frmRehabMedikICD

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

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        btnBaruICD_Click(Me, Nothing)
    End Sub

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select r.idrehabmedik as id,r.rehabmedik as content from rehabmedik r order by r.rehabmedik asc", "rehab2")
        lueRehabMedik2.Properties.DataSource = mysqls.dataTable("rehab2")
        lueRehabMedik2.Properties.ValueMember = "id"
        lueRehabMedik2.Properties.DisplayMember = "content"
        lueRehabMedik2.EditValue = Nothing
        gcICD.DataSource = Nothing
    End Sub

    Private Sub loadICD(idrehab As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idrehabmedikicd,r.idrehabmedik,i.idicd,i.kode,i.diagnosa,i.remarks from rehabmedikicd r left join icd i on r.idicd=i.idicd and i.icdtype=3 where r.idrehabmedik=3 group by r.idrehabmedikicd,r.idrehabmedik,i.idicd,i.kode,i.diagnosa,i.remarks order by i.kode asc", "icd")
        gcICD.DataSource = sqls.dataTable("icd")
        gvICD.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub lueRehabMedik2_EditValueChanged(sender As Object, e As EventArgs) Handles lueRehabMedik2.EditValueChanged
        If lueRehabMedik2.EditValue Is Nothing Then
            gcICD.DataSource = Nothing
        Else
            loadICD(lueRehabMedik2.EditValue)
        End If
    End Sub


    Private Sub btnSimpanICD_Click(sender As Object, e As EventArgs) Handles btnSimpanICD.Click
        If lueRehabMedik2.EditValue Is Nothing Then
            dizMsgbox("Rehab Medik belum dipilih", dizMsgboxStyle.Info, Me)
            lueRehabMedik2.Focus()
            Exit Sub
        End If
        If lueIICD.EditValue Is Nothing Then
            dizMsgbox("Kode ICD belum dipilih", dizMsgboxStyle.Info, Me)
            lueIICD.Focus()
            Exit Sub
        End If

        Dim idtmp As String = GenerateGUID()
        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idrehabmedikicd", "idrehabmedik", "idicd", "createdby"})
        value.AddRange(New Object() {idtmp, lueRehabMedik2.EditValue, lueIICD.EditValue, userid})
        If dtsqls.datasetSave("rehabmedikicd", idtmp, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "rehabmedikicd")
        End If
    End Sub

    Private Sub btnBaruICD_Click(sender As Object, e As EventArgs) Handles btnBaruICD.Click
        loadLOV()
        gcICD.DataSource = Nothing

        loadLOVICD()

        lueIICD.EditValue = Nothing
        teIDiagnosa.EditValue = Nothing
        teIRemarks.EditValue = Nothing
    End Sub

    Private Sub loadLOVICD()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idicd as id,kode,diagnosa as content from icd where icdtype=3 order by kode asc", "icd")
        lueIICD.Properties.DataSource = sqls.dataTable("icd")
        lueIICD.Properties.ValueMember = "id"
        lueIICD.Properties.DisplayMember = "kode"
        lueIICD.EditValue = Nothing
    End Sub

    Private Sub btnHapusICD_Click(sender As Object, e As EventArgs) Handles btnHapusICD.Click
        Dim sqls As New SQLs(dbstring)
        Dim dcol As DataRow = gvICD.GetDataRow(gvICD.FocusedRowHandle)
        Dim idtmp As String = dcol("idrehabmedikicd")
        If sqls.DMLQuery("delete from rehabmedikicd where idrehabmedikicd='" & idtmp & "'", False) = True Then
            dizMsgbox("Data terhapus", dizMsgboxStyle.Info, Me)
        End If
    End Sub

    Private Sub gvICD_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvICD.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvICD.GetDataRow(e.FocusedRowHandle)
            lueIICD.EditValue = dcol("idicd")

            btnBaruICD.Enabled = True
            btnSimpanICD.Enabled = False
            btnHapusICD.Enabled = True
        Catch ex As Exception
            btnBaruICD_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub lueIICD_EditValueChanged(sender As Object, e As EventArgs) Handles lueIICD.EditValueChanged
        If lueIICD.EditValue Is Nothing Then
            teIDiagnosa.EditValue = Nothing
            teIRemarks.EditValue = Nothing
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select diagnosa,remarks from icd where idicd='" & lueIICD.EditValue & "'", "geticd")
        If sqls.getDataSet("geticd") > 0 Then
            teIDiagnosa.EditValue = sqls.getDataSet("geticd", 0, "diagnosa")
            teIRemarks.EditValue = sqls.getDataSet("geticd", 0, "remarks")
        Else
            teIDiagnosa.EditValue = Nothing
            teIRemarks.EditValue = Nothing
        End If
    End Sub

End Class