Public Class frmNotes

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
        Me.Dispose()
    End Sub

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISNOTE' order by idgeneral asc", "notetype")
        lueNotes.Properties.DataSource = sqls.dataTable("notetype")
        lueNotes.Properties.ValueMember = "id"
        lueNotes.Properties.DisplayMember = "content"
        lueNotes.EditValue = Nothing
    End Sub

    Private Sub loadLIST()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idusernotes,title,convert(varchar,createddate,105) +' ' + convert(varchar,createddate,108) as createddate,isdeleted,isnote from sys_usernotes where iduser='" & userid & "' order by isdeleted asc,isnote desc,createddate desc", "getlist")

        Me.TableLayoutPanel2.RowCount = 0
        Me.TableLayoutPanel2.RowStyles.Clear()
        Me.TableLayoutPanel2.Controls.Clear()

        Me.TableLayoutPanel2.RowCount = 0
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0.0!))
        Dim counter As Integer = 0

        For i As Integer = 0 To sqls.getDataSet("getlist") - 1
            Dim id As String = sqls.getDataSet("getlist", i, "idusernotes")
            Dim ttl As String = sqls.getDataSet("getlist", i, "title")
            Dim cdat As String = sqls.getDataSet("getlist", i, "createddate")
            Dim isdel As String = sqls.getDataSet("getlist", i, "isdeleted")
            Dim isnote As String = sqls.getDataSet("getlist", i, "isnote")

            Dim btnobj As New ucNotes(id, ttl, cdat, isdel, isnote)
            btnobj.Name = "btnNotes" & i
            btnobj.Dock = DockStyle.None
            btnObj.Anchor = AnchorStyles.None
            AddHandler btnobj.btnNotes.Click, AddressOf buttonClick

            Me.TableLayoutPanel2.RowCount = counter + 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
            Me.TableLayoutPanel2.Controls.Add(btnObj, 1, counter + 1)
            counter += 1
        Next

        Me.TableLayoutPanel2.RowCount = counter
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(260, (counter * 70) + 0)

    End Sub

    Private Sub buttonClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim sqls As New SQLs(dbstring)
        idData = sender.tag
        statData = statusData.Edit

        sqls.DMLQuery("select title,notes,isdeleted,isnote,convert(varchar,createddate,105) + ' ' + convert(varchar,createddate,108) as createddate,convert(varchar,updateddate,105) + ' ' + convert(varchar,updateddate,108) as updateddate,convert(varchar,warningdate,105) + ' ' + convert(varchar,warningdate,108) as warningdate from sys_usernotes where idusernotes='" & idData & "'", "getnotes")
        teTitle.Text = sqls.getDataSet("getnotes", 0, "title")
        teCreatedDate.Text = sqls.getDataSet("getnotes", 0, "createddate")
        teUpdatedDate.Text = IIf(IsDBNull(sqls.getDataSet("getnotes", 0, "updateddate")), Format(nowTime, "dd-MM-yyyy HH:mm:ss"), sqls.getDataSet("getnotes", 0, "updateddate"))
        Dim warndate As String = IIf(IsDBNull(sqls.getDataSet("getnotes", 0, "warningdate")), "", sqls.getDataSet("getnotes", 0, "warningdate"))
        Dim warntgl As String
        Dim warnjam As String
        If warndate <> "" Then
            warntgl = warndate.Split(" ")(0)
            warnjam = warndate.Split(" ")(1)
            deWarning.EditValue = Strdatetime2Datetime(warntgl & " " & warnjam)
        Else
            deWarning.EditValue = Nothing
        End If
        lueNotes.EditValue = sqls.getDataSet("getnotes", 0, "isnote")
        meNotes.Text = sqls.getDataSet("getnotes", 0, "notes")
        Dim isdeleted As String = sqls.getDataSet("getnotes", 0, "isdeleted")
        If isdeleted = 0 Then
            btnDelete.Text = "HAPUS"
        ElseIf isdeleted = 1 Then
            btnDelete.Text = "AKTIF"
        End If
        btnDelete.Enabled = True
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        modCore.kosongkanIsian(pTitleNote)
        modCore.kosongkanIsian(pEntryNote)
        btnDelete.Text = "HAPUS"
        btnDelete.Enabled = False
        lueNotes.EditValue = Nothing
        teTitle.EditValue = Nothing
        teCreatedDate.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teUpdatedDate.EditValue = Nothing
        deWarning.EditValue = Nothing
        statData = statusData.Baru
        idData = "-1"
    End Sub

    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkFieldMaxLength(dbstring, pTitleNote, "sys_usernotes")
        checkFieldMaxLength(dbstring, pEntryNote, "sys_usernotes")

        loadLOV()
        loadLIST()

        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim iskosong As Boolean = False
        If checkEntry(pTitleNote) = False Then
            iskosong = True
        End If
        If checkEntry(pEntryNote) = False Then
            iskosong = True
        End If
        If teTitle.EditValue Is Nothing Then
            iskosong = True
        End If
        If lueNotes.EditValue Is Nothing Then
            iskosong = True
        End If
        If deWarning.EditValue IsNot Nothing Then
            If CDate(deWarning.EditValue) < nowTime Then
                dizMsgbox("Tanggal Warning belum benar", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
        End If
        If iskosong = True Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)
        If statData = statusData.Baru Then
            idData = GenerateGUID()
            If deWarning.EditValue Is Nothing Then
                field.AddRange(New String() {"idusernotes", "iduser", "title", "notes", "isnote", "isdeleted", "createddate"})
                value.AddRange(New Object() {idData, userid, teTitle.Text, meNotes.Text, lueNotes.EditValue, 0, nowTime})
            Else
                field.AddRange(New String() {"idusernotes", "iduser", "title", "notes", "isnote", "isdeleted", "createddate", "warningdate"})
                value.AddRange(New Object() {idData, userid, teTitle.Text, meNotes.Text, lueNotes.EditValue, 0, nowTime, CDate(deWarning.EditValue)})
            End If
        Else
            If deWarning.EditValue Is Nothing Then
                field.AddRange(New String() {"idusernotes", "title", "notes", "isnote", "updateddate"})
                value.AddRange(New Object() {idData, teTitle.Text, meNotes.Text, lueNotes.EditValue, nowTime})
            Else
                field.AddRange(New String() {"idusernotes", "title", "notes", "isnote", "updateddate", "warningdate"})
                value.AddRange(New Object() {idData, teTitle.Text, meNotes.Text, lueNotes.EditValue, nowTime, CDate(deWarning.EditValue)})
            End If
        End If
        dtsqls.datasetSave("sys_usernotes", idData, field, value, False)

        field = New List(Of String)
        value = New List(Of Object)
        dtsqls = New dtsetSQLS(dbstring)
        Dim idnotif As String = GenerateGUID()
        field.AddRange(New String() {"idnotifications", "kode", "judul", "konten", "frmname", "tableid", "tablename", "tablecolumnid", "tablecolumndate", "tablecolumnflag", "tablecolumniduser", "duedate", "iduser", "iduserlevel"})
        value.AddRange(New Object() {idnotif, "NOTE", "PENGINGAT NOTE", teTitle.Text, "-", idData, "sys_usernotes", "idusernotes", "completedate", "iscomplete", "-", CDate(deWarning.EditValue), userid, userlevelid})
        dtsqls.datasetSave("sys_notifications", idnotif, field, value, False)

        dizMsgbox("Catatan telah disimpan", dizMsgboxStyle.Info, Me)
        btnNew_Click(btnNew, Nothing)
        loadLIST()
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idusernotes", "isdeleted", "updateddate"})
        If btnDelete.Text = "HAPUS" Then
            value.AddRange(New Object() {idData, 1, nowTime})
            btnDelete.Text = "AKTIF"
        ElseIf btnDelete.Text = "AKTIF" Then
            value.AddRange(New Object() {idData, 0, nowTime})
            btnDelete.Text = "HAPUS"
        End If
        dtsqls.datasetSave("sys_usernotes", idData, field, value, False)
        dizMsgbox("Catatan telah disimpan", dizMsgboxStyle.Info, Me)
        loadLIST()

        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub btnClearWarningDate_Click(sender As Object, e As EventArgs) Handles btnClearWarningDate.Click
        deWarning.EditValue = Nothing
    End Sub

End Class