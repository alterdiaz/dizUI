Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup

Public Class frmMemo
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        bClose = False
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

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        isReadOnly = False
        xtccMemo.SelectedTabPage = xtpMemo

        teNoMemo.ReadOnly = False
        lueJenisMemo.ReadOnly = False
        teJudulMemo.ReadOnly = False
        meMemo.ReadOnly = False

        teNoMemo.EditValue = Nothing
        lueJenisMemo.EditValue = Nothing
        teJudulMemo.EditValue = Nothing
        meMemo.EditValue = Nothing
        clbcUser.Enabled = True

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select f.idfiles,f.filename,'' as filepath,f.fileextension,convert(varchar,f.createddate,105)+' '+convert(varchar,f.createddate,108) as createddate from sys_files f left join sys_memofiles mf on mf.idfiles=f.idfiles left join sys_memo m on m.idmemo=mf.idmemo where 1=0", "file")
        dtfiles = sqls.dataSet
        gcData.DataSource = dtfiles.Tables("file")
        btnBrowse.Enabled = True
        btnBrowse.Visible = True

        gcKomentar.DataSource = Nothing
        clbcForward.Enabled = False
        pKomentar.Enabled = False
        lueMessage.EditValue = Nothing
        lueMessage.Enabled = False
        meMessage.Enabled = False
        meMessage.EditValue = Nothing
        pKomentarBottom.Enabled = False
        ceSendType.Enabled = False
        ceSendType.CheckState = CheckState.Unchecked
        ceQuick.Enabled = False
        ceQuick.CheckState = CheckState.Unchecked
        btnSend.Enabled = False

        clbcUser.Visible = False
        clbcForward.Visible = False
        pKomentar.Visible = False

        idd = -1

        clbcUser.UnCheckAll()
        clbcForward.UnCheckAll()
        For b As Integer = 0 To clbcUser.ItemCount - 1
            clbcUser.SetItemChecked(b, False)
        Next
        For b As Integer = 0 To clbcForward.ItemCount - 1
            clbcForward.SetItemChecked(b, False)
        Next
        For Each ctrl As Control In tlpList.Controls
            For Each ctrl1 As Control In ctrl.Controls
                If CType(ctrl1, System.Windows.Forms.Button).Enabled = True Then
                    CType(ctrl1, System.Windows.Forms.Button).FlatAppearance.BorderColor = Color.FromArgb(246, 139, 31)
                    CType(ctrl1, System.Windows.Forms.Button).BackColor = Color.GreenYellow
                Else
                    CType(ctrl1, System.Windows.Forms.Button).FlatAppearance.BorderColor = Color.FromArgb(246, 139, 31)
                    CType(ctrl1, System.Windows.Forms.Button).BackColor = Color.Gray
                End If
            Next
        Next
        btnBrowse.Text = "TAMBAH FILE"
    End Sub

    Private Sub frmMemo_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        checkFieldMaxLength(dbstring, pMessage, "sys_memo")
        checkFieldMaxLength(dbstring, tlpHeader1, "sys_memo")
        checkFieldMaxLength(dbstring, tlpHeader2, "sys_memo")

        loadButton()
        loadLOV()
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='MEMOTYPE' order by generalcode asc", "mt")
        lueJenisMemo.Properties.DataSource = sqls.dataTable("mt")
        lueJenisMemo.Properties.ValueMember = "id"
        lueJenisMemo.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISIMEMO' order by idgeneral asc", "im")
        lueMessage.Properties.DataSource = sqls.dataTable("im")
        lueMessage.Properties.ValueMember = "id"
        lueMessage.Properties.DisplayMember = "content"

        sqls.DMLQuery("select iduser as id,namalengkap as content from sys_user where isuseronline=0 order by namalengkap asc", "user")
        clbcUser.DataSource = sqls.dataTable("user")
        clbcUser.DisplayMember = "content"
        clbcUser.ValueMember = "id"
        clbcUser.UnCheckAll()

        sqls.DMLQuery("select iduser as id,namalengkap as content from sys_user where isuseronline=0 order by namalengkap asc", "frwrd")
        clbcForward.DataSource = sqls.dataTable("frwrd")
        clbcForward.DisplayMember = "content"
        clbcForward.ValueMember = "id"
        clbcForward.UnCheckAll()
    End Sub

    Private dtfiles As New DataSet
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If btnBrowse.Text = "TAMBAH FILE" Then
            Dim opendlg As New OpenFileDialog
            opendlg.Title = "Pilih file"
            opendlg.InitialDirectory = Environment.SpecialFolder.MyComputer
            opendlg.Multiselect = True
            opendlg.Filter = "Office Files|*.rtf;*.docx;*.doc;*.xlsx;*.xls;*.pptx;*.ppt;*.vsd;*.vsdx|PDF Files|*.pdf|Text Files|*.txt|Images Files|*.jpg;*.png;*.gif;*.jpeg"

            If opendlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim newfiles() As String = opendlg.FileNames
                For i As Integer = 0 To newfiles.Length - 1
                    Dim dr As DataRow = dtfiles.Tables("file").NewRow
                    dr("idfiles") = -1
                    dr("filepath") = newfiles(i)
                    dr("filename") = IO.Path.GetFileNameWithoutExtension(newfiles(i))
                    dr("fileextension") = IO.Path.GetExtension(newfiles(i))
                    dr("createddate") = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
                    dtfiles.Tables("file").Rows.Add(dr)

                    gcData.DataSource = dtfiles.Tables("file")
                    gvData.BestFitColumns()
                Next
            End If
        ElseIf btnBrowse.Text = "LIHAT FILE" Then
            If gvData.RowCount = 0 Then
                dizMsgbox("File tidak ditemukan", dizMsgboxStyle.Info, me)
                Exit Sub
            End If
            If gvData.FocusedRowHandle < 0 Then
                dizMsgbox("File belum dipilih", dizMsgboxStyle.Info, me)
                Exit Sub
            End If
            Dim dr As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
            Dim idfile As String = dr("idfiles")
            Dim sqls As New SQLs(dbstring)
            sqls.getFile("sys_files", "filebinary", idfile, "idfiles")
            Dim filedata As Byte() = sqls.getFileByte
            Dim filepath As String = pathTemp & Format(nowTime, "ddMMyyyyHHmmssff") & "-" & dr("filename") & dr("fileextension")
            If Not filedata Is Nothing Then
                Dim ms As New System.IO.MemoryStream(filedata, 0, filedata.Length)
                ms.Write(filedata, 0, filedata.Length)
                Dim file As New System.IO.FileStream(filepath, System.IO.FileMode.Create, System.IO.FileAccess.Write)
                ms.WriteTo(file)
                file.Close()
                ms.Close()

                Diagnostics.Process.Start(filepath)
            End If
        End If
    End Sub

    Private idd As String = -1
    Private imgByteArray As Byte() = Nothing
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim bcek As Boolean = True
        If teJudulMemo.Text = "" Then
            bcek = False
        End If
        If teNoMemo.Text = "" Then
            bcek = False
        End If
        If lueJenisMemo.EditValue Is Nothing Then
            bcek = False
        End If
        If meMemo.Text = "" Then
            bcek = False
        End If
        If clbcForward.SelectedItems.Count = 0 Then
            bcek = False
        End If
        If gvData.RowCount = 0 Then
            bcek = False
        End If
        If pKomentar.Visible = True Then
            If meMessage.Text = "" Then
                bcek = False
            End If
        End If
        If bcek = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("Select memono from sys_memo where replace(memono,' ','')='" & teNoMemo.Text.Replace(" ", "") & "' and createdby='" & userid & "'", "cekexist")
        If sqls.getDataSet("cekexist") > 0 Then
            dizMsgbox("Nomor Memo tersebut sudah ada", dizMsgboxStyle.Info, Me)
            teNoMemo.Focus()
            Exit Sub
        End If
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim idfiles As String = -1
        Dim retval As Boolean = False
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsql As New dtsetSQLS(dbstring)
        idd = GenerateGUID()
        field.AddRange(New String() {"idmemo", "memono", "memotype", "judul", "konten", "isdeleted", "createdby", "createddate"})
        value.AddRange(New Object() {idd, teNoMemo.Text, lueJenisMemo.EditValue, teJudulMemo.Text, meMemo.Text, 0, userid, nowTime})
        dtsql.datasetSave("sys_memo", idd, field, value, False)

        field.Clear()
        value.Clear()
        Dim fieldfile As New List(Of String)
        Dim valuefile As New List(Of Object)

        field.AddRange(New String() {"idmemofiles", "idmemo", "idfiles", "isdeleted", "createdby", "createddate"})
        fieldfile.AddRange(New String() {"idfiles", "filename", "fileextension", "filebinary", "createddate"})
        For Each dr As DataRow In dtfiles.Tables("file").Rows
            Try
                idfiles = GenerateGUID()
                sqls = New SQLs(dbstring)
                dtsql = New dtsetSQLS(dbstring)
                value = New List(Of Object)
                imgByteArray = Nothing
                imgByteArray = IO.File.ReadAllBytes(dr("filepath"))

                valuefile.AddRange(New Object() {idfiles, dr("filename"), dr("fileextension"), imgByteArray, nowTime})
                retval = dtsql.datasetSave("sys_Files", idfiles, fieldfile, valuefile, False)

                Dim idtmp As String = GenerateGUID()
                value.AddRange(New Object() {idtmp, idd, idfiles, 0, userid, nowTime})
                retval = dtsql.datasetSave("sys_MemoFiles", idtmp, field, value, False)

                Threading.Thread.Sleep(100)
                GC.Collect()
            Catch ex As Exception
            End Try
        Next
        field.Clear()
        value.Clear()
        field.AddRange(New String() {"idmemopermission", "idmemo", "iduser", "isview", "isdeleted", "createdby", "createddate"})
        For i As Integer = 0 To clbcUser.CheckedItemsCount - 1
            Dim idtmp As String = GenerateGUID()
            value = New List(Of Object)
            value.AddRange(New Object() {idtmp, idd, clbcUser.CheckedItems(i), 0, 0, userid, nowTime})
            dtsql = New dtsetSQLS(dbstring)
            retval = dtsql.datasetSave("sys_memopermission", idtmp, field, value, False)
        Next
        Me.Cursor = Cursors.Default
        splashClosed = True

        If retval = True Then
            dizMsgbox("Memo telah tersimpan", dizMsgboxStyle.Info, Me)
            loadButton()
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Private Sub loadButton()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select m.idmemo,m.memono,m.judul,m.memotype,isnull(count(mc.idmemocomment),0) as counter,m.isdeleted from sys_memo m left join sys_memocomment mc on m.idmemo=mc.idmemo where m.idmemo in (select distinct a.id from (select m.idmemo as id,m.createdby as uid from sys_memo m where m.createdby='" & userid & "' union all select mp.idmemo as id,mp.iduser as uid from sys_memopermission mp where mp.iduser='" & userid & "' union all select mc.idmemo as id,mc.forwardto as uid from sys_memocomment mc where mc.forwardto='" & userid & "') a) group by m.idmemo,m.memono,m.judul,m.memotype,m.isdeleted order by isnull(count(mc.idmemocomment),0) desc", "memo")
        Dim counter As Integer = 0
        Me.tlpList.RowCount = 0
        Me.tlpList.RowStyles.Clear()
        Me.tlpList.Controls.Clear()
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))

        For i As Integer = 0 To sqls.getDataSet("memo") - 1
            Me.tlpList.SuspendLayout()
            Dim tmp As String = sqls.getDataSet("memo", i, "judul")

            Dim btnObj As New ucMemo
            btnObj.Name = "btnMemo" & i
            btnObj.isdeleted = sqls.getDataSet("memo", i, "isdeleted")
            btnObj.id = sqls.getDataSet("memo", i, "idmemo")
            If tmp.Length > 20 Then
                tmp = tmp.Remove(21) & "..."
            End If
            btnObj.str = "No. " & sqls.getDataSet("memo", i, "memono") &
                vbCrLf & tmp &
                vbCrLf & sqls.getDataSet("memo", i, "counter") & " komentar"
            btnObj.jenis = sqls.getDataSet("memo", i, "memotype")
            btnObj.Dock = DockStyle.None
            btnObj.Anchor = AnchorStyles.None
            AddHandler btnObj.btnMemo.Click, AddressOf buttonClick
            btnObj.buildObj()

            Me.tlpList.RowCount = counter + 1
            Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
            Me.tlpList.Controls.Add(btnObj, 1, counter + 1)
            Me.tlpList.Size = New System.Drawing.Size(385, (counter * 70) + 10)
            counter += 1

            Me.tlpList.ResumeLayout()
        Next

        Me.tlpList.RowCount = counter
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpList.Size = New System.Drawing.Size(385, (counter * 70) + 10)

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub buttonClick(ByVal sender As Object, ByVal e As System.EventArgs)
        idd = sender.tag
        xtccMemo.SelectedTabPage = xtpMemo
        isReadOnly = False
        clbcUser.UnCheckAll()
        clbcForward.UnCheckAll()
        For b As Integer = 0 To clbcUser.ItemCount - 1
            clbcUser.SetItemChecked(b, False)
        Next
        For b As Integer = 0 To clbcForward.ItemCount - 1
            clbcForward.SetItemChecked(b, False)
        Next

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select memono,memotype,judul,konten from sys_memo where idmemo='" & sender.tag & "'", "getmemo")
        sqls.DMLQuery("select mf.idfiles,f.filename,f.fileextension,convert(varchar,mf.createddate,105) +' '+convert(varchar,mf.createddate,108) as createddate from sys_memofiles mf left join sys_files f on mf.idfiles=f.idfiles where mf.idmemo='" & sender.tag & "'", "getmemofiles")
        sqls.DMLQuery("select mc.idmemocomment,'* '+ isnull(su.namalengkap,'') + CHAR(13)+CHAR(10) + mc.memocomment + CHAR(13)+CHAR(10) + isnull(convert(varchar,mc.forwarddate,105)+' '+convert(varchar,mc.forwarddate,108),'belum dilihat') as komentar,convert(varchar,mc.createddate,105)+' '+convert(varchar,mc.createddate,108) as createddate from sys_memocomment mc left join sys_user su on mc.createdby=su.iduser where mc.idmemo='" & sender.tag & "' order by mc.createddate asc", "getmemokomentar")

        gcKomentar.DataSource = sqls.dataTable("getmemokomentar")
        gvKomentar.BestFitColumns()
        gcData.DataSource = sqls.dataTable("getmemofiles")
        gvData.BestFitColumns()

        teNoMemo.Text = sqls.getDataSet("getmemo", 0, "memono")
        lueJenisMemo.EditValue = CLng(sqls.getDataSet("getmemo", 0, "memotype"))
        teJudulMemo.Text = sqls.getDataSet("getmemo", 0, "judul")
        meMemo.Text = sqls.getDataSet("getmemo", 0, "konten")

        btnBrowse.Text = "LIHAT FILE"
        teNoMemo.Properties.ReadOnly = True
        lueJenisMemo.Properties.ReadOnly = True
        teJudulMemo.Properties.ReadOnly = True
        meMemo.Properties.ReadOnly = True

        btnBrowse.Enabled = True
        btnBrowse.Visible = True

        clbcForward.Enabled = True
        pKomentar.Enabled = True
        lueMessage.EditValue = Nothing
        lueMessage.Enabled = True
        meMessage.Enabled = True
        meMessage.EditValue = Nothing
        pKomentarBottom.Enabled = True
        ceSendType.Enabled = True
        ceQuick.Enabled = True
        btnSend.Enabled = True

        clbcUser.Enabled = True

        sqls.DMLQuery("select mp.iduser from sys_memopermission mp left join sys_memo m on mp.idmemo=m.idmemo where m.idmemo='" & sender.tag & "'", "getuser")
        If clbcUser.ItemCount > 0 Then
            For a As Integer = 0 To sqls.getDataSet("getuser") - 1
                For b As Integer = 0 To clbcUser.ItemCount - 1
                    If clbcUser.GetItemValue(b) = sqls.getDataSet("getuser", a, "iduser") Then
                        clbcUser.SetItemChecked(b, True)
                    End If
                Next
            Next
        End If

        isReadOnly = True
        For Each ctrl As Control In tlpList.Controls
            For Each ctrl1 As Control In ctrl.Controls
                If CType(ctrl1, System.Windows.Forms.Button).Enabled = True Then
                    CType(ctrl1, System.Windows.Forms.Button).FlatAppearance.BorderColor = Color.FromArgb(246, 139, 31)
                    CType(ctrl1, System.Windows.Forms.Button).BackColor = Color.GreenYellow
                Else
                    CType(ctrl1, System.Windows.Forms.Button).FlatAppearance.BorderColor = Color.FromArgb(246, 139, 31)
                    CType(ctrl1, System.Windows.Forms.Button).BackColor = Color.Gray
                End If
            Next
        Next

        sqls.DMLQuery("update sys_memopermission set isview=1,viewdate=getdate() where isview=0 and idmemo='" & sender.tag & "' and iduser='" & userid & "'", False)
        sqls.DMLQuery("update sys_memocomment set forwarddate=getdate() where idmemo='" & sender.tag & "' and forwardto='" & userid & "'", False)
        CType(sender, System.Windows.Forms.Button).FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0)
        CType(sender, System.Windows.Forms.Button).BackColor = Color.White
    End Sub

    Private Sub lueJenisMemo_EditValueChanged(sender As Object, e As EventArgs) Handles lueJenisMemo.EditValueChanged
        If lueJenisMemo.EditValue Is Nothing Then
            clbcUser.Visible = False
            clbcForward.Visible = False
            pKomentar.Visible = False
            Exit Sub
        End If
        If lueJenisMemo.EditValue = 1 Then
            clbcUser.Visible = True
            clbcForward.Visible = False
            pKomentar.Visible = True
        ElseIf lueJenisMemo.EditValue = 2 Then
            clbcUser.Visible = False
            clbcForward.Visible = True
            pKomentar.Visible = True
        End If
        If clbcUser.Visible Then clbcUser.Enabled = True
        If clbcForward.Visible Then clbcForward.Enabled = True
        If pKomentar.Visible Then pKomentar.Enabled = True
    End Sub

    Private Sub ceQuick_CheckedChanged(sender As Object, e As EventArgs) Handles ceQuick.CheckedChanged
        If ceQuick.Checked = True Then
            pKomentar.Size = New Size(pKomentar.Size.Width, 40)
            meMessage.Visible = False
            meMessage.Dock = DockStyle.None
            ceSendType.Visible = False
            lueMessage.Visible = True
            lueMessage.Dock = DockStyle.Fill
        Else
            pKomentar.Size = New Size(pKomentar.Size.Width, 56)
            meMessage.Visible = True
            meMessage.Dock = DockStyle.Fill
            ceSendType.Visible = True
            lueMessage.Visible = False
            lueMessage.Dock = DockStyle.None
        End If
    End Sub

    Private Sub meMemo_TextChanged(sender As Object, e As EventArgs) Handles meMemo.TextChanged
        lblCounter.Text = meMemo.Text.Length & " / 8000"
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If clbcForward.Visible = True Then
            If clbcForward.CheckedItemsCount = 0 Then
                dizMsgbox("User belum dipilih", dizMsgboxStyle.Info, Me)
                clbcForward.Focus()
                Exit Sub
            End If
        End If

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        Dim idtmp As String = GenerateGUID()
        If ceQuick.CheckState = CheckState.Checked Then
            If clbcForward.Visible = False Then
                field.AddRange(New String() {"idmemocomment", "idmemo", "memocomment", "isdeleted", "forwardto", "forwarddate", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idd, lueMessage.Text, 0, 0, nowTime, userid, nowTime})
            Else
                field.AddRange(New String() {"idmemocomment", "idmemo", "memocomment", "isdeleted", "forwardto", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idd, lueMessage.Text, 0, clbcForward.CheckedItems(0), userid, nowTime})
            End If
        ElseIf ceQuick.CheckState = CheckState.Unchecked Then
            If clbcForward.Visible = False Then
                field.AddRange(New String() {"idmemocomment", "idmemo", "memocomment", "isdeleted", "forwardto", "forwarddate", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idd, meMessage.Text, 0, 0, nowTime, userid, nowTime})
            Else
                field.AddRange(New String() {"idmemocomment", "idmemo", "memocomment", "isdeleted", "forwardto", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idd, meMessage.Text, 0, clbcForward.CheckedItems(0), userid, nowTime})
            End If
        End If
        Dim retval As Boolean = dtsql.datasetSave("sys_memocomment", idtmp, field, value, False)

        If retval = True Then
            dizMsgbox("Komentar telah tersimpan", dizMsgboxStyle.Info, Me)
            loadButton()
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Private isReadOnly As Boolean = False
    Private Sub clbcUser_ItemChecking(sender As Object, e As ItemCheckingEventArgs) Handles clbcUser.ItemChecking
        If isReadOnly Then
            e.Cancel = True
        End If
    End Sub

    Private Sub clbcForward_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbcForward.ItemCheck
        For b As Integer = 0 To clbcForward.ItemCount - 1
            If b <> e.Index Then
                clbcForward.SetItemChecked(b, False)
            End If
        Next
    End Sub

    Private Sub meMessage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles meMessage.KeyPress
        If ceSendType.Checked = True Then
            If Asc(e.KeyChar) = 13 Then
                e.Handled = False
                btnSend_Click(btnSend, Nothing)
            End If
        End If
    End Sub

    Private Sub btnDeleteChat_Click(sender As Object, e As EventArgs) Handles btnDeleteChat.Click
        If idd = "-1" Then
            dizMsgbox("Memo belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If dizMsgbox("Menghapus memo ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update sys_memo set isdeleted=1 where idmemo='" & idd & "'", False)

            loadButton()
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

End Class