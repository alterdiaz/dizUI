Imports DevExpress.XtraGrid.Views.Base

Public Class frmPermintaanFarmasiNQLMA
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

    Private Sub loadItem(ByVal idunit As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@idunit"})
        value.AddRange(New Object() {idunit})
        sqls.CallSP("spLoadLOVItemFarmasiNQ", "getitem", field, value)
        gcItem.DataSource = sqls.dataTable("getitem")
    End Sub

    Private Sub loadUnit(idunit As List(Of String))
        Dim sqls As New SQLs(dbstring)
        Dim str As String = ""
        If idunit.Count > 0 Then
            For i As Integer = 0 To idunit.Count - 1
                str &= "'" & idunit(i) & "'"
                If i <> idunit.Count - 1 Then
                    str &= ","
                End If
            Next
            'str = String.Join(",", idunit)
            sqls.DMLQuery("select u.idunit as id,u.unit as content from unit u where u.isdeleted=0 and u.idunit in (" & str & ")", "getunit")
        Else
            If usersuper = 1 Then
                sqls.DMLQuery("select u.idunit as id,u.unit as content from unit u where u.isdeleted=0 and u.idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit')) ", "getunit")
            End If
        End If

        lueUnit.Properties.DataSource = sqls.dataTable("getunit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
        If sqls.getDataSet("getunit") = 1 Then
            lueUnit.EditValue = sqls.getDataSet("getunit", 0, "id")
            btnLock_Click(btnLock, Nothing)
        Else
            lueUnit.EditValue = Nothing
        End If
    End Sub

    Private dttbl As New DataTable
    Private Sub loadgrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select '-' as idtransaksidt,i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty,0 as qtylalu,0 as qtyask,'-' as remarks from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where 1=0", "getnull")
        dttbl = sqls.dataTable("getnull")
        gcData.DataSource = dttbl
    End Sub

    Private Sub frmPermintaanFarmasi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.Properties.ReadOnly = True
        deTanggal.Enabled = False
        deTanggal.Properties.AppearanceDisabled.ForeColor = Color.Black
        deTanggal.Properties.AppearanceReadOnly.ForeColor = Color.Black

        teKode.Properties.ReadOnly = True
        teKode.Enabled = False
        teKode.Properties.AppearanceDisabled.ForeColor = Color.Black
        teKode.Properties.AppearanceReadOnly.ForeColor = Color.Black

        For i As Integer = 0 To gvData.Columns.Count - 1
            Dim col As New DevExpress.XtraGrid.Columns.GridColumn
            col = gvData.Columns.Item(i)
            col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            col.OptionsFilter.AllowFilter = False
            col.OptionsFilter.AllowAutoFilter = False
        Next
        For i As Integer = 0 To gvItem.Columns.Count - 1
            Dim col As New DevExpress.XtraGrid.Columns.GridColumn
            col = gvData.Columns.Item(i)
            col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            col.OptionsFilter.AllowFilter = False
            col.OptionsFilter.AllowAutoFilter = False
        Next

        seQty.MinValue = 0
        seQty.MaxValue = 1000
        sccForm.SplitterPosition = sccForm.Width - 275
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select * from sys_appsetting where variable='DaysSPF' and value like '%" & nowTime.DayOfWeek & "%'", "getdays")
        If sqls.getDataSet("getdays") = 0 Then
            dizMsgbox("Hari ini bukan hari permintaan Farmasi", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Me.Dispose()
            Exit Sub
        End If

        checkFieldMaxLength(dbstring, tlpField, "transaksi")
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private idunit2 As New List(Of String)
    Private iddept2 As New List(Of String)
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadgrid()
        kosongkanIsian(tlpField)

        idData = "-1"
        isVoid = False
        teKode.Text = "XXXX/XXX/XXX/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teKode.ReadOnly = True
        deTanggal.EditValue = nowTime
        deTanggal.ReadOnly = True
        btnDeleteAllItem.Enabled = True
        btnDeleteItem.Enabled = True

        btnLock.BackColor = Color.FromArgb(156, 207, 49)
        teNote.ReadOnly = False
        lueUnit.ReadOnly = False
        lueUnit.EditValue = Nothing
        xtcItem.Enabled = False

        gcData.Enabled = True
        btnLock.Enabled = True
        gcQty.OptionsColumn.ReadOnly = False
        gcQtyAsk.OptionsColumn.ReadOnly = False
        gcQtyLalu.OptionsColumn.ReadOnly = False
        gcQty.OptionsColumn.AllowEdit = True
        gcQtyAsk.OptionsColumn.AllowEdit = True
        gcQtyLalu.OptionsColumn.AllowEdit = True

        btnSearch.Enabled = True
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "VOID"
        statData = statusData.Baru

        If usersuper = 1 Then
            Dim selkary As New frmSelectKaryawan2()
            tambahChild(selkary)
            If selkary.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
            Dim tmpstaffid As String = ""
            tmpstaffid = selkary.getID(0)
            selkary.Dispose()

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iddepartment,idunit from staff where idstaff='" & tmpstaffid & "' order by createddate desc", "getDU")
            If sqls.getDataSet("getDU") > 0 Then
                idunit2.Clear()
                iddept2.Clear()
                For i As Integer = 0 To sqls.getDataSet("getDU") - 1
                    idunit2.Add(sqls.getDataSet("getDU", 0, "idunit"))
                    iddept2.Add(sqls.getDataSet("getDU", 0, "iddepartment"))
                Next
                loadUnit(idunit2)
            Else
                btnSave.Enabled = False
                btnLock.Enabled = False
            End If
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iddepartment,idunit from staff where iduser='" & userid & "' order by createddate desc", "getDU")
            If sqls.getDataSet("getDU") > 0 Then
                idunit2.Clear()
                iddept2.Clear()
                For i As Integer = 0 To sqls.getDataSet("getDU") - 1
                    idunit2.Add(sqls.getDataSet("getDU", 0, "idunit"))
                    iddept2.Add(sqls.getDataSet("getDU", 0, "iddepartment"))
                Next
                loadUnit(idunit2)
            Else
                dizMsgbox("User anda tidak memiliki data karyawan", dizMsgboxStyle.Kesalahan, Me)
                btnSave.Enabled = False
                btnLock.Enabled = False
            End If
        End If
    End Sub

    Private Sub lueUnit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueUnit.EditValueChanged
        If lueUnit.EditValue Is Nothing Then
            gcItem.DataSource = Nothing
            loadgrid()
            Exit Sub
        End If

        loadItem(lueUnit.EditValue)
        loadgrid()
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
                    dr("idtransaksidt") = GenerateGUID()
                    dr("iditem") = dra("iditem")
                    sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where i.iditem='" & dra("iditem") & "'", "dataitem")
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("remarks") = "-"
                    dr("qty") = 0
                    dr("qtylalu") = 0
                    dr("qtyask") = 0
                    dttbl.Rows.Add(dr)
                End If
                dra("cek") = 0
            End If
        Next
        gcData.DataSource = dttbl
    End Sub

    Dim idtrans As String
    Dim notrans As String
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        save(False)
    End Sub

    Private Sub btnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLock.Click
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

            teKode.Text = ""
            btnLock.ForeColor = Color.White
            btnLock.BackColor = Color.FromArgb(156, 207, 49)
            lueUnit.ReadOnly = False
            xtcItem.Enabled = False
            loadgrid()
        Else
            If gvItem.RowCount = 0 Then
                dizMsgbox("Item pada unit tidak tersedia", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            Dim pair As KeyValuePair(Of String, String) = generateno2(idunit2(lueUnit.ItemIndex), iddept2(lueUnit.ItemIndex), "Permintaan Farmasi", True)
            Dim idtrans As String = pair.Key
            Dim notrans As String = pair.Value
            teKode.Text = notrans

            btnLock.ForeColor = Color.White
            btnLock.BackColor = Color.Maroon
            lueUnit.ReadOnly = True
            xtcItem.Enabled = True


            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select t.idtransaksi,t.idtransaksireff,t.transaksitype,t.transaksitypereff,t.transaksino,t.transaksistatus,t.asaltype,t.idasal,t.iddeptasal,t.tujuantype,t.idtujuan,t.iddepttujuan,t.kodetujuan,t.namatujuan,t.npwp,t.phone,t.email,t.alamat,t.contactperson,t.paymenttype,t.isdeleted,t.remarks,t.subtotal,t.discglobal,t.discsubtotal,t.subtotaldisc,t.ppn,t.subtotaldiscppn,t.ongkir,t.subtotaldiscppnongkir,t.createdby,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,t.createdfromip,t.createdfromhostname,t.updatedby,convert(varchar,t.updateddate,105)+' '+convert(varchar,t.updateddate,108) as updateddate,t.updatedfromip,t.updatedfromhostname,convert(varchar,t.revieweddate,105)+' '+convert(varchar,t.revieweddate,108) as revieweddate,t.reviewedfromip,t.reviewedfromhostname,t.isdone,t.deletereason,t.reviewedby2,convert(varchar,t.revieweddate2,105)+' '+convert(varchar,t.revieweddate2,108) as revieweddate2,t.reviewedfromip2,t.reviewedfromhostname2,t.reviewedby3,convert(varchar,t.revieweddate3,105)+' '+convert(varchar,t.revieweddate3,108) as revieweddate3,t.reviewedfromip3,t.reviewedfromhostname3,t.idcompany,t.lockby,convert(varchar,t.lockdate,105)+' '+convert(varchar,t.lockdate,108) as lockdate,t.lockipaddress from transaksi t where convert(varchar,t.createddate,105)=convert(varchar,getdate(),105) and t.idasal='" & idunit2(lueUnit.ItemIndex) & "' and t.iddeptasal='" & iddept2(lueUnit.ItemIndex) & "' and t.transaksistatus=1", "cekhd")
            If sqls.getDataSet("cekhd") > 0 Then
                statData = statusData.Edit
                idtrans = sqls.getDataSet("cekhd", 0, "transaksitype")
                notrans = sqls.getDataSet("cekhd", 0, "transaksino")
                idData = sqls.getDataSet("cekhd", 0, "idtransaksi")
                teKode.Text = sqls.getDataSet("cekhd", 0, "transaksino")
                deTanggal.EditValue = Strdatetime2Datetime(sqls.getDataSet("cekhd", 0, "createddate"))
                teNote.Text = sqls.getDataSet("cekhd", 0, "remarks")

                sqls.DMLQuery("select dt.idtransaksidt,i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,dt.qtylalu as qty,dt.qtylalu,dt.qtyask,dt.qtyask as qtydispose,dt.qtyask as qtycharges,dt.remarks from transaksidt dt left join item i on dt.iditem=i.iditem left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan  where dt.idtransaksi='" & sqls.getDataSet("cekhd", 0, "idtransaksi") & "'", "cekdt")

                dttbl = sqls.dataTable("cekdt")
                gcData.DataSource = dttbl
            Else
                statData = statusData.Baru
                idData = "-1"
            End If
        End If
    End Sub

    Private Sub btnAllItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAllItem.Click
        If gvItem.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If dizMsgbox("Item terpilih sebanyak :  " & gvItem.RowCount & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
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
                    dr("idtransaksidt") = GenerateGUID()
                    dr("iditem") = dra("iditem")
                    sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where i.iditem='" & dra("iditem") & "'", "dataitem")
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("remarks") = "-"
                    dr("qty") = 0
                    dr("qtylalu") = 0
                    dr("qtyask") = 0
                    dttbl.Rows.Add(dr)
                End If
                dra("cek") = 0
            Next
            gcData.DataSource = dttbl
        End If
    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Item yang dipilih tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        Dim dr As DataRow = dttbl.Rows(gvData.FocusedRowHandle)
        If dizMsgbox("Item dibawah ini" & vbCrLf & "Item (" & dr("item") & ")" & vbCrLf & "Akan dihapus dari daftar, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("delete from transaksidt where idtransaksidt='" & dr("idtransaksidt") & "'", False)
            dttbl.Rows.Remove(dr)
            gcData.DataSource = dttbl
        End If
    End Sub

    Private Sub btnDeleteAllItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAllItem.Click
        If dizMsgbox("Item yang telah dipilih" & vbCrLf & "Akan dihapus keseluruhan dari daftar" & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            For i As Integer = 0 To gvData.RowCount - 1
                Dim dr As DataRow = dttbl.Rows(i)
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("delete from transaksidt where idtransaksidt='" & dr("idtransaksidt") & "'", False)
            Next
            loadgrid()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring)
        Dim dset As New DataSet
        If usersuper = 1 Then
            sqls.DMLQuery("select t.idtransaksi,t.transaksino,t.remarks,dt.counter as totalitem,dtot.total as totalFarmasi,c.username as createdby,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate from transaksi t left join sys_user c on t.createdby=c.iduser left join (select idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi) dtot on t.idtransaksi=dtot.idtransaksi where t.transaksitype in (select idtransactiontype from transactiontype where kodetransaksi = 'SPF') and t.isdeleted=0 and t.transaksistatus=1", "gettotal")
        Else
            sqls.DMLQuery("select t.idtransaksi,t.transaksino,t.remarks,dt.counter as totalitem,dtot.total as totalFarmasi,c.username as createdby,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,c.username as createdby from transaksi t left join sys_user c on t.createdby=c.iduser left join (select idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi) dtot on t.idtransaksi=dtot.idtransaksi where t.transaksitype in (select idtransactiontype from transactiontype where kodetransaksi = 'SPF' and iddepartment='" & iddept2(lueUnit.ItemIndex) & "' and idunit='" & idunit2(lueUnit.ItemIndex) & "') and t.isdeleted=0 and t.transaksistatus=1", "gettotal")
        End If
        dset = sqls.dataSet
        Dim cari As New frmSearch(dset, "gettotal", "idtransaksi")
        tambahChild(cari)
        If cari.ShowDialog() = Windows.Forms.DialogResult.OK Then
            idData = cari.GetIDSelectData

            sqls.DMLQuery("select h.idtransaksi,h.transaksino,h.idasal,h.asaltype,h.remarks,convert(varchar,h.createddate,105) as tanggal,convert(varchar,h.createddate,108) as waktu from transaksi h where h.idtransaksi='" & idData & "'", "header")
            teKode.Text = sqls.getDataSet("header", 0, "transaksino")
            lueUnit.EditValue = sqls.getDataSet("header", 0, "idasal")
            teNote.Text = sqls.getDataSet("header", 0, "remarks")
            Dim tmptgl As String = sqls.getDataSet("header", 0, "tanggal").ToString
            Dim tmpwaktu As String = sqls.getDataSet("header", 0, "waktu").ToString
            deTanggal.EditValue = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)

            sqls.DMLQuery("select d.idtransaksidt,d.idtransaksi,d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,d.qtylalu,d.qtyask,d.qtycharges as qty from transaksidt d where d.idtransaksi='" & idData & "'", "detail")
            gcData.DataSource = sqls.dataTable("detail")
            gcData.Enabled = False

            btnDeleteAllItem.Enabled = False
            btnDeleteItem.Enabled = False
            btnLock.Enabled = False
            teNote.ReadOnly = True
            lueUnit.ReadOnly = True
            deTanggal.ReadOnly = True
            deTanggal.Enabled = False
            teKode.ReadOnly = True
            xtcItem.Enabled = False
            gcQty.OptionsColumn.ReadOnly = True
            gcQtyAsk.OptionsColumn.ReadOnly = True
            gcQtyLalu.OptionsColumn.ReadOnly = True

            btnSearch.Enabled = True
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnDelete.Enabled = True
            btnDelete.Text = "VOID"
            statData = statusData.Edit
        Else
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dizMsgbox("Anda akan melakukan void Permintaan Farmasi ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then

            Dim reason As New frmDeleteReason
            Dim strreason As String = ""
            If reason.ShowDialog = Windows.Forms.DialogResult.OK Then
                If reason.reason.Length = 0 Then
                    dizMsgbox("Alasan pembatalan transaksi harus diisi", dizMsgboxStyle.Peringatan, "Peringatan", Me)
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
            strreason = "DELETE NOTE : " & vbCrLf & reason.reason

            Dim dtsets As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idtransaksi", "transaksistatus", "isdeleted", "deletereason", "updatedby", "updateddate", "updatedfromip", "updatedfromhostname"})
            value.AddRange(New Object() {idData, 2, 1, strreason, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
            dtsets.datasetSave("transaksi", idData, field, value, False)

            btnDelete.Enabled = False
            isVoid = True

            Dim bmp As Bitmap = My.Resources.stampVoid
            Dim hdc As Int32 = GetDC(0)
            Dim g As Graphics = Graphics.FromHdc(New IntPtr(hdc))
            g.DrawImage(bmp, CInt((Me.Width / 2) - (bmp.Width / 2)), CInt((Me.Height / 2) - (bmp.Height / 2)))
            ReleaseDC(0, hdc)
            g.Dispose()
            bmp.Dispose()
        End If
    End Sub

    Private Sub gvData_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvData.CellValueChanged
        If e.RowHandle < 0 Then
            Exit Sub
        End If
        If e.Column.FieldName = "remarks" Then
            If e.Value = "" Then
                gvData.SetFocusedRowCellValue(e.Column, "-")
            End If
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        save(True)
    End Sub

    Private Sub save(iscetak As Boolean)
        Dim bEntry As Boolean = False
        bEntry = checkEntry(tlpField)
        If gvData.RowCount > 0 Then bEntry = True
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            If dr("qtyask") = 0 Then
                bEntry = False
                Exit For
            End If
        Next
        If bEntry = False Then
            dizMsgbox("Data tidak valid", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim retval As Boolean = False
        Dim sqls As New SQLs(dbstring)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        sqls.DMLQuery("select top 1 convert(bigint,value) as value from sys_appsetting where variable='AllowAutoReviewSPF'", "autoreview")
        Dim isautoreview As String = sqls.getDataSet("autoreview", 0, "value")

        If statData = statusData.Baru Then
            idtrans = ""
            notrans = ""
            Dim pair As KeyValuePair(Of String, String) = generateno2(idunit2(lueUnit.ItemIndex), iddept2(lueUnit.ItemIndex), "Permintaan Farmasi", False)
            idtrans = pair.Key
            notrans = pair.Value
            teKode.Text = notrans
            idData = GenerateGUID()
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If isautoreview = "0" Then
            If statData = statusData.Baru Then
                field.AddRange(New String() {"idtransaksi", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "iddeptasal", "isdeleted", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany"})
            Else
                field.AddRange(New String() {"idtransaksi", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "iddeptasal", "isdeleted", "remarks", "updatedby", "updateddate", "updatedfromip", "updatedfromhostname", "idcompany"})
            End If
            value.AddRange(New Object() {idData, idtrans, teKode.Text, 1, lueUnit.EditValue, "Unit", iddept2(lueUnit.ItemIndex), 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp})
        Else
            field.AddRange(New String() {"idtransaksi", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "iddeptasal", "isdeleted", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "reviewedby", "revieweddate", "reviewedfromip", "reviewedfromhostname", "idcompany"})
            value.AddRange(New Object() {idData, idtrans, teKode.Text, 6, lueUnit.EditValue, "Unit", iddept2(lueUnit.ItemIndex), 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp})
        End If
        retval = dtsql.datasetSave("transaksi", idData, field, value, False)
        'sqls.DMLQuery("select idtransaksi from transaksi where guid='" & hashcode & "'", "getid")
        'idData = sqls.getDataSet("getid", 0, "idtransaksi")

        Dim fielddt As New List(Of String)
        Dim valuedt As New List(Of Object)
        fielddt.AddRange(New String() {"idtransaksidt", "idtransaksi", "iditem", "idsatuan", "kodeitem", "item", "itemtype", "type", "qtylalu", "qtyask", "qtydispose", "qtycharges", "satuan", "isdeleted", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany"})
        For i As Integer = 0 To gvData.RowCount - 1
            Dim iddt As String = GenerateGUID()

            dtsql = New dtsetSQLS(dbstring)
            valuedt = New List(Of Object)
            Dim dr As DataRow = gvData.GetDataRow(i)
            valuedt.AddRange(New Object() {iddt, idData, dr("iditem"), dr("idsatuan"), dr("kode"), dr("item"), dr("itemtype"), dr("type"), dr("qtylalu"), dr("qtyask"), dr("qty"), dr("qty"), dr("satuan"), 0, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp})
            retval = dtsql.datasetSave("transaksidt", iddt, fielddt, valuedt, False)
        Next

        If iscetak = True Then
            Dim field2 As New List(Of String)
            Dim value2 As New List(Of Object)
            field2.AddRange(New String() {"@id"})
            value2.AddRange(New Object() {lueUnit.EditValue})

            Dim mysUnit As New SQLs(dbstring)
            mysUnit.CallSP("spGetParentUnitGrup", "parentunit", field2, value2)
            value2.Clear()

            If mysUnit.getDataSet("parentunit") > 0 Then
                Dim idparent As String = mysUnit.getDataSet("parentunit", 0, "idunit")
                value2.AddRange(New Object() {idparent})
            Else
                value2.AddRange(New Object() {lueUnit.EditValue})
            End If
            mysUnit.CallSP("spUnit", "unit", field2, value2)

            Dim mys As New SQLs(dbstring)
            Dim fieldctk As New List(Of String)
            Dim valuectk As New List(Of Object)
            fieldctk.AddRange(New String() {"id"})
            valuectk.AddRange(New Object() {idData})
            mys.CallSP("spSPF", "spSPF")
            mys.CallSP("spSPFLMA", "spSPFLMA")

            Dim rpt As New xrSPFLMA
            rpt.RequestParameters = False
            rpt.DataAdapter = mys.getDataAdapter
            rpt.DataSource = mys.dataSet
            rpt.DataMember = "spSPF"
            rpt.DisplayName = "SPFLMA"
            rpt.Parameters("pID").Value = idData
            rpt.Parameters("pNo").Value = idData
            rpt.Parameters("pUnit").Value = mysUnit.getDataSet("unit", 0, "unit")
            rpt.Parameters("pNotes").Value = mysUnit.getDataSet("unit", 0, "notes")
            rpt.Parameters("pFooter").Value = "dicetak oleh " & username & " pada " & Format(nowTime, "dd ") & NamaBulan(nowTime.Month) & Format(nowTime, " yyyy HH: mm")
            rpt.ShowPrintMarginsWarning = False

            Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
            pt.Report.CreateDocument(False)
            AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load

            Dim sharename As String = getPrinter("SPFLMA")
            If sharename <> "" Then
                Try
                    pt.Print(sharename)
                Catch ex As Exception
                    dizMsgbox("Printer tidak ditemukan/tidak ada akses", dizMsgboxStyle.Peringatan, Me)
                End Try
            Else
                dizMsgbox("Printer belum disetting untuk cetak dokumen ini", dizMsgboxStyle.Peringatan, Me)
            End If
        End If

        If retval = True Then
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object,
       ByVal args As Printing.PrintPageEventArgs)
    End Sub

    Private Sub PreviewForm_Load(sender As Object, ByVal e As EventArgs)
        Dim frm As DevExpress.XtraPrinting.Preview.PrintPreviewFormEx = CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)
        frm.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Scale, New Object() {1.0F})
    End Sub

End Class