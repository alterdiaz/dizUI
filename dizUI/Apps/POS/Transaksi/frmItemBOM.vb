Public Class frmItemBOM
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
        Threading.Thread.Sleep(1000)
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

    Private dttbl As New DataTable
    Private Sub loadGrid(ByVal iditem As String, ByVal idunit As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select m.iditembom,d.iditembomdt,d.iditem,i.itemtype,t.generalcode as type,i.idsatuan,s.satuan,i.kode,i.item,d.qty from itembom m left join itembomdt d on m.iditembom=d.iditembom left join item i on d.iditem=i.iditem left join sys_generalcode t on i.itemtype=t.idgeneral and t.gctype='ITEMTYPE' left join satuan s on i.idsatuan=s.idsatuan where m.isdeleted=0 and m.idunit='" & lueUnit.EditValue & "' and m.iditem='" & iditem & "'", "data")
        dttbl = sqls.dataTable("data")
        If sqls.getDataSet("data") > 0 Then
            idData = sqls.getDataSet("data", 0, "iditembom")
        Else
            idData = "-1"
        End If
        gcData.DataSource = dttbl
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
        loadItem(-1)
        checkFieldMaxLength(dbstring, tlpField, "itembom")
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        kosongkanIsian(tlpField)
        lueItem.EditValue = Nothing
        teKode.Text = ""
        teType.Text = ""
        teSatuan.Text = ""
        teNote.Text = ""

        lueUnit.Enabled = True
        lueUnit.Properties.ReadOnly = False
        lueUnit.EditValue = Nothing
        btnLockUnit.Enabled = True
        btnLockUnit.BackColor = Color.FromArgb(156, 207, 49)

        idData = "-1"
        isVoid = False
        loadGrid(-1, -1)
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        statData = statusData.Baru
    End Sub

    Private Sub gvData_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvData.CellValueChanged
    End Sub

    Private Sub gvData_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvData.RowCountChanged
        If gvData.RowCount = 0 Then
            gcData.Enabled = False
        Else
            gcData.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("Item BOM belum dipilih", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If

        Dim bf As New List(Of String)
        Dim bv As New List(Of Object)
        Dim sqls As New SQLs(dbstring)
        Dim bset As New dtsetSQLS(dbstring)

        If statData = statusData.Baru Then
            If lueItem.EditValue Is Nothing Then
                dizMsgbox("Item belum dipilih", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            idData = GenerateGUID()
            bf.AddRange(New String() {"iditembom", "iditem", "remarks", "isdeleted", "createdby", "createddate"})
            bv.AddRange(New Object() {idData, lueItem.EditValue, teNote.Text, 0, userid, nowTime})
            bset.datasetSave("itembom", idData, bf, bv, False)
            'sqls.DMLQuery("select iditembom from itembom where hashcode='" & hashcode & "'", "getid")
            'idData = sqls.getDataSet("getid", 0, "iditembom")
        End If

        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)

            bf.Clear()
            bv.Clear()
            bset = New dtsetSQLS(dbstring)
            Dim iditembomdt As String = GenerateGUID()
            bf.AddRange(New String() {"iditembomdt", "iditembom", "iditem", "qty", "isdeleted", "createdby", "createddate"})
            bv.AddRange(New Object() {iditembomdt, idData, dr("iditem"), dr("qty"), 0, userid, nowTime})
            bset.datasetSave("itembomdt", iditembomdt, bf, bv, False)
        Next
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub lueItem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueItem.EditValueChanged
        If lueItem.EditValue Is Nothing Then
            teType.Text = ""
            teSatuan.Text = ""
            teKode.Text = ""
            teNote.Text = ""

            idData = "-1"
            isVoid = False
            btnNew.Enabled = False
            btnSave.Enabled = True
            btnDelete.Enabled = False
            btnDelete.Text = "HAPUS"
            statData = statusData.Baru
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iditembom from itembom where isdeleted=0 and iditem='" & lueItem.EditValue & "'", "idbom")
            If sqls.getDataSet("idbom") > 0 Then
                idData = sqls.getDataSet("idbom", 0, "iditembom")
                loadGrid(lueItem.EditValue, lueUnit.EditValue)
            End If

            sqls.DMLQuery("select i.kode,t.generalcode as type,s.satuan,isnull(b.remarks,'') as remarks from item i left join (select iditem,remarks from itembom b where b.isdeleted=0 and b.iditem='" & lueItem.EditValue & "') b on i.iditem=b.iditem left join sys_generalcode t on i.itemtype=t.idgeneral and t.gctype='ITEMTYPE' left join satuan s on i.idsatuan=s.idsatuan where i.iditem='" & lueItem.EditValue & "'", "item")
            teKode.Text = sqls.getDataSet("item", 0, "kode")
            teNote.Text = sqls.getDataSet("item", 0, "remarks")
            teType.Text = sqls.getDataSet("item", 0, "type")
            teSatuan.Text = sqls.getDataSet("item", 0, "satuan")

            isVoid = False
            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            btnDelete.Text = "HAPUS"
            statData = statusData.Edit
        End If
    End Sub

    Private Sub btnAllItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllItem.Click
        If gvItem.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        For i As Integer = 0 To gvItem.RowCount - 1
            Dim dra As DataRow = gvItem.GetDataRow(i)
            Dim sqls As New SQLs(dbstring)
            Dim cekExist As Boolean = False
            For a As Integer = 0 To gvData.RowCount - 1
                Dim drc As DataRow = gvData.GetDataRow(a)
                If drc("iditem") = dra("iditem") Then
                    cekExist = True
                    Exit For
                End If
            Next
            If cekExist = False Then
                Dim dr As DataRow = dttbl.NewRow
                dr("iditem") = dra("iditem")
                sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where i.iditem='" & dra("iditem") & "'", "dataitem")
                dr("iditembomdt") = (i + 1) * -1
                dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                dr("type") = sqls.getDataSet("dataitem", 0, "type")
                dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                dr("item") = sqls.getDataSet("dataitem", 0, "item")
                dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                dr("qty") = 0
                dttbl.Rows.Add(dr)
            End If
            dra("cek") = 0
        Next
        gcData.DataSource = dttbl
    End Sub

    Private Sub btnItemSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemSelect.Click
        If gvItem.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        For i As Integer = 0 To gvItem.RowCount - 1
            Dim dra As DataRow = gvItem.GetDataRow(i)
            If dra("cek") = "True" Then
                Dim sqls As New SQLs(dbstring)
                Dim cekExist As Boolean = False
                For a As Integer = 0 To gvData.RowCount - 1
                    Dim drc As DataRow = gvData.GetDataRow(a)
                    If drc("iditem") = dra("iditem") Then
                        cekExist = True
                        Exit For
                    End If
                Next
                If cekExist = False Then
                    Dim dr As DataRow = dttbl.NewRow
                    dr("iditem") = dra("iditem")
                    sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where i.iditem='" & dra("iditem") & "'", "dataitem")
                    dr("iditembomdt") = (i + 1) * -1
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("qty") = 0
                    dttbl.Rows.Add(dr)
                End If
                dra("cek") = 0
            End If
        Next
        gcData.DataSource = dttbl
    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Item yang dipilih tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        Dim dr As DataRow = dttbl.Rows(gvData.FocusedRowHandle)
        If dizMsgbox("Item dibawah ini" & vbCrLf & "Item (" & dr("item") & ")" & vbCrLf & "Akan dihapus dari daftar, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            dttbl.Rows.Remove(dr)
            gcData.DataSource = dttbl
        End If
    End Sub

    Private Sub btnDeleteAllItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAllItem.Click
        If dizMsgbox("Item yang telah dipilih" & vbCrLf & "Akan dihapus keseluruhan dari daftar" & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            loadGrid(-1, -1)
        End If
    End Sub

    Private Sub loadItem(ByVal idunit As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select i.iditem,i.item,isnull(iu.qty,0) as qty,isnull(iu.price,0) as price,convert(bit,0) as cek,'('+ gc.generalcode +') Price Rp.'+REPLACE(REPLACE(REPLACE(CONVERT(varchar, CONVERT(money, isnull(iu.price,0)), 1), ',', ' '), '.', ','), ' ', '.')+' Qty '+convert(varchar,isnull(iu.qty,0)) as note from item i left join sys_generalcode gc on i.itemtype=gc.idgeneral and gc.gctype='ITEMTYPE' left join itemunit iu on i.iditem=iu.iditem and iu.idunit='" & idunit & "' where i.itemtype=1 order by i.item asc", "getitem")
        gcItem.DataSource = sqls.dataTable("getitem")
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idunit as id,unit as content from unit where isdeleted=0", "unit")
        lueUnit.Properties.DataSource = sqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"

        sqls.DMLQuery("select iditem as id, item as content from item where itemtype=3", "item")
        lueItem.Properties.DataSource = sqls.dataTable("item")
        lueItem.Properties.ValueMember = "id"
        lueItem.Properties.DisplayMember = "content"
    End Sub

    Private Sub lueUnit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueUnit.EditValueChanged
        If (lueUnit.EditValue Is Nothing Or lueUnit.EditValue Is Nothing Or (lueUnit.EditValue Is Nothing And lueUnit.EditValue Is Nothing)) Then
            gcItem.DataSource = Nothing
            gcData.DataSource = Nothing
            loadGrid(-1, -1)
            Exit Sub
        End If

        If lueUnit.EditValue Is Nothing Then
            loadItem(-1)
        Else
            loadItem(lueUnit.EditValue)
        End If
        loadGrid(lueItem.EditValue, lueUnit.EditValue)
    End Sub

    Private Sub btnLockUnit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLockUnit.Click
        If lueUnit.EditValue Is Nothing Then
            dizMsgbox("Unit belum dipilih", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If lueUnit.Properties.ReadOnly = True Then
            If gvData.RowCount > 0 Then
                If dizMsgbox("Item terpilih akan dihapus" & vbCrLf & "Tetap melanjutkan ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi", Me) = dizMsgboxValue.Batal Then
                    Exit Sub
                End If
            End If

            btnLockUnit.ForeColor = Color.White
            btnLockUnit.BackColor = Color.FromArgb(156, 207, 49)
            lueUnit.Properties.ReadOnly = False
            lueUnit.BackColor = canWrite
            lueUnit.ForeColor = Color.Black
            xtpItem.PageEnabled = True
            xtcItem.Enabled = True
            loadGrid(lueItem.EditValue, lueUnit.EditValue)
        Else
            If gvItem.RowCount = 0 Then
                dizMsgbox("Item pada unit tidak tersedia", dizMsgboxStyle.peringatan, Me)
                'Exit Sub
            End If
            btnLockUnit.ForeColor = Color.White
            btnLockUnit.BackColor = Color.Maroon
            lueUnit.Properties.ReadOnly = True
            lueUnit.BackColor = justRead
            lueUnit.ForeColor = Color.Black
            xtcItem.Enabled = True
            xtpItem.PageEnabled = True
        End If
    End Sub

    Private Sub btnLockItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLockItem.Click
        If lueItem.EditValue Is Nothing Then
            dizMsgbox("Item belum dipilih", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If lueItem.Properties.ReadOnly = True Then
            If gvData.RowCount > 0 Then
                If dizMsgbox("Item terpilih akan dihapus" & vbCrLf & "Tetap melanjutkan ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi", Me) = dizMsgboxValue.Batal Then
                    Exit Sub
                End If
            End If

            btnLockItem.ForeColor = Color.White
            btnLockItem.BackColor = Color.FromArgb(156, 207, 49)
            lueItem.Properties.ReadOnly = False
            lueItem.BackColor = canWrite
            lueItem.ForeColor = Color.Black
            xtpItem.PageEnabled = True
            xtcItem.Enabled = True
            loadGrid(lueItem.EditValue, lueUnit.EditValue)
        Else
            If gvItem.RowCount = 0 Then
                dizMsgbox("Item pada unit tidak tersedia", dizMsgboxStyle.peringatan, Me)
                'Exit Sub
            End If
            btnLockItem.ForeColor = Color.White
            btnLockItem.BackColor = Color.Maroon
            lueItem.Properties.ReadOnly = True
            lueItem.BackColor = justRead
            lueItem.ForeColor = Color.Black
            xtcItem.Enabled = True
            xtpItem.PageEnabled = True
        End If
    End Sub

End Class