Public Class frmItem
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
        mysqls.DMLQuery("select i.iditem,i.itemgrup,i.itemtype,gc.generalcode as type,g.itemgrup as grup,i.kode,i.item,i.isdeleted,d.generalcode as statdata,i.idsatuan,s.satuan,i.remarks from item i left join satuan s on i.idsatuan=s.idsatuan left join itemgrup g on i.itemgrup=g.iditemgrup left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join sys_generalcode d on d.idgeneral=i.isdeleted and d.gctype='DELETE'", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select iditemgrup as id,itemgrup as content from itemgrup order by itemgrup asc", "grup")
        lueGrup.Properties.DataSource = mysqls.dataTable("grup")
        lueGrup.Properties.ValueMember = "id"
        lueGrup.Properties.DisplayMember = "content"

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ITEMTYPE'", "type")
        lueType.Properties.DataSource = mysqls.dataTable("type")
        lueType.Properties.ValueMember = "id"
        lueType.Properties.DisplayMember = "content"

        mysqls.DMLQuery("select idsatuan as id,satuan as content from satuan where isdeleted=0", "satuan")
        lueSatuan.Properties.DataSource = mysqls.dataTable("satuan")
        lueSatuan.Properties.ValueMember = "id"
        lueSatuan.Properties.DisplayMember = "content"
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        kosongkanIsian(tlpField)

        lueGrup.Properties.ReadOnly = False
        lueType.Properties.ReadOnly = False
        teKode.Properties.ReadOnly = False

        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        statData = statusData.Baru
    End Sub

    'Private Function generateNO(ByVal prefix As String) As String
    '    Dim retval As String = ""
    '    Dim mysqls As New SQLs(dbstring)
    '    Dim tblname As String = IIf(prefix = "", "X", prefix) & Format(nowTime, "yyyy")
    '    mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & "'", "GetLast")
    '    Dim idgen As Integer = -1
    '    Dim formatStr As String = ""
    '    Dim currid As Integer = 0
    '    Dim currStrId As String = ""
    '    Dim posnumber As String = ""
    '    Dim lenStr As String = ""
    '    Dim lenId As Integer = 0

    '    If mysqls.getDataSet("GetLast") = 0 Then
    '        formatStr = prefix & Format(nowTime, "yyyy") & "-"
    '        currid = 1
    '        posnumber = "Belakang"
    '        lenId = 4
    '    Else
    '        idgen = mysqls.getDataSet("GetLast", 0, "idgeneratenumber")

    '        formatStr = mysqls.getDataSet("GetLast", 0, "formatstring")
    '        currid = CInt(mysqls.getDataSet("GetLast", 0, "lastnumber")) + 1
    '        posnumber = mysqls.getDataSet("GetLast", 0, "positionnumber")
    '        lenId = CInt(mysqls.getDataSet("GetLast", 0, "digitnumber"))
    '    End If
    '    For i As Integer = 0 To lenId - 1
    '        If i = 0 Then
    '            lenStr = "0"
    '        Else
    '            lenStr &= "#"
    '        End If
    '    Next
    '    currStrId = Format(currid, lenStr)

    '    If posnumber = "Belakang" Then
    '        retval = formatStr & currStrId
    '    ElseIf posnumber = "Depan" Then
    '        retval = currStrId & formatStr
    '    End If

    '    Dim dtsave As New dtsetSQLS(dbstring)
    '    Dim field As New List(Of String)
    '    Dim value As New List(Of Object)
    '    field.AddRange(New String() {"idgeneratenumber", "tablename", "formatstring", "lastnumber", "positionnumber", "digitnumber"})
    '    value.AddRange(New String() {idgen, tblname, formatStr, currid, posnumber, lenId})
    '    dtsave.datasetSave("sys_generatenumber", idgen, field, value, False)

    '    Return retval
    '    'retval = "SPB/" & codeDept & "/" & Format(nowTime, "MM") & "/" & Format(nowTime, "yyyy").Remove(0, 2) & "/"
    '    'Dim cnt As Integer = CInt(loadSingleData("count(nospb)", "nospb like '" & retval & "%'", "spb"))
    '    'retval = retval & Format(cnt + 1, "0##")
    'End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iditem from item where kode='" & teKode.Text & "'", "kodeexist")
            If sqls.getDataSet("kodeexist") > 0 Then
                dizMsgbox("Kode tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teKode.Focus()
                Exit Sub
            End If
            sqls.DMLQuery("select iditem from item where replace(item,' ','')='" & teNama.Text.Replace(" ", "") & "' and itemgrup='" & lueGrup.EditValue & "' and itemtype='" & lueType.EditValue & "'", "exist")
            If sqls.getDataSet("exist") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                teNama.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Edit Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iditem from item where kode='" & teKode.Text & "' and iditem <>'" & idData & "'", "kodeexist")
            If sqls.getDataSet("kodeexist") > 0 Then
                dizMsgbox("Kode tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teKode.Focus()
                Exit Sub
            End If
            sqls.DMLQuery("Select item from item where replace(item,' ','')='" & teNama.Text.Replace(" ", "") & "' and itemgrup='" & lueGrup.EditValue & "' and itemtype='" & lueType.EditValue & "' and iditem<>'" & idData & "'", "exist")
            If sqls.getDataSet("exist") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                teNama.Focus()
                Exit Sub
            End If
        End If

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If statData = statusData.Baru Then
            idData = GenerateGUID()
            teKode.Text = generateno3("", lueType.Text.ToUpper.Chars(0), "yyyy", False)
            field.AddRange(New String() {"iditem", "idsatuan", "itemgrup", "itemtype", "kode", "item", "remarks", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, lueSatuan.EditValue, lueGrup.EditValue, lueType.EditValue, teKode.Text, teNama.Text, teRemarks.Text, 0, userid, nowTime})
        Else
            Dim sql1 As New SQLs(dbstring)
            sql1.DMLQuery("select idtransaksidt from transaksidt where iditem='" & idData & "'", "cektrf")
            If sql1.getDataSet("cektrf") > 0 Then
                field.AddRange(New String() {"iditem", "item", "remarks", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, teNama.Text, teRemarks.Text, userid, nowTime})
            Else
                field.AddRange(New String() {"iditem", "idsatuan", "item", "remarks", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, lueSatuan.EditValue, teNama.Text, teRemarks.Text, userid, nowTime})
            End If
        End If

        If dtSQL.datasetSave("item", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "item")

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
            field.AddRange(New String() {"iditem", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("item", idData, field, value, False)
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"iditem", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("item", idData, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "item")
        btnNew_Click(Me, Nothing)
    End Sub

    Private isdeleted As String = ""
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            lueGrup.Properties.ReadOnly = False
            lueType.Properties.ReadOnly = False
            teKode.Properties.ReadOnly = False

            lueGrup.EditValue = dcol("itemgrup")
            lueType.EditValue = dcol("itemtype")
            lueSatuan.EditValue = dcol("idsatuan")
            teKode.Text = dcol("kode")
            teNama.Text = dcol("item")
            teRemarks.Text = dcol("remarks")

            idData = dcol("iditem")

            Dim sql1 As New SQLs(dbstring)
            sql1.DMLQuery("select idtransaksidt from transaksidt where iditem='" & idData & "'", "cektrf")
            If sql1.getDataSet("cektrf") > 0 Then
                lueGrup.Properties.ReadOnly = True
                lueType.Properties.ReadOnly = True
                teKode.Properties.ReadOnly = True
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

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()

        checkFieldMaxLength(dbstring, tlpField, "item")
        btnNew_Click(Me, Nothing)
    End Sub

End Class