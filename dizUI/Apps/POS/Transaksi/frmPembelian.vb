Public Class frmPembelian
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

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=1", "supp")
        lueSupplier.Properties.DataSource = sqls.dataTable("supp")
        lueSupplier.Properties.ValueMember = "id"
        lueSupplier.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idunit as id,unit as content from unit where isdeleted=0", "unit")
        lueUnit.Properties.DataSource = sqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='PAYTYPE'", "bayar")
        luePayment.Properties.DataSource = sqls.dataTable("bayar")
        luePayment.Properties.ValueMember = "id"
        luePayment.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='POTYPE'", "potype")
        lueJenis.Properties.DataSource = sqls.dataTable("potype")
        lueJenis.Properties.ValueMember = "id"
        lueJenis.Properties.DisplayMember = "content"
    End Sub

    Private dttbl As New DataTable
    Private Sub loadGrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,d.discamount,d.discpersen,d.price,d.subtotal,d.qty from transaksidt d where d.idtransaksidt=-1", "data")
        dttbl = sqls.dataTable("data")
        gcData.DataSource = dttbl
    End Sub

    Private Sub frmPembelian_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.Properties.ReadOnly = True
        deTanggal.Enabled = False
        deTanggal.BackColor = justRead
        deTanggal.Properties.AppearanceDisabled.ForeColor = Color.Black
        deTanggal.Properties.AppearanceReadOnly.ForeColor = Color.Black

        teKode.Properties.ReadOnly = True
        teKode.Enabled = False
        teKode.BackColor = justRead
        teKode.Properties.AppearanceDisabled.ForeColor = Color.Black
        teKode.Properties.AppearanceReadOnly.ForeColor = Color.Black

        teCP.Properties.ReadOnly = True
        teCP.Enabled = False
        teCP.BackColor = justRead
        teCP.Properties.AppearanceDisabled.ForeColor = Color.Black
        teCP.Properties.AppearanceReadOnly.ForeColor = Color.Black

        teEmail.Properties.ReadOnly = True
        teEmail.Enabled = False
        teEmail.BackColor = justRead
        teEmail.Properties.AppearanceDisabled.ForeColor = Color.Black
        teEmail.Properties.AppearanceReadOnly.ForeColor = Color.Black

        teNoPermintaan.Properties.ReadOnly = True
        teNoPermintaan.Enabled = False
        teNoPermintaan.BackColor = justRead
        teNoPermintaan.Properties.AppearanceDisabled.ForeColor = Color.Black
        teNoPermintaan.Properties.AppearanceReadOnly.ForeColor = Color.Black

        deTerima.Properties.ReadOnly = True
        deTerima.Enabled = False
        deTerima.BackColor = justRead
        deTerima.ForeColor = Color.Black

        nudDiskon.Properties.ReadOnly = True
        nudDiskon.Enabled = False
        nudDiskon.BackColor = justRead
        nudDiskon.ForeColor = Color.Black

        nudPajak.Properties.ReadOnly = True
        nudPajak.Enabled = False
        nudPajak.BackColor = justRead
        nudPajak.ForeColor = Color.Black

        nudTotal.Properties.ReadOnly = True
        nudTotal.Enabled = False
        nudTotal.BackColor = justRead
        nudTotal.ForeColor = Color.Black

        For i As Integer = 0 To gvItem.Columns.Count - 1
            Dim col As New DevExpress.XtraGrid.Columns.GridColumn
            col = gvData.Columns.Item(i)
            col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            col.OptionsFilter.AllowFilter = False
            col.OptionsFilter.AllowAutoFilter = False
        Next

        For i As Integer = 0 To gvItemSupplier.Columns.Count - 1
            Dim col As New DevExpress.XtraGrid.Columns.GridColumn
            col = gvData.Columns.Item(i)
            col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            col.OptionsFilter.AllowFilter = False
            col.OptionsFilter.AllowAutoFilter = False
        Next

        seQty.MinValue = 0
        seQty.MaxValue = 1000
        loadLOV()

        checkFieldMaxLength(dbstring, tlpField, "transaksi")
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = -1

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadgrid()
        kosongkanIsian(tlpField)

        idData = -1
        isVoid = False

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select formatstring from transactiontype where kodetransaksi='121'", "ttype")
        teKode.Text = sqls.getDataSet("ttype", 0, "formatstring") & "-XXXXXXXX-XXX"
        teNoPermintaan.Text = ""
        teNoPermintaan.Tag = -1
        lueSupplier.EditValue = Nothing
        teEmail.Text = ""

        deTanggal.EditValue = nowTime
        lueUnit.EditValue = Nothing
        teCP.Text = ""
        teNote.Text = ""

        lueJenis.EditValue = Nothing
        deTerima.EditValue = Nothing
        nudOngkir.Value = 0
        nudBayar.Value = 0

        luePayment.EditValue = Nothing
        nudDiskon.Value = 0
        nudPajak.Value = 0
        nudTotal.Value = 0

        btnDeleteAllItem.Enabled = True
        btnDeleteItem.Enabled = True

        btnLockUnit.BackColor = Color.FromArgb(156, 207, 49)
        btnLockSupplier.BackColor = Color.FromArgb(156, 207, 49)

        teNote.BackColor = canWrite
        teNote.Properties.ReadOnly = False
        teNote.Enabled = True

        lueSupplier.BackColor = canWrite
        lueSupplier.Enabled = True
        lueSupplier.Properties.ReadOnly = False
        lueSupplier.BackColor = canWrite
        lueSupplier.EditValue = Nothing
        btnLockSupplier.Enabled = True

        lueUnit.BackColor = canWrite
        lueUnit.Enabled = True
        lueUnit.Properties.ReadOnly = False
        lueUnit.BackColor = canWrite
        lueUnit.EditValue = Nothing
        btnLockUnit.Enabled = True

        xtcItem.Enabled = False
        xtpItem.PageEnabled = False
        xtpItemSupplier.PageEnabled = False

        btnLockUnit.Enabled = True
        gcQty.OptionsColumn.AllowEdit = True
        gcQty.OptionsColumn.ReadOnly = False
        gcQty.AppearanceCell.BackColor = canWrite

        btnSearch.Enabled = True
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "VOID"
        statData = statusData.Baru
    End Sub

    Private Sub lueJenis_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueJenis.EditValueChanged
        If lueJenis.EditValue Is Nothing Then
            deTerima.EditValue = Nothing
            Exit Sub
        End If
        If lueJenis.EditValue = 1 Then
            deTerima.EditValue = Nothing
        ElseIf lueJenis.EditValue = 2 Then
            deTerima.EditValue = nowTime
        End If
    End Sub

    Private Sub luePayment_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePayment.EditValueChanged
        If luePayment.EditValue Is Nothing Then
            nudBayar.Value = 0
            Exit Sub
        End If
        If luePayment.EditValue = 1 Then
            nudBayar.Value = nudTotal.Value
        ElseIf luePayment.EditValue = 2 Then
            nudBayar.Value = 0
        End If
    End Sub

    Private Sub btnLockUnit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLockUnit.Click
        If lueUnit.EditValue Is Nothing Then
            dizMsgbox("Unit belum dipilih", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If lueUnit.Properties.ReadOnly = True Then
            If teNoPermintaan.Tag = -1 Then
                If gvData.RowCount > 0 Then
                    If dizMsgbox("Item terpilih akan dihapus" & vbCrLf & "Tetap melanjutkan ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi", Me) = dizMsgboxValue.Batal Then
                        Exit Sub
                    End If
                End If
            End If

            btnLockUnit.ForeColor = Color.White
            btnLockUnit.BackColor = Color.FromArgb(156, 207, 49)
            lueUnit.Properties.ReadOnly = False
            lueUnit.BackColor = canWrite
            lueUnit.ForeColor = Color.Black
            xtpItem.PageEnabled = False
            If xtpItemSupplier.PageEnabled = True Then
                xtcItem.Enabled = True
            End If
            If teNoPermintaan.Tag = -1 Then
                loadGrid()
            Else
                xtpItem.PageEnabled = False
            End If
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

    Private Sub loadItemSupplier(ByVal idsupplier As Integer)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select su.iditem,i.item,isnull(su.price,0) as price,convert(bit,0) as cek,'('+ gc.generalcode +') Price Rp.'+REPLACE(REPLACE(REPLACE(CONVERT(varchar, CONVERT(money, isnull(su.price,0)), 1), ',', ' '), '.', ','), ' ', '.') as note,su.discpersen from (select su.iditem,su.price,su.discpersen from itemsupplier su inner join item i on su.iditem=i.iditem and su.idsupplier='" & idsupplier & "') su left join item i on su.iditem=i.iditem left join sys_generalcode gc on i.itemtype=gc.idgeneral and gc.gctype='ITEMTYPE' order by i.item asc", "getitem")
        gcItemSupplier.DataSource = sqls.dataTable("getitem")
    End Sub

    Private Sub loadItem(ByVal idunit As Integer)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select i.iditem,i.item,isnull(iu.qty,0) as qty,isnull(iu.price,0) as price,convert(bit,0) as cek,'('+ gc.generalcode +') Price Rp.'+REPLACE(REPLACE(REPLACE(CONVERT(varchar, CONVERT(money, isnull(iu.price,0)), 1), ',', ' '), '.', ','), ' ', '.')+' Qty '+convert(varchar,isnull(iu.qty,0)) as note from item i left join sys_generalcode gc on i.itemtype=gc.idgeneral and gc.gctype='ITEMTYPE' left join itemunit iu on i.iditem=iu.iditem and iu.idunit='" & idunit & "' where i.itemtype<>3 order by i.item asc", "getitem")
        gcItem.DataSource = sqls.dataTable("getitem")
    End Sub

    Private Sub lueUnit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueUnit.EditValueChanged
        If (lueUnit.EditValue Is Nothing And lueSupplier.EditValue Is Nothing) Or (lueUnit.EditValue Is Nothing Or lueSupplier.EditValue Is Nothing) Then
            gcItemSupplier.DataSource = Nothing
            gcItem.DataSource = Nothing
            If teNoPermintaan.Tag = -1 Then
                loadGrid()
            End If
            Exit Sub
        End If

        loadItem(lueUnit.EditValue)
        If teNoPermintaan.Tag = -1 Then
            loadGrid()
        End If
    End Sub

    Private Sub btnLockSupplier_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLockSupplier.Click
        If lueSupplier.EditValue Is Nothing Then
            dizMsgbox("Supplier belum dipilih", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If lueSupplier.Properties.ReadOnly = True Then
            If teNoPermintaan.Tag = -1 Then
                If gvData.RowCount > 0 Then
                    If dizMsgbox("Item terpilih akan dihapus" & vbCrLf & "Tetap melanjutkan ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi", Me) = dizMsgboxValue.Batal Then
                        Exit Sub
                    End If
                End If
            End If
            btnLockSupplier.ForeColor = Color.White
            btnLockSupplier.BackColor = Color.FromArgb(156, 207, 49)
            lueSupplier.Properties.ReadOnly = False
            lueSupplier.BackColor = canWrite
            lueSupplier.ForeColor = Color.Black
            xtcItem.Enabled = False
            xtpItemSupplier.PageEnabled = False
            If xtpItem.PageEnabled = True Then
                xtcItem.Enabled = True
            End If
            If teNoPermintaan.Tag = -1 Then
                loadGrid()
            Else
                xtpItem.PageEnabled = False
            End If
        Else
            If gvItemSupplier.RowCount = 0 Then
                dizMsgbox("Item pada supplier tidak tersedia", dizMsgboxStyle.peringatan, Me)
                'Exit Sub
            End If
            btnLockSupplier.ForeColor = Color.White
            btnLockSupplier.BackColor = Color.Maroon
            lueSupplier.Properties.ReadOnly = True
            lueSupplier.BackColor = justRead
            lueSupplier.ForeColor = Color.Black
            xtcItem.Enabled = True
            xtpItemSupplier.PageEnabled = True
        End If
    End Sub

    Private Sub lueSupplier_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueSupplier.EditValueChanged
        If (lueUnit.EditValue Is Nothing And lueSupplier.EditValue Is Nothing) Or (lueUnit.EditValue Is Nothing Or lueSupplier.EditValue Is Nothing) Then
            gcItemSupplier.DataSource = Nothing
            gcItem.DataSource = Nothing

            If teNoPermintaan.Tag = -1 Then
                loadGrid()
            End If
            Exit Sub
        End If

        If lueSupplier.EditValue Is Nothing Then
            teEmail.Text = ""
            teCP.Text = ""
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select email,contactperson from businesspartner where idbusinesspartner='" & lueSupplier.EditValue & "'", "bp")
            teEmail.Text = sqls.getDataSet("bp", 0, "email")
            teCP.Text = sqls.getDataSet("bp", 0, "contactperson")
        End If

        loadItemSupplier(lueSupplier.EditValue)
        If teNoPermintaan.Tag = -1 Then
            loadGrid()
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select d.idtransaksidt,d.idtransaksi,d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,isnull(su.discamount,0) as discamount,ISNULL(su.discpersen,0) as discpersen,isnull(su.price,0) as price,(isnull(su.price,0)*d.qty)-(isnull(su.discamount,0)*d.qty) as subtotal,d.qty from transaksidt d left join itemsupplier su on d.iditem=su.iditem and su.idsupplier='" & lueSupplier.EditValue & "' where d.idtransaksi='" & teNoPermintaan.Tag & "'", "detail")
            gcData.DataSource = sqls.dataTable("detail")
            subHitung()
        End If
    End Sub

    Private Sub btnDeleteAllItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAllItem.Click
        If dizMsgbox("Item yang telah dipilih" & vbCrLf & "Akan dihapus keseluruhan dari daftar" & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.konfirmasi, Me) = dizMsgboxValue.OK Then
            loadGrid()
        End If
    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Item yang dipilih tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        Dim dr As DataRow = dttbl.Rows(gvData.FocusedRowHandle)
        If dizMsgbox("Item dibawah ini" & vbCrLf & "Item (" & dr("item") & ")" & vbCrLf & "Akan dihapus dari daftar, tetap melanjutkan?", dizMsgboxStyle.konfirmasi, Me) = dizMsgboxValue.OK Then
            dttbl.Rows.Remove(dr)
            gcData.DataSource = dttbl
        End If
    End Sub

    Private Sub btnAllItemSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllItemSupplier.Click
        If gvItemSupplier.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If dizMsgbox("Item terpilih sebanyak : " & gvItemSupplier.RowCount & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.konfirmasi, Me) = dizMsgboxValue.OK Then
            For i As Integer = 0 To gvItemSupplier.RowCount - 1
                Dim dra As DataRow = gvItemSupplier.GetDataRow(i)
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
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("qty") = 0
                    dr("price") = dra("price")
                    dr("discpersen") = dra("discpersen")
                    dr("discamount") = (CInt(CInt(dra("discpersen")) / 100) * dra("price"))
                    dr("subtotal") = 0
                    dttbl.Rows.Add(dr)
                End If
                dra("cek") = 0
            Next
            gcData.DataSource = dttbl
        End If
    End Sub

    Private Sub btnAllItemSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAllItemSelect.Click
        If gvItem.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If dizMsgbox("Item terpilih sebanyak : " & gvItem.RowCount & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.konfirmasi, Me) = dizMsgboxValue.OK Then
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
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("qty") = 0
                    dr("price") = dra("price")
                    dr("discpersen") = 0
                    dr("discamount") = 0
                    dr("subtotal") = 0
                    dttbl.Rows.Add(dr)
                End If
                dra("cek") = 0
            Next
            gcData.DataSource = dttbl
        End If
    End Sub

    Private Sub btnItemSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnItemSelect.Click
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
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("qty") = 0
                    dr("price") = dra("price")
                    dr("discpersen") = 0
                    dr("discamount") = 0
                    dr("subtotal") = 0
                    dttbl.Rows.Add(dr)
                End If
                dra("cek") = 0
            End If
        Next
        gcData.DataSource = dttbl
    End Sub

    Private Sub btnItemSupplierSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnItemSupplierSelect.Click
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
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("qty") = 0
                    dr("price") = dra("price")
                    dr("discpersen") = dra("discpersen")
                    dr("discamount") = (CInt(CInt(dra("discpersen")) / 100) * dra("price"))
                    dr("subtotal") = 0
                    dttbl.Rows.Add(dr)
                End If
                dra("cek") = 0
            End If
        Next
        gcData.DataSource = dttbl
    End Sub

    Dim currCol As DevExpress.XtraGrid.Columns.GridColumn
    Dim subTotal As Long = 0
    Dim subDiskon As Long = 0
    Dim subPajak As Long = 0
    Dim subPrice As Long = 0

    Private Sub subHitung()
        subTotal = 0
        subDiskon = 0
        subPajak = 0
        subPrice = 0
        If gvData.RowCount > 0 Then
            For i As Integer = 0 To gvData.RowCount - 1
                Dim dr As DataRow = gvData.GetDataRow(i)
                subDiskon += (CLng(dr("discamount")) * CLng(dr("qty")))
                subPrice += (CLng(dr("price")) * CLng(dr("qty")))
                subTotal += subPrice
            Next
        End If
        nudSubtotal.Value = subPrice
        nudDiskon.Value = subDiskon
        subPajak = (subTotal - subDiskon) * 0.1
        nudPajak.Value = (subTotal - subDiskon - CLng(nudDiskonGlobal.Value)) * 0.1
        nudTotal.Value = subPrice - subDiskon - CLng(nudDiskonGlobal.Value) + nudOngkir.Value + nudPajak.Value
        nudDiskonGlobal.Properties.MaxValue = nudTotal.Value
        nudBayar.Properties.MaxValue = nudTotal.Value
        If luePayment.EditValue = 1 Then
            nudBayar.Value = nudTotal.Value
        End If
    End Sub

    Private Sub gvData_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvData.CellValueChanged
        Dim dr As DataRow = gvData.GetDataRow(e.RowHandle)
        If e.Column Is gcDiscP Then
            currCol = e.Column
            Dim price As Long = CLng(dr("price"))
            Dim discp As Long = CLng(e.Value)
            Dim discamt As Long = CLng(price * CDec(discp / 100))
            Dim qty As Long = dr("qty")
            gvData.SetRowCellValue(e.RowHandle, "discamount", discamt)
            Dim totprice As Long = qty * price
            Dim totdisc As Long = qty * discamt
            Dim subtot As Long = totprice - totdisc
            gvData.SetRowCellValue(e.RowHandle, "subtotal", subtot)
            subHitung()
        ElseIf e.Column Is gcPrice Then
            currCol = e.Column
            Dim price As Long = CLng(e.Value)
            Dim discp As Long = CLng(dr("discpersen"))
            Dim discamt As Long = CLng(price * CDec(discp / 100))
            Dim qty As Long = dr("qty")
            gvData.SetRowCellValue(e.RowHandle, "discamount", discamt)
            Dim totprice As Long = qty * price
            Dim totdisc As Long = qty * discamt
            Dim subtot As Long = totprice - totdisc
            gvData.SetRowCellValue(e.RowHandle, "subtotal", subtot)
            subHitung()
        ElseIf e.Column Is gcQty Then
            currCol = e.Column
            Dim price As Long = CLng(dr("price"))
            Dim discp As Long = CLng(dr("discpersen"))
            Dim discamt As Long = CLng(price * CDec(discp / 100))
            Dim qty As Long = CLng(e.Value)
            gvData.SetRowCellValue(e.RowHandle, "discamount", discamt)
            Dim totprice As Long = qty * price
            Dim totdisc As Long = qty * discamt
            Dim subtot As Long = totprice - totdisc
            gvData.SetRowCellValue(e.RowHandle, "subtotal", subtot)
            subHitung()
        End If
    End Sub

    Private Sub btnPermintaan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPermintaan.Click
        Dim sqls As New SQLs(dbstring)
        Dim dset As New DataSet
        Dim idtmpdata As String = -1
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,t.remarks,dt.counter as totalitem,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,c.username as createdby from transaksi t left join sys_user c on t.createdby=c.iduser left join (select idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi) dt on t.idtransaksi=dt.idtransaksi where t.transaksitype=(select idtransactiontype from transactiontype where kodetransaksi='111') and t.isdeleted=0 and t.transaksistatus=1", "gettotal")
        dset = sqls.dataSet
        Dim cari As New frmSearch(dset, "gettotal", "idtransaksi")
        tambahChild(cari)
        If cari.ShowDialog() = Windows.Forms.DialogResult.OK Then
            idtmpdata = cari.GetIDSelectData
            teNoPermintaan.Tag = idtmpdata

            sqls.DMLQuery("select h.idtransaksi,h.transaksino,h.idunitasal,h.unitasal,h.remarks,convert(varchar,h.createddate,105) as tanggal from transaksi h where h.idtransaksi='" & idtmpdata & "'", "header")
            teNoPermintaan.Text = sqls.getDataSet("header", 0, "transaksino")
            lueUnit.EditValue = sqls.getDataSet("header", 0, "idunitasal")
            teNote.Text = sqls.getDataSet("header", 0, "remarks")

            If lueSupplier.EditValue Is Nothing Then
                sqls.DMLQuery("select d.idtransaksidt,d.idtransaksi,d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,isnull(su.discamount,0) as discamount,ISNULL(su.discpersen,0) as discpersen,isnull(su.price,0) as price,(isnull(su.price,0)*d.qty)-(isnull(su.discamount,0)*d.qty) as subtotal,d.qty from transaksidt d left join itemsupplier su on d.iditem=su.iditem and su.idsupplier=0 where d.idtransaksi='" & idtmpdata & "'", "detail")
            Else
                sqls.DMLQuery("select d.idtransaksidt,d.idtransaksi,d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,isnull(su.discamount,0) as discamount,ISNULL(su.discpersen,0) as discpersen,isnull(su.price,0) as price,(isnull(su.price,0)*d.qty)-(isnull(su.discamount,0)*d.qty) as subtotal,d.qty from transaksidt d left join itemsupplier su on d.iditem=su.iditem and su.idsupplier='" & lueSupplier.EditValue & "' where d.idtransaksi='" & idtmpdata & "'", "detail")
            End If
            gcData.DataSource = sqls.dataTable("detail")

            btnDeleteAllItem.Enabled = False
            btnDeleteItem.Enabled = False
            lueUnit.ForeColor = Color.Black
            lueUnit.Properties.ReadOnly = False
            lueUnit.BackColor = canWrite
            lueUnit.Enabled = True
            btnLockUnit_Click(btnLockUnit, Nothing)
            btnLockUnit.Enabled = False
            teNote.ForeColor = Color.Black
            teNote.BackColor = justRead
            teNote.Properties.ReadOnly = True
            teNote.Enabled = False
            gcQty.OptionsColumn.AllowEdit = False
            gcQty.OptionsColumn.ReadOnly = True
            gcQty.AppearanceCell.BackColor = justRead

            subHitung()
            btnSearch.Enabled = True
            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = False
            btnDelete.Text = "VOID"
            statData = statusData.Baru
        Else
            teNoPermintaan.Tag = -1
            If gvData.RowCount = 0 Then
                btnNew_Click(btnNew, Nothing)
            End If
        End If
    End Sub

    Private Sub gvData_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvData.RowCountChanged
        If gvData.RowCount = 0 Then
            gcData.Enabled = False
        Else
            gcData.Enabled = True
        End If
    End Sub

    Private Sub nudBayar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudBayar.ValueChanged
        If nudBayar.Value = nudTotal.Value Then
            luePayment.EditValue = CLng(1)
        Else
            luePayment.EditValue = CLng(2)
        End If
    End Sub

    Private Sub nudOngkir_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudOngkir.ValueChanged
        nudPajak.Value = (CLng(nudSubtotal.Value) - CLng(nudDiskon.Value) - CLng(nudDiskonGlobal.Value)) * 0.1
        nudTotal.Value = CLng(nudSubtotal.Value) - CLng(nudDiskon.Value) - CLng(nudDiskonGlobal.Value) + CLng(nudOngkir.Value) + CLng(nudPajak.Value)
        nudBayar.Properties.MaxValue = nudTotal.Value
        If luePayment.EditValue = CLng(1) Then
            nudBayar.Value = nudTotal.Value
        End If
    End Sub

    Private Sub nudDiskonGlobal_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudDiskonGlobal.ValueChanged
        nudPajak.Value = (CLng(nudSubtotal.Value) - CLng(nudDiskon.Value) - CLng(nudDiskonGlobal.Value)) * 0.1
        nudTotal.Value = CLng(nudSubtotal.Value) - CLng(nudDiskon.Value) - CLng(nudDiskonGlobal.Value) + CLng(nudOngkir.Value) + CLng(nudPajak.Value)
        nudBayar.Properties.MaxValue = nudTotal.Value
        If luePayment.EditValue = CLng(1) Then
            nudBayar.Value = nudTotal.Value
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim bEntry As Boolean = True
        Dim sEntry As String = String.Empty
        If gvData.RowCount = 0 Then
            bEntry = False
            If sEntry.Length = 0 Then
                sEntry = "Item masih kosong"
            Else
                sEntry &= vbCrLf & "Item masih kosong"
            End If
        End If
        If gvData.RowCount > 0 Then
            For i As Integer = 0 To gvData.RowCount - 1
                Dim dr As DataRow = gvData.GetDataRow(i)
                If dr("price") = 0 Then
                    bEntry = False
                    If sEntry.Length = 0 Then
                        sEntry = "Harga ada yang nol"
                    Else
                        sEntry &= vbCrLf & "Harga ada yang nol"
                    End If
                    Exit For
                End If
                If dr("qty") = 0 Then
                    bEntry = False
                    If sEntry.Length = 0 Then
                        sEntry = "Qty ada yang nol"
                    Else
                        sEntry &= vbCrLf & "Qty ada yang nol"
                    End If
                    Exit For
                End If
            Next
        End If
        If luePayment.EditValue Is Nothing Then
            bEntry = False
            If sEntry.Length = 0 Then
                sEntry = "Pembayaran belum dipilih"
            Else
                sEntry &= vbCrLf & "Pembayaran belum dipilih"
            End If
        End If
        If lueJenis.EditValue Is Nothing Then
            bEntry = False
            If sEntry.Length = 0 Then
                sEntry = "Jenis PO belum dipilih"
            Else
                sEntry &= vbCrLf & "Jenis PO belum dipilih"
            End If
        End If
        If bEntry = False Then
            dizMsgbox("Isian belum valid" & vbCrLf & sEntry, dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If nudBayar.Value = 0 Then
            If dizMsgbox("Nominal bayar masih nol" & vbCrLf & "Tetap melanjutkan ?", dizMsgboxStyle.konfirmasi, Me) = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If
        If nudOngkir.Value = 0 Then
            If dizMsgbox("Ongkos kirim masih nol" & vbCrLf & "Tetap melanjutkan ?", dizMsgboxStyle.konfirmasi, Me) = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If
        Dim retval As Boolean = False
        Dim dsql As New dtsetSQLS(dbstring)
        Dim sqls As New SQLs(dbstring)
        Dim hashcode As String = GenerateUniqueID(GenerateHash("PO" & Format(nowTime, "ddMMyyyyHHmmssff")), 1000)
        Dim hf As New List(Of String)
        Dim hv As New List(Of Object)
        Dim df As New List(Of String)
        Dim dv As New List(Of Object)
        Dim isf As New List(Of String)
        Dim isv As New List(Of Object)

        Dim tmpiddata As String = 0
        Dim pair As KeyValuePair(Of String, String) = generatePO()
        Dim idtrans As String = pair.Key
        Dim notrans As String = pair.Value
        teKode.Text = notrans

        dsql = New dtsetSQLS(dbstring)
        sqls = New SQLs(dbstring)

        Dim idreff As String
        Dim trftypereff As String = ""
        If teNoPermintaan.Tag <> -1 Then
            sqls.DMLQuery("select idtransactiontype from transactiontype where kodetransaksi='111'", "idttype")
            idreff = teNoPermintaan.Tag
            trftypereff = sqls.getDataSet("idttype", 0, "idtransactiontype")
        End If
        sqls.DMLQuery("select businesspartnertype,kode,npwp,phone,alamat from businesspartner where idbusinesspartner='" & lueSupplier.EditValue & "'", "bp")
        idData = GenerateGUID()

        If teNoPermintaan.Tag = -1 Then
            hf.AddRange(New String() {"idtransaksi", "transaksitype", "idunitasal", "unitasal", "idbusinesspartner", "businesspartnertype", "transaksino", "transaksistatus", "kodepartner", "namapartner", "npwp", "phone", "email", "alamat", "contactperson", "paymenttype", "isdeleted", "remarks", "subtotal", "discglobal", "discsubtotal", "subtotaldisc", "ppnsubtotal", "subtotaldiscppn", "ongkir", "subtotaldiscppnongkir", "createdby", "createddate", "createdfromip", "createdfromhostname", "hashcode"})
            hv.AddRange(New Object() {idData, idtrans, lueUnit.EditValue, lueUnit.Text, lueSupplier.EditValue, sqls.getDataSet("bp", 0, "businesspartnertype"), notrans, 1, sqls.getDataSet("bp", 0, "kode"), lueSupplier.Text, sqls.getDataSet("bp", 0, "npwp"), sqls.getDataSet("bp", 0, "phone"), teEmail.Text, sqls.getDataSet("bp", 0, "alamat"), teCP.Text, luePayment.EditValue, 0, teNote.Text, nudSubtotal.Value, nudDiskonGlobal.Value, nudDiskon.Value, (nudDiskonGlobal.Value + nudDiskon.Value), nudPajak.Value, (nudDiskonGlobal.Value + nudDiskon.Value + nudPajak.Value), nudOngkir.Value, (nudDiskonGlobal.Value + nudDiskon.Value + nudOngkir.Value), userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), hashcode})
        Else
            If lueJenis.EditValue = 1 Then
                hf.AddRange(New String() {"idtransaksi", "transaksitype", "idtransaksireff", "transaksitypereff", "idunitasal", "unitasal", "idbusinesspartner", "businesspartnertype", "transaksino", "transaksistatus", "kodepartner", "namapartner", "npwp", "phone", "email", "alamat", "contactperson", "paymenttype", "isdeleted", "remarks", "subtotal", "discglobal", "discsubtotal", "subtotaldisc", "ppnsubtotal", "subtotaldiscppn", "ongkir", "subtotaldiscppnongkir", "createdby", "createddate", "createdfromip", "createdfromhostname", "hashcode"})
                hv.AddRange(New Object() {idData, idtrans, idreff, trftypereff, lueUnit.EditValue, lueUnit.Text, lueSupplier.EditValue, sqls.getDataSet("bp", 0, "businesspartnertype"), notrans, 1, sqls.getDataSet("bp", 0, "kode"), lueSupplier.Text, sqls.getDataSet("bp", 0, "npwp"), sqls.getDataSet("bp", 0, "phone"), teEmail.Text, sqls.getDataSet("bp", 0, "alamat"), teCP.Text, luePayment.EditValue, 0, teNote.Text, nudSubtotal.Value, nudDiskonGlobal.Value, nudDiskon.Value, (nudDiskonGlobal.Value + nudDiskon.Value), nudPajak.Value, (nudDiskonGlobal.Value + nudDiskon.Value + nudPajak.Value), nudOngkir.Value, (nudDiskonGlobal.Value + nudDiskon.Value + nudOngkir.Value), userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), hashcode})
            ElseIf lueJenis.EditValue = 2 Then
                hf.AddRange(New String() {"idtransaksi", "transaksitype", "idtransaksireff", "transaksitypereff", "idunitasal", "unitasal", "idbusinesspartner", "businesspartnertype", "transaksino", "transaksistatus", "kodepartner", "namapartner", "npwp", "phone", "email", "alamat", "contactperson", "paymenttype", "isdeleted", "remarks", "subtotal", "discglobal", "discsubtotal", "subtotaldisc", "ppnsubtotal", "subtotaldiscppn", "ongkir", "subtotaldiscppnongkir", "createdby", "createddate", "createdfromip", "createdfromhostname", "hashcode"})
                hv.AddRange(New Object() {idData, idtrans, idreff, trftypereff, lueUnit.EditValue, lueUnit.Text, lueSupplier.EditValue, sqls.getDataSet("bp", 0, "businesspartnertype"), notrans, 7, sqls.getDataSet("bp", 0, "kode"), lueSupplier.Text, sqls.getDataSet("bp", 0, "npwp"), sqls.getDataSet("bp", 0, "phone"), teEmail.Text, sqls.getDataSet("bp", 0, "alamat"), teCP.Text, luePayment.EditValue, 0, teNote.Text, nudSubtotal.Value, nudDiskonGlobal.Value, nudDiskon.Value, (nudDiskonGlobal.Value + nudDiskon.Value), nudPajak.Value, (nudDiskonGlobal.Value + nudDiskon.Value + nudPajak.Value), nudOngkir.Value, (nudDiskonGlobal.Value + nudDiskon.Value + nudOngkir.Value), userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), hashcode})
            End If
        End If

        retval = dsql.datasetSave("transaksi", idData, hf, hv, False)

        If nudBayar.Value > 0 Then
            Dim hashpay As String = GenerateUniqueID(GenerateHash("PAY" & Format(nowTime, "ddMMyyyyHHmmssff")), 1000)
            Dim pairpay As KeyValuePair(Of String, String) = generatePAY()
            Dim idpay As String = pairpay.Key
            Dim nopay As String = pairpay.Value
            Dim fp As New List(Of String)
            Dim vp As New List(Of Object)
            Dim pset As New dtsetSQLS(dbstring)
            If luePayment.EditValue = 1 Then
                pset = New dtsetSQLS(dbstring)
                fp.Clear()
                vp.Clear()

                Dim idpayment As String = GenerateGUID()
                sqls.DMLQuery("select idgeneral from sys_generalcode where generalcode='CASH' and gctype='PAYMETHOD'", "idcash")
                fp.AddRange(New String() {"idpayment", "transaksitype", "paymentno", "remarks", "isdeleted", "createdby", "createddate", "totalpayment", "paymentmethod", "hashcode"})
                vp.AddRange(New Object() {idpayment, idpay, nopay, "LUNAS", 0, userid, nowTime, nudBayar.Value, sqls.getDataSet("idcash", 0, "idgeneral"), hashpay})
                pset.datasetSave("payment", idpayment, fp, vp, False)

                Dim iddtmp As String = GenerateGUID()
                pset = New dtsetSQLS(dbstring)
                fp.Clear()
                vp.Clear()
                fp.AddRange(New String() {"idpaymentdt", "idpayment", "idtransaksi", "totalpayment"})
                vp.AddRange(New Object() {iddtmp, idpayment, idData, nudBayar.Value})
                pset.datasetSave("paymentdt", iddtmp, fp, vp, False)
            ElseIf luePayment.EditValue = 2 Then
                pset = New dtsetSQLS(dbstring)
                fp.Clear()
                vp.Clear()

                Dim idpayment As String = GenerateGUID()
                sqls.DMLQuery("select idgeneral from sys_generalcode where generalcode='DOWN PAYMENT' and gctype='PAYMETHOD'", "iddp")
                fp.AddRange(New String() {"idpayment", "transaksitype", "paymentno", "remarks", "isdeleted", "createdby", "createddate", "totalpayment", "paymentmethod", "hashcode"})
                vp.AddRange(New Object() {idpayment, idpay, nopay, "DOWN PAYMENT", 0, userid, nowTime, nudBayar.Value, sqls.getDataSet("iddp", 0, "idgeneral"), hashpay})
                pset.datasetSave("payment", idpayment, fp, vp, False)

                Dim iddtmp As String = GenerateGUID()
                pset = New dtsetSQLS(dbstring)
                fp.Clear()
                vp.Clear()
                fp.AddRange(New String() {"idpaymentdt", "idpayment", "idtransaksi", "totalpayment"})
                vp.AddRange(New Object() {iddtmp, idpayment, idData, nudBayar.Value})
                pset.datasetSave("paymentdt", iddtmp, fp, vp, False)
            End If
        End If

        If lueJenis.EditValue = 2 Then
            Threading.Thread.Sleep(1000)

            sqls.DMLQuery("select idtransactiontype from transactiontype where kodetransaksi='112'", "idrcvttype")
            Dim idreffrcv As String = idData
            Dim trfrefftypereff As String = sqls.getDataSet("idrcvttype", 0, "idtransactiontype")

            Dim idreceive As String = GenerateGUID()
            Dim pairrcv As KeyValuePair(Of String, String) = generateRCV()
            Dim idrcv As Long = pairrcv.Key
            Dim norcv As String = pairrcv.Value
            hf.Clear()
            hv.Clear()
            hf.AddRange(New String() {"idtransaksi", "transaksitype", "idtransaksireff", "transaksitypereff", "idunitasal", "unitasal", "idbusinesspartner", "businesspartnertype", "transaksino", "transaksistatus", "kodepartner", "namapartner", "npwp", "phone", "email", "alamat", "contactperson", "paymenttype", "isdeleted", "remarks", "subtotal", "discglobal", "discsubtotal", "subtotaldisc", "ppnsubtotal", "subtotaldiscppn", "ongkir", "subtotaldiscppnongkir", "createdby", "createddate", "createdfromip", "createdfromhostname"})
            hv.AddRange(New Object() {idreceive, idrcv, idreffrcv, idtrans, lueUnit.EditValue, lueUnit.Text, lueSupplier.EditValue, sqls.getDataSet("bp", 0, "businesspartnertype"), norcv, 7, sqls.getDataSet("bp", 0, "kode"), lueSupplier.Text, sqls.getDataSet("bp", 0, "npwp"), sqls.getDataSet("bp", 0, "phone"), teEmail.Text, sqls.getDataSet("bp", 0, "alamat"), teCP.Text, luePayment.EditValue, 0, teNote.Text, nudSubtotal.Value, nudDiskonGlobal.Value, nudDiskon.Value, (nudDiskonGlobal.Value + nudDiskon.Value), nudPajak.Value, (nudDiskonGlobal.Value + nudDiskon.Value + nudPajak.Value), nudOngkir.Value, (nudDiskonGlobal.Value + nudDiskon.Value + nudOngkir.Value), userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
            retval = dsql.datasetSave("transaksi", idreceive, hf, hv, False)
        End If

        For i As Integer = 0 To gvData.RowCount - 1
            df.Clear()
            dv.Clear()

            Dim dr As DataRow = gvData.GetDataRow(i)
            sqls = New SQLs(dbstring)
            dsql = New dtsetSQLS(dbstring)

            df.AddRange(New String() {"idtransaksidt", "idtransaksi", "iditem", "idsatuan", "kodeitem", "item", "itemtype", "type", "qty", "satuan", "price", "subtotal", "isdeleted", "disctype", "discpersen", "discamount", "discsubtotal", "subtotaldisc", "ongkoslain", "subtotaldisclain", "isppn", "ppnamount", "subtotaldisclainppn", "createdby", "createddate", "createdfromip", "createdfromhostname"})
            dsql.DMLQuery("select i.idsatuan,i.kode,i.item,i.itemtype,t.generalcode as stritemtype,s.satuan from item i left join satuan s on i.idsatuan=s.idsatuan left join sys_generalcode t on i.itemtype=t.idgeneralcode and t.gctype='ITEMTYPE' where i.iditem=" & dr("iditem"), "item")
            dv.AddRange(New Object() {-1, idData, dr("iditem"), dr("idsatuan"), dr("kode"), dr("item"), dr("itemtype"), dr("type"), dr("qty"), dr("satuan"), dr("price"), dr("subtotal"), 0, 1, dr("discpersen"), dr("discamount"), CLng(dr("discamount")) * CLng(dr("qty")), CLng(dr("subtotal")) - (CLng(dr("discamount")) * CLng(dr("qty"))), 0, CLng(dr("subtotal")) - (CLng(dr("discamount")) * CLng(dr("qty"))), 1, 0.1 * (CLng(dr("subtotal")) - (CLng(dr("discamount")) * CLng(dr("qty")))), 0.9 * (CLng(dr("subtotal")) - (CLng(dr("discamount")) * CLng(dr("qty")))), userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
            dsql.datasetSave("transaksidt", -1, df, dv, False)

            isf.Clear()
            isv.Clear()

            sqls.DMLQuery("select iditemsupplier from itemsupplier where isdeleted=0 and iditem=" & dr("iditem") & " and idsupplier=" & lueSupplier.EditValue, "is")
            If sqls.getDataSet("is") = 0 Then
                isf.AddRange(New String() {"iditemsupplier", "iditem", "idsupplier", "disctype", "discpersen", "discamount", "price", "isdeleted", "createdby", "createddate"})
                isv.AddRange(New Object() {-1, dr("iditem"), lueSupplier.EditValue, 1, dr("discpersen"), dr("discamount"), dr("price"), 0, userid, nowTime})
                dsql = New dtsetSQLS(dbstring)
                dsql.datasetSave("itemsupplier", -1, isf, isv, False)
            Else
                isf.AddRange(New String() {"iditemsupplier", "iditem", "idsupplier", "disctype", "discpersen", "discamount", "price", "isdeleted", "updatedby", "updateddate"})
                isv.AddRange(New Object() {sqls.getDataSet("is", 0, "iditemsupplier"), dr("iditem"), lueSupplier.EditValue, 1, dr("discpersen"), dr("discamount"), dr("price"), 0, userid, nowTime})
                dsql = New dtsetSQLS(dbstring)
                dsql.datasetSave("itemsupplier", sqls.getDataSet("is", 0, "iditemsupplier"), isf, isv, False)
            End If

            If lueJenis.EditValue = 2 Then
                df.Clear()
                dv.Clear()

                sqls = New SQLs(dbstring)
                dsql = New dtsetSQLS(dbstring)

                df.AddRange(New String() {"idtransaksidt", "idtransaksi", "iditem", "idsatuan", "kodeitem", "item", "itemtype", "type", "qty", "satuan", "price", "subtotal", "isdeleted", "disctype", "discpersen", "discamount", "discsubtotal", "subtotaldisc", "ongkoslain", "subtotaldisclain", "isppn", "ppnamount", "subtotaldisclainppn", "createdby", "createddate", "createdfromip", "createdfromhostname"})
                dsql.DMLQuery("select i.idsatuan,i.kode,i.item,i.itemtype,t.generalcode as stritemtype,s.satuan from item i left join satuan s on i.idsatuan=s.idsatuan left join sys_generalcode t on i.itemtype=t.idgeneralcode and t.gctype='ITEMTYPE' where i.iditem=" & dr("iditem"), "item")
                dv.AddRange(New Object() {-1, tmpiddata, dr("iditem"), dr("idsatuan"), dr("kode"), dr("item"), dr("itemtype"), dr("type"), dr("qty"), dr("satuan"), dr("price"), dr("subtotal"), 0, 1, dr("discpersen"), dr("discamount"), CLng(dr("discamount")) * CLng(dr("qty")), CLng(dr("subtotal")) - (CLng(dr("discamount")) * CLng(dr("qty"))), 0, CLng(dr("subtotal")) - (CLng(dr("discamount")) * CLng(dr("qty"))), 1, 0.1 * (CLng(dr("subtotal")) - (CLng(dr("discamount")) * CLng(dr("qty")))), 0.9 * (CLng(dr("subtotal")) - (CLng(dr("discamount")) * CLng(dr("qty")))), userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
                dsql.datasetSave("transaksidt", -1, df, dv, False)

                df.Clear()
                dv.Clear()

                sqls = New SQLs(dbstring)
                dsql = New dtsetSQLS(dbstring)

                sqls.DMLQuery("select iu.iditemunit,i.idsatuan,i.kode,i.item,i.itemtype,t.generalcode as stritemtype,s.satuan,iu.qty,iu.price,iu.priceavg from item i left join itemunit iu on i.iditem=iu.iditem join satuan s on i.idsatuan=s.idsatuan left join sys_generalcode t on i.itemtype=t.idgeneralcode and t.gctype='ITEMTYPE' where iu.idunit=" & lueUnit.EditValue & " and iu.iditem=" & dr("iditem"), "iu")
                Dim priceavg As Long = 0
                Dim qty As Long = 0
                Dim iu As Long = -1
                If sqls.getDataSet("iu") > 0 Then
                    priceavg = sqls.getDataSet("iu", 0, "priceavg")
                    qty = CLng(dr("qty")) + CLng(sqls.getDataSet("iu", 0, "qty"))
                    iu = sqls.getDataSet("iu", 0, "iditemunit")
                Else
                    priceavg = CLng(dr("price")) - CLng(dr("discamount"))
                    qty = CLng(dr("qty"))
                    iu = -1
                End If
                Dim pricebeli As Long = CLng(dr("price")) - CLng(dr("discamount"))
                priceavg = (priceavg + pricebeli) / 2

                If iu = -1 Then
                    df.AddRange(New String() {"iditemunit", "iditem", "idunit", "qty", "price", "priceavg", "createdby", "createddate"})
                    dv.AddRange(New Object() {iu, dr("iditem"), lueUnit.EditValue, qty, pricebeli, priceavg, userid, nowTime})
                Else
                    df.AddRange(New String() {"iditemunit", "iditem", "idunit", "qty", "price", "priceavg", "updatedby", "updateddate"})
                    dv.AddRange(New Object() {iu, dr("iditem"), lueUnit.EditValue, qty, pricebeli, priceavg, userid, nowTime})
                End If
                dsql.datasetSave("itemunit", iu, df, dv, False)
            End If
        Next
        dizMsgbox("Data Pembelian telah tersimpan", dizMsgboxStyle.info, Me)
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Function generatePO() As KeyValuePair(Of String, String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idtransactiontype,formatstring,formatperiode,positionnumber,digitnumber from transactiontype where kodetransaksi='121'", "getformat")

        Dim idtrans As String = sqls.getDataSet("getformat", 0, "idtransactiontype")
        Dim formatstr As String = sqls.getDataSet("getformat", 0, "formatstring")
        Dim formatperiode As String = sqls.getDataSet("getformat", 0, "formatperiode")
        Dim posnumber As String = sqls.getDataSet("getformat", 0, "positionnumber")
        Dim digitno As String = sqls.getDataSet("getformat", 0, "digitnumber")

        Dim notrans As String = generateno1(formatstr, formatperiode, posnumber, digitno, False)
        Dim retval As New KeyValuePair(Of String, String)(idtrans, notrans)
        Return retval
    End Function

    Private Function generatePAY() As KeyValuePair(Of String, String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idtransactiontype,formatstring,formatperiode,positionnumber,digitnumber from transactiontype where kodetransaksi='211'", "getformat")

        Dim idtrans As String = sqls.getDataSet("getformat", 0, "idtransactiontype")
        Dim formatstr As String = sqls.getDataSet("getformat", 0, "formatstring")
        Dim formatperiode As String = sqls.getDataSet("getformat", 0, "formatperiode")
        Dim posnumber As String = sqls.getDataSet("getformat", 0, "positionnumber")
        Dim digitno As String = sqls.getDataSet("getformat", 0, "digitnumber")

        Dim notrans As String = generateNO(formatstr, formatperiode, posnumber, digitno)
        Dim retval As New KeyValuePair(Of String, String)(idtrans, notrans)
        Return retval
    End Function

    Private Function generateRCV() As KeyValuePair(Of String, String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idtransactiontype,formatstring,formatperiode,positionnumber,digitnumber from transactiontype where kodetransaksi='112'", "getformat")

        Dim idtrans As String = sqls.getDataSet("getformat", 0, "idtransactiontype")
        Dim formatstr As String = sqls.getDataSet("getformat", 0, "formatstring")
        Dim formatperiode As String = sqls.getDataSet("getformat", 0, "formatperiode")
        Dim posnumber As String = sqls.getDataSet("getformat", 0, "positionnumber")
        Dim digitno As String = sqls.getDataSet("getformat", 0, "digitnumber")

        Dim notrans As String = generateNO(formatstr, formatperiode, posnumber, digitno)
        Dim retval As New KeyValuePair(Of String, String)(idtrans, notrans)
        Return retval
    End Function

    Private Function generateNO(ByVal prefix As String, ByVal periodeformat As String, ByVal posisinomor As String, ByVal digitnomor As Integer) As String
        Dim retval As String = ""
        Dim mysqls As New SQLs(dbstring)
        Dim tblname As String = prefix & Format(nowTime, periodeformat)
        mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & "'", "GetLast")
        Dim idgen As Long = -1
        Dim formatStr As String = ""
        Dim currid As Long = 0
        Dim currStrId As String = ""
        Dim posnumber As String = ""
        Dim lenStr As String = ""
        Dim lenId As Long = 0

        If mysqls.getDataSet("GetLast") = 0 Then
            formatStr = prefix & "-" & Format(nowTime, periodeformat)
            currid = 1
            posnumber = posisinomor
            lenId = digitnomor
        Else
            idgen = mysqls.getDataSet("GetLast", 0, "idgeneratenumber")

            formatStr = prefix & "-" & Format(nowTime, periodeformat) 'mysqls.getDataSet("GetLast", 0, "formatstring")
            currid = CInt(mysqls.getDataSet("GetLast", 0, "lastnumber")) + 1
            posnumber = mysqls.getDataSet("GetLast", 0, "positionnumber")
            lenId = CInt(mysqls.getDataSet("GetLast", 0, "digitnumber"))
        End If
        For i As Integer = 0 To lenId - 1
            If i = 0 Then
                lenStr = "0"
            Else
                lenStr &= "#"
            End If
        Next
        currStrId = Format(currid, lenStr)

        If posnumber.ToLower = "belakang" Then
            retval = formatStr & "-" & currStrId
        ElseIf posnumber.ToLower = "tengah" Then
            formatStr = prefix & "-" & currStrId & "-" & Format(nowTime, periodeformat)
            retval = formatStr
        ElseIf posnumber.ToLower = "depan" Then
            retval = currStrId & "-" & formatStr
        End If

        Dim dtsave As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idgeneratenumber", "tablename", "formatstring", "lastnumber", "positionnumber", "digitnumber"})
        value.AddRange(New String() {idgen, tblname, formatStr, currid, posnumber, lenId})
        dtsave.datasetSave("sys_generatenumber", idgen, field, value, False)

        Return retval
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring)
        Dim dset As New DataSet
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,'' as nopermintaan,t.namapartner,t.email,convert(varchar,t.createddate,105) +' ' + convert(varchar,t.createddate,108) as createddate,t.namapartner,t.idunitasal,t.contactperson,t.remarks from transaksi t where t.transaksitype=(select idtransactiontype from transactiontype where kodetransaksi='121') and t.transaksistatus=1 and t.isdeleted=0", "gettotal")
        dset = sqls.dataSet
        Dim cari As New frmSearch(dset, "gettotal", "idtransaksi")
        tambahChild(cari)
        If cari.ShowDialog() = Windows.Forms.DialogResult.OK Then
            idData = cari.GetIDSelectData

            sqls.DMLQuery("select h.idtransaksi,h.paymenttype,h.subtotal,h.discsubtotal,h.discglobal,h.ppnsubtotal,h.ongkir,h.subtotaldiscppnongkir,h.transaksino,isnull(h.idtransaksireff,-1) as idtransaksireff,isnull(r.transaksino,'') as refftransaksino,h.idbusinesspartner,h.idunitasal,h.unitasal,isnull(h.remarks,'') as remarks,isnull(h.email,0) as email,isnull(h.contactperson,'') as contactperson,convert(varchar,h.createddate,105) as tanggal from transaksi h left join transaksi r on h.idtransaksireff=r.idtransaksi where h.idtransaksi=" & idData, "header")

            teKode.Text = sqls.getDataSet("header", 0, "transaksino")
            teNoPermintaan.Text = sqls.getDataSet("header", 0, "refftransaksino")
            teNoPermintaan.Tag = sqls.getDataSet("header", 0, "idtransaksireff")
            lueSupplier.EditValue = sqls.getDataSet("header", 0, "idbusinesspartner")
            teEmail.Text = sqls.getDataSet("header", 0, "email")

            Dim strtgl As String = sqls.getDataSet("header", 0, "createddate")
            deTanggal.EditValue = New Date(strtgl.Split(" ")(0).Split("-")(2), strtgl.Split(" ")(0).Split("-")(1), strtgl.Split(" ")(0).Split("-")(0), strtgl.Split(" ")(1).Split(":")(0), strtgl.Split(" ")(1).Split(":")(1), strtgl.Split(" ")(1).Split(":")(2))
            lueUnit.EditValue = sqls.getDataSet("header", 0, "idunitasal")
            teCP.Text = sqls.getDataSet("header", 0, "contactperson")
            teNote.Text = sqls.getDataSet("header", 0, "remarks")

            luePayment.EditValue = sqls.getDataSet("header", 0, "paymenttype")
            nudSubtotal.Value = sqls.getDataSet("header", 0, "subtotal")
            nudDiskon.Value = sqls.getDataSet("header", 0, "discsubtotal")
            nudDiskonGlobal.Value = sqls.getDataSet("header", 0, "discglobal")
            nudPajak.Value = sqls.getDataSet("header", 0, "ppnsubtotal")

            sqls.DMLQuery("select idtransaksireff from transaksi where transaksitypereff=(select idtransactiontype from transactiontype where kodetransaksi='112') and idtransaksireff=" & idData, "cekreff")
            sqls.DMLQuery("select p.paymentmethod,d.totalpayment from payment p left join paymentdt d on p.idpayment=d.idpayment where d.idtransaksi=" & idData, "cekpayment")
            If sqls.getDataSet("cekpayment") = 0 Then
                nudBayar.Value = 0
            Else
                nudBayar.Value = sqls.getDataSet("cekpayment", 0, "totalpayment")
                sqls.DMLQuery("select idgeneral from sys_generalcode where generalcode='DOWN PAYMENT' and gctype='PAYMETHOD'", "iddp")
                sqls.DMLQuery("select idgeneral from sys_generalcode where generalcode='CASH' and gctype='PAYMETHOD'", "idcash")
                If sqls.getDataSet("cekpayment", 0, "paymentmethod") = sqls.getDataSet("idcash", 0, "idgeneral") Then
                    luePayment.EditValue = CLng(1)
                ElseIf sqls.getDataSet("cekpayment", 0, "paymentmethod") = sqls.getDataSet("iddp", 0, "idgeneral") Then
                    luePayment.EditValue = CLng(2)
                End If
            End If

            If sqls.getDataSet("cekreff") = 0 Then
                lueJenis.EditValue = CLng(1)
            Else
                lueJenis.EditValue = CLng(2)
            End If
            deTerima.EditValue = New Date(strtgl.Split(" ")(0).Split("-")(2), strtgl.Split(" ")(0).Split("-")(1), strtgl.Split(" ")(0).Split("-")(0), strtgl.Split(" ")(1).Split(":")(0), strtgl.Split(" ")(1).Split(":")(1), strtgl.Split(" ")(1).Split(":")(2))
            nudOngkir.Value = sqls.getDataSet("header", 0, "ongkir")

            sqls.DMLQuery("select d.idtransaksidt,d.idtransaksi,d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,d.discamount,d.discpersen,d.price,(isnull(su.price,0)*d.qty)-(isnull(su.discamount,0)*d.qty) as subtotal,d.qty from transaksidt d where d.idtransaksi=" & idData, "detail")
            gcData.DataSource = sqls.dataTable("detail")

            btnDeleteAllItem.Enabled = False
            btnDeleteItem.Enabled = False
            lueUnit.ForeColor = Color.Black
            lueUnit.Properties.ReadOnly = False
            lueUnit.BackColor = canWrite
            lueUnit.Enabled = True
            btnLockUnit_Click(btnLockUnit, Nothing)
            btnLockUnit.Enabled = False
            teNote.ForeColor = Color.Black
            teNote.BackColor = justRead
            teNote.Properties.ReadOnly = True
            teNote.Enabled = False
            gcQty.OptionsColumn.AllowEdit = False
            gcQty.OptionsColumn.ReadOnly = True
            gcQty.AppearanceCell.BackColor = justRead

            btnSearch.Enabled = True
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnDelete.Enabled = True
            btnDelete.Text = "VOID"
            statData = statusData.Baru
        Else
            teNoPermintaan.Tag = -1
            If gvData.RowCount = 0 Then
                btnNew_Click(btnNew, Nothing)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click

    End Sub

End Class