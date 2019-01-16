Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTab

Public Class frmRehabMedik
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

    Private Sub loadGrid()
        loadLOV()

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select r.idrehabmedik,r.rehabmedik,r.isdeleted,del.generalcode as statdata from rehabmedik r left join sys_generalcode del on r.isdeleted=del.idgeneral and del.gctype='DELETE' order by r.rehabmedik asc", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadDetil(idrehab As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idrehabmedik,r.rehabmediktype,rty.generalcode as jenis,i.kode,i.diagnosa,i.remarks,r.isdeleted,del.generalcode as statdata from rehabmedikdt r left join sys_generalcode rty on r.rehabmediktype=rty.idgeneral and rty.gctype='REHABMEDIKTYPE' left join sys_generalcode del on r.isdeleted=del.idgeneral and del.gctype='DELETE' left join icd i on r.idicd=i.idicd where r.idrehabmedik='" & idrehab & "' order by rty.generalcode asc,i.diagnosa asc", "detil")
        gcDetil.DataSource = sqls.dataTable("detil")
        gvDetil.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
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

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select r.idrehabmedik as id,r.rehabmedik as content from rehabmedik r order by r.rehabmedik asc", "rehab")
        lueRehab.Properties.DataSource = mysqls.dataTable("rehab")
        lueRehab.Properties.ValueMember = "id"
        lueRehab.Properties.DisplayMember = "content"
        lueRehab.EditValue = Nothing

        mysqls.DMLQuery("select r.idrehabmedik as id,r.rehabmedik as content from rehabmedik r order by r.rehabmedik asc", "rehab2")
        lueRehabMedik2.Properties.DataSource = mysqls.dataTable("rehab2")
        lueRehabMedik2.Properties.ValueMember = "id"
        lueRehabMedik2.Properties.DisplayMember = "content"
        lueRehabMedik2.EditValue = Nothing

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='REHABMEDIKTYPE'", "rehabtype")
        lueType.Properties.DataSource = mysqls.dataTable("rehabtype")
        lueType.Properties.ValueMember = "id"
        lueType.Properties.DisplayMember = "content"
        lueType.EditValue = Nothing

        mysqls.DMLQuery("select i.idicd as id,i.kode,i.diagnosa as content from icd i where i.icdtype=1 order by i.kode asc", "icd1")
        lueICD.Properties.DataSource = mysqls.dataTable("icd1")
        lueICD.Properties.ValueMember = "id"
        lueICD.Properties.DisplayMember = "kode"
        lueICD.EditValue = Nothing
    End Sub

    Private Sub lueRehabMedik2_EditValueChanged(sender As Object, e As EventArgs) Handles lueRehabMedik2.EditValueChanged
        If lueRehabMedik2.EditValue Is Nothing Then
            gcICD.DataSource = Nothing
        Else
            loadICD(lueRehabMedik2.EditValue)
        End If
    End Sub

    Private Sub lueICD_EditValueChanged(sender As Object, e As EventArgs) Handles lueICD.EditValueChanged
        If lueICD.EditValue Is Nothing Then
            teDiagnosa.EditValue = Nothing
            teRemarks.EditValue = Nothing
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select isnull(diagnosa,'-') as diagnosa,isnull(remarks,'-') as remarks from icd where idicd='" & lueICD.EditValue & "'", "geticd")

            teDiagnosa.Text = sqls.getDataSet("geticd", 0, "diagnosa")
            teRemarks.Text = sqls.getDataSet("geticd", 0, "remarks")
        End If
    End Sub

    Private islovrehab As Boolean = False
    Private Sub lueRehab_EditValueChanged(sender As Object, e As EventArgs) Handles lueRehab.EditValueChanged
        islovrehab = True
        If lueRehab.EditValue Is Nothing Then
            gcDetil.DataSource = Nothing
        Else
            loadDetil(lueRehab.EditValue)

            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='REHABMEDIKTYPE'", "rehabtype")
            lueType.Properties.DataSource = mysqls.dataTable("rehabtype")
            lueType.Properties.ValueMember = "id"
            lueType.Properties.DisplayMember = "content"
            lueType.EditValue = Nothing

            mysqls.DMLQuery("select i.idicd as id,i.kode,i.diagnosa as content from icd i where i.icdtype=1 order by i.kode asc", "icd1")
            lueICD.Properties.DataSource = mysqls.dataTable("icd1")
            lueICD.Properties.ValueMember = "id"
            lueICD.Properties.DisplayMember = "content"
            lueICD.EditValue = Nothing

            teDiagnosa.EditValue = Nothing
            teRemarks.EditValue = Nothing
        End If
        islovrehab = False
    End Sub

    Private idrehab As String = -1
    Private Sub btnBaruRehab_Click(sender As Object, e As EventArgs) Handles btnBaruRehab.Click
        loadGrid()
        teRehabMedik.EditValue = Nothing
        idrehab = -1

        btnBaruRehab.Enabled = True
        btnSimpanRehab.Enabled = True
        btnHapusRehab.Enabled = False
    End Sub

    Private Sub btnSimpanRehab_Click(sender As Object, e As EventArgs) Handles btnSimpanRehab.Click
        If idrehab = "-1" Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select idrehabmedik from rehabmedik where replace(rehabmedik,' ','')='" & teRehabMedik.Text.Replace(" ", "") & "'", "cek")
            If sqls.getDataSet("cek") > 0 Then
                dizMsgbox("Rehab Medik tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teRehabMedik.Focus()
                Exit Sub
            Else
                idrehab = GenerateGUID()
                Dim val As New List(Of Object)
                val.AddRange(New Object() {idrehab, teRehabMedik.Text, userid})
                Dim col As New List(Of String)
                col.AddRange(New String() {"idrehabmedik", "rehabmedik", "createdby"})
                Dim dtSQL As New dtsetSQLS(dbstring)

                If dtSQL.datasetSave("rehabmedik", idrehab, col, val, False) = True Then
                    dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
                    isiLog(userid, dbstring, col, val, "rehabmedik")

                    btnBaruRehab_Click(Me, Nothing)
                End If
            End If
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select idrehabmedik from rehabmedik where idrehabmedik<>'" & idrehab & "' and replace(rehabmedik,' ','')='" & teRehabMedik.Text.Replace(" ", "") & "'", "cek")
            If sqls.getDataSet("cek") > 0 Then
                dizMsgbox("Rehab Medik tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teRehabMedik.Focus()
                Exit Sub
            Else
                Dim val As New List(Of Object)
                val.AddRange(New Object() {idrehab, teRehabMedik.Text, userid, nowTime})
                Dim col As New List(Of String)
                col.AddRange(New String() {"idrehabmedik", "rehabmedik", "updatedby", "updateddate"})
                Dim dtsql As New dtsetSQLS(dbstring)

                If dtsql.datasetSave("rehabmedik", idrehab, col, val, False) = True Then
                    dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
                    isiLog(userid, dbstring, col, val, "rehabmedik")

                    btnBaruRehab_Click(Me, Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub btnHapusRehab_Click(sender As Object, e As EventArgs) Handles btnHapusRehab.Click
        Dim retval As Boolean = False
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnHapusRehab.Text = "HAPUS" Then
            field.AddRange(New String() {"idrehabmedik", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idrehab, 1, userid, nowTime})
            retval = sqls.datasetSave("rehabmedik", idrehab, field, value, False)
            If retval Then
                btnHapusRehab.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"idrehabmedik", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idrehab, 0, userid, nowTime})
            retval = sqls.datasetSave("rehabmedik", idrehab, field, value, False)
            If retval Then
                btnHapusRehab.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "rehabmedik")
        btnHapusRehab_Click(Me, Nothing)
    End Sub

    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            teRehabMedik.Text = dcol("rehabmedik")
            idrehab = dcol("idrehabmedik")

            Dim isdeleted As Integer = dcol("isdeleted")
            If isdeleted = 1 Then
                btnHapusRehab.Text = "AKTIF"
            Else
                btnHapusRehab.Text = "HAPUS"
            End If

            btnBaruRehab.Enabled = True
            btnSimpanRehab.Enabled = True
            btnHapusRehab.Enabled = True
        Catch ex As Exception
            btnBaruRehab_Click(Me, Nothing)
        End Try
    End Sub

    Private iddetil As String = -1
    Private Sub btnBaruDetil_Click(sender As Object, e As EventArgs) Handles btnBaruDetil.Click
        loadDetil(0)

        lueRehab.EditValue = Nothing
        lueICD.EditValue = Nothing
        lueType.EditValue = Nothing
        teDiagnosa.EditValue = Nothing
        teRemarks.EditValue = Nothing
        iddetil = -1

        btnSimpanDetil.Enabled = True
        btnHapusDetil.Enabled = False
        btnHapusDetil.Text = "HAPUS"
    End Sub

    Private Sub btnSimpandetil_Click(sender As Object, e As EventArgs) Handles btnSimpanDetil.Click
        If iddetil = "-1" Then
            If lueRehab.EditValue Is Nothing Then
                dizMsgbox("Rehab Medik belum dipilih", dizMsgboxStyle.Info, Me)
                lueRehab.Focus()
                Exit Sub
            End If
            If lueType.EditValue Is Nothing Then
                dizMsgbox("Jenis belum dipilih", dizMsgboxStyle.Info, Me)
                lueType.Focus()
                Exit Sub
            End If
            If lueICD.EditValue Is Nothing Then
                dizMsgbox("Kode ICD belum dipilih", dizMsgboxStyle.Info, Me)
                lueICD.Focus()
                Exit Sub
            End If

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select idrehabmedik from rehabmedikdt where rehabmediktype='" & lueType.EditValue & "' and idicd='" & lueICD.EditValue & "' and idrehabmedik='" & lueRehab.EditValue & "'", "cek")
            If sqls.getDataSet("cek") > 0 Then
                dizMsgbox("Rehab Medik tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teRehabMedik.Focus()
                Exit Sub
            Else
                Dim idtmp As String = GenerateGUID()
                Dim val As New List(Of Object)
                val.AddRange(New Object() {idtmp, lueRehab.EditValue, lueType.EditValue, lueICD.EditValue, userid})
                Dim col As New List(Of String)
                col.AddRange(New String() {"idrehabmedikdt", "idrehabmedik", "rehabmediktype", "idicd", "createdby"})
                Dim dtSQL As New dtsetSQLS(dbstring)

                If dtSQL.datasetSave("rehabmedikdt", idtmp, col, val, False) = True Then
                    dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
                    isiLog(userid, dbstring, col, val, "rehabmedikdt")

                    btnBaruDetil_Click(Me, Nothing)
                End If
            End If
        Else
            If lueRehab.EditValue Is Nothing Then
                dizMsgbox("Rehab Medik belum dipilih", dizMsgboxStyle.Info, Me)
                lueRehab.Focus()
                Exit Sub
            End If
            If lueType.EditValue Is Nothing Then
                dizMsgbox("Jenis belum dipilih", dizMsgboxStyle.Info, Me)
                lueType.Focus()
                Exit Sub
            End If
            If lueICD.EditValue Is Nothing Then
                dizMsgbox("Kode ICD belum dipilih", dizMsgboxStyle.Info, Me)
                lueICD.Focus()
                Exit Sub
            End If

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select idrehabmedik from rehabmedikdt where idrehabmedikdt<>'" & iddetil & "' rehabmediktype='" & lueType.EditValue & "' and idicd='" & lueICD.EditValue & "' and idrehabmedik='" & lueRehab.EditValue & "'", "cek")
            If sqls.getDataSet("cek") > 0 Then
                dizMsgbox("Rehab Medik tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teRehabMedik.Focus()
                Exit Sub
            Else
                Dim val As New List(Of Object)
                val.AddRange(New Object() {iddetil, lueRehab.EditValue, lueType.EditValue, lueICD.EditValue, userid, nowTime})
                Dim col As New List(Of String)
                col.AddRange(New String() {"idrehabmedikdt", "idrehabmedik", "rehabmediktype", "idicd", "updatedby", "updateddate"})
                Dim dtsql As New dtsetSQLS(dbstring)

                If dtsql.datasetSave("rehabmedikdt", idrehab, col, val, False) = True Then
                    dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
                    isiLog(userid, dbstring, col, val, "rehabmedikdt")

                    btnBaruDetil_Click(Me, Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub btnHapusDetil_Click(sender As Object, e As EventArgs) Handles btnHapusDetil.Click
        Dim retval As Boolean = False
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnHapusDetil.Text = "HAPUS" Then
            field.AddRange(New String() {"idrehabmedikdt", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {iddetil, 1, userid, nowTime})
            retval = sqls.datasetSave("rehabmedikdt", idrehab, field, value, False)
            If retval Then
                btnHapusDetil.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"idrehabmedikdt", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {iddetil, 0, userid, nowTime})
            retval = sqls.datasetSave("rehabmedikdt", idrehab, field, value, False)
            If retval Then
                btnHapusDetil.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "rehabmedikdt")
        btnBaruDetil_Click(Me, Nothing)
    End Sub

    Private Sub gvDetil_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvDetil.FocusedRowChanged
        If islovrehab = True Then Exit Sub
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            lueType.EditValue = dcol("rehabmediktype")
            lueICD.EditValue = dcol("idicd")
            iddetil = dcol("idrehabmedikdt")

            Dim isdeleted As Integer = dcol("isdeleted")
            If isdeleted = 1 Then
                btnHapusDetil.Text = "AKTIF"
            Else
                btnHapusDetil.Text = "HAPUS"
            End If

            btnBaruDetil.Enabled = True
            btnSimpanDetil.Enabled = True
            btnHapusDetil.Enabled = True
        Catch ex As Exception
            btnBaruDetil_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub frmRehabMedik_Load(sender As Object, e As EventArgs) Handles Me.Load
        xtcRehab.SelectedTabPage = xtpRehab
        btnBaruRehab_Click(Me, Nothing)
    End Sub

    Private Sub xtcRehab_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles xtcRehab.SelectedPageChanged
        If xtcRehab.SelectedTabPage Is xtpRehab Then
            btnBaruRehab_Click(Me, Nothing)
        ElseIf xtcRehab.SelectedTabPage Is xtpRehabDT Then
            btnBaruDetil_Click(Me, Nothing)
        ElseIf xtcRehab.SelectedTabPage Is xtpRehabICD Then
            lueRehabMedik2.EditValue = Nothing
            gcICD.DataSource = Nothing
        End If
    End Sub

    'Private dttbl As New DataTable

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

        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim idtmp As String = GenerateGUID()
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
        Dim dcol As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
        Dim idtmp As String = dcol("idrehabmedikicd")
        If sqls.DMLQuery("delete from rehabmedikicd where idrehabmedikicd='" & idtmp & "'", False) = True Then
            dizMsgbox("Data terhapus", dizMsgboxStyle.Info, Me)
        End If
    End Sub

    Private Sub gvICD_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvICD.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
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